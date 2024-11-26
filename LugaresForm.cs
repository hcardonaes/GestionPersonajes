using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HistoriaMedieval
{
    public partial class LugaresForm : Form
    {
        private SQLiteConnection connection;
        private string connectionString = "Data Source=Historia_Medieval.db;Version=3;";
        private int? lugarId;

        // Evento para enviar los datos seleccionados
        public event Action<int, string> LugarSeleccionado;

        public LugaresForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadLugares();
            dataGridViewLugares.SelectionChanged += dataGridViewLugares_SelectionChanged;

        }

        private void InitializeDatabaseConnection()
        {
            connection = new SQLiteConnection(connectionString);
        }

        private bool isUpdating = false; // Bandera para controlar eventos

        private void LoadLugares()
        {
            try
            {
                isUpdating = true; // Comienza el proceso de actualización

                string query = @"
            SELECT id, nombre, latitud, longitud, descripcion 
            FROM lugares;
        ";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewLugares.DataSource = null; // Limpiar el origen previo
                        dataGridViewLugares.DataSource = dataTable; // Asignar nuevo origen
                        dataGridViewLugares.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando lugares: {ex.Message}");
            }
            finally
            {
                isUpdating = false; // Finaliza el proceso de actualización
            }
        }

        private void ClearFields()
        {
            textBoxNombre.Clear();
            textBoxLatitud.Clear();
            textBoxLongitud.Clear();
            textBoxDescripcion.Clear();
            lugarId = null;
        }

        private object ValidateTextBox(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text) ? DBNull.Value : textBox.Text;
        }

        private void ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                throw new Exception("El nombre del lugar no puede estar vacío.");
        }

        private void dataGridViewLugares_SelectionChanged(object sender, EventArgs e)
        {
            //if (isUpdating) return; // Salir si el DataGridView está en proceso de actualización

            try
            {
                if (dataGridViewLugares.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewLugares.SelectedRows[0];

                    lugarId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    textBoxNombre.Text = selectedRow.Cells["nombre"].Value?.ToString();
                    textBoxLatitud.Text = selectedRow.Cells["latitud"].Value?.ToString();
                    textBoxLongitud.Text = selectedRow.Cells["longitud"].Value?.ToString();
                    textBoxDescripcion.Text = selectedRow.Cells["descripcion"].Value?.ToString();
                }
                else
                {
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar un lugar: {ex.Message}");
            }
        }

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
                ValidateFields();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    if (lugarId.HasValue && lugarId > 0)
                    {
                        query = @"
                    UPDATE lugares 
                    SET nombre = @nombre, 
                        latitud = @latitud, 
                        longitud = @longitud, 
                        descripcion = @descripcion
                    WHERE id = @id;";
                    }
                    else
                    {
                        query = @"
                    INSERT INTO lugares (nombre, latitud, longitud, descripcion) 
                    VALUES (@nombre, @latitud, @longitud, @descripcion);";
                    }

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        if (lugarId.HasValue && lugarId > 0)
                        {
                            command.Parameters.AddWithValue("@id", lugarId);
                        }
                        command.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                        command.Parameters.AddWithValue("@latitud", ValidateTextBox(textBoxLatitud));
                        command.Parameters.AddWithValue("@longitud", ValidateTextBox(textBoxLongitud));
                        command.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(lugarId.HasValue && lugarId > 0
                    ? "Lugar actualizado con éxito."
                    : "Lugar guardado con éxito.");

                LoadLugares(); // Recargar datos sin disparar eventos innecesarios
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error guardando lugar: {ex.Message}");
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!lugarId.HasValue)
            {
                MessageBox.Show("Por favor, selecciona un lugar para eliminar.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este lugar?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo
            );

            if (confirmResult != DialogResult.Yes)
                return;

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM lugares WHERE id = @id;";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", lugarId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Lugar eliminado con éxito.");
                LoadLugares();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error eliminando lugar: {ex.Message}");
            }

        }

        private void dataGridViewLugares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtener los datos de la fila seleccionada
                DataGridViewRow row = dataGridViewLugares.Rows[e.RowIndex];
                int id = Convert.ToInt32(row.Cells["id"].Value);
                string nombre = row.Cells["nombre"].Value.ToString();

                // Disparar el evento con los datos seleccionados
                LugarSeleccionado?.Invoke(id, nombre);

                // Cerrar el formulario después de seleccionar
                this.Close();
            }
        }
    }
}

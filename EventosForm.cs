using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HistoriaMedieval
{
    public partial class EventosForm : Form
    {
        private SQLiteConnection connection;
        private string connectionString = "Data Source=Historia_Medieval.db;Version=3;";
        private int? eventoId;
        
        public EventosForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadEventos();
           dataGridViewEventos.SelectionChanged += dataGridViewEventos_SelectionChanged;

        }

        private void InitializeDatabaseConnection()
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void LoadEventos()
        {
            try
            {
                // Actualiza la consulta con los nombres correctos de las columnas
                string query = @"
        SELECT 
            e.id AS evento_id, 
            e.nombre AS evento_nombre,  
            COALESCE(l.id || ' - ' || l.nombre, 'Sin lugar asignado') AS lugar, 
            e.fecha_inicio AS fecha_inicio, 
            e.fecha_fin AS fecha_fin,
            e.descripcion AS descripcion
        FROM eventos e
        LEFT JOIN lugares l ON e.lugar_id = l.id;";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        if (dataTable.Rows.Count > 0)
                        {
                            dataGridViewEventos.DataSource = dataTable;
                            dataGridViewEventos.Refresh();
                        }
                        else
                        {
                            MessageBox.Show("No se encontraron eventos para cargar.");
                            dataGridViewEventos.DataSource = null;
                        }
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error en la base de datos: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando eventos: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            textBoxNombre.Clear();
            textBoxFechaInicio.Clear();
            textBoxFechaFin.Clear();
            textBoxLugar_id.Clear();
            textBoxDescripcion.Clear();
            eventoId = null;
        }


        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateFields();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    if (eventoId.HasValue && eventoId > 0)
                    {
                        query = @"
                            UPDATE eventos 
                            SET nombre = @nombre, 
                                fecha_inicio = @fechaInicio, 
                                fecha_fin = @fechaFin, 
                                lugar_id = @lugar_id, 
                                descripcion = @descripcion 
                            WHERE id = @id;";
                    }
                    else
                    {
                        query = @"
                            INSERT INTO eventos (nombre, fecha_inicio, fecha_fin, lugar_id, descripcion) 
                            VALUES (@nombre, @fechaInicio, @fechaFin, @lugar_id, @descripcion);";
                    }

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        if (eventoId.HasValue && eventoId > 0)
                        {
                            command.Parameters.AddWithValue("@id", eventoId);
                        }
                        command.Parameters.AddWithValue("@nombre", textBoxNombre.Text);
                        command.Parameters.AddWithValue("@fechaInicio", ValidateTextBox(textBoxFechaInicio));
                        command.Parameters.AddWithValue("@fechaFin", ValidateTextBox(textBoxFechaFin));
                        command.Parameters.AddWithValue("@lugar_id", textBoxLugar_id.Text);
                        command.Parameters.AddWithValue("@descripcion", textBoxDescripcion.Text);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(eventoId.HasValue && eventoId > 0
                    ? "Evento actualizado con éxito."
                    : "Evento guardado con éxito.");

                LoadEventos();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error guardando evento: {ex.Message}");
            }
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            if (!eventoId.HasValue)
            {
                MessageBox.Show("Por favor, selecciona un evento para eliminar.");
                return;
            }

            var confirmResult = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este evento?",
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
                    string query = "DELETE FROM eventos WHERE id = @id;";
                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@id", eventoId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Evento eliminado con éxito.");
                LoadEventos();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error eliminando evento: {ex.Message}");
            }
        }

        private object ValidateTextBox(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text) ? DBNull.Value : textBox.Text;
        }

        private void ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
                throw new Exception("El nombre del evento no puede estar vacío.");
            if (string.IsNullOrWhiteSpace(textBoxFechaInicio.Text))
                throw new Exception("La descripción del evento no puede estar vacía.");
        }

        private void dataGridViewEventos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Verifica que haya al menos una fila seleccionada
                if (dataGridViewEventos.SelectedRows.Count > 0)
                {
                    // Obtén la fila seleccionada
                    DataGridViewRow selectedRow = dataGridViewEventos.SelectedRows[0];

                    // Asigna los valores de las celdas a los TextBox correspondientes

                    eventoId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                    textBoxNombre.Text = selectedRow.Cells["nombre"].Value?.ToString();                    textBoxDescripcion.Text = selectedRow.Cells["descripcion"].Value?.ToString();
                    textBoxFechaInicio.Text = selectedRow.Cells["fecha_inicio"].Value?.ToString();
                    textBoxFechaFin.Text = selectedRow.Cells["fecha_fin"].Value?.ToString();
                    textBoxLugar_id.Text = selectedRow.Cells["lugar_id"].Value?.ToString();
                }
                else
                {
                    // Si no hay selección, limpiar los campos
                    ClearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al seleccionar una fila: {ex.Message}");
            }
        }

        private void textBoxLugar_id_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario LugaresForm
            LugaresForm lugaresForm = new LugaresForm();

            // Configurar un manejador para capturar el lugar seleccionado
            lugaresForm.LugarSeleccionado += (id, nombre) =>
            {
                // Actualizar el textBox con el lugar seleccionado
                textBoxLugar_id.Text = $"{id} - {nombre}";
            };

            // Mostrar el formulario en modo de diálogo
            lugaresForm.ShowDialog();
        }

    }
}


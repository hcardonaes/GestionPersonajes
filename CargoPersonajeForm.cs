using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HistoriaMedieval
{
    public partial class CargoPersonajeForm : Form
    {
        private SQLiteConnection connection;
        private string connectionString = "Data Source=Historia_Medieval.db;Version=3;";
        private int? cargoId;

        public CargoPersonajeForm(int? personajeId = null)
        {
            InitializeComponent();
            this.cargoId = personajeId;
            InitializeDatabaseConnection();
            LoadPersonajes();
            LoadCargos();
            LoadAsignaciones();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void LoadPersonajes()
        {
            try
            {
                string query = "SELECT id, nombre || ' ' || apellido AS nombre_completo FROM personajes;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboBoxPersonaje.DataSource = dataTable;
                        comboBoxPersonaje.DisplayMember = "nombre_completo";
                        comboBoxPersonaje.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando personajes: {ex.Message}");
            }
        }

        private void LoadCargos()
        {
            try
            {
                string query = "SELECT id, nombre FROM cargos;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboBoxCargo.DataSource = dataTable;
                        comboBoxCargo.DisplayMember = "nombre";
                        comboBoxCargo.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando cargos: {ex.Message}");
            }
        }

        private void LoadAsignaciones()
        {
            try
            {
                string query = @"
                    SELECT cp.id, 
                           p.nombre || ' ' || p.apellido AS personaje, 
                           c.nombre AS cargo, 
                           cp.fecha_inicio, 
                           cp.fecha_fin
                    FROM cargo_personaje cp
                    JOIN personajes p ON cp.personaje_id = p.id
                    JOIN cargos c ON cp.cargo_id = c.id;
                ";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        dataGridViewCargos.DataSource = dataTable;
                        dataGridViewCargos.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando asignaciones: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            comboBoxPersonaje.SelectedIndex = -1;
            comboBoxCargo.SelectedIndex = -1;
            textBoxFechaInicio.Clear();
            textBoxFechaFin.Clear();
            cargoId = null;
        }

        private object ValidateComboBox(ComboBox comboBox)
        {
            if (comboBox.SelectedValue == null)
            {
                throw new Exception($"Por favor, selecciona un valor en {comboBox.Name}");
            }
            return comboBox.SelectedValue;
        }

        private object ValidateTextBox(TextBox textBox)
        {
            return string.IsNullOrWhiteSpace(textBox.Text) ? DBNull.Value : textBox.Text;
        }

        private void dataGridViewCargos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCargos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewCargos.SelectedRows[0];
                cargoId = Convert.ToInt32(row.Cells["id"].Value);
                comboBoxPersonaje.SelectedValue = GetPersonajeId(row.Cells["personaje"].Value.ToString());
                comboBoxCargo.SelectedValue = GetCargoId(row.Cells["cargo"].Value.ToString());
                textBoxFechaInicio.Text = row.Cells["fecha_inicio"].Value?.ToString();
                textBoxFechaFin.Text = row.Cells["fecha_fin"].Value?.ToString();
            }
            else
            {
                ClearFields();
            }
        }

        private int GetPersonajeId(string nombreCompleto)
        {
            connection.Open();
            string query = "SELECT id FROM personajes WHERE nombre || ' ' || apellido = @nombreCompleto;";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombreCompleto", nombreCompleto);
                object result = command.ExecuteScalar();
                connection.Close();
                return Convert.ToInt32(result);
            }
        }

        private int GetCargoId(string nombre)
        {
            connection.Open();
            string query = "SELECT id FROM cargos WHERE nombre = @nombre;";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombre", nombre);
                object result = command.ExecuteScalar();
                connection.Close();
                return Convert.ToInt32(result);
            }
        }

        private void ValidateFields()
        {
            if (comboBoxPersonaje.SelectedValue == null)
                throw new Exception("Por favor, selecciona un personaje.");
            if (comboBoxCargo.SelectedValue == null)
                throw new Exception("Por favor, selecciona un cargo.");
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ValidateFields();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    if (cargoId.HasValue && cargoId > 0)
                    {
                        query = @"
                    UPDATE cargo_personaje 
                    SET personaje_id = @personaje, 
                        cargo_id = @cargo, 
                        fecha_inicio = @fechaInicio, 
                        fecha_fin = @fechaFin 
                    WHERE id = @id;";
                    }
                    else
                    {
                        query = @"
                    INSERT INTO cargo_personaje 
                    (personaje_id, cargo_id, fecha_inicio, fecha_fin) 
                    VALUES (@personaje, @cargo, @fechaInicio, @fechaFin);";
                    }

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        if (cargoId.HasValue && cargoId > 0)
                        {
                            command.Parameters.AddWithValue("@id", cargoId);
                        }
                        command.Parameters.AddWithValue("@personaje", ValidateComboBox(comboBoxPersonaje));
                        command.Parameters.AddWithValue("@cargo", ValidateComboBox(comboBoxCargo));
                        command.Parameters.AddWithValue("@fechaInicio", ValidateTextBox(textBoxFechaInicio));
                        command.Parameters.AddWithValue("@fechaFin", ValidateTextBox(textBoxFechaFin));

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(cargoId.HasValue && cargoId > 0
                    ? "Asignación actualizada con éxito."
                    : "Asignación guardada con éxito.");

                // Aquí se recarga el DataGridView
                LoadAsignaciones();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error guardando asignación: {ex.Message}");
            }
        }

        private void dataGridViewCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewCargos.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewCargos.SelectedRows[0];
                if (row.Cells["id"].Value != null)
                {
                    cargoId = Convert.ToInt32(row.Cells["id"].Value);
                    comboBoxPersonaje.SelectedValue = GetPersonajeId(row.Cells["personaje"].Value.ToString());
                    comboBoxCargo.SelectedValue = GetPersonajeId(row.Cells["cargo"].Value.ToString());
                    textBoxFechaInicio.Text = row.Cells["fecha_inicio"].Value?.ToString();
                    textBoxFechaFin.Text = row.Cells["fecha_fin"].Value?.ToString();
                }
            }
            else
            {
                ClearFields(); // Limpiar campos si no hay fila seleccionada
            }
        }

        private void CargoPersonajeForm_Load(object sender, EventArgs e)
        {

        }
    }
}


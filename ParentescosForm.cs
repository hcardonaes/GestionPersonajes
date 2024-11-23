using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HistoriaMedieval
{
    public partial class ParentescosForm : Form
    {
        private SQLiteConnection connection;
        private string connectionString = "Data Source=Historia_Medieval.db;Version=3;";
        private int? personajeId; // Campo opcional para el parámetro

        // Constructor predeterminado
        public ParentescosForm(int? personajeId = null)
        {
            InitializeComponent(); // Asegúrate de inicializar los componentes del formulario
            this.personajeId = personajeId; // Guarda el personajeId
            InitializeDatabaseConnection();
            LoadPersonajes();
            LoadTiposParentesco();
            LoadRelaciones();
            comboBoxtipoParentesco.SelectedIndexChanged += comboBoxtipoParentesco_SelectedIndexChanged;

        }

        private void ParentescosForm_Load(object sender, EventArgs e)
        {
            if (personajeId.HasValue)
            {
                // Preseleccionar el personaje en comboBoxpersonaje1
                comboBoxpersonaje1.SelectedValue = personajeId.Value;
            }
        }

        private void InitializeDatabaseConnection()
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void LoadPersonajes()
        {
            try
            {
                connection.Open();
                string query = "SELECT id, nombre || ' ' || apellido AS nombre_completo FROM personajes;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Poblar ComboBoxes con los personajes
                comboBoxpersonaje1.DataSource = dataTable.Copy();
                comboBoxpersonaje1.DisplayMember = "nombre_completo";
                comboBoxpersonaje1.ValueMember = "id";

                comboBoxpersonaje2.DataSource = dataTable.Copy();
                comboBoxpersonaje2.DisplayMember = "nombre_completo";
                comboBoxpersonaje2.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando personajes: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadTiposParentesco()
        {
            try
            {
                connection.Open();
                string query = "SELECT id, nombre FROM tipos_relaciones_familiares;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxtipoParentesco.DataSource = dataTable;
                comboBoxtipoParentesco.DisplayMember = "nombre";
                comboBoxtipoParentesco.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando tipos de parentesco: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();

                // Si hay una relación seleccionada en el DataGridView, actualiza
                if (dataGridViewRelaciones.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = dataGridViewRelaciones.SelectedRows[0];
                    int idRelacion = Convert.ToInt32(row.Cells["id"].Value);

                    string query = "UPDATE parentescos SET personaje_id1 = @personaje1, personaje_id2 = @personaje2, tipo_relacion_id = @tipo, " +
                                   "fecha_inicio = @fechaInicio, fecha_fin = @fechaFin WHERE id = @id;";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@id", idRelacion);
                        command.Parameters.AddWithValue("@personaje1", comboBoxpersonaje1.SelectedValue);
                        command.Parameters.AddWithValue("@personaje2", comboBoxpersonaje2.SelectedValue);
                        command.Parameters.AddWithValue("@tipo", comboBoxtipoParentesco.SelectedValue);
                        command.Parameters.AddWithValue("@fechaInicio", string.IsNullOrWhiteSpace(textBoxFechaInicio.Text) ? DBNull.Value : (object)textBoxFechaInicio.Text);
                        command.Parameters.AddWithValue("@fechaFin", string.IsNullOrWhiteSpace(textBoxFechaFin.Text) ? DBNull.Value : (object)textBoxFechaFin.Text);
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Relación actualizada con éxito.");
                }
                else
                {
                    // Código de inserción como antes
                }

                LoadRelaciones(); // Refrescar el DataGridView
                ClearFields();    // Limpiar los campos
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error guardando relación: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private bool EsParentescoEsposos(int tipoParentescoId)
        {
            try
            {
                connection.Open();
                string query = "SELECT nombre FROM tipos_relaciones_familiares WHERE id = @id;";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", tipoParentescoId);
                    string nombre = command.ExecuteScalar()?.ToString();
                    return nombre?.ToLower() == "esposos";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verificando parentesco: {ex.Message}");
                return false;
            }
            finally
            {
                connection.Close();
            }
        }

        private void ClearFields()
        {
            comboBoxpersonaje1.SelectedIndex = -1;
            comboBoxpersonaje2.SelectedIndex = -1;
            comboBoxtipoParentesco.SelectedIndex = -1;
            textBoxFechaInicio.Clear();
            textBoxFechaFin.Clear();
        }

        private void LoadRelaciones()
        {
            try
            {
                connection.Open();
                string query = @"
            SELECT r.id, 
                   p1.nombre || ' ' || p1.apellido AS personaje1, 
                   p2.nombre || ' ' || p2.apellido AS personaje2,
                   t.nombre AS tipo_relacion, 
                   r.fecha_inicio, 
                   r.fecha_fin
            FROM parentescos r
            JOIN personajes p1 ON r.personaje_id1 = p1.id
            JOIN personajes p2 ON r.personaje_id2 = p2.id
            JOIN tipos_relaciones_familiares t ON r.tipo_relacion_id = t.id;
        ";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewRelaciones.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando relaciones: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridViewRelaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRelaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewRelaciones.SelectedRows[0];
                int idRelacion = Convert.ToInt32(row.Cells["id"].Value);

                // Cargar los datos en los campos
                comboBoxpersonaje1.SelectedValue = GetPersonajeId(row.Cells["personaje1"].Value.ToString());
                comboBoxpersonaje2.SelectedValue = GetPersonajeId(row.Cells["personaje2"].Value.ToString());
                comboBoxtipoParentesco.SelectedValue = GetTipoRelacionId(row.Cells["tipo_relacion"].Value.ToString());
                textBoxFechaInicio.Text = row.Cells["fecha_inicio"].Value?.ToString();
                textBoxFechaFin.Text = row.Cells["fecha_fin"].Value?.ToString();
            }
        }

        // Métodos para obtener los IDs basados en los nombres
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

        private int GetTipoRelacionId(string tipoRelacion)
        {
            connection.Open();
            string query = "SELECT id FROM tipos_relaciones_familiares WHERE nombre = @tipoRelacion;";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@tipoRelacion", tipoRelacion);
                object result = command.ExecuteScalar();
                connection.Close();
                return Convert.ToInt32(result);
            }
        }

        private void comboBoxtipoParentesco_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Mostrar u ocultar campos de fecha dependiendo del tipo de parentesco
            int tipoParentescoId = Convert.ToInt32(comboBoxtipoParentesco.SelectedValue);
            bool requiereFechas = EsParentescoEsposos(tipoParentescoId);

            labelFechaInicio.Visible = requiereFechas;
            textBoxFechaInicio.Visible = requiereFechas;
            labelFechaFin.Visible = requiereFechas;
            textBoxFechaFin.Visible = requiereFechas;

        }
    }
}

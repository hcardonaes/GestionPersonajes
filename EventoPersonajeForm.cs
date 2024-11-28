using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HistoriaMedieval
{
    public partial class EventoPersonajeForm : Form
    {
        private SQLiteConnection connection;
        private string connectionString = "Data Source=Historia_Medieval.db;Version=3;";
        private int? eventoPersonajeId;

        public EventoPersonajeForm(int? eventoPersonajeId = null)
        {
            InitializeComponent();
            this.eventoPersonajeId = eventoPersonajeId;
            InitializeDatabaseConnection();
            LoadEventos();
            LoadPersonajes();
            LoadEventoPersonajes();
        }

        private void InitializeDatabaseConnection()
        {
            connection = new SQLiteConnection(connectionString);
        }

        private void LoadEventos()
        {
            try
            {
                connection.Open();
                string query = "SELECT id, nombre FROM eventos;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                comboBoxEvento.DataSource = dataTable;
                comboBoxEvento.DisplayMember = "nombre";
                comboBoxEvento.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando eventos: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
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

                comboBoxPersonaje.DataSource = dataTable;
                comboBoxPersonaje.DisplayMember = "nombre_completo";
                comboBoxPersonaje.ValueMember = "id";
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

        private void LoadEventoPersonajes()
        {
            try
            {
                connection.Open();
                string query = @"
                SELECT ep.id, 
                       e.nombre AS evento, 
                       p.nombre || ' ' || p.apellido AS personaje 
                FROM evento_personaje ep
                JOIN eventos e ON ep.evento_id = e.id
                JOIN personajes p ON ep.personaje_id = p.id;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dataGridViewEventoPersonajes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando relaciones evento-personaje: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void ClearFields()
        {
            comboBoxEvento.SelectedIndex = -1;
            comboBoxPersonaje.SelectedIndex = -1;
        }

        private void dataGridViewEventoPersonajes_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEventoPersonajes.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewEventoPersonajes.SelectedRows[0];
                eventoPersonajeId = Convert.ToInt32(row.Cells["id"].Value);
                comboBoxEvento.SelectedValue = GetEventoId(row.Cells["evento"].Value.ToString());
                comboBoxPersonaje.SelectedValue = GetPersonajeId(row.Cells["personaje"].Value.ToString());
            }
        }

        private int GetEventoId(string nombreEvento)
        {
            connection.Open();
            string query = "SELECT id FROM eventos WHERE nombre = @nombreEvento;";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nombreEvento", nombreEvento);
                object result = command.ExecuteScalar();
                connection.Close();
                return Convert.ToInt32(result);
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

        private void buttonSave_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    connection.Open();
                    string query;

                    if (eventoPersonajeId.HasValue && eventoPersonajeId > 0)
                    {
                        query = @"
                    UPDATE evento_personaje 
                    SET evento_id = @evento, 
                        personaje_id = @personaje 
                    WHERE id = @id;";
                    }
                    else
                    {
                        query = @"
                    INSERT INTO evento_personaje 
                    (evento_id, personaje_id) 
                    VALUES (@evento, @personaje);";
                    }

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        if (eventoPersonajeId.HasValue && eventoPersonajeId > 0)
                        {
                            command.Parameters.AddWithValue("@id", eventoPersonajeId);
                        }
                        command.Parameters.AddWithValue("@evento", comboBoxEvento.SelectedValue);
                        command.Parameters.AddWithValue("@personaje", comboBoxPersonaje.SelectedValue);

                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show(eventoPersonajeId.HasValue && eventoPersonajeId > 0
                        ? "Relación evento-personaje actualizada con éxito."
                        : "Relación evento-personaje guardada con éxito.");

                    LoadEventoPersonajes();
                    ClearFields();
                    eventoPersonajeId = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error guardando relación evento-personaje: {ex.Message}");
                }
                finally
                {
                    connection.Close();
                }

            }
        }
    }
}

// Archivo: MainForm.cs
using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace HistoriaMedieval
{
    public partial class MainForm : Form
    {
        private SQLiteConnection connection;
        //private string connectionString = "Data Source=Historia_Medieval.db;Version=3;";
        //private string connectionString = $"Data Source={Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Historia_Medieval.db")};Version=3;";
        private string connectionString = "Data Source=Historia_Medieval.db;Version=3;";

        public MainForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadPersonajes();
            buttonOpenProtagonistas.Click += buttonOpenProtagonistas_Click;
        }

        private void InitializeDatabaseConnection()
        {
            string fullPath = Path.GetFullPath(connectionString);
            if (HasInvalidVolumeSeparator(fullPath) || HasWildCardCharacters(fullPath))
            {
                MessageBox.Show("Invalid database path format.");
                return;
            }

            connection = new SQLiteConnection(connectionString);
           // MessageBox.Show($"Ruta de la base de datos: {fullPath}");
        }

        private bool HasInvalidVolumeSeparator(string path)
        {
            return path.IndexOfAny(Path.GetInvalidPathChars()) >= 0;
        }

        private bool HasWildCardCharacters(string path)
        {
            return path.Contains("*") || path.Contains("?");
        }

        private BindingSource bindingSource = new BindingSource();

        private void LoadPersonajes()
        {
            try
            {
                personajesDataGridView.DataSource = null; // Quitar el origen de datos para evitar conflictos

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT id, nombre, apellido, mote, fecha_nacimiento, fecha_muerte, importancia, biografia FROM personajes;";
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        personajesDataGridView.DataSource = dataTable; // Asignar los datos
                    }
                }
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show($"Error de SQLite: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando personajes: {ex.Message}");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query;

                if (string.IsNullOrEmpty(idTextBox.Text)) // Añadir nuevo personaje
                {
                    query = "INSERT INTO personajes (nombre, apellido, mote, fecha_nacimiento, fecha_muerte, importancia, biografia) " +
                            "VALUES (@nombre, @apellido, @mote, @fechaNacimiento, @fechaMuerte, @importancia, @biografia);";
                }
                else // Actualizar personaje existente
                {
                    query = "UPDATE personajes SET nombre = @nombre, apellido = @apellido, mote = @mote, fecha_nacimiento = @fechaNacimiento, " +
                            "fecha_muerte = @fechaMuerte, importancia = @importancia, biografia = @biografia WHERE id = @id;";
                }

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", idTextBox.Text);
                    command.Parameters.AddWithValue("@nombre", nombreTextBox.Text);
                    command.Parameters.AddWithValue("@apellido", apellidoTextBox.Text);
                    command.Parameters.AddWithValue("@mote", moteTextBox.Text);
                    command.Parameters.AddWithValue("@fechaNacimiento", fechaNacimientoTextBox.Text);
                    command.Parameters.AddWithValue("@fechaMuerte", fechaMuerteTextBox.Text);
                    command.Parameters.AddWithValue("@importancia", importanciaTextBox.Text);
                    command.Parameters.AddWithValue("@biografia", biografiaTextBox.Text);

                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Datos guardados con éxito.");

                // Registrar el flujo antes de recargar
                Console.WriteLine("Inicio de recarga de datos...");
                LoadPersonajes(); // Recargar datos
                Console.WriteLine("Datos recargados exitosamente.");

                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error guardando datos: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void personajesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (personajesDataGridView.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = personajesDataGridView.SelectedRows[0];
                    idTextBox.Text = row.Cells["id"].Value.ToString();
                    nombreTextBox.Text = row.Cells["nombre"].Value.ToString();
                    apellidoTextBox.Text = row.Cells["apellido"].Value.ToString();
                    moteTextBox.Text = row.Cells["mote"].Value.ToString();
                    fechaNacimientoTextBox.Text = row.Cells["fecha_nacimiento"].Value.ToString();
                    fechaMuerteTextBox.Text = row.Cells["fecha_muerte"].Value.ToString();
                    importanciaTextBox.Text = row.Cells["importancia"].Value.ToString();
                    biografiaTextBox.Text = row.Cells["biografia"].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en SelectionChanged: {ex.Message}");
            }
        }

        private void ClearFields()
        {
            idTextBox.Clear();
            nombreTextBox.Clear();
            apellidoTextBox.Clear();
            moteTextBox.Clear();
            fechaNacimientoTextBox.Clear();
            fechaMuerteTextBox.Clear();
            importanciaTextBox.Clear();
            biografiaTextBox.Clear();
        }

        private void buttonOpenParentescos_Click(object sender, EventArgs e)
        {
            if (personajesDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = personajesDataGridView.SelectedRows[0];
                int personajeId = Convert.ToInt32(row.Cells["id"].Value);
                ParentescosForm parentescosForm = new ParentescosForm(personajeId);
                parentescosForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un personaje.");
            }
        }

        private void buttonOpenRelaciones_Click(object sender, EventArgs e)
        {
            if (personajesDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = personajesDataGridView.SelectedRows[0];
                int personajeId = Convert.ToInt32(row.Cells["id"].Value);
                RelacionesSociopoliticasForm relacionesSociopoliticasForm = new RelacionesSociopoliticasForm(personajeId);
                relacionesSociopoliticasForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un personaje.");
            }

        }
        private void buttonOpenCargos_Click(object sender, EventArgs e)
        {
            if (personajesDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = personajesDataGridView.SelectedRows[0];
                int personajeId = Convert.ToInt32(row.Cells["id"].Value);
                CargoPersonajeForm relacionesSociopoliticasForm = new CargoPersonajeForm(personajeId);
                relacionesSociopoliticasForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un personaje.");
            }

        }
        private void buttonEventos_Click(object sender, EventArgs e)
        {
            try
            {
                EventosForm eventosForm = new EventosForm(); // Crear una instancia de EventosForm
                eventosForm.Show(); // Mostrar el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario de eventos: {ex.Message}");
            }
        }

        private void buttonLugares_Click(object sender, EventArgs e)
        {
            try
            {
                LugaresForm LugaresForm = new LugaresForm(); // Crear una instancia de EventosForm
                LugaresForm.Show(); // Mostrar el formulario
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir el formulario de eventos: {ex.Message}");
            }

        }

        private void personajesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonOpenProtagonistas_Click(object sender, EventArgs e)
        {
            if (personajesDataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = personajesDataGridView.SelectedRows[0];
                int personajeId = Convert.ToInt32(row.Cells["id"].Value);
                EventoPersonajeForm eventoPersonajeForm = new EventoPersonajeForm(personajeId);
                eventoPersonajeForm.Show();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un personaje.");
            }
        }

    }
}


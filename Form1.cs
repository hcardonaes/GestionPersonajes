// Archivo: MainForm.cs
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HistoriaMedieval
{
    public partial class MainForm : Form
    {
        private SQLiteConnection connection;
        private string connectionString = "Data Source=Historia_Medieval.db;Version=3;";

        public MainForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadPersonajes();
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
                string query = "SELECT id, nombre, apellido, mote, fecha_nacimiento, fecha_muerte, importancia, biografia FROM personajes;";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                personajesDataGridView.DataSource = dataTable;
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
                LoadPersonajes(); // Recargar los datos
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
    }
}

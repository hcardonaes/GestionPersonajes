using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace HistoriaMedieval
{
    public partial class RelacionesSociopoliticasForm : Form
    {
        private SQLiteConnection connection;
        private string connectionString = "Data Source=Historia_Medieval.db;Version=3;";
        private int? relacionId;

    public RelacionesSociopoliticasForm(int? personajeId = null)
    {
        InitializeComponent(); // Asegúrate de inicializar los componentes del formulario
        this.relacionId = personajeId; // Guarda el personajeId
        InitializeDatabaseConnection();
        LoadPersonajes();
        LoadTiposRelaciones();
        LoadRelaciones();
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

                        comboBoxPersonaje1.DataSource = dataTable.Copy();
                        dataGridViewRelaciones.Refresh();

                        comboBoxPersonaje1.DisplayMember = "nombre_completo";
                        comboBoxPersonaje1.ValueMember = "id";

                        comboBoxPersonaje2.DataSource = dataTable.Copy();
                        dataGridViewRelaciones.Refresh();

                        comboBoxPersonaje2.DisplayMember = "nombre_completo";
                        comboBoxPersonaje2.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando personajes: {ex.Message}");
            }
        }

        private void LoadTiposRelaciones()
        {
            try
            {
                string query = "SELECT id, nombre FROM tipos_relaciones_sociopoliticas;";
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        comboBoxTipoRelacion.DataSource = dataTable;
                        comboBoxTipoRelacion.DisplayMember = "nombre";
                        comboBoxTipoRelacion.ValueMember = "id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando tipos de relaciones: {ex.Message}");
            }
        }

        private void LoadRelaciones()
        {
            try
            {
                string query = @"
            SELECT r.id, 
                   p1.nombre || ' ' || p1.apellido AS personaje1, 
                   p2.nombre || ' ' || p2.apellido AS personaje2,
                   t.nombre AS tipo_relacion, 
                   r.fecha_inicio, 
                   r.fecha_fin
            FROM relaciones_sociopoliticas r
            JOIN personajes p1 ON r.personaje_id1 = p1.id
            JOIN personajes p2 ON r.personaje_id2 = p2.id
            JOIN tipos_relaciones_sociopoliticas t ON r.tipo_relacion_id = t.id;
        ";

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, conn))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Verifica cuántas filas se cargan
                        Console.WriteLine($"Relaciones cargadas: {dataTable.Rows.Count}");
                        MessageBox.Show($"Relaciones cargadas: {dataTable.Rows.Count}");

                        dataGridViewRelaciones.DataSource = null; // Limpia el DataSource previo
                        dataGridViewRelaciones.DataSource = dataTable; // Asigna el nuevo DataSource
                        dataGridViewRelaciones.Refresh(); // Fuerza el redibujado
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error cargando relaciones: {ex.Message}");
            }
        }


        private void ClearFields()
        {
            comboBoxPersonaje1.SelectedIndex = -1;
            comboBoxPersonaje2.SelectedIndex = -1;
            comboBoxTipoRelacion.SelectedIndex = -1;
            textBoxFechaInicio.Clear();
            textBoxFechaFin.Clear();
            relacionId = null; // Reinicia relacionId para nuevas inserciones
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


        private void dataGridViewRelaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewRelaciones.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewRelaciones.SelectedRows[0];
                if (row.Cells["id"].Value != null)
                {
                    relacionId = Convert.ToInt32(row.Cells["id"].Value);
                    comboBoxPersonaje1.SelectedValue = GetPersonajeId(row.Cells["personaje1"].Value.ToString());
                    comboBoxPersonaje2.SelectedValue = GetPersonajeId(row.Cells["personaje2"].Value.ToString());
                    comboBoxTipoRelacion.SelectedValue = GetTipoRelacionId(row.Cells["tipo_relacion"].Value.ToString());
                    textBoxFechaInicio.Text = row.Cells["fecha_inicio"].Value?.ToString();
                    textBoxFechaFin.Text = row.Cells["fecha_fin"].Value?.ToString();
                }
            }
            else
            {
                ClearFields(); // Limpiar campos si no hay fila seleccionada
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

        private int GetTipoRelacionId(string tipoRelacion)
        {
            connection.Open();
            string query = "SELECT id FROM tipos_relaciones_sociopoliticas WHERE nombre = @tipoRelacion;";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@tipoRelacion", tipoRelacion);
                object result = command.ExecuteScalar();
                connection.Close();
                return Convert.ToInt32(result);
            }
        }

        private void RelacionesSociopoliticasForm_Load(object sender, EventArgs e)
        {
            if (relacionId.HasValue)
            {
                // Preseleccionar el personaje en comboBoxpersonaje1
                comboBoxPersonaje1.SelectedValue = relacionId.Value;
            }

        }

        private void buttonRSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar campos antes de proceder
                ValidateFields();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query;

                    if (relacionId.HasValue && relacionId > 0)
                    {
                        // Actualizar relación existente
                        query = @"
                UPDATE relaciones_sociopoliticas 
                SET personaje_id1 = @personaje1, 
                    personaje_id2 = @personaje2, 
                    tipo_relacion_id = @tipo, 
                    fecha_inicio = @fechaInicio, 
                    fecha_fin = @fechaFin 
                WHERE id = @id;";
                    }
                    else
                    {
                        // Insertar nueva relación
                        query = @"
                INSERT INTO relaciones_sociopoliticas 
                (personaje_id1, personaje_id2, tipo_relacion_id, fecha_inicio, fecha_fin) 
                VALUES (@personaje1, @personaje2, @tipo, @fechaInicio, @fechaFin);";
                    }

                    using (SQLiteCommand command = new SQLiteCommand(query, conn))
                    {
                        if (relacionId.HasValue && relacionId > 0)
                        {
                            command.Parameters.AddWithValue("@id", relacionId);
                        }
                        command.Parameters.AddWithValue("@personaje1", ValidateComboBox(comboBoxPersonaje1));
                        command.Parameters.AddWithValue("@personaje2", ValidateComboBox(comboBoxPersonaje2));
                        command.Parameters.AddWithValue("@tipo", ValidateComboBox(comboBoxTipoRelacion));
                        command.Parameters.AddWithValue("@fechaInicio", ValidateTextBox(textBoxFechaInicio));
                        command.Parameters.AddWithValue("@fechaFin", ValidateTextBox(textBoxFechaFin));

                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                }

                // Mostrar mensaje basado en la operación
                MessageBox.Show(relacionId.HasValue && relacionId > 0
                    ? "Relación actualizada con éxito."
                    : "Relación guardada con éxito.");

                // Refrescar el DataGridView y limpiar los campos
                LoadRelaciones();
                ClearFields();

                // Reiniciar relacionId para evitar confusión en futuras operaciones
                relacionId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error guardando relación: {ex.Message}");
            }
        }

        //private void comboBoxTipoRelacion_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //        DataGridViewRow row = dataGridViewRelaciones.SelectedRows[0];
        //        if (row.Cells["id"].Value != null)
        //        {
        //            relacionId = Convert.ToInt32(row.Cells["id"].Value);
        //            comboBoxPersonaje1.SelectedValue = GetPersonajeId(row.Cells["personaje1"].Value.ToString());
        //            comboBoxPersonaje2.SelectedValue = GetPersonajeId(row.Cells["personaje2"].Value.ToString());
        //            comboBoxTipoRelacion.SelectedValue = GetTipoRelacionId(row.Cells["tipo_relacion"].Value.ToString());
        //            textBoxFechaInicio.Text = row.Cells["fecha_inicio"].Value?.ToString();
        //            textBoxFechaFin.Text = row.Cells["fecha_fin"].Value?.ToString();
        //        }          
        //}
        private void ValidateFields()
        {
            if (comboBoxPersonaje1.SelectedValue == null)
                throw new Exception("Por favor, selecciona el primer personaje.");
            if (comboBoxPersonaje2.SelectedValue == null)
                throw new Exception("Por favor, selecciona el segundo personaje.");
            if (comboBoxTipoRelacion.SelectedValue == null)
                throw new Exception("Por favor, selecciona el tipo de relación.");
        }



    }
}

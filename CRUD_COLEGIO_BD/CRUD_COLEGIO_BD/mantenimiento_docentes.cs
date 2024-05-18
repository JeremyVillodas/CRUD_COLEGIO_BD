using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_COLEGIO_BD
{
    public partial class mantenimiento_docentes : Form
    {
        public mantenimiento_docentes()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string insertarDocente = "INSERT INTO DOCENTE (Id_Docente, Ape_Paterno, Ape_Materno, Nombres, Estado_Civil, Fecha_Nacimiento, Direccion, Telefono, DNI, Sueldo) VALUES (@Id_Docente, @Ape_Paterno, @Ape_Materno, @Nombres, @Estado_Civil, @Fecha_Nacimiento, @Direccion, @Telefono, @DNI, @Sueldo)";
            SqlCommand cmd1 = new SqlCommand(insertarDocente, conexion.conectar());
            cmd1.Parameters.AddWithValue("@Id_Docente", textBox18.Text);
            cmd1.Parameters.AddWithValue("@Ape_Paterno", textBox17.Text);
            cmd1.Parameters.AddWithValue("@Ape_Materno", textBox16.Text);
            cmd1.Parameters.AddWithValue("@Nombres", textBox15.Text);
            cmd1.Parameters.AddWithValue("@Estado_Civil", comboBox3.Text);
            cmd1.Parameters.AddWithValue("@Fecha_Nacimiento", dateTimePicker2.Value.ToString());
            cmd1.Parameters.AddWithValue("@Direccion", textBox14.Text);
            cmd1.Parameters.AddWithValue("@Telefono", textBox13.Text);
            cmd1.Parameters.AddWithValue("@DNI", textBox12.Text);
            cmd1.Parameters.AddWithValue("@Sueldo", decimal.Parse(textBox11.Text));

            cmd1.ExecuteNonQuery();

            dataGridView2.DataSource = llenar_datos();

            textBox18.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();
        }
        public DataTable llenar_datos()
        {
            conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM DOCENTE";
            SqlCommand cmd = new SqlCommand(consulta, conexion.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            conexion.conectar();
            dataGridView2.DataSource = llenar_datos();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string modificar = "UPDATE DOCENTE SET Ape_Paterno=@Ape_Paterno, Ape_Materno=@Ape_Materno, Nombres=@Nombres, Estado_Civil=@Estado_Civil, Fecha_Nacimiento=@Fecha_Nacimiento, Direccion=@Direccion, Telefono=@Telefono, DNI=@DNI, Sueldo=@Sueldo WHERE Id_Docente=@Id_Docente";

            SqlCommand cmd2 = new SqlCommand(modificar, conexion.conectar());

            cmd2.Parameters.AddWithValue("@Id_Docente", textBox18.Text);
            cmd2.Parameters.AddWithValue("@Ape_Paterno", textBox17.Text);
            cmd2.Parameters.AddWithValue("@Ape_Materno", textBox16.Text);
            cmd2.Parameters.AddWithValue("@Nombres", textBox15.Text);
            cmd2.Parameters.AddWithValue("@Estado_Civil", comboBox3.Text);
            cmd2.Parameters.AddWithValue("@Fecha_Nacimiento", dateTimePicker2.Value.ToString());
            cmd2.Parameters.AddWithValue("@Direccion", textBox14.Text);
            cmd2.Parameters.AddWithValue("@Telefono", int.Parse(textBox13.Text));
            cmd2.Parameters.AddWithValue("@DNI", int.Parse(textBox12.Text));
            cmd2.Parameters.AddWithValue("@Sueldo", decimal.Parse(textBox11.Text));

            cmd2.ExecuteNonQuery();

            dataGridView2.DataSource = llenar_datos();

            textBox18.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string eliminar = "DELETE FROM DOCENTE WHERE Id_Docente=@Id_Docente";
            SqlCommand cmd3 = new SqlCommand(eliminar, conexion.conectar());

            cmd3.Parameters.AddWithValue("@Id_Docente", textBox18.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("EL REGISTRO SE ELIMINÓ DMANERA CORRECTA");


            dataGridView2.DataSource = llenar_datos();

            textBox18.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox18.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
            textBox14.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox18.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox17.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                textBox16.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                textBox15.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
                comboBox3.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
                textBox14.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
                textBox13.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
                textBox12.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
                textBox11.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();

            }
            catch
            {

            }
        }
    }
}

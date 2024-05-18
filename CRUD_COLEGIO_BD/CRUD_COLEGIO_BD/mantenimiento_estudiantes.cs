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
    public partial class mantenimiento_estudiantes : Form
    {
        public mantenimiento_estudiantes()
        {
            InitializeComponent();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string insertar = "INSERT INTO ESTUDIANTE (Id_Estudiante, Ape_Paterno, Ape_Materno, Nombres, Fecha_Nacimiento, Direccion, Telefono, DNI, Distrito, CorreoElectronico, Genero)  VALUES (@Id_Estudiante, @Ape_Paterno, @Ape_Materno, @Nombres,@Fecha_Nacimiento,@Direccion,@Telefono,@DNI,@Distrito,@CorreoElectronico,@Genero)";
            SqlCommand cmd1 = new SqlCommand(insertar, conexion.conectar());
            cmd1.Parameters.AddWithValue("@Id_Estudiante", textBox1.Text);
            cmd1.Parameters.AddWithValue("@Ape_Paterno", textBox2.Text);
            cmd1.Parameters.AddWithValue("@Ape_Materno", textBox3.Text);
            cmd1.Parameters.AddWithValue("@Nombres", textBox4.Text);
            cmd1.Parameters.AddWithValue("@Fecha_Nacimiento", dateTimePicker1.Value.ToString());
            cmd1.Parameters.AddWithValue("@Direccion", textBox6.Text);
            cmd1.Parameters.AddWithValue("@Telefono", textBox7.Text);
            cmd1.Parameters.AddWithValue("@DNI", textBox8.Text);
            cmd1.Parameters.AddWithValue("@Distrito", textBox9.Text);
            cmd1.Parameters.AddWithValue("@CorreoElectronico", textBox10.Text);
            cmd1.Parameters.AddWithValue("@Genero", comboBox1.Text);

            cmd1.ExecuteNonQuery();

            dataGridView1.DataSource = llenar_datos();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            conexion.conectar();
            dataGridView1.DataSource = llenar_datos();

        }

        public DataTable llenar_datos()
        {
            conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM ESTUDIANTE";
            SqlCommand cmd = new SqlCommand(consulta, conexion.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox7.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox8.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                textBox9.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                textBox10.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            }
            catch
            {

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string modificar = "UPDATE ESTUDIANTE SET Ape_Paterno=@Ape_Paterno, Ape_Materno=@Ape_Materno, Nombres=@Nombres, Fecha_Nacimiento=@Fecha_Nacimiento, Direccion=@Direccion, Telefono=@Telefono, DNI=@DNI, Distrito=@Distrito, CorreoElectronico=@CorreoElectronico, Genero=@Genero WHERE Id_Estudiante=@Id_Estudiante";

            SqlCommand cmd2 = new SqlCommand(modificar, conexion.conectar());

            cmd2.Parameters.AddWithValue("@Id_Estudiante", textBox1.Text);
            cmd2.Parameters.AddWithValue("@Ape_Paterno", textBox2.Text);
            cmd2.Parameters.AddWithValue("@Ape_Materno", textBox3.Text);
            cmd2.Parameters.AddWithValue("@Nombres", textBox4.Text);
            cmd2.Parameters.AddWithValue("@Fecha_Nacimiento", dateTimePicker1.Value);
            cmd2.Parameters.AddWithValue("@Direccion", textBox6.Text);
            cmd2.Parameters.AddWithValue("@Telefono", textBox7.Text);
            cmd2.Parameters.AddWithValue("@DNI", textBox8.Text);
            cmd2.Parameters.AddWithValue("@Distrito", textBox9.Text);
            cmd2.Parameters.AddWithValue("@CorreoElectronico", textBox10.Text);
            cmd2.Parameters.AddWithValue("@Genero", comboBox1.Text);

            cmd2.ExecuteNonQuery();

            dataGridView1.DataSource = llenar_datos();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string eliminar = "DELETE FROM ESTUDIANTE WHERE Id_Estudiante=@Id_Estudiante";
            SqlCommand cmd3 = new SqlCommand(eliminar, conexion.conectar());

            cmd3.Parameters.AddWithValue("@Id_Estudiante", textBox1.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("EL REGISTRO SE ELIMINÓ DMANERA CORRECTA");


            dataGridView1.DataSource = llenar_datos();

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

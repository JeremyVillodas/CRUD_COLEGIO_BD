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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CRUD_COLEGIO_BD
{
    public partial class mantenimiento_cursos : Form
    {
        public mantenimiento_cursos()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            conexion.conectar();
            dataGridView2.DataSource = llenar_datos();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string insertar = "INSERT INTO CURSO (Id_Curso, Id_Horario, Id_Docente, Nombre) VALUES (@Id_Curso, @Id_Horario, @Id_Docente, @Nombre)";
            SqlCommand cmd1 = new SqlCommand(insertar, conexion.conectar());
            cmd1.Parameters.AddWithValue("@Id_Curso", textBox18.Text);
            cmd1.Parameters.AddWithValue("@Id_Horario", textBox5.Text);
            cmd1.Parameters.AddWithValue("@Id_Docente", textBox11.Text);
            cmd1.Parameters.AddWithValue("@Nombre", textBox12.Text);

            cmd1.ExecuteNonQuery();

            dataGridView2.DataSource = llenar_datos();

            textBox18.Clear();
            textBox5.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }
        public DataTable llenar_datos()
        {
            conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM CURSO";
            SqlCommand cmd = new SqlCommand(consulta, conexion.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox18.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
                textBox5.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
                textBox11.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
                textBox12.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();

            }
            catch
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string modificar = "UPDATE CURSO SET Id_Horario=@Id_Horario, Id_Docente=@Id_Docente, Nombre=@Nombre WHERE Id_Curso=@Id_Curso";

            SqlCommand cmd2 = new SqlCommand(modificar, conexion.conectar());

            cmd2.Parameters.AddWithValue("@Id_Curso", textBox18.Text);
            cmd2.Parameters.AddWithValue("@Id_Horario", textBox5.Text);
            cmd2.Parameters.AddWithValue("@Id_Docente", textBox11.Text);
            cmd2.Parameters.AddWithValue("@Nombre", textBox12.Text);

            cmd2.ExecuteNonQuery();

            dataGridView2.DataSource = llenar_datos();

            textBox18.Clear();
            textBox5.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string eliminar = "DELETE FROM CURSO WHERE Id_Curso=@Id_Curso";
            SqlCommand cmd3 = new SqlCommand(eliminar, conexion.conectar());

            cmd3.Parameters.AddWithValue("@Id_Curso", textBox18.Text);

            cmd3.ExecuteNonQuery();

            MessageBox.Show("EL REGISTRO SE ELIMINÓ DMANERA CORRECTA");


            dataGridView2.DataSource = llenar_datos();

            textBox18.Clear();
            textBox5.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox18.Clear();
            textBox5.Clear();
            textBox11.Clear();
            textBox12.Clear();
        }
    }
}

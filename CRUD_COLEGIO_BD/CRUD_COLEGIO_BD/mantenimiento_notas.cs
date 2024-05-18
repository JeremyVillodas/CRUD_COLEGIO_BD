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
    public partial class mantenimiento_notas : Form
    {
        public mantenimiento_notas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox6.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            }
            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string insertar = "INSERT INTO NOTAS (Id_Nota, Id_Estudiante, Id_Curso, Calificacion) VALUES (@Id_Nota, @Id_Estudiante, @Id_Curso, @Calificacion)";
            SqlCommand cmd1 = new SqlCommand(insertar, conexion.conectar());
            cmd1.Parameters.AddWithValue("@Id_Nota", textBox1.Text);
            cmd1.Parameters.AddWithValue("@Id_Estudiante", textBox2.Text);
            cmd1.Parameters.AddWithValue("@Id_Curso", textBox4.Text);
            cmd1.Parameters.AddWithValue("@Calificacion", int.Parse(textBox6.Text));

            cmd1.ExecuteNonQuery();

            dataGridView1.DataSource = llenar_datos();

            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
        }
        public DataTable llenar_datos()
        {
            conexion.conectar();
            DataTable dt = new DataTable();
            string consulta = "SELECT * FROM NOTAS";
            SqlCommand cmd = new SqlCommand(consulta, conexion.conectar());

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            return dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string modificar = "UPDATE NOTAS SET Id_Estudiante=@Id_Estudiante, Id_Curso=@Id_Curso, Calificacion=@Calificacion WHERE Id_Nota=@Id_Nota";

            SqlCommand cmd2 = new SqlCommand(modificar, conexion.conectar());

            cmd2.Parameters.AddWithValue("@Id_Nota", textBox1.Text);
            cmd2.Parameters.AddWithValue("@Id_Estudiante", textBox2.Text);
            cmd2.Parameters.AddWithValue("@Id_Curso", textBox4.Text);
            cmd2.Parameters.AddWithValue("@Calificacion", int.Parse(textBox6.Text));

            cmd2.ExecuteNonQuery();

            dataGridView1.DataSource = llenar_datos();


            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conexion.conectar();
            string eliminar = "DELETE FROM NOTAS WHERE Id_Nota=@Id_Nota";

            SqlCommand cmd3 = new SqlCommand(eliminar, conexion.conectar());

            cmd3.Parameters.AddWithValue("@Id_Nota", textBox1.Text);

            cmd3.ExecuteNonQuery();

            dataGridView1.DataSource = llenar_datos();

            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
            textBox6.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            conexion.conectar();
            dataGridView1.DataSource = llenar_datos();
        }
    }
}

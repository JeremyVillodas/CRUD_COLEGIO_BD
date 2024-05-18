using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_COLEGIO_BD
{
    public partial class Seleccion_mantenimiento : Form
    {
        public Seleccion_mantenimiento()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento_estudiantes formNext = new mantenimiento_estudiantes();
            formNext.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento_docentes formNext = new mantenimiento_docentes();
            formNext.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento_cursos formNext = new mantenimiento_cursos();
            formNext.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            mantenimiento_notas formNext = new mantenimiento_notas();
            formNext.ShowDialog();
        }
    }
}

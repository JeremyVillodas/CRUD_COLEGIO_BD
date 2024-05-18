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
    public partial class Login : Form
    {
        String[] users = { "root1", "root2", "root3" };
        String[] passwords = { "123", "456", "789" };
        int[] attempts = { 0, 0, 0 };
        bool[] blockeds = { false, false, false };

        public Login()
        {
            InitializeComponent();
        }

        private void blockAccounts(int index)
        {
            if (attempts[index] >= 3)
            {
                blockeds[index] = true;
                MessageBox.Show("!!! Tu cuenta fue bloqueada !!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;

            int index = Array.IndexOf(users, user);

            if (index != -1)
            {
                if (!blockeds[index])
                {
                    if (password == passwords[index])
                    {
                        textBox1.Clear();
                        textBox2.Clear();
                        this.Hide();
                        Seleccion_mantenimiento Inicio = new Seleccion_mantenimiento();
                        Inicio.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show(" !! Contraseña incorrecta !! ");
                        textBox2.Clear();
                        textBox2.Focus();
                        attempts[index]++;
                        blockAccounts(index);
                    }
                }
                else
                {
                    MessageBox.Show("! Tu cuenta fue bloqueada por seguridad !");
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }
            }
            else
            {
                MessageBox.Show(" ! El usuario no existe ! ");
                textBox1.Clear();
                textBox1.Focus();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BringToFront();
            pictureBox2.Visible = true;
            textBox2.PasswordChar = '\0';
            pictureBox1.Visible = false;
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            textBox2.PasswordChar = '*';
        }
    }
}

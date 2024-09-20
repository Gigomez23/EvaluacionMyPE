using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Problema4
{
    public partial class Form1 : Form
    {
        int intentos = 0;
        int idUsuario = 12;
        int idContrasena = 1234;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (intentos < 3)
            {
                try
                {
                    if(Int32.Parse(tbUser.Text) == idUsuario)
                    {
                        if(Int32.Parse(tbPassword.Text) == idContrasena)
                        {
                            MessageBox.Show("Bienvenido usuario. ");
                        }
                        else
                        {
                            MessageBox.Show("La contraseña es incorrecta. ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("El nombre de usuario es incorrecto");
                    }
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                intentos++;
                tbUser.Clear();
                tbPassword.Clear();
                btnLogin.Enabled = false;

            }
            else
            {
                MessageBox.Show("Ya a excedido el limite de 3 intentos.");
            }
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            if (tbPassword.Text != "")
            {
                btnLogin.Enabled = true;
            }
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            if (tbUser.Text != "")
            {
                btnLogin.Enabled = true;
            }
        }
    }
}

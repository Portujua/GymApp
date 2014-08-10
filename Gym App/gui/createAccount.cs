using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gym_App.database;

namespace Gym_App.gui
{
    public partial class createAccount : Form
    {
        DBHandler dbh;

        public createAccount()
        {
            InitializeComponent();
            dbh = new DBHandler();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dbh.create(textBox_Usuario.Text, textBox_Clave.Text,
                    textBox_Nombre.Text, textBox_Apellido.Text))
            {
                this.Visible = false;
                MessageBox.Show("Usuario creado!!!");
            }
            else
                MessageBox.Show("Error, usuario ya existente");
        }
    }
}

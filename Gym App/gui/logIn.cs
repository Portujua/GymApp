using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gym_App.database;
using Gym_App.gui;

namespace Gym_App
{
    public partial class form_Login : Form
    {
        DBHandler dbh;
        mainWindow mainWnd;

        public form_Login()
        {
            InitializeComponent();
            dbh = new DBHandler();
        }

        private void but_logIn_Click(object sender, EventArgs e)
        {
            string user = textBox_Usuario.Text;
            string pw = textBox_Clave.Text;
            if (dbh.login(user, pw))
            {
                mainWnd = new mainWindow(dbh.getNombre(user), dbh.getApellido(user), user, pw);
                mainWnd.Show();
                //notifyIcon1.Text = dbh.getNombre(user) + " " + dbh.getApellido(user) + " - Personal Gym";
                textBox_Clave.Text = "";
                this.Visible = false;
            }
            else
                MessageBox.Show("Usuario o clave incorrecta!!", "Error al iniciar sesion!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            createAccount newAcc = new createAccount();
            newAcc.Show();
        }

        private void mainWindowLogOutTimer_Tick(object sender, EventArgs e)
        {
            if (!this.Visible)
                if (!mainWnd.Visible)
                {
                    mainWnd = null;
                    //notifyIcon1.Text = "Logged off - Personal Gym";
                    this.Visible = true;
                }
        }
    }
}

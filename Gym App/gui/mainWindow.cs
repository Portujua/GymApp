using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gym_App.database;
using Private_Gym.gui;

namespace Gym_App.gui
{
    public partial class mainWindow : Form
    {
        private string nombre, apellido, user, pw;
        private DBHandler dbh;

        /* IDS CONSTANTES */
        private const int USER = 0;
        private const int BICEPS = 1;
        private const int TRICEPS = 2;
        private const int ESPALDA = 3;
        private const int PECHO = 4;
        private const int HOMBROS = 5;
        private const int ABS = 6;

        /* Ventanas */
        private aboutMe acercaDeMi;

        public mainWindow(string nombre, string apellido, string user, string pw)
        {
            InitializeComponent();

            dbh = new DBHandler();
            acercaDeMi = new aboutMe();

            this.nombre = nombre;
            this.apellido = apellido;
            this.user = user;
            this.pw = pw;

            updateAllInfo();
        }

        private void updateAllInfo()
        {
            /* LABELS */
            label_helloMsg.Text = "Hola " + nombre + "!";
            
            // Niveles
            label_userLevel.Text = "Nivel " + dbh.getNivel(user, USER);
            label_levelBiceps.Text = dbh.getNivel(user, BICEPS);
            label_levelTriceps.Text = dbh.getNivel(user, TRICEPS);
            label_levelPecho.Text = dbh.getNivel(user, PECHO);
            label_levelEspalda.Text = dbh.getNivel(user, ESPALDA);
            label_levelHombros.Text = dbh.getNivel(user, HOMBROS);
            label_levelAbs.Text = dbh.getNivel(user, ABS);

            // Estados -- Texto
            label_statusBiceps.Text = getStatusString(Convert.ToInt32(dbh.getEstado(user, BICEPS)));
            label_statusTriceps.Text = getStatusString(Convert.ToInt32(dbh.getEstado(user, TRICEPS)));
            label_statusPecho.Text = getStatusString(Convert.ToInt32(dbh.getEstado(user, PECHO)));
            label_statusEspalda.Text = getStatusString(Convert.ToInt32(dbh.getEstado(user, ESPALDA)));
            label_statusHombros.Text = getStatusString(Convert.ToInt32(dbh.getEstado(user, HOMBROS)));
            label_statusAbs.Text = getStatusString(Convert.ToInt32(dbh.getEstado(user, ABS)));

            // Estados -- Color
            label_statusBiceps.ForeColor = getColor(Convert.ToInt32(dbh.getEstado(user, BICEPS)));
            label_statusTriceps.ForeColor = getColor(Convert.ToInt32(dbh.getEstado(user, TRICEPS)));
            label_statusPecho.ForeColor = getColor(Convert.ToInt32(dbh.getEstado(user, PECHO)));
            label_statusEspalda.ForeColor = getColor(Convert.ToInt32(dbh.getEstado(user, ESPALDA)));
            label_statusHombros.ForeColor = getColor(Convert.ToInt32(dbh.getEstado(user, HOMBROS)));
            label_statusAbs.ForeColor = getColor(Convert.ToInt32(dbh.getEstado(user, ABS)));

            /* BARRAS */
            // Setteando sus capacidades
            bar_userLevel.Maximum = 100 + (Convert.ToInt32(dbh.getNivel(user, USER)) * 10);
            bar_Biceps.Maximum = 100 + (Convert.ToInt32(dbh.getNivel(user, BICEPS)) * 10);
            bar_Triceps.Maximum = 100 + (Convert.ToInt32(dbh.getNivel(user, TRICEPS)) * 10);
            bar_Pecho.Maximum = 100 + (Convert.ToInt32(dbh.getNivel(user, PECHO)) * 10);
            bar_Espalda.Maximum = 100 + (Convert.ToInt32(dbh.getNivel(user, ESPALDA)) * 10);
            bar_Hombros.Maximum = 100 + (Convert.ToInt32(dbh.getNivel(user, HOMBROS)) * 10);
            bar_Abs.Maximum = 100 + (Convert.ToInt32(dbh.getNivel(user, ABS)) * 10);

            //Setteando sus valores
            bar_userLevel.Value = Convert.ToInt32(dbh.getExp(user, USER));
            bar_Biceps.Value = Convert.ToInt32(dbh.getExp(user, BICEPS));
            bar_Triceps.Value = Convert.ToInt32(dbh.getExp(user, TRICEPS));
            bar_Pecho.Value = Convert.ToInt32(dbh.getExp(user, PECHO));
            bar_Espalda.Value = Convert.ToInt32(dbh.getExp(user, ESPALDA));
            bar_Hombros.Value = Convert.ToInt32(dbh.getExp(user, HOMBROS));
            bar_Abs.Value = Convert.ToInt32(dbh.getExp(user, ABS));
            
            /* Foto */
            myPhoto.Image = Image.FromFile(dbh.getImgURL(user));
        }

        private Color getColor(int cansancio)
        {
            if (cansancio <= 33)
                return Color.Green;
            else if (cansancio <= 75)
                return Color.Yellow;
            else
                return Color.Red;  
        }

        private string getStatusString(int cansancio)
        {
            if (cansancio <= 33)            
                return "Perfecto";            
            else if (cansancio <= 75)            
                return "Cansado";            
            else            
                return "CRITICO";            
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void miInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!acercaDeMi.Visible)
            {
                acercaDeMi.setInfo(nombre + " " + apellido, dbh.getFecha(user));
                acercaDeMi.Show();
            }
        }
    }
}

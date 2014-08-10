using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Private_Gym.gui
{
    public partial class aboutMe : Form
    {
        public aboutMe()
        {
            InitializeComponent();
        }

        public void setInfo(string nombreCompleto, string fecha)
        {
            this.label_Nombre.Text = "Nombre completo: " + nombreCompleto;
            this.label_fecha.Text = "Usuario desde: " + fecha;
        }
    }
}

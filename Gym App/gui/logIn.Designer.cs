namespace Gym_App
{
    partial class form_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.but_logIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Clave = new System.Windows.Forms.TextBox();
            this.textBox_Usuario = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainWindowLogOutTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // but_logIn
            // 
            this.but_logIn.ForeColor = System.Drawing.Color.Black;
            this.but_logIn.Location = new System.Drawing.Point(101, 115);
            this.but_logIn.Name = "but_logIn";
            this.but_logIn.Size = new System.Drawing.Size(93, 28);
            this.but_logIn.TabIndex = 3;
            this.but_logIn.Text = "Login";
            this.but_logIn.UseVisualStyleBackColor = true;
            this.but_logIn.Click += new System.EventHandler(this.but_logIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Contraseña";
            // 
            // textBox_Clave
            // 
            this.textBox_Clave.Location = new System.Drawing.Point(113, 75);
            this.textBox_Clave.Name = "textBox_Clave";
            this.textBox_Clave.Size = new System.Drawing.Size(143, 20);
            this.textBox_Clave.TabIndex = 2;
            this.textBox_Clave.UseSystemPasswordChar = true;
            // 
            // textBox_Usuario
            // 
            this.textBox_Usuario.Location = new System.Drawing.Point(113, 39);
            this.textBox_Usuario.Name = "textBox_Usuario";
            this.textBox_Usuario.Size = new System.Drawing.Size(143, 20);
            this.textBox_Usuario.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(68, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "No tienes cuenta?";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mainWindowLogOutTimer
            // 
            this.mainWindowLogOutTimer.Enabled = true;
            this.mainWindowLogOutTimer.Tick += new System.EventHandler(this.mainWindowLogOutTimer_Tick);
            // 
            // form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(288, 182);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Usuario);
            this.Controls.Add(this.textBox_Clave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.but_logIn);
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Gym";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button but_logIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Clave;
        private System.Windows.Forms.TextBox textBox_Usuario;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer mainWindowLogOutTimer;
    }
}


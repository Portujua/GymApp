namespace Gym_App.gui
{
    partial class mainWindow
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
            this.label_helloMsg = new System.Windows.Forms.Label();
            this.button_logOut = new System.Windows.Forms.Button();
            this.myPhoto = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miInformacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label_userLevel = new System.Windows.Forms.Label();
            this.bar_userLevel = new System.Windows.Forms.ProgressBar();
            this.label_levelBiceps = new System.Windows.Forms.Label();
            this.label_levelAbs = new System.Windows.Forms.Label();
            this.label_levelTriceps = new System.Windows.Forms.Label();
            this.label_levelPecho = new System.Windows.Forms.Label();
            this.label_levelHombros = new System.Windows.Forms.Label();
            this.label_levelEspalda = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bar_Biceps = new System.Windows.Forms.ProgressBar();
            this.bar_Triceps = new System.Windows.Forms.ProgressBar();
            this.bar_Pecho = new System.Windows.Forms.ProgressBar();
            this.bar_Espalda = new System.Windows.Forms.ProgressBar();
            this.bar_Hombros = new System.Windows.Forms.ProgressBar();
            this.bar_Abs = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_statusBiceps = new System.Windows.Forms.Label();
            this.label_statusTriceps = new System.Windows.Forms.Label();
            this.label_statusPecho = new System.Windows.Forms.Label();
            this.label_statusEspalda = new System.Windows.Forms.Label();
            this.label_statusHombros = new System.Windows.Forms.Label();
            this.label_statusAbs = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.myPhoto)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_helloMsg
            // 
            this.label_helloMsg.AutoSize = true;
            this.label_helloMsg.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_helloMsg.Location = new System.Drawing.Point(237, 46);
            this.label_helloMsg.Name = "label_helloMsg";
            this.label_helloMsg.Size = new System.Drawing.Size(233, 23);
            this.label_helloMsg.TabIndex = 0;
            this.label_helloMsg.Text = "Hola, Nombre Apellido!";
            // 
            // button_logOut
            // 
            this.button_logOut.BackColor = System.Drawing.Color.Silver;
            this.button_logOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logOut.ForeColor = System.Drawing.Color.Black;
            this.button_logOut.Location = new System.Drawing.Point(27, 296);
            this.button_logOut.Name = "button_logOut";
            this.button_logOut.Size = new System.Drawing.Size(187, 33);
            this.button_logOut.TabIndex = 1;
            this.button_logOut.Text = "Salir de la cuenta";
            this.button_logOut.UseVisualStyleBackColor = false;
            this.button_logOut.Click += new System.EventHandler(this.button_logOut_Click);
            // 
            // myPhoto
            // 
            this.myPhoto.Location = new System.Drawing.Point(27, 46);
            this.myPhoto.Name = "myPhoto";
            this.myPhoto.Size = new System.Drawing.Size(187, 233);
            this.myPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.myPhoto.TabIndex = 2;
            this.myPhoto.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCuentaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miCuentaToolStripMenuItem
            // 
            this.miCuentaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miInformacionToolStripMenuItem});
            this.miCuentaToolStripMenuItem.Name = "miCuentaToolStripMenuItem";
            this.miCuentaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.miCuentaToolStripMenuItem.Text = "Mi Cuenta";
            // 
            // miInformacionToolStripMenuItem
            // 
            this.miInformacionToolStripMenuItem.Name = "miInformacionToolStripMenuItem";
            this.miInformacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.miInformacionToolStripMenuItem.Text = "Acerca de mi..";
            this.miInformacionToolStripMenuItem.Click += new System.EventHandler(this.miInformacionToolStripMenuItem_Click);
            // 
            // label_userLevel
            // 
            this.label_userLevel.AutoSize = true;
            this.label_userLevel.Location = new System.Drawing.Point(566, 39);
            this.label_userLevel.Name = "label_userLevel";
            this.label_userLevel.Size = new System.Drawing.Size(48, 13);
            this.label_userLevel.TabIndex = 4;
            this.label_userLevel.Text = "Nivel XX";
            // 
            // bar_userLevel
            // 
            this.bar_userLevel.Location = new System.Drawing.Point(540, 55);
            this.bar_userLevel.Name = "bar_userLevel";
            this.bar_userLevel.Size = new System.Drawing.Size(99, 14);
            this.bar_userLevel.TabIndex = 5;
            // 
            // label_levelBiceps
            // 
            this.label_levelBiceps.AutoSize = true;
            this.label_levelBiceps.Location = new System.Drawing.Point(346, 118);
            this.label_levelBiceps.Name = "label_levelBiceps";
            this.label_levelBiceps.Size = new System.Drawing.Size(21, 13);
            this.label_levelBiceps.TabIndex = 6;
            this.label_levelBiceps.Text = "XX";
            // 
            // label_levelAbs
            // 
            this.label_levelAbs.AutoSize = true;
            this.label_levelAbs.Location = new System.Drawing.Point(554, 280);
            this.label_levelAbs.Name = "label_levelAbs";
            this.label_levelAbs.Size = new System.Drawing.Size(21, 13);
            this.label_levelAbs.TabIndex = 7;
            this.label_levelAbs.Text = "XX";
            // 
            // label_levelTriceps
            // 
            this.label_levelTriceps.AutoSize = true;
            this.label_levelTriceps.Location = new System.Drawing.Point(346, 200);
            this.label_levelTriceps.Name = "label_levelTriceps";
            this.label_levelTriceps.Size = new System.Drawing.Size(21, 13);
            this.label_levelTriceps.TabIndex = 8;
            this.label_levelTriceps.Text = "XX";
            // 
            // label_levelPecho
            // 
            this.label_levelPecho.AutoSize = true;
            this.label_levelPecho.Location = new System.Drawing.Point(346, 280);
            this.label_levelPecho.Name = "label_levelPecho";
            this.label_levelPecho.Size = new System.Drawing.Size(21, 13);
            this.label_levelPecho.TabIndex = 9;
            this.label_levelPecho.Text = "XX";
            // 
            // label_levelHombros
            // 
            this.label_levelHombros.AutoSize = true;
            this.label_levelHombros.Location = new System.Drawing.Point(554, 201);
            this.label_levelHombros.Name = "label_levelHombros";
            this.label_levelHombros.Size = new System.Drawing.Size(21, 13);
            this.label_levelHombros.TabIndex = 10;
            this.label_levelHombros.Text = "XX";
            // 
            // label_levelEspalda
            // 
            this.label_levelEspalda.AutoSize = true;
            this.label_levelEspalda.Location = new System.Drawing.Point(554, 119);
            this.label_levelEspalda.Name = "label_levelEspalda";
            this.label_levelEspalda.Size = new System.Drawing.Size(21, 13);
            this.label_levelEspalda.TabIndex = 11;
            this.label_levelEspalda.Text = "XX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(238, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Biceps:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Triceps:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(238, 251);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Pecho:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(446, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Hombros:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(446, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "Espalda:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(446, 251);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 16);
            this.label12.TabIndex = 17;
            this.label12.Text = "Abdominales:";
            // 
            // bar_Biceps
            // 
            this.bar_Biceps.Location = new System.Drawing.Point(241, 117);
            this.bar_Biceps.Name = "bar_Biceps";
            this.bar_Biceps.Size = new System.Drawing.Size(99, 14);
            this.bar_Biceps.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.bar_Biceps.TabIndex = 18;
            // 
            // bar_Triceps
            // 
            this.bar_Triceps.Location = new System.Drawing.Point(241, 199);
            this.bar_Triceps.Name = "bar_Triceps";
            this.bar_Triceps.Size = new System.Drawing.Size(99, 14);
            this.bar_Triceps.TabIndex = 19;
            // 
            // bar_Pecho
            // 
            this.bar_Pecho.Location = new System.Drawing.Point(241, 279);
            this.bar_Pecho.Name = "bar_Pecho";
            this.bar_Pecho.Size = new System.Drawing.Size(99, 14);
            this.bar_Pecho.TabIndex = 20;
            // 
            // bar_Espalda
            // 
            this.bar_Espalda.Location = new System.Drawing.Point(449, 118);
            this.bar_Espalda.Name = "bar_Espalda";
            this.bar_Espalda.Size = new System.Drawing.Size(99, 14);
            this.bar_Espalda.TabIndex = 21;
            // 
            // bar_Hombros
            // 
            this.bar_Hombros.Location = new System.Drawing.Point(449, 200);
            this.bar_Hombros.Name = "bar_Hombros";
            this.bar_Hombros.Size = new System.Drawing.Size(99, 14);
            this.bar_Hombros.TabIndex = 22;
            // 
            // bar_Abs
            // 
            this.bar_Abs.Location = new System.Drawing.Point(449, 279);
            this.bar_Abs.Name = "bar_Abs";
            this.bar_Abs.Size = new System.Drawing.Size(99, 14);
            this.bar_Abs.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(238, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(238, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Estado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(446, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Estado:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(446, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Estado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(446, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Estado:";
            // 
            // label_statusBiceps
            // 
            this.label_statusBiceps.AutoSize = true;
            this.label_statusBiceps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statusBiceps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_statusBiceps.Location = new System.Drawing.Point(288, 143);
            this.label_statusBiceps.Name = "label_statusBiceps";
            this.label_statusBiceps.Size = new System.Drawing.Size(48, 13);
            this.label_statusBiceps.TabIndex = 30;
            this.label_statusBiceps.Text = "Perfecto";
            // 
            // label_statusTriceps
            // 
            this.label_statusTriceps.AutoSize = true;
            this.label_statusTriceps.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statusTriceps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_statusTriceps.Location = new System.Drawing.Point(288, 225);
            this.label_statusTriceps.Name = "label_statusTriceps";
            this.label_statusTriceps.Size = new System.Drawing.Size(48, 13);
            this.label_statusTriceps.TabIndex = 31;
            this.label_statusTriceps.Text = "Perfecto";
            // 
            // label_statusPecho
            // 
            this.label_statusPecho.AutoSize = true;
            this.label_statusPecho.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statusPecho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_statusPecho.Location = new System.Drawing.Point(288, 306);
            this.label_statusPecho.Name = "label_statusPecho";
            this.label_statusPecho.Size = new System.Drawing.Size(48, 13);
            this.label_statusPecho.TabIndex = 32;
            this.label_statusPecho.Text = "Perfecto";
            // 
            // label_statusEspalda
            // 
            this.label_statusEspalda.AutoSize = true;
            this.label_statusEspalda.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statusEspalda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_statusEspalda.Location = new System.Drawing.Point(493, 143);
            this.label_statusEspalda.Name = "label_statusEspalda";
            this.label_statusEspalda.Size = new System.Drawing.Size(48, 13);
            this.label_statusEspalda.TabIndex = 33;
            this.label_statusEspalda.Text = "Perfecto";
            // 
            // label_statusHombros
            // 
            this.label_statusHombros.AutoSize = true;
            this.label_statusHombros.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statusHombros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_statusHombros.Location = new System.Drawing.Point(493, 225);
            this.label_statusHombros.Name = "label_statusHombros";
            this.label_statusHombros.Size = new System.Drawing.Size(48, 13);
            this.label_statusHombros.TabIndex = 34;
            this.label_statusHombros.Text = "Perfecto";
            // 
            // label_statusAbs
            // 
            this.label_statusAbs.AutoSize = true;
            this.label_statusAbs.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_statusAbs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label_statusAbs.Location = new System.Drawing.Point(493, 306);
            this.label_statusAbs.Name = "label_statusAbs";
            this.label_statusAbs.Size = new System.Drawing.Size(48, 13);
            this.label_statusAbs.TabIndex = 35;
            this.label_statusAbs.Text = "Perfecto";
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(675, 341);
            this.ControlBox = false;
            this.Controls.Add(this.label_statusAbs);
            this.Controls.Add(this.label_statusHombros);
            this.Controls.Add(this.label_statusEspalda);
            this.Controls.Add(this.label_statusPecho);
            this.Controls.Add(this.label_statusTriceps);
            this.Controls.Add(this.label_statusBiceps);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bar_Abs);
            this.Controls.Add(this.bar_Hombros);
            this.Controls.Add(this.bar_Espalda);
            this.Controls.Add(this.bar_Pecho);
            this.Controls.Add(this.bar_Triceps);
            this.Controls.Add(this.bar_Biceps);
            this.Controls.Add(this.label_userLevel);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_levelEspalda);
            this.Controls.Add(this.label_levelHombros);
            this.Controls.Add(this.label_levelPecho);
            this.Controls.Add(this.label_levelTriceps);
            this.Controls.Add(this.label_levelAbs);
            this.Controls.Add(this.label_levelBiceps);
            this.Controls.Add(this.bar_userLevel);
            this.Controls.Add(this.myPhoto);
            this.Controls.Add(this.button_logOut);
            this.Controls.Add(this.label_helloMsg);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Private Gym";
            ((System.ComponentModel.ISupportInitialize)(this.myPhoto)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_helloMsg;
        private System.Windows.Forms.Button button_logOut;
        private System.Windows.Forms.PictureBox myPhoto;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miInformacionToolStripMenuItem;
        private System.Windows.Forms.Label label_userLevel;
        private System.Windows.Forms.ProgressBar bar_userLevel;
        private System.Windows.Forms.Label label_levelBiceps;
        private System.Windows.Forms.Label label_levelAbs;
        private System.Windows.Forms.Label label_levelTriceps;
        private System.Windows.Forms.Label label_levelPecho;
        private System.Windows.Forms.Label label_levelHombros;
        private System.Windows.Forms.Label label_levelEspalda;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ProgressBar bar_Biceps;
        private System.Windows.Forms.ProgressBar bar_Triceps;
        private System.Windows.Forms.ProgressBar bar_Pecho;
        private System.Windows.Forms.ProgressBar bar_Espalda;
        private System.Windows.Forms.ProgressBar bar_Hombros;
        private System.Windows.Forms.ProgressBar bar_Abs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_statusBiceps;
        private System.Windows.Forms.Label label_statusTriceps;
        private System.Windows.Forms.Label label_statusPecho;
        private System.Windows.Forms.Label label_statusEspalda;
        private System.Windows.Forms.Label label_statusHombros;
        private System.Windows.Forms.Label label_statusAbs;
    }
}
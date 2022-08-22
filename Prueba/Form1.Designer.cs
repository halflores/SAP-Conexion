namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Server = new System.Windows.Forms.TextBox();
            this.CompanyDB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DbPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DbUserName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LicenseServer = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.res = new System.Windows.Forms.TextBox();
            this.servertype = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.languaje = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.trusted = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SLDServer = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(418, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "CONECTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Server";
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(141, 14);
            this.Server.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(293, 22);
            this.Server.TabIndex = 2;
            this.Server.Text = "NDB@192.168.1.16:30013";
            // 
            // CompanyDB
            // 
            this.CompanyDB.Location = new System.Drawing.Point(141, 41);
            this.CompanyDB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyDB.Name = "CompanyDB";
            this.CompanyDB.Size = new System.Drawing.Size(293, 22);
            this.CompanyDB.TabIndex = 4;
            this.CompanyDB.Text = "TEST";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "CompanyDB";
            // 
            // DbPassword
            // 
            this.DbPassword.Location = new System.Drawing.Point(141, 97);
            this.DbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbPassword.Name = "DbPassword";
            this.DbPassword.Size = new System.Drawing.Size(293, 22);
            this.DbPassword.TabIndex = 8;
            this.DbPassword.Text = "SAPC1ms12021";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "DbPassword";
            // 
            // DbUserName
            // 
            this.DbUserName.Location = new System.Drawing.Point(141, 69);
            this.DbUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DbUserName.Name = "DbUserName";
            this.DbUserName.Size = new System.Drawing.Size(293, 22);
            this.DbUserName.TabIndex = 6;
            this.DbUserName.Text = "SAPINST";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "DbUserName";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(141, 153);
            this.Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(293, 22);
            this.Password.TabIndex = 12;
            this.Password.Text = "1234";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(141, 126);
            this.UserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(293, 22);
            this.UserName.TabIndex = 10;
            this.UserName.Text = "jjustiniano";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "UserName";
            // 
            // LicenseServer
            // 
            this.LicenseServer.Location = new System.Drawing.Point(141, 181);
            this.LicenseServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LicenseServer.Name = "LicenseServer";
            this.LicenseServer.Size = new System.Drawing.Size(293, 22);
            this.LicenseServer.TabIndex = 14;
            this.LicenseServer.Text = "NDB@192.168.1.16:30013";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "LicenseServer";
            // 
            // res
            // 
            this.res.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.res.Location = new System.Drawing.Point(16, 542);
            this.res.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.res.Multiline = true;
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(419, 97);
            this.res.TabIndex = 15;
            // 
            // servertype
            // 
            this.servertype.Location = new System.Drawing.Point(141, 236);
            this.servertype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.servertype.Name = "servertype";
            this.servertype.Size = new System.Drawing.Size(293, 22);
            this.servertype.TabIndex = 16;
            this.servertype.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "server type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "languaje";
            // 
            // languaje
            // 
            this.languaje.Location = new System.Drawing.Point(141, 264);
            this.languaje.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.languaje.Name = "languaje";
            this.languaje.Size = new System.Drawing.Size(293, 22);
            this.languaje.TabIndex = 18;
            this.languaje.Text = "1";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(16, 296);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(52, 17);
            this.label.TabIndex = 21;
            this.label.Text = "trusted";
            // 
            // trusted
            // 
            this.trusted.Location = new System.Drawing.Point(141, 292);
            this.trusted.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trusted.Name = "trusted";
            this.trusted.Size = new System.Drawing.Size(293, 22);
            this.trusted.TabIndex = 20;
            this.trusted.Text = "2";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 467);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 37);
            this.button2.TabIndex = 22;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(119, 467);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 37);
            this.button3.TabIndex = 23;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(212, 467);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 37);
            this.button4.TabIndex = 24;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(300, 467);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(87, 37);
            this.button5.TabIndex = 25;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(19, 389);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(416, 28);
            this.button6.TabIndex = 26;
            this.button6.Text = "CREAR ASIENTO";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // SLDServer
            // 
            this.SLDServer.Location = new System.Drawing.Point(141, 210);
            this.SLDServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SLDServer.Name = "SLDServer";
            this.SLDServer.Size = new System.Drawing.Size(293, 22);
            this.SLDServer.TabIndex = 27;
            this.SLDServer.Text = "192.168.1.16:40000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 28;
            this.label10.Text = "SLD";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 667);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SLDServer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.trusted);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.languaje);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.servertype);
            this.Controls.Add(this.res);
            this.Controls.Add(this.LicenseServer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DbPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DbUserName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CompanyDB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.TextBox CompanyDB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DbPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DbUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LicenseServer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox res;
        private System.Windows.Forms.TextBox servertype;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox languaje;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox trusted;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox SLDServer;
        private System.Windows.Forms.Label label10;
    }
}


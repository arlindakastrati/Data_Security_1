namespace TCP_Klienti
{
        partial class Client
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
                this.btnConnect = new System.Windows.Forms.Button();
                this.txtIP = new System.Windows.Forms.TextBox();
                this.txtPorti = new System.Windows.Forms.TextBox();
                this.txtMesazhi = new System.Windows.Forms.TextBox();
                this.txtPassword = new System.Windows.Forms.TextBox();
                this.txtUsername = new System.Windows.Forms.TextBox();
                this.label6 = new System.Windows.Forms.Label();
                this.label5 = new System.Windows.Forms.Label();
                this.label4 = new System.Windows.Forms.Label();
                this.label3 = new System.Windows.Forms.Label();
                this.label2 = new System.Windows.Forms.Label();
                this.label0 = new System.Windows.Forms.Label();
                this.label1 = new System.Windows.Forms.Label();
                this.btnLogin = new System.Windows.Forms.Button();
                this.SuspendLayout();
                // 
                // btnConnect -buttoni CONNECT
                // 
                this.btnConnect.Location = new System.Drawing.Point(206, 18);
                this.btnConnect.Name = "btnConnect";
                this.btnConnect.Size = new System.Drawing.Size(130, 50);
                this.btnConnect.TabIndex = 30;
                this.btnConnect.Text = "Connect";
                this.btnConnect.UseVisualStyleBackColor = true;
                this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
                // 
                // txtIP per ip adresen e serverit
                // 
                this.txtIP.Enabled = false;
                this.txtIP.Location = new System.Drawing.Point(91, 18);
                this.txtIP.Name = "txtIP";
                this.txtIP.Size = new System.Drawing.Size(98, 20);
                this.txtIP.TabIndex = 29;
                this.txtIP.Text = "127.0.0.1";
                // 
                // txtPorti per portin e serverit
                // 
                this.txtPorti.Enabled = false;
                this.txtPorti.Location = new System.Drawing.Point(91, 47);
                this.txtPorti.Name = "txtPorti";
                this.txtPorti.Size = new System.Drawing.Size(45, 20);
                this.txtPorti.TabIndex = 26;
                this.txtPorti.Text = "7000";
                // 
                // txtMesazhi per pergjigjen e Serverit
                // 
                this.txtMesazhi.Enabled = false;
                this.txtMesazhi.Location = new System.Drawing.Point(29, 384);
                this.txtMesazhi.Multiline = true;
                this.txtMesazhi.Name = "txtMesazhi";
                this.txtMesazhi.Size = new System.Drawing.Size(313, 50);
                this.txtMesazhi.TabIndex = 24;
            
                // 
                // label4 per tekstin Porti
                // 
                this.label4.AutoSize = true;
                this.label4.Location = new System.Drawing.Point(29, 50);
                this.label4.Name = "label4";
                this.label4.Size = new System.Drawing.Size(31, 13);
                this.label4.TabIndex = 28;
                this.label4.Text = "Porti:";
                // 
                // label3 per teksin IP Adresa
                // 
                this.label3.AutoSize = true;
                this.label3.Location = new System.Drawing.Point(29, 21);
                this.label3.Name = "label3";
                this.label3.Size = new System.Drawing.Size(56, 13);
                this.label3.TabIndex = 27;
                this.label3.Text = "IP Adresa:";
                // 
                // label0 per Login
                // 
                this.label0.AutoSize = true;
                this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.label0.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
                this.label0.Location = new System.Drawing.Point(150, 100);
                this.label0.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                this.label0.Name = "label0";
                this.label0.Size = new System.Drawing.Size(73,29);
                this.label0.TabIndex = 0;
                this.label0.Text = "Login";
                // 
                // label1 per label te Username
                // 
                this.label1.AutoSize = true;
                this.label1.Location = new System.Drawing.Point(80, 150);
                this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                this.label1.Name = "label1";
                this.label1.Size = new System.Drawing.Size(55, 13);
                this.label1.TabIndex = 3;
                this.label1.Text = "Username:";
                // 
                // txtUsername per tekstin e username
                // 
                this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtUsername.Location = new System.Drawing.Point(80, 170);
                this.txtUsername.Margin = new System.Windows.Forms.Padding(2);
                this.txtUsername.Name = "txtUsername";
                this.txtUsername.Size = new System.Drawing.Size(224, 21);
                this.txtUsername.TabIndex = 1;
                // 
                // label5 per label te Passwordit
                // 
                this.label5.AutoSize = true;
                this.label5.Location = new System.Drawing.Point(80, 200);
                this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                this.label5.Name = "label5";
                this.label5.Size = new System.Drawing.Size(53, 13);
                this.label5.TabIndex = 4;
                this.label5.Text = "Password:";
                // 
                // txtPassword
                // 
                this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtPassword.Location = new System.Drawing.Point(80, 220);
                this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
                this.txtPassword.Name = "txtPassword";
                this.txtPassword.Size = new System.Drawing.Size(224, 21);
                this.txtPassword.TabIndex = 2;
                this.txtPassword.UseSystemPasswordChar = true;
                // 
                // btnLogin per butonin e Login
                // 
                this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(83)))), ((int)(((byte)(120)))));
                this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(255)))), ((int)(((byte)(226)))));
                this.btnLogin.Location = new System.Drawing.Point(150, 260);
                this.btnLogin.Margin = new System.Windows.Forms.Padding(2);
                this.btnLogin.Name = "btnLogin";
                this.btnLogin.Size = new System.Drawing.Size(92, 32);
                this.btnLogin.TabIndex = 5;
                this.btnLogin.Text = "Login";
                this.btnLogin.UseVisualStyleBackColor = false;
                this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
                // 
                // label6 per Sign up
                // 
                this.label6.AutoSize = true;
                this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(149)))), ((int)(((byte)(163)))));
                this.label6.Location = new System.Drawing.Point(100, 300);
                this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
                this.label6.Name = "label6";
                this.label6.Size = new System.Drawing.Size(193, 13);
                this.label6.TabIndex = 6;
                this.label6.Text = "Don\'t have an account ? Sign up now !";
                this.label6.Click += new System.EventHandler(this.Label6_Click);
                // 
                // label2 per tekstin Pergjigjja nga Serveri
                // 
                this.label2.AutoSize = true;
                this.label2.Location = new System.Drawing.Point(30, 368);
                this.label2.Name = "label2";
                this.label2.Size = new System.Drawing.Size(122, 13);
                this.label2.TabIndex = 25;
                this.label2.Text = "Pergjigjja nga SERVERI:";


                // 
                // Klienti
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.ClientSize = new System.Drawing.Size(375, 450);
                this.Controls.Add(this.btnConnect);
                this.Controls.Add(this.btnLogin);
                this.Controls.Add(this.txtIP);
                this.Controls.Add(this.txtPorti);
                this.Controls.Add(this.txtMesazhi);
                this.Controls.Add(this.txtPassword);
                this.Controls.Add(this.txtUsername);
                this.Controls.Add(this.label6);
                this.Controls.Add(this.label5);
                this.Controls.Add(this.label4);
                this.Controls.Add(this.label3);
                this.Controls.Add(this.label2);
                this.Controls.Add(this.label0);
                this.Controls.Add(this.label1);
                this.Name = "Klienti";
                this.Text = "Klienti";
                this.ResumeLayout(false);
                this.PerformLayout();
            }

            #endregion
           
            private System.Windows.Forms.Button btnConnect;
            private System.Windows.Forms.Button btnLogin;
            private System.Windows.Forms.TextBox txtIP;
            private System.Windows.Forms.TextBox txtPorti;
            private System.Windows.Forms.TextBox txtMesazhi;
            private System.Windows.Forms.Label label6;
            private System.Windows.Forms.Label label5;
            private System.Windows.Forms.Label label4;
            private System.Windows.Forms.Label label3;
            private System.Windows.Forms.Label label2;
            private System.Windows.Forms.Label label0;
            private System.Windows.Forms.Label label1;
            private System.Windows.Forms.TextBox txtUsername;
            private System.Windows.Forms.TextBox txtPassword;


        }
    }

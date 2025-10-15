namespace PetitPlannerIntegrador
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            Panel_azul = new RoundPanel();
            titulo = new Label();
            userLabel = new Label();
            passwordLabel = new Label();
            userPanel = new RoundPanel();
            textBoxUsuario = new TextBox();
            passwordPanel = new RoundPanel();
            textBoxPassword = new TextBox();
            loginButton = new RoundButton();
            Panel_azul.SuspendLayout();
            userPanel.SuspendLayout();
            passwordPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Panel_azul
            // 
            Panel_azul.BackColor = Color.FromArgb(0, 0, 64);
            Panel_azul.Controls.Add(titulo);
            Panel_azul.Controls.Add(userLabel);
            Panel_azul.Controls.Add(passwordLabel);
            Panel_azul.Controls.Add(userPanel);
            Panel_azul.Controls.Add(passwordPanel);
            Panel_azul.Controls.Add(loginButton);
            Panel_azul.CornerRadius = 40;
            Panel_azul.Location = new Point(176, 88);
            Panel_azul.Name = "Panel_azul";
            Panel_azul.Size = new Size(600, 410);
            Panel_azul.TabIndex = 0;
            // 
            // titulo
            // 
            titulo.AutoSize = true;
            titulo.BackColor = Color.Transparent;
            titulo.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titulo.ForeColor = Color.White;
            titulo.Location = new Point(224, 29);
            titulo.Name = "titulo";
            titulo.Size = new Size(151, 60);
            titulo.TabIndex = 0;
            titulo.Text = "Log In";
            titulo.Click += titleLabel_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.BackColor = Color.Transparent;
            userLabel.Font = new Font("Segoe UI", 10F);
            userLabel.ForeColor = Color.White;
            userLabel.Location = new Point(95, 120);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(51, 28);
            userLabel.TabIndex = 1;
            userLabel.Text = "User";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.BackColor = Color.Transparent;
            passwordLabel.Font = new Font("Segoe UI", 10F);
            passwordLabel.ForeColor = Color.White;
            passwordLabel.Location = new Point(95, 205);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(93, 28);
            passwordLabel.TabIndex = 2;
            passwordLabel.Text = "Password";
            // 
            // userPanel
            // 
            userPanel.BackColor = Color.FromArgb(53, 64, 103);
            userPanel.Controls.Add(textBoxUsuario);
            userPanel.CornerRadius = 20;
            userPanel.Location = new Point(100, 150);
            userPanel.Name = "userPanel";
            userPanel.Padding = new Padding(10, 5, 10, 5);
            userPanel.Size = new Size(400, 45);
            userPanel.TabIndex = 3;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = Color.FromArgb(53, 64, 103);
            textBoxUsuario.BorderStyle = BorderStyle.None;
            textBoxUsuario.Dock = DockStyle.Fill;
            textBoxUsuario.Font = new Font("Segoe UI", 12F);
            textBoxUsuario.ForeColor = Color.White;
            textBoxUsuario.Location = new Point(10, 5);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(380, 32);
            textBoxUsuario.TabIndex = 0;
            // 
            // passwordPanel
            // 
            passwordPanel.BackColor = Color.FromArgb(53, 64, 103);
            passwordPanel.Controls.Add(textBoxPassword);
            passwordPanel.CornerRadius = 20;
            passwordPanel.Location = new Point(100, 235);
            passwordPanel.Name = "passwordPanel";
            passwordPanel.Padding = new Padding(10, 5, 10, 5);
            passwordPanel.Size = new Size(400, 45);
            passwordPanel.TabIndex = 4;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(53, 64, 103);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Dock = DockStyle.Fill;
            textBoxPassword.Font = new Font("Segoe UI", 12F);
            textBoxPassword.ForeColor = Color.White;
            textBoxPassword.Location = new Point(10, 5);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(380, 32);
            textBoxPassword.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.White;
            loginButton.CornerRadius = 25;
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            loginButton.ForeColor = Color.FromArgb(29, 38, 68);
            loginButton.Location = new Point(200, 320);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(200, 55);
            loginButton.TabIndex = 5;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(214, 214, 227);
            ClientSize = new Size(962, 548);
            Controls.Add(Panel_azul);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Petit Planner - Login";
            Resize += Form1_Resize;
            Panel_azul.ResumeLayout(false);
            Panel_azul.PerformLayout();
            userPanel.ResumeLayout(false);
            userPanel.PerformLayout();
            passwordPanel.ResumeLayout(false);
            passwordPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        // --- Declaración de las variables para los nuevos controles ---
        private RoundPanel Panel_azul;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label passwordLabel;
        private RoundButton loginButton;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.TextBox textBoxPassword;
        private RoundPanel userPanel;
        private RoundPanel passwordPanel;
        private Label label1;
        
    }
}

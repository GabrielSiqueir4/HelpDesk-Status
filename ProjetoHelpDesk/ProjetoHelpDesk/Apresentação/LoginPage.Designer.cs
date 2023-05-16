namespace ProjetoHelpDesk.Apresentação
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            textBoxLogin = new TextBox();
            textBoxSenha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonEntrar = new Button();
            buttonSair = new Button();
            buttonCadastrar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(439, 110);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(222, 23);
            textBoxLogin.TabIndex = 0;
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(439, 191);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(222, 23);
            textBoxSenha.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(437, 73);
            label1.Name = "label1";
            label1.Size = new Size(47, 18);
            label1.TabIndex = 2;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(437, 158);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 3;
            label2.Text = "Senha";
            // 
            // buttonEntrar
            // 
            buttonEntrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEntrar.Location = new Point(439, 262);
            buttonEntrar.Name = "buttonEntrar";
            buttonEntrar.Size = new Size(95, 26);
            buttonEntrar.TabIndex = 4;
            buttonEntrar.Text = "Entrar";
            buttonEntrar.UseVisualStyleBackColor = true;
            buttonEntrar.Click += buttonEntrar_Click;
            // 
            // buttonSair
            // 
            buttonSair.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSair.Location = new Point(566, 262);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(95, 26);
            buttonSair.TabIndex = 5;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = true;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastrar.Location = new Point(467, 325);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(140, 29);
            buttonCadastrar.TabIndex = 6;
            buttonCadastrar.Text = "Cadastrar-Se";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(133, 52);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 52);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(83, 81);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(51, 232);
            label3.Name = "label3";
            label3.Size = new Size(289, 41);
            label3.TabIndex = 9;
            label3.Text = "HelpDesk Status";
            label3.Click += label3_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 46, 133);
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCadastrar);
            Controls.Add(buttonSair);
            Controls.Add(buttonEntrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxLogin);
            Name = "LoginPage";
            Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxLogin;
        private TextBox textBoxSenha;
        private Label label1;
        private Label label2;
        private Button buttonEntrar;
        private Button buttonSair;
        private Button buttonCadastrar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
    }
}
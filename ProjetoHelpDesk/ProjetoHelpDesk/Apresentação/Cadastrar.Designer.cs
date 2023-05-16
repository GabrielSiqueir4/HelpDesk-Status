namespace ProjetoHelpDesk.Apresentação
{
    partial class Cadastrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cadastrar));
            buttonCadastrar = new Button();
            label2 = new Label();
            label1 = new Label();
            textBoxSenha = new TextBox();
            textBoxLogin = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            textBoxConfirmarSenha = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCadastrar.Location = new Point(195, 347);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(140, 29);
            buttonCadastrar.TabIndex = 13;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(166, 184);
            label2.Name = "label2";
            label2.Size = new Size(53, 18);
            label2.TabIndex = 10;
            label2.Text = "Senha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(166, 99);
            label1.Name = "label1";
            label1.Size = new Size(47, 18);
            label1.TabIndex = 9;
            label1.Text = "Login";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(168, 217);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.PasswordChar = '*';
            textBoxSenha.Size = new Size(222, 23);
            textBoxSenha.TabIndex = 8;
            // 
            // textBoxLogin
            // 
            textBoxLogin.Location = new Point(168, 136);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(222, 23);
            textBoxLogin.TabIndex = 7;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(91, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(164, 260);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 16;
            label3.Text = "Confirmar Senha";
            label3.Click += label3_Click;
            // 
            // textBoxConfirmarSenha
            // 
            textBoxConfirmarSenha.Location = new Point(166, 293);
            textBoxConfirmarSenha.Name = "textBoxConfirmarSenha";
            textBoxConfirmarSenha.PasswordChar = '*';
            textBoxConfirmarSenha.Size = new Size(222, 23);
            textBoxConfirmarSenha.TabIndex = 15;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 46, 133);
            ClientSize = new Size(481, 450);
            Controls.Add(label3);
            Controls.Add(textBoxConfirmarSenha);
            Controls.Add(pictureBox1);
            Controls.Add(buttonCadastrar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxLogin);
            Name = "Cadastrar";
            Text = "Cadastrar";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonCadastrar;
        private Label label2;
        private Label label1;
        private TextBox textBoxSenha;
        private TextBox textBoxLogin;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox textBoxConfirmarSenha;
    }
}
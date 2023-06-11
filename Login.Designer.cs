namespace Icarus
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.Lbl_Senha = new System.Windows.Forms.Label();
            this.Lbl_Usuario = new System.Windows.Forms.Label();
            this.Txb_Senha = new System.Windows.Forms.TextBox();
            this.Txb_Usuario = new System.Windows.Forms.TextBox();
            this.Lbl_Bem_Vindo = new System.Windows.Forms.Label();
            this.Lbl_Acesso = new System.Windows.Forms.Label();
            this.Lbl_Copyright = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Btn_Entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Senha
            // 
            this.Lbl_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_Senha.AutoSize = true;
            this.Lbl_Senha.Location = new System.Drawing.Point(451, 481);
            this.Lbl_Senha.Name = "Lbl_Senha";
            this.Lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Senha.TabIndex = 0;
            this.Lbl_Senha.Text = "Senha";
            this.Lbl_Senha.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Lbl_Usuario
            // 
            this.Lbl_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Lbl_Usuario.AutoSize = true;
            this.Lbl_Usuario.Location = new System.Drawing.Point(451, 379);
            this.Lbl_Usuario.Name = "Lbl_Usuario";
            this.Lbl_Usuario.Size = new System.Drawing.Size(43, 13);
            this.Lbl_Usuario.TabIndex = 0;
            this.Lbl_Usuario.Text = "Usuário";
            this.Lbl_Usuario.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Txb_Senha
            // 
            this.Txb_Senha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Txb_Senha.Location = new System.Drawing.Point(450, 458);
            this.Txb_Senha.Name = "Txb_Senha";
            this.Txb_Senha.PasswordChar = '●';
            this.Txb_Senha.Size = new System.Drawing.Size(300, 20);
            this.Txb_Senha.TabIndex = 2;
            // 
            // Txb_Usuario
            // 
            this.Txb_Usuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Txb_Usuario.Location = new System.Drawing.Point(450, 358);
            this.Txb_Usuario.Name = "Txb_Usuario";
            this.Txb_Usuario.Size = new System.Drawing.Size(300, 20);
            this.Txb_Usuario.TabIndex = 1;
            // 
            // Lbl_Bem_Vindo
            // 
            this.Lbl_Bem_Vindo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Bem_Vindo.AutoSize = true;
            this.Lbl_Bem_Vindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Bem_Vindo.Location = new System.Drawing.Point(485, 190);
            this.Lbl_Bem_Vindo.Name = "Lbl_Bem_Vindo";
            this.Lbl_Bem_Vindo.Size = new System.Drawing.Size(233, 24);
            this.Lbl_Bem_Vindo.TabIndex = 0;
            this.Lbl_Bem_Vindo.Text = "Seja bem-vindo ao Icarus! ";
            // 
            // Lbl_Acesso
            // 
            this.Lbl_Acesso.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Lbl_Acesso.AutoSize = true;
            this.Lbl_Acesso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Acesso.Location = new System.Drawing.Point(450, 264);
            this.Lbl_Acesso.Name = "Lbl_Acesso";
            this.Lbl_Acesso.Size = new System.Drawing.Size(299, 18);
            this.Lbl_Acesso.TabIndex = 0;
            this.Lbl_Acesso.Text = "Por favor, faça login para acessar o sistema";
            // 
            // Lbl_Copyright
            // 
            this.Lbl_Copyright.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Copyright.AutoSize = true;
            this.Lbl_Copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Copyright.Location = new System.Drawing.Point(984, 722);
            this.Lbl_Copyright.Name = "Lbl_Copyright";
            this.Lbl_Copyright.Size = new System.Drawing.Size(162, 15);
            this.Lbl_Copyright.TabIndex = 0;
            this.Lbl_Copyright.Text = "Icarus Aviation technology  ©";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Icarus.Properties.Resources.Logo_200x200_Form;
            this.pictureBox1.Location = new System.Drawing.Point(30, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Btn_Entrar
            // 
            this.Btn_Entrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Btn_Entrar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Entrar.Location = new System.Drawing.Point(550, 524);
            this.Btn_Entrar.Name = "Btn_Entrar";
            this.Btn_Entrar.Size = new System.Drawing.Size(100, 26);
            this.Btn_Entrar.TabIndex = 4;
            this.Btn_Entrar.Text = "Entrar";
            this.Btn_Entrar.UseVisualStyleBackColor = true;
            this.Btn_Entrar.Click += new System.EventHandler(this.Btn_Entrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.Btn_Entrar);
            this.Controls.Add(this.Lbl_Copyright);
            this.Controls.Add(this.Lbl_Senha);
            this.Controls.Add(this.Lbl_Acesso);
            this.Controls.Add(this.Lbl_Usuario);
            this.Controls.Add(this.Txb_Senha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Txb_Usuario);
            this.Controls.Add(this.Lbl_Bem_Vindo);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Txb_Usuario;
        private System.Windows.Forms.TextBox Txb_Senha;
        private System.Windows.Forms.Label Lbl_Senha;
        private System.Windows.Forms.Label Lbl_Usuario;
        private System.Windows.Forms.Label Lbl_Acesso;
        private System.Windows.Forms.Label Lbl_Bem_Vindo;
        private System.Windows.Forms.Label Lbl_Copyright;
        private System.Windows.Forms.Button Btn_Entrar;
    }
}


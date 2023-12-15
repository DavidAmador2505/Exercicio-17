namespace Exercicio_17
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtNome = new TextBox();
            TxtEmail = new TextBox();
            TxtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Btn_Registar = new Button();
            button2 = new Button();
            button3 = new Button();
            cbPassword = new CheckBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(118, 60);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(100, 23);
            TxtNome.TabIndex = 0;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(118, 120);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(100, 23);
            TxtEmail.TabIndex = 1;
            TxtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(118, 175);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(100, 23);
            TxtPassword.TabIndex = 2;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 68);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 3;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 128);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 4;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 183);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // Btn_Registar
            // 
            Btn_Registar.Location = new Point(278, 193);
            Btn_Registar.Name = "Btn_Registar";
            Btn_Registar.Size = new Size(94, 39);
            Btn_Registar.TabIndex = 6;
            Btn_Registar.Text = "Registar Contas";
            Btn_Registar.UseVisualStyleBackColor = true;
            Btn_Registar.Click += Btn_Registar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(43, 274);
            button2.Name = "button2";
            button2.Size = new Size(85, 61);
            button2.TabIndex = 7;
            button2.Text = "Fechar Formulário";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(455, 293);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 8;
            button3.Text = "Página 2";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(118, 233);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(120, 19);
            cbPassword.TabIndex = 9;
            cbPassword.Text = "Mostrar Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 9);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 11;
            label4.Text = "label4";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(cbPassword);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Btn_Registar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPassword);
            Controls.Add(TxtEmail);
            Controls.Add(TxtNome);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtNome;
        private TextBox TxtEmail;
        private TextBox TxtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button Btn_Registar;
        private Button button2;
        private Button button3;
        private CheckBox cbPassword;
        private Label label4;
    }
}
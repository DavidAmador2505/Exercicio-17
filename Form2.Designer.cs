namespace Exercicio_17
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtPassword = new TextBox();
            TxtEmail = new TextBox();
            TxtNome = new TextBox();
            Btn_Registar = new Button();
            button2 = new Button();
            button3 = new Button();
            cbPassword = new CheckBox();
            ListaUtilizadores = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 69);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 131);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(77, 185);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 22);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "label4";
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(148, 177);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(100, 23);
            TxtPassword.TabIndex = 6;
            TxtPassword.TextChanged += TxtPassword_TextChanged;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(148, 123);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(100, 23);
            TxtEmail.TabIndex = 7;
            TxtEmail.TextChanged += TxtEmail_TextChanged;
            // 
            // TxtNome
            // 
            TxtNome.Location = new Point(148, 69);
            TxtNome.Name = "TxtNome";
            TxtNome.Size = new Size(100, 23);
            TxtNome.TabIndex = 8;
            TxtNome.TextChanged += TxtNome_TextChanged;
            // 
            // Btn_Registar
            // 
            Btn_Registar.Location = new Point(328, 202);
            Btn_Registar.Name = "Btn_Registar";
            Btn_Registar.Size = new Size(75, 47);
            Btn_Registar.TabIndex = 9;
            Btn_Registar.Text = "Registar Contas";
            Btn_Registar.UseVisualStyleBackColor = true;
            Btn_Registar.Click += Btn_Registar_Click;
            // 
            // button2
            // 
            button2.Location = new Point(77, 262);
            button2.Name = "button2";
            button2.Size = new Size(84, 40);
            button2.TabIndex = 10;
            button2.Text = "Fechar Formulários";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(451, 293);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 11;
            button3.Text = "Página 1";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cbPassword
            // 
            cbPassword.AutoSize = true;
            cbPassword.Location = new Point(148, 218);
            cbPassword.Name = "cbPassword";
            cbPassword.Size = new Size(120, 19);
            cbPassword.TabIndex = 12;
            cbPassword.Text = "Mostrar Password";
            cbPassword.UseVisualStyleBackColor = true;
            cbPassword.CheckedChanged += cbPassword_CheckedChanged;
            // 
            // ListaUtilizadores
            // 
            ListaUtilizadores.FormattingEnabled = true;
            ListaUtilizadores.ItemHeight = 15;
            ListaUtilizadores.Location = new Point(386, 34);
            ListaUtilizadores.Name = "ListaUtilizadores";
            ListaUtilizadores.Size = new Size(184, 139);
            ListaUtilizadores.TabIndex = 14;
            ListaUtilizadores.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ListaUtilizadores);
            Controls.Add(cbPassword);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Btn_Registar);
            Controls.Add(TxtNome);
            Controls.Add(TxtEmail);
            Controls.Add(TxtPassword);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtPassword;
        private TextBox TxtEmail;
        private TextBox TxtNome;
        private Button Btn_Registar;
        private Button button2;
        private Button button3;
        private CheckBox cbPassword;
        private ListBox ListaUtilizadores;
    }
}
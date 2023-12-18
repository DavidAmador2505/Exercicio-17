namespace Exercicio_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.ForeColor = Color.Black;
            this.Text = "Página Principal";
            label4.Text = ClasseUtilizador.Nome;

        }

        private void TxtNome_TextChanged(object sender, EventArgs e)
        {

        }



        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_TextChanged(object sender, EventArgs e)
        {
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void Btn_Registar_Click(object sender, EventArgs e)
        {
            string nome = TxtNome.Text;
            string email = TxtEmail.Text;
            string password = TxtPassword.Text;

            if (nome == "")
            {
                string Nome = "Nome";
            }

            if (email == "")
            {
                string Email = "Email";
            }

            if (password == "")
            {
                string Password = "Password";
                MessageBox.Show("Utilizador Registado");
            }

            else
            {
                MessageBox.Show("Não Preencheu" + nome + email + password);
            }

         

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FecharTodososForms.Fecharformularios();
            button3.ForeColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 Seguinte = new Form2();
            Seguinte.Show();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPassword.Checked)
            {
                TxtPassword.UseSystemPasswordChar = false;

            }

            else

            {
                TxtPassword.UseSystemPasswordChar = true;
            }
        }


        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
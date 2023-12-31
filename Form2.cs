﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio_17
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.Text = "Página Secundária";
            label4.Text = ClasseUtilizador.Nome;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

            if (nome=="")
            {
                string Nome = "Nome";
            }

            if (email=="")
            {
                string Email = "Email";
            }
          
            if (password=="")
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
            Form1 Anterior = new Form1();
            Anterior.Show();
            button2.ForeColor = Color.Black;
        }

        private void cbPassword_CheckedChanged(object sender, EventArgs e)
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ClasseUtilizador utilizador in ClasseUtilizador.ListaUtilizadores)
            {
                ListaUtilizadores.Items.Add("Nome:" + ClasseUtilizador.Nome);
                ListaUtilizadores.Items.Add("Email:" + ClasseUtilizador.Email);
                ListaUtilizadores.Items.Add("Password:" + ClasseUtilizador.Password);
            }

        }
    }
}

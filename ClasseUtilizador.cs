using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Exercicio_17
{
    public class ClasseUtilizador
    {
        public static string Nome;

        public static string Email;

        public static string Password;

        public ClasseUtilizador(string nome, string email, string password)
        {
            Nome = nome;
            Email = email;
            Password = password;

        }

        public static List<ClasseUtilizador> ListaUtilizadores = new List<ClasseUtilizador>();

        public static List (ClasseUtilizador.nome);

    }

}

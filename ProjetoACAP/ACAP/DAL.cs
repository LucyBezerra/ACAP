using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACAP
{
    public class DAL
    {
        static string servidor = "127.0.0.1"; //localhost
        static string porta = "5432"; //porta defaut
        static string userName = "postgres"; //nome do administrador
        static string password = "root"; //senha do administrador
        static string banco = "ProjetoACAP"; //nome do banco de dados


        NpgsqlConnection pgsqlConnection = null;
        string connectionString = null;

        public DAL()
        {
            connectionString = "Server=" + servidor + ";Port=" + porta + ";User Id=" + userName +
                ";Password=" + password + ";Database=" + banco + ";";
        }


            public void InserirPessoa(string nome, string sobrenome, string email, bool associado)
        {


            try {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connectionString))
                {
                    pgsqlConnection.Open();
                    string cmdInserir = String.Format("Insert Into Pessoa(nome, sobrenome, email, associado) values ('{0}', '{1}', '{2}', {3})", nome, sobrenome, email,associado);
                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                    pgsqlConnection.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

        }

    }
}


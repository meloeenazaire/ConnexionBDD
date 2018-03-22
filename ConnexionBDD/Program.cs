using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

namespace ConnexionBDD
{
    class Program
    {
        static void Main(string[] args)
        {
            string sCnx = "user=root password=siojjr database=basePersonne host=localhost";
            MySqlConnection connexion = new MySqlConnection(sCnx);
            connexion.Open();


            string sCmd = "insert into personne(id, nom, age) values(1, 'Albert', 21)";
            MySqlCommand cmd = new MySqlCommand(sCmd, connexion);
            cmd.ExecuteNonQuery();
            connexion.Close();

        }
    }
}

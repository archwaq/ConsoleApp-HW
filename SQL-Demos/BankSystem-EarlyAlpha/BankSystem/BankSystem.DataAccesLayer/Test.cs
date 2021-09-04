using BankSystem.BisinessObject;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace BankSystem.DataAccesLayer
{
    class Test
    {
        static void Main(string[] args)
        {
            ReadAllClients();

            //UpdateClient();
            //CreateClient();
            //DeleteClient();
        }

        private static void CreateClient()
        {
            Client client = new Client();

            using MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=sql_banking;port=3306;password=t62HMZ6vACtPpxEq");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO `clients` (`client_id`,`firstname`, `surname`, `familyname`, `yearofbirth`) VALUES(@client_id,@firstname,@surname,@familyname,@yearofbirth)", con);

            Console.Write("Insert Id: ");
            client.Id = int.Parse(Console.ReadLine());
            Console.Write("Insert First Name: ");
            client.FirstName = Console.ReadLine();
            Console.Write("Insert Sur Name: ");
            client.SurName = Console.ReadLine();
            Console.Write("Insert Family Name: ");
            client.FamilyName = Console.ReadLine();
            Console.Write("Insert Date: ");
            client.YearOfBirth = Convert.ToDateTime(Console.ReadLine());

            cmd.Parameters.Add("@client_id", MySqlDbType.Int32).Value = client.Id;
            cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = client.FirstName;
            cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = client.SurName;
            cmd.Parameters.Add("@familyname", MySqlDbType.VarChar).Value = client.FamilyName;
            cmd.Parameters.Add("@yearofbirth", MySqlDbType.Date).Value = client.YearOfBirth;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private static void ReadAllClients()
        {
            List<Client> clients = new List<Client>();

            using MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=sql_banking;port=3306;password=t62HMZ6vACtPpxEq");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from clients", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Client client = new Client();
                client.Id = Convert.ToInt32(reader["client_id"]);
                client.FirstName = reader["firstname"].ToString();
                client.SurName = reader["surname"].ToString();
                client.FamilyName = reader["familyname"].ToString();
                client.YearOfBirth = Convert.ToDateTime(reader["yearofbirth"]);

                clients.Add(client);

            }
            reader.Close();


            foreach (var client in clients)
            {
                Console.WriteLine($"{client.Id} {client.FirstName} {client.SurName} {client.FamilyName} {client.YearOfBirth}");
            }
        }

        private static void UpdateClient()
        {
            Client client = new Client();

            using MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=sql_banking;port=3306;password=t62HMZ6vACtPpxEq");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("UPDATE `clients` SET firstname =@firstname, surname =@surname, familyname =@familyname, yearofbirth =@yearofbirth WHERE client_id =@client_id", con);

            Console.Write("Insert First Name: ");
            client.FirstName = Console.ReadLine();
            Console.Write("Insert Sur Name: ");
            client.SurName = Console.ReadLine();
            Console.Write("Insert Family Name: ");
            client.FamilyName = Console.ReadLine();
            Console.Write("Insert Date: ");
            client.YearOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.Write("Insert Id: ");
            client.Id = int.Parse(Console.ReadLine());


            cmd.Parameters.Add("@firstname", MySqlDbType.VarChar).Value = client.FirstName;
            cmd.Parameters.Add("@surname", MySqlDbType.VarChar).Value = client.SurName;
            cmd.Parameters.Add("@familyname", MySqlDbType.VarChar).Value = client.FamilyName;
            cmd.Parameters.Add("@yearofbirth", MySqlDbType.Date).Value = client.YearOfBirth;

            cmd.Parameters.Add("@client_id", MySqlDbType.Int32).Value = client.Id;

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private static void DeleteClient()
        {
            Client client = new Client();

            using MySqlConnection con = new MySqlConnection("server=localhost;user=root;database=sql_banking;port=3306;password=t62HMZ6vACtPpxEq");
            con.Open();
            MySqlCommand cmd = new MySqlCommand("DELETE FROM `clients` WHERE client_id =@client_id", con);

            Console.Write("Insert Id(Delete): ");
            client.Id = int.Parse(Console.ReadLine());

            cmd.Parameters.Add("@client_id", MySqlDbType.Int32).Value = client.Id;

            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}

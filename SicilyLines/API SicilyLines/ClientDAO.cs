using MySql.Data.MySqlClient;

namespace APISicily
{
    public class ClientDAO
    {


        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Insertion d'un employé

        public static void deleteClient(int id)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("delete from client where id = " + id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        // Mise à jour d'un employé

        public static void updateClient(Client c)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("update client set adresse= '" + c.Adresse + "' and set cp='"+ c.Cp + "' where id = " + c.Id);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        // Mise à jour d'un employé

        public static void insertClient(Client u)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                string req = "insert into client values (" + u.Id + ",'" + u.Login + "','" + u.Mdp + "','" + u.Adresse + "','" + u.Cp + "')";


                Ocom = maConnexionSql.reqExec(req);


                int i = Ocom.ExecuteNonQuery();



                maConnexionSql.closeConnection();



            }

            catch (Exception emp)
            {

                throw (emp);
            }


        }

        // Mise à jour d'un employé

        public static Client trouveClient(int id)
        {

            try
            {


                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();

                string req = "Select * from client where id = " + id;

                Ocom = maConnexionSql.reqExec(req);

                MySqlDataReader reader = Ocom.ExecuteReader();

                Client c = null;



                // Tant qu'il existe une ligne dans la table
                while (reader.Read())
                {
                    // récupération de la ligne
                    int num = (int)reader.GetValue(0);
                    string login = (string)reader.GetValue(1);
                    string mdp = (string)reader.GetValue(2);
                    string adresse = (string)reader.GetValue(3);
                    string cp = (string)reader.GetValue(4);

                    //Instanciation d'un Employe
                    c = new Client(num, login, mdp, adresse, cp);

                }

                // fermeture du reader
                reader.Close();

                //fermeture de la connexion
                maConnexionSql.closeConnection();

                // Envoi de l'employé au Manager
                return (c);


            }

            catch (Exception ex)
            {

                throw (ex);

            }

        }

        // Récupération de la liste des employés
        public static List<Client> getClients()
        {

            List<Client> lc = new List<Client>();

            try
            {
                // Pour se connecter à la base
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                // ouverture de la connexion
                maConnexionSql.openConnection();

                // exécution de la requete avec l'objer Command
                Ocom = maConnexionSql.reqExec("Select * from client");

                // lire les données ligne par ligne avec le reader

                MySqlDataReader reader = Ocom.ExecuteReader();

                Client c;



                // Tant qu'il existe une ligne dans la table
                while (reader.Read())
                {
                    // récupération de la ligne
                    int num = (int)reader.GetValue(0);
                    string login = (string)reader.GetValue(1);
                    string mdp = (string)reader.GetValue(2);
                    string adresse = (string)reader.GetValue(3);
                    string cp = (string)reader.GetValue(4);

                    //Instanciation d'un Employe
                    c = new Client(num, login, mdp, adresse, cp);

                    // Ajout de cet employe à la liste 
                    lc.Add(c);


                }


                // fermeture du reader
                reader.Close();

                //fermeture de la connexion
                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception emp)
            {

                throw (emp);

            }


        }
    }
}

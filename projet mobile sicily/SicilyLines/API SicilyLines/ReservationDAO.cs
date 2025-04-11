using APISicily;
using MySql.Data.MySqlClient;

namespace API_SicilyLines
{
    public class ReservationDAO
    {



        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "sicilylines";

        private static string uid = "root";

        private static string mdp = "";



        private static ConnexionSql maConnexionSql;


        private static MySqlCommand Ocom;


        // Récupération de la liste des employés
        public static List<Reservation> getReservationsClient(int client)
        {

            List<Reservation> lr = new List<Reservation>();

            try
            {
                // Pour se connecter à la base
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                // ouverture de la connexion
                maConnexionSql.openConnection();

                // exécution de la requete avec l'objer Command
                Ocom = maConnexionSql.reqExec("Select * " +
                                              "from reservation join client join traversee " +
                                              "on client.id = reservation.idClient " +
                                              "and traversee.id = reservation.idTraversee " +
                                              "where idClient = " + client);


                MySqlDataReader reader = Ocom.ExecuteReader();

                Reservation r = null;




                while (reader.Read())
                {
                    int idReservation = (int)reader.GetValue(0);
                    int idClient = (int)reader.GetValue(1);
                    int idTraversee = (int)reader.GetValue(2);
                    string dateTraversee = (string)reader.GetValue(3);


                    r = new Reservation(idReservation, idClient, idTraversee, dateTraversee);

                    lr.Add(r);

                }

                // fermeture du reader
                reader.Close();

                //fermeture de la connexion
                maConnexionSql.closeConnection();

                return (lr);

            }

            catch (Exception reserv)
            {

                throw (reserv);

            }


        }
    }
}

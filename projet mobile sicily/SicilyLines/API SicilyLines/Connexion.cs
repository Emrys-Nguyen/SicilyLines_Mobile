﻿using MySql.Data.MySqlClient;

namespace APISicily
{
    public class ConnexionSql
    {

        private static ConnexionSql connection = null;

        private MySqlConnection mysqlCn;

        private static readonly object mylock = new object();

        private string connString;

        // Constructeur privé pour n'avoir qu'une seule con nexion à la fois
        private ConnexionSql(string unProvider, string uneDataBase, string unUid, string unMdp)
        {


            try
            {
                connString = "SERVER=" + unProvider + ";" + "DATABASE=" +
                uneDataBase + ";" + "UID=" + unUid + ";" + "PASSWORD=" + unMdp + ";";
                try
                {
                    mysqlCn = new MySqlConnection(connString);
                }
                catch (Exception emp)
                {
                    throw (emp);
                }
            }
            catch (Exception emp)
            {
                throw (emp);
            }



        }



        /**
         * méthode de création d'une instance de connexion si elle n'existe pas (singleton)
         */
        public static ConnexionSql getInstance(string unProvider, string uneDataBase, string unUid, string unMdp)
        {

            lock ((mylock))
            {

                try
                {


                    if (null == connection)
                    { // Premier appel
                        connection = new ConnexionSql(unProvider, uneDataBase, unUid, unMdp);

                    }

                }
                catch (Exception emp)
                {
                    throw (emp);


                }
                return connection;

            }
        }





        /**
         * Ouverture de la connexion
         */
        public void openConnection()
        {
            try
            {
                if(mysqlCn.State == System.Data.ConnectionState.Closed)
                    mysqlCn.Open();
            }
            catch (Exception emp)
            {
                throw (emp);
            }
        }

        /**
         * Fermeture de la connexion
         */
        public void closeConnection()
        {
            if (mysqlCn.State == System.Data.ConnectionState.Open)
                mysqlCn.Close();
        }

        /**
         * Exécutiuon d'une requête
         */
        public MySqlCommand reqExec(string req)
        {
            MySqlCommand mysqlCom = new MySqlCommand(req, this.mysqlCn);
            return (mysqlCom);
        }

    }
}

namespace SicilyLines
{
    public class Client
    {

        private int id;
        private string login;
        private string mdp;
        private string nom;
        private string prenom;
        private string adresse;
        private string cp;



        // Les nouveaux get et set version C# et VS.Net. Remplacent getLogin() et setLogin(string unLogin)
        // remplace getId()
        public int Id { get => id; set => id = value; }
        public string Login { get => login; set => login = value; }
        public string Mdp { get => mdp; set => mdp = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Cp { get => cp; set => cp = value; }
        public string Adresse { get => adresse; set => adresse = value; }

        // Constructeur de la classe Employe
        public Client(int unId, string unLogin, string unMdp, string unNom, string unPrenom, string uneAdresse, string unCp)
        {
            this.id = unId;
            this.login = unLogin;
            this.mdp = unMdp;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.adresse = uneAdresse;
            this.cp = unCp;
        }

        // Constructeur vide


        public Client(int unId, string unLogin)
        {
            this.id = unId;

            this.login = unLogin;

            this.mdp = "";

            this.nom = "";

            this.prenom = "";

            this.adresse = "";

            this.cp = "";

        }

        // pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.id + " Login : " + this.login + " Mot de Passe : " + this.mdp + " Adresse : " + this.adresse + " CP : " + this.cp;
        }
    }
}

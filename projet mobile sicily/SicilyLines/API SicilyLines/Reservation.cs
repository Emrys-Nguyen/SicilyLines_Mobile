namespace API_SicilyLines
{
    public class Reservation
    {

        private int id;
        private int idClient;
        private int idTraversee;
        private string dateTraversee;




        // Les nouveaux get et set version C# et VS.Net. Remplacent getLogin() et setLogin(string unLogin)
        // remplace getId()
        public int Id { get => id; set => id = value; }
        public int IdClient { get => idClient; set => idClient = value; }
        public int IdTraversee { get => idTraversee; set => idTraversee = value; }
        public string DateTraversee { get => dateTraversee; set => dateTraversee = value; }


        // Constructeur de la classe Employe
        public Reservation(int unId, int unIdClient, int unIdTraversee, string uneDateTraversee)
        {
            this.id = unId;
            this.idClient = unIdClient;
            this.idTraversee = unIdTraversee;
            this.dateTraversee = uneDateTraversee;

        }


        // pour afficher la liste par la suite
        public string Description
        {
            get => "Id : " + this.id + " Id Client : " + this.idClient + " Id Traversée : " + this.idTraversee + " Date Traversée : " + this.dateTraversee;
        }
    }
}

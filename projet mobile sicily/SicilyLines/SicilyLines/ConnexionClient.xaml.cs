using Newtonsoft.Json;

namespace SicilyLines
{
    public partial class ConnexionClient : ContentPage
    {

        public ConnexionClient()
        {
            InitializeComponent();
        }
        private async void OnClickButtonConnexion(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            var restURL = "http://localhost:5179/clientsitems/";
            client.BaseAddress = new Uri(restURL);
            HttpResponseMessage response = await client.GetAsync(restURL);

            if (response.IsSuccessStatusCode)
            {
                bool res = false;
                var content = await response.Content.ReadAsStringAsync();
                var Items = JsonConvert.DeserializeObject<dynamic>(content);
                int idClient = 0;


                foreach (var item in Items)
                {
                    var login = item.login;
                    var mdp = item.mdp;

                    if (login == Login.Text && mdp == Password.Text)
                    {

                        idClient = item.id;
                        res = true;
                    }

                }
                if (res)
                {
                    await Navigation.PushAsync(new affichage_button(idClient));
                }
                else
                {
                    await DisplayAlert("Alerte", "Connexion user refusée", "Cancel");
                }
            }
            else
            {
                await DisplayAlert("Alerte", "Pas de connexion avec l'API", "Cancel");
            }
        }
    }
}

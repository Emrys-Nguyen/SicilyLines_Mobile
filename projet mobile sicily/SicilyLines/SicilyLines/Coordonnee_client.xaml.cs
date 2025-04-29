using Newtonsoft.Json;

namespace SicilyLines;

public partial class Coordonnee_client : ContentPage
{
    private int idClient;

    public Coordonnee_client(int idClient)
	{
		InitializeComponent();
        this.idClient = idClient;
        loadDataFromAPI();
    }
    public async void loadDataFromAPI()
    {
        HttpClient client = new HttpClient();
        var restURL = "http://localhost:5179/clientsitems/"+idClient;
        client.BaseAddress = new Uri(restURL);
        HttpResponseMessage response = await client.GetAsync(restURL);
        var content = await response.Content.ReadAsStringAsync();
        var Item = JsonConvert.DeserializeObject<dynamic>(content);
        NomLabel.Text = "Nom : " + Item.nom;
        PrenomLabel.Text = "Prénom : " + Item.prenom;

    }
    public async void loadDataFromLocalAssets()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("client.json");

        using var reader = new StreamReader(stream);

        var content = await reader.ReadToEndAsync();

        var Items = JsonConvert.DeserializeObject<List<Client>>(content);

    }
}
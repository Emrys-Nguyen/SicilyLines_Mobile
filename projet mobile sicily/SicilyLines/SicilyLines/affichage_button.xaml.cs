namespace SicilyLines;

public partial class affichage_button : ContentPage
{
    private int idClient;
	public affichage_button(int idClient)
	{
        this.idClient = idClient;
        InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        //reservation

    }

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        //coordonnées
        await Navigation.PushAsync(new Coordonnee_client(idClient));

    }
}
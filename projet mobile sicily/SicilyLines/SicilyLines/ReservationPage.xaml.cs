using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace SicilyLines
{
    public partial class ReservationPage : ContentPage
    {
        public ReservationPage(int idLogin)
        {
            InitializeComponent();
            GetReservations(idLogin);

        }

        public async void GetReservations(int id)
        {
            HttpClient client = new HttpClient();
            var restURL = "http://localhost:5179/reservationsitems/"+id;
            client.BaseAddress = new Uri(restURL);
            HttpResponseMessage response = await client.GetAsync(restURL);

            if (response.IsSuccessStatusCode)
            {
                List<Reservation> reservationsExpirees = new List<Reservation>();
                List<Reservation> reservationsValidees = new List<Reservation>();

                var content = await response.Content.ReadAsStringAsync();
                var Items = JsonConvert.DeserializeObject<List<Reservation>>(content);
                DateTime localDate = DateTime.Now;
                Items = Items.Where(reservation => reservation.IdClient == id).ToList();
                foreach (var item in Items)
                {
                    Reservation reservationNew = new Reservation(item.Id, item.IdClient, item.IdTraversee, item.DateTraversee);
                    var date = DateTime.ParseExact(reservationNew.DateTraversee, "dd/mm/yyyy", System.Globalization.CultureInfo.InvariantCulture);
                    if (DateTime.Compare(date,localDate)<0)
                    {
                        reservationsExpirees.Add(reservationNew);
                    } else
                    {
                        reservationsValidees.Add(reservationNew);
                    }

                }
                maListViewReservationExpirees.ItemsSource = reservationsExpirees;
                maListViewReservationValidees.ItemsSource = reservationsValidees;
            }
            else
            {
                await DisplayAlert("Alerte", "Pas de connexion avec l'API", "Cancel");
            }
        }
    }
}

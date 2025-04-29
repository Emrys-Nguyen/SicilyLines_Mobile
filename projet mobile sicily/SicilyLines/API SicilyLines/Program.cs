using API_SicilyLines;
using APISicily;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/reservationsitems/{id}", (int id) =>
    ReservationDAO.getReservationsClient(id)
        is List<Reservation> r
            ? Results.Ok(r)
            : Results.NotFound());

app.MapGet("/clientsitems", () => ClientDAO.getClients());


app.MapGet("/clientsitems/{id}", (int id) =>
    ClientDAO.trouveClient(id)
        is Client u
            ? Results.Ok(u)
            : Results.NotFound());

app.MapPost("/clientsitems", (Client u) =>
{
    ClientDAO.insertClient(u);


});

app.MapPut("/clientsitems", (Client u) =>
{
    ClientDAO.updateClient(u);


});

app.MapDelete("/clientsitems/{id}", (int id) =>
{

    ClientDAO.deleteClient(id);


});
app.Run();

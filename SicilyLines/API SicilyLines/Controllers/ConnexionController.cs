using Microsoft.AspNetCore.Mvc;
using APISicily;

namespace API_SicilyLines.Controllers;

[ApiController]
[Route("[controller]")]
public class ConnexionController : ControllerBase
{

    private readonly ILogger<ConnexionController> _logger;

    public ConnexionController(ILogger<ConnexionController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUser/{pseudo}/{pass}")]
    public bool Get(string pseudo, string pass)
    {
        List<User> users = UserDAO.getUsers();
        foreach (var user in users)
        {
            if (pseudo == user.Login && pass == user.Mdp)
            {
                return true;
            }
        }
        return false;
    }
}

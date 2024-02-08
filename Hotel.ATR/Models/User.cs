
namespace Hotel.ATR.Models;

public class User
{
    public string email { get; set; }
    public string name { get; set; }

    public User(string email, string name)
    {
        this.email = email ?? throw new ArgumentNullException(nameof(email));
        this.name = name ?? throw new ArgumentNullException(nameof(name));
    }
}

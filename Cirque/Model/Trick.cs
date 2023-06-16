namespace Cirque.Model;

//Enum to properly know what type of trick it is
public enum TrickType
{
    Song,
    Acrobatic
}

//Class to handle the name and the trick type in order to OnTrickShowed to work correctly
public class Trick
{
    public string? Name { get; set; }
    public readonly TrickType TrickType;

    public Trick(string name, TrickType trickType)
    {
        Name = name;
        TrickType = trickType;
    }
}
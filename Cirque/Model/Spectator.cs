namespace Cirque.Model;

public class Spectator
{
    private static Spectator? _instance;

    private Spectator() { }
    
    public static Spectator GetInstance()
    {
        if (_instance == null) _instance = new Spectator();
        return _instance;
    }

    //Event method called when the Action method from the class Monkey is called that 
    // manage to send the proper reaction depending on the type of the trick
    public void OnTrickShowed(object source, TrickEventArgs trickEventArgs)
    {
        if (trickEventArgs.Trick is {TrickType: TrickType.Song}) 
            Console.WriteLine("Spectator: *Siffle*");
        if (trickEventArgs.Trick is {TrickType: TrickType.Acrobatic}) 
            Console.WriteLine("Spectator: *Applaudit*");
    }
}
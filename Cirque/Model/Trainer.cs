namespace Cirque.Model;

public class Trainer
{
    private string Name { get; set; }
    private Monkey? Monkey { get; set; }
    private readonly List<Trick> _tricksList = new List<Trick>();

    //Create an instance of spectator inside of the main class to keep control of the number of instance of this class
    private readonly Spectator? _spectator = Spectator.GetInstance();
    
    //Create tricks inside the constructor of the class Trainer and assigned the created class Monkey to the respective trainer 
    public Trainer(String name, Monkey monkey)
    {
        Name = name;
        Monkey = monkey;
        _tricksList.Add(new Trick("Trompette", TrickType.Song));
        _tricksList.Add(new Trick("Guitare", TrickType.Song));
        _tricksList.Add(new Trick("Batterie", TrickType.Song));
        _tricksList.Add(new Trick("Saut", TrickType.Acrobatic));
        _tricksList.Add(new Trick("Roulade", TrickType.Acrobatic));
        _tricksList.Add(new Trick("Plongeons sur le bitum", TrickType.Acrobatic));
    }

    //Method that handle subscribing and unsubscribing the events from the called Action method 
    public void AskTrick()
    {
        Console.WriteLine($"{Name} demande à {Monkey?.GetName()} de faire ces tours : ");
        foreach (var trick in _tricksList)
        {
            if (Monkey == null || _spectator == null) continue;
            Monkey.ShowingTrick -= _spectator.OnTrickShowed;
            Monkey.ShowingTrick += _spectator.OnTrickShowed;
            Monkey?.Action(trick);
        }
    }
}
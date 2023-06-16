namespace Cirque.Model;

public class TrickEventArgs : EventArgs
{
    public Trick? Trick { get; init; }
}
public sealed class Monkey
{
    private string? Name { get; set; }

    public Monkey(string name)
    {
        Name = name;
    }
    
    //Delegate to handle the listener of the event
    public delegate void SpectatorReactionHandler(object source, TrickEventArgs trick);
    //Event to send to the listener that the event passed
    public event SpectatorReactionHandler? ShowingTrick;

    //Get the name of the monkey
    public string? GetName()
    {
        return Name;
    }
    
    //Play the current trick from the parameters
    public void Action(Trick trick)
    {
        Console.WriteLine($"{Name} commence le tour {trick.TrickType}... {trick.Name}");
        Thread.Sleep(2000);
        
        OnTrickShowed(trick);
    }
    
    //Method for the subscribe of the event
    private void OnTrickShowed(Trick trick)
    {
        ShowingTrick?.Invoke(this, new TrickEventArgs(){ Trick = trick });
    }
}
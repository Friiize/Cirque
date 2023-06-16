namespace Cirque.Model;

public class Spectacle
{
    //Initialize the trainers of the monkey with a List
    private const int MaxTrainer = 2;
    private readonly List<Trainer>? _trainers = new List<Trainer>();

    //Create an instance of the class made private to prevent direct access from outside of the class and static to be
    //accessible to GetInstance function
    private static Spectacle? _instance;

    private Spectacle()
    {
        //Create 2 instances of the class Trainer with their respective monkey
        for (int i = 0; i < MaxTrainer; i++) _trainers?.Add(new Trainer(
            "Trainer" + i, 
            new Monkey("Monkey" + i
            )));
    }

    //Method used for the singleton pattern preventing more than one instance of the class Spectacle
    public static Spectacle GetInstance()
    {
        if (_instance == null) _instance = new Spectacle();
        return _instance;
    }

    //Method for the runtime of the Program, everything showed in the console, start here.
    public void ShowTime()
    {
        //Handle possible exception of the program
        try
        {
            if (_trainers == null) return;
            Console.WriteLine(
                $"Spectator croise {_trainers.Count} avec leur singe respective. Ils veulent absolument montrer leur numéros");
            foreach (var trainer in _trainers)
                trainer.AskTrick();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

}
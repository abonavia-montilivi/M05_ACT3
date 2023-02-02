internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleKeyInfo tecla;
        do
        {
            Console.Clear();
            ShowOptions();
            tecla = Console.ReadKey();
            Console.Clear();
            switch (tecla.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    MusicCuriosities();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    DadJokes();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Science();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    DrivingSchool();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Riddles();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Astronomy();
                    break;
                case ConsoleKey.D7:
                case ConsoleKey.NumPad7:
                    History();
                    break;
                case ConsoleKey.D8:
                case ConsoleKey.NumPad8:
                    Cinema();
                    break;
                case ConsoleKey.D9:
                case ConsoleKey.NumPad9:
                    Geography();
                    break;
                 case ConsoleKey.D0:
                case ConsoleKey.NumPad0:
                    MsgNextScreen("PRESS ANY KEY TO EXIT");
                    break;
                default:
                    MsgNextScreen("Error. Prem una tecla per tornar al menú...");
                    break;
            }
        } while (tecla.Key != ConsoleKey.D0);
    }

    public static void ShowOptions()
    {
        Console.Clear();
        Console.WriteLine("1 - MUSIC CURIOSITIES");
        Console.WriteLine("2 - DAD JOKES");
        Console.WriteLine("3 - SCIENCE");
        Console.WriteLine("4 - DRIVING SCHOOL");
        Console.WriteLine("5 - RIDDLES");
        Console.WriteLine("6 - ASTRONOMY");
        Console.WriteLine("7 - HISTORY");
        Console.WriteLine("8 - CINEMA");
        Console.WriteLine("9 - GEOGRAPHY");
        Console.WriteLine("0 - EXIT");
    }
    public static void MsgNextScreen(string msg)
    {
        Console.WriteLine(msg);
        Console.ReadKey();
    }
    //Arnau



    //Eloy




    //Jaume
    public static void History()
    {
        int sum = 0;
        char rightAnswer = 'd';

        Console.Write("What was the triggering cause of World War I?" +
        "\n\na) the Night of the Broken Glass in 1938" +
        "\nb) The rise to power of Kemal Atatürk in Turkey in 1920" +
        "\nc) The Italian invasion of Ethiopia in 1935" +
        "\nd) The assassination of Archduke Franz Ferdinand of Austria in 1914" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'c';
        
        Console.Write("According to the legend, who founded Rome?" +
        "\n\na) Achilles and Odysseus" +
        "\nb) Alexander the Great" +
        "\nc) Romulus and Remus" +
        "\nd) Athena and Kratos" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)}");

        NextQuestion();

        rightAnswer = 'a';

        Console.Write("The Fall of the Berlin Wall took place in..." +
        "\n\na) 1989 " +
        "\nb) 1977 " +
        "\nc) 1994 " +
        "\nd) 1966" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'b';

        Console.Write("Who is the most famous inquisitor of the Spanish inquisition?" +
        "\n\na) Luis de Aliaga" +
        "\nb) Tomás de Torquemada" +
        "\nc) Adriano de Utrecht" +
        "\nd) Gaspar de Quiroga" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'c';

        Console.Write("What was the most famous nickname of Louis XVI (France - XVIII century)?" +
        "\n\na) The Bewitched" +
        "\nb) The Untouchable" +
        "\nc) The Sun King" +
        "\nd) The Mad King" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        MsgNextScreen("\nPress any key to return to the menu...");  
    }

    public static void Cinema()
    {
        int sum = 0;
        char rightAnswer = 'b';

        Console.Write("Who said 'Look to my coming on the first light of the fifth day, at dawn look to the east'?" +
        "\n\na) Aragorn" +
        "\nb) Gandalf the White" +
        "\nc) Saruman" +
        "\nd) Gandalf the Grey" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'd';

        Console.Write("Which one of these movies doesn't belong to Tarantino as a Director?" +
        "\n\na) Death Proof" +
        "\nb) From Dusk Till Dawn" +
        "\nc) Jackie Brown" +
        "\nd) Natural Born Killers" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'd';

        Console.Write("Which film has won the most Oscars in history?" +
        "\n\na) Lord Of the Rings: The Return of the King" +
        "\nb) Titanic" +
        "\nc) Ben Hur" +
        "\nd) All are correct" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'a';

        Console.Write("what year was the premiere of the movie 'Nightmare before christmas'?" +
        "\n\na) 1993" +
        "\nb) 1984" +
        "\nc) 1975" +
        "\nd) 2000" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'c';

        Console.Write("What is the iconic car brand from the movie 'Back to the Future?" +
        "\n\na) Chevrolet" +
        "\nb) Pontiac" +
        "\nc) Delorean" +
        "\nd) Dodge" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        MsgNextScreen("\nPress any key to return to the menu...");
    }

    public static void Geography()
    {
        int sum = 0;
        char rightAnswer = 'a';

        Console.Write("Which is the largest country in the world?" +
        "\n\na) Russia" +
        "\nb) Brazil" +
        "\nc) Canada" +
        "\nd) China" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'a';

        Console.Write("When is the best time to see the northern lights??" +
        "\n\na) From September to April" +
        "\nb) From December to March" +
        "\nc) From August to November" +
        "\nd) Just in February" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'b';

        Console.Write("which is the highest mountain in Spain?" +
        "\n\na) Maladeta" +
        "\nb) Teide" +
        "\nc) Aneto" +
        "\nd) La Alcazaba" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'd';

        Console.Write("Which city once had the name 'Leningrad'?" +
        "\n\na) Volgograd" +
        "\nb) Moscow" +
        "\nc) Krasnodar" +
        "\nd) St.Petersburg" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        NextQuestion();

        rightAnswer = 'b';

        Console.Write("Which European river flows through 10 different countries?" +
        "\n\na) Rin river" +
        "\nb) Danube river" +
        "\nc) Volga river" +
        "\nd) Sena river" +
        "" +
        "\n\nYour answer → ");

        Console.WriteLine($"Punctuation: {sum += Punctuation(rightAnswer)} points ");

        MsgNextScreen("\nPress any key to return to the menu...");
    }

    public static int Punctuation(char rightAnswer)
    {
        char option=RightFormatOption();

        if (option == rightAnswer)
        {
            return 1;
        }
        else
        {
            return 0;
        }
    }

    public static char RightFormatOption ()
    {
        bool correct = false;
        char option =' ';

        do
        {
            try
            {
                string valor = Console.ReadLine();
                if (valor.Length != 1)
                {
                    Console.WriteLine("Please, enter just one character...");
                }
                else
                {
                    option = Convert.ToChar(valor);
                    if (option >= 'a' && option <= 'd') correct = true;
                    else Console.WriteLine("Please, choose one of the options above...");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        } while (!correct);       

        return option;
    }

    public static void NextQuestion()
    {
        Console.WriteLine("\nPress any key for the next question!");
        Console.ReadKey();
        Console.Clear();
    }
}
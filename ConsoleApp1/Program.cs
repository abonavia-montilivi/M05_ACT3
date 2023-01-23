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
                //case ConsoleKey.D1:
                //case ConsoleKey.NumPad1:
                //    MusicCuriosities();
                //    break;
                //case ConsoleKey.D2:
                //case ConsoleKey.NumPad2:
                //    DadJokes();
                //    break;
                //case ConsoleKey.D3:
                //case ConsoleKey.NumPad3:
                //    Science();
                //    break;
                //case ConsoleKey.D4:
                //case ConsoleKey.NumPad4:
                //    DrivingSchool();
                //    break;
                //case ConsoleKey.D5:
                //case ConsoleKey.NumPad5:
                //    Riddles();
                //    break;
                //case ConsoleKey.D6:
                //case ConsoleKey.NumPad6:
                //    Astronomy();
                //    break;
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
        try
        {
            char option;
            int punctuation=0;

            Console.WriteLine("Question....." +
            "\na) Option 1 " +
            "\nb) Option 2 " +
            "\nc) Option 3 " +
            "\nd) Option4");

            Console.Write("\nYour answer → ");
            option = Convert.ToChar(Console.ReadLine());

            if(option == 'a')
            {
                Console.WriteLine("\nRight answer");
                punctuation++;
            }
            else
            {
                Console.WriteLine("\nWrong answer");
            }

            Console.WriteLine("\nPress any key for the next question!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n2) Question....." +
            "\na) Option 1 " +
            "\nb) Option 2 " +
            "\nc) Option 3 " +
            "\nd) Option4");

            Console.Write("\nYour answer → ");
            option = Convert.ToChar(Console.ReadLine());

            if (option == 'a')
            {
                Console.WriteLine("\nRight answer");
                punctuation++;
            }
            else
            {
                Console.WriteLine("\nWrong answer");
            }

            Console.WriteLine("\nPress any key for the next question!");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("\n3) Question....." +
            "\na) Option 1 " +
            "\nb) Option 2 " +
            "\nc) Option 3 " +
            "\nd) Option4");

            Console.Write("\nYour answer → ");
            option = Convert.ToChar(Console.ReadLine());

            if (option == 'a')
            {
                Console.WriteLine("\nRight answer");
                punctuation++;
            }
            else
            {
                Console.WriteLine("\nWrong answer");
            }

            Console.WriteLine($"\nPunctuation → {punctuation}");

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("Press any key to return to the menu...");
        }
    }

    public static void Cinema()
    {

    }

    public static void Geography()
    {

    }





}
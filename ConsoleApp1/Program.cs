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
                //case ConsoleKey.D7:
                //case ConsoleKey.NumPad7:
                //    History();
                //    break;
                //case ConsoleKey.D8:
                //case ConsoleKey.NumPad8:
                //    Cinema();
                //    break;
                //case ConsoleKey.D9:
                //case ConsoleKey.NumPad9:
                //    Geography();
                //    break;
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
    public static int ValidAnswer()
    {
        int answer = 0;
        try
        {
            bool valid = false;
            Console.Write("\t Answer: ");
            //Console.Write("\t");
            while (!valid)
            {

                ConsoleKeyInfo tecla;
                tecla = Console.ReadKey();
                switch (tecla.Key)
                {
                    case ConsoleKey.A:
                        answer = 1;
                        Console.WriteLine();
                        Console.WriteLine("A");
                        valid = true;
                        break;
                    case ConsoleKey.B:
                        Console.WriteLine();
                        Console.WriteLine("B");
                        answer = 2;
                        valid = true;
                        break;
                    case ConsoleKey.C:
                        Console.WriteLine();
                        Console.WriteLine("C");
                        answer = 3;
                        valid=true;
                        break;
                    case ConsoleKey.D:
                        Console.WriteLine();
                        Console.WriteLine("D");
                        answer = 4;
                        valid = true;
                        break;
                    default:
                        answer = 0;
                        break;

                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return answer;
    }
    public static void MusicCuriosities()
    {
        try
        {
            Console.WriteLine("Why does Fall out Boy have it's name?");
            Console.WriteLine("A - A RANDOM GUY IN THE CROWD SHOUDED THE NAME");
            Console.WriteLine("B - THEY ARE ALL FANS FROM THE SIMPSONS");
            Console.WriteLine("C - IS THE VILLAN FROM A COMIC BOOK SERIES");
            Console.WriteLine("D - THEY CHECKED DIFFERENT COMBINATIONS OF NAMES");
            if (ValidAnswer() == 1)
                Console.WriteLine("YEP");
            else
                Console.WriteLine("NOPE");
            //Console.Clear(); Clean screen between questions

        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRESS A KEY TO GO TO THE MAIN MENU");
        }
    }

    //Eloy




    //Jaume






}
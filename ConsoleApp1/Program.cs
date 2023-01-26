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
                /*case ConsoleKey.D1:
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
                    break;*/
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
                /*case ConsoleKey.D7:
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
                    break;*/
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
    
    public static void DrivingSchool()
    {
        string resposta;
        int puntuation = 0;
        try
        {
            try
            {
                Console.WriteLine("Is it forbidden to go backwards?");
                Console.WriteLine("\t A - Yes, unless you cannot go forward or change direction or sense of direction.");
                Console.WriteLine("\t B - No, except on highways and dual carriageways.");
                Console.WriteLine("\t C - Yes, if there are other users nearby.");
                Console.WriteLine("\t D - You can only go backwards to park.");
                resposta = Console.ReadLine();
                switch(resposta)
                {
                    case "A":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "a":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("What breathalyzer rate is applied to new drivers, do you know what rate and for how long?");
                Console.WriteLine("\t A - 0.25 milligrams of alcohol per liter of exhaled air for two years.");
                Console.WriteLine("\t B - 0.15 milligrams of alcohol per liter of blood for two years.");
                Console.WriteLine("\t C - 0.30 grams of alcohol per liter of blood for two years.");
                Console.WriteLine("\t D - 0.15 milligrams of alcohol per liter of blood for a year.");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "C":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "c":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("The load that protrudes from the front of the vehicle must be marked...");
                Console.WriteLine("\t A - With a white light and a white reflector, at night or in conditions that significantly reduces visibility.");
                Console.WriteLine("\t B - With a white light, both day and night.");
                Console.WriteLine("\t C - With a white reflector in conditions that significantly reduce visibility.");
                Console.WriteLine("\t D - With a white light, at night or in conditions that significantly reduce visibility.");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "D":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "d":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("If at an intersection, you see an officer with his arm raised vertically, you must stop...");
                Console.WriteLine("\t A - As long as you can do it safely.");
                Console.WriteLine("\t B - Only if you have already entered the intersection.");
                Console.WriteLine("\t C - Only if you see the agent from the front and as long as you can do it safely.");
                Console.WriteLine("\t D - Whenever there is a red light.");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "A":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "a":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("Is it allowed to use bursts with long-range lighting to warn the vehicle in front of the intention to overtake?");
                Console.WriteLine("\t A - No.");
                Console.WriteLine("\t B - Yes, both in town and out of town.");
                Console.WriteLine("\t C - Yes, but only out of town.");
                Console.WriteLine("\t D - No, except in town.");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "B":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "b":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen($"YOUR PUNTUATION: {puntuation}/5");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRES A KEY TO GO TO THE MAIN MENU");
        }
    }

    public static void Riddles()
    {
        string resposta;
        int puntuation = 0;
        try
        {
            try
            {
                Console.WriteLine("What is the living being that starts walking with 4 paws, then with 2 and ends with 3?");
                Console.WriteLine("\t A - A monkey.");
                Console.WriteLine("\t B - A human.");
                Console.WriteLine("\t C - A horse.");
                Console.WriteLine("\t D - A kangaroo.");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "B":
                        Console.WriteLine("Correct. A human start crawling at 4, then he walks with 2 and when he gets older he uses a cane that ends up being 3.");
                        puntuation++;
                        break;
                    case "b":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("Mr. and Mrs. Perez have six daughters, and each daughter has a brother. How many people make up the Pérez family?");
                Console.WriteLine("\t A - 12");
                Console.WriteLine("\t B - 14");
                Console.WriteLine("\t C - 11");
                Console.WriteLine("\t D - 9");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "D":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "d":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("I'm not alive but I grow, I need air to live but I don't have lungs, and although I don't have a mouth, water kills me. Who I am?");
                Console.WriteLine("\t A - Clouds.");
                Console.WriteLine("\t B - Thunder.");
                Console.WriteLine("\t C - Fire.");
                Console.WriteLine("\t D - Sand.");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "C":
                        Console.WriteLine("Correct. ");
                        puntuation++;
                        break;
                    case "c":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("You continue in red, but you stop in green. That I am?");
                Console.WriteLine("\t A - Traffic light.");
                Console.WriteLine("\t B - Peppers.");
                Console.WriteLine("\t C - Watermelon.");
                Console.WriteLine("\t D - Tree.");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "C":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "c":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("The one who makes it doesn't want it, the one who buys it doesn't use it, the one who uses it doesn't know it. What is?");
                Console.WriteLine("\t A - Weapon.");
                Console.WriteLine("\t B - Coffin.");
                Console.WriteLine("\t C - Backpack. ");
                Console.WriteLine("\t D - Money.");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "B":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "b":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen($"YOUR PUNTUATION: {puntuation}/5");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRES A KEY TO GO TO THE MAIN MENU");
        }
    }

    public static void Astronomy()
    {
        string resposta;
        int puntuation = 0;
        try
        {
            try
            {
                Console.WriteLine("When was the first astronomical photograph of the Moon taken by chemistry professor William Draper?");
                Console.WriteLine("\t A - 1780");
                Console.WriteLine("\t B - 1840");
                Console.WriteLine("\t C - 1880");
                Console.WriteLine("\t D - 1790");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "B":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "b":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("How many confirmed moons does Saturn currently have?");
                Console.WriteLine("\t A - 200");
                Console.WriteLine("\t B - 83");
                Console.WriteLine("\t C - 51");
                Console.WriteLine("\t D - 132");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "A":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "a":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("How many degrees does the Sun make?");
                Console.WriteLine("\t A - 6248 ºC");
                Console.WriteLine("\t B - 7281 ºC");
                Console.WriteLine("\t C - 5505 ºC");
                Console.WriteLine("\t D - 8467 ºC");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "C":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "c":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("In what position is Neptune in the Solar System??");
                Console.WriteLine("\t A - 8");
                Console.WriteLine("\t B - 7");
                Console.WriteLine("\t C - 9");
                Console.WriteLine("\t D - 6");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "A":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "a":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen("PRES A KEY TO GO TO THE NEXT QÜESTION -->");
            }
            try
            {
                Console.Clear();
                Console.WriteLine("How long does it take for the green comet to return to our Solar System?");
                Console.WriteLine("\t A - 80.000 years");
                Console.WriteLine("\t B - 15.000 years");
                Console.WriteLine("\t C - 100.000 years");
                Console.WriteLine("\t D - 50.000 years");
                resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "D":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    case "d":
                        Console.WriteLine("Correct");
                        puntuation++;
                        break;
                    default:
                        Console.WriteLine("Incorrect");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                MsgNextScreen($"YOUR PUNTUATION: {puntuation}/5");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            MsgNextScreen("PRES A KEY TO GO TO THE MAIN MENU");
        }
    }

    //Jaume






}
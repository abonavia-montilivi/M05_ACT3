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
        } while (!(tecla.Key == ConsoleKey.D0)||(tecla.Key == ConsoleKey.NumPad0));
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
        Console.Clear();
        int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0; 
        double total;
        count1=MusicQuestion1();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count2 = MusicQuestion2();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count3 = MusicQuestion3();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count4 = MusicQuestion4();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count5 = MusicQuestion5();
        total = count1+ count2+count3+count4+count5;
        Console.WriteLine("You've got {0} out of 5 questions right", total);
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT MAIN MENU");

    }
    public static int MusicQuestion1()
    {
            Console.Clear();
            int count = 0;
            Console.WriteLine("Why does Fall out Boy have it's name?");
            Console.WriteLine("A - A RANDOM GUY IN THE CROWD SHOUDED THE NAME");
            Console.WriteLine("B - THEY ARE ALL FANS FROM THE SIMPSONS");
            Console.WriteLine("C - IS THE VILLAN FROM A COMIC BOOK SERIES");
            Console.WriteLine("D - THEY CHECKED DIFFERENT COMBINATIONS OF NAMES");
            if (ValidAnswer() == 1)
            {
                Console.WriteLine("CORRECT!");
                count = 1;
            }
            else
            {
                Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → A");
                count=0;
            }
            return count;

    }
    public static int MusicQuestion2()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("The singer of what band did not recognize himself on the radio?");
        Console.WriteLine("A - The Sex Pistols");
        Console.WriteLine("B - Red Hot Chilli peppers");
        Console.WriteLine("C - Nickelback");
        Console.WriteLine("D - Aerosmith");
        if (ValidAnswer() == 4)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → D");
            count = 0;
        }
        return count;

    }
    public static int MusicQuestion3()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("What band rejected Slash's audition because he was too ugly?");
        Console.WriteLine("A - Europe");
        Console.WriteLine("B - T.Rex");
        Console.WriteLine("C - Poison");
        Console.WriteLine("D - Bon Jovi");
        if (ValidAnswer() == 3)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → C");
            count = 0;
        }
        return count;
;
    }
    public static int MusicQuestion4()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("What singer is knwown for volunteering every year to feed the poor on thanks giving?");
        Console.WriteLine("A - Alice Cooper");
        Console.WriteLine("B - Bruce Sprignsteen");
        Console.WriteLine("C - Kenny loggins");
        Console.WriteLine("D - Myles Kennedy");
        if (ValidAnswer() == 1)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → A");
            count = 0;
        }
        return count;
;
    }
    public static int MusicQuestion5()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("The singer of what metal band is a pilot for a comercial airline when he's not with the band?");
        Console.WriteLine("A - James Hetfield from Metallica");
        Console.WriteLine("B - James LaBrie from Dream Theater");
        Console.WriteLine("C - Bruce Dickinson from Iron Maiden");
        Console.WriteLine("D - Dave Mustaine from Megadeth");
        if (ValidAnswer() == 3)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → C");
            count = 0;
        }
        return count;

    }
    public static void DadJokes()
    {
        Console.Clear();
        int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
        double total;
        count1 = DadQuestion1();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count2 = DadQuestion2();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count3 = DadQuestion3();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count4 = DadQuestion4();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count5 = DadQuestion5();
        total = count1 + count2 + count3 + count4 + count5;
        Console.WriteLine("You've got {0} out of 5 questions right", total);
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT MAIN MENU");

    }
    public static int DadQuestion1()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("Whath's brown and sticky?");
        Console.WriteLine("A - Bread Dough");
        Console.WriteLine("B - A horse bottom");
        Console.WriteLine("C - A stick");
        Console.WriteLine("D - Chewing gum");
        if (ValidAnswer() == 3)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → C");
            count = 0;
        }
        return count;

    }
    public static int DadQuestion2()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("What did the buffalo say to his son when he left for college?");
        Console.WriteLine("A - Bye bye my son");
        Console.WriteLine("B - Bison");
        Console.WriteLine("C - I'm going to buy tobaco, i'll be back soon");
        Console.WriteLine("D - Save the cheerleader, save the world!");
        if (ValidAnswer() == 2)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → B");
            count = 0;
        }
        return count;

    }
    public static int DadQuestion3()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("Who is the fastest brother of Bruce Lee?");
        Console.WriteLine("A - Patient-Lee");
        Console.WriteLine("B - Honest-lee");
        Console.WriteLine("C - Suden-Lee");
        Console.WriteLine("D - Broco-Lee");
        if (ValidAnswer() == 3)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → C");
            count = 0;
        }
        return count;
        ;
    }
    public static int DadQuestion4()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("How do you know when a joke is a 'dad joke'?");
        Console.WriteLine("A - It's apparent");
        Console.WriteLine("B - It's bad");
        Console.WriteLine("C - It's a pun");
        Console.WriteLine("D - It's dumb");
        if (ValidAnswer() == 1)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → A");
            count = 0;
        }
        return count;
        ;
    }
    public static int DadQuestion5()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("What kind of bees produces milk?");
        Console.WriteLine("A - Cow bees");
        Console.WriteLine("B - Nicolas Cage, NOT THE BEES!!!");
        Console.WriteLine("C - Moo bees");
        Console.WriteLine("D - Boo bees");
        if (ValidAnswer() == 4)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → D");
            count = 0;
        }
        return count;

    }
    public static void Science()
    {
        Console.Clear();
        int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0;
        double total;
        count1 = ScienceQuestion1();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count2 = ScienceQuestion2();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count3 = ScienceQuestion3();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count4 = ScienceQuestion4();
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT QUESTION");
        count5 = ScienceQuestion5();
        total = count1 + count2 + count3 + count4 + count5;
        Console.WriteLine("You've got {0} out of 5 questions right", total);
        MsgNextScreen("PRESS A KEY TO GO TO THE NEXT MAIN MENU");

    }
    public static int ScienceQuestion1()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("The hardest substance available on earth is");
        Console.WriteLine("A - Gold");
        Console.WriteLine("B - Iron");
        Console.WriteLine("C - Diamond");
        Console.WriteLine("D - Platinum");
        if (ValidAnswer() == 3)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → C");
            count = 0;
        }
        return count;

    }
    public static int ScienceQuestion2()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("The inert gas which is substituted for nitrogen in the air used by deep sea divers for breathing, is");
        Console.WriteLine("A - Argon");
        Console.WriteLine("B - Helium");
        Console.WriteLine("C - Krypton");
        Console.WriteLine("D - Xenon");
        if (ValidAnswer() == 2)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → B");
            count = 0;
        }
        return count;

    }
    public static int ScienceQuestion3()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("The average salinity of sea water is");
        Console.WriteLine("A - 2.5%");
        Console.WriteLine("B - 3%");
        Console.WriteLine("C - 3.5%");
        Console.WriteLine("D - 4%");
        if (ValidAnswer() == 3)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → C");
            count = 0;
        }
        return count;
        ;
    }
    public static int ScienceQuestion4()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("The audiable range of sound for an average adult is ______");
        Console.WriteLine("A - 20 Hz - 20 KHz");
        Console.WriteLine("B - 20 Hz - 50 KHz");
        Console.WriteLine("C - 50 Hz - 20 KHz");
        Console.WriteLine("D - 50 Hz - 50 KHz");
        if (ValidAnswer() == 1)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → A");
            count = 0;
        }
        return count;
        ;
    }
    public static int ScienceQuestion5()
    {
        Console.Clear();
        int count = 0;
        Console.WriteLine("Who is known as the father of Physics?");
        Console.WriteLine("A - Albert Einsteinb");
        Console.WriteLine("B - Johannes kepler");
        Console.WriteLine("C - Isaac Newton");
        Console.WriteLine("D - Galileo Galilei");
        if (ValidAnswer() == 4)
        {
            Console.WriteLine("CORRECT!");
            count = 1;
        }
        else
        {
            Console.WriteLine("SORRY BUT THE RIGHT QUESTION WAS THE LETTER → D");
            count = 0;
        }
        return count;

    }
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
using System;
using HEM02;
namespace HEM02CarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine DankEngine = new Engine("AirForce1 Prototye", 9001, "CaryMCCarFace", false); // Type Output SerialNR LDCSSPEED YN
            SoundSystem SoundSystem3K = new SoundSystem(true, "Looking for Freedom");// Switch ONOFF SongName
            Person HasselHoff = new Person("David", "HasselHoff"); // FirstName LastName
            M3Car DankCar = new M3Car("Lexus", "TK421", DankEngine, SoundSystem3K, HasselHoff); //Brand, Model, Engine, SoundSystem, VehicleOwner

            /*
             Console.WriteLine(DankCar); writes APPNAME.Class
             Console.WriteLine(DankCar.VehicleOwner.FirstName+" "+DankCar.VehicleOwner.LastName +"" +
                              " is driving a "+DankCar.Brand + " model :" + DankCar.Model);
             Console.ReadLine();
             if(SoundSystem3K.Music_Switch == true)
             Console.WriteLine("And listening to " +SoundSystem3K.SongName);
             */
            string val = "";
            bool theDream = true;
            while(theDream == true)
            {
                Console.Clear();
                Console.WriteLine("1.Press the Button\n2.Don't Press the Button\n3.Exit");
                val = Console.ReadLine();
                switch(val)
                {
                    case "1":
                    DankCar.PressSpeedButton();
                    Console.ReadLine();
                    break;



                    case "2":
                    Console.WriteLine("Wuss!");
                    Console.ReadLine();
                    break;


                    case "3":
                    Environment.Exit(1); 
                    break;
                    default:
                    Console.WriteLine("Invalid Selection");
                    break;
                }
            }
        }
            
        }
    }


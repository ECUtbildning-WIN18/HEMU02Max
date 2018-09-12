using System;

namespace HEM02
{

    // Elon Musks Bil Bibliotek
    // Feturing these Classes
    // Car
    // Engine
    // SoudSystem
    // Person
    public class M3Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        private Engine Engine { get; set; } // Bil har en Engine från klass Engine noice Association
        private SoundSystem SLSLBeatbox { get; set; }
        public Person VehicleOwner { get; set; }

        public M3Car(string _Brand, string _Model, Engine engine, SoundSystem _SLSLBeatbox, Person _VehicleOwner) //CarConstructorFactory
        {
            Brand = _Brand;
            Model = _Model;
            Engine = engine;
           SLSLBeatbox = _SLSLBeatbox;
            VehicleOwner = _VehicleOwner;
        }

        public void PressSpeedButton()// Call this 4 Ludicrous Speed
        {
            
            Engine.LudicrousSpeed();
            if(Engine.Ludicrous_Speed == true)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Gas Gas Gas");
                }
            }
        }
        
    }

    public class Engine
    {
        public string Type { get; set; }
        public int Output { get; set; }
        public string SerialNumber { get; set; }
        public bool Ludicrous_Speed { get; set; }

        public Engine(string _Type, int _Output, string _SerialNumber, bool _Ludicrous_Speed)
        {
            Type = _Type;
            Output = _Output;
            SerialNumber = _SerialNumber;
            Ludicrous_Speed = _Ludicrous_Speed;



        }
            public bool LudicrousSpeed()
            {
            Ludicrous_Speed = true;
            return Ludicrous_Speed;
            } 
    }

   public class SoundSystem
    {
      private bool Music_Switch { get; set; }
      private string SongName { get; set; }

        public SoundSystem(bool _Music_switch, string _Songname)
        {
            Music_Switch = _Music_switch;
            SongName = _Songname;
        }

        public bool ChangeSettings(bool onoff) // stäng av eller sätt på musiken
        {
            if (onoff == false)
                onoff = true;
            else if (onoff == true)
                onoff = false;

            return onoff;
        }
    }
  public  class Person
    {
        private string FirstName { get; }
        private string LastName { get; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}

using System;

namespace ModelLib.model
{
    public class FanOutput
    {
        private int _id;
        private string _name;
        private int _temp;
        private int _humidity;

        public FanOutput(int id, string name, int temp, int humidity)
        {
            _id = id;
            _name = name;
            _temp = temp;
            _humidity = humidity;
        }

        public FanOutput()
        {

        }

        public int Id { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name is null or empty");
                }
                else if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("Name is too short.");
                }
                _name = value;
            }
        }

        public int Temp
        {
            get => _temp;
            set
            {
                if (value < 15 || value > 25)
                {
                    throw new ArgumentOutOfRangeException("Temperature Is lower than 15, or higher than 25.");
                }
                else
                {
                    _temp = value;
                }
            }
        }
        public int Humidity
        {
            get => _humidity;
            set {
                if (value < 30 || value > 80)
                {
                    throw new ArgumentOutOfRangeException("Humidity is lower than 30 or higher than 80.");
                }
                else
                {
                    _humidity = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Temp: {Temp}, Humidity: {Humidity}";
        }

        static void Data()
        {

        }
    }
}
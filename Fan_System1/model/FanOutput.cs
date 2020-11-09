using System;

namespace ModelLib.model
{
    public class FanOutput
    {
        private int _id;
        private String _name;
        private int _temp;
        private int _humidity;

        public FanOutput(int id, string name, int temp, int humidity)
        {
            this._id = id;
            this._name = name;
            this._temp = temp;
            this._humidity = humidity;
        }

        public int GetId()
        {
            return _id;
        }
        public void SetId(int id)
        {
            this._id = id;
        }
        public String GetName()
        {
            return _name;
        }
        public void SetName(String name)
        {
            if (name.Length > 2)
            {
                this._name = name;
            }
            else
            {
                throw new System.ArgumentException("Name is too short.");
            }
        }
        public int GetTemp()
        {
            return _temp;
        }
        public void SetTemp(int temp)
        {
            if(temp >= 15 & temp <= 25)
            {
                this._temp = temp;
            }
            else
            {
                throw new System.ArgumentException("Temp value is invalid (Is less than 15, or more than 25.");
            }
        }
        public int GetHumidity()
        {
            return _humidity;
        }
        public void SetHumidity(int humidity)
        {
            if (humidity >= 30 & humidity <= 80)
            {
                this._humidity = humidity;
            }
            else
            {
               throw new System.ArgumentException("Humidity value is invalid (Is less than 30, or more than 80.");
            }
        }
        public string GetFanData()
        {
            return "Id: " + GetId() + " Name: " + GetName() + " Temp: " + GetTemp() + " Humidity: " + GetHumidity();
        }
    }
}
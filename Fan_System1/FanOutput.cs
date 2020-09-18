using System;

namespace FanSystem
{
    public class FanOutput
    {
        private int id;
        private String name;
        private int temp;
        private int humidity;

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public String getName()
        {
            return name;
        }
        public void setName(String name)
        {
            if (name.Length > 2)
            {
                this.name = name;
            }
            else
            {
                throw new System.ArgumentException("Name is too short.");
            }
        }
        public int getTemp()
        {
            return temp;
        }
        public void setTemp(int temp)
        {
            if(temp >= 15 & temp <= 25)
            {
                this.temp = temp;
            }
            else
            {
                throw new System.ArgumentException("Temp value is invalid (Is less than 15, or more than 25.");
            }
        }
        public int getHumidity()
        {
            return humidity;
        }
        public void setHumidity(int humidity)
        {
            if (humidity >= 30 & humidity <= 80)
            {
                this.humidity = humidity;
            }
            else
            {
               throw new System.ArgumentException("Humidity value is invalid (Is less than 30, or more than 80.");
            }
        }
    }
}
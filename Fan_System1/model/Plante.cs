using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.model
{
    public class Plante
    {
        private int _planteId;
        private String _planteType;
        private String _planteNavn;
        private int _price;
        private int _maksHoejde;

        public Plante(int planteId, string planteType, string planteNavn, int price, int maksHoejde)
        {
            this._planteId = planteId;
            this._planteType = planteType;
            this._planteNavn = planteNavn;
            this._price = price;
            this._maksHoejde = maksHoejde;
        }

        public int GetPlanteId()
        {
            return _planteId;
        }
        public void SetPlanteId(int id)
        {
            this._planteId = id;
        }
        public String GetPlanteType()
        {
            return _planteType;
        }
        public void SetPlanteType(String type)
        {
            this._planteType = type;
        }
        public String GetPlanteNavn()
        {
            return _planteNavn;
        }
        public void SetPlanteNavn(String navn)
        {
            this._planteNavn = navn;
        }
        public int GetPrice()
        {
            return _price;
        }
        public void SetPrice(int price)
        {
            this._price = price;
        }
        public int GetMaksHoejde()
        {
            return _maksHoejde;
        }
        public void SetMaksHoejde(int maksHoejde)
        {
            this._maksHoejde = maksHoejde;
        }
        public string SetPlanteData()
        {
            return "Id: " + GetPlanteId() + " Type: " + GetPlanteType() + " Name: " + GetPlanteNavn() + " Price: " + GetPrice() + " Maks Højde: " + GetMaksHoejde();
        }
    }
}

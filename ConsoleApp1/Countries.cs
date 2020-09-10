using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class countries
    {
        private String countryCode;
        private double taxRate;

        public countries(String countryCode, double taxRate)
        {
            this.countryCode = countryCode;
            this.taxRate = taxRate;
        }

        public String getCountryCode()
        {
            return countryCode;
        }
        public void setCountryCode(String countryCode)
        {
            this.countryCode = countryCode;
        }
        public double getTaxRate()
        {
            return taxRate;
        }
        public void setTaxRate(double taxRate)
        {
            this.taxRate = taxRate;
        }
    }
}
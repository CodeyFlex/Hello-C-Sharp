using System;

namespace Calculator
{
    public class CalculatorClass
    {
        //Calculates the sum of two numbers
        public int sum(int a, int b)
        {
            int result = a + b;
            return result;
        }
        //Calculates Minus of two numbers
        public int minus(int a, int b)
        {
            int result = a - b;
            return result;
        }
        //Calculates multiplication of two numbers

        public int multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }
        //Calculates division of two numbers

        public int divide(int a, int b)
        {
            int result = a / b;
            return result;
        }
        //Calculates use experience
        public string userExperience(String name)
        {
            String experience = " is very impressed by this calculator";
            return name + experience;
        }
        //Calculates money left after daily expenses
        public int spareMoney(int income, int rent, int food, int internetBill, int phoneBill)
        {
            int result = income - rent - food - internetBill - phoneBill;
            return result;
        }
    }
}
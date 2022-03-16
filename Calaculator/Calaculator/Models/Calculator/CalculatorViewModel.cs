namespace Calaculator.Models.Calculator
{
    public class CalculatorViewModel
    {
        public double EntryOne { get; set; }
        public double EntryTwo { get; set; }

        public double TotalNumber = 0;
        public MakeCalculate makecalculate { get; set; }


        public enum MakeCalculate
        {
            Add = '+',
            Multiply = '*',
            Subtract ='-',
            Divide = '/'   
        }




        //public double AddInput(double FirstNumber, double SecondNumber)
        //{
        //    TotalNumber = FirstNumber + SecondNumber;
        //    return TotalNumber;
        //}




        //public double SubtractInput(double FirstNumber, double SecondNumber)
        //{
        //    TotalNumber = FirstNumber - SecondNumber;
        //    return TotalNumber;
        //}




        //public double DivideInput(double FirstNumber, double SecondNumber)
        //{
        //    TotalNumber = FirstNumber / SecondNumber;
        //    return TotalNumber;
        //}




        //public double MultiplyInput(double FirstNumber, double SecondNumber)
        //{
        //    TotalNumber = FirstNumber * SecondNumber;
        //    return TotalNumber;
        //}


    }
    
}

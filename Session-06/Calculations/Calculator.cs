namespace Calculations
{
    public class Calculator
    {
        public ComputationTypeEnum ComputationType { get; set; }

        public Calculator()
        {

        }

        public decimal Add(decimal inputA, decimal inputB)
        {
            decimal sum = inputA + inputB;

            return sum;
        }

        public decimal Substract(decimal inputA, decimal inputB)
        {
            decimal sub = Math.Abs(inputA) - Math.Abs(inputB);

            return sub;
        }

        public decimal Multiply(decimal inputA, decimal inputB)
        {
            decimal product = inputA * inputB;

            return product;
        }

        public decimal Divide(decimal inputA, decimal inputB)
        {
            decimal result = 0;

            try
            {
                result = inputA / inputB;
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public decimal GetPow(decimal inputA, decimal inputB)
        {
            double numberA = Convert.ToDouble(inputA);
            double numberB = Convert.ToDouble(inputB);
            decimal pow = Convert.ToDecimal(Math.Pow(numberA, numberB));

            return pow;
        }

        public decimal GetSqrt(decimal input)
        {
            double number = Convert.ToDouble(input);
            decimal sqrt = Convert.ToDecimal(Math.Sqrt(number));

            return sqrt;
        }

        public decimal Compute(decimal inputA, decimal inputB, ComputationTypeEnum computationType)
        {
            decimal result;
            switch (computationType)
            {
                case ComputationTypeEnum.Addition:
                    result = Add(inputA, inputB);
                    break;
                case ComputationTypeEnum.Subtraction:
                    result = Substract(inputA, inputB);
                    break;
                case ComputationTypeEnum.Multiplication:
                    result = Multiply(inputA, inputB);
                    break;
                case ComputationTypeEnum.Division:
                    result = Divide(inputA, inputB);
                    break;
                case ComputationTypeEnum.Power:
                    result = GetPow(inputA, inputB);
                    break;
                case ComputationTypeEnum.SquareRoot:
                    result = GetSqrt(inputA);
                    break;
                default:
                    result = 0m;
                    break;
            }

            return result;
        }

    }

}
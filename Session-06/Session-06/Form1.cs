namespace Session_06
{
    public partial class Form1 : Form
    {
        private decimal _result;
        private Calculations.Calculator _calc;

        public Form1()
        {
            InitializeComponent();
            _calc = new Calculations.Calculator();
            _result = 0m;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtCalculation_TextChanged(object sender, EventArgs e)
        {

        }


        private void btnSymbol0_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "0";
            this.txtCalculation.Text += "0";


        }

        private void btnSymbol1_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "1";
            this.txtCalculation.Text += "1";

        }

        private void btnSymbol2_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "2";
            this.txtCalculation.Text += "2";

        }

        private void btnSymbol3_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "3";
            this.txtCalculation.Text += "3";

        }

        private void btnSymbol4_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "4";
            this.txtCalculation.Text += "4";

        }

        private void btnSymbol5_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "5";
            this.txtCalculation.Text += "5";

        }

        private void btnSymbol6_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "6";
            this.txtCalculation.Text += "6";

        }

        private void btnSymbol7_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "7";
            this.txtCalculation.Text += "7";

        }

        private void btnSymbol8_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "8";
            this.txtCalculation.Text += "8";

        }

        private void btnSymbol9_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += "9";
            this.txtCalculation.Text += "9";

        }

        private void btnSymbolPeriod_Click(object sender, EventArgs e)
        {
            this.txtDisplay.Text += ".";
            this.txtCalculation.Text += ".";
        }
        private void btnSymbolPlus_Click(object sender, EventArgs e)
        {
            _result = Convert.ToDecimal(this.txtCalculation.Text);
            decimal number = Convert.ToDecimal(this.txtCalculation.Text);
            _result = _calc.Compute(_result, number, Calculations.ComputationTypeEnum.Addition);
            this.txtDisplay.Text += " + ";
            this.txtCalculation.Clear();
            _calc.ComputationType = Calculations.ComputationTypeEnum.Addition;
        }

        private void btnSymbolMinus_Click(object sender, EventArgs e)
        {
            _result = Convert.ToDecimal(this.txtCalculation.Text);
            decimal number = Convert.ToDecimal(this.txtCalculation.Text);
            _result = _calc.Compute(_result, number, Calculations.ComputationTypeEnum.Subtraction);
            this.txtDisplay.Text += " - ";
            this.txtCalculation.Clear();
            _calc.ComputationType = Calculations.ComputationTypeEnum.Subtraction;
        }

        private void btnSymbolMultiply_Click(object sender, EventArgs e)
        {
            _result = Convert.ToDecimal(this.txtCalculation.Text);
            decimal number = Convert.ToDecimal(this.txtCalculation.Text);
            _result = _calc.Compute(_result, number, Calculations.ComputationTypeEnum.Multiplication);
            this.txtDisplay.Text += " * ";
            this.txtCalculation.Clear();
            _calc.ComputationType = Calculations.ComputationTypeEnum.Multiplication;
        }

        private void btnSymbolDivide_Click(object sender, EventArgs e)
        {
            _result = Convert.ToDecimal(this.txtCalculation.Text);
            decimal number = Convert.ToDecimal(this.txtCalculation.Text);
            _result = _calc.Compute(_result, number, Calculations.ComputationTypeEnum.Division);
            this.txtDisplay.Text += " / ";
            this.txtCalculation.Clear();
            _calc.ComputationType = Calculations.ComputationTypeEnum.Division;
        }

        private void btnSymbolSqrt_Click(object sender, EventArgs e)
        {
            _result = Convert.ToDecimal(this.txtCalculation.Text);
            decimal number = Convert.ToDecimal(this.txtCalculation.Text);
            _result = _calc.Compute(_result, number, Calculations.ComputationTypeEnum.SquareRoot);
            this.txtDisplay.Text += " Sqrt ";
            this.txtCalculation.Clear();
            _calc.ComputationType = Calculations.ComputationTypeEnum.SquareRoot;
        }
        private void btnSymbolPow_Click(object sender, EventArgs e)
        {
            _result = Convert.ToDecimal(this.txtCalculation.Text);
            decimal number = Convert.ToDecimal(this.txtCalculation.Text);
            _result = _calc.Compute(_result, number, Calculations.ComputationTypeEnum.Power);
            this.txtDisplay.Text += " Power ";
            this.txtCalculation.Clear();
            _calc.ComputationType = Calculations.ComputationTypeEnum.Power;
        }
        private void btnSymbolEqual_Click(object sender, EventArgs e)
        {
            _result = Convert.ToDecimal(this.txtCalculation.Text);
            decimal number = Convert.ToDecimal(this.txtCalculation.Text);
            _result = _calc.Compute(_result, number, _calc.ComputationType);
            this.txtDisplay.Text += " = " + Convert.ToString(_result) + Environment.NewLine;
            this.txtCalculation.Clear();

        }

    }
}
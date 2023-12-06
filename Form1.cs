namespace MyCalculator
{
    public partial class Form1 : Form
    {
        ICalculate calculate;
        public Form1()
        {
            InitializeComponent();
            calculate = new Calculate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void SumButton_Click(object sender, EventArgs e)
        {
            if (VAlidateInput())
            {
                int sum = calculate.Plus((int)TxtNumber1.Value, (int)TxtNumber2.Value);
                Risultbutton.BackColor = Color.Pink;
                Risultbutton.Text = $"sum is : {sum}";
            }
        }
        bool VAlidateInput()
        {
            bool isValid = true;

            if (TxtNumber1.Value == 0)
            {
                isValid = false;
                MessageBox.Show("لطفا عدد اول را وارد کنید");
            }
            else
            {
                if (TxtNumber2.Value == 0)
                {
                    isValid = false;
                    MessageBox.Show("عدد دوم را وارد کنید");
                }
            }
            return isValid;
        }

        private void MinusButton_Click(object sender, EventArgs e)
        {
            if (VAlidateInput())
            {
                int minus = calculate.Minus((int)TxtNumber1.Value, (int)TxtNumber2.Value);
                Risultbutton.BackColor = Color.Purple;
                Risultbutton.Text = $"Minus is: {minus}";
            }
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (VAlidateInput())
            {
                int multiply = calculate.Multiple((int)TxtNumber1.Value, (int)TxtNumber2.Value);
                Risultbutton.BackColor = Color.LightBlue;
                Risultbutton.Text = $"Multiple is : {multiply}";
            }

        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            int Divide = calculate.Divide((int)TxtNumber1.Value, (int)TxtNumber2.Value);
            Risultbutton.BackColor = Color.LightGreen;
            Risultbutton.Text = $"Multiple is : {Divide}";

        }
    }
}
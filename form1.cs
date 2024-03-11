namespace pog_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberOfElements = int.Parse(textBox1.Text);
            string fibonacciSequence = CalculateFibonacciSequence(numberOfElements);
            textBox1.Text = fibonacciSequence;
        }

        private string CalculateFibonacciSequence(int numberOfElements)
        {
            int[] fibonacciSequence = new int[numberOfElements];
            fibonacciSequence[0] = 0;
            fibonacciSequence[1] = 1;

            for (int i = 2; i < numberOfElements; i++)
            {
                fibonacciSequence[i] = fibonacciSequence[i - 1] + fibonacciSequence[i - 2];
            }

            return string.Join(", ", fibonacciSequence);
        }
    }
}

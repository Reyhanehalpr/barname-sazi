namespace pog2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0, y = 1;
            try
            {

                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            MessageBox.Show((x + y).ToString());

        }

        private void button2_Click(object sender, EventArgs e)
        {


            int x = 0, y = 1;
            try
            {

                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            MessageBox.Show((y - x).ToString());



        }

        private void button3_Click(object sender, EventArgs e)
        {

            int x = 0, y = 1;
            try
            {

                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            MessageBox.Show((y * x).ToString());


        }

        private void button4_Click(object sender, EventArgs e)
        {

            int x = 0, y = 1;
            try
            {

                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            MessageBox.Show((y / x).ToString());

        }
    }
}
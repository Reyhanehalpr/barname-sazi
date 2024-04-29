namespace POG3
{
    using System.IO;
    public partial class Form1 : Form
    {
        string a;
        string b;
        int c;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            a = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            b = textBox1.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                c = int.Parse(textBox1.Text);
            }
            catch(Exception ex) { }

            var user = textBox1.Text + "," + textBox2.Text + "," + textBox3.Text+"\n";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
         
            
            File.AppendAllText("1.csv",user);
               




        }
    }
}
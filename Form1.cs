using System.Security.Cryptography.X509Certificates;

namespace modul3_1302223134
{
    public partial class Form1 : Form
    {
        String operanString;
        int nOperan;
        int[] arrOperan = new int[256];
        int total = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            boxHasil.Text += button1.Text;
            operanString += button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boxHasil.Text += button2.Text;
            operanString += button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boxHasil.Text += button3.Text;
            operanString += button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            boxHasil.Text += button4.Text;
            operanString += button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            boxHasil.Text += button5.Text;
            operanString += button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            boxHasil.Text += button6.Text;
            operanString += button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            boxHasil.Text += button7.Text;
            operanString += button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            boxHasil.Text += button8.Text;
            operanString += button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            boxHasil.Text += button9.Text;
            operanString += button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(operanString.Length > 0)
            { 
                boxHasil.Text += button0.Text;
                operanString += button0.Text;
            }
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            boxHasil.Text += buttonPlus.Text;
            arrOperan[nOperan] = int.Parse(operanString);
            nOperan += 1;
            operanString = "";
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            arrOperan[nOperan] = int.Parse(operanString);
            nOperan += 1;
            for (int i = 0; i < nOperan; i++)
            {
                total += arrOperan[i];
            }
            boxHasil.Text += "=" + total;
            operanString = total.ToString();
            nOperan = 0;
            total = 0;
        }

        private void boxHasil_TextChanged(object sender, EventArgs e)
        { 
            
        }
    }
}

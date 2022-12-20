namespace FİnalProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            {
                int havadurumu = Convert.ToInt32(textBox1.Text);
                if (havadurumu >= 20)
                {
                    MessageBox.Show("Kombinizi açmanıza gerek yoktur.");
                }
                else if (havadurumu >= 10 && havadurumu < 20)
                {
                    MessageBox.Show("Kombinizin derecesini 30 veya 35 yapabilirsiniz.");
                }
                else if (havadurumu >= 0 && havadurumu < 10)
                {
                    MessageBox.Show("Kombinizin derecesini 40 veya 45 yapabilirsiniz.");
                }
                else
                {
                    MessageBox.Show("Kombinizin derecesini 50 veya 60 yapabilirsiniz.");
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
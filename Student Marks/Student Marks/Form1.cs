namespace Student_Marks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double java, python, dotnet, total, average;

            java = int.Parse(txtJava.Text);
            python = int.Parse(txtPython.Text);
            dotnet= int.Parse(txtdotnet.Text);

            total = java + python + dotnet;

            txtTotal.Text = total.ToString();

            average = total / 3;

            txtAverage.Text = average.ToString();



            


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
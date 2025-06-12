namespace Ej1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //double valor = Convert.ToDouble(TBingresarValor.Text);

            //LBmostrar.Text = $"{valor}";

            Form2 fModal=new Form2();
            if (fModal.ShowDialog()==DialogResult.OK )
            {
                LBmostrar.Text = fModal.TBvalor.Text;
            }
            else
            {
                LBmostrar.Text = "valor cancelado ";
            }



        }


    }
}

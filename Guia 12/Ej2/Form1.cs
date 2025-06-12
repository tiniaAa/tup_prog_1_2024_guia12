namespace Ej2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNmostrarValor_Click(object sender, EventArgs e)
        {
            Form2 fDialog = new Form2();
            
            fDialog.LBmostrarValor.Text=TBvalor.Text;

            fDialog.ShowDialog();



        }
    }
}

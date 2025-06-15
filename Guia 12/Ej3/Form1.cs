namespace Ej3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNsolicitar_Click(object sender, EventArgs e)
        {
            Form2 fModal = new Form2();
            fModal.ShowDialog();
            for (int i = 0; i < 10 && fModal.DialogResult == DialogResult.OK; i++)
            {
                LSBlistado.Items.Add($"{fModal.TBvalor.Text}");

                fModal.TBvalor.Clear();
                fModal.ShowDialog();
                LBcantida.Text = $"{i+1}";


            }
            
            
            
                
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

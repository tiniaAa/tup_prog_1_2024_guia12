namespace EJ4
{
    public partial class Form1 : Form
    {
        int[] numero = new int[10];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
           
        }
        private void BTNsolicitarValor_Click(object sender, EventArgs e)
        {
            Form2 fDialog = new Form2();
            fDialog.ShowDialog();

            for (int i = 0; i < 10 && fDialog.DialogResult==DialogResult.OK; i++) 
            {
                
                int val = Convert.ToInt32(fDialog.TBingreso.Text);
                numero[i] = val;
                fDialog.TBingreso.Clear();
                contador++;
                fDialog.ShowDialog();

                    
            }
            LBcantidad.Text = $"{contador}";

            if (fDialog.DialogResult == DialogResult.OK) 
            {
                for (int i = 0; i < contador; i++)
                {
                    LBXlistado.Items.Add(numero[i]);
                }
            }

        }
    }
}

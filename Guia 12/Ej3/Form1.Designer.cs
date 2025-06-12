namespace Ej3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTNsolicitar = new Button();
            label1 = new Label();
            label2 = new Label();
            LBcantidad = new Label();
            LSBlistado = new ListBox();
            LBcantida = new Label();
            SuspendLayout();
            // 
            // BTNsolicitar
            // 
            BTNsolicitar.Location = new Point(12, 12);
            BTNsolicitar.Name = "BTNsolicitar";
            BTNsolicitar.Size = new Size(223, 29);
            BTNsolicitar.TabIndex = 0;
            BTNsolicitar.Text = "Solicitar valor";
            BTNsolicitar.UseVisualStyleBackColor = true;
            BTNsolicitar.Click += BTNsolicitar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 66);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Listado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 66);
            label2.Name = "label2";
            label2.Size = new Size(72, 20);
            label2.TabIndex = 2;
            label2.Text = "Cantidad:";
            // 
            // LBcantidad
            // 
            LBcantidad.AutoSize = true;
            LBcantidad.Location = new Point(185, 66);
            LBcantidad.Name = "LBcantidad";
            LBcantidad.Size = new Size(0, 20);
            LBcantidad.TabIndex = 3;
            // 
            // LSBlistado
            // 
            LSBlistado.FormattingEnabled = true;
            LSBlistado.Location = new Point(12, 117);
            LSBlistado.Name = "LSBlistado";
            LSBlistado.Size = new Size(223, 104);
            LSBlistado.TabIndex = 4;
            // 
            // LBcantida
            // 
            LBcantida.AutoSize = true;
            LBcantida.Location = new Point(191, 66);
            LBcantida.Name = "LBcantida";
            LBcantida.Size = new Size(0, 20);
            LBcantida.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(348, 243);
            Controls.Add(LBcantida);
            Controls.Add(LSBlistado);
            Controls.Add(LBcantidad);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTNsolicitar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNsolicitar;
        private Label label1;
        private Label label2;
        private Label LBcantidad;
        private ListBox LSBlistado;
        private Label LBcantida;
    }
}

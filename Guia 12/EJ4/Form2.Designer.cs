namespace EJ4
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BTNaceptar = new Button();
            BTNcancelar = new Button();
            TBingreso = new TextBox();
            SuspendLayout();
            // 
            // BTNaceptar
            // 
            BTNaceptar.DialogResult = DialogResult.OK;
            BTNaceptar.Location = new Point(159, 45);
            BTNaceptar.Name = "BTNaceptar";
            BTNaceptar.Size = new Size(94, 29);
            BTNaceptar.TabIndex = 0;
            BTNaceptar.Text = "Aceptar";
            BTNaceptar.UseVisualStyleBackColor = true;
            // 
            // BTNcancelar
            // 
            BTNcancelar.DialogResult = DialogResult.Cancel;
            BTNcancelar.Location = new Point(47, 45);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(94, 29);
            BTNcancelar.TabIndex = 1;
            BTNcancelar.Text = "Cancelar";
            BTNcancelar.UseVisualStyleBackColor = true;
            // 
            // TBingreso
            // 
            TBingreso.Location = new Point(31, 12);
            TBingreso.Name = "TBingreso";
            TBingreso.Size = new Size(237, 27);
            TBingreso.TabIndex = 2;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 88);
            Controls.Add(TBingreso);
            Controls.Add(BTNcancelar);
            Controls.Add(BTNaceptar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNaceptar;
        private Button BTNcancelar;
        public TextBox TBingreso;
    }
}
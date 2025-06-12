namespace Ej3
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
            label1 = new Label();
            TBvalor = new TextBox();
            BTNcancelar = new Button();
            SuspendLayout();
            // 
            // BTNaceptar
            // 
            BTNaceptar.DialogResult = DialogResult.OK;
            BTNaceptar.Location = new Point(132, 86);
            BTNaceptar.Name = "BTNaceptar";
            BTNaceptar.Size = new Size(94, 29);
            BTNaceptar.TabIndex = 0;
            BTNaceptar.Text = "Aceptar";
            BTNaceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 29);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 1;
            label1.Text = "valor";
            // 
            // TBvalor
            // 
            TBvalor.Location = new Point(101, 26);
            TBvalor.Name = "TBvalor";
            TBvalor.Size = new Size(125, 27);
            TBvalor.TabIndex = 2;
            // 
            // BTNcancelar
            // 
            BTNcancelar.DialogResult = DialogResult.Cancel;
            BTNcancelar.Location = new Point(12, 86);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(94, 29);
            BTNcancelar.TabIndex = 3;
            BTNcancelar.Text = "Cancelar";
            BTNcancelar.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 143);
            Controls.Add(BTNcancelar);
            Controls.Add(TBvalor);
            Controls.Add(label1);
            Controls.Add(BTNaceptar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNaceptar;
        private Label label1;
        private Button BTNcancelar;
        public TextBox TBvalor;
    }
}
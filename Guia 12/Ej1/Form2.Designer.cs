namespace Ej1
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
            BTNcancelar = new Button();
            BTNaceptar = new Button();
            TBvalor = new TextBox();
            LBvalor = new Label();
            SuspendLayout();
            // 
            // BTNcancelar
            // 
            BTNcancelar.DialogResult = DialogResult.Cancel;
            BTNcancelar.Location = new Point(52, 103);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(124, 65);
            BTNcancelar.TabIndex = 0;
            BTNcancelar.Text = "cancelar";
            BTNcancelar.UseVisualStyleBackColor = true;
            // 
            // BTNaceptar
            // 
            BTNaceptar.DialogResult = DialogResult.OK;
            BTNaceptar.Location = new Point(210, 103);
            BTNaceptar.Name = "BTNaceptar";
            BTNaceptar.Size = new Size(124, 65);
            BTNaceptar.TabIndex = 1;
            BTNaceptar.Text = "aceptar";
            BTNaceptar.UseVisualStyleBackColor = true;
            // 
            // TBvalor
            // 
            TBvalor.Location = new Point(105, 19);
            TBvalor.Name = "TBvalor";
            TBvalor.Size = new Size(188, 27);
            TBvalor.TabIndex = 2;
            // 
            // LBvalor
            // 
            LBvalor.AutoSize = true;
            LBvalor.Location = new Point(20, 26);
            LBvalor.Name = "LBvalor";
            LBvalor.Size = new Size(43, 20);
            LBvalor.TabIndex = 3;
            LBvalor.Text = "Valor";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 203);
            Controls.Add(LBvalor);
            Controls.Add(TBvalor);
            Controls.Add(BTNaceptar);
            Controls.Add(BTNcancelar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNcancelar;
        private Button BTNaceptar;
        private Label LBvalor;
        public TextBox TBvalor;
    }
}
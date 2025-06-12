namespace Ej2
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
            Aceptar = new Button();
            label1 = new Label();
            LBmostrarValor = new Label();
            SuspendLayout();
            // 
            // Aceptar
            // 
            Aceptar.DialogResult = DialogResult.OK;
            Aceptar.Location = new Point(141, 75);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(94, 29);
            Aceptar.TabIndex = 0;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 22);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 2;
            label1.Text = "valor ";
            // 
            // LBmostrarValor
            // 
            LBmostrarValor.Location = new Point(64, 22);
            LBmostrarValor.Name = "LBmostrarValor";
            LBmostrarValor.Size = new Size(254, 39);
            LBmostrarValor.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 116);
            Controls.Add(LBmostrarValor);
            Controls.Add(label1);
            Controls.Add(Aceptar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Aceptar;
        private Label label1;
        public Label LBmostrarValor;
    }
}
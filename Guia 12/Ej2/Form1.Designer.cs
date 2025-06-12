namespace Ej2
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
            BTNmostrarValor = new Button();
            TBvalor = new TextBox();
            LBvalor = new Label();
            SuspendLayout();
            // 
            // BTNmostrarValor
            // 
            BTNmostrarValor.Location = new Point(359, 27);
            BTNmostrarValor.Name = "BTNmostrarValor";
            BTNmostrarValor.Size = new Size(127, 29);
            BTNmostrarValor.TabIndex = 0;
            BTNmostrarValor.Text = "Mostrar Valor ";
            BTNmostrarValor.UseVisualStyleBackColor = true;
            BTNmostrarValor.Click += BTNmostrarValor_Click;
            // 
            // TBvalor
            // 
            TBvalor.Location = new Point(120, 28);
            TBvalor.Name = "TBvalor";
            TBvalor.Size = new Size(214, 27);
            TBvalor.TabIndex = 1;
            // 
            // LBvalor
            // 
            LBvalor.AutoSize = true;
            LBvalor.Location = new Point(41, 31);
            LBvalor.Name = "LBvalor";
            LBvalor.Size = new Size(42, 20);
            LBvalor.TabIndex = 2;
            LBvalor.Text = "valor";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 90);
            Controls.Add(LBvalor);
            Controls.Add(TBvalor);
            Controls.Add(BTNmostrarValor);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNmostrarValor;
        private TextBox TBvalor;
        private Label LBvalor;
    }
}

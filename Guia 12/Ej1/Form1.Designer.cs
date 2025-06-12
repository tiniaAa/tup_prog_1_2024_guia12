namespace Ej1
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
            BTNsolicitarValor = new Button();
            LBresultado = new Label();
            LBmostrar = new Label();
            TBingresarValor = new TextBox();
            SuspendLayout();
            // 
            // BTNsolicitarValor
            // 
            BTNsolicitarValor.Location = new Point(126, 44);
            BTNsolicitarValor.Name = "BTNsolicitarValor";
            BTNsolicitarValor.Size = new Size(330, 64);
            BTNsolicitarValor.TabIndex = 0;
            BTNsolicitarValor.Text = "Solicitar Valor ";
            BTNsolicitarValor.UseVisualStyleBackColor = true;
            BTNsolicitarValor.Click += button1_Click;
            // 
            // LBresultado
            // 
            LBresultado.AutoSize = true;
            LBresultado.Location = new Point(29, 157);
            LBresultado.Name = "LBresultado";
            LBresultado.Size = new Size(75, 20);
            LBresultado.TabIndex = 1;
            LBresultado.Text = "Resultado";
            // 
            // LBmostrar
            // 
            LBmostrar.BackColor = SystemColors.ActiveCaption;
            LBmostrar.Location = new Point(126, 157);
            LBmostrar.Name = "LBmostrar";
            LBmostrar.Size = new Size(330, 166);
            LBmostrar.TabIndex = 2;
            // 
            // TBingresarValor
            // 
            TBingresarValor.Location = new Point(500, 63);
            TBingresarValor.Name = "TBingresarValor";
            TBingresarValor.Size = new Size(190, 27);
            TBingresarValor.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(800, 450);
            Controls.Add(TBingresarValor);
            Controls.Add(LBmostrar);
            Controls.Add(LBresultado);
            Controls.Add(BTNsolicitarValor);
            Name = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BTNsolicitarValor;
        private Label LBresultado;
        private Label LBmostrar;
        private TextBox TBingresarValor;
    }
}

namespace SistemaSupermercado
{
    partial class FormNota
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
            txtNota = new TextBox();
            SuspendLayout();
            // 
            // txtNota
            // 
            txtNota.BackColor = SystemColors.Info;
            txtNota.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNota.Location = new Point(12, 12);
            txtNota.Multiline = true;
            txtNota.Name = "txtNota";
            txtNota.ReadOnly = true;
            txtNota.ScrollBars = ScrollBars.Vertical;
            txtNota.Size = new Size(460, 537);
            txtNota.TabIndex = 0;
            txtNota.TextChanged += txtNota_TextChanged;
            // 
            // FormNota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(484, 561);
            Controls.Add(txtNota);
            Name = "FormNota";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nota Fiscal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota;
    }
}
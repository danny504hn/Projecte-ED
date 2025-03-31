namespace ProjecteED
{
    partial class frmPrincipal1
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
            btnPolaca = new Button();
            SuspendLayout();
            // 
            // btnPolaca
            // 
            btnPolaca.Location = new Point(969, 297);
            btnPolaca.Name = "btnPolaca";
            btnPolaca.Size = new Size(201, 62);
            btnPolaca.TabIndex = 0;
            btnPolaca.Text = "anotacio Polaca";
            btnPolaca.UseVisualStyleBackColor = true;
            btnPolaca.Click += btnPolaca_Click;
            // 
            // frmPrincipal1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 513);
            Controls.Add(btnPolaca);
            Name = "frmPrincipal1";
            Text = "frmPrincipal1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPolaca;
    }
}
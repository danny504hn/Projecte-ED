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
            btnValidacio = new Button();
            SuspendLayout();
            // 
            // btnPolaca
            // 
            btnPolaca.Location = new Point(146, 106);
            btnPolaca.Margin = new Padding(3, 2, 3, 2);
            btnPolaca.Name = "btnPolaca";
            btnPolaca.Size = new Size(176, 46);
            btnPolaca.TabIndex = 0;
            btnPolaca.Text = "anotacio Polaca";
            btnPolaca.UseVisualStyleBackColor = true;
            btnPolaca.Click += btnPolaca_Click;
            // 
            // btnValidacio
            // 
            btnValidacio.Location = new Point(662, 106);
            btnValidacio.Name = "btnValidacio";
            btnValidacio.Size = new Size(176, 46);
            btnValidacio.TabIndex = 1;
            btnValidacio.Text = "Compilador";
            btnValidacio.UseVisualStyleBackColor = true;
            btnValidacio.Click += btnValidacio_Click;
            // 
            // frmPrincipal1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 385);
            Controls.Add(btnValidacio);
            Controls.Add(btnPolaca);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal1";
            Text = "frmPrincipal1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnPolaca;
        private Button btnValidacio;
    }
}
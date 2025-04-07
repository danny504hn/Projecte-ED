namespace ProjecteED
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
            btnValidar = new Button();
            txtExpressio = new TextBox();
            lblExpressio = new Label();
            SuspendLayout();
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(854, 44);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(166, 63);
            btnValidar.TabIndex = 0;
            btnValidar.Text = "Validar expressió";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // txtExpressio
            // 
            txtExpressio.Location = new Point(487, 62);
            txtExpressio.Name = "txtExpressio";
            txtExpressio.Size = new Size(189, 27);
            txtExpressio.TabIndex = 1;
            txtExpressio.TextChanged += txtExpressio_TextChanged;
            // 
            // lblExpressio
            // 
            lblExpressio.AutoSize = true;
            lblExpressio.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblExpressio.Location = new Point(331, 56);
            lblExpressio.Name = "lblExpressio";
            lblExpressio.Size = new Size(110, 31);
            lblExpressio.TabIndex = 2;
            lblExpressio.Text = "Expressió";
            lblExpressio.Click += lblExpressio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1173, 549);
            Controls.Add(lblExpressio);
            Controls.Add(txtExpressio);
            Controls.Add(btnValidar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnValidar;
        private TextBox txtExpressio;
        private Label lblExpressio;
    }
}

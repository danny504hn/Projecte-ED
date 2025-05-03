namespace ProjecteED
{
    partial class calculadora
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
            numUno = new Button();
            numDos = new Button();
            numTres = new Button();
            multiplicar = new Button();
            numQuatre = new Button();
            resta = new Button();
            numSis = new Button();
            numCinc = new Button();
            suma = new Button();
            numNou = new Button();
            numVuit = new Button();
            numSet = new Button();
            divisio = new Button();
            borrar = new Button();
            rentar = new Button();
            numZero = new Button();
            total = new Button();
            pantalla = new TextBox();
            btnClose = new Button();
            SuspendLayout();
            // 
            // numUno
            // 
            numUno.Location = new Point(133, 418);
            numUno.Name = "numUno";
            numUno.Size = new Size(242, 69);
            numUno.TabIndex = 0;
            numUno.Text = "1";
            numUno.UseVisualStyleBackColor = true;
            numUno.Click += NumberOnClick;
            // 
            // numDos
            // 
            numDos.Location = new Point(394, 418);
            numDos.Name = "numDos";
            numDos.Size = new Size(242, 69);
            numDos.TabIndex = 1;
            numDos.Text = "2";
            numDos.UseVisualStyleBackColor = true;
            numDos.Click += NumberOnClick;
            // 
            // numTres
            // 
            numTres.Location = new Point(656, 418);
            numTres.Name = "numTres";
            numTres.Size = new Size(242, 69);
            numTres.TabIndex = 3;
            numTres.Text = "3";
            numTres.UseVisualStyleBackColor = true;
            numTres.Click += NumberOnClick;
            // 
            // multiplicar
            // 
            multiplicar.Location = new Point(925, 418);
            multiplicar.Name = "multiplicar";
            multiplicar.Size = new Size(242, 69);
            multiplicar.TabIndex = 2;
            multiplicar.Text = "*";
            multiplicar.UseVisualStyleBackColor = true;
            multiplicar.Click += OperatorOnClick;
            // 
            // numQuatre
            // 
            numQuatre.Location = new Point(133, 333);
            numQuatre.Name = "numQuatre";
            numQuatre.Size = new Size(242, 69);
            numQuatre.TabIndex = 7;
            numQuatre.Text = "4";
            numQuatre.UseVisualStyleBackColor = true;
            numQuatre.Click += NumberOnClick;
            // 
            // resta
            // 
            resta.Location = new Point(925, 333);
            resta.Name = "resta";
            resta.Size = new Size(242, 69);
            resta.TabIndex = 6;
            resta.Text = "-";
            resta.UseVisualStyleBackColor = true;
            resta.Click += OperatorOnClick;
            // 
            // numSis
            // 
            numSis.Location = new Point(656, 333);
            numSis.Name = "numSis";
            numSis.Size = new Size(242, 69);
            numSis.TabIndex = 5;
            numSis.Text = "6";
            numSis.UseVisualStyleBackColor = true;
            numSis.Click += NumberOnClick;
            // 
            // numCinc
            // 
            numCinc.Location = new Point(394, 333);
            numCinc.Name = "numCinc";
            numCinc.Size = new Size(242, 69);
            numCinc.TabIndex = 4;
            numCinc.Text = "5";
            numCinc.UseVisualStyleBackColor = true;
            numCinc.Click += NumberOnClick;
            // 
            // suma
            // 
            suma.Location = new Point(925, 244);
            suma.Name = "suma";
            suma.Size = new Size(242, 69);
            suma.TabIndex = 11;
            suma.Text = "+";
            suma.UseVisualStyleBackColor = true;
            suma.Click += OperatorOnClick;
            // 
            // numNou
            // 
            numNou.Location = new Point(656, 244);
            numNou.Name = "numNou";
            numNou.Size = new Size(242, 69);
            numNou.TabIndex = 10;
            numNou.Text = "9";
            numNou.UseVisualStyleBackColor = true;
            numNou.Click += NumberOnClick;
            // 
            // numVuit
            // 
            numVuit.Location = new Point(394, 244);
            numVuit.Name = "numVuit";
            numVuit.Size = new Size(242, 69);
            numVuit.TabIndex = 9;
            numVuit.Text = "8";
            numVuit.UseVisualStyleBackColor = true;
            numVuit.Click += NumberOnClick;
            // 
            // numSet
            // 
            numSet.Location = new Point(133, 244);
            numSet.Name = "numSet";
            numSet.Size = new Size(242, 69);
            numSet.TabIndex = 8;
            numSet.Text = "7";
            numSet.UseVisualStyleBackColor = true;
            numSet.Click += NumberOnClick;
            // 
            // divisio
            // 
            divisio.Location = new Point(925, 155);
            divisio.Name = "divisio";
            divisio.Size = new Size(242, 69);
            divisio.TabIndex = 15;
            divisio.Text = "/";
            divisio.UseVisualStyleBackColor = true;
            divisio.Click += OperatorOnClick;
            // 
            // borrar
            // 
            borrar.Location = new Point(656, 155);
            borrar.Name = "borrar";
            borrar.Size = new Size(242, 69);
            borrar.TabIndex = 14;
            borrar.Text = "Borrar";
            borrar.UseVisualStyleBackColor = true;
            borrar.Click += borrar_Click;
            // 
            // rentar
            // 
            rentar.Location = new Point(394, 155);
            rentar.Name = "rentar";
            rentar.Size = new Size(242, 69);
            rentar.TabIndex = 13;
            rentar.Text = "AC";
            rentar.UseVisualStyleBackColor = true;
            rentar.Click += rentar_Click;
            // 
            // numZero
            // 
            numZero.AccessibleName = "";
            numZero.BackColor = SystemColors.ControlLight;
            numZero.Location = new Point(133, 503);
            numZero.Name = "numZero";
            numZero.Size = new Size(765, 67);
            numZero.TabIndex = 12;
            numZero.Text = "0";
            numZero.UseVisualStyleBackColor = false;
            numZero.Click += NumberOnClick;
            // 
            // total
            // 
            total.Location = new Point(925, 503);
            total.Name = "total";
            total.Size = new Size(242, 67);
            total.TabIndex = 16;
            total.Text = "=";
            total.UseVisualStyleBackColor = true;
            total.Click += total_Click;
            // 
            // pantalla
            // 
            pantalla.Location = new Point(133, 80);
            pantalla.Multiline = true;
            pantalla.Name = "pantalla";
            pantalla.Size = new Size(1034, 54);
            pantalla.TabIndex = 17;
            pantalla.TextChanged += pantalla_TextChanged;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(1297, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(164, 54);
            btnClose.TabIndex = 18;
            btnClose.Text = "btnClose";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // calculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1473, 644);
            Controls.Add(btnClose);
            Controls.Add(pantalla);
            Controls.Add(total);
            Controls.Add(divisio);
            Controls.Add(borrar);
            Controls.Add(rentar);
            Controls.Add(numZero);
            Controls.Add(suma);
            Controls.Add(numNou);
            Controls.Add(numVuit);
            Controls.Add(numSet);
            Controls.Add(numQuatre);
            Controls.Add(resta);
            Controls.Add(numSis);
            Controls.Add(numCinc);
            Controls.Add(numTres);
            Controls.Add(multiplicar);
            Controls.Add(numDos);
            Controls.Add(numUno);
            Name = "calculadora";
            Text = "calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button numUno;
        private Button numDos;
        private Button numTres;
        private Button multiplicar;
        private Button numQuatre;
        private Button resta;
        private Button numSis;
        private Button numCinc;
        private Button suma;
        private Button numNou;
        private Button numVuit;
        private Button numSet;
        private Button divisio;
        private Button borrar;
        private Button rentar;
        private Button numZero;
        private Button total;
        private TextBox pantalla;
        private Button btnClose;
    }
}
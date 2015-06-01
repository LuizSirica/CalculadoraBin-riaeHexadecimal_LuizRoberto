namespace CalculadoraBináriaeHexadecimal
{
    partial class Form1
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.nadanada = new System.Windows.Forms.Label();
            this.caixaresultado = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.TextBox();
            this.Binário = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.Binário.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage1.Controls.Add(this.nadanada);
            this.tabPage1.Controls.Add(this.caixaresultado);
            this.tabPage1.Controls.Add(this.button11);
            this.tabPage1.Controls.Add(this.button10);
            this.tabPage1.Controls.Add(this.button9);
            this.tabPage1.Controls.Add(this.button8);
            this.tabPage1.Controls.Add(this.button7);
            this.tabPage1.Controls.Add(this.button6);
            this.tabPage1.Controls.Add(this.button5);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.numero);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(279, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CalculadoraBinária";
            // 
            // nadanada
            // 
            this.nadanada.AutoSize = true;
            this.nadanada.Location = new System.Drawing.Point(7, 71);
            this.nadanada.Name = "nadanada";
            this.nadanada.Size = new System.Drawing.Size(55, 13);
            this.nadanada.TabIndex = 16;
            this.nadanada.Text = "Resposta:";
            // 
            // caixaresultado
            // 
            this.caixaresultado.AutoSize = true;
            this.caixaresultado.Location = new System.Drawing.Point(68, 71);
            this.caixaresultado.Name = "caixaresultado";
            this.caixaresultado.Size = new System.Drawing.Size(0, 13);
            this.caixaresultado.TabIndex = 15;
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button11.Location = new System.Drawing.Point(140, 264);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(125, 46);
            this.button11.TabIndex = 14;
            this.button11.Text = "C";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.c_Button);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button10.Location = new System.Drawing.Point(10, 316);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(255, 80);
            this.button10.TabIndex = 13;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.igual);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button9.Location = new System.Drawing.Point(10, 264);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(124, 46);
            this.button9.TabIndex = 12;
            this.button9.Text = "←";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.delete);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button8.Location = new System.Drawing.Point(140, 156);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 50);
            this.button8.TabIndex = 11;
            this.button8.Text = "/";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.divisao);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button7.Location = new System.Drawing.Point(215, 156);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 50);
            this.button7.TabIndex = 10;
            this.button7.Text = "*";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.multiplicacao);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button6.Location = new System.Drawing.Point(10, 156);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 50);
            this.button6.TabIndex = 9;
            this.button6.Text = "-";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.subtracao);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button5.Location = new System.Drawing.Point(84, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 50);
            this.button5.TabIndex = 8;
            this.button5.Text = "+";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.soma);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(140, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 46);
            this.button4.TabIndex = 7;
            this.button4.Text = "Converter em Hexadecimal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.toHexa);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(10, 212);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "Converter em Decimal";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.toDecimal);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(140, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.um_Button);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(10, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.zero_Button);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Escreva o valor em binário";
            // 
            // numero
            // 
            this.numero.Location = new System.Drawing.Point(7, 39);
            this.numero.Name = "numero";
            this.numero.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.numero.Size = new System.Drawing.Size(258, 20);
            this.numero.TabIndex = 0;
            // 
            // Binário
            // 
            this.Binário.Controls.Add(this.tabPage1);
            this.Binário.Location = new System.Drawing.Point(1, 1);
            this.Binário.Name = "Binário";
            this.Binário.SelectedIndex = 0;
            this.Binário.Size = new System.Drawing.Size(287, 445);
            this.Binário.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(289, 449);
            this.Controls.Add(this.Binário);
            this.Name = "Form1";
            this.Text = "CalculadoraBináriaeHexadecimal";
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.Binário.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label nadanada;
        private System.Windows.Forms.Label caixaresultado;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numero;
        private System.Windows.Forms.TabControl Binário;

    }
}


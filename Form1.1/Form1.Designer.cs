
namespace Form1._1
{
    partial class Calculo
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
            this.textValor1 = new System.Windows.Forms.TextBox();
            this.textValor2 = new System.Windows.Forms.TextBox();
            this.label1Titulo = new System.Windows.Forms.Label();
            this.label2Valor1 = new System.Windows.Forms.Label();
            this.label3Valor2 = new System.Windows.Forms.Label();
            this.label4Resultado = new System.Windows.Forms.Label();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.bntcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textValor1
            // 
            this.textValor1.Location = new System.Drawing.Point(122, 74);
            this.textValor1.Name = "textValor1";
            this.textValor1.Size = new System.Drawing.Size(125, 23);
            this.textValor1.TabIndex = 0;
            // 
            // textValor2
            // 
            this.textValor2.Location = new System.Drawing.Point(122, 127);
            this.textValor2.Name = "textValor2";
            this.textValor2.Size = new System.Drawing.Size(125, 23);
            this.textValor2.TabIndex = 1;
            // 
            // label1Titulo
            // 
            this.label1Titulo.AutoSize = true;
            this.label1Titulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1Titulo.Location = new System.Drawing.Point(65, 35);
            this.label1Titulo.Name = "label1Titulo";
            this.label1Titulo.Size = new System.Drawing.Size(126, 21);
            this.label1Titulo.TabIndex = 2;
            this.label1Titulo.Text = "Calculo da Soma";
            // 
            // label2Valor1
            // 
            this.label2Valor1.AutoSize = true;
            this.label2Valor1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2Valor1.Location = new System.Drawing.Point(36, 78);
            this.label2Valor1.Name = "label2Valor1";
            this.label2Valor1.Size = new System.Drawing.Size(48, 19);
            this.label2Valor1.TabIndex = 3;
            this.label2Valor1.Text = "Valor1";
            // 
            // label3Valor2
            // 
            this.label3Valor2.AutoSize = true;
            this.label3Valor2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3Valor2.Location = new System.Drawing.Point(33, 131);
            this.label3Valor2.Name = "label3Valor2";
            this.label3Valor2.Size = new System.Drawing.Size(48, 19);
            this.label3Valor2.TabIndex = 4;
            this.label3Valor2.Text = "Valor2";
            // 
            // label4Resultado
            // 
            this.label4Resultado.AutoSize = true;
            this.label4Resultado.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4Resultado.Location = new System.Drawing.Point(27, 183);
            this.label4Resultado.Name = "label4Resultado";
            this.label4Resultado.Size = new System.Drawing.Size(69, 19);
            this.label4Resultado.TabIndex = 5;
            this.label4Resultado.Text = "Resultado";
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(122, 175);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(125, 23);
            this.textResultado.TabIndex = 6;
            // 
            // bntcalcular
            // 
            this.bntcalcular.Location = new System.Drawing.Point(85, 231);
            this.bntcalcular.Name = "bntcalcular";
            this.bntcalcular.Size = new System.Drawing.Size(75, 23);
            this.bntcalcular.TabIndex = 7;
            this.bntcalcular.Text = "Calcular";
            this.bntcalcular.UseVisualStyleBackColor = true;
            this.bntcalcular.Click += new System.EventHandler(this.bntcalcular_Click);
            // 
            // Calculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 306);
            this.Controls.Add(this.bntcalcular);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.label4Resultado);
            this.Controls.Add(this.label3Valor2);
            this.Controls.Add(this.label2Valor1);
            this.Controls.Add(this.label1Titulo);
            this.Controls.Add(this.textValor2);
            this.Controls.Add(this.textValor1);
            this.Name = "Calculo";
            this.Text = "Calculo da Soma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textValor1;
        private System.Windows.Forms.TextBox textValor2;
        private System.Windows.Forms.Label label1Titulo;
        private System.Windows.Forms.Label label2Valor1;
        private System.Windows.Forms.Label label3Valor2;
        private System.Windows.Forms.Label label4Resultado;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button bntcalcular;
    }
}


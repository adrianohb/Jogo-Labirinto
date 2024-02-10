namespace Jogo_Labirinto
{
    partial class Tela3Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDIR3 = new System.Windows.Forms.Button();
            this.btnBAIXO3 = new System.Windows.Forms.Button();
            this.btnCIMA3 = new System.Windows.Forms.Button();
            this.btnESQ3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(180, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 69);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dica para seu próximo movimento. \r\nQual parte do tapete \r\nnão se deve colocar a s" +
    "ujeira?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDIR3
            // 
            this.btnDIR3.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDIR3.Location = new System.Drawing.Point(657, 156);
            this.btnDIR3.Name = "btnDIR3";
            this.btnDIR3.Size = new System.Drawing.Size(131, 139);
            this.btnDIR3.TabIndex = 11;
            this.btnDIR3.Text = "DIREITA";
            this.btnDIR3.UseVisualStyleBackColor = true;
            this.btnDIR3.Click += new System.EventHandler(this.btnDIR3_Click);
            // 
            // btnBAIXO3
            // 
            this.btnBAIXO3.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBAIXO3.Location = new System.Drawing.Point(307, 355);
            this.btnBAIXO3.Name = "btnBAIXO3";
            this.btnBAIXO3.Size = new System.Drawing.Size(186, 83);
            this.btnBAIXO3.TabIndex = 10;
            this.btnBAIXO3.Text = "BAIXO";
            this.btnBAIXO3.UseVisualStyleBackColor = true;
            this.btnBAIXO3.Click += new System.EventHandler(this.btnBAIXO3_Click);
            // 
            // btnCIMA3
            // 
            this.btnCIMA3.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIMA3.Location = new System.Drawing.Point(307, 12);
            this.btnCIMA3.Name = "btnCIMA3";
            this.btnCIMA3.Size = new System.Drawing.Size(186, 83);
            this.btnCIMA3.TabIndex = 9;
            this.btnCIMA3.Text = "CIMA";
            this.btnCIMA3.UseVisualStyleBackColor = true;
            this.btnCIMA3.Click += new System.EventHandler(this.btnCIMA3_Click);
            // 
            // btnESQ3
            // 
            this.btnESQ3.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESQ3.Location = new System.Drawing.Point(12, 156);
            this.btnESQ3.Name = "btnESQ3";
            this.btnESQ3.Size = new System.Drawing.Size(131, 139);
            this.btnESQ3.TabIndex = 8;
            this.btnESQ3.Text = "ESQUERDA";
            this.btnESQ3.UseVisualStyleBackColor = true;
            this.btnESQ3.Click += new System.EventHandler(this.btnESQ3_Click);
            // 
            // Tela3Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDIR3);
            this.Controls.Add(this.btnBAIXO3);
            this.Controls.Add(this.btnCIMA3);
            this.Controls.Add(this.btnESQ3);
            this.MaximizeBox = false;
            this.Name = "Tela3Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..: Jogo do labirinto :..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDIR3;
        private System.Windows.Forms.Button btnBAIXO3;
        private System.Windows.Forms.Button btnCIMA3;
        private System.Windows.Forms.Button btnESQ3;
    }
}
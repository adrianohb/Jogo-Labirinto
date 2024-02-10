namespace Jogo_Labirinto
{
    partial class Tela4Form
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
            this.btnDIR4 = new System.Windows.Forms.Button();
            this.btnBAIXO4 = new System.Windows.Forms.Button();
            this.btnCIMA4 = new System.Windows.Forms.Button();
            this.btnESQ4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDIR4
            // 
            this.btnDIR4.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDIR4.Location = new System.Drawing.Point(657, 156);
            this.btnDIR4.Name = "btnDIR4";
            this.btnDIR4.Size = new System.Drawing.Size(131, 139);
            this.btnDIR4.TabIndex = 11;
            this.btnDIR4.Text = "DIREITA";
            this.btnDIR4.UseVisualStyleBackColor = true;
            this.btnDIR4.Click += new System.EventHandler(this.btnDIR4_Click);
            // 
            // btnBAIXO4
            // 
            this.btnBAIXO4.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBAIXO4.Location = new System.Drawing.Point(307, 355);
            this.btnBAIXO4.Name = "btnBAIXO4";
            this.btnBAIXO4.Size = new System.Drawing.Size(186, 83);
            this.btnBAIXO4.TabIndex = 10;
            this.btnBAIXO4.Text = "BAIXO";
            this.btnBAIXO4.UseVisualStyleBackColor = true;
            this.btnBAIXO4.Click += new System.EventHandler(this.btnBAIXO4_Click);
            // 
            // btnCIMA4
            // 
            this.btnCIMA4.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIMA4.Location = new System.Drawing.Point(307, 12);
            this.btnCIMA4.Name = "btnCIMA4";
            this.btnCIMA4.Size = new System.Drawing.Size(186, 83);
            this.btnCIMA4.TabIndex = 9;
            this.btnCIMA4.Text = "CIMA";
            this.btnCIMA4.UseVisualStyleBackColor = true;
            this.btnCIMA4.Click += new System.EventHandler(this.btnCIMA4_Click);
            // 
            // btnESQ4
            // 
            this.btnESQ4.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESQ4.Location = new System.Drawing.Point(12, 156);
            this.btnESQ4.Name = "btnESQ4";
            this.btnESQ4.Size = new System.Drawing.Size(131, 139);
            this.btnESQ4.TabIndex = 8;
            this.btnESQ4.Text = "ESQUERDA";
            this.btnESQ4.UseVisualStyleBackColor = true;
            this.btnESQ4.Click += new System.EventHandler(this.btnESQ4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(174, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Você está quase lá... Não desista!";
            // 
            // Tela4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDIR4);
            this.Controls.Add(this.btnBAIXO4);
            this.Controls.Add(this.btnCIMA4);
            this.Controls.Add(this.btnESQ4);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.Name = "Tela4Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..: Jogo do labirinto :..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnDIR4;
        private System.Windows.Forms.Button btnBAIXO4;
        private System.Windows.Forms.Button btnCIMA4;
        private System.Windows.Forms.Button btnESQ4;
        private System.Windows.Forms.Label label1;
    }
}
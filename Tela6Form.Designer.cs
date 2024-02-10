namespace Jogo_Labirinto
{
    partial class Tela6Form
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
            this.btnDIR6 = new System.Windows.Forms.Button();
            this.btnBAIXO6 = new System.Windows.Forms.Button();
            this.btnCIMA6 = new System.Windows.Forms.Button();
            this.btnESQ6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(190, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "CUIDADO! A direita é contramão!";
            // 
            // btnDIR6
            // 
            this.btnDIR6.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDIR6.Location = new System.Drawing.Point(657, 156);
            this.btnDIR6.Name = "btnDIR6";
            this.btnDIR6.Size = new System.Drawing.Size(131, 139);
            this.btnDIR6.TabIndex = 11;
            this.btnDIR6.Text = "DIREITA";
            this.btnDIR6.UseVisualStyleBackColor = true;
            this.btnDIR6.Click += new System.EventHandler(this.btnDIR6_Click);
            // 
            // btnBAIXO6
            // 
            this.btnBAIXO6.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBAIXO6.Location = new System.Drawing.Point(307, 355);
            this.btnBAIXO6.Name = "btnBAIXO6";
            this.btnBAIXO6.Size = new System.Drawing.Size(186, 83);
            this.btnBAIXO6.TabIndex = 10;
            this.btnBAIXO6.Text = "BAIXO";
            this.btnBAIXO6.UseVisualStyleBackColor = true;
            this.btnBAIXO6.Click += new System.EventHandler(this.btnBAIXO6_Click);
            // 
            // btnCIMA6
            // 
            this.btnCIMA6.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIMA6.Location = new System.Drawing.Point(307, 12);
            this.btnCIMA6.Name = "btnCIMA6";
            this.btnCIMA6.Size = new System.Drawing.Size(186, 83);
            this.btnCIMA6.TabIndex = 9;
            this.btnCIMA6.Text = "CIMA";
            this.btnCIMA6.UseVisualStyleBackColor = true;
            this.btnCIMA6.Click += new System.EventHandler(this.btnCIMA6_Click);
            // 
            // btnESQ6
            // 
            this.btnESQ6.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESQ6.Location = new System.Drawing.Point(12, 156);
            this.btnESQ6.Name = "btnESQ6";
            this.btnESQ6.Size = new System.Drawing.Size(131, 139);
            this.btnESQ6.TabIndex = 8;
            this.btnESQ6.Text = "ESQUERDA";
            this.btnESQ6.UseVisualStyleBackColor = true;
            this.btnESQ6.Click += new System.EventHandler(this.btnESQ6_Click);
            // 
            // Tela6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDIR6);
            this.Controls.Add(this.btnBAIXO6);
            this.Controls.Add(this.btnCIMA6);
            this.Controls.Add(this.btnESQ6);
            this.MaximizeBox = false;
            this.Name = "Tela6Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..: Jogo do labirinto :..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDIR6;
        private System.Windows.Forms.Button btnBAIXO6;
        private System.Windows.Forms.Button btnCIMA6;
        private System.Windows.Forms.Button btnESQ6;
    }
}
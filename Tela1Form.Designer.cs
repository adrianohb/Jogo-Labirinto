namespace Jogo_Labirinto
{
    partial class Tela1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela1Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnESQ1 = new System.Windows.Forms.Button();
            this.btnCIMA1 = new System.Windows.Forms.Button();
            this.btnBAIXO1 = new System.Windows.Forms.Button();
            this.btnDIR1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 245);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnESQ1
            // 
            this.btnESQ1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESQ1.Location = new System.Drawing.Point(12, 156);
            this.btnESQ1.Name = "btnESQ1";
            this.btnESQ1.Size = new System.Drawing.Size(131, 139);
            this.btnESQ1.TabIndex = 1;
            this.btnESQ1.Text = "ESQUERDA";
            this.btnESQ1.UseVisualStyleBackColor = true;
            this.btnESQ1.Click += new System.EventHandler(this.btnESQ1_Click);
            // 
            // btnCIMA1
            // 
            this.btnCIMA1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIMA1.Location = new System.Drawing.Point(307, 12);
            this.btnCIMA1.Name = "btnCIMA1";
            this.btnCIMA1.Size = new System.Drawing.Size(186, 83);
            this.btnCIMA1.TabIndex = 3;
            this.btnCIMA1.Text = "CIMA";
            this.btnCIMA1.UseVisualStyleBackColor = true;
            this.btnCIMA1.Click += new System.EventHandler(this.btnCIMA1_Click);
            // 
            // btnBAIXO1
            // 
            this.btnBAIXO1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBAIXO1.Location = new System.Drawing.Point(307, 355);
            this.btnBAIXO1.Name = "btnBAIXO1";
            this.btnBAIXO1.Size = new System.Drawing.Size(186, 83);
            this.btnBAIXO1.TabIndex = 4;
            this.btnBAIXO1.Text = "BAIXO";
            this.btnBAIXO1.UseVisualStyleBackColor = true;
            this.btnBAIXO1.Click += new System.EventHandler(this.btnBAIXO1_Click);
            // 
            // btnDIR1
            // 
            this.btnDIR1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDIR1.Location = new System.Drawing.Point(657, 156);
            this.btnDIR1.Name = "btnDIR1";
            this.btnDIR1.Size = new System.Drawing.Size(131, 139);
            this.btnDIR1.TabIndex = 5;
            this.btnDIR1.Text = "DIREITA";
            this.btnDIR1.UseVisualStyleBackColor = true;
            this.btnDIR1.Click += new System.EventHandler(this.btnDIR1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "Qual seu próximo movimento?";
            // 
            // Tela1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDIR1);
            this.Controls.Add(this.btnBAIXO1);
            this.Controls.Add(this.btnCIMA1);
            this.Controls.Add(this.btnESQ1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Tela1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..: Jogo do labirinto :..";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnESQ1;
        private System.Windows.Forms.Button btnCIMA1;
        private System.Windows.Forms.Button btnBAIXO1;
        private System.Windows.Forms.Button btnDIR1;
        private System.Windows.Forms.Label label1;
    }
}
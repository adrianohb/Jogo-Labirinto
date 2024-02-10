namespace Jogo_Labirinto
{
    partial class Tela5Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tela5Form));
            this.label1 = new System.Windows.Forms.Label();
            this.btnDIR5 = new System.Windows.Forms.Button();
            this.btnBAIXO5 = new System.Windows.Forms.Button();
            this.btnCIMA5 = new System.Windows.Forms.Button();
            this.btnESQ5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Qual seu próximo movimento?";
            // 
            // btnDIR5
            // 
            this.btnDIR5.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDIR5.Location = new System.Drawing.Point(657, 156);
            this.btnDIR5.Name = "btnDIR5";
            this.btnDIR5.Size = new System.Drawing.Size(131, 139);
            this.btnDIR5.TabIndex = 11;
            this.btnDIR5.Text = "DIREITA";
            this.btnDIR5.UseVisualStyleBackColor = true;
            this.btnDIR5.Click += new System.EventHandler(this.btnDIR5_Click);
            // 
            // btnBAIXO5
            // 
            this.btnBAIXO5.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBAIXO5.Location = new System.Drawing.Point(307, 355);
            this.btnBAIXO5.Name = "btnBAIXO5";
            this.btnBAIXO5.Size = new System.Drawing.Size(186, 83);
            this.btnBAIXO5.TabIndex = 10;
            this.btnBAIXO5.Text = "BAIXO";
            this.btnBAIXO5.UseVisualStyleBackColor = true;
            this.btnBAIXO5.Click += new System.EventHandler(this.btnBAIXO5_Click);
            // 
            // btnCIMA5
            // 
            this.btnCIMA5.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIMA5.Location = new System.Drawing.Point(307, 12);
            this.btnCIMA5.Name = "btnCIMA5";
            this.btnCIMA5.Size = new System.Drawing.Size(186, 83);
            this.btnCIMA5.TabIndex = 9;
            this.btnCIMA5.Text = "CIMA";
            this.btnCIMA5.UseVisualStyleBackColor = true;
            this.btnCIMA5.Click += new System.EventHandler(this.btnCIMA5_Click);
            // 
            // btnESQ5
            // 
            this.btnESQ5.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESQ5.Location = new System.Drawing.Point(12, 156);
            this.btnESQ5.Name = "btnESQ5";
            this.btnESQ5.Size = new System.Drawing.Size(131, 139);
            this.btnESQ5.TabIndex = 8;
            this.btnESQ5.Text = "ESQUERDA";
            this.btnESQ5.UseVisualStyleBackColor = true;
            this.btnESQ5.Click += new System.EventHandler(this.btnESQ5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 245);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Tela5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDIR5);
            this.Controls.Add(this.btnBAIXO5);
            this.Controls.Add(this.btnCIMA5);
            this.Controls.Add(this.btnESQ5);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "Tela5Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..: Jogo do labirinto :..";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDIR5;
        private System.Windows.Forms.Button btnBAIXO5;
        private System.Windows.Forms.Button btnCIMA5;
        private System.Windows.Forms.Button btnESQ5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
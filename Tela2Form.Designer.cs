namespace Jogo_Labirinto
{
    partial class Tela2Form
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
            this.btnDIR2 = new System.Windows.Forms.Button();
            this.btnBAIXO2 = new System.Windows.Forms.Button();
            this.btnCIMA2 = new System.Windows.Forms.Button();
            this.btnESQ2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(764, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "Resolva a charada abaixo para tentar seu próximo movimento";
            // 
            // btnDIR2
            // 
            this.btnDIR2.Enabled = false;
            this.btnDIR2.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDIR2.Location = new System.Drawing.Point(657, 156);
            this.btnDIR2.Name = "btnDIR2";
            this.btnDIR2.Size = new System.Drawing.Size(131, 139);
            this.btnDIR2.TabIndex = 11;
            this.btnDIR2.Text = "DIREITA";
            this.btnDIR2.UseVisualStyleBackColor = true;
            this.btnDIR2.Click += new System.EventHandler(this.btnDIR2_Click);
            // 
            // btnBAIXO2
            // 
            this.btnBAIXO2.Enabled = false;
            this.btnBAIXO2.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBAIXO2.Location = new System.Drawing.Point(307, 355);
            this.btnBAIXO2.Name = "btnBAIXO2";
            this.btnBAIXO2.Size = new System.Drawing.Size(186, 83);
            this.btnBAIXO2.TabIndex = 10;
            this.btnBAIXO2.Text = "BAIXO";
            this.btnBAIXO2.UseVisualStyleBackColor = true;
            this.btnBAIXO2.Click += new System.EventHandler(this.btnBAIXO2_Click);
            // 
            // btnCIMA2
            // 
            this.btnCIMA2.Enabled = false;
            this.btnCIMA2.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCIMA2.Location = new System.Drawing.Point(307, 12);
            this.btnCIMA2.Name = "btnCIMA2";
            this.btnCIMA2.Size = new System.Drawing.Size(186, 83);
            this.btnCIMA2.TabIndex = 9;
            this.btnCIMA2.Text = "CIMA";
            this.btnCIMA2.UseVisualStyleBackColor = true;
            this.btnCIMA2.Click += new System.EventHandler(this.btnCIMA2_Click);
            // 
            // btnESQ2
            // 
            this.btnESQ2.Enabled = false;
            this.btnESQ2.Font = new System.Drawing.Font("OCR A Extended", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnESQ2.Location = new System.Drawing.Point(12, 156);
            this.btnESQ2.Name = "btnESQ2";
            this.btnESQ2.Size = new System.Drawing.Size(131, 139);
            this.btnESQ2.TabIndex = 8;
            this.btnESQ2.Text = "ESQUERDA";
            this.btnESQ2.UseVisualStyleBackColor = true;
            this.btnESQ2.Click += new System.EventHandler(this.btnESQ2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 30);
            this.label2.TabIndex = 13;
            this.label2.Text = "Quanto é 12+9 ?";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(285, 233);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(81, 39);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "31";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("OCR A Extended", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(434, 233);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(81, 39);
            this.checkBox2.TabIndex = 15;
            this.checkBox2.Text = "21";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Tela2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDIR2);
            this.Controls.Add(this.btnBAIXO2);
            this.Controls.Add(this.btnCIMA2);
            this.Controls.Add(this.btnESQ2);
            this.MaximizeBox = false;
            this.Name = "Tela2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "..: Jogo do labirinto :..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDIR2;
        private System.Windows.Forms.Button btnBAIXO2;
        private System.Windows.Forms.Button btnCIMA2;
        private System.Windows.Forms.Button btnESQ2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}
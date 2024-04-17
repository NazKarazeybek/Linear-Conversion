namespace Linear_Conversion
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.convertLabel = new System.Windows.Forms.Label();
            this.enterLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.choiceBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.covertingButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.DarkOrchid;
            this.titleLabel.Location = new System.Drawing.Point(123, 45);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(343, 51);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Linear Conversion";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // convertLabel
            // 
            this.convertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convertLabel.Location = new System.Drawing.Point(164, 122);
            this.convertLabel.Name = "convertLabel";
            this.convertLabel.Size = new System.Drawing.Size(302, 186);
            this.convertLabel.TabIndex = 1;
            this.convertLabel.Text = "1. Inches to Centimeters\r\n\r\n2. Feet to Centimeters \r\n\r\n3. Yards to Meters\r\n\r\n4. M" +
    "iles to Kilometers";
            // 
            // enterLabel
            // 
            this.enterLabel.Location = new System.Drawing.Point(128, 353);
            this.enterLabel.Name = "enterLabel";
            this.enterLabel.Size = new System.Drawing.Size(241, 70);
            this.enterLabel.TabIndex = 2;
            this.enterLabel.Text = "Enter Conversion Choice (1-4):\r\n\r\nEnter Value To Be Converted:\r\n";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(273, 451);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 4;
            // 
            // choiceBox
            // 
            this.choiceBox.Location = new System.Drawing.Point(366, 353);
            this.choiceBox.Name = "choiceBox";
            this.choiceBox.Size = new System.Drawing.Size(100, 26);
            this.choiceBox.TabIndex = 5;
            // 
            // valueBox
            // 
            this.valueBox.Location = new System.Drawing.Point(366, 385);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(100, 26);
            this.valueBox.TabIndex = 6;
            // 
            // covertingButton
            // 
            this.covertingButton.Location = new System.Drawing.Point(47, 451);
            this.covertingButton.Name = "covertingButton";
            this.covertingButton.Size = new System.Drawing.Size(469, 35);
            this.covertingButton.TabIndex = 7;
            this.covertingButton.Text = "Convert";
            this.covertingButton.UseVisualStyleBackColor = true;
            this.covertingButton.Click += new System.EventHandler(this.covertingButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.Red;
            this.outputLabel.Location = new System.Drawing.Point(87, 499);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(395, 36);
            this.outputLabel.TabIndex = 8;
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(566, 544);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.covertingButton);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.choiceBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.enterLabel);
            this.Controls.Add(this.convertLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label convertLabel;
        private System.Windows.Forms.Label enterLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox choiceBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button covertingButton;
        private System.Windows.Forms.Label outputLabel;
    }
}


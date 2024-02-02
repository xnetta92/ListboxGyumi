namespace ListboxGyumi
{
    partial class FruitsAdd
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
            this.label_ProductCode = new System.Windows.Forms.Label();
            this.textBox_ProductCode = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.textBox_amount = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ProductCode
            // 
            this.label_ProductCode.AutoSize = true;
            this.label_ProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_ProductCode.Location = new System.Drawing.Point(22, 43);
            this.label_ProductCode.Name = "label_ProductCode";
            this.label_ProductCode.Size = new System.Drawing.Size(96, 18);
            this.label_ProductCode.TabIndex = 0;
            this.label_ProductCode.Text = "ProductCode";
            // 
            // textBox_ProductCode
            // 
            this.textBox_ProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_ProductCode.Location = new System.Drawing.Point(124, 39);
            this.textBox_ProductCode.Name = "textBox_ProductCode";
            this.textBox_ProductCode.ReadOnly = true;
            this.textBox_ProductCode.Size = new System.Drawing.Size(178, 26);
            this.textBox_ProductCode.TabIndex = 1;
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_name.Location = new System.Drawing.Point(22, 96);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(48, 18);
            this.label_name.TabIndex = 0;
            this.label_name.Text = "Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(124, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label_amount
            // 
            this.label_amount.AutoSize = true;
            this.label_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_amount.Location = new System.Drawing.Point(22, 158);
            this.label_amount.Name = "label_amount";
            this.label_amount.Size = new System.Drawing.Size(59, 18);
            this.label_amount.TabIndex = 0;
            this.label_amount.Text = "Amount";
            // 
            // textBox_amount
            // 
            this.textBox_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_amount.Location = new System.Drawing.Point(124, 154);
            this.textBox_amount.Name = "textBox_amount";
            this.textBox_amount.Size = new System.Drawing.Size(178, 26);
            this.textBox_amount.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FruitsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_amount);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox_ProductCode);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_ProductCode);
            this.Name = "FruitsAdd";
            this.Text = "FruitsAdd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ProductCode;
        private System.Windows.Forms.TextBox textBox_ProductCode;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.TextBox textBox_amount;
        private System.Windows.Forms.Button button1;
    }
}
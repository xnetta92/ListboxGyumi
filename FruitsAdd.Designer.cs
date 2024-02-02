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
            this.label_productCode = new System.Windows.Forms.Label();
            this.textBox_productCode = new System.Windows.Forms.TextBox();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label_amount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown_amount = new System.Windows.Forms.NumericUpDown();
            this.label_kg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).BeginInit();
            this.SuspendLayout();
            // 
            // label_productCode
            // 
            this.label_productCode.AutoSize = true;
            this.label_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_productCode.Location = new System.Drawing.Point(22, 43);
            this.label_productCode.Name = "label_productCode";
            this.label_productCode.Size = new System.Drawing.Size(96, 18);
            this.label_productCode.TabIndex = 0;
            this.label_productCode.Text = "ProductCode";
            // 
            // textBox_productCode
            // 
            this.textBox_productCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_productCode.Location = new System.Drawing.Point(124, 39);
            this.textBox_productCode.Name = "textBox_productCode";
            this.textBox_productCode.ReadOnly = true;
            this.textBox_productCode.Size = new System.Drawing.Size(155, 26);
            this.textBox_productCode.TabIndex = 1;
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
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_name.Location = new System.Drawing.Point(124, 96);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(178, 26);
            this.textBox_name.TabIndex = 1;
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 43);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_amount
            // 
            this.numericUpDown_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown_amount.Location = new System.Drawing.Point(124, 158);
            this.numericUpDown_amount.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDown_amount.Name = "numericUpDown_amount";
            this.numericUpDown_amount.Size = new System.Drawing.Size(155, 26);
            this.numericUpDown_amount.TabIndex = 3;
            // 
            // label_kg
            // 
            this.label_kg.AutoSize = true;
            this.label_kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_kg.Location = new System.Drawing.Point(285, 163);
            this.label_kg.Name = "label_kg";
            this.label_kg.Size = new System.Drawing.Size(22, 16);
            this.label_kg.TabIndex = 4;
            this.label_kg.Text = "kg";
            // 
            // FruitsAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 268);
            this.Controls.Add(this.label_kg);
            this.Controls.Add(this.numericUpDown_amount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.textBox_productCode);
            this.Controls.Add(this.label_amount);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.label_productCode);
            this.Name = "FruitsAdd";
            this.Text = "FruitsAdd";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_amount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_productCode;
        private System.Windows.Forms.TextBox textBox_productCode;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label_amount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown_amount;
        private System.Windows.Forms.Label label_kg;
    }
}
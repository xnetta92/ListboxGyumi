namespace ListboxGyumi
{
    partial class Form_Fruits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Fruits));
            this.listBox_Fruits = new System.Windows.Forms.ListBox();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.button_edit = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_Fruits
            // 
            this.listBox_Fruits.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox_Fruits.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox_Fruits.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listBox_Fruits.FormattingEnabled = true;
            this.listBox_Fruits.ItemHeight = 21;
            this.listBox_Fruits.Location = new System.Drawing.Point(0, 0);
            this.listBox_Fruits.Name = "listBox_Fruits";
            this.listBox_Fruits.Size = new System.Drawing.Size(349, 450);
            this.listBox_Fruits.TabIndex = 0;
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(441, 56);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(275, 48);
            this.button_upload.TabIndex = 1;
            this.button_upload.Text = "Upload";
            this.button_upload.UseVisualStyleBackColor = true;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(441, 123);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(275, 48);
            this.button_Save.TabIndex = 1;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            // 
            // button_New
            // 
            this.button_New.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_New.Location = new System.Drawing.Point(441, 188);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(275, 48);
            this.button_New.TabIndex = 1;
            this.button_New.Text = "New";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // button_edit
            // 
            this.button_edit.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_edit.Location = new System.Drawing.Point(441, 254);
            this.button_edit.Name = "button_edit";
            this.button_edit.Size = new System.Drawing.Size(275, 48);
            this.button_edit.TabIndex = 1;
            this.button_edit.Text = "Edit";
            this.button_edit.UseVisualStyleBackColor = true;
            this.button_edit.Click += new System.EventHandler(this.button_edit_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(441, 318);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(275, 48);
            this.button_delete.TabIndex = 1;
            this.button_delete.Text = "Delete";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Form_Fruits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_edit);
            this.Controls.Add(this.button_New);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.listBox_Fruits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Fruits";
            this.Text = "FruitsRegister";
            this.Load += new System.EventHandler(this.Form_FruitsRegister_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.Button button_edit;
        private System.Windows.Forms.Button button_delete;
        public System.Windows.Forms.ListBox listBox_Fruits;
    }
}


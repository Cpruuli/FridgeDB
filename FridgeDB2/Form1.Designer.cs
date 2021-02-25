namespace FridgeDB2
{
    partial class Form1
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
            this.listFoods = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listFoodNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "FoodType";
            // 
            // listFoods
            // 
            this.listFoods.FormattingEnabled = true;
            this.listFoods.Location = new System.Drawing.Point(92, 126);
            this.listFoods.Name = "listFoods";
            this.listFoods.Size = new System.Drawing.Size(120, 95);
            this.listFoods.TabIndex = 1;
            this.listFoods.SelectedIndexChanged += new System.EventHandler(this.listFoods_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Food Names";
            this.label2.Click += new System.EventHandler(this.Form1_Load);
            // 
            // listFoodNames
            // 
            this.listFoodNames.FormattingEnabled = true;
            this.listFoodNames.Location = new System.Drawing.Point(323, 126);
            this.listFoodNames.Name = "listFoodNames";
            this.listFoodNames.Size = new System.Drawing.Size(120, 95);
            this.listFoodNames.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listFoodNames);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listFoods);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listFoods;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listFoodNames;
    }
}


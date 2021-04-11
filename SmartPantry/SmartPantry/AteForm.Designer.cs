
namespace SmartPantry
{
    partial class AteForm
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
            this.ateList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ateNewFoodButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.servingPicker = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.selectFood = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.servingPicker)).BeginInit();
            this.SuspendLayout();
            // 
            // ateList
            // 
            this.ateList.FormattingEnabled = true;
            this.ateList.ItemHeight = 25;
            this.ateList.Location = new System.Drawing.Point(66, 127);
            this.ateList.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ateList.Name = "ateList";
            this.ateList.Size = new System.Drawing.Size(384, 629);
            this.ateList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(60, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Which Food You Ate:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ateNewFoodButton
            // 
            this.ateNewFoodButton.BackColor = System.Drawing.Color.Silver;
            this.ateNewFoodButton.Location = new System.Drawing.Point(142, 791);
            this.ateNewFoodButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ateNewFoodButton.Name = "ateNewFoodButton";
            this.ateNewFoodButton.Size = new System.Drawing.Size(308, 90);
            this.ateNewFoodButton.TabIndex = 3;
            this.ateNewFoodButton.Text = "New Food";
            this.ateNewFoodButton.UseVisualStyleBackColor = false;
            this.ateNewFoodButton.Click += new System.EventHandler(this.ateNewFoodButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rage Italic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(54, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(274, 68);
            this.label3.TabIndex = 6;
            this.label3.Text = "Snack Foods";
            // 
            // servingPicker
            // 
            this.servingPicker.Location = new System.Drawing.Point(482, 127);
            this.servingPicker.Name = "servingPicker";
            this.servingPicker.Size = new System.Drawing.Size(120, 31);
            this.servingPicker.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(477, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Servings:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // selectFood
            // 
            this.selectFood.BackColor = System.Drawing.Color.Silver;
            this.selectFood.Location = new System.Drawing.Point(482, 239);
            this.selectFood.Name = "selectFood";
            this.selectFood.Size = new System.Drawing.Size(120, 69);
            this.selectFood.TabIndex = 9;
            this.selectFood.Text = "Select Food";
            this.selectFood.UseVisualStyleBackColor = false;
            this.selectFood.Click += new System.EventHandler(this.selectFood_Click);
            // 
            // AteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(634, 908);
            this.Controls.Add(this.selectFood);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.servingPicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ateNewFoodButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ateList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AteForm";
            ((System.ComponentModel.ISupportInitialize)(this.servingPicker)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ateList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ateNewFoodButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown servingPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button selectFood;
    }
}
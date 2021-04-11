
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ateList
            // 
            this.ateList.FormattingEnabled = true;
            this.ateList.Location = new System.Drawing.Point(33, 79);
            this.ateList.Name = "ateList";
            this.ateList.Size = new System.Drawing.Size(253, 316);
            this.ateList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(30, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Which Food You Ate:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ateNewFoodButton
            // 
            this.ateNewFoodButton.Location = new System.Drawing.Point(71, 414);
            this.ateNewFoodButton.Name = "ateNewFoodButton";
            this.ateNewFoodButton.Size = new System.Drawing.Size(154, 47);
            this.ateNewFoodButton.TabIndex = 3;
            this.ateNewFoodButton.Text = "New Food";
            this.ateNewFoodButton.UseVisualStyleBackColor = true;
            this.ateNewFoodButton.Click += new System.EventHandler(this.ateNewFoodButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(186, 53);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(136, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Search:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rage Italic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(27, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Snack Foods";
            // 
            // AteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(317, 472);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ateNewFoodButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ateList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AteForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ateList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ateNewFoodButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
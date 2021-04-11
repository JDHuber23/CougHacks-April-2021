
namespace SmartPantry
{
    partial class CookedForm
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
            this.cookedRecipeList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cookedNewRecipeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.recipeSearchTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cookedRecipeList
            // 
            this.cookedRecipeList.FormattingEnabled = true;
            this.cookedRecipeList.Location = new System.Drawing.Point(24, 63);
            this.cookedRecipeList.Name = "cookedRecipeList";
            this.cookedRecipeList.Size = new System.Drawing.Size(253, 342);
            this.cookedRecipeList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Which Recipe You Crafted:";
            // 
            // cookedNewRecipeButton
            // 
            this.cookedNewRecipeButton.Location = new System.Drawing.Point(66, 411);
            this.cookedNewRecipeButton.Name = "cookedNewRecipeButton";
            this.cookedNewRecipeButton.Size = new System.Drawing.Size(155, 40);
            this.cookedNewRecipeButton.TabIndex = 2;
            this.cookedNewRecipeButton.Text = "New Recipe";
            this.cookedNewRecipeButton.UseVisualStyleBackColor = true;
            this.cookedNewRecipeButton.Click += new System.EventHandler(this.cookedNewRecipeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(136, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search:";
            // 
            // recipeSearchTB
            // 
            this.recipeSearchTB.Location = new System.Drawing.Point(177, 40);
            this.recipeSearchTB.Name = "recipeSearchTB";
            this.recipeSearchTB.Size = new System.Drawing.Size(100, 20);
            this.recipeSearchTB.TabIndex = 4;
            this.recipeSearchTB.TextChanged += new System.EventHandler(this.recipeSearchTB_TextChanged);
            // 
            // CookedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 470);
            this.Controls.Add(this.recipeSearchTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cookedNewRecipeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cookedRecipeList);
            this.Name = "CookedForm";
            this.Text = "Cooked Recipe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cookedRecipeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cookedNewRecipeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recipeSearchTB;
    }
}

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
            this.label3 = new System.Windows.Forms.Label();
            this.SelectRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cookedRecipeList
            // 
            this.cookedRecipeList.BackColor = System.Drawing.SystemColors.Window;
            this.cookedRecipeList.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cookedRecipeList.FormattingEnabled = true;
            this.cookedRecipeList.ItemHeight = 25;
            this.cookedRecipeList.Location = new System.Drawing.Point(47, 171);
            this.cookedRecipeList.Margin = new System.Windows.Forms.Padding(6);
            this.cookedRecipeList.Name = "cookedRecipeList";
            this.cookedRecipeList.Size = new System.Drawing.Size(502, 604);
            this.cookedRecipeList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(42, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Which Recipe You Crafted:";
            // 
            // cookedNewRecipeButton
            // 
            this.cookedNewRecipeButton.BackColor = System.Drawing.Color.Silver;
            this.cookedNewRecipeButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cookedNewRecipeButton.Location = new System.Drawing.Point(323, 787);
            this.cookedNewRecipeButton.Margin = new System.Windows.Forms.Padding(6);
            this.cookedNewRecipeButton.Name = "cookedNewRecipeButton";
            this.cookedNewRecipeButton.Size = new System.Drawing.Size(227, 77);
            this.cookedNewRecipeButton.TabIndex = 2;
            this.cookedNewRecipeButton.Text = "New Recipe";
            this.cookedNewRecipeButton.UseVisualStyleBackColor = false;
            this.cookedNewRecipeButton.Click += new System.EventHandler(this.cookedNewRecipeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(272, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Search:";
            // 
            // recipeSearchTB
            // 
            this.recipeSearchTB.Location = new System.Drawing.Point(354, 127);
            this.recipeSearchTB.Margin = new System.Windows.Forms.Padding(6);
            this.recipeSearchTB.Name = "recipeSearchTB";
            this.recipeSearchTB.Size = new System.Drawing.Size(196, 31);
            this.recipeSearchTB.TabIndex = 4;
            this.recipeSearchTB.TextChanged += new System.EventHandler(this.recipeSearchTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rage Italic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(36, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(379, 84);
            this.label3.TabIndex = 5;
            this.label3.Text = "Cooked Recipe";
            // 
            // SelectRecipe
            // 
            this.SelectRecipe.BackColor = System.Drawing.Color.Silver;
            this.SelectRecipe.Location = new System.Drawing.Point(50, 787);
            this.SelectRecipe.Name = "SelectRecipe";
            this.SelectRecipe.Size = new System.Drawing.Size(224, 77);
            this.SelectRecipe.TabIndex = 6;
            this.SelectRecipe.Text = "Select Recipe";
            this.SelectRecipe.UseVisualStyleBackColor = false;
            this.SelectRecipe.Click += new System.EventHandler(this.SelectRecipe_Click);
            // 
            // CookedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(604, 904);
            this.Controls.Add(this.SelectRecipe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.recipeSearchTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cookedNewRecipeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cookedRecipeList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CookedForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox cookedRecipeList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cookedNewRecipeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox recipeSearchTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SelectRecipe;
    }
}
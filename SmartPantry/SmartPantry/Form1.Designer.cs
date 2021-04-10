
namespace SmartPantry
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
            this.cookedButton = new System.Windows.Forms.Button();
            this.pantryButton = new System.Windows.Forms.Button();
            this.refrigeratorButton = new System.Windows.Forms.Button();
            this.allFoodButton = new System.Windows.Forms.Button();
            this.freezerButton = new System.Windows.Forms.Button();
            this.ateButton = new System.Windows.Forms.Button();
            this.recipeButton = new System.Windows.Forms.Button();
            this.shoppingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cookedButton
            // 
            this.cookedButton.Location = new System.Drawing.Point(14, 24);
            this.cookedButton.Name = "cookedButton";
            this.cookedButton.Size = new System.Drawing.Size(203, 207);
            this.cookedButton.TabIndex = 0;
            this.cookedButton.Text = "I Cooked Something!";
            this.cookedButton.UseVisualStyleBackColor = true;
            this.cookedButton.Click += new System.EventHandler(this.cookedButton_Click);
            // 
            // pantryButton
            // 
            this.pantryButton.Location = new System.Drawing.Point(260, 120);
            this.pantryButton.Name = "pantryButton";
            this.pantryButton.Size = new System.Drawing.Size(382, 56);
            this.pantryButton.TabIndex = 1;
            this.pantryButton.Text = "Pantry";
            this.pantryButton.UseVisualStyleBackColor = true;
            this.pantryButton.Click += new System.EventHandler(this.pantryButton_Click);
            // 
            // refrigeratorButton
            // 
            this.refrigeratorButton.Location = new System.Drawing.Point(260, 208);
            this.refrigeratorButton.Name = "refrigeratorButton";
            this.refrigeratorButton.Size = new System.Drawing.Size(381, 58);
            this.refrigeratorButton.TabIndex = 2;
            this.refrigeratorButton.Text = "Refrigerator";
            this.refrigeratorButton.UseVisualStyleBackColor = true;
            this.refrigeratorButton.Click += new System.EventHandler(this.refrigeratorButton_Click);
            // 
            // allFoodButton
            // 
            this.allFoodButton.Location = new System.Drawing.Point(259, 24);
            this.allFoodButton.Name = "allFoodButton";
            this.allFoodButton.Size = new System.Drawing.Size(380, 58);
            this.allFoodButton.TabIndex = 3;
            this.allFoodButton.Text = "All Food";
            this.allFoodButton.UseVisualStyleBackColor = true;
            this.allFoodButton.Click += new System.EventHandler(this.allFoodButton_Click);
            // 
            // freezerButton
            // 
            this.freezerButton.Location = new System.Drawing.Point(260, 302);
            this.freezerButton.Name = "freezerButton";
            this.freezerButton.Size = new System.Drawing.Size(380, 59);
            this.freezerButton.TabIndex = 4;
            this.freezerButton.Text = "Freezer";
            this.freezerButton.UseVisualStyleBackColor = true;
            this.freezerButton.Click += new System.EventHandler(this.freezerButton_Click);
            // 
            // ateButton
            // 
            this.ateButton.Location = new System.Drawing.Point(14, 266);
            this.ateButton.Name = "ateButton";
            this.ateButton.Size = new System.Drawing.Size(202, 189);
            this.ateButton.TabIndex = 5;
            this.ateButton.Text = "I Ate Something!";
            this.ateButton.UseVisualStyleBackColor = true;
            this.ateButton.Click += new System.EventHandler(this.ateButton_Click);
            // 
            // recipeButton
            // 
            this.recipeButton.Location = new System.Drawing.Point(260, 395);
            this.recipeButton.Name = "recipeButton";
            this.recipeButton.Size = new System.Drawing.Size(379, 59);
            this.recipeButton.TabIndex = 6;
            this.recipeButton.Text = "Recipes";
            this.recipeButton.UseVisualStyleBackColor = true;
            this.recipeButton.Click += new System.EventHandler(this.recipeButton_Click);
            // 
            // shoppingButton
            // 
            this.shoppingButton.Location = new System.Drawing.Point(679, 24);
            this.shoppingButton.Name = "shoppingButton";
            this.shoppingButton.Size = new System.Drawing.Size(156, 430);
            this.shoppingButton.TabIndex = 7;
            this.shoppingButton.Text = "Shopping List";
            this.shoppingButton.UseVisualStyleBackColor = true;
            this.shoppingButton.Click += new System.EventHandler(this.shoppingButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 502);
            this.Controls.Add(this.shoppingButton);
            this.Controls.Add(this.recipeButton);
            this.Controls.Add(this.ateButton);
            this.Controls.Add(this.freezerButton);
            this.Controls.Add(this.allFoodButton);
            this.Controls.Add(this.refrigeratorButton);
            this.Controls.Add(this.pantryButton);
            this.Controls.Add(this.cookedButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cookedButton;
        private System.Windows.Forms.Button pantryButton;
        private System.Windows.Forms.Button refrigeratorButton;
        private System.Windows.Forms.Button allFoodButton;
        private System.Windows.Forms.Button freezerButton;
        private System.Windows.Forms.Button ateButton;
        private System.Windows.Forms.Button recipeButton;
        private System.Windows.Forms.Button shoppingButton;
    }
}


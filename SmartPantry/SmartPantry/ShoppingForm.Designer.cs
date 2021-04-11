
namespace SmartPantry
{
    partial class ShoppingForm
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
            this.shoppingList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.newShoppingItemButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // shoppingList
            // 
            this.shoppingList.FormattingEnabled = true;
            this.shoppingList.Location = new System.Drawing.Point(30, 41);
            this.shoppingList.Name = "shoppingList";
            this.shoppingList.Size = new System.Drawing.Size(268, 381);
            this.shoppingList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Shopping List Items:";
            // 
            // newShoppingItemButton
            // 
            this.newShoppingItemButton.Location = new System.Drawing.Point(91, 428);
            this.newShoppingItemButton.Name = "newShoppingItemButton";
            this.newShoppingItemButton.Size = new System.Drawing.Size(131, 42);
            this.newShoppingItemButton.TabIndex = 2;
            this.newShoppingItemButton.Text = "New Shopping Item";
            this.newShoppingItemButton.UseVisualStyleBackColor = true;
            this.newShoppingItemButton.Click += new System.EventHandler(this.newShoppingItemButton_Click);
            // 
            // ShoppingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 479);
            this.Controls.Add(this.newShoppingItemButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.shoppingList);
            this.Name = "ShoppingForm";
            this.Text = "Shopping List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox shoppingList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button newShoppingItemButton;
    }
}
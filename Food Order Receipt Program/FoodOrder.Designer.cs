
namespace LB1
{
    partial class FormFoodOrder
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
            this.labelOrderTitle = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelError = new System.Windows.Forms.Label();
            this.labelSundae = new System.Windows.Forms.Label();
            this.checkBoxSundae = new System.Windows.Forms.CheckBox();
            this.labelSundaeToppingsTitle = new System.Windows.Forms.Label();
            this.checkBoxSprinkles = new System.Windows.Forms.CheckBox();
            this.checkBoxNuts = new System.Windows.Forms.CheckBox();
            this.checkBoxChocolateSyrup = new System.Windows.Forms.CheckBox();
            this.labelToppingsError = new System.Windows.Forms.Label();
            this.buttonAddToOrder = new System.Windows.Forms.Button();
            this.labelMixinError = new System.Windows.Forms.Label();
            this.checkBoxMango = new System.Windows.Forms.CheckBox();
            this.checkBoxPeach = new System.Windows.Forms.CheckBox();
            this.checkBoxLime = new System.Windows.Forms.CheckBox();
            this.labelDrinkMixinsTitle = new System.Windows.Forms.Label();
            this.checkBoxSoda = new System.Windows.Forms.CheckBox();
            this.labelSoda = new System.Windows.Forms.Label();
            this.textBoxReceipt = new System.Windows.Forms.TextBox();
            this.labelOrder = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelOrderTitle
            // 
            this.labelOrderTitle.AutoSize = true;
            this.labelOrderTitle.Location = new System.Drawing.Point(12, 9);
            this.labelOrderTitle.Name = "labelOrderTitle";
            this.labelOrderTitle.Size = new System.Drawing.Size(484, 53);
            this.labelOrderTitle.TabIndex = 0;
            this.labelOrderTitle.Text = "What name do you want on the order?";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(21, 65);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(281, 59);
            this.textBoxName.TabIndex = 0;
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.labelError.ForeColor = System.Drawing.Color.Red;
            this.labelError.Location = new System.Drawing.Point(14, 136);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(325, 38);
            this.labelError.TabIndex = 2;
            this.labelError.Text = "Name Required/No Food Selected";
            this.labelError.Visible = false;
            // 
            // labelSundae
            // 
            this.labelSundae.AutoSize = true;
            this.labelSundae.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.labelSundae.Location = new System.Drawing.Point(14, 187);
            this.labelSundae.Name = "labelSundae";
            this.labelSundae.Size = new System.Drawing.Size(217, 38);
            this.labelSundae.TabIndex = 3;
            this.labelSundae.Text = "Do you want a sundae?";
            // 
            // checkBoxSundae
            // 
            this.checkBoxSundae.AutoSize = true;
            this.checkBoxSundae.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.checkBoxSundae.Location = new System.Drawing.Point(21, 229);
            this.checkBoxSundae.Name = "checkBoxSundae";
            this.checkBoxSundae.Size = new System.Drawing.Size(70, 42);
            this.checkBoxSundae.TabIndex = 1;
            this.checkBoxSundae.Text = "Yes";
            this.checkBoxSundae.UseVisualStyleBackColor = true;
            // 
            // labelSundaeToppingsTitle
            // 
            this.labelSundaeToppingsTitle.AutoSize = true;
            this.labelSundaeToppingsTitle.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.labelSundaeToppingsTitle.Location = new System.Drawing.Point(14, 275);
            this.labelSundaeToppingsTitle.Name = "labelSundaeToppingsTitle";
            this.labelSundaeToppingsTitle.Size = new System.Drawing.Size(170, 38);
            this.labelSundaeToppingsTitle.TabIndex = 5;
            this.labelSundaeToppingsTitle.Text = "Sundae Toppings";
            // 
            // checkBoxSprinkles
            // 
            this.checkBoxSprinkles.AutoSize = true;
            this.checkBoxSprinkles.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.checkBoxSprinkles.Location = new System.Drawing.Point(21, 317);
            this.checkBoxSprinkles.Name = "checkBoxSprinkles";
            this.checkBoxSprinkles.Size = new System.Drawing.Size(121, 42);
            this.checkBoxSprinkles.TabIndex = 2;
            this.checkBoxSprinkles.Text = "Sprinkles";
            this.checkBoxSprinkles.UseVisualStyleBackColor = true;
            // 
            // checkBoxNuts
            // 
            this.checkBoxNuts.AutoSize = true;
            this.checkBoxNuts.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.checkBoxNuts.Location = new System.Drawing.Point(21, 363);
            this.checkBoxNuts.Name = "checkBoxNuts";
            this.checkBoxNuts.Size = new System.Drawing.Size(82, 42);
            this.checkBoxNuts.TabIndex = 3;
            this.checkBoxNuts.Text = "Nuts";
            this.checkBoxNuts.UseVisualStyleBackColor = true;
            // 
            // checkBoxChocolateSyrup
            // 
            this.checkBoxChocolateSyrup.AutoSize = true;
            this.checkBoxChocolateSyrup.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.checkBoxChocolateSyrup.Location = new System.Drawing.Point(21, 409);
            this.checkBoxChocolateSyrup.Name = "checkBoxChocolateSyrup";
            this.checkBoxChocolateSyrup.Size = new System.Drawing.Size(186, 42);
            this.checkBoxChocolateSyrup.TabIndex = 4;
            this.checkBoxChocolateSyrup.Text = "Chocolate Syrup";
            this.checkBoxChocolateSyrup.UseVisualStyleBackColor = true;
            // 
            // labelToppingsError
            // 
            this.labelToppingsError.AutoSize = true;
            this.labelToppingsError.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.labelToppingsError.ForeColor = System.Drawing.Color.Red;
            this.labelToppingsError.Location = new System.Drawing.Point(14, 454);
            this.labelToppingsError.Name = "labelToppingsError";
            this.labelToppingsError.Size = new System.Drawing.Size(228, 38);
            this.labelToppingsError.TabIndex = 9;
            this.labelToppingsError.Text = "Only 2 toppings allowed";
            this.labelToppingsError.Visible = false;
            // 
            // buttonAddToOrder
            // 
            this.buttonAddToOrder.Font = new System.Drawing.Font("Reem Kufi", 13.8F);
            this.buttonAddToOrder.Location = new System.Drawing.Point(21, 508);
            this.buttonAddToOrder.Name = "buttonAddToOrder";
            this.buttonAddToOrder.Size = new System.Drawing.Size(221, 53);
            this.buttonAddToOrder.TabIndex = 9;
            this.buttonAddToOrder.Text = "Add to Order";
            this.buttonAddToOrder.UseVisualStyleBackColor = true;
            this.buttonAddToOrder.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelMixinError
            // 
            this.labelMixinError.AutoSize = true;
            this.labelMixinError.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.labelMixinError.ForeColor = System.Drawing.Color.Red;
            this.labelMixinError.Location = new System.Drawing.Point(279, 454);
            this.labelMixinError.Name = "labelMixinError";
            this.labelMixinError.Size = new System.Drawing.Size(194, 38);
            this.labelMixinError.TabIndex = 17;
            this.labelMixinError.Text = "Only 1 mixin allowed";
            this.labelMixinError.Visible = false;
            // 
            // checkBoxMango
            // 
            this.checkBoxMango.AutoSize = true;
            this.checkBoxMango.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.checkBoxMango.Location = new System.Drawing.Point(286, 409);
            this.checkBoxMango.Name = "checkBoxMango";
            this.checkBoxMango.Size = new System.Drawing.Size(165, 42);
            this.checkBoxMango.TabIndex = 8;
            this.checkBoxMango.Text = "Mango Flavor";
            this.checkBoxMango.UseVisualStyleBackColor = true;
            // 
            // checkBoxPeach
            // 
            this.checkBoxPeach.AutoSize = true;
            this.checkBoxPeach.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.checkBoxPeach.Location = new System.Drawing.Point(286, 363);
            this.checkBoxPeach.Name = "checkBoxPeach";
            this.checkBoxPeach.Size = new System.Drawing.Size(155, 42);
            this.checkBoxPeach.TabIndex = 7;
            this.checkBoxPeach.Text = "Peach Flavor";
            this.checkBoxPeach.UseVisualStyleBackColor = true;
            // 
            // checkBoxLime
            // 
            this.checkBoxLime.AutoSize = true;
            this.checkBoxLime.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.checkBoxLime.Location = new System.Drawing.Point(286, 317);
            this.checkBoxLime.Name = "checkBoxLime";
            this.checkBoxLime.Size = new System.Drawing.Size(146, 42);
            this.checkBoxLime.TabIndex = 6;
            this.checkBoxLime.Text = "Lime Flavor";
            this.checkBoxLime.UseVisualStyleBackColor = true;
            // 
            // labelDrinkMixinsTitle
            // 
            this.labelDrinkMixinsTitle.AutoSize = true;
            this.labelDrinkMixinsTitle.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.labelDrinkMixinsTitle.Location = new System.Drawing.Point(279, 275);
            this.labelDrinkMixinsTitle.Name = "labelDrinkMixinsTitle";
            this.labelDrinkMixinsTitle.Size = new System.Drawing.Size(127, 38);
            this.labelDrinkMixinsTitle.TabIndex = 13;
            this.labelDrinkMixinsTitle.Text = "Drink Mixins";
            // 
            // checkBoxSoda
            // 
            this.checkBoxSoda.AutoSize = true;
            this.checkBoxSoda.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.checkBoxSoda.Location = new System.Drawing.Point(286, 229);
            this.checkBoxSoda.Name = "checkBoxSoda";
            this.checkBoxSoda.Size = new System.Drawing.Size(70, 42);
            this.checkBoxSoda.TabIndex = 5;
            this.checkBoxSoda.Text = "Yes";
            this.checkBoxSoda.UseVisualStyleBackColor = true;
            // 
            // labelSoda
            // 
            this.labelSoda.AutoSize = true;
            this.labelSoda.Font = new System.Drawing.Font("Reem Kufi", 12F);
            this.labelSoda.Location = new System.Drawing.Point(279, 187);
            this.labelSoda.Name = "labelSoda";
            this.labelSoda.Size = new System.Drawing.Size(195, 38);
            this.labelSoda.TabIndex = 11;
            this.labelSoda.Text = "Do you want a soda?";
            // 
            // textBoxReceipt
            // 
            this.textBoxReceipt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxReceipt.Font = new System.Drawing.Font("Reem Kufi", 13.8F);
            this.textBoxReceipt.Location = new System.Drawing.Point(502, 65);
            this.textBoxReceipt.Multiline = true;
            this.textBoxReceipt.Name = "textBoxReceipt";
            this.textBoxReceipt.ReadOnly = true;
            this.textBoxReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceipt.Size = new System.Drawing.Size(452, 427);
            this.textBoxReceipt.TabIndex = 18;
            this.textBoxReceipt.TabStop = false;
            // 
            // labelOrder
            // 
            this.labelOrder.AutoSize = true;
            this.labelOrder.Location = new System.Drawing.Point(854, 9);
            this.labelOrder.Name = "labelOrder";
            this.labelOrder.Size = new System.Drawing.Size(100, 53);
            this.labelOrder.TabIndex = 19;
            this.labelOrder.Text = "Order";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(707, 508);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(90, 53);
            this.labelTotal.TabIndex = 20;
            this.labelTotal.Text = "Total:";
            // 
            // FormFoodOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 51F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 585);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelOrder);
            this.Controls.Add(this.textBoxReceipt);
            this.Controls.Add(this.labelMixinError);
            this.Controls.Add(this.checkBoxMango);
            this.Controls.Add(this.checkBoxPeach);
            this.Controls.Add(this.checkBoxLime);
            this.Controls.Add(this.labelDrinkMixinsTitle);
            this.Controls.Add(this.checkBoxSoda);
            this.Controls.Add(this.labelSoda);
            this.Controls.Add(this.buttonAddToOrder);
            this.Controls.Add(this.labelToppingsError);
            this.Controls.Add(this.checkBoxChocolateSyrup);
            this.Controls.Add(this.checkBoxNuts);
            this.Controls.Add(this.checkBoxSprinkles);
            this.Controls.Add(this.labelSundaeToppingsTitle);
            this.Controls.Add(this.checkBoxSundae);
            this.Controls.Add(this.labelSundae);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelOrderTitle);
            this.Font = new System.Drawing.Font("Reem Kufi", 16.2F);
            this.Margin = new System.Windows.Forms.Padding(6, 10, 6, 10);
            this.Name = "FormFoodOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelOrderTitle;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.Label labelSundae;
        private System.Windows.Forms.CheckBox checkBoxSundae;
        private System.Windows.Forms.Label labelSundaeToppingsTitle;
        private System.Windows.Forms.CheckBox checkBoxSprinkles;
        private System.Windows.Forms.CheckBox checkBoxNuts;
        private System.Windows.Forms.CheckBox checkBoxChocolateSyrup;
        private System.Windows.Forms.Label labelToppingsError;
        private System.Windows.Forms.Button buttonAddToOrder;
        private System.Windows.Forms.Label labelMixinError;
        private System.Windows.Forms.CheckBox checkBoxMango;
        private System.Windows.Forms.CheckBox checkBoxPeach;
        private System.Windows.Forms.CheckBox checkBoxLime;
        private System.Windows.Forms.Label labelDrinkMixinsTitle;
        private System.Windows.Forms.CheckBox checkBoxSoda;
        private System.Windows.Forms.Label labelSoda;
        private System.Windows.Forms.TextBox textBoxReceipt;
        private System.Windows.Forms.Label labelOrder;
        private System.Windows.Forms.Label labelTotal;
    }
}


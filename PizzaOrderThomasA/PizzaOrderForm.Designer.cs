namespace PizzaOrderThomasA
{
    partial class frmPizzaOrder
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
            this.lblGreeting = new System.Windows.Forms.Label();
            this.lblPizzaSizePrompt = new System.Windows.Forms.Label();
            this.nubPizzaSizeChosen = new System.Windows.Forms.NumericUpDown();
            this.lblLargePizzaNumber = new System.Windows.Forms.Label();
            this.ExtraLargePizzaNumber = new System.Windows.Forms.Label();
            this.lblExtraExtraLargePizzaNumber = new System.Windows.Forms.Label();
            this.lblNumberOfDrinksPrompt = new System.Windows.Forms.Label();
            this.lblNumberOfToppingsPrompt = new System.Windows.Forms.Label();
            this.lblOneToppingNumber = new System.Windows.Forms.Label();
            this.lblTwoToppingNumber = new System.Windows.Forms.Label();
            this.lblThreeToppingNumber = new System.Windows.Forms.Label();
            this.lblFourToppingNumber = new System.Windows.Forms.Label();
            this.lblZeroDrinkNumber = new System.Windows.Forms.Label();
            this.lblOneDrinkNumber = new System.Windows.Forms.Label();
            this.lblTwoDrinkNumber = new System.Windows.Forms.Label();
            this.lblDeliveryOptionPrompt = new System.Windows.Forms.Label();
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniStoreLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.mniOttawaStore = new System.Windows.Forms.ToolStripMenuItem();
            this.mniNewfoundlandStore = new System.Windows.Forms.ToolStripMenuItem();
            this.nubToppingNumberChosen = new System.Windows.Forms.NumericUpDown();
            this.nubDrinkAmountChosen = new System.Windows.Forms.NumericUpDown();
            this.nubDeliveryOptionChosen = new System.Windows.Forms.NumericUpDown();
            this.lblTrueDeliveryNumber = new System.Windows.Forms.Label();
            this.lblFalseDeliveryNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nubPizzaSizeChosen)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubToppingNumberChosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubDrinkAmountChosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubDeliveryOptionChosen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(12, 44);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(634, 61);
            this.lblGreeting.TabIndex = 0;
            this.lblGreeting.Text = "Welcome to Luigi\'s Pizza Shop!";
            // 
            // lblPizzaSizePrompt
            // 
            this.lblPizzaSizePrompt.AutoSize = true;
            this.lblPizzaSizePrompt.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaSizePrompt.Location = new System.Drawing.Point(13, 115);
            this.lblPizzaSizePrompt.Name = "lblPizzaSizePrompt";
            this.lblPizzaSizePrompt.Size = new System.Drawing.Size(389, 33);
            this.lblPizzaSizePrompt.TabIndex = 1;
            this.lblPizzaSizePrompt.Text = "Select the size of pizza you would like:";
            // 
            // nubPizzaSizeChosen
            // 
            this.nubPizzaSizeChosen.Location = new System.Drawing.Point(589, 125);
            this.nubPizzaSizeChosen.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nubPizzaSizeChosen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubPizzaSizeChosen.Name = "nubPizzaSizeChosen";
            this.nubPizzaSizeChosen.ReadOnly = true;
            this.nubPizzaSizeChosen.Size = new System.Drawing.Size(41, 20);
            this.nubPizzaSizeChosen.TabIndex = 2;
            this.nubPizzaSizeChosen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nubPizzaSizeChosen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLargePizzaNumber
            // 
            this.lblLargePizzaNumber.AutoSize = true;
            this.lblLargePizzaNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLargePizzaNumber.Location = new System.Drawing.Point(15, 158);
            this.lblLargePizzaNumber.Name = "lblLargePizzaNumber";
            this.lblLargePizzaNumber.Size = new System.Drawing.Size(108, 20);
            this.lblLargePizzaNumber.TabIndex = 3;
            this.lblLargePizzaNumber.Text = "Large Pizza = 1";
            // 
            // ExtraLargePizzaNumber
            // 
            this.ExtraLargePizzaNumber.AutoSize = true;
            this.ExtraLargePizzaNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraLargePizzaNumber.Location = new System.Drawing.Point(15, 181);
            this.ExtraLargePizzaNumber.Name = "ExtraLargePizzaNumber";
            this.ExtraLargePizzaNumber.Size = new System.Drawing.Size(147, 20);
            this.ExtraLargePizzaNumber.TabIndex = 4;
            this.ExtraLargePizzaNumber.Text = "Extra Large Pizza = 2";
            // 
            // lblExtraExtraLargePizzaNumber
            // 
            this.lblExtraExtraLargePizzaNumber.AutoSize = true;
            this.lblExtraExtraLargePizzaNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraExtraLargePizzaNumber.Location = new System.Drawing.Point(14, 205);
            this.lblExtraExtraLargePizzaNumber.Name = "lblExtraExtraLargePizzaNumber";
            this.lblExtraExtraLargePizzaNumber.Size = new System.Drawing.Size(186, 20);
            this.lblExtraExtraLargePizzaNumber.TabIndex = 5;
            this.lblExtraExtraLargePizzaNumber.Text = "Extra Extra Large Pizza = 3";
            // 
            // lblNumberOfDrinksPrompt
            // 
            this.lblNumberOfDrinksPrompt.AutoSize = true;
            this.lblNumberOfDrinksPrompt.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDrinksPrompt.Location = new System.Drawing.Point(13, 394);
            this.lblNumberOfDrinksPrompt.Name = "lblNumberOfDrinksPrompt";
            this.lblNumberOfDrinksPrompt.Size = new System.Drawing.Size(443, 33);
            this.lblNumberOfDrinksPrompt.TabIndex = 6;
            this.lblNumberOfDrinksPrompt.Text = "Select the amount of drinks you would like:";
            // 
            // lblNumberOfToppingsPrompt
            // 
            this.lblNumberOfToppingsPrompt.AutoSize = true;
            this.lblNumberOfToppingsPrompt.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfToppingsPrompt.Location = new System.Drawing.Point(13, 251);
            this.lblNumberOfToppingsPrompt.Name = "lblNumberOfToppingsPrompt";
            this.lblNumberOfToppingsPrompt.Size = new System.Drawing.Size(464, 33);
            this.lblNumberOfToppingsPrompt.TabIndex = 7;
            this.lblNumberOfToppingsPrompt.Text = "Select the amount of toppings you would like:";
            // 
            // lblOneToppingNumber
            // 
            this.lblOneToppingNumber.AutoSize = true;
            this.lblOneToppingNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneToppingNumber.Location = new System.Drawing.Point(14, 297);
            this.lblOneToppingNumber.Name = "lblOneToppingNumber";
            this.lblOneToppingNumber.Size = new System.Drawing.Size(121, 20);
            this.lblOneToppingNumber.TabIndex = 8;
            this.lblOneToppingNumber.Text = "One Topping = 1";
            // 
            // lblTwoToppingNumber
            // 
            this.lblTwoToppingNumber.AutoSize = true;
            this.lblTwoToppingNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoToppingNumber.Location = new System.Drawing.Point(15, 317);
            this.lblTwoToppingNumber.Name = "lblTwoToppingNumber";
            this.lblTwoToppingNumber.Size = new System.Drawing.Size(127, 20);
            this.lblTwoToppingNumber.TabIndex = 9;
            this.lblTwoToppingNumber.Text = "Two Toppings = 2";
            // 
            // lblThreeToppingNumber
            // 
            this.lblThreeToppingNumber.AutoSize = true;
            this.lblThreeToppingNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThreeToppingNumber.Location = new System.Drawing.Point(15, 337);
            this.lblThreeToppingNumber.Name = "lblThreeToppingNumber";
            this.lblThreeToppingNumber.Size = new System.Drawing.Size(137, 20);
            this.lblThreeToppingNumber.TabIndex = 10;
            this.lblThreeToppingNumber.Text = "Three Toppings = 3";
            // 
            // lblFourToppingNumber
            // 
            this.lblFourToppingNumber.AutoSize = true;
            this.lblFourToppingNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFourToppingNumber.Location = new System.Drawing.Point(15, 357);
            this.lblFourToppingNumber.Name = "lblFourToppingNumber";
            this.lblFourToppingNumber.Size = new System.Drawing.Size(130, 20);
            this.lblFourToppingNumber.TabIndex = 11;
            this.lblFourToppingNumber.Text = "Four Toppings = 4";
            // 
            // lblZeroDrinkNumber
            // 
            this.lblZeroDrinkNumber.AutoSize = true;
            this.lblZeroDrinkNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZeroDrinkNumber.Location = new System.Drawing.Point(15, 434);
            this.lblZeroDrinkNumber.Name = "lblZeroDrinkNumber";
            this.lblZeroDrinkNumber.Size = new System.Drawing.Size(114, 20);
            this.lblZeroDrinkNumber.TabIndex = 12;
            this.lblZeroDrinkNumber.Text = "Zero Drinks = 0";
            // 
            // lblOneDrinkNumber
            // 
            this.lblOneDrinkNumber.AutoSize = true;
            this.lblOneDrinkNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneDrinkNumber.Location = new System.Drawing.Point(15, 454);
            this.lblOneDrinkNumber.Name = "lblOneDrinkNumber";
            this.lblOneDrinkNumber.Size = new System.Drawing.Size(105, 20);
            this.lblOneDrinkNumber.TabIndex = 13;
            this.lblOneDrinkNumber.Text = "One Drink = 1";
            // 
            // lblTwoDrinkNumber
            // 
            this.lblTwoDrinkNumber.AutoSize = true;
            this.lblTwoDrinkNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTwoDrinkNumber.Location = new System.Drawing.Point(15, 474);
            this.lblTwoDrinkNumber.Name = "lblTwoDrinkNumber";
            this.lblTwoDrinkNumber.Size = new System.Drawing.Size(111, 20);
            this.lblTwoDrinkNumber.TabIndex = 14;
            this.lblTwoDrinkNumber.Text = "Two Drinks = 2";
            // 
            // lblDeliveryOptionPrompt
            // 
            this.lblDeliveryOptionPrompt.AutoSize = true;
            this.lblDeliveryOptionPrompt.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeliveryOptionPrompt.Location = new System.Drawing.Point(13, 522);
            this.lblDeliveryOptionPrompt.Name = "lblDeliveryOptionPrompt";
            this.lblDeliveryOptionPrompt.Size = new System.Drawing.Size(250, 33);
            this.lblDeliveryOptionPrompt.TabIndex = 15;
            this.lblDeliveryOptionPrompt.Text = "Would you like delivery?";
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniStoreLocation});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(1175, 24);
            this.mnuMainMenu.TabIndex = 16;
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(152, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.mniExit_Click);
            // 
            // mniStoreLocation
            // 
            this.mniStoreLocation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniOttawaStore,
            this.mniNewfoundlandStore});
            this.mniStoreLocation.Name = "mniStoreLocation";
            this.mniStoreLocation.Size = new System.Drawing.Size(95, 20);
            this.mniStoreLocation.Text = "Store Location";
            // 
            // mniOttawaStore
            // 
            this.mniOttawaStore.Name = "mniOttawaStore";
            this.mniOttawaStore.Size = new System.Drawing.Size(153, 22);
            this.mniOttawaStore.Text = "Ottawa";
            // 
            // mniNewfoundlandStore
            // 
            this.mniNewfoundlandStore.Name = "mniNewfoundlandStore";
            this.mniNewfoundlandStore.Size = new System.Drawing.Size(153, 22);
            this.mniNewfoundlandStore.Text = "Newfoundland";
            // 
            // nubToppingNumberChosen
            // 
            this.nubToppingNumberChosen.Location = new System.Drawing.Point(589, 262);
            this.nubToppingNumberChosen.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nubToppingNumberChosen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubToppingNumberChosen.Name = "nubToppingNumberChosen";
            this.nubToppingNumberChosen.ReadOnly = true;
            this.nubToppingNumberChosen.Size = new System.Drawing.Size(41, 20);
            this.nubToppingNumberChosen.TabIndex = 17;
            this.nubToppingNumberChosen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nubToppingNumberChosen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nubDrinkAmountChosen
            // 
            this.nubDrinkAmountChosen.Location = new System.Drawing.Point(589, 405);
            this.nubDrinkAmountChosen.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nubDrinkAmountChosen.Name = "nubDrinkAmountChosen";
            this.nubDrinkAmountChosen.ReadOnly = true;
            this.nubDrinkAmountChosen.Size = new System.Drawing.Size(41, 20);
            this.nubDrinkAmountChosen.TabIndex = 18;
            this.nubDrinkAmountChosen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nubDeliveryOptionChosen
            // 
            this.nubDeliveryOptionChosen.Location = new System.Drawing.Point(589, 533);
            this.nubDeliveryOptionChosen.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nubDeliveryOptionChosen.Name = "nubDeliveryOptionChosen";
            this.nubDeliveryOptionChosen.ReadOnly = true;
            this.nubDeliveryOptionChosen.Size = new System.Drawing.Size(41, 20);
            this.nubDeliveryOptionChosen.TabIndex = 19;
            this.nubDeliveryOptionChosen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTrueDeliveryNumber
            // 
            this.lblTrueDeliveryNumber.AutoSize = true;
            this.lblTrueDeliveryNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrueDeliveryNumber.Location = new System.Drawing.Point(19, 584);
            this.lblTrueDeliveryNumber.Name = "lblTrueDeliveryNumber";
            this.lblTrueDeliveryNumber.Size = new System.Drawing.Size(126, 20);
            this.lblTrueDeliveryNumber.TabIndex = 21;
            this.lblTrueDeliveryNumber.Text = "With Delivery = 1";
            // 
            // lblFalseDeliveryNumber
            // 
            this.lblFalseDeliveryNumber.AutoSize = true;
            this.lblFalseDeliveryNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFalseDeliveryNumber.Location = new System.Drawing.Point(19, 564);
            this.lblFalseDeliveryNumber.Name = "lblFalseDeliveryNumber";
            this.lblFalseDeliveryNumber.Size = new System.Drawing.Size(148, 20);
            this.lblFalseDeliveryNumber.TabIndex = 22;
            this.lblFalseDeliveryNumber.Text = "Without Delivery = 0";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(817, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(337, 329);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 772);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblFalseDeliveryNumber);
            this.Controls.Add(this.lblTrueDeliveryNumber);
            this.Controls.Add(this.nubDeliveryOptionChosen);
            this.Controls.Add(this.nubDrinkAmountChosen);
            this.Controls.Add(this.nubToppingNumberChosen);
            this.Controls.Add(this.lblDeliveryOptionPrompt);
            this.Controls.Add(this.lblTwoDrinkNumber);
            this.Controls.Add(this.lblOneDrinkNumber);
            this.Controls.Add(this.lblZeroDrinkNumber);
            this.Controls.Add(this.lblFourToppingNumber);
            this.Controls.Add(this.lblThreeToppingNumber);
            this.Controls.Add(this.lblTwoToppingNumber);
            this.Controls.Add(this.lblOneToppingNumber);
            this.Controls.Add(this.lblNumberOfToppingsPrompt);
            this.Controls.Add(this.lblNumberOfDrinksPrompt);
            this.Controls.Add(this.lblExtraExtraLargePizzaNumber);
            this.Controls.Add(this.ExtraLargePizzaNumber);
            this.Controls.Add(this.lblLargePizzaNumber);
            this.Controls.Add(this.nubPizzaSizeChosen);
            this.Controls.Add(this.lblPizzaSizePrompt);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order By Thomas Aubin";
            ((System.ComponentModel.ISupportInitialize)(this.nubPizzaSizeChosen)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nubToppingNumberChosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubDrinkAmountChosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nubDeliveryOptionChosen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblPizzaSizePrompt;
        private System.Windows.Forms.NumericUpDown nubPizzaSizeChosen;
        private System.Windows.Forms.Label lblLargePizzaNumber;
        private System.Windows.Forms.Label ExtraLargePizzaNumber;
        private System.Windows.Forms.Label lblExtraExtraLargePizzaNumber;
        private System.Windows.Forms.Label lblNumberOfDrinksPrompt;
        private System.Windows.Forms.Label lblNumberOfToppingsPrompt;
        private System.Windows.Forms.Label lblOneToppingNumber;
        private System.Windows.Forms.Label lblTwoToppingNumber;
        private System.Windows.Forms.Label lblThreeToppingNumber;
        private System.Windows.Forms.Label lblFourToppingNumber;
        private System.Windows.Forms.Label lblZeroDrinkNumber;
        private System.Windows.Forms.Label lblOneDrinkNumber;
        private System.Windows.Forms.Label lblTwoDrinkNumber;
        private System.Windows.Forms.Label lblDeliveryOptionPrompt;
        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniStoreLocation;
        private System.Windows.Forms.ToolStripMenuItem mniOttawaStore;
        private System.Windows.Forms.ToolStripMenuItem mniNewfoundlandStore;
        private System.Windows.Forms.NumericUpDown nubToppingNumberChosen;
        private System.Windows.Forms.NumericUpDown nubDrinkAmountChosen;
        private System.Windows.Forms.NumericUpDown nubDeliveryOptionChosen;
        private System.Windows.Forms.Label lblTrueDeliveryNumber;
        private System.Windows.Forms.Label lblFalseDeliveryNumber;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}


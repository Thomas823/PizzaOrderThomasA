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
            this.nudPizzaSizeChosen = new System.Windows.Forms.NumericUpDown();
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
            this.nudToppingNumberChosen = new System.Windows.Forms.NumericUpDown();
            this.nudDrinkAmountChosen = new System.Windows.Forms.NumericUpDown();
            this.nudDeliveryOptionChosen = new System.Windows.Forms.NumericUpDown();
            this.lblTrueDeliveryNumber = new System.Windows.Forms.Label();
            this.lblFalseDeliveryNumber = new System.Windows.Forms.Label();
            this.grbReceipt = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblHST = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.lblStoreLocation = new System.Windows.Forms.Label();
            this.radCashMethod = new System.Windows.Forms.RadioButton();
            this.radDebitMethod = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSizeChosen)).BeginInit();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingNumberChosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinkAmountChosen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeliveryOptionChosen)).BeginInit();
            this.grbReceipt.SuspendLayout();
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
            // nudPizzaSizeChosen
            // 
            this.nudPizzaSizeChosen.Location = new System.Drawing.Point(589, 125);
            this.nudPizzaSizeChosen.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.nudPizzaSizeChosen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPizzaSizeChosen.Name = "nudPizzaSizeChosen";
            this.nudPizzaSizeChosen.ReadOnly = true;
            this.nudPizzaSizeChosen.Size = new System.Drawing.Size(41, 20);
            this.nudPizzaSizeChosen.TabIndex = 2;
            this.nudPizzaSizeChosen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudPizzaSizeChosen.Value = new decimal(new int[] {
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
            this.mniExit.Size = new System.Drawing.Size(92, 22);
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
            this.mniOttawaStore.Click += new System.EventHandler(this.mniOttawaStore_Click);
            // 
            // mniNewfoundlandStore
            // 
            this.mniNewfoundlandStore.Name = "mniNewfoundlandStore";
            this.mniNewfoundlandStore.Size = new System.Drawing.Size(153, 22);
            this.mniNewfoundlandStore.Text = "Newfoundland";
            this.mniNewfoundlandStore.Click += new System.EventHandler(this.mniNewfoundlandStore_Click);
            // 
            // nudToppingNumberChosen
            // 
            this.nudToppingNumberChosen.Location = new System.Drawing.Point(589, 262);
            this.nudToppingNumberChosen.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudToppingNumberChosen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudToppingNumberChosen.Name = "nudToppingNumberChosen";
            this.nudToppingNumberChosen.ReadOnly = true;
            this.nudToppingNumberChosen.Size = new System.Drawing.Size(41, 20);
            this.nudToppingNumberChosen.TabIndex = 17;
            this.nudToppingNumberChosen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudToppingNumberChosen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudDrinkAmountChosen
            // 
            this.nudDrinkAmountChosen.Location = new System.Drawing.Point(589, 405);
            this.nudDrinkAmountChosen.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudDrinkAmountChosen.Name = "nudDrinkAmountChosen";
            this.nudDrinkAmountChosen.ReadOnly = true;
            this.nudDrinkAmountChosen.Size = new System.Drawing.Size(41, 20);
            this.nudDrinkAmountChosen.TabIndex = 18;
            this.nudDrinkAmountChosen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nudDeliveryOptionChosen
            // 
            this.nudDeliveryOptionChosen.Location = new System.Drawing.Point(589, 533);
            this.nudDeliveryOptionChosen.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDeliveryOptionChosen.Name = "nudDeliveryOptionChosen";
            this.nudDeliveryOptionChosen.ReadOnly = true;
            this.nudDeliveryOptionChosen.Size = new System.Drawing.Size(41, 20);
            this.nudDeliveryOptionChosen.TabIndex = 19;
            this.nudDeliveryOptionChosen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // grbReceipt
            // 
            this.grbReceipt.Controls.Add(this.lblTotal);
            this.grbReceipt.Controls.Add(this.lblHST);
            this.grbReceipt.Controls.Add(this.lblSubtotal);
            this.grbReceipt.Location = new System.Drawing.Point(805, 251);
            this.grbReceipt.Name = "grbReceipt";
            this.grbReceipt.Size = new System.Drawing.Size(337, 329);
            this.grbReceipt.TabIndex = 23;
            this.grbReceipt.TabStop = false;
            this.grbReceipt.Text = "Receipt";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(112, 212);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(130, 28);
            this.lblTotal.TabIndex = 26;
            this.lblTotal.Text = "Total = $0.00";
            // 
            // lblHST
            // 
            this.lblHST.AutoSize = true;
            this.lblHST.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHST.Location = new System.Drawing.Point(128, 126);
            this.lblHST.Name = "lblHST";
            this.lblHST.Size = new System.Drawing.Size(91, 20);
            this.lblHST.TabIndex = 25;
            this.lblHST.Text = "HST = $0.00";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(113, 89);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(117, 20);
            this.lblSubtotal.TabIndex = 24;
            this.lblSubtotal.Text = "Subtotal = $0.00";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Font = new System.Drawing.Font("Segoe Print", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckOut.Location = new System.Drawing.Point(904, 172);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(161, 53);
            this.btnCheckOut.TabIndex = 25;
            this.btnCheckOut.Text = "Check Out";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // lblStoreLocation
            // 
            this.lblStoreLocation.AutoSize = true;
            this.lblStoreLocation.Location = new System.Drawing.Point(965, 9);
            this.lblStoreLocation.Name = "lblStoreLocation";
            this.lblStoreLocation.Size = new System.Drawing.Size(116, 13);
            this.lblStoreLocation.TabIndex = 26;
            this.lblStoreLocation.Text = "Store Location: Ottawa";
            // 
            // radCashMethod
            // 
            this.radCashMethod.AutoSize = true;
            this.radCashMethod.Location = new System.Drawing.Point(937, 88);
            this.radCashMethod.Name = "radCashMethod";
            this.radCashMethod.Size = new System.Drawing.Size(84, 17);
            this.radCashMethod.TabIndex = 27;
            this.radCashMethod.TabStop = true;
            this.radCashMethod.Text = "Pay by Cash";
            this.radCashMethod.UseVisualStyleBackColor = true;
            this.radCashMethod.Click += new System.EventHandler(this.radCashMethod_Click);
            // 
            // radDebitMethod
            // 
            this.radDebitMethod.AutoSize = true;
            this.radDebitMethod.Location = new System.Drawing.Point(937, 110);
            this.radDebitMethod.Name = "radDebitMethod";
            this.radDebitMethod.Size = new System.Drawing.Size(85, 17);
            this.radDebitMethod.TabIndex = 28;
            this.radDebitMethod.TabStop = true;
            this.radDebitMethod.Text = "Pay by Debit";
            this.radDebitMethod.UseVisualStyleBackColor = true;
            this.radDebitMethod.Click += new System.EventHandler(this.radDebitMethod_Click);
            // 
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 650);
            this.Controls.Add(this.radDebitMethod);
            this.Controls.Add(this.radCashMethod);
            this.Controls.Add(this.lblStoreLocation);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.grbReceipt);
            this.Controls.Add(this.lblFalseDeliveryNumber);
            this.Controls.Add(this.lblTrueDeliveryNumber);
            this.Controls.Add(this.nudDeliveryOptionChosen);
            this.Controls.Add(this.nudDrinkAmountChosen);
            this.Controls.Add(this.nudToppingNumberChosen);
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
            this.Controls.Add(this.nudPizzaSizeChosen);
            this.Controls.Add(this.lblPizzaSizePrompt);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.mnuMainMenu);
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order By Thomas Aubin";
            ((System.ComponentModel.ISupportInitialize)(this.nudPizzaSizeChosen)).EndInit();
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudToppingNumberChosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDrinkAmountChosen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDeliveryOptionChosen)).EndInit();
            this.grbReceipt.ResumeLayout(false);
            this.grbReceipt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Label lblPizzaSizePrompt;
        private System.Windows.Forms.NumericUpDown nudPizzaSizeChosen;
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
        private System.Windows.Forms.NumericUpDown nudToppingNumberChosen;
        private System.Windows.Forms.NumericUpDown nudDrinkAmountChosen;
        private System.Windows.Forms.NumericUpDown nudDeliveryOptionChosen;
        private System.Windows.Forms.Label lblTrueDeliveryNumber;
        private System.Windows.Forms.Label lblFalseDeliveryNumber;
        private System.Windows.Forms.GroupBox grbReceipt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblHST;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.Label lblStoreLocation;
        private System.Windows.Forms.RadioButton radCashMethod;
        private System.Windows.Forms.RadioButton radDebitMethod;
    }
}


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
            ((System.ComponentModel.ISupportInitialize)(this.nubPizzaSizeChosen)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGreeting.Location = new System.Drawing.Point(8, 9);
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
            this.lblLargePizzaNumber.Location = new System.Drawing.Point(14, 153);
            this.lblLargePizzaNumber.Name = "lblLargePizzaNumber";
            this.lblLargePizzaNumber.Size = new System.Drawing.Size(108, 20);
            this.lblLargePizzaNumber.TabIndex = 3;
            this.lblLargePizzaNumber.Text = "Large Pizza = 1";
            // 
            // ExtraLargePizzaNumber
            // 
            this.ExtraLargePizzaNumber.AutoSize = true;
            this.ExtraLargePizzaNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraLargePizzaNumber.Location = new System.Drawing.Point(14, 176);
            this.ExtraLargePizzaNumber.Name = "ExtraLargePizzaNumber";
            this.ExtraLargePizzaNumber.Size = new System.Drawing.Size(147, 20);
            this.ExtraLargePizzaNumber.TabIndex = 4;
            this.ExtraLargePizzaNumber.Text = "Extra Large Pizza = 2";
            // 
            // lblExtraExtraLargePizzaNumber
            // 
            this.lblExtraExtraLargePizzaNumber.AutoSize = true;
            this.lblExtraExtraLargePizzaNumber.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraExtraLargePizzaNumber.Location = new System.Drawing.Point(13, 200);
            this.lblExtraExtraLargePizzaNumber.Name = "lblExtraExtraLargePizzaNumber";
            this.lblExtraExtraLargePizzaNumber.Size = new System.Drawing.Size(186, 20);
            this.lblExtraExtraLargePizzaNumber.TabIndex = 5;
            this.lblExtraExtraLargePizzaNumber.Text = "Extra Extra Large Pizza = 3";
            // 
            // lblNumberOfDrinksPrompt
            // 
            this.lblNumberOfDrinksPrompt.AutoSize = true;
            this.lblNumberOfDrinksPrompt.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfDrinksPrompt.Location = new System.Drawing.Point(12, 296);
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
            // frmPizzaOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 586);
            this.Controls.Add(this.lblNumberOfToppingsPrompt);
            this.Controls.Add(this.lblNumberOfDrinksPrompt);
            this.Controls.Add(this.lblExtraExtraLargePizzaNumber);
            this.Controls.Add(this.ExtraLargePizzaNumber);
            this.Controls.Add(this.lblLargePizzaNumber);
            this.Controls.Add(this.nubPizzaSizeChosen);
            this.Controls.Add(this.lblPizzaSizePrompt);
            this.Controls.Add(this.lblGreeting);
            this.Name = "frmPizzaOrder";
            this.Text = "Pizza Order By Thomas Aubin";
            ((System.ComponentModel.ISupportInitialize)(this.nubPizzaSizeChosen)).EndInit();
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
    }
}


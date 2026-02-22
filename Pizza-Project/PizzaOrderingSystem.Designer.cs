namespace Pizza_Project
{
    partial class PizzaOrderingSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PizzaOrderingSystem));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.rbLarg = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.grpToppings = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chckMushrooms = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.grpCrustType = new System.Windows.Forms.GroupBox();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.grpWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.grpOrderSummry = new System.Windows.Forms.GroupBox();
            this.lblTotalPriceResult = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWhereToEatResult = new System.Windows.Forms.Label();
            this.lblCrustTypeResult = new System.Windows.Forms.Label();
            this.lblCrustResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultToppings = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lblReultSize = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.grpSize.SuspendLayout();
            this.grpToppings.SuspendLayout();
            this.grpCrustType.SuspendLayout();
            this.grpWhereToEat.SuspendLayout();
            this.grpOrderSummry.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Bauhaus 93", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make Your";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(547, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pizza !";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grpSize
            // 
            this.grpSize.BackColor = System.Drawing.Color.White;
            this.grpSize.Controls.Add(this.rbLarg);
            this.grpSize.Controls.Add(this.rbMeduim);
            this.grpSize.Controls.Add(this.rbSmall);
            this.grpSize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpSize.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSize.Location = new System.Drawing.Point(79, 143);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(186, 164);
            this.grpSize.TabIndex = 2;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Size";
            // 
            // rbLarg
            // 
            this.rbLarg.AutoSize = true;
            this.rbLarg.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbLarg.Location = new System.Drawing.Point(19, 122);
            this.rbLarg.Name = "rbLarg";
            this.rbLarg.Size = new System.Drawing.Size(63, 24);
            this.rbLarg.TabIndex = 8;
            this.rbLarg.TabStop = true;
            this.rbLarg.Tag = "30";
            this.rbLarg.Text = "Larg";
            this.rbLarg.UseVisualStyleBackColor = true;
            this.rbLarg.CheckedChanged += new System.EventHandler(this.rbLarg_CheckedChanged);
            // 
            // rbMeduim
            // 
            this.rbMeduim.AutoSize = true;
            this.rbMeduim.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMeduim.Location = new System.Drawing.Point(19, 81);
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.Size = new System.Drawing.Size(88, 24);
            this.rbMeduim.TabIndex = 7;
            this.rbMeduim.TabStop = true;
            this.rbMeduim.Tag = "20";
            this.rbMeduim.Text = "Meduim";
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSmall.Location = new System.Drawing.Point(19, 40);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(67, 24);
            this.rbSmall.TabIndex = 6;
            this.rbSmall.TabStop = true;
            this.rbSmall.Tag = "10";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // grpToppings
            // 
            this.grpToppings.BackColor = System.Drawing.Color.White;
            this.grpToppings.Controls.Add(this.chkOlives);
            this.grpToppings.Controls.Add(this.chkOnion);
            this.grpToppings.Controls.Add(this.chkTomatoes);
            this.grpToppings.Controls.Add(this.chckMushrooms);
            this.grpToppings.Controls.Add(this.chkExtraCheese);
            this.grpToppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpToppings.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpToppings.Location = new System.Drawing.Point(332, 143);
            this.grpToppings.Name = "grpToppings";
            this.grpToppings.Size = new System.Drawing.Size(271, 164);
            this.grpToppings.TabIndex = 5;
            this.grpToppings.TabStop = false;
            this.grpToppings.Text = "Toppings";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOlives.Location = new System.Drawing.Point(183, 81);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(74, 24);
            this.chkOlives.TabIndex = 6;
            this.chkOlives.Tag = "2";
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnion.Location = new System.Drawing.Point(183, 40);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(73, 24);
            this.chkOnion.TabIndex = 5;
            this.chkOnion.Tag = "2";
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkTomatoes.Location = new System.Drawing.Point(15, 123);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(99, 24);
            this.chkTomatoes.TabIndex = 4;
            this.chkTomatoes.Tag = "2";
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chckMushrooms
            // 
            this.chckMushrooms.AutoSize = true;
            this.chckMushrooms.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chckMushrooms.Location = new System.Drawing.Point(15, 81);
            this.chckMushrooms.Name = "chckMushrooms";
            this.chckMushrooms.Size = new System.Drawing.Size(115, 24);
            this.chckMushrooms.TabIndex = 3;
            this.chckMushrooms.Tag = "2";
            this.chckMushrooms.Text = "Mushrooms";
            this.chckMushrooms.UseVisualStyleBackColor = true;
            this.chckMushrooms.CheckedChanged += new System.EventHandler(this.chckMushrooms_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExtraCheese.Location = new System.Drawing.Point(15, 40);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(123, 24);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Tag = "2";
            this.chkExtraCheese.Text = "Extra Cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // grpCrustType
            // 
            this.grpCrustType.BackColor = System.Drawing.Color.White;
            this.grpCrustType.Controls.Add(this.rbThickCrust);
            this.grpCrustType.Controls.Add(this.rbThinCrust);
            this.grpCrustType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpCrustType.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCrustType.Location = new System.Drawing.Point(79, 359);
            this.grpCrustType.Name = "grpCrustType";
            this.grpCrustType.Size = new System.Drawing.Size(186, 161);
            this.grpCrustType.TabIndex = 5;
            this.grpCrustType.TabStop = false;
            this.grpCrustType.Text = "Crust Type";
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThickCrust.Location = new System.Drawing.Point(19, 82);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(115, 24);
            this.rbThickCrust.TabIndex = 9;
            this.rbThickCrust.TabStop = true;
            this.rbThickCrust.Tag = "5";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbThinCrust.Location = new System.Drawing.Point(19, 40);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(108, 24);
            this.rbThinCrust.TabIndex = 8;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // grpWhereToEat
            // 
            this.grpWhereToEat.BackColor = System.Drawing.Color.White;
            this.grpWhereToEat.Controls.Add(this.rbTakeOut);
            this.grpWhereToEat.Controls.Add(this.rbEatIn);
            this.grpWhereToEat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpWhereToEat.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpWhereToEat.Location = new System.Drawing.Point(332, 359);
            this.grpWhereToEat.Name = "grpWhereToEat";
            this.grpWhereToEat.Size = new System.Drawing.Size(271, 90);
            this.grpWhereToEat.TabIndex = 10;
            this.grpWhereToEat.TabStop = false;
            this.grpWhereToEat.Text = "Where To Eat ?";
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTakeOut.Location = new System.Drawing.Point(160, 40);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(96, 24);
            this.rbTakeOut.TabIndex = 9;
            this.rbTakeOut.TabStop = true;
            this.rbTakeOut.Tag = "2";
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Font = new System.Drawing.Font("Bell MT", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEatIn.Location = new System.Drawing.Point(19, 40);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(73, 24);
            this.rbEatIn.TabIndex = 8;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Location = new System.Drawing.Point(332, 483);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(114, 37);
            this.btnOrderPizza.TabIndex = 11;
            this.btnOrderPizza.Text = "Order Pizaa";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.Location = new System.Drawing.Point(489, 483);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(114, 37);
            this.btnResetForm.TabIndex = 12;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // grpOrderSummry
            // 
            this.grpOrderSummry.BackColor = System.Drawing.Color.White;
            this.grpOrderSummry.Controls.Add(this.lblTotalPriceResult);
            this.grpOrderSummry.Controls.Add(this.label3);
            this.grpOrderSummry.Controls.Add(this.lblWhereToEatResult);
            this.grpOrderSummry.Controls.Add(this.lblCrustTypeResult);
            this.grpOrderSummry.Controls.Add(this.lblCrustResult);
            this.grpOrderSummry.Controls.Add(this.label4);
            this.grpOrderSummry.Controls.Add(this.lblResultToppings);
            this.grpOrderSummry.Controls.Add(this.lblToppings);
            this.grpOrderSummry.Controls.Add(this.lblReultSize);
            this.grpOrderSummry.Controls.Add(this.lblSize);
            this.grpOrderSummry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOrderSummry.Font = new System.Drawing.Font("Bauhaus 93", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOrderSummry.Location = new System.Drawing.Point(662, 143);
            this.grpOrderSummry.Name = "grpOrderSummry";
            this.grpOrderSummry.Size = new System.Drawing.Size(363, 377);
            this.grpOrderSummry.TabIndex = 9;
            this.grpOrderSummry.TabStop = false;
            this.grpOrderSummry.Text = "Order Summry";
            // 
            // lblTotalPriceResult
            // 
            this.lblTotalPriceResult.AutoSize = true;
            this.lblTotalPriceResult.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalPriceResult.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPriceResult.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPriceResult.Location = new System.Drawing.Point(186, 293);
            this.lblTotalPriceResult.Name = "lblTotalPriceResult";
            this.lblTotalPriceResult.Size = new System.Drawing.Size(150, 35);
            this.lblTotalPriceResult.TabIndex = 23;
            this.lblTotalPriceResult.Text = "Total Price ";
            this.lblTotalPriceResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(41, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 28);
            this.label3.TabIndex = 22;
            this.label3.Text = "Total Price :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblWhereToEatResult
            // 
            this.lblWhereToEatResult.AutoSize = true;
            this.lblWhereToEatResult.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhereToEatResult.Location = new System.Drawing.Point(198, 206);
            this.lblWhereToEatResult.Name = "lblWhereToEatResult";
            this.lblWhereToEatResult.Size = new System.Drawing.Size(131, 23);
            this.lblWhereToEatResult.TabIndex = 21;
            this.lblWhereToEatResult.Text = "Where To Eat";
            this.lblWhereToEatResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCrustTypeResult
            // 
            this.lblCrustTypeResult.AutoSize = true;
            this.lblCrustTypeResult.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustTypeResult.Location = new System.Drawing.Point(210, 82);
            this.lblCrustTypeResult.Name = "lblCrustTypeResult";
            this.lblCrustTypeResult.Size = new System.Drawing.Size(104, 23);
            this.lblCrustTypeResult.TabIndex = 19;
            this.lblCrustTypeResult.Text = "Crust Type";
            this.lblCrustTypeResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCrustResult
            // 
            this.lblCrustResult.AutoSize = true;
            this.lblCrustResult.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCrustResult.Location = new System.Drawing.Point(210, 49);
            this.lblCrustResult.Name = "lblCrustResult";
            this.lblCrustResult.Size = new System.Drawing.Size(104, 24);
            this.lblCrustResult.TabIndex = 18;
            this.lblCrustResult.Text = "CrustType";
            this.lblCrustResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(198, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Where To Eat:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblResultToppings
            // 
            this.lblResultToppings.AutoSize = true;
            this.lblResultToppings.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultToppings.Location = new System.Drawing.Point(41, 206);
            this.lblResultToppings.Name = "lblResultToppings";
            this.lblResultToppings.Size = new System.Drawing.Size(90, 23);
            this.lblResultToppings.TabIndex = 17;
            this.lblResultToppings.Text = "Toppings";
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToppings.Location = new System.Drawing.Point(41, 162);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(104, 24);
            this.lblToppings.TabIndex = 16;
            this.lblToppings.Text = "Toppings :";
            this.lblToppings.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblReultSize
            // 
            this.lblReultSize.AutoSize = true;
            this.lblReultSize.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReultSize.Location = new System.Drawing.Point(41, 82);
            this.lblReultSize.Name = "lblReultSize";
            this.lblReultSize.Size = new System.Drawing.Size(44, 23);
            this.lblReultSize.TabIndex = 15;
            this.lblReultSize.Text = "Size";
            this.lblReultSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Bell MT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSize.Location = new System.Drawing.Point(41, 49);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(56, 24);
            this.lblSize.TabIndex = 14;
            this.lblSize.Text = "Size :";
            this.lblSize.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1094, 577);
            this.Controls.Add(this.grpOrderSummry);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.grpWhereToEat);
            this.Controls.Add(this.grpCrustType);
            this.Controls.Add(this.grpToppings);
            this.Controls.Add(this.grpSize);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pizza Ordering System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpToppings.ResumeLayout(false);
            this.grpToppings.PerformLayout();
            this.grpCrustType.ResumeLayout(false);
            this.grpCrustType.PerformLayout();
            this.grpWhereToEat.ResumeLayout(false);
            this.grpWhereToEat.PerformLayout();
            this.grpOrderSummry.ResumeLayout(false);
            this.grpOrderSummry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.GroupBox grpToppings;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chckMushrooms;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.GroupBox grpCrustType;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.RadioButton rbLarg;
        private System.Windows.Forms.GroupBox grpWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.GroupBox grpOrderSummry;
        private System.Windows.Forms.Label lblReultSize;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblResultToppings;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblCrustTypeResult;
        private System.Windows.Forms.Label lblCrustResult;
        private System.Windows.Forms.Label lblWhereToEatResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalPriceResult;
        private System.Windows.Forms.Label label3;
    }
}


namespace View.Forms.Order_Screens
{
    partial class Overview
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
            this.billOverViewListView = new System.Windows.Forms.ListView();
            this.MenuItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Amount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bonOverzichtLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.overViewPanel = new System.Windows.Forms.Panel();
            this.addOrderPanel = new System.Windows.Forms.Panel();
            this.lunchSubPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.commentAndAmountPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addCommentTextBox = new System.Windows.Forms.TextBox();
            this.dinerSubPanel = new System.Windows.Forms.Panel();
            this.dinerSubLabel = new System.Windows.Forms.Label();
            this.drankenSubPanel = new System.Windows.Forms.Panel();
            this.drankenSubLabel = new System.Windows.Forms.Label();
            this.alchoholSubPanel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.menuItemsListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newOrderItemsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeOrderPanel = new System.Windows.Forms.Panel();
            this.changeOrderListView = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.changeOrderButton2 = new View.CustomControls.CustomButton();
            this.lunchMainButton = new View.CustomControls.CustomButton();
            this.lunchDesertButton = new View.CustomControls.CustomButton();
            this.lunchStarterButton = new View.CustomControls.CustomButton();
            this.minusButton = new View.CustomControls.CustomButton();
            this.plusButton = new View.CustomControls.CustomButton();
            this.changeItemButton = new View.CustomControls.CustomButton();
            this.clearOrderButton = new View.CustomControls.CustomButton();
            this.dinerDesertButton = new View.CustomControls.CustomButton();
            this.dinerMainButton = new View.CustomControls.CustomButton();
            this.dinerSideButton = new View.CustomControls.CustomButton();
            this.dinerStarterButton = new View.CustomControls.CustomButton();
            this.deleteItemFromOrderButton = new View.CustomControls.CustomButton();
            this.frisdrankButton = new View.CustomControls.CustomButton();
            this.warmeDrankenButton = new View.CustomControls.CustomButton();
            this.gedestilleerdButton = new View.CustomControls.CustomButton();
            this.wijnButton = new View.CustomControls.CustomButton();
            this.bierButton = new View.CustomControls.CustomButton();
            this.alcoholButton = new View.CustomControls.CustomButton();
            this.drankenButton = new View.CustomControls.CustomButton();
            this.dinerButton = new View.CustomControls.CustomButton();
            this.lunchButton = new View.CustomControls.CustomButton();
            this.backToOverviewButton = new View.CustomControls.CustomButton();
            this.insertOrderButton = new View.CustomControls.CustomButton();
            this.addItemButton = new View.CustomControls.CustomButton();
            this.ChangeOrderButton = new View.CustomControls.CustomButton();
            this.orderInPreparationToggle = new View.CustomControls.ToggleButton();
            this.groupItemsToggle = new View.CustomControls.ToggleButton();
            this.backToTablesButton = new View.CustomControls.CustomButton();
            this.newOrderButton = new View.CustomControls.CustomButton();
            this.overViewPanel.SuspendLayout();
            this.addOrderPanel.SuspendLayout();
            this.lunchSubPanel.SuspendLayout();
            this.commentAndAmountPanel.SuspendLayout();
            this.dinerSubPanel.SuspendLayout();
            this.drankenSubPanel.SuspendLayout();
            this.alchoholSubPanel.SuspendLayout();
            this.changeOrderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // billOverViewListView
            // 
            this.billOverViewListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MenuItem,
            this.Amount,
            this.Comment});
            this.billOverViewListView.FullRowSelect = true;
            this.billOverViewListView.GridLines = true;
            this.billOverViewListView.HideSelection = false;
            this.billOverViewListView.Location = new System.Drawing.Point(10, 25);
            this.billOverViewListView.Name = "billOverViewListView";
            this.billOverViewListView.Size = new System.Drawing.Size(406, 456);
            this.billOverViewListView.TabIndex = 3;
            this.billOverViewListView.UseCompatibleStateImageBehavior = false;
            this.billOverViewListView.View = System.Windows.Forms.View.Details;
            // 
            // MenuItem
            // 
            this.MenuItem.Text = "Item";
            this.MenuItem.Width = 200;
            // 
            // Amount
            // 
            this.Amount.Text = "Amount";
            this.Amount.Width = 48;
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            this.Comment.Width = 100;
            // 
            // bonOverzichtLabel
            // 
            this.bonOverzichtLabel.AutoSize = true;
            this.bonOverzichtLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.bonOverzichtLabel.Location = new System.Drawing.Point(10, 9);
            this.bonOverzichtLabel.Name = "bonOverzichtLabel";
            this.bonOverzichtLabel.Size = new System.Drawing.Size(74, 13);
            this.bonOverzichtLabel.TabIndex = 4;
            this.bonOverzichtLabel.Text = "Bon Overzicht";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(12, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Groepeer dezelfde items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(12, 526);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 20);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(12, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(230, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Laat bestelling in bereiding zien";
            // 
            // overViewPanel
            // 
            this.overViewPanel.Controls.Add(this.ChangeOrderButton);
            this.overViewPanel.Controls.Add(this.bonOverzichtLabel);
            this.overViewPanel.Controls.Add(this.orderInPreparationToggle);
            this.overViewPanel.Controls.Add(this.groupItemsToggle);
            this.overViewPanel.Controls.Add(this.backToTablesButton);
            this.overViewPanel.Controls.Add(this.billOverViewListView);
            this.overViewPanel.Controls.Add(this.label4);
            this.overViewPanel.Controls.Add(this.newOrderButton);
            this.overViewPanel.Controls.Add(this.label2);
            this.overViewPanel.Location = new System.Drawing.Point(0, 0);
            this.overViewPanel.Name = "overViewPanel";
            this.overViewPanel.Size = new System.Drawing.Size(428, 795);
            this.overViewPanel.TabIndex = 19;
            this.overViewPanel.Visible = false;
            // 
            // addOrderPanel
            // 
            this.addOrderPanel.Controls.Add(this.lunchSubPanel);
            this.addOrderPanel.Controls.Add(this.commentAndAmountPanel);
            this.addOrderPanel.Controls.Add(this.changeItemButton);
            this.addOrderPanel.Controls.Add(this.clearOrderButton);
            this.addOrderPanel.Controls.Add(this.dinerSubPanel);
            this.addOrderPanel.Controls.Add(this.deleteItemFromOrderButton);
            this.addOrderPanel.Controls.Add(this.drankenSubPanel);
            this.addOrderPanel.Controls.Add(this.alchoholSubPanel);
            this.addOrderPanel.Controls.Add(this.alcoholButton);
            this.addOrderPanel.Controls.Add(this.drankenButton);
            this.addOrderPanel.Controls.Add(this.dinerButton);
            this.addOrderPanel.Controls.Add(this.lunchButton);
            this.addOrderPanel.Controls.Add(this.menuItemsListView);
            this.addOrderPanel.Controls.Add(this.backToOverviewButton);
            this.addOrderPanel.Controls.Add(this.newOrderItemsListView);
            this.addOrderPanel.Controls.Add(this.insertOrderButton);
            this.addOrderPanel.Controls.Add(this.addItemButton);
            this.addOrderPanel.Location = new System.Drawing.Point(0, 0);
            this.addOrderPanel.Name = "addOrderPanel";
            this.addOrderPanel.Size = new System.Drawing.Size(428, 795);
            this.addOrderPanel.TabIndex = 18;
            this.addOrderPanel.Visible = false;
            // 
            // lunchSubPanel
            // 
            this.lunchSubPanel.Controls.Add(this.lunchMainButton);
            this.lunchSubPanel.Controls.Add(this.lunchDesertButton);
            this.lunchSubPanel.Controls.Add(this.lunchStarterButton);
            this.lunchSubPanel.Controls.Add(this.label6);
            this.lunchSubPanel.Location = new System.Drawing.Point(305, 55);
            this.lunchSubPanel.Name = "lunchSubPanel";
            this.lunchSubPanel.Size = new System.Drawing.Size(102, 326);
            this.lunchSubPanel.TabIndex = 23;
            this.lunchSubPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(29, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Lunch";
            // 
            // commentAndAmountPanel
            // 
            this.commentAndAmountPanel.Controls.Add(this.label5);
            this.commentAndAmountPanel.Controls.Add(this.minusButton);
            this.commentAndAmountPanel.Controls.Add(this.amountLabel);
            this.commentAndAmountPanel.Controls.Add(this.addCommentTextBox);
            this.commentAndAmountPanel.Controls.Add(this.plusButton);
            this.commentAndAmountPanel.Location = new System.Drawing.Point(10, 387);
            this.commentAndAmountPanel.Name = "commentAndAmountPanel";
            this.commentAndAmountPanel.Size = new System.Drawing.Size(288, 52);
            this.commentAndAmountPanel.TabIndex = 28;
            this.commentAndAmountPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(12, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Opmerking:";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.amountLabel.Location = new System.Drawing.Point(203, 9);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(37, 39);
            this.amountLabel.TabIndex = 17;
            this.amountLabel.Text = "1";
            // 
            // addCommentTextBox
            // 
            this.addCommentTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addCommentTextBox.Location = new System.Drawing.Point(12, 22);
            this.addCommentTextBox.Name = "addCommentTextBox";
            this.addCommentTextBox.Size = new System.Drawing.Size(130, 20);
            this.addCommentTextBox.TabIndex = 18;
            // 
            // dinerSubPanel
            // 
            this.dinerSubPanel.Controls.Add(this.dinerDesertButton);
            this.dinerSubPanel.Controls.Add(this.dinerMainButton);
            this.dinerSubPanel.Controls.Add(this.dinerSideButton);
            this.dinerSubPanel.Controls.Add(this.dinerStarterButton);
            this.dinerSubPanel.Controls.Add(this.dinerSubLabel);
            this.dinerSubPanel.Location = new System.Drawing.Point(305, 55);
            this.dinerSubPanel.Name = "dinerSubPanel";
            this.dinerSubPanel.Size = new System.Drawing.Size(102, 326);
            this.dinerSubPanel.TabIndex = 24;
            this.dinerSubPanel.Visible = false;
            // 
            // dinerSubLabel
            // 
            this.dinerSubLabel.AutoSize = true;
            this.dinerSubLabel.ForeColor = System.Drawing.Color.White;
            this.dinerSubLabel.Location = new System.Drawing.Point(29, 11);
            this.dinerSubLabel.Name = "dinerSubLabel";
            this.dinerSubLabel.Size = new System.Drawing.Size(35, 13);
            this.dinerSubLabel.TabIndex = 0;
            this.dinerSubLabel.Text = "Diner:";
            // 
            // drankenSubPanel
            // 
            this.drankenSubPanel.Controls.Add(this.frisdrankButton);
            this.drankenSubPanel.Controls.Add(this.warmeDrankenButton);
            this.drankenSubPanel.Controls.Add(this.drankenSubLabel);
            this.drankenSubPanel.Location = new System.Drawing.Point(305, 55);
            this.drankenSubPanel.Name = "drankenSubPanel";
            this.drankenSubPanel.Size = new System.Drawing.Size(102, 326);
            this.drankenSubPanel.TabIndex = 22;
            this.drankenSubPanel.Visible = false;
            // 
            // drankenSubLabel
            // 
            this.drankenSubLabel.AutoSize = true;
            this.drankenSubLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.drankenSubLabel.Location = new System.Drawing.Point(29, 10);
            this.drankenSubLabel.Name = "drankenSubLabel";
            this.drankenSubLabel.Size = new System.Drawing.Size(51, 13);
            this.drankenSubLabel.TabIndex = 0;
            this.drankenSubLabel.Text = "Dranken:";
            // 
            // alchoholSubPanel
            // 
            this.alchoholSubPanel.Controls.Add(this.gedestilleerdButton);
            this.alchoholSubPanel.Controls.Add(this.wijnButton);
            this.alchoholSubPanel.Controls.Add(this.bierButton);
            this.alchoholSubPanel.Controls.Add(this.label7);
            this.alchoholSubPanel.Location = new System.Drawing.Point(305, 55);
            this.alchoholSubPanel.Name = "alchoholSubPanel";
            this.alchoholSubPanel.Size = new System.Drawing.Size(102, 326);
            this.alchoholSubPanel.TabIndex = 21;
            this.alchoholSubPanel.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(29, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Alcohol:";
            // 
            // menuItemsListView
            // 
            this.menuItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.Item});
            this.menuItemsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuItemsListView.FullRowSelect = true;
            this.menuItemsListView.GridLines = true;
            this.menuItemsListView.HideSelection = false;
            this.menuItemsListView.Location = new System.Drawing.Point(10, 55);
            this.menuItemsListView.Name = "menuItemsListView";
            this.menuItemsListView.Size = new System.Drawing.Size(397, 326);
            this.menuItemsListView.TabIndex = 0;
            this.menuItemsListView.UseCompatibleStateImageBehavior = false;
            this.menuItemsListView.View = System.Windows.Forms.View.Details;
            this.menuItemsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.menuItemsListView_ItemSelectionChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 29;
            // 
            // Item
            // 
            this.Item.Text = "Item";
            this.Item.Width = 200;
            // 
            // newOrderItemsListView
            // 
            this.newOrderItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.newOrderItemsListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderItemsListView.FullRowSelect = true;
            this.newOrderItemsListView.GridLines = true;
            this.newOrderItemsListView.HideSelection = false;
            this.newOrderItemsListView.Location = new System.Drawing.Point(10, 453);
            this.newOrderItemsListView.Name = "newOrderItemsListView";
            this.newOrderItemsListView.Size = new System.Drawing.Size(397, 179);
            this.newOrderItemsListView.TabIndex = 5;
            this.newOrderItemsListView.UseCompatibleStateImageBehavior = false;
            this.newOrderItemsListView.View = System.Windows.Forms.View.Details;
            this.newOrderItemsListView.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.newOrderItemsListView_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Item";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Aantal";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Comment";
            this.columnHeader3.Width = 100;
            // 
            // changeOrderPanel
            // 
            this.changeOrderPanel.Controls.Add(this.changeOrderButton2);
            this.changeOrderPanel.Controls.Add(this.changeOrderListView);
            this.changeOrderPanel.Location = new System.Drawing.Point(0, 0);
            this.changeOrderPanel.Name = "changeOrderPanel";
            this.changeOrderPanel.Size = new System.Drawing.Size(428, 795);
            this.changeOrderPanel.TabIndex = 29;
            this.changeOrderPanel.Visible = false;
            // 
            // changeOrderListView
            // 
            this.changeOrderListView.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeOrderListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.changeOrderListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.changeOrderListView.FullRowSelect = true;
            this.changeOrderListView.GridLines = true;
            this.changeOrderListView.HideSelection = false;
            this.changeOrderListView.Location = new System.Drawing.Point(10, 25);
            this.changeOrderListView.Name = "changeOrderListView";
            this.changeOrderListView.Size = new System.Drawing.Size(406, 404);
            this.changeOrderListView.TabIndex = 4;
            this.changeOrderListView.UseCompatibleStateImageBehavior = false;
            this.changeOrderListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Item";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Amount";
            this.columnHeader5.Width = 48;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Comment";
            this.columnHeader6.Width = 100;
            // 
            // changeOrderButton2
            // 
            this.changeOrderButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.changeOrderButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.changeOrderButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.changeOrderButton2.BorderRadius = 20;
            this.changeOrderButton2.BorderSize = 0;
            this.changeOrderButton2.Enabled = false;
            this.changeOrderButton2.FlatAppearance.BorderSize = 0;
            this.changeOrderButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeOrderButton2.ForeColor = System.Drawing.Color.White;
            this.changeOrderButton2.Location = new System.Drawing.Point(313, 435);
            this.changeOrderButton2.Name = "changeOrderButton2";
            this.changeOrderButton2.Size = new System.Drawing.Size(103, 37);
            this.changeOrderButton2.TabIndex = 28;
            this.changeOrderButton2.Text = "Wijzig Item";
            this.changeOrderButton2.TextColor = System.Drawing.Color.White;
            this.changeOrderButton2.UseVisualStyleBackColor = false;
            this.changeOrderButton2.Visible = false;
            this.changeOrderButton2.Click += new System.EventHandler(this.changeOrderButton2_Click);
            // 
            // lunchMainButton
            // 
            this.lunchMainButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lunchMainButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lunchMainButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lunchMainButton.BorderRadius = 5;
            this.lunchMainButton.BorderSize = 0;
            this.lunchMainButton.FlatAppearance.BorderSize = 0;
            this.lunchMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lunchMainButton.ForeColor = System.Drawing.Color.White;
            this.lunchMainButton.Location = new System.Drawing.Point(3, 73);
            this.lunchMainButton.Name = "lunchMainButton";
            this.lunchMainButton.Size = new System.Drawing.Size(92, 40);
            this.lunchMainButton.TabIndex = 26;
            this.lunchMainButton.Text = "Main";
            this.lunchMainButton.TextColor = System.Drawing.Color.White;
            this.lunchMainButton.UseVisualStyleBackColor = false;
            this.lunchMainButton.Click += new System.EventHandler(this.lunchMainButton_Click);
            // 
            // lunchDesertButton
            // 
            this.lunchDesertButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lunchDesertButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lunchDesertButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lunchDesertButton.BorderRadius = 5;
            this.lunchDesertButton.BorderSize = 0;
            this.lunchDesertButton.FlatAppearance.BorderSize = 0;
            this.lunchDesertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lunchDesertButton.ForeColor = System.Drawing.Color.White;
            this.lunchDesertButton.Location = new System.Drawing.Point(3, 119);
            this.lunchDesertButton.Name = "lunchDesertButton";
            this.lunchDesertButton.Size = new System.Drawing.Size(92, 40);
            this.lunchDesertButton.TabIndex = 25;
            this.lunchDesertButton.Text = "Desert";
            this.lunchDesertButton.TextColor = System.Drawing.Color.White;
            this.lunchDesertButton.UseVisualStyleBackColor = false;
            this.lunchDesertButton.Click += new System.EventHandler(this.lunchDesertButton_Click);
            // 
            // lunchStarterButton
            // 
            this.lunchStarterButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lunchStarterButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lunchStarterButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lunchStarterButton.BorderRadius = 5;
            this.lunchStarterButton.BorderSize = 0;
            this.lunchStarterButton.FlatAppearance.BorderSize = 0;
            this.lunchStarterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lunchStarterButton.ForeColor = System.Drawing.Color.White;
            this.lunchStarterButton.Location = new System.Drawing.Point(3, 27);
            this.lunchStarterButton.Name = "lunchStarterButton";
            this.lunchStarterButton.Size = new System.Drawing.Size(92, 40);
            this.lunchStarterButton.TabIndex = 24;
            this.lunchStarterButton.Text = "Starter";
            this.lunchStarterButton.TextColor = System.Drawing.Color.White;
            this.lunchStarterButton.UseVisualStyleBackColor = false;
            this.lunchStarterButton.Click += new System.EventHandler(this.lunchStarterButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Tomato;
            this.minusButton.BackgroundColor = System.Drawing.Color.Tomato;
            this.minusButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.minusButton.BorderRadius = 23;
            this.minusButton.BorderSize = 0;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.Color.Black;
            this.minusButton.Location = new System.Drawing.Point(160, 9);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(44, 37);
            this.minusButton.TabIndex = 16;
            this.minusButton.Text = "-";
            this.minusButton.TextColor = System.Drawing.Color.Black;
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.PaleGreen;
            this.plusButton.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.plusButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plusButton.BorderRadius = 25;
            this.plusButton.BorderSize = 0;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.Color.Black;
            this.plusButton.Location = new System.Drawing.Point(241, 9);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(44, 37);
            this.plusButton.TabIndex = 15;
            this.plusButton.Text = "+";
            this.plusButton.TextColor = System.Drawing.Color.Black;
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.plusButton_Click);
            // 
            // changeItemButton
            // 
            this.changeItemButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.changeItemButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.changeItemButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.changeItemButton.BorderRadius = 20;
            this.changeItemButton.BorderSize = 0;
            this.changeItemButton.Enabled = false;
            this.changeItemButton.FlatAppearance.BorderSize = 0;
            this.changeItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeItemButton.ForeColor = System.Drawing.Color.White;
            this.changeItemButton.Location = new System.Drawing.Point(308, 638);
            this.changeItemButton.Name = "changeItemButton";
            this.changeItemButton.Size = new System.Drawing.Size(103, 37);
            this.changeItemButton.TabIndex = 27;
            this.changeItemButton.Text = "Wijzig Item";
            this.changeItemButton.TextColor = System.Drawing.Color.White;
            this.changeItemButton.UseVisualStyleBackColor = false;
            this.changeItemButton.Visible = false;
            this.changeItemButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // clearOrderButton
            // 
            this.clearOrderButton.BackColor = System.Drawing.Color.BurlyWood;
            this.clearOrderButton.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.clearOrderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.clearOrderButton.BorderRadius = 20;
            this.clearOrderButton.BorderSize = 0;
            this.clearOrderButton.Enabled = false;
            this.clearOrderButton.FlatAppearance.BorderSize = 0;
            this.clearOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearOrderButton.ForeColor = System.Drawing.Color.Black;
            this.clearOrderButton.Location = new System.Drawing.Point(14, 638);
            this.clearOrderButton.Name = "clearOrderButton";
            this.clearOrderButton.Size = new System.Drawing.Size(109, 37);
            this.clearOrderButton.TabIndex = 26;
            this.clearOrderButton.Text = "Leeg Order";
            this.clearOrderButton.TextColor = System.Drawing.Color.Black;
            this.clearOrderButton.UseVisualStyleBackColor = false;
            this.clearOrderButton.Visible = false;
            this.clearOrderButton.Click += new System.EventHandler(this.clearOrderButton_Click);
            // 
            // dinerDesertButton
            // 
            this.dinerDesertButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerDesertButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerDesertButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dinerDesertButton.BorderRadius = 5;
            this.dinerDesertButton.BorderSize = 0;
            this.dinerDesertButton.FlatAppearance.BorderSize = 0;
            this.dinerDesertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dinerDesertButton.ForeColor = System.Drawing.Color.White;
            this.dinerDesertButton.Location = new System.Drawing.Point(3, 165);
            this.dinerDesertButton.Name = "dinerDesertButton";
            this.dinerDesertButton.Size = new System.Drawing.Size(92, 40);
            this.dinerDesertButton.TabIndex = 28;
            this.dinerDesertButton.Text = "Desert";
            this.dinerDesertButton.TextColor = System.Drawing.Color.White;
            this.dinerDesertButton.UseVisualStyleBackColor = false;
            this.dinerDesertButton.MouseCaptureChanged += new System.EventHandler(this.dinerDesertButton_Click);
            // 
            // dinerMainButton
            // 
            this.dinerMainButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerMainButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerMainButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dinerMainButton.BorderRadius = 5;
            this.dinerMainButton.BorderSize = 0;
            this.dinerMainButton.FlatAppearance.BorderSize = 0;
            this.dinerMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dinerMainButton.ForeColor = System.Drawing.Color.White;
            this.dinerMainButton.Location = new System.Drawing.Point(3, 119);
            this.dinerMainButton.Name = "dinerMainButton";
            this.dinerMainButton.Size = new System.Drawing.Size(92, 40);
            this.dinerMainButton.TabIndex = 27;
            this.dinerMainButton.Text = "Main";
            this.dinerMainButton.TextColor = System.Drawing.Color.White;
            this.dinerMainButton.UseVisualStyleBackColor = false;
            this.dinerMainButton.Click += new System.EventHandler(this.dinerMainButton_Click);
            // 
            // dinerSideButton
            // 
            this.dinerSideButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerSideButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerSideButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dinerSideButton.BorderRadius = 5;
            this.dinerSideButton.BorderSize = 0;
            this.dinerSideButton.FlatAppearance.BorderSize = 0;
            this.dinerSideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dinerSideButton.ForeColor = System.Drawing.Color.White;
            this.dinerSideButton.Location = new System.Drawing.Point(3, 73);
            this.dinerSideButton.Name = "dinerSideButton";
            this.dinerSideButton.Size = new System.Drawing.Size(92, 40);
            this.dinerSideButton.TabIndex = 26;
            this.dinerSideButton.Text = "Side";
            this.dinerSideButton.TextColor = System.Drawing.Color.White;
            this.dinerSideButton.UseVisualStyleBackColor = false;
            this.dinerSideButton.Click += new System.EventHandler(this.dinerSideButton_Click);
            // 
            // dinerStarterButton
            // 
            this.dinerStarterButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerStarterButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerStarterButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dinerStarterButton.BorderRadius = 5;
            this.dinerStarterButton.BorderSize = 0;
            this.dinerStarterButton.FlatAppearance.BorderSize = 0;
            this.dinerStarterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dinerStarterButton.ForeColor = System.Drawing.Color.White;
            this.dinerStarterButton.Location = new System.Drawing.Point(3, 27);
            this.dinerStarterButton.Name = "dinerStarterButton";
            this.dinerStarterButton.Size = new System.Drawing.Size(92, 40);
            this.dinerStarterButton.TabIndex = 25;
            this.dinerStarterButton.Text = "Starter";
            this.dinerStarterButton.TextColor = System.Drawing.Color.White;
            this.dinerStarterButton.UseVisualStyleBackColor = false;
            this.dinerStarterButton.Click += new System.EventHandler(this.dinerStarterButton_Click);
            // 
            // deleteItemFromOrderButton
            // 
            this.deleteItemFromOrderButton.BackColor = System.Drawing.Color.BurlyWood;
            this.deleteItemFromOrderButton.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.deleteItemFromOrderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteItemFromOrderButton.BorderRadius = 20;
            this.deleteItemFromOrderButton.BorderSize = 0;
            this.deleteItemFromOrderButton.Enabled = false;
            this.deleteItemFromOrderButton.FlatAppearance.BorderSize = 0;
            this.deleteItemFromOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemFromOrderButton.ForeColor = System.Drawing.Color.Black;
            this.deleteItemFromOrderButton.Location = new System.Drawing.Point(128, 638);
            this.deleteItemFromOrderButton.Name = "deleteItemFromOrderButton";
            this.deleteItemFromOrderButton.Size = new System.Drawing.Size(109, 37);
            this.deleteItemFromOrderButton.TabIndex = 25;
            this.deleteItemFromOrderButton.Text = "Verwijder Item";
            this.deleteItemFromOrderButton.TextColor = System.Drawing.Color.Black;
            this.deleteItemFromOrderButton.UseVisualStyleBackColor = false;
            this.deleteItemFromOrderButton.Visible = false;
            this.deleteItemFromOrderButton.Click += new System.EventHandler(this.deleteItemFromOrderButton_Click);
            // 
            // frisdrankButton
            // 
            this.frisdrankButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.frisdrankButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.frisdrankButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.frisdrankButton.BorderRadius = 5;
            this.frisdrankButton.BorderSize = 0;
            this.frisdrankButton.FlatAppearance.BorderSize = 0;
            this.frisdrankButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.frisdrankButton.ForeColor = System.Drawing.Color.White;
            this.frisdrankButton.Location = new System.Drawing.Point(7, 84);
            this.frisdrankButton.Name = "frisdrankButton";
            this.frisdrankButton.Size = new System.Drawing.Size(92, 51);
            this.frisdrankButton.TabIndex = 24;
            this.frisdrankButton.Text = "Frisdrank";
            this.frisdrankButton.TextColor = System.Drawing.Color.White;
            this.frisdrankButton.UseVisualStyleBackColor = false;
            this.frisdrankButton.Click += new System.EventHandler(this.frisdrankButton_Click);
            // 
            // warmeDrankenButton
            // 
            this.warmeDrankenButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.warmeDrankenButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.warmeDrankenButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.warmeDrankenButton.BorderRadius = 5;
            this.warmeDrankenButton.BorderSize = 0;
            this.warmeDrankenButton.FlatAppearance.BorderSize = 0;
            this.warmeDrankenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.warmeDrankenButton.ForeColor = System.Drawing.Color.White;
            this.warmeDrankenButton.Location = new System.Drawing.Point(7, 27);
            this.warmeDrankenButton.Name = "warmeDrankenButton";
            this.warmeDrankenButton.Size = new System.Drawing.Size(92, 51);
            this.warmeDrankenButton.TabIndex = 23;
            this.warmeDrankenButton.Text = "Warme Dranken";
            this.warmeDrankenButton.TextColor = System.Drawing.Color.White;
            this.warmeDrankenButton.UseVisualStyleBackColor = false;
            this.warmeDrankenButton.Click += new System.EventHandler(this.warmeDrankenButton_Click);
            // 
            // gedestilleerdButton
            // 
            this.gedestilleerdButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.gedestilleerdButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.gedestilleerdButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.gedestilleerdButton.BorderRadius = 5;
            this.gedestilleerdButton.BorderSize = 0;
            this.gedestilleerdButton.FlatAppearance.BorderSize = 0;
            this.gedestilleerdButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gedestilleerdButton.ForeColor = System.Drawing.Color.White;
            this.gedestilleerdButton.Location = new System.Drawing.Point(7, 123);
            this.gedestilleerdButton.Name = "gedestilleerdButton";
            this.gedestilleerdButton.Size = new System.Drawing.Size(86, 40);
            this.gedestilleerdButton.TabIndex = 24;
            this.gedestilleerdButton.Text = "Gedestilleerde Dranken";
            this.gedestilleerdButton.TextColor = System.Drawing.Color.White;
            this.gedestilleerdButton.UseVisualStyleBackColor = false;
            this.gedestilleerdButton.Click += new System.EventHandler(this.gedestilleerdButton_Click);
            // 
            // wijnButton
            // 
            this.wijnButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.wijnButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.wijnButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.wijnButton.BorderRadius = 5;
            this.wijnButton.BorderSize = 0;
            this.wijnButton.FlatAppearance.BorderSize = 0;
            this.wijnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.wijnButton.ForeColor = System.Drawing.Color.White;
            this.wijnButton.Location = new System.Drawing.Point(7, 73);
            this.wijnButton.Name = "wijnButton";
            this.wijnButton.Size = new System.Drawing.Size(86, 44);
            this.wijnButton.TabIndex = 23;
            this.wijnButton.Text = "Wijn";
            this.wijnButton.TextColor = System.Drawing.Color.White;
            this.wijnButton.UseVisualStyleBackColor = false;
            this.wijnButton.Click += new System.EventHandler(this.wijnButton_Click);
            // 
            // bierButton
            // 
            this.bierButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bierButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.bierButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.bierButton.BorderRadius = 5;
            this.bierButton.BorderSize = 0;
            this.bierButton.FlatAppearance.BorderSize = 0;
            this.bierButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bierButton.ForeColor = System.Drawing.Color.White;
            this.bierButton.Location = new System.Drawing.Point(7, 26);
            this.bierButton.Name = "bierButton";
            this.bierButton.Size = new System.Drawing.Size(86, 41);
            this.bierButton.TabIndex = 22;
            this.bierButton.Text = "Bier";
            this.bierButton.TextColor = System.Drawing.Color.White;
            this.bierButton.UseVisualStyleBackColor = false;
            this.bierButton.Click += new System.EventHandler(this.bierButton_Click);
            // 
            // alcoholButton
            // 
            this.alcoholButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.alcoholButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.alcoholButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.alcoholButton.BorderRadius = 5;
            this.alcoholButton.BorderSize = 0;
            this.alcoholButton.FlatAppearance.BorderSize = 0;
            this.alcoholButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alcoholButton.ForeColor = System.Drawing.Color.White;
            this.alcoholButton.Location = new System.Drawing.Point(308, 9);
            this.alcoholButton.Name = "alcoholButton";
            this.alcoholButton.Size = new System.Drawing.Size(99, 40);
            this.alcoholButton.TabIndex = 18;
            this.alcoholButton.Text = "Alcohol";
            this.alcoholButton.TextColor = System.Drawing.Color.White;
            this.alcoholButton.UseVisualStyleBackColor = false;
            this.alcoholButton.Click += new System.EventHandler(this.alcoholButton_Click);
            // 
            // drankenButton
            // 
            this.drankenButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.drankenButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.drankenButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.drankenButton.BorderRadius = 5;
            this.drankenButton.BorderSize = 0;
            this.drankenButton.FlatAppearance.BorderSize = 0;
            this.drankenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drankenButton.ForeColor = System.Drawing.Color.White;
            this.drankenButton.Location = new System.Drawing.Point(211, 9);
            this.drankenButton.Name = "drankenButton";
            this.drankenButton.Size = new System.Drawing.Size(92, 40);
            this.drankenButton.TabIndex = 17;
            this.drankenButton.Text = "Dranken";
            this.drankenButton.TextColor = System.Drawing.Color.White;
            this.drankenButton.UseVisualStyleBackColor = false;
            this.drankenButton.Click += new System.EventHandler(this.drankenButton_Click);
            // 
            // dinerButton
            // 
            this.dinerButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.dinerButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dinerButton.BorderRadius = 5;
            this.dinerButton.BorderSize = 0;
            this.dinerButton.FlatAppearance.BorderSize = 0;
            this.dinerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dinerButton.ForeColor = System.Drawing.Color.White;
            this.dinerButton.Location = new System.Drawing.Point(113, 9);
            this.dinerButton.Name = "dinerButton";
            this.dinerButton.Size = new System.Drawing.Size(92, 40);
            this.dinerButton.TabIndex = 16;
            this.dinerButton.Text = "Diner";
            this.dinerButton.TextColor = System.Drawing.Color.White;
            this.dinerButton.UseVisualStyleBackColor = false;
            this.dinerButton.Click += new System.EventHandler(this.dinerButton_Click);
            // 
            // lunchButton
            // 
            this.lunchButton.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.lunchButton.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.lunchButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.lunchButton.BorderRadius = 5;
            this.lunchButton.BorderSize = 0;
            this.lunchButton.FlatAppearance.BorderSize = 0;
            this.lunchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lunchButton.ForeColor = System.Drawing.Color.White;
            this.lunchButton.Location = new System.Drawing.Point(10, 9);
            this.lunchButton.Name = "lunchButton";
            this.lunchButton.Size = new System.Drawing.Size(92, 40);
            this.lunchButton.TabIndex = 15;
            this.lunchButton.Text = "Lunch";
            this.lunchButton.TextColor = System.Drawing.Color.White;
            this.lunchButton.UseVisualStyleBackColor = false;
            this.lunchButton.Click += new System.EventHandler(this.lunchButton_Click);
            // 
            // backToOverviewButton
            // 
            this.backToOverviewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.backToOverviewButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.backToOverviewButton.BorderColor = System.Drawing.Color.White;
            this.backToOverviewButton.BorderRadius = 20;
            this.backToOverviewButton.BorderSize = 1;
            this.backToOverviewButton.FlatAppearance.BorderSize = 0;
            this.backToOverviewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToOverviewButton.ForeColor = System.Drawing.Color.White;
            this.backToOverviewButton.Location = new System.Drawing.Point(10, 713);
            this.backToOverviewButton.Name = "backToOverviewButton";
            this.backToOverviewButton.Size = new System.Drawing.Size(195, 70);
            this.backToOverviewButton.TabIndex = 12;
            this.backToOverviewButton.Text = "Annuleer bestelling";
            this.backToOverviewButton.TextColor = System.Drawing.Color.White;
            this.backToOverviewButton.UseVisualStyleBackColor = false;
            this.backToOverviewButton.Click += new System.EventHandler(this.backToOverviewButton_Click);
            // 
            // insertOrderButton
            // 
            this.insertOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.insertOrderButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.insertOrderButton.BorderColor = System.Drawing.Color.White;
            this.insertOrderButton.BorderRadius = 20;
            this.insertOrderButton.BorderSize = 1;
            this.insertOrderButton.FlatAppearance.BorderSize = 0;
            this.insertOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertOrderButton.ForeColor = System.Drawing.Color.White;
            this.insertOrderButton.Location = new System.Drawing.Point(226, 713);
            this.insertOrderButton.Name = "insertOrderButton";
            this.insertOrderButton.Size = new System.Drawing.Size(190, 70);
            this.insertOrderButton.TabIndex = 11;
            this.insertOrderButton.Text = "Plaats bestelling";
            this.insertOrderButton.TextColor = System.Drawing.Color.White;
            this.insertOrderButton.UseVisualStyleBackColor = false;
            this.insertOrderButton.Click += new System.EventHandler(this.insertOrderButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.addItemButton.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.addItemButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.addItemButton.BorderRadius = 20;
            this.addItemButton.BorderSize = 0;
            this.addItemButton.FlatAppearance.BorderSize = 0;
            this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addItemButton.ForeColor = System.Drawing.Color.White;
            this.addItemButton.Location = new System.Drawing.Point(304, 392);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(103, 47);
            this.addItemButton.TabIndex = 6;
            this.addItemButton.Text = "Voeg toe";
            this.addItemButton.TextColor = System.Drawing.Color.White;
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // ChangeOrderButton
            // 
            this.ChangeOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.ChangeOrderButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.ChangeOrderButton.BorderColor = System.Drawing.Color.White;
            this.ChangeOrderButton.BorderRadius = 20;
            this.ChangeOrderButton.BorderSize = 1;
            this.ChangeOrderButton.FlatAppearance.BorderSize = 0;
            this.ChangeOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeOrderButton.ForeColor = System.Drawing.Color.White;
            this.ChangeOrderButton.Location = new System.Drawing.Point(223, 621);
            this.ChangeOrderButton.Name = "ChangeOrderButton";
            this.ChangeOrderButton.Size = new System.Drawing.Size(193, 70);
            this.ChangeOrderButton.TabIndex = 18;
            this.ChangeOrderButton.Text = "Wijzig bestelling";
            this.ChangeOrderButton.TextColor = System.Drawing.Color.White;
            this.ChangeOrderButton.UseVisualStyleBackColor = false;
            this.ChangeOrderButton.Click += new System.EventHandler(this.ChangeOrderButton_Click);
            // 
            // orderInPreparationToggle
            // 
            this.orderInPreparationToggle.Location = new System.Drawing.Point(315, 523);
            this.orderInPreparationToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.orderInPreparationToggle.Name = "orderInPreparationToggle";
            this.orderInPreparationToggle.OffBackColor = System.Drawing.Color.Gray;
            this.orderInPreparationToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.orderInPreparationToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.orderInPreparationToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.orderInPreparationToggle.Size = new System.Drawing.Size(101, 23);
            this.orderInPreparationToggle.TabIndex = 15;
            this.orderInPreparationToggle.UseVisualStyleBackColor = true;
            this.orderInPreparationToggle.CheckedChanged += new System.EventHandler(this.orderInPreparationToggle_CheckedChanged);
            // 
            // groupItemsToggle
            // 
            this.groupItemsToggle.Location = new System.Drawing.Point(315, 494);
            this.groupItemsToggle.MinimumSize = new System.Drawing.Size(45, 22);
            this.groupItemsToggle.Name = "groupItemsToggle";
            this.groupItemsToggle.OffBackColor = System.Drawing.Color.Gray;
            this.groupItemsToggle.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.groupItemsToggle.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.groupItemsToggle.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.groupItemsToggle.Size = new System.Drawing.Size(101, 23);
            this.groupItemsToggle.TabIndex = 17;
            this.groupItemsToggle.UseVisualStyleBackColor = true;
            this.groupItemsToggle.CheckedChanged += new System.EventHandler(this.groupItemsToggle_CheckedChanged);
            // 
            // backToTablesButton
            // 
            this.backToTablesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.backToTablesButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.backToTablesButton.BorderColor = System.Drawing.Color.White;
            this.backToTablesButton.BorderRadius = 20;
            this.backToTablesButton.BorderSize = 1;
            this.backToTablesButton.FlatAppearance.BorderSize = 0;
            this.backToTablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToTablesButton.ForeColor = System.Drawing.Color.White;
            this.backToTablesButton.Location = new System.Drawing.Point(13, 697);
            this.backToTablesButton.Name = "backToTablesButton";
            this.backToTablesButton.Size = new System.Drawing.Size(192, 70);
            this.backToTablesButton.TabIndex = 10;
            this.backToTablesButton.Text = "Terug naar tafels";
            this.backToTablesButton.TextColor = System.Drawing.Color.White;
            this.backToTablesButton.UseVisualStyleBackColor = false;
            this.backToTablesButton.Click += new System.EventHandler(this.backToTablesButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.newOrderButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(58)))), ((int)(((byte)(118)))));
            this.newOrderButton.BorderColor = System.Drawing.Color.PaleGreen;
            this.newOrderButton.BorderRadius = 20;
            this.newOrderButton.BorderSize = 3;
            this.newOrderButton.FlatAppearance.BorderSize = 0;
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.ForeColor = System.Drawing.Color.White;
            this.newOrderButton.Location = new System.Drawing.Point(223, 697);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(193, 70);
            this.newOrderButton.TabIndex = 7;
            this.newOrderButton.Text = "Nieuwe bestelling";
            this.newOrderButton.TextColor = System.Drawing.Color.White;
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Overview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(428, 795);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.overViewPanel);
            this.Controls.Add(this.changeOrderPanel);
            this.Controls.Add(this.addOrderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Overview";
            this.Text = "Overview";
            this.overViewPanel.ResumeLayout(false);
            this.overViewPanel.PerformLayout();
            this.addOrderPanel.ResumeLayout(false);
            this.lunchSubPanel.ResumeLayout(false);
            this.lunchSubPanel.PerformLayout();
            this.commentAndAmountPanel.ResumeLayout(false);
            this.commentAndAmountPanel.PerformLayout();
            this.dinerSubPanel.ResumeLayout(false);
            this.dinerSubPanel.PerformLayout();
            this.drankenSubPanel.ResumeLayout(false);
            this.drankenSubPanel.PerformLayout();
            this.alchoholSubPanel.ResumeLayout(false);
            this.alchoholSubPanel.PerformLayout();
            this.changeOrderPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView billOverViewListView;
        private System.Windows.Forms.ColumnHeader MenuItem;
        private System.Windows.Forms.ColumnHeader Amount;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.Label bonOverzichtLabel;
        private CustomControls.CustomButton newOrderButton;
        private CustomControls.CustomButton backToTablesButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private CustomControls.ToggleButton orderInPreparationToggle;
        private System.Windows.Forms.Label label4;
        private CustomControls.ToggleButton groupItemsToggle;
        private System.Windows.Forms.Panel overViewPanel;
        private System.Windows.Forms.Panel addOrderPanel;
        private System.Windows.Forms.Panel commentAndAmountPanel;
        private System.Windows.Forms.Label label5;
        private CustomControls.CustomButton minusButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox addCommentTextBox;
        private CustomControls.CustomButton plusButton;
        private CustomControls.CustomButton changeItemButton;
        private CustomControls.CustomButton clearOrderButton;
        private CustomControls.CustomButton deleteItemFromOrderButton;
        private System.Windows.Forms.Panel dinerSubPanel;
        private CustomControls.CustomButton dinerDesertButton;
        private CustomControls.CustomButton dinerMainButton;
        private CustomControls.CustomButton dinerSideButton;
        private CustomControls.CustomButton dinerStarterButton;
        private System.Windows.Forms.Label dinerSubLabel;
        private System.Windows.Forms.Panel lunchSubPanel;
        private CustomControls.CustomButton lunchMainButton;
        private CustomControls.CustomButton lunchDesertButton;
        private CustomControls.CustomButton lunchStarterButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel drankenSubPanel;
        private CustomControls.CustomButton frisdrankButton;
        private CustomControls.CustomButton warmeDrankenButton;
        private System.Windows.Forms.Label drankenSubLabel;
        private System.Windows.Forms.Panel alchoholSubPanel;
        private CustomControls.CustomButton gedestilleerdButton;
        private CustomControls.CustomButton wijnButton;
        private CustomControls.CustomButton bierButton;
        private System.Windows.Forms.Label label7;
        private CustomControls.CustomButton alcoholButton;
        private CustomControls.CustomButton drankenButton;
        private CustomControls.CustomButton dinerButton;
        private CustomControls.CustomButton lunchButton;
        private System.Windows.Forms.ListView menuItemsListView;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader Item;
        private CustomControls.CustomButton backToOverviewButton;
        private System.Windows.Forms.ListView newOrderItemsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private CustomControls.CustomButton insertOrderButton;
        private CustomControls.CustomButton addItemButton;
        private CustomControls.CustomButton ChangeOrderButton;
        private System.Windows.Forms.Panel changeOrderPanel;
        private System.Windows.Forms.ListView changeOrderListView;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private CustomControls.CustomButton changeOrderButton2;
    }
}
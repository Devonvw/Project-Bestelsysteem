namespace View.Forms.Order_Screens
{
    partial class AddOrder
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
            this.menuItemsListView = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Item = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.newOrderItemsListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addItemButton = new View.CustomControls.CustomButton();
            this.backToOverviewButton = new View.CustomControls.CustomButton();
            this.insertOrderButton = new View.CustomControls.CustomButton();
            this.addOrderPanel = new System.Windows.Forms.Panel();
            this.commentAndAmountPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.minusButton = new View.CustomControls.CustomButton();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addCommentTextBox = new System.Windows.Forms.TextBox();
            this.plusButton = new View.CustomControls.CustomButton();
            this.changeItemButton = new View.CustomControls.CustomButton();
            this.clearOrderButton = new View.CustomControls.CustomButton();
            this.deleteItemOrderButton = new View.CustomControls.CustomButton();
            this.dinerSubPanel = new System.Windows.Forms.Panel();
            this.dinerDesertButton = new View.CustomControls.CustomButton();
            this.dinerMainButton = new View.CustomControls.CustomButton();
            this.dinerSideButton = new View.CustomControls.CustomButton();
            this.dinerStarterButton = new View.CustomControls.CustomButton();
            this.dinerSubLabel = new System.Windows.Forms.Label();
            this.lunchSubPanel = new System.Windows.Forms.Panel();
            this.lunchMainButton = new View.CustomControls.CustomButton();
            this.lunchDesertButton = new View.CustomControls.CustomButton();
            this.lunchStarterButton = new View.CustomControls.CustomButton();
            this.label4 = new System.Windows.Forms.Label();
            this.drankenSubPanel = new System.Windows.Forms.Panel();
            this.frisdrankButton = new View.CustomControls.CustomButton();
            this.warmeDrankenButton = new View.CustomControls.CustomButton();
            this.drankenSubLabel = new System.Windows.Forms.Label();
            this.alchoholSubPanel = new System.Windows.Forms.Panel();
            this.gedestilleerdButton = new View.CustomControls.CustomButton();
            this.wijnButton = new View.CustomControls.CustomButton();
            this.bierButton = new View.CustomControls.CustomButton();
            this.label3 = new System.Windows.Forms.Label();
            this.alcoholButton = new View.CustomControls.CustomButton();
            this.drankenButton = new View.CustomControls.CustomButton();
            this.dinerButton = new View.CustomControls.CustomButton();
            this.lunchButton = new View.CustomControls.CustomButton();
            this.addOrderPanel.SuspendLayout();
            this.commentAndAmountPanel.SuspendLayout();
            this.dinerSubPanel.SuspendLayout();
            this.lunchSubPanel.SuspendLayout();
            this.drankenSubPanel.SuspendLayout();
            this.alchoholSubPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.menuItemsListView.Location = new System.Drawing.Point(21, 71);
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
            this.newOrderItemsListView.FullRowSelect = true;
            this.newOrderItemsListView.GridLines = true;
            this.newOrderItemsListView.HideSelection = false;
            this.newOrderItemsListView.Location = new System.Drawing.Point(21, 469);
            this.newOrderItemsListView.Name = "newOrderItemsListView";
            this.newOrderItemsListView.Size = new System.Drawing.Size(397, 124);
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
            this.addItemButton.Location = new System.Drawing.Point(315, 408);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(103, 47);
            this.addItemButton.TabIndex = 6;
            this.addItemButton.Text = "Voeg toe";
            this.addItemButton.TextColor = System.Drawing.Color.White;
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
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
            this.backToOverviewButton.Location = new System.Drawing.Point(21, 713);
            this.backToOverviewButton.Name = "backToOverviewButton";
            this.backToOverviewButton.Size = new System.Drawing.Size(184, 70);
            this.backToOverviewButton.TabIndex = 12;
            this.backToOverviewButton.Text = "Terug naar bon overzicht";
            this.backToOverviewButton.TextColor = System.Drawing.Color.White;
            this.backToOverviewButton.UseVisualStyleBackColor = false;
            this.backToOverviewButton.Click += new System.EventHandler(this.backButton_Click);
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
            this.insertOrderButton.Size = new System.Drawing.Size(183, 70);
            this.insertOrderButton.TabIndex = 11;
            this.insertOrderButton.Text = "Plaats bestelling";
            this.insertOrderButton.TextColor = System.Drawing.Color.White;
            this.insertOrderButton.UseVisualStyleBackColor = false;
            this.insertOrderButton.Click += new System.EventHandler(this.insertOrderButton_Click);
            // 
            // addOrderPanel
            // 
            this.addOrderPanel.Controls.Add(this.commentAndAmountPanel);
            this.addOrderPanel.Controls.Add(this.changeItemButton);
            this.addOrderPanel.Controls.Add(this.clearOrderButton);
            this.addOrderPanel.Controls.Add(this.deleteItemOrderButton);
            this.addOrderPanel.Controls.Add(this.dinerSubPanel);
            this.addOrderPanel.Controls.Add(this.lunchSubPanel);
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
            this.addOrderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addOrderPanel.Location = new System.Drawing.Point(0, 0);
            this.addOrderPanel.Name = "addOrderPanel";
            this.addOrderPanel.Size = new System.Drawing.Size(428, 795);
            this.addOrderPanel.TabIndex = 13;
            // 
            // commentAndAmountPanel
            // 
            this.commentAndAmountPanel.Controls.Add(this.label1);
            this.commentAndAmountPanel.Controls.Add(this.minusButton);
            this.commentAndAmountPanel.Controls.Add(this.amountLabel);
            this.commentAndAmountPanel.Controls.Add(this.addCommentTextBox);
            this.commentAndAmountPanel.Controls.Add(this.plusButton);
            this.commentAndAmountPanel.Location = new System.Drawing.Point(12, 403);
            this.commentAndAmountPanel.Name = "commentAndAmountPanel";
            this.commentAndAmountPanel.Size = new System.Drawing.Size(288, 52);
            this.commentAndAmountPanel.TabIndex = 28;
            this.commentAndAmountPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Opmerking:";
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
            this.minusButton.Location = new System.Drawing.Point(191, 9);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(44, 37);
            this.minusButton.TabIndex = 16;
            this.minusButton.Text = "-";
            this.minusButton.TextColor = System.Drawing.Color.Black;
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.minusButton_Click);
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.amountLabel.Location = new System.Drawing.Point(159, 9);
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
            this.changeItemButton.Location = new System.Drawing.Point(315, 599);
            this.changeItemButton.Name = "changeItemButton";
            this.changeItemButton.Size = new System.Drawing.Size(103, 50);
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
            this.clearOrderButton.Location = new System.Drawing.Point(21, 599);
            this.clearOrderButton.Name = "clearOrderButton";
            this.clearOrderButton.Size = new System.Drawing.Size(109, 37);
            this.clearOrderButton.TabIndex = 26;
            this.clearOrderButton.Text = "Leeg Order";
            this.clearOrderButton.TextColor = System.Drawing.Color.Black;
            this.clearOrderButton.UseVisualStyleBackColor = false;
            this.clearOrderButton.Visible = false;
            this.clearOrderButton.Click += new System.EventHandler(this.clearOrderButton_Click);
            // 
            // deleteItemOrderButton
            // 
            this.deleteItemOrderButton.BackColor = System.Drawing.Color.BurlyWood;
            this.deleteItemOrderButton.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.deleteItemOrderButton.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.deleteItemOrderButton.BorderRadius = 20;
            this.deleteItemOrderButton.BorderSize = 0;
            this.deleteItemOrderButton.Enabled = false;
            this.deleteItemOrderButton.FlatAppearance.BorderSize = 0;
            this.deleteItemOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteItemOrderButton.ForeColor = System.Drawing.Color.Black;
            this.deleteItemOrderButton.Location = new System.Drawing.Point(135, 599);
            this.deleteItemOrderButton.Name = "deleteItemOrderButton";
            this.deleteItemOrderButton.Size = new System.Drawing.Size(109, 37);
            this.deleteItemOrderButton.TabIndex = 25;
            this.deleteItemOrderButton.Text = "Verwijder Item";
            this.deleteItemOrderButton.TextColor = System.Drawing.Color.Black;
            this.deleteItemOrderButton.UseVisualStyleBackColor = false;
            this.deleteItemOrderButton.Visible = false;
            this.deleteItemOrderButton.Click += new System.EventHandler(this.deleteItemOrderButton_Click);
            // 
            // dinerSubPanel
            // 
            this.dinerSubPanel.Controls.Add(this.dinerDesertButton);
            this.dinerSubPanel.Controls.Add(this.dinerMainButton);
            this.dinerSubPanel.Controls.Add(this.dinerSideButton);
            this.dinerSubPanel.Controls.Add(this.dinerStarterButton);
            this.dinerSubPanel.Controls.Add(this.dinerSubLabel);
            this.dinerSubPanel.Location = new System.Drawing.Point(316, 71);
            this.dinerSubPanel.Name = "dinerSubPanel";
            this.dinerSubPanel.Size = new System.Drawing.Size(102, 326);
            this.dinerSubPanel.TabIndex = 24;
            this.dinerSubPanel.Visible = false;
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
            this.dinerDesertButton.Click += new System.EventHandler(this.dinerDesertButton_Click);
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
            // lunchSubPanel
            // 
            this.lunchSubPanel.Controls.Add(this.lunchMainButton);
            this.lunchSubPanel.Controls.Add(this.lunchDesertButton);
            this.lunchSubPanel.Controls.Add(this.lunchStarterButton);
            this.lunchSubPanel.Controls.Add(this.label4);
            this.lunchSubPanel.Location = new System.Drawing.Point(316, 71);
            this.lunchSubPanel.Name = "lunchSubPanel";
            this.lunchSubPanel.Size = new System.Drawing.Size(102, 326);
            this.lunchSubPanel.TabIndex = 23;
            this.lunchSubPanel.Visible = false;
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(29, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lunch";
            // 
            // drankenSubPanel
            // 
            this.drankenSubPanel.Controls.Add(this.frisdrankButton);
            this.drankenSubPanel.Controls.Add(this.warmeDrankenButton);
            this.drankenSubPanel.Controls.Add(this.drankenSubLabel);
            this.drankenSubPanel.Location = new System.Drawing.Point(316, 71);
            this.drankenSubPanel.Name = "drankenSubPanel";
            this.drankenSubPanel.Size = new System.Drawing.Size(102, 326);
            this.drankenSubPanel.TabIndex = 22;
            this.drankenSubPanel.Visible = false;
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
            this.alchoholSubPanel.Controls.Add(this.label3);
            this.alchoholSubPanel.Location = new System.Drawing.Point(316, 71);
            this.alchoholSubPanel.Name = "alchoholSubPanel";
            this.alchoholSubPanel.Size = new System.Drawing.Size(102, 326);
            this.alchoholSubPanel.TabIndex = 21;
            this.alchoholSubPanel.Visible = false;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(29, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Alcohol:";
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
            this.alcoholButton.Location = new System.Drawing.Point(317, 25);
            this.alcoholButton.Name = "alcoholButton";
            this.alcoholButton.Size = new System.Drawing.Size(92, 40);
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
            this.drankenButton.Location = new System.Drawing.Point(217, 25);
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
            this.dinerButton.Location = new System.Drawing.Point(119, 25);
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
            this.lunchButton.Location = new System.Drawing.Point(21, 25);
            this.lunchButton.Name = "lunchButton";
            this.lunchButton.Size = new System.Drawing.Size(92, 40);
            this.lunchButton.TabIndex = 15;
            this.lunchButton.Text = "Lunch";
            this.lunchButton.TextColor = System.Drawing.Color.White;
            this.lunchButton.UseVisualStyleBackColor = false;
            this.lunchButton.Click += new System.EventHandler(this.lunchButton_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(0)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(428, 795);
            this.Controls.Add(this.addOrderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddOrder";
            this.Text = "AddOrderScreen";
            this.addOrderPanel.ResumeLayout(false);
            this.commentAndAmountPanel.ResumeLayout(false);
            this.commentAndAmountPanel.PerformLayout();
            this.dinerSubPanel.ResumeLayout(false);
            this.dinerSubPanel.PerformLayout();
            this.lunchSubPanel.ResumeLayout(false);
            this.lunchSubPanel.PerformLayout();
            this.drankenSubPanel.ResumeLayout(false);
            this.drankenSubPanel.PerformLayout();
            this.alchoholSubPanel.ResumeLayout(false);
            this.alchoholSubPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView menuItemsListView;
        private System.Windows.Forms.ColumnHeader Item;
        private System.Windows.Forms.ListView newOrderItemsListView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader ID;
        private CustomControls.CustomButton addItemButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private CustomControls.CustomButton backToOverviewButton;
        private CustomControls.CustomButton insertOrderButton;
        private System.Windows.Forms.Panel addOrderPanel;
        private CustomControls.CustomButton alcoholButton;
        private CustomControls.CustomButton drankenButton;
        private CustomControls.CustomButton dinerButton;
        private CustomControls.CustomButton lunchButton;
        private System.Windows.Forms.Panel alchoholSubPanel;
        private CustomControls.CustomButton gedestilleerdButton;
        private CustomControls.CustomButton wijnButton;
        private CustomControls.CustomButton bierButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel drankenSubPanel;
        private CustomControls.CustomButton frisdrankButton;
        private CustomControls.CustomButton warmeDrankenButton;
        private System.Windows.Forms.Label drankenSubLabel;
        private System.Windows.Forms.Panel lunchSubPanel;
        private CustomControls.CustomButton lunchMainButton;
        private CustomControls.CustomButton lunchDesertButton;
        private CustomControls.CustomButton lunchStarterButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel dinerSubPanel;
        private CustomControls.CustomButton dinerDesertButton;
        private CustomControls.CustomButton dinerMainButton;
        private CustomControls.CustomButton dinerSideButton;
        private CustomControls.CustomButton dinerStarterButton;
        private System.Windows.Forms.Label dinerSubLabel;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private CustomControls.CustomButton clearOrderButton;
        private CustomControls.CustomButton deleteItemOrderButton;
        private CustomControls.CustomButton changeItemButton;
        private System.Windows.Forms.Panel commentAndAmountPanel;
        private System.Windows.Forms.Label label1;
        private CustomControls.CustomButton minusButton;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.TextBox addCommentTextBox;
        private CustomControls.CustomButton plusButton;
    }
}
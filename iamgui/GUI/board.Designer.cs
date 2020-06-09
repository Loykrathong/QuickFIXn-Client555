namespace GUI
{
    partial class board
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
            this.SymbolTextbox = new System.Windows.Forms.RichTextBox();
            this.PendingBox = new System.Windows.Forms.GroupBox();
            this.checkCustomer1 = new System.Windows.Forms.CheckBox();
            this.AskButton = new System.Windows.Forms.Button();
            this.BidButton = new System.Windows.Forms.Button();
            this.IDPending = new System.Windows.Forms.RichTextBox();
            this.QtyPending = new System.Windows.Forms.RichTextBox();
            this.PendingPrice = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkCustomer2 = new System.Windows.Forms.CheckBox();
            this.SellMarket = new System.Windows.Forms.Button();
            this.BuyMarket = new System.Windows.Forms.Button();
            this.QtyMarket = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RequestrichTextBox = new System.Windows.Forms.RichTextBox();
            this.RequestTest = new System.Windows.Forms.Button();
            this.listViewAsk = new System.Windows.Forms.ListView();
            this.AskPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AskQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBid = new System.Windows.Forms.ListView();
            this.BidQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BidPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SymbolListBox1 = new System.Windows.Forms.ListBox();
            this.labelDisplaying = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelSymbol = new System.Windows.Forms.Label();
            this.PendingBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SymbolTextbox
            // 
            this.SymbolTextbox.Location = new System.Drawing.Point(70, 232);
            this.SymbolTextbox.Name = "SymbolTextbox";
            this.SymbolTextbox.Size = new System.Drawing.Size(76, 22);
            this.SymbolTextbox.TabIndex = 1;
            this.SymbolTextbox.Text = "";
            this.SymbolTextbox.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged_1);
            // 
            // PendingBox
            // 
            this.PendingBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.PendingBox.Controls.Add(this.checkCustomer1);
            this.PendingBox.Controls.Add(this.AskButton);
            this.PendingBox.Controls.Add(this.BidButton);
            this.PendingBox.Controls.Add(this.IDPending);
            this.PendingBox.Controls.Add(this.QtyPending);
            this.PendingBox.Controls.Add(this.PendingPrice);
            this.PendingBox.Controls.Add(this.label6);
            this.PendingBox.Controls.Add(this.label5);
            this.PendingBox.Controls.Add(this.label2);
            this.PendingBox.Location = new System.Drawing.Point(9, 266);
            this.PendingBox.Name = "PendingBox";
            this.PendingBox.Size = new System.Drawing.Size(779, 88);
            this.PendingBox.TabIndex = 14;
            this.PendingBox.TabStop = false;
            this.PendingBox.Text = "Pending :";
            // 
            // checkCustomer1
            // 
            this.checkCustomer1.AutoSize = true;
            this.checkCustomer1.Location = new System.Drawing.Point(193, 62);
            this.checkCustomer1.Name = "checkCustomer1";
            this.checkCustomer1.Size = new System.Drawing.Size(70, 17);
            this.checkCustomer1.TabIndex = 7;
            this.checkCustomer1.Text = "Customer";
            this.checkCustomer1.UseVisualStyleBackColor = true;
            this.checkCustomer1.CheckedChanged += new System.EventHandler(this.checkCustomer1_CheckedChanged);
            // 
            // AskButton
            // 
            this.AskButton.Location = new System.Drawing.Point(462, 33);
            this.AskButton.Name = "AskButton";
            this.AskButton.Size = new System.Drawing.Size(75, 23);
            this.AskButton.TabIndex = 6;
            this.AskButton.Text = "Ask";
            this.AskButton.UseVisualStyleBackColor = true;
            this.AskButton.Click += new System.EventHandler(this.AskButton_Click);
            // 
            // BidButton
            // 
            this.BidButton.Location = new System.Drawing.Point(297, 33);
            this.BidButton.Name = "BidButton";
            this.BidButton.Size = new System.Drawing.Size(75, 23);
            this.BidButton.TabIndex = 5;
            this.BidButton.Text = "Bid";
            this.BidButton.UseVisualStyleBackColor = true;
            this.BidButton.Click += new System.EventHandler(this.BidButton_Click);
            // 
            // IDPending
            // 
            this.IDPending.Location = new System.Drawing.Point(97, 60);
            this.IDPending.Name = "IDPending";
            this.IDPending.Size = new System.Drawing.Size(76, 22);
            this.IDPending.TabIndex = 4;
            this.IDPending.Text = "";
            // 
            // QtyPending
            // 
            this.QtyPending.Location = new System.Drawing.Point(97, 35);
            this.QtyPending.Name = "QtyPending";
            this.QtyPending.Size = new System.Drawing.Size(76, 22);
            this.QtyPending.TabIndex = 3;
            this.QtyPending.Text = "";
            // 
            // PendingPrice
            // 
            this.PendingPrice.Location = new System.Drawing.Point(97, 10);
            this.PendingPrice.Name = "PendingPrice";
            this.PendingPrice.Size = new System.Drawing.Size(76, 22);
            this.PendingPrice.TabIndex = 2;
            this.PendingPrice.Text = "";
            this.PendingPrice.TextChanged += new System.EventHandler(this.PendingPrice_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "ID :";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Quantity :";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Price :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox1.Controls.Add(this.checkCustomer2);
            this.groupBox1.Controls.Add(this.SellMarket);
            this.groupBox1.Controls.Add(this.BuyMarket);
            this.groupBox1.Controls.Add(this.QtyMarket);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(9, 360);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 88);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Market :";
            // 
            // checkCustomer2
            // 
            this.checkCustomer2.AutoSize = true;
            this.checkCustomer2.Location = new System.Drawing.Point(193, 42);
            this.checkCustomer2.Name = "checkCustomer2";
            this.checkCustomer2.Size = new System.Drawing.Size(70, 17);
            this.checkCustomer2.TabIndex = 12;
            this.checkCustomer2.Text = "Customer";
            this.checkCustomer2.UseVisualStyleBackColor = true;
            this.checkCustomer2.CheckedChanged += new System.EventHandler(this.checkCustomer2_CheckedChanged);
            // 
            // SellMarket
            // 
            this.SellMarket.Location = new System.Drawing.Point(462, 37);
            this.SellMarket.Name = "SellMarket";
            this.SellMarket.Size = new System.Drawing.Size(75, 23);
            this.SellMarket.TabIndex = 11;
            this.SellMarket.Text = "Sell";
            this.SellMarket.UseVisualStyleBackColor = true;
            this.SellMarket.Click += new System.EventHandler(this.SellMarket_Click);
            // 
            // BuyMarket
            // 
            this.BuyMarket.Location = new System.Drawing.Point(297, 37);
            this.BuyMarket.Name = "BuyMarket";
            this.BuyMarket.Size = new System.Drawing.Size(75, 23);
            this.BuyMarket.TabIndex = 10;
            this.BuyMarket.Text = "Buy";
            this.BuyMarket.UseVisualStyleBackColor = true;
            this.BuyMarket.Click += new System.EventHandler(this.BuyMarket_Click);
            // 
            // QtyMarket
            // 
            this.QtyMarket.Location = new System.Drawing.Point(97, 39);
            this.QtyMarket.Name = "QtyMarket";
            this.QtyMarket.Size = new System.Drawing.Size(76, 22);
            this.QtyMarket.TabIndex = 8;
            this.QtyMarket.Text = "";
            this.QtyMarket.TextChanged += new System.EventHandler(this.QtyMarket_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Quantity :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Symbol :";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.labelSymbol);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelDisplaying);
            this.groupBox2.Controls.Add(this.RequestrichTextBox);
            this.groupBox2.Controls.Add(this.RequestTest);
            this.groupBox2.Controls.Add(this.listViewAsk);
            this.groupBox2.Controls.Add(this.listViewBid);
            this.groupBox2.Location = new System.Drawing.Point(152, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 254);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display :";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // RequestrichTextBox
            // 
            this.RequestrichTextBox.Location = new System.Drawing.Point(35, 169);
            this.RequestrichTextBox.Name = "RequestrichTextBox";
            this.RequestrichTextBox.Size = new System.Drawing.Size(114, 26);
            this.RequestrichTextBox.TabIndex = 7;
            this.RequestrichTextBox.Text = "";
            // 
            // RequestTest
            // 
            this.RequestTest.Location = new System.Drawing.Point(50, 201);
            this.RequestTest.Name = "RequestTest";
            this.RequestTest.Size = new System.Drawing.Size(81, 23);
            this.RequestTest.TabIndex = 6;
            this.RequestTest.Text = "RequestTest";
            this.RequestTest.UseVisualStyleBackColor = true;
            this.RequestTest.Click += new System.EventHandler(this.RequestTest_Click);
            // 
            // listViewAsk
            // 
            this.listViewAsk.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AskPrice,
            this.AskQty});
            this.listViewAsk.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewAsk.HideSelection = false;
            this.listViewAsk.Location = new System.Drawing.Point(381, 19);
            this.listViewAsk.Name = "listViewAsk";
            this.listViewAsk.Size = new System.Drawing.Size(200, 215);
            this.listViewAsk.TabIndex = 1;
            this.listViewAsk.UseCompatibleStateImageBehavior = false;
            this.listViewAsk.View = System.Windows.Forms.View.Details;
            // 
            // AskPrice
            // 
            this.AskPrice.Text = "AskPrice";
            this.AskPrice.Width = 95;
            // 
            // AskQty
            // 
            this.AskQty.Text = "AskQty";
            this.AskQty.Width = 95;
            // 
            // listViewBid
            // 
            this.listViewBid.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listViewBid.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.BidQty,
            this.BidPrice});
            this.listViewBid.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewBid.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewBid.HideSelection = false;
            this.listViewBid.Location = new System.Drawing.Point(175, 19);
            this.listViewBid.Name = "listViewBid";
            this.listViewBid.Size = new System.Drawing.Size(200, 215);
            this.listViewBid.TabIndex = 0;
            this.listViewBid.UseCompatibleStateImageBehavior = false;
            this.listViewBid.View = System.Windows.Forms.View.Details;
            this.listViewBid.SelectedIndexChanged += new System.EventHandler(this.listViewBid_SelectedIndexChanged);
            this.listViewBid.DoubleClick += new System.EventHandler(this.listViewBid_DoubleClick);
            // 
            // BidQty
            // 
            this.BidQty.Text = "BidQty";
            this.BidQty.Width = 95;
            // 
            // BidPrice
            // 
            this.BidPrice.Text = "BidPrice";
            this.BidPrice.Width = 95;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Display";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Symbols :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // SymbolListBox1
            // 
            this.SymbolListBox1.FormattingEnabled = true;
            this.SymbolListBox1.Location = new System.Drawing.Point(15, 34);
            this.SymbolListBox1.Name = "SymbolListBox1";
            this.SymbolListBox1.Size = new System.Drawing.Size(120, 95);
            this.SymbolListBox1.Sorted = true;
            this.SymbolListBox1.TabIndex = 31;
            this.SymbolListBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // labelDisplaying
            // 
            this.labelDisplaying.AutoSize = true;
            this.labelDisplaying.Location = new System.Drawing.Point(47, 53);
            this.labelDisplaying.Name = "labelDisplaying";
            this.labelDisplaying.Size = new System.Drawing.Size(96, 13);
            this.labelDisplaying.TabIndex = 8;
            this.labelDisplaying.Text = "Displaying symbol :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // labelSymbol
            // 
            this.labelSymbol.AutoSize = true;
            this.labelSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.labelSymbol.Location = new System.Drawing.Point(62, 73);
            this.labelSymbol.Name = "labelSymbol";
            this.labelSymbol.Size = new System.Drawing.Size(66, 25);
            this.labelSymbol.TabIndex = 10;
            this.labelSymbol.Text = "\"........\"";
            // 
            // board
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SymbolListBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SymbolTextbox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PendingBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "board";
            this.Text = "Order";
            this.Load += new System.EventHandler(this.board_Load);
            this.PendingBox.ResumeLayout(false);
            this.PendingBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox PendingBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox IDPending;
        private System.Windows.Forms.RichTextBox QtyPending;
        private System.Windows.Forms.RichTextBox PendingPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox QtyMarket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button SellMarket;
        private System.Windows.Forms.Button BuyMarket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox SymbolTextbox;
        private System.Windows.Forms.Button AskButton;
        private System.Windows.Forms.Button BidButton;
        private System.Windows.Forms.CheckBox checkCustomer1;
        private System.Windows.Forms.CheckBox checkCustomer2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewAsk;
        private System.Windows.Forms.ColumnHeader AskPrice;
        private System.Windows.Forms.ColumnHeader AskQty;
        private System.Windows.Forms.ListView listViewBid;
        private System.Windows.Forms.ColumnHeader BidQty;
        private System.Windows.Forms.ColumnHeader BidPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox SymbolListBox1;
        private System.Windows.Forms.Button RequestTest;
        private System.Windows.Forms.RichTextBox RequestrichTextBox;
        private System.Windows.Forms.Label labelDisplaying;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelSymbol;
    }
}
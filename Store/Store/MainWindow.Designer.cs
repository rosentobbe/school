namespace Store
{
    partial class MainWindow
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        #region
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.registerTab = new System.Windows.Forms.TabPage();
            this.sub_registerTab = new System.Windows.Forms.TabControl();
            this.sell_tab = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.register_amount_number = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.add_selected_to_cart = new System.Windows.Forms.Button();
            this.register_remItem_button = new System.Windows.Forms.Button();
            this.clear_cart_button = new System.Windows.Forms.Button();
            this.pay_button = new System.Windows.Forms.Button();
            this.cartList = new System.Windows.Forms.ListBox();
            this.cartLabel = new System.Windows.Forms.Label();
            this.sumLabel = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.return_tab = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.return_Product_name_box = new System.Windows.Forms.TextBox();
            this.return_button = new System.Windows.Forms.Button();
            this.return_balance = new System.Windows.Forms.NumericUpDown();
            this.id_dropdown_box = new System.Windows.Forms.ComboBox();
            this.storageTab = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.addTab = new System.Windows.Forms.TabPage();
            this.add_product_button = new System.Windows.Forms.Button();
            this.number_Balance = new System.Windows.Forms.NumericUpDown();
            this.number_Price = new System.Windows.Forms.NumericUpDown();
            this.label_Balance = new System.Windows.Forms.Label();
            this.label_Price = new System.Windows.Forms.Label();
            this.textbox_ID = new System.Windows.Forms.TextBox();
            this.label_ID = new System.Windows.Forms.Label();
            this.storage_productName_texbox = new System.Windows.Forms.TextBox();
            this.label_Name = new System.Windows.Forms.Label();
            this.removeTab = new System.Windows.Forms.TabPage();
            this.remove_balance_textbox = new System.Windows.Forms.TextBox();
            this.remove_price_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.remove_id_textbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.remove_name_textbox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.selected_product_label = new System.Windows.Forms.Label();
            this.remove_product_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.remove_product_label = new System.Windows.Forms.Label();
            this.restockTab = new System.Windows.Forms.TabPage();
            this.place_order_button = new System.Windows.Forms.Button();
            this.order_amount_numeric = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.order_balance_textbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.order_id_textbox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.order_product_textbox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.storage_ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search_label = new System.Windows.Forms.Label();
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.search_button = new System.Windows.Forms.Button();
            this.clear_search_button = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.registerTab.SuspendLayout();
            this.sub_registerTab.SuspendLayout();
            this.sell_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_amount_number)).BeginInit();
            this.return_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.return_balance)).BeginInit();
            this.storageTab.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.addTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_Balance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Price)).BeginInit();
            this.removeTab.SuspendLayout();
            this.restockTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_amount_numeric)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.registerTab);
            this.tabControl1.Controls.Add(this.storageTab);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(617, 756);
            this.tabControl1.TabIndex = 0;
            // 
            // registerTab
            // 
            this.registerTab.BackColor = System.Drawing.Color.Transparent;
            this.registerTab.Controls.Add(this.sub_registerTab);
            this.registerTab.Location = new System.Drawing.Point(4, 22);
            this.registerTab.Name = "registerTab";
            this.registerTab.Padding = new System.Windows.Forms.Padding(3);
            this.registerTab.Size = new System.Drawing.Size(609, 730);
            this.registerTab.TabIndex = 0;
            this.registerTab.Text = "Register";
            // 
            // sub_registerTab
            // 
            this.sub_registerTab.Controls.Add(this.sell_tab);
            this.sub_registerTab.Controls.Add(this.return_tab);
            this.sub_registerTab.Location = new System.Drawing.Point(0, 6);
            this.sub_registerTab.Name = "sub_registerTab";
            this.sub_registerTab.SelectedIndex = 0;
            this.sub_registerTab.Size = new System.Drawing.Size(609, 724);
            this.sub_registerTab.TabIndex = 0;
            this.sub_registerTab.SelectedIndexChanged += new System.EventHandler(this.sub_registerTab_SelectedIndexChanged);
            // 
            // sell_tab
            // 
            this.sell_tab.BackColor = System.Drawing.Color.Transparent;
            this.sell_tab.Controls.Add(this.label19);
            this.sell_tab.Controls.Add(this.register_amount_number);
            this.sell_tab.Controls.Add(this.label20);
            this.sell_tab.Controls.Add(this.label21);
            this.sell_tab.Controls.Add(this.label18);
            this.sell_tab.Controls.Add(this.label22);
            this.sell_tab.Controls.Add(this.add_selected_to_cart);
            this.sell_tab.Controls.Add(this.register_remItem_button);
            this.sell_tab.Controls.Add(this.clear_cart_button);
            this.sell_tab.Controls.Add(this.pay_button);
            this.sell_tab.Controls.Add(this.cartList);
            this.sell_tab.Controls.Add(this.cartLabel);
            this.sell_tab.Controls.Add(this.sumLabel);
            this.sell_tab.Controls.Add(this.totalPriceLabel);
            this.sell_tab.Location = new System.Drawing.Point(4, 22);
            this.sell_tab.Name = "sell_tab";
            this.sell_tab.Padding = new System.Windows.Forms.Padding(3);
            this.sell_tab.Size = new System.Drawing.Size(601, 698);
            this.sell_tab.TabIndex = 0;
            this.sell_tab.Text = "Sell";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label19.Location = new System.Drawing.Point(440, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 20);
            this.label19.TabIndex = 22;
            this.label19.Text = "Balance";
            // 
            // register_amount_number
            // 
            this.register_amount_number.Location = new System.Drawing.Point(514, 257);
            this.register_amount_number.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.register_amount_number.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.register_amount_number.Name = "register_amount_number";
            this.register_amount_number.Size = new System.Drawing.Size(74, 20);
            this.register_amount_number.TabIndex = 26;
            this.register_amount_number.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label20.Location = new System.Drawing.Point(327, 31);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(44, 20);
            this.label20.TabIndex = 20;
            this.label20.Text = "Price";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label21.Location = new System.Drawing.Point(65, 31);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 20);
            this.label21.TabIndex = 18;
            this.label21.Text = "Name";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label18.Location = new System.Drawing.Point(519, 228);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(60, 17);
            this.label18.TabIndex = 25;
            this.label18.Text = "Amount:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label22.Location = new System.Drawing.Point(11, 31);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(26, 20);
            this.label22.TabIndex = 16;
            this.label22.Text = "ID";
            // 
            // add_selected_to_cart
            // 
            this.add_selected_to_cart.Location = new System.Drawing.Point(513, 292);
            this.add_selected_to_cart.Name = "add_selected_to_cart";
            this.add_selected_to_cart.Size = new System.Drawing.Size(75, 80);
            this.add_selected_to_cart.TabIndex = 24;
            this.add_selected_to_cart.Text = "Add Selected Item To Cart";
            this.add_selected_to_cart.UseVisualStyleBackColor = true;
            this.add_selected_to_cart.Click += new System.EventHandler(this.addToCart_Click);
            // 
            // register_remItem_button
            // 
            this.register_remItem_button.Location = new System.Drawing.Point(513, 57);
            this.register_remItem_button.Name = "register_remItem_button";
            this.register_remItem_button.Size = new System.Drawing.Size(75, 80);
            this.register_remItem_button.TabIndex = 23;
            this.register_remItem_button.Text = "Remove Selected Item From Cart";
            this.register_remItem_button.UseVisualStyleBackColor = true;
            this.register_remItem_button.Click += new System.EventHandler(this.remove_ItemCart_click);
            // 
            // clear_cart_button
            // 
            this.clear_cart_button.Location = new System.Drawing.Point(513, 13);
            this.clear_cart_button.Name = "clear_cart_button";
            this.clear_cart_button.Size = new System.Drawing.Size(75, 38);
            this.clear_cart_button.TabIndex = 21;
            this.clear_cart_button.Text = "Clear Cart";
            this.clear_cart_button.UseVisualStyleBackColor = true;
            this.clear_cart_button.Click += new System.EventHandler(this.clear_cart_button_Click);
            // 
            // pay_button
            // 
            this.pay_button.Location = new System.Drawing.Point(513, 481);
            this.pay_button.Name = "pay_button";
            this.pay_button.Size = new System.Drawing.Size(75, 162);
            this.pay_button.TabIndex = 19;
            this.pay_button.Text = "Pay";
            this.pay_button.UseVisualStyleBackColor = true;
            this.pay_button.Click += new System.EventHandler(this.pay_button_click);
            // 
            // cartList
            // 
            this.cartList.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartList.FormattingEnabled = true;
            this.cartList.Location = new System.Drawing.Point(10, 54);
            this.cartList.Name = "cartList";
            this.cartList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cartList.Size = new System.Drawing.Size(497, 589);
            this.cartList.TabIndex = 17;
            // 
            // cartLabel
            // 
            this.cartLabel.AutoSize = true;
            this.cartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.cartLabel.Location = new System.Drawing.Point(5, 3);
            this.cartLabel.Name = "cartLabel";
            this.cartLabel.Size = new System.Drawing.Size(55, 25);
            this.cartLabel.TabIndex = 15;
            this.cartLabel.Text = "Cart:";
            // 
            // sumLabel
            // 
            this.sumLabel.AutoSize = true;
            this.sumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sumLabel.Location = new System.Drawing.Point(100, 646);
            this.sumLabel.Name = "sumLabel";
            this.sumLabel.Size = new System.Drawing.Size(16, 18);
            this.sumLabel.TabIndex = 14;
            this.sumLabel.Text = "0";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.totalPriceLabel.Location = new System.Drawing.Point(9, 646);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(87, 18);
            this.totalPriceLabel.TabIndex = 13;
            this.totalPriceLabel.Text = "Total Price: ";
            // 
            // return_tab
            // 
            this.return_tab.BackColor = System.Drawing.Color.Transparent;
            this.return_tab.Controls.Add(this.label23);
            this.return_tab.Controls.Add(this.label25);
            this.return_tab.Controls.Add(this.label26);
            this.return_tab.Controls.Add(this.return_Product_name_box);
            this.return_tab.Controls.Add(this.return_button);
            this.return_tab.Controls.Add(this.return_balance);
            this.return_tab.Controls.Add(this.id_dropdown_box);
            this.return_tab.Location = new System.Drawing.Point(4, 22);
            this.return_tab.Name = "return_tab";
            this.return_tab.Padding = new System.Windows.Forms.Padding(3);
            this.return_tab.Size = new System.Drawing.Size(601, 698);
            this.return_tab.TabIndex = 1;
            this.return_tab.Text = "Return";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(21, 183);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 13);
            this.label23.TabIndex = 15;
            this.label23.Text = "Balance:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(21, 76);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(21, 13);
            this.label25.TabIndex = 12;
            this.label25.Text = "ID:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(20, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(78, 13);
            this.label26.TabIndex = 10;
            this.label26.Text = "Product Name:";
            // 
            // return_Product_name_box
            // 
            this.return_Product_name_box.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.return_Product_name_box.Enabled = false;
            this.return_Product_name_box.Location = new System.Drawing.Point(23, 144);
            this.return_Product_name_box.Name = "return_Product_name_box";
            this.return_Product_name_box.Size = new System.Drawing.Size(201, 20);
            this.return_Product_name_box.TabIndex = 3;
            // 
            // return_button
            // 
            this.return_button.Location = new System.Drawing.Point(23, 235);
            this.return_button.Name = "return_button";
            this.return_button.Size = new System.Drawing.Size(201, 51);
            this.return_button.TabIndex = 2;
            this.return_button.Text = "Return Item(s)";
            this.return_button.UseVisualStyleBackColor = true;
            this.return_button.Click += new System.EventHandler(this.return_button_Click);
            // 
            // return_balance
            // 
            this.return_balance.Location = new System.Drawing.Point(24, 199);
            this.return_balance.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.return_balance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.return_balance.Name = "return_balance";
            this.return_balance.Size = new System.Drawing.Size(200, 20);
            this.return_balance.TabIndex = 1;
            this.return_balance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // id_dropdown_box
            // 
            this.id_dropdown_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.id_dropdown_box.FormattingEnabled = true;
            this.id_dropdown_box.Location = new System.Drawing.Point(23, 92);
            this.id_dropdown_box.Name = "id_dropdown_box";
            this.id_dropdown_box.Size = new System.Drawing.Size(201, 21);
            this.id_dropdown_box.TabIndex = 0;
            this.id_dropdown_box.SelectedIndexChanged += new System.EventHandler(this.id_dropdown_box_SelectedIndexChanged);
            // 
            // storageTab
            // 
            this.storageTab.BackColor = System.Drawing.Color.Transparent;
            this.storageTab.Controls.Add(this.tabControl2);
            this.storageTab.Location = new System.Drawing.Point(4, 22);
            this.storageTab.Name = "storageTab";
            this.storageTab.Padding = new System.Windows.Forms.Padding(3);
            this.storageTab.Size = new System.Drawing.Size(609, 730);
            this.storageTab.TabIndex = 1;
            this.storageTab.Text = "Storage";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.addTab);
            this.tabControl2.Controls.Add(this.removeTab);
            this.tabControl2.Controls.Add(this.restockTab);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(414, 721);
            this.tabControl2.TabIndex = 0;
            // 
            // addTab
            // 
            this.addTab.BackColor = System.Drawing.Color.Transparent;
            this.addTab.Controls.Add(this.add_product_button);
            this.addTab.Controls.Add(this.number_Balance);
            this.addTab.Controls.Add(this.number_Price);
            this.addTab.Controls.Add(this.label_Balance);
            this.addTab.Controls.Add(this.label_Price);
            this.addTab.Controls.Add(this.textbox_ID);
            this.addTab.Controls.Add(this.label_ID);
            this.addTab.Controls.Add(this.storage_productName_texbox);
            this.addTab.Controls.Add(this.label_Name);
            this.addTab.Location = new System.Drawing.Point(4, 22);
            this.addTab.Name = "addTab";
            this.addTab.Padding = new System.Windows.Forms.Padding(3);
            this.addTab.Size = new System.Drawing.Size(406, 695);
            this.addTab.TabIndex = 0;
            this.addTab.Text = "Add New Product";
            // 
            // add_product_button
            // 
            this.add_product_button.Location = new System.Drawing.Point(22, 277);
            this.add_product_button.Name = "add_product_button";
            this.add_product_button.Size = new System.Drawing.Size(229, 52);
            this.add_product_button.TabIndex = 10;
            this.add_product_button.Text = "Add Product";
            this.add_product_button.UseVisualStyleBackColor = true;
            this.add_product_button.Click += new System.EventHandler(this.add_product_button_Click);
            // 
            // number_Balance
            // 
            this.number_Balance.Location = new System.Drawing.Point(22, 226);
            this.number_Balance.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.number_Balance.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number_Balance.Name = "number_Balance";
            this.number_Balance.Size = new System.Drawing.Size(229, 20);
            this.number_Balance.TabIndex = 9;
            this.number_Balance.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // number_Price
            // 
            this.number_Price.DecimalPlaces = 2;
            this.number_Price.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.number_Price.Location = new System.Drawing.Point(22, 166);
            this.number_Price.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.number_Price.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.number_Price.Name = "number_Price";
            this.number_Price.Size = new System.Drawing.Size(229, 20);
            this.number_Price.TabIndex = 8;
            this.number_Price.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_Balance
            // 
            this.label_Balance.AutoSize = true;
            this.label_Balance.Location = new System.Drawing.Point(19, 198);
            this.label_Balance.Name = "label_Balance";
            this.label_Balance.Size = new System.Drawing.Size(49, 13);
            this.label_Balance.TabIndex = 6;
            this.label_Balance.Text = "Balance:";
            // 
            // label_Price
            // 
            this.label_Price.AutoSize = true;
            this.label_Price.Location = new System.Drawing.Point(19, 141);
            this.label_Price.Name = "label_Price";
            this.label_Price.Size = new System.Drawing.Size(34, 13);
            this.label_Price.TabIndex = 4;
            this.label_Price.Text = "Price:";
            // 
            // textbox_ID
            // 
            this.textbox_ID.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textbox_ID.Enabled = false;
            this.textbox_ID.Location = new System.Drawing.Point(22, 53);
            this.textbox_ID.Name = "textbox_ID";
            this.textbox_ID.Size = new System.Drawing.Size(229, 20);
            this.textbox_ID.TabIndex = 3;
            // 
            // label_ID
            // 
            this.label_ID.AutoSize = true;
            this.label_ID.Location = new System.Drawing.Point(19, 37);
            this.label_ID.Name = "label_ID";
            this.label_ID.Size = new System.Drawing.Size(21, 13);
            this.label_ID.TabIndex = 2;
            this.label_ID.Text = "ID:";
            // 
            // storage_productName_texbox
            // 
            this.storage_productName_texbox.BackColor = System.Drawing.SystemColors.Window;
            this.storage_productName_texbox.Location = new System.Drawing.Point(22, 105);
            this.storage_productName_texbox.Name = "storage_productName_texbox";
            this.storage_productName_texbox.Size = new System.Drawing.Size(229, 20);
            this.storage_productName_texbox.TabIndex = 1;
            this.storage_productName_texbox.TextChanged += new System.EventHandler(this.textField_Name_TextChanged);
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Location = new System.Drawing.Point(19, 89);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(78, 13);
            this.label_Name.TabIndex = 0;
            this.label_Name.Text = "Product Name:";
            // 
            // removeTab
            // 
            this.removeTab.BackColor = System.Drawing.Color.Transparent;
            this.removeTab.Controls.Add(this.remove_balance_textbox);
            this.removeTab.Controls.Add(this.remove_price_textbox);
            this.removeTab.Controls.Add(this.label7);
            this.removeTab.Controls.Add(this.label8);
            this.removeTab.Controls.Add(this.remove_id_textbox);
            this.removeTab.Controls.Add(this.label9);
            this.removeTab.Controls.Add(this.remove_name_textbox);
            this.removeTab.Controls.Add(this.label10);
            this.removeTab.Controls.Add(this.selected_product_label);
            this.removeTab.Controls.Add(this.remove_product_button);
            this.removeTab.Controls.Add(this.label6);
            this.removeTab.Controls.Add(this.remove_product_label);
            this.removeTab.Location = new System.Drawing.Point(4, 22);
            this.removeTab.Name = "removeTab";
            this.removeTab.Padding = new System.Windows.Forms.Padding(3);
            this.removeTab.Size = new System.Drawing.Size(406, 695);
            this.removeTab.TabIndex = 1;
            this.removeTab.Text = "Remove Product";
            // 
            // remove_balance_textbox
            // 
            this.remove_balance_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.remove_balance_textbox.Enabled = false;
            this.remove_balance_textbox.Location = new System.Drawing.Point(9, 452);
            this.remove_balance_textbox.Name = "remove_balance_textbox";
            this.remove_balance_textbox.Size = new System.Drawing.Size(229, 20);
            this.remove_balance_textbox.TabIndex = 17;
            // 
            // remove_price_textbox
            // 
            this.remove_price_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.remove_price_textbox.Enabled = false;
            this.remove_price_textbox.Location = new System.Drawing.Point(9, 393);
            this.remove_price_textbox.Name = "remove_price_textbox";
            this.remove_price_textbox.Size = new System.Drawing.Size(229, 20);
            this.remove_price_textbox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Balance:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 368);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Price:";
            // 
            // remove_id_textbox
            // 
            this.remove_id_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.remove_id_textbox.Enabled = false;
            this.remove_id_textbox.Location = new System.Drawing.Point(9, 280);
            this.remove_id_textbox.Name = "remove_id_textbox";
            this.remove_id_textbox.Size = new System.Drawing.Size(229, 20);
            this.remove_id_textbox.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "ID:";
            // 
            // remove_name_textbox
            // 
            this.remove_name_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.remove_name_textbox.Enabled = false;
            this.remove_name_textbox.Location = new System.Drawing.Point(9, 332);
            this.remove_name_textbox.Name = "remove_name_textbox";
            this.remove_name_textbox.Size = new System.Drawing.Size(229, 20);
            this.remove_name_textbox.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Product Name:";
            // 
            // selected_product_label
            // 
            this.selected_product_label.AutoSize = true;
            this.selected_product_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_product_label.Location = new System.Drawing.Point(5, 226);
            this.selected_product_label.Name = "selected_product_label";
            this.selected_product_label.Size = new System.Drawing.Size(176, 24);
            this.selected_product_label.TabIndex = 3;
            this.selected_product_label.Text = "Selected Product:";
            // 
            // remove_product_button
            // 
            this.remove_product_button.Location = new System.Drawing.Point(9, 149);
            this.remove_product_button.Name = "remove_product_button";
            this.remove_product_button.Size = new System.Drawing.Size(242, 44);
            this.remove_product_button.TabIndex = 2;
            this.remove_product_button.Text = "Remove Selected Product";
            this.remove_product_button.UseVisualStyleBackColor = true;
            this.remove_product_button.Click += new System.EventHandler(this.remove_StoreProduct_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 24);
            this.label6.TabIndex = 1;
            this.label6.Text = "Instructions:";
            // 
            // remove_product_label
            // 
            this.remove_product_label.AutoSize = true;
            this.remove_product_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.remove_product_label.Location = new System.Drawing.Point(6, 47);
            this.remove_product_label.Name = "remove_product_label";
            this.remove_product_label.Size = new System.Drawing.Size(245, 85);
            this.remove_product_label.TabIndex = 0;
            this.remove_product_label.Text = " 1.  Select product from the list\r\n 2.  Click \"Remove Selected Product\"\r\n(3). If " +
    "product have balance > 0,\r\n      \"Yes\", removes product anyways\r\n      \"No\", the" +
    " product is not removed. \r\n";
            // 
            // restockTab
            // 
            this.restockTab.BackColor = System.Drawing.Color.Transparent;
            this.restockTab.Controls.Add(this.place_order_button);
            this.restockTab.Controls.Add(this.order_amount_numeric);
            this.restockTab.Controls.Add(this.label14);
            this.restockTab.Controls.Add(this.order_balance_textbox);
            this.restockTab.Controls.Add(this.label13);
            this.restockTab.Controls.Add(this.order_id_textbox);
            this.restockTab.Controls.Add(this.label15);
            this.restockTab.Controls.Add(this.order_product_textbox);
            this.restockTab.Controls.Add(this.label16);
            this.restockTab.Controls.Add(this.label17);
            this.restockTab.Controls.Add(this.label11);
            this.restockTab.Controls.Add(this.label12);
            this.restockTab.Location = new System.Drawing.Point(4, 22);
            this.restockTab.Name = "restockTab";
            this.restockTab.Padding = new System.Windows.Forms.Padding(3);
            this.restockTab.Size = new System.Drawing.Size(406, 695);
            this.restockTab.TabIndex = 2;
            this.restockTab.Text = "Restock a Product";
            // 
            // place_order_button
            // 
            this.place_order_button.Location = new System.Drawing.Point(6, 381);
            this.place_order_button.Name = "place_order_button";
            this.place_order_button.Size = new System.Drawing.Size(233, 43);
            this.place_order_button.TabIndex = 29;
            this.place_order_button.Text = "Place Order";
            this.place_order_button.UseVisualStyleBackColor = true;
            this.place_order_button.Click += new System.EventHandler(this.restock_Storage_click);
            // 
            // order_amount_numeric
            // 
            this.order_amount_numeric.Location = new System.Drawing.Point(6, 335);
            this.order_amount_numeric.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
            this.order_amount_numeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.order_amount_numeric.Name = "order_amount_numeric";
            this.order_amount_numeric.Size = new System.Drawing.Size(229, 20);
            this.order_amount_numeric.TabIndex = 28;
            this.order_amount_numeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(91, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Amount To Order:";
            // 
            // order_balance_textbox
            // 
            this.order_balance_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.order_balance_textbox.Enabled = false;
            this.order_balance_textbox.Location = new System.Drawing.Point(10, 284);
            this.order_balance_textbox.Name = "order_balance_textbox";
            this.order_balance_textbox.Size = new System.Drawing.Size(229, 20);
            this.order_balance_textbox.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 268);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Current Balance:";
            // 
            // order_id_textbox
            // 
            this.order_id_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.order_id_textbox.Enabled = false;
            this.order_id_textbox.Location = new System.Drawing.Point(10, 181);
            this.order_id_textbox.Name = "order_id_textbox";
            this.order_id_textbox.Size = new System.Drawing.Size(229, 20);
            this.order_id_textbox.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "ID:";
            // 
            // order_product_textbox
            // 
            this.order_product_textbox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.order_product_textbox.Enabled = false;
            this.order_product_textbox.Location = new System.Drawing.Point(10, 233);
            this.order_product_textbox.Name = "order_product_textbox";
            this.order_product_textbox.Size = new System.Drawing.Size(229, 20);
            this.order_product_textbox.TabIndex = 20;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 217);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Product Name:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(6, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(176, 24);
            this.label17.TabIndex = 18;
            this.label17.Text = "Selected Product:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(122, 24);
            this.label11.TabIndex = 3;
            this.label11.Text = "Instructions:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label12.Location = new System.Drawing.Point(7, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(343, 51);
            this.label12.TabIndex = 2;
            this.label12.Text = " 1.  Select product from the list\r\n 2.  Enter the amount desiered to orber from g" +
    "rossist.\r\n 3.  Click button \"Order Product\"";
            // 
            // storage_ListBox
            // 
            this.storage_ListBox.Font = new System.Drawing.Font("Consolas", 10F);
            this.storage_ListBox.FormattingEnabled = true;
            this.storage_ListBox.ItemHeight = 15;
            this.storage_ListBox.Location = new System.Drawing.Point(631, 126);
            this.storage_ListBox.Name = "storage_ListBox";
            this.storage_ListBox.Size = new System.Drawing.Size(570, 634);
            this.storage_ListBox.TabIndex = 0;
            this.storage_ListBox.SelectedIndexChanged += new System.EventHandler(this.storage_ListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(635, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "In Store:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(631, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(726, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(941, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(1098, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Balance";
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.search_label.Location = new System.Drawing.Point(634, 75);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(117, 17);
            this.search_label.TabIndex = 6;
            this.search_label.Text = "Search by Name:";
            // 
            // search_textbox
            // 
            this.search_textbox.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_textbox.Location = new System.Drawing.Point(757, 72);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(220, 22);
            this.search_textbox.TabIndex = 7;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(983, 63);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(75, 35);
            this.search_button.TabIndex = 8;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // clear_search_button
            // 
            this.clear_search_button.Location = new System.Drawing.Point(1064, 63);
            this.clear_search_button.Name = "clear_search_button";
            this.clear_search_button.Size = new System.Drawing.Size(66, 35);
            this.clear_search_button.TabIndex = 9;
            this.clear_search_button.Text = "Clear Search";
            this.clear_search_button.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 780);
            this.Controls.Add(this.clear_search_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.search_label);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.storage_ListBox);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(2000, 2000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1046, 819);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.registerTab.ResumeLayout(false);
            this.sub_registerTab.ResumeLayout(false);
            this.sell_tab.ResumeLayout(false);
            this.sell_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.register_amount_number)).EndInit();
            this.return_tab.ResumeLayout(false);
            this.return_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.return_balance)).EndInit();
            this.storageTab.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.addTab.ResumeLayout(false);
            this.addTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.number_Balance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number_Price)).EndInit();
            this.removeTab.ResumeLayout(false);
            this.removeTab.PerformLayout();
            this.restockTab.ResumeLayout(false);
            this.restockTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.order_amount_numeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage registerTab;
        private System.Windows.Forms.TabPage storageTab;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage addTab;
        private System.Windows.Forms.TabPage removeTab;
        private System.Windows.Forms.ListBox storage_ListBox;
        private System.Windows.Forms.Label label_Balance;
        private System.Windows.Forms.Label label_Price;
        private System.Windows.Forms.TextBox textbox_ID;
        private System.Windows.Forms.Label label_ID;
        private System.Windows.Forms.TextBox storage_productName_texbox;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.TabPage restockTab;
        private System.Windows.Forms.NumericUpDown number_Balance;
        private System.Windows.Forms.NumericUpDown number_Price;
        private System.Windows.Forms.Button add_product_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button remove_product_button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label remove_product_label;
        private System.Windows.Forms.TextBox remove_balance_textbox;
        private System.Windows.Forms.TextBox remove_price_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox remove_id_textbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox remove_name_textbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label selected_product_label;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown order_amount_numeric;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox order_balance_textbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox order_id_textbox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox order_product_textbox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button place_order_button;
        private System.Windows.Forms.TabControl sub_registerTab;
        private System.Windows.Forms.TabPage sell_tab;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown register_amount_number;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button add_selected_to_cart;
        private System.Windows.Forms.Button register_remItem_button;
        private System.Windows.Forms.Button clear_cart_button;
        private System.Windows.Forms.Button pay_button;
        private System.Windows.Forms.ListBox cartList;
        private System.Windows.Forms.Label cartLabel;
        private System.Windows.Forms.Label sumLabel;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.TabPage return_tab;
        private System.Windows.Forms.ComboBox id_dropdown_box;
        private System.Windows.Forms.Button return_button;
        private System.Windows.Forms.NumericUpDown return_balance;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox return_Product_name_box;
        private System.Windows.Forms.Label search_label;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button clear_search_button;
    }
}


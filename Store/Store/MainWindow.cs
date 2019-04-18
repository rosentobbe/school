using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Store
{
    public partial class MainWindow : Form
    {
        int P_NAME_MAX_LENGTH = 100;
        int CARTLIST_NAME_LENGTH = 35;
        int STORAGE_NAME_LENGTH = 25;
        int STATISTIC_NAME_LENGTH = 45;
        int MAX_BALANCE = 999999999;
        int nextID = 1;
        static String Storage_format    = "{0,-12} {1,-30} {2,-22} {3,-10}";
        static String Register_format   = "{0,-8} {1,-43} {2,-18} {3,-10}";
        static String Statistic_format = "{0,-7} {1,-7} {2,-51} {3,-5}\n";

        // Register
        Register registerObject = new Register();


        //Storage 
        Storage storageObject = new Storage();

        public MainWindow()
        {
            InitializeComponent();
            this.Text = "Tobi Store";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "  ddd dd MMM yyyy";
            dateTimePicker1.CustomFormat = "  ddd dd MMM yyyy";
            
            storage_productName_texbox.MaxLength  = P_NAME_MAX_LENGTH;
            search_textbox.MaxLength              = P_NAME_MAX_LENGTH;

            registerObject.loadProductStatistic();
            storageObject.loadStorage();

            update_ID();
            update_All_Lists();
        }

        //Triggers when User enters a value. Purpose is to remove the red background when wrong input.
        private void textField_Name_TextChanged(object sender, EventArgs e)
        {
            storage_productName_texbox.BackColor = Color.White;
        }
        /*******************************************************************/
        /*                  Form closing handler                           */
        /*******************************************************************/
        //Triggers as the form is closed. Handels all the saving of the storage and statistics
        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (registerObject.isCartEmpty())
            {
                storageObject.saveStorage();
                registerObject.saveProductToStatistic();
            }
            else
            {
                MessageBox.Show("Can't close the store when cart isn't empty!");
                e.Cancel = true;
            }
        }
        /*******************************************************************/
        /*                  List, ID and List Updaters                     */
        /*******************************************************************/
        //Updates the ID so that the incremention of product IDs are correct. 
        //If storage doesn't contain any products it starts from zero. Otherwise from the highest value.
        private void update_ID()
        {
            if (storageObject.isStoreEmpty())
                textbox_ID.Text = nextID.ToString();
            else
            {
                nextID = storageObject.getAvailableProducts().Last().P_ID + 1;
                textbox_ID.Text = nextID.ToString();
            }
        }
        //Updates all list displayers so that they contain the everything from the storage.
        //Correct the product names so that they are of "correct" length.
        private void update_All_Lists()
        {
            string searchValue = search_textbox.Text.ToLower();
            clearAllFields();
            storage_ListBox.Items.Clear();
            cartList.Items.Clear();
            string temp_name;
            foreach (Product x in registerObject.getAllProductsInCart())
            {
                if (x.Name.Length < CARTLIST_NAME_LENGTH)
                    temp_name = x.Name;
                else
                    temp_name = x.Name.Substring(0, CARTLIST_NAME_LENGTH) + "...";
                cartList.Items.Add(String.Format(Register_format, x.P_ID, temp_name, x.Price, x.Balance));
            }

            foreach (Product x in storageObject.getAvailableProducts())
            {
                if (x.Name.ToLower().Contains(searchValue))
                {
                    if (x.Name.Length < STORAGE_NAME_LENGTH)
                        temp_name = x.Name;
                    else
                        temp_name = x.Name.Substring(0, STORAGE_NAME_LENGTH) + "...";
                    storage_ListBox.Items.Add(String.Format(Storage_format, x.P_ID, temp_name, x.Price, x.Balance));
                }
            }
            update_total_price();
        }
        //Clears all the feilds so that no old values can accidently be used.
        private void clearAllFields()
        {
            remove_id_textbox.Clear();
            remove_name_textbox.Clear();
            remove_price_textbox.Clear();
            remove_balance_textbox.Clear();

            order_id_textbox.Clear();
            order_product_textbox.Clear();
            order_balance_textbox.Clear();

            register_amount_number.Value = 1;

            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();
            stat_text_box_display.Clear();
            stat_combo_ID.SelectedIndex = -1;

            return_Product_name_box.Clear();
            id_dropdown_box.SelectedIndex = -1;
        }
        //Updates and displays the total price of the Items in the cart. 
        private void update_total_price()
        {
            sumLabel.Text = registerObject.totalSum.ToString() + " €";
        }
        //Lets the User remove items from the storage. 
        //Condition: The cart is empty.
        private void remove_product_from_lists(int selectedIndex, int ProductID)
        {
            if (registerObject.isCartEmpty())
            {
                storage_ListBox.Items.RemoveAt(selectedIndex);
                storageObject.removeProduct(ProductID);

                clearAllFields();
            }
            else
                MessageBox.Show("Please Clear the Cart Before Removing a Product");
        }
        /*******************************************************************/
        /*                  Index Event Handlers                           */
        /*******************************************************************/
        //Triggers as the User changes tabs. Used to make sure that dropdowns contain available values. 
        private void sub_registerTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sub_registerTab.SelectedTab.Name == "return_tab")
            {
                foreach (Product x in storageObject.getAvailableProducts())
                {
                    id_dropdown_box.Items.Add(x.P_ID);
                }
            }
            else if(sub_registerTab.SelectedTab.Name == "stat_tab")
            {
                foreach (Product x in storageObject.getAvailableProducts())
                {
                    stat_combo_ID.Items.Add(x.P_ID);
                }
            }
        }
        //Triggers as the user changes index. The function update fields so that they contain name of product.
        private void id_dropdown_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (id_dropdown_box.SelectedIndex != -1)
                return_Product_name_box.Text = storageObject.getProductWithID((int)id_dropdown_box.SelectedItem).Name;
        }
        //Triggers as the User changes index. 
        //Used to update fields so that they contain information about the right product
        private void storage_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storage_ListBox.SelectedIndex >= 0)
            {
                List<Product> temp_product_list = storageObject.getAvailableProducts();
                Product temp_product = temp_product_list.ElementAt(0);
                int productID = Convert.ToInt32(((string)storage_ListBox.SelectedItem).Split(' ')[0]);
                foreach (Product x in temp_product_list)
                {
                    if (x.P_ID == productID)
                    {
                        temp_product = x;
                        break;
                    }
                }
                if (tabControl1.SelectedTab.Name == "storageTab")
                {
                    string activeSubtab = tabControl2.SelectedTab.Name;
                    if (activeSubtab == "removeTab")
                    {
                        remove_id_textbox.Text = temp_product.P_ID.ToString();
                        remove_name_textbox.Text = temp_product.Name;
                        remove_price_textbox.Text = temp_product.Price.ToString();
                        remove_balance_textbox.Text = temp_product.Balance.ToString();
                    }
                    else if (activeSubtab == "restockTab")
                    {
                        order_id_textbox.Text = temp_product.P_ID.ToString();
                        order_product_textbox.Text = temp_product.Name.ToString();
                        order_balance_textbox.Text = temp_product.Balance.ToString();
                    }
                }
            }
        }

        /*******************************************************************/
        /*                  Button Click handlers                          */
        /*******************************************************************/
        //Triggers as the User clicks the return button in register tab.
        //Checks that the balance is of valid value. Else triggers an error message.
        private void return_button_Click(object sender, EventArgs e)
        {
            if (id_dropdown_box.SelectedIndex != -1)
            {
                if (storageObject.getProductWithID((int)id_dropdown_box.SelectedItem).Balance + (int)return_balance.Value < MAX_BALANCE)
                {
                    storageObject.increaseBalance((int)id_dropdown_box.SelectedItem, (int)return_balance.Value);
                    update_All_Lists();
                    clearAllFields();
                }
                else
                    MessageBox.Show("Our storage can't hold that amount, please return less!");
            }
        }
        //Triggers the update_all_lists so that the list only contains object relatet to the search.
        private void search_button_Click(object sender, EventArgs e)
        {
            update_All_Lists();
        }
        //Clears the serach field and the triggers the update_all_lists to display all items.
        private void clear_search_button_Click(object sender, EventArgs e)
        {
            search_textbox.Clear();
            update_All_Lists();
        }
        //Triggers as the User runs a specific search. Locates and then displays this item and its amount.
        private void top_Specific_Click(object sender, EventArgs e)
        {
            stat_text_box_display.Clear();
            string from_date = dateTimePicker1.Value.ToShortDateString();
            string to_date   = dateTimePicker2.Value.ToShortDateString();
            int p_id = 0;
            int count = 0;
            if (stat_combo_ID.SelectedIndex != -1)
                p_id = (int)stat_combo_ID.SelectedItem;
            if (from_date.CompareTo(to_date) != 1 && p_id != 0)
            {
                string specific_product_Name = storageObject.getProductWithID(p_id).Name;
                List<StatisticProduct> statistics = registerObject.getStatisticList();
                foreach(StatisticProduct x in statistics)
                {
                    if (x.P_ID == p_id && x.Name == specific_product_Name && from_date.CompareTo(x.Date) != 1 && to_date.CompareTo(x.Date) != -1 )
                        count = count + x.Balance;
                }
                if (specific_product_Name.Length >= STATISTIC_NAME_LENGTH)
                    specific_product_Name = specific_product_Name.Substring(0, STATISTIC_NAME_LENGTH) + "...";
                stat_text_box_display.Text = String.Format(Statistic_format, 1.ToString(), p_id, specific_product_Name, count);
            }
            else
                MessageBox.Show("Need an ID and \"From\" can't be a later date than \"To\".");
        }
        //Triggers as the User clicks on any of the preset top sales buttons. Then displays and updates 
        private void top_sales_buttons_click(object sender, EventArgs e)
        {
            stat_text_box_display.Clear();
            string theTrigger = ((Button)sender).Name;
            List<StatisticProduct> topList = new List<StatisticProduct>();
            int range = 10;
            int rankCount = 1;
            string temp_name;
            
            if (sender == top_all_time)
                topList = topAllTimeHandler();
            else if (sender == top_month)
                topList = topMonthHandler();
            else if (sender == top_year)
                topList = topYearHandler();

            if (topList.Count < range)
                range = topList.Count;
            topList = topList.OrderBy(si => si.Balance).Reverse().ToList().GetRange(0,range);
            foreach(StatisticProduct x in topList)
            {
                if (x.Name.Length < STATISTIC_NAME_LENGTH)
                    temp_name = x.Name;
                else
                    temp_name = x.Name.Substring(0, STATISTIC_NAME_LENGTH) + "...";

                stat_text_box_display.Text += String.Format(Statistic_format, rankCount, x.P_ID, temp_name, x.Balance);
                rankCount++;
            }
        }
        //Triggers as the "Add selected item to the cart" is clicked. 
        //It will collect the ID of the selected product and then retrive the product and it's balance from the storage. 
        //It will add x number of items if balance is larger than x.
        public void addToCart_Click(object sender, EventArgs e)
        {
            if(storage_ListBox.SelectedItem != null) { 
                int productID = Convert.ToInt32(((string)storage_ListBox.SelectedItem).Split(' ')[0]);

                if (productID > -1)
                {
                    List<Product> temp_product_list = storageObject.getAvailableProducts();
                    Product temp_product = temp_product_list.ElementAt(0);
                    foreach (Product x in temp_product_list)
                    {
                        if (x.P_ID == productID)
                        {
                            temp_product = x;
                            break;
                        }
                    }
                    if (temp_product.Balance >= register_amount_number.Value)
                    {
                        registerObject.add(temp_product.P_ID, temp_product.Name, temp_product.Price, (int)register_amount_number.Value);
                        storageObject.decreaseBalance(temp_product.P_ID, (int)register_amount_number.Value);
                        update_All_Lists();
                    }
                    else
                        MessageBox.Show("Don't have enough in store, choose a less amount");
                }
            }
        }
        //Triggers as the User wants to removes a product from storage. If the balance isn't 0 the User will get a notification.
        private void remove_StoreProduct_Click(object sender, EventArgs e)
        {
            int selectedIndex = storage_ListBox.SelectedIndex;
            int productID = Convert.ToInt32(((string)storage_ListBox.SelectedItem).Split(' ')[0]);

            if (remove_id_textbox.Text != "")
            {
                if (storageObject.getAvailableProducts().ElementAt(selectedIndex).Balance == 0)
                    remove_product_from_lists(selectedIndex, productID);
                else
                {
                    if (MessageBox.Show("Balance > 0\nDo you still want to remove?", "Balance > 0", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        remove_product_from_lists(selectedIndex, productID);
                }
            }
        }
        //Allows the Storage User to restock a product.
        //Controls the wished amount so that it dont exceed the limit.
        //Condition: Cart is empty.
        private void restock_Storage_click(object sender, EventArgs e)
        {
            if (registerObject.isCartEmpty())
            {
                if (storage_ListBox.SelectedIndex != -1)
                {
                    List<Product> temp_product_list = storageObject.getAvailableProducts();
                    Product temp_product = temp_product_list.ElementAt(0);
                    int productID = Convert.ToInt32(((string)storage_ListBox.SelectedItem).Split(' ')[0]);
                    foreach (Product x in temp_product_list)
                    {
                        if (x.P_ID == productID)
                        {
                            temp_product = x;
                            break;
                        }
                    }

                    int order_amount = (int)order_amount_numeric.Value;
                    if (order_amount + temp_product.Balance > MAX_BALANCE)
                        MessageBox.Show("Our storage can only hold an extra " + (MAX_BALANCE - temp_product.Balance).ToString());
                    else
                    {
                        storageObject.increaseBalance(temp_product.P_ID, order_amount);
                        update_All_Lists();
                    }
                }
            }
            else
                MessageBox.Show("Please Clear the Cart Before Restocking a Product");
        }
        //Clears the whole register cart and restores the product balance in Storage.
        private void clear_cart_button_Click(object sender, EventArgs e)
        {
            foreach (Product x in registerObject.getAllProductsInCart())
            {
                storageObject.increaseBalance(x.P_ID, x.Balance);
            }
            registerObject.clear();
            cartList.Items.Clear();
            update_All_Lists();
        }
        //Allows the storage users to add new product to the store. Checks if all the fileds are correct.
        private void add_product_button_Click(object sender, EventArgs e)
        {
            if (storage_productName_texbox.Text == "" || storage_productName_texbox.Text.First() == ' ')
                storage_productName_texbox.BackColor = Color.Red;
            else if (storage_productName_texbox.Text.Contains(","))
            {
                storage_productName_texbox.BackColor = Color.Red;
                MessageBox.Show("Product names can not contain ','");
            }
            else
            {
                storageObject.addNewProduct(storage_productName_texbox.Text, nextID, number_Price.Value, (int)number_Balance.Value);
                number_Price.Value = 1;
                number_Balance.Value = 1;
                storage_productName_texbox.Clear();
                update_All_Lists();
                update_ID();
            }
        }
        //Removes a selected item from the register cart. Also restore that products balance in the storage.
        private void remove_ItemCart_click(object sender, EventArgs e)
        {
            int selectedIndex = cartList.SelectedIndex;
            if (selectedIndex > -1)
            {
                Product product = registerObject.GetProductAtIndex(selectedIndex);

                registerObject.remove(selectedIndex);
                cartList.Items.RemoveAt(selectedIndex);

                storageObject.increaseBalance(product.P_ID, product.Balance);
                update_All_Lists();
            }
        }
        //Triggers as the register User clicks pay. Will call checkout function and then clear all fields.
        private void pay_button_click(object sender, EventArgs e)
        {
            if (!registerObject.isCartEmpty())
            {
                registerObject.checkout();

                registerObject.clear();
                cartList.Items.Clear();
                update_All_Lists();
            }
        }


        /*******************************************************************/
        /*                  Top 10 List Handlers                           */
        /*******************************************************************/
        //Updates the all time top list and displays it. 
        //Removed products that have the same ID will show up with the ID they had at that time. 
        //This will happen as long as they remain top sales.
        private List<StatisticProduct> topAllTimeHandler()
        {
            bool contain;
            List<StatisticProduct> statistics = registerObject.getStatisticList();
            List<StatisticProduct> topList = new List<StatisticProduct>();
            foreach (StatisticProduct x in statistics)
            {
                contain = false;
                foreach (StatisticProduct y in topList)
                {
                    if (x.P_ID == y.P_ID && x.Name == y.Name)
                    {
                        contain = true;
                        y.Balance += x.Balance;
                        break;
                    }
                }
                if (!contain)
                    topList.Add(new StatisticProduct("", x.Name, x.P_ID, x.Balance));
            }
            return topList;
        }
        //Updates the top sales for this month. 
        //Same feature here, removed products can have the same ID as existing ones. 
        private List<StatisticProduct> topMonthHandler()
        {
            bool contain;
            List<StatisticProduct> statistics = registerObject.getStatisticList();
            List<StatisticProduct> topList = new List<StatisticProduct>();
            string temp_year_month;
            string CurrentYearMonth = DateTime.Now.Year.ToString("0000") + "-" + DateTime.Now.Month.ToString("00");
            foreach (StatisticProduct x in statistics)
            {
                string[] Xsplit = x.Date.Split('-');
                temp_year_month = Xsplit[0] + "-" + Xsplit[1];
                contain = false;
                foreach (StatisticProduct y in topList)
                {
                    if (x.P_ID == y.P_ID && x.Name == y.Name && temp_year_month == CurrentYearMonth)
                    {
                        contain = true;
                        y.Balance += x.Balance;
                        break;
                    }
                }
                if (!contain && temp_year_month == CurrentYearMonth)
                    topList.Add(new StatisticProduct("", x.Name, x.P_ID, x.Balance));
            }
            return topList;
        }
        //Updates the top sales for this year.
        private List<StatisticProduct> topYearHandler()
        {
            bool contain;
            List<StatisticProduct> statistics = registerObject.getStatisticList();
            List<StatisticProduct> topList = new List<StatisticProduct>();
            string temp_year;
            string CurrentYear = DateTime.Now.Year.ToString("0000");
            foreach (StatisticProduct x in statistics)
            {
                temp_year = x.Date.Split('-')[0];
                contain = false;
                foreach (StatisticProduct y in topList)
                {
                    if (x.P_ID == y.P_ID && x.Name == y.Name && temp_year == CurrentYear)
                    {
                        contain = true;
                        y.Balance += x.Balance;
                        break;
                    }
                }
                if (!contain && temp_year == CurrentYear)
                    topList.Add(new StatisticProduct("", x.Name, x.P_ID, x.Balance));
            }
            return topList;
        }

        private void help_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Add product - Instructions:\n" +
                "1. Select a product from the store list to your right.\n" +
                "2. Enter number of the product to add.\n" +
                "3. Click the add to cart button.\n" +
                "4. Click pay when all product are registered.\n\n" +
                "Remove/Clear - Instructions:\n" +
                "1a. Clear button will clear the whole cart.\n" +
                "1b. Select a product from the cart.\n" +
                "2b. Click remove product from cart to remove the all instances of a specific product.\n" +
                "");
        }
    }
}

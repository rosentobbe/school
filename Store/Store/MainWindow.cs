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
        int MAX_BALANCE = 999999999;
        int nextID = 1;
        static String Storage_format    = "{0,-12} {1,-30} {2,-22} {3,-10}";
        static String Register_format   = "{0,-8} {1,-43} {2,-18} {3,-10}";

        // Register
        Register registerObject = new Register();


        //Storage 
        Storage storageObject = new Storage();

        public MainWindow()
        {
            InitializeComponent();
            storage_productName_texbox.MaxLength  = P_NAME_MAX_LENGTH;
            search_textbox.MaxLength              = P_NAME_MAX_LENGTH;
            storageObject.loadStorage();
            update_ID();
            update_All_Lists();
        }
        public void addToCart_Click(object sender, EventArgs e)
        {
            int index = storage_ListBox.SelectedIndex;
            if (index > -1)
            {
                Product temp_product = storageObject.getAvailableProducts().ElementAt(index);
                if (temp_product.Balance >= register_amount_number.Value)
                {
                    registerObject.add(temp_product.P_ID, temp_product.Name, temp_product.Price, (int)register_amount_number.Value);
                    storageObject.decreaseBalance(temp_product.P_ID, (int)register_amount_number.Value);
                    update_All_Lists();
                }
            }
        }

        private void add_product_button_Click(object sender, EventArgs e)
        {
            if (storage_productName_texbox.Text == "")
                storage_productName_texbox.BackColor = Color.Red;
            else if (storage_productName_texbox.Text.Contains(","))
            {
                MessageBox.Show("Product names can not contain ','");
            }
            else
            {
                storageObject.addNewProduct(storage_productName_texbox.Text, nextID, number_Price.Value, (int)number_Balance.Value);
                update_All_Lists();
                update_ID();
            }
        }
        
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

        private void remove_product_from_lists(int selectedIndex)
        {
            if (registerObject.isCartEmpty())
            {
                storage_ListBox.Items.RemoveAt(selectedIndex);
                storageObject.removeProduct(selectedIndex);

                clearAllFields();
            }
            else
                MessageBox.Show("Please Clear the Cart Before Removing a Product");
        }

        private void clearAllFields()
        {
            remove_id_textbox.Clear();
            remove_name_textbox.Clear();
            remove_price_textbox.Clear();
            remove_balance_textbox.Clear();

            order_id_textbox.Clear();
            order_product_textbox.Clear();
            order_balance_textbox.Clear();

            return_Product_name_box.Clear();
            id_dropdown_box.SelectedIndex = -1;
        }
        private void update_All_Lists()
        {
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
                if (x.Name.Length < STORAGE_NAME_LENGTH)
                    temp_name = x.Name;
                else
                    temp_name = x.Name.Substring(0, STORAGE_NAME_LENGTH) + "...";
                storage_ListBox.Items.Add(String.Format(Storage_format, x.P_ID, temp_name, x.Price, x.Balance));
            }
            update_total_price();
        }

        private void textField_Name_TextChanged(object sender, EventArgs e)
        {
            storage_productName_texbox.BackColor = Color.White;
        }

        private void remove_StoreProduct_Click(object sender, EventArgs e)
        {
            int selectedIndex = storage_ListBox.SelectedIndex;
            if (remove_id_textbox.Text != "")
            {
                if (storageObject.getAvailableProducts().ElementAt(selectedIndex).Balance == 0)
                {
                    remove_product_from_lists(selectedIndex);
                }
                else
                {
                    if (MessageBox.Show("Balance > 0\nDo you still want to remove?", "Balance > 0", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        remove_product_from_lists(selectedIndex);
                }
            }
        }

        private void restock_Storage_click(object sender, EventArgs e)
        {
            if (registerObject.isCartEmpty())
            {
                if (storage_ListBox.SelectedIndex != -1)
                {
                    List<Product> temp_product_list = storageObject.getAvailableProducts();
                    Product temp_product = temp_product_list.ElementAt(storage_ListBox.SelectedIndex);
                    int order_amount = (int)order_amount_numeric.Value;
                    if (order_amount + temp_product.Balance > MAX_BALANCE)
                    {
                        MessageBox.Show("Our storage can only hold an extra " + (MAX_BALANCE - temp_product.Balance).ToString());
                    }
                    else
                    {
                        storageObject.increaseBalance(temp_product.P_ID, order_amount);
                        update_All_Lists();
                    }
                }
            }
            else
                MessageBox.Show("Please Clear the Cart Before Removing a Product");
        }

        private void clear_cart_button_Click(object sender, EventArgs e)
        {
           foreach(Product x in registerObject.getAllProductsInCart())
            {
                storageObject.increaseBalance(x.P_ID, x.Balance);
            }
            registerObject.clear();
            cartList.Items.Clear();
            update_All_Lists();
        }

        private void storage_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (storage_ListBox.SelectedIndex >= 0)
            {
                List<Product> temp_product_list = storageObject.getAvailableProducts();
                Product temp_product = temp_product_list.ElementAt(storage_ListBox.SelectedIndex);
                if(tabControl1.SelectedTab.Name == "storageTab")
                {
                    string activeSubtab = tabControl2.SelectedTab.Name;
                    if (activeSubtab == "removeTab")
                    {
                        remove_id_textbox.Text      = temp_product.P_ID.ToString();
                        remove_name_textbox.Text    = temp_product.Name;
                        remove_price_textbox.Text   = temp_product.Price.ToString();
                        remove_balance_textbox.Text = temp_product.Balance.ToString();
                    }
                    else if(activeSubtab == "restockTab")
                    {
                        order_id_textbox.Text       = temp_product.P_ID.ToString();
                        order_product_textbox.Text  = temp_product.Name.ToString();
                        order_balance_textbox.Text  = temp_product.Balance.ToString();
                    }
                }
            }
        }

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
        private void update_total_price()
        {
            sumLabel.Text = registerObject.totalSum.ToString();
        }

        private void pay_button_click(object sender, EventArgs e)
        {
            //For version 1
            registerObject.clear();
            cartList.Items.Clear();
            update_All_Lists();
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (registerObject.isCartEmpty())
                storageObject.saveStorage();
            else
            {
                MessageBox.Show("Can't close the store when cart isn't empty!");
                e.Cancel = true;
            }
        }

        private void sub_registerTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sub_registerTab.SelectedTab.Name == "return_tab")
            {
                foreach (Product x in storageObject.getAvailableProducts())
                {
                    id_dropdown_box.Items.Add(x.P_ID);
                }
            }
        }

        private void id_dropdown_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (id_dropdown_box.SelectedIndex != -1)
                return_Product_name_box.Text = storageObject.getProductWithID((int)id_dropdown_box.SelectedItem).Name;
        }

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

        private void search_button_Click(object sender, EventArgs e)
        {
            // HÄR ÄR DU! Du har problem med hur du ska använda index från listan.
            List<Product> temp_products = storageObject.getAvailableProducts();
            foreach(Product x in temp_products)
            {
                if (x.Name.Contains(search_textbox.Text))
                {

                }
            }
        }
    }
}

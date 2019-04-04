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
        int MAX_LENGTH = 25;
        int productMax = 999999999;
        string activeTab;
        int nextID = 1;
        static String Storage_format = "{0,-12} {1,-30} {2,-20} {3,-10}";

        // Register
        Register registerObject = new Register();


        //Storage 
        Storage storageObject = new Storage();

        public MainWindow()
        {
            InitializeComponent();
            textField_Name.MaxLength = MAX_LENGTH;
            update_ID();

            //For testing
            textField_Name.Text  = "This is test Procudt Name";
            number_Balance.Value = 999999999;
            number_Price.Value   = 999999999;



        }
        public void addToCart()
        {

        }
        public void clearCart()
        {

        }
        public void removeItemCart()
        {

        }
        public void isCartEmpty()
        {

        }
        public void saveStorage()
        {

        }

        private void add_product_button_Click(object sender, EventArgs e)
        {
            if (textField_Name.Text == "")
                textField_Name.BackColor = Color.Red;
            else
            {
                storageObject.addNewProduct(textField_Name.Text, nextID, number_Price.Value, (int)number_Balance.Value);
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
            storage_ListBox.Items.RemoveAt(selectedIndex);
            storageObject.removeProduct(selectedIndex);
            remove_id_textbox.Clear();
            remove_name_textbox.Clear();
            remove_price_textbox.Clear();
            remove_balance_textbox.Clear();
            order_id_textbox.Clear();
            order_product_textbox.Clear();
            order_balance_textbox.Clear();
        }

        private void update_All_Lists()
        {
            storage_ListBox.Items.Clear();
            foreach (Product x in storageObject.getAvailableProducts())
            {                     
                storage_ListBox.Items.Add(String.Format(Storage_format, x.P_ID, x.Name, x.Price, x.Balance));
            }
        }

        private void textField_Name_TextChanged(object sender, EventArgs e)
        {
            textField_Name.BackColor = Color.White;
        }

        private void remove_product_button_Click(object sender, EventArgs e)
        {
            int selectedIndex = storage_ListBox.SelectedIndex;
            if (remove_id_textbox.Text != "")
            {
                if (storageObject.getAvailableProducts().ElementAt(selectedIndex).Balance == 0)
                {
                    remove_product_from_lists(selectedIndex);
                }
                else
                    if (MessageBox.Show("Balance > 0\nDo you still want to remove?", "Balance > 0", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    remove_product_from_lists(selectedIndex);
            }
        }

        private void place_order_button_Click(object sender, EventArgs e)
        {
            List<Product> temp_product_list = storageObject.getAvailableProducts();
            Product temp_product = temp_product_list.ElementAt(storage_ListBox.SelectedIndex);
            int order_amount = (int)order_amount_numeric.Value;
            if(order_amount + temp_product.Balance > productMax)
            {
                MessageBox.Show("Our storage can only hold an extra " + (productMax - temp_product.Balance).ToString());
            }
            else
            {
                //// HÄR ÄR DU! Fixa så att värdet updateras och läggs till på rätt sätt i listan.
            }
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


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Milestone
{
    public partial class InventoryManagement : Form
    {
        InventoryManager im = new InventoryManager();
        BindingSource bs = new BindingSource();
        BindingSource bs2 = new BindingSource();
        
        bool loggedIn = false;
        bool editingInv = false;
        BindingSource bsource = new BindingSource();
        public InventoryManagement()
        {
            
            InitializeComponent();
            im.inventoryList.Add(new InventoryItem("Blueberry Candle", "This candle smells like fresh blueberries.", "Paraffin", "Zinc Core", "Blue", "Blueberry", false, 4, 100, 3.00));
            im.inventoryList.Add(new InventoryItem("Vanilla Candle", "This is a white candle that smells like vanilla.", "Bees", "Paper Core", "White", "Vanilla", true, 8, 65, 5.00));
            im.inventoryList.Add(new InventoryItem("Hawaiian Candle", "This is an orange candle that smells like a tropical getaway.", "Soy", "CD", "Orange", "Hawaiian", true, 12, 52, 8.00));
            im.inventoryList.Add(new InventoryItem("Apple Cinnamon Candle", "This candle smells like apple cinnamon.", "Palm", "ECO", "Red", "Apple Cinnamon", false, 4, 74, 3.00));
            im.inventoryList.Add(new InventoryItem("Forest Candle", "This candle smells like an evergreen forest.", "Paraffin", "LX", "Green", "Evergreen", false, 8, 28, 5.00));
            im.inventoryList.Add(new InventoryItem("Fresh Linen Candle", "This candle smells like fresh linen", "Palm", "Paper Core", "Blue", "Fresh Linen", false, 4, 40, 3.00));
            im.inventoryList.Add(new InventoryItem("Cherry Blossom Candle", "This is a cherry blossom candle.", "Paraffin", "Zinc Core", "Pink", "Cherry Blossom", false, 8, 39, 5.00));
            im.inventoryList.Add(new InventoryItem("Cotton Candy Swirl Candle", "This candle smells like cotton candy freshness.", "Palm", "ECO", "Blue and Pink", "Cotton Candy", true, 12, 40, 8.00));
            im.inventoryList.Add(new InventoryItem("Strawberry Cream Candle", "This candle smells like strawberry cream.", "Paraffin", "ECO", "Red", "Strawberry Cream", true, 12, 29, 8.00));
            im.inventoryList.Add(new InventoryItem("Citrus Candle", "This candle smells like fresh citrus.", "Soy", "LX", "Orange", "Citrus", true, 8, 72, 5.00));
            im.RestockItem("Fresh Linen Candle", 4);
            im.RestockItem("Cotton Candy Swirl Candle", 7);
            im.RestockItem("Strawberry Cream Candle", 20);
            im.RestockItem("Blueberry Candle", 10);
            im.RestockItem("Hawaiian Candle", 17);
            im.RestockItem("Citrus Candle", 11);

        }

        //When this button is clicked it validates the users input and if it meets expectations it continues the program to the menu screen.
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(UsernameTextBox.Text.ToLower() == "admin" && PasswordTextBox.Text.ToLower() == "admin")
            {
                loggedIn = true;
                MenuPanel.Visible = true;
                UsernameTextBox.Clear();
                PasswordTextBox.Clear();
            }
        }

        //If this button is clicked it logs the user out and activates the login screen.
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            loggedIn = false;
            MenuPanel.Visible = false;
        }

        //This button closes the inventory screen, going back to the main menu screen.
        private void BackButton1_Click(object sender, EventArgs e)
        {
            InventoryPanel.Visible = false;
        }

        //This button is used to go to the inventory screen from the main menu.
        private void InventoryButton_Click(object sender, EventArgs e)
        {
            this.InventoryPanel.BringToFront();
            NameRadio.Checked = true;
            InventoryPanel.Visible = true;
            bs.DataSource = im.DisplayItems();
            dataGridView1.DataSource = bs;
            bs.ResetBindings(false);
            dataGridView1.AutoResizeColumns();
        }

        //This button brings up the panel to add new items.
        private void button1_Click(object sender, EventArgs e)
        {
            AddItemPanel.Visible = true;
        }

        //This button closes the additems panel
        private void button2_Click(object sender, EventArgs e)
        {
            AddItemPanel.Visible = false;
        }

        //This button handles adding new items to the inventory
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(NameTextBox.Text) && !string.IsNullOrWhiteSpace(DescriptionTextBox.Text) && !string.IsNullOrWhiteSpace(WaxTypeTextBox.Text) &&
                !string.IsNullOrWhiteSpace(WickTypeTextBox.Text) && !string.IsNullOrWhiteSpace(ColorTextBox.Text) && !string.IsNullOrWhiteSpace(ScentTextBox.Text) &&
                !string.IsNullOrWhiteSpace(SizeTextBox.Text) && !string.IsNullOrWhiteSpace(QuantityTextBox.Text) &&
                !string.IsNullOrWhiteSpace(PriceTextBox.Text))
                {
                    bool shimmeringCheckBox = false;
                    if(ShimmeringCheckBox.Checked)
                    {
                        shimmeringCheckBox = true;

                    }
                    if(!im.CreateItem(NameTextBox.Text, DescriptionTextBox.Text, WaxTypeTextBox.Text, WickTypeTextBox.Text, ColorTextBox.Text, ScentTextBox.Text, shimmeringCheckBox, Int32.Parse(SizeTextBox.Text), Int32.Parse(QuantityTextBox.Text), double.Parse(PriceTextBox.Text)))
                    {
                        dataGridView1.DataSource = bs;
                        bs.ResetBindings(false);
                        dataGridView1.AutoResizeColumns();
                        AddItemPanel.Visible = false;
                        NameTextBox.Clear();
                        DescriptionTextBox.Clear();
                        WaxTypeTextBox.Clear();
                        WickTypeTextBox.Clear();
                        ColorTextBox.Clear();
                        ScentTextBox.Clear();
                        ShimmeringCheckBox.Checked = false;
                        SizeTextBox.Clear();
                        QuantityTextBox.Clear();
                        PriceTextBox.Clear();
                        MessageBox.Show("Item added successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Item could not be added");
                    }
                }
                else
                {
                    MessageBox.Show("No Boxes can be empty!!");
                }
            }
            catch(System.FormatException s)
            {
                MessageBox.Show("Please enter the correct values!");
            }
            
        }

        //This button refreshes the list so the current items in the inventory are displayed.
        private void RefreshButton_Click(object sender, EventArgs e)
        {
            bs.DataSource = im.DisplayItems();
            bs.ResetBindings(false);
            dataGridView1.AutoResizeColumns();
        }

        //This button is to close the remove item panel
        private void RemoveBackButton_Click(object sender, EventArgs e)
        {

            RemovePanel.Visible = false;
        }

        //This button is used to open the remove item panel
        private void RemoveButton1_Click(object sender, EventArgs e)
        {
            RemovePanel.Visible = true;
            bs.DataSource = im.DisplayItems();
            ItemListBox.DataSource = bs;
            ItemListBox.DisplayMember = "Name";
        }

        //This button is used to remove an item.
        private void RemoveButton_Click(object sender, EventArgs e)
        {
            im.RemoveItem(ItemListBox.GetItemText(ItemListBox.SelectedItem));
            bs.ResetBindings(false);
            
        }

        //This button is used to bring up the orders panel
        private void OrdersButton_Click(object sender, EventArgs e)
        {
            this.OrderPanel.BringToFront();
            OrderPanel.Visible = true;
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "Description";
            dataGridView2.Columns[2].Name = "Current Quantity";
            dataGridView2.Columns[3].Name = "Last Ordered Quantity";
            dataGridView2.Columns[4].Name = "Last Ordered Date";
            dataGridView2.Rows.Clear();
            int i = 0;
            foreach (List<string> list in im.rows)
            {
                dataGridView2.Rows.Add(list[i], list[i + 1], list[i + 2], list[i + 3], list [i + 4] );
                
            }
            dataGridView2.AutoResizeColumns();
        }

        //This button is used to close the orders panel.
        private void BackButtonOrders_Click(object sender, EventArgs e)
        {
            OrderPanel.Visible = false;
        }

        //This button is used to open the panel to order new items.
        private void OrderButton_Click(object sender, EventArgs e)
        {
            OrderItemPanel.Visible = true;
        }

        //This button is used to close the order new items panel
        private void OrderBack_Click(object sender, EventArgs e)
        {
            OrderItemPanel.Visible = false;
            OrderNameTextBox.Clear();
            OrderQuantityTextBox.Clear();
        }

        //This button is used to place the order for new items.
        private void PlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(OrderNameTextBox.Text) && !string.IsNullOrWhiteSpace(OrderQuantityTextBox.Text))
                {
                    if (im.RestockItem(OrderNameTextBox.Text, Int32.Parse(OrderQuantityTextBox.Text)))
                    {
                        dataGridView2.Rows.Clear();
                        int i = 0;
                        foreach (List<string> list in im.rows)
                        {
                            dataGridView2.Rows.Add(list[i], list[i + 1], list[i + 2], list[i + 3], list[i + 4]);

                        }
                        dataGridView2.AutoResizeColumns();
                        OrderItemPanel.Visible = false;
                        OrderNameTextBox.Clear();
                        OrderQuantityTextBox.Clear();
                    }
                    else 
                    {
                        MessageBox.Show("Item not in inventory!");
                    }
                }
                else
                {
                    MessageBox.Show("Fields cannot be empty!");
                }

            }
            catch (System.FormatException p)
            {
                MessageBox.Show("Quantity must be a number!");
            }
        }

        //This button is used to search through the inventory.
        private void SearchBox_Click(object sender, EventArgs e)
        {
            List<InventoryItem> templist = new List<InventoryItem>();
            string radioSelected = null;
            if (NameRadio.Checked)
            {
                radioSelected = NameRadio.Text;
            }
            else if (ScentRadio.Checked)
            {
                radioSelected = ScentRadio.Text;
            }
            else
            {
                radioSelected = ColorRadio.Text;
            }

            templist = im.LookupItem(radioSelected, SearchTextBox.Text);
            SearchTextBox.Clear();
            
            if(templist.Count == 0)
            {
                MessageBox.Show("Your search returned 0 results!");
            }
            else
            {
                bs.DataSource = templist;
                bs.ResetBindings(false);
                dataGridView1.AutoResizeColumns();
            }

            
        }
    }
    
}


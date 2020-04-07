using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parallelised_Order_Processing {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void LoadDataDirectoryButton_Click(object sender, EventArgs e) {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            DialogResult result = fbd.ShowDialog();
            if(result == DialogResult.OK) {
                DataDirectoryTextBox.Text = fbd.SelectedPath;
            }
        }

        private void SelectStoreInfoButton_Click(object sender, EventArgs e) {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "CSV files (*.csv)|*.csv";
            DialogResult result = ofd.ShowDialog();
            if(result == DialogResult.OK) {
                SelectStoreInfoTextBox.Text = ofd.FileName;
            }
        }

        private void DataDirectoryTextBox_TextChanged(object sender, EventArgs e) {
            // Ensure both file directory boxes are not empty
            if (!string.IsNullOrWhiteSpace(DataDirectoryTextBox.Text) && !string.IsNullOrWhiteSpace(SelectStoreInfoTextBox.Text)) {
                LoadDataButton.Enabled = true;
            } else {
                LoadDataButton.Enabled = false;
            }
        }

        private void SelectStoreInfoTextBox_TextChanged(object sender, EventArgs e) {
            // Ensure both file directory boxes are not empty
            if (!string.IsNullOrWhiteSpace(DataDirectoryTextBox.Text) && !string.IsNullOrWhiteSpace(SelectStoreInfoTextBox.Text)) {
                LoadDataButton.Enabled = true;
            } else {
                LoadDataButton.Enabled = false;
            }
        }

        // Store information loaded from files
        SortedDictionary<string, Store> stores = new SortedDictionary<string, Store>();
        HashSet<Date> dates = new HashSet<Date>();
        HashSet<string> supplierNames = new HashSet<string>();
        HashSet<string> supplierTypes = new HashSet<string>();
        ConcurrentBag<Order> orders = new ConcurrentBag<Order>();

        private void LoadDataButton_Click(object sender, EventArgs e) {
            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Load store data
            string[] storeData = File.ReadAllLines(SelectStoreInfoTextBox.Text);
            foreach(string line in storeData) {
                ProcessStoreDataLine(line);
            }

            // Load order data
            string[] fileNames = Directory.GetFiles(DataDirectoryTextBox.Text);
            FileLoadingProgressBar.Maximum = fileNames.Length;  //Set maximum of progress bar
            FileLoadingProgressBar.Value = 0;

            // Ensure folder isn't empty
            if (fileNames.Length == 0)
                MessageBox.Show("Can't find any order data in specified file path", "Invalid File Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            foreach(string path in fileNames) {
                if (Path.GetExtension(path) != ".csv")
                    return;

                // Get stripped filename and split into StoreCode, Week and Year
                string fileName = Path.GetFileNameWithoutExtension(path.Split('\\').Last());
                string[] splitFileName = fileName.Split('_');

                // Find which store coresponds to order data
                Store store = stores[splitFileName[0]];

                // Save date from filename into Date object
                Date date = new Date();
                date.week = Convert.ToInt32(splitFileName[1]);
                date.year = Convert.ToInt32(splitFileName[2]);
                dates.Add(date);

                // Parallel process each line of order data
                string[] orderData = File.ReadAllLines(path);
                foreach(string orderLine in orderData) {
                    ProcessOrderFile(orderLine, store, date);
                }

                // Progress bar and percentage loaded
                FileLoadingProgressBar.Value++;
                FileLoadingProgressBar.Refresh();
                if(FileLoadingProgressBar.Value == FileLoadingProgressBar.Maximum) {
                    LoadDataButton.Text = "Load Data";
                    LoadDataButton.Enabled = true;
                    LoadDataButton.Refresh();
                } else {
                    LoadDataButton.Text = "Loading Data: " + (int)(((float)FileLoadingProgressBar.Value / (float)FileLoadingProgressBar.Maximum)*100) + "%";
                    LoadDataButton.Enabled = false;
                    LoadDataButton.Refresh();
                }
            }

            sw.Stop();  //Stop load data timer and print milliseconds
            Console.WriteLine("Data Loaded in " + sw.ElapsedMilliseconds/1000.0f + " seconds.");

            
            PopulateListBoxes();
        }

        void ProcessStoreDataLine(string line) {
            string[] splitLine = line.Split(',');
            Store store = new Store();
            store.code = splitLine[0];
            store.location = splitLine[1];
            if (!stores.ContainsKey(store.code))
                stores.Add(store.code, store);
        }

        void ProcessOrderFile(string orderLine, Store store, Date date) {
            string[] splitOrderInfo = orderLine.Split(',');

            // Add to supplier information HashSets
            supplierNames.Add(splitOrderInfo[0]);
            supplierTypes.Add(splitOrderInfo[1]);

            // Create order object
            Order order = new Order();
            order.store = store;
            order.date = date;
            order.supplierName = splitOrderInfo[0];
            order.supplierType = splitOrderInfo[1];
            order.cost = Convert.ToDouble(splitOrderInfo[2]);
            orders.Add(order);
        }

        void PopulateListBoxes() {
            // Enable List Boxes
            StoresListBox.Enabled = true;
            SuppliersListBox.Enabled = true;
            SupplierTypesListBox.Enabled = true;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Convert HashSets to Lists
            List<string> supNames = supplierNames.ToList();
            List<string> supTypes = supplierTypes.ToList();

            // Populate all list boxes
            foreach(string s in supNames) { 
                SuppliersListBox.Items.Add(s);
            }
            foreach (string s in supTypes) {
                SupplierTypesListBox.Items.Add(s);
            }
            foreach (var store in stores) {
                StoresListBox.Items.Add(store.Value.location);
            }

            sw.Stop();
            Console.WriteLine("ListBoxes populated in " + sw.ElapsedMilliseconds / 1000.0f + " seconds.");
        }

    }
}

class Store {
    public String code;
    public String location;
}

class Date {
    public int week;
    public int year;
}

class Order {
    public Store store;
    public Date date;
    public string supplierName;
    public string supplierType;
    public double cost;
}
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

        private void LoadDataButton_Click(object sender, EventArgs e) {
            // Store information loaded from files
            ConcurrentDictionary<string, Store> stores = new ConcurrentDictionary<string, Store>();
            ConcurrentDictionary<Date, byte> dates = new ConcurrentDictionary<Date, byte>();
            ConcurrentDictionary<Supplier, byte> suppliers = new ConcurrentDictionary<Supplier, byte>();
            List<Order> orders = new List<Order>();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Load store data
            string[] storeData = File.ReadAllLines(SelectStoreInfoTextBox.Text);
            Parallel.ForEach(storeData, line => ProcessStoreDataLine(line, ref stores));

            // Load order data
            string[] fileNames = Directory.GetFiles(DataDirectoryTextBox.Text);
            FileLoadingProgressBar.Maximum = fileNames.Length;
            if (fileNames.Length == 0)
                MessageBox.Show("Can't find any order data in specified file path", "Invalid File Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Parallel.ForEach(fileNames, path => ProcessOrderData(path, ref stores, ref dates, ref suppliers, ref orders));

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            int x = 0;
        }

        void ProcessStoreDataLine(string line, ref ConcurrentDictionary<string, Store> stores) {
            string[] splitLine = line.Split(',');
            Store store = new Store();
            store.code = splitLine[0];
            store.location = splitLine[1];
            if (!stores.ContainsKey(store.code))
                stores.TryAdd(store.code, store);
        }

        void ProcessOrderData(string path, ref ConcurrentDictionary<string, Store> stores, ref ConcurrentDictionary<Date, byte> dates, ref ConcurrentDictionary<Supplier, byte> suppliers, ref List<Order> orders) {
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
            dates.TryAdd(date, 0x00);

            // Process each line of order data
            string[] orderData = File.ReadAllLines(path);
            foreach(string orderLine in orderData) {
                string[] splitOrderInfo = orderLine.Split(',');
                Supplier supplier = new Supplier();
                supplier.name = splitOrderInfo[0];
                supplier.type = splitOrderInfo[1];
                suppliers.TryAdd(supplier, 0x00);

                Order order = new Order();
                order.store = store;
                order.date = date;
                order.supplier = supplier;
                order.cost = Convert.ToDouble(splitOrderInfo[2]);
                orders.Add(order);
            }

            // Increment loading bar
            //if (FileLoadingProgressBar.InvokeRequired) {
            //    FileLoadingProgressBar.Invoke(new MethodInvoker(delegate { FileLoadingProgressBar.Increment(1); }));
            //}
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

class Supplier {
    public string name;
    public string type;
}

class Order {
    public Store store;
    public Date date;
    public Supplier supplier;
    public double cost;
}
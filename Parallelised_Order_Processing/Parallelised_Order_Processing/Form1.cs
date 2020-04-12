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

        // Globals
        SortedDictionary<string, Store> stores = new SortedDictionary<string, Store>();
        HashSet<Date> dates = new HashSet<Date>(new DateComparer());
        HashSet<string> supplierNames = new HashSet<string>();
        HashSet<string> supplierTypes = new HashSet<string>();
        List<Order> orders = new List<Order>();

        int[] selectionIndices = { -1, -1, -1, -1 };
        enum INDICES {
            STORE = 0,
            SUPPLIER = 1,
            SUPPLIER_T = 2,
            DATE = 3
        }

        private void LoadDataButton_Click(object sender, EventArgs e) {
            stores.Clear();         // Clear previously loaded data
            dates.Clear();
            supplierNames.Clear();
            supplierTypes.Clear();
            orders.Clear();

            selectionIndices = Enumerable.Repeat<int>(-1, 4).ToArray(); // Reset previous selections

            StoresListBox.Items.Clear();        // Clear list boxes
            SuppliersListBox.Items.Clear();
            SupplierTypesListBox.Items.Clear();
            DatesListBox.Items.Clear();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Load store data
            string[] storeData = File.ReadAllLines(SelectStoreInfoTextBox.Text);
            foreach(string line in storeData) {
                ProcessStoreDataLine(line);
            }

            // Load order data
            string[] fileNames = Directory.GetFiles(DataDirectoryTextBox.Text);

            // Ensure folder isn't empty
            if (fileNames.Length == 0)
                MessageBox.Show("Can't find any order data in specified file path", "Invalid File Path", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Loop through each file in data directory             foreach(string path in fileNames)
            foreach (string path in fileNames) {
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
                foreach (string orderLine in orderData) {
                    ProcessOrderFile(orderLine, store, date);
                }
            }

            sw.Stop();  //Stop load data timer and print milliseconds
            Console.WriteLine("Data Loaded in " + sw.ElapsedMilliseconds/1000.0f + " seconds.");

            LoadDataButton.Enabled = true;
            LoadDataButton.Text = "Load Data";

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
            DatesListBox.Enabled = true;

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Populate all list boxes
            foreach (string s in supplierNames.AsParallel()) { 
                SuppliersListBox.Items.Add(s);
            }
            foreach (string s in supplierTypes.AsParallel()) {
                SupplierTypesListBox.Items.Add(s);
            }
            foreach (var store in stores.AsParallel()) {
                StoresListBox.Items.Add(store.Value.location);
            }
            foreach (var date in dates.AsParallel()) {
                DatesListBox.Items.Add("Week " + Convert.ToString(date.week) + ", " + Convert.ToString(date.year));
            }

            sw.Stop();
            Console.WriteLine("ListBoxes populated in " + sw.ElapsedMilliseconds / 1000.0f + " seconds.");

            ViewGraphButton.Enabled = true;
        }

        private void StoresListBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectionIndices[(int)INDICES.STORE] = StoresListBox.SelectedIndex;
            UpdateViewGraphsButton();
        }
        private void SuppliersListBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectionIndices[(int)INDICES.SUPPLIER] = SuppliersListBox.SelectedIndex;
            UpdateViewGraphsButton();
        }
        private void SupplierTypesListBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectionIndices[(int)INDICES.SUPPLIER_T] = SupplierTypesListBox.SelectedIndex;
            UpdateViewGraphsButton();
        }
        private void DatesListBox_SelectedIndexChanged(object sender, EventArgs e) {
            selectionIndices[(int)INDICES.DATE] = DatesListBox.SelectedIndex;
            UpdateViewGraphsButton();
        }

        private void StoresDeselectLabel_Click(object sender, EventArgs e) {
            StoresListBox.SelectedIndex = -1;
            UpdateViewGraphsButton();
        }
        private void SuppliersDeactivateLabel_Click(object sender, EventArgs e) {
            SuppliersListBox.SelectedIndex = -1;
            UpdateViewGraphsButton();
        }
        private void SupplierTypesDeactivateLabel_Click(object sender, EventArgs e) {
            SupplierTypesListBox.SelectedIndex = -1;
            UpdateViewGraphsButton();
        }
        private void DateDeactivateLabel_Click(object sender, EventArgs e) {
            DatesListBox.SelectedIndex = -1;
            UpdateViewGraphsButton();
        }

        void UpdateViewGraphsButton() {
            string updatedButtonText = "View orders from";
            updatedButtonText += (selectionIndices[(int)INDICES.STORE] == -1 ? 
                                            " ALL stores," : 
                                            " the " + stores.Values.ElementAt(selectionIndices[(int)INDICES.STORE]).location + " Store,");
            updatedButtonText += (selectionIndices[(int)INDICES.SUPPLIER] == -1 ? 
                                            " ALL suppliers," : 
                                            " Supplier \"" + supplierNames.ElementAt(selectionIndices[(int)INDICES.SUPPLIER]) + "\",");
            updatedButtonText += (selectionIndices[(int)INDICES.SUPPLIER_T] == -1 ? 
                                            " ALL supplier types" : 
                                            " Supplier Type \"" + supplierTypes.ElementAt(selectionIndices[(int)INDICES.SUPPLIER_T]) + "\"");
            updatedButtonText += (selectionIndices[(int)INDICES.DATE] == -1 ? 
                                            " and ALL dates" : 
                                            " from Week " + dates.ElementAt(selectionIndices[(int)INDICES.DATE]).week + ", " + dates.ElementAt(selectionIndices[(int)INDICES.DATE]).year);

            ViewGraphButton.Text = updatedButtonText;
        }

        void ClearCharts() {
            DatesChart.Series[0].Points.Clear();
            StoresChart.Series[0].Points.Clear();
            SupplierChart.Series[0].Points.Clear();
            SupplierTypesChart.Series[0].Points.Clear();
        }

        private void ViewGraphButton_Click(object sender, EventArgs e) {
            ClearCharts();
            FilteredOrdersListView.Items.Clear();
            TotalCostLabel.Text = "Total Cost: £0";

            Stopwatch sw = new Stopwatch();
            sw.Start();

            // Query all orders using PLINQ
            var parallelQuery = from num in orders.AsParallel()
                                select num;

            // Filter query by user selection. -1 means no selection so it doesn't filter for that category.
            if(selectionIndices[(int)INDICES.STORE] != -1)
                parallelQuery = parallelQuery.Where(o => o.store.code == stores.Values.ElementAt(selectionIndices[(int)INDICES.STORE]).code);
            if (selectionIndices[(int)INDICES.SUPPLIER] != -1)
                parallelQuery = parallelQuery.Where(o => o.supplierName == supplierNames.ElementAt(selectionIndices[(int)INDICES.SUPPLIER]));
            if (selectionIndices[(int)INDICES.SUPPLIER_T] != -1)
                parallelQuery = parallelQuery.Where(o => o.supplierType == supplierTypes.ElementAt(selectionIndices[(int)INDICES.SUPPLIER_T]));
            if (selectionIndices[(int)INDICES.DATE] != -1)
                parallelQuery = parallelQuery.Where(o => (o.date.week + "" + o.date.year) == dates.ElementAt(selectionIndices[(int)INDICES.DATE]).week + "" + dates.ElementAt(selectionIndices[(int)INDICES.DATE]).year);

            var queryList = parallelQuery.ToList();

            if (queryList.Count == 0) { 
                MessageBox.Show("Unable to find any orders with specified parameters", "No orders found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            sw.Stop();
            Console.WriteLine("Filtered orders using PLINQ in " + sw.ElapsedMilliseconds / 1000.0f + " seconds");

            sw.Restart();

            // Split cost into categories
            double totalCost = queryList.AsParallel().Sum(item => item.cost);
            Dictionary<string, double> graphStoresData = new Dictionary<string, double>();
            Dictionary<string, double> graphSuppliersData = new Dictionary<string, double>();
            Dictionary<string, double> graphSupplierTypesData = new Dictionary<string, double>();
            Dictionary<string, double> graphDatesData = new Dictionary<string, double>();
            List<ListViewItem> lvis = new List<ListViewItem>();
            foreach (var obj in queryList) {
                // Populate ListView
                ListViewItem lvi = new ListViewItem(obj.store.location);
                lvi.SubItems.Add(obj.supplierName);
                lvi.SubItems.Add(obj.supplierType);
                lvi.SubItems.Add("Week " + obj.date.week + ", " + obj.date.year);
                lvi.SubItems.Add("£" + obj.cost);
                lvis.Add(lvi);

                TotalCostLabel.Text = "Total Cost: £" + String.Format("{0:n}", totalCost);

                // Populate stores graph dictionary
                if (graphStoresData.ContainsKey(obj.store.code)) 
                    graphStoresData[obj.store.code] = graphStoresData[obj.store.code] + obj.cost;
                 else 
                    graphStoresData.Add(obj.store.code, obj.cost);

                // Populate suppliers graph dictionary
                if (graphSuppliersData.ContainsKey(obj.supplierName))
                    graphSuppliersData[obj.supplierName] = graphSuppliersData[obj.supplierName] + obj.cost;
                else
                    graphSuppliersData.Add(obj.supplierName, obj.cost);

                // Populate supplier type graph dictionary
                if (graphSupplierTypesData.ContainsKey(obj.supplierType))
                    graphSupplierTypesData[obj.supplierType] = graphSupplierTypesData[obj.supplierType] + obj.cost;
                else
                    graphSupplierTypesData.Add(obj.supplierType, obj.cost);

                // Populate dates graph dictionary
                if (graphDatesData.ContainsKey("W"+obj.date.week+" Y"+obj.date.year))
                    graphDatesData["W" + obj.date.week + " Y" + obj.date.year] = graphDatesData["W" + obj.date.week + " Y" + obj.date.year] + obj.cost;
                else
                    graphDatesData.Add("W" + obj.date.week + " Y" + obj.date.year, obj.cost);
            }

            // Build Stores graph
            StoresChart.Titles[0].Text = "Stores - Total Cost: £" + String.Format("{0:n}", totalCost); 
            StoresChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            foreach(var x in graphStoresData) {
                StoresChart.Series[0].Points.AddXY(x.Key, x.Value);
            }

            // Build Suppliers graph
            SupplierChart.Titles[0].Text = "Suppliers - Total Cost: £" + String.Format("{0:n}", totalCost);
            SupplierChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            foreach (var x in graphSuppliersData) {
                SupplierChart.Series[0].Points.AddXY(x.Key, x.Value);
            }

            // Build Supplier Types graph
            SupplierTypesChart.Titles[0].Text = "Supplier Types - Total Cost: £" + String.Format("{0:n}", totalCost);
            SupplierTypesChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            foreach (var x in graphSupplierTypesData) {
                SupplierTypesChart.Series[0].Points.AddXY(x.Key, x.Value);
            }

            // Build Dates graph
            DatesChart.Titles[0].Text = "Dates - Total Cost: £" + String.Format("{0:n}", totalCost);
            DatesChart.ChartAreas[0].AxisX.LabelStyle.Interval = 1;
            foreach (var x in graphDatesData) {
                DatesChart.Series[0].Points.AddXY(x.Key, x.Value);
            }

            sw.Stop();
            Console.WriteLine("Graphs built in " + sw.ElapsedMilliseconds / 1000.0f + " seconds");

            // Add filtered orders to list view
            FilteredOrdersListView.Items.AddRange(lvis.ToArray());
        }
    }
}

class Store {
    public String code;
    public String location;
}

public class Date {
    public int week;
    public int year;
}

public class DateComparer : IEqualityComparer<Date> {
    public bool Equals(Date x, Date y) {
        string combined1 = Convert.ToString(x.week) + Convert.ToString(x.year);
        string combined2 = Convert.ToString(y.week) + Convert.ToString(y.year);
        
        return combined1 == combined2;
    }

    public int GetHashCode(Date obj) {
        string combined = Convert.ToString(obj.week) + Convert.ToString(obj.year);
        
        return combined.GetHashCode();
    }
}

class Order {
    public Store store;
    public Date date;
    public string supplierName;
    public string supplierType;
    public double cost;
}
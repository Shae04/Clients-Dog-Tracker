//Select the row to have the current dog selected
namespace Dog_Tracker
{
    public partial class Form1 : Form
    {
        private List<Client> clients = new List<Client>();//creates list 
        public Form1()
        {
            InitializeComponent();

            //adds columns with headers 
            dataGridViewClients.Columns.Add("DogName", "Dog's Name");
            dataGridViewClients.Columns.Add("OwnerName", "Owner's Name");
            dataGridViewClients.Columns.Add("Address", "Address");
            dataGridViewClients.Columns.Add("BehaviorNotes", "Behavior Notes");
            dataGridViewClients.Columns.Add("TotalTimeWalked", "Total Time Walked");
        }

        private int currentRowIndex = -1;// sets current index

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            // Create and add a new Client object to the List.
            string dogName = txtDogName.Text;
            string ownerName = txtOwnerName.Text;
            string address = txtAddress.Text;
            string behaviorNotes = txtBehaviorNotes.Text;

            clients.Add(new Client(dogName, ownerName, address, behaviorNotes, 0));

            // Update the DataGridView with client information.
            dataGridViewClients.Rows.Add(dogName, ownerName, address, behaviorNotes, 0);

            // Clear the input fields
            txtDogName.Clear();
            txtOwnerName.Clear();
            txtAddress.Clear();
            txtBehaviorNotes.Clear();
        }

        private void btnAddWalkingTime_Click(object sender, EventArgs e)
        {
            // Find the selected client in the liost and update its walking time.
            int selectedRowIndex = dataGridViewClients.CurrentRow.Index;
            int walkingTimeToAdd = Convert.ToInt32(txtWalkingTime.Text);

            clients[selectedRowIndex].TotalTimeWalked += walkingTimeToAdd;//adds total walking time to time entered 

            // Update the data grid with the new walking time.
            dataGridViewClients.Rows[selectedRowIndex].Cells["TotalTimeWalked"].Value =
                clients[selectedRowIndex].TotalTimeWalked;

            // Clear the input field
            txtWalkingTime.Clear();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            int totalTimeWalkedAllDogs = clients.Sum(client => client.TotalTimeWalked);//adds the running total for all dogs 

            MessageBox.Show($"Total Time Walked for All Dogs: {totalTimeWalkedAllDogs} minutes");

            if (currentRowIndex >= 0 && currentRowIndex < clients.Count)
            {
                string currentDogName = dataGridViewClients.Rows[currentRowIndex].Cells["DogName"].Value.ToString();

                int totalTimeWalkedCurrentDog = clients
                    .Where(client => client.DogName == currentDogName)//uses LINQ to find dogname 
                    .Sum(client => client.TotalTimeWalked);//Uses LINQ to find the sum of the total time of the client

                MessageBox.Show($"Total Time Walked for {currentDogName}: {totalTimeWalkedCurrentDog} minutes");
            }
        }

        private void dataGridViewClients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Checks if a valid row is clicked.
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewClients.Rows.Count)
            {
                currentRowIndex = e.RowIndex; // Store the index of the currently selected row.
                string dogName = dataGridViewClients.Rows[e.RowIndex].Cells["DogName"].Value.ToString();
                lblCurrentDog.Text = $"Current Dog: {dogName}";
            }
        }
    }

    public class Client
    {
        public string DogName { get; set; }
        public string OwnerName { get; set; }
        public string Address { get; set; }
        public string BehaviorNotes { get; set; }
        public int TotalTimeWalked { get; set; }

        public Client(string dogName, string ownerName, string address, string behaviorNotes, int totalTimeWalked)
        {
            //declares vairables
            DogName = dogName;
            OwnerName = ownerName;
            Address = address;
            BehaviorNotes = behaviorNotes;
            TotalTimeWalked = totalTimeWalked;
        }
    }
}
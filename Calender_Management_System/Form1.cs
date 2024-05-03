using Microsoft.Extensions.Logging;
using MySqlConnector;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calender_Management_System
{
    public partial class Form1 : Form
    {
        private string connstr = "server=csitmariadb.eku.edu;uid=student;pwd=Maroon@21?;database=csc340_db;";
        public Form1()
        {
            InitializeComponent();
            Form1_Load();
        }
        private void Form1_Load()
        {
            // Set the initial visibility of panels
            LoginPg.Visible = true; // Show the first panel

        }

        private void PopulateTimeComboBoxes()
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Round current time up to the nearest 30 minutes
            currentTime = currentTime.AddMinutes(30 - currentTime.Minute % 30);

            // Generate time intervals until the end of the day
            DateTime endOfDay = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 23, 59, 59);

            while (currentTime <= endOfDay)
            {
                comboBoxStartTime.Items.Add(currentTime.ToString("H:mm"));
                currentTime = currentTime.AddMinutes(30);
                comboBoxEndTime.Items.Add(currentTime.ToString("H:mm"));
            }

            // Set default values (optional)
            comboBoxStartTime.SelectedIndex = 0;
            comboBoxEndTime.SelectedIndex = 0;
        }

        private void PopulateTimeComboBoxesForEdit()
        {
            // Get the current time
            DateTime currentTime = DateTime.Now;

            // Round current time up to the nearest 30 minutes
            currentTime = currentTime.AddMinutes(30 - currentTime.Minute % 30);

            // Generate time intervals until the end of the day
            DateTime endOfDay = new DateTime(currentTime.Year, currentTime.Month, currentTime.Day, 23, 59, 59);

            while (currentTime <= endOfDay)
            {
                comboBox2.Items.Add(currentTime.ToString("H:mm"));
                currentTime = currentTime.AddMinutes(30);
                comboBox1.Items.Add(currentTime.ToString("H:mm"));
            }

            // Set default values (optional)
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedIndex = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(connstr);
            try
            {
                conn.Open();
                //MessageBox.Show("Connected to the database!");
                // You can execute queries or other database operations here
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            string selectQuery = "SELECT username, password FROM cms_users WHERE username = @username";
            MySqlCommand cmd = new MySqlCommand(selectQuery, conn);
            cmd.Parameters.AddWithValue("@username", textBox1.Text);

            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string storedPassword = reader["password"].ToString();
                    if (storedPassword == textBox2.Text)
                    {
                        MainMenu.Visible = true;
                        LoginPg.Visible = false;

                    }
                    else
                    {
                        LoginFailed.Visible = true; // Show the first panel
                        LoginPg.Visible = false; // Hide the second panel
                    }
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginFailed.Visible = false;
            LoginPg.Visible = true;
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            LoginPg.Visible = true;
            MainMenu.Visible = false;
        }

        private void MainMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginFailed_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateEvntPg.Visible = false;
            MainMenu.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CreateEvntPg.Visible = false;
            MainMenu.Visible = true;
        }

        private void CreateEvntPg_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createEvent_Click_1(object sender, EventArgs e)
        {
            MainMenu.Visible = false;
            PopulateTimeComboBoxes();
            CreateEvntPg.Visible = true;
        }

        private void saveEvent_Click(object sender, EventArgs e)
        {
            // Get data from form fields
            string title = txtTitle.Text;
            DateTime date = datePicker.Value.Date;
            string startTime = comboBoxStartTime.SelectedItem.ToString();
            string endTime = comboBoxEndTime.SelectedItem.ToString();
            string description = txtDescription.Text;
            string priority;
            if (checkBox1.Checked)
            {
                priority = "Y";
            }
            else
            {
                priority = "N";
            }

            // Check if the specified start time and date already exist in the table
            bool conflictExists = false;
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM cms_events WHERE start_time = @StartTime AND date = @Date";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@StartTime", startTime);
                    checkCmd.Parameters.AddWithValue("@Date", date);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    conflictExists = count > 0;
                }
            }

            if (conflictExists)
            {
                CreateEvntPg.Visible = false;
                ConflictPg.Visible = true;
            }
            else
            {
                CreateEvntPg.Visible = false;
                CreateEventSuccess.Visible = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConflictPg.Visible = false;
            CreateEvntPg.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Get data from form fields
            string event_id = eventID.Text;
            string title = txtTitle.Text;
            DateTime date = datePicker.Value.Date;
            string startTime = comboBoxStartTime.SelectedItem.ToString();
            string endTime = comboBoxEndTime.SelectedItem.ToString();
            string description = txtDescription.Text;
            string priority;
            if (checkBox1.Checked)
            {
                priority = "Y";
            }
            else
            {
                priority = "N";
            }
            // Insert data into the database
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                string insertQuery = "INSERT INTO cms_events (event_id, title, date, start_time, end_time, description,priority) " +
                                     "VALUES (@Event_Id, @Title, @Date, @StartTime, @EndTime, @Description, @Priority)";
                using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Event_Id", event_id);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Date", date);
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);
                    cmd.Parameters.AddWithValue("@Description", description);
                    cmd.Parameters.AddWithValue("@Priority", priority);
                    cmd.ExecuteNonQuery();
                }
            }
            CreateEventSuccess.Visible = false;
            MainMenu.Visible = true;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            viewEventPg.Visible = false;
            showEventPg.Visible = true;
            showEventDetails();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            showEventPg.Visible = false;
            viewEventPg.Visible = true;
        }
        private void showEventDetails()
        {
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                string event_id = viewEventTxtBox.Text;
                connection.Open();
                string selectQuery = "SELECT date, start_time, end_time FROM cms_events WHERE event_id = @Event_Id";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Event_Id", event_id);

                    // Execute the query and read the result
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming you have a TextBox named txtResult to display the result
                            showEventBox.Text = $"Date: {reader["date"]}\n Start Time: {reader["start_time"]}\n End Time: {reader["end_time"]}";
                        }
                        else
                        {
                            showEventBox.Text = "No data found for the specified event ID.";
                        }
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showEventPg.Visible = false;
            MainMenu.Visible = true;
        }

        private void viewEvent_Click(object sender, EventArgs e)
        {
            viewEventPg.Visible = true;
            MainMenu.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            editEventPg.Visible = false;
            showEditPg.Visible = true;
            showEditEventDetails();
        }

        private void showEditEventDetails()
        {
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                string event_id = editEventTxtBox.Text;
                connection.Open();
                string selectQuery = "SELECT date, start_time, end_time FROM cms_events WHERE event_id = @Event_Id";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Event_Id", event_id);

                    // Execute the query and read the result
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming you have a TextBox named txtResult to display the result
                            textBox3.Text = $"Date: {reader["date"]}\n Start Time: {reader["start_time"]}\n End Time: {reader["end_time"]}";
                        }
                        else
                        {
                            textBox3.Text = "No data found for the specified event ID.";
                        }
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            showEditPg.Visible = false;
            editEventConfPg.Visible = true;
            PopulateTimeComboBoxesForEdit();
        }

        private void editEvent_Click(object sender, EventArgs e)
        {
            editEventPg.Visible = true;
            MainMenu.Visible = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            showEditPg.Visible = true;
            editEventConfPg.Visible = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            editEventConfPg.Visible = false;
            MainMenu.Visible = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            string event_id = editEventTxtBox.Text;
            string title = textBox5.Text;
            DateTime date = dateTimePicker1.Value.Date;
            string startTime = comboBox2.SelectedItem.ToString();
            string endTime = comboBox1.SelectedItem.ToString();
            string description = textBox4.Text;
            string priority;
            if (checkBox2.Checked)
            {
                priority = "Y";
            }
            else
            {
                priority = "N";
            }
            // Check if the specified start time and date already exist in the table
            bool conflictExists = false;
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                string checkQuery = "SELECT COUNT(*) FROM cms_events WHERE start_time = @StartTime AND date = @Date";
                using (MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@StartTime", startTime);
                    checkCmd.Parameters.AddWithValue("@Date", date);
                    int count = Convert.ToInt32(checkCmd.ExecuteScalar());
                    conflictExists = count > 0;
                }
            }

            if (conflictExists)
            {
                ConflictPg.Visible = true;
                editEventConfPg.Visible = false;
            }
            else
            {
                // Insert data into the database
                using (MySqlConnection connection = new MySqlConnection(connstr))
                {
                    connection.Open();
                    string insertQuery = "UPDATE cms_events SET title=@Title, date=@Date, start_time=@StartTime, end_time=@EndTime, description=@Description where event_id=@Event_id;";
                    using (MySqlCommand cmd = new MySqlCommand(insertQuery, connection))
                    {
                        cmd.Parameters.AddWithValue("@Event_Id", event_id);
                        cmd.Parameters.AddWithValue("@Title", title);
                        cmd.Parameters.AddWithValue("@Date", date);
                        cmd.Parameters.AddWithValue("@StartTime", startTime);
                        cmd.Parameters.AddWithValue("@EndTime", endTime);
                        cmd.Parameters.AddWithValue("@Description", description);
                        cmd.Parameters.AddWithValue("@Priority", priority);
                        cmd.ExecuteNonQuery();
                    }
                }
                editEventConfPg.Visible = false;
                MainMenu.Visible = true;
            }
        }

        private void deleteEvent_Click(object sender, EventArgs e)
        {
            MainMenu.Visible = false;
            deleteEventPg.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            selectDeleteEventPg.Visible = true;
            deleteEventPg.Visible = false;
            string event_id = deleteEventTxtBox.Text;
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                string selectQuery = "SELECT date, start_time, end_time FROM cms_events WHERE event_id = @Event_Id";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Event_Id", event_id);

                    // Execute the query and read the result
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Assuming you have a TextBox named txtResult to display the result
                            showDeleteEventBox.Text = $"Date: {reader["date"]}\n Start Time: {reader["start_time"]}\n End Time: {reader["end_time"]}";
                        }
                        else
                        {
                            showDeleteEventBox.Text = "No data found for the specified event ID.";
                        }
                    }
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            deletedPg.Visible = true;
            selectDeleteEventPg.Visible = false;
            string event_id = deleteEventTxtBox.Text;
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM cms_events WHERE event_id = @Event_Id;";
                using (MySqlCommand cmd = new MySqlCommand(deleteQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Event_Id", event_id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            deletedPg.Visible = false;
            MainMenu.Visible = true;
        }

        private void eventList_Click(object sender, EventArgs e)
        {
            MainMenu.Visible = false;
            eventListPg.Visible = true;
        }

        private void viewEventList_Click(object sender, EventArgs e)
        {
            eventListPg.Visible = false;
            showEventList.Visible = true;
            DateTime date = dateTimePicker2.Value.Date;
            using (MySqlConnection connection = new MySqlConnection(connstr))
            {
                connection.Open();
                string selectQuery = "SELECT date, start_time, end_time FROM cms_events WHERE date = @Date";
                using (MySqlCommand cmd = new MySqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Date", date);

                    // Execute the query and read the result
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Initialize a StringBuilder to store all event information
                            StringBuilder eventInfo = new StringBuilder();

                            while (reader.Read())
                            {
                                string eventDate = reader["date"].ToString();
                                string startTime = reader["start_time"].ToString();
                                string endTime = reader["end_time"].ToString();

                                // Append event information to the StringBuilder
                                eventInfo.AppendLine($"Date: {eventDate}, Start Time: {startTime}, End Time: {endTime}");
                            }

                            // Assuming you have a TextBox named eventdisplay to display the result
                            textBox6.Text = eventInfo.ToString();
                        }
                        else
                        {
                            textBox6.Text = "No data found for the specified event ID.";
                        }
                    }
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu.Visible = true;
            showEventList.Visible = false;
        }
    }
}


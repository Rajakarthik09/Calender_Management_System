namespace Calender_Management_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginFailed = new Panel();
            button2 = new Button();
            label4 = new Label();
            MainMenu = new Panel();
            logOut = new Button();
            deleteEvent = new Button();
            eventList = new Button();
            editEvent = new Button();
            viewEvent = new Button();
            createEvent = new Button();
            monthCalendar1 = new MonthCalendar();
            LoginPg = new Panel();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            CreateEvntPg = new Panel();
            checkBox1 = new CheckBox();
            button5 = new Button();
            saveEvent = new Button();
            button3 = new Button();
            txtDescription = new TextBox();
            label6 = new Label();
            comboBoxEndTime = new ComboBox();
            label5 = new Label();
            comboBoxStartTime = new ComboBox();
            label1 = new Label();
            datePicker = new DateTimePicker();
            label8 = new Label();
            txtTitle = new TextBox();
            label9 = new Label();
            ConflictPg = new Panel();
            button4 = new Button();
            label7 = new Label();
            CreateEventSuccess = new Panel();
            button6 = new Button();
            eventID = new TextBox();
            label10 = new Label();
            viewEventPg = new Panel();
            viewEventTxtBox = new TextBox();
            button7 = new Button();
            label11 = new Label();
            showEventPg = new Panel();
            button9 = new Button();
            button8 = new Button();
            showEventBox = new TextBox();
            label12 = new Label();
            editEventPg = new Panel();
            button10 = new Button();
            editEventTxtBox = new TextBox();
            label13 = new Label();
            showEditPg = new Panel();
            button11 = new Button();
            textBox3 = new TextBox();
            label14 = new Label();
            editEventConfPg = new Panel();
            checkBox2 = new CheckBox();
            button14 = new Button();
            button13 = new Button();
            button12 = new Button();
            textBox4 = new TextBox();
            label15 = new Label();
            comboBox1 = new ComboBox();
            label16 = new Label();
            comboBox2 = new ComboBox();
            label17 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label19 = new Label();
            textBox5 = new TextBox();
            label20 = new Label();
            deleteEventPg = new Panel();
            button15 = new Button();
            deleteEventTxtBox = new TextBox();
            label18 = new Label();
            selectDeleteEventPg = new Panel();
            button16 = new Button();
            showDeleteEventBox = new TextBox();
            label21 = new Label();
            deletedPg = new Panel();
            button17 = new Button();
            label22 = new Label();
            showEventList = new Panel();
            button18 = new Button();
            textBox6 = new TextBox();
            label24 = new Label();
            eventListPg = new Panel();
            viewEventList = new Button();
            dateTimePicker2 = new DateTimePicker();
            label23 = new Label();
            LoginFailed.SuspendLayout();
            MainMenu.SuspendLayout();
            LoginPg.SuspendLayout();
            CreateEvntPg.SuspendLayout();
            ConflictPg.SuspendLayout();
            CreateEventSuccess.SuspendLayout();
            viewEventPg.SuspendLayout();
            showEventPg.SuspendLayout();
            editEventPg.SuspendLayout();
            showEditPg.SuspendLayout();
            editEventConfPg.SuspendLayout();
            deleteEventPg.SuspendLayout();
            selectDeleteEventPg.SuspendLayout();
            deletedPg.SuspendLayout();
            showEventList.SuspendLayout();
            eventListPg.SuspendLayout();
            SuspendLayout();
            // 
            // LoginFailed
            // 
            LoginFailed.BackColor = SystemColors.AppWorkspace;
            LoginFailed.Controls.Add(button2);
            LoginFailed.Controls.Add(label4);
            LoginFailed.Font = new Font("Segoe UI", 10F);
            LoginFailed.Location = new Point(10, 10);
            LoginFailed.Margin = new Padding(3, 2, 3, 2);
            LoginFailed.Name = "LoginFailed";
            LoginFailed.Size = new Size(654, 360);
            LoginFailed.TabIndex = 0;
            LoginFailed.Visible = false;
            LoginFailed.Paint += LoginFailed_Paint;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(283, 208);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(110, 52);
            button2.TabIndex = 7;
            button2.Text = "Try Again";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(200, 110);
            label4.Name = "label4";
            label4.Size = new Size(284, 50);
            label4.TabIndex = 6;
            label4.Text = "Authentication Error \r\nIncorrect Username or Password";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // MainMenu
            // 
            MainMenu.BackColor = SystemColors.AppWorkspace;
            MainMenu.Controls.Add(logOut);
            MainMenu.Controls.Add(deleteEvent);
            MainMenu.Controls.Add(eventList);
            MainMenu.Controls.Add(editEvent);
            MainMenu.Controls.Add(viewEvent);
            MainMenu.Controls.Add(createEvent);
            MainMenu.Controls.Add(monthCalendar1);
            MainMenu.Location = new Point(10, 9);
            MainMenu.Margin = new Padding(3, 2, 3, 2);
            MainMenu.Name = "MainMenu";
            MainMenu.Size = new Size(649, 358);
            MainMenu.TabIndex = 8;
            MainMenu.Visible = false;
            MainMenu.Paint += MainMenu_Paint;
            // 
            // logOut
            // 
            logOut.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logOut.Location = new Point(530, 294);
            logOut.Margin = new Padding(3, 2, 3, 2);
            logOut.Name = "logOut";
            logOut.Size = new Size(111, 32);
            logOut.TabIndex = 6;
            logOut.Text = "LOGOUT";
            logOut.UseVisualStyleBackColor = true;
            logOut.Click += logOut_Click;
            // 
            // deleteEvent
            // 
            deleteEvent.Location = new Point(380, 244);
            deleteEvent.Margin = new Padding(3, 2, 3, 2);
            deleteEvent.Name = "deleteEvent";
            deleteEvent.Size = new Size(159, 32);
            deleteEvent.TabIndex = 5;
            deleteEvent.Text = "Delete Event";
            deleteEvent.UseVisualStyleBackColor = true;
            deleteEvent.Click += deleteEvent_Click;
            // 
            // eventList
            // 
            eventList.Location = new Point(380, 197);
            eventList.Margin = new Padding(3, 2, 3, 2);
            eventList.Name = "eventList";
            eventList.Size = new Size(159, 32);
            eventList.TabIndex = 4;
            eventList.Text = "View Event List";
            eventList.UseVisualStyleBackColor = true;
            eventList.Click += eventList_Click;
            // 
            // editEvent
            // 
            editEvent.Location = new Point(380, 150);
            editEvent.Margin = new Padding(3, 2, 3, 2);
            editEvent.Name = "editEvent";
            editEvent.Size = new Size(159, 32);
            editEvent.TabIndex = 3;
            editEvent.Text = "Edit Event";
            editEvent.UseVisualStyleBackColor = true;
            editEvent.Click += editEvent_Click;
            // 
            // viewEvent
            // 
            viewEvent.Location = new Point(380, 100);
            viewEvent.Margin = new Padding(3, 2, 3, 2);
            viewEvent.Name = "viewEvent";
            viewEvent.Size = new Size(159, 32);
            viewEvent.TabIndex = 2;
            viewEvent.Text = "View Event";
            viewEvent.UseVisualStyleBackColor = true;
            viewEvent.Click += viewEvent_Click;
            // 
            // createEvent
            // 
            createEvent.Location = new Point(380, 56);
            createEvent.Margin = new Padding(3, 2, 3, 2);
            createEvent.Name = "createEvent";
            createEvent.Size = new Size(159, 32);
            createEvent.TabIndex = 1;
            createEvent.Text = "Create Event";
            createEvent.UseVisualStyleBackColor = true;
            createEvent.Click += createEvent_Click_1;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            monthCalendar1.Location = new Point(36, 98);
            monthCalendar1.Margin = new Padding(8, 7, 8, 7);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // LoginPg
            // 
            LoginPg.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginPg.BackColor = SystemColors.AppWorkspace;
            LoginPg.Controls.Add(button1);
            LoginPg.Controls.Add(textBox2);
            LoginPg.Controls.Add(textBox1);
            LoginPg.Controls.Add(label3);
            LoginPg.Controls.Add(label2);
            LoginPg.Location = new Point(10, 9);
            LoginPg.Margin = new Padding(3, 2, 3, 2);
            LoginPg.Name = "LoginPg";
            LoginPg.Size = new Size(654, 361);
            LoginPg.TabIndex = 6;
            // 
            // button1
            // 
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(292, 210);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(103, 33);
            button1.TabIndex = 5;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(295, 138);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(204, 23);
            textBox2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(295, 93);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(204, 23);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(159, 136);
            label3.Name = "label3";
            label3.Size = new Size(97, 21);
            label3.TabIndex = 2;
            label3.Text = "PASSWORD:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(161, 93);
            label2.Name = "label2";
            label2.Size = new Size(95, 21);
            label2.TabIndex = 1;
            label2.Text = "USERNAME:";
            // 
            // CreateEvntPg
            // 
            CreateEvntPg.BackColor = SystemColors.AppWorkspace;
            CreateEvntPg.Controls.Add(checkBox1);
            CreateEvntPg.Controls.Add(button5);
            CreateEvntPg.Controls.Add(saveEvent);
            CreateEvntPg.Controls.Add(button3);
            CreateEvntPg.Controls.Add(txtDescription);
            CreateEvntPg.Controls.Add(label6);
            CreateEvntPg.Controls.Add(comboBoxEndTime);
            CreateEvntPg.Controls.Add(label5);
            CreateEvntPg.Controls.Add(comboBoxStartTime);
            CreateEvntPg.Controls.Add(label1);
            CreateEvntPg.Controls.Add(datePicker);
            CreateEvntPg.Controls.Add(label8);
            CreateEvntPg.Controls.Add(txtTitle);
            CreateEvntPg.Controls.Add(label9);
            CreateEvntPg.Location = new Point(10, 9);
            CreateEvntPg.Margin = new Padding(3, 2, 3, 2);
            CreateEvntPg.Name = "CreateEvntPg";
            CreateEvntPg.Size = new Size(654, 361);
            CreateEvntPg.TabIndex = 9;
            CreateEvntPg.Visible = false;
            CreateEvntPg.Paint += CreateEvntPg_Paint;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.Location = new Point(235, 280);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(103, 19);
            checkBox1.TabIndex = 25;
            checkBox1.Text = "Set as Priority";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(36, 314);
            button5.Margin = new Padding(3, 2, 3, 2);
            button5.Name = "button5";
            button5.Size = new Size(113, 28);
            button5.TabIndex = 24;
            button5.Text = "CANCEL";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // saveEvent
            // 
            saveEvent.Location = new Point(257, 314);
            saveEvent.Margin = new Padding(3, 2, 3, 2);
            saveEvent.Name = "saveEvent";
            saveEvent.Size = new Size(113, 28);
            saveEvent.TabIndex = 23;
            saveEvent.Text = "SAVE EVENT";
            saveEvent.UseVisualStyleBackColor = true;
            saveEvent.Click += saveEvent_Click;
            // 
            // button3
            // 
            button3.Location = new Point(482, 314);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(113, 28);
            button3.TabIndex = 22;
            button3.Text = "BACK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(235, 182);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(280, 88);
            txtDescription.TabIndex = 21;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(136, 184);
            label6.Name = "label6";
            label6.Size = new Size(89, 19);
            label6.TabIndex = 20;
            label6.Text = "Description:";
            // 
            // comboBoxEndTime
            // 
            comboBoxEndTime.FormattingEnabled = true;
            comboBoxEndTime.Location = new Point(235, 136);
            comboBoxEndTime.Margin = new Padding(3, 2, 3, 2);
            comboBoxEndTime.Name = "comboBoxEndTime";
            comboBoxEndTime.Size = new Size(123, 23);
            comboBoxEndTime.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(191, 138);
            label5.Name = "label5";
            label5.Size = new Size(37, 19);
            label5.TabIndex = 18;
            label5.Text = "End:";
            // 
            // comboBoxStartTime
            // 
            comboBoxStartTime.FormattingEnabled = true;
            comboBoxStartTime.Location = new Point(235, 92);
            comboBoxStartTime.Margin = new Padding(3, 2, 3, 2);
            comboBoxStartTime.Name = "comboBoxStartTime";
            comboBoxStartTime.Size = new Size(123, 23);
            comboBoxStartTime.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(182, 94);
            label1.Name = "label1";
            label1.Size = new Size(45, 19);
            label1.TabIndex = 16;
            label1.Text = "Start:";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(235, 58);
            datePicker.Margin = new Padding(3, 2, 3, 2);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(157, 23);
            datePicker.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(144, 60);
            label8.Name = "label8";
            label8.Size = new Size(81, 19);
            label8.TabIndex = 13;
            label8.Text = "Date Time:";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(235, 20);
            txtTitle.Margin = new Padding(3, 2, 3, 2);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(284, 23);
            txtTitle.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(133, 20);
            label9.Name = "label9";
            label9.Size = new Size(93, 19);
            label9.TabIndex = 11;
            label9.Text = "Event Name:";
            // 
            // ConflictPg
            // 
            ConflictPg.BackColor = SystemColors.AppWorkspace;
            ConflictPg.Controls.Add(button4);
            ConflictPg.Controls.Add(label7);
            ConflictPg.Location = new Point(10, 8);
            ConflictPg.Margin = new Padding(3, 2, 3, 2);
            ConflictPg.Name = "ConflictPg";
            ConflictPg.Size = new Size(654, 359);
            ConflictPg.TabIndex = 10;
            ConflictPg.Visible = false;
            // 
            // button4
            // 
            button4.Location = new Point(253, 204);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(117, 40);
            button4.TabIndex = 1;
            button4.Text = "BACK";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(99, 72);
            label7.Name = "label7";
            label7.Size = new Size(406, 64);
            label7.TabIndex = 0;
            label7.Text = "Error\r\nEvent Conflicts with another Event";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // CreateEventSuccess
            // 
            CreateEventSuccess.BackColor = SystemColors.AppWorkspace;
            CreateEventSuccess.Controls.Add(button6);
            CreateEventSuccess.Controls.Add(eventID);
            CreateEventSuccess.Controls.Add(label10);
            CreateEventSuccess.Location = new Point(10, 8);
            CreateEventSuccess.Margin = new Padding(3, 2, 3, 2);
            CreateEventSuccess.Name = "CreateEventSuccess";
            CreateEventSuccess.Size = new Size(654, 362);
            CreateEventSuccess.TabIndex = 11;
            CreateEventSuccess.Visible = false;
            // 
            // button6
            // 
            button6.Location = new Point(245, 227);
            button6.Margin = new Padding(3, 2, 3, 2);
            button6.Name = "button6";
            button6.Size = new Size(113, 34);
            button6.TabIndex = 2;
            button6.Text = "OK";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // eventID
            // 
            eventID.Location = new Point(191, 159);
            eventID.Margin = new Padding(3, 2, 3, 2);
            eventID.Name = "eventID";
            eventID.Size = new Size(224, 23);
            eventID.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(46, 57);
            label10.Name = "label10";
            label10.Size = new Size(507, 64);
            label10.TabIndex = 0;
            label10.Text = "Event Added Successfully...!\r\nSave this Event With An Unique ID Number";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // viewEventPg
            // 
            viewEventPg.BackColor = SystemColors.AppWorkspace;
            viewEventPg.Controls.Add(viewEventTxtBox);
            viewEventPg.Controls.Add(button7);
            viewEventPg.Controls.Add(label11);
            viewEventPg.Location = new Point(10, 6);
            viewEventPg.Margin = new Padding(3, 2, 3, 2);
            viewEventPg.Name = "viewEventPg";
            viewEventPg.Size = new Size(654, 364);
            viewEventPg.TabIndex = 12;
            viewEventPg.Visible = false;
            // 
            // viewEventTxtBox
            // 
            viewEventTxtBox.Location = new Point(200, 163);
            viewEventTxtBox.Margin = new Padding(3, 2, 3, 2);
            viewEventTxtBox.Name = "viewEventTxtBox";
            viewEventTxtBox.Size = new Size(241, 23);
            viewEventTxtBox.TabIndex = 2;
            // 
            // button7
            // 
            button7.Location = new Point(252, 229);
            button7.Margin = new Padding(3, 2, 3, 2);
            button7.Name = "button7";
            button7.Size = new Size(122, 36);
            button7.TabIndex = 1;
            button7.Text = "VIEW EVENT";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(68, 52);
            label11.Name = "label11";
            label11.Size = new Size(465, 64);
            label11.TabIndex = 0;
            label11.Text = "Please Enter The Unique ID Number To \r\nView Event";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // showEventPg
            // 
            showEventPg.BackColor = SystemColors.AppWorkspace;
            showEventPg.Controls.Add(button9);
            showEventPg.Controls.Add(button8);
            showEventPg.Controls.Add(showEventBox);
            showEventPg.Controls.Add(label12);
            showEventPg.Location = new Point(10, 6);
            showEventPg.Name = "showEventPg";
            showEventPg.Size = new Size(654, 364);
            showEventPg.TabIndex = 13;
            showEventPg.Visible = false;
            // 
            // button9
            // 
            button9.Location = new Point(133, 272);
            button9.Name = "button9";
            button9.Size = new Size(107, 38);
            button9.TabIndex = 3;
            button9.Text = "BACK";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.Location = new Point(408, 272);
            button8.Name = "button8";
            button8.Size = new Size(107, 38);
            button8.TabIndex = 2;
            button8.Text = "DONE";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // showEventBox
            // 
            showEventBox.Location = new Point(191, 126);
            showEventBox.Multiline = true;
            showEventBox.Name = "showEventBox";
            showEventBox.Size = new Size(250, 106);
            showEventBox.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(235, 74);
            label12.Name = "label12";
            label12.Size = new Size(162, 32);
            label12.TabIndex = 0;
            label12.Text = "Event Details";
            // 
            // editEventPg
            // 
            editEventPg.BackColor = SystemColors.AppWorkspace;
            editEventPg.Controls.Add(button10);
            editEventPg.Controls.Add(editEventTxtBox);
            editEventPg.Controls.Add(label13);
            editEventPg.Location = new Point(10, 6);
            editEventPg.Name = "editEventPg";
            editEventPg.Size = new Size(654, 364);
            editEventPg.TabIndex = 14;
            editEventPg.Visible = false;
            // 
            // button10
            // 
            button10.Location = new Point(266, 238);
            button10.Name = "button10";
            button10.Size = new Size(108, 34);
            button10.TabIndex = 2;
            button10.Text = "VIEW EVENT";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // editEventTxtBox
            // 
            editEventTxtBox.Location = new Point(200, 153);
            editEventTxtBox.Multiline = true;
            editEventTxtBox.Name = "editEventTxtBox";
            editEventTxtBox.Size = new Size(250, 42);
            editEventTxtBox.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(99, 63);
            label13.Name = "label13";
            label13.Size = new Size(458, 64);
            label13.TabIndex = 0;
            label13.Text = "Please Enter The Unique ID Number To\r\nEdit Event";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // showEditPg
            // 
            showEditPg.BackColor = SystemColors.AppWorkspace;
            showEditPg.Controls.Add(button11);
            showEditPg.Controls.Add(textBox3);
            showEditPg.Controls.Add(label14);
            showEditPg.Location = new Point(10, 6);
            showEditPg.Name = "showEditPg";
            showEditPg.Size = new Size(654, 364);
            showEditPg.TabIndex = 15;
            showEditPg.Visible = false;
            // 
            // button11
            // 
            button11.Location = new Point(265, 251);
            button11.Name = "button11";
            button11.Size = new Size(93, 34);
            button11.TabIndex = 2;
            button11.Text = "EDIT";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(176, 119);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(269, 88);
            textBox3.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(73, 59);
            label14.Name = "label14";
            label14.Size = new Size(484, 32);
            label14.TabIndex = 0;
            label14.Text = "Choose The Event You Would Like To Edit";
            // 
            // editEventConfPg
            // 
            editEventConfPg.BackColor = SystemColors.AppWorkspace;
            editEventConfPg.Controls.Add(checkBox2);
            editEventConfPg.Controls.Add(button14);
            editEventConfPg.Controls.Add(button13);
            editEventConfPg.Controls.Add(button12);
            editEventConfPg.Controls.Add(textBox4);
            editEventConfPg.Controls.Add(label15);
            editEventConfPg.Controls.Add(comboBox1);
            editEventConfPg.Controls.Add(label16);
            editEventConfPg.Controls.Add(comboBox2);
            editEventConfPg.Controls.Add(label17);
            editEventConfPg.Controls.Add(dateTimePicker1);
            editEventConfPg.Controls.Add(label19);
            editEventConfPg.Controls.Add(textBox5);
            editEventConfPg.Controls.Add(label20);
            editEventConfPg.Location = new Point(10, 6);
            editEventConfPg.Name = "editEventConfPg";
            editEventConfPg.Size = new Size(654, 364);
            editEventConfPg.TabIndex = 16;
            editEventConfPg.Visible = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(235, 247);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(97, 19);
            checkBox2.TabIndex = 38;
            checkBox2.Text = "Set as Priority";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            button14.BackColor = Color.White;
            button14.Location = new Point(454, 291);
            button14.Name = "button14";
            button14.Size = new Size(141, 38);
            button14.TabIndex = 37;
            button14.Text = "BACK";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.White;
            button13.Location = new Point(36, 291);
            button13.Name = "button13";
            button13.Size = new Size(141, 38);
            button13.TabIndex = 36;
            button13.Text = "CANCEL";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button12
            // 
            button12.BackColor = Color.White;
            button12.Location = new Point(251, 291);
            button12.Name = "button12";
            button12.Size = new Size(141, 38);
            button12.TabIndex = 35;
            button12.Text = "SAVE EVENT";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(235, 177);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(319, 47);
            textBox4.TabIndex = 34;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(131, 185);
            label15.Name = "label15";
            label15.Size = new Size(89, 19);
            label15.TabIndex = 33;
            label15.Text = "Description:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 32;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(185, 139);
            label16.Name = "label16";
            label16.Size = new Size(37, 19);
            label16.TabIndex = 31;
            label16.Text = "End:";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(236, 99);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(140, 23);
            comboBox2.TabIndex = 30;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(175, 102);
            label17.Name = "label17";
            label17.Size = new Size(45, 19);
            label17.TabIndex = 29;
            label17.Text = "Start:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(235, 63);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(179, 23);
            dateTimePicker1.TabIndex = 27;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(176, 69);
            label19.Name = "label19";
            label19.Size = new Size(44, 19);
            label19.TabIndex = 26;
            label19.Text = "Date:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(235, 23);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(324, 23);
            textBox5.TabIndex = 25;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(147, 27);
            label20.Name = "label20";
            label20.Size = new Size(74, 19);
            label20.TabIndex = 24;
            label20.Text = "Add Title:";
            // 
            // deleteEventPg
            // 
            deleteEventPg.BackColor = SystemColors.AppWorkspace;
            deleteEventPg.Controls.Add(button15);
            deleteEventPg.Controls.Add(deleteEventTxtBox);
            deleteEventPg.Controls.Add(label18);
            deleteEventPg.Location = new Point(10, 6);
            deleteEventPg.Name = "deleteEventPg";
            deleteEventPg.Size = new Size(654, 365);
            deleteEventPg.TabIndex = 17;
            deleteEventPg.Visible = false;
            // 
            // button15
            // 
            button15.Location = new Point(266, 252);
            button15.Name = "button15";
            button15.Size = new Size(93, 40);
            button15.TabIndex = 2;
            button15.Text = "VIEW EVENT";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // deleteEventTxtBox
            // 
            deleteEventTxtBox.Location = new Point(176, 141);
            deleteEventTxtBox.Multiline = true;
            deleteEventTxtBox.Name = "deleteEventTxtBox";
            deleteEventTxtBox.Size = new Size(275, 85);
            deleteEventTxtBox.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(147, 60);
            label18.Name = "label18";
            label18.Size = new Size(348, 64);
            label18.TabIndex = 0;
            label18.Text = "Enter The Unique Event ID To\r\nDelete Event";
            label18.TextAlign = ContentAlignment.TopCenter;
            // 
            // selectDeleteEventPg
            // 
            selectDeleteEventPg.BackColor = SystemColors.AppWorkspace;
            selectDeleteEventPg.Controls.Add(button16);
            selectDeleteEventPg.Controls.Add(showDeleteEventBox);
            selectDeleteEventPg.Controls.Add(label21);
            selectDeleteEventPg.Location = new Point(10, 6);
            selectDeleteEventPg.Name = "selectDeleteEventPg";
            selectDeleteEventPg.Size = new Size(654, 365);
            selectDeleteEventPg.TabIndex = 18;
            selectDeleteEventPg.Visible = false;
            // 
            // button16
            // 
            button16.Location = new Point(279, 248);
            button16.Name = "button16";
            button16.Size = new Size(91, 38);
            button16.TabIndex = 2;
            button16.Text = "DELETE";
            button16.UseVisualStyleBackColor = true;
            button16.Click += button16_Click;
            // 
            // showDeleteEventBox
            // 
            showDeleteEventBox.Location = new Point(200, 121);
            showDeleteEventBox.Multiline = true;
            showDeleteEventBox.Name = "showDeleteEventBox";
            showDeleteEventBox.Size = new Size(251, 104);
            showDeleteEventBox.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label21.Location = new Point(163, 66);
            label21.Name = "label21";
            label21.Size = new Size(356, 32);
            label21.TabIndex = 0;
            label21.Text = "SELECT THE EVENT TO DELETE";
            // 
            // deletedPg
            // 
            deletedPg.BackColor = SystemColors.AppWorkspace;
            deletedPg.Controls.Add(button17);
            deletedPg.Controls.Add(label22);
            deletedPg.Location = new Point(10, 6);
            deletedPg.Name = "deletedPg";
            deletedPg.Size = new Size(654, 365);
            deletedPg.TabIndex = 19;
            deletedPg.Visible = false;
            // 
            // button17
            // 
            button17.Location = new Point(253, 178);
            button17.Name = "button17";
            button17.Size = new Size(105, 41);
            button17.TabIndex = 1;
            button17.Text = "Okay";
            button17.UseVisualStyleBackColor = true;
            button17.Click += button17_Click;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label22.Location = new Point(113, 75);
            label22.Name = "label22";
            label22.Size = new Size(426, 32);
            label22.TabIndex = 0;
            label22.Text = "The Event Is Permanently Deleted...!";
            // 
            // showEventList
            // 
            showEventList.BackColor = SystemColors.AppWorkspace;
            showEventList.Controls.Add(button18);
            showEventList.Controls.Add(textBox6);
            showEventList.Controls.Add(label24);
            showEventList.Location = new Point(10, 6);
            showEventList.Name = "showEventList";
            showEventList.Size = new Size(654, 362);
            showEventList.TabIndex = 19;
            showEventList.Visible = false;
            // 
            // button18
            // 
            button18.Location = new Point(251, 284);
            button18.Name = "button18";
            button18.Size = new Size(109, 38);
            button18.TabIndex = 2;
            button18.Text = "DONE";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button18_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(144, 110);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(351, 154);
            textBox6.TabIndex = 1;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label24.Location = new Point(185, 57);
            label24.Name = "label24";
            label24.Size = new Size(265, 32);
            label24.TabIndex = 0;
            label24.Text = "Monthly Based Events";
            // 
            // eventListPg
            // 
            eventListPg.BackColor = SystemColors.AppWorkspace;
            eventListPg.Controls.Add(viewEventList);
            eventListPg.Controls.Add(dateTimePicker2);
            eventListPg.Controls.Add(label23);
            eventListPg.Location = new Point(10, 6);
            eventListPg.Name = "eventListPg";
            eventListPg.Size = new Size(654, 364);
            eventListPg.TabIndex = 19;
            eventListPg.Visible = false;
            // 
            // viewEventList
            // 
            viewEventList.Location = new Point(245, 193);
            viewEventList.Name = "viewEventList";
            viewEventList.Size = new Size(125, 31);
            viewEventList.TabIndex = 2;
            viewEventList.Text = "VIEW EVENT LIST";
            viewEventList.UseVisualStyleBackColor = true;
            viewEventList.Click += viewEventList_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(190, 116);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(251, 23);
            dateTimePicker2.TabIndex = 1;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(82, 52);
            label23.Name = "label23";
            label23.Size = new Size(492, 32);
            label23.TabIndex = 0;
            label23.Text = "Enter The Month And Year To View Events";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 379);
            Controls.Add(deletedPg);
            Controls.Add(eventListPg);
            Controls.Add(showEventList);
            Controls.Add(selectDeleteEventPg);
            Controls.Add(deleteEventPg);
            Controls.Add(editEventConfPg);
            Controls.Add(showEditPg);
            Controls.Add(editEventPg);
            Controls.Add(showEventPg);
            Controls.Add(viewEventPg);
            Controls.Add(CreateEventSuccess);
            Controls.Add(ConflictPg);
            Controls.Add(CreateEvntPg);
            Controls.Add(LoginFailed);
            Controls.Add(MainMenu);
            Controls.Add(LoginPg);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            LoginFailed.ResumeLayout(false);
            LoginFailed.PerformLayout();
            MainMenu.ResumeLayout(false);
            LoginPg.ResumeLayout(false);
            LoginPg.PerformLayout();
            CreateEvntPg.ResumeLayout(false);
            CreateEvntPg.PerformLayout();
            ConflictPg.ResumeLayout(false);
            ConflictPg.PerformLayout();
            CreateEventSuccess.ResumeLayout(false);
            CreateEventSuccess.PerformLayout();
            viewEventPg.ResumeLayout(false);
            viewEventPg.PerformLayout();
            showEventPg.ResumeLayout(false);
            showEventPg.PerformLayout();
            editEventPg.ResumeLayout(false);
            editEventPg.PerformLayout();
            showEditPg.ResumeLayout(false);
            showEditPg.PerformLayout();
            editEventConfPg.ResumeLayout(false);
            editEventConfPg.PerformLayout();
            deleteEventPg.ResumeLayout(false);
            deleteEventPg.PerformLayout();
            selectDeleteEventPg.ResumeLayout(false);
            selectDeleteEventPg.PerformLayout();
            deletedPg.ResumeLayout(false);
            deletedPg.PerformLayout();
            showEventList.ResumeLayout(false);
            showEventList.PerformLayout();
            eventListPg.ResumeLayout(false);
            eventListPg.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel LoginFailed;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Button button1;
        private Panel LoginPg;
        private Button button2;
        private Label label4;
        private Panel MainMenu;
        private Button eventList;
        private Button editEvent;
        private Button viewEvent;
        private Button createEvent;
        private MonthCalendar monthCalendar1;
        private Button logOut;
        private Button deleteEvent;
        private Panel CreateEvntPg;
        private Button button3;
        private TextBox txtDescription;
        private Label label6;
        private ComboBox comboBoxEndTime;
        private Label label5;
        private ComboBox comboBoxStartTime;
        private Label label1;
        private DateTimePicker datePicker;
        private Label label8;
        private TextBox txtTitle;
        private Label label9;
        private Button button5;
        private Button saveEvent;
        private CheckBox checkBox1;
        private Panel ConflictPg;
        private Button button4;
        private Label label7;
        private Panel CreateEventSuccess;
        private Label label10;
        private Button button6;
        private TextBox eventID;
        private Panel viewEventPg;
        private Button button7;
        private Label label11;
        private TextBox viewEventTxtBox;
        private Panel showEventPg;
        private Button button9;
        private Button button8;
        private TextBox showEventBox;
        private Label label12;
        private Panel editEventPg;
        private Button button10;
        private TextBox editEventTxtBox;
        private Label label13;
        private Panel showEditPg;
        private Button button11;
        private TextBox textBox3;
        private Label label14;
        private Panel editEventConfPg;
        private Button button12;
        private TextBox textBox4;
        private Label label15;
        private ComboBox comboBox1;
        private Label label16;
        private ComboBox comboBox2;
        private Label label17;
        private DateTimePicker dateTimePicker1;
        private Label label19;
        private TextBox textBox5;
        private Label label20;
        private Button button14;
        private Button button13;
        private CheckBox checkBox2;
        private Panel deleteEventPg;
        private Label label18;
        private TextBox deleteEventTxtBox;
        private Button button15;
        private Panel selectDeleteEventPg;
        private Button button16;
        private TextBox showDeleteEventBox;
        private Label label21;
        private Panel deletedPg;
        private Button button17;
        private Label label22;
        private Panel eventListPg;
        private Label label23;
        private Button viewEventList;
        private DateTimePicker dateTimePicker2;
        private Panel showEventList;
        private Button button18;
        private TextBox textBox6;
        private Label label24;
    }
}

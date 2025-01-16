namespace BerkleyUpdateCreator
{
    partial class MainForm
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
            meetingType = new ComboBox();
            lblMeetingType = new Label();
            lblMeetingLocation = new Label();
            meetingLocation = new ComboBox();
            meetingInfo = new TextBox();
            lblMeetingInfo = new Label();
            lblDateTime = new Label();
            meetingDate = new DateTimePicker();
            meetingLink = new TextBox();
            lblMeetingLink = new Label();
            label1 = new Label();
            outputTextBox = new RichTextBox();
            lblTicket1 = new Label();
            label2 = new Label();
            internalNotes = new TextBox();
            label3 = new Label();
            questions = new TextBox();
            label4 = new Label();
            meetingTime = new TextBox();
            btnCreateReport = new Button();
            btn_addTicket = new Button();
            btn_editTicket = new Button();
            btn_deleteTicket = new Button();
            ticketsDisplay = new ListBox();
            btn_timeNow = new Button();
            btn_settings = new Button();
            SuspendLayout();
            // 
            // meetingType
            // 
            meetingType.BackColor = SystemColors.Window;
            meetingType.DropDownStyle = ComboBoxStyle.DropDownList;
            meetingType.FlatStyle = FlatStyle.Flat;
            meetingType.FormattingEnabled = true;
            meetingType.Items.AddRange(new object[] { "PB DSU", "PB DSU + Refinement", "PB DSU + Retro", "PB DSU + Sprint Planning + Refinement" });
            meetingType.Location = new Point(52, 96);
            meetingType.Name = "meetingType";
            meetingType.Size = new Size(256, 28);
            meetingType.TabIndex = 1;
            meetingType.SelectedIndexChanged += meetingType_SelectedIndexChanged;
            // 
            // lblMeetingType
            // 
            lblMeetingType.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMeetingType.ForeColor = Color.LimeGreen;
            lblMeetingType.Location = new Point(52, 69);
            lblMeetingType.Name = "lblMeetingType";
            lblMeetingType.Size = new Size(256, 24);
            lblMeetingType.TabIndex = 3;
            lblMeetingType.Text = "Type";
            lblMeetingType.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblMeetingLocation
            // 
            lblMeetingLocation.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMeetingLocation.ForeColor = Color.LimeGreen;
            lblMeetingLocation.Location = new Point(52, 412);
            lblMeetingLocation.Name = "lblMeetingLocation";
            lblMeetingLocation.Size = new Size(256, 24);
            lblMeetingLocation.TabIndex = 11;
            lblMeetingLocation.Text = "Location";
            lblMeetingLocation.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // meetingLocation
            // 
            meetingLocation.BackColor = SystemColors.Window;
            meetingLocation.DropDownStyle = ComboBoxStyle.DropDownList;
            meetingLocation.FlatStyle = FlatStyle.Flat;
            meetingLocation.FormattingEnabled = true;
            meetingLocation.Items.AddRange(new object[] { "1st Floor Conference Room", "2nd Floor Conference Room", "3rd Floor Conference Room", "Ground Floor Conference Room" });
            meetingLocation.Location = new Point(52, 439);
            meetingLocation.Name = "meetingLocation";
            meetingLocation.Size = new Size(256, 28);
            meetingLocation.TabIndex = 6;
            // 
            // meetingInfo
            // 
            meetingInfo.Location = new Point(52, 345);
            meetingInfo.MinimumSize = new Size(256, 64);
            meetingInfo.Multiline = true;
            meetingInfo.Name = "meetingInfo";
            meetingInfo.Size = new Size(256, 64);
            meetingInfo.TabIndex = 5;
            // 
            // lblMeetingInfo
            // 
            lblMeetingInfo.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMeetingInfo.ForeColor = Color.LimeGreen;
            lblMeetingInfo.Location = new Point(52, 318);
            lblMeetingInfo.Name = "lblMeetingInfo";
            lblMeetingInfo.Size = new Size(256, 24);
            lblMeetingInfo.TabIndex = 8;
            lblMeetingInfo.Text = "Info";
            lblMeetingInfo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDateTime
            // 
            lblDateTime.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblDateTime.ForeColor = Color.LimeGreen;
            lblDateTime.Location = new Point(52, 127);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(256, 24);
            lblDateTime.TabIndex = 7;
            lblDateTime.Text = "Date";
            lblDateTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // meetingDate
            // 
            meetingDate.Location = new Point(52, 154);
            meetingDate.MinimumSize = new Size(256, 32);
            meetingDate.Name = "meetingDate";
            meetingDate.Size = new Size(256, 32);
            meetingDate.TabIndex = 2;
            meetingDate.Value = new DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // meetingLink
            // 
            meetingLink.Location = new Point(52, 283);
            meetingLink.MinimumSize = new Size(256, 32);
            meetingLink.Name = "meetingLink";
            meetingLink.Size = new Size(256, 32);
            meetingLink.TabIndex = 4;
            // 
            // lblMeetingLink
            // 
            lblMeetingLink.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblMeetingLink.ForeColor = Color.LimeGreen;
            lblMeetingLink.Location = new Point(52, 256);
            lblMeetingLink.Name = "lblMeetingLink";
            lblMeetingLink.Size = new Size(256, 24);
            lblMeetingLink.TabIndex = 4;
            lblMeetingLink.Text = "Link";
            lblMeetingLink.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(52, 27);
            label1.Name = "label1";
            label1.Size = new Size(256, 42);
            label1.TabIndex = 12;
            label1.Text = "Meeting Info";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // outputTextBox
            // 
            outputTextBox.Location = new Point(948, 92);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            outputTextBox.Size = new Size(512, 651);
            outputTextBox.TabIndex = 16;
            outputTextBox.Text = "";
            // 
            // lblTicket1
            // 
            lblTicket1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTicket1.ForeColor = Color.LimeGreen;
            lblTicket1.Location = new Point(393, 65);
            lblTicket1.Name = "lblTicket1";
            lblTicket1.Size = new Size(256, 24);
            lblTicket1.TabIndex = 16;
            lblTicket1.Text = "Tickets";
            lblTicket1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(393, 331);
            label2.Name = "label2";
            label2.Size = new Size(256, 24);
            label2.TabIndex = 25;
            label2.Text = "Internal Notes";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // internalNotes
            // 
            internalNotes.Location = new Point(393, 358);
            internalNotes.MinimumSize = new Size(256, 32);
            internalNotes.Multiline = true;
            internalNotes.Name = "internalNotes";
            internalNotes.Size = new Size(512, 174);
            internalNotes.TabIndex = 13;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(393, 552);
            label3.Name = "label3";
            label3.Size = new Size(256, 24);
            label3.TabIndex = 28;
            label3.Text = "Questions";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // questions
            // 
            questions.Location = new Point(393, 579);
            questions.MinimumSize = new Size(256, 32);
            questions.Multiline = true;
            questions.Name = "questions";
            questions.Size = new Size(512, 164);
            questions.TabIndex = 14;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.ForeColor = Color.LimeGreen;
            label4.Location = new Point(52, 194);
            label4.Name = "label4";
            label4.Size = new Size(256, 24);
            label4.TabIndex = 30;
            label4.Text = "Time";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // meetingTime
            // 
            meetingTime.Location = new Point(52, 221);
            meetingTime.MinimumSize = new Size(256, 32);
            meetingTime.Name = "meetingTime";
            meetingTime.Size = new Size(256, 32);
            meetingTime.TabIndex = 3;
            // 
            // btnCreateReport
            // 
            btnCreateReport.Location = new Point(83, 513);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(197, 63);
            btnCreateReport.TabIndex = 15;
            btnCreateReport.Text = "Create Report";
            btnCreateReport.UseVisualStyleBackColor = true;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // btn_addTicket
            // 
            btn_addTicket.Location = new Point(393, 282);
            btn_addTicket.Name = "btn_addTicket";
            btn_addTicket.Size = new Size(132, 29);
            btn_addTicket.TabIndex = 31;
            btn_addTicket.Text = "Add New Ticket";
            btn_addTicket.UseVisualStyleBackColor = true;
            btn_addTicket.Click += btn_addTicket_Click;
            // 
            // btn_editTicket
            // 
            btn_editTicket.Location = new Point(599, 282);
            btn_editTicket.Name = "btn_editTicket";
            btn_editTicket.Size = new Size(94, 29);
            btn_editTicket.TabIndex = 32;
            btn_editTicket.Text = "Edit Ticket";
            btn_editTicket.UseVisualStyleBackColor = true;
            btn_editTicket.Click += btn_editTicket_Click;
            // 
            // btn_deleteTicket
            // 
            btn_deleteTicket.Location = new Point(752, 282);
            btn_deleteTicket.Name = "btn_deleteTicket";
            btn_deleteTicket.Size = new Size(153, 29);
            btn_deleteTicket.TabIndex = 33;
            btn_deleteTicket.Text = "Delete Ticket";
            btn_deleteTicket.UseVisualStyleBackColor = true;
            btn_deleteTicket.Click += btn_deleteTicket_Click;
            // 
            // ticketsDisplay
            // 
            ticketsDisplay.AllowDrop = true;
            ticketsDisplay.FormattingEnabled = true;
            ticketsDisplay.Location = new Point(393, 92);
            ticketsDisplay.Name = "ticketsDisplay";
            ticketsDisplay.Size = new Size(512, 164);
            ticketsDisplay.TabIndex = 34;
            ticketsDisplay.DragDrop += ticketsDisplay_DragDrop;
            ticketsDisplay.DragOver += ticketsDisplay_DragOver;
            ticketsDisplay.MouseDown += ticketsDisplay_MouseDown;
            // 
            // btn_timeNow
            // 
            btn_timeNow.BackColor = Color.White;
            btn_timeNow.BackgroundImageLayout = ImageLayout.None;
            btn_timeNow.FlatStyle = FlatStyle.Flat;
            btn_timeNow.Location = new Point(314, 154);
            btn_timeNow.Name = "btn_timeNow";
            btn_timeNow.Size = new Size(32, 32);
            btn_timeNow.TabIndex = 35;
            btn_timeNow.Text = "O";
            btn_timeNow.UseVisualStyleBackColor = false;
            btn_timeNow.Click += btn_timeNow_Click;
            // 
            // btn_settings
            // 
            btn_settings.BackColor = Color.White;
            btn_settings.BackgroundImageLayout = ImageLayout.None;
            btn_settings.FlatStyle = FlatStyle.Flat;
            btn_settings.Location = new Point(1358, 27);
            btn_settings.Name = "btn_settings";
            btn_settings.Size = new Size(102, 32);
            btn_settings.TabIndex = 37;
            btn_settings.Text = "Settings";
            btn_settings.UseVisualStyleBackColor = false;
            btn_settings.Click += btn_settings_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1505, 786);
            Controls.Add(btn_settings);
            Controls.Add(btn_timeNow);
            Controls.Add(ticketsDisplay);
            Controls.Add(btn_deleteTicket);
            Controls.Add(btn_editTicket);
            Controls.Add(btn_addTicket);
            Controls.Add(btnCreateReport);
            Controls.Add(meetingTime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(questions);
            Controls.Add(label2);
            Controls.Add(internalNotes);
            Controls.Add(lblTicket1);
            Controls.Add(outputTextBox);
            Controls.Add(label1);
            Controls.Add(lblMeetingLocation);
            Controls.Add(meetingLocation);
            Controls.Add(meetingType);
            Controls.Add(meetingInfo);
            Controls.Add(lblMeetingType);
            Controls.Add(lblMeetingInfo);
            Controls.Add(lblMeetingLink);
            Controls.Add(lblDateTime);
            Controls.Add(meetingLink);
            Controls.Add(meetingDate);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "Berkley Updates";
            FormClosing += MainForm_FormClosing;
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox meetingType;
        private Label lblMeetingType;
        private Label lblMeetingLink;
        private TextBox meetingLink;
        private Label lblDateTime;
        private DateTimePicker meetingDate;
        private TextBox meetingInfo;
        private Label lblMeetingInfo;
        private Label lblMeetingLocation;
        private ComboBox meetingLocation;
        private Label label1;
        private RichTextBox outputTextBox;
        private Label lblTicket1;
        private Label label2;
        private TextBox internalNotes;
        private Label label3;
        private TextBox questions;
        private Label label4;
        private TextBox meetingTime;
        private Button btnCreateReport;
        private Button btn_addTicket;
        private Button btn_editTicket;
        private Button btn_deleteTicket;
        private ListBox ticketsDisplay;
        private Button btn_timeNow;
        private Button btn_settings;
    }
}

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
            ticketLink1 = new TextBox();
            ticketDescription1 = new TextBox();
            lblTicket1 = new Label();
            lblTicket2 = new Label();
            ticketDescription2 = new TextBox();
            ticketLink2 = new TextBox();
            lblTicket3 = new Label();
            ticketDescription3 = new TextBox();
            ticketLink3 = new TextBox();
            label2 = new Label();
            internalNotes = new TextBox();
            label3 = new Label();
            questions = new TextBox();
            label4 = new Label();
            meetingTime = new TextBox();
            btnCreateReport = new Button();
            SuspendLayout();
            // 
            // meetingType
            // 
            meetingType.BackColor = SystemColors.Window;
            meetingType.DropDownStyle = ComboBoxStyle.DropDownList;
            meetingType.FlatStyle = FlatStyle.Flat;
            meetingType.FormattingEnabled = true;
            meetingType.Items.AddRange(new object[] { "PB DSU", "PB DSU + Refinement", "PB DSU + Retro" });
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
            outputTextBox.Location = new Point(930, 400);
            outputTextBox.Name = "outputTextBox";
            outputTextBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            outputTextBox.Size = new Size(512, 346);
            outputTextBox.TabIndex = 16;
            outputTextBox.Text = "";
            // 
            // ticketLink1
            // 
            ticketLink1.Location = new Point(389, 92);
            ticketLink1.MinimumSize = new Size(256, 32);
            ticketLink1.Multiline = true;
            ticketLink1.Name = "ticketLink1";
            ticketLink1.Size = new Size(512, 64);
            ticketLink1.TabIndex = 7;
            // 
            // ticketDescription1
            // 
            ticketDescription1.Location = new Point(389, 162);
            ticketDescription1.MinimumSize = new Size(256, 32);
            ticketDescription1.Multiline = true;
            ticketDescription1.Name = "ticketDescription1";
            ticketDescription1.Size = new Size(512, 128);
            ticketDescription1.TabIndex = 8;
            // 
            // lblTicket1
            // 
            lblTicket1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTicket1.ForeColor = Color.LimeGreen;
            lblTicket1.Location = new Point(389, 65);
            lblTicket1.Name = "lblTicket1";
            lblTicket1.Size = new Size(256, 24);
            lblTicket1.TabIndex = 16;
            lblTicket1.Text = "Ticket 1";
            lblTicket1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTicket2
            // 
            lblTicket2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTicket2.ForeColor = Color.LimeGreen;
            lblTicket2.Location = new Point(389, 293);
            lblTicket2.Name = "lblTicket2";
            lblTicket2.Size = new Size(256, 24);
            lblTicket2.TabIndex = 19;
            lblTicket2.Text = "Ticket 2";
            lblTicket2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ticketDescription2
            // 
            ticketDescription2.Location = new Point(389, 390);
            ticketDescription2.MinimumSize = new Size(256, 32);
            ticketDescription2.Multiline = true;
            ticketDescription2.Name = "ticketDescription2";
            ticketDescription2.Size = new Size(512, 128);
            ticketDescription2.TabIndex = 10;
            // 
            // ticketLink2
            // 
            ticketLink2.Location = new Point(389, 320);
            ticketLink2.MinimumSize = new Size(256, 32);
            ticketLink2.Multiline = true;
            ticketLink2.Name = "ticketLink2";
            ticketLink2.Size = new Size(512, 64);
            ticketLink2.TabIndex = 9;
            // 
            // lblTicket3
            // 
            lblTicket3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTicket3.ForeColor = Color.LimeGreen;
            lblTicket3.Location = new Point(389, 521);
            lblTicket3.Name = "lblTicket3";
            lblTicket3.Size = new Size(256, 24);
            lblTicket3.TabIndex = 22;
            lblTicket3.Text = "Ticket 3";
            lblTicket3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ticketDescription3
            // 
            ticketDescription3.Location = new Point(389, 618);
            ticketDescription3.MinimumSize = new Size(256, 32);
            ticketDescription3.Multiline = true;
            ticketDescription3.Name = "ticketDescription3";
            ticketDescription3.Size = new Size(512, 128);
            ticketDescription3.TabIndex = 12;
            // 
            // ticketLink3
            // 
            ticketLink3.Location = new Point(389, 548);
            ticketLink3.MinimumSize = new Size(256, 32);
            ticketLink3.Multiline = true;
            ticketLink3.Name = "ticketLink3";
            ticketLink3.Size = new Size(512, 64);
            ticketLink3.TabIndex = 11;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(930, 65);
            label2.Name = "label2";
            label2.Size = new Size(256, 24);
            label2.TabIndex = 25;
            label2.Text = "Internal Notes";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // internalNotes
            // 
            internalNotes.Location = new Point(930, 92);
            internalNotes.MinimumSize = new Size(256, 32);
            internalNotes.Multiline = true;
            internalNotes.Name = "internalNotes";
            internalNotes.Size = new Size(512, 128);
            internalNotes.TabIndex = 13;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(930, 229);
            label3.Name = "label3";
            label3.Size = new Size(256, 24);
            label3.TabIndex = 28;
            label3.Text = "Questions";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // questions
            // 
            questions.Location = new Point(930, 256);
            questions.MinimumSize = new Size(256, 32);
            questions.Multiline = true;
            questions.Name = "questions";
            questions.Size = new Size(512, 128);
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
            btnCreateReport.Location = new Point(86, 535);
            btnCreateReport.Name = "btnCreateReport";
            btnCreateReport.Size = new Size(180, 53);
            btnCreateReport.TabIndex = 15;
            btnCreateReport.Text = "Create Report";
            btnCreateReport.UseVisualStyleBackColor = true;
            btnCreateReport.Click += btnCreateReport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(1588, 777);
            Controls.Add(btnCreateReport);
            Controls.Add(meetingTime);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(questions);
            Controls.Add(label2);
            Controls.Add(internalNotes);
            Controls.Add(lblTicket3);
            Controls.Add(ticketDescription3);
            Controls.Add(ticketLink3);
            Controls.Add(lblTicket2);
            Controls.Add(ticketDescription2);
            Controls.Add(ticketLink2);
            Controls.Add(lblTicket1);
            Controls.Add(ticketDescription1);
            Controls.Add(ticketLink1);
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
        private TextBox ticketLink1;
        private TextBox ticketDescription1;
        private Label lblTicket1;
        private Label lblTicket2;
        private TextBox ticketDescription2;
        private TextBox ticketLink2;
        private Label lblTicket3;
        private TextBox ticketDescription3;
        private TextBox ticketLink3;
        private Label label2;
        private TextBox internalNotes;
        private Label label3;
        private TextBox questions;
        private Label label4;
        private TextBox meetingTime;
        private Button btnCreateReport;
    }
}

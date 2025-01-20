namespace BerkleyUpdateCreator
{
    partial class TicketForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lblTicket1 = new Label();
            ticketDescription1 = new TextBox();
            ticketLink1 = new TextBox();
            cbx_jiraTicketTitle = new CheckBox();
            label2 = new Label();
            label3 = new Label();
            btn_SubmitTicket = new Button();
            label4 = new Label();
            cbx_story = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(36, 26);
            label1.Name = "label1";
            label1.Size = new Size(256, 42);
            label1.TabIndex = 13;
            label1.Text = "Ticket Form\r\n";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTicket1
            // 
            lblTicket1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTicket1.ForeColor = Color.LimeGreen;
            lblTicket1.Location = new Point(36, 217);
            lblTicket1.Name = "lblTicket1";
            lblTicket1.Size = new Size(256, 17);
            lblTicket1.TabIndex = 19;
            lblTicket1.Text = "Ticket Title";
            lblTicket1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ticketDescription1
            // 
            ticketDescription1.Location = new Point(36, 353);
            ticketDescription1.MinimumSize = new Size(256, 32);
            ticketDescription1.Multiline = true;
            ticketDescription1.Name = "ticketDescription1";
            ticketDescription1.Size = new Size(512, 212);
            ticketDescription1.TabIndex = 18;
            // 
            // ticketLink1
            // 
            ticketLink1.Location = new Point(36, 244);
            ticketLink1.MinimumSize = new Size(256, 32);
            ticketLink1.Multiline = true;
            ticketLink1.Name = "ticketLink1";
            ticketLink1.Size = new Size(512, 57);
            ticketLink1.TabIndex = 17;
            // 
            // cbx_jiraTicketTitle
            // 
            cbx_jiraTicketTitle.AutoSize = true;
            cbx_jiraTicketTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbx_jiraTicketTitle.ForeColor = Color.LimeGreen;
            cbx_jiraTicketTitle.Location = new Point(36, 82);
            cbx_jiraTicketTitle.Name = "cbx_jiraTicketTitle";
            cbx_jiraTicketTitle.Size = new Size(137, 24);
            cbx_jiraTicketTitle.TabIndex = 16;
            cbx_jiraTicketTitle.Text = "Jira Ticket Title";
            cbx_jiraTicketTitle.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(36, 326);
            label2.Name = "label2";
            label2.Size = new Size(256, 17);
            label2.TabIndex = 21;
            label2.Text = "Ticket Updates";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(36, 109);
            label3.Name = "label3";
            label3.Size = new Size(256, 76);
            label3.TabIndex = 22;
            label3.Text = "When Selected, first row of title should be link to Jira Ticket, second row of title should be Title of Jira Ticket";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_SubmitTicket
            // 
            btn_SubmitTicket.Location = new Point(195, 571);
            btn_SubmitTicket.Name = "btn_SubmitTicket";
            btn_SubmitTicket.Size = new Size(207, 63);
            btn_SubmitTicket.TabIndex = 19;
            btn_SubmitTicket.Text = "Submit Ticket";
            btn_SubmitTicket.UseVisualStyleBackColor = true;
            btn_SubmitTicket.Click += btn_SubmitTicket_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label4.ForeColor = Color.LimeGreen;
            label4.Location = new Point(292, 109);
            label4.Name = "label4";
            label4.Size = new Size(256, 76);
            label4.TabIndex = 24;
            label4.Text = "When selected, ticket will have Story prefix and will be a bit larger";
            // 
            // cbx_story
            // 
            cbx_story.AutoSize = true;
            cbx_story.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbx_story.ForeColor = Color.LimeGreen;
            cbx_story.Location = new Point(292, 82);
            cbx_story.Name = "cbx_story";
            cbx_story.Size = new Size(69, 24);
            cbx_story.TabIndex = 23;
            cbx_story.Text = "Story";
            cbx_story.UseVisualStyleBackColor = true;
            // 
            // TicketForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(589, 662);
            Controls.Add(label4);
            Controls.Add(cbx_story);
            Controls.Add(btn_SubmitTicket);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbx_jiraTicketTitle);
            Controls.Add(lblTicket1);
            Controls.Add(ticketDescription1);
            Controls.Add(ticketLink1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TicketForm";
            Text = "TicketForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblTicket1;
        private TextBox ticketDescription1;
        private TextBox ticketLink1;
        private CheckBox cbx_jiraTicketTitle;
        private Label label2;
        private Label label3;
        private Button btn_SubmitTicket;
        private Label label4;
        private CheckBox cbx_story;
    }
}
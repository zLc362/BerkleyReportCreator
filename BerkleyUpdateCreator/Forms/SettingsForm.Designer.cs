namespace BerkleyUpdateCreator.Forms
{
    partial class SettingsForm
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
            btn_editTypes = new Button();
            cbx_jiraTicketTitle = new CheckBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btn_editTypes
            // 
            btn_editTypes.BackColor = Color.White;
            btn_editTypes.BackgroundImageLayout = ImageLayout.None;
            btn_editTypes.FlatStyle = FlatStyle.Flat;
            btn_editTypes.Location = new Point(50, 310);
            btn_editTypes.Name = "btn_editTypes";
            btn_editTypes.Size = new Size(97, 28);
            btn_editTypes.TabIndex = 37;
            btn_editTypes.Text = "Edit Types";
            btn_editTypes.UseVisualStyleBackColor = false;
            btn_editTypes.Click += btn_editTypes_Click;
            // 
            // cbx_jiraTicketTitle
            // 
            cbx_jiraTicketTitle.AutoSize = true;
            cbx_jiraTicketTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cbx_jiraTicketTitle.ForeColor = Color.LimeGreen;
            cbx_jiraTicketTitle.Location = new Point(50, 156);
            cbx_jiraTicketTitle.Name = "cbx_jiraTicketTitle";
            cbx_jiraTicketTitle.Size = new Size(137, 24);
            cbx_jiraTicketTitle.TabIndex = 38;
            cbx_jiraTicketTitle.Text = "Jira Ticket Title";
            cbx_jiraTicketTitle.UseVisualStyleBackColor = true;
            cbx_jiraTicketTitle.CheckedChanged += cbx_jiraTicketTitle_CheckedChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(430, 42);
            label1.TabIndex = 39;
            label1.Text = "Settings";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(22, 74);
            label2.Name = "label2";
            label2.Size = new Size(430, 63);
            label2.TabIndex = 40;
            label2.Text = "Sets whether when adding a new ticket, the jira checkbox is selected by default";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(22, 233);
            label3.Name = "label3";
            label3.Size = new Size(430, 63);
            label3.TabIndex = 41;
            label3.Text = "Opens window to edit the \r\nMeeting Type - Meeting Time mappings";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(477, 356);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbx_jiraTicketTitle);
            Controls.Add(btn_editTypes);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SettingsForm";
            Text = "Settings";
            Load += SettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_editTypes;
        private CheckBox cbx_jiraTicketTitle;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
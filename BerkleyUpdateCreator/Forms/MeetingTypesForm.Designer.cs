namespace BerkleyUpdateCreator
{
    partial class MeetingTypesForm
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
            lblTicket1 = new Label();
            label1 = new Label();
            typeTimeMappings = new ListBox();
            meetingTypeInput = new TextBox();
            meetingTimeInput = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btn_deleteDef = new Button();
            btn_addDef = new Button();
            btn_Save = new Button();
            SuspendLayout();
            // 
            // lblTicket1
            // 
            lblTicket1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            lblTicket1.ForeColor = Color.LimeGreen;
            lblTicket1.Location = new Point(38, 151);
            lblTicket1.Name = "lblTicket1";
            lblTicket1.Size = new Size(256, 17);
            lblTicket1.TabIndex = 20;
            lblTicket1.Text = "Meeting Type";
            lblTicket1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.LimeGreen;
            label1.Location = new Point(34, 30);
            label1.Name = "label1";
            label1.Size = new Size(430, 42);
            label1.TabIndex = 21;
            label1.Text = "Meeting Types and Times Definitions";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // typeTimeMappings
            // 
            typeTimeMappings.AllowDrop = true;
            typeTimeMappings.FormattingEnabled = true;
            typeTimeMappings.Location = new Point(38, 313);
            typeTimeMappings.Name = "typeTimeMappings";
            typeTimeMappings.Size = new Size(512, 164);
            typeTimeMappings.TabIndex = 35;
            // 
            // meetingTypeInput
            // 
            meetingTypeInput.Location = new Point(38, 171);
            meetingTypeInput.MinimumSize = new Size(0, 32);
            meetingTypeInput.Multiline = true;
            meetingTypeInput.Name = "meetingTypeInput";
            meetingTypeInput.Size = new Size(240, 32);
            meetingTypeInput.TabIndex = 36;
            // 
            // meetingTimeInput
            // 
            meetingTimeInput.Location = new Point(310, 171);
            meetingTimeInput.MinimumSize = new Size(0, 32);
            meetingTimeInput.Multiline = true;
            meetingTimeInput.Name = "meetingTimeInput";
            meetingTimeInput.Size = new Size(240, 32);
            meetingTimeInput.TabIndex = 37;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(310, 151);
            label2.Name = "label2";
            label2.Size = new Size(256, 17);
            label2.TabIndex = 38;
            label2.Text = "Meeting Time";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label3.ForeColor = Color.LimeGreen;
            label3.Location = new Point(38, 293);
            label3.Name = "label3";
            label3.Size = new Size(256, 17);
            label3.TabIndex = 39;
            label3.Text = "Current Definitions";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btn_deleteDef
            // 
            btn_deleteDef.Location = new Point(310, 239);
            btn_deleteDef.Name = "btn_deleteDef";
            btn_deleteDef.Size = new Size(240, 29);
            btn_deleteDef.TabIndex = 42;
            btn_deleteDef.Text = "Delete Definition";
            btn_deleteDef.UseVisualStyleBackColor = true;
            btn_deleteDef.Click += btn_deleteDef_Click;
            // 
            // btn_addDef
            // 
            btn_addDef.Location = new Point(38, 239);
            btn_addDef.Name = "btn_addDef";
            btn_addDef.Size = new Size(240, 29);
            btn_addDef.TabIndex = 40;
            btn_addDef.Text = "Add New Definition";
            btn_addDef.UseVisualStyleBackColor = true;
            btn_addDef.Click += btn_addDef_Click;
            // 
            // btn_Save
            // 
            btn_Save.Location = new Point(184, 537);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(207, 63);
            btn_Save.TabIndex = 43;
            btn_Save.Text = "Save";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // MeetingTypesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(48, 48, 48);
            ClientSize = new Size(589, 662);
            Controls.Add(btn_Save);
            Controls.Add(btn_deleteDef);
            Controls.Add(btn_addDef);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(meetingTimeInput);
            Controls.Add(meetingTypeInput);
            Controls.Add(typeTimeMappings);
            Controls.Add(label1);
            Controls.Add(lblTicket1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MeetingTypesForm";
            Text = "Meeting Type And Time Definitions";
            Load += MeetingTypesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTicket1;
        private Label label1;
        private ListBox typeTimeMappings;
        private TextBox meetingTypeInput;
        private TextBox meetingTimeInput;
        private Label label2;
        private Label label3;
        private Button btn_deleteDef;
        private Button btn_addDef;
        private Button btn_Save;
    }
}
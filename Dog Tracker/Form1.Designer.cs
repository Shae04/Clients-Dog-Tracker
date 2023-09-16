namespace Dog_Tracker
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
            txtDogName = new TextBox();
            txtOwnerName = new TextBox();
            txtAddress = new TextBox();
            txtBehaviorNotes = new TextBox();
            txtWalkingTime = new TextBox();
            groupBox1 = new GroupBox();
            lblBehaviorNotes = new Label();
            lblAddress = new Label();
            lblOwnerName = new Label();
            lblDogName = new Label();
            btnAddClient = new Button();
            btnAddWalkingTime = new Button();
            btnGenerateReport = new Button();
            dataGridViewClients = new DataGridView();
            lblCurrentDog = new Label();
            groupBox2 = new GroupBox();
            label1 = new Label();
            pictureBoxDog = new PictureBox();
            btnUploadImage = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).BeginInit();
            SuspendLayout();
            // 
            // txtDogName
            // 
            txtDogName.Location = new Point(153, 38);
            txtDogName.Name = "txtDogName";
            txtDogName.Size = new Size(125, 27);
            txtDogName.TabIndex = 0;
            // 
            // txtOwnerName
            // 
            txtOwnerName.Location = new Point(153, 90);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(125, 27);
            txtOwnerName.TabIndex = 1;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(153, 137);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(125, 27);
            txtAddress.TabIndex = 2;
            // 
            // txtBehaviorNotes
            // 
            txtBehaviorNotes.Location = new Point(153, 191);
            txtBehaviorNotes.Name = "txtBehaviorNotes";
            txtBehaviorNotes.Size = new Size(125, 27);
            txtBehaviorNotes.TabIndex = 3;
            // 
            // txtWalkingTime
            // 
            txtWalkingTime.Location = new Point(153, 57);
            txtWalkingTime.Name = "txtWalkingTime";
            txtWalkingTime.Size = new Size(125, 27);
            txtWalkingTime.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblBehaviorNotes);
            groupBox1.Controls.Add(lblAddress);
            groupBox1.Controls.Add(lblOwnerName);
            groupBox1.Controls.Add(lblDogName);
            groupBox1.Controls.Add(btnAddClient);
            groupBox1.Controls.Add(txtDogName);
            groupBox1.Controls.Add(txtOwnerName);
            groupBox1.Controls.Add(txtBehaviorNotes);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Location = new Point(45, 26);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 283);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add a Client ";
            // 
            // lblBehaviorNotes
            // 
            lblBehaviorNotes.AutoSize = true;
            lblBehaviorNotes.Location = new Point(15, 191);
            lblBehaviorNotes.Name = "lblBehaviorNotes";
            lblBehaviorNotes.Size = new Size(113, 20);
            lblBehaviorNotes.TabIndex = 10;
            lblBehaviorNotes.Text = "Behavior Notes:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(15, 140);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(65, 20);
            lblAddress.TabIndex = 9;
            lblAddress.Text = "Address:";
            // 
            // lblOwnerName
            // 
            lblOwnerName.AutoSize = true;
            lblOwnerName.Location = new Point(15, 93);
            lblOwnerName.Name = "lblOwnerName";
            lblOwnerName.Size = new Size(108, 20);
            lblOwnerName.TabIndex = 8;
            lblOwnerName.Text = "Owner's Name:";
            lblOwnerName.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblDogName
            // 
            lblDogName.AutoSize = true;
            lblDogName.Location = new Point(15, 41);
            lblDogName.Name = "lblDogName";
            lblDogName.Size = new Size(91, 20);
            lblDogName.TabIndex = 7;
            lblDogName.Text = "Dogs Name:";
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(61, 239);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(181, 29);
            btnAddClient.TabIndex = 6;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // btnAddWalkingTime
            // 
            btnAddWalkingTime.Location = new Point(12, 56);
            btnAddWalkingTime.Name = "btnAddWalkingTime";
            btnAddWalkingTime.Size = new Size(94, 29);
            btnAddWalkingTime.TabIndex = 11;
            btnAddWalkingTime.Text = "Add";
            btnAddWalkingTime.UseVisualStyleBackColor = true;
            btnAddWalkingTime.Click += btnAddWalkingTime_Click;
            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(570, 338);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(133, 29);
            btnGenerateReport.TabIndex = 12;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;
            // 
            // dataGridViewClients
            // 
            dataGridViewClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClients.Location = new Point(409, 90);
            dataGridViewClients.Name = "dataGridViewClients";
            dataGridViewClients.RowHeadersWidth = 51;
            dataGridViewClients.RowTemplate.Height = 29;
            dataGridViewClients.Size = new Size(490, 188);
            dataGridViewClients.TabIndex = 13;
            dataGridViewClients.CellClick += dataGridViewClients_CellClick;
            // 
            // lblCurrentDog
            // 
            lblCurrentDog.AutoSize = true;
            lblCurrentDog.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrentDog.Location = new Point(492, 47);
            lblCurrentDog.Name = "lblCurrentDog";
            lblCurrentDog.Size = new Size(158, 31);
            lblCurrentDog.TabIndex = 15;
            lblCurrentDog.Text = "Current Dog: ";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtWalkingTime);
            groupBox2.Controls.Add(btnAddWalkingTime);
            groupBox2.Location = new Point(45, 313);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(308, 125);
            groupBox2.TabIndex = 16;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add Time in Minutes";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(394, 289);
            label1.Name = "label1";
            label1.Size = new Size(519, 20);
            label1.TabIndex = 17;
            label1.Text = "Note: After adding client, select the populated row you would like to have active.";
            // 
            // pictureBoxDog
            // 
            pictureBoxDog.BackColor = SystemColors.ActiveBorder;
            pictureBoxDog.Location = new Point(986, 90);
            pictureBoxDog.Name = "pictureBoxDog";
            pictureBoxDog.Size = new Size(254, 188);
            pictureBoxDog.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxDog.TabIndex = 18;
            pictureBoxDog.TabStop = false;
            // 
            // btnUploadImage
            // 
            btnUploadImage.Location = new Point(1053, 298);
            btnUploadImage.Name = "btnUploadImage";
            btnUploadImage.Size = new Size(124, 29);
            btnUploadImage.TabIndex = 19;
            btnUploadImage.Text = "Upload Image";
            btnUploadImage.UseVisualStyleBackColor = true;
            btnUploadImage.Click += btnUploadImage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1312, 450);
            Controls.Add(btnUploadImage);
            Controls.Add(pictureBoxDog);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(lblCurrentDog);
            Controls.Add(dataGridViewClients);
            Controls.Add(btnGenerateReport);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClients).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxDog).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDogName;
        private TextBox txtOwnerName;
        private TextBox txtAddress;
        private TextBox txtBehaviorNotes;
        private TextBox txtWalkingTime;
        private GroupBox groupBox1;
        private Label lblBehaviorNotes;
        private Label lblAddress;
        private Label lblOwnerName;
        private Label lblDogName;
        private Button btnAddClient;
        private Button btnAddWalkingTime;
        private Button btnGenerateReport;
        private DataGridView dataGridViewClients;
        private Label lblCurrentDog;
        private GroupBox groupBox2;
        private Label label1;
        private PictureBox pictureBoxDog;
        private Button btnUploadImage;
    }
}
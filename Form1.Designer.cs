namespace CodeExercise
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
            dataView = new DataGridView();
            FirstNameBox = new TextBox();
            groupBox = new GroupBox();
            ResetButton = new Button();
            MaxLabel = new Label();
            MinLabel = new Label();
            MaxTrack = new TrackBar();
            MinTrack = new TrackBar();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            StatusCombo = new ComboBox();
            label2 = new Label();
            IDBox = new TextBox();
            LastNameBox = new TextBox();
            label1 = new Label();
            FirstName = new Label();
            CountLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataView).BeginInit();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MaxTrack).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MinTrack).BeginInit();
            SuspendLayout();
            // 
            // dataView
            // 
            dataView.AllowUserToAddRows = false;
            dataView.AllowUserToDeleteRows = false;
            dataView.AllowUserToOrderColumns = true;
            dataView.AllowUserToResizeColumns = false;
            dataView.AllowUserToResizeRows = false;
            dataView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataView.EditMode = DataGridViewEditMode.EditProgrammatically;
            dataView.Location = new Point(89, 225);
            dataView.Name = "dataView";
            dataView.RowTemplate.Height = 25;
            dataView.Size = new Size(562, 304);
            dataView.TabIndex = 0;
            // 
            // FirstNameBox
            // 
            FirstNameBox.Location = new Point(102, 78);
            FirstNameBox.Name = "FirstNameBox";
            FirstNameBox.Size = new Size(189, 23);
            FirstNameBox.TabIndex = 1;
            FirstNameBox.TextChanged += FirstNameBox_TextChanged;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(ResetButton);
            groupBox.Controls.Add(MaxLabel);
            groupBox.Controls.Add(MinLabel);
            groupBox.Controls.Add(MaxTrack);
            groupBox.Controls.Add(MinTrack);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(StatusCombo);
            groupBox.Controls.Add(label2);
            groupBox.Controls.Add(IDBox);
            groupBox.Controls.Add(LastNameBox);
            groupBox.Controls.Add(label1);
            groupBox.Controls.Add(FirstName);
            groupBox.Controls.Add(FirstNameBox);
            groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.Location = new Point(55, 8);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(632, 207);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Filters";
            // 
            // ResetButton
            // 
            ResetButton.Location = new Point(382, 166);
            ResetButton.Name = "ResetButton";
            ResetButton.Size = new Size(132, 23);
            ResetButton.TabIndex = 15;
            ResetButton.Text = "Reset";
            ResetButton.UseVisualStyleBackColor = true;
            ResetButton.Click += ResetButton_Click;
            // 
            // MaxLabel
            // 
            MaxLabel.AutoSize = true;
            MaxLabel.Location = new Point(541, 105);
            MaxLabel.Name = "MaxLabel";
            MaxLabel.Size = new Size(14, 15);
            MaxLabel.TabIndex = 14;
            MaxLabel.Text = "0";
            // 
            // MinLabel
            // 
            MinLabel.AutoSize = true;
            MinLabel.Location = new Point(541, 39);
            MinLabel.Name = "MinLabel";
            MinLabel.Size = new Size(14, 15);
            MinLabel.TabIndex = 13;
            MinLabel.Text = "0";
            // 
            // MaxTrack
            // 
            MaxTrack.Location = new Point(336, 117);
            MaxTrack.Name = "MaxTrack";
            MaxTrack.Size = new Size(247, 45);
            MaxTrack.TabIndex = 12;
            MaxTrack.Scroll += MaxTrack_Scroll;
            // 
            // MinTrack
            // 
            MinTrack.Location = new Point(336, 54);
            MinTrack.Name = "MinTrack";
            MinTrack.Size = new Size(247, 45);
            MinTrack.TabIndex = 11;
            MinTrack.Scroll += MinTrack_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(394, 105);
            label5.Name = "label5";
            label5.Size = new Size(103, 15);
            label5.TabIndex = 10;
            label5.Text = "Max Credit Score";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(394, 39);
            label4.Name = "label4";
            label4.Size = new Size(100, 15);
            label4.TabIndex = 9;
            label4.Text = "Min Credit Score";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 169);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 8;
            label3.Text = "Status";
            // 
            // StatusCombo
            // 
            StatusCombo.FormattingEnabled = true;
            StatusCombo.Location = new Point(102, 166);
            StatusCombo.Name = "StatusCombo";
            StatusCombo.Size = new Size(189, 23);
            StatusCombo.TabIndex = 7;
            StatusCombo.SelectedIndexChanged += StatusCombo_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 38);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 6;
            label2.Text = "ID";
            // 
            // IDBox
            // 
            IDBox.Location = new Point(102, 35);
            IDBox.Name = "IDBox";
            IDBox.Size = new Size(189, 23);
            IDBox.TabIndex = 5;
            IDBox.TextChanged += IDBox_TextChanged;
            IDBox.KeyPress += IDBox_KeyPress;
            // 
            // LastNameBox
            // 
            LastNameBox.Location = new Point(102, 124);
            LastNameBox.Name = "LastNameBox";
            LastNameBox.Size = new Size(189, 23);
            LastNameBox.TabIndex = 4;
            LastNameBox.TextChanged += LastNameBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 127);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "Last Name";
            // 
            // FirstName
            // 
            FirstName.AutoSize = true;
            FirstName.Location = new Point(20, 81);
            FirstName.Name = "FirstName";
            FirstName.Size = new Size(67, 15);
            FirstName.TabIndex = 2;
            FirstName.Text = "First Name";
            // 
            // CountLabel
            // 
            CountLabel.AutoSize = true;
            CountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            CountLabel.Location = new Point(594, 534);
            CountLabel.Name = "CountLabel";
            CountLabel.Size = new Size(14, 15);
            CountLabel.TabIndex = 3;
            CountLabel.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 558);
            Controls.Add(CountLabel);
            Controls.Add(groupBox);
            Controls.Add(dataView);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataView).EndInit();
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MaxTrack).EndInit();
            ((System.ComponentModel.ISupportInitialize)MinTrack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataView;
        private TextBox FirstNameBox;
        private GroupBox groupBox;
        private TextBox LastNameBox;
        private Label label1;
        private Label FirstName;
        private Label label2;
        private TextBox IDBox;
        private Label label3;
        private ComboBox StatusCombo;
        private TrackBar MaxTrack;
        private TrackBar MinTrack;
        private Label label5;
        private Label label4;
        private Label MinLabel;
        private Label MaxLabel;
        private Button ResetButton;
        private Label CountLabel;
    }
}
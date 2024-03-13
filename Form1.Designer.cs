namespace Lab2
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
            parentGridView = new DataGridView();
            childGridView = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)parentGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)childGridView).BeginInit();
            SuspendLayout();
            // 
            // parentGridView
            // 
            parentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            parentGridView.Location = new Point(83, 204);
            parentGridView.Name = "parentGridView";
            parentGridView.Size = new Size(421, 278);
            parentGridView.TabIndex = 0;
            parentGridView.CellContentClick += parentGridView_CellContentClick;
            // 
            // childGridView
            // 
            childGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            childGridView.Location = new Point(830, 204);
            childGridView.Name = "childGridView";
            childGridView.Size = new Size(421, 278);
            childGridView.TabIndex = 1;
            childGridView.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 156);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 2;
            label1.Text = "Parent ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1019, 156);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 3;
            label2.Text = "Child";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(641, 550);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 4;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += updateButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1431, 682);
            Controls.Add(updateButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(childGridView);
            Controls.Add(parentGridView);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)parentGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)childGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView parentGridView;
        private DataGridView childGridView;
        private Label label1;
        private Label label2;
        private Button updateButton;
    }
}

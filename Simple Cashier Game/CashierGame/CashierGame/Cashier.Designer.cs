namespace CashierGame
{
    partial class Cashier
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
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("7");
            ListViewItem listViewItem2 = new ListViewItem("8");
            ListViewItem listViewItem3 = new ListViewItem("9");
            ListViewItem listViewItem4 = new ListViewItem("4");
            ListViewItem listViewItem5 = new ListViewItem("5");
            ListViewItem listViewItem6 = new ListViewItem("6");
            ListViewItem listViewItem7 = new ListViewItem("1");
            ListViewItem listViewItem8 = new ListViewItem("2");
            ListViewItem listViewItem9 = new ListViewItem("3");
            ListViewItem listViewItem10 = new ListViewItem("0");
            ListViewItem listViewItem11 = new ListViewItem(".");
            ListViewItem listViewItem12 = new ListViewItem("ENTER");
            numpad = new ListView();
            checkedListBox1 = new CheckedListBox();
            priceLabel = new Label();
            priceValue = new Label();
            progressBar1 = new ProgressBar();
            totalLabel = new Label();
            toolTip1 = new ToolTip(components);
            totalValue = new Label();
            timer = new System.Windows.Forms.Timer(components);
            createdBy = new Label();
            resultLabel = new Label();
            colorDialog1 = new ColorDialog();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // numpad
            // 
            numpad.BackColor = Color.White;
            numpad.BackgroundImageTiled = true;
            numpad.Font = new Font("Courier New", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            numpad.ImeMode = ImeMode.Disable;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            listViewItem4.StateImageIndex = 0;
            listViewItem5.StateImageIndex = 0;
            listViewItem6.StateImageIndex = 0;
            listViewItem7.StateImageIndex = 0;
            listViewItem8.StateImageIndex = 0;
            listViewItem9.StateImageIndex = 0;
            listViewItem10.StateImageIndex = 0;
            listViewItem11.StateImageIndex = 0;
            listViewItem12.StateImageIndex = 0;
            numpad.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11, listViewItem12 });
            numpad.Location = new Point(329, 98);
            numpad.Name = "numpad";
            numpad.Size = new Size(160, 177);
            numpad.TabIndex = 0;
            numpad.UseCompatibleStateImageBehavior = false;
            // 
            // checkedListBox1
            // 
            checkedListBox1.CheckOnClick = true;
            checkedListBox1.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Flour ( RM 3.50 )", "Mushroom ( RM 8.00 )", "Papaya ( RM 5.00 )", "Pencil (RM 2.15 )", "Salt ( RM 4.00 )" });
            checkedListBox1.Location = new Point(12, 98);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(274, 109);
            checkedListBox1.Sorted = true;
            checkedListBox1.TabIndex = 1;
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Cursor = Cursors.No;
            priceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceLabel.Location = new Point(25, 222);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(55, 21);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Price : ";
            priceLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // priceValue
            // 
            priceValue.AutoSize = true;
            priceValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            priceValue.Location = new Point(69, 222);
            priceValue.Name = "priceValue";
            priceValue.Size = new Size(68, 21);
            priceValue.TabIndex = 3;
            priceValue.Text = "RM 0.00";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.ControlLightLight;
            progressBar1.Location = new Point(12, 30);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(477, 23);
            progressBar1.TabIndex = 4;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(25, 248);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(49, 21);
            totalLabel.TabIndex = 5;
            totalLabel.Text = "Total :";
            // 
            // totalValue
            // 
            totalValue.AutoSize = true;
            totalValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalValue.Location = new Point(69, 248);
            totalValue.Name = "totalValue";
            totalValue.Size = new Size(68, 21);
            totalValue.TabIndex = 6;
            totalValue.Text = "RM 0.00";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // createdBy
            // 
            createdBy.AutoSize = true;
            createdBy.Font = new Font("Carlito", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            createdBy.Location = new Point(139, 371);
            createdBy.Name = "createdBy";
            createdBy.Size = new Size(198, 14);
            createdBy.TabIndex = 7;
            createdBy.Text = "Created By: Zakiah Zulkefli (Nov 2024)";
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Cursor = Cursors.No;
            resultLabel.Font = new Font("Elephant", 15.7499981F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            resultLabel.ForeColor = Color.FromArgb(0, 192, 0);
            resultLabel.Location = new Point(114, 68);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(0, 27);
            resultLabel.TabIndex = 8;
            // 
            // Cashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Beige;
            ClientSize = new Size(501, 395);
            Controls.Add(resultLabel);
            Controls.Add(createdBy);
            Controls.Add(totalValue);
            Controls.Add(totalLabel);
            Controls.Add(progressBar1);
            Controls.Add(priceValue);
            Controls.Add(priceLabel);
            Controls.Add(checkedListBox1);
            Controls.Add(numpad);
            KeyPreview = true;
            MaximizeBox = false;
            Name = "Cashier";
            Text = "Cashier";
            KeyDown += Cashier_KeyDown;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView numpad;
        private CheckedListBox checkedListBox1;
        private Label priceLabel;
        private Label priceValue;
        private ProgressBar progressBar1;
        private Label totalLabel;
        private ToolTip toolTip1;
        private Label totalValue;
        private System.Windows.Forms.Timer timer;
        private Label createdBy;
        private Label resultLabel;
        private ColorDialog colorDialog1;
        private BindingSource bindingSource1;
    }
}
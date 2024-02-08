namespace dataGridView
{
    partial class Form1
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
            this.controlPanel = new System.Windows.Forms.Panel();
            this.addRowBtn = new System.Windows.Forms.Button();
            this.addColBtn = new System.Windows.Forms.Button();
            this.userDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.displayBox = new System.Windows.Forms.RichTextBox();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.displayBox);
            this.controlPanel.Controls.Add(this.addRowBtn);
            this.controlPanel.Controls.Add(this.addColBtn);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Location = new System.Drawing.Point(914, 0);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(170, 611);
            this.controlPanel.TabIndex = 0;
            // 
            // addRowBtn
            // 
            this.addRowBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addRowBtn.Location = new System.Drawing.Point(0, 511);
            this.addRowBtn.Name = "addRowBtn";
            this.addRowBtn.Size = new System.Drawing.Size(170, 50);
            this.addRowBtn.TabIndex = 1;
            this.addRowBtn.Text = "Add Row";
            this.addRowBtn.UseVisualStyleBackColor = true;
            this.addRowBtn.Click += new System.EventHandler(this.addRowBtn_Click);
            // 
            // addColBtn
            // 
            this.addColBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addColBtn.Location = new System.Drawing.Point(0, 561);
            this.addColBtn.Name = "addColBtn";
            this.addColBtn.Size = new System.Drawing.Size(170, 50);
            this.addColBtn.TabIndex = 0;
            this.addColBtn.Text = "Add Column";
            this.addColBtn.UseVisualStyleBackColor = true;
            this.addColBtn.Click += new System.EventHandler(this.addColBtn_Click);
            // 
            // userDGV
            // 
            this.userDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.userDGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userDGV.Location = new System.Drawing.Point(0, 0);
            this.userDGV.Name = "userDGV";
            this.userDGV.RowHeadersVisible = false;
            this.userDGV.Size = new System.Drawing.Size(914, 611);
            this.userDGV.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // displayBox
            // 
            this.displayBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.displayBox.Location = new System.Drawing.Point(0, 0);
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(170, 444);
            this.displayBox.TabIndex = 2;
            this.displayBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 611);
            this.Controls.Add(this.userDGV);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.controlPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Button addColBtn;
        private System.Windows.Forms.Button addRowBtn;
        private System.Windows.Forms.DataGridView userDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.RichTextBox displayBox;
    }
}


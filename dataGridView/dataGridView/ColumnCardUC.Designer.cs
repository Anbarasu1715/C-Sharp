namespace dataGridView
{
    partial class ColumnCardUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.colNameTB = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.warnLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // colNameTB
            // 
            this.colNameTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.colNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colNameTB.Location = new System.Drawing.Point(0, 50);
            this.colNameTB.Multiline = true;
            this.colNameTB.Name = "colNameTB";
            this.colNameTB.Size = new System.Drawing.Size(300, 40);
            this.colNameTB.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 48);
            this.button1.TabIndex = 3;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warnLbl
            // 
            this.warnLbl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.warnLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.warnLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.warnLbl.ForeColor = System.Drawing.Color.Red;
            this.warnLbl.Location = new System.Drawing.Point(0, 90);
            this.warnLbl.Name = "warnLbl";
            this.warnLbl.Size = new System.Drawing.Size(300, 40);
            this.warnLbl.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 50);
            this.label2.TabIndex = 5;
            this.label2.Text = "Column Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox
            // 
            this.comboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "string",
            "checkBox",
            "link",
            "comboBox",
            "Button",
            "image"});
            this.comboBox.Location = new System.Drawing.Point(0, 180);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(300, 24);
            this.comboBox.TabIndex = 6;
            this.comboBox.Text = "Choose Type";
            // 
            // ColumnCardUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.warnLbl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.colNameTB);
            this.Controls.Add(this.label1);
            this.Name = "ColumnCardUC";
            this.Size = new System.Drawing.Size(300, 274);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox colNameTB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label warnLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox;
    }
}

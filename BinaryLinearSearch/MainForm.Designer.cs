namespace BinaryLinearSearch
{
    partial class MainForm
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
            this.initArray_Btn = new System.Windows.Forms.Button();
            this.find_Btn = new System.Windows.Forms.Button();
            this.binarySearch_RBtn = new System.Windows.Forms.RadioButton();
            this.linearSearch_RBtn = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.arrayView_Lbl = new System.Windows.Forms.Label();
            this.searchType_Lbl = new System.Windows.Forms.Label();
            this.count_Lbl = new System.Windows.Forms.Label();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // initArray_Btn
            // 
            this.initArray_Btn.Location = new System.Drawing.Point(12, 46);
            this.initArray_Btn.Name = "initArray_Btn";
            this.initArray_Btn.Size = new System.Drawing.Size(75, 23);
            this.initArray_Btn.TabIndex = 0;
            this.initArray_Btn.Text = "Init array";
            this.initArray_Btn.UseVisualStyleBackColor = true;
            this.initArray_Btn.Click += new System.EventHandler(this.initArray_Btn_Click);
            // 
            // find_Btn
            // 
            this.find_Btn.Location = new System.Drawing.Point(102, 12);
            this.find_Btn.Name = "find_Btn";
            this.find_Btn.Size = new System.Drawing.Size(75, 23);
            this.find_Btn.TabIndex = 2;
            this.find_Btn.Text = "Find";
            this.find_Btn.UseVisualStyleBackColor = true;
            this.find_Btn.Click += new System.EventHandler(this.find_Btn_Click);
            // 
            // binarySearch_RBtn
            // 
            this.binarySearch_RBtn.AutoSize = true;
            this.binarySearch_RBtn.Location = new System.Drawing.Point(3, 3);
            this.binarySearch_RBtn.Name = "binarySearch_RBtn";
            this.binarySearch_RBtn.Size = new System.Drawing.Size(54, 17);
            this.binarySearch_RBtn.TabIndex = 3;
            this.binarySearch_RBtn.Text = "Binary";
            this.binarySearch_RBtn.UseVisualStyleBackColor = true;
            this.binarySearch_RBtn.CheckedChanged += new System.EventHandler(this.binarySearch_RBtn_CheckedChanged);
            // 
            // linearSearch_RBtn
            // 
            this.linearSearch_RBtn.AutoSize = true;
            this.linearSearch_RBtn.Checked = true;
            this.linearSearch_RBtn.Location = new System.Drawing.Point(3, 26);
            this.linearSearch_RBtn.Name = "linearSearch_RBtn";
            this.linearSearch_RBtn.Size = new System.Drawing.Size(54, 17);
            this.linearSearch_RBtn.TabIndex = 4;
            this.linearSearch_RBtn.TabStop = true;
            this.linearSearch_RBtn.Text = "Linear";
            this.linearSearch_RBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.linearSearch_RBtn);
            this.panel1.Controls.Add(this.binarySearch_RBtn);
            this.panel1.Location = new System.Drawing.Point(209, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 51);
            this.panel1.TabIndex = 5;
            // 
            // arrayView_Lbl
            // 
            this.arrayView_Lbl.AutoSize = true;
            this.arrayView_Lbl.BackColor = System.Drawing.SystemColors.Window;
            this.arrayView_Lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrayView_Lbl.Location = new System.Drawing.Point(13, 102);
            this.arrayView_Lbl.Name = "arrayView_Lbl";
            this.arrayView_Lbl.Size = new System.Drawing.Size(2, 15);
            this.arrayView_Lbl.TabIndex = 6;
            this.arrayView_Lbl.Visible = false;
            // 
            // searchType_Lbl
            // 
            this.searchType_Lbl.AutoSize = true;
            this.searchType_Lbl.Location = new System.Drawing.Point(238, 7);
            this.searchType_Lbl.Name = "searchType_Lbl";
            this.searchType_Lbl.Size = new System.Drawing.Size(44, 13);
            this.searchType_Lbl.TabIndex = 7;
            this.searchType_Lbl.Text = "Search:";
            // 
            // count_Lbl
            // 
            this.count_Lbl.AutoSize = true;
            this.count_Lbl.Location = new System.Drawing.Point(253, 89);
            this.count_Lbl.Name = "count_Lbl";
            this.count_Lbl.Size = new System.Drawing.Size(0, 13);
            this.count_Lbl.TabIndex = 8;
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(13, 12);
            this.numericUpDown.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(206, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Count=";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.count_Lbl);
            this.Controls.Add(this.searchType_Lbl);
            this.Controls.Add(this.arrayView_Lbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.find_Btn);
            this.Controls.Add(this.initArray_Btn);
            this.Name = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button initArray_Btn;
        private System.Windows.Forms.Button find_Btn;
        private System.Windows.Forms.RadioButton binarySearch_RBtn;
        private System.Windows.Forms.RadioButton linearSearch_RBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label arrayView_Lbl;
        private System.Windows.Forms.Label searchType_Lbl;
        private System.Windows.Forms.Label count_Lbl;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label1;
    }
}


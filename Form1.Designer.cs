
namespace WatermarkAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pathBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.runBtn = new System.Windows.Forms.Button();
            this.wtrBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sizeBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.destBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.allPageCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // pathBox
            // 
            this.pathBox.Location = new System.Drawing.Point(168, 22);
            this.pathBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pathBox.Name = "pathBox";
            this.pathBox.Size = new System.Drawing.Size(297, 22);
            this.pathBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(472, 22);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add File";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(169, 171);
            this.nameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(297, 22);
            this.nameBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Watered Filename";
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(239, 268);
            this.runBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(136, 41);
            this.runBtn.TabIndex = 5;
            this.runBtn.Text = "Water Your PDF";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // wtrBox
            // 
            this.wtrBox.Location = new System.Drawing.Point(168, 75);
            this.wtrBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.wtrBox.Multiline = true;
            this.wtrBox.Name = "wtrBox";
            this.wtrBox.Size = new System.Drawing.Size(297, 81);
            this.wtrBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Watermark Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Font Size";
            // 
            // sizeBox
            // 
            this.sizeBox.FormattingEnabled = true;
            this.sizeBox.Items.AddRange(new object[] {
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32",
            "34",
            "36",
            "38",
            "40"});
            this.sizeBox.Location = new System.Drawing.Point(169, 200);
            this.sizeBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sizeBox.Name = "sizeBox";
            this.sizeBox.Size = new System.Drawing.Size(297, 24);
            this.sizeBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Destination Folder";
            // 
            // destBox
            // 
            this.destBox.Location = new System.Drawing.Point(169, 237);
            this.destBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.destBox.Name = "destBox";
            this.destBox.Size = new System.Drawing.Size(297, 22);
            this.destBox.TabIndex = 14;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(471, 237);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(127, 26);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Browse";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // allPageCheck
            // 
            this.allPageCheck.AutoSize = true;
            this.allPageCheck.Location = new System.Drawing.Point(205, 49);
            this.allPageCheck.Name = "allPageCheck";
            this.allPageCheck.Size = new System.Drawing.Size(170, 21);
            this.allPageCheck.TabIndex = 16;
            this.allPageCheck.Text = "Watermark All Pages?";
            this.allPageCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 320);
            this.Controls.Add(this.allPageCheck);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.destBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sizeBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.wtrBox);
            this.Controls.Add(this.runBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pathBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "WaterPDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox pathBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.TextBox wtrBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sizeBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox destBox;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.CheckBox allPageCheck;
    }
}


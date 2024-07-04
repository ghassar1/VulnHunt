
namespace VulnHunt
{
    partial class Main
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
            this.TabNMap = new System.Windows.Forms.TabControl();
            this.NMAP = new System.Windows.Forms.TabPage();
            this.RichTextArea1 = new System.Windows.Forms.RichTextBox();
            this.Btn_Scan = new System.Windows.Forms.Button();
            this.TextBox_IPRange = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMetasploit = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btn_autoScan = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox_serviceName = new System.Windows.Forms.TextBox();
            this.label_service = new System.Windows.Forms.Label();
            this.TabNMap.SuspendLayout();
            this.NMAP.SuspendLayout();
            this.tabMetasploit.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabNMap
            // 
            this.TabNMap.Controls.Add(this.NMAP);
            this.TabNMap.Controls.Add(this.tabMetasploit);
            this.TabNMap.Location = new System.Drawing.Point(0, 0);
            this.TabNMap.Name = "TabNMap";
            this.TabNMap.SelectedIndex = 0;
            this.TabNMap.Size = new System.Drawing.Size(644, 483);
            this.TabNMap.TabIndex = 2;
            // 
            // NMAP
            // 
            this.NMAP.Controls.Add(this.RichTextArea1);
            this.NMAP.Controls.Add(this.Btn_Scan);
            this.NMAP.Controls.Add(this.TextBox_IPRange);
            this.NMAP.Controls.Add(this.label1);
            this.NMAP.Location = new System.Drawing.Point(4, 24);
            this.NMAP.Name = "NMAP";
            this.NMAP.Padding = new System.Windows.Forms.Padding(3);
            this.NMAP.Size = new System.Drawing.Size(636, 455);
            this.NMAP.TabIndex = 0;
            this.NMAP.Text = "Nmap Scan";
            this.NMAP.UseVisualStyleBackColor = true;
            // 
            // RichTextArea1
            // 
            this.RichTextArea1.Location = new System.Drawing.Point(8, 51);
            this.RichTextArea1.Name = "RichTextArea1";
            this.RichTextArea1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.RichTextArea1.Size = new System.Drawing.Size(621, 395);
            this.RichTextArea1.TabIndex = 5;
            this.RichTextArea1.Text = "";
            this.RichTextArea1.TextChanged += new System.EventHandler(this.RichTextArea_TextChanged);
            // 
            // Btn_Scan
            // 
            this.Btn_Scan.Location = new System.Drawing.Point(318, 12);
            this.Btn_Scan.Name = "Btn_Scan";
            this.Btn_Scan.Size = new System.Drawing.Size(75, 23);
            this.Btn_Scan.TabIndex = 4;
            this.Btn_Scan.Text = "Scan";
            this.Btn_Scan.UseVisualStyleBackColor = true;
            this.Btn_Scan.Click += new System.EventHandler(this.Btn_Scan_Click);
            // 
            // TextBox_IPRange
            // 
            this.TextBox_IPRange.AccessibleDescription = "";
            this.TextBox_IPRange.Location = new System.Drawing.Point(79, 12);
            this.TextBox_IPRange.Name = "TextBox_IPRange";
            this.TextBox_IPRange.PlaceholderText = "Enter IP range to scan";
            this.TextBox_IPRange.Size = new System.Drawing.Size(217, 23);
            this.TextBox_IPRange.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP Range:";
            // 
            // tabMetasploit
            // 
            this.tabMetasploit.Controls.Add(this.richTextBox1);
            this.tabMetasploit.Controls.Add(this.btn_autoScan);
            this.tabMetasploit.Controls.Add(this.btnSearch);
            this.tabMetasploit.Controls.Add(this.textBox_serviceName);
            this.tabMetasploit.Controls.Add(this.label_service);
            this.tabMetasploit.Location = new System.Drawing.Point(4, 24);
            this.tabMetasploit.Name = "tabMetasploit";
            this.tabMetasploit.Padding = new System.Windows.Forms.Padding(3);
            this.tabMetasploit.Size = new System.Drawing.Size(636, 455);
            this.tabMetasploit.TabIndex = 1;
            this.tabMetasploit.Text = "Metasploit";
            this.tabMetasploit.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 47);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(621, 402);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // btn_autoScan
            // 
            this.btn_autoScan.Location = new System.Drawing.Point(380, 20);
            this.btn_autoScan.Name = "btn_autoScan";
            this.btn_autoScan.Size = new System.Drawing.Size(75, 23);
            this.btn_autoScan.TabIndex = 3;
            this.btn_autoScan.Text = "Auto Scan";
            this.btn_autoScan.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(279, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox_serviceName
            // 
            this.textBox_serviceName.Location = new System.Drawing.Point(96, 18);
            this.textBox_serviceName.Name = "textBox_serviceName";
            this.textBox_serviceName.Size = new System.Drawing.Size(154, 23);
            this.textBox_serviceName.TabIndex = 1;
            // 
            // label_service
            // 
            this.label_service.AutoSize = true;
            this.label_service.Location = new System.Drawing.Point(8, 21);
            this.label_service.Name = "label_service";
            this.label_service.Size = new System.Drawing.Size(82, 15);
            this.label_service.TabIndex = 0;
            this.label_service.Text = "Service Name:";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 482);
            this.Controls.Add(this.TabNMap);
            this.Name = "Main";
            this.Text = "Form1";
            this.TabNMap.ResumeLayout(false);
            this.NMAP.ResumeLayout(false);
            this.NMAP.PerformLayout();
            this.tabMetasploit.ResumeLayout(false);
            this.tabMetasploit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabNMap;
        private System.Windows.Forms.TabPage NMAP;
        private System.Windows.Forms.Button Btn_Scan;
        private System.Windows.Forms.TextBox TextBox_IPRange;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabMetasploit;
        private System.Windows.Forms.RichTextBox RichTextArea1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btn_autoScan;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox_serviceName;
        private System.Windows.Forms.Label label_service;
    }
}


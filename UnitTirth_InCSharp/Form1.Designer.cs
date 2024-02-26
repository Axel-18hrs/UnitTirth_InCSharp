namespace UnitTirth_InCSharp
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label1 = new Label();
            dgvTableCSV = new DataGridView();
            label9 = new Label();
            btnDeleteCSV = new Button();
            btnSearchCSV = new Button();
            txtSearchCSV = new TextBox();
            btnSaveCSV = new Button();
            btnOpenCSV = new Button();
            tabPage2 = new TabPage();
            tvJSON = new TreeView();
            btnOpenJSON = new Button();
            label2 = new Label();
            tabPage3 = new TabPage();
            tvXML = new TreeView();
            btnOpenXML = new Button();
            label3 = new Label();
            tabPage4 = new TabPage();
            label6 = new Label();
            btnOpenTXT = new Button();
            label5 = new Label();
            txtSearchTXT = new TextBox();
            label4 = new Label();
            btnSearchTXT = new Button();
            lstResultados = new ListBox();
            lstDocumentTXT = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTableCSV).BeginInit();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(-3, -1);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1010, 512);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.Gray;
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(dgvTableCSV);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(btnDeleteCSV);
            tabPage1.Controls.Add(btnSearchCSV);
            tabPage1.Controls.Add(txtSearchCSV);
            tabPage1.Controls.Add(btnSaveCSV);
            tabPage1.Controls.Add(btnOpenCSV);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1002, 479);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "CSV";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(107, 57);
            label1.Name = "label1";
            label1.Size = new Size(225, 46);
            label1.TabIndex = 34;
            label1.Text = "CSV Manager";
            // 
            // dgvTableCSV
            // 
            dgvTableCSV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTableCSV.Location = new Point(107, 106);
            dgvTableCSV.Name = "dgvTableCSV";
            dgvTableCSV.RowHeadersVisible = false;
            dgvTableCSV.RowHeadersWidth = 51;
            dgvTableCSV.Size = new Size(531, 228);
            dgvTableCSV.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F);
            label9.Location = new Point(680, 142);
            label9.Name = "label9";
            label9.Size = new Size(114, 24);
            label9.TabIndex = 29;
            label9.Text = "Text to search";
            // 
            // btnDeleteCSV
            // 
            btnDeleteCSV.Font = new Font("Arial Narrow", 10.8F);
            btnDeleteCSV.Location = new Point(680, 273);
            btnDeleteCSV.Name = "btnDeleteCSV";
            btnDeleteCSV.Size = new Size(160, 46);
            btnDeleteCSV.TabIndex = 28;
            btnDeleteCSV.Text = "Delete";
            btnDeleteCSV.UseVisualStyleBackColor = true;
            btnDeleteCSV.Click += btnDeleteCSV_Click;
            // 
            // btnSearchCSV
            // 
            btnSearchCSV.Font = new Font("Arial Narrow", 10.8F);
            btnSearchCSV.Location = new Point(680, 221);
            btnSearchCSV.Name = "btnSearchCSV";
            btnSearchCSV.Size = new Size(160, 46);
            btnSearchCSV.TabIndex = 23;
            btnSearchCSV.Text = "Search";
            btnSearchCSV.UseVisualStyleBackColor = true;
            btnSearchCSV.Click += btnSearchCSV_Click;
            // 
            // txtSearchCSV
            // 
            txtSearchCSV.Location = new Point(680, 169);
            txtSearchCSV.Name = "txtSearchCSV";
            txtSearchCSV.Size = new Size(205, 27);
            txtSearchCSV.TabIndex = 20;
            // 
            // btnSaveCSV
            // 
            btnSaveCSV.Font = new Font("Arial Narrow", 10.8F);
            btnSaveCSV.Location = new Point(273, 352);
            btnSaveCSV.Name = "btnSaveCSV";
            btnSaveCSV.Size = new Size(160, 46);
            btnSaveCSV.TabIndex = 19;
            btnSaveCSV.Text = "Save";
            btnSaveCSV.UseVisualStyleBackColor = true;
            btnSaveCSV.Click += btnSaveCSV_Click;
            // 
            // btnOpenCSV
            // 
            btnOpenCSV.Font = new Font("Arial Narrow", 10.8F);
            btnOpenCSV.Location = new Point(107, 352);
            btnOpenCSV.Name = "btnOpenCSV";
            btnOpenCSV.Size = new Size(160, 45);
            btnOpenCSV.TabIndex = 18;
            btnOpenCSV.Text = "Open";
            btnOpenCSV.UseVisualStyleBackColor = true;
            btnOpenCSV.Click += btnOpenCSV_Click;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gray;
            tabPage2.Controls.Add(tvJSON);
            tabPage2.Controls.Add(btnOpenJSON);
            tabPage2.Controls.Add(label2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1002, 479);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "JSON";
            // 
            // tvJSON
            // 
            tvJSON.Location = new Point(22, 97);
            tvJSON.Name = "tvJSON";
            tvJSON.Size = new Size(756, 290);
            tvJSON.TabIndex = 36;
            // 
            // btnOpenJSON
            // 
            btnOpenJSON.Font = new Font("Arial Narrow", 10.8F);
            btnOpenJSON.Location = new Point(21, 393);
            btnOpenJSON.Name = "btnOpenJSON";
            btnOpenJSON.Size = new Size(160, 45);
            btnOpenJSON.TabIndex = 35;
            btnOpenJSON.Text = "Open";
            btnOpenJSON.UseVisualStyleBackColor = true;
            btnOpenJSON.Click += btnOpenJSON_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 38);
            label2.Name = "label2";
            label2.Size = new Size(217, 46);
            label2.TabIndex = 33;
            label2.Text = "JSON Viewer";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Gray;
            tabPage3.Controls.Add(tvXML);
            tabPage3.Controls.Add(btnOpenXML);
            tabPage3.Controls.Add(label3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(1002, 479);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "XML";
            // 
            // tvXML
            // 
            tvXML.Location = new Point(124, 98);
            tvXML.Name = "tvXML";
            tvXML.Size = new Size(756, 290);
            tvXML.TabIndex = 39;
            // 
            // btnOpenXML
            // 
            btnOpenXML.Font = new Font("Arial Narrow", 10.8F);
            btnOpenXML.Location = new Point(123, 394);
            btnOpenXML.Name = "btnOpenXML";
            btnOpenXML.Size = new Size(160, 45);
            btnOpenXML.TabIndex = 38;
            btnOpenXML.Text = "Open";
            btnOpenXML.UseVisualStyleBackColor = true;
            btnOpenXML.Click += btnOpenXML_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 39);
            label3.Name = "label3";
            label3.Size = new Size(196, 46);
            label3.TabIndex = 37;
            label3.Text = "XML Viewer";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Gray;
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(lstDocumentTXT);
            tabPage4.Controls.Add(btnOpenTXT);
            tabPage4.Controls.Add(label5);
            tabPage4.Controls.Add(txtSearchTXT);
            tabPage4.Controls.Add(label4);
            tabPage4.Controls.Add(btnSearchTXT);
            tabPage4.Controls.Add(lstResultados);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(1002, 479);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "TXT";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(714, 60);
            label6.Name = "label6";
            label6.Size = new Size(128, 46);
            label6.TabIndex = 45;
            label6.Text = "Results";
            // 
            // btnOpenTXT
            // 
            btnOpenTXT.Font = new Font("Arial Narrow", 10.8F);
            btnOpenTXT.Location = new Point(38, 398);
            btnOpenTXT.Name = "btnOpenTXT";
            btnOpenTXT.Size = new Size(160, 45);
            btnOpenTXT.TabIndex = 43;
            btnOpenTXT.Text = "Open";
            btnOpenTXT.UseVisualStyleBackColor = true;
            btnOpenTXT.Click += btnOpenTXT_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(38, 60);
            label5.Name = "label5";
            label5.Size = new Size(270, 46);
            label5.TabIndex = 42;
            label5.Text = "TEXT Document ";
            // 
            // txtSearchTXT
            // 
            txtSearchTXT.Location = new Point(449, 136);
            txtSearchTXT.Name = "txtSearchTXT";
            txtSearchTXT.Size = new Size(205, 27);
            txtSearchTXT.TabIndex = 41;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F);
            label4.Location = new Point(449, 109);
            label4.Name = "label4";
            label4.Size = new Size(114, 24);
            label4.TabIndex = 40;
            label4.Text = "Text to search";
            // 
            // btnSearchTXT
            // 
            btnSearchTXT.Font = new Font("Arial Narrow", 10.8F);
            btnSearchTXT.Location = new Point(449, 169);
            btnSearchTXT.Name = "btnSearchTXT";
            btnSearchTXT.Size = new Size(160, 45);
            btnSearchTXT.TabIndex = 39;
            btnSearchTXT.Text = "Search";
            btnSearchTXT.UseVisualStyleBackColor = true;
            btnSearchTXT.Click += btnSearchTXT_Click;
            // 
            // lstResultados
            // 
            lstResultados.FormattingEnabled = true;
            lstResultados.Location = new Point(714, 109);
            lstResultados.Name = "lstResultados";
            lstResultados.Size = new Size(244, 284);
            lstResultados.TabIndex = 0;
            // 
            // lstDocumentTXT
            // 
            lstDocumentTXT.FormattingEnabled = true;
            lstDocumentTXT.Location = new Point(38, 109);
            lstDocumentTXT.Name = "lstDocumentTXT";
            lstDocumentTXT.Size = new Size(405, 284);
            lstDocumentTXT.TabIndex = 44;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 505);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTableCSV).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label9;
        private Button btnDeleteCSV;
        private Button btnSearchCSV;
        private TextBox txtSearchCSV;
        private Button btnSaveCSV;
        private Button btnOpenCSV;
        private DataGridView dgvTableCSV;
        private Button btnOpenJSON;
        private Label label2;
        private TreeView tvJSON;
        private Label label1;
        private TabPage tabPage3;
        private TreeView tvXML;
        private Button btnOpenXML;
        private Label label3;
        private TabPage tabPage4;
        private Button btnSearchTXT;
        private TextBox txtSearchTXT;
        private Label label4;
        private Label label5;
        private Button btnOpenTXT;
        private Label label6;
        private ListBox lstDocumentTXT;
        private ListBox lstResultados;
    }
}

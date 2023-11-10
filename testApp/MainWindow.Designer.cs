
namespace LRTapp
{
    partial class mainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainWindow));
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.buttonMeasureL = new System.Windows.Forms.Button();
            this.buttonNew = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonSaveCSV = new System.Windows.Forms.Button();
            this.labelBattery = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonBCompositionUC = new System.Windows.Forms.Button();
            this.buttonMeasureUC = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.userControl11 = new LRTapp.UserControl1();
            this.userControl31 = new LRTapp.UserControl3();
            this.userControl21 = new LRTapp.UserControl2();
            this.buttonMeasureR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(12, 6);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(123, 46);
            this.buttonConnect.TabIndex = 1;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Enabled = false;
            this.buttonDisconnect.Location = new System.Drawing.Point(12, 58);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(123, 46);
            this.buttonDisconnect.TabIndex = 2;
            this.buttonDisconnect.Text = "Disconnect";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // buttonMeasureL
            // 
            this.buttonMeasureL.Enabled = false;
            this.buttonMeasureL.Location = new System.Drawing.Point(12, 120);
            this.buttonMeasureL.Name = "buttonMeasureL";
            this.buttonMeasureL.Size = new System.Drawing.Size(123, 46);
            this.buttonMeasureL.TabIndex = 3;
            this.buttonMeasureL.Text = "Measure Left";
            this.buttonMeasureL.UseVisualStyleBackColor = true;
            this.buttonMeasureL.Click += new System.EventHandler(this.buttonMeasureL_Click);
            // 
            // buttonNew
            // 
            this.buttonNew.Location = new System.Drawing.Point(15, 408);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(120, 46);
            this.buttonNew.TabIndex = 6;
            this.buttonNew.Text = "New Patient";
            this.buttonNew.UseVisualStyleBackColor = true;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Silver;
            this.progressBar1.Location = new System.Drawing.Point(15, 224);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(120, 20);
            this.progressBar1.TabIndex = 11;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AllowUserToResizeColumns = false;
            this.dataGridViewPatients.AllowUserToResizeRows = false;
            this.dataGridViewPatients.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridViewPatients.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.ColumnHeadersVisible = false;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.ColumnNote});
            this.dataGridViewPatients.Location = new System.Drawing.Point(15, 460);
            this.dataGridViewPatients.MultiSelect = false;
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.RowHeadersVisible = false;
            this.dataGridViewPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients.Size = new System.Drawing.Size(120, 147);
            this.dataGridViewPatients.TabIndex = 14;
            this.dataGridViewPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_CellClick);
            // 
            // ColumnName
            // 
            this.ColumnName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnName.FillWeight = 90F;
            this.ColumnName.HeaderText = "Name";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnNote
            // 
            this.ColumnNote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNote.FillWeight = 60F;
            this.ColumnNote.HeaderText = "Note";
            this.ColumnNote.Name = "ColumnNote";
            this.ColumnNote.ReadOnly = true;
            this.ColumnNote.Visible = false;
            // 
            // buttonSaveCSV
            // 
            this.buttonSaveCSV.Enabled = false;
            this.buttonSaveCSV.Location = new System.Drawing.Point(15, 250);
            this.buttonSaveCSV.Name = "buttonSaveCSV";
            this.buttonSaveCSV.Size = new System.Drawing.Size(120, 41);
            this.buttonSaveCSV.TabIndex = 5;
            this.buttonSaveCSV.Text = "SaveCSV";
            this.buttonSaveCSV.UseVisualStyleBackColor = true;
            this.buttonSaveCSV.Click += new System.EventHandler(this.buttonSaveCSV_Click);
            // 
            // labelBattery
            // 
            this.labelBattery.AutoSize = true;
            this.labelBattery.BackColor = System.Drawing.Color.Silver;
            this.labelBattery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelBattery.Location = new System.Drawing.Point(1016, 14);
            this.labelBattery.Name = "labelBattery";
            this.labelBattery.Size = new System.Drawing.Size(0, 13);
            this.labelBattery.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.buttonMeasureR);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonConnect);
            this.panel1.Controls.Add(this.buttonDisconnect);
            this.panel1.Controls.Add(this.buttonMeasureL);
            this.panel1.Controls.Add(this.dataGridViewPatients);
            this.panel1.Controls.Add(this.buttonSaveCSV);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.buttonNew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 610);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Silver;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(4, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Copyright 2020 Bodystat Ltd.";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.labelBattery);
            this.panel2.Controls.Add(this.labelTitle);
            this.panel2.Controls.Add(this.buttonBCompositionUC);
            this.panel2.Controls.Add(this.buttonMeasureUC);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1434, 41);
            this.panel2.TabIndex = 20;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelTitle.Location = new System.Drawing.Point(12, 14);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(161, 16);
            this.labelTitle.TabIndex = 18;
            this.labelTitle.Text = "Lymphostat Research Tool";
            // 
            // buttonBCompositionUC
            // 
            this.buttonBCompositionUC.Location = new System.Drawing.Point(455, 8);
            this.buttonBCompositionUC.Name = "buttonBCompositionUC";
            this.buttonBCompositionUC.Size = new System.Drawing.Size(89, 30);
            this.buttonBCompositionUC.TabIndex = 8;
            this.buttonBCompositionUC.Text = "2D Graph";
            this.buttonBCompositionUC.UseVisualStyleBackColor = true;
            this.buttonBCompositionUC.Click += new System.EventHandler(this.buttonBCompositionUC_Click);
            // 
            // buttonMeasureUC
            // 
            this.buttonMeasureUC.Location = new System.Drawing.Point(360, 8);
            this.buttonMeasureUC.Name = "buttonMeasureUC";
            this.buttonMeasureUC.Size = new System.Drawing.Size(89, 30);
            this.buttonMeasureUC.TabIndex = 7;
            this.buttonMeasureUC.Text = "Measure";
            this.buttonMeasureUC.UseVisualStyleBackColor = true;
            this.buttonMeasureUC.Click += new System.EventHandler(this.buttonMeasureUC_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1364, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(26, 24);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "|";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1396, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(26, 24);
            this.button3.TabIndex = 10;
            this.button3.TabStop = false;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // userControl11
            // 
            this.userControl11.AutoSize = true;
            this.userControl11.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.userControl11.BackColor = System.Drawing.Color.White;
            this.userControl11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl11.Location = new System.Drawing.Point(150, 41);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(1284, 610);
            this.userControl11.TabIndex = 24;
            // 
            // userControl31
            // 
            this.userControl31.AccessibleName = "";
            this.userControl31.BackColor = System.Drawing.Color.White;
            this.userControl31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl31.Location = new System.Drawing.Point(150, 41);
            this.userControl31.Name = "userControl31";
            this.userControl31.Size = new System.Drawing.Size(1284, 610);
            this.userControl31.TabIndex = 23;
            // 
            // userControl21
            // 
            this.userControl21.BackColor = System.Drawing.Color.White;
            this.userControl21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl21.Location = new System.Drawing.Point(150, 41);
            this.userControl21.Name = "userControl21";
            this.userControl21.Size = new System.Drawing.Size(1284, 610);
            this.userControl21.TabIndex = 22;
            // 
            // buttonMeasureR
            // 
            this.buttonMeasureR.Enabled = false;
            this.buttonMeasureR.Location = new System.Drawing.Point(12, 172);
            this.buttonMeasureR.Name = "buttonMeasureR";
            this.buttonMeasureR.Size = new System.Drawing.Size(123, 46);
            this.buttonMeasureR.TabIndex = 27;
            this.buttonMeasureR.Text = "Measure Right";
            this.buttonMeasureR.UseVisualStyleBackColor = true;
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1434, 651);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.userControl31);
            this.Controls.Add(this.userControl21);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainWindow";
            this.Text = "LRTapp";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button buttonMeasureL;
        private System.Windows.Forms.Button buttonNew;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonSaveCSV;
        private System.Windows.Forms.Label labelBattery;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBCompositionUC;
        private System.Windows.Forms.Button buttonMeasureUC;
        private UserControl2 userControl21;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNote;
        private UserControl3 userControl31;
        private System.Windows.Forms.Label labelTitle;
        private UserControl1 userControl11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonMeasureR;
    }
}


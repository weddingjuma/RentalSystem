﻿namespace WindowsFormsApplication1.Manager
{
    partial class manager_agent_details
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(manager_agent_details));
            this.label3 = new System.Windows.Forms.Label();
            this.pHome = new System.Windows.Forms.PictureBox();
            this.pAvailable = new System.Windows.Forms.PictureBox();
            this.pAgent = new System.Windows.Forms.PictureBox();
            this.pAddHouse = new System.Windows.Forms.PictureBox();
            this.pReser = new System.Windows.Forms.PictureBox();
            this.pClint = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboagentname = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pRent = new System.Windows.Forms.PictureBox();
            this.pReturn = new System.Windows.Forms.PictureBox();
            this.pExit = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.luname = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAvailable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAgent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAddHouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClint)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "LOGOUT";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // pHome
            // 
            this.pHome.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pHome.Image = ((System.Drawing.Image)(resources.GetObject("pHome.Image")));
            this.pHome.Location = new System.Drawing.Point(78, 31);
            this.pHome.Name = "pHome";
            this.pHome.Size = new System.Drawing.Size(69, 60);
            this.pHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pHome.TabIndex = 0;
            this.pHome.TabStop = false;
            this.toolTip1.SetToolTip(this.pHome, "Home");
            this.pHome.Click += new System.EventHandler(this.pHome_Click);
            // 
            // pAvailable
            // 
            this.pAvailable.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pAvailable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAvailable.Image = ((System.Drawing.Image)(resources.GetObject("pAvailable.Image")));
            this.pAvailable.Location = new System.Drawing.Point(153, 31);
            this.pAvailable.Name = "pAvailable";
            this.pAvailable.Size = new System.Drawing.Size(69, 60);
            this.pAvailable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAvailable.TabIndex = 1;
            this.pAvailable.TabStop = false;
            this.toolTip1.SetToolTip(this.pAvailable, "Avaliable\r\n  Houses");
            this.pAvailable.Click += new System.EventHandler(this.pAvailable_Click);
            // 
            // pAgent
            // 
            this.pAgent.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pAgent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAgent.Image = ((System.Drawing.Image)(resources.GetObject("pAgent.Image")));
            this.pAgent.Location = new System.Drawing.Point(228, 31);
            this.pAgent.Name = "pAgent";
            this.pAgent.Size = new System.Drawing.Size(69, 62);
            this.pAgent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAgent.TabIndex = 2;
            this.pAgent.TabStop = false;
            this.toolTip1.SetToolTip(this.pAgent, "Agent Details");
            // 
            // pAddHouse
            // 
            this.pAddHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pAddHouse.Image = ((System.Drawing.Image)(resources.GetObject("pAddHouse.Image")));
            this.pAddHouse.Location = new System.Drawing.Point(303, 31);
            this.pAddHouse.Name = "pAddHouse";
            this.pAddHouse.Size = new System.Drawing.Size(69, 62);
            this.pAddHouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pAddHouse.TabIndex = 3;
            this.pAddHouse.TabStop = false;
            this.toolTip1.SetToolTip(this.pAddHouse, "Add House");
            this.pAddHouse.Click += new System.EventHandler(this.pAddHouse_Click);
            // 
            // pReser
            // 
            this.pReser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pReser.Image = ((System.Drawing.Image)(resources.GetObject("pReser.Image")));
            this.pReser.Location = new System.Drawing.Point(378, 31);
            this.pReser.Name = "pReser";
            this.pReser.Size = new System.Drawing.Size(69, 62);
            this.pReser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pReser.TabIndex = 4;
            this.pReser.TabStop = false;
            this.toolTip1.SetToolTip(this.pReser, "Record Manager");
            this.pReser.Click += new System.EventHandler(this.pReser_Click);
            // 
            // pClint
            // 
            this.pClint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pClint.Image = ((System.Drawing.Image)(resources.GetObject("pClint.Image")));
            this.pClint.Location = new System.Drawing.Point(453, 31);
            this.pClint.Name = "pClint";
            this.pClint.Size = new System.Drawing.Size(69, 60);
            this.pClint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pClint.TabIndex = 5;
            this.pClint.TabStop = false;
            this.toolTip1.SetToolTip(this.pClint, "Clints\r\nDetails");
            this.pClint.Click += new System.EventHandler(this.pClint_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.l1);
            this.panel1.Controls.Add(this.listView2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboagentname);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Location = new System.Drawing.Point(11, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(820, 334);
            this.panel1.TabIndex = 6;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(665, 290);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(115, 23);
            this.btnGenerate.TabIndex = 51;
            this.btnGenerate.Text = "Generate Report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Old English Text MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l1.ForeColor = System.Drawing.Color.Snow;
            this.l1.Location = new System.Drawing.Point(65, 72);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(171, 32);
            this.l1.TabIndex = 50;
            this.l1.Text = "Agent Details";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView2.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView2.GridLines = true;
            this.listView2.LabelEdit = true;
            this.listView2.Location = new System.Drawing.Point(71, 107);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(709, 167);
            this.listView2.TabIndex = 49;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.Visible = false;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "House Number";
            this.columnHeader6.Width = 128;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "House Address";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 298;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Clint name";
            this.columnHeader8.Width = 118;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Booking Date";
            this.columnHeader9.Width = 157;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 48;
            this.button1.Text = "Show Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(319, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 47;
            this.label1.Text = "Search Details ";
            // 
            // comboagentname
            // 
            this.comboagentname.FormattingEnabled = true;
            this.comboagentname.Location = new System.Drawing.Point(449, 46);
            this.comboagentname.Name = "comboagentname";
            this.comboagentname.Size = new System.Drawing.Size(121, 21);
            this.comboagentname.TabIndex = 46;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Segoe UI Emoji", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.LabelEdit = true;
            this.listView1.Location = new System.Drawing.Point(71, 107);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(709, 123);
            this.listView1.TabIndex = 45;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Agent name";
            this.columnHeader1.Width = 128;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Managing Area";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 174;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Contact number";
            this.columnHeader3.Width = 107;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Username";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Password";
            this.columnHeader5.Width = 137;
            // 
            // pRent
            // 
            this.pRent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pRent.Cursor = System.Windows.Forms.Cursors.No;
            this.pRent.Image = ((System.Drawing.Image)(resources.GetObject("pRent.Image")));
            this.pRent.Location = new System.Drawing.Point(528, 31);
            this.pRent.Name = "pRent";
            this.pRent.Size = new System.Drawing.Size(69, 60);
            this.pRent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pRent.TabIndex = 6;
            this.pRent.TabStop = false;
            this.toolTip1.SetToolTip(this.pRent, "Only agent can acces");
            // 
            // pReturn
            // 
            this.pReturn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pReturn.Cursor = System.Windows.Forms.Cursors.No;
            this.pReturn.Image = ((System.Drawing.Image)(resources.GetObject("pReturn.Image")));
            this.pReturn.Location = new System.Drawing.Point(603, 31);
            this.pReturn.Name = "pReturn";
            this.pReturn.Size = new System.Drawing.Size(69, 60);
            this.pReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pReturn.TabIndex = 7;
            this.pReturn.TabStop = false;
            this.toolTip1.SetToolTip(this.pReturn, "Only agent can acces");
            // 
            // pExit
            // 
            this.pExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pExit.Image = ((System.Drawing.Image)(resources.GetObject("pExit.Image")));
            this.pExit.Location = new System.Drawing.Point(678, 31);
            this.pExit.Name = "pExit";
            this.pExit.Size = new System.Drawing.Size(69, 62);
            this.pExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pExit.TabIndex = 8;
            this.pExit.TabStop = false;
            this.toolTip1.SetToolTip(this.pExit, "Exit");
            this.pExit.Click += new System.EventHandler(this.pExit_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 11;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pHome, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.pAvailable, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.pAgent, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.pAddHouse, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.pReser, 5, 1);
            this.tableLayoutPanel3.Controls.Add(this.pClint, 6, 1);
            this.tableLayoutPanel3.Controls.Add(this.pRent, 7, 1);
            this.tableLayoutPanel3.Controls.Add(this.pReturn, 8, 1);
            this.tableLayoutPanel3.Controls.Add(this.pExit, 9, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 62);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.85075F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.14925F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(836, 96);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(3, 3);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(45, 41);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 9;
            this.pictureBox10.TabStop = false;
            // 
            // luname
            // 
            this.luname.AutoSize = true;
            this.luname.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luname.ForeColor = System.Drawing.Color.Coral;
            this.luname.Location = new System.Drawing.Point(54, 0);
            this.luname.Name = "luname";
            this.luname.Size = new System.Drawing.Size(88, 46);
            this.luname.TabIndex = 0;
            this.luname.Text = "\r\nUsername";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox10, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.luname, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(147, 47);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 10;
            this.toolTip1.AutoPopDelay = 0;
            this.toolTip1.InitialDelay = 0;
            this.toolTip1.ReshowDelay = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.06897F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.93103F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(842, 161);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // manager_agent_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(844, 556);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "manager_agent_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGENTS DETAILS";
            this.Load += new System.EventHandler(this.manager_agent_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAvailable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAgent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pAddHouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pClint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pExit)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pHome;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pAvailable;
        private System.Windows.Forms.PictureBox pAgent;
        private System.Windows.Forms.PictureBox pAddHouse;
        private System.Windows.Forms.PictureBox pReser;
        private System.Windows.Forms.PictureBox pClint;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pRent;
        private System.Windows.Forms.PictureBox pReturn;
        private System.Windows.Forms.PictureBox pExit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.Label luname;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboagentname;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button btnGenerate;
    }
}
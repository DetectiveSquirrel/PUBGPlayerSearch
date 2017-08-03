namespace PUBG_Player_Search
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
            this.RefreshButton = new System.Windows.Forms.Button();
            this.UserBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegionBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PlayerInformationGroup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LastPlacement = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LastDamage = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LastAssists = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.LastKills = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LastRaitingChange = new System.Windows.Forms.Label();
            this.LastRankChange = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Rank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RaitingLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RankLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlayerSearchGroup = new System.Windows.Forms.GroupBox();
            this.ModeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SeasonBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.APIKeyBox = new System.Windows.Forms.TextBox();
            this.PlayerInformationGroup.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.PlayerSearchGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshButton
            // 
            this.RefreshButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshButton.Location = new System.Drawing.Point(12, 12);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(407, 51);
            this.RefreshButton.TabIndex = 1;
            this.RefreshButton.TabStop = false;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserBox
            // 
            this.UserBox.Location = new System.Drawing.Point(45, 21);
            this.UserBox.Name = "UserBox";
            this.UserBox.Size = new System.Drawing.Size(133, 23);
            this.UserBox.TabIndex = 2;
            this.UserBox.TabStop = false;
            this.UserBox.TextChanged += new System.EventHandler(this.SaveSettings);
            this.UserBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "User:";
            // 
            // RegionBox
            // 
            this.RegionBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionBox.FormattingEnabled = true;
            this.RegionBox.Items.AddRange(new object[] {
            "Oceania",
            "North America",
            "South America",
            "Europe",
            "Asia",
            "South East Asia",
            "All Regions Combined"});
            this.RegionBox.Location = new System.Drawing.Point(265, 21);
            this.RegionBox.Name = "RegionBox";
            this.RegionBox.Size = new System.Drawing.Size(133, 23);
            this.RegionBox.TabIndex = 5;
            this.RegionBox.TabStop = false;
            this.RegionBox.SelectedIndexChanged += new System.EventHandler(this.SaveSettings);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(210, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Region:";
            // 
            // PlayerInformationGroup
            // 
            this.PlayerInformationGroup.Controls.Add(this.button1);
            this.PlayerInformationGroup.Controls.Add(this.groupBox1);
            this.PlayerInformationGroup.Controls.Add(this.listView1);
            this.PlayerInformationGroup.Controls.Add(this.RaitingLabel);
            this.PlayerInformationGroup.Controls.Add(this.label5);
            this.PlayerInformationGroup.Controls.Add(this.RankLabel);
            this.PlayerInformationGroup.Controls.Add(this.label3);
            this.PlayerInformationGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerInformationGroup.Location = new System.Drawing.Point(12, 161);
            this.PlayerInformationGroup.Name = "PlayerInformationGroup";
            this.PlayerInformationGroup.Size = new System.Drawing.Size(407, 514);
            this.PlayerInformationGroup.TabIndex = 7;
            this.PlayerInformationGroup.TabStop = false;
            this.PlayerInformationGroup.Text = "Stats";
            this.PlayerInformationGroup.Enter += new System.EventHandler(this.PlayerInformationGroup_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(265, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 51);
            this.button1.TabIndex = 10;
            this.button1.TabStop = false;
            this.button1.Text = "View On PUBG Tracker";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LastPlacement);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.LastDamage);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.LastAssists);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.LastKills);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.LastRaitingChange);
            this.groupBox1.Controls.Add(this.LastRankChange);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(7, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Last Known Game";
            // 
            // LastPlacement
            // 
            this.LastPlacement.AutoSize = true;
            this.LastPlacement.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastPlacement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastPlacement.Location = new System.Drawing.Point(107, 19);
            this.LastPlacement.Name = "LastPlacement";
            this.LastPlacement.Size = new System.Drawing.Size(73, 15);
            this.LastPlacement.TabIndex = 22;
            this.LastPlacement.Text = "Placeholder";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(5, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 15);
            this.label16.TabIndex = 21;
            this.label16.Text = "Placement:";
            // 
            // LastDamage
            // 
            this.LastDamage.AutoSize = true;
            this.LastDamage.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastDamage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastDamage.Location = new System.Drawing.Point(305, 49);
            this.LastDamage.Name = "LastDamage";
            this.LastDamage.Size = new System.Drawing.Size(73, 15);
            this.LastDamage.TabIndex = 20;
            this.LastDamage.Text = "Placeholder";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(203, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(58, 15);
            this.label14.TabIndex = 19;
            this.label14.Text = "Damage:";
            // 
            // LastAssists
            // 
            this.LastAssists.AutoSize = true;
            this.LastAssists.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastAssists.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastAssists.Location = new System.Drawing.Point(305, 34);
            this.LastAssists.Name = "LastAssists";
            this.LastAssists.Size = new System.Drawing.Size(73, 15);
            this.LastAssists.TabIndex = 18;
            this.LastAssists.Text = "Placeholder";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(203, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 15);
            this.label12.TabIndex = 17;
            this.label12.Text = "Assists:";
            // 
            // LastKills
            // 
            this.LastKills.AutoSize = true;
            this.LastKills.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastKills.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastKills.Location = new System.Drawing.Point(305, 19);
            this.LastKills.Name = "LastKills";
            this.LastKills.Size = new System.Drawing.Size(73, 15);
            this.LastKills.TabIndex = 16;
            this.LastKills.Text = "Placeholder";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(203, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Kills:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(5, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "Rank Change:";
            // 
            // LastRaitingChange
            // 
            this.LastRaitingChange.AutoSize = true;
            this.LastRaitingChange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastRaitingChange.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LastRaitingChange.Location = new System.Drawing.Point(107, 34);
            this.LastRaitingChange.Name = "LastRaitingChange";
            this.LastRaitingChange.Size = new System.Drawing.Size(73, 15);
            this.LastRaitingChange.TabIndex = 14;
            this.LastRaitingChange.Text = "Placeholder";
            // 
            // LastRankChange
            // 
            this.LastRankChange.AutoSize = true;
            this.LastRankChange.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastRankChange.Location = new System.Drawing.Point(107, 49);
            this.LastRankChange.Name = "LastRankChange";
            this.LastRankChange.Size = new System.Drawing.Size(73, 15);
            this.LastRankChange.TabIndex = 12;
            this.LastRankChange.Text = "Placeholder";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Raiting Change:";
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Stat,
            this.Value,
            this.Rank});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 136);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(392, 371);
            this.listView1.TabIndex = 9;
            this.listView1.TabStop = false;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // Stat
            // 
            this.Stat.Text = "Stat";
            this.Stat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Stat.Width = 165;
            // 
            // Value
            // 
            this.Value.Text = "Value";
            this.Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Value.Width = 98;
            // 
            // Rank
            // 
            this.Rank.Text = "Rank";
            this.Rank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Rank.Width = 108;
            // 
            // RaitingLabel
            // 
            this.RaitingLabel.AutoSize = true;
            this.RaitingLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaitingLabel.Location = new System.Drawing.Point(56, 34);
            this.RaitingLabel.Name = "RaitingLabel";
            this.RaitingLabel.Size = new System.Drawing.Size(73, 15);
            this.RaitingLabel.TabIndex = 3;
            this.RaitingLabel.Text = "Placeholder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Raiting:";
            // 
            // RankLabel
            // 
            this.RankLabel.AutoSize = true;
            this.RankLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RankLabel.Location = new System.Drawing.Point(56, 19);
            this.RankLabel.Name = "RankLabel";
            this.RankLabel.Size = new System.Drawing.Size(73, 15);
            this.RankLabel.TabIndex = 1;
            this.RankLabel.Text = "Placeholder";
            this.RankLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Rank:";
            // 
            // PlayerSearchGroup
            // 
            this.PlayerSearchGroup.Controls.Add(this.ModeBox);
            this.PlayerSearchGroup.Controls.Add(this.label6);
            this.PlayerSearchGroup.Controls.Add(this.SeasonBox);
            this.PlayerSearchGroup.Controls.Add(this.label4);
            this.PlayerSearchGroup.Controls.Add(this.label1);
            this.PlayerSearchGroup.Controls.Add(this.label2);
            this.PlayerSearchGroup.Controls.Add(this.UserBox);
            this.PlayerSearchGroup.Controls.Add(this.RegionBox);
            this.PlayerSearchGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerSearchGroup.Location = new System.Drawing.Point(12, 69);
            this.PlayerSearchGroup.Name = "PlayerSearchGroup";
            this.PlayerSearchGroup.Size = new System.Drawing.Size(407, 86);
            this.PlayerSearchGroup.TabIndex = 8;
            this.PlayerSearchGroup.TabStop = false;
            this.PlayerSearchGroup.Text = "Player Search";
            this.PlayerSearchGroup.Enter += new System.EventHandler(this.PlayerSearchGroup_Enter);
            // 
            // ModeBox
            // 
            this.ModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeBox.FormattingEnabled = true;
            this.ModeBox.Items.AddRange(new object[] {
            "Solo",
            "Duo",
            "Squad"});
            this.ModeBox.Location = new System.Drawing.Point(45, 48);
            this.ModeBox.Name = "ModeBox";
            this.ModeBox.Size = new System.Drawing.Size(133, 23);
            this.ModeBox.TabIndex = 11;
            this.ModeBox.TabStop = false;
            this.ModeBox.SelectedIndexChanged += new System.EventHandler(this.SaveSettings);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Season:";
            // 
            // SeasonBox
            // 
            this.SeasonBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonBox.FormattingEnabled = true;
            this.SeasonBox.Items.AddRange(new object[] {
            "Season 3",
            "Season 2",
            "Season 1"});
            this.SeasonBox.Location = new System.Drawing.Point(265, 48);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(133, 23);
            this.SeasonBox.TabIndex = 9;
            this.SeasonBox.TabStop = false;
            this.SeasonBox.SelectedIndexChanged += new System.EventHandler(this.SaveSettings);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mode:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.APIKeyBox);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 681);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox2.Size = new System.Drawing.Size(407, 47);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "API Key";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // APIKeyBox
            // 
            this.APIKeyBox.Location = new System.Drawing.Point(5, 18);
            this.APIKeyBox.Name = "APIKeyBox";
            this.APIKeyBox.PasswordChar = '*';
            this.APIKeyBox.Size = new System.Drawing.Size(395, 21);
            this.APIKeyBox.TabIndex = 12;
            this.APIKeyBox.TabStop = false;
            this.APIKeyBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.APIKeyBox.TextChanged += new System.EventHandler(this.SaveSettings);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(431, 742);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PlayerSearchGroup);
            this.Controls.Add(this.PlayerInformationGroup);
            this.Controls.Add(this.RefreshButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PUBG Player Search";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Move += new System.EventHandler(this.Form1_Move);
            this.PlayerInformationGroup.ResumeLayout(false);
            this.PlayerInformationGroup.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PlayerSearchGroup.ResumeLayout(false);
            this.PlayerSearchGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.TextBox UserBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox PlayerInformationGroup;
        private System.Windows.Forms.Label RaitingLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RankLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox PlayerSearchGroup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Stat;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader Rank;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox RegionBox;
        private System.Windows.Forms.ComboBox SeasonBox;
        private System.Windows.Forms.ComboBox ModeBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.Label LastRaitingChange;
        public System.Windows.Forms.Label LastRankChange;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label LastKills;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label LastPlacement;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label LastDamage;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label LastAssists;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox APIKeyBox;
    }
}


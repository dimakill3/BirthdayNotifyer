
namespace BirthdayNotifyer
{
    partial class NotifyerForm
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
            this.todayDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.FileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.dayLabel = new System.Windows.Forms.Label();
            this.notifyDay = new System.Windows.Forms.NumericUpDown();
            this.MainTabPanel = new System.Windows.Forms.TabControl();
            this.allFriendsTabPage = new System.Windows.Forms.TabPage();
            this.allFriendsTable = new System.Windows.Forms.DataGridView();
            this.closeBirthdaysTabPage = new System.Windows.Forms.TabPage();
            this.closeBirthdaysTable = new System.Windows.Forms.DataGridView();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifyDay)).BeginInit();
            this.MainTabPanel.SuspendLayout();
            this.allFriendsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allFriendsTable)).BeginInit();
            this.closeBirthdaysTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBirthdaysTable)).BeginInit();
            this.SuspendLayout();
            // 
            // todayDate
            // 
            this.todayDate.Location = new System.Drawing.Point(103, 42);
            this.todayDate.Name = "todayDate";
            this.todayDate.Size = new System.Drawing.Size(200, 20);
            this.todayDate.TabIndex = 0;
            this.todayDate.ValueChanged += new System.EventHandler(this.todayDate_ValueChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сегодня:";
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(553, 24);
            this.menu.TabIndex = 2;
            this.menu.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            this.FileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenFileMenuItem});
            this.FileMenuItem.Name = "FileMenuItem";
            this.FileMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileMenuItem.Text = "Файл";
            // 
            // OpenFileMenuItem
            // 
            this.OpenFileMenuItem.Name = "OpenFileMenuItem";
            this.OpenFileMenuItem.Size = new System.Drawing.Size(151, 22);
            this.OpenFileMenuItem.Text = "Сгенерироать";
            this.OpenFileMenuItem.Click += new System.EventHandler(this.OpenFileMenuItem_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(309, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Уведомлять за";
            // 
            // dayLabel
            // 
            this.dayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayLabel.Location = new System.Drawing.Point(471, 42);
            this.dayLabel.Name = "dayLabel";
            this.dayLabel.Size = new System.Drawing.Size(44, 20);
            this.dayLabel.TabIndex = 5;
            this.dayLabel.Text = "дней";
            // 
            // notifyDay
            // 
            this.notifyDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.notifyDay.Location = new System.Drawing.Point(421, 42);
            this.notifyDay.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.notifyDay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.notifyDay.Name = "notifyDay";
            this.notifyDay.Size = new System.Drawing.Size(44, 20);
            this.notifyDay.TabIndex = 6;
            this.notifyDay.Tag = "";
            this.notifyDay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.notifyDay.ValueChanged += new System.EventHandler(this.notifyDay_ValueChanged);
            // 
            // MainTabPanel
            // 
            this.MainTabPanel.Controls.Add(this.allFriendsTabPage);
            this.MainTabPanel.Controls.Add(this.closeBirthdaysTabPage);
            this.MainTabPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainTabPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTabPanel.Location = new System.Drawing.Point(0, 81);
            this.MainTabPanel.Name = "MainTabPanel";
            this.MainTabPanel.SelectedIndex = 0;
            this.MainTabPanel.Size = new System.Drawing.Size(553, 291);
            this.MainTabPanel.TabIndex = 9;
            // 
            // allFriendsTabPage
            // 
            this.allFriendsTabPage.Controls.Add(this.allFriendsTable);
            this.allFriendsTabPage.Location = new System.Drawing.Point(4, 24);
            this.allFriendsTabPage.Name = "allFriendsTabPage";
            this.allFriendsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.allFriendsTabPage.Size = new System.Drawing.Size(545, 263);
            this.allFriendsTabPage.TabIndex = 1;
            this.allFriendsTabPage.Text = "Все друзья";
            this.allFriendsTabPage.UseVisualStyleBackColor = true;
            // 
            // allFriendsTable
            // 
            this.allFriendsTable.AllowUserToAddRows = false;
            this.allFriendsTable.AllowUserToDeleteRows = false;
            this.allFriendsTable.AllowUserToResizeRows = false;
            this.allFriendsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.allFriendsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.allFriendsTable.Location = new System.Drawing.Point(3, 3);
            this.allFriendsTable.MultiSelect = false;
            this.allFriendsTable.Name = "allFriendsTable";
            this.allFriendsTable.ReadOnly = true;
            this.allFriendsTable.RowHeadersVisible = false;
            this.allFriendsTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.allFriendsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.allFriendsTable.Size = new System.Drawing.Size(539, 257);
            this.allFriendsTable.TabIndex = 0;
            this.allFriendsTable.TabStop = false;
            this.allFriendsTable.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allFriendsTable_CellDoubleClick);
            // 
            // closeBirthdaysTabPage
            // 
            this.closeBirthdaysTabPage.Controls.Add(this.closeBirthdaysTable);
            this.closeBirthdaysTabPage.Location = new System.Drawing.Point(4, 24);
            this.closeBirthdaysTabPage.Name = "closeBirthdaysTabPage";
            this.closeBirthdaysTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.closeBirthdaysTabPage.Size = new System.Drawing.Size(545, 263);
            this.closeBirthdaysTabPage.TabIndex = 0;
            this.closeBirthdaysTabPage.Text = "Близжайшие дни рождения";
            this.closeBirthdaysTabPage.UseVisualStyleBackColor = true;
            // 
            // closeBirthdaysTable
            // 
            this.closeBirthdaysTable.AllowUserToAddRows = false;
            this.closeBirthdaysTable.AllowUserToDeleteRows = false;
            this.closeBirthdaysTable.AllowUserToResizeRows = false;
            this.closeBirthdaysTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.closeBirthdaysTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBirthdaysTable.Location = new System.Drawing.Point(3, 3);
            this.closeBirthdaysTable.MultiSelect = false;
            this.closeBirthdaysTable.Name = "closeBirthdaysTable";
            this.closeBirthdaysTable.ReadOnly = true;
            this.closeBirthdaysTable.RowHeadersVisible = false;
            this.closeBirthdaysTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.closeBirthdaysTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.closeBirthdaysTable.Size = new System.Drawing.Size(539, 257);
            this.closeBirthdaysTable.TabIndex = 0;
            this.closeBirthdaysTable.TabStop = false;
            // 
            // NotifyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 372);
            this.Controls.Add(this.MainTabPanel);
            this.Controls.Add(this.notifyDay);
            this.Controls.Add(this.dayLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.todayDate);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.MinimumSize = new System.Drawing.Size(569, 411);
            this.Name = "NotifyerForm";
            this.Text = "Напоминатор";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifyDay)).EndInit();
            this.MainTabPanel.ResumeLayout(false);
            this.allFriendsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allFriendsTable)).EndInit();
            this.closeBirthdaysTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.closeBirthdaysTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker todayDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem FileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenFileMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label dayLabel;
        private System.Windows.Forms.NumericUpDown notifyDay;
        private System.Windows.Forms.TabControl MainTabPanel;
        private System.Windows.Forms.TabPage closeBirthdaysTabPage;
        private System.Windows.Forms.DataGridView closeBirthdaysTable;
        private System.Windows.Forms.TabPage allFriendsTabPage;
        private System.Windows.Forms.DataGridView allFriendsTable;
    }
}


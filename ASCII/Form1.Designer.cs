namespace ASCII {
    partial class ASCIIWindow {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ASCIIWindow));
            this.tableMain = new System.Windows.Forms.TableLayoutPanel();
            this.description = new System.Windows.Forms.Label();
            this.tableOptions = new System.Windows.Forms.TableLayoutPanel();
            this.closeButton = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.trackOpaque = new System.Windows.Forms.TrackBar();
            this.labelOpaque = new System.Windows.Forms.Label();
            this.charPanel = new System.Windows.Forms.ListView();
            this.columnHeaderHex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderChar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableMain.SuspendLayout();
            this.tableOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpaque)).BeginInit();
            this.SuspendLayout();
            // 
            // tableMain
            // 
            this.tableMain.BackColor = System.Drawing.Color.Transparent;
            this.tableMain.ColumnCount = 2;
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableMain.Controls.Add(this.description, 1, 1);
            this.tableMain.Controls.Add(this.tableOptions, 1, 0);
            this.tableMain.Controls.Add(this.charPanel, 0, 0);
            this.tableMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableMain.Location = new System.Drawing.Point(0, 0);
            this.tableMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableMain.Name = "tableMain";
            this.tableMain.RowCount = 3;
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableMain.Size = new System.Drawing.Size(432, 432);
            this.tableMain.TabIndex = 0;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.BackColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(217, 113);
            this.description.Margin = new System.Windows.Forms.Padding(1);
            this.description.Name = "description";
            this.description.Padding = new System.Windows.Forms.Padding(4);
            this.description.Size = new System.Drawing.Size(176, 92);
            this.description.TabIndex = 10;
            this.description.Text = "Created by voltavidTony\r\non April 28, 2021\r\nVersion 1.2\r\n\r\nWindows 1252\r\nDouble c" +
    "lick to insert";
            this.description.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableOptions
            // 
            this.tableOptions.AutoSize = true;
            this.tableOptions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableOptions.BackColor = System.Drawing.Color.White;
            this.tableOptions.ColumnCount = 2;
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableOptions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableOptions.Controls.Add(this.closeButton, 1, 0);
            this.tableOptions.Controls.Add(this.title, 0, 0);
            this.tableOptions.Controls.Add(this.checkBox1, 0, 1);
            this.tableOptions.Controls.Add(this.checkBox2, 0, 2);
            this.tableOptions.Controls.Add(this.checkBox3, 0, 3);
            this.tableOptions.Controls.Add(this.trackOpaque, 0, 4);
            this.tableOptions.Controls.Add(this.labelOpaque, 1, 4);
            this.tableOptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableOptions.Location = new System.Drawing.Point(217, 1);
            this.tableOptions.Margin = new System.Windows.Forms.Padding(1);
            this.tableOptions.Name = "tableOptions";
            this.tableOptions.RowCount = 5;
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOptions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableOptions.Size = new System.Drawing.Size(214, 110);
            this.tableOptions.TabIndex = 2;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Transparent;
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.closeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(33)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Location = new System.Drawing.Point(169, 0);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(45, 30);
            this.closeButton.TabIndex = 3;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.Paint += new System.Windows.Forms.PaintEventHandler(this.CloseButton_Paint);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.title.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(0, 0);
            this.title.Margin = new System.Windows.Forms.Padding(0);
            this.title.Name = "title";
            this.title.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.title.Size = new System.Drawing.Size(169, 30);
            this.title.TabIndex = 4;
            this.title.Text = "ASCII";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelDrag_MouseDown);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.tableOptions.SetColumnSpan(this.checkBox1, 2);
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.Location = new System.Drawing.Point(3, 30);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(211, 20);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Show Control Characters";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.tableOptions.SetColumnSpan(this.checkBox2, 2);
            this.checkBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox2.Location = new System.Drawing.Point(3, 50);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(211, 20);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Sort Lexicographically";
            this.checkBox2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.tableOptions.SetColumnSpan(this.checkBox3, 2);
            this.checkBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox3.Location = new System.Drawing.Point(3, 70);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(211, 20);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Transparency";
            this.checkBox3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckStateChanged += new System.EventHandler(this.CheckBox_CheckStateChanged);
            // 
            // trackOpaque
            // 
            this.trackOpaque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackOpaque.LargeChange = 10;
            this.trackOpaque.Location = new System.Drawing.Point(0, 90);
            this.trackOpaque.Margin = new System.Windows.Forms.Padding(0);
            this.trackOpaque.Maximum = 100;
            this.trackOpaque.Minimum = 50;
            this.trackOpaque.Name = "trackOpaque";
            this.trackOpaque.Size = new System.Drawing.Size(169, 20);
            this.trackOpaque.SmallChange = 5;
            this.trackOpaque.TabIndex = 8;
            this.trackOpaque.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackOpaque.Value = 100;
            this.trackOpaque.ValueChanged += new System.EventHandler(this.TrackOpaque_ValueChanged);
            // 
            // labelOpaque
            // 
            this.labelOpaque.AutoSize = true;
            this.labelOpaque.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOpaque.Location = new System.Drawing.Point(169, 90);
            this.labelOpaque.Margin = new System.Windows.Forms.Padding(0);
            this.labelOpaque.Name = "labelOpaque";
            this.labelOpaque.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.labelOpaque.Size = new System.Drawing.Size(45, 20);
            this.labelOpaque.TabIndex = 9;
            this.labelOpaque.Text = "100 %";
            this.labelOpaque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // charPanel
            // 
            this.charPanel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.charPanel.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderHex,
            this.columnHeaderValue,
            this.columnHeaderChar});
            this.charPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.charPanel.FullRowSelect = true;
            this.charPanel.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.charPanel.HideSelection = false;
            this.charPanel.LabelWrap = false;
            this.charPanel.Location = new System.Drawing.Point(1, 1);
            this.charPanel.Margin = new System.Windows.Forms.Padding(1);
            this.charPanel.MultiSelect = false;
            this.charPanel.Name = "charPanel";
            this.tableMain.SetRowSpan(this.charPanel, 3);
            this.charPanel.Size = new System.Drawing.Size(214, 430);
            this.charPanel.TabIndex = 1;
            this.charPanel.TileSize = new System.Drawing.Size(60, 50);
            this.charPanel.UseCompatibleStateImageBehavior = false;
            this.charPanel.View = System.Windows.Forms.View.Details;
            this.charPanel.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.CharPanel_ColumnWidthChanging);
            this.charPanel.DoubleClick += new System.EventHandler(this.CharPanel_DoubleClick);
            // 
            // columnHeaderHex
            // 
            this.columnHeaderHex.Text = "Hex";
            this.columnHeaderHex.Width = 50;
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            // 
            // columnHeaderChar
            // 
            this.columnHeaderChar.Text = "Character";
            this.columnHeaderChar.Width = 80;
            // 
            // ASCIIWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Lime;
            this.ClientSize = new System.Drawing.Size(432, 432);
            this.Controls.Add(this.tableMain);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ASCIIWindow";
            this.ShowInTaskbar = false;
            this.Text = "ASCII";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Lime;
            this.tableMain.ResumeLayout(false);
            this.tableMain.PerformLayout();
            this.tableOptions.ResumeLayout(false);
            this.tableOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackOpaque)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableMain;
        private System.Windows.Forms.TableLayoutPanel tableOptions;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TrackBar trackOpaque;
        private System.Windows.Forms.Label labelOpaque;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView charPanel;
        private System.Windows.Forms.ColumnHeader columnHeaderHex;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.ColumnHeader columnHeaderChar;
    }
}


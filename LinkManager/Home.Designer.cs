namespace LinkManager
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.groupBoxControl = new System.Windows.Forms.GroupBox();
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxLinks = new System.Windows.Forms.GroupBox();
            this.dataGridViewLinks = new System.Windows.Forms.DataGridView();
            this.groupBoxControl.SuspendLayout();
            this.panelControl.SuspendLayout();
            this.groupBoxLinks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinks)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxControl
            // 
            this.groupBoxControl.Controls.Add(this.panelControl);
            this.groupBoxControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBoxControl.Location = new System.Drawing.Point(0, 395);
            this.groupBoxControl.Name = "groupBoxControl";
            this.groupBoxControl.Size = new System.Drawing.Size(593, 59);
            this.groupBoxControl.TabIndex = 0;
            this.groupBoxControl.TabStop = false;
            this.groupBoxControl.Text = "Control";
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.buttonUpdate);
            this.panelControl.Controls.Add(this.buttonAdd);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl.Location = new System.Drawing.Point(369, 16);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(221, 40);
            this.panelControl.TabIndex = 1;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(56, 8);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(137, 8);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxLinks
            // 
            this.groupBoxLinks.Controls.Add(this.dataGridViewLinks);
            this.groupBoxLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxLinks.Location = new System.Drawing.Point(0, 0);
            this.groupBoxLinks.Name = "groupBoxLinks";
            this.groupBoxLinks.Size = new System.Drawing.Size(593, 395);
            this.groupBoxLinks.TabIndex = 1;
            this.groupBoxLinks.TabStop = false;
            this.groupBoxLinks.Text = "Links";
            // 
            // dataGridViewLinks
            // 
            this.dataGridViewLinks.AllowUserToAddRows = false;
            this.dataGridViewLinks.AllowUserToDeleteRows = false;
            this.dataGridViewLinks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLinks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewLinks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLinks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewLinks.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewLinks.Name = "dataGridViewLinks";
            this.dataGridViewLinks.ReadOnly = true;
            this.dataGridViewLinks.RowHeadersVisible = false;
            this.dataGridViewLinks.Size = new System.Drawing.Size(587, 376);
            this.dataGridViewLinks.TabIndex = 0;
            this.dataGridViewLinks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLinks_CellClick);
            this.dataGridViewLinks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLinks_CellContentClick);
            this.dataGridViewLinks.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewLinks_CellContentDoubleClick);
            this.dataGridViewLinks.SelectionChanged += new System.EventHandler(this.dataGridViewLinks_SelectionChanged);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 454);
            this.Controls.Add(this.groupBoxLinks);
            this.Controls.Add(this.groupBoxControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.groupBoxControl.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.groupBoxLinks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLinks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxControl;
        private System.Windows.Forms.GroupBox groupBoxLinks;
        private System.Windows.Forms.DataGridView dataGridViewLinks;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonAdd;
    }
}
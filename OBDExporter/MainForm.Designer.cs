namespace OBDExporter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.objectsTabControl = new System.Windows.Forms.TabControl();
            this.itemsTabPage = new System.Windows.Forms.TabPage();
            this.itemsListBox = new OpenTibia.Controls.ThingTypeListBox();
            this.outfitsTabPage = new System.Windows.Forms.TabPage();
            this.outfitsListBox = new OpenTibia.Controls.ThingTypeListBox();
            this.effectsTabPage = new System.Windows.Forms.TabPage();
            this.effectsListBox = new OpenTibia.Controls.ThingTypeListBox();
            this.missilesTabPage = new System.Windows.Forms.TabPage();
            this.missilesListBox = new OpenTibia.Controls.ThingTypeListBox();
            this.versionsComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obdVersionLabel = new System.Windows.Forms.Label();
            this.obdVersionComboBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.thingTypeListBox = new OpenTibia.Controls.ThingTypeListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.versionsLabel = new System.Windows.Forms.Label();
            this.objectsTabControl.SuspendLayout();
            this.itemsTabPage.SuspendLayout();
            this.outfitsTabPage.SuspendLayout();
            this.effectsTabPage.SuspendLayout();
            this.missilesTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // objectsTabControl
            // 
            this.objectsTabControl.Controls.Add(this.itemsTabPage);
            this.objectsTabControl.Controls.Add(this.outfitsTabPage);
            this.objectsTabControl.Controls.Add(this.effectsTabPage);
            this.objectsTabControl.Controls.Add(this.missilesTabPage);
            this.objectsTabControl.Location = new System.Drawing.Point(13, 13);
            this.objectsTabControl.Name = "objectsTabControl";
            this.objectsTabControl.SelectedIndex = 0;
            this.objectsTabControl.Size = new System.Drawing.Size(213, 536);
            this.objectsTabControl.TabIndex = 0;
            // 
            // itemsTabPage
            // 
            this.itemsTabPage.Controls.Add(this.itemsListBox);
            this.itemsTabPage.Location = new System.Drawing.Point(4, 22);
            this.itemsTabPage.Name = "itemsTabPage";
            this.itemsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.itemsTabPage.Size = new System.Drawing.Size(205, 510);
            this.itemsTabPage.TabIndex = 0;
            this.itemsTabPage.Text = "Items";
            this.itemsTabPage.UseVisualStyleBackColor = true;
            // 
            // itemsListBox
            // 
            this.itemsListBox.Client = null;
            this.itemsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(3, 3);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.itemsListBox.Size = new System.Drawing.Size(199, 504);
            this.itemsListBox.TabIndex = 0;
            // 
            // outfitsTabPage
            // 
            this.outfitsTabPage.Controls.Add(this.outfitsListBox);
            this.outfitsTabPage.Location = new System.Drawing.Point(4, 22);
            this.outfitsTabPage.Name = "outfitsTabPage";
            this.outfitsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.outfitsTabPage.Size = new System.Drawing.Size(205, 510);
            this.outfitsTabPage.TabIndex = 1;
            this.outfitsTabPage.Text = "Outfits";
            this.outfitsTabPage.UseVisualStyleBackColor = true;
            // 
            // outfitsListBox
            // 
            this.outfitsListBox.Client = null;
            this.outfitsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outfitsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.outfitsListBox.FormattingEnabled = true;
            this.outfitsListBox.Location = new System.Drawing.Point(3, 3);
            this.outfitsListBox.Name = "outfitsListBox";
            this.outfitsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.outfitsListBox.Size = new System.Drawing.Size(199, 504);
            this.outfitsListBox.TabIndex = 0;
            // 
            // effectsTabPage
            // 
            this.effectsTabPage.Controls.Add(this.effectsListBox);
            this.effectsTabPage.Location = new System.Drawing.Point(4, 22);
            this.effectsTabPage.Name = "effectsTabPage";
            this.effectsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.effectsTabPage.Size = new System.Drawing.Size(205, 510);
            this.effectsTabPage.TabIndex = 2;
            this.effectsTabPage.Text = "Effects";
            this.effectsTabPage.UseVisualStyleBackColor = true;
            // 
            // effectsListBox
            // 
            this.effectsListBox.Client = null;
            this.effectsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.effectsListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.effectsListBox.FormattingEnabled = true;
            this.effectsListBox.Location = new System.Drawing.Point(3, 3);
            this.effectsListBox.Name = "effectsListBox";
            this.effectsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.effectsListBox.Size = new System.Drawing.Size(199, 504);
            this.effectsListBox.TabIndex = 0;
            // 
            // missilesTabPage
            // 
            this.missilesTabPage.Controls.Add(this.missilesListBox);
            this.missilesTabPage.Location = new System.Drawing.Point(4, 22);
            this.missilesTabPage.Name = "missilesTabPage";
            this.missilesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.missilesTabPage.Size = new System.Drawing.Size(205, 510);
            this.missilesTabPage.TabIndex = 3;
            this.missilesTabPage.Text = "Missiles";
            this.missilesTabPage.UseVisualStyleBackColor = true;
            // 
            // missilesListBox
            // 
            this.missilesListBox.Client = null;
            this.missilesListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.missilesListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.missilesListBox.FormattingEnabled = true;
            this.missilesListBox.Location = new System.Drawing.Point(3, 3);
            this.missilesListBox.Name = "missilesListBox";
            this.missilesListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.missilesListBox.Size = new System.Drawing.Size(199, 504);
            this.missilesListBox.TabIndex = 0;
            // 
            // versionsComboBox
            // 
            this.versionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.versionsComboBox.FormattingEnabled = true;
            this.versionsComboBox.Location = new System.Drawing.Point(9, 32);
            this.versionsComboBox.Name = "versionsComboBox";
            this.versionsComboBox.Size = new System.Drawing.Size(157, 21);
            this.versionsComboBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.obdVersionLabel);
            this.groupBox1.Controls.Add(this.obdVersionComboBox);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.removeButton);
            this.groupBox1.Controls.Add(this.addButton);
            this.groupBox1.Controls.Add(this.thingTypeListBox);
            this.groupBox1.Controls.Add(this.saveButton);
            this.groupBox1.Controls.Add(this.loadButton);
            this.groupBox1.Controls.Add(this.progressBar);
            this.groupBox1.Controls.Add(this.versionsLabel);
            this.groupBox1.Controls.Add(this.versionsComboBox);
            this.groupBox1.Location = new System.Drawing.Point(233, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(539, 515);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // obdVersionLabel
            // 
            this.obdVersionLabel.AutoSize = true;
            this.obdVersionLabel.Location = new System.Drawing.Point(176, 16);
            this.obdVersionLabel.Name = "obdVersionLabel";
            this.obdVersionLabel.Size = new System.Drawing.Size(71, 13);
            this.obdVersionLabel.TabIndex = 11;
            this.obdVersionLabel.Text = "OBD Version:";
            // 
            // obdVersionComboBox
            // 
            this.obdVersionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.obdVersionComboBox.FormattingEnabled = true;
            this.obdVersionComboBox.Location = new System.Drawing.Point(179, 32);
            this.obdVersionComboBox.Name = "obdVersionComboBox";
            this.obdVersionComboBox.Size = new System.Drawing.Size(147, 21);
            this.obdVersionComboBox.TabIndex = 10;
            this.obdVersionComboBox.SelectedIndexChanged += new System.EventHandler(this.ObdVersionComboBox_SelectedIndexChanged);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(468, 486);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(65, 23);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(403, 486);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(59, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(334, 486);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(63, 23);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // thingTypeListBox
            // 
            this.thingTypeListBox.Client = null;
            this.thingTypeListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.thingTypeListBox.FormattingEnabled = true;
            this.thingTypeListBox.Location = new System.Drawing.Point(334, 16);
            this.thingTypeListBox.Name = "thingTypeListBox";
            this.thingTypeListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.thingTypeListBox.Size = new System.Drawing.Size(199, 460);
            this.thingTypeListBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(91, 457);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(9, 457);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(9, 486);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(157, 23);
            this.progressBar.TabIndex = 3;
            // 
            // versionsLabel
            // 
            this.versionsLabel.AutoSize = true;
            this.versionsLabel.Location = new System.Drawing.Point(6, 16);
            this.versionsLabel.Name = "versionsLabel";
            this.versionsLabel.Size = new System.Drawing.Size(74, 13);
            this.versionsLabel.TabIndex = 2;
            this.versionsLabel.Text = "Client Version:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.objectsTabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "OBDExporter";
            this.objectsTabControl.ResumeLayout(false);
            this.itemsTabPage.ResumeLayout(false);
            this.outfitsTabPage.ResumeLayout(false);
            this.effectsTabPage.ResumeLayout(false);
            this.missilesTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl objectsTabControl;
        private System.Windows.Forms.TabPage itemsTabPage;
        private System.Windows.Forms.TabPage outfitsTabPage;
        private System.Windows.Forms.TabPage effectsTabPage;
        private System.Windows.Forms.TabPage missilesTabPage;
        private OpenTibia.Controls.ThingTypeListBox itemsListBox;
        private OpenTibia.Controls.ThingTypeListBox outfitsListBox;
        private OpenTibia.Controls.ThingTypeListBox effectsListBox;
        private OpenTibia.Controls.ThingTypeListBox missilesListBox;
        private System.Windows.Forms.ComboBox versionsComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label versionsLabel;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private OpenTibia.Controls.ThingTypeListBox thingTypeListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label obdVersionLabel;
        private System.Windows.Forms.ComboBox obdVersionComboBox;
    }
}


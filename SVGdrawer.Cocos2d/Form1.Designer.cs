namespace LvLEditor.Windows
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
            this.clearColor2 = new System.Windows.Forms.ComboBox();
            this.vertexColor3b = new System.Windows.Forms.ComboBox();
            this.vertexColor2b = new System.Windows.Forms.ComboBox();
            this.vertexColor1b = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsClear = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAddTriangle = new System.Windows.Forms.ToolStripButton();
            this.btnAddCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSelection = new System.Windows.Forms.ToolStripButton();
            this.btnMove = new System.Windows.Forms.ToolStripButton();
            this.spinningTriangleControl1 = new LvLEditor.Windows.DrawingPanelControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clearColor2
            // 
            this.clearColor2.DropDownHeight = 500;
            this.clearColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clearColor2.FormattingEnabled = true;
            this.clearColor2.IntegralHeight = false;
            this.clearColor2.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.clearColor2.Location = new System.Drawing.Point(339, 52);
            this.clearColor2.Name = "clearColor2";
            this.clearColor2.Size = new System.Drawing.Size(103, 21);
            this.clearColor2.TabIndex = 7;
            this.clearColor2.SelectedIndexChanged += new System.EventHandler(this.clearColor2_SelectedIndexChanged);
            // 
            // vertexColor3b
            // 
            this.vertexColor3b.DropDownHeight = 500;
            this.vertexColor3b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexColor3b.FormattingEnabled = true;
            this.vertexColor3b.IntegralHeight = false;
            this.vertexColor3b.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.vertexColor3b.Location = new System.Drawing.Point(230, 52);
            this.vertexColor3b.Name = "vertexColor3b";
            this.vertexColor3b.Size = new System.Drawing.Size(103, 21);
            this.vertexColor3b.TabIndex = 6;
            this.vertexColor3b.SelectedIndexChanged += new System.EventHandler(this.vertexColor_SelectedIndexChanged);
            // 
            // vertexColor2b
            // 
            this.vertexColor2b.DropDownHeight = 500;
            this.vertexColor2b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexColor2b.FormattingEnabled = true;
            this.vertexColor2b.IntegralHeight = false;
            this.vertexColor2b.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.vertexColor2b.Location = new System.Drawing.Point(121, 52);
            this.vertexColor2b.Name = "vertexColor2b";
            this.vertexColor2b.Size = new System.Drawing.Size(103, 21);
            this.vertexColor2b.TabIndex = 5;
            this.vertexColor2b.SelectedIndexChanged += new System.EventHandler(this.vertexColor_SelectedIndexChanged);
            // 
            // vertexColor1b
            // 
            this.vertexColor1b.DropDownHeight = 500;
            this.vertexColor1b.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.vertexColor1b.FormattingEnabled = true;
            this.vertexColor1b.IntegralHeight = false;
            this.vertexColor1b.Items.AddRange(new object[] {
            "BurlyWood",
            "Chartreuse",
            "Coral",
            "CornflowerBlue",
            "Cornsilk",
            "Firebrick",
            "Fuchsia",
            "Goldenrod",
            "Indigo",
            "Tan",
            "Teal",
            "Thistle",
            "Tomato"});
            this.vertexColor1b.Location = new System.Drawing.Point(12, 52);
            this.vertexColor1b.Name = "vertexColor1b";
            this.vertexColor1b.Size = new System.Drawing.Size(103, 21);
            this.vertexColor1b.TabIndex = 4;
            this.vertexColor1b.SelectedIndexChanged += new System.EventHandler(this.vertexColor_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(792, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsClear,
            this.tsExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tsClear
            // 
            this.tsClear.Name = "tsClear";
            this.tsClear.Size = new System.Drawing.Size(101, 22);
            this.tsClear.Text = "Clear";
            // 
            // tsExit
            // 
            this.tsExit.Name = "tsExit";
            this.tsExit.Size = new System.Drawing.Size(101, 22);
            this.tsExit.Text = "Exit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTriangle,
            this.btnAddCircle,
            this.toolStripSeparator1,
            this.btnSelection,
            this.btnMove});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(792, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAddTriangle
            // 
            this.btnAddTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddTriangle.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTriangle.Image")));
            this.btnAddTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTriangle.Name = "btnAddTriangle";
            this.btnAddTriangle.Size = new System.Drawing.Size(23, 22);
            this.btnAddTriangle.Text = "Triangle";
            // 
            // btnAddCircle
            // 
            this.btnAddCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnAddCircle.Image")));
            this.btnAddCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddCircle.Name = "btnAddCircle";
            this.btnAddCircle.Size = new System.Drawing.Size(23, 22);
            this.btnAddCircle.Text = "Square";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSelection
            // 
            this.btnSelection.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSelection.Image = ((System.Drawing.Image)(resources.GetObject("btnSelection.Image")));
            this.btnSelection.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(23, 22);
            this.btnSelection.Text = "Select";
            // 
            // btnMove
            // 
            this.btnMove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnMove.Image = ((System.Drawing.Image)(resources.GetObject("btnMove.Image")));
            this.btnMove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(23, 22);
            this.btnMove.Text = "Move";
            // 
            // spinningTriangleControl1
            // 
            this.spinningTriangleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinningTriangleControl1.BackColor = System.Drawing.Color.Black;
            this.spinningTriangleControl1.Location = new System.Drawing.Point(12, 79);
            this.spinningTriangleControl1.Name = "spinningTriangleControl1";
            this.spinningTriangleControl1.Size = new System.Drawing.Size(768, 482);
            this.spinningTriangleControl1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 573);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.clearColor2);
            this.Controls.Add(this.spinningTriangleControl1);
            this.Controls.Add(this.vertexColor3b);
            this.Controls.Add(this.vertexColor1b);
            this.Controls.Add(this.vertexColor2b);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "LvLEditor v0.000001";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox vertexColor3b;
        private System.Windows.Forms.ComboBox vertexColor2b;
        private System.Windows.Forms.ComboBox vertexColor1b;
        private DrawingPanelControl spinningTriangleControl1;
        private System.Windows.Forms.ComboBox clearColor2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsClear;
        private System.Windows.Forms.ToolStripMenuItem tsExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAddTriangle;
        private System.Windows.Forms.ToolStripButton btnAddCircle;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSelection;
        private System.Windows.Forms.ToolStripButton btnMove;
    }
}


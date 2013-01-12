namespace binary_calculator
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelExp = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.numericUpDownExponent = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNum1 = new System.Windows.Forms.Button();
            this.buttonNum3 = new System.Windows.Forms.Button();
            this.buttonNum2 = new System.Windows.Forms.Button();
            this.buttonNum4 = new System.Windows.Forms.Button();
            this.buttonNum5 = new System.Windows.Forms.Button();
            this.buttonNum6 = new System.Windows.Forms.Button();
            this.buttonNum7 = new System.Windows.Forms.Button();
            this.buttonNum0 = new System.Windows.Forms.Button();
            this.buttonNum8 = new System.Windows.Forms.Button();
            this.buttonNum9 = new System.Windows.Forms.Button();
            this.buttonNumA = new System.Windows.Forms.Button();
            this.buttonNumB = new System.Windows.Forms.Button();
            this.buttonNumC = new System.Windows.Forms.Button();
            this.buttonNumD = new System.Windows.Forms.Button();
            this.buttonNumE = new System.Windows.Forms.Button();
            this.buttonNumF = new System.Windows.Forms.Button();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonNeg = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unsignedIntergersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signedIntegersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floatNonIEEE754ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleFloatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.numberBasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryBase2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.octalBase8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decimalBase10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexidecimalBase16ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExponent)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.menuStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(209, 237);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(60, 23);
            this.buttonClear.TabIndex = 14;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelExp
            // 
            this.labelExp.AutoSize = true;
            this.labelExp.Location = new System.Drawing.Point(206, 306);
            this.labelExp.Name = "labelExp";
            this.labelExp.Size = new System.Drawing.Size(103, 13);
            this.labelExp.TabIndex = 7;
            this.labelExp.Text = "exponent bit amount";
            this.labelExp.Visible = false;
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(209, 267);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(27, 13);
            this.labelSize.TabIndex = 6;
            this.labelSize.Text = "Size";
            // 
            // numericUpDownExponent
            // 
            this.numericUpDownExponent.Location = new System.Drawing.Point(209, 322);
            this.numericUpDownExponent.Name = "numericUpDownExponent";
            this.numericUpDownExponent.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownExponent.TabIndex = 4;
            this.numericUpDownExponent.Visible = false;
            this.numericUpDownExponent.ValueChanged += new System.EventHandler(this.numericUpDownExponent_ValueChanged);
            this.numericUpDownExponent.Click += new System.EventHandler(this.numericUpDownExponent_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(0, 27);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(301, 183);
            this.textBox1.TabIndex = 0;
            // 
            // buttonNum1
            // 
            this.buttonNum1.Location = new System.Drawing.Point(15, 35);
            this.buttonNum1.Name = "buttonNum1";
            this.buttonNum1.Size = new System.Drawing.Size(33, 23);
            this.buttonNum1.TabIndex = 15;
            this.buttonNum1.Text = "1";
            this.buttonNum1.UseVisualStyleBackColor = true;
            this.buttonNum1.Click += new System.EventHandler(this.buttonNum1_Click);
            // 
            // buttonNum3
            // 
            this.buttonNum3.Location = new System.Drawing.Point(85, 35);
            this.buttonNum3.Name = "buttonNum3";
            this.buttonNum3.Size = new System.Drawing.Size(33, 23);
            this.buttonNum3.TabIndex = 16;
            this.buttonNum3.Text = "3";
            this.buttonNum3.UseVisualStyleBackColor = true;
            this.buttonNum3.Click += new System.EventHandler(this.buttonNum3_Click);
            // 
            // buttonNum2
            // 
            this.buttonNum2.Location = new System.Drawing.Point(50, 35);
            this.buttonNum2.Name = "buttonNum2";
            this.buttonNum2.Size = new System.Drawing.Size(33, 23);
            this.buttonNum2.TabIndex = 17;
            this.buttonNum2.Text = "2";
            this.buttonNum2.UseVisualStyleBackColor = true;
            this.buttonNum2.Click += new System.EventHandler(this.buttonNum2_Click);
            // 
            // buttonNum4
            // 
            this.buttonNum4.Location = new System.Drawing.Point(120, 35);
            this.buttonNum4.Name = "buttonNum4";
            this.buttonNum4.Size = new System.Drawing.Size(33, 23);
            this.buttonNum4.TabIndex = 18;
            this.buttonNum4.Text = "4";
            this.buttonNum4.UseVisualStyleBackColor = true;
            this.buttonNum4.Click += new System.EventHandler(this.buttonNum4_Click);
            // 
            // buttonNum5
            // 
            this.buttonNum5.Location = new System.Drawing.Point(155, 35);
            this.buttonNum5.Name = "buttonNum5";
            this.buttonNum5.Size = new System.Drawing.Size(33, 23);
            this.buttonNum5.TabIndex = 19;
            this.buttonNum5.Text = "5";
            this.buttonNum5.UseVisualStyleBackColor = true;
            this.buttonNum5.Click += new System.EventHandler(this.buttonNum5_Click);
            // 
            // buttonNum6
            // 
            this.buttonNum6.Location = new System.Drawing.Point(15, 65);
            this.buttonNum6.Name = "buttonNum6";
            this.buttonNum6.Size = new System.Drawing.Size(33, 23);
            this.buttonNum6.TabIndex = 20;
            this.buttonNum6.Text = "6";
            this.buttonNum6.UseVisualStyleBackColor = true;
            this.buttonNum6.Click += new System.EventHandler(this.buttonNum6_Click);
            // 
            // buttonNum7
            // 
            this.buttonNum7.Location = new System.Drawing.Point(50, 65);
            this.buttonNum7.Name = "buttonNum7";
            this.buttonNum7.Size = new System.Drawing.Size(33, 23);
            this.buttonNum7.TabIndex = 21;
            this.buttonNum7.Text = "7";
            this.buttonNum7.UseVisualStyleBackColor = true;
            this.buttonNum7.Click += new System.EventHandler(this.buttonNum7_Click);
            // 
            // buttonNum0
            // 
            this.buttonNum0.Location = new System.Drawing.Point(15, 5);
            this.buttonNum0.Name = "buttonNum0";
            this.buttonNum0.Size = new System.Drawing.Size(33, 23);
            this.buttonNum0.TabIndex = 22;
            this.buttonNum0.Text = "0";
            this.buttonNum0.UseVisualStyleBackColor = true;
            this.buttonNum0.Click += new System.EventHandler(this.buttonNum0_Click);
            // 
            // buttonNum8
            // 
            this.buttonNum8.Location = new System.Drawing.Point(85, 65);
            this.buttonNum8.Name = "buttonNum8";
            this.buttonNum8.Size = new System.Drawing.Size(33, 23);
            this.buttonNum8.TabIndex = 23;
            this.buttonNum8.Text = "8";
            this.buttonNum8.UseVisualStyleBackColor = true;
            this.buttonNum8.Click += new System.EventHandler(this.buttonNum8_Click);
            // 
            // buttonNum9
            // 
            this.buttonNum9.Location = new System.Drawing.Point(120, 65);
            this.buttonNum9.Name = "buttonNum9";
            this.buttonNum9.Size = new System.Drawing.Size(33, 23);
            this.buttonNum9.TabIndex = 24;
            this.buttonNum9.Text = "9";
            this.buttonNum9.UseVisualStyleBackColor = true;
            this.buttonNum9.Click += new System.EventHandler(this.buttonNum9_Click);
            // 
            // buttonNumA
            // 
            this.buttonNumA.Enabled = false;
            this.buttonNumA.Location = new System.Drawing.Point(155, 65);
            this.buttonNumA.Name = "buttonNumA";
            this.buttonNumA.Size = new System.Drawing.Size(33, 23);
            this.buttonNumA.TabIndex = 25;
            this.buttonNumA.Text = "A";
            this.buttonNumA.UseVisualStyleBackColor = true;
            this.buttonNumA.Click += new System.EventHandler(this.buttonNumA_Click);
            // 
            // buttonNumB
            // 
            this.buttonNumB.Enabled = false;
            this.buttonNumB.Location = new System.Drawing.Point(15, 95);
            this.buttonNumB.Name = "buttonNumB";
            this.buttonNumB.Size = new System.Drawing.Size(33, 23);
            this.buttonNumB.TabIndex = 26;
            this.buttonNumB.Text = "B";
            this.buttonNumB.UseVisualStyleBackColor = true;
            this.buttonNumB.Click += new System.EventHandler(this.buttonNumB_Click);
            // 
            // buttonNumC
            // 
            this.buttonNumC.Enabled = false;
            this.buttonNumC.Location = new System.Drawing.Point(50, 95);
            this.buttonNumC.Name = "buttonNumC";
            this.buttonNumC.Size = new System.Drawing.Size(33, 23);
            this.buttonNumC.TabIndex = 27;
            this.buttonNumC.Text = "C";
            this.buttonNumC.UseVisualStyleBackColor = true;
            this.buttonNumC.Click += new System.EventHandler(this.buttonNumC_Click);
            // 
            // buttonNumD
            // 
            this.buttonNumD.Enabled = false;
            this.buttonNumD.Location = new System.Drawing.Point(85, 95);
            this.buttonNumD.Name = "buttonNumD";
            this.buttonNumD.Size = new System.Drawing.Size(33, 23);
            this.buttonNumD.TabIndex = 28;
            this.buttonNumD.Text = "D";
            this.buttonNumD.UseVisualStyleBackColor = true;
            this.buttonNumD.Click += new System.EventHandler(this.buttonNumD_Click);
            // 
            // buttonNumE
            // 
            this.buttonNumE.Enabled = false;
            this.buttonNumE.Location = new System.Drawing.Point(120, 95);
            this.buttonNumE.Name = "buttonNumE";
            this.buttonNumE.Size = new System.Drawing.Size(33, 23);
            this.buttonNumE.TabIndex = 29;
            this.buttonNumE.Text = "E";
            this.buttonNumE.UseVisualStyleBackColor = true;
            this.buttonNumE.Click += new System.EventHandler(this.buttonNumE_Click);
            // 
            // buttonNumF
            // 
            this.buttonNumF.Enabled = false;
            this.buttonNumF.Location = new System.Drawing.Point(155, 95);
            this.buttonNumF.Name = "buttonNumF";
            this.buttonNumF.Size = new System.Drawing.Size(33, 23);
            this.buttonNumF.TabIndex = 30;
            this.buttonNumF.Text = "F";
            this.buttonNumF.UseVisualStyleBackColor = true;
            // 
            // buttonPoint
            // 
            this.buttonPoint.Enabled = false;
            this.buttonPoint.Location = new System.Drawing.Point(15, 125);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(33, 23);
            this.buttonPoint.TabIndex = 31;
            this.buttonPoint.Text = ".";
            this.buttonPoint.UseVisualStyleBackColor = true;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // buttonNeg
            // 
            this.buttonNeg.Enabled = false;
            this.buttonNeg.Location = new System.Drawing.Point(50, 125);
            this.buttonNeg.Name = "buttonNeg";
            this.buttonNeg.Size = new System.Drawing.Size(70, 23);
            this.buttonNeg.TabIndex = 32;
            this.buttonNeg.Text = "Negate";
            this.buttonNeg.UseVisualStyleBackColor = true;
            this.buttonNeg.Click += new System.EventHandler(this.buttonNeg_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonNumC);
            this.panel2.Controls.Add(this.buttonNeg);
            this.panel2.Controls.Add(this.buttonNum1);
            this.panel2.Controls.Add(this.buttonPoint);
            this.panel2.Controls.Add(this.buttonNum3);
            this.panel2.Controls.Add(this.buttonNumF);
            this.panel2.Controls.Add(this.buttonNum2);
            this.panel2.Controls.Add(this.buttonNumE);
            this.panel2.Controls.Add(this.buttonNum4);
            this.panel2.Controls.Add(this.buttonNumD);
            this.panel2.Controls.Add(this.buttonNum5);
            this.panel2.Controls.Add(this.buttonNum6);
            this.panel2.Controls.Add(this.buttonNum7);
            this.panel2.Controls.Add(this.buttonNumB);
            this.panel2.Controls.Add(this.buttonNum0);
            this.panel2.Controls.Add(this.buttonNumA);
            this.panel2.Controls.Add(this.buttonNum8);
            this.panel2.Controls.Add(this.buttonNum9);
            this.panel2.Location = new System.Drawing.Point(12, 306);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 152);
            this.panel2.TabIndex = 33;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.dataTypeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(313, 24);
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Visible = false;
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Enabled = false;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            this.helpToolStripMenuItem.Visible = false;
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(119, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // dataTypeToolStripMenuItem
            // 
            this.dataTypeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unsignedIntergersToolStripMenuItem,
            this.signedIntegersToolStripMenuItem,
            this.floatNonIEEE754ToolStripMenuItem,
            this.floatToolStripMenuItem,
            this.doubleFloatToolStripMenuItem});
            this.dataTypeToolStripMenuItem.Name = "dataTypeToolStripMenuItem";
            this.dataTypeToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.dataTypeToolStripMenuItem.Text = "Conversion Mode";
            // 
            // unsignedIntergersToolStripMenuItem
            // 
            this.unsignedIntergersToolStripMenuItem.Checked = true;
            this.unsignedIntergersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.unsignedIntergersToolStripMenuItem.Name = "unsignedIntergersToolStripMenuItem";
            this.unsignedIntergersToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.unsignedIntergersToolStripMenuItem.Text = "Unsigned Intergers";
            this.unsignedIntergersToolStripMenuItem.Click += new System.EventHandler(this.unsignedIntergersToolStripMenuItem_Click);
            // 
            // signedIntegersToolStripMenuItem
            // 
            this.signedIntegersToolStripMenuItem.Name = "signedIntegersToolStripMenuItem";
            this.signedIntegersToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.signedIntegersToolStripMenuItem.Text = "Signed Integers";
            this.signedIntegersToolStripMenuItem.Click += new System.EventHandler(this.signedIntegersToolStripMenuItem_Click);
            // 
            // floatNonIEEE754ToolStripMenuItem
            // 
            this.floatNonIEEE754ToolStripMenuItem.Name = "floatNonIEEE754ToolStripMenuItem";
            this.floatNonIEEE754ToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.floatNonIEEE754ToolStripMenuItem.Text = "Float (Non-IEEE 754)";
            this.floatNonIEEE754ToolStripMenuItem.Click += new System.EventHandler(this.floatNonIEEE754ToolStripMenuItem_Click);
            // 
            // floatToolStripMenuItem
            // 
            this.floatToolStripMenuItem.Name = "floatToolStripMenuItem";
            this.floatToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.floatToolStripMenuItem.Text = "Float ";
            this.floatToolStripMenuItem.Click += new System.EventHandler(this.floatToolStripMenuItem_Click);
            // 
            // doubleFloatToolStripMenuItem
            // 
            this.doubleFloatToolStripMenuItem.Name = "doubleFloatToolStripMenuItem";
            this.doubleFloatToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.doubleFloatToolStripMenuItem.Text = "Double Float";
            this.doubleFloatToolStripMenuItem.Click += new System.EventHandler(this.doubleFloatToolStripMenuItem_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(209, 283);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDown1.TabIndex = 38;
            this.numericUpDown1.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDown1.Click += new System.EventHandler(this.numericUpDown1_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberBasesToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(18, 225);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(142, 24);
            this.menuStrip3.TabIndex = 43;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // numberBasesToolStripMenuItem
            // 
            this.numberBasesToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.numberBasesToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("numberBasesToolStripMenuItem.BackgroundImage")));
            this.numberBasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.binaryBase2ToolStripMenuItem,
            this.octalBase8ToolStripMenuItem,
            this.decimalBase10ToolStripMenuItem,
            this.hexidecimalBase16ToolStripMenuItem});
            this.numberBasesToolStripMenuItem.Name = "numberBasesToolStripMenuItem";
            this.numberBasesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.numberBasesToolStripMenuItem.Text = "Change Number Base";
            // 
            // binaryBase2ToolStripMenuItem
            // 
            this.binaryBase2ToolStripMenuItem.Name = "binaryBase2ToolStripMenuItem";
            this.binaryBase2ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.binaryBase2ToolStripMenuItem.Text = "Binary (Base 2)";
            this.binaryBase2ToolStripMenuItem.Click += new System.EventHandler(this.binaryBase2ToolStripMenuItem_Click);
            // 
            // octalBase8ToolStripMenuItem
            // 
            this.octalBase8ToolStripMenuItem.Name = "octalBase8ToolStripMenuItem";
            this.octalBase8ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.octalBase8ToolStripMenuItem.Text = "Octal (Base 8)";
            this.octalBase8ToolStripMenuItem.Click += new System.EventHandler(this.octalBase8ToolStripMenuItem_Click);
            // 
            // decimalBase10ToolStripMenuItem
            // 
            this.decimalBase10ToolStripMenuItem.Checked = true;
            this.decimalBase10ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.decimalBase10ToolStripMenuItem.Name = "decimalBase10ToolStripMenuItem";
            this.decimalBase10ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.decimalBase10ToolStripMenuItem.Text = "Decimal (Base 10)";
            this.decimalBase10ToolStripMenuItem.Click += new System.EventHandler(this.decimalBase10ToolStripMenuItem_Click);
            // 
            // hexidecimalBase16ToolStripMenuItem
            // 
            this.hexidecimalBase16ToolStripMenuItem.Name = "hexidecimalBase16ToolStripMenuItem";
            this.hexidecimalBase16ToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.hexidecimalBase16ToolStripMenuItem.Text = "Hexidecimal (Base 16)";
            this.hexidecimalBase16ToolStripMenuItem.Click += new System.EventHandler(this.hexidecimalBase16ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 516);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.numericUpDownExponent);
            this.Controls.Add(this.labelExp);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelSize);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Programmer\'s Calculator";
            this.Click += new System.EventHandler(this.MainForm_Click);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownExponent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.NumericUpDown numericUpDownExponent;
        private System.Windows.Forms.Label labelExp;
        private System.Windows.Forms.Button buttonNum1;
        private System.Windows.Forms.Button buttonNum3;
        private System.Windows.Forms.Button buttonNum2;
        private System.Windows.Forms.Button buttonNum4;
        private System.Windows.Forms.Button buttonNum5;
        private System.Windows.Forms.Button buttonNum6;
        private System.Windows.Forms.Button buttonNum7;
        private System.Windows.Forms.Button buttonNum0;
        private System.Windows.Forms.Button buttonNum8;
        private System.Windows.Forms.Button buttonNum9;
        private System.Windows.Forms.Button buttonNumA;
        private System.Windows.Forms.Button buttonNumB;
        private System.Windows.Forms.Button buttonNumC;
        private System.Windows.Forms.Button buttonNumD;
        private System.Windows.Forms.Button buttonNumE;
        private System.Windows.Forms.Button buttonNumF;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonNeg;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem numberBasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryBase2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem octalBase8ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decimalBase10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hexidecimalBase16ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unsignedIntergersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signedIntegersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floatNonIEEE754ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleFloatToolStripMenuItem;
    }
}


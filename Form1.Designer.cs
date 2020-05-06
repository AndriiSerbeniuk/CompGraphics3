namespace cg_lr3
{
    partial class cg_lr3
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
            this.paneldimetric = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.XTransBox = new System.Windows.Forms.NumericUpDown();
            this.ZTransBox = new System.Windows.Forms.NumericUpDown();
            this.YTransBox = new System.Windows.Forms.NumericUpDown();
            this.panelzx = new System.Windows.Forms.Panel();
            this.panelxy = new System.Windows.Forms.Panel();
            this.panelyz = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.YRotBox = new System.Windows.Forms.NumericUpDown();
            this.ZRotBox = new System.Windows.Forms.NumericUpDown();
            this.XRotBox = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TransformGB = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ScalValBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BSurfGB = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TvalBox = new System.Windows.Forms.NumericUpDown();
            this.p44rb = new System.Windows.Forms.RadioButton();
            this.p43rb = new System.Windows.Forms.RadioButton();
            this.p42rb = new System.Windows.Forms.RadioButton();
            this.p41rb = new System.Windows.Forms.RadioButton();
            this.p34rb = new System.Windows.Forms.RadioButton();
            this.p33rb = new System.Windows.Forms.RadioButton();
            this.p32rb = new System.Windows.Forms.RadioButton();
            this.p31rb = new System.Windows.Forms.RadioButton();
            this.p24rb = new System.Windows.Forms.RadioButton();
            this.p23rb = new System.Windows.Forms.RadioButton();
            this.p22rb = new System.Windows.Forms.RadioButton();
            this.p21rb = new System.Windows.Forms.RadioButton();
            this.p14rb = new System.Windows.Forms.RadioButton();
            this.p13rb = new System.Windows.Forms.RadioButton();
            this.p12rb = new System.Windows.Forms.RadioButton();
            this.p11rb = new System.Windows.Forms.RadioButton();
            this.AllSurfRB = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.DrawSelectGB = new System.Windows.Forms.GroupBox();
            this.PyramidRB = new System.Windows.Forms.RadioButton();
            this.SurfaceRB = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.paneldimetric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XTransBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZTransBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTransBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YRotBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZRotBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRotBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.TransformGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScalValBox)).BeginInit();
            this.BSurfGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvalBox)).BeginInit();
            this.DrawSelectGB.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paneldimetric
            // 
            this.paneldimetric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paneldimetric.Controls.Add(this.pictureBox1);
            this.paneldimetric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paneldimetric.Location = new System.Drawing.Point(223, 4);
            this.paneldimetric.Name = "paneldimetric";
            this.paneldimetric.Size = new System.Drawing.Size(811, 673);
            this.paneldimetric.TabIndex = 0;
            this.paneldimetric.Paint += new System.Windows.Forms.PaintEventHandler(this.paneldimetric_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(807, 675);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // XTransBox
            // 
            this.XTransBox.DecimalPlaces = 2;
            this.XTransBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.XTransBox.Location = new System.Drawing.Point(37, 33);
            this.XTransBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.XTransBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.XTransBox.Name = "XTransBox";
            this.XTransBox.Size = new System.Drawing.Size(66, 20);
            this.XTransBox.TabIndex = 2;
            this.XTransBox.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // ZTransBox
            // 
            this.ZTransBox.DecimalPlaces = 2;
            this.ZTransBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ZTransBox.Location = new System.Drawing.Point(37, 85);
            this.ZTransBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ZTransBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.ZTransBox.Name = "ZTransBox";
            this.ZTransBox.Size = new System.Drawing.Size(66, 20);
            this.ZTransBox.TabIndex = 3;
            this.ZTransBox.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // YTransBox
            // 
            this.YTransBox.DecimalPlaces = 2;
            this.YTransBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.YTransBox.Location = new System.Drawing.Point(37, 59);
            this.YTransBox.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.YTransBox.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.YTransBox.Name = "YTransBox";
            this.YTransBox.Size = new System.Drawing.Size(66, 20);
            this.YTransBox.TabIndex = 4;
            this.YTransBox.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // panelzx
            // 
            this.panelzx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelzx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelzx.Location = new System.Drawing.Point(3, 244);
            this.panelzx.Name = "panelzx";
            this.panelzx.Size = new System.Drawing.Size(200, 200);
            this.panelzx.TabIndex = 1;
            // 
            // panelxy
            // 
            this.panelxy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelxy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelxy.Location = new System.Drawing.Point(3, 25);
            this.panelxy.Name = "panelxy";
            this.panelxy.Size = new System.Drawing.Size(200, 200);
            this.panelxy.TabIndex = 1;
            // 
            // panelyz
            // 
            this.panelyz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelyz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelyz.Location = new System.Drawing.Point(3, 464);
            this.panelyz.Name = "panelyz";
            this.panelyz.Size = new System.Drawing.Size(200, 200);
            this.panelyz.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "YZ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "XY";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "XZ";
            // 
            // YRotBox
            // 
            this.YRotBox.DecimalPlaces = 2;
            this.YRotBox.Location = new System.Drawing.Point(40, 150);
            this.YRotBox.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.YRotBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.YRotBox.Name = "YRotBox";
            this.YRotBox.Size = new System.Drawing.Size(66, 20);
            this.YRotBox.TabIndex = 10;
            this.YRotBox.ValueChanged += new System.EventHandler(this.YRotBox_ValueChanged);
            // 
            // ZRotBox
            // 
            this.ZRotBox.DecimalPlaces = 2;
            this.ZRotBox.Location = new System.Drawing.Point(40, 176);
            this.ZRotBox.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.ZRotBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.ZRotBox.Name = "ZRotBox";
            this.ZRotBox.Size = new System.Drawing.Size(66, 20);
            this.ZRotBox.TabIndex = 9;
            this.ZRotBox.ValueChanged += new System.EventHandler(this.ZRotBox_ValueChanged);
            // 
            // XRotBox
            // 
            this.XRotBox.DecimalPlaces = 2;
            this.XRotBox.Location = new System.Drawing.Point(40, 124);
            this.XRotBox.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.XRotBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.XRotBox.Name = "XRotBox";
            this.XRotBox.Size = new System.Drawing.Size(66, 20);
            this.XRotBox.TabIndex = 8;
            this.XRotBox.ValueChanged += new System.EventHandler(this.XRotBox_ValueChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33967F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.8456F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.81473F));
            this.tableLayoutPanel1.Controls.Add(this.paneldimetric, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1264, 681);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TransformGB);
            this.panel2.Controls.Add(this.BSurfGB);
            this.panel2.Controls.Add(this.DrawSelectGB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(1041, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(219, 673);
            this.panel2.TabIndex = 12;
            // 
            // TransformGB
            // 
            this.TransformGB.Controls.Add(this.label10);
            this.TransformGB.Controls.Add(this.YTransBox);
            this.TransformGB.Controls.Add(this.ZTransBox);
            this.TransformGB.Controls.Add(this.XTransBox);
            this.TransformGB.Controls.Add(this.ScalValBox);
            this.TransformGB.Controls.Add(this.label4);
            this.TransformGB.Controls.Add(this.label12);
            this.TransformGB.Controls.Add(this.label5);
            this.TransformGB.Controls.Add(this.label7);
            this.TransformGB.Controls.Add(this.label11);
            this.TransformGB.Controls.Add(this.label8);
            this.TransformGB.Controls.Add(this.label6);
            this.TransformGB.Controls.Add(this.label9);
            this.TransformGB.Controls.Add(this.XRotBox);
            this.TransformGB.Controls.Add(this.YRotBox);
            this.TransformGB.Controls.Add(this.ZRotBox);
            this.TransformGB.Location = new System.Drawing.Point(-1, -1);
            this.TransformGB.Name = "TransformGB";
            this.TransformGB.Size = new System.Drawing.Size(169, 242);
            this.TransformGB.TabIndex = 29;
            this.TransformGB.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Translation";
            // 
            // ScalValBox
            // 
            this.ScalValBox.DecimalPlaces = 2;
            this.ScalValBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScalValBox.Location = new System.Drawing.Point(40, 215);
            this.ScalValBox.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.ScalValBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.ScalValBox.Name = "ScalValBox";
            this.ScalValBox.Size = new System.Drawing.Size(66, 20);
            this.ScalValBox.TabIndex = 21;
            this.ScalValBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ScalValBox.ValueChanged += new System.EventHandler(this.ScalValBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(6, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 19;
            this.label12.Text = "Scaling";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 178);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Z:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(6, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Rotation";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Z:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "X:";
            // 
            // BSurfGB
            // 
            this.BSurfGB.Controls.Add(this.label14);
            this.BSurfGB.Controls.Add(this.TvalBox);
            this.BSurfGB.Controls.Add(this.p44rb);
            this.BSurfGB.Controls.Add(this.p43rb);
            this.BSurfGB.Controls.Add(this.p42rb);
            this.BSurfGB.Controls.Add(this.p41rb);
            this.BSurfGB.Controls.Add(this.p34rb);
            this.BSurfGB.Controls.Add(this.p33rb);
            this.BSurfGB.Controls.Add(this.p32rb);
            this.BSurfGB.Controls.Add(this.p31rb);
            this.BSurfGB.Controls.Add(this.p24rb);
            this.BSurfGB.Controls.Add(this.p23rb);
            this.BSurfGB.Controls.Add(this.p22rb);
            this.BSurfGB.Controls.Add(this.p21rb);
            this.BSurfGB.Controls.Add(this.p14rb);
            this.BSurfGB.Controls.Add(this.p13rb);
            this.BSurfGB.Controls.Add(this.p12rb);
            this.BSurfGB.Controls.Add(this.p11rb);
            this.BSurfGB.Controls.Add(this.AllSurfRB);
            this.BSurfGB.Controls.Add(this.label13);
            this.BSurfGB.Controls.Add(this.checkBox1);
            this.BSurfGB.Enabled = false;
            this.BSurfGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BSurfGB.Location = new System.Drawing.Point(7, 328);
            this.BSurfGB.Name = "BSurfGB";
            this.BSurfGB.Size = new System.Drawing.Size(207, 320);
            this.BSurfGB.TabIndex = 28;
            this.BSurfGB.TabStop = false;
            this.BSurfGB.Text = "Bezier surface:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 26);
            this.label14.TabIndex = 45;
            this.label14.Text = "t and s parameters \r\nvalue:";
            // 
            // TvalBox
            // 
            this.TvalBox.DecimalPlaces = 2;
            this.TvalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TvalBox.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.TvalBox.Location = new System.Drawing.Point(127, 187);
            this.TvalBox.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TvalBox.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            131072});
            this.TvalBox.Name = "TvalBox";
            this.TvalBox.Size = new System.Drawing.Size(66, 20);
            this.TvalBox.TabIndex = 22;
            this.TvalBox.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.TvalBox.ValueChanged += new System.EventHandler(this.TvalBox_ValueChanged);
            // 
            // p44rb
            // 
            this.p44rb.AutoSize = true;
            this.p44rb.Location = new System.Drawing.Point(147, 149);
            this.p44rb.Name = "p44rb";
            this.p44rb.Size = new System.Drawing.Size(47, 17);
            this.p44rb.TabIndex = 44;
            this.p44rb.Text = "P44";
            this.p44rb.UseVisualStyleBackColor = true;
            this.p44rb.CheckedChanged += new System.EventHandler(this.p44rb_CheckedChanged);
            // 
            // p43rb
            // 
            this.p43rb.AutoSize = true;
            this.p43rb.Location = new System.Drawing.Point(99, 149);
            this.p43rb.Name = "p43rb";
            this.p43rb.Size = new System.Drawing.Size(47, 17);
            this.p43rb.TabIndex = 43;
            this.p43rb.Text = "P43";
            this.p43rb.UseVisualStyleBackColor = true;
            this.p43rb.CheckedChanged += new System.EventHandler(this.p43rb_CheckedChanged);
            // 
            // p42rb
            // 
            this.p42rb.AutoSize = true;
            this.p42rb.Location = new System.Drawing.Point(51, 149);
            this.p42rb.Name = "p42rb";
            this.p42rb.Size = new System.Drawing.Size(47, 17);
            this.p42rb.TabIndex = 42;
            this.p42rb.Text = "P42";
            this.p42rb.UseVisualStyleBackColor = true;
            this.p42rb.CheckedChanged += new System.EventHandler(this.p42rb_CheckedChanged);
            // 
            // p41rb
            // 
            this.p41rb.AutoSize = true;
            this.p41rb.Location = new System.Drawing.Point(3, 149);
            this.p41rb.Name = "p41rb";
            this.p41rb.Size = new System.Drawing.Size(47, 17);
            this.p41rb.TabIndex = 41;
            this.p41rb.Text = "P41";
            this.p41rb.UseVisualStyleBackColor = true;
            this.p41rb.CheckedChanged += new System.EventHandler(this.p41rb_CheckedChanged);
            // 
            // p34rb
            // 
            this.p34rb.AutoSize = true;
            this.p34rb.Location = new System.Drawing.Point(147, 126);
            this.p34rb.Name = "p34rb";
            this.p34rb.Size = new System.Drawing.Size(47, 17);
            this.p34rb.TabIndex = 40;
            this.p34rb.Text = "P34";
            this.p34rb.UseVisualStyleBackColor = true;
            this.p34rb.CheckedChanged += new System.EventHandler(this.p34rb_CheckedChanged);
            // 
            // p33rb
            // 
            this.p33rb.AutoSize = true;
            this.p33rb.Location = new System.Drawing.Point(99, 126);
            this.p33rb.Name = "p33rb";
            this.p33rb.Size = new System.Drawing.Size(47, 17);
            this.p33rb.TabIndex = 39;
            this.p33rb.Text = "P33";
            this.p33rb.UseVisualStyleBackColor = true;
            this.p33rb.CheckedChanged += new System.EventHandler(this.p33rb_CheckedChanged);
            // 
            // p32rb
            // 
            this.p32rb.AutoSize = true;
            this.p32rb.Location = new System.Drawing.Point(51, 126);
            this.p32rb.Name = "p32rb";
            this.p32rb.Size = new System.Drawing.Size(47, 17);
            this.p32rb.TabIndex = 38;
            this.p32rb.Text = "P32";
            this.p32rb.UseVisualStyleBackColor = true;
            this.p32rb.CheckedChanged += new System.EventHandler(this.p32rb_CheckedChanged);
            // 
            // p31rb
            // 
            this.p31rb.AutoSize = true;
            this.p31rb.Location = new System.Drawing.Point(3, 126);
            this.p31rb.Name = "p31rb";
            this.p31rb.Size = new System.Drawing.Size(47, 17);
            this.p31rb.TabIndex = 37;
            this.p31rb.Text = "P31";
            this.p31rb.UseVisualStyleBackColor = true;
            this.p31rb.CheckedChanged += new System.EventHandler(this.p31rb_CheckedChanged);
            // 
            // p24rb
            // 
            this.p24rb.AutoSize = true;
            this.p24rb.Location = new System.Drawing.Point(146, 103);
            this.p24rb.Name = "p24rb";
            this.p24rb.Size = new System.Drawing.Size(47, 17);
            this.p24rb.TabIndex = 36;
            this.p24rb.Text = "P24";
            this.p24rb.UseVisualStyleBackColor = true;
            this.p24rb.CheckedChanged += new System.EventHandler(this.p24rb_CheckedChanged);
            // 
            // p23rb
            // 
            this.p23rb.AutoSize = true;
            this.p23rb.Location = new System.Drawing.Point(98, 103);
            this.p23rb.Name = "p23rb";
            this.p23rb.Size = new System.Drawing.Size(47, 17);
            this.p23rb.TabIndex = 35;
            this.p23rb.Text = "P23";
            this.p23rb.UseVisualStyleBackColor = true;
            this.p23rb.CheckedChanged += new System.EventHandler(this.p23rb_CheckedChanged);
            // 
            // p22rb
            // 
            this.p22rb.AutoSize = true;
            this.p22rb.Location = new System.Drawing.Point(50, 103);
            this.p22rb.Name = "p22rb";
            this.p22rb.Size = new System.Drawing.Size(47, 17);
            this.p22rb.TabIndex = 34;
            this.p22rb.Text = "P22";
            this.p22rb.UseVisualStyleBackColor = true;
            this.p22rb.CheckedChanged += new System.EventHandler(this.p22rb_CheckedChanged);
            // 
            // p21rb
            // 
            this.p21rb.AutoSize = true;
            this.p21rb.Location = new System.Drawing.Point(2, 103);
            this.p21rb.Name = "p21rb";
            this.p21rb.Size = new System.Drawing.Size(47, 17);
            this.p21rb.TabIndex = 33;
            this.p21rb.Text = "P21";
            this.p21rb.UseVisualStyleBackColor = true;
            this.p21rb.CheckedChanged += new System.EventHandler(this.p21rb_CheckedChanged);
            // 
            // p14rb
            // 
            this.p14rb.AutoSize = true;
            this.p14rb.Location = new System.Drawing.Point(146, 80);
            this.p14rb.Name = "p14rb";
            this.p14rb.Size = new System.Drawing.Size(47, 17);
            this.p14rb.TabIndex = 32;
            this.p14rb.Text = "P14";
            this.p14rb.UseVisualStyleBackColor = true;
            this.p14rb.CheckedChanged += new System.EventHandler(this.p14rb_CheckedChanged);
            // 
            // p13rb
            // 
            this.p13rb.AutoSize = true;
            this.p13rb.Location = new System.Drawing.Point(98, 80);
            this.p13rb.Name = "p13rb";
            this.p13rb.Size = new System.Drawing.Size(47, 17);
            this.p13rb.TabIndex = 31;
            this.p13rb.Text = "P13";
            this.p13rb.UseVisualStyleBackColor = true;
            this.p13rb.CheckedChanged += new System.EventHandler(this.p13rb_CheckedChanged);
            // 
            // p12rb
            // 
            this.p12rb.AutoSize = true;
            this.p12rb.Location = new System.Drawing.Point(50, 80);
            this.p12rb.Name = "p12rb";
            this.p12rb.Size = new System.Drawing.Size(47, 17);
            this.p12rb.TabIndex = 30;
            this.p12rb.Text = "P12";
            this.p12rb.UseVisualStyleBackColor = true;
            this.p12rb.CheckedChanged += new System.EventHandler(this.p12rb_CheckedChanged);
            // 
            // p11rb
            // 
            this.p11rb.AutoSize = true;
            this.p11rb.Location = new System.Drawing.Point(2, 80);
            this.p11rb.Name = "p11rb";
            this.p11rb.Size = new System.Drawing.Size(47, 17);
            this.p11rb.TabIndex = 29;
            this.p11rb.Text = "P11";
            this.p11rb.UseVisualStyleBackColor = true;
            this.p11rb.CheckedChanged += new System.EventHandler(this.p11rb_CheckedChanged);
            // 
            // AllSurfRB
            // 
            this.AllSurfRB.AutoSize = true;
            this.AllSurfRB.Checked = true;
            this.AllSurfRB.Location = new System.Drawing.Point(2, 56);
            this.AllSurfRB.Name = "AllSurfRB";
            this.AllSurfRB.Size = new System.Drawing.Size(104, 17);
            this.AllSurfRB.TabIndex = 28;
            this.AllSurfRB.TabStop = true;
            this.AllSurfRB.Text = "whole surface";
            this.AllSurfRB.UseVisualStyleBackColor = true;
            this.AllSurfRB.CheckedChanged += new System.EventHandler(this.AllSurfRB_CheckedChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(-1, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Transform:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(136, 17);
            this.checkBox1.TabIndex = 26;
            this.checkBox1.Text = "Draw control points";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // DrawSelectGB
            // 
            this.DrawSelectGB.Controls.Add(this.PyramidRB);
            this.DrawSelectGB.Controls.Add(this.SurfaceRB);
            this.DrawSelectGB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DrawSelectGB.Location = new System.Drawing.Point(3, 247);
            this.DrawSelectGB.Name = "DrawSelectGB";
            this.DrawSelectGB.Size = new System.Drawing.Size(165, 75);
            this.DrawSelectGB.TabIndex = 25;
            this.DrawSelectGB.TabStop = false;
            this.DrawSelectGB.Text = "Draw:";
            // 
            // PyramidRB
            // 
            this.PyramidRB.AutoSize = true;
            this.PyramidRB.Checked = true;
            this.PyramidRB.Location = new System.Drawing.Point(6, 19);
            this.PyramidRB.Name = "PyramidRB";
            this.PyramidRB.Size = new System.Drawing.Size(158, 17);
            this.PyramidRB.TabIndex = 23;
            this.PyramidRB.TabStop = true;
            this.PyramidRB.Text = "Cut pentagonal pyramid";
            this.PyramidRB.UseVisualStyleBackColor = true;
            this.PyramidRB.CheckedChanged += new System.EventHandler(this.PyramidRB_CheckedChanged);
            // 
            // SurfaceRB
            // 
            this.SurfaceRB.AutoSize = true;
            this.SurfaceRB.Location = new System.Drawing.Point(6, 42);
            this.SurfaceRB.Name = "SurfaceRB";
            this.SurfaceRB.Size = new System.Drawing.Size(106, 17);
            this.SurfaceRB.TabIndex = 24;
            this.SurfaceRB.Text = "Bezier surface";
            this.SurfaceRB.UseVisualStyleBackColor = true;
            this.SurfaceRB.CheckedChanged += new System.EventHandler(this.SurfaceRB_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panelxy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panelzx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panelyz);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 673);
            this.panel1.TabIndex = 2;
            // 
            // cg_lr3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "cg_lr3";
            this.Text = "cglr3";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.paneldimetric.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XTransBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZTransBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTransBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YRotBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZRotBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.XRotBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.TransformGB.ResumeLayout(false);
            this.TransformGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ScalValBox)).EndInit();
            this.BSurfGB.ResumeLayout(false);
            this.BSurfGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TvalBox)).EndInit();
            this.DrawSelectGB.ResumeLayout(false);
            this.DrawSelectGB.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel paneldimetric;
        private System.Windows.Forms.NumericUpDown XTransBox;
        private System.Windows.Forms.NumericUpDown ZTransBox;
        private System.Windows.Forms.NumericUpDown YTransBox;
        private System.Windows.Forms.Panel panelzx;
        private System.Windows.Forms.Panel panelxy;
        private System.Windows.Forms.Panel panelyz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown YRotBox;
        private System.Windows.Forms.NumericUpDown ZRotBox;
        private System.Windows.Forms.NumericUpDown XRotBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown ScalValBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton SurfaceRB;
        private System.Windows.Forms.RadioButton PyramidRB;
        private System.Windows.Forms.GroupBox DrawSelectGB;
        private System.Windows.Forms.GroupBox BSurfGB;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox TransformGB;
        private System.Windows.Forms.RadioButton p44rb;
        private System.Windows.Forms.RadioButton p43rb;
        private System.Windows.Forms.RadioButton p42rb;
        private System.Windows.Forms.RadioButton p41rb;
        private System.Windows.Forms.RadioButton p34rb;
        private System.Windows.Forms.RadioButton p33rb;
        private System.Windows.Forms.RadioButton p32rb;
        private System.Windows.Forms.RadioButton p31rb;
        private System.Windows.Forms.RadioButton p24rb;
        private System.Windows.Forms.RadioButton p23rb;
        private System.Windows.Forms.RadioButton p22rb;
        private System.Windows.Forms.RadioButton p21rb;
        private System.Windows.Forms.RadioButton p14rb;
        private System.Windows.Forms.RadioButton p13rb;
        private System.Windows.Forms.RadioButton p12rb;
        private System.Windows.Forms.RadioButton p11rb;
        private System.Windows.Forms.RadioButton AllSurfRB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown TvalBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


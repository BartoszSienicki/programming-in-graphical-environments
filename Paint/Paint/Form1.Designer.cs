namespace Paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panelShadow = new Panel();
            toolStrip1 = new ToolStrip();
            noweToolStripButton = new ToolStripButton();
            otwórzToolStripButton = new ToolStripButton();
            zapiszToolStripButton = new ToolStripButton();
            printToolStripButton = new ToolStripButton();
            toolStripSeparator = new ToolStripSeparator();
            cutToolStripButton = new ToolStripButton();
            copyToolStripButton = new ToolStripButton();
            pasteToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            Punkt = new ToolStripButton();
            Linia = new ToolStripButton();
            Prostokąt = new ToolStripButton();
            Elipsa = new ToolStripButton();
            btnPenColor = new ToolStripButton();
            btnBrushColor = new ToolStripButton();
            comboBoxPenWidth = new ToolStripComboBox();
            colorDialog1 = new ColorDialog();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(30, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 300);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            panel1.MouseDown += panel1_MouseDown;
            panel1.MouseUp += panel1_MouseUp;
            // 
            // panelShadow
            // 
            panelShadow.BackColor = Color.LightGray;
            panelShadow.Location = new Point(35, 35);
            panelShadow.Name = "panelShadow";
            panelShadow.Size = new Size(400, 300);
            panelShadow.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(18, 18);
            toolStrip1.Items.AddRange(new ToolStripItem[] { noweToolStripButton, otwórzToolStripButton, zapiszToolStripButton, printToolStripButton, toolStripSeparator, cutToolStripButton, copyToolStripButton, pasteToolStripButton, toolStripSeparator1, Punkt, Linia, Prostokąt, Elipsa, btnPenColor, btnBrushColor, comboBoxPenWidth });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // noweToolStripButton
            // 
            noweToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            noweToolStripButton.Image = (Image)resources.GetObject("noweToolStripButton.Image");
            noweToolStripButton.ImageTransparentColor = Color.Magenta;
            noweToolStripButton.Name = "noweToolStripButton";
            noweToolStripButton.Size = new Size(25, 22);
            noweToolStripButton.Text = "&Nowe";
            // 
            // otwórzToolStripButton
            // 
            otwórzToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            otwórzToolStripButton.Image = (Image)resources.GetObject("otwórzToolStripButton.Image");
            otwórzToolStripButton.ImageTransparentColor = Color.Magenta;
            otwórzToolStripButton.Name = "otwórzToolStripButton";
            otwórzToolStripButton.Size = new Size(25, 22);
            otwórzToolStripButton.Text = "&Otwórz";
            // 
            // zapiszToolStripButton
            // 
            zapiszToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            zapiszToolStripButton.Image = (Image)resources.GetObject("zapiszToolStripButton.Image");
            zapiszToolStripButton.ImageTransparentColor = Color.Magenta;
            zapiszToolStripButton.Name = "zapiszToolStripButton";
            zapiszToolStripButton.Size = new Size(25, 22);
            zapiszToolStripButton.Text = "&Zapisz";
            // 
            // printToolStripButton
            // 
            printToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            printToolStripButton.Image = (Image)resources.GetObject("printToolStripButton.Image");
            printToolStripButton.ImageTransparentColor = Color.Magenta;
            printToolStripButton.Name = "printToolStripButton";
            printToolStripButton.Size = new Size(25, 22);
            printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 25);
            // 
            // cutToolStripButton
            // 
            cutToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            cutToolStripButton.Image = (Image)resources.GetObject("cutToolStripButton.Image");
            cutToolStripButton.ImageTransparentColor = Color.Magenta;
            cutToolStripButton.Name = "cutToolStripButton";
            cutToolStripButton.Size = new Size(25, 22);
            cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            copyToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            copyToolStripButton.Image = (Image)resources.GetObject("copyToolStripButton.Image");
            copyToolStripButton.ImageTransparentColor = Color.Magenta;
            copyToolStripButton.Name = "copyToolStripButton";
            copyToolStripButton.Size = new Size(25, 22);
            copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            pasteToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            pasteToolStripButton.Image = (Image)resources.GetObject("pasteToolStripButton.Image");
            pasteToolStripButton.ImageTransparentColor = Color.Magenta;
            pasteToolStripButton.Name = "pasteToolStripButton";
            pasteToolStripButton.Size = new Size(25, 22);
            pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // Punkt
            // 
            Punkt.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Punkt.Image = (Image)resources.GetObject("Punkt.Image");
            Punkt.ImageTransparentColor = Color.Magenta;
            Punkt.Name = "Punkt";
            Punkt.Size = new Size(43, 22);
            Punkt.Text = "Punkt";
            Punkt.Click += toolStripButtonPoint_Click;
            // 
            // Linia
            // 
            Linia.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Linia.Image = (Image)resources.GetObject("Linia.Image");
            Linia.ImageTransparentColor = Color.Magenta;
            Linia.Name = "Linia";
            Linia.Size = new Size(38, 22);
            Linia.Text = "Linia";
            Linia.Click += toolStripButtonLine_Click;
            // 
            // Prostokąt
            // 
            Prostokąt.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Prostokąt.Image = (Image)resources.GetObject("Prostokąt.Image");
            Prostokąt.ImageTransparentColor = Color.Magenta;
            Prostokąt.Name = "Prostokąt";
            Prostokąt.Size = new Size(67, 22);
            Prostokąt.Text = "Prostokąt";
            Prostokąt.Click += toolStripButtonRect_Click;
            // 
            // Elipsa
            // 
            Elipsa.DisplayStyle = ToolStripItemDisplayStyle.Text;
            Elipsa.Image = (Image)resources.GetObject("Elipsa.Image");
            Elipsa.ImageTransparentColor = Color.Magenta;
            Elipsa.Name = "Elipsa";
            Elipsa.Size = new Size(46, 22);
            Elipsa.Text = "Elipsa";
            Elipsa.Click += toolStripButtonEllipse_Click;
            // 
            // btnPenColor
            // 
            btnPenColor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnPenColor.Image = (Image)resources.GetObject("btnPenColor.Image");
            btnPenColor.ImageTransparentColor = Color.Magenta;
            btnPenColor.Name = "btnPenColor";
            btnPenColor.Size = new Size(85, 22);
            btnPenColor.Text = "Kolor pisaka";
            btnPenColor.Click += btnPenColor_Click;
            btnPenColor.Paint += btnPenColor_Paint;
            // 
            // btnBrushColor
            // 
            btnBrushColor.DisplayStyle = ToolStripItemDisplayStyle.Text;
            btnBrushColor.Image = (Image)resources.GetObject("btnBrushColor.Image");
            btnBrushColor.ImageTransparentColor = Color.Magenta;
            btnBrushColor.Name = "btnBrushColor";
            btnBrushColor.Size = new Size(85, 22);
            btnBrushColor.Text = "kolor pędzla";
            btnBrushColor.Click += btnBrushColor_Click;
            btnBrushColor.Paint += btnBrushColor_Paint;
            // 
            // comboBoxPenWidth
            // 
            comboBoxPenWidth.Items.AddRange(new object[] { "1", "2", "4", "6", "8" });
            comboBoxPenWidth.Name = "comboBoxPenWidth";
            comboBoxPenWidth.Size = new Size(121, 25);
            comboBoxPenWidth.TextChanged += comboBoxPenWidth_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(panelShadow);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panelShadow;
        private ToolStrip toolStrip1;
        private ToolStripButton noweToolStripButton;
        private ToolStripButton otwórzToolStripButton;
        private ToolStripButton zapiszToolStripButton;
        private ToolStripButton printToolStripButton;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripButton cutToolStripButton;
        private ToolStripButton copyToolStripButton;
        private ToolStripButton pasteToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton Punkt;
        private ToolStripButton Linia;
        private ToolStripButton Prostokąt;
        private ToolStripButton Elipsa;
        private ToolStripButton btnPenColor;
        private ToolStripButton btnBrushColor;
        private ColorDialog colorDialog1;
        private ToolStripComboBox comboBoxPenWidth;
    }
}

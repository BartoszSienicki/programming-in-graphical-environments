namespace Zad9TreeView
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
            treeView1 = new TreeView();
            buttonAddRoot = new Button();
            buttonAddChild = new Button();
            buttonEditText = new Button();
            buttonNodeDelete = new Button();
            buttonDeleteChildren = new Button();
            textNodeText = new TextBox();
            textEditText = new TextBox();
            checkBox1 = new CheckBox();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            noweToolStripMenuItem = new ToolStripMenuItem();
            otwórzToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            zapiszToolStripMenuItem = new ToolStripMenuItem();
            zapiszAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            podglądwydrukuToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            zakończToolStripMenuItem = new ToolStripMenuItem();
            edytujToolStripMenuItem = new ToolStripMenuItem();
            cofnijToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            wytnijToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            wybierzwszystkoToolStripMenuItem = new ToolStripMenuItem();
            narzędziaToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            zawartośćToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            wyszukajToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 62);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(254, 352);
            treeView1.TabIndex = 0;
            // 
            // buttonAddRoot
            // 
            buttonAddRoot.Location = new Point(272, 63);
            buttonAddRoot.Name = "buttonAddRoot";
            buttonAddRoot.Size = new Size(165, 25);
            buttonAddRoot.TabIndex = 1;
            buttonAddRoot.Text = "Dodaj korzeń";
            buttonAddRoot.UseVisualStyleBackColor = true;
            buttonAddRoot.Click += buttonAddRoot_Click;
            // 
            // buttonAddChild
            // 
            buttonAddChild.Location = new Point(272, 169);
            buttonAddChild.Name = "buttonAddChild";
            buttonAddChild.Size = new Size(165, 25);
            buttonAddChild.TabIndex = 2;
            buttonAddChild.Text = "Dodaj dziecko w tekście";
            buttonAddChild.UseVisualStyleBackColor = true;
            buttonAddChild.Click += buttonAddChild_Click;
            // 
            // buttonEditText
            // 
            buttonEditText.Location = new Point(272, 232);
            buttonEditText.Name = "buttonEditText";
            buttonEditText.Size = new Size(165, 25);
            buttonEditText.TabIndex = 3;
            buttonEditText.Text = "Edytuj tekst węzła";
            buttonEditText.UseVisualStyleBackColor = true;
            buttonEditText.Click += buttonEditText_Click;
            // 
            // buttonNodeDelete
            // 
            buttonNodeDelete.Location = new Point(272, 306);
            buttonNodeDelete.Name = "buttonNodeDelete";
            buttonNodeDelete.Size = new Size(229, 25);
            buttonNodeDelete.TabIndex = 4;
            buttonNodeDelete.Text = "Usuń wskazany węzeł";
            buttonNodeDelete.UseVisualStyleBackColor = true;
            buttonNodeDelete.Click += buttonNodeDelete_Click;
            // 
            // buttonDeleteChildren
            // 
            buttonDeleteChildren.Location = new Point(272, 337);
            buttonDeleteChildren.Name = "buttonDeleteChildren";
            buttonDeleteChildren.Size = new Size(229, 25);
            buttonDeleteChildren.TabIndex = 5;
            buttonDeleteChildren.Text = "Usuń wszystkie węzły potomne";
            buttonDeleteChildren.UseVisualStyleBackColor = true;
            buttonDeleteChildren.Click += buttonDeleteChildren_Click;
            // 
            // textNodeText
            // 
            textNodeText.Location = new Point(443, 169);
            textNodeText.Name = "textNodeText";
            textNodeText.Size = new Size(153, 25);
            textNodeText.TabIndex = 6;
            // 
            // textEditText
            // 
            textEditText.Location = new Point(443, 232);
            textEditText.Name = "textEditText";
            textEditText.Size = new Size(153, 25);
            textEditText.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(272, 394);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(153, 21);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Rozwiń/zwiń wszystko";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(18, 18);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, edytujToolStripMenuItem, narzędziaToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 25);
            menuStrip1.TabIndex = 9;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { noweToolStripMenuItem, otwórzToolStripMenuItem, toolStripSeparator, zapiszToolStripMenuItem, zapiszAsToolStripMenuItem, toolStripSeparator1, printToolStripMenuItem, podglądwydrukuToolStripMenuItem, toolStripSeparator2, zakończToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(39, 21);
            fileToolStripMenuItem.Text = "&File";
            // 
            // noweToolStripMenuItem
            // 
            noweToolStripMenuItem.Image = (Image)resources.GetObject("noweToolStripMenuItem.Image");
            noweToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            noweToolStripMenuItem.Name = "noweToolStripMenuItem";
            noweToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            noweToolStripMenuItem.Size = new Size(198, 24);
            noweToolStripMenuItem.Text = "&Nowe";
            // 
            // otwórzToolStripMenuItem
            // 
            otwórzToolStripMenuItem.Image = (Image)resources.GetObject("otwórzToolStripMenuItem.Image");
            otwórzToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            otwórzToolStripMenuItem.Name = "otwórzToolStripMenuItem";
            otwórzToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            otwórzToolStripMenuItem.Size = new Size(198, 24);
            otwórzToolStripMenuItem.Text = "&Otwórz";
            otwórzToolStripMenuItem.Click += otwórzToolStripMenuItem_Click;
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(195, 6);
            // 
            // zapiszToolStripMenuItem
            // 
            zapiszToolStripMenuItem.Image = (Image)resources.GetObject("zapiszToolStripMenuItem.Image");
            zapiszToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            zapiszToolStripMenuItem.Name = "zapiszToolStripMenuItem";
            zapiszToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            zapiszToolStripMenuItem.Size = new Size(198, 24);
            zapiszToolStripMenuItem.Text = "&Zapisz";
            zapiszToolStripMenuItem.Click += zapiszToolStripMenuItem_Click;
            // 
            // zapiszAsToolStripMenuItem
            // 
            zapiszAsToolStripMenuItem.Name = "zapiszAsToolStripMenuItem";
            zapiszAsToolStripMenuItem.Size = new Size(198, 24);
            zapiszAsToolStripMenuItem.Text = "Zapisz &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(195, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(198, 24);
            printToolStripMenuItem.Text = "&Print";
            // 
            // podglądwydrukuToolStripMenuItem
            // 
            podglądwydrukuToolStripMenuItem.Image = (Image)resources.GetObject("podglądwydrukuToolStripMenuItem.Image");
            podglądwydrukuToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            podglądwydrukuToolStripMenuItem.Name = "podglądwydrukuToolStripMenuItem";
            podglądwydrukuToolStripMenuItem.Size = new Size(198, 24);
            podglądwydrukuToolStripMenuItem.Text = "&Podgląd wydruku";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(195, 6);
            // 
            // zakończToolStripMenuItem
            // 
            zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            zakończToolStripMenuItem.Size = new Size(198, 24);
            zakończToolStripMenuItem.Text = "&Zakończ";
            // 
            // edytujToolStripMenuItem
            // 
            edytujToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cofnijToolStripMenuItem, redoToolStripMenuItem, toolStripSeparator3, wytnijToolStripMenuItem, copyToolStripMenuItem, pasteToolStripMenuItem, toolStripSeparator4, wybierzwszystkoToolStripMenuItem });
            edytujToolStripMenuItem.Name = "edytujToolStripMenuItem";
            edytujToolStripMenuItem.Size = new Size(55, 21);
            edytujToolStripMenuItem.Text = "&Edytuj";
            // 
            // cofnijToolStripMenuItem
            // 
            cofnijToolStripMenuItem.Name = "cofnijToolStripMenuItem";
            cofnijToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            cofnijToolStripMenuItem.Size = new Size(184, 24);
            cofnijToolStripMenuItem.Text = "&Cofnij";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(184, 24);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(181, 6);
            // 
            // wytnijToolStripMenuItem
            // 
            wytnijToolStripMenuItem.Image = (Image)resources.GetObject("wytnijToolStripMenuItem.Image");
            wytnijToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            wytnijToolStripMenuItem.Name = "wytnijToolStripMenuItem";
            wytnijToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            wytnijToolStripMenuItem.Size = new Size(184, 24);
            wytnijToolStripMenuItem.Text = "Wyt&nij";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(184, 24);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(184, 24);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(181, 6);
            // 
            // wybierzwszystkoToolStripMenuItem
            // 
            wybierzwszystkoToolStripMenuItem.Name = "wybierzwszystkoToolStripMenuItem";
            wybierzwszystkoToolStripMenuItem.Size = new Size(184, 24);
            wybierzwszystkoToolStripMenuItem.Text = "Wybier&z wszystko";
            // 
            // narzędziaToolStripMenuItem
            // 
            narzędziaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { customizeToolStripMenuItem, optionsToolStripMenuItem });
            narzędziaToolStripMenuItem.Name = "narzędziaToolStripMenuItem";
            narzędziaToolStripMenuItem.Size = new Size(79, 21);
            narzędziaToolStripMenuItem.Text = "&Narzędzia";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(142, 24);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(142, 24);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { zawartośćToolStripMenuItem, indexToolStripMenuItem, wyszukajToolStripMenuItem, toolStripSeparator5, aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(47, 21);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // zawartośćToolStripMenuItem
            // 
            zawartośćToolStripMenuItem.Name = "zawartośćToolStripMenuItem";
            zawartośćToolStripMenuItem.Size = new Size(141, 24);
            zawartośćToolStripMenuItem.Text = "&Zawartość";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(141, 24);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // wyszukajToolStripMenuItem
            // 
            wyszukajToolStripMenuItem.Name = "wyszukajToolStripMenuItem";
            wyszukajToolStripMenuItem.Size = new Size(141, 24);
            wyszukajToolStripMenuItem.Text = "&Wyszukaj";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(138, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(141, 24);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(textEditText);
            Controls.Add(textNodeText);
            Controls.Add(buttonDeleteChildren);
            Controls.Add(buttonNodeDelete);
            Controls.Add(buttonEditText);
            Controls.Add(buttonAddChild);
            Controls.Add(buttonAddRoot);
            Controls.Add(treeView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Button buttonAddRoot;
        private Button buttonAddChild;
        private Button buttonEditText;
        private Button buttonNodeDelete;
        private Button buttonDeleteChildren;
        private TextBox textNodeText;
        private TextBox textEditText;
        private CheckBox checkBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem noweToolStripMenuItem;
        private ToolStripMenuItem otwórzToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem zapiszToolStripMenuItem;
        private ToolStripMenuItem zapiszAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem podglądwydrukuToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem zakończToolStripMenuItem;
        private ToolStripMenuItem edytujToolStripMenuItem;
        private ToolStripMenuItem cofnijToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem wytnijToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem wybierzwszystkoToolStripMenuItem;
        private ToolStripMenuItem narzędziaToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem zawartośćToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem wyszukajToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}

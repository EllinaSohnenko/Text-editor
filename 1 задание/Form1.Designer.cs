namespace _1_задание
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.ToolStrip = new System.Windows.Forms.ToolStrip();
            this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.копироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.вставкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.BoldToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ItalicToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnderlineToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.SizeTSComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.ColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FillColorToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.FontToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.CenterToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.RightToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LeftToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.TextEdt = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MainMenu.Size = new System.Drawing.Size(978, 24);
            this.MainMenu.TabIndex = 0;
            this.MainMenu.Text = "menuStrip1";
            // 
            // ToolStrip
            // 
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripSeparator,
            this.вырезатьToolStripButton,
            this.копироватьToolStripButton,
            this.вставкаToolStripButton,
            this.toolStripSeparator1,
            this.справкаToolStripButton,
            this.BoldToolStripButton,
            this.ItalicToolStripButton,
            this.UnderlineToolStripButton,
            this.SizeTSComboBox,
            this.ColorToolStripButton,
            this.FillColorToolStripButton,
            this.FontToolStripButton,
            this.CenterToolStripButton,
            this.RightToolStripButton,
            this.LeftToolStripButton});
            this.ToolStrip.Location = new System.Drawing.Point(0, 24);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.ToolStrip.Size = new System.Drawing.Size(978, 34);
            this.ToolStrip.TabIndex = 1;
            this.ToolStrip.Text = "toolStrip1";
            // 
            // создатьToolStripButton
            // 
            this.создатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.создатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripButton.Image")));
            this.создатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripButton.Name = "создатьToolStripButton";
            this.создатьToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.создатьToolStripButton.Text = "&Создать";
            this.создатьToolStripButton.Click += new System.EventHandler(this.создатьToolStripButton_Click);
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.открытьToolStripButton.Text = "&Открыть";
            this.открытьToolStripButton.Click += new System.EventHandler(this.открытьToolStripButton_Click);
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            this.сохранитьToolStripButton.Click += new System.EventHandler(this.сохранитьToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 34);
            // 
            // вырезатьToolStripButton
            // 
            this.вырезатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вырезатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripButton.Image")));
            this.вырезатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripButton.Name = "вырезатьToolStripButton";
            this.вырезатьToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.вырезатьToolStripButton.Text = "В&ырезать";
            this.вырезатьToolStripButton.Click += new System.EventHandler(this.вырезатьToolStripButton_Click);
            // 
            // копироватьToolStripButton
            // 
            this.копироватьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.копироватьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripButton.Image")));
            this.копироватьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripButton.Name = "копироватьToolStripButton";
            this.копироватьToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.копироватьToolStripButton.Text = "&Копировать";
            this.копироватьToolStripButton.Click += new System.EventHandler(this.копироватьToolStripButton_Click);
            // 
            // вставкаToolStripButton
            // 
            this.вставкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вставкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripButton.Image")));
            this.вставкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripButton.Name = "вставкаToolStripButton";
            this.вставкаToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.вставкаToolStripButton.Text = "Вст&авка";
            this.вставкаToolStripButton.Click += new System.EventHandler(this.вставкаToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // справкаToolStripButton
            // 
            this.справкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripButton.Image")));
            this.справкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.справкаToolStripButton.Name = "справкаToolStripButton";
            this.справкаToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.справкаToolStripButton.Text = "Спр&авка";
            this.справкаToolStripButton.Click += new System.EventHandler(this.справкаToolStripButton_Click);
            // 
            // BoldToolStripButton
            // 
            this.BoldToolStripButton.CheckOnClick = true;
            this.BoldToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BoldToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.BoldToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BoldToolStripButton.Image")));
            this.BoldToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldToolStripButton.Name = "BoldToolStripButton";
            this.BoldToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.BoldToolStripButton.Text = "Ж";
            this.BoldToolStripButton.Click += new System.EventHandler(this.BoldToolStripButton_Click);
            // 
            // ItalicToolStripButton
            // 
            this.ItalicToolStripButton.CheckOnClick = true;
            this.ItalicToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ItalicToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic);
            this.ItalicToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ItalicToolStripButton.Image")));
            this.ItalicToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicToolStripButton.Name = "ItalicToolStripButton";
            this.ItalicToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.ItalicToolStripButton.Text = "К";
            this.ItalicToolStripButton.Click += new System.EventHandler(this.ItalicToolStripButton_Click);
            // 
            // UnderlineToolStripButton
            // 
            this.UnderlineToolStripButton.CheckOnClick = true;
            this.UnderlineToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.UnderlineToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
            this.UnderlineToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineToolStripButton.Image")));
            this.UnderlineToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineToolStripButton.Name = "UnderlineToolStripButton";
            this.UnderlineToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.UnderlineToolStripButton.Text = "Ч";
            this.UnderlineToolStripButton.Click += new System.EventHandler(this.UnderlineToolStripButton_Click);
            // 
            // SizeTSComboBox
            // 
            this.SizeTSComboBox.AutoSize = false;
            this.SizeTSComboBox.Items.AddRange(new object[] {
            "8",
            "10",
            "12",
            "14",
            "16",
            "18",
            "20"});
            this.SizeTSComboBox.Name = "SizeTSComboBox";
            this.SizeTSComboBox.Size = new System.Drawing.Size(50, 33);
            this.SizeTSComboBox.Text = "12";
            this.SizeTSComboBox.DropDownClosed += new System.EventHandler(this.SizeTSComboBox_DropDownClosed);
            this.SizeTSComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SizeTSComboBox_KeyDown);
            // 
            // ColorToolStripButton
            // 
            this.ColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ColorToolStripButton.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.ColorToolStripButton.ForeColor = System.Drawing.Color.Red;
            this.ColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ColorToolStripButton.Image")));
            this.ColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ColorToolStripButton.Name = "ColorToolStripButton";
            this.ColorToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.ColorToolStripButton.Text = "А";
            this.ColorToolStripButton.Click += new System.EventHandler(this.ColorToolStripButton_Click);
            // 
            // FillColorToolStripButton
            // 
            this.FillColorToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FillColorToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FillColorToolStripButton.Image")));
            this.FillColorToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FillColorToolStripButton.Name = "FillColorToolStripButton";
            this.FillColorToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.FillColorToolStripButton.Text = "toolStripButton2";
            this.FillColorToolStripButton.Click += new System.EventHandler(this.FillColorToolStripButton_Click);
            // 
            // FontToolStripButton
            // 
            this.FontToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.FontToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("FontToolStripButton.Image")));
            this.FontToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FontToolStripButton.Name = "FontToolStripButton";
            this.FontToolStripButton.Size = new System.Drawing.Size(49, 29);
            this.FontToolStripButton.Text = "font";
            this.FontToolStripButton.Click += new System.EventHandler(this.FontToolStripButton_Click);
            // 
            // CenterToolStripButton
            // 
            this.CenterToolStripButton.CheckOnClick = true;
            this.CenterToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("CenterToolStripButton.Image")));
            this.CenterToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CenterToolStripButton.Name = "CenterToolStripButton";
            this.CenterToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.CenterToolStripButton.Text = "toolStripButton1";
            this.CenterToolStripButton.Click += new System.EventHandler(this.CenterToolStripButton_Click);
            // 
            // RightToolStripButton
            // 
            this.RightToolStripButton.CheckOnClick = true;
            this.RightToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RightToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("RightToolStripButton.Image")));
            this.RightToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RightToolStripButton.Name = "RightToolStripButton";
            this.RightToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.RightToolStripButton.Text = "toolStripButton2";
            this.RightToolStripButton.Click += new System.EventHandler(this.RightToolStripButton_Click);
            // 
            // LeftToolStripButton
            // 
            this.LeftToolStripButton.CheckOnClick = true;
            this.LeftToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LeftToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("LeftToolStripButton.Image")));
            this.LeftToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LeftToolStripButton.Name = "LeftToolStripButton";
            this.LeftToolStripButton.Size = new System.Drawing.Size(34, 29);
            this.LeftToolStripButton.Text = "toolStripButton3";
            this.LeftToolStripButton.Click += new System.EventHandler(this.LeftToolStripButton_Click);
            // 
            // TextEdt
            // 
            this.TextEdt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextEdt.Location = new System.Drawing.Point(0, 58);
            this.TextEdt.Name = "TextEdt";
            this.TextEdt.Size = new System.Drawing.Size(978, 586);
            this.TextEdt.TabIndex = 2;
            this.TextEdt.Text = "";
            this.TextEdt.SelectionChanged += new System.EventHandler(this.TextEdt_SelectionChanged);
            this.TextEdt.Enter += new System.EventHandler(this.TextEdt_Enter);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Значок1.ico");
            this.imageList1.Images.SetKeyName(1, "Значок3.ico");
            this.imageList1.Images.SetKeyName(2, "Значок2.ico");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 644);
            this.Controls.Add(this.TextEdt);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "MainForm";
            this.Text = "Текстовый редактор";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.RichTextBox TextEdt;
        private System.Windows.Forms.ToolStripButton создатьToolStripButton;
        private System.Windows.Forms.ToolStripButton открытьToolStripButton;
        private System.Windows.Forms.ToolStripButton сохранитьToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton вырезатьToolStripButton;
        private System.Windows.Forms.ToolStripButton копироватьToolStripButton;
        private System.Windows.Forms.ToolStripButton вставкаToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton справкаToolStripButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton BoldToolStripButton;
        private System.Windows.Forms.ToolStripButton ItalicToolStripButton;
        private System.Windows.Forms.ToolStripButton UnderlineToolStripButton;
        private System.Windows.Forms.ToolStripComboBox SizeTSComboBox;
        private System.Windows.Forms.ToolStripButton ColorToolStripButton;
        private System.Windows.Forms.ToolStripButton FillColorToolStripButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripButton FontToolStripButton;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripButton CenterToolStripButton;
        private System.Windows.Forms.ToolStripButton RightToolStripButton;
        private System.Windows.Forms.ToolStripButton LeftToolStripButton;
        private System.Windows.Forms.ImageList imageList1;
    }
}


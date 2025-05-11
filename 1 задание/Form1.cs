using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_задание {
    public partial class MainForm : Form {
        int start, len;
        bool l = true;
        public MainForm() {
            InitializeComponent();
        }

        private void открытьToolStripButton_Click(object sender, EventArgs e) {
            if (TextEdt.CanUndo) {
                DialogResult d = MessageBox.Show("Сохранить изменения в файле?", "Сохранение", MessageBoxButtons.YesNo);
                bool k = true;
                if (d == DialogResult.Yes) сохранитьToolStripButton_Click(sender, e);
                //else TextEdt.Clear();
                if (openFileDialog1.FileName != "openFileDialog1") {
                    openFileDialog1.FileName = "openFileDialog1";
                    Text = "Текстовый редактор";
                    //устанавливаем фильтр
                    openFileDialog1.Filter = "RTF files|*.rtf";
                }
                    
            }
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                TextEdt.Clear();
                //загружаем текст из файла
                TextEdt.LoadFile(openFileDialog1.FileName);
                //отображаем полное имя файла в заголовке формы
                Text = "Текстовый редактор   " + openFileDialog1.FileName;
            }
        }

        private void сохранитьToolStripButton_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "RTF files|*.rtf";
            if (openFileDialog1.FileName != "openFileDialog1") TextEdt.SaveFile(openFileDialog1.FileName);
            else if (saveFileDialog1.ShowDialog() == DialogResult.OK) {
                TextEdt.SaveFile(saveFileDialog1.FileName);
                Text = "Текстовый редактор   " + saveFileDialog1.FileName;
            }
        }

        private void создатьToolStripButton_Click(object sender, EventArgs e) {
            if (TextEdt.CanUndo) {
                DialogResult d = MessageBox.Show("Сохранить изменения в файле?", "Сохранение", MessageBoxButtons.YesNo);
                if (d == DialogResult.Yes) сохранитьToolStripButton_Click(sender, e);
                else TextEdt.Clear();
            }
            if (openFileDialog1.FileName != "openFileDialog1") {
                TextEdt.Clear();
                openFileDialog1.FileName = "openFileDialog1";
                Text = "Текстовый редактор";
            }
        }

        private void справкаToolStripButton_Click(object sender, EventArgs e) {
            MessageBox.Show("Программа разработана студентом 2 курса");
        }

        private void BoldToolStripButton_Click(object sender, EventArgs e) {
            try {
                start = TextEdt.SelectionStart;
                len = TextEdt.SelectionLength;
                int end = start + len;
                if (start == 0 && end != 0) {
                    l = false;
                    TextEdt.Select(0, 1);
                    l = true;
                    if (BoldToolStripButton.Checked)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Bold);
                    else TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style & ~FontStyle.Bold);
                }
                for (int i = start; i < end; i++) {
                    l = false;
                    TextEdt.Select(i, 1);
                    l = true;
                    if (BoldToolStripButton.Checked)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Bold);
                    else TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style & ~FontStyle.Bold);
                }
                TextEdt.Select(start, len);
            }
            catch { }
            TextEdt.Focus();
        }

        private void TextEdt_SelectionChanged(object sender, EventArgs e) {
            if (TextEdt.SelectionFont == null) return;
            if (l) {
                BoldToolStripButton.Checked = TextEdt.SelectionFont.Bold;
                ItalicToolStripButton.Checked = TextEdt.SelectionFont.Italic;
                UnderlineToolStripButton.Checked = TextEdt.SelectionFont.Underline;
            }
            SizeTSComboBox.Text = TextEdt.SelectionFont.Size.ToString();
            FillColorToolStripButton.BackColor = TextEdt.SelectionBackColor;
            ColorToolStripButton.ForeColor = TextEdt.SelectionColor;
            CenterToolStripButton.Checked = false;
            RightToolStripButton.Checked = false;
            LeftToolStripButton.Checked = false;
            if (TextEdt.SelectionAlignment == HorizontalAlignment.Center)
                CenterToolStripButton.Checked = true;
            else if (TextEdt.SelectionAlignment == HorizontalAlignment.Right)
                RightToolStripButton.Checked = true;
            else if (TextEdt.SelectionAlignment == HorizontalAlignment.Left)
                LeftToolStripButton.Checked = true;
        }

        private void SizeTSComboBox_DropDownClosed(object sender, EventArgs e) {
            if (SizeTSComboBox.SelectedItem != null) SizeTSComboBox.Text = SizeTSComboBox.SelectedItem.ToString();
            else SizeTSComboBox.SelectedItem = SizeTSComboBox.Text;
            int size = Convert.ToInt16(SizeTSComboBox.Text);
            try {
                start = TextEdt.SelectionStart;
                len = TextEdt.SelectionLength;
                int end = start + len;
                if (start - end != 0) {
                    TextEdt.Select(start, 1);
                    bool bold = false, italic = false, underLine = false;
                    string st = TextEdt.SelectionFont.Style.ToString();
                    for (int i = 0; i < st.Length; i++) {
                        if (st[i] == 'B') {
                            bold = true;
                            i += 3;
                        }
                        else if (st[i] == 'I') {
                            italic = true;
                            i += 5;
                        }
                        else if (st[i] == 'U') {
                            underLine = true;
                            i += 8;
                        }
                    }
                    TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, size, TextEdt.SelectionFont.Style);

                    TextEdt.Select();
                    TextEdt.Select(start, 1);
                    if (bold)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Bold);
                    if (italic)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Italic);
                    if (underLine)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Underline);
                }
                for (int i = start; i < end; i++) {
                    TextEdt.Select(i, 1);
                    FontStyle a = TextEdt.SelectionFont.Style;
                    TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, size, TextEdt.SelectionFont.Style);

                    TextEdt.Select();
                    TextEdt.Select(i, 1);
                    if (a == FontStyle.Bold)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Bold);
                    if (a == FontStyle.Italic)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Italic);
                    if (a == FontStyle.Underline)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Underline);
                }
                TextEdt.Select(start, len);
            }
            catch { }
            TextEdt.Focus();
        }

        private void SizeTSComboBox_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) SizeTSComboBox_DropDownClosed(sender, e);
        }

        private void ItalicToolStripButton_Click(object sender, EventArgs e) {
            try {
                start = TextEdt.SelectionStart;
                len = TextEdt.SelectionLength;
                int end = start + len;
                if (start == 0 && end != 0) {
                    l = false;
                    TextEdt.Select(0, 1);
                    l = true;
                    if (ItalicToolStripButton.Checked)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Italic);
                    else TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style & ~FontStyle.Italic);
                }
                for (int i = start; i < end; i++) {
                    l = false;
                    TextEdt.Select(i, 1);
                    l = true;
                    if (ItalicToolStripButton.Checked)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Italic);
                    else TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style & ~FontStyle.Italic);
                }
                TextEdt.Select(start, len);
            }
            catch { }
            TextEdt.Focus();
        }

        private void UnderlineToolStripButton_Click(object sender, EventArgs e) {
            try {
                start = TextEdt.SelectionStart;
                len = TextEdt.SelectionLength;
                int end = start + len;
                if (start == 0 && end != 0) {
                    l = false;
                    TextEdt.Select(0, 1);
                    l = true;
                    if (UnderlineToolStripButton.Checked)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Underline);
                    else TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style & ~FontStyle.Underline);
                }
                for (int i = start; i < end; i++) {
                    l = false;
                    TextEdt.Select(i, 1);
                    l = true;
                    if (UnderlineToolStripButton.Checked)
                        TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style | FontStyle.Underline);
                    else TextEdt.SelectionFont = new Font(TextEdt.SelectionFont.FontFamily, TextEdt.SelectionFont.Size, TextEdt.SelectionFont.Style & ~FontStyle.Underline);
                }
                TextEdt.Select(start, len);
            }
            catch { }
            TextEdt.Focus();
        }

        private void ColorToolStripButton_Click(object sender, EventArgs e) {
            colorDialog1.ShowDialog();
            TextEdt.SelectionColor = colorDialog1.Color;
            ColorToolStripButton.ForeColor = colorDialog1.Color;
        }

        private void FillColorToolStripButton_Click(object sender, EventArgs e) {
            colorDialog1.ShowDialog();
            TextEdt.SelectionBackColor = colorDialog1.Color;
            FillColorToolStripButton.BackColor = colorDialog1.Color;
        }

        private void FontToolStripButton_Click(object sender, EventArgs e) {
            fontDialog1.ShowDialog();
            TextEdt.SelectionFont = fontDialog1.Font;
            FontToolStripButton.Text = fontDialog1.Font.Name.ToString();
            FontToolStripButton.Font = fontDialog1.Font;
        }

        private void CenterToolStripButton_Click(object sender, EventArgs e) {
            if (TextEdt.SelectionAlignment == HorizontalAlignment.Center) {
                TextEdt.SelectionAlignment = HorizontalAlignment.Left;
                CenterToolStripButton.Checked = false;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = true;
            }
            else {
                TextEdt.SelectionAlignment = HorizontalAlignment.Center;
                CenterToolStripButton.Checked = true;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = false;
            }
        }

        private void RightToolStripButton_Click(object sender, EventArgs e) {
            if (TextEdt.SelectionAlignment == HorizontalAlignment.Right)
            {
                TextEdt.SelectionAlignment = HorizontalAlignment.Left;
                CenterToolStripButton.Checked = false;
                RightToolStripButton.Checked = false;
                LeftToolStripButton.Checked = true;
            }
            else {
                TextEdt.SelectionAlignment = HorizontalAlignment.Right;
                CenterToolStripButton.Checked = false;
                RightToolStripButton.Checked = true;
                LeftToolStripButton.Checked = false;
            }
        }

        private void LeftToolStripButton_Click(object sender, EventArgs e) {
            TextEdt.SelectionAlignment = HorizontalAlignment.Left;
            CenterToolStripButton.Checked = false;
            RightToolStripButton.Checked = false;
            LeftToolStripButton.Checked = true;
        }

        private void вырезатьToolStripButton_Click(object sender, EventArgs e) {
            try { TextEdt.Cut(); }
            catch { }
        }

        private void копироватьToolStripButton_Click(object sender, EventArgs e) {
            try { TextEdt.Copy(); }
            catch { }
        }

        private void вставкаToolStripButton_Click(object sender, EventArgs e) {
            try { TextEdt.Paste(); }
            catch { }
        }

        private void MainForm_Load(object sender, EventArgs e) {
            ColorToolStripButton.ForeColor = colorDialog1.Color;
            FillColorToolStripButton.BackColor = colorDialog1.Color;
            TextEdt.SelectionFont = fontDialog1.Font;
            FontToolStripButton.Text = TextEdt.Font.Name.ToString();
            FontToolStripButton.Font = fontDialog1.Font;
            ToolStrip.ImageList = imageList1;
            CenterToolStripButton.ImageIndex = 1;
            LeftToolStripButton.ImageIndex = 0;
            RightToolStripButton.ImageIndex = 2;
        }

        private void TextEdt_Enter(object sender, EventArgs e) {
            SizeTSComboBox_DropDownClosed(sender, e);
            TextEdt.Select(start, len);
        }
    }
}
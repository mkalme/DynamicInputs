using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DynamicInputs {
    public partial class DynamicInputForm : Form {
        public List<Entry> Entries { get; set; }
        private Graphics Graphics { get; set; }

        public DynamicInputForm(List<Entry> entries) {
            InitializeComponent();
            InitializeUserComponent();

            Entries = entries;
            SetPanel();
        }
        private void InitializeUserComponent() {
            LayoutPanel.RowStyles[0] = GetRowStyle();
            Graphics = CreateGraphics();
        }

        private void SetPanel() {
            int width = 0;

            for (int i = 0; i < Entries.Count; i++) {
                Entry entry = Entries[i];

                Label label = GetLabel(entry.GetName());
                int labelWidth = (int)Graphics.MeasureString(label.Text, label.Font).Width;
                if (width < labelWidth) width = labelWidth;

                LayoutPanel.Controls.Add(label, 0, i);
                LayoutPanel.Controls.Add(entry.Control, 1, i);

                if (i > 0 && i < Entries.Count - 1) {
                    LayoutPanel.RowStyles.Add(GetRowStyle());
                }
            }

            LayoutPanel.ColumnStyles[0] = new ColumnStyle(SizeType.Absolute, width + 10);
        }
        private static RowStyle GetRowStyle() {
            return new RowStyle(SizeType.Absolute, 30);
        }
        private static Label GetLabel(string text) {
            return new Label() {
                Text = text,
                Anchor = AnchorStyles.Left,
                AutoSize = true,
                Margin = new Padding(0)
            };
        }

        private void SetValues() {
            foreach (var entry in Entries) {
                entry.UpdateValue();
            }
        }

        private void DoneButton_Click(object sender, EventArgs e) {
            SetValues();

            Close();
        }
    }
}

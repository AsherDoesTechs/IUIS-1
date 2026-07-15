using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace IUIS.Utilities
{
    public static class ModernUi
    {
        public static readonly Color PageBackground = Color.FromArgb(245, 247, 251);
        public static readonly Color Surface = Color.White;
        public static readonly Color Primary = Color.FromArgb(37, 99, 235);
        public static readonly Color PrimaryDark = Color.FromArgb(30, 64, 175);
        public static readonly Color Text = Color.FromArgb(15, 23, 42);
        public static readonly Color MutedText = Color.FromArgb(100, 116, 139);
        public static readonly Color Border = Color.FromArgb(226, 232, 240);
        public static readonly Color Soft = Color.FromArgb(241, 245, 249);
        public static readonly Color Success = Color.FromArgb(16, 185, 129);
        public static readonly Color Danger = Color.FromArgb(220, 38, 38);

        public static Font TitleFont(float size = 18F) => new Font("Segoe UI", size, FontStyle.Bold, GraphicsUnit.Point);
        public static Font BodyFont(float size = 9.5F) => new Font("Segoe UI", size, FontStyle.Regular, GraphicsUnit.Point);
        public static Font ButtonFont(float size = 9.5F) => new Font("Segoe UI", size, FontStyle.Bold, GraphicsUnit.Point);

        public static void StyleForm(Form form, Size minimumSize)
        {
            form.BackColor = PageBackground;
            form.Font = BodyFont();
            form.MinimumSize = minimumSize;
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        /// <summary>
        /// Applies the IUIS visual system to every control in a window, including
        /// controls contained in panels, group boxes, tabs, and embedded forms.
        /// </summary>
        public static void ApplyTheme(Form form)
        {
            form.BackColor = PageBackground;
            form.Font = BodyFont();
            form.ForeColor = Text;
            StyleControls(form.Controls);
        }

        private static void StyleControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls.Cast<Control>())
            {
                switch (control)
                {
                    case DataGridView grid:
                        StyleGrid(grid);
                        break;
                    case TextBox textBox:
                        StyleTextBox(textBox);
                        break;
                    case Button button:
                        StyleButton(button);
                        break;
                    case ComboBox comboBox:
                        comboBox.FlatStyle = FlatStyle.Flat;
                        comboBox.BackColor = Surface;
                        comboBox.ForeColor = Text;
                        comboBox.Font = BodyFont(10F);
                        break;
                    case CheckedListBox checkedListBox:
                        checkedListBox.BackColor = Surface;
                        checkedListBox.ForeColor = Text;
                        checkedListBox.BorderStyle = BorderStyle.FixedSingle;
                        checkedListBox.Font = BodyFont(9.5F);
                        break;
                    case Panel panel when panel.BackColor != Primary && panel.BackColor != PrimaryDark:
                        // Preserve intentionally coloured headers, sidebars, and metric tiles.
                        if (panel.BackColor == SystemColors.Control || panel.BackColor == Color.Empty || panel.BackColor == Surface)
                        {
                            panel.BackColor = Surface;
                        }
                        break;
                    case GroupBox groupBox:
                        groupBox.ForeColor = Text;
                        groupBox.Font = ButtonFont(9.5F);
                        break;
                    case Label label:
                        if (label.ForeColor == Color.Empty || label.ForeColor == Color.Black)
                        {
                            label.ForeColor = Text;
                        }

                        if (label.Name.Contains("header", System.StringComparison.OrdinalIgnoreCase) ||
                            label.Name.Contains("title", System.StringComparison.OrdinalIgnoreCase))
                        {
                            label.Font = TitleFont(label.Font.Size >= 16F ? label.Font.Size : 14F);
                        }
                        else if (label.Name.Contains("hint", System.StringComparison.OrdinalIgnoreCase) ||
                                 label.Name.Contains("summary", System.StringComparison.OrdinalIgnoreCase) ||
                                 label.Name.Contains("subtitle", System.StringComparison.OrdinalIgnoreCase))
                        {
                            label.ForeColor = MutedText;
                        }
                        break;
                }

                if (control.HasChildren)
                {
                    StyleControls(control.Controls);
                }
            }
        }

        private static void StyleButton(Button button)
        {
            bool destructive = button.Name.Contains("delete", System.StringComparison.OrdinalIgnoreCase) ||
                               button.Text.Contains("delete", System.StringComparison.OrdinalIgnoreCase) ||
                               button.Text.Contains("remove", System.StringComparison.OrdinalIgnoreCase);
            bool primary = button.Name.Contains("save", System.StringComparison.OrdinalIgnoreCase) ||
                           button.Name.Contains("login", System.StringComparison.OrdinalIgnoreCase) ||
                           button.Name.Contains("primary", System.StringComparison.OrdinalIgnoreCase) ||
                           button.BackColor == Primary ||
                           button.Text.Contains("add", System.StringComparison.OrdinalIgnoreCase) ||
                           button.Text.Contains("save", System.StringComparison.OrdinalIgnoreCase) ||
                           button.Text.Contains("continue", System.StringComparison.OrdinalIgnoreCase);

            if (destructive)
            {
                button.BackColor = Danger;
                button.ForeColor = Color.White;
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
                button.Font = ButtonFont();
                button.Cursor = Cursors.Hand;
                button.UseVisualStyleBackColor = false;
            }
            else if (primary)
            {
                StylePrimaryButton(button);
            }
            else
            {
                StyleSecondaryButton(button);
            }
        }

        public static void StylePrimaryButton(Button button)
        {
            button.BackColor = Primary;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.Font = ButtonFont();
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
        }

        public static void StyleSecondaryButton(Button button)
        {
            button.BackColor = Soft;
            button.ForeColor = Text;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Border;
            button.FlatAppearance.BorderSize = 1;
            button.Font = ButtonFont();
            button.Cursor = Cursors.Hand;
            button.UseVisualStyleBackColor = false;
        }

        public static void StyleGrid(DataGridView grid)
        {
            grid.BackgroundColor = Surface;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Text;
            grid.ColumnHeadersDefaultCellStyle.Font = ButtonFont(9F);
            grid.ColumnHeadersHeight = 38;
            grid.DefaultCellStyle.BackColor = Surface;
            grid.DefaultCellStyle.ForeColor = Text;
            grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(219, 234, 254);
            grid.DefaultCellStyle.SelectionForeColor = Text;
            grid.EnableHeadersVisualStyles = false;
            grid.GridColor = Border;
            grid.ReadOnly = true;
            grid.RowHeadersVisible = false;
            grid.RowTemplate.Height = 32;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static void StyleTextBox(TextBox textBox)
        {
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = BodyFont(10F);
        }
    }
}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ExpenseManagerUI
{
    // Dialog Types
    public enum DialogType
    {
        Success,
        Warning,
        Error
    }

    public static class CustomMessageBox
    {
        public static DialogResult Show(
            string message,
            string headerText,
            DialogType type,
            Form owner = null)
        {
            // =========================
            // FORM SETUP
            // =========================

            Form dialog = new Form
            {
                Size = new Size(540, 500),
                FormBorderStyle = FormBorderStyle.None,
                BackColor = Color.White,
                StartPosition = owner == null
                    ? FormStartPosition.CenterScreen
                    : FormStartPosition.CenterParent,
                Opacity = 0
            };

            // =========================
            // THEME COLORS
            // =========================

            Color themeColor;
            string windowTitle;

            switch (type)
            {
                case DialogType.Warning:
                    themeColor = Color.FromArgb(255, 170, 0);
                    windowTitle = "Expense Manager : Warning";
                    break;

                case DialogType.Error:
                    themeColor = Color.FromArgb(220, 53, 69);
                    windowTitle = "Expense Manager : Error";
                    break;

                default:
                    themeColor = Color.FromArgb(34, 169, 69);
                    windowTitle = "Expense Manager : Success";
                    break;
            }

            Color darkText = Color.FromArgb(35, 35, 35);
            Color lightText = Color.FromArgb(120, 120, 120);

            dialog.Text = windowTitle;

            // =========================
            // FADE ANIMATION
            // =========================

            System.Windows.Forms.Timer fadeTimer = new System.Windows.Forms.Timer();
            fadeTimer.Interval = 10;

            fadeTimer.Tick += (s, e) =>
            {
                if (dialog.Opacity < 1)
                {
                    dialog.Opacity += 0.05;
                }
                else
                {
                    fadeTimer.Stop();
                }
            };

            fadeTimer.Start();

            // =========================
            // HEADER PANEL
            // =========================

            Panel headerPanel = new Panel
            {
                Size = new Size(dialog.Width, 50),
                Location = new Point(0, 0),
                BackColor = Color.Transparent
            };

            Label lblTop = new Label
            {
                Text = "📊 Expense Manager",
                Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold),
                ForeColor = darkText,
                AutoSize = true,
                Location = new Point(20, 15)
            };

            Button btnClose = new Button
            {
                Text = "✕",
                Font = new Font("Segoe UI", 11F),
                FlatStyle = FlatStyle.Flat,
                ForeColor = lightText,
                Size = new Size(35, 35),
                Location = new Point(dialog.Width - 50, 10),
                Cursor = Cursors.Hand
            };

            btnClose.FlatAppearance.BorderSize = 0;

            btnClose.MouseEnter += (s, e) =>
            {
                btnClose.BackColor = Color.FromArgb(240, 240, 240);
            };

            btnClose.MouseLeave += (s, e) =>
            {
                btnClose.BackColor = Color.Transparent;
            };

            btnClose.Click += (s, e) =>
            {
                dialog.DialogResult = DialogResult.Cancel;
                dialog.Close();
            };

            headerPanel.Controls.Add(lblTop);
            headerPanel.Controls.Add(btnClose);

            dialog.Controls.Add(headerPanel);

            // =========================
            // TITLE LABEL
            // =========================

            Label lblHeader = new Label
            {
                Text = headerText,
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                ForeColor = themeColor,
                AutoSize = false,
                Width = dialog.Width,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0, 240)
            };

            dialog.Controls.Add(lblHeader);

            // =========================
            // MESSAGE LABEL
            // =========================

            Label lblMessage = new Label
            {
                Text = message,
                Font = new Font("Segoe UI", 12F),
                ForeColor = darkText,
                AutoSize = false,
                Width = dialog.Width,
                Height = 40,
                TextAlign = ContentAlignment.MiddleCenter,
                Location = new Point(0, 300)
            };

            dialog.Controls.Add(lblMessage);

            // =========================
            // BUTTON
            // =========================

            Button btnOK = new Button
            {
                Text = "OK  →",
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                Size = new Size(200, 52),
                Location = new Point((dialog.Width - 200) / 2, 390),
                BackColor = themeColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Cursor = Cursors.Hand
            };

            btnOK.FlatAppearance.BorderSize = 0;

            btnOK.Paint += (s, e) =>
            {
                using (GraphicsPath btnPath =
                    GetRoundedPath(
                        new Rectangle(0, 0, btnOK.Width, btnOK.Height),
                        14))
                {
                    btnOK.Region = new Region(btnPath);
                }
            };

            btnOK.MouseEnter += (s, e) =>
            {
                btnOK.BackColor = ControlPaint.Dark(themeColor);
            };

            btnOK.MouseLeave += (s, e) =>
            {
                btnOK.BackColor = themeColor;
            };

            btnOK.Click += (s, e) =>
            {
                dialog.DialogResult = DialogResult.OK;
                dialog.Close();
            };

            dialog.Controls.Add(btnOK);

            // =========================
            // CUSTOM PAINTING
            // =========================

            dialog.Paint += (s, e) =>
            {
                Graphics g = e.Graphics;

                g.SmoothingMode = SmoothingMode.AntiAlias;

                // Rounded Form
                using (GraphicsPath formPath =
                    GetRoundedPath(
                        new Rectangle(0, 0, dialog.Width, dialog.Height),
                        28))
                {
                    dialog.Region = new Region(formPath);
                }

                // Decorative Waves
                using (Pen wavePen =
                    new Pen(Color.FromArgb(35, themeColor), 1.5f))
                {
                    for (int i = 0; i < 4; i++)
                    {
                        using (GraphicsPath wavePath = new GraphicsPath())
                        {
                            wavePath.AddArc(
                                -50,
                                dialog.Height - (90 + (i * 12)),
                                dialog.Width + 100,
                                160,
                                180,
                                -180);

                            g.DrawPath(wavePen, wavePath);
                        }
                    }
                }

                // Floating Crystals
                DrawFloatingCrystals(g, themeColor);

                // Main Circle
                int cx = (dialog.Width - 115) / 2;
                int cy = 85;

                using (SolidBrush glow =
                    new SolidBrush(Color.FromArgb(25, themeColor)))
                {
                    g.FillEllipse(glow, cx - 12, cy - 12, 139, 139);
                }

                Color darkTheme = ControlPaint.Dark(themeColor);

                using (LinearGradientBrush gradient =
                    new LinearGradientBrush(
                        new Rectangle(cx, cy, 115, 115),
                        themeColor,
                        darkTheme,
                        LinearGradientMode.Vertical))
                {
                    g.FillEllipse(gradient, cx, cy, 115, 115);
                }

                // ICONS

                if (type == DialogType.Warning)
                {
                    using (SolidBrush wb = new SolidBrush(Color.White))
                    {
                        g.FillRectangle(wb, cx + 53, cy + 28, 10, 38);
                        g.FillEllipse(wb, cx + 53, cy + 75, 10, 10);
                    }
                }
                else if (type == DialogType.Error)
                {
                    using (Pen crossPen =
                        new Pen(Color.White, 7))
                    {
                        crossPen.StartCap = LineCap.Round;
                        crossPen.EndCap = LineCap.Round;

                        g.DrawLine(crossPen,
                            cx + 38, cy + 38,
                            cx + 77, cy + 77);

                        g.DrawLine(crossPen,
                            cx + 77, cy + 38,
                            cx + 38, cy + 77);
                    }
                }
                else
                {
                    using (Pen checkPen =
                        new Pen(Color.White, 7))
                    {
                        checkPen.StartCap = LineCap.Round;
                        checkPen.EndCap = LineCap.Round;

                        g.DrawLine(checkPen,
                            cx + 35, cy + 58,
                            cx + 50, cy + 74);

                        g.DrawLine(checkPen,
                            cx + 50, cy + 74,
                            cx + 82, cy + 42);
                    }
                }
            };

            return dialog.ShowDialog(owner);
        }

        // =========================
        // ROUNDED PATH
        // =========================

        private static GraphicsPath GetRoundedPath(
            Rectangle bounds,
            int radius)
        {
            GraphicsPath path = new GraphicsPath();

            int d = radius * 2;

            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);

            path.CloseAllFigures();

            return path;
        }

        // =========================
        // DECORATIVE CRYSTALS
        // =========================

        private static void DrawFloatingCrystals(
            Graphics g,
            Color themeColor)
        {
            Point[] left =
            {
                new Point(110, 160),
                new Point(70, 200),
                new Point(150, 190),
                new Point(120, 220)
            };

            Point[] right =
            {
                new Point(410, 155),
                new Point(450, 185),
                new Point(380, 210),
                new Point(425, 230)
            };

            Color secondary =
                Color.FromArgb(160, themeColor);

            Action<Point, Color, int> drawCrystal =
                (center, color, size) =>
                {
                    using (SolidBrush b =
                        new SolidBrush(color))
                    {
                        Point[] pts =
                        {
                            new Point(center.X, center.Y - size),
                            new Point(center.X + size, center.Y),
                            new Point(center.X, center.Y + size),
                            new Point(center.X - size, center.Y)
                        };

                        g.FillPolygon(b, pts);
                    }
                };

            for (int i = 0; i < left.Length; i++)
            {
                drawCrystal(
                    left[i],
                    (i % 2 == 0) ? themeColor : secondary,
                    (i % 2 == 0) ? 7 : 5);

                drawCrystal(
                    right[i],
                    (i % 2 == 0) ? themeColor : secondary,
                    (i % 2 == 0) ? 7 : 5);
            }
        }
    }
}
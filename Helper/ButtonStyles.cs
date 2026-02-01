using Syncfusion.WinForms.Controls;
using System;
using System.Collections.Generic;
using System.Text;

namespace LabLink.Helper
{
    public static class ButtonStyles
    {

        public static void ApplyNavButtonStyle(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Check if the control is an SfButton
                if (control is SfButton button)
                {
                    button.Style.Border = null;
                    button.Style.FocusedBorder = null;
                    button.Style.HoverBorder = null;
                    button.Style.PressedBorder = null;

                    button.Style.BackColor = Color.White;
                    button.Style.ForeColor = Color.FromArgb(74, 83, 100);
                    button.Style.ImageForeColor = Color.FromArgb(107, 112, 129);

                    button.Style.HoverBackColor = Color.FromArgb(249, 250, 251);
                    button.Style.HoverForeColor = Color.FromArgb(74, 83, 100);
                    button.Style.HoverImageForeColor = Color.FromArgb(54, 63, 82);

                    button.Style.PressedBackColor = Color.FromArgb(249, 250, 251);
                    button.Style.PressedForeColor = Color.FromArgb(74, 83, 100);
                    button.Style.PressedImageForeColor = Color.FromArgb(54, 63, 82);

                    button.Style.FocusedBackColor = Color.FromArgb(235, 242, 255);
                    button.Style.FocusedForeColor = Color.FromArgb(30, 72, 207);
                    button.Style.FocusedImageForeColor = Color.FromArgb(30, 72, 207);

                }

                // Recursively check child controls
                if (control.HasChildren)
                {
                    ApplyNavButtonStyle(control);
                }
            }
        }

        public static void PrimaryButton(SfButton button)
        {
            button.Style.Border = null;
            button.Style.FocusedBorder = null;
            button.Style.HoverBorder = null;
            button.Style.PressedBorder = null;

            button.Style.BackColor = Color.FromArgb(30, 72, 207);
            button.Style.ForeColor = Color.White;
            button.Style.ImageForeColor = Color.White;

            button.Style.HoverBackColor = Color.FromArgb(67, 0, 219);
            button.Style.HoverForeColor = Color.White;
            button.Style.HoverImageForeColor = Color.White;

            button.Style.PressedBackColor = Color.FromArgb(67, 0, 219);
            button.Style.PressedForeColor = Color.White;
            button.Style.PressedImageForeColor = Color.White;

            button.Style.FocusedBackColor = Color.FromArgb(30, 72, 207);
            button.Style.FocusedForeColor = Color.White;
            button.Style.FocusedImageForeColor = Color.White;
        }

        public static void SecondaryButton(SfButton button)
        {
            button.Style.Border = new Pen(Color.FromArgb(218, 223, 231));
            button.Style.FocusedBorder = new Pen(Color.FromArgb(218, 223, 231));
            button.Style.HoverBorder = new Pen(Color.FromArgb(218, 223, 231));
            button.Style.PressedBorder = new Pen(Color.FromArgb(218, 223, 231));

            button.Style.BackColor = Color.White;
            button.Style.ForeColor = Color.Black;
            button.Style.ImageForeColor = Color.Black;

            button.Style.HoverBackColor = Color.FromArgb(249, 250, 251);
            button.Style.HoverForeColor = Color.FromArgb(54, 63, 82);
            button.Style.HoverImageForeColor = Color.FromArgb(54, 63, 82);

            button.Style.PressedBackColor = Color.FromArgb(249, 250, 251);
            button.Style.PressedForeColor = Color.Black;
            button.Style.PressedImageForeColor = Color.Black;

            button.Style.FocusedBackColor = Color.White;
            button.Style.FocusedForeColor = Color.Black;
            button.Style.FocusedImageForeColor = Color.Black;
        }

        public static void TernaryButton(SfButton button)
        {
            button.Style.Border = null;
            button.Style.FocusedBorder = null;
            button.Style.HoverBorder = null;
            button.Style.PressedBorder = null;

            button.Style.BackColor = Color.FromArgb(249, 250, 251);
            button.Style.ForeColor = Color.Black;
            button.Style.ImageForeColor = Color.Black;

            button.Style.HoverBackColor = Color.FromArgb(245, 245, 245);
            button.Style.HoverForeColor = Color.FromArgb(54, 63, 82);
            button.Style.HoverImageForeColor = Color.FromArgb(54, 63, 82);

            button.Style.PressedBackColor = Color.FromArgb(247, 247, 247);
            button.Style.PressedForeColor = Color.Black;
            button.Style.PressedImageForeColor = Color.Black;

            button.Style.FocusedBackColor = Color.FromArgb(249, 250, 251);
            button.Style.FocusedForeColor = Color.Black;
            button.Style.FocusedImageForeColor = Color.Black;
        }
    }
}

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

                    button.Style.BackColor = Color.FromArgb(41, 59, 80);
                    button.Style.ForeColor = Color.FromArgb(199, 206, 212);
                    button.Style.ImageForeColor = Color.FromArgb(199, 206, 212);

                    button.Style.HoverBackColor = Color.FromArgb(51, 74, 100);
                    button.Style.HoverForeColor = Color.FromArgb(239, 242, 245);
                    button.Style.HoverImageForeColor = Color.FromArgb(239, 242, 245);

                    button.Style.PressedBackColor = Color.FromArgb(51, 74, 100);
                    button.Style.PressedForeColor = Color.FromArgb(239, 242, 245);
                    button.Style.PressedImageForeColor = Color.FromArgb(239, 242, 245);

                    button.Style.FocusedBackColor = Color.FromArgb(5, 142, 223);
                    button.Style.FocusedForeColor = Color.FromArgb(239, 242, 245);
                    button.Style.FocusedImageForeColor = Color.FromArgb(239, 242, 245);

                }

                // Recursively check child controls
                if (control.HasChildren)
                {
                    ApplyNavButtonStyle(control);
                }
            }
        }
    }
}

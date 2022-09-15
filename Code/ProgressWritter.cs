using System;
namespace BISMDocumenterLibrary
{
    class ProgressWriter
    {
        public string InvokedAppType { get; set; }

        public void WriteProgress(String ProgressText, object WriteProgressTo)
        {
            if (this.InvokedAppType == "Windows")
            {
                System.Windows.Forms.TextBox ProgressTextBox = (System.Windows.Forms.TextBox)WriteProgressTo;
                ProgressText = ProgressText + Environment.NewLine;
                ProgressTextBox.AppendText(ProgressText);
            }
        }

    }
}

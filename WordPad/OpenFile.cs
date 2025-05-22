using System;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WordPad
{
    partial class WordPad
    {
        public string OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Открыть файл";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                   return File.ReadAllText(openFileDialog.FileName);
                   
                }
                catch (Exception ex)
                {
                    
                }
            }
        }
    }
}

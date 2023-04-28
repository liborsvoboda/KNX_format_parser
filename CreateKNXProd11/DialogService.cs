using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CreateKnxProd
{
    public class DialogService : IDialogService
    {
        public void ShowMessage(string message)
        {
            MessageBox.Show(message);
        }

        public string ChooseSaveFile(string title, string extension, string filter)
        {
            var dlg = new SaveFileDialog();
            dlg.DefaultExt = extension;
            dlg.Filter = filter;
            dlg.Title = title;

            var result = dlg.ShowDialog();
            if (result != true)
                return null;

            return dlg.FileName;
        }

        public bool? Ask(string question)
        {
            var result = MessageBox.Show(question, "Otázka", MessageBoxButton.YesNoCancel);
            if (result == MessageBoxResult.Cancel)
                return null;

            return result == MessageBoxResult.Yes;
        }

        public string ChooseFileToOpen(string title,string extension, string filter)
        {
            var dlg = new OpenFileDialog();
            dlg.DefaultExt = extension;
            dlg.Filter = filter;
            dlg.Title = title;
                
            var result = dlg.ShowDialog();
            if (result != true)
                return null;

            return dlg.FileName;
        }
    }
}

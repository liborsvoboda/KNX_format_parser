using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateKnxProd
{
    public interface IDialogService
    {
        void ShowMessage(string message);
        string ChooseSaveFile(string title, string extension, string filter);
        bool? Ask(string question);

        string ChooseFileToOpen(string title, string extension, string filter);
    }
}

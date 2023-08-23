using NotepadClone.Models;
using System;
using System.Windows.Input;

namespace NotepadClone.ViewModels
{
    public class EditorViewModel
    {
        public ICommand FormatCommand { get; set; }
        public ICommand WrapCommand { get; set; }
        public FormatModel Format { get; set; }
        public DocumentModel Document { get; set; }

        public EditorViewModel(DocumentModel document)
        {
            Document = document;
            Format = new FormatModel();
            FormatCommand = new RelayCommand(OpenStyleDialog);
            WrapCommand = new RelayCommand(ToggleWrap);
        }

        private void OpenStyleDialog()
        {
            throw new NotImplementedException();
        }
        public void ToggleWrap()
        {
            if(Format.Wrap == System.Windows.TextWrapping.Wrap)
            {
                Format.Wrap = System.Windows.TextWrapping.NoWrap;
            }
            else
            {
                Format.Wrap = System.Windows.TextWrapping.Wrap;
            }
        }
    }
}

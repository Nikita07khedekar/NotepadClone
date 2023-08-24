using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotepadClone.Models
{
    public class DocumentModel : ObservableObject
    {
        private string _text;
        public string Text 
        { 
            get { return _text; } 
            set { OnPropertyChanged(ref _text,value) ; } 
        }
        private string _filePath;
        public string FilePath
        {
            get { return _filePath; }
            set
            {
                _filePath = value;
                OnPropertyChanged(ref _filePath,value); 
            }
        }
        private string _fileName;
        public string FileName
        { 
            get { return _fileName==null || _fileName==""? "Untitled Notepad Clone - Nikita" : _fileName + " Notepad Clone - Nikita "; }
            set {
                OnPropertyChanged(ref _fileName , value: value); }
        }

        public bool isEmpty
        {
            get
            {
                if(string.IsNullOrEmpty(FileName) || string.IsNullOrEmpty(FilePath))
                {
                    return true;
                }
            return false;
            }
        }
    }
}

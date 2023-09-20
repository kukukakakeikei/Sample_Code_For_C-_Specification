using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSampleCode
{
    interface IControl
    { 
        void Paint();
    }
    interface ITextBox : IControl
    { 
        void SetText(string text);
    }
    interface IListBox : IControl
    { 
        void SetItems(String[] items);
    }
    interface IComboBox : ITextBox, IListBox { }//多重继承
    interface IDataBound
    {
        void Bind(Binder b);
    }
    public class EditBox : IControl, IDataBound
    {
        public void Paint() { }
        public void Bind(Binder b) { }
    }
}

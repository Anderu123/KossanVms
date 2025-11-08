using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KossanVMS.Utility
{
    public class ListItem
    {
        public int Id;
        public string Text = "";
        public override string ToString()
        {
            return Text;
        }
    }
}

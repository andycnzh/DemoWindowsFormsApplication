using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoWindowsFormsApplication
{
    class Test
    {
        public delegate void UpdateMessageEventHandler(string message);
        public event UpdateMessageEventHandler UpdateMessageEvent;

        //public event EventHandler UpdateMessageEvent;

        public void A()
        {
            UpdateMessageEvent("This is from A");

            B();
        }

        public void B()
        {
            UpdateMessageEvent("This is from B");
        }
    }
}

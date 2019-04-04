using System;
using System.ComponentModel;

namespace StorageSystem
{
    public class MyKeyEventArgs: HandledEventArgs
    {
        public ConsoleKeyInfo key;

        public MyKeyEventArgs(ConsoleKeyInfo _key)
        {
            key = _key;
        }
    }
}

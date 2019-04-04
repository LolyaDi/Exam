using System;

namespace StorageSystem
{
    public class KeyEvent
    {
        public event EventHandler<MyKeyEventArgs> KeyPressed;

        public void OnKeyPressed(ConsoleKeyInfo _key)
        {
            KeyPressed(this, new MyKeyEventArgs(_key));
        }
    }
}

using System;

namespace UserInterface
{
    public class KeyPressEventArgs : EventArgs
    {
        public ConsoleKeyInfo Key { get; }

        public KeyPressEventArgs(ConsoleKeyInfo key)
        {
            Key = key;
        }
    }
}
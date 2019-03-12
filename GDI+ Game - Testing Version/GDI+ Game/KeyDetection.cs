using System;

namespace GDI__Game
{
    class KeyDetection
    {
        [System.Runtime.InteropServices.DllImport("user32")]
        static extern Int16 GetAsyncKeyState(int vKey);

        public bool GetKeyState(int key1)
        {
            int s = GetAsyncKeyState(key1);
            if (s == 0) { return false; }

            return true;
        }
    }
}

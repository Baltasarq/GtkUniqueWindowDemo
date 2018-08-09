namespace UniqueWindowDemo
{
    class Ppal
    {
        [System.STAThread]
        static void Main()
        {
            Gtk.Application.Init();
            new UniqueWindowCtrl().Start();
            Gtk.Application.Run();
        }
    }
}

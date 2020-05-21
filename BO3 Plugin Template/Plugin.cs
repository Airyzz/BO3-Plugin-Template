using AiryzPluginFramework;
using System.Windows.Controls;

namespace MyBO3Plugin
{
    public class Plugin : APlugin
    {
        public string TabName => "MY Plugin";
        public string Name => "Test Plugin";
        public string Author => "Author";
        public string Description => "Template Plugin";
        public string Version => "1.0.0";
        public UserControl UI => ui;
        public bool requiresUI => true;

        private Interface ui = new Interface();

        public int main()
        {
            return 1;
        }

        public bool ReadAllAddresses()
        {
            System.Console.WriteLine("Reading All Addresses for: " + Name + " Plugin");
            return true;
        }
    }
}
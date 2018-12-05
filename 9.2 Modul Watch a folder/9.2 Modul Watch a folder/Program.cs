using System;
using System.IO;

namespace _9._2_Modul_Watch_a_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            var watcher = new FileSystemWatcher();
            watcher.Path = @"C:\Projekt\AcceleratedLearning\TestMapp";
            watcher.EnableRaisingEvents = true;

            Console.WriteLine($"I'm watching this folder {watcher.Path}");

            watcher.Changed += SkapadFil;
            watcher.Deleted += BorttagenFil;
            watcher.Renamed += NyttNamn;

            Console.ReadKey();
        }

        private static void SkapadFil(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " skapades!");
        }
        private static void BorttagenFil(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " är borttagen!");
        }
        private static void NyttNamn(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine(e.Name + " är ändrad!");
        }
    }
}

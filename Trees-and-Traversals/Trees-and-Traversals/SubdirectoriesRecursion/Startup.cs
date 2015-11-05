namespace SubdirectoriesRecursion
{
    using System;
    using System.IO;

    public class Startup
    {
        static void Main(string[] args)
        {
            var rootDir = @"C:\Windows";

            TraverseDirectories(rootDir);
        }

        private static void TraverseDirectories(string rootDir)
        {
            try
            {
                if (string.IsNullOrEmpty(rootDir))
                {
                    return;
                }

                var files = Directory.GetFiles(rootDir, "*.exe");
                foreach (var file in files)
                {
                    var result = file.Split(new[] { '\\' }, StringSplitOptions.RemoveEmptyEntries);
                    var print = result[result.Length-1];
                    Console.WriteLine(print);
                }

                var dirs = Directory.EnumerateDirectories(rootDir);
                foreach (var dir in dirs)
                {
                    TraverseDirectories(dir);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

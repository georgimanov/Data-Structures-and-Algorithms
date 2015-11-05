namespace FileSystem
{
    using System;
    using System.IO;

    public class Startup
    {
        private static Folder mainFolder = new Folder("WINDOWS");

        static void Main()
        {
            TraverseMyFolderDFS(mainFolder);

            TraverseDirDFS(new DirectoryInfo(@"C:\WINDOWS\Web"), mainFolder);

            Console.WriteLine("The content size of all is: " + mainFolder.GetSizeOfAll());
        }

        private static void TraverseMyFolderDFS(Folder folder)
        {
            var folders = folder.Folders;
            foreach (var item in folders)
            {
                Console.WriteLine("Folder name: " + item.Name);
                TraverseMyFolderDFS(item);
            }

            var files = folder.Files;
            foreach (var item in files)
            {
                Console.WriteLine("File name: " + item.Name);
            }
        }

        private static void TraverseDirDFS(DirectoryInfo directory, Folder folder)
        {
            try
            {
                var files = directory.GetFiles();
                foreach (var file in files)
                {
                    var myFile = new File(file.Name, file.Length);

                    folder.Files.Add(myFile);
                }

                var directories = directory.GetDirectories();
                foreach (var dir in directories)
                {
                    var newFolder = new Folder(dir.Name);

                    TraverseDirDFS(dir, newFolder);

                    folder.Folders.Add(newFolder);
                }
            }
            catch (UnauthorizedAccessException)
            {
                return;
            }
        }
    }
}

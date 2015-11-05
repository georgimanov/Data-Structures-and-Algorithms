namespace FileSystem
{
    using System.Collections.Generic;

    public class Folder
    {
        private ICollection<File> files;
        private ICollection<Folder> folders;
        private long size = 0;

        public Folder(string name)
        {
            this.Name = name;
            this.files = new HashSet<File>();
            this.folders = new HashSet<Folder>();
        }

        public ICollection<File> Files
        {
            get
            {
                return this.files;
            }
            set
            {
                this.files = value;
            }
        }

        public ICollection<Folder> Folders
        {
            get
            {
                return this.folders;
            }
            set
            {
                this.folders = value;
            }
        }

        public string Name
        {
            get; set;
        }

        public long GetSizeOfAll()
        {
            if (this.Folders.Count == 0)
            {
                foreach (var file in this.Files)
                {
                    size += file.Size;
                }

                return size;
            }

            foreach (var file in this.Files)
            {
                size += file.Size;
            }

            foreach (var folder in this.Folders)
            {
                this.size += folder.GetSizeOfAll();
            }

            return this.size;
        }
    }
}

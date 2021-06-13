using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask
{
    class File : Folder
    {
        String fileName;
        public File(String fileName, String name, String path) : base(name, path)
        {
            this.fileName = fileName;
        }

        public virtual String getFileName()
        {
            return fileName;
        }

        public virtual void setFileName()
        {
            this.fileName = fileName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OOPTask
{
    class Folder
    {
        protected String path;
        protected String name;

        public Folder(string path, string name)
        {
            this.path = path;
            this.name = name;
        }

        public virtual String getPath()
        {
            return path;
        }
        public virtual String getName()
        {
            return name;
        }

        public virtual void setPath(String path)
        {
            this.path = path;
        }

        public virtual void setName(String name)
        {
            this.name = name;
        }
        
        

    }
}

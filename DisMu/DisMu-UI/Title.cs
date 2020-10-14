using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisMu_UI
{
    class Title
    {
        private static int idPool = 0;

        public int Id { get; }

        public String Name { get; set; }

        public Title(String name = "")
        {
            this.Id = idPool++;

            this.Name = name;
        }
    }
}

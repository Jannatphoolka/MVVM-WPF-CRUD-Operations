using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeViewers.Domain.Models
{
    public class Employee
    {
        private int id;

        public int IDProperty
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string NamesProperty
        {
            get { return name; }
            set { name = value; }
        }

        private int sal;

        public int SalProperty
        {
            get { return sal; }
            set { sal = value; }
        }

        private string design;

        public string DesignProperty
        {
            get { return design; }
            set { design = value; }
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    public abstract class Movie
    {
        private string category;
        private string title;

        public string Title
        {
            get
            {
                return title;
            }

            set
            {
                Title = title;
            }
        }

        public string Category
        {
            get
            {
                return category;
            }

            set
            {
                Category = category;
            }
        }


        public virtual string GetTitle()
        {
            return title;
        }
        public string GetCategory()
        {
            return category;
        }


    }
}
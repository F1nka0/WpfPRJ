using System;
using System.Collections.Generic;
using System.Text;

namespace BorisPRJ.DataTypes
{
    class Object
    {
        private String time;
        private String title;

        public Object(String time, String title)
        {
            this.time = time;
            this.title = title;
        }

        public String getTime()
        {
            return time;
        }

        public String getTitle()
        {
            return title;
        }
    }
}

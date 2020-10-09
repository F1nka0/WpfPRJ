using System;
using System.Collections.Generic;
using System.Text;

namespace BorisPRJ.DataTypes
{
    class Student
    {
        private String initials;
        private String group;
        private String temperatureOrFault;
        private String reasonOrMeasures;
        private bool isBored;

        public Student(String initials, String group, String temperatureOrFault, String reasonOrMeasures, bool isBored)
        {
            this.initials = initials;
            this.group = group;
            this.temperatureOrFault = temperatureOrFault;
            this.reasonOrMeasures = reasonOrMeasures;
        }

        public String getInitials()
        {
            return initials;
        }

        public String getGroup()
        {
            return group;
        }

        public String getTemperatureOrFault()
        {
            return temperatureOrFault;
        }

        public String getReasonOrMeasures()
        {
            return reasonOrMeasures;
        }
    }
}

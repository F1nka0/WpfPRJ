using System;
using System.Collections.Generic;
using System.Text;

namespace BorisPRJ.DataTypes
{
    class Group
    {
        private String title;
        private int totalStudents;
        private int factStudents;
        private int missedStudent;

        public Group(String title, int totalStudents, int factStudents)
        {
            this.title = title;
            this.totalStudents = totalStudents;
            this.factStudents = factStudents;
            this.missedStudent = totalStudents - factStudents;
        }

        public String getTitle()
        {
            return title;
        }

        public int getTotalStudents()
        {
            return totalStudents;
        }

        public int getFactStudents()
        {
            return factStudents;
        }

        public int getMissedStudent()
        {
            return missedStudent;
        }
    }
}

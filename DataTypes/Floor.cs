using System;
using System.Collections.Generic;
using System.Text;

namespace BorisPRJ.DataTypes
{
    class Floor
    {
        private bool hasToiletDesinfection;
        private bool roomVentilated;
        private bool coridorVentilated;

        public Floor(bool hasToiletDesinfection, bool isRoomVentilated, bool isCoridorVentilated)
        {
            this.hasToiletDesinfection = hasToiletDesinfection;
            this.roomVentilated = isRoomVentilated;
            this.coridorVentilated = isCoridorVentilated;
        }

        public bool isHasToiletDesinfection()
        {
            return hasToiletDesinfection;
        }

        public bool isRoomVentilated()
        {
            return roomVentilated;
        }

        public bool isCoridorVentilated()
        {
            return coridorVentilated;
        }

    }
}

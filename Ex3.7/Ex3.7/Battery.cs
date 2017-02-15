using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._7
{
    class Battery
    {
        public enum BatteryType
        {
            Li_Ion, NiMH, NiCd
        }

        BatteryType? type;
        string batteryModel;
        int? batteryCapacity;

        public Battery(BatteryType? type, string batteryModel, int? batteryCapacity)
        {
            this.type = type;
            this.batteryModel = batteryModel;
            this.batteryCapacity = batteryCapacity;
        }
    }
}

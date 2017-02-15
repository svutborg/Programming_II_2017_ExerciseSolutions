using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._7
{
    public struct ScreenDimmensions
    {
        public int? Width;
        public int? Height;
    }

    class Phone
    {
        string brand;
        string model;
        int? price;
        string owner;
        Battery bat;
        int? batteryIdleTime;
        int? batteryHoursTalk;
        ScreenDimmensions screenDimmensions;
        int? screenColorDepth;
        public List<CallInfo> Calls {get;}

        public Phone(string brand, string model, int? price, string owner, Battery.BatteryType? type, string batteryModel, int? batteryCapacity, int? batteryIdleTime, int? batteryHoursTalk, int? screenWidth, int? screenHeight, int? screenColorDepth)
        {
            this.brand = brand;
            this.model = model;
            this.price = price;
            this.owner = owner;
            bat = new Battery(type, batteryModel, batteryCapacity);
            this.batteryIdleTime = batteryIdleTime;
            this.batteryHoursTalk = batteryHoursTalk;
            this.screenDimmensions.Height = screenHeight;
            this.screenDimmensions.Width = screenWidth;
            this.screenColorDepth = screenColorDepth;
            Calls = new List<CallInfo>();
        }

        public Phone(string brand, string model, int price, Battery.BatteryType type, string batteryModel, int batteryCapacity, int batteryIdleTime, int batteryHoursTalk, int? screenWidth, int? screenHeight, int screenColorDepth): this(brand, model, price, null, type, batteryModel, batteryCapacity, batteryIdleTime, batteryHoursTalk, screenWidth, screenHeight, screenColorDepth){ }
        public Phone(string brand, string model) : this(brand, model, null, null, null, null, null, null, null, null, null, null) { }

        public void addCall(CallInfo call)
        {
            Calls.Add(call);
        }

        public string callsToString()
        {
            string result = "";
            foreach(CallInfo C in Calls)
            {
                result = $"{result}\n{C.ToString()}";
                //String.Concat(result, C.ToString(), "\n");
            }

            return result;
        }
    }

}

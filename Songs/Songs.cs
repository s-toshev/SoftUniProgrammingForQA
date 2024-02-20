using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Songs
{
    public class Songs
    {
        private string TypeList { get; set; }
        private string Name { get; set; }
        private string Time { get; set; }

        public Songs(string typeList, string name, string time)
        {
            this.TypeList = typeList;
            this.Name = name;
            this.Time = time;
        }

        public string GetTypeList()
        {
            return this.TypeList;
        }

        public string GetName() { return this.Name; }

        public string GetTime() { return this.Time; }

    }
}

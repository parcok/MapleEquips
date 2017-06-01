using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapleEquips.Objects {
    class Item {

        private string name { get; set; }
        private short str { get; set; }
        private short dex { get; set; }
        private short @int { get; set; }
        private short luk { get; set; }

        public Item() { }
        public Item(string name, short str, short dex, short @int, short luk) {
            this.name = name;
            this.str = str;
            this.dex = dex;
            this.@int = @int;
            this.luk = luk;
        }

        public string hoverStats() {
            return "STR : " + this.str + "\r\nDEX : " + this.dex + "\r\nINT : " + this.@int + "\r\nLUK : " + this.luk + "\r\nW.ATT : \r\nM.ATT : \r\n";
        }
    }
}

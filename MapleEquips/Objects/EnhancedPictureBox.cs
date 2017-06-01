using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleEquips.Objects {
    class EnhancedPictureBox : PictureBox {

        public EnhancedPictureBox():base(){ }


        public Item Item { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VipGradeModel
    {

        public VipGradeModel()
        {

        }
        public VipGradeModel(int VGID, string VGName,double VGDiscount)
        {
             this.VGID = VGID;
             this.VGName = VGName;
             this.VGDiscount = VGDiscount;
        }
        public VipGradeModel(string VGName, double VGDiscount)
        {
            this.VGName = VGName;
            this.VGDiscount = VGDiscount;
        }
        private int VGID;

        public int VGID1
        {
            get { return VGID; }
            set { VGID = value; }
        }
        private string VGName;

        public string VGName1
        {
            get { return VGName; }
            set { VGName = value; }
        }
        private double VGDiscount;

        public double VGDiscount1
        {
            get { return VGDiscount; }
            set { VGDiscount = value; }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class VipsModel
    {

        public VipsModel()
        {

        }
        public VipsModel(int VipID, string VipName, string VipSex, string GradeID, string VipTel, string VipStartDate, string VipEndDate)
        {
            this.VipID = VipID;
            this.VipName = VipName;
            this.VipSex = VipSex;
            this.GradeID =GradeID;
            this.VipTel = VipTel;
            this.VipStartDate =VipStartDate;
            this.VipEndDate = VipEndDate;
        }
        public VipsModel(string VipName, string VipSex, string GradeID, string VipTel, string VipStartDate, string VipEndDate)
        {
            this.VipName = VipName;
            this.VipSex = VipSex;
            this.GradeID = GradeID;
            this.VipTel = VipTel;
            this.VipStartDate = VipStartDate;
            this.VipEndDate = VipEndDate;
        }
        //为了模糊查询定义的
        private string VipID2;

        public string VipID21
        {
            get { return VipID2; }
            set { VipID2 = value; }
        }
        private int VipID;

        public int VipID1
        {
            get { return VipID; }
            set { VipID = value; }
        }
        private string VipName;

        public string VipName1
        {
            get { return VipName; }
            set { VipName = value; }
        }
        private string VipSex;

        public string VipSex1
        {
            get { return VipSex; }
            set { VipSex = value; }
        }
        private string GradeID;

        public string GradeID1
        {
            get { return GradeID; }
            set { GradeID = value; }
        }
        private string VipTel;

        public string VipTel1
        {
            get { return VipTel; }
            set { VipTel = value; }
        }
        private string VipStartDate;

        public string VipStartDate1
        {
            get { return VipStartDate; }
            set { VipStartDate = value; }
        }
        private string VipEndDate;

        public string VipEndDate1
        {
            get { return VipEndDate; }
            set { VipEndDate = value; }
        }

        
    }
}

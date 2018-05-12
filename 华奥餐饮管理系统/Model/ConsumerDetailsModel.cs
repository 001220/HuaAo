using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ConsumerDetailsModel
    {
        
        public ConsumerDetailsModel()
        {

        }
        public ConsumerDetailsModel(int CDID,string CBID,int ProductID,double CDPrice,int CDNum,double CDSale,double CDMoney,int CDType,string CDDate)
        {
            this.CDID = CDID;
            this.CBID = CBID;
            this.ProductID = ProductID;
            this.CDPrice = CDPrice;
            this.CDNum = CDNum;
            this.CDSale = CDSale;
            this.CDMoney = CDMoney;
            this.CDType = CDType;
            this.CDDate = CDDate;
        }
        public ConsumerDetailsModel(string CBID, int ProductID, double CDPrice, int CDNum, double CDSale, double CDMoney, int CDType, string CDDate)
        {
            this.CBID = CBID;
            this.ProductID = ProductID;
            this.CDPrice = CDPrice;
            this.CDNum = CDNum;
            this.CDSale = CDSale;
            this.CDMoney = CDMoney;
            this.CDType = CDType;
            this.CDDate = CDDate;
        }
        private int CDID;

        public int CDID1
        {
            get { return CDID; }
            set { CDID = value; }
        }
        private string CBID;

        public string CBID1
        {
            get { return CBID; }
            set { CBID = value; }
        }
        private int ProductID;

        public int ProductID1
        {
            get { return ProductID; }
            set { ProductID = value; }
        }
        private double CDPrice;

        public double CDPrice1
        {
            get { return CDPrice; }
            set { CDPrice = value; }
        }
        private int CDNum;

        public int CDNum1
        {
            get { return CDNum; }
            set { CDNum = value; }
        }
        private double CDSale;

        public double CDSale1
        {
            get { return CDSale; }
            set { CDSale = value; }
        }
        private double CDMoney;

        public double CDMoney1
        {
            get { return CDMoney; }
            set { CDMoney = value; }
        }
        private int CDType;

        public int CDType1
        {
            get { return CDType; }
            set { CDType = value; }
        }
        private string CDDate;

        public string CDDate1
        {
            get { return CDDate; }
            set { CDDate = value; }
        }
    }
}

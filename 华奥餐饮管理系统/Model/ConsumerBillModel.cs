using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //消费账单表
    public class ConsumerBillModel
    {
        
        public ConsumerBillModel()
        {

        }
        public ConsumerBillModel(string CBID,int TableID,string CBAmount,string VipID,string CBDiscount,string CBStartDate,string CBEndDate,int AdminID,double CBSale,int CBClose)
        {
            this.CBID = CBID;
            this.TableID = TableID;
            this.CBAmount = CBAmount;
            this.VipID = VipID;
            this.CBDiscount = CBDiscount;
            this.CBStartDate = CBStartDate;
            this.CBEndDate = CBEndDate;
            this.AdminID = AdminID;
            this.CBSale = CBSale;
            this.CBClose = CBClose;
        }
        public ConsumerBillModel(int TableID, string CBAmount, string VipID, string CBDiscount, string CBStartDate, string CBEndDate, int AdminID, double CBSale, int CBClose)
        {
            this.TableID = TableID;
            this.CBAmount = CBAmount;
            this.VipID = VipID;
            this.CBDiscount = CBDiscount;
            this.CBEndDate = CBEndDate;
            this.AdminID = AdminID;
            this.CBSale = CBSale;
            this.CBClose = CBClose;
        }
        private string CBID;

        public string CBID1
        {
            get { return CBID; }
            set { CBID = value; }
        }
        private int TableID;

        public int TableID1
        {
            get { return TableID; }
            set { TableID = value; }
        }
        private string CBAmount;

        public string CBAmount1
        {
            get { return CBAmount; }
            set { CBAmount = value; }
        }
        private string VipID;

        public string VipID1
        {
            get { return VipID; }
            set { VipID = value; }
        }
        private string CBDiscount;

        public string CBDiscount1
        {
            get { return CBDiscount; }
            set { CBDiscount = value; }
        }
        private string CBStartDate;

        public string CBStartDate1
        {
            get { return CBStartDate; }
            set { CBStartDate = value; }
        }
        private string CBEndDate;

        public string CBEndDate1
        {
            get { return CBEndDate; }
            set { CBEndDate = value; }
        }
        private int AdminID;

        public int AdminID1
        {
            get { return AdminID; }
            set { AdminID = value; }
        }
        private double CBSale;

        public double CBSale1
        {
            get { return CBSale; }
            set { CBSale = value; }
        }
        private int CBClose;

        public int CBClose1
        {
            get { return CBClose; }
            set { CBClose = value; }
        }
    }
}

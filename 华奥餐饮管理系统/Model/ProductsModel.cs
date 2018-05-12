using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //商品类实体层基于商品表字段写该字段
    public class ProductsModel
    {
        public ProductsModel()
        {

        }
        public ProductsModel(int ProductID,string ProductName,string PTID,string ProductJP,double ProductPrice)
        {
            this.ProductID = ProductID;
            this.ProductName = ProductName;
            this.PTID = PTID;
            this.ProductJP = ProductJP;
            this.ProductPrice = ProductPrice;
        }
        public ProductsModel(string ProductName, string PTID, string ProductJP, double ProductPrice)
        {
            this.ProductName = ProductName;
            this.PTID = PTID;
            this.ProductJP = ProductJP;
            this.ProductPrice = ProductPrice;
        }
        private int ProductID;

        public int ProductID1
        {
            get { return ProductID; }
            set { ProductID = value; }
        }
        private string ProductName;

        public string ProductName1
        {
            get { return ProductName; }
            set { ProductName = value; }
        }
        private string PTID;

        public string PTID1
        {
            get { return PTID; }
            set { PTID = value; }
        }
        private string ProductJP;

        public string ProductJP1
        {
            get { return ProductJP; }
            set { ProductJP = value; }
        }
        private double ProductPrice;

        public double ProductPrice1
        {
            get { return ProductPrice; }
            set { ProductPrice = value; }
        }

    }
}

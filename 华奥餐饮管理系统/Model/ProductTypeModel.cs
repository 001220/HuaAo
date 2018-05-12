using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class ProductTypeModel
    {

        public ProductTypeModel()
        {

        }

        public ProductTypeModel(int PTID, string PTName)
        {
            this.PTID = PTID;
            this.PTName = PTName;
        }
        private int PTID;

        public int PTID1
        {
            get { return PTID; }
            set { PTID = value; }
        }

        private string PTName;

        public string PTName1
        {
            get { return PTName; }
            set { PTName = value; }
        }
    }
}

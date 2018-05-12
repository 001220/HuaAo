using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    /// <summary>
    /// 房间类型表
    /// </summary>
    public class RoomTypeModel
    {
        public RoomTypeModel()
        {

        }
        public RoomTypeModel(int RTID, string RTName, int RTConsume, int RTIsDisCount, int RTMount)
        {
            this.RTID = RTID;
            this.RTName = RTName;
            this.RTConsume = RTConsume;
            this.RTIsDisCount = RTIsDisCount;
            this.RTMount = RTMount;
        }

        public RoomTypeModel(string RTName, int RTConsume, int RTIsDisCount, int RTMount)
        {
            this.RTName = RTName;
            this.RTConsume = RTConsume;
            this.RTIsDisCount = RTIsDisCount;
            this.RTMount = RTMount;
        }
        private int RTID = -1;

        public int RTID1
        {
            get { return RTID; }
            set { RTID = value; }
        }
        private string RTName;

        public string RTName1
        {
            get { return RTName; }
            set { RTName = value; }
        }
        private int RTConsume;

        public int RTConsume1
        {
            get { return RTConsume; }
            set { RTConsume = value; }
        }
        private int RTIsDisCount;

        public int RTIsDisCount1
        {
            get { return RTIsDisCount; }
            set { RTIsDisCount = value; }
        }
        private int RTMount;

        public int RTMount1
        {
            get { return RTMount; }
            set { RTMount = value; }
        }
    }
}

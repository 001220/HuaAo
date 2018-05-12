using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class EditingRoomBLL
    {
        public static bool flag(RoomTypeModel room) {
            if (room.RTID1==-1)
            {
                return false;
            }
            return true;
        }
    }
}

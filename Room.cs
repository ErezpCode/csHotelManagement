using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{

    internal class Room
   
    {
        private int roomNumber;
        private bool isFree;
        private int floor;

        public Room(int roomNumber ,  int floor)
       {
            this.roomNumber = roomNumber;
            this.floor = floor;
            this.isFree = false;
        }



}

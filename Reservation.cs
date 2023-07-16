using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    intrernal class Reservation
    {
        private Client client;
        private Room room;
        private Payment payment;

        public Reservation(Client client, Room room, Payment payment)
        {
            this.client = client;
            this.room = room;
            this.payment = payment;

        }

    }

}

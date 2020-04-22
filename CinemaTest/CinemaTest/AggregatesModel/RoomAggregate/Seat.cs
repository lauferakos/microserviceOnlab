using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.RoomAggregate
{
    public class Seat : Entity
    {
       

        private int row;

        [Required]
        public int Row
        {
            get { return row; }
            set { row = value; }
        }

        private int column;

        [Required]
        public int Column
        {
            get { return column; }
            set { column = value; }
        }

        private int price;
        [Required]
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        //RoomFK

        private int roomId;

        public Room Room { get; set; }

        [ForeignKey("Room")]
        public int RoomFK
        {
            get { return roomId; }
            set { roomId = value; }
        }
    }
}

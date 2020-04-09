using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.OrderAggregate
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

    }
}

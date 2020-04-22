using CinemaTest.AggregatesModel.OrderAggregate;
using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.ViewerAggregate
{
    public class Viewer : Entity, IAggregateRoot
    {
		private int orderId;

		public Order Order { get; set; }

		[ForeignKey("Order")]
		public int OrderFK
		{
			get { return orderId; }
			set { orderId = value; }
		}

	}
}

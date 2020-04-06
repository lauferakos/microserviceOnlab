using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WindowsWebApp.AggregatesModel.OrderAggregate;
using WindowsWebApp.Infractructure.SeedWork;

namespace WindowsWebApp.AggregatesModel.ViewerAggregate
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

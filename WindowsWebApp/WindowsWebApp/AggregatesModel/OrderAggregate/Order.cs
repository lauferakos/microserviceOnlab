using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using WindowsWebApp.AggregatesModel.ProjectionAggregate;
using WindowsWebApp.Infractructure.SeedWork;

namespace WindowsWebApp.AggregatesModel.OrderAggregate
{
    public class Order : Entity, IAggregateRoot
    {
		private int projectionId;

		public Projection Projection { get; set; }

		[ForeignKey("Projection")]
		public int ProjectionFK
		{
			get { return projectionId; }
			set { projectionId = value; }
		}

		private int fullPrice;

		public int FullPrice
		{
			get { return fullPrice; }
			set { fullPrice = value; }
		}


	}
}

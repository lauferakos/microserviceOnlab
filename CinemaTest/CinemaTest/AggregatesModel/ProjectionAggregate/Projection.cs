using CinemaTest.AggregatesModel.RoomAggregate;
using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.ProjectionAggregate
{
    public class Projection : Entity, IAggregateRoot
    {
		
		private int filmId;

		public Film Film { get; set; }

		[ForeignKey("Film")]
		public int FilmFK
		{
			get { return filmId; }
			set { filmId = value; }
		}

		private int roomId;

		public Room Room { get; set; }

		[ForeignKey("Room")]
		public int RoomFK
		{
			get { return roomId; }
			set { roomId = value; }
		}

		private DateTime startTime;

		[Required]
		public  DateTime StartTime
		{
			get { return startTime; }
			set { startTime = value; }
		}

		private int freeSeats;

		[Required]
		public int FreeSeats
		{
			get { return freeSeats; }
			set { freeSeats = value; }
		}





	}
}

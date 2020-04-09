﻿using CinemaTest.SeedWork;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CinemaTest.AggregatesModel.ProjectionAggregate
{
    public class Room : Entity
    {
		
		private int roomNumber;

		[Required]
		public int RoomNumber
		{
			get { return roomNumber; }
			set { roomNumber = value; }
		}

		private int numOfSeats;

		[Required]
		public int NumOfSeats
		{
			get { return numOfSeats; }
			set { numOfSeats = value; }
		}



	}
}
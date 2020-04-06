using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WindowsWebApp.Infractructure.SeedWork;

namespace WindowsWebApp.AggregatesModel.ProjectionAggregate
{
    public class Film : Entity
    {
        private string title;

        [Required]
        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        private int duration;

        [Required]
        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        private string director;

        public string Director
        {
            get { return director; }
            set { director = value; }
        }

        private string descprition;

        public string Description
        {
            get { return descprition; }
            set { descprition = value; }
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Together.Mobile.Model
{
    public class RouteListItem
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime CreateDate { get; set; }

        public int MaxPassengers { get; set; }

        public int PassengersCount { get; set; }

        public string RouteType { get; set; }

        public string CreatorId { get; set; }

        public string CreatorFirstName { get; set; }

        public string CreatorLastName { get; set; }

        // public List<RouteListPassengerModel> Passengers { get; set; }

        // public List<RoutePointModel> RoutePoints { get; set; }
    }
}

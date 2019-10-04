using System;
using System.Collections.Generic;
using System.Text;
using Together.Mobile.Model;

namespace Together.Mobile.ViewModels
{
    public class RouteListViewModel
    {
        public List<RouteListItem> Routes { get; }

        public RouteListViewModel()
        {
            Routes = new List<RouteListItem>();
            for (int i = 0; i < 8; i++)
            {
                Routes.Add(new RouteListItem()
                {
                    Id = 1,
                    CreateDate = DateTime.Now,
                    CreatorFirstName = $"User {i}",
                    CreatorLastName = $"Lastname {i}",
                    MaxPassengers = i + 1,
                    PassengersCount = i,
                    RouteType = "Car",
                    StartDate = DateTime.Now.AddHours(i),
                    Name = $"Route {i}",
                    CreatorId = $"{i}"
                });
            }
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using LogisticsFlow.Models;
using System.Collections.Generic;

namespace LogisticsFlow.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        // This is the data that the Dashboard needs to display
        var shipments = new List<Shipment>
        {
            new Shipment { Id = 1, TrackingNumber = "RYD-1001", CarrierName = "Ryder", Status = "In Transit", Destination = "Vienna, VA" },
            new Shipment { Id = 2, TrackingNumber = "CH-2002", CarrierName = "Cardinal Health", Status = "Delayed", Destination = "Chicago, IL" },
            new Shipment { Id = 3, TrackingNumber = "TOTE-3003", CarrierName = "TOTE Logistics", Status = "Delivered", Destination = "Miami, FL" },
            new Shipment { Id = 4, TrackingNumber = "RYD-1005", CarrierName = "Ryder", Status = "Delivered", Destination = "Dallas, TX" }
        };

        // This line is the most important—it sends the list to the View
        return View(shipments);
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
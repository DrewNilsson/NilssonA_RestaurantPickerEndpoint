// Andrew Nilsson
// 10/27/22
// Restuarant Picker - Endpoint
// A webapi that takes an input and outputs a random restaurant from the category inputed
// Peer Review by Jovann Contreras -  Code looks clean I am able to choose between 3 categories and get a random result I also like how simplified the code is.


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NilssonA_RestaurantPickerEndpoint.Controllers
{
    [Route("[controller]")]
    public class RestaurantPickerController : Controller
    {
        [HttpGet]
        [Route("Picker/{input}")]
        public string Picker(string input)
        {
            string[] breakfast = { "Denny's", "BiscuitVille", "Cracker Barrel", "Waffle House", "IHOP", "The Original Pancake House", "Black Bear Diner", "Huddle House", "Snooze", "The Flying Biscuit" };
            string[] dinner = { "Olive Garden", "The Cheesecake Factory", "Texas Roadhouse", "Red Lobster", "Outback Steakhouse", "Buffalo Wild Wings", "Longhorn Steakhouse", "Red Robin", "Chili's", "Applebee's" };
            string[] fastFood = { "Five Guys", "Arby's", "McDonald's", "Carl's Jr.", "Dairy Queen", "Popeyes", "In-N-Out", "Jack in the Box", "Smashburger", "Dominos Pizza" };

            int catIndex;
            int index = 0;
            Random rnd = new Random();

            if (input == "breakfast") catIndex = 0;
            else if (input == "dinner") catIndex = 1;
            else if (input == "fast food") catIndex = 2;
            else catIndex = rnd.Next(3);

            index = rnd.Next(10);

            switch (catIndex)
            {
                case 0:
                    return breakfast[index];
                case 1:
                    return dinner[index];
                case 2:
                    return fastFood[index];
                default:
                    return "Error";
            }
        }
    }
}
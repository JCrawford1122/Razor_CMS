using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ScheduleApp.Pages.Customers
{
    public class DetailsModel : PageModel
    {
        public Customer Customer { get; set; }
        public void OnGet(int customerId)
        {
            Customer = new Customer();
            Customer.Id = customerId;
        }
    }
}
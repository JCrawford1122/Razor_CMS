using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core;
using CMS.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ScheduleApp.Pages.Customers
{
    public class DetailsModel : PageModel
    {

        public Customer Customer { get; set; }
        private readonly ICmsData customerData;

        public IActionResult OnGet(int customerId)
        {
            Customer = customerData.CustomerById(customerId);
            if(Customer == null)
            {
                return RedirectToPage("NotFound");
            }
            return Page();
        }
        public DetailsModel(ICmsData customerData)
        {
            this.customerData = customerData;
        }
    }
}
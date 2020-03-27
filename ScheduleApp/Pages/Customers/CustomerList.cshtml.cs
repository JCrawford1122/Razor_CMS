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
    public class CustomerListModel : PageModel
    {
        public IEnumerable<Customer> Customers { get; set; }
        public readonly ICmsData CmsData;
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public CustomerListModel(ICmsData cmsData)
        {
            this.CmsData = cmsData;
        }

      

        public void OnGet(string searchTerm)
        {
            Customers = CmsData.GetCustomersByName(SearchTerm);
        }
    }
}

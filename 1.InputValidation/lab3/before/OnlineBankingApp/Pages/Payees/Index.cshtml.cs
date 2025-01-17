using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OnlineBankingApp.Data;
using OnlineBankingApp.Models;
using OnlineBankingApp.Services;

namespace OnlineBankingApp.Pages.Payees
{
    public class IndexModel : PageModel
    {
        public IList<Payee> Payee { get;set; }

        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        private readonly IPayeeService _payeeService;
        private readonly ILdapDirectoryService _ldapDirectoryService;

        public IndexModel(IPayeeService payeeService, ILdapDirectoryService ldapDirectoryService)
        {
            _payeeService = payeeService;
            _ldapDirectoryService = ldapDirectoryService;
        }

        public void OnGet()
        {

            var payees = _payeeService.Get(); 

            if (!string.IsNullOrEmpty(SearchString))
            {
                var user = _ldapDirectoryService.Search(SearchString);
                payees = _payeeService.Get(SearchString);                
            }

            Payee = payees.ToList();
        }
    }
}

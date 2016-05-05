using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NonMVC.Models.AccountViewModels
{
    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        
        public string ReturnUrl { get; set; }

        public bool RememberMe { get; set; }
    }
}

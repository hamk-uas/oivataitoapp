using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using OivaTaitoApp.Services;
using OivaTaitoApp.Data.Models;
using OivaTaitoApp.Userid;
namespace OivaTaitoApp.Pages
{
    public class LogoutDeleteUserModel : PageModel
    {
        private UserService _userService;
        private GlobalId _globalId;
        public LogoutDeleteUserModel(UserService userService, GlobalId globalId)
        {
            _userService = userService;
            _globalId = globalId;
        }
        
        public string ReturnUrl { get; private set; }
        public async Task<IActionResult> OnGetAsync(
            string returnUrl = null)
        {
            _ = returnUrl ?? Url.Content("~/");
            // Clear the existing external cookie
            try
            {
                await HttpContext
                    .SignOutAsync();
                _userService.DeleteUser(_userService.GetUser(_globalId.GetGlobalId()));
                
            }
            catch (Exception ex)
            {
                string error_ = ex.Message;
            }
            return LocalRedirect("/");
        }
    }
}
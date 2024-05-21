// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
#nullable disable

using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Bulky.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BulkyWeb.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        //private readonly UserManager<IdentityUser> _userManager;
        //private readonly SignInManager<IdentityUser> _signInManager;


        //public IndexModel(
        //    UserManager<IdentityUser> userManager,
        //    SignInManager<IdentityUser> signInManager)
        //{
        //    _userManager = userManager;
        //    _signInManager = signInManager;
        //}
        private readonly UserManager<ApplicationUser> _userManager; // Change IdentityUser to ApplicationUser
        private readonly SignInManager<ApplicationUser> _signInManager; // Change IdentityUser to ApplicationUser

        public IndexModel(
            UserManager<ApplicationUser> userManager, // Change IdentityUser to ApplicationUser
            SignInManager<ApplicationUser> signInManager) // Change IdentityUser to ApplicationUser
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }






        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [TempData]
        public string StatusMessage { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        [BindProperty]
        public InputModel Input { get; set; }

        /// <summary>
        ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
        ///     directly from your code. This API may change or be removed in future releases.
        /// </summary>
        public class InputModel
        {
            /// <summary>
            ///     This API supports the ASP.NET Core Identity default UI infrastructure and is not intended to be used
            ///     directly from your code. This API may change or be removed in future releases.
            /// </summary>
            /// 


            [DisplayName("Address")]
            public string? StreetAddress { get; set; }
            public string? City { get; set; }
            public string? State { get; set; }

            public string? PostalCode { get; set; }

            [Required]
            [Phone]
            [Display(Name = "Phone number")]
            public string? PhoneNumber { get; set; }

            public string? Country { get; set; }
            [Required]
            [DisplayName("First Name")]
            public string? Name { get; set; }
            public string? LastName { get; set; }

        }

        private async Task LoadAsync(ApplicationUser user)
        {
            //var userName = await _userManager.GetUserNameAsync(user);
            //var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            var userName = await _userManager.GetUserNameAsync(user);
            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);

            //Add the new fields here
            //var name = user.Name;
            //var lastName = user.LastName;
            //var streetAddress = user.StreetAddress;
            //var city = user.City;
            //var state = user.State;
            //var country = user.Country;
            //var postalCode = user.PostalCode;

            var userWithCustomProperties = await _userManager.FindByIdAsync(user.Id);

            var name = userWithCustomProperties.Name;
            var lastName = userWithCustomProperties.LastName;
            var streetAddress = userWithCustomProperties.StreetAddress;
            var city = userWithCustomProperties.City;
            var state = userWithCustomProperties.State;
            var country = userWithCustomProperties.Country;
            var postalCode = userWithCustomProperties.PostalCode;

            Username = userName;

            Input = new InputModel
            {
                PhoneNumber = phoneNumber,
                Name = name,
                LastName = lastName,
                StreetAddress = streetAddress,
                City = city,
                State = state,
                Country = country,
                PostalCode = postalCode
            };
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            var phoneNumber = await _userManager.GetPhoneNumberAsync(user);
            if (Input.PhoneNumber != phoneNumber)
            {
                var setPhoneResult = await _userManager.SetPhoneNumberAsync(user, Input.PhoneNumber);
                if (!setPhoneResult.Succeeded)
                {
                    StatusMessage = "Unexpected error when trying to set phone number.";
                    return RedirectToPage();
                }
            }

            await _signInManager.RefreshSignInAsync(user);
            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}

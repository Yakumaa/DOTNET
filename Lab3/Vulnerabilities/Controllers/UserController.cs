using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Vulnerabilities.Data;
using Vulnerabilities.Models;

namespace Vulnerabilities.Controllers
{
    [AutoValidateAntiforgeryToken] // CSRF Protection
    public class UserController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: /User/Login
        public IActionResult Login()
        {
            return View();
        }

        // POST: /User/Login
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Prevent SQL Injection by using parameterized query
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);

            if (user != null)
            {
                // Login successful
                return RedirectToAction("Profile", new { id = user.Id });
            }

            ModelState.AddModelError("", "Invalid username or password");
            return View();
        }

        // GET: /User/Profile/5
        public async Task<IActionResult> Profile(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: /User/UpdateProfile
        [HttpPost]
        public async Task<IActionResult> UpdateProfile(int id, string email)
        {
            var user = await _context.Users.FindAsync(id);
            if (user == null)
            {
                return NotFound();
            }

            user.Email = email;
            await _context.SaveChangesAsync();

            // Prevent Open Redirect attack
            return RedirectToLocal($"/User/Profile/{id}");
        }

        // Helper method to prevent Open Redirect attacks
        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(Profile));
            }
        }
    }
}

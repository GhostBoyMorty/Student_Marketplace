using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Student_Marketplace.Models;

namespace Student_Marketplace.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Marketplace()
        {
            ViewBag.UserName = "Guest";
            return View();
        }

        public IActionResult Auth()
        {
            return View();
        }

        // PARTIAL LOADER. . .
        public IActionResult LoadPartial(string partial)
        {
            // Set common seller data for all partials
            ViewBag.SellerData = new {
                SellerId = "12345678",
                BusinessName = "Campus Eats Delivery",
                AvatarUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?auto=format&fit=crop&w=150&q=80",
                Rating = 4.9,
                TotalReviews = 67,
                TotalSales = 234,
                ActiveListings = 6,
                PendingInquiries = 12,
                CompletedSales = 45,
                UnreadMessages = 3,
                RecentEarnings = 1250.00,
                ProfileViews = 1824,
                ConversionRate = "7.2%",
                AverageRating = "4.9",
                ResponseTime = "< 4 hours",
                DeliveryRadius = "5 km",
                CampusCoverage = "Durban Campuses",
                NotificationChannel = "Email",
                NewOrders = 1,
                DraftShipments = 0,
                ConfirmedShipments = 1,
                ShippedShipments = 6,
                NotificationsCount = 2,
                ExportRequests = 4
            };

            // Set partial-specific data
            ViewBag.Listings = new[] {
                new { Id = 1, Title = "Chicken Wrap Meal", Price = 45, Status = "Active", Views = 23, Inquiries = 5 },
                new { Id = 2, Title = "Veggie Bowl Special", Price = 38, Status = "Active", Views = 31, Inquiries = 8 },
                new { Id = 3, Title = "Breakfast Sandwich", Price = 32, Status = "Active", Views = 18, Inquiries = 3 },
                new { Id = 4, Title = "Healthy Salad Box", Price = 42, Status = "Active", Views = 12, Inquiries = 2 },
                new { Id = 5, Title = "Custom Meal Prep Service", Price = 280, Status = "Active", Views = 8, Inquiries = 1 },
                new { Id = 6, Title = "Catering for Events", Price = 450, Status = "Active", Views = 15, Inquiries = 4 }
            };

            ViewBag.Orders = new[] {
                new { Id = 1, CustomerName = "John Doe", Amount = 150, Status = "Delivered", Date = "2024-05-08" },
                new { Id = 2, CustomerName = "Jane Smith", Amount = 95, Status = "Processing", Date = "2024-05-10" },
                new { Id = 3, CustomerName = "Mike Johnson", Amount = 210, Status = "Pending", Date = "2024-05-11" }
            };

            ViewBag.Analytics = new {
                TotalViews = 1824,
                TotalClicks = 156,
                TotalSales = 234,
                Revenue = 29475.00,
                ConversionRate = 7.2,
                AverageOrderValue = 125.50,
                TopProduct = "Chicken Wrap Meal",
                BestDay = "Friday",
                PeakHour = "12:00 - 14:00"
            };

            ViewBag.Profile = new {
                BusinessName = "Campus Eats Delivery",
                AvatarUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?auto=format&fit=crop&w=150&q=80",
                Email = "campuseats@vendly.co.za",
                Phone = "+27 61 234 5678",
                Campus = "Durban Campuses",
                Address = "DUT North Campus, Durban",
                DeliveryRadius = "5 km",
                Bio = "Delivering fresh, affordable meals to students across DUT campuses.",
                IsVerified = true,
                Rating = 4.9
            };

            ViewBag.Settings = new {
                BusinessName = "Campus Eats Delivery",
                AvatarUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?auto=format&fit=crop&w=150&q=80",
                Email = "campuseats@vendly.co.za",
                Phone = "+27 61 234 5678",
                Campus = "Durban Campuses",
                Address = "DUT North Campus, Durban",
                DeliveryRadius = "5 km",
                NotificationEmail = true,
                NotificationSms = false,
                PayoutMethod = "Bank Transfer",
                BankName = "First National Bank",
                AccountNumber = "1234567890"
            };

            return PartialView($"~/Views/Home/SellerPartials/_{partial}.cshtml");
        }

        public IActionResult Profile(string sellerId)
        {
            // Mock seller data - in real app this would come from database
            var sellers = new Dictionary<string, object>
            {
                ["demo-seller"] = new {
                    SellerId = "demo-seller",
                    BusinessName = "Campus Eats Delivery",
                    AvatarUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?auto=format&fit=crop&w=150&q=80",
                    Rating = 4.9,
                    TotalReviews = 67,
                    TotalSales = 234,
                    MemberSince = "January 2024",
                    IsVerified = true,
                    Bio = "Delivering fresh, affordable meals to students across DUT campuses. Specializing in healthy options and quick delivery.",
                    Campus = "Durban Campuses",
                    ResponseTime = "< 2 hours",
                    Email = "campuseats@vendly.co.za",
                    Phone = "+27 61 234 5678",
                    Address = "DUT North Campus, Durban",
                    DeliveryRadius = "5 km",
                    Categories = new[] { "Food & Catering", "Campus Meals", "Meal Prep" },
                    OpenHours = "Mon - Fri, 08:00 - 20:00",
                    Followers = 124,
                    ListingsCount = 12,
                    Reviews = new[] {
                        new { Reviewer = "Nandi M.", Rating = 5, Comment = "Great portion sizes and quick delivery!", Time = "1 day ago" },
                        new { Reviewer = "Lwazi P.", Rating = 5, Comment = "The wrap was fresh and tasty. Highly recommend.", Time = "3 days ago" },
                        new { Reviewer = "Sibongile T.", Rating = 4, Comment = "Excellent service, just wish the drink options were bigger.", Time = "5 days ago" }
                    }
                },
                ["thabo-seller"] = new {
                    SellerId = "thabo-seller",
                    BusinessName = "Thabo's Textbooks",
                    AvatarUrl = "https://images.unsplash.com/photo-1472099645785-5658abf4ff4e?auto=format&fit=crop&w=150&q=80",
                    Rating = 4.8,
                    TotalReviews = 45,
                    TotalSales = 156,
                    MemberSince = "March 2024",
                    IsVerified = true,
                    Bio = "Secondhand textbooks at affordable prices. All books are in good condition and include study notes.",
                    Campus = "Durban Campuses",
                    ResponseTime = "< 1 hour",
                    Email = "thabo.books@vendly.co.za",
                    Phone = "+27 74 567 8901",
                    Address = "DUT City Campus, Durban",
                    DeliveryRadius = "6 km",
                    Categories = new[] { "Books", "Study Materials", "Revision Notes" },
                    OpenHours = "Mon - Sat, 09:00 - 17:00",
                    Followers = 72,
                    ListingsCount = 9,
                    Reviews = new[] {
                        new { Reviewer = "Kabelo Z.", Rating = 5, Comment = "Fast response and good condition books.", Time = "2 days ago" },
                        new { Reviewer = "Anele D.", Rating = 4, Comment = "Helpful seller, great prices.", Time = "4 days ago" },
                        new { Reviewer = "Musa T.", Rating = 5, Comment = "Saved me money with secondhand textbooks.", Time = "1 week ago" }
                    }
                },
                ["zinhle-seller"] = new {
                    SellerId = "zinhle-seller",
                    BusinessName = "Zinhle's Tech Repairs",
                    AvatarUrl = "https://images.unsplash.com/photo-1494790108755-2616b612b786?auto=format&fit=crop&w=150&q=80",
                    Rating = 4.9,
                    TotalReviews = 78,
                    TotalSales = 203,
                    MemberSince = "February 2024",
                    IsVerified = true,
                    Bio = "Professional phone and laptop repairs. Fast turnaround and warranty on all work.",
                    Campus = "Midlands Campus",
                    ResponseTime = "< 3 hours",
                    Email = "zinhle.repair@vendly.co.za",
                    Phone = "+27 73 456 7890",
                    Address = "DUT Midlands Campus",
                    DeliveryRadius = "8 km",
                    Categories = new[] { "Tech Repair", "Phone Repair", "Laptop Service" },
                    OpenHours = "Mon - Fri, 10:00 - 18:00",
                    Followers = 94,
                    ListingsCount = 10,
                    Reviews = new[] {
                        new { Reviewer = "Sipho K.", Rating = 5, Comment = "Repaired my phone quickly and affordably.", Time = "12 hours ago" },
                        new { Reviewer = "Thuli M.", Rating = 5, Comment = "Excellent service with a warranty.", Time = "3 days ago" },
                        new { Reviewer = "Zodwa P.", Rating = 4, Comment = "Very professional and fast.", Time = "5 days ago" }
                    }
                },
                ["innocent-seller"] = new {
                    SellerId = "innocent-seller",
                    BusinessName = "Innocent Graphics",
                    AvatarUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?auto=format&fit=crop&w=150&q=80",
                    Rating = 4.7,
                    TotalReviews = 32,
                    TotalSales = 89,
                    MemberSince = "April 2024",
                    IsVerified = true,
                    Bio = "Professional graphic design services for students and businesses. Logos, posters, and branding.",
                    Campus = "Durban Campuses",
                    ResponseTime = "< 4 hours",
                    Email = "innocent.design@vendly.co.za",
                    Phone = "+27 79 123 4567",
                    Address = "DUT North Campus",
                    DeliveryRadius = "7 km",
                    Categories = new[] { "Graphic Design", "Branding", "Print Design" },
                    OpenHours = "Mon - Fri, 09:00 - 19:00",
                    Followers = 64,
                    ListingsCount = 7,
                    Reviews = new[] {
                        new { Reviewer = "Mbali S.", Rating = 5, Comment = "Beautiful designs and fast turnaround.", Time = "6 days ago" },
                        new { Reviewer = "Jason P.", Rating = 4, Comment = "Great quality but a bit pricey.", Time = "1 week ago" },
                        new { Reviewer = "Lerato N.", Rating = 5, Comment = "Very professional and responsive.", Time = "2 weeks ago" }
                    }
                },
                ["siya-seller"] = new {
                    SellerId = "siya-seller",
                    BusinessName = "Siya's Math Tutoring",
                    AvatarUrl = "https://images.unsplash.com/photo-1500648767791-00dcc994a43e?auto=format&fit=crop&w=150&q=80",
                    Rating = 4.8,
                    TotalReviews = 56,
                    TotalSales = 178,
                    MemberSince = "January 2024",
                    IsVerified = true,
                    Bio = "Mathematics tutoring for all levels. Patient and experienced tutor with proven results.",
                    Campus = "Durban Campuses",
                    ResponseTime = "< 2 hours",
                    Email = "siya.tutoring@vendly.co.za",
                    Phone = "+27 72 345 6789",
                    Address = "DUT City Campus, Durban",
                    DeliveryRadius = "4 km",
                    Categories = new[] { "Tutoring", "Math Help", "Exam Prep" },
                    OpenHours = "Mon - Sat, 09:00 - 18:00",
                    Followers = 88,
                    ListingsCount = 8,
                    Reviews = new[] {
                        new { Reviewer = "Thabo N.", Rating = 5, Comment = "Clear explanations and excellent support.", Time = "2 days ago" },
                        new { Reviewer = "Zinhle S.", Rating = 5, Comment = "Helped me improve my grades quickly.", Time = "6 days ago" },
                        new { Reviewer = "Anele D.", Rating = 4, Comment = "Very patient and knowledgeable.", Time = "1 week ago" }
                    }
                }
            };

            var sellerData = sellers.ContainsKey(sellerId ?? "demo-seller")
                ? sellers[sellerId ?? "demo-seller"]
                : sellers["demo-seller"];

            ViewBag.Seller = sellerData;
            return View();
        }

        public IActionResult SellerDashboard()
        {
            // Mock seller dashboard data
            ViewBag.SellerData = new {
                SellerId = "12345678",
                BusinessName = "Campus Eats Delivery",
                AvatarUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?auto=format&fit=crop&w=150&q=80",
                Rating = 4.9,
                TotalReviews = 67,
                TotalSales = 234,
                ActiveListings = 6,
                PendingInquiries = 12,
                CompletedSales = 45,
                UnreadMessages = 3,
                RecentEarnings = 1250.00,
                ProfileViews = 1824,
                ConversionRate = "7.2%",
                AverageRating = "4.9",
                ResponseTime = "< 4 hours",
                DeliveryRadius = "5 km",
                CampusCoverage = "Durban Campuses",
                NotificationChannel = "Email",
                NewOrders = 1,
                DraftShipments = 0,
                ConfirmedShipments = 1,
                ShippedShipments = 6,
                NotificationsCount = 2,
                ExportRequests = 4
            };

            ViewBag.Listings = new[] {
                new { Id = 1, Title = "Chicken Wrap Meal", Price = 45, Status = "Active", Views = 23, Inquiries = 5 },
                new { Id = 2, Title = "Veggie Bowl Special", Price = 38, Status = "Active", Views = 31, Inquiries = 8 },
                new { Id = 3, Title = "Breakfast Sandwich", Price = 32, Status = "Active", Views = 18, Inquiries = 3 },
                new { Id = 4, Title = "Healthy Salad Box", Price = 42, Status = "Active", Views = 12, Inquiries = 2 },
                new { Id = 5, Title = "Custom Meal Prep Service", Price = 280, Status = "Active", Views = 8, Inquiries = 1 },
                new { Id = 6, Title = "Catering for Events", Price = 450, Status = "Active", Views = 15, Inquiries = 4 }
            };

            return View();
        }

        public IActionResult Settings()
        {
            ViewBag.SettingsData = new
            {
                BusinessName = "Campus Eats Delivery",

                AvatarUrl = "https://images.unsplash.com/photo-1507003211169-0a1dd7228f2d?auto=format&fit=crop&w=150&q=80",

                Email = "campuseats@vendly.co.za",
                Phone = "+27 61 234 5678",
                Campus = "Durban Campuses",
                Address = "DUT North Campus, Durban",
                DeliveryRadius = "5 km",
                NotificationEmail = true,
                NotificationSms = false,
                PayoutMethod = "Bank Transfer",
                BankName = "First National Bank",
                AccountNumber = "1234567890"
            };

            return View();
        }

        [HttpPost]
        public IActionResult SaveSettings(IFormCollection form)
        {
            // Placeholder for future backend integration.
            // The form values are available in `form` and can be saved to a database.
            TempData["SettingsSaved"] = "Your settings have been saved successfully.";
            return RedirectToAction("Settings");
        }

        [HttpPost]
        public IActionResult SaveProfile(IFormCollection form)
        {
            // Placeholder for future backend integration.
            // The profile values are available in `form` and can be saved to a database.
            TempData["ProfileSaved"] = "Your profile updates have been saved successfully.";
            return RedirectToAction("Profile", new { sellerId = form["SellerId"].ToString() ?? "demo-seller" });
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // Browsing page for guests
        public IActionResult Shopping()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

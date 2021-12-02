using Microsoft.AspNetCore.Mvc;

namespace PartsUnlimited.PaymentsService.Controllers;

[ApiController]
[Route("[controller]")]
public class PaymentsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Processing"
    };

    private readonly ILogger<PaymentsController> _logger;

    public PaymentsController(ILogger<PaymentsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetPayments")]
    public IEnumerable<Payments> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Payments
        {
            if (string.Equals(formCollection["PromoCode"].FirstOrDefault(), PromoCode,
                    StringComparison.OrdinalIgnoreCase) == false)
                {
                    return View(order);
                }
                else
                {
                    order.Username = HttpContext.User.Identity.Name;
                    order.OrderDate = DateTime.Now;

                    //Add the Order
                    _db.Orders.Add(order);

                    //Process the order
                    var cart = ShoppingCart.GetCart(_db, HttpContext);
                    cart.CreateOrder(order);

                    // Save all changes
                    await _db.SaveChangesAsync(HttpContext.RequestAborted);

                    return RedirectToAction("Complete",
                        new { id = order.OrderId });
                }
        })
        .ToArray();
    }
}

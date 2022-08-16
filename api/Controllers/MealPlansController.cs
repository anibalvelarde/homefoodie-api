using Microsoft.AspNetCore.Mvc;
using homefoodie_api.Models;

namespace homefoodie_api.Controllers;

[ApiController]
[Route("[controller]")]
public class MealPlansController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<MealPlansController> _logger;

    public MealPlansController(ILogger<MealPlansController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "ProposeMealPlan")]
    public Dictionary<string, IEnumerable<Meal>> Get(int dailyMealsToPlan)
    {
        var planner = new MealPlanner(dailyMealsToPlan);
        var weeklyMealPlan = new Dictionary<string, IEnumerable<Meal>>();
        weeklyMealPlan.Add("Monday", planner.MondayMeals());
        weeklyMealPlan.Add("Tuesday", planner.TuesdayMeals());
        weeklyMealPlan.Add("Wednesday", planner.WednesdayMeals());
        weeklyMealPlan.Add("Thursday", planner.ThursdayMeals());
        weeklyMealPlan.Add("Friday", planner.FridayMeals());
        weeklyMealPlan.Add("Saturday", planner.SaturdayMeals());
        weeklyMealPlan.Add("Sunday", planner.SundayMeals());

        return weeklyMealPlan;
    }
}

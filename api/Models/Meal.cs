namespace homefoodie_api.Models;

public class Meal
{
    private readonly MealPlanner _fromPlan;

    public Meal(MealPlanner fromPlan) => _fromPlan = fromPlan;

    public string MainCourse { get; set;}
    public string SideDish {get; set;}
    public string Dessert {get; set;}
    public string Drink {get; set;}
}
namespace homefoodie_api.Models;

public class MealPlanner
{
    private readonly int _dailyMealsToPlan = 0;

    public MealPlanner(int dailyMealsToPlan)
    {
        _dailyMealsToPlan = dailyMealsToPlan;
        ProposalOnly = true;
    }

    public DateTime From { get; set; }
    public DateTime Through { get; set; }

    public string Title { get; set; }

    public IEnumerable<Meal> MondayMeals()
    {
        return MakeMeals(_dailyMealsToPlan);        
    }

    public IEnumerable<Meal> TuesdayMeals()
    {
        return MakeMeals(_dailyMealsToPlan);        
    }
    
    public IEnumerable<Meal> WednesdayMeals()
    {
        return MakeMeals(_dailyMealsToPlan);        
    }

    public IEnumerable<Meal> ThursdayMeals()
    {
        return MakeMeals(_dailyMealsToPlan);        
    }

    public IEnumerable<Meal> FridayMeals()
    {
        return MakeMeals(_dailyMealsToPlan);        
    }

    public IEnumerable<Meal> SaturdayMeals()
    {
        return MakeMeals(_dailyMealsToPlan);        
    }

    public IEnumerable<Meal> SundayMeals()
    {
        return MakeMeals(_dailyMealsToPlan);        
    }

    public bool ProposalOnly {get; set;}

    private IEnumerable<Meal> MakeMeals(int mealCount)
    {
        for (int i = 0; i < mealCount; i++)
        {
            yield return new Meal(this)
            {
                MainCourse = $"Main-Course-{i}",
                SideDish = $"Side-Dish-{i}",
                Dessert = $"Dessert-{i}",
                Drink = $"some-drink-{i}"
            };
        }
    }
}

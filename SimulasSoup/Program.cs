(FoodType type, MainIngredient ingredient, SeasoningType seasoning) soup = MakeSoup();
Console.WriteLine($"{soup.seasoning} {soup.ingredient} {soup.type}");


(FoodType, MainIngredient, SeasoningType) MakeSoup()
{
    FoodType type = GetFoodType();
    MainIngredient ingredient = GetIngredient();
    SeasoningType seasoning = GetSeasoning();
    return(type, ingredient, seasoning);
}

FoodType GetFoodType()
{
    Console.Write("What soup type would you like (soup, stew or gumbo): ");
    string soupType = Console.ReadLine().ToLower();

    return soupType switch
    {
        "soup" => FoodType.Soup,
        "stew" => FoodType.Stew,
        "gumbo" => FoodType.Gumbo
    };
}

MainIngredient GetIngredient()
{
    Console.Write("What main ingredient would you like to use (mushrooms, chicken, carrots, or potatoes): ");
    string ingredient = Console.ReadLine().ToLower();

    return ingredient switch
    {
        "mushrooms" => MainIngredient.Mushroom,
        "chicken" => MainIngredient.Chicken,
        "carrots" => MainIngredient.Carrot,
        "potatoes" => MainIngredient.Potato
    };
}

SeasoningType GetSeasoning()
{
    Console.Write("What seasoning would you like to use (spicy, salty, or sweet): ");
    string seasoning = Console.ReadLine().ToLower();

    return seasoning switch
    {
        "spicy" => SeasoningType.Spicy,
        "salty" => SeasoningType.Salty,
        "sweet" => SeasoningType.Sweet
    };
}
enum FoodType { Soup, Stew, Gumbo }
enum MainIngredient { Mushroom, Chicken, Carrot, Potato }
enum SeasoningType { Spicy, Salty, Sweet }
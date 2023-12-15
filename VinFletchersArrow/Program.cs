Arrow arrow = GetArrow();
Console.WriteLine($"Your arrow costs {arrow.GetCost()} gold.");

Arrow GetArrow()
{
    Arrowhead arrowhead = GetArrowType();
    Fletching fletching = GetFletching();
    float length = GetLength();

    return new Arrow(arrowhead, fletching, length);
}

Arrowhead GetArrowType()
{
    Console.Write("What arrow type would you like to use, steel, wood, or obsidian? ");
    string arrowType = Console.ReadLine().ToLower();

    return arrowType switch
    {
        "steel" => Arrowhead.Steel,
        "wood" => Arrowhead.Wood,
        "obsidian" => Arrowhead.Obsidian
    };
}

Fletching GetFletching()
{
    Console.Write("Which fletching type would you like to use, platic, turkey feathers, or goose feathers? ");
    string fletchType = Console.ReadLine().ToLower();

    return fletchType switch
    {
        "plastic" => Fletching.Plastic,
        "turkey feathers" => Fletching.TurkeyFeathers,
        "goose feathers" => Fletching.GooseFeathers
    };
}

float GetLength()
{
    Console.Write("How long would you like your arrow, between 60 - 100 cm? ");
    float arrowLength = float.Parse(Console.ReadLine());

    return arrowLength;
}

class Arrow
{
    public Arrowhead _arrowType;
    public Fletching _fletchingType;
    public float _length;

    public Arrow(Arrowhead arrowType, Fletching fletchingType, float length)
    {
        _arrowType = arrowType;
        _fletchingType = fletchingType;
        _length = length;
    }

    public float GetCost()
    {
        float arrowHeadCost = _arrowType switch
        {
            Arrowhead.Steel => 10,
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5
        };

        float fletchingCost = _fletchingType switch
        {
            Fletching.Plastic => 10,
            Fletching.TurkeyFeathers => 5,
            Fletching.GooseFeathers => 3
        };

        float lengthCost = _length * .05f;

        return lengthCost + arrowHeadCost + fletchingCost;
    }

}


enum Arrowhead { Steel, Wood, Obsidian }
enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }
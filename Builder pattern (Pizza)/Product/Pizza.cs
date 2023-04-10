namespace Week10.Builder_pattern__Pizza_.Product;

/// <summary>
/// Represents a Pizza Product
/// </summary>
public class Pizza
{
    private bool _hasPepperoni;
    private bool _hasTomato;
    private bool _hasCheese;
    private bool _hasHam;
    private bool _hasMushroom;
    private bool _hasOnion;
    private bool _hasBacon; 
    private bool _hasOregano; 
    private bool _hasBeefMeat;
    private bool _hasRedPepper; 
    private bool _hasOlives;
    private bool _hasCorn;
    private bool _hasPineapple;
    private bool _hasChicken;
    private bool _hasChili;
    private bool _hasKebabMeat;

    public Pizza(bool hasPepperoni,
        bool hasTomato,
        bool hasCheese,
        bool hasHam,
        bool hasMushroom,
        bool hasOnion,
        bool hasBacon,
        bool hasOregano,
        bool hasBeefMeat,
        bool hasRedPepper,
        bool hasOlives,
        bool hasCorn,
        bool hasPineapple,
        bool hasChicken,
        bool hasChili,
        bool hasKebabMeat)
    {
        _hasPepperoni = hasPepperoni;
        _hasTomato = hasTomato;
        _hasCheese = hasCheese;
        _hasHam = hasHam;
        _hasMushroom = hasMushroom;
        _hasOnion = hasOnion;
        _hasBacon = hasBacon;
        _hasOregano = hasOregano;
        _hasBeefMeat = hasBeefMeat;
        _hasRedPepper = hasRedPepper;
        _hasOlives = hasOlives;
        _hasCorn = hasCorn;
        _hasPineapple = hasPineapple;
        _hasChicken = hasChicken;
        _hasChili = hasChili;
        _hasKebabMeat = hasKebabMeat;
    }

    public override string ToString()
    {
        return $"{nameof(_hasPepperoni)}: {_hasPepperoni}, {nameof(_hasTomato)}: {_hasTomato}, {nameof(_hasCheese)}: {_hasCheese}, {nameof(_hasHam)}: {_hasHam}, {nameof(_hasMushroom)}: {_hasMushroom}, {nameof(_hasOnion)}: {_hasOnion}, {nameof(_hasBacon)}: {_hasBacon}, {nameof(_hasOregano)}: {_hasOregano}, {nameof(_hasBeefMeat)}: {_hasBeefMeat}, {nameof(_hasRedPepper)}: {_hasRedPepper}, {nameof(_hasOlives)}: {_hasOlives}, {nameof(_hasCorn)}: {_hasCorn}, {nameof(_hasPineapple)}: {_hasPineapple}, {nameof(_hasChicken)}: {_hasChicken}, {nameof(_hasChili)}: {_hasChili}, {nameof(_hasKebabMeat)}: {_hasKebabMeat}";
    }
}
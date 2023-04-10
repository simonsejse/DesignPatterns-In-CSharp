
using Week10.Builder_pattern__Pizza_.Product;

namespace Week10.Builder_pattern__Pizza_.Builder;

/// <summary>
/// Represents a Concrete Builder for the Pizza product
/// </summary>
public class ConcretePizzaBuilder : IAbstractBuilder<Pizza>
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
    
    public IAbstractBuilder<Pizza> SetHasPepperoni(bool has)
    {
        _hasPepperoni = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasTomato(bool has)
    {
        _hasTomato = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasCheese(bool has)
    {
        _hasCheese = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasHam(bool has)
    {
        _hasHam = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasMushroom(bool has)
    {
        _hasMushroom = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasOnion(bool has)
    {
        _hasOnion = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasBacon(bool has)
    {
        _hasBacon = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasOregano(bool has)
    {
        _hasOregano = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasBeefMeat(bool has)
    {
        _hasBeefMeat = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasRedPepper(bool has)
    {
        _hasRedPepper = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasOlives(bool has)
    {
        _hasOlives = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasCorn(bool has)
    {
        _hasCorn = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasPineapple(bool has)
    {
        _hasPineapple = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasChicken(bool has)
    {
        _hasChicken = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasChili(bool has)
    {
        _hasChili = has;
        return this;
    }

    public IAbstractBuilder<Pizza> SetHasKebabMeat(bool has)
    {
        _hasKebabMeat = has;
        return this;
    }

    public Pizza GetResult()
    {
        return new Pizza(_hasPepperoni,
            _hasTomato,
            _hasCheese,
            _hasHam,
            _hasMushroom,
            _hasOnion,
            _hasBacon,
            _hasOregano,
            _hasBeefMeat,
            _hasRedPepper,
            _hasOlives,
            _hasCorn,
            _hasPineapple,
            _hasChicken,
            _hasChili,
            _hasKebabMeat);
    }
}
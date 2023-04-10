using Week10.Builder_pattern__Pizza_.Builder;
using Week10.Builder_pattern__Pizza_.Product;

namespace Week10.Builder_pattern__Pizza_.Director;

public class PizzaDirector
{
    public Pizza ConstructMargarita(IAbstractBuilder<Pizza> pizza)
    {
        return pizza.SetHasTomato(true)
            .SetHasCheese(true)
            .SetHasOregano(true)
            .GetResult();
    }
    
    public Pizza ConstructCapricaso(IAbstractBuilder<Pizza> pizza)
    {
        return pizza
            .SetHasTomato(true)
            .SetHasCheese(true)
            .SetHasHam(true)
            .SetHasMushroom(true)
            .SetHasOnion(true)
            .SetHasOregano(true)
            .GetResult();
    } 
    
    public Pizza ConstructVeviso(IAbstractBuilder<Pizza> pizza)
    {
        return pizza
            .SetHasTomato(true)
            .SetHasCheese(true)
            .SetHasHam(true)
            .SetHasOnion(true)
            .SetHasBacon(true)
            .SetHasOregano(true)
            .GetResult();
    }
    
    public Pizza ConstructAmalfi(IAbstractBuilder<Pizza> pizza)
    {
        return pizza
            .SetHasTomato(true)
            .SetHasCheese(true)
            .SetHasBeefMeat(true)
            .SetHasMushroom(true)
            .SetHasOnion(true)
            .SetHasBacon(true)
            .SetHasOregano(true)
            .GetResult();
    }
    
    public Pizza ConstructNewYork(IAbstractBuilder<Pizza> pizza)
    {
        return pizza
            .SetHasTomato(true)
            .SetHasCheese(true)
            .SetHasHam(true)
            .SetHasBacon(true)
            .SetHasBeefMeat(true)
            .SetHasOregano(true)
            .GetResult();
    }
    
    public Pizza ConstructVegetar(IAbstractBuilder<Pizza> pizza)
    {
        return pizza
            .SetHasTomato(true)
            .SetHasCheese(true)
            .SetHasMushroom(true)
            .SetHasOnion(true)
            .SetHasRedPepper(true)
            .SetHasOlives(true)
            .SetHasCorn(true)
            .SetHasOregano(true)
            .GetResult();
    }
    
    public Pizza ConstructRomagnola(IAbstractBuilder<Pizza> pizza)
    {
        return pizza
            .SetHasTomato(true)
            .SetHasCheese(true)
            .SetHasMushroom(true)
            .SetHasHam(true)
            .SetHasPineapple(true)
            .SetHasOnion(true)
            .SetHasRedPepper(true)
            .SetHasOlives(true)
            .GetResult();
    }
    public Pizza ConstructAdamsSpecial(IAbstractBuilder<Pizza> pizza)
    {
        return pizza
            .SetHasTomato(true)
            .SetHasPepperoni(true)
            .SetHasCheese(true)
            .SetHasKebabMeat(true)
            .SetHasChicken(true)
            .SetHasChili(true)
            .SetHasOnion(true)
            .SetHasOregano(true)
            .GetResult();
    }
}
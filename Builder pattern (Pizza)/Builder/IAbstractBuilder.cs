
namespace Week10.Builder_pattern__Pizza_.Builder;


/// <summary>
/// Represents the Abstract Builder for a Pizza Product
/// Multiple concrete builders can inherit from this
/// </summary>
/// <typeparam name="T">Represents the Product type</typeparam>
public interface IAbstractBuilder<out T>
{
    IAbstractBuilder<T> SetHasPepperoni(bool has);
    IAbstractBuilder<T> SetHasTomato(bool has);
    IAbstractBuilder<T> SetHasCheese(bool has);
    IAbstractBuilder<T> SetHasHam(bool has);
    IAbstractBuilder<T> SetHasMushroom(bool has);
    IAbstractBuilder<T> SetHasOnion(bool has);
    IAbstractBuilder<T> SetHasBacon(bool has);
    IAbstractBuilder<T> SetHasOregano(bool has);
    IAbstractBuilder<T> SetHasBeefMeat(bool has);
    IAbstractBuilder<T> SetHasRedPepper(bool has);
    IAbstractBuilder<T> SetHasOlives(bool has);
    IAbstractBuilder<T> SetHasCorn(bool has);
    IAbstractBuilder<T> SetHasPineapple(bool has);
    IAbstractBuilder<T> SetHasChicken(bool has);
    IAbstractBuilder<T> SetHasChili(bool has);
    IAbstractBuilder<T> SetHasKebabMeat(bool has);
    T GetResult();
}
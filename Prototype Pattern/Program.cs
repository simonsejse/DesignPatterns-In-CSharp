namespace Week10.Prototype_Pattern;

public class Program : ITestPattern
{
    public string Name() => "Prototype pattern";

    public void Run()
    {
        ShapeCacheRegistry shapeCacheRegistry = new();
        var shape1 = shapeCacheRegistry["Medium blue rectangle"];
        var shape2 = shapeCacheRegistry["Big green circle"];
        var shape3 = shapeCacheRegistry["Big green circle"];
        
        if (shape1 != null && shape1 != shape2 && !shape1.Equals(shape2)) {
            Console.WriteLine("(good) Big green circle is not the same as Medium blue rectangle!");
        } else {
            Console.WriteLine("(bad) Big green circle is the same as Medium blue reactangle!");
        }

        if (shape2 != shape3) {
            Console.WriteLine("(good) Medium blue rectangles are two different objects of same class!");
            if (shape2 != null && shape2.Equals(shape3)) {
                Console.WriteLine("(good) they are identical!");
            } else {
                Console.WriteLine("(bad) they are NOT identical!");
            }
        } else {
            Console.WriteLine("(bad) They share the same memory address on the heap, meaning they are the same object..");
        }
    }
}
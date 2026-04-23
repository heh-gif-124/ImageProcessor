ImageProcessor myimagejohndoe = new ImageProcessor();

myimagejohndoe.resize(5);
myimagejohndoe.resize(150);
myimagejohndoe.resize(450,550);
myimagejohndoe.resize("A5");
class ImageProcessor
{
    public void resize(int size)
    {
        if (size <= 0)
        {
            Console.WriteLine("THATS TOO SMALL");
        }
        else if (size > 100)
        {
            Console.WriteLine($"SIZE (ENLARGED) CHANGED TO: {size}%");
        }
        else if (size < 100)
        {
            Console.WriteLine($"SIZE (SHRINKED) CHANGED TO: {size}%");
        }
        else
        {
            Console.WriteLine("NOTHING CHANGED");
        }
    }
    public void resize(int width, int height)
    {
        Console.WriteLine($"SIZE CHANGED TO {width} {height}");
    }
    public void resize(string PaperSize)
    {
        Console.WriteLine($"SIZE ADJUSTED TO {PaperSize}");
    }
}
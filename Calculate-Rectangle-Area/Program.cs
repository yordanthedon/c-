int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

Console.WriteLine(RectangleArea(width, length));

static int RectangleArea(int w, int l)
{
    return w * l;
}
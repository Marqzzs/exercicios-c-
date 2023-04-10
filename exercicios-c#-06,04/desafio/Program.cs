// int x = 0;
// int y = 1;
// int res;

// for (int i = 0; i < 500; i++)
// {
//     res = x;
//     x = y;
//     y = x + res;

//     Console.WriteLine($"{y}");


//     if (y > 500)
//     {
//         break;
//     }
// }

int a = 0;
int b = 1;
int c = 0;

Console.Write("{0} {1}", a, b);

while (c < 500)
{
    c = a + b;
    Console.Write(" {0}", c);
    a = b;
    b = c;
}

Console.ReadKey();
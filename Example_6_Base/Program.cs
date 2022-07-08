int a = 4;
int b = 20;
int c = 1;
int d = 5;
int e = 6;

int max = a;

if ( a > max ) max = a;
if ( b > max ) max = b;
if ( c > max ) max = c;
if ( d > max ) max = d;
if ( e > max ) max = e;

Console.Write("max=");
Console.WriteLine(max);
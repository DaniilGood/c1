int Max( int arg1, int arg2, int arg3)
{
    int resalt= arg1;
    if(arg2> resalt) resalt=arg2;
    if(arg3> resalt) resalt =arg3;
    return resalt;
}

int a1 = 48;
int b1 = 93;
int c1 = 80;
int a2 = 4933;
int b2 = 454;
int c2 = 9;
int a3 = 5;
int b3 = 44;
int c3 = 30;

int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);
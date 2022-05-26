using System;
using static System.Console;

Clear();

int M = AskNumber("M");
int N = AskNumber("N");
WriteLine($"M = {M}; N = {N} -> A(m,n) = {Akerman(M, N)}");

static int Akerman(int n, int m) {
    if (n==0)
        return m+1;
    else
        if ((n!=0)&&(m==0))
            return Akerman(n-1,1);
        else
            return Akerman(n-1,Akerman(n,m-1));
}

static int AskNumber(string name) {
    Write($"Введите число {name}: ");
    return int.Parse(ReadLine());
}


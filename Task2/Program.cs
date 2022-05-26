using System;
using static System.Console;

Clear();

int M = AskNumber("M");
int N = AskNumber("N");
WriteLine($"M = {M}; N = {N} -> {PrintSum(M, N)}");

static int PrintSum(int M, int N) {
    if(M > N) {
        return 0;
    }
    return M + PrintSum(M + 1, N);
}

static int AskNumber(string name) {
    Write($"Введите число {name}: ");
    return int.Parse(ReadLine());
}


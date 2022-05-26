using System;
using static System.Console;

Clear();

int M = AskNumber("M");
int N = AskNumber("N");
WriteLine($"M = {M}; N = {N}. -> \"{PrintRange(M, N)}\"");

static string PrintRange(int M, int N) {
    if(N < M) {
        return "";
    }
    string part = N == M ? $"{N}" : $"{N}, ";
    return part + PrintRange(M, N - 1);
}

static int AskNumber(string name) {
    Write($"Введите число {name}: ");
    return int.Parse(ReadLine());
}

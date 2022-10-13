// Task03.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
/*
3. Дан целочисленный массив, состоящий из N элементов (N > 0).
Если в наборе имеются отрицательные четные числа, 
то найти сумму всех положительных нечетных чисел,
иначе вычислить сумму всех чисел, которые кратные числу 3.
*/

#include <iostream>
char* InputFileString(const char FileName[25], int NumString);
void OutputFileString(const char FileName[25], const char Text[256]);
bool IsPositive(int Mass[], int N);

int main()
{
    char sResult[256];
    char* pvsResult = &sResult[0];
    const int N = 1024;
    int Mass[N];
    int Result = 0;
    for (int i = 0; i < N; i++)
    {
        Mass[i] = atoi(InputFileString("Input.txt", i));
    }
    if (IsPositive(Mass, N))
    {
        for (int i = 0; i < N; i++)
        {
            if (Mass[i] % 3 == 0)
                Result += Mass[i];
        }
    }
    else
    {
        for (int i = 0; i < N; i++)
        {
            if (Mass[i] > 0 && Mass[i] % 2 == 1)
                Result += Mass[i];
        }
    }
    _itoa_s(Result, pvsResult, 256, 10);
    OutputFileString("Output.txt", sResult);
}
bool IsPositive(int Mass[], int N)
{
    for (int i = 0; i < N; i++)
    {
        if (Mass[i] < 0)
            return false;
    }
    return true;
}
char* InputFileString(const char FileName[25], int NumString)
{
    FILE* pInput;
    char String[256];
    char* pvStr = &String[0];
    int k;
    char end[3] = "\0";
    fopen_s(&pInput, FileName, "r");
    if (pInput == NULL)
    {
        printf("\nOpen-1 error !");
        return 0;
    }
    for (; NumString > 0; NumString--)
        if (fscanf_s(pInput, "%s", String, 256) == EOF)
        {
            NumString = 0;
            pvStr = &end[0];
        }
    fclose(pInput);
    return pvStr;
}

void OutputFileString(const char FileName[25], const char Text[256])
{
    FILE* pOutput;
    int k;
    fopen_s(&pOutput, "Output.txt", "w");
    if (pOutput == NULL)
    {
        printf("\nOpen-2 error !");
        scanf_s("%d", &k);
        return;
    }
    fprintf_s(pOutput, "%s\n", Text);
    fclose(pOutput);
}
// Запуск программы: CTRL+F5 или меню "Отладка" > "Запуск без отладки"
// Отладка программы: F5 или меню "Отладка" > "Запустить отладку"

// Советы по началу работы 
//   1. В окне обозревателя решений можно добавлять файлы и управлять ими.
//   2. В окне Team Explorer можно подключиться к системе управления версиями.
//   3. В окне "Выходные данные" можно просматривать выходные данные сборки и другие сообщения.
//   4. В окне "Список ошибок" можно просматривать ошибки.
//   5. Последовательно выберите пункты меню "Проект" > "Добавить новый элемент", чтобы создать файлы кода, или "Проект" > "Добавить существующий элемент", чтобы добавить в проект существующие файлы кода.
//   6. Чтобы снова открыть этот проект позже, выберите пункты меню "Файл" > "Открыть" > "Проект" и выберите SLN-файл.

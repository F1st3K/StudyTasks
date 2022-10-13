// Task04.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
/*
4. Написать функцию int MulRange(A, B) целого типа,
находящую произведение всех целых чисел от A до B включительно (A и B — целые положительные). 
Если A > B, то функция должна возвращать число 0.
*/

#include <iostream>

char* InputFileString(const char FileName[25], int NumString);
void OutputFileString(const char FileName[25], const char Text[256]);
int MulRange(int A, int B);

int main()
{
    int A, B;
    int Result;
    char sResult[256];
    char* pvsResult = &sResult[0];
    A = atoi(InputFileString("Input.txt", 1));
    B = atoi(InputFileString("Input.txt", 2));
    Result = MulRange(A, B);
    if (Result == -1.0)
    {
        printf("\n!!incorrect input!!!");
        printf("\n------------------------------------------------------------------------------------\n");
        return 0;
    }
    _itoa_s(Result, pvsResult, 256, 10);
    OutputFileString("Output.txt", sResult);
}
char* InputFileString(const char FileName[25], int NumString)
{
    FILE* pInput;
    char String[256];
    char* pvStr = &String[0];
    int k;
    fopen_s(&pInput, FileName, "r");
    if (pInput == NULL)
    {
        printf("\nOpen-1 error !");
        scanf_s("%d", &k);
        return 0;
    }
    for (; NumString > 0; NumString--)
        fscanf_s(pInput, "%s", String, 256);
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
int MulRange(int A, int B)
{
    if (A < 0 || B < 0)
        return -1;
    int Result = 1;
    for (int i = A; i <= B; i++)
    {
        Result *= i;
    }
    if (Result == 1 || A>B)
        Result = 0;
    return Result;
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

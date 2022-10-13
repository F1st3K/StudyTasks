// pr07.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
/*ВАРИАНТ № А42 / Б9
1. Проверить истинность высказывания : "Сумма двух первых цифр данного 
целого положительного четырехзначного числа равна сумме двух его последних цифр".
*/
#include <iostream>
bool FourDigitNumberCheck(int N);
char* InputFileString(const char FileName[25], int NumString);
void OutputFileString(const char FileName[25], const char Text[256]);

int main()
{
    bool Result = false;
    int N;
    
    N = atoi(InputFileString("Input.txt", 1));
    if (!(1000 <= N && N < 10000))
    {
        printf("!!!warning");
        printf("\n------------------------------------------\n");
        return 0;
    }

    Result = FourDigitNumberCheck(N);
    if (Result)
        OutputFileString("Output.txt", "True");
    else
        OutputFileString("Output.txt", "False");
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
    for (;NumString>0;NumString--)
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
bool FourDigitNumberCheck(int N)
{
    int s1 = 0;
    int s2 = 0;
    bool Result = false;
    for (int i = N; i >= 1; i /= 10)
    {
        if (i == N)
        {
            s1 = (i % 10) + ((i / 10) % 10);
        }
        else if (i / 100 >= 1)
        {
            s2 = ((i / 100) % 10) + ((i / 10) % 10);
        }
    }
    if (s1 == s2)
        Result = true;
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

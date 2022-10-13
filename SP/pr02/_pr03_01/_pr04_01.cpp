/*
������� � �22/�9

1. ���� ������������ ����� A � ����� ����� N (N > 0).
������� �������� ���������� A � ������� N: AN = A*A*...*A (����� A ������������� N ���).

2. ���� ��� ����� �����: A, B, C. ��������� ���������� ������������: ����� �� ���� �� ����� A, B, C �������������.

3. ���� ����� M (� - ����� ������������� �����) � �����������.
��������� �������� ������� ������, ����� ���������� ������ ���� � ��� (1 ����� = 1000 ��).

4. ��������� ���������� ������������: "��� ����� ������� ������ �������������� ������������ ����� ���������� � ���������� ��������".

5. �������������� �������� ��� ������� ������������� ��������� �������: 1 - ��������, 2 - ���������, 3 - ���������, 4 - �������.
��� ����� �������� N (����� ����� � ��������� �� 1 �� 4) � ������������ ����� A � B (B �� ����� 0).
��������� ��� ������� ��������� �������� � ������� ���������.
*/

#include "stdafx.h"



void Task01()
{
    double A;
    double resA;
    int N;
    printf("enter A: ");
    scanf_s("%lf", &A);
    printf("enter B: ");
    scanf_s("%d", &N);
    resA = A;
    for (; N > 1; N -= 1)
    {
        resA *= A;
    }
    printf("%f\n", resA);
}
void Task02()
{
    int A;
    int B;
    int C;
    bool IsPositiveNumber = false;
    printf("enter A: ");
    scanf_s("%d", &A);
    printf("enter B: ");
    scanf_s("%d", &B);
    printf("enter C: ");
    scanf_s("%d", &C);
    if (A > 0 || B > 0 || C > 0)
    {
        IsPositiveNumber = true;
        printf("true\n");
        return;
    }
    printf("false\n");
}
void Task03()
{
    int M;
    int Tons;
    printf("enter mass: ");
    scanf_s("%d", &M);
    Tons = M / 1000;
    printf("%d\n", Tons);
}
void Task04()
{
    int Number;
    printf("enter number: ");
    scanf_s("%d", &Number);
    if (Number >= 1000)
    {
        printf("!!!");
        Task04();
        return;
    }
    for (int i = Number; i >= 1; i /= 10)
    {
        for (int j = Number; j >= 1; j /= 10)
        {
            if ((i % 10 == j % 10) && (i != j))
            {
                printf("%d:%d\n", i % 10, j % 10);
                return;
            }
        }
    }
    printf("good\n");
}
void Task05()
{
    int A;
    int Action;
    int B;
    int Result = 0;
    printf("enter A: ");
    scanf_s("%d", &A);
    printf("enter Action: ");
    scanf_s("%d", &Action);
    printf("enter B: ");
    scanf_s("%d", &B);
    switch (Action)
    {
    case 1: 
    {
        Result = A + B;
    }
        break;
    case 2:
    {
        Result = A - B;
    }
        break;
    case 3:
    {
        Result = A * B;
    }
    break;
    case 4:
    {
        if (B != 0)
            Result = A / B;
    }
    break;
    default:
        break;
    }
    printf("%d\n", Result);
}

int _tmain(int argc, _TCHAR* argv[])
{

    //Task01();
    //Task02();
    //Task03();
    //Task04();
    Task05();
	return 0;
}

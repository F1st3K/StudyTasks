// pr04.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

// pr04.cpp : ���� ���� �������� ������� "main". ����� ���������� � ������������� ���������� ���������.
//
/*������� � �22/�9
1. ���� ��� ����� �����: A, B, C. ��������� ���������� ������������: ����� �� ���� �� ����� A, B, C �������������.

2. ���� ��� ����� �����: A, B, C. ��������� ���������� ������������: ������ B ��������� ����� ������� A � C�.

3. �������� ������, ���������� ����� � �����. ����� ������ ����� ���� ������.
������� ����� � ������������ ���� ���� ��������� ������.
����� �������� �������������� ������������ ��� ������������,
��������� ��� ��������� � ������� ������������ ���������� � �������� ��� ��� ������������ �����.

4. ��� ������������� ������, ��������� �� N ��������� (N > 0).
���������, ���������� �� � ��� ������ � �������� �����.
���� ����������, �� ������� 0, ���� ���, �� ������� ���������� ����� ������� ��������, ����������� ��������������.

5. ��� ������������� ������, ��������� �� N ��������� (N > 0).
���� � ������ ������� ������ ������������� ������ �����, �� ������� True; � ��������� ������ ������� False.*/
#include <iostream>

void Task01()
{
	printf("\nTask01------------------------------------\n");
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
		printf("true");
		return;
	}
	printf("false");
	printf("\n------------------------------------------\n");
}
void Task02()
{
	printf("\nTask02------------------------------------\n");
	int A;
	int B;
	int C;
	bool BIsMedium = false;
	printf("enter A: ");
	scanf_s("%d", &A);
	printf("enter B: ");
	scanf_s("%d", &B);
	printf("enter C: ");
	scanf_s("%d", &C);
	if ((A < B)&(B < C) || (A > B)&(B > C))
	{
		BIsMedium = true;
		printf("true");
		return;
	}
	printf("false");
	printf("\n------------------------------------------\n");
}
void Task03()
{
	printf("\nTask03------------------------------------\n");
	double MulAllNumber = 1.0;
	int AddAllNumber = 0;
	char str[200];
	printf("enter string:  ");
	scanf_s("%s", str, sizeof(str));

	for (int i = 0; str[i] != '\0'; i++)
	{
		if (isdigit(str[i]))
		{
			MulAllNumber *= (str[i] - 48);
			AddAllNumber += (str[i] - 48);
		}
	}
	printf(" Mul: %f", MulAllNumber);
	printf(" Add: %d", AddAllNumber);
	printf("\n------------------------------------------\n");
}
void Task04()
{
	printf("\nTask04------------------------------------\n");
	int N;
	printf("enter size mass: ");
	scanf_s("%d", &N);
	if (N <= 0)
	{
		printf("!!!\n");
		Task04();
		return;
	}
	int mass[200];
	for (int i = 0; i < N; i++)
	{
		printf("enter %d element:  ", i+1);
		scanf_s("%d", &mass[i]);
	}
	int RotationNumber;
	if (((mass[0]) % 2) == 0)
		RotationNumber = 1;
	else
		RotationNumber = 0;
	for (int i = 1; i < N; i++)
	{
		if ((mass[i] + RotationNumber) % 2 != 0)
		{
			printf("%d", i+1);
			return;
		}
		RotationNumber = RotationNumber == 1 ? 0 : 1;
	}
	printf("%d", 0);
	printf("\n------------------------------------------\n");
}
void Task05()
{
	printf("\nTask05------------------------------------\n");
	int N;
	printf("enter size mass: ");
	scanf_s("%d", &N);
	if (N <= 0)
	{
		printf("!!!\n");
		Task05();
		return;
	}
	int mass[200];
	for (int i = 0; i < N; i++)
	{
		printf("enter %d element:  ", i + 1);
		scanf_s("%d", &mass[i]);
	}
	for (int i = 0; i < N; i++)
	{
		if (!(mass[i] > 0 && mass[i] % 2 == 0))
		{
			printf("false");
			printf("\n------------------------------------------\n");
			return;
		}
	}
	printf("True");
	printf("\n------------------------------------------\n");
}

int main()
{
	Task01();
	Task02();
	Task03();
	Task04();
	Task05();
}
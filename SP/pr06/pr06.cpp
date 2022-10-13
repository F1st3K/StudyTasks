// pr06.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
/*ВАРИАНТ № А27/Б9
1. Из пяти введенных целых положительных чисел найти два наибольших и вывести сумму этих двух наибольших чисел.
2. Ввести пять ненулевых целых чисел. Найти произведение двух наименьших чисел.
3. Дан целочисленный массив, состоящий из N элементов (N > 0). Найти сумму и произведение всех чисел из данного массива.
4. Написать функцию double TriangleP(a, h), находящую периметр равнобедренного треугольника по его основанию a и высоте h,
проведенной к основанию (a и h — вещественные). Для нахождения боковой стороны b треугольника использовать теорему Пифагора: b2 = (a/2)2 + h2.
5. Вводится строка, состоящая из цифр и символов английского алфавита. Длина строки может быть разной.
Вывести на экран произведение всех нечетных цифр этого числа.*/
#include <iostream>

void Menu();

void Task01();
int FindLargestValue(int mass[5], int exept);
void Task02();
int FindSmallerValue(int mass[5], int exept);
void Task03();
int SumAllNumbers(int mass[1024], int N);
double MulAllNumbers(int mass[1024], int N);
void Task04();
double TriangleP(double a, double h);
void Task05();
double MulOddNumberInString(char str[1024]);

int main()
{
	Menu();
}

void Menu()
{
	int Choice = 0;
	printf("\n+------------------------+");
	printf("\n|       0 - exit         |");
	printf("\n|       1 - Task01       |");
	printf("\n|       2 - Task02       |");
	printf("\n|       3 - Task03       |");
	printf("\n|       4 - Task04       |");
	printf("\n|       5 - Task05       |");
	printf("\n+------------------------+\n: ");
	scanf_s("%d", &Choice);
	switch (Choice)
	{
	case 0:
		break;
	case 1:
	{
		Task01();
		Menu();
	}
	break;
	case 2:
	{
		Task02();
		Menu();
	}
	break;
	case 3:
	{
		Task03();
		Menu();
	}
	break;
	case 4:
	{
		Task04();
		Menu();
	}
	break;
	case 5:
	{
		Task05();
		Menu();
	}
	break;
	default:
	{
		printf("\nError!\n");
		Menu();
	}
	break;
	}
	return;
}

void Task01()
{
	printf("\nTask01------------------------------------------------------------------------------\n");
	int mass[5];
	int Result;
	for (int i = 0; i < 5; i++)
	{
		printf("\nEnter %d element: ", i+1);
		scanf_s("%d", &mass[i]);
	}
	Result = FindLargestValue(mass, INT_MAX);
	if (Result == -1)
	{
		printf("\n!!incorrect input!!!");
		printf("\n------------------------------------------------------------------------------------\n");
		Task01();
		return;
	}
	Result += FindLargestValue(mass, FindLargestValue(mass, INT_MAX));
	printf("\nResult: %d", Result);
	printf("\n------------------------------------------------------------------------------------\n");
}
int FindLargestValue(int mass[5], int exept)
{
	int Result = 0;
	for (int i = 0; i < 5; i++)
	{
		if (mass[i] < 0)
			return -1;
		if (Result < mass[i] && mass[i] != exept)
			Result = mass[i];
	}
	return Result;
}

void Task02()
{
	printf("\nTask02------------------------------------------------------------------------------\n");
	int mass[5];
	int Result;
	for (int i = 0; i < 5; i++)
	{
		printf("\nEnter %d element: ", i + 1);
		scanf_s("%d", &mass[i]);
	}
	Result = FindSmallerValue(mass, INT_MAX);
	if (Result == 0)
	{
		printf("\n!!incorrect input!!!");
		printf("\n------------------------------------------------------------------------------------\n");
		Task02();
		return;
	}
	Result *= FindSmallerValue(mass, FindSmallerValue(mass, INT_MAX));
	printf("\nResult: %d", Result);
	printf("\n------------------------------------------------------------------------------------\n");
}

int FindSmallerValue(int mass[5], int exept)
{
	int Result = INT_MAX;
	for (int i = 0; i < 5; i++)
	{
		if (mass[i] == 0)
			return 0;
		if (Result > mass[i] && mass[i] != exept)
			Result = mass[i];
	}
	return Result;
}
void Task03()
{
	printf("\nTask03------------------------------------------------------------------------------\n");
	int mass[1024];
	int N;
	int ResultSum;
	double ResultMul;
	printf("\nEnter num mass: ");
	scanf_s("%d", &N);
	if (N <= 0)
	{
		printf("\n!!incorrect input!!!");
		printf("\n------------------------------------------------------------------------------------\n");
		Task03();
		return;
	}
	for (int i = 0; i < N; i++)
	{
		printf("\nEnter %d elment: ", i + 1);
		scanf_s("%d", &mass[i]);
	}
	ResultSum = SumAllNumbers(mass, N);
	ResultMul = MulAllNumbers(mass, N);
	printf("\nResult Sum: %d, Mul: %lf", ResultSum, ResultMul);
	printf("\n------------------------------------------------------------------------------------\n");
}
int SumAllNumbers(int mass[1024], int N)
{
	int Result = 0;
	for (int i = 0; i < N; i++)
	{
		Result += mass[i];
	}
	return Result;
}
double MulAllNumbers(int mass[1024], int N)
{
	int Result = 1;
	for (int i = 0; i < N; i++)
	{
		Result *= mass[i];
	}
	return Result;
}
void Task04()
{
	printf("\nTask04------------------------------------------------------------------------------\n");
	double A, H;
	double Result = 0;
	printf("\nEnter A: ");
	scanf_s("%lf", &A);
	printf("\nEnter H: ");
	scanf_s("%lf", &H);
	Result = TriangleP(A, H);
	if (Result == -1)
	{
		printf("\n!!incorrect input!!!");
		printf("\n------------------------------------------------------------------------------------\n");
		Task04();
		return;
	}
	printf("\nResult: %lf", Result);
	printf("\n------------------------------------------------------------------------------------\n");
}
double TriangleP(double a, double h)
{
	double b, Result;
	if (a <= 0 || h <= 0)
		return -1;
	b = sqrt((a / 2)*(a / 2) + h*h);
	Result = 2 * b + a;
	return Result;

}
void Task05()
{
	printf("\nTask05------------------------------------------------------------------------------\n");
	int Result = 0;
	char str[1024];
	printf("input string: ");
	scanf_s("%s", str, sizeof(str));
	Result = MulOddNumberInString(str);
	printf("\nResult: %d", Result);
	printf("\n------------------------------------------------------------------------------------\n");
}
double MulOddNumberInString(char str[1024])
{
	double Result = 1.0;
	for (int i = 0; str[i] != '\0'; i++)
	{
		if (isdigit(str[i]) && (str[i]-48) % 2 == 1)
			Result *= (str[i] - 48);
	}
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

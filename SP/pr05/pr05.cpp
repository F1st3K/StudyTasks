// pr05.cpp : Этот файл содержит функцию "main". Здесь начинается и заканчивается выполнение программы.
/*ВАРИАНТ № А22/Б9
* 
1. Даны два целых положительных числа A и B (число A меньше числа B). 
Найти произведение всех четных чисел расположенных между этими числами A и B.

2. Дан целочисленный массив, состоящий из N элементов (N > 0), содержащий, по крайней мере, два нуля. 
Вычислить сумму чисел из данного набора, расположенных между этими двумя нулями. Если нули идут подряд, то вывести 0. 
Если в массиве имеется только одно значение 0, то вычислить сумму всех его элементов.

3. Вводится строка, изображающая целочисленное арифметическое выражение вида «цифра_цифра_цифра_цифра», 
где на месте знака операции «_» находится символ «+» или «-», а на месте "цифра" находится одна из цифр (от 1 до 9). 
Например, «4+7-2+5». Вывести значение данного выражения (как целое число).

4. Написать функцию int Calc(A, B, Op) целого типа, 
выполняющую над ненулевыми целыми числами A и B одну из арифметических операций и возвращающую ее результат.
Вид операции определяется целым параметром Op: 1 — вычитание, 2 — умножение, 3 — деление, 4 — сложение.

5. Написать функцию int DigitN(K, N) целого типа, 
возвращающую N-ю цифру целого положительного числа K (цифры в числе нумеруются справа налево).
Если количество цифр в числе K меньше N, то функция должна возвращать значение -1.*/

#include <iostream>

void Menu();

void Task01();
double ProductBetweenNumbers(int A, int B);
void Task02();
int SumBetweenZeros(int mass[1024], int N);
void Task03();
double DigitCalculator(char str[1024]);
void Task04();
int Calc(int A, int B, int Op);
void Task05();
int DigitN(int K, int N);

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
	int A, B;
	double Result;
	printf("\nEnter A: ");
	scanf_s("%d", &A);
	printf("\nEnter B: ");
	scanf_s("%d", &B);
	Result = ProductBetweenNumbers(A, B);
	if (Result == -1.0)
	{
		printf("\n!!incorrect input!!!");
		printf("\n------------------------------------------------------------------------------------\n");
		Task01();
		return;
	}
	printf("\nResult: %lf", Result);
	printf("\n------------------------------------------------------------------------------------\n");
}
double ProductBetweenNumbers(int A, int B)
{
	if ((A >= B) || (A < 0 || B < 0))
		return -1.0;
	double Result = 1;
	for (int i = A; i < B; i++)
	{
		if (i % 2 == 0)
			Result *= i;
	}
	if (Result == 1)
		Result = 0;
	return Result;
}

void Task02()
{
	printf("\nTask02------------------------------------------------------------------------------\n");
	int mass[1024];
	int N;
	int CheckNull = 0;
	int* pmass;
	int Result;
	printf("\nEnter num mass: ");
	scanf_s("%d", &N);
	if (N <= 0)
	{
		printf("\n!!incorrect input!!!");
		printf("\n------------------------------------------------------------------------------------\n");
		Task02();
		return;
	}
	for (int i = 0; i < N; i++)
	{
		printf("\nEnter %d elment: ", i + 1);
		scanf_s("%d", &mass[i]);
	}
	pmass = mass;
	Result = SumBetweenZeros(pmass, N);
	printf("\nResult: %d", Result);
	printf("\n------------------------------------------------------------------------------------\n");
}
int SumBetweenZeros(int mass[1024], int N)
{
	int Result = 0;
	int CheckZerors = 0;
	for (int i = 0; i < N; i++)
	{
		if (mass[i] == 0)
			CheckZerors++;
		if (CheckZerors == 1)
		{
			Result += mass[i];
		}
	}
	if (CheckZerors < 2)
	{
		Result = 0;
		for (int i = 0; i < N; i++)
		{
			Result += mass[i];
		}
	}
	return Result;
}

void Task03()
{
	printf("\nTask03------------------------------------------------------------------------------\n");
	char str[1024];
	char* pstr;;
	double Result;
	printf("\nEnter String: ");
	scanf_s("%s", str, 1024);
	pstr = str;
	Result = DigitCalculator(pstr);
	if (Result == 0.1)
	{
		printf("\n!!incorrect input!!!");
		printf("\n------------------------------------------------------------------------------------\n");
		Task03();
		return;
	}
	printf("\nResult: %lf", Result);
	printf("\n------------------------------------------------------------------------------------\n");
}
double DigitCalculator(char str[1024])
{
	double Result = 0;
	int Action = 1;
	for (int i = 0; str[i] != '\0'; i++)
	{
		if ((i % 2 == 0) && !(isdigit(str[i])) || ((i % 2 == 1) && (str[i] != '+' && str[i] != '-')))
		{
			return 0.1;
		}
	}
	for (int i = 0; str[i] != '\0'; i++)
	{
		if (i % 2 == 0)
		{
			if (Action == 1)
				Result += (str[i] - 48);
			else if (Action == 2)
				Result -= (str[i] - 48);
		}
		else if (i % 2 == 1)
		{
			if (str[i] == '+')
				Action = 1;
			else if (str[i] == '-')
				Action = 2;
		}
	}
	return Result;
}
void Task04()
{
	printf("\nTask04------------------------------------------------------------------------------\n");
	int A, B, Op;
	int Result;
	printf("\nEnter A: ");
	scanf_s("%d", &A);
	printf("\nEnter Action: ");
	scanf_s("%d", &Op);
	printf("\nEnter B: ");
	scanf_s("%d", &B);
	Result = Calc(A, B, Op);
	if (A == 0 || B == 0)
	{
		printf("\n!!incorrect input!!!");
		printf("\n------------------------------------------------------------------------------------\n");
		Task04();
		return;
	}
	printf("\nResult: %d", Result);
	printf("\n------------------------------------------------------------------------------------\n");
}
int Calc(int A, int B, int Op)
{
	int Result = 0;
	if (A == 0 || B == 0)
		return Result;
	switch (Op)
	{
	case 1:
		Result = A - B;
		break;
	case 2:
		Result = A * B;
		break;
	case 3:
		Result = A / B;
		break;
	case 4:
		Result = A + B;
		break;
	default:
		break;
	}
	return Result;
}
void Task05()
{
	printf("\nTask05------------------------------------------------------------------------------\n");
	int K, N;
	int Result;
	printf("\nEnter K: ");
	scanf_s("%d", &K);
	printf("\nEnter N: ");
	scanf_s("%d", &N);
	Result = DigitN(K, N);
	if (Result == -1)
	{
		printf("\n!!incorrect input!!!");
		printf("\n------------------------------------------------------------------------------------\n");
		Task05();
		return;
	}
	printf("\nResult: %d", Result);
	printf("\n------------------------------------------------------------------------------------\n");
}
int DigitN(int K, int N)
{
	int Result = -1;
	int Count = 0;
	if (N <= 0 || K <= 0)
		return Result;
	for (int i = K; i >= 1; i /= 10)
	{
		Count++;
	}
	if (Count < N)
	{
		return Result;
	}
	for (int i = K; i >= 1; i /= 10)
	{
		Result = i % 10;
		if (N == 1)
			return Result;
		N--;
	}
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

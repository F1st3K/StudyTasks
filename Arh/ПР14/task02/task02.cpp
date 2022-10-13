// 2. Выполнить расчет по формуле: (3.32*X + Y) / (5.73*X - Y) + (Y/3.78 - X)
//

#include "stdafx.h"

double n1 = 3.32;
double n2 = 5.73;
double n3 = 3.78;
double res = 0;
double x = 0;
double y = 0;
char PrivX[] = "Enter X: ";
char PrivY[] = "Enter Y: ";
char form[] = "%f";
char vRes[] = "result: %f";

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{	
	inputX:
		//ввод X
		lea eax, PrivX
		call rid
		lea eax, x
		call writ
	inputY:
		//ввод Y
		lea eax, PrivY
		call rid
		lea eax, y
		call writ

	main:
		//выполнение основной функции

		//(3.32*X + Y)
		fld dword ptr y
		fld qword ptr n1
		fmul dword ptr x
		fadd st, st(1)
		//(5.73*X - Y)
		fld qword ptr n2
		fmul dword ptr x
		fsub st, st(2)
		//(Y / 3.78 - X)
		fld n3
		fdiv st(3), st(0)
		fld dword ptr x
		fsub st(4), st(0)
		//очишаем ненужное
		fstp n1
		fstp n1
		//основное деление и сложение
		fdivr st, st(1)
		fadd st, st(2)
		fstp res

	output:
		//выводим ответ
		fld qword ptr [res]
		sub  esp, 8
		fst qword ptr [esp]
		lea eax, vRes
		push eax
		call printf
		add esp, 12
		nop
	}
	return 0;
	_asm
	{
	rid:
		push eax
		call printf
		add esp, 4
		ret

	writ:
		push eax;
		xor eax, eax
		lea eax, form
		push eax;
		call scanf
		add esp, 8
		ret
	}
}


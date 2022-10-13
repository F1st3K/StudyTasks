//2. ¬ыполнить расчет по формуле: (Y - 2.77/X) - (X + 6.8*Y) + (Y/4.78 - X)

#include "stdafx.h"

double n1 = 2.77;
double n2 = 6.8;
double n3 = 4.78;
double res = 0;
double x = 1.0;
double y = 2.0;
char vRes[] = "result: %f";


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{	
	main:
		//выполнение основной функции
		fld x
		fld y
		//(Y - 2.28/X)
		fld qword ptr n1
		fdiv qword ptr x
		fld qword ptr y
		fsub st, st(1)
		//очишаем ненужное
		fstp n1
		fstp n1
		fstp n1
		//(X + 6.27*Y)
		fld qword ptr n2
		fmul qword ptr y
		fld qword ptr x
		fadd st, st(2)
		//(Y/7.13 - X)
		fld qword ptr y
		fld qword ptr n3
		fdiv st(1), st(0)
		fld qword ptr x
		fsub st(2), st(0)
		//очишаем ненужное
		fstp n1
		fstp n1
		//основное вычитание и сложение
		fadd st, st(2)
		fsubr st, st(3)
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
	
}

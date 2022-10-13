// 3. Выполнить расчет по формуле: (Y/2.22 - X) * (X + Y*6.63) - (3.64*X - Y)
//

#include "stdafx.h"


double n1 = 2.22;
double n2 = 6.63;
double n3 = 3.64;
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
		//(Y/2.22 - X)
		fdiv qword ptr n1
		fld qword ptr x
		fsubr st, st(1)
		//очишаем ненужное
		fxch st(2)
		fstp n1
		fstp n1
		//(X + 6.63*Y)
		fld qword ptr n2
		fmul qword ptr y
		fld qword ptr x
		fadd st, st(1)
		//(3.64*X - Y)
		fld qword ptr x
		fld qword ptr n3
		fmul st(1), st(0)
		fld qword ptr y
		fsub st(2), st(0)
		//очишаем ненужное
		fstp n1
		fstp n1
		//основное вычитание и умножение
		fxch st(2)
		fmul st, st(3)
		fsubr st, st(2)
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

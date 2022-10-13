// ВАРИАНТ № А22/Б9
//3. Выполнить расчет по формуле: (Y + 3.95/X) + (6.04/Y + X) / (Y + 3.63*X)
//Ответ в result

#include "stdafx.h"
double x = 1.01;
double y = 2.01;

double n1 = 3.95;
double n2 = 6.04;
double n3 = 3.63;

double result = 0.0;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		finit
		fld n3
		fld n2
		fld y
		fld x
		fld n1
		nop				// сверху вот это все нада (заносим переменные в стек вещ чисел)
		
	m1:					//тут считаем (Y + 3.95/X)
		fdiv st, st(1)	
		fadd st, st(2)
		nop
	m2:					//тут считаем (6.04/Y + X)
		fxch st(3)
		fdiv st, st(2)
		fadd st, st(1)
		nop
	m3:					//тут считаем (Y + 3.63*X)
		fxch st(4)
		fmul st, st(1)
		fadd st, st(2)
		nop

	res :				//тут сначала (2) делим на (3) и прибавляем (1)
		fxch st(4)
		fdiv st, st(4)
		fadd st, st(3)
		nop

	fst result			//Тут ответ
	nop
	}
	return 0;
}


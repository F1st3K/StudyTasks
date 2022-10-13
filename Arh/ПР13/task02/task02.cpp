//2. Выполнить расчет по формуле: (Y*2.53 - X) / (X + Y*7.6) + (2.3/X + Y)

#include "stdafx.h"

double x = 1.5;
double y = 2.5;
double n1 = 2.53;
double n2 = 7.6;
double n3 = 2.3;
double res = 0;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		finit

		fld x
		fld y

		fmul n1
		fsub st, st(1)

		fld y

		fmul n2
		fadd st, st(2)

		fxch st(2)

		fdivr n3
		fld y
		fadd st, st(1)

		fxch st(2)
		fdiv st, st(3)
		fadd st, st(2)

		fst res
		nop

	}
	return 0;
}


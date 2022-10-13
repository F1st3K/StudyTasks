// Выполнить расчет по формуле: (4.46*X + Y) + (Y - X/7.42) * (Y - X*5.17)
//

#include "stdafx.h"
double x = 1.0;
double y = 2.0;

double n1 = 4.46;
double n2 = 7.42;
double n3 = 5.17;

double res = 0;

double trash = 0.0;


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
	start:
		fld x
		fmul n1
		fld y
		fadd st, st(1)
		fxch st(1)
		fstp trash

		fld x
		fdiv n2
		fld y
		fsub st, st(1)
		fxch st(1)
		fstp trash

		fld x
		fmul n3
		fld y
		fsub st, st(1)
		fxch st(1)
		fstp trash
		
		
		fmul st, st(1)
		fadd st, st(2)

		fst res
	end:
		nop
	}
	return 0;
}


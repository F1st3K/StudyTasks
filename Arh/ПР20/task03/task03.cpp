// Определить, чему равна разность 564.3 и сумма первых 12 вещественных чисел последовательности 6.68, 13.57, 20.46, ...?
//

#include "stdafx.h"
double sumn = 564.3;
double firn = 6.68;
double itrn = 6.89;

double res = 0;
int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		finit
		fld itrn
		fld firn
		fld sumn
		mov ecx, 12

	start:
		fsub st, st(1)
		fxch st(1)
		fadd st, st(2)
		fxch st(1)
		loop start
	end:
		fst res
		nop
	}
	return 0;
}


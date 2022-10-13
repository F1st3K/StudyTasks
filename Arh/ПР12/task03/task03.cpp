//¬¿–»¿Õ“ π ¿22/¡9
// z = (sin(pi/2))/(1-cos(2*A/pi))+(1-tg(A/2))

#include "stdafx.h"

double r2 = 2;
double A = 0.523599;
double res = 0;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		finit

		fldpi
		fld r2
		fdivr st, st(1)
		fsin


		fld A
		fld r2
		fmul st, st(1)
		fxch st(1)
		fxch st(3)
		fdivr st, st(1)
		fcos
		fld1
		fsubr st, st(1)

		fsubr st, st(4)

		fld A
		fld r2
		fdivr st, st(1)
		fptan
		fsub st, st(1)


	}
	return 0;
}


//¬¿–»¿Õ“ π ¿22/¡9
//2. z = 0.25*(sin(2B)-tg(B))-0.25*(sin(A/pi)-cos(B/2))2
//

#include "stdafx.h"

double res = 0;
double w1 = 0.25;
double w2 = 2;
double A = 0.523599;
double B = 0.785398;
double r1, r2 = 0;


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		finit
		
		fld B
		fptan

		fld B
		fmul w2
		fsin

		fsub st(2), st
		fxch st(2)
		fstp r1


		fldpi
		fld A
		fdiv st, st(1)
		fsin

		fld w2
		fld B
		fdiv st, st(1)
		fcos

		fsubr st(2), st
		fxch st(2)
		fmul w1

		fld r1
		fsub st(1), st
		fxch st(1)
		fmul w1

		fst res




	


	}
	return 0;
}


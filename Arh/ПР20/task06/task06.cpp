//. z = (cos(A/2)-sin(B))/(cos2(A)+(1-tg(3A)))
//

#include "stdafx.h"

double res = 0;
double A = 30.0;
double B = 70.0;
double N2 = 2.0;
double N3 = 3.0;
double trash = 0;
double prev = 180;


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		finit

	//выполнение самой функции
main:
		//cos(A/2)
		fld A
		call translate
		fdiv N2
		fcos

		//-sin(B)
		fld B
		call translate
		fsin

		fsubr st, st(1)
		fxch st(1)
		fstp trash

		//cos^2(A)
		fld A
		call translate
		fcos
		fmul st, st(0)
		
		//(+1-tg(3A))
		fld A
		call translate
		fmul N3
		fptan
		fsub st, st(1)
		fxch st(1)
		fstp trash

		fadd st, st(1)
		fxch st(1)
		fstp trash

		//делим
		fdivr st, st(1)


		fstp res
		nop

	}
	return 0;
	_asm
	{
	translate:
		fldpi
		fmul st, st(1)
		fdiv prev
		fxch st(1)
		fstp trash
		ret
	}
}

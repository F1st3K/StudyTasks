//4. z = (tg(2B/pi)+ctg(2A))/(cos2(A+B/pi)+tg(B/8))
//

#include "stdafx.h"


double res = 0;
double A = 30.0;
double B = 70.0;
double N2 = 2.0;
double N8 = 8.0;
double trash = 0;
double prev = 180;
char vRes[] = "result: %f";


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		finit

	//выполнение самой функции
main:
		//tg(2B/pi)
		fld B
		call translate
		fmul N2
		fldpi
		fdivr st, st(1)
		fptan
		fstp trash
		fxch st(1)
		fstp trash

		//+ctg(2A)
		fld A
		call translate
		fmul N2
		fptan
		fdiv st, st(1)
		fxch st(1)
		fstp trash

		fadd st, st(1)
		fxch st(1)
		fstp trash

		//cos^2(A+B/pi)
		fld B
		call translate
		fldpi
		fdivr st, st(1)
		fxch st(1)
		fstp trash
		fld A
		call translate
		fadd st, st(1)
		fcos
		fmul st, st(0)
		fxch st(1)
		fstp trash
		
		//+tg(B/8)
		fld B
		call translate
		fdiv N8
		fptan
		fstp trash

		fadd st, st(1)
		fxch st(1)
		fstp trash

		//делим
		fdivr st, st(1)


		fstp res

	output:
		//вывод ответа
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
	translate:
		fldpi
		fmul st, st(1)
		fdiv prev
		fxch st(1)
		fstp trash
		ret
	}
}


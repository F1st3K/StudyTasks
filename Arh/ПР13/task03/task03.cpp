//3. z = 0.25*cos(B/pi)/(1+ctg(2A))+0.25*2tg(pi/4)

#include "stdafx.h"

double prev = 180;
double N1 = 0.25;
double N2 = 2;
double N3 = 4;
double res = 0;
double trash = 0;
int A[5] = {26, 28, 30, 32, 34};
double allRes[5] = {};
int B = 30;
int x1 = 0;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		mov ecx, 5
		lea edi, A
		lea esi, allRes

	start:
		call main
		fld res
		fstp [esi]
		add edi, 4
		add esi, 8
		loop start
	nop

	}
	return 0;
	_asm
	{
	main:
		push eax
		xor eax, eax
		finit


		mov eax, B
		mov x1, eax
		call translate

		fldpi
		fdivr st, st(1)
		fcos
		fmul N1
		fstp res
		fstp trash

		mov eax, [edi]
		mov x1, eax
		call translate

		fmul N2
		fptan
		fdiv st, st(1)
		fld1
		fadd st, st(1)

		fld res
		fdiv st, st(1)
		fstp res
		fstp trash
		fstp trash
		fstp trash

		fldpi
		fdiv N3
		fptan
		fstp trash
		fmul N2
		fmul N1
		fadd res
		fstp res

		pop eax
		ret
	}
	_asm
	{
	translate:
		fldpi
		fild x1

		fmul st, st(1)
		fdiv prev
		fxch st(1)
		fstp trash
		ret
	}

}


// ВАРИАНТ № А22/Б9
//1. Определить, меньше ли число 548.95 чем сумма первых 12 вещественных чисел последовательности 5.86, 13.82, 21.78, ...?
//

#include "stdafx.h"

double Maks = 548.95;
double frst = 5.86;
double itr = 7.96;
double mas = 0;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax
		mov ecx, 12

		finit
		fld itr
		fld frst
		fld mas

	start:
		fadd st, st(1)
		fxch st(1)
		fadd st, st(2)
		fxch st(1)
		loop start

	con:
		fcom Maks
		fnstsw ax
		sahf
		ja less
		jmp great

	less:
		mov bl, 1
		jmp end
	great:
		mov bl, 0
		jmp end
	end:
	   nop

	}
	return 0;
}


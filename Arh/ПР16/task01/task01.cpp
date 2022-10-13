//1. ќпределить, превосходит ли сумма первых 8 вещественных чисел последовательности 5.26, 11.46, 17.66, ... число 311.37?

#include "stdafx.h"

double n1 = 5.26;
double nr = 6.20;
double nmax = 311.37;

char vPrivetN[] = "Result: is not prevision!";
char vPrivetY[] = "Result: is mast prevision!";

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		mov ecx, 8
		finit
		fld n1
		fld nr
		fldz

	main:
		fadd st, st(2)
		fxch st(2)
		fadd st, st(1)
		fxch st(2)
		loop main

	con:
		fcom nmax
		fnstsw ax
		sahf
		ja endY
		jmp endN

	endN:
		lea	eax, vPrivetN
		push eax
		call printf
		add esp, 4
		nop

	endY:
		lea	eax, vPrivetY
		push eax
		call printf
		add esp, 4
		nop
	}
	return 0;
}


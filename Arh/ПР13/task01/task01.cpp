//1. ������� �� ������������� ����� 544.56 ������������������ ���� 8.26, 14.85, 21.44, ... ���� ��������� ������ 39.44 ��� �����.
//����������, ������� ������ ������������������ ���� ������������.

#include "stdafx.h"

double max = 544.56;
double nach = 8.26;
double posl = 6.59;
double min = 39.44;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax
		xor ecx, ecx

		finit

		fld nach
		fld posl
		fld max

	start:
		fcom min
		fnstsw ax
		sahf
		jb end
		inc ecx
		fsub st, st(2)
		fxch st(2)
		fadd st, st(1)
		fxch st(2)
		jmp start

	end:
		nop
	}

	return 0;
}


//1. ����������, ����� �� ���������������� ������������ ����� 6.86, 11.21, 15.56 ���� � ����� ���� ����� 328.04 ��� ������?

#include "stdafx.h"

double frnum = 6.86;
double rtnum = 4.35;
double res = 0;
double mxnum = 328.04;

char vPrivet1[] = "Pzh enter the beginning of the sequence (with a dot)!\n";
char vPrivet2[] = "Pzh enter the increasing sequence (with a dot)!\n";
char vPrivet3[] = "Pzh enter the maximum value of the sum of these numbers (with a dot)!\n";
char vPrivet4[] = "Result: %f\n";
char form[] = "%f";

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
	input:
		//���� ������� ��������
		lea eax, vPrivet1
		call rid

		lea eax, frnum
		call writ
		//���� ������� ������������������
		lea eax, vPrivet2
		call rid

		lea eax, rtnum
		call writ
		//���� ������������� ��������
		lea eax, vPrivet3
		call rid

		lea eax, mxnum
		call writ

	prev:
		//�������� ���������� �������� � ����
		xor eax, eax
		finit

		fld dword ptr rtnum
		fld dword ptr frnum
		fldz

	Start:
		//���������� ������� 
		fcom dword ptr mxnum
		fstsw ax
		sahf
		jae end
		fxch st(1)
		fadd st, st(2)
		fadd st(1), st(0)
		fst res
		fxch st(1)
		jmp Start

	end:
		//������� �����
		fld qword ptr res
		sub esp, 8
		fstp qword ptr[esp]
		lea	eax, vPrivet4
		push eax
		call printf
		add esp, 0Ch
		nop

	}
	return 0;
	_asm
	{
	rid:
		push eax
		call printf
		add esp, 4
		ret

	writ:
		push eax;
		xor eax, eax
		lea eax, form
		push eax;
		call scanf
		add esp, 8
		ret
	}
}

// 2. ������� � ������������ ������ 3.58 ������������������ ���� 7.81, 13.83, 19.85, ...
//���� ��������� ������ 317.47 ��� �����. 
//����������, ������� ������ ������������������ ���� ������������.
//

#include "stdafx.h"


double frnum = 7.81;
double rtnum = 6.02;
double sumnum = 3.58;
int res = 0;
double mxnum = 317.47;

char vRes[] = "Result: %d";

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor ecx, ecx
	prev:
		//�������� ���������� �������� � ����
		xor eax, eax
		finit
		fld qword ptr frnum
		fld qword ptr rtnum
		
		fld qword ptr sumnum
		

	Start:
		//���������� ������� 
		fcom qword ptr mxnum
		fstsw ax
		sahf
		jae end
		fadd st, st(2)
		fxch st(2)
		fadd st, st(1)
		fxch st(2)
		inc res
		jmp Start

	end:
		//������� �����
		push res
		lea eax, vRes
		push eax
		call printf
		add esp, 8
		nop

	}
	return 0;
}

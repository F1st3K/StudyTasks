//������� � �22/�9
//1. ����������, ����������� �� ����� ������ 12 ������������ ����� ������������������ 7.1, 14.76, 22.42, ... ����� 332.5 ?
//� ah 1 ��� 0 �������������� �� ��� ���

#include "stdafx.h"

double frst = 7.1;
double itr = 7.66;
double result = 0.0;
double max = 332.5;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax
		mov ecx, 12
		finit

		fld qword ptr itr
		fld qword ptr frst
		fld result
		fadd frst
								//����������� �������� � ����
	start:
		fadd st, st(2)			//���������� 
		fxch st(2)
		fadd itr				//��������� ������� ��� ��������
		fxch st(2)
		loop start				//��������� ��� 11 ���

	con:
		fcom qword ptr max		//��������� �������
		fnstsw ax
		fstp itr
		sahf
		jbe m2					
		ja m1
		

	m1:
		mov ah, 1
		jmp end					//���� �� ����������� �� � ah 1

	m2:
		mov ah, 0
		jmp end					//����� � ah 0

	end:

		nop

	}
	return 0;
}


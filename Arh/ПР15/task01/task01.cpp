//1. ������� � ������������ ������ 7.29 ������������������ ���� 4.62, 12.77, 20.92, ... ���� ��������� ������ 284.45 ��� �����.
//����������, ������� ������ ������������������ ���� ������������.

#include "stdafx.h"

double frnum = 0;
double rtnum = 0;
double sumnum = 0;
int res = 0;
double mxnum = 0;

char vPrivet1[] = "Pzh enter the beginning of the sequence (with a dot)!\n";
char vPrivet2[] = "Pzh enter the increasing sequence (with a dot)!\n";
char vPrivet3[] = "Pzh enter the maximum value of the sum of these numbers (with a dot)!\n";
char vPrivet4[] = "Pzh enter value of the sum numbers (with a dot)!\n";
char form[] = "%f";
char myOutFormat[] = "%d";
char vOutputFile[] = "res.txt";
char myW[] = "w";

FILE *myOutputFile;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
	input:
		//���� ����� � ������� ����������
		lea eax, vPrivet4
		call rid

		lea eax, sumnum
		call writ
		
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
		fld dword ptr frnum
		fld dword ptr rtnum
		
		fld dword ptr sumnum
		

	Start:
		//���������� ������� 
		fcom dword ptr mxnum
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
		lea	eax, myW
		push eax
		lea	eax, vOutputFile
		push eax
		call fopen	
		add	esp, 8
		mov	dword ptr myOutputFile, eax	
			
	
		mov	eax, res	
		push eax				
		lea eax, myOutFormat	
		push eax
		push dword ptr myOutputFile	
		call fprintf				
		add	esp, 12
	
		push dword ptr myOutputFile		
		call fclose
		add	esp, 4
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


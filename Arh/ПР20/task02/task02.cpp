// ��� ������ ����� ������������� � ������������� �����.
//������������� � ������������� ����� � ������� ����� ������������. 
//������ ������� ����� ���� ������. 
//����� ������ ������������� ��������� ������� �������� �������� �� ����� 0.
//

#include "stdafx.h"

int Mas[] = {1,2,-2,3,4,5,6,7,8,-8,9,-10,-45, 123, -345};

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		lea edi, Mas

	start:
		cmp[edi], 0h
		je end
		cmp[edi+4], 0
		jg rnul
		add edi, 4
		jmp start

	rnul:
		mov[edi], 0
		add edi, 4
		jmp start

	end:
		nop

	}
	return 0;
}


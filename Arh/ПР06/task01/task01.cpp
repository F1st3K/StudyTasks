//������� � �22/�9
//1. ����������, ���� ����� �������� 557 � ����� ������ 11 ����� ������������������ 8, 13, 18, ...?

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		mov eax, 557	// �����
		xor ecx, ecx	// �������
		mov ebx, 8		// ������������������		

	start:
		sub eax, ebx	// ��������
		cmp ecx, 10		//������� �� �������
		je end			// ����������
		add ebx, 5		// ���� ����� ����
		inc ecx			// ������� ++
		jmp start		// ���������

	end:
		nop
	}
	return 0;
}


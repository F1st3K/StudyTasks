//������� � �22/�9
//2. ���� ������. ������ ������ ����� ���� ������.
//��������� � ��������� � �������� AL ����� �������� ���� ������ (��������� ������ ������� ����������), �������� ��� ���� (�� ��������� ��� �����) ������� 'a', '6' � '/'.

#include "stdafx.h"
 
char data [] = "6f/af/af6af/6f";
int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax
		lea esi, data-1

	start:
		inc esi
		cmp [esi], 0h
		je end
		cmp[esi], 61h
		je start
		cmp[esi], 2fh
		je start
		cmp[esi], 36h
		je start
		inc al
		jmp start

	end:
		nop
	}
	return 0;
}


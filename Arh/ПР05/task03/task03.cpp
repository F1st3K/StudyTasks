//������� 22
//������� �� 11-�� ������� ��������� � 10-�� ������� ���������

#include "stdafx.h"

char strng[] = "......6A";	// ���� ������
int number = 0;				//���� �����
int Base = 11;				// ������� ��������� �� ������� ���������

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		lea edi, strng + 7
		mov ebx, 0
		mov ecx, 1

	start:
		cmp[edi], '.'
		je m500
		xor eax, eax
		mov al, [edi]
		cmp al, '9'
		jle m300
		sub al, 37h
		jmp m400

	m300 :
		sub al, 30h
		jmp m400

	m400 :
		mul ecx
		add	ebx, eax
		mov eax, ecx
		mul Base
		mov ecx, eax
		dec edi
		jmp start

	m500 :
		mov number, ebx
		lea edi, strng
		nop
	}
	return 0;
}
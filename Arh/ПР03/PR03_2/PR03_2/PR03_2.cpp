// PR03_2.cpp : Defines the entry point for the console application.
//������� � �22/�9 ����������, ������� ���������������� ������������� ����� ����� ������� � 6 ����� � ����� ���� ����� 294 ��� ������?

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		mov eax, 0 // ������ �����
		mov ebx, 6 // ������ ����� ������������������
		mov ecx, 0 // ������� ���������� �����

	m001:
		inc ecx //�������
		add eax, ebx //��������� ��������
		inc ebx // ���� �� ������������������ ������������� ����� �����(+1)
		cmp eax, 294 // ���������� ����� � 294
		jge m010 // ���� ������ ��� ����� 294 ����������� � �������� ecx ����� ��������� �����
		jmp m001 // ����� ���������

	m010:
		nop
		



	}
	return 0;
}


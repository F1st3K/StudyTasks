//������� � �22/�9
//1. ����������, ������ �� ����� 318, ��� ����� ������ 12 ��������� ������������������ ����� �������� ����� ?
//��������� � �������� al
#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax	//������� 
		xor ecx, ecx	//��������
		mov ebx, 1		//�������������� ������� ��� ������������������

	start:
		add eax, ebx	//���������
		add ebx, 2		//������������ �� ������������������
		inc ecx			//������� ��������
		cmp ecx, 12		//��������� ����� ��� ��������
		jge res1		//���� 12 �������� �� ���� ������������ ���������
		jmp start		//����� ���������

	res1:
		cmp eax, 318	//���������� �����
		jl res2
		mov al, 0		//���������� ���������
		jmp end

	res2:
		mov al, 1		//���������� ���������
		jmp end

	end:
		nop				//�����

	}
	return 0;
}


//���������� � ����������� ��������� ���������� �� ������ ���
//������� 9, ������� xor
//
#include "stdafx.h"

char Text[] = "kostin_nikita_konstantinovih";
short Key = 2777;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax			//�������
		lea esi, Text			//������� ������
		mov bl, byte ptr Key	//������� ����

	encryption :
		cmp[esi], 0h			//��������� ����� 
		je pouse
		mov	ax, word ptr[esi]	//������� � ������� 2 �������
		xor ax, bx				//�������
		mov word ptr[esi], ax	//�������������� �������
		add esi, 2				//������������ �� ������
		jmp encryption			//���������

	pouse :
		nop						//����������
		xor eax, eax			//�������
		lea esi, Text			//�������
		jmp decryption			//���� ��������������


	decryption :
		cmp[esi], 0h			//��������� �����
		je end
		mov	ax, word ptr[esi]	//������� � ������� 2 �������
		xor ax, bx				//��������������
		mov word ptr[esi], ax	//�������������� �������
		add esi, 2				//������������ �� ������
		jmp decryption			//������

	end :
		nop



	}
	return 0;
}
//����� � esi
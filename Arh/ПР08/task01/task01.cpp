//���������� � ����������� ��������� ���������� �� ������ ���
//������� 9, ���������� xor

#include "stdafx.h"

char Text[] = "kostin_nikita_konstantinovih";
char Key = 0x7;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax			//�������
		lea esi, Text			//������� ������
		mov cl, byte ptr Key	//������� ����

	encryption:
		cmp[esi], 0h			//��������� ����� 
		je pouse				
		mov	eax, dword ptr[esi]	//������� � ������� 4 �������
		rol eax, cl				//�������
		mov dword ptr[esi], eax	//�������������� �������
		add esi, 4				//������������ �� ������
		jmp encryption			//���������

	pouse:
		nop						//����������
		xor eax, eax			//�������
		lea esi, Text			//�������
		jmp decryption			//���� ��������������


	decryption:
		cmp[esi], 0h			//��������� ����� 
		je end
		mov	eax, dword ptr[esi]	//������� � ������� 4 �������
		ror eax, cl				//��������������
		mov dword ptr[esi], eax	//�������������� �������
		add esi, 4				//������������ �� ������
		jmp decryption			//������

	end:
		nop

	}
	return 0;
}
//����� � esi

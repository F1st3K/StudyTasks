//3. ���� ������. ������ ������ ����� ���� ������. 
//�������� �� ������ 'G' ��� ������� � �������� ������, ������� ���������� ������� ����� � ������. 
//��������, abcGcdf_kfgGgkhmGmr__dqozyn.

#include "stdafx.h"

char strng []= "fghfgfkfghhbhghfhklkkgghhhg";
int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		lea esi, strng	//�������� ������ ������
		xor eax, eax	//������� �������

	start:
		cmp[esi], 0h	//��������� ����� ������
		je end
		mov al, [esi]	//��� ��������� ���������� ������ ������� � �������
		add esi, 2		
		cmp al, [esi]	//���������� ������ �� � ��������� ����� ����
		je rwrt			//���� ��� ����� ���� ��������������
		dec esi			//����� ��������� ��� ��� �� ��������� ���������
		jmp start

	rwrt:
		dec esi			//������������ �� ������� ������� ����� ��������������
		mov[esi], 'G'	//����������
		add esi, 1		//��������� � ���������� �������� �������
		jmp start		//���������

	end:
		nop

	}
	return 0;
}


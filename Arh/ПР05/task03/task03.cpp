//Вариант 22
//Перевод из 11-ой системы счисления в 10-ую систему счисления

#include "stdafx.h"

char strng[] = "......6A";	// Наша строка
int number = 0;				//наше число
int Base = 11;				// Система счисления из которой переводим

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
//ВАРИАНТ № А22/Б9
//Дан массив целых чисел, содержащий, по крайней мере, два нуля. Размер массива может быть разный. 
//Найти и сохранить в регистр AL сумму чисел из данного набора, 
//расположенных между этими двумя нулями (если два нуля идут подряд, то сохранить в тот же регистр значение 0).

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	int Mas[] = { 1, 2, 0, 0, 5, 6, 0, 8};

	_asm
	{
		lea esi, Mas
		xor eax, eax
		xor ebx, ebx

	start:
		cmp[esi], 0h
		je f1
		add esi, 4
		jmp start
		
	f1:
		mov eax, esi
		add eax, 4
		jmp second

	second:
		mov esi, eax
		xor eax, eax
		cmp[esi], 0h
		je f2
		jmp summ

	f2:
		mov al, 0
		jmp end
	summ:
		cmp[esi], 0h
		je end
		add al, [esi]
		add esi, 4
		jmp summ

	end:
		nop
	}
	return 0;
}


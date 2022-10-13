//1. Дан массив целых чисел. Размер массива может быть разный. 
//Обнулить элементы массива, расположенные между его минимальным и максимальным элементами
//(не включая минимальный и максимальный элементы).
//

#include "stdafx.h"

char Mas[] = {1, 2, 3, -1, 4, 5, 6, 7, 100, 8, 9};

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		lea esi, Mas
		xor eax, eax
		xor ebx, ebx
		mov al, [esi]
		mov bl, [esi]

	start:
		cmp[esi], 0h
		je con
		jmp rtlow

	rtlow:
		cmp[esi], al
		jl wrlow
		jmp rttop

	rttop:
		cmp[esi], bl
		jg wrtop
		jmp rtend

	rtend:
		inc esi
		jmp start

	wrlow:
		mov al, [esi]
		mov edi, esi
		jmp rttop

	wrtop:
		mov bl, [esi]
		mov edx, esi
		jmp rtend

	con:
		inc edi
		cmp edi, edx
		je end
		mov[edi], 0
		jmp con

	end:
		nop

	}
	return 0;
}


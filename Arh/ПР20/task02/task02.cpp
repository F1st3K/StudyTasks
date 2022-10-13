// ƒан массив целых положительных и отрицательных чисел.
//ѕоложительные и отрицательные числа в массиве могут чередоватьс€. 
//–азмер массива может быть разный. 
//ѕеред каждым положительным элементом массива заменить значение на число 0.
//

#include "stdafx.h"

int Mas[] = {1,2,-2,3,4,5,6,7,8,-8,9,-10,-45, 123, -345};

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		lea edi, Mas

	start:
		cmp[edi], 0h
		je end
		cmp[edi+4], 0
		jg rnul
		add edi, 4
		jmp start

	rnul:
		mov[edi], 0
		add edi, 4
		jmp start

	end:
		nop

	}
	return 0;
}


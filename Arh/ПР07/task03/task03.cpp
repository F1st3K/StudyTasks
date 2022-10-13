//ВАРИАНТ № А22/Б9
//Дан массив целых положительных и отрицательных чисел. 
//Положительные и отрицательные числа в массиве могут чередоваться.
//Размер массива может быть разный. Умножить на число 6 все положительные элементы из этого массива. 
//Сохранить в регистр AL количество отрицательных элементов из этого массива.


#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	int Mas[] = { 1, 2, 1, -2, -1, 1, -1, 8, 0};

	_asm
	{
		lea esi, Mas
		mov ebx, 6
		xor eax, eax
		xor edx, edx

	start:
		cmp[esi], 0h
		je end
		cmp[esi], 0
		jl min
		mov al, [esi]
		mul bl
		mov[esi], al
		add esi, 4
		jmp start

	min:
		inc dl
		add esi, 4
		jmp start

	end:
		nop
	}
	return 0;
}


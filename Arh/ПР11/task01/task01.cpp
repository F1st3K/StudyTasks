//ВАРИАНТ № А22/Б9
//1. Определить, превосходит ли сумма первых 12 вещественных чисел последовательности 7.1, 14.76, 22.42, ... число 332.5 ?
//в ah 1 или 0 соответственно да или нет

#include "stdafx.h"

double frst = 7.1;
double itr = 7.66;
double result = 0.0;
double max = 332.5;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax
		mov ecx, 12
		finit

		fld qword ptr itr
		fld qword ptr frst
		fld result
		fadd frst
								//подготовили регистры и стек
	start:
		fadd st, st(2)			//прибавляем 
		fxch st(2)
		fadd itr				//следующий элемент для сложения
		fxch st(2)
		loop start				//повторить еще 11 раз

	con:
		fcom qword ptr max		//проверяем условие
		fnstsw ax
		fstp itr
		sahf
		jbe m2					
		ja m1
		

	m1:
		mov ah, 1
		jmp end					//если не превосходит то в ah 1

	m2:
		mov ah, 0
		jmp end					//иначе в ah 0

	end:

		nop

	}
	return 0;
}


//ВАРИАНТ № А22/Б9
//1. Определить, чему равна разность 557 и сумма первых 11 чисел последовательности 8, 13, 18, ...?

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		mov eax, 557	// число
		xor ecx, ecx	// счетчик
		mov ebx, 8		// последовательность		

	start:
		sub eax, ebx	// вычитаем
		cmp ecx, 10		//смотрим на счетчик
		je end			// зачкончить
		add ebx, 5		// след число посл
		inc ecx			// счетчик ++
		jmp start		// повторить

	end:
		nop
	}
	return 0;
}


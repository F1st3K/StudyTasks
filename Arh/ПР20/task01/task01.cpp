// Определить, чему равна разность 518 и сумма первых 10 чисел последовательности 5, 10, 15, ...?
//

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		mov eax, 518
		mov ebx, 5
		mov edx, 5
		mov ecx, 10

	start:
		sub eax, ebx
		add ebx, edx
		loop start
	end:
		nop
	}
	return 0;
}


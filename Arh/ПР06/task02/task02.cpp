//ВАРИАНТ № А22/Б9
//2. Дана строка. Размер строки может быть разным.
//Вычислить и сохранить в регистре AL длину заданной Вами строки (используя только команды ассемблера), отбросив при этом (не учитывать при счете) символы 'a', '6' и '/'.

#include "stdafx.h"
 
char data [] = "6f/af/af6af/6f";
int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax
		lea esi, data-1

	start:
		inc esi
		cmp [esi], 0h
		je end
		cmp[esi], 61h
		je start
		cmp[esi], 2fh
		je start
		cmp[esi], 36h
		je start
		inc al
		jmp start

	end:
		nop
	}
	return 0;
}


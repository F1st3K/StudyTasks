//Dана строка, состоящая из букв английского алфавита и цифр (от 1 до 9). 
//Размер строки может быть разным. 
//Вычислить и сохранить в регистр AX произведение всех цифр, 
//встречающихся в этой строке, 
//отбросив при этом (не учитывать при счете) цифры 2 и 7.
//

#include "stdafx.h"

char Str[] = "dfk1234567";

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		lea edi, Str
		xor ebx, ebx
		mov eax, 1
	start:
		cmp[edi], 0h
		je end
		cmp[edi], 31h
		je strmul
		cmp[edi], 33h
		je strmul
		cmp[edi], 34h
		je strmul
		cmp[edi], 35h
		je strmul
		cmp[edi], 36h
		je strmul
		cmp[edi], 38h
		je strmul
		cmp[edi], 39h
		je strmul
		inc edi
		jmp start
	strmul:
		mov bl, [edi]
		sub bl, 48
		mul bl
		inc edi
		jmp start
	end:
		nop
	}
	return 0;
}


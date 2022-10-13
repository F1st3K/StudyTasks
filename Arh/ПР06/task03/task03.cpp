//
//3. ƒана строка, содержаща€ латинские буквы и круглые скобки. ƒлина строки может быть разной. 
//≈сли скобки расставлены правильно (т.е. каждой открывающей скобке соответствует одна закрывающа€ скобка), то в регистр AL сохранить число 0. 
//¬ противном случае, получить или номер позиции, в которой расположена перва€ ошибочна€ закрывающа€ скобка, или, если закрывающих скобок не хватает, то в регистр AL сохранить число 255.

#include "stdafx.h"
char data[] = "(()";

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		lea esi, data-1
		xor eax, eax
		xor ebx, ebx
		xor ecx, ecx
		xor edi, edi

	start:
		inc esi
		inc ch
		cmp [esi], 0h
		je con
		cmp [esi], 28h
		je A
		cmp [esi], 29h
		je B
		jmp start

	A:
		inc di
		jmp start
	B:
		inc bx
		inc edi
		cmp edi, 1
		je C
		jmp start

	C:
		mov ah, ch
		jmp start

	con:
		cmp di, bx
		je m1
		cmp di, bx
		jl m2
		cmp di, bx
		jg m3

	m1:
		mov al, 0
		jmp end
	m3:
		mov al, ah
		jmp end
	m2:
		mov al, 255
		jmp end

	end:
		nop
	}
	return 0;
}


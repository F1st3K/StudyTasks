// ??????? ? ?22/?9
// ???? ??????, ????????? ?? ???? ??????????? ???????? ? ???? (?? 1 ?? 9). ?????? ?????? ????? ???? ??????.
// ????? 11 ? 19 ????????? ? ???? ??????, ????? ? ????????? ? ??????? AX ???????????? ???? 2.

#include "stdafx.h"

char Mas[] = "dhfj32k3kck2222222e5567sdhjd";

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
	lea esi, Mas	// ???????? ? ??????? ?????? ?????? ?????? ?? ???????

	mov bx, 2		// ?????????? ??? ?????????
	mov ax, 1		// ?????? ???????? 1 ??? ?? ??? ????????? ?? ???????? 0
	mov edi, esi	// ???????? ? ??? ???? ???????
	add edi, 19		// ??????? edi ?????? ?? ?????? ????? ?????? ??????
	add esi, 11		// ??????? esi c ?????? ????? ?????? ??????
m1:
	cmp esi, edi	// ????????? ???????? ??????????? ???????? ? ??????
	jge m3			// ??? ?????????? ???????????
	cmp[esi], 32h	// ????? ???? 2 ? ??????
	je m2			// ??????? ??????? ?2
	inc esi			// ????? ????????? ? ???? ???????? ??????
	jmp m1			// ? ?????????

m2 :
	mul bx			// ???????? ax ?? 2
	inc esi			// ? ???? ?? ??????
	jmp m1			// ??????? ?1

m3 :
	nop
	}
	return 0;
}
//????? ????? ? ???????? AX


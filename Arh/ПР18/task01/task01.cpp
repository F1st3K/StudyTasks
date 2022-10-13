//1. Определить, больше ли число 492.26 чем сумма первых десяти вещественных чисел последовательности 3.78, 7.47, 11.16, ...?
//

#include "stdafx.h"

double frnum = 3.78;
double rtnum = 3.69;
int res = 0;
double mxnum = 492.26;

char myOutFormat[] = "%d";
char vOutputFile[] = "out.txt";
char myW[] = "w";

FILE *myOutputFile;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{	

	prev:
		//выгрузка полученных значений в стэк
		xor eax, eax
		finit
		fld qword ptr frnum
		fld qword ptr rtnum
		fldz
		mov ecx, 9

	Start:
		fadd st, st(2)
		fxch st(2)
		fadd st, st(1)
		fxch st(2)
		loop Start

	con:
		lea	eax, myW
		push eax
		lea	eax, vOutputFile
		push eax
		call fopen	
		add	esp, 8
		mov	dword ptr myOutputFile, eax	
		//выполнение функции 
		fcom qword ptr mxnum
		fstsw ax
		sahf
		jbe no
		jmp yes

	no:
		mov	eax, 0
		jmp end

	yes:
	   mov	eax, 1
	   jmp end

	end:
	   //выводим ответ
		push eax
		lea eax, myOutFormat
		push eax
		push dword ptr myOutputFile
		call fprintf
		add	esp, 12

		push dword ptr myOutputFile
		call fclose
		add	esp, 4
		nop
	
		

	}
	return 0;
}


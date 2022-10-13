//2. Выполнить расчет по формуле: (Y - 2.28/X) - (X + 6.27*Y) + (Y/7.13 - X)

#include "stdafx.h"
double n1 = 2.28;
double n2 = 6.27;
double n3 = 7.13;
double res = 0;
double x = 0;
double y = 0;
char PrivX[] = "Enter X: ";
char PrivY[] = "Enter Y: ";
char form[] = "%f";
char vRes[] = "result: %f";
char vOutputFile[] = "output.txt";
char myW[] = "w";

FILE *myOutputFile;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{	
	inputX:
		//ввод X
		lea eax, PrivX
		call rid
		lea eax, x
		call writ
	inputY:
		//ввод Y
		lea eax, PrivY
		call rid
		lea eax, y
		call writ

	main:
		//выполнение основной функции

		//(Y - 2.28/X)
		fld qword ptr n1
		fdiv dword ptr x
		fld dword ptr y
		fsub st, st(1)
		//(X + 6.27*Y)
		fld qword ptr n2
		fmul dword ptr y
		fld dword ptr x
		fadd st, st(2)
		//(Y/7.13 - X)
		fld dword ptr y
		fld qword ptr n3
		fdiv st(1), st(0)
		fld dword ptr x
		fsub st(2), st(0)
		//очишаем ненужное
		fstp n1
		fstp n1
		//основное вычитание и сложение
		fadd st, st(2)
		fsubr st, st(3)
		fstp res

	output:
		//выводим ответ
		lea	eax, myW
		push eax
		lea	eax, vOutputFile
		push eax
		call fopen	
		add	esp, 8
		mov	dword ptr myOutputFile, eax	
			
	
		fld qword ptr [res]
		sub  esp, 8
		fst qword ptr [esp]	
		lea eax, form
		push eax
		push dword ptr myOutputFile	
		call fprintf				
		add	esp, 16
	
		push dword ptr myOutputFile		
		call fclose
		add	esp, 4
		nop
	}
	return 0;
	_asm
	{
	rid:
		push eax
		call printf
		add esp, 4
		ret

	writ:
		push eax;
		xor eax, eax
		lea eax, form
		push eax;
		call scanf
		add esp, 8
		ret
	}
}

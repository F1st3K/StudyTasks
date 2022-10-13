//3. z = ctg2(3*pi/6)-cos(2A/4)+cos(pi/4)

#include "stdafx.h"
double res = 0;
double A = 30.0;
double B = 70.0;
double N2 = 2.0;
double N3 = 3.0;
double N4 = 4.0;
double N6 = 6.0;
char PrivA[] = "Enter A: ";
char form[] = "%f";
char vRes[] = "result: %f";
double trash = 0;
double prev = 180;
char vOutputFile[] = "output.txt";
char myW[] = "w";

FILE *myOutputFile;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		finit
	input:
		//ввод A
		lea eax, PrivA
		call rid
		lea eax, A
		call writ

	//выполнение самой функции
	main:
			//ctg2(3*pi/6)
		fldpi
		fmul N3 
		fdiv N6
		fptan 
		fdiv st, st(1)
		fmul st, st(0)

		//Очищаем все ненужное в стеке
		fxch st(1)
		fstp trash

			//-cos(2A/4)
		fld A
		call translate
		fmul N2
		fdiv N4
		fcos
		fsub st(1), st(0)

		//Очищаем все ненужное в стеке
		fxch st(1)
		fstp trash

			//+cos(pi/4)
		fldpi
		fdiv N4
		fcos

		fadd st, st(1)
		
		fstp res

	output:
		//вывод ответа
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
	translate:
		fldpi
		fmul st, st(1)
		fdiv prev
		fxch st(1)
		fstp trash
		ret

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

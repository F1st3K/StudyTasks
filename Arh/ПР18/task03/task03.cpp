// 3. z = (sin(2B)+sin(5A/2))/(cos(A/4)-2sin(2A/pi))
//

#include "stdafx.h"

double res = 0;
double A = 30.0;
double B = 70.0;
double N2 = 2.0;
double N5 = 5.0;
double N4 = 4.0;
char form[] = "%f";
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

	//выполнение самой функции
main:
		//sin(2B)
		fld B
		call translate
		fmul N2
		fsin

		//+sin(5A/2)
		fld A
		call translate
		fmul N5
		fdiv N2
		fsin

		fadd st, st(1)
		fxch st(1)
		fstp trash

		//cos(A/4)
		fld A
		call translate
		fdiv N4
		fcos
		
		//-2sin(2A/pi
		fld A
		call translate
		fmul N2
		fldpi
		fdivr st, st(1)
		fxch st(1)
		fstp trash
		fsin
		fmul N2

		fsubr st, st(1)
		fxch st(1)
		fstp trash

		//делим
		fdivr st, st(1)


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
	}
}


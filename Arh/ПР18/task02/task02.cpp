// 2. ¬ыполнить расчет по формуле (3.79*X + Y) / (Y - X*5.52)
//

#include "stdafx.h"


double x = 1.0;
double y = 2.0;
double res = 0;
double numf = 3.79;
double nums = 5.52;

char myOutFormat[] = "%d";
char form[] = "%f";
char vOutputFile[] = "out.txt";
char myW[] = "w";

FILE *myOutputFile;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{	

	prev:
		xor eax, eax
		finit

	main:
		fld qword ptr y
		fld qword ptr x
		fmul numf
		fadd st, st(1)

		fld qword ptr x
		fmul nums
		fsub st, st(2)

		fdivr st, st(1)

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

		fld qword ptr[res]
		sub  esp, 8
		fst qword ptr[esp]
		lea eax, form
		push eax
		push qword ptr myOutputFile
		call fprintf
		add	esp, 16

		push qword ptr myOutputFile
		call fclose
		add	esp, 4
		nop
	
		

	}
	return 0;
}

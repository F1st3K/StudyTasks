//3. z = (tg(2B/pi)+tg(2A))/(cos2(A+B/pi))+tg(B/2)

#include "stdafx.h"

double A = 30.0;
double B = 45.0;
double N2 = 2.0;
char vRes[] = "result: %f";
double trash = 0;
double prev = 180;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		finit
	//выполнение самой функции
	main:
			//tg(2B/pi)
		fldpi
		fld A
		call translate

		fdiv st, st(1)
		fmul st, st
		fsin

		//Очищаем все ненужное в стеке
		fxch st(1)
		fstp trash

			//+tg(2A)
		fld A
		call translate
		fmul N2
		fsin
		fadd st, st(1)

		//Очищаем все ненужное в стеке
		fxch st(1)
		fstp trash

			//cos2(A+B/pi)
		fld A
		call translate
		fmul N2
		fptan

		//Очищаем все ненужное в стеке
		fstp trash

			//tg(B/2)
		fld B
		call translate
		fmul N2
		fld A
		call translate
		fmul N2
		fdiv st, st(1)
		fcos
		fadd st, st(2)

		//Очищаем все ненужное в стеке
		fxch st(1)
		fstp trash
		fxch st(1)
		fstp trash

		//выполняем последнее деление
		fdivr st, st(1)

		//Очищаем все ненужное в стеке
		fxch st(1)
		fstp trash

	output:
		//вывод ответа
		sub  esp, 8
		fst qword ptr [esp]
		lea eax, vRes
		push eax
		call printf
		add esp, 12
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

//3. ƒана строка. –азмер строки может быть разным. 
//«аменить на символ 'G' все символы в заданной строке, имеющие одинаковых соседей слева и справа. 
//Ќапример, abcGcdf_kfgGgkhmGmr__dqozyn.

#include "stdafx.h"

char strng []= "fghfgfkfghhbhghfhklkkgghhhg";
int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		lea esi, strng	//получаем адресс строки
		xor eax, eax	//очищаем регистр

	start:
		cmp[esi], 0h	//провер€ем конец строки
		je end
		mov al, [esi]	//дл€ сравнени€ записываем первый элемент в регистр
		add esi, 2		
		cmp al, [esi]	//сравниваем первый эл с элементом через один
		je rwrt			//если они равны идем перезаписывать
		dec esi			//иначе повтор€ем все это со следующим элементом
		jmp start

	rwrt:
		dec esi			//перемещаемс€ на элемент который будем перезаписывать
		mov[esi], 'G'	//перезапись
		add esi, 1		//переходим к следующему элементу массива
		jmp start		//повтор€ем

	end:
		nop

	}
	return 0;
}


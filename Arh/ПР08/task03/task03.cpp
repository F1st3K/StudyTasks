//шифрование и расшифровку сообщения состоящего из Вашего ФИО
//Вариант 9, словный xor
//
#include "stdafx.h"

char Text[] = "kostin_nikita_konstantinovih";
short Key = 2777;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax			//очищаем
		lea esi, Text			//заносим адресс
		mov bl, byte ptr Key	//заносим ключ

	encryption :
		cmp[esi], 0h			//проверяем конец 
		je pouse
		mov	ax, word ptr[esi]	//заносим в регистр 2 символа
		xor ax, bx				//шифруем
		mov word ptr[esi], ax	//перезаписываем символы
		add esi, 2				//продвигаемся по строке
		jmp encryption			//повторяем

	pouse :
		nop						//передохнем
		xor eax, eax			//очищаем
		lea esi, Text			//очищаем
		jmp decryption			//идем расшифровывать


	decryption :
		cmp[esi], 0h			//проверяем конец
		je end
		mov	ax, word ptr[esi]	//заносим в регистр 2 символа
		xor ax, bx				//расшифровываем
		mov word ptr[esi], ax	//перезаписываем символы
		add esi, 2				//продвигаемся по строке
		jmp decryption			//повтор

	end :
		nop



	}
	return 0;
}
//ответ в esi
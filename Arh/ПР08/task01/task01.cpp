//шифрование и расшифровку сообщения состоящего из Вашего ФИО
//Вариант 9, двусловный xor

#include "stdafx.h"

char Text[] = "kostin_nikita_konstantinovih";
char Key = 0x7;

int _tmain(int argc, _TCHAR* argv[])
{
	_asm
	{
		xor eax, eax			//очищаем
		lea esi, Text			//заносим адресс
		mov cl, byte ptr Key	//заносим ключ

	encryption:
		cmp[esi], 0h			//проверяем конец 
		je pouse				
		mov	eax, dword ptr[esi]	//заносим в регистр 4 символа
		rol eax, cl				//шифруем
		mov dword ptr[esi], eax	//перезаписываем символы
		add esi, 4				//продвигаемся по строке
		jmp encryption			//повторяем

	pouse:
		nop						//передохнем
		xor eax, eax			//очищаем
		lea esi, Text			//очищаем
		jmp decryption			//идем расшифровывать


	decryption:
		cmp[esi], 0h			//проверяем конец 
		je end
		mov	eax, dword ptr[esi]	//заносим в регистр 4 символа
		ror eax, cl				//расшифровываем
		mov dword ptr[esi], eax	//перезаписываем символы
		add esi, 4				//продвигаемся по строке
		jmp decryption			//повтор

	end:
		nop

	}
	return 0;
}
//ответ в esi


// PR_08.cpp : Defines the entry point for the console application.
//Авиакомпания (char), тип самолета (char), вместимость пассажиров (int), бортовой номер (int), часов до выработки ресурса (float).
//Поиск по оставшемуся ресурсу "не менее".

#include "stdafx.h"

struct Sprinter
{
	int id;
	char FirstName[16];
	char LastName[16];
	int YearIssued;
	int Distance;
	float BestResult;
	int NumSprinter;
};

FILE *pInputT, *pOutputB, *pInputB;

int vvI, vResult;

void fCreate(), fSelect();
char vWorkStr[30];
char *pWorkStr = &vWorkStr[0];

struct Sprinter sSprinter;

int _tmain(int argc, _TCHAR* argv[])
{

m100:
	printf("\n — MENU —\n");
	printf("________________________________________________________________________\n");
	printf("\n1 - create new bin_file\n\n2 - select from file\n\n3 - end of work\n");
	printf("________________________________________________________________________\n\n");

	int vNum = 0;
	scanf("%d", &vNum);

	if (vNum == 1)
	{
		// создаем двоичный файл
		fCreate();
		goto m100;
	}

	if (vNum == 2)
	{
		// выборки из двоичного файла
		fSelect();
		goto m100;
	}

	if (vNum == 3)
	{
		return 0; // завершение работы
	}

	return 0;
}

void fCreate()
{
	float vfMusor = 0;

	pInputT = fopen("input.txt", "r"); if (pInputT == NULL) goto m_end;
	pOutputB = fopen("input.bin", "wb"); if (pOutputB == NULL) goto m_end;

	for (vvI = 0; vvI<15; vvI++)
	{
		fscanf(pInputT, "%s%s%d%d%f", &sSprinter.FirstName, &sSprinter.LastName, &sSprinter.YearIssued, &sSprinter.Distance, &sSprinter.BestResult);
		sSprinter.NumSprinter = vvI+1;
		fwrite(&sSprinter, sizeof(sSprinter), 1, pOutputB);
	}

	vResult = fclose(pInputT);
	vResult = fclose(pOutputB);

m_end:
	;
}

void fSelect()
{
	int vRecNum;
	float MinResult;

m200:
	printf("________________________________________________________________________\n\n");
	printf("\n1 - get record by number\n\n2 - get record by key\n\n3 - to monitor\n\n");
	printf("________________________________________________________________________\n\n");

	int vNum2 = 0;
	scanf("%d", &vNum2);

	switch (vNum2)
	{
	case 1:
	{
		pInputB = fopen("input.bin", "rb");
		if (pInputB == NULL) goto m_end01;

		printf("________________________________________________________________________\n\n");
		printf("get record number\n");
		printf("________________________________________________________________________\n\n");
		scanf("%d", &vRecNum);
		printf("------------------------------------------------------------------------\n");
		printf("|Num\t|Name\t\t|SName\t\t|Isued\t|Dist\t|%Best\t\t|\n");
		printf("------------------------------------------------------------------------\n");

		fseek(pInputB, vRecNum * sizeof(sSprinter) - sizeof(sSprinter), SEEK_SET);

		fread(&sSprinter, sizeof(sSprinter), 1, pInputB);
		printf("|%d\t|%s\t\t|%s\t\t|%d\t|%d\t|%lf\t|\n", sSprinter.NumSprinter, &sSprinter.FirstName, &sSprinter.LastName, sSprinter.YearIssued, sSprinter.Distance, sSprinter.BestResult);
		printf("------------------------------------------------------------------------\n");
		vResult = fclose(pInputB);

	m_end01:
		break;
	};
	case 2:
	{
		pInputB = fopen("input.bin", "rb");
		if (pInputB == NULL)
		{
			goto m_end02;
		}
		printf("________________________________________________________________________\n\n");
		printf("get key value\n\n");
		printf("________________________________________________________________________\n\n");
		scanf("%f", &MinResult);
		printf("------------------------------------------------------------------------\n");
		printf("|Num\t|Name\t\t|SName\t\t|Isued\t|Dist\t|%Best\t\t|\n");
		printf("------------------------------------------------------------------------\n");

		for (vvI = 0; vvI<15; vvI++)
		{
			fread(&sSprinter, sizeof(sSprinter), 1, pInputB);
			if (sSprinter.BestResult >= MinResult)
			{
				printf("|%d\t|%s\t\t|%s\t\t|%d\t|%d\t|%f\t|\n", sSprinter.NumSprinter, &sSprinter.FirstName, &sSprinter.LastName, sSprinter.YearIssued, sSprinter.Distance, sSprinter.BestResult);

			}
		}

		printf("------------------------------------------------------------------------\n");
		vResult = fclose(pInputB);

	m_end02:
		break;
	};

	case 3: return;

	}

	goto m200;
}



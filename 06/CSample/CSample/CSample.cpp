// CSample.cpp : 定義主控台應用程式的進入點。
//

#include "stdafx.h"


int _tmain(int argc, _TCHAR* argv[])
{
	//弱類型
	int x = 100;
	//200 =x;	不會對X進行附值，弱類型語言通常這樣寫
	if (x = 200)//在C語言中非零為true
	{
		printf("It,s OK!\n");
	}
	return 0;
}


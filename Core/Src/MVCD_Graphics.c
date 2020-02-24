/*
 * MVCD_Graphics.c
 *
 *  Created on: Feb 20, 2020
 *      Author: HBLS
 */

#include "MVCD_Graphics.h"
#include "MVCD_ST7920lib.h"
#include <math.h>



void MVCD_DrawGrid(){

	for(int i=0;i<128;i++){
		MVCD_dot_xy(i, 32);
		if(i<64)MVCD_dot_xy(64,i);
		//draw grid

		MVCD_dot_xy(126,31);
		MVCD_dot_xy(126,33);
		MVCD_dot_xy(125,30);
		MVCD_dot_xy(125,34);
		// right arrow

		MVCD_dot_xy(63,1);
		MVCD_dot_xy(65,1);
		MVCD_dot_xy(62,2);
		MVCD_dot_xy(66,2);
		// up arrow


	}
}

void MVCD_Draw1f(double a,int p,int q,_Bool newflag){
	int x=0,y=0;
	double tempA=0;

	for(x=0;x<64;x++){
		for(int i=0;i<(a > 1 ? a : 1);i++){
			if(YZERO-y-q >= 0)MVCD_dot_xy(XZERO+x+p, YZERO-y-q);
			if(YZERO+y-q < 64)MVCD_dot_xy(XZERO-x+p, YZERO+y-q);
			tempA+=a;
			if(tempA>=1){
				y++;
				tempA=0;
			}
		}


	}

}

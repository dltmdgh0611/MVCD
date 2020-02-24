/*
 * MVCD_Graphics.h
 *
 *  Created on: Feb 20, 2020
 *      Author: user
 */

#ifndef INC_MVCD_GRAPHICS_H_
#define INC_MVCD_GRAPHICS_H_

#include "stm32f4xx_hal.h"

#define XZERO 64

#define YZERO 32

void MVCD_DrawGrid();

void MVCD_Draw1f(double a,int p,int q,_Bool newflag);

#endif /* INC_MVCD_GRAPHICS_H_ */

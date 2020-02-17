#ifndef __MVCD_ST7920lib_H
#define __MVCD_ST7920lib_H

#include "stm32f4xx_hal.h"
#include "stm32f4xx_hal.h"
#include <math.h>

#define INSTMOD 0

#define DATAMOD 1


int lcdmap[8][64];

void MVCD_Send8bit(unsigned char data, _Bool modflag); //send 8bit using to SPI

void MVCD_Dot(int xpos, int ypos); // draw dots on the GLCD

void MVCD_Allclear(); // clear all dots

#endif /*__MVCD_ST7920lib_H*/

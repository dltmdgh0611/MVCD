#include "MVCD_ST7920lib.h"
#include "spi.h"
/*************************************** including */


void MVCD_Send8bit(unsigned char data, _Bool modflag) //send 8bit using to SPI
{
	if(modflag) HAL_SPI_Transmit(&hspi1, (uint8_t)0xFA, 1, 10);
	else HAL_SPI_Transmit(&hspi1, (uint8_t)0xF8, 1, 10);
	// choose mode

	HAL_SPI_Transmit(&hspi1, (uint8_t)data&0xF0, 1, 10);
	HAL_SPI_Transmit(&hspi1, (uint8_t)((data&0x0F)<<4), 1, 10);
	//sending data
}

void MVCD_Dot(int x, int y) // draw dots on the GLCD
{
    int flx = (int)floor(x/16);
    lcdmap[flx][y] |= (0x8000 >> x%16);
    MVCD_Send8bit(0x36, INSTMOD);
    MVCD_Send8bit(0x80+(y % 32), INSTMOD);
    MVCD_Send8bit(0x80+ (y / 32) * 8 + floor(x/16), INSTMOD);

    MVCD_Send8bit(0x30, INSTMOD);
    MVCD_Send8bit(((lcdmap[flx][y] &0xff00)>>8), DATAMOD);
    MVCD_Send8bit(lcdmap[flx][y]&0xff, DATAMOD);
}

void MVCD_Allclear() // clear all dots
{
	for(int j=0;j<8;j++){
		for(int i=0;i<64;i++){
			MVCD_Send8bit(0x36, INSTMOD);
			MVCD_Send8bit(0x80+(i%32), INSTMOD);
			MVCD_Send8bit(0x80+((i/32)*8+j), INSTMOD);
			MVCD_Send8bit(0x30, INSTMOD);
			MVCD_Send8bit(0x00, DATAMOD);
			MVCD_Send8bit(0x00, DATAMOD);
		}
	}
}


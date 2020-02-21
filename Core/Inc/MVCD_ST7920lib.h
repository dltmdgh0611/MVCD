/*
 * MVCD_ST7920lib.h
 *
 *  Created on: Feb 19, 2020
 *      Author: user
 */

#ifndef INC_MVCD_ST7920LIB_H_
#define INC_MVCD_ST7920LIB_H_


#define CMD 0

#define DATA 1

#define ON 1

#define OFF 0

int prv_val[8][64];

void MVCD_delay_us (uint16_t us); //delay microseconds

void MVCD_SendByte_SPI(uint8_t byte); //send 8bit using GPIO SPI

void MVCD_ST7920_Send (uint8_t data, int modflag); //modflag - (data 1), (cmd 0)

void MVCD_ST7920_baseinit(); // setting LCD baseinit

void MVCD_ST7920_GraphicMode (_Bool enable); // GraphicMode On/Off

void MVCD_dot_xy(int x,int y); //set pixel

void MVCD_deldot_xy(int x,int y); //del pixel

void MVCD_LCDclear(); //claer lcd's graphic

void MVCD_DrawBitmap(const unsigned char* graphic); // drawing bitmap

#endif /* INC_MVCD_ST7920LIB_H_ */

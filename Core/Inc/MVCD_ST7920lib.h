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

void SendByte_SPI(uint8_t byte); //send 8bit using GPIO SPI

void ST7920_Send (uint8_t data, _Bool modflag); //modflag - (data 1), (cmd 0)

void MVCD_ST7920_baseinit(); // setting LCD baseinit

void MVCD_ST7920_GraphicMode (_Bool enable); // GraphicMode On/Off

void dot_xy(int x,int y); //set pixel

void LCDclear(); //claer lcd's graphic

#endif /* INC_MVCD_ST7920LIB_H_ */

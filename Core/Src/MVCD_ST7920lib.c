/*
 * MVCD_ST7920lib.c
 *
 *  Created on: Feb 19, 2020
 *      Author: HBLS
 *      Reference URL : https://controllerstech.com/glcd-128x64-st7920-interfacing-with-stm32/
 *
 *
 */


#include "stm32f4xx_hal.h"
#include "MVCD_ST7920lib.h"
#include "tim.h"

#define SCLK_PIN GPIO_PIN_13
#define SCLK_PORT GPIOF
/* SCLK = EN */

#define SID_PIN GPIO_PIN_9
#define SID_PORT GPIOE
/* SID = RW */

#define CS_PIN GPIO_PIN_11
#define CS_PORT GPIOE
/* CS = RS*/

#define RST_PIN GPIO_PIN_14
#define RST_PORT GPIOF

void MVCD_delay_us (uint16_t us)
{
	__HAL_TIM_SET_COUNTER(&htim1,0);  // set the counter value a 0
	while (__HAL_TIM_GET_COUNTER(&htim1) < us);  // wait for the counter to reach the us input in the parameter
}

void MVCD_SendByte_SPI(uint8_t byte)
{
	for(int i=0;i<8;i++)
	{
		if((byte<<i)&0x80)
			{
				HAL_GPIO_WritePin(SID_PORT, SID_PIN, GPIO_PIN_SET);  // SID=1  OR MOSI
			}

		else HAL_GPIO_WritePin(SID_PORT, SID_PIN, GPIO_PIN_RESET);  // SID=0

		HAL_GPIO_WritePin(SCLK_PORT, SCLK_PIN, GPIO_PIN_RESET);  // SCLK =0  OR SCK

		HAL_GPIO_WritePin(SCLK_PORT, SCLK_PIN, GPIO_PIN_SET);  // SCLK=1

	}
}

void MVCD_ST7920_Send (uint8_t data, int modflag) //modflag - (data 1), (cmd 0)
{

	HAL_GPIO_WritePin(CS_PORT, CS_PIN, GPIO_PIN_SET);  // PUll the CS high

	MVCD_SendByte_SPI(0xf8+(modflag<<1));  // send the SYNC + RS(1)
	MVCD_SendByte_SPI(data&0xf0);  // send the higher nibble first
	MVCD_SendByte_SPI((data<<4)&0xf0);  // send the lower nibble
	MVCD_delay_us(10);
	HAL_GPIO_WritePin(CS_PORT, CS_PIN, GPIO_PIN_RESET);  // PUll the CS LOW
}

void MVCD_ST7920_baseinit(){
	HAL_GPIO_WritePin(RST_PORT, RST_PIN, GPIO_PIN_RESET);  // RESET=0
	HAL_Delay(10);   // wait for 10ms
	HAL_GPIO_WritePin(RST_PORT, RST_PIN, GPIO_PIN_SET);  // RESET=1

	HAL_Delay(50);   //wait for >40 ms


	MVCD_ST7920_Send(0x30,CMD);  // 8bit mode
	MVCD_delay_us(110);  //  >100us delay

	MVCD_ST7920_Send(0x30,CMD);  // 8bit mode
	MVCD_delay_us(40);  // >37us delay

	MVCD_ST7920_Send(0x08,CMD);  // D=0, C=0, B=0
	MVCD_delay_us(110);  // >100us delay

	MVCD_ST7920_Send(0x01,CMD);  // clear screen
	HAL_Delay(12);  // >10 ms delay


	MVCD_ST7920_Send(0x06,CMD);  // cursor increment right no shift
	HAL_Delay(1);  // 1ms delay

	MVCD_ST7920_Send(0x0C,CMD);  // D=1, C=0, B=0
    HAL_Delay(1);  // 1ms delay

    MVCD_ST7920_Send(0x02,CMD);  // return to home
	HAL_Delay(1);  // 1ms delay
	HAL_Delay(2);
}

void MVCD_ST7920_GraphicMode (_Bool enable)   // 1-enable, 0-disable
{
	if (enable == ON)
	{
		MVCD_ST7920_Send(0x30,CMD);  // 8 bit mode
		HAL_Delay (1);
		MVCD_ST7920_Send(0x34,CMD);  // switch to Extended instructions
		HAL_Delay (1);
		MVCD_ST7920_Send(0x36,CMD);  // enable graphics
		HAL_Delay (1);
	}

	else if (enable == OFF)
	{
		MVCD_ST7920_Send(0x30,CMD);  // 8 bit mode
		HAL_Delay (1);
	}
}


void MVCD_dot_xy(int x,int y){
    int flx = (int)floor(x/16);
    prv_val[flx][y] |= (0x8000 >> x%16);
    MVCD_ST7920_Send(0x36, CMD);
    MVCD_ST7920_Send(0x80+(y % 32), CMD);
    MVCD_ST7920_Send(0x80+ (y / 32) * 8 + floor(x/16), CMD);

    MVCD_ST7920_Send(0x30, CMD);
    MVCD_ST7920_Send(((prv_val[flx][y] &0xff00)>>8), DATA);
    MVCD_ST7920_Send(prv_val[flx][y]&0xff, DATA);
}

void MVCD_LCDclear(){
    for(int j=0;j<8;j++){
        for(int i=0;i<64;i++){
        	MVCD_ST7920_Send(0x36, CMD);
        	MVCD_ST7920_Send(0x80+(i%32), CMD);
        	MVCD_ST7920_Send(0x80+((i/32)*8+j), CMD);
        	MVCD_ST7920_Send(0x30, CMD);
        	MVCD_ST7920_Send(0x00, DATA);
        	MVCD_ST7920_Send(0x00, DATA);
        	prv_val[j][i] = 0;
        }
    }

}

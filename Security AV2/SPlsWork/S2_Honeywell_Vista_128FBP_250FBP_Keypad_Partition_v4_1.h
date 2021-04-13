#ifndef __S2_HONEYWELL_VISTA_128FBP_250FBP_KEYPAD_PARTITION_V4_1_H__
#define __S2_HONEYWELL_VISTA_128FBP_250FBP_KEYPAD_PARTITION_V4_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_REFRESH_DIG_INPUT 0
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_SEND_KEYS_DIG_INPUT 1

#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_KEY_DIG_INPUT 2
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_KEY_ARRAY_LENGTH 15

/*
* ANALOG_INPUT
*/

#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_PARTITION_STRING_INPUT 0
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_PARTITION_STRING_MAX_LEN 1
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __PARTITION, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_PARTITION_STRING_MAX_LEN );

#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_FROM_MODULE$_BUFFER_INPUT 1
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_FROM_MODULE$_BUFFER_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __FROM_MODULE$, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_FROM_MODULE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_BACK_LIGHT_FB_DIG_OUTPUT 0


/*
* ANALOG_OUTPUT
*/
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_LED_STATUS_ANALOG_OUTPUT 1
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_BACK_LIGHT_MODE_ANALOG_OUTPUT 2

#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_TO_QUEUE$_STRING_OUTPUT 0
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_TEXT_LINE_1$_STRING_OUTPUT 3
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_TEXT_LINE_2$_STRING_OUTPUT 4


/*
* Direct Socket Variables
*/




/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* INTEGER_PARAMETER
*/
/*
* SIGNED_INTEGER_PARAMETER
*/
/*
* LONG_INTEGER_PARAMETER
*/
/*
* SIGNED_LONG_INTEGER_PARAMETER
*/
/*
* STRING_PARAMETER
*/


/*
* INTEGER
*/


/*
* LONG_INTEGER
*/


/*
* SIGNED_INTEGER
*/


/*
* SIGNED_LONG_INTEGER
*/


/*
* STRING
*/
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_STEMP_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __STEMP, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_STEMP_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_SKEYS_STRING_MAX_LEN 5
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __SKEYS, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_SKEYS_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_STEMP1_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __STEMP1, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_STEMP1_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_SRESPONSE_STRING_MAX_LEN 4
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __SRESPONSE, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_SRESPONSE_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_SPARTITION_STRING_MAX_LEN 1
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __SPARTITION, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_SPARTITION_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_STEXT1$_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __STEXT1$, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_STEXT1$_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_STEXT2$_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __STEXT2$, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_STEXT2$_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_SMODULERXMSG_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __SMODULERXMSG, __S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1_SMODULERXMSG_STRING_MAX_LEN );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __KEY );
   unsigned short __ITEMP;
   unsigned short __IBACKLIGHT;
   unsigned short __ILED;
   unsigned short __ITEMPKEY;
   unsigned short __IREFRESH;
   unsigned short __ICOMPORTRXSEMAPHORE;
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __STEMP );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __SKEYS );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __STEMP1 );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __SRESPONSE );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __SPARTITION );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __STEXT1$ );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __STEXT2$ );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __SMODULERXMSG );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __PARTITION );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1, __FROM_MODULE$ );
};

START_NVRAM_VAR_STRUCT( S2_Honeywell_Vista_128FBP_250FBP_Keypad_Partition_v4_1 )
{
};



#endif //__S2_HONEYWELL_VISTA_128FBP_250FBP_KEYPAD_PARTITION_V4_1_H__


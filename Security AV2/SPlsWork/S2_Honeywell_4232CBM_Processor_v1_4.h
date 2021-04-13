#ifndef __S2_HONEYWELL_4232CBM_PROCESSOR_V1_4_H__
#define __S2_HONEYWELL_4232CBM_PROCESSOR_V1_4_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Honeywell_4232CBM_Processor_v1_4_INITIALIZE_DIG_INPUT 0
#define __S2_Honeywell_4232CBM_Processor_v1_4_ENABLE_DEBUGGING_DIG_INPUT 1

#define __S2_Honeywell_4232CBM_Processor_v1_4_KEY_DIG_INPUT 2
#define __S2_Honeywell_4232CBM_Processor_v1_4_KEY_ARRAY_LENGTH 20

/*
* ANALOG_INPUT
*/
#define __S2_Honeywell_4232CBM_Processor_v1_4_SYSTEM_TYPE_ANALOG_INPUT 0


#define __S2_Honeywell_4232CBM_Processor_v1_4_FROM_DEVICE_BUFFER_INPUT 1
#define __S2_Honeywell_4232CBM_Processor_v1_4_FROM_DEVICE_BUFFER_MAX_LEN 1000
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __FROM_DEVICE, __S2_Honeywell_4232CBM_Processor_v1_4_FROM_DEVICE_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Honeywell_4232CBM_Processor_v1_4_BACK_LIGHT_ON_DIG_OUTPUT 0
#define __S2_Honeywell_4232CBM_Processor_v1_4_RECEIVING_DATA_DIG_OUTPUT 1


/*
* ANALOG_OUTPUT
*/
#define __S2_Honeywell_4232CBM_Processor_v1_4_L1_VALUE_ANALOG_OUTPUT 0
#define __S2_Honeywell_4232CBM_Processor_v1_4_L2_VALUE_ANALOG_OUTPUT 1
#define __S2_Honeywell_4232CBM_Processor_v1_4_L3_VALUE_ANALOG_OUTPUT 2

#define __S2_Honeywell_4232CBM_Processor_v1_4_LINE_1_TEXT_STRING_OUTPUT 3
#define __S2_Honeywell_4232CBM_Processor_v1_4_LINE_2_TEXT_STRING_OUTPUT 4
#define __S2_Honeywell_4232CBM_Processor_v1_4_TO_DEVICE_STRING_OUTPUT 5


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
#define __S2_Honeywell_4232CBM_Processor_v1_4_SKEYPRESSES_STRING_MAX_LEN 5
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SKEYPRESSES, __S2_Honeywell_4232CBM_Processor_v1_4_SKEYPRESSES_STRING_MAX_LEN );
#define __S2_Honeywell_4232CBM_Processor_v1_4_SESPCOMMAND_STRING_MAX_LEN 25
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SESPCOMMAND, __S2_Honeywell_4232CBM_Processor_v1_4_SESPCOMMAND_STRING_MAX_LEN );
#define __S2_Honeywell_4232CBM_Processor_v1_4_SCOMMAND_STRING_MAX_LEN 100
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SCOMMAND, __S2_Honeywell_4232CBM_Processor_v1_4_SCOMMAND_STRING_MAX_LEN );
#define __S2_Honeywell_4232CBM_Processor_v1_4_STEMP_STRING_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __STEMP, __S2_Honeywell_4232CBM_Processor_v1_4_STEMP_STRING_MAX_LEN );
#define __S2_Honeywell_4232CBM_Processor_v1_4_SADDRESS_STRING_MAX_LEN 2
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SADDRESS, __S2_Honeywell_4232CBM_Processor_v1_4_SADDRESS_STRING_MAX_LEN );
#define __S2_Honeywell_4232CBM_Processor_v1_4_SLINE1TEXT_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SLINE1TEXT, __S2_Honeywell_4232CBM_Processor_v1_4_SLINE1TEXT_STRING_MAX_LEN );
#define __S2_Honeywell_4232CBM_Processor_v1_4_STEMPLINE1TEXT_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __STEMPLINE1TEXT, __S2_Honeywell_4232CBM_Processor_v1_4_STEMPLINE1TEXT_STRING_MAX_LEN );
#define __S2_Honeywell_4232CBM_Processor_v1_4_SLINE2TEXT_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SLINE2TEXT, __S2_Honeywell_4232CBM_Processor_v1_4_SLINE2TEXT_STRING_MAX_LEN );
#define __S2_Honeywell_4232CBM_Processor_v1_4_STEMPLINE2TEXT_STRING_MAX_LEN 16
CREATE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __STEMPLINE2TEXT, __S2_Honeywell_4232CBM_Processor_v1_4_STEMPLINE2TEXT_STRING_MAX_LEN );
#define __S2_Honeywell_4232CBM_Processor_v1_4_SINITCOMMAND_ARRAY_NUM_ELEMS 4
#define __S2_Honeywell_4232CBM_Processor_v1_4_SINITCOMMAND_ARRAY_NUM_CHARS 25
CREATE_STRING_ARRAY( S2_Honeywell_4232CBM_Processor_v1_4, __SINITCOMMAND, __S2_Honeywell_4232CBM_Processor_v1_4_SINITCOMMAND_ARRAY_NUM_ELEMS, __S2_Honeywell_4232CBM_Processor_v1_4_SINITCOMMAND_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __KEY );
   unsigned short __IKEY;
   unsigned short __IINITSENT;
   unsigned short __IBACKLIGHT;
   unsigned short __IJUNK;
   unsigned short __ILENGTH;
   unsigned short __ICHECKSUM;
   unsigned short __A;
   unsigned short __SYSTEMTYPE;
   unsigned short __INITCOMMANDSCOUNT;
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SKEYPRESSES );
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SESPCOMMAND );
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SCOMMAND );
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __STEMP );
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SADDRESS );
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SLINE1TEXT );
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __STEMPLINE1TEXT );
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __SLINE2TEXT );
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __STEMPLINE2TEXT );
   DECLARE_STRING_ARRAY( S2_Honeywell_4232CBM_Processor_v1_4, __SINITCOMMAND );
   DECLARE_STRING_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4, __FROM_DEVICE );
};

START_NVRAM_VAR_STRUCT( S2_Honeywell_4232CBM_Processor_v1_4 )
{
};

DEFINE_WAITEVENT( S2_Honeywell_4232CBM_Processor_v1_4, WRECEIVINGDATATIMEOUT );
DEFINE_WAITEVENT( S2_Honeywell_4232CBM_Processor_v1_4, WSENDDELAY );
DEFINE_WAITEVENT( S2_Honeywell_4232CBM_Processor_v1_4, WINITDELAY );


#endif //__S2_HONEYWELL_4232CBM_PROCESSOR_V1_4_H__


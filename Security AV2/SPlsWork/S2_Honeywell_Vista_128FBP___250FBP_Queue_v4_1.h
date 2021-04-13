#ifndef __S2_HONEYWELL_VISTA_128FBP___250FBP_QUEUE_V4_1_H__
#define __S2_HONEYWELL_VISTA_128FBP___250FBP_QUEUE_V4_1_H__




/*
* Constructor and Destructor
*/

/*
* DIGITAL_INPUT
*/
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_POLL_DIG_INPUT 0
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_SEND_NEXT_IN_DIG_INPUT 1
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_RECEIVING_DIG_INPUT 2
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_REFRESH_DIG_INPUT 3

#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_POLL_PARTITION_DIG_INPUT 4
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_POLL_PARTITION_ARRAY_LENGTH 8

/*
* ANALOG_INPUT
*/


#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_FROM_MODULE$_BUFFER_INPUT 0
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_FROM_MODULE$_BUFFER_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __FROM_MODULE$, __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_FROM_MODULE$_BUFFER_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_FROM_DEVICE$_BUFFER_INPUT 1
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_FROM_DEVICE$_BUFFER_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __FROM_DEVICE$, __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_FROM_DEVICE$_BUFFER_MAX_LEN );


/*
* DIGITAL_OUTPUT
*/
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_SEND_NEXT_OUT_DIG_OUTPUT 0
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_COMMUNICATION_ON_FB_DIG_OUTPUT 1
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_COMMUNICATION_OFF_FB_DIG_OUTPUT 2
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_NO_KEYPAD_UPDATES_FB_DIG_OUTPUT 3


/*
* ANALOG_OUTPUT
*/

#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_TO_DEVICE$_STRING_OUTPUT 0

#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_TO_PARTITION$_STRING_OUTPUT 1
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_TO_PARTITION$_ARRAY_LENGTH 8

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
CREATE_INTARRAY1D( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __IPOLLPARTITIONS, 8 );;


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
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_STEMP1_STRING_MAX_LEN 250
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __STEMP1, __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_STEMP1_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_STEMP3_STRING_MAX_LEN 15
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __STEMP3, __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_STEMP3_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_SMODULERXMSG_STRING_MAX_LEN 50
CREATE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __SMODULERXMSG, __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_SMODULERXMSG_STRING_MAX_LEN );
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_SQUEUE_ARRAY_NUM_ELEMS 100
#define __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_SQUEUE_ARRAY_NUM_CHARS 25
CREATE_STRING_ARRAY( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __SQUEUE, __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_SQUEUE_ARRAY_NUM_ELEMS, __S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1_SQUEUE_ARRAY_NUM_CHARS );

/*
* STRUCTURE
*/

START_GLOBAL_VAR_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1 )
{
   void* InstancePtr;
   struct GenericOutputString_s sGenericOutStr;
   unsigned short LastModifiedArrayIndex;

   DECLARE_IO_ARRAY( __POLL_PARTITION );
   DECLARE_IO_ARRAY( __TO_PARTITION$ );
   unsigned short __IPARTITIONSENT;
   unsigned short __INEXTSTORE;
   unsigned short __INEXTSEND;
   unsigned short __INEXTPOLL;
   unsigned short __ISENDOK;
   unsigned short __ITEMP;
   unsigned short __IFLAG1;
   unsigned short __IFLAG2;
   unsigned short __A;
   unsigned short __B;
   unsigned short __C;
   unsigned short __PITEMP;
   DECLARE_INTARRAY( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __IPOLLPARTITIONS );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __STEMP1 );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __STEMP3 );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __SMODULERXMSG );
   DECLARE_STRING_ARRAY( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __SQUEUE );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __FROM_MODULE$ );
   DECLARE_STRING_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, __FROM_DEVICE$ );
};

START_NVRAM_VAR_STRUCT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1 )
{
};

DEFINE_WAITEVENT( S2_Honeywell_Vista_128FBP___250FBP_Queue_v4_1, WTIMEOUT );


#endif //__S2_HONEYWELL_VISTA_128FBP___250FBP_QUEUE_V4_1_H__


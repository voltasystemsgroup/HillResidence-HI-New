using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Linq;
using Crestron;
using Crestron.Logos.SplusLibrary;
using Crestron.Logos.SplusObjects;
using Crestron.SimplSharp;

namespace UserModule_KALEIDESCAPE_OSD_PROCESSOR_V8_4_0
{
    public class UserModuleClass_KALEIDESCAPE_OSD_PROCESSOR_V8_4_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private CrestronString GETLIBRARYVERSION (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 61;
            return ( "2.1" ) ; 
            
            }
            
        private ushort ISUPPERLETTER (  SplusExecutionContext __context__, ushort CHARACTER ) 
            { 
            
            __context__.SourceCodeLine = 67;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHARACTER >= 65 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHARACTER <= 90 ) )) )) ; 
            
            }
            
        private ushort ISLOWERLETTER (  SplusExecutionContext __context__, ushort CHARACTER ) 
            { 
            
            __context__.SourceCodeLine = 73;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHARACTER >= 97 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHARACTER <= 122 ) )) )) ; 
            
            }
            
        private ushort ISLETTER (  SplusExecutionContext __context__, ushort CHARACTER ) 
            { 
            
            __context__.SourceCodeLine = 79;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( ISUPPERLETTER( __context__ , (ushort)( CHARACTER ) ) ) || Functions.TestForTrue ( ISLOWERLETTER( __context__ , (ushort)( CHARACTER ) ) )) )) ; 
            
            }
            
        private ushort ISDIGIT (  SplusExecutionContext __context__, ushort CHARACTER ) 
            { 
            
            __context__.SourceCodeLine = 85;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHARACTER >= 48 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHARACTER <= 57 ) )) )) ; 
            
            }
            
        private ushort ISHEX (  SplusExecutionContext __context__, ushort CHARACTER ) 
            { 
            
            __context__.SourceCodeLine = 91;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( ISDIGIT( __context__ , (ushort)( CHARACTER ) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( CHARACTER >= 65 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( CHARACTER <= 70 ) )) ) )) )) ; 
            
            }
            
        private ushort ISSEQUENCE (  SplusExecutionContext __context__, ushort CHARACTER ) 
            { 
            
            __context__.SourceCodeLine = 97;
            return (ushort)( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( ISDIGIT( __context__ , (ushort)( CHARACTER ) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHARACTER == 33) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (CHARACTER == 63) )) )) ; 
            
            }
            
        private ushort TOUPPER (  SplusExecutionContext __context__, ushort CHARACTER ) 
            { 
            
            __context__.SourceCodeLine = 103;
            if ( Functions.TestForTrue  ( ( ISLOWERLETTER( __context__ , (ushort)( CHARACTER ) ))  ) ) 
                {
                __context__.SourceCodeLine = 103;
                return (ushort)( ((CHARACTER + 65) - 97)) ; 
                }
            
            __context__.SourceCodeLine = 104;
            return (ushort)( CHARACTER) ; 
            
            }
            
        private ushort TOLOWER (  SplusExecutionContext __context__, ushort CHARACTER ) 
            { 
            
            __context__.SourceCodeLine = 110;
            if ( Functions.TestForTrue  ( ( ISUPPERLETTER( __context__ , (ushort)( CHARACTER ) ))  ) ) 
                {
                __context__.SourceCodeLine = 110;
                return (ushort)( ((CHARACTER + 97) - 65)) ; 
                }
            
            __context__.SourceCodeLine = 111;
            return (ushort)( CHARACTER) ; 
            
            }
            
        private CrestronString SHAVERIGHTCHARACTER (  SplusExecutionContext __context__, CrestronString INPUTSTRING , ushort NUMTOREMOVE ) 
            { 
            
            __context__.SourceCodeLine = 117;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( INPUTSTRING ) > NUMTOREMOVE ))  ) ) 
                {
                __context__.SourceCodeLine = 117;
                return ( Functions.Left ( INPUTSTRING ,  (int) ( (Functions.Length( INPUTSTRING ) - NUMTOREMOVE) ) ) ) ; 
                }
            
            __context__.SourceCodeLine = 118;
            return ( "" ) ; 
            
            }
            
        private CrestronString GETSYMBOLINSTANCEUMC (  SplusExecutionContext __context__ ) 
            { 
            CrestronString UMC;
            UMC  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 125;
            UMC  .UpdateValue ( GetSymbolInstanceName ( )  ) ; 
            __context__.SourceCodeLine = 126;
            if ( Functions.TestForTrue  ( ( Functions.Find( ":" , UMC ))  ) ) 
                {
                __context__.SourceCodeLine = 127;
                UMC  .UpdateValue ( Functions.Left ( UMC ,  (int) ( (Functions.Find( ":" , UMC ) - 1) ) )  ) ; 
                }
            
            __context__.SourceCodeLine = 128;
            return ( UMC ) ; 
            
            }
            
        private CrestronString TOTITLECAPS (  SplusExecutionContext __context__, CrestronString INPUTSTRING ) 
            { 
            ushort LOOP = 0;
            
            ushort CHARACTER = 0;
            
            ushort INWORD = 0;
            
            CrestronString OUTPUTSTRING;
            OUTPUTSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            
            __context__.SourceCodeLine = 139;
            INWORD = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 141;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( INPUTSTRING ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( LOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (LOOP  >= __FN_FORSTART_VAL__1) && (LOOP  <= __FN_FOREND_VAL__1) ) : ( (LOOP  <= __FN_FORSTART_VAL__1) && (LOOP  >= __FN_FOREND_VAL__1) ) ; LOOP  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 143;
                CHARACTER = (ushort) ( Byte( INPUTSTRING , (int)( LOOP ) ) ) ; 
                __context__.SourceCodeLine = 144;
                if ( Functions.TestForTrue  ( ( ISLETTER( __context__ , (ushort)( CHARACTER ) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 146;
                    if ( Functions.TestForTrue  ( ( INWORD)  ) ) 
                        { 
                        __context__.SourceCodeLine = 149;
                        OUTPUTSTRING  .UpdateValue ( OUTPUTSTRING + Functions.Chr (  (int) ( TOLOWER( __context__ , (ushort)( CHARACTER ) ) ) )  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 154;
                        OUTPUTSTRING  .UpdateValue ( OUTPUTSTRING + Functions.Chr (  (int) ( TOUPPER( __context__ , (ushort)( CHARACTER ) ) ) )  ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 156;
                    INWORD = (ushort) ( 1 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 160;
                    OUTPUTSTRING  .UpdateValue ( OUTPUTSTRING + Functions.Chr (  (int) ( CHARACTER ) )  ) ; 
                    __context__.SourceCodeLine = 161;
                    INWORD = (ushort) ( 0 ) ; 
                    } 
                
                __context__.SourceCodeLine = 141;
                } 
            
            __context__.SourceCodeLine = 164;
            return ( OUTPUTSTRING ) ; 
            
            }
            
        private CrestronString APPENDTITLECAPS (  SplusExecutionContext __context__, CrestronString INPUTSTRING , CrestronString APPENDSTRING ) 
            { 
            ushort STRINGLENGTH = 0;
            
            CrestronString OUTPUTSTRING;
            OUTPUTSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            
            __context__.SourceCodeLine = 173;
            STRINGLENGTH = (ushort) ( Functions.Length( INPUTSTRING ) ) ; 
            __context__.SourceCodeLine = 176;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( STRINGLENGTH > 0 ) ) && Functions.TestForTrue ( ISLETTER( __context__ , (ushort)( Byte( INPUTSTRING , (int)( STRINGLENGTH ) ) ) ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 178;
                OUTPUTSTRING  .UpdateValue ( INPUTSTRING + Functions.Lower ( APPENDSTRING )  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 182;
                OUTPUTSTRING  .UpdateValue ( INPUTSTRING + Functions.Upper ( APPENDSTRING )  ) ; 
                } 
            
            __context__.SourceCodeLine = 185;
            return ( OUTPUTSTRING ) ; 
            
            }
            
        private CrestronString ESCAPE (  SplusExecutionContext __context__, CrestronString INPUTSTRING ) 
            { 
            ushort LOOP = 0;
            
            ushort CHARACTER = 0;
            
            CrestronString OUTPUTSTRING;
            OUTPUTSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            
            __context__.SourceCodeLine = 195;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)Functions.Length( INPUTSTRING ); 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( LOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (LOOP  >= __FN_FORSTART_VAL__1) && (LOOP  <= __FN_FOREND_VAL__1) ) : ( (LOOP  <= __FN_FORSTART_VAL__1) && (LOOP  >= __FN_FOREND_VAL__1) ) ; LOOP  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 197;
                CHARACTER = (ushort) ( Byte( INPUTSTRING , (int)( LOOP ) ) ) ; 
                __context__.SourceCodeLine = 198;
                switch ((int)CHARACTER)
                
                    { 
                    case 58 : 
                    case 47 : 
                    case 92 : 
                    
                        {
                        __context__.SourceCodeLine = 203;
                        OUTPUTSTRING  .UpdateValue ( OUTPUTSTRING + Functions.Chr (  (int) ( 92 ) )  ) ; 
                        }
                    
                    goto default;
                    default : 
                    
                        {
                        __context__.SourceCodeLine = 204;
                        OUTPUTSTRING  .UpdateValue ( OUTPUTSTRING + Functions.Chr (  (int) ( CHARACTER ) )  ) ; 
                        }
                    break;
                    
                    } 
                    
                
                __context__.SourceCodeLine = 195;
                } 
            
            __context__.SourceCodeLine = 207;
            return ( OUTPUTSTRING ) ; 
            
            }
            
        private CrestronString SUBSTITUTE (  SplusExecutionContext __context__, CrestronString INPUTSTRING , ushort CHARACTERTOREPLACE , CrestronString REPLACEMENTSTRING ) 
            { 
            ushort LOOP = 0;
            
            ushort CHARACTER = 0;
            
            ushort INPUTLENGTH = 0;
            
            ushort REPLACEMENTLENGTH = 0;
            
            ushort OUTPUTPOSITION = 0;
            
            CrestronString OUTPUTSTRING;
            OUTPUTSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            
            __context__.SourceCodeLine = 221;
            OUTPUTSTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 222;
            INPUTLENGTH = (ushort) ( Functions.Length( INPUTSTRING ) ) ; 
            __context__.SourceCodeLine = 223;
            REPLACEMENTLENGTH = (ushort) ( Functions.Length( REPLACEMENTSTRING ) ) ; 
            __context__.SourceCodeLine = 224;
            OUTPUTPOSITION = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 225;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)INPUTLENGTH; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( LOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (LOOP  >= __FN_FORSTART_VAL__1) && (LOOP  <= __FN_FOREND_VAL__1) ) : ( (LOOP  <= __FN_FORSTART_VAL__1) && (LOOP  >= __FN_FOREND_VAL__1) ) ; LOOP  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 227;
                CHARACTER = (ushort) ( Byte( INPUTSTRING , (int)( LOOP ) ) ) ; 
                __context__.SourceCodeLine = 228;
                
                    {
                    int __SPLS_TMPVAR__SWTCH_1__ = ((int)CHARACTER);
                    
                        { 
                        if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_1__ == ( CHARACTERTOREPLACE) ) ) ) 
                            { 
                            __context__.SourceCodeLine = 232;
                            SetString ( REPLACEMENTSTRING , (int)OUTPUTPOSITION, OUTPUTSTRING ) ; 
                            __context__.SourceCodeLine = 233;
                            OUTPUTPOSITION = (ushort) ( (OUTPUTPOSITION + REPLACEMENTLENGTH) ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 237;
                            SetString ( Functions.Chr (  (int) ( CHARACTER ) ) , (int)OUTPUTPOSITION, OUTPUTSTRING ) ; 
                            __context__.SourceCodeLine = 238;
                            OUTPUTPOSITION = (ushort) ( (OUTPUTPOSITION + 1) ) ; 
                            } 
                        
                        } 
                        
                    }
                    
                
                __context__.SourceCodeLine = 225;
                } 
            
            __context__.SourceCodeLine = 242;
            return ( OUTPUTSTRING ) ; 
            
            }
            
        private CrestronString NULLTOSPACE (  SplusExecutionContext __context__, CrestronString INPUTSTRING ) 
            { 
            
            __context__.SourceCodeLine = 248;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (INPUTSTRING != ""))  ) ) 
                {
                __context__.SourceCodeLine = 248;
                return ( INPUTSTRING ) ; 
                }
            
            __context__.SourceCodeLine = 249;
            return ( " " ) ; 
            
            }
            
        private CrestronString PROCESSNAT (  SplusExecutionContext __context__, CrestronString GIVENURL , CrestronString HOSTIP ) 
            { 
            CrestronString URI;
            URI  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 500, this );
            
            CrestronString HOST;
            HOST  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            CrestronString JUNK;
            JUNK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
            
            
            __context__.SourceCodeLine = 259;
            URI  .UpdateValue ( GIVENURL  ) ; 
            __context__.SourceCodeLine = 261;
            JUNK  .UpdateValue ( Functions.Remove ( "//" , URI , 1)  ) ; 
            __context__.SourceCodeLine = 262;
            HOST  .UpdateValue ( Functions.Remove ( "/" , URI , 1)  ) ; 
            __context__.SourceCodeLine = 264;
            URI  .UpdateValue ( "http://" + HOSTIP + "/" + URI  ) ; 
            __context__.SourceCodeLine = 266;
            return ( URI ) ; 
            
            }
            
        private CrestronString ITOLABEL (  SplusExecutionContext __context__, ushort INT , CrestronString LABEL ) 
            { 
            CrestronString RESULT;
            RESULT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 274;
            
                {
                int __SPLS_TMPVAR__SWTCH_2__ = ((int)INT);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 278;
                        RESULT  .UpdateValue ( ""  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_2__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 282;
                        MakeString ( RESULT , "{0:d} {1}", (short)INT, LABEL ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 286;
                        MakeString ( RESULT , "{0:d} {1}s", (short)INT, LABEL ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 289;
            return ( RESULT ) ; 
            
            }
            
        private CrestronString MAKETIMESTRING (  SplusExecutionContext __context__, ushort HOURS , ushort MINUTES ) 
            { 
            CrestronString RESULT;
            RESULT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 42, this );
            
            CrestronString HOURSTR;
            HOURSTR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            CrestronString MINUTESTR;
            MINUTESTR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
            
            
            __context__.SourceCodeLine = 299;
            HOURSTR  .UpdateValue ( ITOLABEL (  __context__ , (ushort)( HOURS ), "hour")  ) ; 
            __context__.SourceCodeLine = 300;
            MINUTESTR  .UpdateValue ( ITOLABEL (  __context__ , (ushort)( MINUTES ), "minute")  ) ; 
            __context__.SourceCodeLine = 302;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( HOURS > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( MINUTES > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 304;
                RESULT  .UpdateValue ( HOURSTR + " " + MINUTESTR  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 308;
                RESULT  .UpdateValue ( HOURSTR + MINUTESTR  ) ; 
                } 
            
            __context__.SourceCodeLine = 311;
            return ( RESULT ) ; 
            
            }
            
        
        
        
        
        
        
        
        
        private void PRINTMESSAGEERROR (  SplusExecutionContext __context__, CrestronString MESSAGE , ushort ERRORCODE ) 
            { 
            CrestronString INSTANCENAME;
            INSTANCENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 335;
            INSTANCENAME  .UpdateValue ( GETSYMBOLINSTANCEUMC (  __context__  )  ) ; 
            __context__.SourceCodeLine = 337;
            
                {
                int __SPLS_TMPVAR__SWTCH_3__ = ((int)ERRORCODE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 0) ) ) ) 
                        {
                        __context__.SourceCodeLine = 340;
                        return ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 1) ) ) ) 
                        {
                        __context__.SourceCodeLine = 343;
                        Trace( "Kaleidescape ({0}):  Response too short.\r\n  message is: {1}\r\n", INSTANCENAME , MESSAGE ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 346;
                        Trace( "Kaleidescape ({0}):  Received garbled message.\r\n    message is: {1}\r\n", INSTANCENAME , MESSAGE ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 350;
                        Trace( "Kaleidescape ({0}):  Serial Number device IDs are not supported.  Ignoring Address: {1}\r\n", INSTANCENAME , Functions.Left ( MESSAGE ,  (int) ( 13 ) ) ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 354;
                        Trace( "Kaleidescape ({0}):  Bad checksum.\r\n", INSTANCENAME ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 357;
                        Trace( "Kaleidescape ({0}): Ignoring message with zone ID {1}\r\n", INSTANCENAME , MESSAGE ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 360;
                        Trace( "Kaleidescape ({0}): Ignoring message with address {1}\r\n", INSTANCENAME , MESSAGE ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_3__ == ( 7) ) ) ) 
                        {
                        __context__.SourceCodeLine = 363;
                        Trace( "Kaleidescape ({0}): Ignoring message with sequence {1}\r\n", INSTANCENAME , MESSAGE ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 366;
                        Trace( "Kaleidescape ({0}):  Unknown parsing error {1:d}", INSTANCENAME , (short)ERRORCODE) ; 
                        }
                    
                    } 
                    
                }
                
            
            
            }
            
        private ushort MESSAGETARGETERROR (  SplusExecutionContext __context__, ushort MESSAGEDEVICEID , ushort MESSAGEZONEID , ushort MESSAGESEQUENCE , ushort TARGETDEVICEID , ushort TARGETZONEID , ushort TARGETSEQUENCE , ushort DIRECTCONNECT , ushort DEBUG ) 
            { 
            
            __context__.SourceCodeLine = 380;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MESSAGEDEVICEID != TARGETDEVICEID))  ) ) 
                { 
                __context__.SourceCodeLine = 382;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (DIRECTCONNECT == 0) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (DIRECTCONNECT == 1) ) && Functions.TestForTrue ( Functions.BoolToInt (MESSAGEDEVICEID != 1) )) ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 384;
                    if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 384;
                        PRINTMESSAGEERROR (  __context__ , Functions.ItoA( (int)( MESSAGEDEVICEID ) ), (ushort)( 5 )) ; 
                        }
                    
                    __context__.SourceCodeLine = 386;
                    return (ushort)( 5) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 390;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (MESSAGEZONEID != TARGETZONEID) ) && Functions.TestForTrue ( Functions.BoolToInt ( MESSAGEZONEID > 0 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 392;
                if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 392;
                    PRINTMESSAGEERROR (  __context__ , Functions.ItoA( (int)( MESSAGEZONEID ) ), (ushort)( 6 )) ; 
                    }
                
                __context__.SourceCodeLine = 394;
                return (ushort)( 6) ; 
                } 
            
            __context__.SourceCodeLine = 397;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (MESSAGESEQUENCE != 33) ) && Functions.TestForTrue ( Functions.BoolToInt (MESSAGESEQUENCE != 63) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 399;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ((MESSAGESEQUENCE - 48) != TARGETSEQUENCE))  ) ) 
                    { 
                    __context__.SourceCodeLine = 401;
                    if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                        { 
                        __context__.SourceCodeLine = 403;
                        PRINTMESSAGEERROR (  __context__ , Functions.Chr( (int)( MESSAGESEQUENCE ) ), (ushort)( 7 )) ; 
                        } 
                    
                    __context__.SourceCodeLine = 406;
                    return (ushort)( 7) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 410;
            return (ushort)( 0) ; 
            
            }
            
        private ushort ISTARGETMESSAGE (  SplusExecutionContext __context__, ushort MESSAGEDEVICEID , ushort MESSAGEZONEID , ushort MESSAGESEQUENCE , ushort TARGETDEVICEID , ushort TARGETZONEID , ushort TARGETSEQUENCE , ushort DIRECTCONNECT , ushort DEBUG ) 
            { 
            
            __context__.SourceCodeLine = 421;
            return (ushort)( Functions.Not( MESSAGETARGETERROR( __context__ , (ushort)( MESSAGEDEVICEID ) , (ushort)( MESSAGEZONEID ) , (ushort)( MESSAGESEQUENCE ) , (ushort)( TARGETDEVICEID ) , (ushort)( TARGETZONEID ) , (ushort)( TARGETSEQUENCE ) , (ushort)( DIRECTCONNECT ) , (ushort)( DEBUG ) ) )) ; 
            
            }
            
        private ushort MESSAGEERROR (  SplusExecutionContext __context__, CrestronString MESSAGE , ref ushort MESSAGEDEVICEID , ref ushort MESSAGEZONEID , ref ushort MESSAGESEQUENCE , ushort MESSAGEEND ) 
            { 
            ushort CALCULATEDCHECKSUM = 0;
            
            ushort RESPONSECHECKSUM = 0;
            
            ushort INDEX = 0;
            
            ushort SEGMENTDELIMITER = 0;
            
            
            __context__.SourceCodeLine = 445;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MESSAGEEND < 9 ))  ) ) 
                { 
                __context__.SourceCodeLine = 447;
                return (ushort)( 1) ; 
                } 
            
            __context__.SourceCodeLine = 454;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 1 ) ) == 35) ) && Functions.TestForTrue ( Functions.BoolToInt ( MESSAGEEND < 22 ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 456;
                return (ushort)( 1) ; 
                } 
            
            __context__.SourceCodeLine = 463;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( MESSAGE , (int)( MESSAGEEND ) ) == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 465;
                SEGMENTDELIMITER = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 469;
                SEGMENTDELIMITER = (ushort) ( 47 ) ; 
                } 
            
            __context__.SourceCodeLine = 474;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 1 ) ) == 35) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 14 ) ) == 46) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 476;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 2 ) ) ) ) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 3 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 4 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 5 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 6 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 7 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 8 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 9 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 10 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 11 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 12 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 13 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISDIGIT( __context__ , (ushort)( Byte( MESSAGE , (int)( 15 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISDIGIT( __context__ , (ushort)( Byte( MESSAGE , (int)( 16 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 17 ) ) != SEGMENTDELIMITER) )) ) ) || Functions.TestForTrue ( Functions.Not( ISSEQUENCE( __context__ , (ushort)( Byte( MESSAGE , (int)( 18 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 19 ) ) != SEGMENTDELIMITER) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 494;
                    return (ushort)( 2) ; 
                    } 
                
                __context__.SourceCodeLine = 497;
                MESSAGEDEVICEID = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 498;
                MESSAGEZONEID = (ushort) ( Functions.Atoi( Functions.Mid( MESSAGE , (int)( 15 ) , (int)( 2 ) ) ) ) ; 
                __context__.SourceCodeLine = 501;
                return (ushort)( 3) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 504;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( MESSAGE , (int)( 1 ) ) == 35))  ) ) 
                    { 
                    __context__.SourceCodeLine = 506;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 2 ) ) ) ) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 3 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 4 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 5 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 6 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 7 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 8 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 9 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 10 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 11 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 12 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISHEX( __context__ , (ushort)( Byte( MESSAGE , (int)( 13 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 14 ) ) != SEGMENTDELIMITER) )) ) ) || Functions.TestForTrue ( Functions.Not( ISSEQUENCE( __context__ , (ushort)( Byte( MESSAGE , (int)( 15 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 16 ) ) != SEGMENTDELIMITER) )) ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 522;
                        return (ushort)( 2) ; 
                        } 
                    
                    __context__.SourceCodeLine = 525;
                    MESSAGEDEVICEID = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 526;
                    MESSAGEZONEID = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 529;
                    return (ushort)( 3) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 532;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( MESSAGE , (int)( 3 ) ) == 46))  ) ) 
                        { 
                        __context__.SourceCodeLine = 534;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( ISDIGIT( __context__ , (ushort)( Byte( MESSAGE , (int)( 1 ) ) ) ) ) ) || Functions.TestForTrue ( Functions.Not( ISDIGIT( __context__ , (ushort)( Byte( MESSAGE , (int)( 2 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISDIGIT( __context__ , (ushort)( Byte( MESSAGE , (int)( 4 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.Not( ISDIGIT( __context__ , (ushort)( Byte( MESSAGE , (int)( 5 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 6 ) ) != SEGMENTDELIMITER) )) ) ) || Functions.TestForTrue ( Functions.Not( ISSEQUENCE( __context__ , (ushort)( Byte( MESSAGE , (int)( 7 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 8 ) ) != SEGMENTDELIMITER) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 542;
                            return (ushort)( 2) ; 
                            } 
                        
                        __context__.SourceCodeLine = 545;
                        MESSAGEDEVICEID = (ushort) ( Functions.Atoi( Functions.Left( MESSAGE , (int)( 2 ) ) ) ) ; 
                        __context__.SourceCodeLine = 546;
                        MESSAGEZONEID = (ushort) ( Functions.Atoi( Functions.Mid( MESSAGE , (int)( 4 ) , (int)( 2 ) ) ) ) ; 
                        __context__.SourceCodeLine = 547;
                        MESSAGESEQUENCE = (ushort) ( Byte( MESSAGE , (int)( 7 ) ) ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 552;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( ISDIGIT( __context__ , (ushort)( Byte( MESSAGE , (int)( 1 ) ) ) ) ) ) || Functions.TestForTrue ( Functions.Not( ISDIGIT( __context__ , (ushort)( Byte( MESSAGE , (int)( 2 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 3 ) ) != SEGMENTDELIMITER) )) ) ) || Functions.TestForTrue ( Functions.Not( ISSEQUENCE( __context__ , (ushort)( Byte( MESSAGE , (int)( 4 ) ) ) ) ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 5 ) ) != SEGMENTDELIMITER) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 558;
                            return (ushort)( 2) ; 
                            } 
                        
                        __context__.SourceCodeLine = 560;
                        MESSAGEDEVICEID = (ushort) ( Functions.Atoi( Functions.Left( MESSAGE , (int)( 2 ) ) ) ) ; 
                        __context__.SourceCodeLine = 561;
                        MESSAGESEQUENCE = (ushort) ( Byte( MESSAGE , (int)( 4 ) ) ) ; 
                        __context__.SourceCodeLine = 562;
                        MESSAGEZONEID = (ushort) ( 0 ) ; 
                        } 
                    
                    }
                
                }
            
            __context__.SourceCodeLine = 565;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (SEGMENTDELIMITER == 47))  ) ) 
                { 
                __context__.SourceCodeLine = 567;
                CALCULATEDCHECKSUM = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 568;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)(MESSAGEEND - 2); 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( INDEX  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (INDEX  >= __FN_FORSTART_VAL__1) && (INDEX  <= __FN_FOREND_VAL__1) ) : ( (INDEX  <= __FN_FORSTART_VAL__1) && (INDEX  >= __FN_FOREND_VAL__1) ) ; INDEX  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 570;
                    CALCULATEDCHECKSUM = (ushort) ( Mod( (CALCULATEDCHECKSUM + Byte( MESSAGE , (int)( INDEX ) )) , 100 ) ) ; 
                    __context__.SourceCodeLine = 568;
                    } 
                
                __context__.SourceCodeLine = 573;
                RESPONSECHECKSUM = (ushort) ( Functions.Atoi( Functions.Right( MESSAGE , (int)( ((Functions.Length( MESSAGE ) - MESSAGEEND) + 2) ) ) ) ) ; 
                __context__.SourceCodeLine = 574;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CALCULATEDCHECKSUM != RESPONSECHECKSUM))  ) ) 
                    { 
                    __context__.SourceCodeLine = 576;
                    return (ushort)( 4) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 579;
            return (ushort)( 0) ; 
            
            }
            
        private ushort CHECKMESSAGE (  SplusExecutionContext __context__, CrestronString MESSAGE , ushort DEVICEID , ushort DEVICEZONEID , ushort SEQUENCESENT , ushort MESSAGEEND , ushort DIRECTCONNECT , ushort DEBUG ) 
            { 
            ushort MESSAGEDEVICEID = 0;
            
            ushort MESSAGEZONEID = 0;
            
            ushort MESSAGESEQUENCE = 0;
            
            ushort MESSAGEERRORCODE = 0;
            
            
            __context__.SourceCodeLine = 590;
            MESSAGEERRORCODE = (ushort) ( MESSAGEERROR( __context__ , MESSAGE , ref MESSAGEDEVICEID , ref MESSAGEZONEID , ref MESSAGESEQUENCE , (ushort)( MESSAGEEND ) ) ) ; 
            __context__.SourceCodeLine = 591;
            if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 591;
                PRINTMESSAGEERROR (  __context__ , MESSAGE, (ushort)( MESSAGEERRORCODE )) ; 
                }
            
            __context__.SourceCodeLine = 593;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MESSAGEERRORCODE == 0))  ) ) 
                {
                __context__.SourceCodeLine = 594;
                return (ushort)( MESSAGETARGETERROR( __context__ , (ushort)( MESSAGEDEVICEID ) , (ushort)( MESSAGEZONEID ) , (ushort)( MESSAGESEQUENCE ) , (ushort)( DEVICEID ) , (ushort)( DEVICEZONEID ) , (ushort)( SEQUENCESENT ) , (ushort)( DIRECTCONNECT ) , (ushort)( DEBUG ) )) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 598;
                return (ushort)( MESSAGEERRORCODE) ; 
                }
            
            
            return 0; // default return value (none specified in module)
            }
            
        private ushort VALIDATEMESSAGE (  SplusExecutionContext __context__, CrestronString MESSAGE , ref ushort MESSAGEDEVICEID , ref ushort MESSAGEZONEID , ref ushort MESSAGESEQUENCE , ushort MESSAGEEND , ushort PLAYERID , ushort DEBUG ) 
            { 
            ushort ERRORCODE = 0;
            
            
            __context__.SourceCodeLine = 627;
            ERRORCODE = (ushort) ( MESSAGEERROR( __context__ , MESSAGE , ref MESSAGEDEVICEID , ref MESSAGEZONEID , ref MESSAGESEQUENCE , (ushort)( MESSAGEEND ) ) ) ; 
            __context__.SourceCodeLine = 629;
            if ( Functions.TestForTrue  ( ( Functions.Not( ERRORCODE ))  ) ) 
                {
                __context__.SourceCodeLine = 629;
                return (ushort)( 1) ; 
                }
            
            __context__.SourceCodeLine = 631;
            if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 631;
                PRINTMESSAGEERROR (  __context__ , MESSAGE, (ushort)( ERRORCODE )) ; 
                }
            
            __context__.SourceCodeLine = 632;
            return (ushort)( 0) ; 
            
            }
            
        private ushort ISVALIDMESSAGE (  SplusExecutionContext __context__, CrestronString MESSAGE , ushort DEVICEID , ushort DEVICEZONEID , ushort SEQUENCESENT , ushort MESSAGEEND , ushort PLAYERID , ushort DIRECTCONNECT , ushort DEBUG ) 
            { 
            ushort MESSAGEDEVICEID = 0;
            
            ushort MESSAGEZONEID = 0;
            
            ushort MESSAGESEQUENCE = 0;
            
            
            __context__.SourceCodeLine = 644;
            if ( Functions.TestForTrue  ( ( VALIDATEMESSAGE( __context__ , MESSAGE , ref MESSAGEDEVICEID , ref MESSAGEZONEID , ref MESSAGESEQUENCE , (ushort)( MESSAGEEND ) , (ushort)( PLAYERID ) , (ushort)( DEBUG ) ))  ) ) 
                { 
                __context__.SourceCodeLine = 647;
                return (ushort)( ISTARGETMESSAGE( __context__ , (ushort)( MESSAGEDEVICEID ) , (ushort)( MESSAGEZONEID ) , (ushort)( MESSAGESEQUENCE ) , (ushort)( DEVICEID ) , (ushort)( DEVICEZONEID ) , (ushort)( SEQUENCESENT ) , (ushort)( DIRECTCONNECT ) , (ushort)( DEBUG ) )) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 653;
                return (ushort)( 0) ; 
                } 
            
            
            return 0; // default return value (none specified in module)
            }
            
        private void GETNARGUMENTSPRINTABLE (  SplusExecutionContext __context__, CrestronString [] ARGUMENTS , ref ushort NUMARGS , ushort NEWTOTALARGS , CrestronString MESSAGE , ref ushort MESSAGEPOSITION , ref ushort MESSAGEEND ) 
            { 
            ushort CHARACTER = 0;
            
            ushort ESCAPED = 0;
            
            ushort ARGUMENTLENGTH = 0;
            
            
            __context__.SourceCodeLine = 667;
            ESCAPED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 668;
            ARGUMENTLENGTH = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 670;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( MESSAGEPOSITION <= MESSAGEEND ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NUMARGS < NEWTOTALARGS ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 673;
                CHARACTER = (ushort) ( Byte( MESSAGE , (int)( MESSAGEPOSITION ) ) ) ; 
                __context__.SourceCodeLine = 674;
                MESSAGEPOSITION = (ushort) ( (MESSAGEPOSITION + 1) ) ; 
                __context__.SourceCodeLine = 676;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ESCAPED == 1))  ) ) 
                    { 
                    __context__.SourceCodeLine = 679;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_4__ = ((int)CHARACTER);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 100) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 684;
                                CHARACTER = (ushort) ( ((Byte( MESSAGE , (int)( MESSAGEPOSITION ) ) - 48) * 100) ) ; 
                                __context__.SourceCodeLine = 685;
                                CHARACTER = (ushort) ( (CHARACTER + ((Byte( MESSAGE , (int)( (MESSAGEPOSITION + 1) ) ) - 48) * 10)) ) ; 
                                __context__.SourceCodeLine = 686;
                                CHARACTER = (ushort) ( (CHARACTER + (Byte( MESSAGE , (int)( (MESSAGEPOSITION + 2) ) ) - 48)) ) ; 
                                __context__.SourceCodeLine = 687;
                                MESSAGEPOSITION = (ushort) ( (MESSAGEPOSITION + 3) ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 116) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 691;
                                CHARACTER = (ushort) ( 9 ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 110) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 695;
                                CHARACTER = (ushort) ( 10 ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_4__ == ( 114) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 699;
                                CHARACTER = (ushort) ( 13 ) ; 
                                } 
                            
                            else 
                                { 
                                } 
                            
                            } 
                            
                        }
                        
                    
                    __context__.SourceCodeLine = 706;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGUMENTLENGTH == 0))  ) ) 
                        {
                        __context__.SourceCodeLine = 706;
                        ARGUMENTS [ NUMARGS]  .UpdateValue ( ""  ) ; 
                        }
                    
                    __context__.SourceCodeLine = 709;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ARGUMENTLENGTH < 200 ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 711;
                        SetString ( Functions.Chr (  (int) ( CHARACTER ) ) , (int)(ARGUMENTLENGTH + 1), ARGUMENTS [ NUMARGS] ) ; 
                        __context__.SourceCodeLine = 712;
                        ARGUMENTLENGTH = (ushort) ( (ARGUMENTLENGTH + 1) ) ; 
                        } 
                    
                    __context__.SourceCodeLine = 716;
                    ESCAPED = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 720;
                    
                        {
                        int __SPLS_TMPVAR__SWTCH_5__ = ((int)CHARACTER);
                        
                            { 
                            if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 92) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 724;
                                ESCAPED = (ushort) ( 1 ) ; 
                                } 
                            
                            else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_5__ == ( 58) ) ) ) 
                                { 
                                __context__.SourceCodeLine = 728;
                                NUMARGS = (ushort) ( (NUMARGS + 1) ) ; 
                                __context__.SourceCodeLine = 729;
                                ARGUMENTLENGTH = (ushort) ( 0 ) ; 
                                } 
                            
                            else 
                                { 
                                __context__.SourceCodeLine = 733;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGUMENTLENGTH == 0))  ) ) 
                                    {
                                    __context__.SourceCodeLine = 733;
                                    ARGUMENTS [ NUMARGS]  .UpdateValue ( ""  ) ; 
                                    }
                                
                                __context__.SourceCodeLine = 736;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ARGUMENTLENGTH < 200 ))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 738;
                                    SetString ( Functions.Chr (  (int) ( CHARACTER ) ) , (int)(ARGUMENTLENGTH + 1), ARGUMENTS [ NUMARGS] ) ; 
                                    __context__.SourceCodeLine = 739;
                                    ARGUMENTLENGTH = (ushort) ( (ARGUMENTLENGTH + 1) ) ; 
                                    } 
                                
                                } 
                            
                            } 
                            
                        }
                        
                    
                    } 
                
                __context__.SourceCodeLine = 670;
                } 
            
            
            }
            
        private void GETNARGUMENTSBINARY (  SplusExecutionContext __context__, CrestronString [] ARGUMENTS , ref ushort NUMARGS , ushort NEWTOTALARGS , CrestronString MESSAGE , ref ushort MESSAGEPOSITION , ref ushort MESSAGEEND ) 
            { 
            ushort DELIMITERPOSITION = 0;
            
            ushort ARGLENGTH = 0;
            
            
            __context__.SourceCodeLine = 756;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( MESSAGEPOSITION <= MESSAGEEND ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NUMARGS < NEWTOTALARGS ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 758;
                DELIMITERPOSITION = (ushort) ( Functions.Find( "\u0002" , MESSAGE , MESSAGEPOSITION ) ) ; 
                __context__.SourceCodeLine = 761;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DELIMITERPOSITION == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 763;
                    MESSAGEPOSITION = (ushort) ( (MESSAGEEND + 1) ) ; 
                    __context__.SourceCodeLine = 764;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 767;
                ARGLENGTH = (ushort) ( (DELIMITERPOSITION - MESSAGEPOSITION) ) ; 
                __context__.SourceCodeLine = 768;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( ARGLENGTH >= 200 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 768;
                    ARGLENGTH = (ushort) ( 200 ) ; 
                    }
                
                __context__.SourceCodeLine = 770;
                ARGUMENTS [ NUMARGS]  .UpdateValue ( Functions.Mid ( MESSAGE ,  (int) ( MESSAGEPOSITION ) ,  (int) ( ARGLENGTH ) )  ) ; 
                __context__.SourceCodeLine = 772;
                NUMARGS = (ushort) ( (NUMARGS + 1) ) ; 
                __context__.SourceCodeLine = 773;
                MESSAGEPOSITION = (ushort) ( (DELIMITERPOSITION + 1) ) ; 
                __context__.SourceCodeLine = 756;
                } 
            
            
            }
            
        private void GETNARGUMENTS (  SplusExecutionContext __context__, CrestronString [] ARGUMENTS , ref ushort NUMARGS , ushort NEWTOTALARGS , CrestronString MESSAGE , ref ushort MESSAGEPOSITION , ref ushort MESSAGEEND ) 
            { 
            ushort LOOP = 0;
            
            
            __context__.SourceCodeLine = 783;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( MESSAGE , (int)( MESSAGEEND ) ) == 2))  ) ) 
                { 
                __context__.SourceCodeLine = 785;
                GETNARGUMENTSBINARY (  __context__ , ARGUMENTS,   ref  NUMARGS , (ushort)( NEWTOTALARGS ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 789;
                GETNARGUMENTSPRINTABLE (  __context__ , ARGUMENTS,   ref  NUMARGS , (ushort)( NEWTOTALARGS ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                } 
            
            __context__.SourceCodeLine = 792;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NUMARGS < NEWTOTALARGS ))  ) ) 
                { 
                __context__.SourceCodeLine = 795;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( NUMARGS ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)NEWTOTALARGS; 
                int __FN_FORSTEP_VAL__1 = (int)1; 
                for ( LOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (LOOP  >= __FN_FORSTART_VAL__1) && (LOOP  <= __FN_FOREND_VAL__1) ) : ( (LOOP  <= __FN_FORSTART_VAL__1) && (LOOP  >= __FN_FOREND_VAL__1) ) ; LOOP  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 797;
                    ARGUMENTS [ LOOP]  .UpdateValue ( ""  ) ; 
                    __context__.SourceCodeLine = 795;
                    } 
                
                } 
            
            
            }
            
        private void PRINTPLAYERERROR (  SplusExecutionContext __context__, ushort ERRORCODE , CrestronString DETAILS , ushort PLAYERID ) 
            { 
            CrestronString DESCRIPTION;
            DESCRIPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            CrestronString INSTANCENAME;
            INSTANCENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 808;
            INSTANCENAME  .UpdateValue ( GETSYMBOLINSTANCEUMC (  __context__  )  ) ; 
            __context__.SourceCodeLine = 810;
            
                {
                int __SPLS_TMPVAR__SWTCH_6__ = ((int)ERRORCODE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 813;
                        DESCRIPTION  .UpdateValue ( "Message too long"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 817;
                        DESCRIPTION  .UpdateValue ( "Message contains invalid character"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 821;
                        DESCRIPTION  .UpdateValue ( "Checksum error"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 825;
                        DESCRIPTION  .UpdateValue ( "Invalid device or device is offline"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 829;
                        DESCRIPTION  .UpdateValue ( "Device unavailable"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 10) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 833;
                        DESCRIPTION  .UpdateValue ( "Invalid request"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 11) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 837;
                        DESCRIPTION  .UpdateValue ( "Invalid number of parameters"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 12) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 841;
                        DESCRIPTION  .UpdateValue ( "Invalid parameter"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 13) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 845;
                        DESCRIPTION  .UpdateValue ( "Device identifier conflict"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 14) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 849;
                        DESCRIPTION  .UpdateValue ( "Invalid sequence number"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 15) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 853;
                        DESCRIPTION  .UpdateValue ( "Disallowed due to parental control"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 16) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 857;
                        DESCRIPTION  .UpdateValue ( "Invalid passcode"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 17) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 861;
                        DESCRIPTION  .UpdateValue ( "Invalid content handle"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 20) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 865;
                        DESCRIPTION  .UpdateValue ( "Command not processed"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_6__ == ( 999) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 869;
                        DESCRIPTION  .UpdateValue ( "Undetermined error"  ) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 873;
                        DESCRIPTION  .UpdateValue ( "Unknown error."  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 878;
            Trace( "Kaleidescape ({0}):  K device responded with error {1:d3} ({2})  {3}\r\n", INSTANCENAME , (short)ERRORCODE, DESCRIPTION , DETAILS ) ; 
            
            }
            
        private ushort CHECKDEVICETYPE (  SplusExecutionContext __context__, ushort DEVICETYPE , ushort PLAYERID ) 
            { 
            CrestronString TYPETEXT;
            TYPETEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
            
            CrestronString UMCNAME;
            UMCNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 888;
            
                {
                int __SPLS_TMPVAR__SWTCH_7__ = ((int)DEVICETYPE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 891;
                        TYPETEXT  .UpdateValue ( "a Server"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 896;
                        TYPETEXT  .UpdateValue ( "a Player"  ) ; 
                        __context__.SourceCodeLine = 897;
                        return (ushort)( 1) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 902;
                        TYPETEXT  .UpdateValue ( "a Bulk Loader"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 907;
                        TYPETEXT  .UpdateValue ( "a DVD Reader"  ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 7) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 912;
                        TYPETEXT  .UpdateValue ( ""  ) ; 
                        __context__.SourceCodeLine = 913;
                        return (ushort)( 1) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_7__ == ( 8) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 918;
                        TYPETEXT  .UpdateValue ( "a Music Player"  ) ; 
                        __context__.SourceCodeLine = 919;
                        return (ushort)( 1) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 924;
                        TYPETEXT  .UpdateValue ( "an unknown device"  ) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 929;
            UMCNAME  .UpdateValue ( GETSYMBOLINSTANCEUMC (  __context__  )  ) ; 
            __context__.SourceCodeLine = 930;
            Trace( "\r\nKaleidescape ({0}) is controlling {1}, not a Player.\r\n", UMCNAME , TYPETEXT ) ; 
            __context__.SourceCodeLine = 931;
            Trace( "The Kaleidescape module only controls a Kaleidescape player.\r\n\r\n") ; 
            __context__.SourceCodeLine = 932;
            return (ushort)( 0) ; 
            
            }
            
        private void REFACTORCONNECTIONSETTINGS (  SplusExecutionContext __context__, ushort STATEDPLAYERID , CrestronString PLAYERSN , ref ushort PLAYERID , CrestronString CONNECTEDDEVICESN , ushort CONNECTEDDEVICEID , ref ushort DIRECTCONNECT , ushort DEBUG ) 
            { 
            CrestronString UMCNAME;
            UMCNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 940;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PLAYERSN == CONNECTEDDEVICESN))  ) ) 
                { 
                __context__.SourceCodeLine = 942;
                DIRECTCONNECT = (ushort) ( 1 ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 946;
                DIRECTCONNECT = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 950;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATEDPLAYERID == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 953;
                PLAYERID = (ushort) ( CONNECTEDDEVICEID ) ; 
                __context__.SourceCodeLine = 954;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PLAYERID == 0))  ) ) 
                    {
                    __context__.SourceCodeLine = 954;
                    PLAYERID = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 955;
                DIRECTCONNECT = (ushort) ( 1 ) ; 
                } 
            
            __context__.SourceCodeLine = 962;
            if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                { 
                __context__.SourceCodeLine = 964;
                UMCNAME  .UpdateValue ( GETSYMBOLINSTANCEUMC (  __context__  )  ) ; 
                __context__.SourceCodeLine = 965;
                Trace( "K module {0} refactored interface.\r\n", UMCNAME ) ; 
                __context__.SourceCodeLine = 966;
                Trace( "          Player SN = {0}\r\n", PLAYERSN ) ; 
                __context__.SourceCodeLine = 967;
                Trace( "Connected Device SN = {0}\r\n", CONNECTEDDEVICESN ) ; 
                __context__.SourceCodeLine = 968;
                Trace( "Direct connect = {0:d}\r\n\r\n", (short)DIRECTCONNECT) ; 
                __context__.SourceCodeLine = 969;
                Trace( "Stated ID = {0:d}, Connected ID = {1:d}, Player ID = {2:d}.\r\n\r\n", (ushort)STATEDPLAYERID, (ushort)CONNECTEDDEVICEID, (ushort)PLAYERID) ; 
                } 
            
            
            }
            
        private ushort VALIDATEDEVICE (  SplusExecutionContext __context__, CrestronString MODULENAME , ushort CPDID , CrestronString DEVICENAME , ushort NUMVIDZONES , ushort NUMAUDZONES , ushort MYZONE ) 
            { 
            CrestronString ERRORTEXT;
            ERRORTEXT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
            
            CrestronString INSTANCENAME;
            INSTANCENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 981;
            INSTANCENAME  .UpdateValue ( GETSYMBOLINSTANCEUMC (  __context__  )  ) ; 
            __context__.SourceCodeLine = 982;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (DEVICENAME == ""))  ) ) 
                {
                __context__.SourceCodeLine = 982;
                DEVICENAME  .UpdateValue ( "device"  ) ; 
                }
            
            __context__.SourceCodeLine = 984;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MYZONE > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 986;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( MYZONE <= NUMAUDZONES ))  ) ) 
                    {
                    __context__.SourceCodeLine = 987;
                    return (ushort)( 1) ; 
                    }
                
                __context__.SourceCodeLine = 989;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NUMAUDZONES == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 991;
                    MakeString ( ERRORTEXT , "Kaleidescape ({0}) Config ERROR! {1} is set to control CPDID {2:d2}, zone {3:d2}; a {4} with no audio zones.", INSTANCENAME , MODULENAME , (short)CPDID, (short)MYZONE, DEVICENAME ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 995;
                    MakeString ( ERRORTEXT , "Kaleidescape ({0}) Config ERROR! {1} is set to control CPDID {2:d2}, zone {3:d2}; a {4} with only {5:d} audio zone(s).", INSTANCENAME , MODULENAME , (short)CPDID, (short)MYZONE, DEVICENAME , (short)NUMAUDZONES) ; 
                    } 
                
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1000;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NUMVIDZONES > 0 ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1001;
                    return (ushort)( 1) ; 
                    }
                
                __context__.SourceCodeLine = 1003;
                MakeString ( ERRORTEXT , "Kaleidescape ({0}) Config ERROR! {1} is set to control CPDID {2:d2}; a {3} which has no video zones.", INSTANCENAME , MODULENAME , (short)CPDID, DEVICENAME ) ; 
                } 
            
            __context__.SourceCodeLine = 1006;
            GenerateUserError ( "{0}", ERRORTEXT ) ; 
            __context__.SourceCodeLine = 1007;
            Trace( "\r\n\r\n{0}\r\n\r\n", ERRORTEXT ) ; 
            __context__.SourceCodeLine = 1009;
            return (ushort)( 0) ; 
            
            }
            
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        private ushort CONNECTIONHANDLER (  SplusExecutionContext __context__, ushort STATEEVENT , ref ushort STATE , ref CrestronString [] COMMANDS , ref ushort COMMANDCOUNT , ref ushort POWERSTATE , ref ushort POWERSTATESTATUS , ref CrestronString MODULEDESCRIPTION , ushort DIRECTCONNECTION , ushort DEBUG ) 
            { 
            ushort NEWSTATE = 0;
            
            ushort OLDSTATE = 0;
            
            
            __context__.SourceCodeLine = 1072;
            OLDSTATE = (ushort) ( STATE ) ; 
            __context__.SourceCodeLine = 1073;
            NEWSTATE = (ushort) ( 999 ) ; 
            __context__.SourceCodeLine = 1075;
            if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1075;
                Trace( "connectionHandler called with state event {0:d}.  State={1:d}, Power state={2:d}\r\n", (short)STATEEVENT, (short)STATE, (short)POWERSTATE) ; 
                }
            
            __context__.SourceCodeLine = 1076;
            
                {
                int __SPLS_TMPVAR__SWTCH_8__ = ((int)STATEEVENT);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1082;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE >= 2 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1083;
                            return (ushort)( 0) ; 
                            }
                        
                        __context__.SourceCodeLine = 1085;
                        NEWSTATE = (ushort) ( 2 ) ; 
                        __context__.SourceCodeLine = 1087;
                        if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 1087;
                            Trace( "ConnectionHandler - Connection step 2\r\n") ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 105) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1094;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE == 1))  ) ) 
                            {
                            __context__.SourceCodeLine = 1095;
                            NEWSTATE = (ushort) ( 1 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 1098;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STATE != 999) ) && Functions.TestForTrue ( Functions.BoolToInt ( STATE >= 4 ) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (POWERSTATE == 254) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1100;
                            MakeString ( COMMANDS [ 1] , "GET_DEVICE_POWER_STATE:") ; 
                            __context__.SourceCodeLine = 1101;
                            COMMANDCOUNT = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 1102;
                            return (ushort)( 1) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 100) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1109;
                        NEWSTATE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 101) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1115;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE < 1 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1116;
                            NEWSTATE = (ushort) ( 1 ) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 102) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1121;
                        NEWSTATE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 16) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1126;
                        NEWSTATE = (ushort) ( 2 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 10) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1133;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE < 3 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1134;
                            NEWSTATE = (ushort) ( 3 ) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1140;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE < 4 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1141;
                            NEWSTATE = (ushort) ( 4 ) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 14) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1146;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE < 4 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1147;
                            NEWSTATE = (ushort) ( 4 ) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1153;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE < 5 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1154;
                            NEWSTATE = (ushort) ( 5 ) ; 
                            }
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1156;
                            POWERSTATE = (ushort) ( 1 ) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1161;
                        POWERSTATE = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 1163;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE != 4))  ) ) 
                            {
                            __context__.SourceCodeLine = 1164;
                            NEWSTATE = (ushort) ( 4 ) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1170;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE < 6 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1171;
                            NEWSTATE = (ushort) ( 6 ) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 11) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1176;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE < 2 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1178;
                            NEWSTATE = (ushort) ( 2 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 1180;
                        if ( Functions.TestForTrue  ( ( DIRECTCONNECTION)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1182;
                            POWERSTATE = (ushort) ( 0 ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 12) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1189;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE < 2 ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1191;
                            NEWSTATE = (ushort) ( 2 ) ; 
                            } 
                        
                        __context__.SourceCodeLine = 1193;
                        if ( Functions.TestForTrue  ( ( DIRECTCONNECTION)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1195;
                            POWERSTATE = (ushort) ( 1 ) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 103) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1202;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE > 1 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1203;
                            NEWSTATE = (ushort) ( 1 ) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 13) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1209;
                        if ( Functions.TestForTrue  ( ( DIRECTCONNECTION)  ) ) 
                            { 
                            __context__.SourceCodeLine = 1211;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE != 4))  ) ) 
                                {
                                __context__.SourceCodeLine = 1212;
                                NEWSTATE = (ushort) ( 4 ) ; 
                                }
                            
                            __context__.SourceCodeLine = 1214;
                            POWERSTATE = (ushort) ( 0 ) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1218;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE != 2))  ) ) 
                                {
                                __context__.SourceCodeLine = 1219;
                                NEWSTATE = (ushort) ( 2 ) ; 
                                }
                            
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 15) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1226;
                        if ( Functions.TestForTrue  ( ( Functions.Not( DIRECTCONNECTION ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1228;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE != 3))  ) ) 
                                {
                                __context__.SourceCodeLine = 1229;
                                NEWSTATE = (ushort) ( 3 ) ; 
                                }
                            
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( (1000 + 004)) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1237;
                        if ( Functions.TestForTrue  ( ( Functions.Not( DIRECTCONNECTION ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1239;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE != 3))  ) ) 
                                {
                                __context__.SourceCodeLine = 1240;
                                NEWSTATE = (ushort) ( 3 ) ; 
                                }
                            
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( (1000 + 020)) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1247;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( STATE > 4 ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1248;
                            NEWSTATE = (ushort) ( 4 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 1250;
                        POWERSTATE = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 106) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1255;
                        MakeString ( COMMANDS [ 5] , "\r\n") ; 
                        __context__.SourceCodeLine = 1256;
                        return (ushort)( 2) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 104) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1261;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATE == 4))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1263;
                            MakeString ( COMMANDS [ 1] , "SEND_TO_SYSLOG:INFORMATION:{0}:", ESCAPE (  __context__ , MODULEDESCRIPTION) ) ; 
                            __context__.SourceCodeLine = 1264;
                            COMMANDCOUNT = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 1265;
                            return (ushort)( 1) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 1267;
                            return (ushort)( 0) ; 
                            }
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 107) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1272;
                        POWERSTATESTATUS = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 1275;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POWERSTATE == 0))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1277;
                            POWERSTATE = (ushort) ( 254 ) ; 
                            __context__.SourceCodeLine = 1278;
                            COMMANDCOUNT = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 1279;
                            return (ushort)( 1) ; 
                            } 
                        
                        __context__.SourceCodeLine = 1283;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (POWERSTATE == 254) ) && Functions.TestForTrue ( Functions.BoolToInt ( STATE >= 5 ) )) ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1285;
                            POWERSTATE = (ushort) ( 1 ) ; 
                            __context__.SourceCodeLine = 1286;
                            COMMANDCOUNT = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 1287;
                            return (ushort)( 1) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 108) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1294;
                        POWERSTATESTATUS = (ushort) ( 0 ) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_8__ == ( 109) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1299;
                        POWERSTATESTATUS = (ushort) ( 0 ) ; 
                        __context__.SourceCodeLine = 1302;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (POWERSTATE == 1))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1304;
                            POWERSTATE = (ushort) ( 254 ) ; 
                            __context__.SourceCodeLine = 1305;
                            COMMANDCOUNT = (ushort) ( 0 ) ; 
                            __context__.SourceCodeLine = 1306;
                            return (ushort)( 1) ; 
                            } 
                        
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 1312;
                        if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 1312;
                            Trace( "Kaleidescape connectionHandler unknown event: {0:d}\r\n", (short)STATEEVENT) ; 
                            }
                        
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 1316;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (NEWSTATE != 999))  ) ) 
                { 
                __context__.SourceCodeLine = 1319;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( NEWSTATE > STATE ))  ) ) 
                    {
                    __context__.SourceCodeLine = 1319;
                    NEWSTATE = (ushort) ( (STATE + 1) ) ; 
                    }
                
                __context__.SourceCodeLine = 1320;
                STATE = (ushort) ( NEWSTATE ) ; 
                } 
            
            __context__.SourceCodeLine = 1324;
            
                {
                int __SPLS_TMPVAR__SWTCH_9__ = ((int)NEWSTATE);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 0) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1328;
                        POWERSTATE = (ushort) ( 254 ) ; 
                        __context__.SourceCodeLine = 1329;
                        return (ushort)( 4) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 1) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1333;
                        POWERSTATE = (ushort) ( 254 ) ; 
                        __context__.SourceCodeLine = 1334;
                        MakeString ( COMMANDS [ 5] , "01/0/GET_DEVICE_POWER_STATE:\r\n") ; 
                        __context__.SourceCodeLine = 1335;
                        return (ushort)( 2) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 2) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1339;
                        if ( Functions.TestForTrue  ( ( Functions.Not( DIRECTCONNECTION ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1340;
                            POWERSTATE = (ushort) ( 254 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 1342;
                        MakeString ( COMMANDS [ 5] , "01/0/GET_DEVICE_INFO:\r\n") ; 
                        __context__.SourceCodeLine = 1343;
                        return (ushort)( 2) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 3) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1347;
                        if ( Functions.TestForTrue  ( ( Functions.Not( DIRECTCONNECTION ))  ) ) 
                            {
                            __context__.SourceCodeLine = 1348;
                            POWERSTATE = (ushort) ( 254 ) ; 
                            }
                        
                        __context__.SourceCodeLine = 1350;
                        MakeString ( COMMANDS [ 1] , "GET_DEVICE_INFO:") ; 
                        __context__.SourceCodeLine = 1351;
                        COMMANDCOUNT = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 1352;
                        return (ushort)( 5) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 4) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1356;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( OLDSTATE < NEWSTATE ))  ) ) 
                            { 
                            __context__.SourceCodeLine = 1358;
                            MakeString ( COMMANDS [ 1] , "SEND_TO_SYSLOG:INFORMATION:{0}:", ESCAPE (  __context__ , MODULEDESCRIPTION) ) ; 
                            __context__.SourceCodeLine = 1359;
                            MakeString ( COMMANDS [ 2] , "GET_DEVICE_POWER_STATE:") ; 
                            __context__.SourceCodeLine = 1360;
                            COMMANDCOUNT = (ushort) ( 2 ) ; 
                            __context__.SourceCodeLine = 1361;
                            return (ushort)( 1) ; 
                            } 
                        
                        else 
                            { 
                            __context__.SourceCodeLine = 1366;
                            return (ushort)( 6) ; 
                            } 
                        
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 5) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1371;
                        POWERSTATE = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 1372;
                        MakeString ( COMMANDS [ 1] , "GET_DEVICE_TYPE_NAME:") ; 
                        __context__.SourceCodeLine = 1373;
                        MakeString ( COMMANDS [ 2] , "GET_NUM_ZONES:") ; 
                        __context__.SourceCodeLine = 1374;
                        COMMANDCOUNT = (ushort) ( 2 ) ; 
                        __context__.SourceCodeLine = 1375;
                        return (ushort)( 1) ; 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_9__ == ( 6) ) ) ) 
                        { 
                        __context__.SourceCodeLine = 1379;
                        return (ushort)( 3) ; 
                        } 
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 1384;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( POWERSTATESTATUS ) && Functions.TestForTrue ( Functions.BoolToInt (POWERSTATE == 0) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1386;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (STATE == 4) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( DIRECTCONNECTION ) && Functions.TestForTrue ( Functions.BoolToInt ( STATE >= 2 ) )) ) )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1389;
                    MakeString ( COMMANDS [ 1] , "LEAVE_STANDBY:") ; 
                    __context__.SourceCodeLine = 1390;
                    COMMANDCOUNT = (ushort) ( 1 ) ; 
                    __context__.SourceCodeLine = 1392;
                    return (ushort)( 1) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 1396;
            return (ushort)( 0) ; 
            
            }
            
        private ushort PARSE010MESSAGEEVENT (  SplusExecutionContext __context__, CrestronString MESSAGE , ushort MESSAGEEND , ushort PLAYERID , ushort DIRECTCONNECT , ref CrestronString CONNECTEDDEVICESN , ref ushort CONNECTEDDEVICEID , ushort DEBUG ) 
            { 
            ushort NUMARGS = 0;
            
            ushort MESSAGEPOSITION = 0;
            
            CrestronString [] ARGS;
            ARGS  = new CrestronString[ 16 ];
            for( uint i = 0; i < 16; i++ )
                ARGS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
            
            CrestronString UMCNAME;
            UMCNAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
            
            
            __context__.SourceCodeLine = 1407;
            if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1407;
                UMCNAME  .UpdateValue ( GETSYMBOLINSTANCEUMC (  __context__  )  ) ; 
                }
            
            __context__.SourceCodeLine = 1408;
            if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1408;
                Trace( "Kaleidescape ({0}) Parsing 01/0 message\r\n", UMCNAME ) ; 
                }
            
            __context__.SourceCodeLine = 1411;
            if ( Functions.TestForTrue  ( ( Functions.Not( ISVALIDMESSAGE( __context__ , MESSAGE , (ushort)( 1 ) , (ushort)( 0 ) , (ushort)( 0 ) , (ushort)( MESSAGEEND ) , (ushort)( PLAYERID ) , (ushort)( DIRECTCONNECT ) , (ushort)( DEBUG ) ) ))  ) ) 
                {
                __context__.SourceCodeLine = 1411;
                return (ushort)( 0) ; 
                }
            
            __context__.SourceCodeLine = 1414;
            MESSAGEPOSITION = (ushort) ( 6 ) ; 
            __context__.SourceCodeLine = 1415;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( MESSAGE , (int)( MESSAGEEND ) ) != 2))  ) ) 
                { 
                __context__.SourceCodeLine = 1417;
                MESSAGEEND = (ushort) ( (MESSAGEEND - 3) ) ; 
                } 
            
            __context__.SourceCodeLine = 1419;
            NUMARGS = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1421;
            GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 5 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
            __context__.SourceCodeLine = 1423;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == "DEVICE_INFO"))  ) ) 
                { 
                __context__.SourceCodeLine = 1425;
                CONNECTEDDEVICESN  .UpdateValue ( ARGS [ 3 ]  ) ; 
                __context__.SourceCodeLine = 1426;
                CONNECTEDDEVICEID = (ushort) ( Functions.Atoi( ARGS[ 4 ] ) ) ; 
                __context__.SourceCodeLine = 1427;
                if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1427;
                    Trace( "Kaleidescape ({0}) Found DEVICE_INFO message.  args[3]={1}\r\n", UMCNAME , ARGS [ 3 ] ) ; 
                    }
                
                __context__.SourceCodeLine = 1428;
                return (ushort)( 10) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 1430;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == "DEVICE_POWER_STATE"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1432;
                    if ( Functions.TestForTrue  ( ( DEBUG)  ) ) 
                        {
                        __context__.SourceCodeLine = 1432;
                        Trace( "Kaleidescape ({0}) Found DEVICE_POWER_STATE.  args[2]={1}\r\n", UMCNAME , ARGS [ 2 ] ) ; 
                        }
                    
                    __context__.SourceCodeLine = 1433;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( ARGS[ 2 ] ) > 0 ))  ) ) 
                        {
                        __context__.SourceCodeLine = 1434;
                        return (ushort)( 12) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 1436;
                        return (ushort)( 11) ; 
                        }
                    
                    } 
                
                }
            
            __context__.SourceCodeLine = 1439;
            return (ushort)( 1) ; 
            
            }
            
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput TOUCH_CHANNEL;
        Crestron.Logos.SplusObjects.DigitalInput USING_MASKING;
        Crestron.Logos.SplusObjects.DigitalInput CONNECTION_OPEN;
        Crestron.Logos.SplusObjects.DigitalInput POWER_OFF_TRIGGER;
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON_TRIGGER;
        Crestron.Logos.SplusObjects.DigitalInput REFRESH_DETAILS;
        Crestron.Logos.SplusObjects.AnalogInput STATED_PLAYER_ID;
        Crestron.Logos.SplusObjects.AnalogInput TOUCH_X;
        Crestron.Logos.SplusObjects.AnalogInput TOUCH_Y;
        Crestron.Logos.SplusObjects.BufferInput RX__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput COMMAND_TO_PLAYER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput KEYBOARD_INPUT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput PLAY_SCRIPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput CONSOLE_COMMAND__DOLLAR__;
        Crestron.Logos.SplusObjects.StringInput CONTROL_MUSIC_ZONE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput OSD_SAVER;
        Crestron.Logos.SplusObjects.DigitalOutput CAMERA_ANGLES_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MOVIES_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput MUSIC_AVAILABLE;
        Crestron.Logos.SplusObjects.DigitalOutput DETAILS_VISIBLE;
        Crestron.Logos.SplusObjects.DigitalOutput MUSIC_PLAYBACK_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput MOVIE_PLAYBACK_ACTIVE;
        Crestron.Logos.SplusObjects.DigitalOutput RANDOM_STATUS;
        Crestron.Logos.SplusObjects.DigitalOutput REPEAT_STATUS;
        Crestron.Logos.SplusObjects.DigitalOutput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalOutput VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalOutput VOLUME_MUTE;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_ON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_OFF_FB;
        Crestron.Logos.SplusObjects.StringOutput TX__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput PLAY_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput TITLE_LENGTH;
        Crestron.Logos.SplusObjects.AnalogOutput TITLE_LOCATION;
        Crestron.Logos.SplusObjects.AnalogOutput TITLE_REMAINING;
        Crestron.Logos.SplusObjects.AnalogOutput TITLE_LEVEL;
        Crestron.Logos.SplusObjects.AnalogOutput CHAPTER_NUMBER;
        Crestron.Logos.SplusObjects.AnalogOutput CHAPTER_LENGTH;
        Crestron.Logos.SplusObjects.AnalogOutput CHAPTER_LOCATION;
        Crestron.Logos.SplusObjects.AnalogOutput CHAPTER_REMAINING;
        Crestron.Logos.SplusObjects.AnalogOutput CHAPTER_LEVEL;
        Crestron.Logos.SplusObjects.AnalogOutput SYSTEM_READINESS_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput MOVIE_LOCATION;
        Crestron.Logos.SplusObjects.StringOutput NOW_PLAYING_TITLE_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NOW_PLAYING_ARTIST_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NOW_PLAYING_ALBUM_NAME_OR_CHAPTER__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput NOW_PLAYING_COVER_ART_URL__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput OSD_SCREEN;
        Crestron.Logos.SplusObjects.AnalogOutput OSD_POPUP;
        Crestron.Logos.SplusObjects.AnalogOutput OSD_DIALOG;
        Crestron.Logos.SplusObjects.AnalogOutput CHILD_MODE_STATE;
        Crestron.Logos.SplusObjects.AnalogOutput CINEMASCAPE_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput CINEMASCAPE_SCALE_MODE;
        Crestron.Logos.SplusObjects.AnalogOutput CINEMASCAPE_MASK;
        Crestron.Logos.SplusObjects.AnalogOutput IMAGE_ASPECT_RATIO;
        Crestron.Logos.SplusObjects.AnalogOutput FRAME_ASPECT_RATIO;
        Crestron.Logos.SplusObjects.AnalogOutput MASK_DATA;
        Crestron.Logos.SplusObjects.AnalogOutput MASK_CONSERVATIVE;
        Crestron.Logos.SplusObjects.AnalogOutput PROTOCOL_VERSION;
        Crestron.Logos.SplusObjects.AnalogOutput USER_INPUT;
        Crestron.Logos.SplusObjects.StringOutput USER_INPUT_PROMPT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput USER_INPUT_TEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput MASK_ABS_TOP;
        Crestron.Logos.SplusObjects.AnalogOutput MASK_ABS_BOTTOM;
        Crestron.Logos.SplusObjects.AnalogOutput CURRENT_CAMERA_ANGLE;
        Crestron.Logos.SplusObjects.AnalogOutput NUM_CAMERA_ANGLES;
        Crestron.Logos.SplusObjects.AnalogOutput VIDEO_MODE_COMPOSITE;
        Crestron.Logos.SplusObjects.AnalogOutput VIDEO_MODE_COMPONENT;
        Crestron.Logos.SplusObjects.AnalogOutput VIDEO_MODE_HDMI;
        Crestron.Logos.SplusObjects.StringOutput USER_DEFINED_EVENT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput FRIENDLY_NAME__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DETAILS_TEXT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DETAILS_TITLE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput DETAILS_COVER_URL__DOLLAR__;
        Crestron.Logos.SplusObjects.AnalogOutput MASK_CALIBRATED_TOP;
        Crestron.Logos.SplusObjects.AnalogOutput MASK_CALIBRATED_BOTTOM;
        Crestron.Logos.SplusObjects.StringOutput CONTROLLED_MUSIC_SN_ZONE__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput CONTROLLED_MUSIC_CPDID_ZONE__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_DISC_IN_TRAY_BUTTON;
        Crestron.Logos.SplusObjects.DigitalOutput DISC_IN_TRAY_OK_TO_IMPORT;
        Crestron.Logos.SplusObjects.DigitalOutput DISC_IN_TRAY_IMPORTED;
        Crestron.Logos.SplusObjects.DigitalOutput DISC_IN_TRAY_IMPORTING;
        Crestron.Logos.SplusObjects.AnalogOutput DISC_IN_TRAY_MEDIA_TYPE;
        Crestron.Logos.SplusObjects.AnalogOutput MEDIA_TYPE;
        Crestron.Logos.SplusObjects.StringOutput RX__DOLLAR___LOOPBACK;
        ushort _TOUCHXCHANGED = 0;
        ushort _TOUCHYCHANGED = 0;
        ushort _TOUCHPRESSED = 0;
        ushort _DIRECTCONNECT = 0;
        ushort _SENDTIMEOUT = 0;
        ushort _TXCOUNT = 0;
        ushort _POWERSTATE = 0;
        ushort _POWERSTATESTATUS = 0;
        CrestronString _MODULEDESCRIPTION;
        CrestronString _PLAYERSN;
        CrestronString _DEVICENAME;
        CrestronString _CONNECTEDDEVICESN;
        ushort _PLAYERID = 0;
        ushort _CONNECTEDDEVICEID = 0;
        ushort _NUMVIDZONES = 0;
        ushort _NUMAUDZONES = 0;
        ushort _LASTCHAPTER = 0;
        CrestronString _MOVIETITLE;
        ushort _NUMBEROFDETAILS = 0;
        ushort _NOWPLAYINGDETAILSLOADING = 0;
        ushort _NOWPLAYINGDETAILSPENDING = 0;
        CrestronString _NOWPLAYINGHANDLE;
        ushort _BROWSEDETAILSLOADING = 0;
        ushort _BROWSEDETAILSPENDING = 0;
        CrestronString _BROWSEDETAILSHANDLE;
        STRUCT_DETAILS _CONTENTDETAIL;
        ushort _DEBUG = 0;
        CrestronString _SYMBOLINSTANCE;
        ushort _CURRENTDELIMITER = 0;
        CrestronString [] _DELIMITERS;
        CrestronString [] _FIELDDELIMITER;
        ushort _PARSINGFLAG = 0;
        ushort _FOUNDDELIMITER = 0;
        ushort _CONNECTIONSTATE = 0;
        CrestronString [] _CONNECTIONCOMMAND;
        ushort _CONNECTIONCOMMANDCOUNT = 0;
        CrestronString _MUSICCONTROLSN__DOLLAR__;
        CrestronString _MUSICCONTROLCPDID__DOLLAR__;
        CrestronString _MUSICCONTROLZONE__DOLLAR__;
        CrestronString _MODULESHORTDESCRIPTION;
        CrestronString _HANDLE;
        CrestronString MSGPLAYER_RESTART;
        CrestronString MSG01_BANG_020;
        CrestronString MSGAVAILABLE_DEVICES;
        CrestronString MSGPLAY_STATUS;
        CrestronString MSGMUSIC_NOW_PLAYING_STATUS;
        CrestronString MSGMUSIC_PLAY_STATUS;
        CrestronString MSGSCREEN_MASK;
        CrestronString MSGSCREEN_MASK2;
        CrestronString MSGTITLE_NAME;
        CrestronString MSGMUSIC_TITLE;
        CrestronString MSGUI_STATE;
        CrestronString MSGMOVIE_MEDIA_TYPE;
        CrestronString MSGMOVIE_LOCATION;
        CrestronString MSGASPECT_RATIO;
        CrestronString MSGCINEMASCAPE_MODE;
        CrestronString MSGSCALE_MODE;
        CrestronString MSGCINEMASCAPE_MASK;
        CrestronString MSGDEVICE_INFO;
        CrestronString MSGNUM_ZONES;
        CrestronString MSGDEVICE_TYPE_NAME;
        CrestronString MSGDEVICE_POWER_STATE;
        CrestronString MSGPROTOCOL;
        CrestronString MSGUSER_INPUT;
        CrestronString MSGCAMERA_ANGLE;
        CrestronString MSGVIDEO_MODE;
        CrestronString MSGUSER_DEFINED_EVENT;
        CrestronString MSGFRIENDLY_NAME;
        CrestronString MSGCONTROLLED_ZONE;
        CrestronString MSGHIGHLIGHTED_SELECTION;
        CrestronString MSGCONTENT_DETAILS_OVERVIEW;
        CrestronString MSGCONTENT_DETAILS;
        CrestronString MSGCHILD_MODE_STATE;
        CrestronString MSGVOLUME_UP_PRESS;
        CrestronString MSGVOLUME_UP_RELEASE;
        CrestronString MSGVOLUME_UP;
        CrestronString MSGVOLUME_DOWN_PRESS;
        CrestronString MSGVOLUME_DOWN_RELEASE;
        CrestronString MSGVOLUME_DOWN;
        CrestronString MSGTOGGLE_MUTE;
        CrestronString MSGSYSTEM_READINESS;
        CrestronString MSGDISC_IN_TRAY_SELECTION;
        private void INITMESSAGES (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1783;
            MSGPLAYER_RESTART  .UpdateValue ( "PLAYER_RESTART"  ) ; 
            __context__.SourceCodeLine = 1784;
            MSG01_BANG_020  .UpdateValue ( "01/!/020:"  ) ; 
            __context__.SourceCodeLine = 1785;
            MSGAVAILABLE_DEVICES  .UpdateValue ( "AVAILABLE_DEVICES"  ) ; 
            __context__.SourceCodeLine = 1786;
            MSGPLAY_STATUS  .UpdateValue ( "PLAY_STATUS"  ) ; 
            __context__.SourceCodeLine = 1787;
            MSGMUSIC_NOW_PLAYING_STATUS  .UpdateValue ( "MUSIC_NOW_PLAYING_STATUS"  ) ; 
            __context__.SourceCodeLine = 1788;
            MSGMUSIC_PLAY_STATUS  .UpdateValue ( "MUSIC_PLAY_STATUS"  ) ; 
            __context__.SourceCodeLine = 1789;
            MSGSCREEN_MASK  .UpdateValue ( "SCREEN_MASK"  ) ; 
            __context__.SourceCodeLine = 1790;
            MSGSCREEN_MASK2  .UpdateValue ( "SCREEN_MASK2"  ) ; 
            __context__.SourceCodeLine = 1791;
            MSGTITLE_NAME  .UpdateValue ( "TITLE_NAME"  ) ; 
            __context__.SourceCodeLine = 1792;
            MSGMUSIC_TITLE  .UpdateValue ( "MUSIC_TITLE"  ) ; 
            __context__.SourceCodeLine = 1793;
            MSGUI_STATE  .UpdateValue ( "UI_STATE"  ) ; 
            __context__.SourceCodeLine = 1794;
            MSGMOVIE_MEDIA_TYPE  .UpdateValue ( "MOVIE_MEDIA_TYPE"  ) ; 
            __context__.SourceCodeLine = 1795;
            MSGMOVIE_LOCATION  .UpdateValue ( "MOVIE_LOCATION"  ) ; 
            __context__.SourceCodeLine = 1796;
            MSGCINEMASCAPE_MODE  .UpdateValue ( "CINEMASCAPE_MODE"  ) ; 
            __context__.SourceCodeLine = 1797;
            MSGSCALE_MODE  .UpdateValue ( "SCALE_MODE"  ) ; 
            __context__.SourceCodeLine = 1798;
            MSGCINEMASCAPE_MASK  .UpdateValue ( "CINEMASCAPE_MASK"  ) ; 
            __context__.SourceCodeLine = 1799;
            MSGASPECT_RATIO  .UpdateValue ( "ASPECT_RATIO"  ) ; 
            __context__.SourceCodeLine = 1800;
            MSGDEVICE_INFO  .UpdateValue ( "DEVICE_INFO"  ) ; 
            __context__.SourceCodeLine = 1801;
            MSGNUM_ZONES  .UpdateValue ( "NUM_ZONES"  ) ; 
            __context__.SourceCodeLine = 1802;
            MSGDEVICE_TYPE_NAME  .UpdateValue ( "DEVICE_TYPE_NAME"  ) ; 
            __context__.SourceCodeLine = 1803;
            MSGDEVICE_POWER_STATE  .UpdateValue ( "DEVICE_POWER_STATE"  ) ; 
            __context__.SourceCodeLine = 1804;
            MSGPROTOCOL  .UpdateValue ( "PROTOCOL"  ) ; 
            __context__.SourceCodeLine = 1805;
            MSGUSER_INPUT  .UpdateValue ( "USER_INPUT"  ) ; 
            __context__.SourceCodeLine = 1806;
            MSGCAMERA_ANGLE  .UpdateValue ( "CAMERA_ANGLE"  ) ; 
            __context__.SourceCodeLine = 1807;
            MSGVIDEO_MODE  .UpdateValue ( "VIDEO_MODE"  ) ; 
            __context__.SourceCodeLine = 1808;
            MSGUSER_DEFINED_EVENT  .UpdateValue ( "USER_DEFINED_EVENT"  ) ; 
            __context__.SourceCodeLine = 1809;
            MSGFRIENDLY_NAME  .UpdateValue ( "FRIENDLY_NAME"  ) ; 
            __context__.SourceCodeLine = 1810;
            MSGCONTROLLED_ZONE  .UpdateValue ( "CONTROLLED_ZONE"  ) ; 
            __context__.SourceCodeLine = 1811;
            MSGHIGHLIGHTED_SELECTION  .UpdateValue ( "HIGHLIGHTED_SELECTION"  ) ; 
            __context__.SourceCodeLine = 1812;
            MSGCONTENT_DETAILS_OVERVIEW  .UpdateValue ( "CONTENT_DETAILS_OVERVIEW"  ) ; 
            __context__.SourceCodeLine = 1813;
            MSGCONTENT_DETAILS  .UpdateValue ( "CONTENT_DETAILS"  ) ; 
            __context__.SourceCodeLine = 1814;
            MSGCHILD_MODE_STATE  .UpdateValue ( "CHILD_MODE_STATE"  ) ; 
            __context__.SourceCodeLine = 1815;
            MSGVOLUME_UP_PRESS  .UpdateValue ( "VOLUME_UP_PRESS"  ) ; 
            __context__.SourceCodeLine = 1816;
            MSGVOLUME_UP_RELEASE  .UpdateValue ( "VOLUME_UP_RELEASE"  ) ; 
            __context__.SourceCodeLine = 1817;
            MSGVOLUME_UP  .UpdateValue ( "VOLUME_UP"  ) ; 
            __context__.SourceCodeLine = 1818;
            MSGVOLUME_DOWN_PRESS  .UpdateValue ( "VOLUME_DOWN_PRESS"  ) ; 
            __context__.SourceCodeLine = 1819;
            MSGVOLUME_DOWN_RELEASE  .UpdateValue ( "VOLUME_DOWN_RELEASE"  ) ; 
            __context__.SourceCodeLine = 1820;
            MSGVOLUME_DOWN  .UpdateValue ( "VOLUME_DOWN"  ) ; 
            __context__.SourceCodeLine = 1821;
            MSGTOGGLE_MUTE  .UpdateValue ( "TOGGLE_MUTE"  ) ; 
            __context__.SourceCodeLine = 1822;
            MSGSYSTEM_READINESS  .UpdateValue ( "SYSTEM_READINESS_STATE"  ) ; 
            __context__.SourceCodeLine = 1823;
            MSGDISC_IN_TRAY_SELECTION  .UpdateValue ( "DISC_IN_TRAY_SELECTION"  ) ; 
            
            }
            
        private void SEND (  SplusExecutionContext __context__, CrestronString DATA ) 
            { 
            CrestronString DATAOUT;
            DATAOUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            
            __context__.SourceCodeLine = 1830;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_PLAYERID == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 1832;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (STATED_PLAYER_ID  .UshortValue == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 1834;
                    Trace( "Kaleidescape ({0}) Player_Id not yet determined, not sending message: {1}\r\n", _SYMBOLINSTANCE , DATA ) ; 
                    __context__.SourceCodeLine = 1835;
                    return ; 
                    } 
                
                __context__.SourceCodeLine = 1837;
                _PLAYERID = (ushort) ( STATED_PLAYER_ID  .UshortValue ) ; 
                __context__.SourceCodeLine = 1838;
                if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
                    {
                    __context__.SourceCodeLine = 1838;
                    Trace( "({0}) \"send\" setting Player_Id to Stated_Player_Id ({1:d}).\r\n", _SYMBOLINSTANCE , (ushort)_PLAYERID) ; 
                    }
                
                } 
            
            __context__.SourceCodeLine = 1841;
            MakeString ( DATAOUT , "{0:d2}/{1:d}/{2}\r\n", (short)_PLAYERID, (short)1, DATA ) ; 
            __context__.SourceCodeLine = 1843;
            if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1843;
                Trace( "({0}) Sending:  {1}", _SYMBOLINSTANCE , DATAOUT ) ; 
                }
            
            __context__.SourceCodeLine = 1845;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( DATAOUT ) > 256 ))  ) ) 
                { 
                __context__.SourceCodeLine = 1847;
                Trace( "Kaleidescape ({0}) module NOT Sending data.  Message length is too long: {1}\r\n", _SYMBOLINSTANCE , DATAOUT ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 1851;
                TX__DOLLAR__  .UpdateValue ( DATAOUT  ) ; 
                __context__.SourceCodeLine = 1852;
                _TXCOUNT = (ushort) ( (_TXCOUNT + 1) ) ; 
                } 
            
            
            }
            
        private void SWITCHDELIMITERS (  SplusExecutionContext __context__, ushort NEWDELIMITER ) 
            { 
            CrestronString RXTEMP;
            RXTEMP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 8192, this );
            
            ushort LASTDELIMITER = 0;
            
            ushort START = 0;
            
            ushort RXTEMPLENGTH = 0;
            
            
            __context__.SourceCodeLine = 1864;
            Trace( "Kaleidescape ({0}) switching delimiters - {1:d}\r\n", _SYMBOLINSTANCE , (short)NEWDELIMITER) ; 
            __context__.SourceCodeLine = 1867;
            LASTDELIMITER = (ushort) ( _CURRENTDELIMITER ) ; 
            __context__.SourceCodeLine = 1868;
            _CURRENTDELIMITER = (ushort) ( NEWDELIMITER ) ; 
            __context__.SourceCodeLine = 1871;
            RXTEMP  .UpdateValue ( RX__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1872;
            Functions.ClearBuffer ( RX__DOLLAR__ ) ; 
            __context__.SourceCodeLine = 1878;
            RX__DOLLAR___LOOPBACK  .UpdateValue ( _DELIMITERS [ LASTDELIMITER ]  ) ; 
            __context__.SourceCodeLine = 1880;
            RXTEMPLENGTH = (ushort) ( Functions.Length( RXTEMP ) ) ; 
            __context__.SourceCodeLine = 1881;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)RXTEMPLENGTH; 
            int __FN_FORSTEP_VAL__1 = (int)255; 
            for ( START  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (START  >= __FN_FORSTART_VAL__1) && (START  <= __FN_FOREND_VAL__1) ) : ( (START  <= __FN_FORSTART_VAL__1) && (START  >= __FN_FOREND_VAL__1) ) ; START  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 1884;
                RX__DOLLAR___LOOPBACK  .UpdateValue ( Functions.Mid ( RXTEMP ,  (int) ( START ) ,  (int) ( 255 ) )  ) ; 
                __context__.SourceCodeLine = 1881;
                } 
            
            
            }
            
        private void REQUESTSTARTUPSTATUS (  SplusExecutionContext __context__ ) 
            { 
            CrestronString COMMAND;
            COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            
            __context__.SourceCodeLine = 1893;
            Functions.Delay (  (int) ( 100 ) ) ; 
            __context__.SourceCodeLine = 1896;
            SEND (  __context__ , "GET_MOVIE_LOCATION:") ; 
            __context__.SourceCodeLine = 1897;
            SEND (  __context__ , "GET_PLAY_STATUS:") ; 
            __context__.SourceCodeLine = 1898;
            SEND (  __context__ , "GET_MUSIC_PLAY_STATUS:") ; 
            __context__.SourceCodeLine = 1899;
            SEND (  __context__ , "GET_PLAYING_TITLE_NAME:") ; 
            __context__.SourceCodeLine = 1900;
            SEND (  __context__ , "GET_CINEMASCAPE_MODE:") ; 
            __context__.SourceCodeLine = 1901;
            SEND (  __context__ , "GET_SCALE_MODE:") ; 
            __context__.SourceCodeLine = 1902;
            SEND (  __context__ , "GET_UI_STATE:") ; 
            __context__.SourceCodeLine = 1903;
            SEND (  __context__ , "GET_CHILD_MODE_STATE:") ; 
            __context__.SourceCodeLine = 1904;
            SEND (  __context__ , "GET_MOVIE_MEDIA_TYPE:") ; 
            __context__.SourceCodeLine = 1905;
            SEND (  __context__ , "GET_VIDEO_MODE:") ; 
            __context__.SourceCodeLine = 1906;
            SEND (  __context__ , "GET_FRIENDLY_NAME:") ; 
            __context__.SourceCodeLine = 1907;
            SEND (  __context__ , "GET_HIGHLIGHTED_SELECTION:") ; 
            __context__.SourceCodeLine = 1908;
            SEND (  __context__ , "GET_CONTROLLED_ZONE:") ; 
            __context__.SourceCodeLine = 1909;
            SEND (  __context__ , "GET_SYSTEM_READINESS_STATE:") ; 
            __context__.SourceCodeLine = 1910;
            SEND (  __context__ , "GET_DISC_IN_TRAY_SELECTION:") ; 
            __context__.SourceCodeLine = 1912;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (USING_MASKING  .Value == 1))  ) ) 
                { 
                __context__.SourceCodeLine = 1914;
                SEND (  __context__ , "SET_SCREEN_MASK:1:") ; 
                } 
            
            __context__.SourceCodeLine = 1917;
            SEND (  __context__ , "GET_PROTOCOL:") ; 
            
            }
            
        private void CLEARSTATUS (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1925;
            if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1925;
                Trace( "({0}) clearing status.\r\n", _SYMBOLINSTANCE ) ; 
                }
            
            __context__.SourceCodeLine = 1927;
            _PLAYERID = (ushort) ( STATED_PLAYER_ID  .UshortValue ) ; 
            __context__.SourceCodeLine = 1929;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_PLAYERID == 1))  ) ) 
                {
                __context__.SourceCodeLine = 1930;
                _DIRECTCONNECT = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 1932;
                _DIRECTCONNECT = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 1934;
            _NUMVIDZONES = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1935;
            _NUMAUDZONES = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1936;
            _PLAYERSN  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1937;
            _DEVICENAME  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1939;
            PLAY_MODE  .Value = (ushort) ( 999 ) ; 
            __context__.SourceCodeLine = 1941;
            DISC_IN_TRAY_MEDIA_TYPE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1942;
            DISC_IN_TRAY_OK_TO_IMPORT  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1943;
            DISC_IN_TRAY_IMPORTED  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1944;
            DISC_IN_TRAY_IMPORTING  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1945;
            SHOW_DISC_IN_TRAY_BUTTON  .Value = (ushort) ( 0 ) ; 
            
            }
            
        private void INITCONNECTION (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1950;
            REFACTORCONNECTIONSETTINGS (  __context__ , (ushort)( STATED_PLAYER_ID  .UshortValue ), _PLAYERSN,   ref  _PLAYERID , _CONNECTEDDEVICESN, (ushort)( _CONNECTEDDEVICEID ),   ref  _DIRECTCONNECT , (ushort)( _DEBUG )) ; 
            __context__.SourceCodeLine = 1953;
            SWITCHDELIMITERS (  __context__ , (ushort)( 1 )) ; 
            __context__.SourceCodeLine = 1954;
            TX__DOLLAR__  .UpdateValue ( "01/0/SET_PROTOCOL_SETTINGS:BINARY_DELIMITERS:LATIN-1:\r\n"  ) ; 
            __context__.SourceCodeLine = 1956;
            Functions.Delay (  (int) ( 100 ) ) ; 
            __context__.SourceCodeLine = 1958;
            SEND (  __context__ , "GET_PROTOCOL:") ; 
            __context__.SourceCodeLine = 1960;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_DIRECTCONNECT == 0) ) && Functions.TestForTrue ( Functions.BoolToInt (_PLAYERID != 1) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 1962;
                TX__DOLLAR__  .UpdateValue ( "01/0/ENABLE_EVENTS:" + Functions.ItoA (  (int) ( _PLAYERID ) ) + ":\r\n"  ) ; 
                __context__.SourceCodeLine = 1963;
                Functions.Delay (  (int) ( 100 ) ) ; 
                } 
            
            
            }
            
        private void CLEARFEEDBACK (  SplusExecutionContext __context__ ) 
            { 
            
            __context__.SourceCodeLine = 1970;
            USER_INPUT  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1972;
            OSD_SCREEN  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1973;
            OSD_POPUP  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1974;
            OSD_DIALOG  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1975;
            CHILD_MODE_STATE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1976;
            DETAILS_VISIBLE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1977;
            CINEMASCAPE_MODE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1979;
            MUSIC_PLAYBACK_ACTIVE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 1980;
            PLAY_MODE  .Value = (ushort) ( 999 ) ; 
            __context__.SourceCodeLine = 1983;
            _MUSICCONTROLSN__DOLLAR__  .UpdateValue ( Functions.Right ( _PLAYERSN ,  (int) ( 12 ) )  ) ; 
            __context__.SourceCodeLine = 1984;
            MakeString ( _MUSICCONTROLCPDID__DOLLAR__ , "{0:d2}", (short)STATED_PLAYER_ID  .UshortValue) ; 
            __context__.SourceCodeLine = 1985;
            _MUSICCONTROLZONE__DOLLAR__  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 1986;
            CONTROLLED_MUSIC_SN_ZONE__DOLLAR__  .UpdateValue ( _MUSICCONTROLSN__DOLLAR__ + "." + _MUSICCONTROLZONE__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 1987;
            CONTROLLED_MUSIC_CPDID_ZONE__DOLLAR__  .UpdateValue ( _MUSICCONTROLCPDID__DOLLAR__ + "." + _MUSICCONTROLZONE__DOLLAR__  ) ; 
            
            }
            
        private void CONNECTIONEVENT (  SplusExecutionContext __context__, ushort STATEEVENT ) 
            { 
            ushort COMMAND = 0;
            ushort LOOP = 0;
            
            
            __context__.SourceCodeLine = 1993;
            COMMAND = (ushort) ( CONNECTIONHANDLER( __context__ , (ushort)( STATEEVENT ) , ref _CONNECTIONSTATE , ref _CONNECTIONCOMMAND , ref _CONNECTIONCOMMANDCOUNT , ref _POWERSTATE , ref _POWERSTATESTATUS , ref _MODULEDESCRIPTION , (ushort)( _DIRECTCONNECT ) , (ushort)( _DEBUG ) ) ) ; 
            __context__.SourceCodeLine = 1994;
            if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 1994;
                Trace( "({0}) ConnectionHandler said do {1:d}.  PowerState = {2:d}.\r\n", _SYMBOLINSTANCE , (short)COMMAND, (short)_POWERSTATE) ; 
                }
            
            __context__.SourceCodeLine = 1995;
            
                {
                int __SPLS_TMPVAR__SWTCH_10__ = ((int)COMMAND);
                
                    { 
                    if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 0) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1997;
                        return ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 1) ) ) ) 
                        { 
                        } 
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 2) ) ) ) 
                        {
                        __context__.SourceCodeLine = 1999;
                        TX__DOLLAR__  .UpdateValue ( _CONNECTIONCOMMAND [ 5 ]  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 3) ) ) ) 
                        {
                        __context__.SourceCodeLine = 2000;
                        REQUESTSTARTUPSTATUS (  __context__  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 4) ) ) ) 
                        {
                        __context__.SourceCodeLine = 2001;
                        CLEARSTATUS (  __context__  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 5) ) ) ) 
                        {
                        __context__.SourceCodeLine = 2002;
                        INITCONNECTION (  __context__  ) ; 
                        }
                    
                    else if  ( Functions.TestForTrue  (  ( __SPLS_TMPVAR__SWTCH_10__ == ( 6) ) ) ) 
                        {
                        __context__.SourceCodeLine = 2003;
                        CLEARFEEDBACK (  __context__  ) ; 
                        }
                    
                    } 
                    
                }
                
            
            __context__.SourceCodeLine = 2007;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)_CONNECTIONCOMMANDCOUNT; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( LOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (LOOP  >= __FN_FORSTART_VAL__1) && (LOOP  <= __FN_FOREND_VAL__1) ) : ( (LOOP  <= __FN_FORSTART_VAL__1) && (LOOP  >= __FN_FOREND_VAL__1) ) ; LOOP  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 2009;
                SEND (  __context__ , _CONNECTIONCOMMAND[ LOOP ]) ; 
                __context__.SourceCodeLine = 2007;
                } 
            
            __context__.SourceCodeLine = 2011;
            _CONNECTIONCOMMANDCOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2013;
            POWER_ON_FB  .Value = (ushort) ( Functions.BoolToInt (_POWERSTATE == 1) ) ; 
            __context__.SourceCodeLine = 2014;
            POWER_OFF_FB  .Value = (ushort) ( Functions.BoolToInt (_POWERSTATE == 0) ) ; 
            
            }
            
        private ushort PROCESSALIENDEVICEINFO (  SplusExecutionContext __context__, CrestronString MESSAGE ) 
            { 
            ushort STARTPOS = 0;
            
            CrestronString SN;
            SN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 12, this );
            
            CrestronString CPDID;
            CPDID  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
            
            CrestronString COMMAND;
            COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            
            __context__.SourceCodeLine = 2026;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( MESSAGE , (int)( 10 ) , (int)( 11 ) ) == "DEVICE_INFO"))  ) ) 
                {
                __context__.SourceCodeLine = 2027;
                STARTPOS = (ushort) ( 29 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 2028;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( MESSAGE , (int)( 21 ) , (int)( 11 ) ) == "DEVICE_INFO"))  ) ) 
                    {
                    __context__.SourceCodeLine = 2029;
                    STARTPOS = (ushort) ( 40 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 2030;
                    return (ushort)( 1) ; 
                    }
                
                }
            
            __context__.SourceCodeLine = 2032;
            SN  .UpdateValue ( Functions.Mid ( MESSAGE ,  (int) ( STARTPOS ) ,  (int) ( 12 ) )  ) ; 
            __context__.SourceCodeLine = 2033;
            CPDID  .UpdateValue ( Functions.Mid ( MESSAGE ,  (int) ( (STARTPOS + 13) ) ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 2035;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (CPDID == _MUSICCONTROLCPDID__DOLLAR__) ) && Functions.TestForTrue ( Functions.BoolToInt (_MUSICCONTROLSN__DOLLAR__ == "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2037;
                _MUSICCONTROLSN__DOLLAR__  .UpdateValue ( SN  ) ; 
                __context__.SourceCodeLine = 2038;
                COMMAND  .UpdateValue ( "SET_CONTROLLED_ZONE:#" + _MUSICCONTROLSN__DOLLAR__ + "." + _MUSICCONTROLZONE__DOLLAR__ + ":"  ) ; 
                __context__.SourceCodeLine = 2039;
                SEND (  __context__ , COMMAND) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2041;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (SN == _MUSICCONTROLSN__DOLLAR__) ) && Functions.TestForTrue ( Functions.BoolToInt (_MUSICCONTROLCPDID__DOLLAR__ == "") )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2043;
                    _MUSICCONTROLCPDID__DOLLAR__  .UpdateValue ( CPDID  ) ; 
                    __context__.SourceCodeLine = 2044;
                    CONTROLLED_MUSIC_CPDID_ZONE__DOLLAR__  .UpdateValue ( _MUSICCONTROLCPDID__DOLLAR__ + "." + _MUSICCONTROLZONE__DOLLAR__  ) ; 
                    } 
                
                }
            
            __context__.SourceCodeLine = 2046;
            return (ushort)( 0) ; 
            
            }
            
        private void SETCONTROLLEDZONE (  SplusExecutionContext __context__ ) 
            { 
            CrestronString COMMAND;
            COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            
            __context__.SourceCodeLine = 2055;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_MUSICCONTROLSN__DOLLAR__ == ""))  ) ) 
                { 
                __context__.SourceCodeLine = 2057;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_MUSICCONTROLCPDID__DOLLAR__ == ""))  ) ) 
                    {
                    __context__.SourceCodeLine = 2058;
                    return ; 
                    }
                
                __context__.SourceCodeLine = 2060;
                TX__DOLLAR__  .UpdateValue ( _MUSICCONTROLCPDID__DOLLAR__ + "/0/GET_DEVICE_INFO:\r\n"  ) ; 
                __context__.SourceCodeLine = 2061;
                return ; 
                } 
            
            __context__.SourceCodeLine = 2065;
            COMMAND  .UpdateValue ( "SET_CONTROLLED_ZONE:#" + _MUSICCONTROLSN__DOLLAR__ + "." + _MUSICCONTROLZONE__DOLLAR__ + ":"  ) ; 
            __context__.SourceCodeLine = 2066;
            SEND (  __context__ , COMMAND) ; 
            
            }
            
        private void DOREQUESTBROWSEDETAILS (  SplusExecutionContext __context__ ) 
            { 
            CrestronString COMMAND;
            COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
            
            ushort FAILSAFECOUNT = 0;
            
            
            __context__.SourceCodeLine = 2079;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_BROWSEDETAILSPENDING == 1))  ) ) 
                {
                __context__.SourceCodeLine = 2079;
                return ; 
                }
            
            __context__.SourceCodeLine = 2080;
            _BROWSEDETAILSPENDING = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2083;
            FAILSAFECOUNT = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2084;
            while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( _BROWSEDETAILSLOADING ) || Functions.TestForTrue ( _NOWPLAYINGDETAILSLOADING )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (RX__DOLLAR__ != "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2086;
                Functions.Delay (  (int) ( 50 ) ) ; 
                __context__.SourceCodeLine = 2087;
                FAILSAFECOUNT = (ushort) ( (FAILSAFECOUNT + 1) ) ; 
                __context__.SourceCodeLine = 2089;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FAILSAFECOUNT >= 20 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2092;
                    _BROWSEDETAILSLOADING = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 2093;
                    _NOWPLAYINGDETAILSLOADING = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 2095;
                    break ; 
                    } 
                
                __context__.SourceCodeLine = 2084;
                } 
            
            __context__.SourceCodeLine = 2098;
            DETAILS_VISIBLE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2099;
            _BROWSEDETAILSPENDING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2100;
            _BROWSEDETAILSLOADING = (ushort) ( 1 ) ; 
            __context__.SourceCodeLine = 2103;
            COMMAND  .UpdateValue ( "GET_CONTENT_DETAILS:" + _BROWSEDETAILSHANDLE + "::"  ) ; 
            __context__.SourceCodeLine = 2104;
            SEND (  __context__ , COMMAND) ; 
            
            }
            
        private void REQUESTBROWSEDETAILS (  SplusExecutionContext __context__, CrestronString HANDLE ) 
            { 
            
            __context__.SourceCodeLine = 2109;
            _BROWSEDETAILSHANDLE  .UpdateValue ( HANDLE  ) ; 
            __context__.SourceCodeLine = 2110;
            DETAILS_VISIBLE  .Value = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2111;
            CreateWait ( "__SPLS_TMPVAR__WAITLABEL_8__" , 40 , __SPLS_TMPVAR__WAITLABEL_8___Callback ) ;
            
            }
            
        public void __SPLS_TMPVAR__WAITLABEL_8___CallbackFn( object stateInfo )
        {
        
            try
            {
                Wait __LocalWait__ = (Wait)stateInfo;
                SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
                __LocalWait__.RemoveFromList();
                
            
            __context__.SourceCodeLine = 2113;
            DOREQUESTBROWSEDETAILS (  __context__  ) ; 
            
        
        
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler(); }
            
        }
        
    private void DOREQUESTNOWPLAYINGDETAILS (  SplusExecutionContext __context__ ) 
        { 
        CrestronString COMMAND;
        COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
        
        ushort FAILSAFECOUNT = 0;
        
        
        __context__.SourceCodeLine = 2126;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_NOWPLAYINGDETAILSPENDING == 1))  ) ) 
            {
            __context__.SourceCodeLine = 2126;
            return ; 
            }
        
        __context__.SourceCodeLine = 2127;
        _NOWPLAYINGDETAILSPENDING = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2130;
        FAILSAFECOUNT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2131;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( _BROWSEDETAILSLOADING ) || Functions.TestForTrue ( _NOWPLAYINGDETAILSLOADING )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (RX__DOLLAR__ != "") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2133;
            Functions.Delay (  (int) ( 20 ) ) ; 
            __context__.SourceCodeLine = 2134;
            FAILSAFECOUNT = (ushort) ( (FAILSAFECOUNT + 1) ) ; 
            __context__.SourceCodeLine = 2135;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( FAILSAFECOUNT >= 50 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2138;
                _BROWSEDETAILSLOADING = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 2139;
                _NOWPLAYINGDETAILSLOADING = (ushort) ( 0 ) ; 
                } 
            
            __context__.SourceCodeLine = 2131;
            } 
        
        __context__.SourceCodeLine = 2142;
        _NOWPLAYINGDETAILSPENDING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2143;
        _NOWPLAYINGDETAILSLOADING = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2146;
        COMMAND  .UpdateValue ( "GET_CONTENT_DETAILS:" + _NOWPLAYINGHANDLE + "::"  ) ; 
        __context__.SourceCodeLine = 2147;
        SEND (  __context__ , COMMAND) ; 
        
        }
        
    private void REQUESTNOWPLAYINGDETAILS (  SplusExecutionContext __context__, CrestronString HANDLE ) 
        { 
        
        __context__.SourceCodeLine = 2152;
        _NOWPLAYINGHANDLE  .UpdateValue ( HANDLE  ) ; 
        __context__.SourceCodeLine = 2153;
        CreateWait ( "__SPLS_TMPVAR__WAITLABEL_9__" , 40 , __SPLS_TMPVAR__WAITLABEL_9___Callback ) ;
        
        }
        
    public void __SPLS_TMPVAR__WAITLABEL_9___CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 2155;
            DOREQUESTNOWPLAYINGDETAILS (  __context__  ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    
private void RENDERDETAILS (  SplusExecutionContext __context__ ) 
    { 
    ushort TOTALSECONDS = 0;
    
    ushort TOTALMINUTES = 0;
    
    ushort HOURS = 0;
    
    ushort MINUTES = 0;
    
    CrestronString TIMESTRING;
    TIMESTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    CrestronString TEMP_DETAILS;
    TEMP_DETAILS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    
    __context__.SourceCodeLine = 2170;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.COVERURL))  ) ) 
        { 
        __context__.SourceCodeLine = 2172;
        DETAILS_COVER_URL__DOLLAR__  .UpdateValue ( _CONTENTDETAIL . COVERURL  ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 2176;
        DETAILS_COVER_URL__DOLLAR__  .UpdateValue ( ""  ) ; 
        } 
    
    __context__.SourceCodeLine = 2179;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("albums" == _CONTENTDETAIL.LIBRARY))  ) ) 
        { 
        __context__.SourceCodeLine = 2181;
        TOTALSECONDS = (ushort) ( Functions.Atoi( _CONTENTDETAIL.RUNNINGTIME ) ) ; 
        __context__.SourceCodeLine = 2182;
        HOURS = (ushort) ( (TOTALSECONDS / 3600) ) ; 
        __context__.SourceCodeLine = 2183;
        MINUTES = (ushort) ( (Mod( TOTALSECONDS , 3600 ) / 60) ) ; 
        __context__.SourceCodeLine = 2184;
        TIMESTRING  .UpdateValue ( MAKETIMESTRING (  __context__ , (ushort)( HOURS ), (ushort)( MINUTES ))  ) ; 
        __context__.SourceCodeLine = 2186;
        DETAILS_TITLE__DOLLAR__  .UpdateValue ( _CONTENTDETAIL . PERFORMER + " - " + _CONTENTDETAIL . TITLE  ) ; 
        __context__.SourceCodeLine = 2188;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_CONTENTDETAIL.YEAR == ""))  ) ) 
            { 
            __context__.SourceCodeLine = 2190;
            DETAILS_TEXT__DOLLAR__  .UpdateValue ( TIMESTRING  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2194;
            MakeString ( DETAILS_TEXT__DOLLAR__ , "Released {0}, {1}", _CONTENTDETAIL . YEAR , TIMESTRING ) ; 
            } 
        
        __context__.SourceCodeLine = 2198;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.GENRE))  ) ) 
            { 
            __context__.SourceCodeLine = 2201;
            _CONTENTDETAIL . GENRE  .UpdateValue ( SUBSTITUTE (  __context__ , _CONTENTDETAIL.GENRE, (ushort)( 13 ), ", ")  ) ; 
            __context__.SourceCodeLine = 2204;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "," , _CONTENTDETAIL.GENRE ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 2206;
                MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rGENRE\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . GENRE ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2210;
                MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rGENRES\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . GENRE ) ; 
                } 
            
            } 
        
        __context__.SourceCodeLine = 2214;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.PERFORMER))  ) ) 
            { 
            __context__.SourceCodeLine = 2216;
            MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rPERFORMER\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . PERFORMER ) ; 
            } 
        
        __context__.SourceCodeLine = 2219;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.DISCLOCATION))  ) ) 
            { 
            __context__.SourceCodeLine = 2221;
            _CONTENTDETAIL . DISCLOCATION  .UpdateValue ( SUBSTITUTE (  __context__ , _CONTENTDETAIL.DISCLOCATION, (ushort)( 10 ), "\r")  ) ; 
            __context__.SourceCodeLine = 2222;
            MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rLOCATION\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . DISCLOCATION ) ; 
            } 
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 2226;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("movies" == _CONTENTDETAIL.LIBRARY))  ) ) 
            { 
            __context__.SourceCodeLine = 2232;
            TOTALMINUTES = (ushort) ( Functions.Atoi( _CONTENTDETAIL.RUNNINGTIME ) ) ; 
            __context__.SourceCodeLine = 2233;
            HOURS = (ushort) ( (TOTALMINUTES / 60) ) ; 
            __context__.SourceCodeLine = 2234;
            MINUTES = (ushort) ( Mod( TOTALMINUTES , 60 ) ) ; 
            __context__.SourceCodeLine = 2235;
            TIMESTRING  .UpdateValue ( MAKETIMESTRING (  __context__ , (ushort)( HOURS ), (ushort)( MINUTES ))  ) ; 
            __context__.SourceCodeLine = 2238;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TIMESTRING != "") ) && Functions.TestForTrue ( Functions.BoolToInt ("" != _CONTENTDETAIL.YEAR) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2240;
                TIMESTRING  .UpdateValue ( TIMESTRING + ", "  ) ; 
                } 
            
            __context__.SourceCodeLine = 2243;
            DETAILS_TITLE__DOLLAR__  .UpdateValue ( _CONTENTDETAIL . TITLE  ) ; 
            __context__.SourceCodeLine = 2245;
            MakeString ( TEMP_DETAILS , "Rated {0}", _CONTENTDETAIL . RATING ) ; 
            __context__.SourceCodeLine = 2246;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.RATINGREASON))  ) ) 
                { 
                __context__.SourceCodeLine = 2248;
                MakeString ( TEMP_DETAILS , "{0} for {1}", TEMP_DETAILS , _CONTENTDETAIL . RATINGREASON ) ; 
                } 
            
            __context__.SourceCodeLine = 2251;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TIMESTRING != "") ) || Functions.TestForTrue ( Functions.BoolToInt (_CONTENTDETAIL.YEAR != "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2253;
                MakeString ( TEMP_DETAILS , "{0}; {1}{2}", TEMP_DETAILS , TIMESTRING , _CONTENTDETAIL . YEAR ) ; 
                } 
            
            __context__.SourceCodeLine = 2256;
            DETAILS_TEXT__DOLLAR__  .UpdateValue ( TEMP_DETAILS  ) ; 
            __context__.SourceCodeLine = 2258;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.SYNOPSIS))  ) ) 
                { 
                __context__.SourceCodeLine = 2260;
                MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rSYNOPSIS\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . SYNOPSIS ) ; 
                } 
            
            __context__.SourceCodeLine = 2263;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.GENRE))  ) ) 
                { 
                __context__.SourceCodeLine = 2266;
                _CONTENTDETAIL . GENRE  .UpdateValue ( SUBSTITUTE (  __context__ , _CONTENTDETAIL.GENRE, (ushort)( 13 ), ", ")  ) ; 
                __context__.SourceCodeLine = 2267;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "," , _CONTENTDETAIL.GENRE ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2269;
                    MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rGENRE\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . GENRE ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2273;
                    MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rGENRES\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . GENRE ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 2278;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.PERFORMER))  ) ) 
                { 
                __context__.SourceCodeLine = 2281;
                _CONTENTDETAIL . PERFORMER  .UpdateValue ( SUBSTITUTE (  __context__ , _CONTENTDETAIL.PERFORMER, (ushort)( 13 ), ", ")  ) ; 
                __context__.SourceCodeLine = 2282;
                MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rCAST\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . PERFORMER ) ; 
                } 
            
            __context__.SourceCodeLine = 2285;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.COMPOSER))  ) ) 
                { 
                __context__.SourceCodeLine = 2288;
                _CONTENTDETAIL . COMPOSER  .UpdateValue ( SUBSTITUTE (  __context__ , _CONTENTDETAIL.COMPOSER, (ushort)( 13 ), ", ")  ) ; 
                __context__.SourceCodeLine = 2289;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Find( "," , _CONTENTDETAIL.COMPOSER ) == 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2291;
                    MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rDIRECTOR\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . COMPOSER ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2295;
                    MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rDIRECTORS\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . COMPOSER ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 2299;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ("" != _CONTENTDETAIL.DISCLOCATION))  ) ) 
                { 
                __context__.SourceCodeLine = 2301;
                _CONTENTDETAIL . DISCLOCATION  .UpdateValue ( SUBSTITUTE (  __context__ , _CONTENTDETAIL.DISCLOCATION, (ushort)( 10 ), "\r")  ) ; 
                __context__.SourceCodeLine = 2302;
                MakeString ( DETAILS_TEXT__DOLLAR__ , "{0} \r \rLOCATION\r{1}", "\u00FE\u0002" , _CONTENTDETAIL . DISCLOCATION ) ; 
                } 
            
            } 
        
        }
    
    __context__.SourceCodeLine = 2306;
    DETAILS_VISIBLE  .Value = (ushort) ( 1 ) ; 
    
    }
    
private void RECEIVECONTENTDETAIL (  SplusExecutionContext __context__, ref CrestronString [] ARGS ) 
    { 
    
    __context__.SourceCodeLine = 2312;
    if ( Functions.TestForTrue  ( ( _BROWSEDETAILSLOADING)  ) ) 
        { 
        __context__.SourceCodeLine = 2314;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Artist"))  ) ) 
            { 
            __context__.SourceCodeLine = 2316;
            _CONTENTDETAIL . PERFORMER  .UpdateValue ( ARGS [ 4]  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2318;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Artists"))  ) ) 
                { 
                __context__.SourceCodeLine = 2320;
                _CONTENTDETAIL . PERFORMER  .UpdateValue ( ARGS [ 4]  ) ; 
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2322;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Performer"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2324;
                    _CONTENTDETAIL . PERFORMER  .UpdateValue ( ARGS [ 4]  ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 2326;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Performers"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2328;
                        _CONTENTDETAIL . PERFORMER  .UpdateValue ( ARGS [ 4]  ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 2330;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Composer"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2332;
                            _CONTENTDETAIL . COMPOSER  .UpdateValue ( ARGS [ 4]  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 2334;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Composers"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2336;
                                _CONTENTDETAIL . COMPOSER  .UpdateValue ( ARGS [ 4]  ) ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 2338;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Genre"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2340;
                                    _CONTENTDETAIL . GENRE  .UpdateValue ( ARGS [ 4]  ) ; 
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 2342;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Genres"))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 2344;
                                        _CONTENTDETAIL . GENRE  .UpdateValue ( ARGS [ 4]  ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 2346;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Album_title"))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 2348;
                                            _CONTENTDETAIL . ALBUMTITLE  .UpdateValue ( ARGS [ 4]  ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 2350;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Title"))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 2352;
                                                _CONTENTDETAIL . TITLE  .UpdateValue ( ARGS [ 4]  ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 2354;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Track_title"))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 2356;
                                                    _CONTENTDETAIL . TITLE  .UpdateValue ( ARGS [ 4]  ) ; 
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 2358;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Album_year"))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 2360;
                                                        _CONTENTDETAIL . YEAR  .UpdateValue ( ARGS [ 4]  ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 2362;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Rating"))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 2364;
                                                            _CONTENTDETAIL . RATING  .UpdateValue ( ARGS [ 4]  ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 2366;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Rating_reason"))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 2368;
                                                                _CONTENTDETAIL . RATINGREASON  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 2370;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Year"))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 2372;
                                                                    _CONTENTDETAIL . YEAR  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                    __context__.SourceCodeLine = 2373;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_CONTENTDETAIL.YEAR == "0"))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 2375;
                                                                        _CONTENTDETAIL . YEAR  .UpdateValue ( ""  ) ; 
                                                                        } 
                                                                    
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 2378;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Actors"))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 2380;
                                                                        _CONTENTDETAIL . PERFORMER  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 2382;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Directors"))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 2384;
                                                                            _CONTENTDETAIL . COMPOSER  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 2386;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Running_time"))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 2388;
                                                                                _CONTENTDETAIL . RUNNINGTIME  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 2390;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Synopsis"))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 2392;
                                                                                    _CONTENTDETAIL . SYNOPSIS  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 2394;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Cover_URL"))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 2396;
                                                                                        __context__.SourceCodeLine = 2397;
                                                                                        _CONTENTDETAIL . COVERURL  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                                        
                                                                                        __context__.SourceCodeLine = 2400;
                                                                                        
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 2404;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Album_content_handle"))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 2406;
                                                                                            _CONTENTDETAIL . ALBUMCONTENTHANDLE  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 2408;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Disc_location"))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 2410;
                                                                                                _CONTENTDETAIL . DISCLOCATION  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                                                } 
                                                                                            
                                                                                            }
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            }
        
        __context__.SourceCodeLine = 2414;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Atoi( ARGS[ 2 ] ) == _CONTENTDETAIL.NUMDETAILSEXPECTED))  ) ) 
            { 
            __context__.SourceCodeLine = 2417;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_CONTENTDETAIL.TITLE == "") ) && Functions.TestForTrue ( Functions.BoolToInt (_CONTENTDETAIL.ALBUMTITLE != "") )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 2419;
                _CONTENTDETAIL . TITLE  .UpdateValue ( _CONTENTDETAIL . ALBUMTITLE  ) ; 
                } 
            
            __context__.SourceCodeLine = 2423;
            _BROWSEDETAILSLOADING = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 2424;
            RENDERDETAILS (  __context__  ) ; 
            } 
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 2427;
        if ( Functions.TestForTrue  ( ( _NOWPLAYINGDETAILSLOADING)  ) ) 
            { 
            __context__.SourceCodeLine = 2429;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 3 ] == "Cover_URL"))  ) ) 
                { 
                __context__.SourceCodeLine = 2431;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 4 ] != ""))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2433;
                    __context__.SourceCodeLine = 2434;
                    NOW_PLAYING_COVER_ART_URL__DOLLAR__  .UpdateValue ( ARGS [ 4]  ) ; 
                    
                    __context__.SourceCodeLine = 2437;
                    
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2443;
                    NOW_PLAYING_COVER_ART_URL__DOLLAR__  .UpdateValue ( ""  ) ; 
                    } 
                
                } 
            
            __context__.SourceCodeLine = 2447;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Atoi( ARGS[ 2 ] ) >= _NUMBEROFDETAILS ))  ) ) 
                { 
                __context__.SourceCodeLine = 2449;
                _NOWPLAYINGDETAILSLOADING = (ushort) ( 0 ) ; 
                } 
            
            } 
        
        }
    
    
    }
    
private void CHECKAVAILABLEDEVICES (  SplusExecutionContext __context__, CrestronString MESSAGE , CrestronString FIELDDELIMITER ) 
    { 
    CrestronString PLAYERIDSEARCHSTRING;
    PLAYERIDSEARCHSTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
    
    
    __context__.SourceCodeLine = 2459;
    if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
        {
        __context__.SourceCodeLine = 2459;
        Trace( "({0}) Searching for my device in AVAILABLE_DEVICES\r\n", _SYMBOLINSTANCE ) ; 
        }
    
    __context__.SourceCodeLine = 2461;
    MakeString ( PLAYERIDSEARCHSTRING , "{0}{1:d2}{2}", FIELDDELIMITER , (short)_PLAYERID, FIELDDELIMITER ) ; 
    __context__.SourceCodeLine = 2464;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Find( PLAYERIDSEARCHSTRING , MESSAGE , 27 ) > 0 ))  ) ) 
        { 
        __context__.SourceCodeLine = 2466;
        CONNECTIONEVENT (  __context__ , (ushort)( 14 )) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 2470;
        CONNECTIONEVENT (  __context__ , (ushort)( 15 )) ; 
        } 
    
    
    }
    
private void PARSEMESSAGE (  SplusExecutionContext __context__, CrestronString MESSAGE , ref CrestronString [] ARGS ) 
    { 
    ushort MESSAGEPOSITION = 0;
    
    ushort MESSAGEEND = 0;
    
    ushort MESSAGEERRORCODE = 0;
    
    ushort NUMARGS = 0;
    
    ushort CONTENTDETAILSFINISHED = 0;
    
    ushort NEWOSDSCREEN = 0;
    
    ushort BINARYDELIMITED = 0;
    
    ushort EVENTTRIGGER = 0;
    
    ushort ERRORCODE = 0;
    
    
    __context__.SourceCodeLine = 2511;
    MESSAGEEND = (ushort) ( Functions.Length( MESSAGE ) ) ; 
    __context__.SourceCodeLine = 2512;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( MESSAGE , (int)( MESSAGEEND ) ) == 4))  ) ) 
        { 
        __context__.SourceCodeLine = 2514;
        BINARYDELIMITED = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 2515;
        MESSAGEEND = (ushort) ( (MESSAGEEND - 1) ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 2519;
        BINARYDELIMITED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 2521;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( MESSAGEEND > 0 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( MESSAGEEND ) ) == 13) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( MESSAGEEND ) ) == 10) )) ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2524;
            MESSAGEEND = (ushort) ( (MESSAGEEND - 1) ) ; 
            __context__.SourceCodeLine = 2521;
            } 
        
        } 
    
    __context__.SourceCodeLine = 2532;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( MESSAGE , (int)( 6 ) , (int)( 14 ) ) == MSGPLAYER_RESTART))  ) ) 
        { 
        __context__.SourceCodeLine = 2534;
        CONNECTIONEVENT (  __context__ , (ushort)( 16 )) ; 
        __context__.SourceCodeLine = 2535;
        return ; 
        } 
    
    __context__.SourceCodeLine = 2539;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( MESSAGE , (int)( 9 ) ) == MSG01_BANG_020))  ) ) 
        { 
        __context__.SourceCodeLine = 2541;
        CONNECTIONEVENT (  __context__ , (ushort)( 13 )) ; 
        } 
    
    __context__.SourceCodeLine = 2545;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _CONNECTIONSTATE < 4 ))  ) ) 
        { 
        __context__.SourceCodeLine = 2548;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 1 ) ) == 48) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 2 ) ) == 49) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 4 ) ) == 48) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 6 ) ) == 48) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 7 ) ) == 48) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt (Byte( MESSAGE , (int)( 8 ) ) == 48) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 2555;
            EVENTTRIGGER = (ushort) ( PARSE010MESSAGEEVENT( __context__ , MESSAGE , (ushort)( MESSAGEEND ) , (ushort)( _PLAYERID ) , (ushort)( _DIRECTCONNECT ) , ref _CONNECTEDDEVICESN , ref _CONNECTEDDEVICEID , (ushort)( _DEBUG ) ) ) ; 
            __context__.SourceCodeLine = 2556;
            if ( Functions.TestForTrue  ( ( EVENTTRIGGER)  ) ) 
                {
                __context__.SourceCodeLine = 2557;
                CONNECTIONEVENT (  __context__ , (ushort)( EVENTTRIGGER )) ; 
                }
            
            __context__.SourceCodeLine = 2558;
            return ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 2562;
    if ( Functions.TestForTrue  ( ( Functions.Not( _DIRECTCONNECT ))  ) ) 
        { 
        __context__.SourceCodeLine = 2565;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Mid( MESSAGE , (int)( 10 ) , (int)( 17 ) ) == MSGAVAILABLE_DEVICES))  ) ) 
            { 
            __context__.SourceCodeLine = 2567;
            CHECKAVAILABLEDEVICES (  __context__ , MESSAGE, _FIELDDELIMITER[ BINARYDELIMITED ]) ; 
            __context__.SourceCodeLine = 2568;
            return ; 
            } 
        
        } 
    
    __context__.SourceCodeLine = 2573;
    MESSAGEERRORCODE = (ushort) ( CHECKMESSAGE( __context__ , MESSAGE , (ushort)( _PLAYERID ) , (ushort)( 0 ) , (ushort)( 1 ) , (ushort)( MESSAGEEND ) , (ushort)( _DIRECTCONNECT ) , (ushort)( _DEBUG ) ) ) ; 
    __context__.SourceCodeLine = 2576;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MESSAGEERRORCODE != 0))  ) ) 
        { 
        __context__.SourceCodeLine = 2578;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MESSAGEERRORCODE == 3))  ) ) 
            {
            __context__.SourceCodeLine = 2579;
            PROCESSALIENDEVICEINFO (  __context__ , MESSAGE) ; 
            }
        
        __context__.SourceCodeLine = 2580;
        return ; 
        } 
    
    __context__.SourceCodeLine = 2583;
    if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
        {
        __context__.SourceCodeLine = 2583;
        Trace( "({0}) Received:  {1}\r\n", _SYMBOLINSTANCE , MESSAGE ) ; 
        }
    
    __context__.SourceCodeLine = 2586;
    MESSAGEPOSITION = (ushort) ( 1 ) ; 
    __context__.SourceCodeLine = 2587;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( MESSAGE , (int)( 3 ) ) == 46))  ) ) 
        { 
        __context__.SourceCodeLine = 2589;
        MESSAGEPOSITION = (ushort) ( (MESSAGEPOSITION + 8) ) ; 
        } 
    
    else 
        { 
        __context__.SourceCodeLine = 2593;
        MESSAGEPOSITION = (ushort) ( (MESSAGEPOSITION + 5) ) ; 
        } 
    
    __context__.SourceCodeLine = 2595;
    if ( Functions.TestForTrue  ( ( Functions.Not( BINARYDELIMITED ))  ) ) 
        { 
        __context__.SourceCodeLine = 2597;
        MESSAGEEND = (ushort) ( (MESSAGEEND - 3) ) ; 
        } 
    
    __context__.SourceCodeLine = 2603;
    _SENDTIMEOUT = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 2604;
    CONNECTIONEVENT (  __context__ , (ushort)( 1 )) ; 
    __context__.SourceCodeLine = 2607;
    NUMARGS = (ushort) ( 0 ) ; 
    __context__.SourceCodeLine = 2609;
    GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 2 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
    __context__.SourceCodeLine = 2611;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Byte( ARGS[ 0 ] , (int)( 1 ) ) != 48) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( ARGS[ 0 ] , (int)( 2 ) ) != 48) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Byte( ARGS[ 0 ] , (int)( 3 ) ) != 48) )) ))  ) ) 
        { 
        __context__.SourceCodeLine = 2614;
        ERRORCODE = (ushort) ( Functions.Atoi( ARGS[ 0 ] ) ) ; 
        __context__.SourceCodeLine = 2616;
        CONNECTIONEVENT (  __context__ , (ushort)( (1000 + ERRORCODE) )) ; 
        __context__.SourceCodeLine = 2619;
        PRINTPLAYERERROR (  __context__ , (ushort)( ERRORCODE ), ARGS[ 1 ], (ushort)( _PLAYERID )) ; 
        __context__.SourceCodeLine = 2622;
        return ; 
        } 
    
    __context__.SourceCodeLine = 2625;
    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGPLAY_STATUS))  ) ) 
        { 
        __context__.SourceCodeLine = 2627;
        GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 10 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
        __context__.SourceCodeLine = 2628;
        PLAY_MODE  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
        __context__.SourceCodeLine = 2629;
        TITLE_LENGTH  .Value = (ushort) ( Functions.Atoi( ARGS[ 5 ] ) ) ; 
        __context__.SourceCodeLine = 2630;
        TITLE_LOCATION  .Value = (ushort) ( Functions.Atoi( ARGS[ 6 ] ) ) ; 
        __context__.SourceCodeLine = 2631;
        CHAPTER_NUMBER  .Value = (ushort) ( Functions.Atoi( ARGS[ 7 ] ) ) ; 
        __context__.SourceCodeLine = 2632;
        CHAPTER_LENGTH  .Value = (ushort) ( Functions.Atoi( ARGS[ 8 ] ) ) ; 
        __context__.SourceCodeLine = 2633;
        CHAPTER_LOCATION  .Value = (ushort) ( Functions.Atoi( ARGS[ 9 ] ) ) ; 
        __context__.SourceCodeLine = 2635;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TITLE_LENGTH  .Value != 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2638;
            TITLE_LEVEL  .Value = (ushort) ( ((TITLE_LOCATION  .Value * 65535) / TITLE_LENGTH  .Value) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2642;
            TITLE_LEVEL  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 2645;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (CHAPTER_LENGTH  .Value != 0))  ) ) 
            { 
            __context__.SourceCodeLine = 2648;
            CHAPTER_LEVEL  .Value = (ushort) ( ((CHAPTER_LOCATION  .Value * 65535) / CHAPTER_LENGTH  .Value) ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 2652;
            CHAPTER_LEVEL  .Value = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 2655;
        TITLE_REMAINING  .Value = (ushort) ( (TITLE_LENGTH  .Value - TITLE_LOCATION  .Value) ) ; 
        __context__.SourceCodeLine = 2656;
        CHAPTER_REMAINING  .Value = (ushort) ( (CHAPTER_LENGTH  .Value - CHAPTER_LOCATION  .Value) ) ; 
        __context__.SourceCodeLine = 2658;
        MOVIE_PLAYBACK_ACTIVE  .Value = (ushort) ( Functions.BoolToInt (Byte( ARGS[ 2 ] , (int)( 1 ) ) != 48) ) ; 
        __context__.SourceCodeLine = 2660;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_LASTCHAPTER != CHAPTER_NUMBER  .Value))  ) ) 
            { 
            __context__.SourceCodeLine = 2662;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( CHAPTER_NUMBER  .Value > 0 ))  ) ) 
                { 
                __context__.SourceCodeLine = 2664;
                MakeString ( NOW_PLAYING_ALBUM_NAME_OR_CHAPTER__DOLLAR__ , "Chapter {0:d}", (short)CHAPTER_NUMBER  .Value) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 2668;
                NOW_PLAYING_ALBUM_NAME_OR_CHAPTER__DOLLAR__  .UpdateValue ( " "  ) ; 
                } 
            
            __context__.SourceCodeLine = 2671;
            NOW_PLAYING_ARTIST_NAME__DOLLAR__  .UpdateValue ( " "  ) ; 
            __context__.SourceCodeLine = 2673;
            _LASTCHAPTER = (ushort) ( CHAPTER_NUMBER  .Value ) ; 
            } 
        
        } 
    
    else 
        {
        __context__.SourceCodeLine = 2676;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGMUSIC_NOW_PLAYING_STATUS))  ) ) 
            { 
            __context__.SourceCodeLine = 2678;
            GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 6 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
            __context__.SourceCodeLine = 2680;
            CHAPTER_NUMBER  .Value = (ushort) ( (Functions.Atoi( ARGS[ 3 ] ) + 1) ) ; 
            __context__.SourceCodeLine = 2681;
            REPEAT_STATUS  .Value = (ushort) ( Functions.BoolToInt (Byte( ARGS[ 4 ] , (int)( 1 ) ) == 49) ) ; 
            __context__.SourceCodeLine = 2682;
            RANDOM_STATUS  .Value = (ushort) ( Functions.BoolToInt (Byte( ARGS[ 5 ] , (int)( 1 ) ) == 49) ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 2685;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGMUSIC_PLAY_STATUS))  ) ) 
                { 
                __context__.SourceCodeLine = 2687;
                GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 6 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                __context__.SourceCodeLine = 2689;
                PLAY_MODE  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                __context__.SourceCodeLine = 2690;
                TITLE_LENGTH  .Value = (ushort) ( Functions.Atoi( ARGS[ 4 ] ) ) ; 
                __context__.SourceCodeLine = 2691;
                TITLE_LOCATION  .Value = (ushort) ( Functions.Atoi( ARGS[ 5 ] ) ) ; 
                __context__.SourceCodeLine = 2692;
                TITLE_REMAINING  .Value = (ushort) ( (TITLE_LENGTH  .Value - TITLE_LOCATION  .Value) ) ; 
                __context__.SourceCodeLine = 2694;
                MUSIC_PLAYBACK_ACTIVE  .Value = (ushort) ( Functions.BoolToInt (Byte( ARGS[ 2 ] , (int)( 1 ) ) != 48) ) ; 
                __context__.SourceCodeLine = 2696;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TITLE_LENGTH  .Value != 0))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2699;
                    TITLE_LEVEL  .Value = (ushort) ( ((TITLE_LOCATION  .Value * 65535) / TITLE_LENGTH  .Value) ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 2703;
                    TITLE_LEVEL  .Value = (ushort) ( 0 ) ; 
                    } 
                
                } 
            
            else 
                {
                __context__.SourceCodeLine = 2706;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGSCREEN_MASK))  ) ) 
                    { 
                    __context__.SourceCodeLine = 2708;
                    GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 8 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                    __context__.SourceCodeLine = 2710;
                    MASK_DATA  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                    __context__.SourceCodeLine = 2711;
                    MASK_CONSERVATIVE  .Value = (ushort) ( Functions.Atoi( ARGS[ 5 ] ) ) ; 
                    __context__.SourceCodeLine = 2712;
                    MASK_ABS_TOP  .Value = (ushort) ( Functions.Atoi( ARGS[ 6 ] ) ) ; 
                    __context__.SourceCodeLine = 2713;
                    MASK_ABS_BOTTOM  .Value = (ushort) ( Functions.Atoi( ARGS[ 7 ] ) ) ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 2715;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGSCREEN_MASK2))  ) ) 
                        { 
                        __context__.SourceCodeLine = 2717;
                        GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 6 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                        __context__.SourceCodeLine = 2719;
                        MASK_CALIBRATED_TOP  .Value = (ushort) ( Functions.Atoi( ARGS[ 4 ] ) ) ; 
                        __context__.SourceCodeLine = 2720;
                        MASK_CALIBRATED_BOTTOM  .Value = (ushort) ( Functions.Atoi( ARGS[ 5 ] ) ) ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 2722;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGTITLE_NAME))  ) ) 
                            { 
                            __context__.SourceCodeLine = 2724;
                            GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                            __context__.SourceCodeLine = 2726;
                            NOW_PLAYING_TITLE_NAME__DOLLAR__  .UpdateValue ( ARGS [ 2]  ) ; 
                            __context__.SourceCodeLine = 2727;
                            _MOVIETITLE  .UpdateValue ( ARGS [ 2]  ) ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 2729;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGMUSIC_TITLE))  ) ) 
                                { 
                                __context__.SourceCodeLine = 2731;
                                GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 7 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                __context__.SourceCodeLine = 2733;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 2 ] == ""))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2735;
                                    NOW_PLAYING_TITLE_NAME__DOLLAR__  .UpdateValue ( _MOVIETITLE  ) ; 
                                    } 
                                
                                else 
                                    { 
                                    __context__.SourceCodeLine = 2739;
                                    NOW_PLAYING_TITLE_NAME__DOLLAR__  .UpdateValue ( ARGS [ 2]  ) ; 
                                    } 
                                
                                __context__.SourceCodeLine = 2741;
                                NOW_PLAYING_ARTIST_NAME__DOLLAR__  .UpdateValue ( NULLTOSPACE (  __context__ , ARGS[ 3 ])  ) ; 
                                __context__.SourceCodeLine = 2742;
                                NOW_PLAYING_ALBUM_NAME_OR_CHAPTER__DOLLAR__  .UpdateValue ( NULLTOSPACE (  __context__ , ARGS[ 4 ])  ) ; 
                                __context__.SourceCodeLine = 2745;
                                NOW_PLAYING_COVER_ART_URL__DOLLAR__  .UpdateValue ( ""  ) ; 
                                __context__.SourceCodeLine = 2748;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 6 ] != ""))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2750;
                                    REQUESTNOWPLAYINGDETAILS (  __context__ , ARGS[ 6 ]) ; 
                                    } 
                                
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 2754;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGUI_STATE))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 2756;
                                    GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 6 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                    __context__.SourceCodeLine = 2758;
                                    NEWOSDSCREEN = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                    __context__.SourceCodeLine = 2761;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( OSD_SCREEN  .Value < 8 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NEWOSDSCREEN >= 8 ) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( OSD_SCREEN  .Value > 8 ) ) && Functions.TestForTrue ( Functions.BoolToInt ( NEWOSDSCREEN <= 8 ) )) ) )) ))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 2764;
                                        DETAILS_VISIBLE  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    __context__.SourceCodeLine = 2767;
                                    OSD_SCREEN  .Value = (ushort) ( NEWOSDSCREEN ) ; 
                                    __context__.SourceCodeLine = 2768;
                                    OSD_POPUP  .Value = (ushort) ( Functions.Atoi( ARGS[ 3 ] ) ) ; 
                                    __context__.SourceCodeLine = 2769;
                                    OSD_DIALOG  .Value = (ushort) ( Functions.Atoi( ARGS[ 4 ] ) ) ; 
                                    __context__.SourceCodeLine = 2770;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( ARGS[ 5 ] , (int)( 1 ) ) == 49))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 2772;
                                        OSD_SAVER  .Value = (ushort) ( 1 ) ; 
                                        } 
                                    
                                    else 
                                        { 
                                        __context__.SourceCodeLine = 2776;
                                        OSD_SAVER  .Value = (ushort) ( 0 ) ; 
                                        } 
                                    
                                    } 
                                
                                else 
                                    {
                                    __context__.SourceCodeLine = 2780;
                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGCHILD_MODE_STATE))  ) ) 
                                        { 
                                        __context__.SourceCodeLine = 2782;
                                        GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                        __context__.SourceCodeLine = 2784;
                                        CHILD_MODE_STATE  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                        } 
                                    
                                    else 
                                        {
                                        __context__.SourceCodeLine = 2786;
                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGMOVIE_MEDIA_TYPE))  ) ) 
                                            { 
                                            __context__.SourceCodeLine = 2788;
                                            GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                            __context__.SourceCodeLine = 2790;
                                            MEDIA_TYPE  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                            } 
                                        
                                        else 
                                            {
                                            __context__.SourceCodeLine = 2793;
                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGMOVIE_LOCATION))  ) ) 
                                                { 
                                                __context__.SourceCodeLine = 2795;
                                                GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                __context__.SourceCodeLine = 2797;
                                                MOVIE_LOCATION  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                } 
                                            
                                            else 
                                                {
                                                __context__.SourceCodeLine = 2799;
                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGCINEMASCAPE_MODE))  ) ) 
                                                    { 
                                                    __context__.SourceCodeLine = 2801;
                                                    GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                    __context__.SourceCodeLine = 2803;
                                                    CINEMASCAPE_MODE  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                    __context__.SourceCodeLine = 2805;
                                                    if ( Functions.TestForTrue  ( ( CINEMASCAPE_MODE  .Value)  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 2807;
                                                        SEND (  __context__ , "GET_CINEMASCAPE_MASK:") ; 
                                                        } 
                                                    
                                                    } 
                                                
                                                else 
                                                    {
                                                    __context__.SourceCodeLine = 2810;
                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGSCALE_MODE))  ) ) 
                                                        { 
                                                        __context__.SourceCodeLine = 2812;
                                                        GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                        __context__.SourceCodeLine = 2814;
                                                        CINEMASCAPE_SCALE_MODE  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                        } 
                                                    
                                                    else 
                                                        {
                                                        __context__.SourceCodeLine = 2816;
                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGCINEMASCAPE_MASK))  ) ) 
                                                            { 
                                                            __context__.SourceCodeLine = 2818;
                                                            GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                            __context__.SourceCodeLine = 2820;
                                                            CINEMASCAPE_MASK  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                            } 
                                                        
                                                        else 
                                                            {
                                                            __context__.SourceCodeLine = 2822;
                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGASPECT_RATIO))  ) ) 
                                                                { 
                                                                __context__.SourceCodeLine = 2824;
                                                                GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 4 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                __context__.SourceCodeLine = 2826;
                                                                IMAGE_ASPECT_RATIO  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                                __context__.SourceCodeLine = 2827;
                                                                FRAME_ASPECT_RATIO  .Value = (ushort) ( Functions.Atoi( ARGS[ 3 ] ) ) ; 
                                                                } 
                                                            
                                                            else 
                                                                {
                                                                __context__.SourceCodeLine = 2829;
                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGDEVICE_INFO))  ) ) 
                                                                    { 
                                                                    __context__.SourceCodeLine = 2831;
                                                                    GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 4 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                    __context__.SourceCodeLine = 2832;
                                                                    _PLAYERSN  .UpdateValue ( ARGS [ 3]  ) ; 
                                                                    __context__.SourceCodeLine = 2833;
                                                                    CONNECTIONEVENT (  __context__ , (ushort)( 2 )) ; 
                                                                    } 
                                                                
                                                                else 
                                                                    {
                                                                    __context__.SourceCodeLine = 2835;
                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGNUM_ZONES))  ) ) 
                                                                        { 
                                                                        __context__.SourceCodeLine = 2837;
                                                                        GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 4 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                        __context__.SourceCodeLine = 2839;
                                                                        _NUMVIDZONES = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                                        __context__.SourceCodeLine = 2840;
                                                                        _NUMAUDZONES = (ushort) ( Functions.Atoi( ARGS[ 3 ] ) ) ; 
                                                                        __context__.SourceCodeLine = 2842;
                                                                        if ( Functions.TestForTrue  ( ( VALIDATEDEVICE( __context__ , _MODULESHORTDESCRIPTION , (ushort)( STATED_PLAYER_ID  .UshortValue ) , _DEVICENAME , (ushort)( _NUMVIDZONES ) , (ushort)( _NUMAUDZONES ) , (ushort)( 0 ) ))  ) ) 
                                                                            {
                                                                            __context__.SourceCodeLine = 2843;
                                                                            CONNECTIONEVENT (  __context__ , (ushort)( 5 )) ; 
                                                                            }
                                                                        
                                                                        } 
                                                                    
                                                                    else 
                                                                        {
                                                                        __context__.SourceCodeLine = 2845;
                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGDEVICE_TYPE_NAME))  ) ) 
                                                                            { 
                                                                            __context__.SourceCodeLine = 2847;
                                                                            GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                            __context__.SourceCodeLine = 2848;
                                                                            _DEVICENAME  .UpdateValue ( ARGS [ 2]  ) ; 
                                                                            } 
                                                                        
                                                                        else 
                                                                            {
                                                                            __context__.SourceCodeLine = 2850;
                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGDEVICE_POWER_STATE))  ) ) 
                                                                                { 
                                                                                __context__.SourceCodeLine = 2852;
                                                                                GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                __context__.SourceCodeLine = 2856;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( ARGS[ 2 ] , (int)( 1 ) ) != 48))  ) ) 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 2857;
                                                                                    CONNECTIONEVENT (  __context__ , (ushort)( 3 )) ; 
                                                                                    }
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 2859;
                                                                                    CONNECTIONEVENT (  __context__ , (ushort)( 4 )) ; 
                                                                                    }
                                                                                
                                                                                } 
                                                                            
                                                                            else 
                                                                                {
                                                                                __context__.SourceCodeLine = 2862;
                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGPROTOCOL))  ) ) 
                                                                                    { 
                                                                                    __context__.SourceCodeLine = 2864;
                                                                                    GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                    __context__.SourceCodeLine = 2866;
                                                                                    PROTOCOL_VERSION  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                                                    __context__.SourceCodeLine = 2868;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( PROTOCOL_VERSION  .Value < 5 ))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 2870;
                                                                                        MOVIES_AVAILABLE  .Value = (ushort) ( 1 ) ; 
                                                                                        __context__.SourceCodeLine = 2871;
                                                                                        MUSIC_AVAILABLE  .Value = (ushort) ( 0 ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 2879;
                                                                                        MOVIES_AVAILABLE  .Value = (ushort) ( 1 ) ; 
                                                                                        __context__.SourceCodeLine = 2880;
                                                                                        MUSIC_AVAILABLE  .Value = (ushort) ( 1 ) ; 
                                                                                        } 
                                                                                    
                                                                                    } 
                                                                                
                                                                                else 
                                                                                    {
                                                                                    __context__.SourceCodeLine = 2883;
                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGUSER_INPUT))  ) ) 
                                                                                        { 
                                                                                        __context__.SourceCodeLine = 2885;
                                                                                        GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 5 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                        __context__.SourceCodeLine = 2887;
                                                                                        USER_INPUT  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                                                        __context__.SourceCodeLine = 2888;
                                                                                        USER_INPUT_PROMPT__DOLLAR__  .UpdateValue ( NULLTOSPACE (  __context__ , ARGS[ 3 ])  ) ; 
                                                                                        __context__.SourceCodeLine = 2889;
                                                                                        USER_INPUT_TEXT__DOLLAR__  .UpdateValue ( NULLTOSPACE (  __context__ , ARGS[ 4 ])  ) ; 
                                                                                        } 
                                                                                    
                                                                                    else 
                                                                                        {
                                                                                        __context__.SourceCodeLine = 2891;
                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGCAMERA_ANGLE))  ) ) 
                                                                                            { 
                                                                                            __context__.SourceCodeLine = 2893;
                                                                                            GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 5 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                            __context__.SourceCodeLine = 2895;
                                                                                            CURRENT_CAMERA_ANGLE  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                                                            __context__.SourceCodeLine = 2896;
                                                                                            NUM_CAMERA_ANGLES  .Value = (ushort) ( Functions.Atoi( ARGS[ 3 ] ) ) ; 
                                                                                            __context__.SourceCodeLine = 2898;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Byte( ARGS[ 4 ] , (int)( 1 ) ) == 48))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 2900;
                                                                                                CAMERA_ANGLES_AVAILABLE  .Value = (ushort) ( 0 ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 2904;
                                                                                                CAMERA_ANGLES_AVAILABLE  .Value = (ushort) ( 1 ) ; 
                                                                                                } 
                                                                                            
                                                                                            } 
                                                                                        
                                                                                        else 
                                                                                            {
                                                                                            __context__.SourceCodeLine = 2907;
                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGVIDEO_MODE))  ) ) 
                                                                                                { 
                                                                                                __context__.SourceCodeLine = 2909;
                                                                                                GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 5 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                                __context__.SourceCodeLine = 2911;
                                                                                                VIDEO_MODE_COMPOSITE  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                                                                __context__.SourceCodeLine = 2912;
                                                                                                VIDEO_MODE_COMPONENT  .Value = (ushort) ( Functions.Atoi( ARGS[ 3 ] ) ) ; 
                                                                                                __context__.SourceCodeLine = 2913;
                                                                                                VIDEO_MODE_HDMI  .Value = (ushort) ( Functions.Atoi( ARGS[ 4 ] ) ) ; 
                                                                                                } 
                                                                                            
                                                                                            else 
                                                                                                {
                                                                                                __context__.SourceCodeLine = 2915;
                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGUSER_DEFINED_EVENT))  ) ) 
                                                                                                    { 
                                                                                                    __context__.SourceCodeLine = 2917;
                                                                                                    GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                                    __context__.SourceCodeLine = 2920;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 2 ] == MSGVOLUME_UP_PRESS))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 2922;
                                                                                                        VOLUME_UP  .Value = (ushort) ( 1 ) ; 
                                                                                                        __context__.SourceCodeLine = 2924;
                                                                                                        VOLUME_DOWN  .Value = (ushort) ( 0 ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 2926;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 2 ] == MSGVOLUME_UP_RELEASE))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 2928;
                                                                                                            VOLUME_UP  .Value = (ushort) ( 0 ) ; 
                                                                                                            __context__.SourceCodeLine = 2930;
                                                                                                            VOLUME_DOWN  .Value = (ushort) ( 0 ) ; 
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 2932;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 2 ] == MSGVOLUME_UP))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 2934;
                                                                                                                Functions.Pulse ( 5, VOLUME_UP ) ; 
                                                                                                                __context__.SourceCodeLine = 2936;
                                                                                                                VOLUME_DOWN  .Value = (ushort) ( 0 ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 2938;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 2 ] == MSGVOLUME_DOWN_PRESS))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 2940;
                                                                                                                    VOLUME_DOWN  .Value = (ushort) ( 1 ) ; 
                                                                                                                    __context__.SourceCodeLine = 2942;
                                                                                                                    VOLUME_UP  .Value = (ushort) ( 0 ) ; 
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 2944;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 2 ] == MSGVOLUME_DOWN_RELEASE))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 2946;
                                                                                                                        VOLUME_DOWN  .Value = (ushort) ( 0 ) ; 
                                                                                                                        __context__.SourceCodeLine = 2948;
                                                                                                                        VOLUME_UP  .Value = (ushort) ( 0 ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 2950;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 2 ] == MSGVOLUME_DOWN))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 2952;
                                                                                                                            Functions.Pulse ( 1, VOLUME_DOWN ) ; 
                                                                                                                            __context__.SourceCodeLine = 2954;
                                                                                                                            VOLUME_UP  .Value = (ushort) ( 0 ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 2956;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 2 ] == MSGTOGGLE_MUTE))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 2958;
                                                                                                                                Functions.Pulse ( 1, VOLUME_MUTE ) ; 
                                                                                                                                __context__.SourceCodeLine = 2960;
                                                                                                                                VOLUME_UP  .Value = (ushort) ( 0 ) ; 
                                                                                                                                __context__.SourceCodeLine = 2961;
                                                                                                                                VOLUME_DOWN  .Value = (ushort) ( 0 ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            else 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 2965;
                                                                                                                                USER_DEFINED_EVENT__DOLLAR__  .UpdateValue ( ARGS [ 2]  ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            }
                                                                                                                        
                                                                                                                        }
                                                                                                                    
                                                                                                                    }
                                                                                                                
                                                                                                                }
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        }
                                                                                                    
                                                                                                    __context__.SourceCodeLine = 2968;
                                                                                                    Functions.Delay (  (int) ( 1 ) ) ; 
                                                                                                    __context__.SourceCodeLine = 2969;
                                                                                                    USER_DEFINED_EVENT__DOLLAR__  .UpdateValue ( ""  ) ; 
                                                                                                    } 
                                                                                                
                                                                                                else 
                                                                                                    {
                                                                                                    __context__.SourceCodeLine = 2971;
                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGFRIENDLY_NAME))  ) ) 
                                                                                                        { 
                                                                                                        __context__.SourceCodeLine = 2973;
                                                                                                        GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                                        __context__.SourceCodeLine = 2975;
                                                                                                        FRIENDLY_NAME__DOLLAR__  .UpdateValue ( ARGS [ 2]  ) ; 
                                                                                                        } 
                                                                                                    
                                                                                                    else 
                                                                                                        {
                                                                                                        __context__.SourceCodeLine = 2977;
                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGCONTROLLED_ZONE))  ) ) 
                                                                                                            { 
                                                                                                            __context__.SourceCodeLine = 2979;
                                                                                                            GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                                            __context__.SourceCodeLine = 2981;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_MUSICCONTROLSN__DOLLAR__ != Functions.Mid( ARGS[ 2 ] , (int)( 2 ) , (int)( 12 ) )))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 2983;
                                                                                                                _MUSICCONTROLCPDID__DOLLAR__  .UpdateValue ( ""  ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            __context__.SourceCodeLine = 2986;
                                                                                                            _MUSICCONTROLSN__DOLLAR__  .UpdateValue ( Functions.Mid ( ARGS [ 2] ,  (int) ( 2 ) ,  (int) ( 12 ) )  ) ; 
                                                                                                            __context__.SourceCodeLine = 2987;
                                                                                                            _MUSICCONTROLZONE__DOLLAR__  .UpdateValue ( Functions.Mid ( ARGS [ 2] ,  (int) ( 15 ) ,  (int) ( 2 ) )  ) ; 
                                                                                                            __context__.SourceCodeLine = 2989;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_MUSICCONTROLSN__DOLLAR__ == Functions.Right( _PLAYERSN , (int)( 12 ) )))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 2991;
                                                                                                                MakeString ( _MUSICCONTROLCPDID__DOLLAR__ , "{0:d2}", (short)STATED_PLAYER_ID  .UshortValue) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            __context__.SourceCodeLine = 2994;
                                                                                                            MakeString ( CONTROLLED_MUSIC_SN_ZONE__DOLLAR__ , "{0}.{1}", _MUSICCONTROLSN__DOLLAR__ , _MUSICCONTROLZONE__DOLLAR__ ) ; 
                                                                                                            __context__.SourceCodeLine = 2996;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_MUSICCONTROLCPDID__DOLLAR__ == ""))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 2998;
                                                                                                                MakeString ( TX__DOLLAR__ , "#{0}/0/GET_DEVICE_INFO:\r\n", _MUSICCONTROLSN__DOLLAR__ ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 3002;
                                                                                                                MakeString ( CONTROLLED_MUSIC_CPDID_ZONE__DOLLAR__ , "{0}.{1}", _MUSICCONTROLCPDID__DOLLAR__ , _MUSICCONTROLZONE__DOLLAR__ ) ; 
                                                                                                                } 
                                                                                                            
                                                                                                            } 
                                                                                                        
                                                                                                        else 
                                                                                                            {
                                                                                                            __context__.SourceCodeLine = 3006;
                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGHIGHLIGHTED_SELECTION))  ) ) 
                                                                                                                { 
                                                                                                                __context__.SourceCodeLine = 3008;
                                                                                                                GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                                                __context__.SourceCodeLine = 3010;
                                                                                                                DETAILS_VISIBLE  .Value = (ushort) ( 0 ) ; 
                                                                                                                __context__.SourceCodeLine = 3011;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( IsSignalDefined( DETAILS_TEXT__DOLLAR__ ) ) || Functions.TestForTrue ( IsSignalDefined( DETAILS_TITLE__DOLLAR__ ) )) ) ) || Functions.TestForTrue ( IsSignalDefined( DETAILS_COVER_URL__DOLLAR__ ) )) ))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 3015;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 2 ] != ""))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 3017;
                                                                                                                        REQUESTBROWSEDETAILS (  __context__ , ARGS[ 2 ]) ; 
                                                                                                                        __context__.SourceCodeLine = 3018;
                                                                                                                        _HANDLE  .UpdateValue ( ARGS [ 2]  ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    } 
                                                                                                                
                                                                                                                } 
                                                                                                            
                                                                                                            else 
                                                                                                                {
                                                                                                                __context__.SourceCodeLine = 3022;
                                                                                                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGCONTENT_DETAILS_OVERVIEW))  ) ) 
                                                                                                                    { 
                                                                                                                    __context__.SourceCodeLine = 3024;
                                                                                                                    GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 5 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                                                    __context__.SourceCodeLine = 3025;
                                                                                                                    if ( Functions.TestForTrue  ( ( _BROWSEDETAILSLOADING)  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 3027;
                                                                                                                        DETAILS_TEXT__DOLLAR__  .UpdateValue ( " "  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3028;
                                                                                                                        _CONTENTDETAIL . NUMDETAILSEXPECTED = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                                                                                        __context__.SourceCodeLine = 3029;
                                                                                                                        _CONTENTDETAIL . LIBRARY  .UpdateValue ( ARGS [ 4]  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3032;
                                                                                                                        _CONTENTDETAIL . TITLE  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3033;
                                                                                                                        _CONTENTDETAIL . ALBUMTITLE  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3034;
                                                                                                                        _CONTENTDETAIL . PERFORMER  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3035;
                                                                                                                        _CONTENTDETAIL . COMPOSER  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3036;
                                                                                                                        _CONTENTDETAIL . GENRE  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3037;
                                                                                                                        _CONTENTDETAIL . YEAR  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3038;
                                                                                                                        _CONTENTDETAIL . COVERURL  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3039;
                                                                                                                        _CONTENTDETAIL . RUNNINGTIME  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3040;
                                                                                                                        _CONTENTDETAIL . RATING  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3041;
                                                                                                                        _CONTENTDETAIL . RATINGREASON  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3042;
                                                                                                                        _CONTENTDETAIL . ALBUMCONTENTHANDLE  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3043;
                                                                                                                        _CONTENTDETAIL . SYNOPSIS  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3044;
                                                                                                                        _CONTENTDETAIL . DISCLOCATION  .UpdateValue ( ""  ) ; 
                                                                                                                        __context__.SourceCodeLine = 3045;
                                                                                                                        DETAILS_VISIBLE  .Value = (ushort) ( 0 ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 3047;
                                                                                                                        if ( Functions.TestForTrue  ( ( _NOWPLAYINGDETAILSLOADING)  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 3049;
                                                                                                                            _NUMBEROFDETAILS = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        }
                                                                                                                    
                                                                                                                    } 
                                                                                                                
                                                                                                                else 
                                                                                                                    {
                                                                                                                    __context__.SourceCodeLine = 3052;
                                                                                                                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGCONTENT_DETAILS))  ) ) 
                                                                                                                        { 
                                                                                                                        __context__.SourceCodeLine = 3054;
                                                                                                                        GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 5 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                                                        __context__.SourceCodeLine = 3055;
                                                                                                                        RECEIVECONTENTDETAIL (  __context__ ,   ref  ARGS ) ; 
                                                                                                                        } 
                                                                                                                    
                                                                                                                    else 
                                                                                                                        {
                                                                                                                        __context__.SourceCodeLine = 3057;
                                                                                                                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGSYSTEM_READINESS))  ) ) 
                                                                                                                            { 
                                                                                                                            __context__.SourceCodeLine = 3059;
                                                                                                                            GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 3 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                                                            __context__.SourceCodeLine = 3060;
                                                                                                                            SYSTEM_READINESS_STATE  .Value = (ushort) ( Functions.Atoi( ARGS[ 2 ] ) ) ; 
                                                                                                                            } 
                                                                                                                        
                                                                                                                        else 
                                                                                                                            {
                                                                                                                            __context__.SourceCodeLine = 3062;
                                                                                                                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ARGS[ 1 ] == MSGDISC_IN_TRAY_SELECTION))  ) ) 
                                                                                                                                { 
                                                                                                                                __context__.SourceCodeLine = 3067;
                                                                                                                                GETNARGUMENTS (  __context__ , ARGS,   ref  NUMARGS , (ushort)( 7 ), MESSAGE,   ref  MESSAGEPOSITION ,   ref  MESSAGEEND ) ; 
                                                                                                                                __context__.SourceCodeLine = 3069;
                                                                                                                                DISC_IN_TRAY_MEDIA_TYPE  .Value = (ushort) ( Functions.Atoi( ARGS[ 3 ] ) ) ; 
                                                                                                                                __context__.SourceCodeLine = 3070;
                                                                                                                                DISC_IN_TRAY_OK_TO_IMPORT  .Value = (ushort) ( Functions.Atoi( ARGS[ 4 ] ) ) ; 
                                                                                                                                __context__.SourceCodeLine = 3071;
                                                                                                                                DISC_IN_TRAY_IMPORTED  .Value = (ushort) ( Functions.Atoi( ARGS[ 5 ] ) ) ; 
                                                                                                                                __context__.SourceCodeLine = 3072;
                                                                                                                                DISC_IN_TRAY_IMPORTING  .Value = (ushort) ( Functions.Atoi( ARGS[ 6 ] ) ) ; 
                                                                                                                                __context__.SourceCodeLine = 3074;
                                                                                                                                SHOW_DISC_IN_TRAY_BUTTON  .Value = (ushort) ( Functions.BoolToInt ( 0 < Functions.Atoi( ARGS[ 3 ] ) ) ) ; 
                                                                                                                                } 
                                                                                                                            
                                                                                                                            }
                                                                                                                        
                                                                                                                        }
                                                                                                                    
                                                                                                                    }
                                                                                                                
                                                                                                                }
                                                                                                            
                                                                                                            }
                                                                                                        
                                                                                                        }
                                                                                                    
                                                                                                    }
                                                                                                
                                                                                                }
                                                                                            
                                                                                            }
                                                                                        
                                                                                        }
                                                                                    
                                                                                    }
                                                                                
                                                                                }
                                                                            
                                                                            }
                                                                        
                                                                        }
                                                                    
                                                                    }
                                                                
                                                                }
                                                            
                                                            }
                                                        
                                                        }
                                                    
                                                    }
                                                
                                                }
                                            
                                            }
                                        
                                        }
                                    
                                    }
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                }
            
            }
        
        }
    
    
    }
    
private void PROCESSRX (  SplusExecutionContext __context__ ) 
    { 
    CrestronString MESSAGE;
    MESSAGE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
    
    CrestronString [] ARGS;
    ARGS  = new CrestronString[ 16 ];
    for( uint i = 0; i < 16; i++ )
        ARGS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    
    ushort LOOP = 0;
    
    
    __context__.SourceCodeLine = 3085;
    while ( Functions.TestForTrue  ( ( 1)  ) ) 
        { 
        __context__.SourceCodeLine = 3087;
        MESSAGE  .UpdateValue ( Functions.Gather ( _DELIMITERS [ _CURRENTDELIMITER ] , RX__DOLLAR__ )  ) ; 
        __context__.SourceCodeLine = 3088;
        _FOUNDDELIMITER = (ushort) ( (_FOUNDDELIMITER + 1) ) ; 
        __context__.SourceCodeLine = 3091;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 0 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)15; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( LOOP  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (LOOP  >= __FN_FORSTART_VAL__1) && (LOOP  <= __FN_FOREND_VAL__1) ) : ( (LOOP  <= __FN_FORSTART_VAL__1) && (LOOP  >= __FN_FOREND_VAL__1) ) ; LOOP  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 3093;
            ARGS [ LOOP ]  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 3091;
            } 
        
        __context__.SourceCodeLine = 3096;
        PARSEMESSAGE (  __context__ , MESSAGE,   ref  ARGS ) ; 
        __context__.SourceCodeLine = 3085;
        } 
    
    
    }
    
object RX__DOLLAR___OnChange_0 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3106;
        if ( Functions.TestForTrue  ( ( _PARSINGFLAG)  ) ) 
            {
            __context__.SourceCodeLine = 3106;
            Functions.TerminateEvent (); 
            }
        
        __context__.SourceCodeLine = 3107;
        _PARSINGFLAG = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 3108;
        PROCESSRX (  __context__  ) ; 
        __context__.SourceCodeLine = 3109;
        _PARSINGFLAG = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object COMMAND_TO_PLAYER__DOLLAR___OnChange_1 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString COMMAND;
        COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
        
        
        __context__.SourceCodeLine = 3117;
        COMMAND  .UpdateValue ( COMMAND_TO_PLAYER__DOLLAR__ + ":"  ) ; 
        __context__.SourceCodeLine = 3118;
        SEND (  __context__ , COMMAND) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYBOARD_INPUT__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort KEY = 0;
        
        CrestronString ESCAPESTRING;
        ESCAPESTRING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
        
        CrestronString COMMAND;
        COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
        
        
        __context__.SourceCodeLine = 3128;
        while ( Functions.TestForTrue  ( ( Functions.Length( KEYBOARD_INPUT__DOLLAR__ ))  ) ) 
            { 
            __context__.SourceCodeLine = 3130;
            KEY = (ushort) ( Functions.GetC( KEYBOARD_INPUT__DOLLAR__ ) ) ; 
            __context__.SourceCodeLine = 3131;
            ESCAPESTRING  .UpdateValue ( ""  ) ; 
            __context__.SourceCodeLine = 3132;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (KEY == 47) ) || Functions.TestForTrue ( Functions.BoolToInt (KEY == 58) )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (KEY == 47) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 3136;
                ESCAPESTRING  .UpdateValue ( Functions.Chr (  (int) ( 47 ) )  ) ; 
                } 
            
            __context__.SourceCodeLine = 3140;
            MakeString ( COMMAND , "KEYBOARD_CHARACTER:{0}{1}:", ESCAPESTRING , Functions.Chr ( KEY ) ) ; 
            __context__.SourceCodeLine = 3141;
            SEND (  __context__ , COMMAND) ; 
            __context__.SourceCodeLine = 3128;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOUCH_CHANNEL_OnRelease_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3174;
        Functions.Delay (  (int) ( 100 ) ) ; 
        __context__.SourceCodeLine = 3175;
        _TOUCHPRESSED = (ushort) ( (_TOUCHPRESSED - 1) ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOUCH_CHANNEL_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort TIMEOUT = 0;
        
        CrestronString COMMAND;
        COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
        
        
        __context__.SourceCodeLine = 3183;
        if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
            { 
            __context__.SourceCodeLine = 3185;
            Trace( "({0}) Received Push.  X_Change = {1:d}, Y_Change = {2:d}, X:{3:d}, Y:{4:d}\r\n", _SYMBOLINSTANCE , (short)_TOUCHXCHANGED, (short)_TOUCHYCHANGED, (ushort)TOUCH_X  .UshortValue, (ushort)TOUCH_Y  .UshortValue) ; 
            } 
        
        __context__.SourceCodeLine = 3189;
        _TOUCHPRESSED = (ushort) ( (_TOUCHPRESSED + 1) ) ; 
        __context__.SourceCodeLine = 3191;
        TIMEOUT = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3192;
        Functions.Delay (  (int) ( 1 ) ) ; 
        __context__.SourceCodeLine = 3195;
        while ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (_TOUCHXCHANGED == 0) ) || Functions.TestForTrue ( Functions.BoolToInt (_TOUCHYCHANGED == 0) )) ) ) && Functions.TestForTrue ( Functions.BoolToInt ( TIMEOUT < 40 ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 3197;
            Functions.Delay (  (int) ( 1 ) ) ; 
            __context__.SourceCodeLine = 3198;
            TIMEOUT = (ushort) ( (TIMEOUT + 1) ) ; 
            __context__.SourceCodeLine = 3195;
            } 
        
        __context__.SourceCodeLine = 3201;
        if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
            { 
            __context__.SourceCodeLine = 3203;
            Trace( "({0}) Sending Push.  X_Change = {1:d}, Y_Change = {2:d}, X:{3:d}, Y:{4:d} (timeout={5:d})\r\n", _SYMBOLINSTANCE , (short)_TOUCHXCHANGED, (short)_TOUCHYCHANGED, (ushort)TOUCH_X  .UshortValue, (ushort)TOUCH_Y  .UshortValue, (short)TIMEOUT) ; 
            } 
        
        __context__.SourceCodeLine = 3207;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_TOUCHXCHANGED == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 3209;
            Trace( "Kaleidescape ({0}) OSD Module Error.  Touch press timeout with no touch coordinate X.\r\n", _SYMBOLINSTANCE ) ; 
            __context__.SourceCodeLine = 3210;
            Trace( "Check the signal path from the video window to the module.\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 3213;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_TOUCHYCHANGED == 0))  ) ) 
            { 
            __context__.SourceCodeLine = 3215;
            Trace( "Kaleidescape ({0}) OSD Module Error.  Touch press timeout with no touch coordinate Y.\r\n", _SYMBOLINSTANCE ) ; 
            __context__.SourceCodeLine = 3216;
            Trace( "Check the signal path from the video window to the module.\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 3219;
        MakeString ( COMMAND , "POSITION_SELECT:{0:d}:{1:d}:", (ushort)TOUCH_X  .UshortValue, (ushort)TOUCH_Y  .UshortValue) ; 
        __context__.SourceCodeLine = 3220;
        SEND (  __context__ , COMMAND) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOUCH_X_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort MYCHANGE = 0;
        
        
        __context__.SourceCodeLine = 3228;
        if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 3228;
            Trace( "({0}) Received X:{1:d}\r\n", _SYMBOLINSTANCE , (ushort)TOUCH_X  .UshortValue) ; 
            }
        
        __context__.SourceCodeLine = 3230;
        _TOUCHXCHANGED = (ushort) ( (_TOUCHXCHANGED + 1) ) ; 
        __context__.SourceCodeLine = 3231;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _TOUCHXCHANGED > 65530 ))  ) ) 
            {
            __context__.SourceCodeLine = 3231;
            _TOUCHXCHANGED = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 3233;
        MYCHANGE = (ushort) ( _TOUCHXCHANGED ) ; 
        __context__.SourceCodeLine = 3234;
        Functions.Delay (  (int) ( 40 ) ) ; 
        __context__.SourceCodeLine = 3235;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MYCHANGE == _TOUCHXCHANGED))  ) ) 
            { 
            __context__.SourceCodeLine = 3237;
            _TOUCHXCHANGED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 3239;
            if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 3239;
                Trace( "({0}) X expired.  my_change={1:d}\r\n", _SYMBOLINSTANCE , (short)MYCHANGE) ; 
                }
            
            __context__.SourceCodeLine = 3241;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_TOUCHPRESSED == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 3243;
                Trace( "Kaleidescape ({0}) OSD Module Error.  Received X Change from video window, but did not receive the digital event.\r\nCheck the signal path from the video window to the module.\r\n", _SYMBOLINSTANCE ) ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object TOUCH_Y_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort MYCHANGE = 0;
        
        
        __context__.SourceCodeLine = 3252;
        if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
            {
            __context__.SourceCodeLine = 3252;
            Trace( "({0}) Received Y:{1:d}\r\n", _SYMBOLINSTANCE , (ushort)TOUCH_Y  .UshortValue) ; 
            }
        
        __context__.SourceCodeLine = 3254;
        _TOUCHYCHANGED = (ushort) ( (_TOUCHYCHANGED + 1) ) ; 
        __context__.SourceCodeLine = 3255;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( _TOUCHYCHANGED > 65530 ))  ) ) 
            {
            __context__.SourceCodeLine = 3255;
            _TOUCHYCHANGED = (ushort) ( 1 ) ; 
            }
        
        __context__.SourceCodeLine = 3257;
        MYCHANGE = (ushort) ( _TOUCHYCHANGED ) ; 
        __context__.SourceCodeLine = 3258;
        Functions.Delay (  (int) ( 40 ) ) ; 
        __context__.SourceCodeLine = 3259;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MYCHANGE == _TOUCHYCHANGED))  ) ) 
            { 
            __context__.SourceCodeLine = 3261;
            _TOUCHYCHANGED = (ushort) ( 0 ) ; 
            __context__.SourceCodeLine = 3263;
            if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
                {
                __context__.SourceCodeLine = 3263;
                Trace( "({0}) Y expired.  my_change={1:d}\r\n", _SYMBOLINSTANCE , (short)MYCHANGE) ; 
                }
            
            __context__.SourceCodeLine = 3264;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (_TOUCHPRESSED == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 3266;
                Trace( "Kaleidescape ({0}) OSD Module Error.  Received Y Change from video window, but did", _SYMBOLINSTANCE ) ; 
                __context__.SourceCodeLine = 3267;
                Trace( " not receive the digital event.\r\nCheck the signal path from the video window") ; 
                __context__.SourceCodeLine = 3268;
                Trace( " to the module.\r\n") ; 
                } 
            
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PLAY_SCRIPT__DOLLAR___OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString COMMAND;
        COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
        
        
        __context__.SourceCodeLine = 3277;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (PLAY_SCRIPT__DOLLAR__ != ""))  ) ) 
            { 
            __context__.SourceCodeLine = 3279;
            COMMAND  .UpdateValue ( PLAY_SCRIPT__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 3280;
            COMMAND  .UpdateValue ( ESCAPE (  __context__ , COMMAND)  ) ; 
            __context__.SourceCodeLine = 3281;
            COMMAND  .UpdateValue ( "PLAY_SCRIPT:" + COMMAND + ":"  ) ; 
            __context__.SourceCodeLine = 3282;
            SEND (  __context__ , COMMAND) ; 
            __context__.SourceCodeLine = 3283;
            PLAY_SCRIPT__DOLLAR__  .UpdateValue ( ""  ) ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONSOLE_COMMAND__DOLLAR___OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString COMMAND;
        COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2048, this );
        
        
        __context__.SourceCodeLine = 3291;
        COMMAND  .UpdateValue ( Functions.Upper ( CONSOLE_COMMAND__DOLLAR__ )  ) ; 
        __context__.SourceCodeLine = 3293;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMMAND == "K HELP") ) || Functions.TestForTrue ( Functions.BoolToInt (COMMAND == "K?") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (COMMAND == "K ?") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 3295;
            Trace( "\r\n\r\nAll commands must be prefixed with userprogcmd.\r\n") ; 
            __context__.SourceCodeLine = 3296;
            Trace( "use \"K debug\" to start debugging and \"K stop debug\" to stop.\r\n") ; 
            __context__.SourceCodeLine = 3297;
            Trace( "\"K debug <device id>\" will start debugging only on the module using that device ID.\r\n") ; 
            __context__.SourceCodeLine = 3298;
            Trace( "use \"K ver\" to obtain the module version information.\r\n") ; 
            __context__.SourceCodeLine = 3299;
            Trace( "use \"K id\" to obtain the module device ID.\r\n") ; 
            __context__.SourceCodeLine = 3300;
            Trace( "use \"K stop\" to stop all playback.\r\n\r\n") ; 
            } 
        
        __context__.SourceCodeLine = 3303;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMMAND == "K DEBUG") ) || Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (Functions.Left( COMMAND , (int)( 8 ) ) == "K DEBUG ") ) && Functions.TestForTrue ( Functions.BoolToInt (Functions.Atoi( Functions.Right( COMMAND , (int)( 2 ) ) ) == _PLAYERID) )) ) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 3306;
            Trace( "Enabling Kaleidescape module debugging output for symbol {0}\r\n", _SYMBOLINSTANCE ) ; 
            __context__.SourceCodeLine = 3307;
            Trace( "{0}\r\n", _MODULEDESCRIPTION ) ; 
            __context__.SourceCodeLine = 3308;
            _DEBUG = (ushort) ( 1 ) ; 
            } 
        
        __context__.SourceCodeLine = 3311;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMMAND == "K STOP DEBUG") ) || Functions.TestForTrue ( Functions.BoolToInt (COMMAND == "K NO DEBUG") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (COMMAND == "K DEBUG STOP") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 3313;
            Trace( "Disabling Kaleidescape module debugging output for symbol {0}.\r\n", _SYMBOLINSTANCE ) ; 
            __context__.SourceCodeLine = 3314;
            _DEBUG = (ushort) ( 0 ) ; 
            } 
        
        __context__.SourceCodeLine = 3317;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (COMMAND == "K VER") ) || Functions.TestForTrue ( Functions.BoolToInt (COMMAND == "K VERSION") )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 3319;
            Trace( "{0} - Device ID {1:d}, Symbol {2}\r\n", _MODULEDESCRIPTION , (short)_PLAYERID, _SYMBOLINSTANCE ) ; 
            } 
        
        __context__.SourceCodeLine = 3322;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMAND == "K ID"))  ) ) 
            { 
            __context__.SourceCodeLine = 3324;
            Trace( "({0}) Device ID {1:d}\r\n", _SYMBOLINSTANCE , (short)_PLAYERID) ; 
            } 
        
        __context__.SourceCodeLine = 3327;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (COMMAND == "K STOP"))  ) ) 
            { 
            __context__.SourceCodeLine = 3329;
            SEND (  __context__ , "STOP:") ; 
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONNECTION_OPEN_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3336;
        CONNECTIONEVENT (  __context__ , (ushort)( 101 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONNECTION_OPEN_OnRelease_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3341;
        CONNECTIONEVENT (  __context__ , (ushort)( 102 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_ON_TRIGGER_OnPush_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3347;
        CONNECTIONEVENT (  __context__ , (ushort)( 107 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_ON_TRIGGER_OnRelease_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3352;
        CONNECTIONEVENT (  __context__ , (ushort)( 108 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_OFF_TRIGGER_OnPush_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3357;
        CONNECTIONEVENT (  __context__ , (ushort)( 109 )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object REFRESH_DETAILS_OnPush_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 3362;
        SEND (  __context__ , "GET_HIGHLIGHTED_SELECTION:") ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTROL_MUSIC_ZONE__DOLLAR___OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        ushort DOT = 0;
        
        CrestronString TARGET;
        TARGET  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
        
        CrestronString ZONE;
        ZONE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 5, this );
        
        
        __context__.SourceCodeLine = 3371;
        DOT = (ushort) ( Functions.Find( "." , CONTROL_MUSIC_ZONE__DOLLAR__ ) ) ; 
        __context__.SourceCodeLine = 3372;
        if ( Functions.TestForTrue  ( ( DOT)  ) ) 
            { 
            __context__.SourceCodeLine = 3374;
            TARGET  .UpdateValue ( Functions.Mid ( CONTROL_MUSIC_ZONE__DOLLAR__ ,  (int) ( 1 ) ,  (int) ( (DOT - 1) ) )  ) ; 
            __context__.SourceCodeLine = 3375;
            ZONE  .UpdateValue ( Functions.Mid ( CONTROL_MUSIC_ZONE__DOLLAR__ ,  (int) ( (DOT + 1) ) ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 3376;
            ZONE  .UpdateValue ( "00" + ZONE  ) ; 
            __context__.SourceCodeLine = 3377;
            ZONE  .UpdateValue ( Functions.Right ( ZONE ,  (int) ( 2 ) )  ) ; 
            __context__.SourceCodeLine = 3379;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (ZONE == "00"))  ) ) 
                {
                __context__.SourceCodeLine = 3379;
                ZONE  .UpdateValue ( "01"  ) ; 
                }
            
            __context__.SourceCodeLine = 3380;
            _MUSICCONTROLZONE__DOLLAR__  .UpdateValue ( ZONE  ) ; 
            } 
        
        else 
            { 
            __context__.SourceCodeLine = 3384;
            TARGET  .UpdateValue ( CONTROL_MUSIC_ZONE__DOLLAR__  ) ; 
            __context__.SourceCodeLine = 3385;
            _MUSICCONTROLZONE__DOLLAR__  .UpdateValue ( "01"  ) ; 
            } 
        
        __context__.SourceCodeLine = 3389;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.BoolToInt (TARGET == "") ) || Functions.TestForTrue ( Functions.BoolToInt (TARGET == "01") )) ) ) || Functions.TestForTrue ( Functions.BoolToInt (Functions.Atoi( TARGET ) == STATED_PLAYER_ID  .UshortValue) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 3391;
            _MUSICCONTROLSN__DOLLAR__  .UpdateValue ( Functions.Right ( _PLAYERSN ,  (int) ( 12 ) )  ) ; 
            __context__.SourceCodeLine = 3392;
            MakeString ( _MUSICCONTROLCPDID__DOLLAR__ , "{0:d2}", (short)STATED_PLAYER_ID  .UshortValue) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 3394;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( Functions.Length( TARGET ) > 2 ))  ) ) 
                { 
                __context__.SourceCodeLine = 3396;
                TARGET  .UpdateValue ( "0000000000" + TARGET  ) ; 
                __context__.SourceCodeLine = 3397;
                _MUSICCONTROLSN__DOLLAR__  .UpdateValue ( Functions.Right ( TARGET ,  (int) ( 12 ) )  ) ; 
                __context__.SourceCodeLine = 3398;
                _MUSICCONTROLCPDID__DOLLAR__  .UpdateValue ( ""  ) ; 
                } 
            
            else 
                { 
                __context__.SourceCodeLine = 3402;
                TARGET  .UpdateValue ( "0" + TARGET  ) ; 
                __context__.SourceCodeLine = 3403;
                _MUSICCONTROLCPDID__DOLLAR__  .UpdateValue ( Functions.Right ( TARGET ,  (int) ( 2 ) )  ) ; 
                __context__.SourceCodeLine = 3404;
                _MUSICCONTROLSN__DOLLAR__  .UpdateValue ( ""  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 3407;
        SETCONTROLLEDZONE (  __context__  ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

public override object FunctionMain (  object __obj__ ) 
    { 
    ushort LASTDATE = 0;
    
    ushort IDLECOUNT = 0;
    
    ushort LASTFOUNDDELIMITER = 0;
    
    ushort LASTTXCOUNT = 0;
    
    ushort LASTRXEMPTY = 0;
    
    short RESIZESTRINGSTATUS = 0;
    
    CrestronString COMMAND;
    COMMAND  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    
    CrestronString OTHERDELIMITER;
    OTHERDELIMITER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    
    try
    {
        SplusExecutionContext __context__ = SplusFunctionMainStartCode();
        
        __context__.SourceCodeLine = 3426;
        _DEBUG = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3428;
        _DELIMITERS [ 0 ]  .UpdateValue ( "\u000A"  ) ; 
        __context__.SourceCodeLine = 3429;
        _DELIMITERS [ 1 ]  .UpdateValue ( "\u0004"  ) ; 
        __context__.SourceCodeLine = 3431;
        _FIELDDELIMITER [ 0 ]  .UpdateValue ( ":"  ) ; 
        __context__.SourceCodeLine = 3432;
        _FIELDDELIMITER [ 1 ]  .UpdateValue ( "\u0002"  ) ; 
        __context__.SourceCodeLine = 3434;
        INITMESSAGES (  __context__  ) ; 
        __context__.SourceCodeLine = 3436;
        _CONTENTDETAIL . TITLE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 3437;
        _CONTENTDETAIL . GENRE  .UpdateValue ( ""  ) ; 
        __context__.SourceCodeLine = 3439;
        RESIZESTRINGSTATUS = (short) ( Functions.ResizeString( ref _SYMBOLINSTANCE , Functions.Length( GETSYMBOLINSTANCEUMC( __context__ ) ) , null ) ) ; 
        __context__.SourceCodeLine = 3440;
        _SYMBOLINSTANCE  .UpdateValue ( GETSYMBOLINSTANCEUMC (  __context__  )  ) ; 
        __context__.SourceCodeLine = 3442;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( _DEBUG ) || Functions.TestForTrue ( Functions.BoolToInt (RESIZESTRINGSTATUS != 0) )) ))  ) ) 
            { 
            __context__.SourceCodeLine = 3444;
            Trace( "{0}, Resize string operation status={1}.", _SYMBOLINSTANCE , Functions.ItoHex (  (int) ( RESIZESTRINGSTATUS ) ) ) ; 
            } 
        
        __context__.SourceCodeLine = 3447;
        _MODULEDESCRIPTION  .UpdateValue ( "Kaleidescape Player Crestron Module v8.4.0.  Mar 26, 2014 " + " Library version " + GETLIBRARYVERSION (  __context__  )  ) ; 
        __context__.SourceCodeLine = 3450;
        _MODULESHORTDESCRIPTION  .UpdateValue ( "OSD Module"  ) ; 
        __context__.SourceCodeLine = 3452;
        _PARSINGFLAG = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3453;
        _TOUCHPRESSED = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3456;
        _BROWSEDETAILSPENDING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3457;
        _BROWSEDETAILSLOADING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3458;
        _NOWPLAYINGDETAILSPENDING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3459;
        _NOWPLAYINGDETAILSLOADING = (ushort) ( 0 ) ; 
        __context__.SourceCodeLine = 3462;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 3464;
        Functions.Delay (  (int) ( 500 ) ) ; 
        __context__.SourceCodeLine = 3466;
        Trace( "{0} - Device ID {1:d}, Symbol {2}\r\n", _MODULEDESCRIPTION , (short)_PLAYERID, _SYMBOLINSTANCE ) ; 
        __context__.SourceCodeLine = 3468;
        CONNECTIONEVENT (  __context__ , (ushort)( 100 )) ; 
        __context__.SourceCodeLine = 3471;
        Functions.Delay (  (int) ( Functions.Random( (ushort)( 0 ) , (ushort)( 300 ) ) ) ) ; 
        __context__.SourceCodeLine = 3473;
        if ( Functions.TestForTrue  ( ( CONNECTION_OPEN  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 3475;
            CONNECTIONEVENT (  __context__ , (ushort)( 101 )) ; 
            } 
        
        __context__.SourceCodeLine = 3478;
        if ( Functions.TestForTrue  ( ( POWER_ON_TRIGGER  .Value)  ) ) 
            { 
            __context__.SourceCodeLine = 3480;
            CONNECTIONEVENT (  __context__ , (ushort)( 107 )) ; 
            } 
        
        __context__.SourceCodeLine = 3485;
        while ( Functions.TestForTrue  ( ( 1)  ) ) 
            { 
            __context__.SourceCodeLine = 3487;
            Functions.Delay (  (int) ( 200 ) ) ; 
            __context__.SourceCodeLine = 3488;
            IDLECOUNT = (ushort) ( (IDLECOUNT + 2) ) ; 
            __context__.SourceCodeLine = 3490;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Mod( IDLECOUNT , 10 ) == 0))  ) ) 
                { 
                __context__.SourceCodeLine = 3492;
                CONNECTIONEVENT (  __context__ , (ushort)( 105 )) ; 
                } 
            
            __context__.SourceCodeLine = 3495;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( IDLECOUNT >= 30 ))  ) ) 
                { 
                __context__.SourceCodeLine = 3497;
                IDLECOUNT = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 3498;
                CONNECTIONEVENT (  __context__ , (ushort)( 106 )) ; 
                } 
            
            __context__.SourceCodeLine = 3501;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LASTDATE != Functions.GetDateNum()))  ) ) 
                { 
                __context__.SourceCodeLine = 3503;
                LASTDATE = (ushort) ( Functions.GetDateNum() ) ; 
                __context__.SourceCodeLine = 3504;
                CONNECTIONEVENT (  __context__ , (ushort)( 104 )) ; 
                } 
            
            __context__.SourceCodeLine = 3508;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( LASTFOUNDDELIMITER ) ) && Functions.TestForTrue ( Functions.Not( _FOUNDDELIMITER ) )) ))  ) ) 
                { 
                __context__.SourceCodeLine = 3511;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( LASTTXCOUNT > 0 ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3513;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RX__DOLLAR__ == ""))  ) ) 
                        { 
                        __context__.SourceCodeLine = 3515;
                        CONNECTIONEVENT (  __context__ , (ushort)( 103 )) ; 
                        } 
                    
                    } 
                
                __context__.SourceCodeLine = 3520;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt ( (Functions.TestForTrue ( Functions.Not( LASTRXEMPTY ) ) && Functions.TestForTrue ( Functions.BoolToInt (RX__DOLLAR__ != "") )) ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 3522;
                    if ( Functions.TestForTrue  ( ( Functions.Find( _DELIMITERS[ Functions.Not( _CURRENTDELIMITER ) ] , RX__DOLLAR__ ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 3525;
                        if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 3525;
                            Trace( "({0}) Found other delimiter in receive buffer.  Switching delimiters.  _CurrentDelimiter = {1:d}\r\n", _SYMBOLINSTANCE , (short)_CURRENTDELIMITER) ; 
                            }
                        
                        __context__.SourceCodeLine = 3527;
                        SWITCHDELIMITERS (  __context__ , (ushort)( Functions.Not( _CURRENTDELIMITER ) )) ; 
                        } 
                    
                    else 
                        { 
                        __context__.SourceCodeLine = 3534;
                        if ( Functions.TestForTrue  ( ( _DEBUG)  ) ) 
                            {
                            __context__.SourceCodeLine = 3534;
                            Trace( "({0}) Garbage in receive buffer, clearing:  {1}\r\n", _SYMBOLINSTANCE , RX__DOLLAR__ ) ; 
                            }
                        
                        __context__.SourceCodeLine = 3535;
                        Functions.ClearBuffer ( RX__DOLLAR__ ) ; 
                        } 
                    
                    } 
                
                } 
            
            __context__.SourceCodeLine = 3541;
            LASTFOUNDDELIMITER = (ushort) ( _FOUNDDELIMITER ) ; 
            __context__.SourceCodeLine = 3542;
            _FOUNDDELIMITER = (ushort) ( (_FOUNDDELIMITER - LASTFOUNDDELIMITER) ) ; 
            __context__.SourceCodeLine = 3544;
            LASTTXCOUNT = (ushort) ( _TXCOUNT ) ; 
            __context__.SourceCodeLine = 3545;
            _TXCOUNT = (ushort) ( (_TXCOUNT - LASTTXCOUNT) ) ; 
            __context__.SourceCodeLine = 3547;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (RX__DOLLAR__ == ""))  ) ) 
                {
                __context__.SourceCodeLine = 3547;
                LASTRXEMPTY = (ushort) ( 1 ) ; 
                }
            
            else 
                {
                __context__.SourceCodeLine = 3548;
                LASTRXEMPTY = (ushort) ( 0 ) ; 
                }
            
            __context__.SourceCodeLine = 3485;
            } 
        
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    _MODULEDESCRIPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _PLAYERSN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
    _DEVICENAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 50, this );
    _CONNECTEDDEVICESN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 16, this );
    _MOVIETITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 100, this );
    _NOWPLAYINGHANDLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    _BROWSEDETAILSHANDLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 200, this );
    _SYMBOLINSTANCE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 3, this );
    _MUSICCONTROLSN__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 15, this );
    _MUSICCONTROLCPDID__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    _MUSICCONTROLZONE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
    _MODULESHORTDESCRIPTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    _HANDLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
    MSGPLAYER_RESTART  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSG01_BANG_020  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 10, this );
    MSGAVAILABLE_DEVICES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGPLAY_STATUS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGMUSIC_NOW_PLAYING_STATUS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    MSGMUSIC_PLAY_STATUS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGSCREEN_MASK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGSCREEN_MASK2  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGTITLE_NAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGMUSIC_TITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGUI_STATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGMOVIE_MEDIA_TYPE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGMOVIE_LOCATION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGASPECT_RATIO  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGCINEMASCAPE_MODE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGSCALE_MODE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGCINEMASCAPE_MASK  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGDEVICE_INFO  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGNUM_ZONES  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGDEVICE_TYPE_NAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGDEVICE_POWER_STATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGPROTOCOL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGUSER_INPUT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGCAMERA_ANGLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGVIDEO_MODE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGUSER_DEFINED_EVENT  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGFRIENDLY_NAME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGCONTROLLED_ZONE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGHIGHLIGHTED_SELECTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    MSGCONTENT_DETAILS_OVERVIEW  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    MSGCONTENT_DETAILS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGCHILD_MODE_STATE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGVOLUME_UP_PRESS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGVOLUME_UP_RELEASE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGVOLUME_UP  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGVOLUME_DOWN_PRESS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGVOLUME_DOWN_RELEASE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 30, this );
    MSGVOLUME_DOWN  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGTOGGLE_MUTE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 20, this );
    MSGSYSTEM_READINESS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    MSGDISC_IN_TRAY_SELECTION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 25, this );
    _DELIMITERS  = new CrestronString[ 3 ];
    for( uint i = 0; i < 3; i++ )
        _DELIMITERS [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    _FIELDDELIMITER  = new CrestronString[ 3 ];
    for( uint i = 0; i < 3; i++ )
        _FIELDDELIMITER [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 1, this );
    _CONNECTIONCOMMAND  = new CrestronString[ 6 ];
    for( uint i = 0; i < 6; i++ )
        _CONNECTIONCOMMAND [i] = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 255, this );
    _CONTENTDETAIL  = new STRUCT_DETAILS( this, true );
    _CONTENTDETAIL .PopulateCustomAttributeList( false );
    
    TOUCH_CHANNEL = new Crestron.Logos.SplusObjects.DigitalInput( TOUCH_CHANNEL__DigitalInput__, this );
    m_DigitalInputList.Add( TOUCH_CHANNEL__DigitalInput__, TOUCH_CHANNEL );
    
    USING_MASKING = new Crestron.Logos.SplusObjects.DigitalInput( USING_MASKING__DigitalInput__, this );
    m_DigitalInputList.Add( USING_MASKING__DigitalInput__, USING_MASKING );
    
    CONNECTION_OPEN = new Crestron.Logos.SplusObjects.DigitalInput( CONNECTION_OPEN__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECTION_OPEN__DigitalInput__, CONNECTION_OPEN );
    
    POWER_OFF_TRIGGER = new Crestron.Logos.SplusObjects.DigitalInput( POWER_OFF_TRIGGER__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_OFF_TRIGGER__DigitalInput__, POWER_OFF_TRIGGER );
    
    POWER_ON_TRIGGER = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON_TRIGGER__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON_TRIGGER__DigitalInput__, POWER_ON_TRIGGER );
    
    REFRESH_DETAILS = new Crestron.Logos.SplusObjects.DigitalInput( REFRESH_DETAILS__DigitalInput__, this );
    m_DigitalInputList.Add( REFRESH_DETAILS__DigitalInput__, REFRESH_DETAILS );
    
    OSD_SAVER = new Crestron.Logos.SplusObjects.DigitalOutput( OSD_SAVER__DigitalOutput__, this );
    m_DigitalOutputList.Add( OSD_SAVER__DigitalOutput__, OSD_SAVER );
    
    CAMERA_ANGLES_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( CAMERA_ANGLES_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( CAMERA_ANGLES_AVAILABLE__DigitalOutput__, CAMERA_ANGLES_AVAILABLE );
    
    MOVIES_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MOVIES_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MOVIES_AVAILABLE__DigitalOutput__, MOVIES_AVAILABLE );
    
    MUSIC_AVAILABLE = new Crestron.Logos.SplusObjects.DigitalOutput( MUSIC_AVAILABLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUSIC_AVAILABLE__DigitalOutput__, MUSIC_AVAILABLE );
    
    DETAILS_VISIBLE = new Crestron.Logos.SplusObjects.DigitalOutput( DETAILS_VISIBLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( DETAILS_VISIBLE__DigitalOutput__, DETAILS_VISIBLE );
    
    MUSIC_PLAYBACK_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MUSIC_PLAYBACK_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUSIC_PLAYBACK_ACTIVE__DigitalOutput__, MUSIC_PLAYBACK_ACTIVE );
    
    MOVIE_PLAYBACK_ACTIVE = new Crestron.Logos.SplusObjects.DigitalOutput( MOVIE_PLAYBACK_ACTIVE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MOVIE_PLAYBACK_ACTIVE__DigitalOutput__, MOVIE_PLAYBACK_ACTIVE );
    
    RANDOM_STATUS = new Crestron.Logos.SplusObjects.DigitalOutput( RANDOM_STATUS__DigitalOutput__, this );
    m_DigitalOutputList.Add( RANDOM_STATUS__DigitalOutput__, RANDOM_STATUS );
    
    REPEAT_STATUS = new Crestron.Logos.SplusObjects.DigitalOutput( REPEAT_STATUS__DigitalOutput__, this );
    m_DigitalOutputList.Add( REPEAT_STATUS__DigitalOutput__, REPEAT_STATUS );
    
    VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalOutput( VOLUME_UP__DigitalOutput__, this );
    m_DigitalOutputList.Add( VOLUME_UP__DigitalOutput__, VOLUME_UP );
    
    VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalOutput( VOLUME_DOWN__DigitalOutput__, this );
    m_DigitalOutputList.Add( VOLUME_DOWN__DigitalOutput__, VOLUME_DOWN );
    
    VOLUME_MUTE = new Crestron.Logos.SplusObjects.DigitalOutput( VOLUME_MUTE__DigitalOutput__, this );
    m_DigitalOutputList.Add( VOLUME_MUTE__DigitalOutput__, VOLUME_MUTE );
    
    POWER_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_ON_FB__DigitalOutput__, POWER_ON_FB );
    
    POWER_OFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_OFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_OFF_FB__DigitalOutput__, POWER_OFF_FB );
    
    SHOW_DISC_IN_TRAY_BUTTON = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_DISC_IN_TRAY_BUTTON__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_DISC_IN_TRAY_BUTTON__DigitalOutput__, SHOW_DISC_IN_TRAY_BUTTON );
    
    DISC_IN_TRAY_OK_TO_IMPORT = new Crestron.Logos.SplusObjects.DigitalOutput( DISC_IN_TRAY_OK_TO_IMPORT__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISC_IN_TRAY_OK_TO_IMPORT__DigitalOutput__, DISC_IN_TRAY_OK_TO_IMPORT );
    
    DISC_IN_TRAY_IMPORTED = new Crestron.Logos.SplusObjects.DigitalOutput( DISC_IN_TRAY_IMPORTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISC_IN_TRAY_IMPORTED__DigitalOutput__, DISC_IN_TRAY_IMPORTED );
    
    DISC_IN_TRAY_IMPORTING = new Crestron.Logos.SplusObjects.DigitalOutput( DISC_IN_TRAY_IMPORTING__DigitalOutput__, this );
    m_DigitalOutputList.Add( DISC_IN_TRAY_IMPORTING__DigitalOutput__, DISC_IN_TRAY_IMPORTING );
    
    STATED_PLAYER_ID = new Crestron.Logos.SplusObjects.AnalogInput( STATED_PLAYER_ID__AnalogSerialInput__, this );
    m_AnalogInputList.Add( STATED_PLAYER_ID__AnalogSerialInput__, STATED_PLAYER_ID );
    
    TOUCH_X = new Crestron.Logos.SplusObjects.AnalogInput( TOUCH_X__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TOUCH_X__AnalogSerialInput__, TOUCH_X );
    
    TOUCH_Y = new Crestron.Logos.SplusObjects.AnalogInput( TOUCH_Y__AnalogSerialInput__, this );
    m_AnalogInputList.Add( TOUCH_Y__AnalogSerialInput__, TOUCH_Y );
    
    PLAY_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( PLAY_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PLAY_MODE__AnalogSerialOutput__, PLAY_MODE );
    
    TITLE_LENGTH = new Crestron.Logos.SplusObjects.AnalogOutput( TITLE_LENGTH__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TITLE_LENGTH__AnalogSerialOutput__, TITLE_LENGTH );
    
    TITLE_LOCATION = new Crestron.Logos.SplusObjects.AnalogOutput( TITLE_LOCATION__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TITLE_LOCATION__AnalogSerialOutput__, TITLE_LOCATION );
    
    TITLE_REMAINING = new Crestron.Logos.SplusObjects.AnalogOutput( TITLE_REMAINING__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TITLE_REMAINING__AnalogSerialOutput__, TITLE_REMAINING );
    
    TITLE_LEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( TITLE_LEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( TITLE_LEVEL__AnalogSerialOutput__, TITLE_LEVEL );
    
    CHAPTER_NUMBER = new Crestron.Logos.SplusObjects.AnalogOutput( CHAPTER_NUMBER__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHAPTER_NUMBER__AnalogSerialOutput__, CHAPTER_NUMBER );
    
    CHAPTER_LENGTH = new Crestron.Logos.SplusObjects.AnalogOutput( CHAPTER_LENGTH__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHAPTER_LENGTH__AnalogSerialOutput__, CHAPTER_LENGTH );
    
    CHAPTER_LOCATION = new Crestron.Logos.SplusObjects.AnalogOutput( CHAPTER_LOCATION__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHAPTER_LOCATION__AnalogSerialOutput__, CHAPTER_LOCATION );
    
    CHAPTER_REMAINING = new Crestron.Logos.SplusObjects.AnalogOutput( CHAPTER_REMAINING__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHAPTER_REMAINING__AnalogSerialOutput__, CHAPTER_REMAINING );
    
    CHAPTER_LEVEL = new Crestron.Logos.SplusObjects.AnalogOutput( CHAPTER_LEVEL__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHAPTER_LEVEL__AnalogSerialOutput__, CHAPTER_LEVEL );
    
    SYSTEM_READINESS_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( SYSTEM_READINESS_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SYSTEM_READINESS_STATE__AnalogSerialOutput__, SYSTEM_READINESS_STATE );
    
    MOVIE_LOCATION = new Crestron.Logos.SplusObjects.AnalogOutput( MOVIE_LOCATION__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MOVIE_LOCATION__AnalogSerialOutput__, MOVIE_LOCATION );
    
    OSD_SCREEN = new Crestron.Logos.SplusObjects.AnalogOutput( OSD_SCREEN__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( OSD_SCREEN__AnalogSerialOutput__, OSD_SCREEN );
    
    OSD_POPUP = new Crestron.Logos.SplusObjects.AnalogOutput( OSD_POPUP__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( OSD_POPUP__AnalogSerialOutput__, OSD_POPUP );
    
    OSD_DIALOG = new Crestron.Logos.SplusObjects.AnalogOutput( OSD_DIALOG__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( OSD_DIALOG__AnalogSerialOutput__, OSD_DIALOG );
    
    CHILD_MODE_STATE = new Crestron.Logos.SplusObjects.AnalogOutput( CHILD_MODE_STATE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CHILD_MODE_STATE__AnalogSerialOutput__, CHILD_MODE_STATE );
    
    CINEMASCAPE_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( CINEMASCAPE_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CINEMASCAPE_MODE__AnalogSerialOutput__, CINEMASCAPE_MODE );
    
    CINEMASCAPE_SCALE_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( CINEMASCAPE_SCALE_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CINEMASCAPE_SCALE_MODE__AnalogSerialOutput__, CINEMASCAPE_SCALE_MODE );
    
    CINEMASCAPE_MASK = new Crestron.Logos.SplusObjects.AnalogOutput( CINEMASCAPE_MASK__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CINEMASCAPE_MASK__AnalogSerialOutput__, CINEMASCAPE_MASK );
    
    IMAGE_ASPECT_RATIO = new Crestron.Logos.SplusObjects.AnalogOutput( IMAGE_ASPECT_RATIO__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( IMAGE_ASPECT_RATIO__AnalogSerialOutput__, IMAGE_ASPECT_RATIO );
    
    FRAME_ASPECT_RATIO = new Crestron.Logos.SplusObjects.AnalogOutput( FRAME_ASPECT_RATIO__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( FRAME_ASPECT_RATIO__AnalogSerialOutput__, FRAME_ASPECT_RATIO );
    
    MASK_DATA = new Crestron.Logos.SplusObjects.AnalogOutput( MASK_DATA__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MASK_DATA__AnalogSerialOutput__, MASK_DATA );
    
    MASK_CONSERVATIVE = new Crestron.Logos.SplusObjects.AnalogOutput( MASK_CONSERVATIVE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MASK_CONSERVATIVE__AnalogSerialOutput__, MASK_CONSERVATIVE );
    
    PROTOCOL_VERSION = new Crestron.Logos.SplusObjects.AnalogOutput( PROTOCOL_VERSION__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PROTOCOL_VERSION__AnalogSerialOutput__, PROTOCOL_VERSION );
    
    USER_INPUT = new Crestron.Logos.SplusObjects.AnalogOutput( USER_INPUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( USER_INPUT__AnalogSerialOutput__, USER_INPUT );
    
    MASK_ABS_TOP = new Crestron.Logos.SplusObjects.AnalogOutput( MASK_ABS_TOP__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MASK_ABS_TOP__AnalogSerialOutput__, MASK_ABS_TOP );
    
    MASK_ABS_BOTTOM = new Crestron.Logos.SplusObjects.AnalogOutput( MASK_ABS_BOTTOM__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MASK_ABS_BOTTOM__AnalogSerialOutput__, MASK_ABS_BOTTOM );
    
    CURRENT_CAMERA_ANGLE = new Crestron.Logos.SplusObjects.AnalogOutput( CURRENT_CAMERA_ANGLE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CURRENT_CAMERA_ANGLE__AnalogSerialOutput__, CURRENT_CAMERA_ANGLE );
    
    NUM_CAMERA_ANGLES = new Crestron.Logos.SplusObjects.AnalogOutput( NUM_CAMERA_ANGLES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NUM_CAMERA_ANGLES__AnalogSerialOutput__, NUM_CAMERA_ANGLES );
    
    VIDEO_MODE_COMPOSITE = new Crestron.Logos.SplusObjects.AnalogOutput( VIDEO_MODE_COMPOSITE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VIDEO_MODE_COMPOSITE__AnalogSerialOutput__, VIDEO_MODE_COMPOSITE );
    
    VIDEO_MODE_COMPONENT = new Crestron.Logos.SplusObjects.AnalogOutput( VIDEO_MODE_COMPONENT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VIDEO_MODE_COMPONENT__AnalogSerialOutput__, VIDEO_MODE_COMPONENT );
    
    VIDEO_MODE_HDMI = new Crestron.Logos.SplusObjects.AnalogOutput( VIDEO_MODE_HDMI__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VIDEO_MODE_HDMI__AnalogSerialOutput__, VIDEO_MODE_HDMI );
    
    MASK_CALIBRATED_TOP = new Crestron.Logos.SplusObjects.AnalogOutput( MASK_CALIBRATED_TOP__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MASK_CALIBRATED_TOP__AnalogSerialOutput__, MASK_CALIBRATED_TOP );
    
    MASK_CALIBRATED_BOTTOM = new Crestron.Logos.SplusObjects.AnalogOutput( MASK_CALIBRATED_BOTTOM__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MASK_CALIBRATED_BOTTOM__AnalogSerialOutput__, MASK_CALIBRATED_BOTTOM );
    
    DISC_IN_TRAY_MEDIA_TYPE = new Crestron.Logos.SplusObjects.AnalogOutput( DISC_IN_TRAY_MEDIA_TYPE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DISC_IN_TRAY_MEDIA_TYPE__AnalogSerialOutput__, DISC_IN_TRAY_MEDIA_TYPE );
    
    MEDIA_TYPE = new Crestron.Logos.SplusObjects.AnalogOutput( MEDIA_TYPE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MEDIA_TYPE__AnalogSerialOutput__, MEDIA_TYPE );
    
    COMMAND_TO_PLAYER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( COMMAND_TO_PLAYER__DOLLAR____AnalogSerialInput__, 2048, this );
    m_StringInputList.Add( COMMAND_TO_PLAYER__DOLLAR____AnalogSerialInput__, COMMAND_TO_PLAYER__DOLLAR__ );
    
    KEYBOARD_INPUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( KEYBOARD_INPUT__DOLLAR____AnalogSerialInput__, 2048, this );
    m_StringInputList.Add( KEYBOARD_INPUT__DOLLAR____AnalogSerialInput__, KEYBOARD_INPUT__DOLLAR__ );
    
    PLAY_SCRIPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( PLAY_SCRIPT__DOLLAR____AnalogSerialInput__, 2048, this );
    m_StringInputList.Add( PLAY_SCRIPT__DOLLAR____AnalogSerialInput__, PLAY_SCRIPT__DOLLAR__ );
    
    CONSOLE_COMMAND__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( CONSOLE_COMMAND__DOLLAR____AnalogSerialInput__, 2048, this );
    m_StringInputList.Add( CONSOLE_COMMAND__DOLLAR____AnalogSerialInput__, CONSOLE_COMMAND__DOLLAR__ );
    
    CONTROL_MUSIC_ZONE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( CONTROL_MUSIC_ZONE__DOLLAR____AnalogSerialInput__, 15, this );
    m_StringInputList.Add( CONTROL_MUSIC_ZONE__DOLLAR____AnalogSerialInput__, CONTROL_MUSIC_ZONE__DOLLAR__ );
    
    TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( TX__DOLLAR____AnalogSerialOutput__, TX__DOLLAR__ );
    
    NOW_PLAYING_TITLE_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOW_PLAYING_TITLE_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOW_PLAYING_TITLE_NAME__DOLLAR____AnalogSerialOutput__, NOW_PLAYING_TITLE_NAME__DOLLAR__ );
    
    NOW_PLAYING_ARTIST_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOW_PLAYING_ARTIST_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOW_PLAYING_ARTIST_NAME__DOLLAR____AnalogSerialOutput__, NOW_PLAYING_ARTIST_NAME__DOLLAR__ );
    
    NOW_PLAYING_ALBUM_NAME_OR_CHAPTER__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOW_PLAYING_ALBUM_NAME_OR_CHAPTER__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOW_PLAYING_ALBUM_NAME_OR_CHAPTER__DOLLAR____AnalogSerialOutput__, NOW_PLAYING_ALBUM_NAME_OR_CHAPTER__DOLLAR__ );
    
    NOW_PLAYING_COVER_ART_URL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( NOW_PLAYING_COVER_ART_URL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( NOW_PLAYING_COVER_ART_URL__DOLLAR____AnalogSerialOutput__, NOW_PLAYING_COVER_ART_URL__DOLLAR__ );
    
    USER_INPUT_PROMPT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USER_INPUT_PROMPT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USER_INPUT_PROMPT__DOLLAR____AnalogSerialOutput__, USER_INPUT_PROMPT__DOLLAR__ );
    
    USER_INPUT_TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USER_INPUT_TEXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USER_INPUT_TEXT__DOLLAR____AnalogSerialOutput__, USER_INPUT_TEXT__DOLLAR__ );
    
    USER_DEFINED_EVENT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( USER_DEFINED_EVENT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( USER_DEFINED_EVENT__DOLLAR____AnalogSerialOutput__, USER_DEFINED_EVENT__DOLLAR__ );
    
    FRIENDLY_NAME__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( FRIENDLY_NAME__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRIENDLY_NAME__DOLLAR____AnalogSerialOutput__, FRIENDLY_NAME__DOLLAR__ );
    
    DETAILS_TEXT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DETAILS_TEXT__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DETAILS_TEXT__DOLLAR____AnalogSerialOutput__, DETAILS_TEXT__DOLLAR__ );
    
    DETAILS_TITLE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DETAILS_TITLE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DETAILS_TITLE__DOLLAR____AnalogSerialOutput__, DETAILS_TITLE__DOLLAR__ );
    
    DETAILS_COVER_URL__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( DETAILS_COVER_URL__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( DETAILS_COVER_URL__DOLLAR____AnalogSerialOutput__, DETAILS_COVER_URL__DOLLAR__ );
    
    CONTROLLED_MUSIC_SN_ZONE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONTROLLED_MUSIC_SN_ZONE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONTROLLED_MUSIC_SN_ZONE__DOLLAR____AnalogSerialOutput__, CONTROLLED_MUSIC_SN_ZONE__DOLLAR__ );
    
    CONTROLLED_MUSIC_CPDID_ZONE__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( CONTROLLED_MUSIC_CPDID_ZONE__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONTROLLED_MUSIC_CPDID_ZONE__DOLLAR____AnalogSerialOutput__, CONTROLLED_MUSIC_CPDID_ZONE__DOLLAR__ );
    
    RX__DOLLAR___LOOPBACK = new Crestron.Logos.SplusObjects.StringOutput( RX__DOLLAR___LOOPBACK__AnalogSerialOutput__, this );
    m_StringOutputList.Add( RX__DOLLAR___LOOPBACK__AnalogSerialOutput__, RX__DOLLAR___LOOPBACK );
    
    RX__DOLLAR__ = new Crestron.Logos.SplusObjects.BufferInput( RX__DOLLAR____AnalogSerialInput__, 8192, this );
    m_StringInputList.Add( RX__DOLLAR____AnalogSerialInput__, RX__DOLLAR__ );
    
    __SPLS_TMPVAR__WAITLABEL_8___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_8___CallbackFn );
    __SPLS_TMPVAR__WAITLABEL_9___Callback = new WaitFunction( __SPLS_TMPVAR__WAITLABEL_9___CallbackFn );
    
    RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( RX__DOLLAR___OnChange_0, false ) );
    COMMAND_TO_PLAYER__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( COMMAND_TO_PLAYER__DOLLAR___OnChange_1, false ) );
    KEYBOARD_INPUT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( KEYBOARD_INPUT__DOLLAR___OnChange_2, false ) );
    TOUCH_CHANNEL.OnDigitalRelease.Add( new InputChangeHandlerWrapper( TOUCH_CHANNEL_OnRelease_3, false ) );
    TOUCH_CHANNEL.OnDigitalPush.Add( new InputChangeHandlerWrapper( TOUCH_CHANNEL_OnPush_4, false ) );
    TOUCH_X.OnAnalogChange.Add( new InputChangeHandlerWrapper( TOUCH_X_OnChange_5, false ) );
    TOUCH_Y.OnAnalogChange.Add( new InputChangeHandlerWrapper( TOUCH_Y_OnChange_6, false ) );
    PLAY_SCRIPT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( PLAY_SCRIPT__DOLLAR___OnChange_7, false ) );
    CONSOLE_COMMAND__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CONSOLE_COMMAND__DOLLAR___OnChange_8, false ) );
    CONNECTION_OPEN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CONNECTION_OPEN_OnPush_9, false ) );
    CONNECTION_OPEN.OnDigitalRelease.Add( new InputChangeHandlerWrapper( CONNECTION_OPEN_OnRelease_10, false ) );
    POWER_ON_TRIGGER.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_ON_TRIGGER_OnPush_11, false ) );
    POWER_ON_TRIGGER.OnDigitalRelease.Add( new InputChangeHandlerWrapper( POWER_ON_TRIGGER_OnRelease_12, false ) );
    POWER_OFF_TRIGGER.OnDigitalPush.Add( new InputChangeHandlerWrapper( POWER_OFF_TRIGGER_OnPush_13, false ) );
    REFRESH_DETAILS.OnDigitalPush.Add( new InputChangeHandlerWrapper( REFRESH_DETAILS_OnPush_14, false ) );
    CONTROL_MUSIC_ZONE__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( CONTROL_MUSIC_ZONE__DOLLAR___OnChange_15, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_KALEIDESCAPE_OSD_PROCESSOR_V8_4_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction __SPLS_TMPVAR__WAITLABEL_8___Callback;
private WaitFunction __SPLS_TMPVAR__WAITLABEL_9___Callback;


const uint TOUCH_CHANNEL__DigitalInput__ = 0;
const uint USING_MASKING__DigitalInput__ = 1;
const uint CONNECTION_OPEN__DigitalInput__ = 2;
const uint POWER_OFF_TRIGGER__DigitalInput__ = 3;
const uint POWER_ON_TRIGGER__DigitalInput__ = 4;
const uint REFRESH_DETAILS__DigitalInput__ = 5;
const uint STATED_PLAYER_ID__AnalogSerialInput__ = 0;
const uint TOUCH_X__AnalogSerialInput__ = 1;
const uint TOUCH_Y__AnalogSerialInput__ = 2;
const uint RX__DOLLAR____AnalogSerialInput__ = 3;
const uint COMMAND_TO_PLAYER__DOLLAR____AnalogSerialInput__ = 4;
const uint KEYBOARD_INPUT__DOLLAR____AnalogSerialInput__ = 5;
const uint PLAY_SCRIPT__DOLLAR____AnalogSerialInput__ = 6;
const uint CONSOLE_COMMAND__DOLLAR____AnalogSerialInput__ = 7;
const uint CONTROL_MUSIC_ZONE__DOLLAR____AnalogSerialInput__ = 8;
const uint OSD_SAVER__DigitalOutput__ = 0;
const uint CAMERA_ANGLES_AVAILABLE__DigitalOutput__ = 1;
const uint MOVIES_AVAILABLE__DigitalOutput__ = 2;
const uint MUSIC_AVAILABLE__DigitalOutput__ = 3;
const uint DETAILS_VISIBLE__DigitalOutput__ = 4;
const uint MUSIC_PLAYBACK_ACTIVE__DigitalOutput__ = 5;
const uint MOVIE_PLAYBACK_ACTIVE__DigitalOutput__ = 6;
const uint RANDOM_STATUS__DigitalOutput__ = 7;
const uint REPEAT_STATUS__DigitalOutput__ = 8;
const uint VOLUME_UP__DigitalOutput__ = 9;
const uint VOLUME_DOWN__DigitalOutput__ = 10;
const uint VOLUME_MUTE__DigitalOutput__ = 11;
const uint POWER_ON_FB__DigitalOutput__ = 12;
const uint POWER_OFF_FB__DigitalOutput__ = 13;
const uint TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint PLAY_MODE__AnalogSerialOutput__ = 1;
const uint TITLE_LENGTH__AnalogSerialOutput__ = 2;
const uint TITLE_LOCATION__AnalogSerialOutput__ = 3;
const uint TITLE_REMAINING__AnalogSerialOutput__ = 4;
const uint TITLE_LEVEL__AnalogSerialOutput__ = 5;
const uint CHAPTER_NUMBER__AnalogSerialOutput__ = 6;
const uint CHAPTER_LENGTH__AnalogSerialOutput__ = 7;
const uint CHAPTER_LOCATION__AnalogSerialOutput__ = 8;
const uint CHAPTER_REMAINING__AnalogSerialOutput__ = 9;
const uint CHAPTER_LEVEL__AnalogSerialOutput__ = 10;
const uint SYSTEM_READINESS_STATE__AnalogSerialOutput__ = 11;
const uint MOVIE_LOCATION__AnalogSerialOutput__ = 12;
const uint NOW_PLAYING_TITLE_NAME__DOLLAR____AnalogSerialOutput__ = 13;
const uint NOW_PLAYING_ARTIST_NAME__DOLLAR____AnalogSerialOutput__ = 14;
const uint NOW_PLAYING_ALBUM_NAME_OR_CHAPTER__DOLLAR____AnalogSerialOutput__ = 15;
const uint NOW_PLAYING_COVER_ART_URL__DOLLAR____AnalogSerialOutput__ = 16;
const uint OSD_SCREEN__AnalogSerialOutput__ = 17;
const uint OSD_POPUP__AnalogSerialOutput__ = 18;
const uint OSD_DIALOG__AnalogSerialOutput__ = 19;
const uint CHILD_MODE_STATE__AnalogSerialOutput__ = 20;
const uint CINEMASCAPE_MODE__AnalogSerialOutput__ = 21;
const uint CINEMASCAPE_SCALE_MODE__AnalogSerialOutput__ = 22;
const uint CINEMASCAPE_MASK__AnalogSerialOutput__ = 23;
const uint IMAGE_ASPECT_RATIO__AnalogSerialOutput__ = 24;
const uint FRAME_ASPECT_RATIO__AnalogSerialOutput__ = 25;
const uint MASK_DATA__AnalogSerialOutput__ = 26;
const uint MASK_CONSERVATIVE__AnalogSerialOutput__ = 27;
const uint PROTOCOL_VERSION__AnalogSerialOutput__ = 28;
const uint USER_INPUT__AnalogSerialOutput__ = 29;
const uint USER_INPUT_PROMPT__DOLLAR____AnalogSerialOutput__ = 30;
const uint USER_INPUT_TEXT__DOLLAR____AnalogSerialOutput__ = 31;
const uint MASK_ABS_TOP__AnalogSerialOutput__ = 32;
const uint MASK_ABS_BOTTOM__AnalogSerialOutput__ = 33;
const uint CURRENT_CAMERA_ANGLE__AnalogSerialOutput__ = 34;
const uint NUM_CAMERA_ANGLES__AnalogSerialOutput__ = 35;
const uint VIDEO_MODE_COMPOSITE__AnalogSerialOutput__ = 36;
const uint VIDEO_MODE_COMPONENT__AnalogSerialOutput__ = 37;
const uint VIDEO_MODE_HDMI__AnalogSerialOutput__ = 38;
const uint USER_DEFINED_EVENT__DOLLAR____AnalogSerialOutput__ = 39;
const uint FRIENDLY_NAME__DOLLAR____AnalogSerialOutput__ = 40;
const uint DETAILS_TEXT__DOLLAR____AnalogSerialOutput__ = 41;
const uint DETAILS_TITLE__DOLLAR____AnalogSerialOutput__ = 42;
const uint DETAILS_COVER_URL__DOLLAR____AnalogSerialOutput__ = 43;
const uint MASK_CALIBRATED_TOP__AnalogSerialOutput__ = 44;
const uint MASK_CALIBRATED_BOTTOM__AnalogSerialOutput__ = 45;
const uint CONTROLLED_MUSIC_SN_ZONE__DOLLAR____AnalogSerialOutput__ = 46;
const uint CONTROLLED_MUSIC_CPDID_ZONE__DOLLAR____AnalogSerialOutput__ = 47;
const uint SHOW_DISC_IN_TRAY_BUTTON__DigitalOutput__ = 14;
const uint DISC_IN_TRAY_OK_TO_IMPORT__DigitalOutput__ = 15;
const uint DISC_IN_TRAY_IMPORTED__DigitalOutput__ = 16;
const uint DISC_IN_TRAY_IMPORTING__DigitalOutput__ = 17;
const uint DISC_IN_TRAY_MEDIA_TYPE__AnalogSerialOutput__ = 48;
const uint MEDIA_TYPE__AnalogSerialOutput__ = 49;
const uint RX__DOLLAR___LOOPBACK__AnalogSerialOutput__ = 50;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    
}

SplusNVRAM _SplusNVRAM = null;

public class __CEvent__ : CEvent
{
    public __CEvent__() {}
    public void Close() { base.Close(); }
    public int Reset() { return base.Reset() ? 1 : 0; }
    public int Set() { return base.Set() ? 1 : 0; }
    public int Wait( int timeOutInMs ) { return base.Wait( timeOutInMs ) ? 1 : 0; }
}
public class __CMutex__ : CMutex
{
    public __CMutex__() {}
    public void Close() { base.Close(); }
    public void ReleaseMutex() { base.ReleaseMutex(); }
    public int WaitForMutex() { return base.WaitForMutex() ? 1 : 0; }
}
 public int IsNull( object obj ){ return (obj == null) ? 1 : 0; }
}

[SplusStructAttribute(-1, true, false)]
public class STRUCT_DETAILS : SplusStructureBase
{

    [SplusStructAttribute(0, false, false)]
    public CrestronString  LIBRARY;
    
    [SplusStructAttribute(1, false, false)]
    public CrestronString  TITLE;
    
    [SplusStructAttribute(2, false, false)]
    public CrestronString  ALBUMTITLE;
    
    [SplusStructAttribute(3, false, false)]
    public CrestronString  PERFORMER;
    
    [SplusStructAttribute(4, false, false)]
    public CrestronString  COMPOSER;
    
    [SplusStructAttribute(5, false, false)]
    public CrestronString  GENRE;
    
    [SplusStructAttribute(6, false, false)]
    public CrestronString  YEAR;
    
    [SplusStructAttribute(7, false, false)]
    public CrestronString  COVERURL;
    
    [SplusStructAttribute(8, false, false)]
    public CrestronString  RUNNINGTIME;
    
    [SplusStructAttribute(9, false, false)]
    public CrestronString  RATING;
    
    [SplusStructAttribute(10, false, false)]
    public CrestronString  RATINGREASON;
    
    [SplusStructAttribute(11, false, false)]
    public CrestronString  SYNOPSIS;
    
    [SplusStructAttribute(12, false, false)]
    public CrestronString  DISCLOCATION;
    
    [SplusStructAttribute(13, false, false)]
    public CrestronString  ALBUMCONTENTHANDLE;
    
    [SplusStructAttribute(14, false, false)]
    public ushort  NUMDETAILSEXPECTED = 0;
    
    
    public STRUCT_DETAILS( SplusObject __caller__, bool bIsStructureVolatile ) : base ( __caller__, bIsStructureVolatile )
    {
        LIBRARY  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        TITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        ALBUMTITLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        PERFORMER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        COMPOSER  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        GENRE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        YEAR  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        COVERURL  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        RUNNINGTIME  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        RATING  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        RATINGREASON  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        SYNOPSIS  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        DISCLOCATION  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        ALBUMCONTENTHANDLE  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 250, Owner );
        
        
    }
    
}

}

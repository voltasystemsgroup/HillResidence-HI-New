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
using UserModule__AS__CONSTANTS;
using AdaptCore;
using AdaptCore.Core;

namespace UserModule__AS__SOURCEFULL_V1_0_0
{
    public class UserModuleClass__AS__SOURCEFULL_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        Crestron.Logos.SplusObjects.DigitalInput READ;
        Crestron.Logos.SplusObjects.DigitalInput WRITE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> QUICK_DIGITAL_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> LIST_DIGITAL_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> D_IN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> LIST_ANALOG_FB;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> A_IN;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> QUICK_SERIAL_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> LIST_SERIAL_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> S_IN;
        Crestron.Logos.SplusObjects.DigitalOutput IN_USE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICK_CONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LIST_DIGITAL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> D_OUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> A_OUT;
        UShortParameter SOURCE_ID;
        StringParameter SOURCE_NAME;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME__DOLLAR__;
        StringParameter READ_AT_BOOTUP;
        UShortParameter AUDIO_SWITCHER;
        UShortParameter AUDIO_INPUT;
        UShortParameter VIDEO_SWITCHER;
        UShortParameter VIDEO_INPUT;
        UShortParameter HANDHELD_PAGE_TYPE;
        AdaptCore.PD_Source MYBRIDGE;
        ushort GINUMDIGITALS = 0;
        ushort GINUMANALOGS = 0;
        ushort GINUMSERIALS = 0;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 107;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)MYBRIDGE.NumQuickControls; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 109;
                MYBRIDGE . QuickDigitalFeedbackChange ( (ushort)( I ), (ushort)( QUICK_DIGITAL_FB[ I ] .Value )) ; 
                __context__.SourceCodeLine = 109;
                MYBRIDGE . QuickSerialFeedbackChange ( (ushort)( I ), QUICK_SERIAL_FB[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 107;
                } 
            
            __context__.SourceCodeLine = 111;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)MYBRIDGE.NumListControls; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 113;
                MYBRIDGE . ListDigitalFeedbackChange ( (ushort)( I ), (ushort)( LIST_DIGITAL_FB[ I ] .Value )) ; 
                __context__.SourceCodeLine = 114;
                MYBRIDGE . ListAnalogFeedbackChange ( (ushort)( I ), (ushort)( LIST_ANALOG_FB[ I ] .UshortValue )) ; 
                __context__.SourceCodeLine = 115;
                MYBRIDGE . ListSerialFeedbackChange ( (ushort)( I ), LIST_SERIAL_FB[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 111;
                } 
            
            __context__.SourceCodeLine = 117;
            ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__3 = (ushort)GINUMDIGITALS; 
            int __FN_FORSTEP_VAL__3 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                { 
                __context__.SourceCodeLine = 117;
                MYBRIDGE . DigitalInputChange ( (ushort)( I ), (ushort)( D_IN[ I ] .Value )) ; 
                __context__.SourceCodeLine = 117;
                } 
            
            __context__.SourceCodeLine = 118;
            ushort __FN_FORSTART_VAL__4 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__4 = (ushort)GINUMANALOGS; 
            int __FN_FORSTEP_VAL__4 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__4; (__FN_FORSTEP_VAL__4 > 0)  ? ( (I  >= __FN_FORSTART_VAL__4) && (I  <= __FN_FOREND_VAL__4) ) : ( (I  <= __FN_FORSTART_VAL__4) && (I  >= __FN_FOREND_VAL__4) ) ; I  += (ushort)__FN_FORSTEP_VAL__4) 
                { 
                __context__.SourceCodeLine = 118;
                MYBRIDGE . AnalogInputChange ( (ushort)( I ), (ushort)( A_IN[ I ] .UshortValue )) ; 
                __context__.SourceCodeLine = 118;
                } 
            
            __context__.SourceCodeLine = 119;
            ushort __FN_FORSTART_VAL__5 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__5 = (ushort)GINUMSERIALS; 
            int __FN_FORSTEP_VAL__5 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__5; (__FN_FORSTEP_VAL__5 > 0)  ? ( (I  >= __FN_FORSTART_VAL__5) && (I  <= __FN_FOREND_VAL__5) ) : ( (I  <= __FN_FORSTART_VAL__5) && (I  >= __FN_FOREND_VAL__5) ) ; I  += (ushort)__FN_FORSTEP_VAL__5) 
                { 
                __context__.SourceCodeLine = 119;
                MYBRIDGE . SerialInputChange ( (ushort)( I ), S_IN[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 119;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 123;
                FNREFRESHINPUTS (  __context__  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEINUSECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 124;
                IN_USE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDIGITALOUTPUT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 126;
                D_OUT [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEANALOGOUTPUT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_AnalogEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 127;
                A_OUT [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKCONTROLCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 129;
                QUICK_CONTROL [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLELISTDIGITALCONTROLCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 131;
                LIST_DIGITAL [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 139;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 139;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 140;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 141;
                MYBRIDGE . FriendlyId = (ushort) ( SOURCE_ID  .Value ) ; 
                __context__.SourceCodeLine = 142;
                MYBRIDGE . FriendlyName  =  ( SOURCE_NAME + Functions.ItoA (  (int) ( SOURCE_ID  .Value ) )  )  .ToString() ; 
                __context__.SourceCodeLine = 143;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 144;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 145;
                MYBRIDGE . DefaultAudioSwitcherId = (ushort) ( AUDIO_SWITCHER  .Value ) ; 
                __context__.SourceCodeLine = 146;
                MYBRIDGE . DefaultAudioInputNumber = (ushort) ( AUDIO_INPUT  .Value ) ; 
                __context__.SourceCodeLine = 147;
                MYBRIDGE . DefaultVideoSwitcherId = (ushort) ( VIDEO_SWITCHER  .Value ) ; 
                __context__.SourceCodeLine = 148;
                MYBRIDGE . DefaultVideoInputNumber = (ushort) ( VIDEO_INPUT  .Value ) ; 
                __context__.SourceCodeLine = 149;
                MYBRIDGE . HandheldPageNum = (ushort) ( HANDHELD_PAGE_TYPE  .Value ) ; 
                __context__.SourceCodeLine = 151;
                MYBRIDGE . NumListDigitals = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 152;
                MYBRIDGE . NumListAnalogs = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 153;
                MYBRIDGE . NumListSerials = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 154;
                MYBRIDGE . NumQuickDigitals = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 155;
                MYBRIDGE . NumQuickAnalogs = (ushort) ( 0 ) ; 
                __context__.SourceCodeLine = 156;
                MYBRIDGE . NumQuickSerials = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 158;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 159;
                // RegisterEvent( MYBRIDGE , SETINUSECHANGE , HANDLEINUSECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetInUseChange  += HANDLEINUSECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 160;
                // RegisterEvent( MYBRIDGE , ONDIGITALOUTPUTCHANGE , HANDLEDIGITALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnDigitalOutputChange  += HANDLEDIGITALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 161;
                // RegisterEvent( MYBRIDGE , ONANALOGOUTPUTCHANGE , HANDLEANALOGOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnAnalogOutputChange  += HANDLEANALOGOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 163;
                // RegisterEvent( MYBRIDGE , SETQUICKCONTROLCHANGE , HANDLEQUICKCONTROLCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetQuickControlChange  += HANDLEQUICKCONTROLCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 164;
                // RegisterEvent( MYBRIDGE , SETLISTDIGITALCONTROLCHANGE , HANDLELISTDIGITALCONTROLCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetListDigitalControlChange  += HANDLELISTDIGITALCONTROLCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 166;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 300 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 168;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( D_IN[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 170;
                        GINUMDIGITALS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 171;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 166;
                    } 
                
                __context__.SourceCodeLine = 175;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 100 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)1; 
                int __FN_FORSTEP_VAL__2 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 177;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( A_IN[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 179;
                        GINUMANALOGS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 180;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 175;
                    } 
                
                __context__.SourceCodeLine = 184;
                ushort __FN_FORSTART_VAL__3 = (ushort) ( 100 ) ;
                ushort __FN_FOREND_VAL__3 = (ushort)1; 
                int __FN_FORSTEP_VAL__3 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                    { 
                    __context__.SourceCodeLine = 186;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( S_IN[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 188;
                        GINUMSERIALS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 189;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 184;
                    } 
                
                __context__.SourceCodeLine = 193;
                MYBRIDGE . NumDigitals = (ushort) ( GINUMDIGITALS ) ; 
                __context__.SourceCodeLine = 194;
                MYBRIDGE . NumAnalogs = (ushort) ( GINUMANALOGS ) ; 
                __context__.SourceCodeLine = 195;
                MYBRIDGE . NumSerials = (ushort) ( GINUMSERIALS ) ; 
                __context__.SourceCodeLine = 197;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object READ_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 200;
            MYBRIDGE . ReadFileData ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object WRITE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 201;
        MYBRIDGE . WriteFileData ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object D_IN_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 204;
        MYBRIDGE . DigitalInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( D_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object A_IN_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 205;
        MYBRIDGE . AnalogInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( A_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object S_IN_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 206;
        MYBRIDGE . SerialInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), S_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object QUICK_DIGITAL_FB_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 208;
        MYBRIDGE . QuickDigitalFeedbackChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( QUICK_DIGITAL_FB[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object QUICK_SERIAL_FB_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 209;
        MYBRIDGE . QuickSerialFeedbackChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), QUICK_SERIAL_FB[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIST_DIGITAL_FB_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 211;
        MYBRIDGE . ListDigitalFeedbackChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( LIST_DIGITAL_FB[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIST_ANALOG_FB_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 212;
        MYBRIDGE . ListAnalogFeedbackChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( LIST_ANALOG_FB[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIST_SERIAL_FB_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 213;
        MYBRIDGE . ListSerialFeedbackChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), LIST_SERIAL_FB[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    INIT = new Crestron.Logos.SplusObjects.DigitalInput( INIT__DigitalInput__, this );
    m_DigitalInputList.Add( INIT__DigitalInput__, INIT );
    
    READ = new Crestron.Logos.SplusObjects.DigitalInput( READ__DigitalInput__, this );
    m_DigitalInputList.Add( READ__DigitalInput__, READ );
    
    WRITE = new Crestron.Logos.SplusObjects.DigitalInput( WRITE__DigitalInput__, this );
    m_DigitalInputList.Add( WRITE__DigitalInput__, WRITE );
    
    QUICK_DIGITAL_FB = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        QUICK_DIGITAL_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( QUICK_DIGITAL_FB__DigitalInput__ + i, QUICK_DIGITAL_FB__DigitalInput__, this );
        m_DigitalInputList.Add( QUICK_DIGITAL_FB__DigitalInput__ + i, QUICK_DIGITAL_FB[i+1] );
    }
    
    LIST_DIGITAL_FB = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        LIST_DIGITAL_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( LIST_DIGITAL_FB__DigitalInput__ + i, LIST_DIGITAL_FB__DigitalInput__, this );
        m_DigitalInputList.Add( LIST_DIGITAL_FB__DigitalInput__ + i, LIST_DIGITAL_FB[i+1] );
    }
    
    D_IN = new InOutArray<DigitalInput>( 300, this );
    for( uint i = 0; i < 300; i++ )
    {
        D_IN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( D_IN__DigitalInput__ + i, D_IN__DigitalInput__, this );
        m_DigitalInputList.Add( D_IN__DigitalInput__ + i, D_IN[i+1] );
    }
    
    IN_USE = new Crestron.Logos.SplusObjects.DigitalOutput( IN_USE__DigitalOutput__, this );
    m_DigitalOutputList.Add( IN_USE__DigitalOutput__, IN_USE );
    
    QUICK_CONTROL = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        QUICK_CONTROL[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICK_CONTROL__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICK_CONTROL__DigitalOutput__ + i, QUICK_CONTROL[i+1] );
    }
    
    LIST_DIGITAL = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        LIST_DIGITAL[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( LIST_DIGITAL__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( LIST_DIGITAL__DigitalOutput__ + i, LIST_DIGITAL[i+1] );
    }
    
    D_OUT = new InOutArray<DigitalOutput>( 300, this );
    for( uint i = 0; i < 300; i++ )
    {
        D_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( D_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( D_OUT__DigitalOutput__ + i, D_OUT[i+1] );
    }
    
    LIST_ANALOG_FB = new InOutArray<AnalogInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        LIST_ANALOG_FB[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( LIST_ANALOG_FB__AnalogSerialInput__ + i, LIST_ANALOG_FB__AnalogSerialInput__, this );
        m_AnalogInputList.Add( LIST_ANALOG_FB__AnalogSerialInput__ + i, LIST_ANALOG_FB[i+1] );
    }
    
    A_IN = new InOutArray<AnalogInput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        A_IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( A_IN__AnalogSerialInput__ + i, A_IN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( A_IN__AnalogSerialInput__ + i, A_IN[i+1] );
    }
    
    A_OUT = new InOutArray<AnalogOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        A_OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( A_OUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( A_OUT__AnalogSerialOutput__ + i, A_OUT[i+1] );
    }
    
    QUICK_SERIAL_FB = new InOutArray<StringInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        QUICK_SERIAL_FB[i+1] = new Crestron.Logos.SplusObjects.StringInput( QUICK_SERIAL_FB__AnalogSerialInput__ + i, QUICK_SERIAL_FB__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( QUICK_SERIAL_FB__AnalogSerialInput__ + i, QUICK_SERIAL_FB[i+1] );
    }
    
    LIST_SERIAL_FB = new InOutArray<StringInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        LIST_SERIAL_FB[i+1] = new Crestron.Logos.SplusObjects.StringInput( LIST_SERIAL_FB__AnalogSerialInput__ + i, LIST_SERIAL_FB__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( LIST_SERIAL_FB__AnalogSerialInput__ + i, LIST_SERIAL_FB[i+1] );
    }
    
    S_IN = new InOutArray<StringInput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        S_IN[i+1] = new Crestron.Logos.SplusObjects.StringInput( S_IN__AnalogSerialInput__ + i, S_IN__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( S_IN__AnalogSerialInput__ + i, S_IN[i+1] );
    }
    
    SOURCE_ID = new UShortParameter( SOURCE_ID__Parameter__, this );
    m_ParameterList.Add( SOURCE_ID__Parameter__, SOURCE_ID );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    AUDIO_SWITCHER = new UShortParameter( AUDIO_SWITCHER__Parameter__, this );
    m_ParameterList.Add( AUDIO_SWITCHER__Parameter__, AUDIO_SWITCHER );
    
    AUDIO_INPUT = new UShortParameter( AUDIO_INPUT__Parameter__, this );
    m_ParameterList.Add( AUDIO_INPUT__Parameter__, AUDIO_INPUT );
    
    VIDEO_SWITCHER = new UShortParameter( VIDEO_SWITCHER__Parameter__, this );
    m_ParameterList.Add( VIDEO_SWITCHER__Parameter__, VIDEO_SWITCHER );
    
    VIDEO_INPUT = new UShortParameter( VIDEO_INPUT__Parameter__, this );
    m_ParameterList.Add( VIDEO_INPUT__Parameter__, VIDEO_INPUT );
    
    HANDHELD_PAGE_TYPE = new UShortParameter( HANDHELD_PAGE_TYPE__Parameter__, this );
    m_ParameterList.Add( HANDHELD_PAGE_TYPE__Parameter__, HANDHELD_PAGE_TYPE );
    
    SOURCE_NAME = new StringParameter( SOURCE_NAME__Parameter__, this );
    m_ParameterList.Add( SOURCE_NAME__Parameter__, SOURCE_NAME );
    
    FILE_NAME__DOLLAR__ = new StringParameter( FILE_NAME__DOLLAR____Parameter__, this );
    m_ParameterList.Add( FILE_NAME__DOLLAR____Parameter__, FILE_NAME__DOLLAR__ );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_OnPush_0, true ) );
    READ.OnDigitalPush.Add( new InputChangeHandlerWrapper( READ_OnPush_1, true ) );
    WRITE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WRITE_OnPush_2, true ) );
    for( uint i = 0; i < 300; i++ )
        D_IN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( D_IN_OnChange_3, false ) );
        
    for( uint i = 0; i < 100; i++ )
        A_IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( A_IN_OnChange_4, false ) );
        
    for( uint i = 0; i < 100; i++ )
        S_IN[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( S_IN_OnChange_5, false ) );
        
    for( uint i = 0; i < 50; i++ )
        QUICK_DIGITAL_FB[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( QUICK_DIGITAL_FB_OnChange_6, false ) );
        
    for( uint i = 0; i < 50; i++ )
        QUICK_SERIAL_FB[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( QUICK_SERIAL_FB_OnChange_7, false ) );
        
    for( uint i = 0; i < 50; i++ )
        LIST_DIGITAL_FB[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( LIST_DIGITAL_FB_OnChange_8, false ) );
        
    for( uint i = 0; i < 50; i++ )
        LIST_ANALOG_FB[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( LIST_ANALOG_FB_OnChange_9, false ) );
        
    for( uint i = 0; i < 50; i++ )
        LIST_SERIAL_FB[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( LIST_SERIAL_FB_OnChange_10, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_Source();
    
    
}

public UserModuleClass__AS__SOURCEFULL_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint READ__DigitalInput__ = 1;
const uint WRITE__DigitalInput__ = 2;
const uint QUICK_DIGITAL_FB__DigitalInput__ = 3;
const uint LIST_DIGITAL_FB__DigitalInput__ = 53;
const uint D_IN__DigitalInput__ = 103;
const uint LIST_ANALOG_FB__AnalogSerialInput__ = 0;
const uint A_IN__AnalogSerialInput__ = 50;
const uint QUICK_SERIAL_FB__AnalogSerialInput__ = 150;
const uint LIST_SERIAL_FB__AnalogSerialInput__ = 200;
const uint S_IN__AnalogSerialInput__ = 250;
const uint IN_USE__DigitalOutput__ = 0;
const uint QUICK_CONTROL__DigitalOutput__ = 1;
const uint LIST_DIGITAL__DigitalOutput__ = 51;
const uint D_OUT__DigitalOutput__ = 101;
const uint A_OUT__AnalogSerialOutput__ = 0;
const uint SOURCE_ID__Parameter__ = 10;
const uint SOURCE_NAME__Parameter__ = 11;
const uint ACCESS_LEVEL__Parameter__ = 12;
const uint FILE_NAME__DOLLAR____Parameter__ = 13;
const uint READ_AT_BOOTUP__Parameter__ = 14;
const uint AUDIO_SWITCHER__Parameter__ = 15;
const uint AUDIO_INPUT__Parameter__ = 16;
const uint VIDEO_SWITCHER__Parameter__ = 17;
const uint VIDEO_INPUT__Parameter__ = 18;
const uint HANDHELD_PAGE_TYPE__Parameter__ = 19;

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


}

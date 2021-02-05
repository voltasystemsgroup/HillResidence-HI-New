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

namespace UserModule__AS__SOURCEIR_V1_0_0
{
    public class UserModuleClass__AS__SOURCEIR_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        Crestron.Logos.SplusObjects.DigitalInput READ;
        Crestron.Logos.SplusObjects.DigitalInput WRITE;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> QUICK_SERIAL_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> LIST_SERIAL_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> S_IN;
        Crestron.Logos.SplusObjects.DigitalOutput IN_USE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICK_CONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LIST_DIGITAL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> D_OUT;
        UShortParameter SOURCE_ID;
        StringParameter SOURCE_NAME;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME__DOLLAR__;
        StringParameter READ_AT_BOOTUP;
        UShortParameter AUDIO_SWITCHER;
        UShortParameter AUDIO_INPUT;
        UShortParameter VIDEO_SWITCHER;
        UShortParameter VIDEO_INPUT;
        AdaptCore.PD_Source MYBRIDGE;
        ushort GINUMDIGITALS = 0;
        ushort GINUMSERIALS = 0;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 87;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)MYBRIDGE.NumQuickControls; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 87;
                MYBRIDGE . QuickSerialFeedbackChange ( (ushort)( I ), QUICK_SERIAL_FB[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 87;
                } 
            
            __context__.SourceCodeLine = 88;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)MYBRIDGE.NumListControls; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 88;
                MYBRIDGE . ListSerialFeedbackChange ( (ushort)( I ), LIST_SERIAL_FB[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 88;
                } 
            
            __context__.SourceCodeLine = 89;
            ushort __FN_FORSTART_VAL__3 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__3 = (ushort)GINUMSERIALS; 
            int __FN_FORSTEP_VAL__3 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                { 
                __context__.SourceCodeLine = 89;
                MYBRIDGE . SerialInputChange ( (ushort)( I ), S_IN[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 89;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 93;
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
                
                __context__.SourceCodeLine = 94;
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
                
                __context__.SourceCodeLine = 96;
                D_OUT [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKCONTROLCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 98;
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
                
                __context__.SourceCodeLine = 100;
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
                
                
                __context__.SourceCodeLine = 108;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 108;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 109;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 110;
                MYBRIDGE . FriendlyId = (ushort) ( SOURCE_ID  .Value ) ; 
                __context__.SourceCodeLine = 111;
                MYBRIDGE . FriendlyName  =  ( SOURCE_NAME + Functions.ItoA (  (int) ( SOURCE_ID  .Value ) )  )  .ToString() ; 
                __context__.SourceCodeLine = 112;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 113;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 114;
                MYBRIDGE . DefaultAudioSwitcherId = (ushort) ( AUDIO_SWITCHER  .Value ) ; 
                __context__.SourceCodeLine = 115;
                MYBRIDGE . DefaultAudioInputNumber = (ushort) ( AUDIO_INPUT  .Value ) ; 
                __context__.SourceCodeLine = 116;
                MYBRIDGE . DefaultVideoSwitcherId = (ushort) ( VIDEO_SWITCHER  .Value ) ; 
                __context__.SourceCodeLine = 117;
                MYBRIDGE . DefaultVideoInputNumber = (ushort) ( VIDEO_INPUT  .Value ) ; 
                __context__.SourceCodeLine = 118;
                MYBRIDGE . HandheldPageNum = (ushort) ( PD_Const.cHandheldFullListPage ) ; 
                __context__.SourceCodeLine = 120;
                MYBRIDGE . NumListDigitals = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 121;
                MYBRIDGE . NumListAnalogs = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 122;
                MYBRIDGE . NumListSerials = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 123;
                MYBRIDGE . NumQuickDigitals = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 124;
                MYBRIDGE . NumQuickAnalogs = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 125;
                MYBRIDGE . NumQuickSerials = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 127;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 128;
                // RegisterEvent( MYBRIDGE , SETINUSECHANGE , HANDLEINUSECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetInUseChange  += HANDLEINUSECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 130;
                // RegisterEvent( MYBRIDGE , ONDIGITALOUTPUTCHANGE , HANDLEDIGITALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnDigitalOutputChange  += HANDLEDIGITALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 132;
                // RegisterEvent( MYBRIDGE , SETQUICKCONTROLCHANGE , HANDLEQUICKCONTROLCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetQuickControlChange  += HANDLEQUICKCONTROLCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 133;
                // RegisterEvent( MYBRIDGE , SETLISTDIGITALCONTROLCHANGE , HANDLELISTDIGITALCONTROLCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetListDigitalControlChange  += HANDLELISTDIGITALCONTROLCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 135;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 300 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 137;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( D_OUT[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 139;
                        GINUMDIGITALS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 140;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 135;
                    } 
                
                __context__.SourceCodeLine = 144;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 100 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)1; 
                int __FN_FORSTEP_VAL__2 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 146;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( S_IN[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 148;
                        GINUMSERIALS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 149;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 144;
                    } 
                
                __context__.SourceCodeLine = 153;
                MYBRIDGE . NumDigitals = (ushort) ( GINUMDIGITALS ) ; 
                __context__.SourceCodeLine = 154;
                MYBRIDGE . NumSerials = (ushort) ( GINUMSERIALS ) ; 
                __context__.SourceCodeLine = 156;
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
            
            __context__.SourceCodeLine = 159;
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
        
        __context__.SourceCodeLine = 160;
        MYBRIDGE . WriteFileData ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object S_IN_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 163;
        MYBRIDGE . SerialInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), S_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object QUICK_SERIAL_FB_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 165;
        MYBRIDGE . QuickSerialFeedbackChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), QUICK_SERIAL_FB[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIST_SERIAL_FB_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 167;
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
    
    SOURCE_NAME = new StringParameter( SOURCE_NAME__Parameter__, this );
    m_ParameterList.Add( SOURCE_NAME__Parameter__, SOURCE_NAME );
    
    FILE_NAME__DOLLAR__ = new StringParameter( FILE_NAME__DOLLAR____Parameter__, this );
    m_ParameterList.Add( FILE_NAME__DOLLAR____Parameter__, FILE_NAME__DOLLAR__ );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_OnPush_0, true ) );
    READ.OnDigitalPush.Add( new InputChangeHandlerWrapper( READ_OnPush_1, true ) );
    WRITE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WRITE_OnPush_2, true ) );
    for( uint i = 0; i < 100; i++ )
        S_IN[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( S_IN_OnChange_3, false ) );
        
    for( uint i = 0; i < 50; i++ )
        QUICK_SERIAL_FB[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( QUICK_SERIAL_FB_OnChange_4, false ) );
        
    for( uint i = 0; i < 50; i++ )
        LIST_SERIAL_FB[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( LIST_SERIAL_FB_OnChange_5, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_Source();
    
    
}

public UserModuleClass__AS__SOURCEIR_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint READ__DigitalInput__ = 1;
const uint WRITE__DigitalInput__ = 2;
const uint QUICK_SERIAL_FB__AnalogSerialInput__ = 0;
const uint LIST_SERIAL_FB__AnalogSerialInput__ = 50;
const uint S_IN__AnalogSerialInput__ = 100;
const uint IN_USE__DigitalOutput__ = 0;
const uint QUICK_CONTROL__DigitalOutput__ = 1;
const uint LIST_DIGITAL__DigitalOutput__ = 51;
const uint D_OUT__DigitalOutput__ = 101;
const uint SOURCE_ID__Parameter__ = 10;
const uint SOURCE_NAME__Parameter__ = 11;
const uint ACCESS_LEVEL__Parameter__ = 12;
const uint FILE_NAME__DOLLAR____Parameter__ = 13;
const uint READ_AT_BOOTUP__Parameter__ = 14;
const uint AUDIO_SWITCHER__Parameter__ = 15;
const uint AUDIO_INPUT__Parameter__ = 16;
const uint VIDEO_SWITCHER__Parameter__ = 17;
const uint VIDEO_INPUT__Parameter__ = 18;

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

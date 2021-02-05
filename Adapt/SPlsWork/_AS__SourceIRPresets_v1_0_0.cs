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

namespace UserModule__AS__SOURCEIRPRESETS_V1_0_0
{
    public class UserModuleClass__AS__SOURCEIRPRESETS_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        Crestron.Logos.SplusObjects.DigitalInput READ;
        Crestron.Logos.SplusObjects.DigitalInput WRITE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> PRESET_RECALL;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> S_IN;
        Crestron.Logos.SplusObjects.DigitalOutput IN_USE;
        Crestron.Logos.SplusObjects.DigitalOutput BUSY;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICK_CONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> D_OUT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> PRESET_NAME;
        UShortParameter SOURCE_ID;
        StringParameter SOURCE_NAME;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME__DOLLAR__;
        StringParameter READ_AT_BOOTUP;
        UShortParameter AUDIO_SWITCHER;
        UShortParameter AUDIO_INPUT;
        UShortParameter VIDEO_SWITCHER;
        UShortParameter VIDEO_INPUT;
        AdaptCore.PD_SourceWithPresets MYBRIDGE;
        ushort GINUMDIGITALS = 0;
        ushort GINUMSERIALS = 0;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 87;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)GINUMSERIALS; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 87;
                MYBRIDGE . SerialInputChange ( (ushort)( I ), S_IN[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 87;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 91;
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
                
                __context__.SourceCodeLine = 92;
                IN_USE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEBUSYEVENT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 93;
                BUSY  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDIGITALOUTPUT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 95;
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
                
                __context__.SourceCodeLine = 97;
                QUICK_CONTROL [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEPRESETNAMECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SEDNER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SEDNER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 99;
                PRESET_NAME [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
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
                
                
                __context__.SourceCodeLine = 107;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 107;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 108;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 109;
                MYBRIDGE . FriendlyId = (ushort) ( SOURCE_ID  .Value ) ; 
                __context__.SourceCodeLine = 110;
                MYBRIDGE . FriendlyName  =  ( SOURCE_NAME + Functions.ItoA (  (int) ( SOURCE_ID  .Value ) )  )  .ToString() ; 
                __context__.SourceCodeLine = 111;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 112;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 113;
                MYBRIDGE . DefaultAudioSwitcherId = (ushort) ( AUDIO_SWITCHER  .Value ) ; 
                __context__.SourceCodeLine = 114;
                MYBRIDGE . DefaultAudioInputNumber = (ushort) ( AUDIO_INPUT  .Value ) ; 
                __context__.SourceCodeLine = 115;
                MYBRIDGE . DefaultVideoSwitcherId = (ushort) ( VIDEO_SWITCHER  .Value ) ; 
                __context__.SourceCodeLine = 116;
                MYBRIDGE . DefaultVideoInputNumber = (ushort) ( VIDEO_INPUT  .Value ) ; 
                __context__.SourceCodeLine = 117;
                MYBRIDGE . HandheldPageNum = (ushort) ( PD_Const.cHandheldFullListPage ) ; 
                __context__.SourceCodeLine = 119;
                MYBRIDGE . NumListDigitals = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 120;
                MYBRIDGE . NumListAnalogs = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 121;
                MYBRIDGE . NumQuickDigitals = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 122;
                MYBRIDGE . NumQuickSerials = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 124;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 125;
                // RegisterEvent( MYBRIDGE , SETINUSECHANGE , HANDLEINUSECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetInUseChange  += HANDLEINUSECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 126;
                // RegisterEvent( MYBRIDGE , ONBUSYEVENT , HANDLEBUSYEVENT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnBusyEvent  += HANDLEBUSYEVENT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 128;
                // RegisterEvent( MYBRIDGE , ONDIGITALOUTPUTCHANGE , HANDLEDIGITALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnDigitalOutputChange  += HANDLEDIGITALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 130;
                // RegisterEvent( MYBRIDGE , SETQUICKCONTROLCHANGE , HANDLEQUICKCONTROLCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetQuickControlChange  += HANDLEQUICKCONTROLCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 131;
                // RegisterEvent( MYBRIDGE , SETPRESETNAMECHANGE , HANDLEPRESETNAMECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetPresetNameChange  += HANDLEPRESETNAMECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 133;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 300 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 135;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( D_OUT[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 137;
                        GINUMDIGITALS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 138;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 133;
                    } 
                
                __context__.SourceCodeLine = 142;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 100 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)1; 
                int __FN_FORSTEP_VAL__2 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 144;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( S_IN[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 146;
                        GINUMSERIALS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 147;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 142;
                    } 
                
                __context__.SourceCodeLine = 151;
                MYBRIDGE . NumDigitals = (ushort) ( GINUMDIGITALS ) ; 
                __context__.SourceCodeLine = 152;
                MYBRIDGE . NumSerials = (ushort) ( GINUMSERIALS ) ; 
                __context__.SourceCodeLine = 154;
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
            
            __context__.SourceCodeLine = 157;
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
        
        __context__.SourceCodeLine = 158;
        MYBRIDGE . WriteFileData ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object PRESET_RECALL_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 161;
        MYBRIDGE . RecallPreset ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object S_IN_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 162;
        MYBRIDGE . SerialInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), S_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        
        
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
    
    PRESET_RECALL = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        PRESET_RECALL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( PRESET_RECALL__DigitalInput__ + i, PRESET_RECALL__DigitalInput__, this );
        m_DigitalInputList.Add( PRESET_RECALL__DigitalInput__ + i, PRESET_RECALL[i+1] );
    }
    
    IN_USE = new Crestron.Logos.SplusObjects.DigitalOutput( IN_USE__DigitalOutput__, this );
    m_DigitalOutputList.Add( IN_USE__DigitalOutput__, IN_USE );
    
    BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( BUSY__DigitalOutput__, BUSY );
    
    QUICK_CONTROL = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        QUICK_CONTROL[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICK_CONTROL__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICK_CONTROL__DigitalOutput__ + i, QUICK_CONTROL[i+1] );
    }
    
    D_OUT = new InOutArray<DigitalOutput>( 300, this );
    for( uint i = 0; i < 300; i++ )
    {
        D_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( D_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( D_OUT__DigitalOutput__ + i, D_OUT[i+1] );
    }
    
    S_IN = new InOutArray<StringInput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        S_IN[i+1] = new Crestron.Logos.SplusObjects.StringInput( S_IN__AnalogSerialInput__ + i, S_IN__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( S_IN__AnalogSerialInput__ + i, S_IN[i+1] );
    }
    
    PRESET_NAME = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        PRESET_NAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( PRESET_NAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( PRESET_NAME__AnalogSerialOutput__ + i, PRESET_NAME[i+1] );
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
    for( uint i = 0; i < 50; i++ )
        PRESET_RECALL[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( PRESET_RECALL_OnPush_3, false ) );
        
    for( uint i = 0; i < 100; i++ )
        S_IN[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( S_IN_OnChange_4, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_SourceWithPresets();
    
    
}

public UserModuleClass__AS__SOURCEIRPRESETS_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint READ__DigitalInput__ = 1;
const uint WRITE__DigitalInput__ = 2;
const uint PRESET_RECALL__DigitalInput__ = 3;
const uint S_IN__AnalogSerialInput__ = 0;
const uint IN_USE__DigitalOutput__ = 0;
const uint BUSY__DigitalOutput__ = 1;
const uint QUICK_CONTROL__DigitalOutput__ = 2;
const uint D_OUT__DigitalOutput__ = 52;
const uint PRESET_NAME__AnalogSerialOutput__ = 0;
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

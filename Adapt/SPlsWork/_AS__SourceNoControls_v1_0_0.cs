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

namespace UserModule__AS__SOURCENOCONTROLS_V1_0_0
{
    public class UserModuleClass__AS__SOURCENOCONTROLS_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        Crestron.Logos.SplusObjects.DigitalInput READ;
        Crestron.Logos.SplusObjects.DigitalInput WRITE;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> INFOLINE;
        Crestron.Logos.SplusObjects.DigitalOutput IN_USE;
        UShortParameter SOURCE_NUM;
        StringParameter SOURCE_NAME;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME__DOLLAR__;
        StringParameter READ_AT_BOOTUP;
        UShortParameter AUDIO_SWITCHER;
        UShortParameter AUDIO_INPUT;
        UShortParameter VIDEO_SWITCHER;
        UShortParameter VIDEO_INPUT;
        AdaptCore.PD_Source MYBRIDGE;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 64;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)4; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 66;
                MYBRIDGE . QuickSerialFeedbackChange ( (ushort)( I ), INFOLINE[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 67;
                MYBRIDGE . ListSerialFeedbackChange ( (ushort)( I ), INFOLINE[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 68;
                MYBRIDGE . SerialInputChange ( (ushort)( I ), INFOLINE[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 64;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 73;
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
                
                __context__.SourceCodeLine = 74;
                IN_USE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
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
                
                
                __context__.SourceCodeLine = 81;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 81;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 82;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 83;
                MYBRIDGE . FriendlyId = (ushort) ( SOURCE_NUM  .Value ) ; 
                __context__.SourceCodeLine = 84;
                MYBRIDGE . FriendlyName  =  ( SOURCE_NAME + Functions.ItoA (  (int) ( SOURCE_NUM  .Value ) )  )  .ToString() ; 
                __context__.SourceCodeLine = 85;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 86;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 87;
                MYBRIDGE . DefaultAudioSwitcherId = (ushort) ( AUDIO_SWITCHER  .Value ) ; 
                __context__.SourceCodeLine = 88;
                MYBRIDGE . DefaultAudioInputNumber = (ushort) ( AUDIO_INPUT  .Value ) ; 
                __context__.SourceCodeLine = 89;
                MYBRIDGE . DefaultVideoSwitcherId = (ushort) ( VIDEO_SWITCHER  .Value ) ; 
                __context__.SourceCodeLine = 90;
                MYBRIDGE . DefaultVideoInputNumber = (ushort) ( VIDEO_INPUT  .Value ) ; 
                __context__.SourceCodeLine = 92;
                MYBRIDGE . HandheldPageNum = (ushort) ( PD_Const.cHandheldInfoOnlyPage ) ; 
                __context__.SourceCodeLine = 93;
                MYBRIDGE . NumListControls = (ushort) ( 4 ) ; 
                __context__.SourceCodeLine = 95;
                MYBRIDGE . NumSerials = (ushort) ( 4 ) ; 
                __context__.SourceCodeLine = 96;
                MYBRIDGE . NumListSerials = (ushort) ( 4 ) ; 
                __context__.SourceCodeLine = 97;
                MYBRIDGE . NumQuickSerials = (ushort) ( 4 ) ; 
                __context__.SourceCodeLine = 99;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 100;
                // RegisterEvent( MYBRIDGE , SETINUSECHANGE , HANDLEINUSECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetInUseChange  += HANDLEINUSECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 102;
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
            
            __context__.SourceCodeLine = 109;
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
        
        __context__.SourceCodeLine = 114;
        MYBRIDGE . WriteFileData ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INFOLINE_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 119;
        MYBRIDGE . QuickSerialFeedbackChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), INFOLINE[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        __context__.SourceCodeLine = 120;
        MYBRIDGE . ListSerialFeedbackChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), INFOLINE[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        __context__.SourceCodeLine = 121;
        MYBRIDGE . SerialInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), INFOLINE[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        
        
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
    
    INFOLINE = new InOutArray<StringInput>( 4, this );
    for( uint i = 0; i < 4; i++ )
    {
        INFOLINE[i+1] = new Crestron.Logos.SplusObjects.StringInput( INFOLINE__AnalogSerialInput__ + i, INFOLINE__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( INFOLINE__AnalogSerialInput__ + i, INFOLINE[i+1] );
    }
    
    SOURCE_NUM = new UShortParameter( SOURCE_NUM__Parameter__, this );
    m_ParameterList.Add( SOURCE_NUM__Parameter__, SOURCE_NUM );
    
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
    for( uint i = 0; i < 4; i++ )
        INFOLINE[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( INFOLINE_OnChange_3, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_Source();
    
    
}

public UserModuleClass__AS__SOURCENOCONTROLS_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint READ__DigitalInput__ = 1;
const uint WRITE__DigitalInput__ = 2;
const uint INFOLINE__AnalogSerialInput__ = 0;
const uint IN_USE__DigitalOutput__ = 0;
const uint SOURCE_NUM__Parameter__ = 10;
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

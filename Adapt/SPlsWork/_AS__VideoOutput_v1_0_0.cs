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

namespace UserModule__AS__VIDEOOUTPUT_V1_0_0
{
    public class UserModuleClass__AS__VIDEOOUTPUT_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> D_FB_IN;
        Crestron.Logos.SplusObjects.AnalogInput SOURCE_FB;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> A_FB_IN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> D_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput VIDEO_SOURCE;
        Crestron.Logos.SplusObjects.AnalogOutput AUDIO_SOURCE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> A_OUT;
        UShortParameter OUTPUT_NUMBER;
        UShortParameter SWITCHER_NUMBER;
        UShortParameter SWITCHER_TYPE;
        StringParameter OUTPUT_NAME;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_VideoOutput MYBRIDGE;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 65;
            MYBRIDGE . SourceFeedbackChange ( (ushort)( SOURCE_FB  .UshortValue )) ; 
            __context__.SourceCodeLine = 67;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)10; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 69;
                MYBRIDGE . DigitalInputChange ( (ushort)( I ), (ushort)( D_FB_IN[ I ] .Value )) ; 
                __context__.SourceCodeLine = 70;
                MYBRIDGE . AnalogInputChange ( (ushort)( I ), (ushort)( A_FB_IN[ I ] .UshortValue )) ; 
                __context__.SourceCodeLine = 67;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 75;
                FNREFRESHINPUTS (  __context__  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDIGITALOUTPUT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 77;
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
                
                __context__.SourceCodeLine = 78;
                A_OUT [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESOURCEVALUECONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 82;
                VIDEO_SOURCE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                __context__.SourceCodeLine = 83;
                AUDIO_SOURCE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEAUDIOSOURCEVALUECONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 86;
                AUDIO_SOURCE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 92;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 92;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 93;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 94;
                MYBRIDGE . FriendlyId = (ushort) ( OUTPUT_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 95;
                MYBRIDGE . OutputNumber = (ushort) ( OUTPUT_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 96;
                MYBRIDGE . ParentId = (ushort) ( SWITCHER_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 97;
                MYBRIDGE . ParentTypeNum = (ushort) ( SWITCHER_TYPE  .Value ) ; 
                __context__.SourceCodeLine = 98;
                MYBRIDGE . FriendlyName  =  ( OUTPUT_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 99;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 100;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 101;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 103;
                MYBRIDGE . NumDigitals = (ushort) ( 10 ) ; 
                __context__.SourceCodeLine = 104;
                MYBRIDGE . NumAnalogs = (ushort) ( 10 ) ; 
                __context__.SourceCodeLine = 106;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 108;
                // RegisterEvent( MYBRIDGE , ONDIGITALOUTPUTCHANGE , HANDLEDIGITALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnDigitalOutputChange  += HANDLEDIGITALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 109;
                // RegisterEvent( MYBRIDGE , ONANALOGOUTPUTCHANGE , HANDLEANALOGOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnAnalogOutputChange  += HANDLEANALOGOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 111;
                // RegisterEvent( MYBRIDGE , SETSOURCECONTROLCHANGE , HANDLESOURCEVALUECONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceControlChange  += HANDLESOURCEVALUECONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 112;
                // RegisterEvent( MYBRIDGE , SETAUDIOSOURCECONTROLCHANGE , HANDLEAUDIOSOURCEVALUECONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetAudioSourceControlChange  += HANDLEAUDIOSOURCEVALUECONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 114;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SOURCE_FB_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 117;
            MYBRIDGE . SourceFeedbackChange ( (ushort)( SOURCE_FB  .UshortValue )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object D_FB_IN_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 119;
        MYBRIDGE . DigitalInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( D_FB_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object A_FB_IN_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 120;
        MYBRIDGE . AnalogInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( A_FB_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .UshortValue )) ; 
        
        
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
    
    D_FB_IN = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        D_FB_IN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( D_FB_IN__DigitalInput__ + i, D_FB_IN__DigitalInput__, this );
        m_DigitalInputList.Add( D_FB_IN__DigitalInput__ + i, D_FB_IN[i+1] );
    }
    
    D_OUT = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        D_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( D_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( D_OUT__DigitalOutput__ + i, D_OUT[i+1] );
    }
    
    SOURCE_FB = new Crestron.Logos.SplusObjects.AnalogInput( SOURCE_FB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SOURCE_FB__AnalogSerialInput__, SOURCE_FB );
    
    A_FB_IN = new InOutArray<AnalogInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        A_FB_IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( A_FB_IN__AnalogSerialInput__ + i, A_FB_IN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( A_FB_IN__AnalogSerialInput__ + i, A_FB_IN[i+1] );
    }
    
    VIDEO_SOURCE = new Crestron.Logos.SplusObjects.AnalogOutput( VIDEO_SOURCE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VIDEO_SOURCE__AnalogSerialOutput__, VIDEO_SOURCE );
    
    AUDIO_SOURCE = new Crestron.Logos.SplusObjects.AnalogOutput( AUDIO_SOURCE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( AUDIO_SOURCE__AnalogSerialOutput__, AUDIO_SOURCE );
    
    A_OUT = new InOutArray<AnalogOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        A_OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( A_OUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( A_OUT__AnalogSerialOutput__ + i, A_OUT[i+1] );
    }
    
    OUTPUT_NUMBER = new UShortParameter( OUTPUT_NUMBER__Parameter__, this );
    m_ParameterList.Add( OUTPUT_NUMBER__Parameter__, OUTPUT_NUMBER );
    
    SWITCHER_NUMBER = new UShortParameter( SWITCHER_NUMBER__Parameter__, this );
    m_ParameterList.Add( SWITCHER_NUMBER__Parameter__, SWITCHER_NUMBER );
    
    SWITCHER_TYPE = new UShortParameter( SWITCHER_TYPE__Parameter__, this );
    m_ParameterList.Add( SWITCHER_TYPE__Parameter__, SWITCHER_TYPE );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    OUTPUT_NAME = new StringParameter( OUTPUT_NAME__Parameter__, this );
    m_ParameterList.Add( OUTPUT_NAME__Parameter__, OUTPUT_NAME );
    
    FILE_NAME = new StringParameter( FILE_NAME__Parameter__, this );
    m_ParameterList.Add( FILE_NAME__Parameter__, FILE_NAME );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_OnPush_0, true ) );
    SOURCE_FB.OnAnalogChange.Add( new InputChangeHandlerWrapper( SOURCE_FB_OnChange_1, false ) );
    for( uint i = 0; i < 10; i++ )
        D_FB_IN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( D_FB_IN_OnChange_2, false ) );
        
    for( uint i = 0; i < 10; i++ )
        A_FB_IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( A_FB_IN_OnChange_3, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_VideoOutput();
    
    
}

public UserModuleClass__AS__VIDEOOUTPUT_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint D_FB_IN__DigitalInput__ = 1;
const uint SOURCE_FB__AnalogSerialInput__ = 0;
const uint A_FB_IN__AnalogSerialInput__ = 1;
const uint D_OUT__DigitalOutput__ = 0;
const uint VIDEO_SOURCE__AnalogSerialOutput__ = 0;
const uint AUDIO_SOURCE__AnalogSerialOutput__ = 1;
const uint A_OUT__AnalogSerialOutput__ = 2;
const uint OUTPUT_NUMBER__Parameter__ = 10;
const uint SWITCHER_NUMBER__Parameter__ = 11;
const uint SWITCHER_TYPE__Parameter__ = 12;
const uint OUTPUT_NAME__Parameter__ = 13;
const uint ACCESS_LEVEL__Parameter__ = 14;
const uint FILE_NAME__Parameter__ = 15;
const uint READ_AT_BOOTUP__Parameter__ = 16;

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

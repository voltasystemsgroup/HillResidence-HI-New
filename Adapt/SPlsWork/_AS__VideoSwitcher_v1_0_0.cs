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

namespace UserModule__AS__VIDEOSWITCHER_V1_0_0
{
    public class UserModuleClass__AS__VIDEOSWITCHER_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT_COMPLETE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> D_FB_IN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> A_FB_IN;
        Crestron.Logos.SplusObjects.DigitalOutput BUSY;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> D_OUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> A_OUT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> S_OUT;
        UShortParameter SWITCHER_NUMBER;
        StringParameter SWITCHER_NAME;
        UShortParameter NUMBER_OF_INPUTS;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_VideoSwitcher MYBRIDGE;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 61;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)32; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 63;
                MYBRIDGE . DigitalInputChange ( (ushort)( I ), (ushort)( D_FB_IN[ I ] .Value )) ; 
                __context__.SourceCodeLine = 64;
                MYBRIDGE . AnalogInputChange ( (ushort)( I ), (ushort)( A_FB_IN[ I ] .UshortValue )) ; 
                __context__.SourceCodeLine = 61;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 69;
                FNREFRESHINPUTS (  __context__  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEBUSYEVENT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 71;
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
                
                __context__.SourceCodeLine = 73;
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
                
                __context__.SourceCodeLine = 74;
                A_OUT [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESERIALOUTPUT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 75;
                S_OUT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_COMPLETE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 80;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 80;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 81;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 82;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 83;
                MYBRIDGE . FriendlyId = (ushort) ( SWITCHER_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 84;
                MYBRIDGE . NumInputs = (ushort) ( NUMBER_OF_INPUTS  .Value ) ; 
                __context__.SourceCodeLine = 85;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 86;
                MYBRIDGE . FriendlyName  =  ( SWITCHER_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 87;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 89;
                MYBRIDGE . NumDigitals = (ushort) ( 32 ) ; 
                __context__.SourceCodeLine = 90;
                MYBRIDGE . NumAnalogs = (ushort) ( 32 ) ; 
                __context__.SourceCodeLine = 92;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 94;
                // RegisterEvent( MYBRIDGE , ONBUSYEVENT , HANDLEBUSYEVENT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnBusyEvent  += HANDLEBUSYEVENT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 96;
                // RegisterEvent( MYBRIDGE , ONDIGITALOUTPUTCHANGE , HANDLEDIGITALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnDigitalOutputChange  += HANDLEDIGITALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 97;
                // RegisterEvent( MYBRIDGE , ONANALOGOUTPUTCHANGE , HANDLEANALOGOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnAnalogOutputChange  += HANDLEANALOGOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 98;
                // RegisterEvent( MYBRIDGE , ONSERIALOUTPUTCHANGE , HANDLESERIALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnSerialOutputChange  += HANDLESERIALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 100;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object D_FB_IN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 103;
            MYBRIDGE . DigitalInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( D_FB_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object A_FB_IN_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 104;
        MYBRIDGE . AnalogInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( A_FB_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}


public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    INIT_COMPLETE = new Crestron.Logos.SplusObjects.DigitalInput( INIT_COMPLETE__DigitalInput__, this );
    m_DigitalInputList.Add( INIT_COMPLETE__DigitalInput__, INIT_COMPLETE );
    
    D_FB_IN = new InOutArray<DigitalInput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        D_FB_IN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( D_FB_IN__DigitalInput__ + i, D_FB_IN__DigitalInput__, this );
        m_DigitalInputList.Add( D_FB_IN__DigitalInput__ + i, D_FB_IN[i+1] );
    }
    
    BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( BUSY__DigitalOutput__, BUSY );
    
    D_OUT = new InOutArray<DigitalOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        D_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( D_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( D_OUT__DigitalOutput__ + i, D_OUT[i+1] );
    }
    
    A_FB_IN = new InOutArray<AnalogInput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        A_FB_IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( A_FB_IN__AnalogSerialInput__ + i, A_FB_IN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( A_FB_IN__AnalogSerialInput__ + i, A_FB_IN[i+1] );
    }
    
    A_OUT = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        A_OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( A_OUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( A_OUT__AnalogSerialOutput__ + i, A_OUT[i+1] );
    }
    
    S_OUT = new InOutArray<StringOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        S_OUT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( S_OUT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( S_OUT__AnalogSerialOutput__ + i, S_OUT[i+1] );
    }
    
    SWITCHER_NUMBER = new UShortParameter( SWITCHER_NUMBER__Parameter__, this );
    m_ParameterList.Add( SWITCHER_NUMBER__Parameter__, SWITCHER_NUMBER );
    
    NUMBER_OF_INPUTS = new UShortParameter( NUMBER_OF_INPUTS__Parameter__, this );
    m_ParameterList.Add( NUMBER_OF_INPUTS__Parameter__, NUMBER_OF_INPUTS );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    SWITCHER_NAME = new StringParameter( SWITCHER_NAME__Parameter__, this );
    m_ParameterList.Add( SWITCHER_NAME__Parameter__, SWITCHER_NAME );
    
    FILE_NAME = new StringParameter( FILE_NAME__Parameter__, this );
    m_ParameterList.Add( FILE_NAME__Parameter__, FILE_NAME );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT_COMPLETE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_COMPLETE_OnPush_0, true ) );
    for( uint i = 0; i < 32; i++ )
        D_FB_IN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( D_FB_IN_OnChange_1, false ) );
        
    for( uint i = 0; i < 32; i++ )
        A_FB_IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( A_FB_IN_OnChange_2, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_VideoSwitcher();
    
    
}

public UserModuleClass__AS__VIDEOSWITCHER_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT_COMPLETE__DigitalInput__ = 0;
const uint D_FB_IN__DigitalInput__ = 1;
const uint A_FB_IN__AnalogSerialInput__ = 0;
const uint BUSY__DigitalOutput__ = 0;
const uint D_OUT__DigitalOutput__ = 1;
const uint A_OUT__AnalogSerialOutput__ = 0;
const uint S_OUT__AnalogSerialOutput__ = 32;
const uint SWITCHER_NUMBER__Parameter__ = 10;
const uint SWITCHER_NAME__Parameter__ = 11;
const uint NUMBER_OF_INPUTS__Parameter__ = 12;
const uint ACCESS_LEVEL__Parameter__ = 13;
const uint FILE_NAME__Parameter__ = 14;
const uint READ_AT_BOOTUP__Parameter__ = 15;

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

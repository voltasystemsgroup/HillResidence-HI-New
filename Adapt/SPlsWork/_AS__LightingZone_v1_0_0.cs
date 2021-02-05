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

namespace UserModule__AS__LIGHTINGZONE_V1_0_0
{
    public class UserModuleClass__AS__LIGHTINGZONE_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT_COMPLETE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SCENE_FB_IN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> LOAD_LEVEL_FB_IN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SCENE_BTN_OUT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> LOAD_CONTROL;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> LOAD_LEVEL_OUT;
        UShortParameter ZONE_NUMBER;
        StringParameter ZONE_NAME;
        UShortParameter NUMBEROFSCENES;
        UShortParameter NUMBEROFLOADS;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_LightingZone MYBRIDGE;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 66;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)MYBRIDGE.NumScenes; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 68;
                MYBRIDGE . ListDigitalFeedbackChange ( (ushort)( I ), (ushort)( SCENE_FB_IN[ I ] .Value )) ; 
                __context__.SourceCodeLine = 69;
                MYBRIDGE . QuickDigitalFeedbackChange ( (ushort)( I ), (ushort)( SCENE_FB_IN[ I ] .Value )) ; 
                __context__.SourceCodeLine = 66;
                } 
            
            __context__.SourceCodeLine = 72;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)NUMBEROFLOADS  .Value; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 74;
                MYBRIDGE . AnalogInputChange ( (ushort)( I ), (ushort)( LOAD_LEVEL_FB_IN[ I ] .UshortValue )) ; 
                __context__.SourceCodeLine = 72;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 79;
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
                
                __context__.SourceCodeLine = 81;
                LOAD_CONTROL [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEANALOGOUTPUT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_AnalogEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 82;
                LOAD_LEVEL_OUT [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKCONTROLCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 84;
                SCENE_BTN_OUT [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLELISTDIGITALCONTROLCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 85;
                SCENE_BTN_OUT [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_COMPLETE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 90;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 90;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 91;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 92;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 93;
                MYBRIDGE . FriendlyId = (ushort) ( ZONE_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 94;
                MYBRIDGE . NumScenes = (ushort) ( NUMBEROFSCENES  .Value ) ; 
                __context__.SourceCodeLine = 95;
                MYBRIDGE . NumLoads = (ushort) ( NUMBEROFLOADS  .Value ) ; 
                __context__.SourceCodeLine = 96;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 97;
                MYBRIDGE . FriendlyName  =  ( ZONE_NAME + Functions.ItoA (  (int) ( ZONE_NUMBER  .Value ) )  )  .ToString() ; 
                __context__.SourceCodeLine = 98;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 100;
                MYBRIDGE . NumDigitals = (ushort) ( 40 ) ; 
                __context__.SourceCodeLine = 101;
                MYBRIDGE . NumSerials = (ushort) ( NUMBEROFLOADS  .Value ) ; 
                __context__.SourceCodeLine = 102;
                MYBRIDGE . NumAnalogs = (ushort) ( NUMBEROFLOADS  .Value ) ; 
                __context__.SourceCodeLine = 103;
                MYBRIDGE . NumListDigitals = (ushort) ( NUMBEROFSCENES  .Value ) ; 
                __context__.SourceCodeLine = 105;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 107;
                // RegisterEvent( MYBRIDGE , ONDIGITALOUTPUTCHANGE , HANDLEDIGITALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnDigitalOutputChange  += HANDLEDIGITALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 108;
                // RegisterEvent( MYBRIDGE , ONANALOGOUTPUTCHANGE , HANDLEANALOGOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnAnalogOutputChange  += HANDLEANALOGOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 110;
                // RegisterEvent( MYBRIDGE , SETQUICKCONTROLCHANGE , HANDLEQUICKCONTROLCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetQuickControlChange  += HANDLEQUICKCONTROLCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 111;
                // RegisterEvent( MYBRIDGE , SETLISTDIGITALCONTROLCHANGE , HANDLELISTDIGITALCONTROLCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetListDigitalControlChange  += HANDLELISTDIGITALCONTROLCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 113;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SCENE_FB_IN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 117;
            MYBRIDGE . ListDigitalFeedbackChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( SCENE_FB_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object LOAD_LEVEL_FB_IN_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 118;
        MYBRIDGE . AnalogInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( LOAD_LEVEL_FB_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .UshortValue )) ; 
        
        
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
    
    SCENE_FB_IN = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        SCENE_FB_IN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_FB_IN__DigitalInput__ + i, SCENE_FB_IN__DigitalInput__, this );
        m_DigitalInputList.Add( SCENE_FB_IN__DigitalInput__ + i, SCENE_FB_IN[i+1] );
    }
    
    SCENE_BTN_OUT = new InOutArray<DigitalOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        SCENE_BTN_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_BTN_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SCENE_BTN_OUT__DigitalOutput__ + i, SCENE_BTN_OUT[i+1] );
    }
    
    LOAD_CONTROL = new InOutArray<DigitalOutput>( 20, this );
    for( uint i = 0; i < 20; i++ )
    {
        LOAD_CONTROL[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( LOAD_CONTROL__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( LOAD_CONTROL__DigitalOutput__ + i, LOAD_CONTROL[i+1] );
    }
    
    LOAD_LEVEL_FB_IN = new InOutArray<AnalogInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LOAD_LEVEL_FB_IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( LOAD_LEVEL_FB_IN__AnalogSerialInput__ + i, LOAD_LEVEL_FB_IN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( LOAD_LEVEL_FB_IN__AnalogSerialInput__ + i, LOAD_LEVEL_FB_IN[i+1] );
    }
    
    LOAD_LEVEL_OUT = new InOutArray<AnalogOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        LOAD_LEVEL_OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( LOAD_LEVEL_OUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( LOAD_LEVEL_OUT__AnalogSerialOutput__ + i, LOAD_LEVEL_OUT[i+1] );
    }
    
    ZONE_NUMBER = new UShortParameter( ZONE_NUMBER__Parameter__, this );
    m_ParameterList.Add( ZONE_NUMBER__Parameter__, ZONE_NUMBER );
    
    NUMBEROFSCENES = new UShortParameter( NUMBEROFSCENES__Parameter__, this );
    m_ParameterList.Add( NUMBEROFSCENES__Parameter__, NUMBEROFSCENES );
    
    NUMBEROFLOADS = new UShortParameter( NUMBEROFLOADS__Parameter__, this );
    m_ParameterList.Add( NUMBEROFLOADS__Parameter__, NUMBEROFLOADS );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    ZONE_NAME = new StringParameter( ZONE_NAME__Parameter__, this );
    m_ParameterList.Add( ZONE_NAME__Parameter__, ZONE_NAME );
    
    FILE_NAME = new StringParameter( FILE_NAME__Parameter__, this );
    m_ParameterList.Add( FILE_NAME__Parameter__, FILE_NAME );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT_COMPLETE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_COMPLETE_OnPush_0, true ) );
    for( uint i = 0; i < 12; i++ )
        SCENE_FB_IN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( SCENE_FB_IN_OnChange_1, false ) );
        
    for( uint i = 0; i < 10; i++ )
        LOAD_LEVEL_FB_IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( LOAD_LEVEL_FB_IN_OnChange_2, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_LightingZone();
    
    
}

public UserModuleClass__AS__LIGHTINGZONE_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT_COMPLETE__DigitalInput__ = 0;
const uint SCENE_FB_IN__DigitalInput__ = 1;
const uint LOAD_LEVEL_FB_IN__AnalogSerialInput__ = 0;
const uint SCENE_BTN_OUT__DigitalOutput__ = 0;
const uint LOAD_CONTROL__DigitalOutput__ = 12;
const uint LOAD_LEVEL_OUT__AnalogSerialOutput__ = 0;
const uint ZONE_NUMBER__Parameter__ = 10;
const uint ZONE_NAME__Parameter__ = 11;
const uint NUMBEROFSCENES__Parameter__ = 12;
const uint NUMBEROFLOADS__Parameter__ = 13;
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

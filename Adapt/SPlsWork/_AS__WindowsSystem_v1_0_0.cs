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

namespace UserModule__AS__WINDOWSSYSTEM_V1_0_0
{
    public class UserModuleClass__AS__WINDOWSSYSTEM_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT_COMPLETE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> D_IN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> A_IN;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> S_IN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> D_OUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> A_OUT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> S_OUT;
        UShortParameter SYSTEM_NUMBER;
        StringParameter SYSTEM_NAME;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_WindowSystem MYBRIDGE;
        ushort GINUMDIGITALS = 0;
        ushort GINUMANALOGS = 0;
        ushort GINUMSERIALS = 0;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 60;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 51 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)GINUMDIGITALS; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 60;
                MYBRIDGE . DigitalInputChange ( (ushort)( I ), (ushort)( D_IN[ I ] .Value )) ; 
                __context__.SourceCodeLine = 60;
                } 
            
            __context__.SourceCodeLine = 61;
            ushort __FN_FORSTART_VAL__2 = (ushort) ( 11 ) ;
            ushort __FN_FOREND_VAL__2 = (ushort)GINUMANALOGS; 
            int __FN_FORSTEP_VAL__2 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                { 
                __context__.SourceCodeLine = 61;
                MYBRIDGE . AnalogInputChange ( (ushort)( I ), (ushort)( A_IN[ I ] .UshortValue )) ; 
                __context__.SourceCodeLine = 61;
                } 
            
            __context__.SourceCodeLine = 62;
            ushort __FN_FORSTART_VAL__3 = (ushort) ( 24 ) ;
            ushort __FN_FOREND_VAL__3 = (ushort)GINUMSERIALS; 
            int __FN_FORSTEP_VAL__3 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                { 
                __context__.SourceCodeLine = 62;
                MYBRIDGE . SerialInputChange ( (ushort)( I ), S_IN[ I ] .ToString()) ; 
                __context__.SourceCodeLine = 62;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 66;
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
                
                __context__.SourceCodeLine = 68;
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
                
                __context__.SourceCodeLine = 69;
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
                
                __context__.SourceCodeLine = 70;
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
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 78;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 78;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 79;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 80;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 81;
                MYBRIDGE . FriendlyId = (ushort) ( SYSTEM_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 82;
                MYBRIDGE . NumScenes = (ushort) ( 12 ) ; 
                __context__.SourceCodeLine = 83;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 84;
                MYBRIDGE . FriendlyName  =  ( SYSTEM_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 85;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 87;
                ushort __FN_FORSTART_VAL__1 = (ushort) ( 300 ) ;
                ushort __FN_FOREND_VAL__1 = (ushort)1; 
                int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                    { 
                    __context__.SourceCodeLine = 89;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( D_IN[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 91;
                        GINUMDIGITALS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 92;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 87;
                    } 
                
                __context__.SourceCodeLine = 96;
                ushort __FN_FORSTART_VAL__2 = (ushort) ( 100 ) ;
                ushort __FN_FOREND_VAL__2 = (ushort)1; 
                int __FN_FORSTEP_VAL__2 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__2; (__FN_FORSTEP_VAL__2 > 0)  ? ( (I  >= __FN_FORSTART_VAL__2) && (I  <= __FN_FOREND_VAL__2) ) : ( (I  <= __FN_FORSTART_VAL__2) && (I  >= __FN_FOREND_VAL__2) ) ; I  += (ushort)__FN_FORSTEP_VAL__2) 
                    { 
                    __context__.SourceCodeLine = 98;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( A_IN[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 100;
                        GINUMANALOGS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 101;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 96;
                    } 
                
                __context__.SourceCodeLine = 105;
                ushort __FN_FORSTART_VAL__3 = (ushort) ( 100 ) ;
                ushort __FN_FOREND_VAL__3 = (ushort)1; 
                int __FN_FORSTEP_VAL__3 = (int)Functions.ToLongInteger( -( 1 ) ); 
                for ( I  = __FN_FORSTART_VAL__3; (__FN_FORSTEP_VAL__3 > 0)  ? ( (I  >= __FN_FORSTART_VAL__3) && (I  <= __FN_FOREND_VAL__3) ) : ( (I  <= __FN_FORSTART_VAL__3) && (I  >= __FN_FOREND_VAL__3) ) ; I  += (ushort)__FN_FORSTEP_VAL__3) 
                    { 
                    __context__.SourceCodeLine = 107;
                    if ( Functions.TestForTrue  ( ( IsSignalDefined( S_IN[ I ] ))  ) ) 
                        { 
                        __context__.SourceCodeLine = 109;
                        GINUMSERIALS = (ushort) ( I ) ; 
                        __context__.SourceCodeLine = 110;
                        break ; 
                        } 
                    
                    __context__.SourceCodeLine = 105;
                    } 
                
                __context__.SourceCodeLine = 114;
                MYBRIDGE . NumDigitals = (ushort) ( GINUMDIGITALS ) ; 
                __context__.SourceCodeLine = 115;
                MYBRIDGE . NumAnalogs = (ushort) ( GINUMANALOGS ) ; 
                __context__.SourceCodeLine = 116;
                MYBRIDGE . NumSerials = (ushort) ( GINUMSERIALS ) ; 
                __context__.SourceCodeLine = 117;
                MYBRIDGE . NumScenes = (ushort) ( 12 ) ; 
                __context__.SourceCodeLine = 119;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 121;
                // RegisterEvent( MYBRIDGE , ONDIGITALOUTPUTCHANGE , HANDLEDIGITALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnDigitalOutputChange  += HANDLEDIGITALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 122;
                // RegisterEvent( MYBRIDGE , ONANALOGOUTPUTCHANGE , HANDLEANALOGOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnAnalogOutputChange  += HANDLEANALOGOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 123;
                // RegisterEvent( MYBRIDGE , ONSERIALOUTPUTCHANGE , HANDLESERIALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnSerialOutputChange  += HANDLESERIALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 125;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object D_IN_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 128;
            MYBRIDGE . DigitalInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( D_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object A_IN_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 129;
        MYBRIDGE . AnalogInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( A_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .UshortValue )) ; 
        
        
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
        
        __context__.SourceCodeLine = 130;
        MYBRIDGE . SerialInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), S_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .ToString()) ; 
        
        
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
    
    D_IN = new InOutArray<DigitalInput>( 300, this );
    for( uint i = 0; i < 300; i++ )
    {
        D_IN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( D_IN__DigitalInput__ + i, D_IN__DigitalInput__, this );
        m_DigitalInputList.Add( D_IN__DigitalInput__ + i, D_IN[i+1] );
    }
    
    D_OUT = new InOutArray<DigitalOutput>( 300, this );
    for( uint i = 0; i < 300; i++ )
    {
        D_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( D_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( D_OUT__DigitalOutput__ + i, D_OUT[i+1] );
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
    
    S_IN = new InOutArray<StringInput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        S_IN[i+1] = new Crestron.Logos.SplusObjects.StringInput( S_IN__AnalogSerialInput__ + i, S_IN__AnalogSerialInput__, 255, this );
        m_StringInputList.Add( S_IN__AnalogSerialInput__ + i, S_IN[i+1] );
    }
    
    S_OUT = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        S_OUT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( S_OUT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( S_OUT__AnalogSerialOutput__ + i, S_OUT[i+1] );
    }
    
    SYSTEM_NUMBER = new UShortParameter( SYSTEM_NUMBER__Parameter__, this );
    m_ParameterList.Add( SYSTEM_NUMBER__Parameter__, SYSTEM_NUMBER );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    SYSTEM_NAME = new StringParameter( SYSTEM_NAME__Parameter__, this );
    m_ParameterList.Add( SYSTEM_NAME__Parameter__, SYSTEM_NAME );
    
    FILE_NAME = new StringParameter( FILE_NAME__Parameter__, this );
    m_ParameterList.Add( FILE_NAME__Parameter__, FILE_NAME );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT_COMPLETE.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_COMPLETE_OnPush_0, true ) );
    for( uint i = 0; i < 300; i++ )
        D_IN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( D_IN_OnChange_1, false ) );
        
    for( uint i = 0; i < 100; i++ )
        A_IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( A_IN_OnChange_2, false ) );
        
    for( uint i = 0; i < 100; i++ )
        S_IN[i+1].OnSerialChange.Add( new InputChangeHandlerWrapper( S_IN_OnChange_3, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_WindowSystem();
    
    
}

public UserModuleClass__AS__WINDOWSSYSTEM_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT_COMPLETE__DigitalInput__ = 0;
const uint D_IN__DigitalInput__ = 1;
const uint A_IN__AnalogSerialInput__ = 0;
const uint S_IN__AnalogSerialInput__ = 100;
const uint D_OUT__DigitalOutput__ = 0;
const uint A_OUT__AnalogSerialOutput__ = 0;
const uint S_OUT__AnalogSerialOutput__ = 100;
const uint SYSTEM_NUMBER__Parameter__ = 10;
const uint SYSTEM_NAME__Parameter__ = 11;
const uint ACCESS_LEVEL__Parameter__ = 12;
const uint FILE_NAME__Parameter__ = 13;
const uint READ_AT_BOOTUP__Parameter__ = 14;

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

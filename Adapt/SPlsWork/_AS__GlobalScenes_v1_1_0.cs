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

namespace UserModule__AS__GLOBALSCENES_V1_1_0
{
    public class UserModuleClass__AS__GLOBALSCENES_V1_1_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SCENE_RECALL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SCENE_RECALLING;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SCENE_NAME;
        UShortParameter USER_NUMBER;
        StringParameter USER_NAME;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME__DOLLAR__;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_User MYBRIDGE;
        public void HANDLESCENENAMEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 57;
                SCENE_NAME [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESCENERECALLED ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 58;
                SCENE_RECALLING [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 63;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 63;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 64;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 65;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME__DOLLAR__  )  .ToString() ; 
                __context__.SourceCodeLine = 66;
                MYBRIDGE . FriendlyId = (ushort) ( USER_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 67;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 68;
                MYBRIDGE . FriendlyName  =  ( USER_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 69;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 71;
                // RegisterEvent( MYBRIDGE , SETSCENENAMEFEEDBACK , HANDLESCENENAMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSceneNameFeedback  += HANDLESCENENAMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 72;
                // RegisterEvent( MYBRIDGE , SETSCENERECALLED , HANDLESCENERECALLED ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSceneRecalled  += HANDLESCENERECALLED; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 74;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object SCENE_RECALL_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 79;
            MYBRIDGE . RecallScene ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) )) ; 
            
            
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
    
    SCENE_RECALL = new InOutArray<DigitalInput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SCENE_RECALL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SCENE_RECALL__DigitalInput__ + i, SCENE_RECALL__DigitalInput__, this );
        m_DigitalInputList.Add( SCENE_RECALL__DigitalInput__ + i, SCENE_RECALL[i+1] );
    }
    
    SCENE_RECALLING = new InOutArray<DigitalOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SCENE_RECALLING[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SCENE_RECALLING__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SCENE_RECALLING__DigitalOutput__ + i, SCENE_RECALLING[i+1] );
    }
    
    SCENE_NAME = new InOutArray<StringOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        SCENE_NAME[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SCENE_NAME__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SCENE_NAME__AnalogSerialOutput__ + i, SCENE_NAME[i+1] );
    }
    
    USER_NUMBER = new UShortParameter( USER_NUMBER__Parameter__, this );
    m_ParameterList.Add( USER_NUMBER__Parameter__, USER_NUMBER );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    USER_NAME = new StringParameter( USER_NAME__Parameter__, this );
    m_ParameterList.Add( USER_NAME__Parameter__, USER_NAME );
    
    FILE_NAME__DOLLAR__ = new StringParameter( FILE_NAME__DOLLAR____Parameter__, this );
    m_ParameterList.Add( FILE_NAME__DOLLAR____Parameter__, FILE_NAME__DOLLAR__ );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_OnPush_0, true ) );
    for( uint i = 0; i < 24; i++ )
        SCENE_RECALL[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( SCENE_RECALL_OnPush_1, true ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_User();
    
    
}

public UserModuleClass__AS__GLOBALSCENES_V1_1_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint SCENE_RECALL__DigitalInput__ = 1;
const uint SCENE_RECALLING__DigitalOutput__ = 0;
const uint SCENE_NAME__AnalogSerialOutput__ = 0;
const uint USER_NUMBER__Parameter__ = 10;
const uint USER_NAME__Parameter__ = 11;
const uint ACCESS_LEVEL__Parameter__ = 12;
const uint FILE_NAME__DOLLAR____Parameter__ = 13;
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

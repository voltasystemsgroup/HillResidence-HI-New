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

namespace UserModule__AS__CLIMATESYSTEM_V1_0_0
{
    public class UserModuleClass__AS__CLIMATESYSTEM_V1_0_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT_COMPLETE;
        UShortParameter SYSTEM_NUMBER;
        StringParameter SYSTEM_NAME;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_ClimateSystemEx MYBRIDGE;
        object INIT_COMPLETE_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                ushort I = 0;
                
                
                __context__.SourceCodeLine = 55;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 55;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 56;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 57;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 58;
                MYBRIDGE . FriendlyId = (ushort) ( SYSTEM_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 59;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 60;
                MYBRIDGE . FriendlyName  =  ( SYSTEM_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 61;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 63;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
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
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        MYBRIDGE  = new AdaptCore.PD_ClimateSystemEx();
        
        
    }
    
    public UserModuleClass__AS__CLIMATESYSTEM_V1_0_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint INIT_COMPLETE__DigitalInput__ = 0;
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

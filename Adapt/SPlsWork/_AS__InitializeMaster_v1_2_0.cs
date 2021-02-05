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

namespace UserModule__AS__INITIALIZEMASTER_V1_2_0
{
    public class UserModuleClass__AS__INITIALIZEMASTER_V1_2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.StringInput UCMD_INPUT__DOLLAR__;
        Crestron.Logos.SplusObjects.DigitalOutput INITIALIZATIONCOMPLETE;
        Crestron.Logos.SplusObjects.DigitalOutput PROGRAMREADY;
        Crestron.Logos.SplusObjects.DigitalOutput LOADINGFILES;
        Crestron.Logos.SplusObjects.StringOutput COREMESSAGES__DOLLAR__;
        StringParameter JOB_NUMBER;
        StringParameter LICENSE_KEY;
        StringParameter DEALER;
        StringParameter PROCESSOR_NAME;
        StringParameter PROCESSOR_IP_ADDRESS;
        UShortParameter DEFAULT_FILE_LOCATION;
        UShortParameter STARTUP_DELAY_SECONDS;
        AdaptCore.PD_Notifier CORENOTICES;
        public void ONNOTICE ( SimplSharpString MESSAGE ) 
            { 
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 53;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MESSAGE .ToString() == PD_Const.cAllowNextProgram))  ) ) 
                    {
                    __context__.SourceCodeLine = 53;
                    PROGRAMREADY  .Value = (ushort) ( 1 ) ; 
                    }
                
                else 
                    {
                    __context__.SourceCodeLine = 54;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MESSAGE .ToString() == PD_Const.cLoadingFilesEndMessage))  ) ) 
                        {
                        __context__.SourceCodeLine = 54;
                        LOADINGFILES  .Value = (ushort) ( 0 ) ; 
                        }
                    
                    else 
                        {
                        __context__.SourceCodeLine = 55;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (MESSAGE .ToString() == PD_Const.cLoadingFilesStartMessage))  ) ) 
                            {
                            __context__.SourceCodeLine = 55;
                            LOADINGFILES  .Value = (ushort) ( 1 ) ; 
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 57;
                COREMESSAGES__DOLLAR__  .UpdateValue ( MESSAGE  .ToString()  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object UCMD_INPUT__DOLLAR___OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                 PD_Core.UserCommand(  UCMD_INPUT__DOLLAR__ .ToString() )  ;  
 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public override object FunctionMain (  object __obj__ ) 
        { 
        try
        {
            SplusExecutionContext __context__ = SplusFunctionMainStartCode();
            
            __context__.SourceCodeLine = 69;
            WaitForInitializationComplete ( ) ; 
            __context__.SourceCodeLine = 71;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                {
                __context__.SourceCodeLine = 71;
                 PD_Core.DebugOn  =  (ushort)( 1 )  ;  
 
                }
            
            __context__.SourceCodeLine = 73;
            // RegisterDelegate( CORENOTICES , NOTICEHANDLER , ONNOTICE ) 
            CORENOTICES .NoticeHandler  = ONNOTICE; ; 
            __context__.SourceCodeLine = 75;
             PD_Core.DealerName  =( DEALER  )  .ToString()  ;  
 
            __context__.SourceCodeLine = 76;
             PD_Core.LicenseKey  =( LICENSE_KEY  )  .ToString()  ;  
 
            __context__.SourceCodeLine = 77;
             PD_Core.ProcessorName  =( PROCESSOR_NAME  )  .ToString()  ;  
 
            __context__.SourceCodeLine = 78;
             PD_Core.ProcessorIp  =( PROCESSOR_IP_ADDRESS  )  .ToString()  ;  
 
            __context__.SourceCodeLine = 81;
             PD_Core.InitializeAsMaster(  JOB_NUMBER  .ToString() , (ushort)( DEFAULT_FILE_LOCATION  .Value ) , (ushort)( STARTUP_DELAY_SECONDS  .Value ) )  ;  
 
            __context__.SourceCodeLine = 82;
            INITIALIZATIONCOMPLETE  .Value = (ushort) ( 1 ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        return __obj__;
        }
        
    
    public override void LogosSplusInitialize()
    {
        _SplusNVRAM = new SplusNVRAM( this );
        
        INITIALIZATIONCOMPLETE = new Crestron.Logos.SplusObjects.DigitalOutput( INITIALIZATIONCOMPLETE__DigitalOutput__, this );
        m_DigitalOutputList.Add( INITIALIZATIONCOMPLETE__DigitalOutput__, INITIALIZATIONCOMPLETE );
        
        PROGRAMREADY = new Crestron.Logos.SplusObjects.DigitalOutput( PROGRAMREADY__DigitalOutput__, this );
        m_DigitalOutputList.Add( PROGRAMREADY__DigitalOutput__, PROGRAMREADY );
        
        LOADINGFILES = new Crestron.Logos.SplusObjects.DigitalOutput( LOADINGFILES__DigitalOutput__, this );
        m_DigitalOutputList.Add( LOADINGFILES__DigitalOutput__, LOADINGFILES );
        
        UCMD_INPUT__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( UCMD_INPUT__DOLLAR____AnalogSerialInput__, 255, this );
        m_StringInputList.Add( UCMD_INPUT__DOLLAR____AnalogSerialInput__, UCMD_INPUT__DOLLAR__ );
        
        COREMESSAGES__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( COREMESSAGES__DOLLAR____AnalogSerialOutput__, this );
        m_StringOutputList.Add( COREMESSAGES__DOLLAR____AnalogSerialOutput__, COREMESSAGES__DOLLAR__ );
        
        DEFAULT_FILE_LOCATION = new UShortParameter( DEFAULT_FILE_LOCATION__Parameter__, this );
        m_ParameterList.Add( DEFAULT_FILE_LOCATION__Parameter__, DEFAULT_FILE_LOCATION );
        
        STARTUP_DELAY_SECONDS = new UShortParameter( STARTUP_DELAY_SECONDS__Parameter__, this );
        m_ParameterList.Add( STARTUP_DELAY_SECONDS__Parameter__, STARTUP_DELAY_SECONDS );
        
        JOB_NUMBER = new StringParameter( JOB_NUMBER__Parameter__, this );
        m_ParameterList.Add( JOB_NUMBER__Parameter__, JOB_NUMBER );
        
        LICENSE_KEY = new StringParameter( LICENSE_KEY__Parameter__, this );
        m_ParameterList.Add( LICENSE_KEY__Parameter__, LICENSE_KEY );
        
        DEALER = new StringParameter( DEALER__Parameter__, this );
        m_ParameterList.Add( DEALER__Parameter__, DEALER );
        
        PROCESSOR_NAME = new StringParameter( PROCESSOR_NAME__Parameter__, this );
        m_ParameterList.Add( PROCESSOR_NAME__Parameter__, PROCESSOR_NAME );
        
        PROCESSOR_IP_ADDRESS = new StringParameter( PROCESSOR_IP_ADDRESS__Parameter__, this );
        m_ParameterList.Add( PROCESSOR_IP_ADDRESS__Parameter__, PROCESSOR_IP_ADDRESS );
        
        
        UCMD_INPUT__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( UCMD_INPUT__DOLLAR___OnChange_0, false ) );
        
        _SplusNVRAM.PopulateCustomAttributeList( true );
        
        NVRAM = _SplusNVRAM;
        
    }
    
    public override void LogosSimplSharpInitialize()
    {
        CORENOTICES  = new AdaptCore.PD_Notifier();
        
        
    }
    
    public UserModuleClass__AS__INITIALIZEMASTER_V1_2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}
    
    
    
    
    const uint UCMD_INPUT__DOLLAR____AnalogSerialInput__ = 0;
    const uint INITIALIZATIONCOMPLETE__DigitalOutput__ = 0;
    const uint PROGRAMREADY__DigitalOutput__ = 1;
    const uint LOADINGFILES__DigitalOutput__ = 2;
    const uint COREMESSAGES__DOLLAR____AnalogSerialOutput__ = 0;
    const uint JOB_NUMBER__Parameter__ = 10;
    const uint LICENSE_KEY__Parameter__ = 11;
    const uint DEALER__Parameter__ = 12;
    const uint PROCESSOR_NAME__Parameter__ = 13;
    const uint PROCESSOR_IP_ADDRESS__Parameter__ = 14;
    const uint DEFAULT_FILE_LOCATION__Parameter__ = 15;
    const uint STARTUP_DELAY_SECONDS__Parameter__ = 16;
    
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

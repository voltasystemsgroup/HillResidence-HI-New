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

namespace UserModule_DYNAMIC_ZERO_DELAY__V1_00
{
    public class UserModuleClass_DYNAMIC_ZERO_DELAY__V1_00 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        Crestron.Logos.SplusObjects.AnalogInput I;
        Crestron.Logos.SplusObjects.AnalogInput DELAY_TIME;
        Crestron.Logos.SplusObjects.AnalogOutput O;
        object I_OnChange_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 15;
                if ( Functions.TestForTrue  ( ( Functions.Not( I  .UshortValue ))  ) ) 
                    { 
                    __context__.SourceCodeLine = 17;
                    CreateWait ( "DELAYEDOUTPUT" , DELAY_TIME  .UshortValue , DELAYEDOUTPUT_Callback ) ;
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 24;
                    CancelWait ( "DELAYEDOUTPUT" ) ; 
                    __context__.SourceCodeLine = 25;
                    O  .Value = (ushort) ( I  .UshortValue ) ; 
                    } 
                
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    public void DELAYEDOUTPUT_CallbackFn( object stateInfo )
    {
    
        try
        {
            Wait __LocalWait__ = (Wait)stateInfo;
            SplusExecutionContext __context__ = SplusThreadStartCode(__LocalWait__);
            __LocalWait__.RemoveFromList();
            
            
            __context__.SourceCodeLine = 19;
            O  .Value = (ushort) ( I  .UshortValue ) ; 
            
        
        
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler(); }
        
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    I = new Crestron.Logos.SplusObjects.AnalogInput( I__AnalogSerialInput__, this );
    m_AnalogInputList.Add( I__AnalogSerialInput__, I );
    
    DELAY_TIME = new Crestron.Logos.SplusObjects.AnalogInput( DELAY_TIME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DELAY_TIME__AnalogSerialInput__, DELAY_TIME );
    
    O = new Crestron.Logos.SplusObjects.AnalogOutput( O__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( O__AnalogSerialOutput__, O );
    
    DELAYEDOUTPUT_Callback = new WaitFunction( DELAYEDOUTPUT_CallbackFn );
    
    I.OnAnalogChange.Add( new InputChangeHandlerWrapper( I_OnChange_0, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_DYNAMIC_ZERO_DELAY__V1_00 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}


private WaitFunction DELAYEDOUTPUT_Callback;


const uint I__AnalogSerialInput__ = 0;
const uint DELAY_TIME__AnalogSerialInput__ = 1;
const uint O__AnalogSerialOutput__ = 0;

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

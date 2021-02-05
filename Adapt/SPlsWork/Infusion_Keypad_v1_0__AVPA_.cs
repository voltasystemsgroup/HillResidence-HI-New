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

namespace UserModule_INFUSION_KEYPAD_V1_0__AVPA_
{
    public class UserModuleClass_INFUSION_KEYPAD_V1_0__AVPA_ : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.StringInput VANTAGE_RX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> BUTTON;
        InOutArray<Crestron.Logos.SplusObjects.StringInput> VID_INPUT__DOLLAR__;
        Crestron.Logos.SplusObjects.StringOutput VANTAGE_TX__DOLLAR__;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> BUTTON_FB;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> BUTTON_STATE_FB;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> BUTTON_LED_BLINK_FB;
        object BUTTON_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 89;
                _SplusNVRAM.IINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
                __context__.SourceCodeLine = 91;
                VANTAGE_TX__DOLLAR__  .UpdateValue ( "BTNPRESS " + VID_INPUT__DOLLAR__ [ _SplusNVRAM.IINDEX ] + " \u000D\u000A"  ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object BUTTON_OnRelease_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 98;
            _SplusNVRAM.IINDEX = (ushort) ( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ) ; 
            __context__.SourceCodeLine = 100;
            VANTAGE_TX__DOLLAR__  .UpdateValue ( "BTNRELEASE " + VID_INPUT__DOLLAR__ [ _SplusNVRAM.IINDEX ] + " \u000D\u000A"  ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object VANTAGE_RX__DOLLAR___OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        CrestronString TEMPSTR__DOLLAR__;
        TEMPSTR__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 40, this );
        
        CrestronString VID_RX__DOLLAR__;
        VID_RX__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 11, this );
        
        CrestronString LED_STATE__DOLLAR__;
        LED_STATE__DOLLAR__  = new CrestronString( Crestron.Logos.SplusObjects.CrestronStringEncoding.eEncodingASCII, 2, this );
        
        ushort STRLENGHT = 0;
        
        ushort I = 0;
        ushort I_POS = 0;
        
        ushort ILED_BLINK_STATE = 0;
        
        
        __context__.SourceCodeLine = 123;
        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( VANTAGE_RX__DOLLAR__ , (int)( 1 ) ) == "S"))  ) ) 
            { 
            __context__.SourceCodeLine = 125;
            TEMPSTR__DOLLAR__  .UpdateValue ( Functions.Remove ( "S:LED " , VANTAGE_RX__DOLLAR__ )  ) ; 
            } 
        
        else 
            {
            __context__.SourceCodeLine = 127;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (Functions.Left( VANTAGE_RX__DOLLAR__ , (int)( 1 ) ) == "R"))  ) ) 
                { 
                __context__.SourceCodeLine = 129;
                TEMPSTR__DOLLAR__  .UpdateValue ( Functions.Remove ( "R:GETLED " , VANTAGE_RX__DOLLAR__ )  ) ; 
                } 
            
            }
        
        __context__.SourceCodeLine = 132;
        TEMPSTR__DOLLAR__  .UpdateValue ( Functions.Remove ( " " , VANTAGE_RX__DOLLAR__ )  ) ; 
        __context__.SourceCodeLine = 133;
        VID_RX__DOLLAR__  .UpdateValue ( Functions.Left ( TEMPSTR__DOLLAR__ ,  (int) ( (Functions.Length( TEMPSTR__DOLLAR__ ) - 1) ) )  ) ; 
        __context__.SourceCodeLine = 136;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)_SplusNVRAM.GDEFINEDINPUTS; 
        int __FN_FORSTEP_VAL__1 = (int)1; 
        for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 140;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VID_RX__DOLLAR__ == VID_INPUT__DOLLAR__[ I ]))  ) ) 
                { 
                __context__.SourceCodeLine = 143;
                TEMPSTR__DOLLAR__  .UpdateValue ( Functions.Remove ( " " , VANTAGE_RX__DOLLAR__ )  ) ; 
                __context__.SourceCodeLine = 144;
                LED_STATE__DOLLAR__  .UpdateValue ( Functions.Left ( TEMPSTR__DOLLAR__ ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 146;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (LED_STATE__DOLLAR__ == "0"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 148;
                    BUTTON_FB [ I]  .Value = (ushort) ( 0 ) ; 
                    } 
                
                else 
                    { 
                    __context__.SourceCodeLine = 150;
                    BUTTON_FB [ I]  .Value = (ushort) ( 1 ) ; 
                    } 
                
                __context__.SourceCodeLine = 154;
                BUTTON_STATE_FB [ I]  .Value = (ushort) ( Functions.Atoi( LED_STATE__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 158;
                I_POS = (ushort) ( Functions.ReverseFind( " " , VANTAGE_RX__DOLLAR__ ) ) ; 
                __context__.SourceCodeLine = 160;
                TEMPSTR__DOLLAR__  .UpdateValue ( Functions.Mid ( VANTAGE_RX__DOLLAR__ ,  (int) ( (I_POS + 1) ) ,  (int) ( 1 ) )  ) ; 
                __context__.SourceCodeLine = 162;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTR__DOLLAR__ == "O"))  ) ) 
                    { 
                    __context__.SourceCodeLine = 164;
                    BUTTON_LED_BLINK_FB [ I]  .Value = (ushort) ( 0 ) ; 
                    __context__.SourceCodeLine = 165;
                    break ; 
                    } 
                
                else 
                    {
                    __context__.SourceCodeLine = 166;
                    if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTR__DOLLAR__ == "F"))  ) ) 
                        { 
                        __context__.SourceCodeLine = 167;
                        BUTTON_LED_BLINK_FB [ I]  .Value = (ushort) ( 1 ) ; 
                        __context__.SourceCodeLine = 168;
                        break ; 
                        } 
                    
                    else 
                        {
                        __context__.SourceCodeLine = 169;
                        if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTR__DOLLAR__ == "M"))  ) ) 
                            { 
                            __context__.SourceCodeLine = 170;
                            BUTTON_LED_BLINK_FB [ I]  .Value = (ushort) ( 2 ) ; 
                            __context__.SourceCodeLine = 171;
                            break ; 
                            } 
                        
                        else 
                            {
                            __context__.SourceCodeLine = 172;
                            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTR__DOLLAR__ == "S"))  ) ) 
                                { 
                                __context__.SourceCodeLine = 173;
                                BUTTON_LED_BLINK_FB [ I]  .Value = (ushort) ( 3 ) ; 
                                __context__.SourceCodeLine = 174;
                                break ; 
                                } 
                            
                            else 
                                {
                                __context__.SourceCodeLine = 175;
                                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (TEMPSTR__DOLLAR__ == "V"))  ) ) 
                                    { 
                                    __context__.SourceCodeLine = 176;
                                    BUTTON_LED_BLINK_FB [ I]  .Value = (ushort) ( 4 ) ; 
                                    __context__.SourceCodeLine = 177;
                                    break ; 
                                    } 
                                
                                }
                            
                            }
                        
                        }
                    
                    }
                
                __context__.SourceCodeLine = 183;
                break ; 
                } 
            
            __context__.SourceCodeLine = 136;
            } 
        
        
        
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
        
        __context__.SourceCodeLine = 200;
        _SplusNVRAM.GSTARTUP = (ushort) ( 1 ) ; 
        __context__.SourceCodeLine = 202;
        WaitForInitializationComplete ( ) ; 
        __context__.SourceCodeLine = 206;
        ushort __FN_FORSTART_VAL__1 = (ushort) ( 8 ) ;
        ushort __FN_FOREND_VAL__1 = (ushort)1; 
        int __FN_FORSTEP_VAL__1 = (int)Functions.ToLongInteger( -( 1 ) ); 
        for ( _SplusNVRAM.GDEFINEDINPUTS  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (_SplusNVRAM.GDEFINEDINPUTS  >= __FN_FORSTART_VAL__1) && (_SplusNVRAM.GDEFINEDINPUTS  <= __FN_FOREND_VAL__1) ) : ( (_SplusNVRAM.GDEFINEDINPUTS  <= __FN_FORSTART_VAL__1) && (_SplusNVRAM.GDEFINEDINPUTS  >= __FN_FOREND_VAL__1) ) ; _SplusNVRAM.GDEFINEDINPUTS  += (ushort)__FN_FORSTEP_VAL__1) 
            { 
            __context__.SourceCodeLine = 208;
            if ( Functions.TestForTrue  ( ( Functions.BoolToInt (VID_INPUT__DOLLAR__[ _SplusNVRAM.GDEFINEDINPUTS ] != "0"))  ) ) 
                { 
                __context__.SourceCodeLine = 210;
                break ; 
                } 
            
            __context__.SourceCodeLine = 206;
            } 
        
        __context__.SourceCodeLine = 214;
        _SplusNVRAM.GSTARTUP = (ushort) ( 0 ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler(); }
    return __obj__;
    }
    

public override void LogosSplusInitialize()
{
    _SplusNVRAM = new SplusNVRAM( this );
    
    BUTTON = new InOutArray<DigitalInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BUTTON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( BUTTON__DigitalInput__ + i, BUTTON__DigitalInput__, this );
        m_DigitalInputList.Add( BUTTON__DigitalInput__ + i, BUTTON[i+1] );
    }
    
    BUTTON_FB = new InOutArray<DigitalOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BUTTON_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( BUTTON_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( BUTTON_FB__DigitalOutput__ + i, BUTTON_FB[i+1] );
    }
    
    BUTTON_STATE_FB = new InOutArray<AnalogOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BUTTON_STATE_FB[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( BUTTON_STATE_FB__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( BUTTON_STATE_FB__AnalogSerialOutput__ + i, BUTTON_STATE_FB[i+1] );
    }
    
    BUTTON_LED_BLINK_FB = new InOutArray<AnalogOutput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        BUTTON_LED_BLINK_FB[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( BUTTON_LED_BLINK_FB__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( BUTTON_LED_BLINK_FB__AnalogSerialOutput__ + i, BUTTON_LED_BLINK_FB[i+1] );
    }
    
    VANTAGE_RX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringInput( VANTAGE_RX__DOLLAR____AnalogSerialInput__, 40, this );
    m_StringInputList.Add( VANTAGE_RX__DOLLAR____AnalogSerialInput__, VANTAGE_RX__DOLLAR__ );
    
    VID_INPUT__DOLLAR__ = new InOutArray<StringInput>( 8, this );
    for( uint i = 0; i < 8; i++ )
    {
        VID_INPUT__DOLLAR__[i+1] = new Crestron.Logos.SplusObjects.StringInput( VID_INPUT__DOLLAR____AnalogSerialInput__ + i, VID_INPUT__DOLLAR____AnalogSerialInput__, 10, this );
        m_StringInputList.Add( VID_INPUT__DOLLAR____AnalogSerialInput__ + i, VID_INPUT__DOLLAR__[i+1] );
    }
    
    VANTAGE_TX__DOLLAR__ = new Crestron.Logos.SplusObjects.StringOutput( VANTAGE_TX__DOLLAR____AnalogSerialOutput__, this );
    m_StringOutputList.Add( VANTAGE_TX__DOLLAR____AnalogSerialOutput__, VANTAGE_TX__DOLLAR__ );
    
    
    for( uint i = 0; i < 8; i++ )
        BUTTON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( BUTTON_OnPush_0, false ) );
        
    for( uint i = 0; i < 8; i++ )
        BUTTON[i+1].OnDigitalRelease.Add( new InputChangeHandlerWrapper( BUTTON_OnRelease_1, false ) );
        
    VANTAGE_RX__DOLLAR__.OnSerialChange.Add( new InputChangeHandlerWrapper( VANTAGE_RX__DOLLAR___OnChange_2, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    
    
}

public UserModuleClass_INFUSION_KEYPAD_V1_0__AVPA_ ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint VANTAGE_RX__DOLLAR____AnalogSerialInput__ = 0;
const uint BUTTON__DigitalInput__ = 0;
const uint VID_INPUT__DOLLAR____AnalogSerialInput__ = 1;
const uint VANTAGE_TX__DOLLAR____AnalogSerialOutput__ = 0;
const uint BUTTON_FB__DigitalOutput__ = 0;
const uint BUTTON_STATE_FB__AnalogSerialOutput__ = 1;
const uint BUTTON_LED_BLINK_FB__AnalogSerialOutput__ = 9;

[SplusStructAttribute(-1, true, false)]
public class SplusNVRAM : SplusStructureBase
{

    public SplusNVRAM( SplusObject __caller__ ) : base( __caller__ ) {}
    
    [SplusStructAttribute(0, false, true)]
            public ushort GSTARTUP = 0;
            [SplusStructAttribute(1, false, true)]
            public ushort GDEFINEDINPUTS = 0;
            [SplusStructAttribute(2, false, true)]
            public ushort IINDEX = 0;
            
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

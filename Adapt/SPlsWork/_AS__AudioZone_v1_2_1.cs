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

namespace UserModule__AS__AUDIOZONE_V1_2_1
{
    public class UserModuleClass__AS__AUDIOZONE_V1_2_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        Crestron.Logos.SplusObjects.DigitalInput ZONE_ON_FB;
        Crestron.Logos.SplusObjects.DigitalInput MUTE_ON_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> D_FB_IN;
        Crestron.Logos.SplusObjects.AnalogInput SOURCE_FB;
        Crestron.Logos.SplusObjects.AnalogInput VOLUME_FB;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> A_FB_IN;
        Crestron.Logos.SplusObjects.DigitalOutput ZONE_ON;
        Crestron.Logos.SplusObjects.DigitalOutput ZONE_OFF;
        Crestron.Logos.SplusObjects.DigitalOutput ZONE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_ON;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_OFF;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalOutput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalOutput VOLUME_DOWN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> D_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput SOURCE;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME;
        Crestron.Logos.SplusObjects.StringOutput FRIENDLY_NAME;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> A_OUT;
        UShortParameter OUTPUT_NUMBER;
        UShortParameter SWITCHER_NUMBER;
        UShortParameter SWITCHER_TYPE;
        StringParameter ZONE_NAME;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_AudioZone MYBRIDGE;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 98;
            MYBRIDGE . ZoneOnFeedbackChange ( (ushort)( ZONE_ON_FB  .Value )) ; 
            __context__.SourceCodeLine = 99;
            MYBRIDGE . MuteOnFeedbackChange ( (ushort)( MUTE_ON_FB  .Value )) ; 
            __context__.SourceCodeLine = 100;
            MYBRIDGE . VolumeFeedbackChange ( (ushort)( VOLUME_FB  .UshortValue )) ; 
            __context__.SourceCodeLine = 101;
            MYBRIDGE . SourceFeedbackChange ( (ushort)( SOURCE_FB  .UshortValue )) ; 
            __context__.SourceCodeLine = 103;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)10; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 105;
                MYBRIDGE . DigitalInputChange ( (ushort)( I ), (ushort)( D_FB_IN[ I ] .Value )) ; 
                __context__.SourceCodeLine = 106;
                MYBRIDGE . AnalogInputChange ( (ushort)( I ), (ushort)( A_FB_IN[ I ] .UshortValue )) ; 
                __context__.SourceCodeLine = 103;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 111;
                FNREFRESHINPUTS (  __context__  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEFRIENDLYNAMECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 112;
                FRIENDLY_NAME  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDIGITALOUTPUT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 114;
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
                
                __context__.SourceCodeLine = 115;
                A_OUT [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEZONEONCONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 117;
                ZONE_ON  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEZONEOFFCONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 118;
                ZONE_OFF  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEZONETOGGLECONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 119;
                ZONE_TOGGLE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEVOLUMEVALUECONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 120;
                VOLUME  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESOURCEVALUECONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 121;
                SOURCE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEVOLUMEUPCONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 122;
                VOLUME_UP  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEVOLUMEDOWNCONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 123;
                VOLUME_DOWN  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMUTEONCONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 125;
                MUTE_ON  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMUTEOFFCONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 126;
                MUTE_OFF  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMUTETOGGLECONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 127;
                MUTE_TOGGLE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 132;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 132;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 133;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 134;
                MYBRIDGE . FriendlyId = (ushort) ( OUTPUT_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 135;
                MYBRIDGE . OutputNumber = (ushort) ( OUTPUT_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 136;
                MYBRIDGE . ParentId = (ushort) ( SWITCHER_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 137;
                MYBRIDGE . ParentTypeNum = (ushort) ( SWITCHER_TYPE  .Value ) ; 
                __context__.SourceCodeLine = 138;
                MYBRIDGE . FriendlyName  =  ( ZONE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 139;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 140;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 141;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 143;
                MYBRIDGE . NumDigitals = (ushort) ( 10 ) ; 
                __context__.SourceCodeLine = 144;
                MYBRIDGE . NumAnalogs = (ushort) ( 10 ) ; 
                __context__.SourceCodeLine = 146;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 148;
                // RegisterEvent( MYBRIDGE , ONFRIENDLYNAMECHANGE , HANDLEFRIENDLYNAMECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnFriendlyNameChange  += HANDLEFRIENDLYNAMECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 150;
                // RegisterEvent( MYBRIDGE , ONDIGITALOUTPUTCHANGE , HANDLEDIGITALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnDigitalOutputChange  += HANDLEDIGITALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 151;
                // RegisterEvent( MYBRIDGE , ONANALOGOUTPUTCHANGE , HANDLEANALOGOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnAnalogOutputChange  += HANDLEANALOGOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 153;
                // RegisterEvent( MYBRIDGE , SETZONEONCONTROLCHANGE , HANDLEZONEONCONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetZoneOnControlChange  += HANDLEZONEONCONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 154;
                // RegisterEvent( MYBRIDGE , SETZONEOFFCONTROLCHANGE , HANDLEZONEOFFCONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetZoneOffControlChange  += HANDLEZONEOFFCONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 155;
                // RegisterEvent( MYBRIDGE , SETZONETOGGLECONTROLCHANGE , HANDLEZONETOGGLECONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetZoneToggleControlChange  += HANDLEZONETOGGLECONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 156;
                // RegisterEvent( MYBRIDGE , SETVOLUMEVALUECONTROLCHANGE , HANDLEVOLUMEVALUECONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetVolumeValueControlChange  += HANDLEVOLUMEVALUECONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 157;
                // RegisterEvent( MYBRIDGE , SETSOURCECONTROLCHANGE , HANDLESOURCEVALUECONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceControlChange  += HANDLESOURCEVALUECONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 158;
                // RegisterEvent( MYBRIDGE , SETVOLUMEUPCONTROLCHANGE , HANDLEVOLUMEUPCONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetVolumeUpControlChange  += HANDLEVOLUMEUPCONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 159;
                // RegisterEvent( MYBRIDGE , SETVOLUMEDOWNCONTROLCHANGE , HANDLEVOLUMEDOWNCONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetVolumeDownControlChange  += HANDLEVOLUMEDOWNCONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 160;
                // RegisterEvent( MYBRIDGE , SETMUTEONCONTROLCHANGE , HANDLEMUTEONCONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMuteOnControlChange  += HANDLEMUTEONCONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 161;
                // RegisterEvent( MYBRIDGE , SETMUTEOFFCONTROLCHANGE , HANDLEMUTEOFFCONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMuteOffControlChange  += HANDLEMUTEOFFCONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 162;
                // RegisterEvent( MYBRIDGE , SETMUTETOGGLECONTROLCHANGE , HANDLEMUTETOGGLECONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMuteToggleControlChange  += HANDLEMUTETOGGLECONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 164;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object ZONE_ON_FB_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 167;
            MYBRIDGE . ZoneOnFeedbackChange ( (ushort)( ZONE_ON_FB  .Value )) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object MUTE_ON_FB_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 168;
        MYBRIDGE . MuteOnFeedbackChange ( (ushort)( MUTE_ON_FB  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_FB_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 169;
        MYBRIDGE . VolumeFeedbackChange ( (ushort)( VOLUME_FB  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_FB_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 170;
        MYBRIDGE . SourceFeedbackChange ( (ushort)( SOURCE_FB  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object D_FB_IN_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 172;
        MYBRIDGE . DigitalInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( D_FB_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object A_FB_IN_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 173;
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
    
    ZONE_ON_FB = new Crestron.Logos.SplusObjects.DigitalInput( ZONE_ON_FB__DigitalInput__, this );
    m_DigitalInputList.Add( ZONE_ON_FB__DigitalInput__, ZONE_ON_FB );
    
    MUTE_ON_FB = new Crestron.Logos.SplusObjects.DigitalInput( MUTE_ON_FB__DigitalInput__, this );
    m_DigitalInputList.Add( MUTE_ON_FB__DigitalInput__, MUTE_ON_FB );
    
    D_FB_IN = new InOutArray<DigitalInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        D_FB_IN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( D_FB_IN__DigitalInput__ + i, D_FB_IN__DigitalInput__, this );
        m_DigitalInputList.Add( D_FB_IN__DigitalInput__ + i, D_FB_IN[i+1] );
    }
    
    ZONE_ON = new Crestron.Logos.SplusObjects.DigitalOutput( ZONE_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( ZONE_ON__DigitalOutput__, ZONE_ON );
    
    ZONE_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( ZONE_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( ZONE_OFF__DigitalOutput__, ZONE_OFF );
    
    ZONE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalOutput( ZONE_TOGGLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ZONE_TOGGLE__DigitalOutput__, ZONE_TOGGLE );
    
    MUTE_ON = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_ON__DigitalOutput__, MUTE_ON );
    
    MUTE_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_OFF__DigitalOutput__, MUTE_OFF );
    
    MUTE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalOutput( MUTE_TOGGLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MUTE_TOGGLE__DigitalOutput__, MUTE_TOGGLE );
    
    VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalOutput( VOLUME_UP__DigitalOutput__, this );
    m_DigitalOutputList.Add( VOLUME_UP__DigitalOutput__, VOLUME_UP );
    
    VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalOutput( VOLUME_DOWN__DigitalOutput__, this );
    m_DigitalOutputList.Add( VOLUME_DOWN__DigitalOutput__, VOLUME_DOWN );
    
    D_OUT = new InOutArray<DigitalOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        D_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( D_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( D_OUT__DigitalOutput__ + i, D_OUT[i+1] );
    }
    
    SOURCE_FB = new Crestron.Logos.SplusObjects.AnalogInput( SOURCE_FB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SOURCE_FB__AnalogSerialInput__, SOURCE_FB );
    
    VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogInput( VOLUME_FB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUME_FB__AnalogSerialInput__, VOLUME_FB );
    
    A_FB_IN = new InOutArray<AnalogInput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        A_FB_IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( A_FB_IN__AnalogSerialInput__ + i, A_FB_IN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( A_FB_IN__AnalogSerialInput__ + i, A_FB_IN[i+1] );
    }
    
    SOURCE = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SOURCE__AnalogSerialOutput__, SOURCE );
    
    VOLUME = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME__AnalogSerialOutput__, VOLUME );
    
    A_OUT = new InOutArray<AnalogOutput>( 10, this );
    for( uint i = 0; i < 10; i++ )
    {
        A_OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( A_OUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( A_OUT__AnalogSerialOutput__ + i, A_OUT[i+1] );
    }
    
    FRIENDLY_NAME = new Crestron.Logos.SplusObjects.StringOutput( FRIENDLY_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( FRIENDLY_NAME__AnalogSerialOutput__, FRIENDLY_NAME );
    
    OUTPUT_NUMBER = new UShortParameter( OUTPUT_NUMBER__Parameter__, this );
    m_ParameterList.Add( OUTPUT_NUMBER__Parameter__, OUTPUT_NUMBER );
    
    SWITCHER_NUMBER = new UShortParameter( SWITCHER_NUMBER__Parameter__, this );
    m_ParameterList.Add( SWITCHER_NUMBER__Parameter__, SWITCHER_NUMBER );
    
    SWITCHER_TYPE = new UShortParameter( SWITCHER_TYPE__Parameter__, this );
    m_ParameterList.Add( SWITCHER_TYPE__Parameter__, SWITCHER_TYPE );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    ZONE_NAME = new StringParameter( ZONE_NAME__Parameter__, this );
    m_ParameterList.Add( ZONE_NAME__Parameter__, ZONE_NAME );
    
    FILE_NAME = new StringParameter( FILE_NAME__Parameter__, this );
    m_ParameterList.Add( FILE_NAME__Parameter__, FILE_NAME );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_OnPush_0, true ) );
    ZONE_ON_FB.OnDigitalChange.Add( new InputChangeHandlerWrapper( ZONE_ON_FB_OnChange_1, false ) );
    MUTE_ON_FB.OnDigitalChange.Add( new InputChangeHandlerWrapper( MUTE_ON_FB_OnChange_2, false ) );
    VOLUME_FB.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUME_FB_OnChange_3, false ) );
    SOURCE_FB.OnAnalogChange.Add( new InputChangeHandlerWrapper( SOURCE_FB_OnChange_4, false ) );
    for( uint i = 0; i < 10; i++ )
        D_FB_IN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( D_FB_IN_OnChange_5, false ) );
        
    for( uint i = 0; i < 10; i++ )
        A_FB_IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( A_FB_IN_OnChange_6, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_AudioZone();
    
    
}

public UserModuleClass__AS__AUDIOZONE_V1_2_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint ZONE_ON_FB__DigitalInput__ = 1;
const uint MUTE_ON_FB__DigitalInput__ = 2;
const uint D_FB_IN__DigitalInput__ = 3;
const uint SOURCE_FB__AnalogSerialInput__ = 0;
const uint VOLUME_FB__AnalogSerialInput__ = 1;
const uint A_FB_IN__AnalogSerialInput__ = 2;
const uint ZONE_ON__DigitalOutput__ = 0;
const uint ZONE_OFF__DigitalOutput__ = 1;
const uint ZONE_TOGGLE__DigitalOutput__ = 2;
const uint MUTE_ON__DigitalOutput__ = 3;
const uint MUTE_OFF__DigitalOutput__ = 4;
const uint MUTE_TOGGLE__DigitalOutput__ = 5;
const uint VOLUME_UP__DigitalOutput__ = 6;
const uint VOLUME_DOWN__DigitalOutput__ = 7;
const uint D_OUT__DigitalOutput__ = 8;
const uint SOURCE__AnalogSerialOutput__ = 0;
const uint VOLUME__AnalogSerialOutput__ = 1;
const uint FRIENDLY_NAME__AnalogSerialOutput__ = 2;
const uint A_OUT__AnalogSerialOutput__ = 3;
const uint OUTPUT_NUMBER__Parameter__ = 10;
const uint SWITCHER_NUMBER__Parameter__ = 11;
const uint SWITCHER_TYPE__Parameter__ = 12;
const uint ZONE_NAME__Parameter__ = 13;
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

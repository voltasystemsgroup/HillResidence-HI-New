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

namespace UserModule__AS__AVRECEIVER_V1_2_0
{
    public class UserModuleClass__AS__AVRECEIVER_V1_2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        Crestron.Logos.SplusObjects.DigitalInput READ;
        Crestron.Logos.SplusObjects.DigitalInput WRITE;
        Crestron.Logos.SplusObjects.DigitalInput POWER_ON_FB;
        Crestron.Logos.SplusObjects.DigitalInput MUTE_ON_FB;
        Crestron.Logos.SplusObjects.DigitalInput USE_LOGIC_FEEDBACK;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> D_FB_IN;
        Crestron.Logos.SplusObjects.AnalogInput INPUT_FB;
        Crestron.Logos.SplusObjects.AnalogInput VOLUME_FB;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> A_FB_IN;
        Crestron.Logos.SplusObjects.DigitalOutput BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_ON;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_OFF;
        Crestron.Logos.SplusObjects.DigitalOutput POWER_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_ON;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_OFF;
        Crestron.Logos.SplusObjects.DigitalOutput MUTE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalOutput VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalOutput VOLUME_DOWN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> D_OUT;
        Crestron.Logos.SplusObjects.AnalogOutput INPUT;
        Crestron.Logos.SplusObjects.AnalogOutput VOLUME;
        Crestron.Logos.SplusObjects.StringOutput COMMAND_TX;
        Crestron.Logos.SplusObjects.StringOutput PACKET_TX;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> A_OUT;
        UShortParameter AV_RECEIVER_NUMBER;
        StringParameter AV_RECEIVER_NAME;
        UShortParameter NUMBER_OF_INPUTS;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_AvReceiver MYBRIDGE;
        private void FNREFRESHINPUTS (  SplusExecutionContext __context__ ) 
            { 
            ushort I = 0;
            
            
            __context__.SourceCodeLine = 96;
            MYBRIDGE . ZoneOnFeedbackChange ( (ushort)( POWER_ON_FB  .Value )) ; 
            __context__.SourceCodeLine = 97;
            MYBRIDGE . MuteOnFeedbackChange ( (ushort)( MUTE_ON_FB  .Value )) ; 
            __context__.SourceCodeLine = 98;
            MYBRIDGE . VolumeFeedbackChange ( (ushort)( VOLUME_FB  .UshortValue )) ; 
            __context__.SourceCodeLine = 99;
            MYBRIDGE . SourceFeedbackChange ( (ushort)( INPUT_FB  .UshortValue )) ; 
            __context__.SourceCodeLine = 101;
            ushort __FN_FORSTART_VAL__1 = (ushort) ( 1 ) ;
            ushort __FN_FOREND_VAL__1 = (ushort)32; 
            int __FN_FORSTEP_VAL__1 = (int)1; 
            for ( I  = __FN_FORSTART_VAL__1; (__FN_FORSTEP_VAL__1 > 0)  ? ( (I  >= __FN_FORSTART_VAL__1) && (I  <= __FN_FOREND_VAL__1) ) : ( (I  <= __FN_FORSTART_VAL__1) && (I  >= __FN_FOREND_VAL__1) ) ; I  += (ushort)__FN_FORSTEP_VAL__1) 
                { 
                __context__.SourceCodeLine = 103;
                MYBRIDGE . DigitalInputChange ( (ushort)( I ), (ushort)( D_FB_IN[ I ] .Value )) ; 
                __context__.SourceCodeLine = 104;
                MYBRIDGE . AnalogInputChange ( (ushort)( I ), (ushort)( A_FB_IN[ I ] .UshortValue )) ; 
                __context__.SourceCodeLine = 101;
                } 
            
            
            }
            
        public void HANDLEREFRESHCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 110;
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
                
                __context__.SourceCodeLine = 112;
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
            
        public void HANDLEPOWERONCONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 117;
                POWER_ON  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEPOWEROFFCONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 118;
                POWER_OFF  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEPOWERTOGGLECONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 119;
                POWER_TOGGLE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
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
            
        public void HANDLEINPUTVALUECONTROL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 121;
                INPUT  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
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
                
                __context__.SourceCodeLine = 124;
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
                
                __context__.SourceCodeLine = 125;
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
                
                __context__.SourceCodeLine = 126;
                MUTE_TOGGLE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECOMMANDSTRINGCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 128;
                COMMAND_TX  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEPACKETTXCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 129;
                PACKET_TX  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 134;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 134;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 135;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 136;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 137;
                MYBRIDGE . FriendlyId = (ushort) ( AV_RECEIVER_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 138;
                MYBRIDGE . NumInputs = (ushort) ( NUMBER_OF_INPUTS  .Value ) ; 
                __context__.SourceCodeLine = 139;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 140;
                MYBRIDGE . FriendlyName  =  ( AV_RECEIVER_NAME + Functions.ItoA (  (int) ( AV_RECEIVER_NUMBER  .Value ) )  )  .ToString() ; 
                __context__.SourceCodeLine = 141;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 143;
                MYBRIDGE . NumDigitals = (ushort) ( 32 ) ; 
                __context__.SourceCodeLine = 144;
                MYBRIDGE . NumAnalogs = (ushort) ( 32 ) ; 
                __context__.SourceCodeLine = 146;
                // RegisterEvent( MYBRIDGE , ONREFRESHINPUTSEVENT , HANDLEREFRESHCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnRefreshInputsEvent  += HANDLEREFRESHCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 148;
                // RegisterEvent( MYBRIDGE , ONBUSYEVENT , HANDLEBUSYEVENT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnBusyEvent  += HANDLEBUSYEVENT; } finally { g_criticalSection.Leave(); }
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
                // RegisterEvent( MYBRIDGE , SETZONEONCONTROLCHANGE , HANDLEPOWERONCONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetZoneOnControlChange  += HANDLEPOWERONCONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 154;
                // RegisterEvent( MYBRIDGE , SETZONEOFFCONTROLCHANGE , HANDLEPOWEROFFCONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetZoneOffControlChange  += HANDLEPOWEROFFCONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 155;
                // RegisterEvent( MYBRIDGE , SETZONETOGGLECONTROLCHANGE , HANDLEPOWERTOGGLECONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetZoneToggleControlChange  += HANDLEPOWERTOGGLECONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 156;
                // RegisterEvent( MYBRIDGE , SETVOLUMEVALUECONTROLCHANGE , HANDLEVOLUMEVALUECONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetVolumeValueControlChange  += HANDLEVOLUMEVALUECONTROL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 157;
                // RegisterEvent( MYBRIDGE , SETSOURCECONTROLCHANGE , HANDLEINPUTVALUECONTROL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceControlChange  += HANDLEINPUTVALUECONTROL; } finally { g_criticalSection.Leave(); }
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
                // RegisterEvent( MYBRIDGE , SETCOMMANDSTRINGCHANGE , HANDLECOMMANDSTRINGCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetCommandStringChange  += HANDLECOMMANDSTRINGCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 165;
                // RegisterEvent( MYBRIDGE , SETSENDPACKETTXCHANGE , HANDLEPACKETTXCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSendPacketTxChange  += HANDLEPACKETTXCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 167;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object READ_OnChange_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 169;
            MYBRIDGE . ReadFileData ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object WRITE_OnChange_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 170;
        MYBRIDGE . WriteFileData ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object POWER_ON_FB_OnChange_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 172;
        MYBRIDGE . ZoneOnFeedbackChange ( (ushort)( POWER_ON_FB  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTE_ON_FB_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 173;
        MYBRIDGE . MuteOnFeedbackChange ( (ushort)( MUTE_ON_FB  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object VOLUME_FB_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 174;
        MYBRIDGE . VolumeFeedbackChange ( (ushort)( VOLUME_FB  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INPUT_FB_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 175;
        MYBRIDGE . SourceFeedbackChange ( (ushort)( INPUT_FB  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object D_FB_IN_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 177;
        MYBRIDGE . DigitalInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( D_FB_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object A_FB_IN_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 178;
        MYBRIDGE . AnalogInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( A_FB_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object USE_LOGIC_FEEDBACK_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 180;
        MYBRIDGE . UseLogicFeedback = (ushort) ( USE_LOGIC_FEEDBACK  .Value ) ; 
        
        
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
    
    READ = new Crestron.Logos.SplusObjects.DigitalInput( READ__DigitalInput__, this );
    m_DigitalInputList.Add( READ__DigitalInput__, READ );
    
    WRITE = new Crestron.Logos.SplusObjects.DigitalInput( WRITE__DigitalInput__, this );
    m_DigitalInputList.Add( WRITE__DigitalInput__, WRITE );
    
    POWER_ON_FB = new Crestron.Logos.SplusObjects.DigitalInput( POWER_ON_FB__DigitalInput__, this );
    m_DigitalInputList.Add( POWER_ON_FB__DigitalInput__, POWER_ON_FB );
    
    MUTE_ON_FB = new Crestron.Logos.SplusObjects.DigitalInput( MUTE_ON_FB__DigitalInput__, this );
    m_DigitalInputList.Add( MUTE_ON_FB__DigitalInput__, MUTE_ON_FB );
    
    USE_LOGIC_FEEDBACK = new Crestron.Logos.SplusObjects.DigitalInput( USE_LOGIC_FEEDBACK__DigitalInput__, this );
    m_DigitalInputList.Add( USE_LOGIC_FEEDBACK__DigitalInput__, USE_LOGIC_FEEDBACK );
    
    D_FB_IN = new InOutArray<DigitalInput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        D_FB_IN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( D_FB_IN__DigitalInput__ + i, D_FB_IN__DigitalInput__, this );
        m_DigitalInputList.Add( D_FB_IN__DigitalInput__ + i, D_FB_IN[i+1] );
    }
    
    BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( BUSY__DigitalOutput__, BUSY );
    
    POWER_ON = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_ON__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_ON__DigitalOutput__, POWER_ON );
    
    POWER_OFF = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_OFF__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_OFF__DigitalOutput__, POWER_OFF );
    
    POWER_TOGGLE = new Crestron.Logos.SplusObjects.DigitalOutput( POWER_TOGGLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( POWER_TOGGLE__DigitalOutput__, POWER_TOGGLE );
    
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
    
    D_OUT = new InOutArray<DigitalOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        D_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( D_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( D_OUT__DigitalOutput__ + i, D_OUT[i+1] );
    }
    
    INPUT_FB = new Crestron.Logos.SplusObjects.AnalogInput( INPUT_FB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( INPUT_FB__AnalogSerialInput__, INPUT_FB );
    
    VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogInput( VOLUME_FB__AnalogSerialInput__, this );
    m_AnalogInputList.Add( VOLUME_FB__AnalogSerialInput__, VOLUME_FB );
    
    A_FB_IN = new InOutArray<AnalogInput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        A_FB_IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( A_FB_IN__AnalogSerialInput__ + i, A_FB_IN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( A_FB_IN__AnalogSerialInput__ + i, A_FB_IN[i+1] );
    }
    
    INPUT = new Crestron.Logos.SplusObjects.AnalogOutput( INPUT__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( INPUT__AnalogSerialOutput__, INPUT );
    
    VOLUME = new Crestron.Logos.SplusObjects.AnalogOutput( VOLUME__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( VOLUME__AnalogSerialOutput__, VOLUME );
    
    A_OUT = new InOutArray<AnalogOutput>( 32, this );
    for( uint i = 0; i < 32; i++ )
    {
        A_OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( A_OUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( A_OUT__AnalogSerialOutput__ + i, A_OUT[i+1] );
    }
    
    COMMAND_TX = new Crestron.Logos.SplusObjects.StringOutput( COMMAND_TX__AnalogSerialOutput__, this );
    m_StringOutputList.Add( COMMAND_TX__AnalogSerialOutput__, COMMAND_TX );
    
    PACKET_TX = new Crestron.Logos.SplusObjects.StringOutput( PACKET_TX__AnalogSerialOutput__, this );
    m_StringOutputList.Add( PACKET_TX__AnalogSerialOutput__, PACKET_TX );
    
    AV_RECEIVER_NUMBER = new UShortParameter( AV_RECEIVER_NUMBER__Parameter__, this );
    m_ParameterList.Add( AV_RECEIVER_NUMBER__Parameter__, AV_RECEIVER_NUMBER );
    
    NUMBER_OF_INPUTS = new UShortParameter( NUMBER_OF_INPUTS__Parameter__, this );
    m_ParameterList.Add( NUMBER_OF_INPUTS__Parameter__, NUMBER_OF_INPUTS );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    AV_RECEIVER_NAME = new StringParameter( AV_RECEIVER_NAME__Parameter__, this );
    m_ParameterList.Add( AV_RECEIVER_NAME__Parameter__, AV_RECEIVER_NAME );
    
    FILE_NAME = new StringParameter( FILE_NAME__Parameter__, this );
    m_ParameterList.Add( FILE_NAME__Parameter__, FILE_NAME );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_OnPush_0, true ) );
    READ.OnDigitalChange.Add( new InputChangeHandlerWrapper( READ_OnChange_1, true ) );
    WRITE.OnDigitalChange.Add( new InputChangeHandlerWrapper( WRITE_OnChange_2, true ) );
    POWER_ON_FB.OnDigitalChange.Add( new InputChangeHandlerWrapper( POWER_ON_FB_OnChange_3, false ) );
    MUTE_ON_FB.OnDigitalChange.Add( new InputChangeHandlerWrapper( MUTE_ON_FB_OnChange_4, false ) );
    VOLUME_FB.OnAnalogChange.Add( new InputChangeHandlerWrapper( VOLUME_FB_OnChange_5, false ) );
    INPUT_FB.OnAnalogChange.Add( new InputChangeHandlerWrapper( INPUT_FB_OnChange_6, false ) );
    for( uint i = 0; i < 32; i++ )
        D_FB_IN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( D_FB_IN_OnChange_7, false ) );
        
    for( uint i = 0; i < 32; i++ )
        A_FB_IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( A_FB_IN_OnChange_8, false ) );
        
    USE_LOGIC_FEEDBACK.OnDigitalChange.Add( new InputChangeHandlerWrapper( USE_LOGIC_FEEDBACK_OnChange_9, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_AvReceiver();
    
    
}

public UserModuleClass__AS__AVRECEIVER_V1_2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint READ__DigitalInput__ = 1;
const uint WRITE__DigitalInput__ = 2;
const uint POWER_ON_FB__DigitalInput__ = 3;
const uint MUTE_ON_FB__DigitalInput__ = 4;
const uint USE_LOGIC_FEEDBACK__DigitalInput__ = 5;
const uint D_FB_IN__DigitalInput__ = 6;
const uint INPUT_FB__AnalogSerialInput__ = 0;
const uint VOLUME_FB__AnalogSerialInput__ = 1;
const uint A_FB_IN__AnalogSerialInput__ = 2;
const uint BUSY__DigitalOutput__ = 0;
const uint POWER_ON__DigitalOutput__ = 1;
const uint POWER_OFF__DigitalOutput__ = 2;
const uint POWER_TOGGLE__DigitalOutput__ = 3;
const uint MUTE_ON__DigitalOutput__ = 4;
const uint MUTE_OFF__DigitalOutput__ = 5;
const uint MUTE_TOGGLE__DigitalOutput__ = 6;
const uint VOLUME_UP__DigitalOutput__ = 7;
const uint VOLUME_DOWN__DigitalOutput__ = 8;
const uint D_OUT__DigitalOutput__ = 9;
const uint INPUT__AnalogSerialOutput__ = 0;
const uint VOLUME__AnalogSerialOutput__ = 1;
const uint COMMAND_TX__AnalogSerialOutput__ = 2;
const uint PACKET_TX__AnalogSerialOutput__ = 3;
const uint A_OUT__AnalogSerialOutput__ = 4;
const uint AV_RECEIVER_NUMBER__Parameter__ = 10;
const uint AV_RECEIVER_NAME__Parameter__ = 11;
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

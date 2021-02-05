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

namespace UserModule__AS__HANDHELD_V1_2_0
{
    public class UserModuleClass__AS__HANDHELD_V1_2_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        Crestron.Logos.SplusObjects.DigitalInput READ;
        Crestron.Logos.SplusObjects.DigitalInput WRITE;
        Crestron.Logos.SplusObjects.DigitalInput ACTIVITY_DETECTED;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_ON;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_OFF;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_MUTE_ON;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_MUTE_OFF;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_MUTE_TOGGLE;
        Crestron.Logos.SplusObjects.AnalogInput ROOM_AV_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ROOM_AV_DIRECT_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput DIRECT_ROOM_SELECT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> CUSTOM_SOURCE_BUTTON;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> HARDKEY;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> LIST_CONTROLS;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> LIGHTINGQUICKCONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> CLIMATEQUICKCONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DOORLOCKQUICKCONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> WINDOWSQUICKCONTROL;
        Crestron.Logos.SplusObjects.DigitalOutput BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_AV_ON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_AV_OFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_AV_MUTE_ON_FB;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_AV_VOLUME_FB;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_AV_DIRECT_SOURCE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput CONNECTED_ROOM_NUM_FB;
        UShortParameter HANDHELD_ID;
        StringParameter HANDHELD_NAME;
        UShortParameter INTERFACE_TYPE;
        UShortParameter NUM_SOURCE_BUTTONS;
        UShortParameter DEFAULT_ROOM;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_Handheld MYBRIDGE;
        public void HANDLEROOMZONEONFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 90;
                ROOM_AV_ON_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMZONEOFFFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 91;
                ROOM_AV_OFF_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMMUTEONFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 92;
                ROOM_AV_MUTE_ON_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMVOLUMEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 93;
                ROOM_AV_VOLUME_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMSOURCEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 94;
                ROOM_AV_DIRECT_SOURCE_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMNUMFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 95;
                CONNECTED_ROOM_NUM_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 100;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 100;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 101;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 102;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 103;
                MYBRIDGE . FriendlyId = (ushort) ( HANDHELD_ID  .Value ) ; 
                __context__.SourceCodeLine = 104;
                MYBRIDGE . FriendlyName  =  ( HANDHELD_NAME + Functions.ItoA (  (int) ( HANDHELD_ID  .Value ) )  )  .ToString() ; 
                __context__.SourceCodeLine = 105;
                MYBRIDGE . InterfaceType = (ushort) ( INTERFACE_TYPE  .Value ) ; 
                __context__.SourceCodeLine = 106;
                MYBRIDGE . NumSourceButtons = (ushort) ( NUM_SOURCE_BUTTONS  .Value ) ; 
                __context__.SourceCodeLine = 107;
                MYBRIDGE . DefaultRoomNum = (ushort) ( DEFAULT_ROOM  .Value ) ; 
                __context__.SourceCodeLine = 108;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 109;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 110;
                MYBRIDGE . MaxNumRooms = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 111;
                MYBRIDGE . MaxNumSources = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 113;
                // RegisterEvent( MYBRIDGE , SETROOMZONEONFEEDBACKCHANGE , HANDLEROOMZONEONFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomZoneOnFeedbackChange  += HANDLEROOMZONEONFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 114;
                // RegisterEvent( MYBRIDGE , SETROOMZONEOFFFEEDBACKCHANGE , HANDLEROOMZONEOFFFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomZoneOffFeedbackChange  += HANDLEROOMZONEOFFFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 115;
                // RegisterEvent( MYBRIDGE , SETROOMMUTEONFEEDBACKCHANGE , HANDLEROOMMUTEONFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomMuteOnFeedbackChange  += HANDLEROOMMUTEONFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 116;
                // RegisterEvent( MYBRIDGE , SETROOMVOLUMEFEEDBACKCHANGE , HANDLEROOMVOLUMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomVolumeFeedbackChange  += HANDLEROOMVOLUMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 117;
                // RegisterEvent( MYBRIDGE , SETROOMSOURCEFEEDBACKCHANGE , HANDLEROOMSOURCEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomSourceFeedbackChange  += HANDLEROOMSOURCEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 118;
                // RegisterEvent( MYBRIDGE , SETCONNECTEDROOMNUMFEEDBACKCHANGE , HANDLEROOMNUMFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetConnectedRoomNumFeedbackChange  += HANDLEROOMNUMFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 120;
                MYBRIDGE . RegisterWithCore ( ) ; 
                
                
            }
            catch(Exception e) { ObjectCatchHandler(e); }
            finally { ObjectFinallyHandler( __SignalEventArg__ ); }
            return this;
            
        }
        
    object READ_OnPush_1 ( Object __EventInfo__ )
    
        { 
        Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
        try
        {
            SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
            
            __context__.SourceCodeLine = 123;
            MYBRIDGE . ReadFileData ( ) ; 
            
            
        }
        catch(Exception e) { ObjectCatchHandler(e); }
        finally { ObjectFinallyHandler( __SignalEventArg__ ); }
        return this;
        
    }
    
object WRITE_OnPush_2 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 124;
        MYBRIDGE . WriteFileData ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ACTIVITY_DETECTED_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 126;
        MYBRIDGE . ActivityDetected ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CUSTOM_SOURCE_BUTTON_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 128;
        MYBRIDGE . CustomSourceButtonPush ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HARDKEY_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 130;
        MYBRIDGE . SourceQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( HARDKEY[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIST_CONTROLS_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 131;
        MYBRIDGE . SoftkeyChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( LIST_CONTROLS[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_ON_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 133;
        MYBRIDGE . ZoneOnControlChange ( (ushort)( ROOM_AV_ON  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_OFF_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 134;
        MYBRIDGE . ZoneOffControlChange ( (ushort)( ROOM_AV_OFF  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_TOGGLE_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 135;
        MYBRIDGE . ZoneToggleControlChange ( (ushort)( ROOM_AV_TOGGLE  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_VOLUME_UP_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 136;
        MYBRIDGE . VolumeUpControlChange ( (ushort)( ROOM_AV_VOLUME_UP  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_VOLUME_DOWN_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 137;
        MYBRIDGE . VolumeDownControlChange ( (ushort)( ROOM_AV_VOLUME_DOWN  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_MUTE_ON_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 138;
        MYBRIDGE . MuteOnControlChange ( (ushort)( ROOM_AV_MUTE_ON  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_MUTE_OFF_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 139;
        MYBRIDGE . MuteOffControlChange ( (ushort)( ROOM_AV_MUTE_OFF  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_MUTE_TOGGLE_OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 140;
        MYBRIDGE . MuteToggleControlChange ( (ushort)( ROOM_AV_MUTE_TOGGLE  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_VOLUME_OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 142;
        MYBRIDGE . VolumeValueControlChange ( (ushort)( ROOM_AV_VOLUME  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_DIRECT_SOURCE_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 143;
        MYBRIDGE . SourceDirectChange ( (ushort)( ROOM_AV_DIRECT_SOURCE  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECT_ROOM_SELECT_OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 145;
        MYBRIDGE . ConnectToRoomDirect ( (ushort)( DIRECT_ROOM_SELECT  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTINGQUICKCONTROL_OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 147;
        MYBRIDGE . LightingQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( LIGHTINGQUICKCONTROL[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIMATEQUICKCONTROL_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 148;
        MYBRIDGE . ClimateQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( CLIMATEQUICKCONTROL[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOORLOCKQUICKCONTROL_OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 149;
        MYBRIDGE . DoorlockQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( DOORLOCKQUICKCONTROL[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WINDOWSQUICKCONTROL_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 150;
        MYBRIDGE . WindowsQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( WINDOWSQUICKCONTROL[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
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
    
    ACTIVITY_DETECTED = new Crestron.Logos.SplusObjects.DigitalInput( ACTIVITY_DETECTED__DigitalInput__, this );
    m_DigitalInputList.Add( ACTIVITY_DETECTED__DigitalInput__, ACTIVITY_DETECTED );
    
    ROOM_AV_ON = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_AV_ON__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_AV_ON__DigitalInput__, ROOM_AV_ON );
    
    ROOM_AV_OFF = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_AV_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_AV_OFF__DigitalInput__, ROOM_AV_OFF );
    
    ROOM_AV_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_AV_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_AV_TOGGLE__DigitalInput__, ROOM_AV_TOGGLE );
    
    ROOM_AV_VOLUME_UP = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_AV_VOLUME_UP__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_AV_VOLUME_UP__DigitalInput__, ROOM_AV_VOLUME_UP );
    
    ROOM_AV_VOLUME_DOWN = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_AV_VOLUME_DOWN__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_AV_VOLUME_DOWN__DigitalInput__, ROOM_AV_VOLUME_DOWN );
    
    ROOM_AV_MUTE_ON = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_AV_MUTE_ON__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_AV_MUTE_ON__DigitalInput__, ROOM_AV_MUTE_ON );
    
    ROOM_AV_MUTE_OFF = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_AV_MUTE_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_AV_MUTE_OFF__DigitalInput__, ROOM_AV_MUTE_OFF );
    
    ROOM_AV_MUTE_TOGGLE = new Crestron.Logos.SplusObjects.DigitalInput( ROOM_AV_MUTE_TOGGLE__DigitalInput__, this );
    m_DigitalInputList.Add( ROOM_AV_MUTE_TOGGLE__DigitalInput__, ROOM_AV_MUTE_TOGGLE );
    
    CUSTOM_SOURCE_BUTTON = new InOutArray<DigitalInput>( 36, this );
    for( uint i = 0; i < 36; i++ )
    {
        CUSTOM_SOURCE_BUTTON[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( CUSTOM_SOURCE_BUTTON__DigitalInput__ + i, CUSTOM_SOURCE_BUTTON__DigitalInput__, this );
        m_DigitalInputList.Add( CUSTOM_SOURCE_BUTTON__DigitalInput__ + i, CUSTOM_SOURCE_BUTTON[i+1] );
    }
    
    HARDKEY = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        HARDKEY[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( HARDKEY__DigitalInput__ + i, HARDKEY__DigitalInput__, this );
        m_DigitalInputList.Add( HARDKEY__DigitalInput__ + i, HARDKEY[i+1] );
    }
    
    LIST_CONTROLS = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        LIST_CONTROLS[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( LIST_CONTROLS__DigitalInput__ + i, LIST_CONTROLS__DigitalInput__, this );
        m_DigitalInputList.Add( LIST_CONTROLS__DigitalInput__ + i, LIST_CONTROLS[i+1] );
    }
    
    LIGHTINGQUICKCONTROL = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        LIGHTINGQUICKCONTROL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTINGQUICKCONTROL__DigitalInput__ + i, LIGHTINGQUICKCONTROL__DigitalInput__, this );
        m_DigitalInputList.Add( LIGHTINGQUICKCONTROL__DigitalInput__ + i, LIGHTINGQUICKCONTROL[i+1] );
    }
    
    CLIMATEQUICKCONTROL = new InOutArray<DigitalInput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        CLIMATEQUICKCONTROL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( CLIMATEQUICKCONTROL__DigitalInput__ + i, CLIMATEQUICKCONTROL__DigitalInput__, this );
        m_DigitalInputList.Add( CLIMATEQUICKCONTROL__DigitalInput__ + i, CLIMATEQUICKCONTROL[i+1] );
    }
    
    DOORLOCKQUICKCONTROL = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        DOORLOCKQUICKCONTROL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( DOORLOCKQUICKCONTROL__DigitalInput__ + i, DOORLOCKQUICKCONTROL__DigitalInput__, this );
        m_DigitalInputList.Add( DOORLOCKQUICKCONTROL__DigitalInput__ + i, DOORLOCKQUICKCONTROL[i+1] );
    }
    
    WINDOWSQUICKCONTROL = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        WINDOWSQUICKCONTROL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( WINDOWSQUICKCONTROL__DigitalInput__ + i, WINDOWSQUICKCONTROL__DigitalInput__, this );
        m_DigitalInputList.Add( WINDOWSQUICKCONTROL__DigitalInput__ + i, WINDOWSQUICKCONTROL[i+1] );
    }
    
    BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( BUSY__DigitalOutput__, BUSY );
    
    ROOM_AV_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_AV_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_AV_ON_FB__DigitalOutput__, ROOM_AV_ON_FB );
    
    ROOM_AV_OFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_AV_OFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_AV_OFF_FB__DigitalOutput__, ROOM_AV_OFF_FB );
    
    ROOM_AV_MUTE_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_AV_MUTE_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_AV_MUTE_ON_FB__DigitalOutput__, ROOM_AV_MUTE_ON_FB );
    
    ROOM_AV_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ROOM_AV_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOM_AV_VOLUME__AnalogSerialInput__, ROOM_AV_VOLUME );
    
    ROOM_AV_DIRECT_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ROOM_AV_DIRECT_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOM_AV_DIRECT_SOURCE__AnalogSerialInput__, ROOM_AV_DIRECT_SOURCE );
    
    DIRECT_ROOM_SELECT = new Crestron.Logos.SplusObjects.AnalogInput( DIRECT_ROOM_SELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DIRECT_ROOM_SELECT__AnalogSerialInput__, DIRECT_ROOM_SELECT );
    
    ROOM_AV_VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_AV_VOLUME_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_AV_VOLUME_FB__AnalogSerialOutput__, ROOM_AV_VOLUME_FB );
    
    ROOM_AV_DIRECT_SOURCE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_AV_DIRECT_SOURCE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_AV_DIRECT_SOURCE_FB__AnalogSerialOutput__, ROOM_AV_DIRECT_SOURCE_FB );
    
    CONNECTED_ROOM_NUM_FB = new Crestron.Logos.SplusObjects.AnalogOutput( CONNECTED_ROOM_NUM_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONNECTED_ROOM_NUM_FB__AnalogSerialOutput__, CONNECTED_ROOM_NUM_FB );
    
    HANDHELD_ID = new UShortParameter( HANDHELD_ID__Parameter__, this );
    m_ParameterList.Add( HANDHELD_ID__Parameter__, HANDHELD_ID );
    
    INTERFACE_TYPE = new UShortParameter( INTERFACE_TYPE__Parameter__, this );
    m_ParameterList.Add( INTERFACE_TYPE__Parameter__, INTERFACE_TYPE );
    
    NUM_SOURCE_BUTTONS = new UShortParameter( NUM_SOURCE_BUTTONS__Parameter__, this );
    m_ParameterList.Add( NUM_SOURCE_BUTTONS__Parameter__, NUM_SOURCE_BUTTONS );
    
    DEFAULT_ROOM = new UShortParameter( DEFAULT_ROOM__Parameter__, this );
    m_ParameterList.Add( DEFAULT_ROOM__Parameter__, DEFAULT_ROOM );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    HANDHELD_NAME = new StringParameter( HANDHELD_NAME__Parameter__, this );
    m_ParameterList.Add( HANDHELD_NAME__Parameter__, HANDHELD_NAME );
    
    FILE_NAME = new StringParameter( FILE_NAME__Parameter__, this );
    m_ParameterList.Add( FILE_NAME__Parameter__, FILE_NAME );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_OnPush_0, true ) );
    READ.OnDigitalPush.Add( new InputChangeHandlerWrapper( READ_OnPush_1, true ) );
    WRITE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WRITE_OnPush_2, true ) );
    ACTIVITY_DETECTED.OnDigitalPush.Add( new InputChangeHandlerWrapper( ACTIVITY_DETECTED_OnPush_3, false ) );
    for( uint i = 0; i < 36; i++ )
        CUSTOM_SOURCE_BUTTON[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( CUSTOM_SOURCE_BUTTON_OnPush_4, false ) );
        
    for( uint i = 0; i < 50; i++ )
        HARDKEY[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( HARDKEY_OnChange_5, false ) );
        
    for( uint i = 0; i < 50; i++ )
        LIST_CONTROLS[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( LIST_CONTROLS_OnChange_6, false ) );
        
    ROOM_AV_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_ON_OnChange_7, false ) );
    ROOM_AV_OFF.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_OFF_OnChange_8, false ) );
    ROOM_AV_TOGGLE.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_TOGGLE_OnChange_9, false ) );
    ROOM_AV_VOLUME_UP.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_VOLUME_UP_OnChange_10, false ) );
    ROOM_AV_VOLUME_DOWN.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_VOLUME_DOWN_OnChange_11, false ) );
    ROOM_AV_MUTE_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_MUTE_ON_OnChange_12, false ) );
    ROOM_AV_MUTE_OFF.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_MUTE_OFF_OnChange_13, false ) );
    ROOM_AV_MUTE_TOGGLE.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_MUTE_TOGGLE_OnChange_14, false ) );
    ROOM_AV_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOM_AV_VOLUME_OnChange_15, false ) );
    ROOM_AV_DIRECT_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOM_AV_DIRECT_SOURCE_OnChange_16, false ) );
    DIRECT_ROOM_SELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( DIRECT_ROOM_SELECT_OnChange_17, false ) );
    for( uint i = 0; i < 12; i++ )
        LIGHTINGQUICKCONTROL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( LIGHTINGQUICKCONTROL_OnChange_18, false ) );
        
    for( uint i = 0; i < 6; i++ )
        CLIMATEQUICKCONTROL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( CLIMATEQUICKCONTROL_OnChange_19, false ) );
        
    for( uint i = 0; i < 2; i++ )
        DOORLOCKQUICKCONTROL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( DOORLOCKQUICKCONTROL_OnChange_20, false ) );
        
    for( uint i = 0; i < 12; i++ )
        WINDOWSQUICKCONTROL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( WINDOWSQUICKCONTROL_OnChange_21, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_Handheld();
    
    
}

public UserModuleClass__AS__HANDHELD_V1_2_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint READ__DigitalInput__ = 1;
const uint WRITE__DigitalInput__ = 2;
const uint ACTIVITY_DETECTED__DigitalInput__ = 3;
const uint ROOM_AV_ON__DigitalInput__ = 4;
const uint ROOM_AV_OFF__DigitalInput__ = 5;
const uint ROOM_AV_TOGGLE__DigitalInput__ = 6;
const uint ROOM_AV_VOLUME_UP__DigitalInput__ = 7;
const uint ROOM_AV_VOLUME_DOWN__DigitalInput__ = 8;
const uint ROOM_AV_MUTE_ON__DigitalInput__ = 9;
const uint ROOM_AV_MUTE_OFF__DigitalInput__ = 10;
const uint ROOM_AV_MUTE_TOGGLE__DigitalInput__ = 11;
const uint ROOM_AV_VOLUME__AnalogSerialInput__ = 0;
const uint ROOM_AV_DIRECT_SOURCE__AnalogSerialInput__ = 1;
const uint DIRECT_ROOM_SELECT__AnalogSerialInput__ = 2;
const uint CUSTOM_SOURCE_BUTTON__DigitalInput__ = 12;
const uint HARDKEY__DigitalInput__ = 48;
const uint LIST_CONTROLS__DigitalInput__ = 98;
const uint LIGHTINGQUICKCONTROL__DigitalInput__ = 148;
const uint CLIMATEQUICKCONTROL__DigitalInput__ = 160;
const uint DOORLOCKQUICKCONTROL__DigitalInput__ = 166;
const uint WINDOWSQUICKCONTROL__DigitalInput__ = 168;
const uint BUSY__DigitalOutput__ = 0;
const uint ROOM_AV_ON_FB__DigitalOutput__ = 1;
const uint ROOM_AV_OFF_FB__DigitalOutput__ = 2;
const uint ROOM_AV_MUTE_ON_FB__DigitalOutput__ = 3;
const uint ROOM_AV_VOLUME_FB__AnalogSerialOutput__ = 0;
const uint ROOM_AV_DIRECT_SOURCE_FB__AnalogSerialOutput__ = 1;
const uint CONNECTED_ROOM_NUM_FB__AnalogSerialOutput__ = 2;
const uint HANDHELD_ID__Parameter__ = 10;
const uint HANDHELD_NAME__Parameter__ = 11;
const uint INTERFACE_TYPE__Parameter__ = 12;
const uint NUM_SOURCE_BUTTONS__Parameter__ = 13;
const uint DEFAULT_ROOM__Parameter__ = 14;
const uint ACCESS_LEVEL__Parameter__ = 15;
const uint FILE_NAME__Parameter__ = 16;
const uint READ_AT_BOOTUP__Parameter__ = 17;

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

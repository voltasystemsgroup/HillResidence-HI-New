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

namespace UserModule__AS__ROOM_V1_1_1
{
    public class UserModuleClass__AS__ROOM_V1_1_1 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        Crestron.Logos.SplusObjects.DigitalInput READ;
        Crestron.Logos.SplusObjects.DigitalInput WRITE;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_ON;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_OFF;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_MUTE_ON;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_MUTE_OFF;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_MUTE_TOGGLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> QUICK_LIGHTING_BTN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> QUICK_CLIMATE_BTN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> QUICK_DOORLOCKS_BTN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> QUICK_WINDOWS_BTN;
        Crestron.Logos.SplusObjects.AnalogInput ROOM_AV_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ROOM_AV_SOURCE;
        Crestron.Logos.SplusObjects.DigitalOutput BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_AV_ON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_AV_OFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_AV_MUTE_ON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput HASAUDIO;
        Crestron.Logos.SplusObjects.DigitalOutput HASDISPLAY;
        Crestron.Logos.SplusObjects.DigitalOutput HASLIGHTING;
        Crestron.Logos.SplusObjects.DigitalOutput HASCLIMATE;
        Crestron.Logos.SplusObjects.DigitalOutput HASDOORLOCKS;
        Crestron.Logos.SplusObjects.DigitalOutput HASWINDOWS;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICK_LIGHTING_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICK_CLIMATE_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICK_DOORLOCKS_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICK_WINDOWS_FB;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_AV_VOLUME_FB;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_AV_SOURCE_FB;
        Crestron.Logos.SplusObjects.StringOutput ROOMNAME;
        Crestron.Logos.SplusObjects.StringOutput ROOM_AV_SOURCE_NAME;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> QUICK_LIGHTING_TEXT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> QUICK_CLIMATE_TEXT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> QUICK_DOORLOCKS_TEXT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> QUICK_WINDOWS_TEXT;
        UShortParameter ROOM_NUMBER;
        StringParameter ROOM_NAME;
        UShortParameter DEFAULT_AUDIO_SWITCHER_TYPE;
        UShortParameter DEFAULT_AUDIO_SWITCHER;
        UShortParameter DEFAULT_AUDIO_OUTPUT;
        UShortParameter DEFAULT_DISPLAY_NUMBER;
        UShortParameter DEFAULT_LIGHTING_ZONE_NUMBER;
        UShortParameter DEFAULT_TSTAT_NUMBER;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME__DOLLAR__;
        StringParameter READ_AT_BOOTUP;
        AdaptCore.PD_Room MYBRIDGE;
        public void HANDLEBUSYEVENT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 107;
                BUSY  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMZONEONFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 109;
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
                
                __context__.SourceCodeLine = 110;
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
                
                __context__.SourceCodeLine = 111;
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
                
                __context__.SourceCodeLine = 112;
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
                
                __context__.SourceCodeLine = 113;
                ROOM_AV_SOURCE_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLELIGHTINGQUICKDIGITALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 115;
                QUICK_LIGHTING_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLELIGHTINGQUICKSERIALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 116;
                QUICK_LIGHTING_TEXT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECLIMATEQUICKDIGITALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 117;
                QUICK_CLIMATE_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECLIMATEQUICKSERIALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 118;
                QUICK_CLIMATE_TEXT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDOORLOCKQUICKDIGITALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 119;
                QUICK_DOORLOCKS_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDOORLOCKQUICKSERIALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 120;
                QUICK_DOORLOCKS_TEXT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEWINDOWSQUICKDIGITALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 121;
                QUICK_WINDOWS_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEWINDOWSQUICKSERIALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 122;
                QUICK_WINDOWS_TEXT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASAUDIO ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 124;
                HASAUDIO  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASDISPLAY ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 125;
                HASDISPLAY  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASLIGHTING ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 126;
                HASLIGHTING  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASCLIMATE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 127;
                HASCLIMATE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASDOORLOCKS ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 128;
                HASDOORLOCKS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASWINDOWS ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 129;
                HASWINDOWS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMSOURCENAME ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 131;
                ROOM_AV_SOURCE_NAME  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMNAMECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 132;
                ROOMNAME  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 137;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 137;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 138;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 139;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME__DOLLAR__  )  .ToString() ; 
                __context__.SourceCodeLine = 140;
                MYBRIDGE . FriendlyId = (ushort) ( ROOM_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 141;
                MYBRIDGE . DefaultAudioSwitcherType = (ushort) ( DEFAULT_AUDIO_SWITCHER_TYPE  .Value ) ; 
                __context__.SourceCodeLine = 142;
                MYBRIDGE . DefaultAudioSwitcherNumber = (ushort) ( DEFAULT_AUDIO_SWITCHER  .Value ) ; 
                __context__.SourceCodeLine = 143;
                MYBRIDGE . DefaultAudioOutputNumber = (ushort) ( DEFAULT_AUDIO_OUTPUT  .Value ) ; 
                __context__.SourceCodeLine = 144;
                MYBRIDGE . DefaultDisplayNumber = (ushort) ( DEFAULT_DISPLAY_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 145;
                MYBRIDGE . DefaultLightingZoneNumber = (ushort) ( DEFAULT_LIGHTING_ZONE_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 146;
                MYBRIDGE . DefaultTstatNumber = (ushort) ( DEFAULT_TSTAT_NUMBER  .Value ) ; 
                __context__.SourceCodeLine = 147;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 148;
                MYBRIDGE . FriendlyName  =  ( ROOM_NAME + Functions.ItoA (  (int) ( ROOM_NUMBER  .Value ) )  )  .ToString() ; 
                __context__.SourceCodeLine = 149;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 151;
                // RegisterEvent( MYBRIDGE , ONBUSYEVENT , HANDLEBUSYEVENT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnBusyEvent  += HANDLEBUSYEVENT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 153;
                // RegisterEvent( MYBRIDGE , SETROOMZONEONFEEDBACKCHANGE , HANDLEROOMZONEONFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomZoneOnFeedbackChange  += HANDLEROOMZONEONFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 154;
                // RegisterEvent( MYBRIDGE , SETROOMZONEOFFFEEDBACKCHANGE , HANDLEROOMZONEOFFFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomZoneOffFeedbackChange  += HANDLEROOMZONEOFFFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 155;
                // RegisterEvent( MYBRIDGE , SETROOMMUTEONFEEDBACKCHANGE , HANDLEROOMMUTEONFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomMuteOnFeedbackChange  += HANDLEROOMMUTEONFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 156;
                // RegisterEvent( MYBRIDGE , SETROOMVOLUMEFEEDBACKCHANGE , HANDLEROOMVOLUMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomVolumeFeedbackChange  += HANDLEROOMVOLUMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 157;
                // RegisterEvent( MYBRIDGE , SETROOMSOURCEFEEDBACKCHANGE , HANDLEROOMSOURCEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomSourceFeedbackChange  += HANDLEROOMSOURCEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 159;
                // RegisterEvent( MYBRIDGE , SETLIGHTINGQUICKDIGITALFEEDBACKCHANGE , HANDLELIGHTINGQUICKDIGITALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetLightingQuickDigitalFeedbackChange  += HANDLELIGHTINGQUICKDIGITALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 160;
                // RegisterEvent( MYBRIDGE , SETLIGHTINGQUICKSERIALFEEDBACKCHANGE , HANDLELIGHTINGQUICKSERIALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetLightingQuickSerialFeedbackChange  += HANDLELIGHTINGQUICKSERIALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 161;
                // RegisterEvent( MYBRIDGE , SETCLIMATEQUICKDIGITALFEEDBACKCHANGE , HANDLECLIMATEQUICKDIGITALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetClimateQuickDigitalFeedbackChange  += HANDLECLIMATEQUICKDIGITALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 162;
                // RegisterEvent( MYBRIDGE , SETCLIMATEQUICKSERIALFEEDBACKCHANGE , HANDLECLIMATEQUICKSERIALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetClimateQuickSerialFeedbackChange  += HANDLECLIMATEQUICKSERIALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 163;
                // RegisterEvent( MYBRIDGE , SETDOORLOCKQUICKDIGITALFEEDBACKCHANGE , HANDLEDOORLOCKQUICKDIGITALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDoorlockQuickDigitalFeedbackChange  += HANDLEDOORLOCKQUICKDIGITALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 164;
                // RegisterEvent( MYBRIDGE , SETDOORLOCKQUICKSERIALFEEDBACKCHANGE , HANDLEDOORLOCKQUICKSERIALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDoorlockQuickSerialFeedbackChange  += HANDLEDOORLOCKQUICKSERIALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 165;
                // RegisterEvent( MYBRIDGE , SETWINDOWSQUICKDIGITALFEEDBACKCHANGE , HANDLEWINDOWSQUICKDIGITALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetWindowsQuickDigitalFeedbackChange  += HANDLEWINDOWSQUICKDIGITALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 166;
                // RegisterEvent( MYBRIDGE , SETWINDOWSQUICKSERIALFEEDBACKCHANGE , HANDLEWINDOWSQUICKSERIALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetWindowsQuickSerialFeedbackChange  += HANDLEWINDOWSQUICKSERIALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 168;
                // RegisterEvent( MYBRIDGE , SETROOMHASAUDIOCHANGE , HANDLEROOMHASAUDIO ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasAudioChange  += HANDLEROOMHASAUDIO; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 169;
                // RegisterEvent( MYBRIDGE , SETROOMHASDISPLAYCHANGE , HANDLEROOMHASDISPLAY ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasDisplayChange  += HANDLEROOMHASDISPLAY; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 170;
                // RegisterEvent( MYBRIDGE , SETROOMHASLIGHTINGCHANGE , HANDLEROOMHASLIGHTING ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasLightingChange  += HANDLEROOMHASLIGHTING; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 171;
                // RegisterEvent( MYBRIDGE , SETROOMHASCLIMATECHANGE , HANDLEROOMHASCLIMATE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasClimateChange  += HANDLEROOMHASCLIMATE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 172;
                // RegisterEvent( MYBRIDGE , SETROOMHASDOORLOCKSCHANGE , HANDLEROOMHASDOORLOCKS ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasDoorlocksChange  += HANDLEROOMHASDOORLOCKS; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 173;
                // RegisterEvent( MYBRIDGE , SETROOMHASWINDOWSCHANGE , HANDLEROOMHASWINDOWS ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasWindowsChange  += HANDLEROOMHASWINDOWS; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 175;
                // RegisterEvent( MYBRIDGE , SETROOMNAMECHANGE , HANDLEROOMNAMECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomNameChange  += HANDLEROOMNAMECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 176;
                // RegisterEvent( MYBRIDGE , SETROOMSOURCENAMECHANGE , HANDLEROOMSOURCENAME ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomSourceNameChange  += HANDLEROOMSOURCENAME; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 178;
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
            
            __context__.SourceCodeLine = 181;
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
        
        __context__.SourceCodeLine = 182;
        MYBRIDGE . WriteFileData ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_ON_OnPush_3 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 184;
        MYBRIDGE . RoomZoneOnControlChange ( (ushort)( ROOM_AV_ON  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_OFF_OnPush_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 185;
        MYBRIDGE . RoomZoneOffControlChange ( (ushort)( ROOM_AV_OFF  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_TOGGLE_OnPush_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 186;
        MYBRIDGE . RoomZoneToggleControlChange ( (ushort)( ROOM_AV_TOGGLE  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_VOLUME_UP_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 187;
        MYBRIDGE . RoomVolumeUpControlChange ( (ushort)( ROOM_AV_VOLUME_UP  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_VOLUME_DOWN_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 188;
        MYBRIDGE . RoomVolumeDownControlChange ( (ushort)( ROOM_AV_VOLUME_DOWN  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_MUTE_ON_OnPush_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 189;
        MYBRIDGE . RoomMuteOnControlChange ( (ushort)( ROOM_AV_MUTE_ON  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_MUTE_OFF_OnPush_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 190;
        MYBRIDGE . RoomMuteOffControlChange ( (ushort)( ROOM_AV_MUTE_OFF  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_MUTE_TOGGLE_OnPush_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 191;
        MYBRIDGE . RoomMuteToggleControlChange ( (ushort)( ROOM_AV_MUTE_TOGGLE  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_VOLUME_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 192;
        MYBRIDGE . RoomVolumeValueControlChange ( (ushort)( ROOM_AV_VOLUME  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_SOURCE_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 193;
        MYBRIDGE . RoomSourceControlChange ( (ushort)( ROOM_AV_SOURCE  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object QUICK_LIGHTING_BTN_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 195;
        MYBRIDGE . LightingQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( QUICK_LIGHTING_BTN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object QUICK_CLIMATE_BTN_OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 196;
        MYBRIDGE . ClimateQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( QUICK_CLIMATE_BTN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object QUICK_DOORLOCKS_BTN_OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 197;
        MYBRIDGE . DoorlockQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( QUICK_DOORLOCKS_BTN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object QUICK_WINDOWS_BTN_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 198;
        MYBRIDGE . WindowsQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( QUICK_WINDOWS_BTN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
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
    
    QUICK_LIGHTING_BTN = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICK_LIGHTING_BTN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( QUICK_LIGHTING_BTN__DigitalInput__ + i, QUICK_LIGHTING_BTN__DigitalInput__, this );
        m_DigitalInputList.Add( QUICK_LIGHTING_BTN__DigitalInput__ + i, QUICK_LIGHTING_BTN[i+1] );
    }
    
    QUICK_CLIMATE_BTN = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICK_CLIMATE_BTN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( QUICK_CLIMATE_BTN__DigitalInput__ + i, QUICK_CLIMATE_BTN__DigitalInput__, this );
        m_DigitalInputList.Add( QUICK_CLIMATE_BTN__DigitalInput__ + i, QUICK_CLIMATE_BTN[i+1] );
    }
    
    QUICK_DOORLOCKS_BTN = new InOutArray<DigitalInput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        QUICK_DOORLOCKS_BTN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( QUICK_DOORLOCKS_BTN__DigitalInput__ + i, QUICK_DOORLOCKS_BTN__DigitalInput__, this );
        m_DigitalInputList.Add( QUICK_DOORLOCKS_BTN__DigitalInput__ + i, QUICK_DOORLOCKS_BTN[i+1] );
    }
    
    QUICK_WINDOWS_BTN = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICK_WINDOWS_BTN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( QUICK_WINDOWS_BTN__DigitalInput__ + i, QUICK_WINDOWS_BTN__DigitalInput__, this );
        m_DigitalInputList.Add( QUICK_WINDOWS_BTN__DigitalInput__ + i, QUICK_WINDOWS_BTN[i+1] );
    }
    
    BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( BUSY__DigitalOutput__, BUSY );
    
    ROOM_AV_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_AV_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_AV_ON_FB__DigitalOutput__, ROOM_AV_ON_FB );
    
    ROOM_AV_OFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_AV_OFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_AV_OFF_FB__DigitalOutput__, ROOM_AV_OFF_FB );
    
    ROOM_AV_MUTE_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_AV_MUTE_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_AV_MUTE_ON_FB__DigitalOutput__, ROOM_AV_MUTE_ON_FB );
    
    HASAUDIO = new Crestron.Logos.SplusObjects.DigitalOutput( HASAUDIO__DigitalOutput__, this );
    m_DigitalOutputList.Add( HASAUDIO__DigitalOutput__, HASAUDIO );
    
    HASDISPLAY = new Crestron.Logos.SplusObjects.DigitalOutput( HASDISPLAY__DigitalOutput__, this );
    m_DigitalOutputList.Add( HASDISPLAY__DigitalOutput__, HASDISPLAY );
    
    HASLIGHTING = new Crestron.Logos.SplusObjects.DigitalOutput( HASLIGHTING__DigitalOutput__, this );
    m_DigitalOutputList.Add( HASLIGHTING__DigitalOutput__, HASLIGHTING );
    
    HASCLIMATE = new Crestron.Logos.SplusObjects.DigitalOutput( HASCLIMATE__DigitalOutput__, this );
    m_DigitalOutputList.Add( HASCLIMATE__DigitalOutput__, HASCLIMATE );
    
    HASDOORLOCKS = new Crestron.Logos.SplusObjects.DigitalOutput( HASDOORLOCKS__DigitalOutput__, this );
    m_DigitalOutputList.Add( HASDOORLOCKS__DigitalOutput__, HASDOORLOCKS );
    
    HASWINDOWS = new Crestron.Logos.SplusObjects.DigitalOutput( HASWINDOWS__DigitalOutput__, this );
    m_DigitalOutputList.Add( HASWINDOWS__DigitalOutput__, HASWINDOWS );
    
    QUICK_LIGHTING_FB = new InOutArray<DigitalOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICK_LIGHTING_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICK_LIGHTING_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICK_LIGHTING_FB__DigitalOutput__ + i, QUICK_LIGHTING_FB[i+1] );
    }
    
    QUICK_CLIMATE_FB = new InOutArray<DigitalOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICK_CLIMATE_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICK_CLIMATE_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICK_CLIMATE_FB__DigitalOutput__ + i, QUICK_CLIMATE_FB[i+1] );
    }
    
    QUICK_DOORLOCKS_FB = new InOutArray<DigitalOutput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        QUICK_DOORLOCKS_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICK_DOORLOCKS_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICK_DOORLOCKS_FB__DigitalOutput__ + i, QUICK_DOORLOCKS_FB[i+1] );
    }
    
    QUICK_WINDOWS_FB = new InOutArray<DigitalOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICK_WINDOWS_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICK_WINDOWS_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICK_WINDOWS_FB__DigitalOutput__ + i, QUICK_WINDOWS_FB[i+1] );
    }
    
    ROOM_AV_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ROOM_AV_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOM_AV_VOLUME__AnalogSerialInput__, ROOM_AV_VOLUME );
    
    ROOM_AV_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ROOM_AV_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOM_AV_SOURCE__AnalogSerialInput__, ROOM_AV_SOURCE );
    
    ROOM_AV_VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_AV_VOLUME_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_AV_VOLUME_FB__AnalogSerialOutput__, ROOM_AV_VOLUME_FB );
    
    ROOM_AV_SOURCE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_AV_SOURCE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_AV_SOURCE_FB__AnalogSerialOutput__, ROOM_AV_SOURCE_FB );
    
    ROOMNAME = new Crestron.Logos.SplusObjects.StringOutput( ROOMNAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOMNAME__AnalogSerialOutput__, ROOMNAME );
    
    ROOM_AV_SOURCE_NAME = new Crestron.Logos.SplusObjects.StringOutput( ROOM_AV_SOURCE_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOM_AV_SOURCE_NAME__AnalogSerialOutput__, ROOM_AV_SOURCE_NAME );
    
    QUICK_LIGHTING_TEXT = new InOutArray<StringOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICK_LIGHTING_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( QUICK_LIGHTING_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( QUICK_LIGHTING_TEXT__AnalogSerialOutput__ + i, QUICK_LIGHTING_TEXT[i+1] );
    }
    
    QUICK_CLIMATE_TEXT = new InOutArray<StringOutput>( 4, this );
    for( uint i = 0; i < 4; i++ )
    {
        QUICK_CLIMATE_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( QUICK_CLIMATE_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( QUICK_CLIMATE_TEXT__AnalogSerialOutput__ + i, QUICK_CLIMATE_TEXT[i+1] );
    }
    
    QUICK_DOORLOCKS_TEXT = new InOutArray<StringOutput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        QUICK_DOORLOCKS_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( QUICK_DOORLOCKS_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( QUICK_DOORLOCKS_TEXT__AnalogSerialOutput__ + i, QUICK_DOORLOCKS_TEXT[i+1] );
    }
    
    QUICK_WINDOWS_TEXT = new InOutArray<StringOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICK_WINDOWS_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( QUICK_WINDOWS_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( QUICK_WINDOWS_TEXT__AnalogSerialOutput__ + i, QUICK_WINDOWS_TEXT[i+1] );
    }
    
    ROOM_NUMBER = new UShortParameter( ROOM_NUMBER__Parameter__, this );
    m_ParameterList.Add( ROOM_NUMBER__Parameter__, ROOM_NUMBER );
    
    DEFAULT_AUDIO_SWITCHER_TYPE = new UShortParameter( DEFAULT_AUDIO_SWITCHER_TYPE__Parameter__, this );
    m_ParameterList.Add( DEFAULT_AUDIO_SWITCHER_TYPE__Parameter__, DEFAULT_AUDIO_SWITCHER_TYPE );
    
    DEFAULT_AUDIO_SWITCHER = new UShortParameter( DEFAULT_AUDIO_SWITCHER__Parameter__, this );
    m_ParameterList.Add( DEFAULT_AUDIO_SWITCHER__Parameter__, DEFAULT_AUDIO_SWITCHER );
    
    DEFAULT_AUDIO_OUTPUT = new UShortParameter( DEFAULT_AUDIO_OUTPUT__Parameter__, this );
    m_ParameterList.Add( DEFAULT_AUDIO_OUTPUT__Parameter__, DEFAULT_AUDIO_OUTPUT );
    
    DEFAULT_DISPLAY_NUMBER = new UShortParameter( DEFAULT_DISPLAY_NUMBER__Parameter__, this );
    m_ParameterList.Add( DEFAULT_DISPLAY_NUMBER__Parameter__, DEFAULT_DISPLAY_NUMBER );
    
    DEFAULT_LIGHTING_ZONE_NUMBER = new UShortParameter( DEFAULT_LIGHTING_ZONE_NUMBER__Parameter__, this );
    m_ParameterList.Add( DEFAULT_LIGHTING_ZONE_NUMBER__Parameter__, DEFAULT_LIGHTING_ZONE_NUMBER );
    
    DEFAULT_TSTAT_NUMBER = new UShortParameter( DEFAULT_TSTAT_NUMBER__Parameter__, this );
    m_ParameterList.Add( DEFAULT_TSTAT_NUMBER__Parameter__, DEFAULT_TSTAT_NUMBER );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    ROOM_NAME = new StringParameter( ROOM_NAME__Parameter__, this );
    m_ParameterList.Add( ROOM_NAME__Parameter__, ROOM_NAME );
    
    FILE_NAME__DOLLAR__ = new StringParameter( FILE_NAME__DOLLAR____Parameter__, this );
    m_ParameterList.Add( FILE_NAME__DOLLAR____Parameter__, FILE_NAME__DOLLAR__ );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_OnPush_0, true ) );
    READ.OnDigitalPush.Add( new InputChangeHandlerWrapper( READ_OnPush_1, true ) );
    WRITE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WRITE_OnPush_2, true ) );
    ROOM_AV_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_AV_ON_OnPush_3, false ) );
    ROOM_AV_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_AV_OFF_OnPush_4, false ) );
    ROOM_AV_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_AV_TOGGLE_OnPush_5, false ) );
    ROOM_AV_VOLUME_UP.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_VOLUME_UP_OnChange_6, false ) );
    ROOM_AV_VOLUME_DOWN.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_VOLUME_DOWN_OnChange_7, false ) );
    ROOM_AV_MUTE_ON.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_AV_MUTE_ON_OnPush_8, false ) );
    ROOM_AV_MUTE_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_AV_MUTE_OFF_OnPush_9, false ) );
    ROOM_AV_MUTE_TOGGLE.OnDigitalPush.Add( new InputChangeHandlerWrapper( ROOM_AV_MUTE_TOGGLE_OnPush_10, false ) );
    ROOM_AV_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOM_AV_VOLUME_OnChange_11, false ) );
    ROOM_AV_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOM_AV_SOURCE_OnChange_12, false ) );
    for( uint i = 0; i < 12; i++ )
        QUICK_LIGHTING_BTN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( QUICK_LIGHTING_BTN_OnChange_13, false ) );
        
    for( uint i = 0; i < 12; i++ )
        QUICK_CLIMATE_BTN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( QUICK_CLIMATE_BTN_OnChange_14, false ) );
        
    for( uint i = 0; i < 2; i++ )
        QUICK_DOORLOCKS_BTN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( QUICK_DOORLOCKS_BTN_OnChange_15, false ) );
        
    for( uint i = 0; i < 12; i++ )
        QUICK_WINDOWS_BTN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( QUICK_WINDOWS_BTN_OnChange_16, false ) );
        
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_Room();
    
    
}

public UserModuleClass__AS__ROOM_V1_1_1 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint READ__DigitalInput__ = 1;
const uint WRITE__DigitalInput__ = 2;
const uint ROOM_AV_ON__DigitalInput__ = 3;
const uint ROOM_AV_OFF__DigitalInput__ = 4;
const uint ROOM_AV_TOGGLE__DigitalInput__ = 5;
const uint ROOM_AV_VOLUME_UP__DigitalInput__ = 6;
const uint ROOM_AV_VOLUME_DOWN__DigitalInput__ = 7;
const uint ROOM_AV_MUTE_ON__DigitalInput__ = 8;
const uint ROOM_AV_MUTE_OFF__DigitalInput__ = 9;
const uint ROOM_AV_MUTE_TOGGLE__DigitalInput__ = 10;
const uint QUICK_LIGHTING_BTN__DigitalInput__ = 11;
const uint QUICK_CLIMATE_BTN__DigitalInput__ = 23;
const uint QUICK_DOORLOCKS_BTN__DigitalInput__ = 35;
const uint QUICK_WINDOWS_BTN__DigitalInput__ = 37;
const uint ROOM_AV_VOLUME__AnalogSerialInput__ = 0;
const uint ROOM_AV_SOURCE__AnalogSerialInput__ = 1;
const uint BUSY__DigitalOutput__ = 0;
const uint ROOM_AV_ON_FB__DigitalOutput__ = 1;
const uint ROOM_AV_OFF_FB__DigitalOutput__ = 2;
const uint ROOM_AV_MUTE_ON_FB__DigitalOutput__ = 3;
const uint HASAUDIO__DigitalOutput__ = 4;
const uint HASDISPLAY__DigitalOutput__ = 5;
const uint HASLIGHTING__DigitalOutput__ = 6;
const uint HASCLIMATE__DigitalOutput__ = 7;
const uint HASDOORLOCKS__DigitalOutput__ = 8;
const uint HASWINDOWS__DigitalOutput__ = 9;
const uint QUICK_LIGHTING_FB__DigitalOutput__ = 10;
const uint QUICK_CLIMATE_FB__DigitalOutput__ = 22;
const uint QUICK_DOORLOCKS_FB__DigitalOutput__ = 34;
const uint QUICK_WINDOWS_FB__DigitalOutput__ = 36;
const uint ROOM_AV_VOLUME_FB__AnalogSerialOutput__ = 0;
const uint ROOM_AV_SOURCE_FB__AnalogSerialOutput__ = 1;
const uint ROOMNAME__AnalogSerialOutput__ = 2;
const uint ROOM_AV_SOURCE_NAME__AnalogSerialOutput__ = 3;
const uint QUICK_LIGHTING_TEXT__AnalogSerialOutput__ = 4;
const uint QUICK_CLIMATE_TEXT__AnalogSerialOutput__ = 16;
const uint QUICK_DOORLOCKS_TEXT__AnalogSerialOutput__ = 20;
const uint QUICK_WINDOWS_TEXT__AnalogSerialOutput__ = 22;
const uint ROOM_NUMBER__Parameter__ = 10;
const uint ROOM_NAME__Parameter__ = 11;
const uint DEFAULT_AUDIO_SWITCHER_TYPE__Parameter__ = 12;
const uint DEFAULT_AUDIO_SWITCHER__Parameter__ = 13;
const uint DEFAULT_AUDIO_OUTPUT__Parameter__ = 14;
const uint DEFAULT_DISPLAY_NUMBER__Parameter__ = 15;
const uint DEFAULT_LIGHTING_ZONE_NUMBER__Parameter__ = 16;
const uint DEFAULT_TSTAT_NUMBER__Parameter__ = 17;
const uint ACCESS_LEVEL__Parameter__ = 18;
const uint FILE_NAME__DOLLAR____Parameter__ = 19;
const uint READ_AT_BOOTUP__Parameter__ = 20;

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

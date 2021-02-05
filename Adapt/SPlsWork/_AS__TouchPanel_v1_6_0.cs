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

namespace UserModule__AS__TOUCHPANEL_V1_6_0
{
    public class UserModuleClass__AS__TOUCHPANEL_V1_6_0 : SplusObject
    {
        static CCriticalSection g_criticalSection = new CCriticalSection();
        
        
        
        
        
        
        
        
        
        Crestron.Logos.SplusObjects.DigitalInput INIT;
        Crestron.Logos.SplusObjects.DigitalInput READ;
        Crestron.Logos.SplusObjects.DigitalInput WRITE;
        Crestron.Logos.SplusObjects.DigitalInput ACTIVITY_DETECTED;
        Crestron.Logos.SplusObjects.DigitalInput ONLINE;
        Crestron.Logos.SplusObjects.DigitalInput CONNECTED_TO_ADDRESS2;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_ON;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_OFF;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_VOLUME_UP;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_VOLUME_DOWN;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_MUTE_ON;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_MUTE_OFF;
        Crestron.Logos.SplusObjects.DigitalInput ROOM_AV_MUTE_TOGGLE;
        Crestron.Logos.SplusObjects.DigitalInput OTHER_ROOMS_OFF;
        Crestron.Logos.SplusObjects.DigitalInput ALL_ROOMS_OFF;
        Crestron.Logos.SplusObjects.DigitalInput AREA_OFF_BTN;
        Crestron.Logos.SplusObjects.DigitalInput BACK_BTN;
        Crestron.Logos.SplusObjects.DigitalInput HOME_BTN;
        Crestron.Logos.SplusObjects.DigitalInput MEDIA_BTN;
        Crestron.Logos.SplusObjects.DigitalInput LIGHTS_BTN;
        Crestron.Logos.SplusObjects.DigitalInput CLIMATE_BTN;
        Crestron.Logos.SplusObjects.DigitalInput SECURITY_BTN;
        Crestron.Logos.SplusObjects.DigitalInput CAMERAS_BTN;
        Crestron.Logos.SplusObjects.DigitalInput WINDOWS_BTN;
        Crestron.Logos.SplusObjects.DigitalInput DOORS_BTN;
        Crestron.Logos.SplusObjects.DigitalInput LOCAL_DEVICE_BTN;
        Crestron.Logos.SplusObjects.DigitalInput GLOBAL_DEVICE_BTN;
        Crestron.Logos.SplusObjects.DigitalInput MULTIROOM_ZONE_OFF_BTN;
        Crestron.Logos.SplusObjects.DigitalInput MULTIROOM_CLEAR_BTN;
        Crestron.Logos.SplusObjects.DigitalInput MULTIROOM_SELECT_ALL_BTN;
        Crestron.Logos.SplusObjects.DigitalInput MULTIROOM_CONTROL_SOURCE_BTN;
        Crestron.Logos.SplusObjects.DigitalInput MULTIROOM_NEW_SCENE_BTN;
        Crestron.Logos.SplusObjects.DigitalInput MULTIROOM_REPLACE_SCENE_BTN;
        Crestron.Logos.SplusObjects.DigitalInput MUTLIROOM_DELETE_SCENE_BTN;
        Crestron.Logos.SplusObjects.DigitalInput KEYBOARD_CLEAR_BTN;
        Crestron.Logos.SplusObjects.DigitalInput KEYBOARD_BACKSPACE_BTN;
        Crestron.Logos.SplusObjects.DigitalInput KEYBOARD_CAPS_LOCK_BTN;
        Crestron.Logos.SplusObjects.DigitalInput KEYBOARD_SHIFT_BTN;
        Crestron.Logos.SplusObjects.DigitalInput KEYBOARD_SAVE_BTN;
        Crestron.Logos.SplusObjects.DigitalInput KEYBOARD_CANCEL_EDIT_BTN;
        Crestron.Logos.SplusObjects.DigitalInput SET_CURRENT_ROOM_TO_DEFAULT;
        Crestron.Logos.SplusObjects.DigitalInput START_SHARE_MODE;
        Crestron.Logos.SplusObjects.DigitalInput STOP_SHARE_MODE;
        Crestron.Logos.SplusObjects.DigitalInput DOORBELL_CANCEL_THIS_ROOM;
        Crestron.Logos.SplusObjects.DigitalInput DOORBELL_CANCEL_ALL;
        Crestron.Logos.SplusObjects.DigitalInput DOORBELL_ANSWER;
        Crestron.Logos.SplusObjects.DigitalInput DOORBELL_END_CALL;
        Crestron.Logos.SplusObjects.AnalogInput ROOM_AV_VOLUME;
        Crestron.Logos.SplusObjects.AnalogInput ROOM_AV_LIST_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput ROOM_AV_DIRECT_SOURCE;
        Crestron.Logos.SplusObjects.AnalogInput SOURCE_LIST_MODE;
        Crestron.Logos.SplusObjects.AnalogInput ROOM_LIST_INDEX;
        Crestron.Logos.SplusObjects.AnalogInput ROOM_DIRECT_SELECT;
        Crestron.Logos.SplusObjects.AnalogInput THROWPAGE;
        Crestron.Logos.SplusObjects.AnalogInput THROWDEVICESUBPAGE;
        Crestron.Logos.SplusObjects.AnalogInput SELECT_PAGE_DEVICE;
        Crestron.Logos.SplusObjects.AnalogInput DIRECT_OTHERDEVICE_SELECT;
        Crestron.Logos.SplusObjects.AnalogInput NAVIGATIONITEMCLICKED;
        Crestron.Logos.SplusObjects.AnalogInput MULTIROOM_VOLUME_IN;
        Crestron.Logos.SplusObjects.AnalogInput MULTIROOM_SOURCE_INDEX;
        Crestron.Logos.SplusObjects.AnalogInput MULTIROOM_MODE;
        Crestron.Logos.SplusObjects.AnalogInput MULTIROOM_SCENE_RECALL;
        Crestron.Logos.SplusObjects.AnalogInput MULTIROOM_SCENE_STORE;
        Crestron.Logos.SplusObjects.AnalogInput CAMERA_SELECT;
        Crestron.Logos.SplusObjects.AnalogInput DISPLAY_SELECT;
        Crestron.Logos.SplusObjects.DigitalInput INTERCOM_ACTIVE;
        Crestron.Logos.SplusObjects.AnalogInput INTERCOM_SELECT;
        Crestron.Logos.SplusObjects.StringInput INTERCOM_MY_URI;
        Crestron.Logos.SplusObjects.StringInput INTERCOM_INCOMING_URI_FB;
        Crestron.Logos.SplusObjects.AnalogInput DEFAULT_ROOM_TIMEOUT;
        Crestron.Logos.SplusObjects.AnalogInput DEFAULT_PAGE_NUM;
        Crestron.Logos.SplusObjects.AnalogInput DEFAULT_PAGE_TIMEOUT;
        Crestron.Logos.SplusObjects.DigitalInput AREA_SELECT_NEXT_BTN;
        Crestron.Logos.SplusObjects.DigitalInput AREA_SELECT_PREV_BTN;
        Crestron.Logos.SplusObjects.AnalogInput AREA_SELECT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> SOURCEQUICKCONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> LIGHTSQUICKCONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> CLIMATEQUICKCONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> DOORLOCKQUICKCONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> WINDOWSQUICKCONTROL;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> D_IN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> CONTROL_LIST_BTN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> MULTIROOM_SELECT_BTN;
        InOutArray<Crestron.Logos.SplusObjects.DigitalInput> KEYBOARD_CHAR_BTN;
        InOutArray<Crestron.Logos.SplusObjects.AnalogInput> A_IN;
        Crestron.Logos.SplusObjects.DigitalOutput PANEL_BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_BUSY;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_AV_ON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_AV_OFF_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_AV_MUTE_ON_FB;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_HAS_AUDIO;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_HAS_DISPLAYS;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_HAS_LIGHTING;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_HAS_CLIMATE;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_HAS_SECURITY;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_HAS_CAMERAS;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_HAS_WINDOWS;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_HAS_DOORS;
        Crestron.Logos.SplusObjects.DigitalOutput DEMO_EXPIRED;
        Crestron.Logos.SplusObjects.DigitalOutput LOCAL_DEVICE_SELECTED;
        Crestron.Logos.SplusObjects.DigitalOutput GLOBAL_DEVICE_SELECTED;
        Crestron.Logos.SplusObjects.DigitalOutput ALLOW_ROAMING;
        Crestron.Logos.SplusObjects.DigitalOutput ALLOW_GLOBAL_LIGHTING;
        Crestron.Logos.SplusObjects.DigitalOutput ALLOW_GLOBAL_CLIMATE;
        Crestron.Logos.SplusObjects.DigitalOutput ALLOW_GLOBAL_SECURITY;
        Crestron.Logos.SplusObjects.DigitalOutput ALLOW_GLOBAL_CAMERAS;
        Crestron.Logos.SplusObjects.DigitalOutput ALLOW_GLOBAL_WINDOWS;
        Crestron.Logos.SplusObjects.DigitalOutput ALLOW_GLOBAL_DOORS;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_AV_VOLUME_FB;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_AV_LIST_SOURCE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_AV_DIRECT_SOURCE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput PANEL_CONTROL_SOURCE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput OTHERDEVICE_CONNECTED_FB;
        Crestron.Logos.SplusObjects.AnalogOutput GO_TO_PAGE;
        Crestron.Logos.SplusObjects.AnalogOutput GO_TO_DEVICE_SUBPAGE;
        Crestron.Logos.SplusObjects.AnalogOutput CONNECTED_ROOM_NUM_FB;
        Crestron.Logos.SplusObjects.AnalogOutput CONNECTED_ROOM_INDEX_FB;
        Crestron.Logos.SplusObjects.AnalogOutput MEDIA_NUM_LINES;
        Crestron.Logos.SplusObjects.AnalogOutput ROOMS_NUM_LINES;
        Crestron.Logos.SplusObjects.AnalogOutput SOURCE_NUM_QUICK_CONTROLS;
        Crestron.Logos.SplusObjects.AnalogOutput LIGHTS_NUM_QUICK_CONTROLS;
        Crestron.Logos.SplusObjects.AnalogOutput WINDOWS_NUM_QUICK_CONTROLS;
        Crestron.Logos.SplusObjects.AnalogOutput HOME_PAGE_TYPE;
        Crestron.Logos.SplusObjects.AnalogOutput NAVIGATIONITEMSELECTED;
        Crestron.Logos.SplusObjects.AnalogOutput CONTROLLISTNUMITEMS;
        Crestron.Logos.SplusObjects.StringOutput CONNECTED_ROOM_NAME_FB;
        Crestron.Logos.SplusObjects.StringOutput QUICK_SOURCE_NAME_FB;
        Crestron.Logos.SplusObjects.StringOutput CONNECTED_CONTROL_NAME_FB;
        Crestron.Logos.SplusObjects.StringOutput HOME_PAGE_TITLE;
        Crestron.Logos.SplusObjects.DigitalOutput MULTIROOM_SHOW_SOURCE_LIST;
        Crestron.Logos.SplusObjects.DigitalOutput MULTIROOM_CONTROL_NOW_VISIBLE;
        Crestron.Logos.SplusObjects.AnalogOutput MULTIROOM_VOLUME_FB;
        Crestron.Logos.SplusObjects.AnalogOutput MULTIROOM_MODE_FB;
        Crestron.Logos.SplusObjects.AnalogOutput MULTIROOM_SOURCE_LIST_SIZE;
        Crestron.Logos.SplusObjects.AnalogOutput MULTIROOM_SOURCE_SELECTED_INDEX;
        Crestron.Logos.SplusObjects.StringOutput MULTIROOM_SOURCE_NAME;
        Crestron.Logos.SplusObjects.DigitalOutput MULTIROOM_SHOW_SCENE_EDIT_POPUP;
        Crestron.Logos.SplusObjects.DigitalOutput MULTIROOM_SHOW_SCENE_SAVE_POPUP;
        Crestron.Logos.SplusObjects.AnalogOutput MULTIROOM_SCENE_LIST_SIZE;
        Crestron.Logos.SplusObjects.DigitalOutput KEYBOARD_CAPS_LOCK_FB;
        Crestron.Logos.SplusObjects.DigitalOutput KEYBOARD_SHIFT_FB;
        Crestron.Logos.SplusObjects.AnalogOutput KEYBOARD_SHIFT_MODE;
        Crestron.Logos.SplusObjects.StringOutput KEYBOARD_CURRENT_TEXT;
        Crestron.Logos.SplusObjects.StringOutput DEFAULT_ROOM_NAME;
        Crestron.Logos.SplusObjects.AnalogOutput DEFAULT_ROOM_TIMEOUT_FB;
        Crestron.Logos.SplusObjects.AnalogOutput DEFAULT_PAGE_NUM_FB;
        Crestron.Logos.SplusObjects.AnalogOutput DEFAULT_PAGE_TIMEOUT_FB;
        Crestron.Logos.SplusObjects.StringOutput QUICKCAMERAURL;
        Crestron.Logos.SplusObjects.AnalogOutput CAMERA_SELECTED;
        Crestron.Logos.SplusObjects.AnalogOutput CAMERA_LIST_NUM_LINES;
        Crestron.Logos.SplusObjects.AnalogOutput CAMERA_VIDEO_TYPE;
        Crestron.Logos.SplusObjects.DigitalOutput ROOM_HAS_MULTIPLE_DISPLAYS;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_DISPLAY_SELECTED;
        Crestron.Logos.SplusObjects.AnalogOutput ROOM_DISPLAYS_NUM_LINES;
        Crestron.Logos.SplusObjects.StringOutput ROOM_SELECTED_DISPLAY_NAME;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_SHARE_BUTTON;
        Crestron.Logos.SplusObjects.DigitalOutput INTERCOM_HANGUP;
        Crestron.Logos.SplusObjects.StringOutput DOORBELL_MESSAGE;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_DOORBELL_CAMERA;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_DOORBELL_INTERCOM;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_DOORBELL_CONTROLS;
        Crestron.Logos.SplusObjects.StringOutput INTERCOM_STRING_TO_DIAL;
        Crestron.Logos.SplusObjects.StringOutput INTERCOM_INCOMING_NAME;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_AREA_CONTROLS;
        Crestron.Logos.SplusObjects.StringOutput CURRENT_AREA_NAME;
        Crestron.Logos.SplusObjects.DigitalOutput SHOW_VOLUME_FEEDBACK;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> D_OUT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> A_OUT;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> S_OUT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> SOURCE_LIST_IN_USE;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> SOURCE_LIST_TEXT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> SOURCE_LIST_ICON;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ROOM_LIST_TEXT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICKSOURCE_D_FB;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> QUICKSOURCE_A_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> QUICKSOURCE_S_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICKLIGHTS_D_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> QUICKLIGHTS_S_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICKCLIMATE_D_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> QUICKCLIMATE_S_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICKDOORLOCK_D_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> QUICKDOORLOCK_S_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> QUICKWINDOWS_D_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> QUICKWINDOWS_S_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> NAVIGATIONITEMENABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> NAVIGATIONITEMVISIBLE;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> NAVIGATIONITEMICON;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> NAVIGATIONITEMTEXT;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> CONTROLLISTDIGITAL_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CONTROLLISTSERIAL_FB;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> MULTIROOM_SELECT_FB;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> MULTIROOM_SOURCE_LIST_TEXT;
        InOutArray<Crestron.Logos.SplusObjects.AnalogOutput> MULTIROOM_SOURCE_LIST_ICON;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> MULTIROOM_SCENE_NAMES;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> CAMERA_NAMES_LIST;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> ROOM_DISPLAYS_LIST;
        InOutArray<Crestron.Logos.SplusObjects.StringOutput> INTERCOM_NAMES_LIST;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> INTERCOM_LIST_ENABLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> INTERCOM_LIST_VISIBLE;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> DOORBELL_CHIME;
        InOutArray<Crestron.Logos.SplusObjects.DigitalOutput> ROOMLISTITEMENABLE;
        UShortParameter TP_ID;
        StringParameter TP_NAME;
        UShortParameter DEFAULT_ROOM;
        UShortParameter ACCESS_LEVEL;
        StringParameter FILE_NAME;
        StringParameter READ_AT_BOOTUP;
        UShortParameter DEFAULT_HOME_PAGE_TYPE;
        AdaptCore.PD_TouchPanel MYBRIDGE;
        public void HANDLEROOMBUSYEVENT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 316;
                ROOM_BUSY  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEPANELBUSYEVENT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 317;
                PANEL_BUSY  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDIGITALOUTPUT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 319;
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
                
                __context__.SourceCodeLine = 320;
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
                
                __context__.SourceCodeLine = 321;
                S_OUT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECONNECTEDDEVICENAMEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 323;
                CONNECTED_CONTROL_NAME_FB  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECONNECTEDROOMNAMEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 325;
                CONNECTED_ROOM_NAME_FB  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECONNECTEDROOMNUMFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 326;
                CONNECTED_ROOM_NUM_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECONNECTEDROOMINDEXFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 327;
                CONNECTED_ROOM_INDEX_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMLISTSIZECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 329;
                ROOMS_NUM_LINES  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMLISTFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 330;
                ROOM_LIST_TEXT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESOURCELISTSIZECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 332;
                MEDIA_NUM_LINES  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESOURCELISTFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 333;
                SOURCE_LIST_TEXT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESOURCELISTICONCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_AnalogEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 334;
                SOURCE_LIST_ICON [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESOURCELISTINUSECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 335;
                SOURCE_LIST_IN_USE [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMZONEONFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 337;
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
                
                __context__.SourceCodeLine = 338;
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
                
                __context__.SourceCodeLine = 339;
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
                
                __context__.SourceCodeLine = 340;
                ROOM_AV_VOLUME_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMLISTSOURCEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 341;
                ROOM_AV_LIST_SOURCE_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMSOURCEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 342;
                ROOM_AV_DIRECT_SOURCE_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMSOURCENAMEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 343;
                QUICK_SOURCE_NAME_FB  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEPANELCONTROLSOURCEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 345;
                PANEL_CONTROL_SOURCE_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKSOURCEDIGITALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 347;
                QUICKSOURCE_D_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKSOURCEANALOGFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_AnalogEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 348;
                QUICKSOURCE_A_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKSOURCESERIALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 349;
                QUICKSOURCE_S_FB [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKSOURCECONTROLSCOUNT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 350;
                SOURCE_NUM_QUICK_CONTROLS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKLIGHTSDIGITALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 352;
                QUICKLIGHTS_D_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKLIGHTSSERIALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 353;
                QUICKLIGHTS_S_FB [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKLIGHTSCONTROLSCOUNT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 354;
                LIGHTS_NUM_QUICK_CONTROLS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKCLIMATEDIGITALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 356;
                QUICKCLIMATE_D_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKCLIMATESERIALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 357;
                QUICKCLIMATE_S_FB [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKDOORLOCKDIGITALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 359;
                QUICKDOORLOCK_D_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKDOORLOCKSERIALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 360;
                QUICKDOORLOCK_S_FB [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKWINDOWSDIGITALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 362;
                QUICKWINDOWS_D_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKWINDOWSSERIALFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 363;
                QUICKWINDOWS_S_FB [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKWINDOWSCONTROLSCOUNT ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 364;
                WINDOWS_NUM_QUICK_CONTROLS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEQUICKCAMERAURL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 366;
                QUICKCAMERAURL  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEPAGEFLIPCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 368;
                GO_TO_PAGE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDEVICESUBPAGECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 369;
                GO_TO_DEVICE_SUBPAGE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASAUDIOCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 371;
                ROOM_HAS_AUDIO  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASDISPLAYSCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 372;
                ROOM_HAS_DISPLAYS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASLIGHTINGCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 373;
                ROOM_HAS_LIGHTING  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASCLIMATECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 374;
                ROOM_HAS_CLIMATE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASSECURITYCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 375;
                ROOM_HAS_SECURITY  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASCAMERASCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 376;
                ROOM_HAS_CAMERAS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASWINDOWSCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 377;
                ROOM_HAS_WINDOWS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASDOORSCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 378;
                ROOM_HAS_DOORS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDEMOEXPIREDCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 380;
                DEMO_EXPIRED  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEHOMEPAGETYPECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 382;
                HOME_PAGE_TYPE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLENAVIGATIONITEMSELECTED ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 383;
                NAVIGATIONITEMSELECTED  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEHOMEPAGETITLECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 384;
                HOME_PAGE_TITLE  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLENAVIGATIONITEMTEXTCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 385;
                NAVIGATIONITEMTEXT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLENAVIGATIONITEMICONCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_AnalogEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 386;
                NAVIGATIONITEMICON [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLENAVIGATIONITEMENABLECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 387;
                NAVIGATIONITEMENABLE [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLENAVIGATIONITEMVISIBLECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 388;
                NAVIGATIONITEMVISIBLE [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECONTROLLISTSIZECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 390;
                CONTROLLISTNUMITEMS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECONTROLLISTDIGITALFEEDBACKCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 391;
                CONTROLLISTDIGITAL_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECONTROLLISTSERIALFEEDBACKCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 392;
                CONTROLLISTSERIAL_FB [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLELOCALDEVICESELECTEDCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 394;
                LOCAL_DEVICE_SELECTED  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEGLOBALDEVICESELECTEDCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 395;
                GLOBAL_DEVICE_SELECTED  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEALLOWROAMINGCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 397;
                ALLOW_ROAMING  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEALLOWGLOBALLIGHTSCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 398;
                ALLOW_GLOBAL_LIGHTING  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEALLOWGLOBALCLIMATECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 399;
                ALLOW_GLOBAL_CLIMATE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEALLOWGLOBALSECURITYCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 400;
                ALLOW_GLOBAL_SECURITY  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEALLOWGLOBALCAMERASCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 401;
                ALLOW_GLOBAL_CAMERAS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEALLOWGLOBALWINDOWSCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 402;
                ALLOW_GLOBAL_WINDOWS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEALLOWGLOBALDOORSCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 403;
                ALLOW_GLOBAL_DOORS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSELECTFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 405;
                MULTIROOM_SELECT_FB [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMVOLUMEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 406;
                MULTIROOM_VOLUME_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMMODESELECTFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 407;
                MULTIROOM_MODE_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSHOWSOURCELIST ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 408;
                MULTIROOM_SHOW_SOURCE_LIST  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSOURCELISTSIZECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 409;
                MULTIROOM_SOURCE_LIST_SIZE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSOURCELISTFEEDBACKCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 410;
                MULTIROOM_SOURCE_LIST_TEXT [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSOURCELISTICONCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_AnalogEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 411;
                MULTIROOM_SOURCE_LIST_ICON [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSELECTEDSOURCENAME ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 412;
                MULTIROOM_SOURCE_NAME  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSELECTEDSOURCEINDEX ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 413;
                MULTIROOM_SOURCE_SELECTED_INDEX  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMCONTROLNOWVISIBILITY ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 414;
                MULTIROOM_CONTROL_NOW_VISIBLE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSHOWSCENEEDITPOPUP ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 416;
                MULTIROOM_SHOW_SCENE_EDIT_POPUP  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSHOWSCENESAVEPOPUP ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 417;
                MULTIROOM_SHOW_SCENE_SAVE_POPUP  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSCENELISTSIZECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 418;
                MULTIROOM_SCENE_LIST_SIZE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEMULTIROOMSCENENAMESLISTCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 419;
                MULTIROOM_SCENE_NAMES [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEKEYBOARDCAPSLOCKFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 421;
                KEYBOARD_CAPS_LOCK_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEKEYBOARDSHIFTFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 422;
                KEYBOARD_SHIFT_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEKEYBOARDCURRENTTEXTFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 423;
                KEYBOARD_CURRENT_TEXT  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEKEYBOARDSHIFTMODECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 424;
                KEYBOARD_SHIFT_MODE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDEFAULTROOMNAMEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 426;
                DEFAULT_ROOM_NAME  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDEFAULTROOMTIMEOUTFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 427;
                DEFAULT_ROOM_TIMEOUT_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDEFAULTPAGENUMFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 428;
                DEFAULT_PAGE_NUM_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDEFAULTPAGETIMEOUTFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 429;
                DEFAULT_PAGE_TIMEOUT_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEOTHERDEVICENUMBERCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 431;
                OTHERDEVICE_CONNECTED_FB  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECAMERANAMESLISTCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 433;
                CAMERA_NAMES_LIST [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECAMERASELECTEDFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 434;
                CAMERA_SELECTED  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECAMERALISTSIZECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 435;
                CAMERA_LIST_NUM_LINES  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECAMERAVIDEOTYPECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 436;
                CAMERA_VIDEO_TYPE  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMHASMULTIPLEDISPLAYSFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 438;
                ROOM_HAS_MULTIPLE_DISPLAYS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMDISPLAYSELECTEDFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 439;
                ROOM_DISPLAY_SELECTED  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMDISPLAYLISTSIZECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 440;
                ROOM_DISPLAYS_NUM_LINES  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMDISPLAYLISTITEMFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 441;
                ROOM_DISPLAYS_LIST [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMDISPLAYNAMESELECTEDFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 442;
                ROOM_SELECTED_DISPLAY_NAME  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESHOWSHAREBUTTONCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 443;
                SHOW_SHARE_BUTTON  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDOORBELLMESSAGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 445;
                DOORBELL_MESSAGE  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDOORBELLCHIME ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 446;
                Functions.Pulse ( 1, DOORBELL_CHIME [ ARGS.SignalValue] ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDOORBELLINTERCOMVISIBLE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 447;
                SHOW_DOORBELL_INTERCOM  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDOORBELLCAMERAVISIBLE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 448;
                SHOW_DOORBELL_CAMERA  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEDOORBELLCONTROLSVISIBLE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 449;
                SHOW_DOORBELL_CONTROLS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEINTERCOMSTRINGTODIAL ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 451;
                INTERCOM_STRING_TO_DIAL  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEINTERCOMLISTITEMENABLE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 452;
                INTERCOM_LIST_ENABLE [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEINTERCOMLISTITEMVISIBLE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 453;
                INTERCOM_LIST_VISIBLE [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEINTERCOMLISTNAMECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_SerialEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 454;
                INTERCOM_NAMES_LIST [ ARGS.JoinNum]  .UpdateValue ( ARGS . SignalValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEINTERCOMINCOMINGNAMECHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 455;
                INTERCOM_INCOMING_NAME  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEINTERCOMHANGUPCHANGE ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 456;
                Functions.Pulse ( 1, INTERCOM_HANGUP ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLECURRENTAREANAMEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_NameEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 458;
                CURRENT_AREA_NAME  .UpdateValue ( ARGS . NameValue  ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLEROOMLISTITEMENABLEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_DigitalEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 459;
                ROOMLISTITEMENABLE [ ARGS.JoinNum]  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESHOWAREACONTROLSFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 460;
                SHOW_AREA_CONTROLS  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        public void HANDLESHOWVOLUMEFEEDBACK ( object __sender__ /*AdaptCore.PD_Bridge SENDER */, AdaptCore.PD_ValueEventArgs ARGS ) 
            { 
            PD_Bridge  SENDER  = (PD_Bridge )__sender__;
            try
            {
                SplusExecutionContext __context__ = SplusSimplSharpDelegateThreadStartCode();
                
                __context__.SourceCodeLine = 462;
                SHOW_VOLUME_FEEDBACK  .Value = (ushort) ( ARGS.SignalValue ) ; 
                
                
            }
            finally { ObjectFinallyHandler(); }
            }
            
        object INIT_OnPush_0 ( Object __EventInfo__ )
        
            { 
            Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
            try
            {
                SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
                
                __context__.SourceCodeLine = 467;
                if ( Functions.TestForTrue  ( ( Functions.BoolToInt (GetSymbolReferenceName() == "DEBUG"))  ) ) 
                    {
                    __context__.SourceCodeLine = 467;
                    MYBRIDGE . DebugOn = (ushort) ( 1 ) ; 
                    }
                
                __context__.SourceCodeLine = 468;
                MYBRIDGE . SymbolName  =  ( "P" + Functions.ItoA (  (int) ( GetProgramNumber() ) ) + ":" + GetSymbolInstanceName ( )  )  .ToString() ; 
                __context__.SourceCodeLine = 469;
                MYBRIDGE . SymbolFileName  =  ( FILE_NAME  )  .ToString() ; 
                __context__.SourceCodeLine = 470;
                MYBRIDGE . FriendlyId = (ushort) ( TP_ID  .Value ) ; 
                __context__.SourceCodeLine = 471;
                MYBRIDGE . FriendlyName  =  ( TP_NAME + Functions.ItoA (  (int) ( TP_ID  .Value ) )  )  .ToString() ; 
                __context__.SourceCodeLine = 472;
                MYBRIDGE . DefaultRoomNum = (ushort) ( DEFAULT_ROOM  .Value ) ; 
                __context__.SourceCodeLine = 473;
                MYBRIDGE . AccessLevel = (ushort) ( ACCESS_LEVEL  .Value ) ; 
                __context__.SourceCodeLine = 474;
                MYBRIDGE . ReadAtBootup  =  ( READ_AT_BOOTUP  )  .ToString() ; 
                __context__.SourceCodeLine = 475;
                MYBRIDGE . HomePageType = (ushort) ( DEFAULT_HOME_PAGE_TYPE  .Value ) ; 
                __context__.SourceCodeLine = 476;
                MYBRIDGE . MaxNumRooms = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 477;
                MYBRIDGE . MaxNumSources = (ushort) ( 50 ) ; 
                __context__.SourceCodeLine = 479;
                // RegisterEvent( MYBRIDGE , ONBUSYEVENT , HANDLEROOMBUSYEVENT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnBusyEvent  += HANDLEROOMBUSYEVENT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 480;
                // RegisterEvent( MYBRIDGE , ONPANELBUSYEVENT , HANDLEPANELBUSYEVENT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnPanelBusyEvent  += HANDLEPANELBUSYEVENT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 482;
                // RegisterEvent( MYBRIDGE , ONDIGITALOUTPUTCHANGE , HANDLEDIGITALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnDigitalOutputChange  += HANDLEDIGITALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 483;
                // RegisterEvent( MYBRIDGE , ONANALOGOUTPUTCHANGE , HANDLEANALOGOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnAnalogOutputChange  += HANDLEANALOGOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 484;
                // RegisterEvent( MYBRIDGE , ONSERIALOUTPUTCHANGE , HANDLESERIALOUTPUT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .OnSerialOutputChange  += HANDLESERIALOUTPUT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 486;
                // RegisterEvent( MYBRIDGE , SETCONNECTEDDEVICENAMEFEEDBACKCHANGE , HANDLECONNECTEDDEVICENAMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetConnectedDeviceNameFeedbackChange  += HANDLECONNECTEDDEVICENAMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 488;
                // RegisterEvent( MYBRIDGE , SETCONNECTEDROOMNAMEFEEDBACKCHANGE , HANDLECONNECTEDROOMNAMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetConnectedRoomNameFeedbackChange  += HANDLECONNECTEDROOMNAMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 489;
                // RegisterEvent( MYBRIDGE , SETCONNECTEDROOMNUMFEEDBACKCHANGE , HANDLECONNECTEDROOMNUMFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetConnectedRoomNumFeedbackChange  += HANDLECONNECTEDROOMNUMFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 490;
                // RegisterEvent( MYBRIDGE , SETCONNECTEDROOMINDEXFEEDBACKCHANGE , HANDLECONNECTEDROOMINDEXFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetConnectedRoomIndexFeedbackChange  += HANDLECONNECTEDROOMINDEXFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 492;
                // RegisterEvent( MYBRIDGE , SETROOMLISTSIZECHANGE , HANDLEROOMLISTSIZECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomListSizeChange  += HANDLEROOMLISTSIZECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 493;
                // RegisterEvent( MYBRIDGE , SETROOMLISTFEEDBACKCHANGE , HANDLEROOMLISTFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomListFeedbackChange  += HANDLEROOMLISTFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 495;
                // RegisterEvent( MYBRIDGE , SETSOURCELISTSIZECHANGE , HANDLESOURCELISTSIZECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceListSizeChange  += HANDLESOURCELISTSIZECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 496;
                // RegisterEvent( MYBRIDGE , SETSOURCELISTFEEDBACKCHANGE , HANDLESOURCELISTFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceListFeedbackChange  += HANDLESOURCELISTFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 497;
                // RegisterEvent( MYBRIDGE , SETSOURCELISTICONCHANGE , HANDLESOURCELISTICONCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceListIconChange  += HANDLESOURCELISTICONCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 498;
                // RegisterEvent( MYBRIDGE , SETSOURCEITEMINUSECHANGE , HANDLESOURCELISTINUSECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceItemInUseChange  += HANDLESOURCELISTINUSECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 500;
                // RegisterEvent( MYBRIDGE , SETROOMZONEONFEEDBACKCHANGE , HANDLEROOMZONEONFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomZoneOnFeedbackChange  += HANDLEROOMZONEONFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 501;
                // RegisterEvent( MYBRIDGE , SETROOMZONEOFFFEEDBACKCHANGE , HANDLEROOMZONEOFFFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomZoneOffFeedbackChange  += HANDLEROOMZONEOFFFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 502;
                // RegisterEvent( MYBRIDGE , SETROOMMUTEONFEEDBACKCHANGE , HANDLEROOMMUTEONFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomMuteOnFeedbackChange  += HANDLEROOMMUTEONFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 503;
                // RegisterEvent( MYBRIDGE , SETROOMVOLUMEFEEDBACKCHANGE , HANDLEROOMVOLUMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomVolumeFeedbackChange  += HANDLEROOMVOLUMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 504;
                // RegisterEvent( MYBRIDGE , SETROOMLISTSOURCEFEEDBACKCHANGE , HANDLEROOMLISTSOURCEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomListSourceFeedbackChange  += HANDLEROOMLISTSOURCEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 505;
                // RegisterEvent( MYBRIDGE , SETROOMSOURCEFEEDBACKCHANGE , HANDLEROOMSOURCEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomSourceFeedbackChange  += HANDLEROOMSOURCEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 506;
                // RegisterEvent( MYBRIDGE , SETROOMSOURCENAMEFEEDBACKCHANGE , HANDLEROOMSOURCENAMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomSourceNameFeedbackChange  += HANDLEROOMSOURCENAMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 508;
                // RegisterEvent( MYBRIDGE , SETPANELCONTROLSOURCEFEEDBACK , HANDLEPANELCONTROLSOURCEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetPanelControlSourceFeedback  += HANDLEPANELCONTROLSOURCEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 510;
                // RegisterEvent( MYBRIDGE , SETSOURCEQUICKDIGITALFEEDBACK , HANDLEQUICKSOURCEDIGITALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceQuickDigitalFeedback  += HANDLEQUICKSOURCEDIGITALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 511;
                // RegisterEvent( MYBRIDGE , SETSOURCEQUICKANALOGFEEDBACK , HANDLEQUICKSOURCEANALOGFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceQuickAnalogFeedback  += HANDLEQUICKSOURCEANALOGFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 512;
                // RegisterEvent( MYBRIDGE , SETSOURCEQUICKSERIALFEEDBACK , HANDLEQUICKSOURCESERIALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceQuickSerialFeedback  += HANDLEQUICKSOURCESERIALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 513;
                // RegisterEvent( MYBRIDGE , SETSOURCEQUICKCONTROLCOUNT , HANDLEQUICKSOURCECONTROLSCOUNT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetSourceQuickControlCount  += HANDLEQUICKSOURCECONTROLSCOUNT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 515;
                // RegisterEvent( MYBRIDGE , SETLIGHTINGQUICKDIGITALFEEDBACK , HANDLEQUICKLIGHTSDIGITALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetLightingQuickDigitalFeedback  += HANDLEQUICKLIGHTSDIGITALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 516;
                // RegisterEvent( MYBRIDGE , SETLIGHTINGQUICKSERIALFEEDBACK , HANDLEQUICKLIGHTSSERIALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetLightingQuickSerialFeedback  += HANDLEQUICKLIGHTSSERIALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 517;
                // RegisterEvent( MYBRIDGE , SETLIGHTINGQUICKCONTROLSCOUNT , HANDLEQUICKLIGHTSCONTROLSCOUNT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetLightingQuickControlsCount  += HANDLEQUICKLIGHTSCONTROLSCOUNT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 519;
                // RegisterEvent( MYBRIDGE , SETCLIMATEQUICKDIGITALFEEDBACK , HANDLEQUICKCLIMATEDIGITALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetClimateQuickDigitalFeedback  += HANDLEQUICKCLIMATEDIGITALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 520;
                // RegisterEvent( MYBRIDGE , SETCLIMATEQUICKSERIALFEEDBACK , HANDLEQUICKCLIMATESERIALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetClimateQuickSerialFeedback  += HANDLEQUICKCLIMATESERIALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 522;
                // RegisterEvent( MYBRIDGE , SETDOORLOCKQUICKDIGITALFEEDBACK , HANDLEQUICKDOORLOCKDIGITALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDoorlockQuickDigitalFeedback  += HANDLEQUICKDOORLOCKDIGITALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 523;
                // RegisterEvent( MYBRIDGE , SETDOORLOCKQUICKSERIALFEEDBACK , HANDLEQUICKDOORLOCKSERIALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDoorlockQuickSerialFeedback  += HANDLEQUICKDOORLOCKSERIALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 525;
                // RegisterEvent( MYBRIDGE , SETWINDOWSQUICKDIGITALFEEDBACK , HANDLEQUICKWINDOWSDIGITALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetWindowsQuickDigitalFeedback  += HANDLEQUICKWINDOWSDIGITALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 526;
                // RegisterEvent( MYBRIDGE , SETWINDOWSQUICKSERIALFEEDBACK , HANDLEQUICKWINDOWSSERIALFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetWindowsQuickSerialFeedback  += HANDLEQUICKWINDOWSSERIALFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 527;
                // RegisterEvent( MYBRIDGE , SETWINDOWSQUICKCONTROLSCOUNT , HANDLEQUICKWINDOWSCONTROLSCOUNT ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetWindowsQuickControlsCount  += HANDLEQUICKWINDOWSCONTROLSCOUNT; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 529;
                // RegisterEvent( MYBRIDGE , SETCAMERAQUICKURLFEEDBACK , HANDLEQUICKCAMERAURL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetCameraQuickUrlFeedback  += HANDLEQUICKCAMERAURL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 531;
                // RegisterEvent( MYBRIDGE , SETPAGEFLIPCHANGE , HANDLEPAGEFLIPCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetPageFlipChange  += HANDLEPAGEFLIPCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 532;
                // RegisterEvent( MYBRIDGE , SETDEVICESUBPAGECHANGE , HANDLEDEVICESUBPAGECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDeviceSubpageChange  += HANDLEDEVICESUBPAGECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 534;
                // RegisterEvent( MYBRIDGE , SETROOMHASAUDIO , HANDLEROOMHASAUDIOCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasAudio  += HANDLEROOMHASAUDIOCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 535;
                // RegisterEvent( MYBRIDGE , SETROOMHASDISPLAYS , HANDLEROOMHASDISPLAYSCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasDisplays  += HANDLEROOMHASDISPLAYSCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 536;
                // RegisterEvent( MYBRIDGE , SETROOMHASLIGHTING , HANDLEROOMHASLIGHTINGCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasLighting  += HANDLEROOMHASLIGHTINGCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 537;
                // RegisterEvent( MYBRIDGE , SETROOMHASCLIMATE , HANDLEROOMHASCLIMATECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasClimate  += HANDLEROOMHASCLIMATECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 538;
                // RegisterEvent( MYBRIDGE , SETROOMHASSECURITY , HANDLEROOMHASSECURITYCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasSecurity  += HANDLEROOMHASSECURITYCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 539;
                // RegisterEvent( MYBRIDGE , SETROOMHASCAMERAS , HANDLEROOMHASCAMERASCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasCameras  += HANDLEROOMHASCAMERASCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 540;
                // RegisterEvent( MYBRIDGE , SETROOMHASWINDOWS , HANDLEROOMHASWINDOWSCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasWindows  += HANDLEROOMHASWINDOWSCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 541;
                // RegisterEvent( MYBRIDGE , SETROOMHASDOORS , HANDLEROOMHASDOORSCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasDoors  += HANDLEROOMHASDOORSCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 543;
                // RegisterEvent( MYBRIDGE , SETDEMOEXPIREDCHANGE , HANDLEDEMOEXPIREDCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDemoExpiredChange  += HANDLEDEMOEXPIREDCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 545;
                // RegisterEvent( MYBRIDGE , SETHOMEPAGETYPECHANGE , HANDLEHOMEPAGETYPECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetHomePageTypeChange  += HANDLEHOMEPAGETYPECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 546;
                // RegisterEvent( MYBRIDGE , SETHOMEPAGEITEMSELECTED , HANDLENAVIGATIONITEMSELECTED ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetHomePageItemSelected  += HANDLENAVIGATIONITEMSELECTED; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 547;
                // RegisterEvent( MYBRIDGE , SETHOMEPAGETITLECHANGE , HANDLEHOMEPAGETITLECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetHomePageTitleChange  += HANDLEHOMEPAGETITLECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 548;
                // RegisterEvent( MYBRIDGE , SETHOMEPAGEITEMTEXTCHANGE , HANDLENAVIGATIONITEMTEXTCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetHomePageItemTextChange  += HANDLENAVIGATIONITEMTEXTCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 549;
                // RegisterEvent( MYBRIDGE , SETHOMEPAGEITEMICONCHANGE , HANDLENAVIGATIONITEMICONCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetHomePageItemIconChange  += HANDLENAVIGATIONITEMICONCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 550;
                // RegisterEvent( MYBRIDGE , SETHOMEPAGEITEMENABLECHANGE , HANDLENAVIGATIONITEMENABLECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetHomePageItemEnableChange  += HANDLENAVIGATIONITEMENABLECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 551;
                // RegisterEvent( MYBRIDGE , SETHOMEPAGEITEMVISIBLECHANGE , HANDLENAVIGATIONITEMVISIBLECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetHomePageItemVisibleChange  += HANDLENAVIGATIONITEMVISIBLECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 553;
                // RegisterEvent( MYBRIDGE , SETCONTROLLISTSIZECHANGE , HANDLECONTROLLISTSIZECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetControlListSizeChange  += HANDLECONTROLLISTSIZECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 554;
                // RegisterEvent( MYBRIDGE , SETCONTROLLISTDIGITALFEEDBACKCHANGE , HANDLECONTROLLISTDIGITALFEEDBACKCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetControlListDigitalFeedbackChange  += HANDLECONTROLLISTDIGITALFEEDBACKCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 555;
                // RegisterEvent( MYBRIDGE , SETCONTROLLISTSERIALFEEDBACKCHANGE , HANDLECONTROLLISTSERIALFEEDBACKCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetControlListSerialFeedbackChange  += HANDLECONTROLLISTSERIALFEEDBACKCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 557;
                // RegisterEvent( MYBRIDGE , SETLOCALDEVICESELECTEDCHANGE , HANDLELOCALDEVICESELECTEDCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetLocalDeviceSelectedChange  += HANDLELOCALDEVICESELECTEDCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 558;
                // RegisterEvent( MYBRIDGE , SETGLOBALDEVICESELECTEDCHANGE , HANDLEGLOBALDEVICESELECTEDCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetGlobalDeviceSelectedChange  += HANDLEGLOBALDEVICESELECTEDCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 560;
                // RegisterEvent( MYBRIDGE , SETALLOWROAMINGCHANGE , HANDLEALLOWROAMINGCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetAllowRoamingChange  += HANDLEALLOWROAMINGCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 561;
                // RegisterEvent( MYBRIDGE , SETALLOWGLOBALLIGHTSCHANGE , HANDLEALLOWGLOBALLIGHTSCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetAllowGlobalLightsChange  += HANDLEALLOWGLOBALLIGHTSCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 562;
                // RegisterEvent( MYBRIDGE , SETALLOWGLOBALCLIMATECHANGE , HANDLEALLOWGLOBALCLIMATECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetAllowGlobalClimateChange  += HANDLEALLOWGLOBALCLIMATECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 563;
                // RegisterEvent( MYBRIDGE , SETALLOWGLOBALSECURITYCHANGE , HANDLEALLOWGLOBALSECURITYCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetAllowGlobalSecurityChange  += HANDLEALLOWGLOBALSECURITYCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 564;
                // RegisterEvent( MYBRIDGE , SETALLOWGLOBALCAMERASCHANGE , HANDLEALLOWGLOBALCAMERASCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetAllowGlobalCamerasChange  += HANDLEALLOWGLOBALCAMERASCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 565;
                // RegisterEvent( MYBRIDGE , SETALLOWGLOBALWINDOWSCHANGE , HANDLEALLOWGLOBALWINDOWSCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetAllowGlobalWindowsChange  += HANDLEALLOWGLOBALWINDOWSCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 566;
                // RegisterEvent( MYBRIDGE , SETALLOWGLOBALDOORSCHANGE , HANDLEALLOWGLOBALDOORSCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetAllowGlobalDoorsChange  += HANDLEALLOWGLOBALDOORSCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 568;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSELECTFEEDBACK , HANDLEMULTIROOMSELECTFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomSelectFeedback  += HANDLEMULTIROOMSELECTFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 569;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMVOLUMEFEEDBACK , HANDLEMULTIROOMVOLUMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomVolumeFeedback  += HANDLEMULTIROOMVOLUMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 570;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMMODESELECTFEEDBACK , HANDLEMULTIROOMMODESELECTFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomModeSelectFeedback  += HANDLEMULTIROOMMODESELECTFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 571;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSHOWSOURCELIST , HANDLEMULTIROOMSHOWSOURCELIST ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomShowSourceList  += HANDLEMULTIROOMSHOWSOURCELIST; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 572;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSOURCELISTSIZECHANGE , HANDLEMULTIROOMSOURCELISTSIZECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomSourceListSizeChange  += HANDLEMULTIROOMSOURCELISTSIZECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 573;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSOURCELISTFEEDBACKCHANGE , HANDLEMULTIROOMSOURCELISTFEEDBACKCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomSourceListFeedbackChange  += HANDLEMULTIROOMSOURCELISTFEEDBACKCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 574;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSOURCELISTICONCHANGE , HANDLEMULTIROOMSOURCELISTICONCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomSourceListIconChange  += HANDLEMULTIROOMSOURCELISTICONCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 575;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSELECTEDSOURCENAME , HANDLEMULTIROOMSELECTEDSOURCENAME ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomSelectedSourceName  += HANDLEMULTIROOMSELECTEDSOURCENAME; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 576;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSELECTEDSOURCEINDEX , HANDLEMULTIROOMSELECTEDSOURCEINDEX ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomSelectedSourceIndex  += HANDLEMULTIROOMSELECTEDSOURCEINDEX; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 577;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMCONTROLNOWVISIBILITY , HANDLEMULTIROOMCONTROLNOWVISIBILITY ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomControlNowVisibility  += HANDLEMULTIROOMCONTROLNOWVISIBILITY; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 578;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSHOWSCENEEDITPOPUP , HANDLEMULTIROOMSHOWSCENEEDITPOPUP ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomShowSceneEditPopup  += HANDLEMULTIROOMSHOWSCENEEDITPOPUP; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 579;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSHOWSCENESAVEPOPUP , HANDLEMULTIROOMSHOWSCENESAVEPOPUP ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomShowSceneSavePopup  += HANDLEMULTIROOMSHOWSCENESAVEPOPUP; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 580;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSCENELISTSIZECHANGE , HANDLEMULTIROOMSCENELISTSIZECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomSceneListSizeChange  += HANDLEMULTIROOMSCENELISTSIZECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 581;
                // RegisterEvent( MYBRIDGE , SETMULTIROOMSCENENAMESLISTCHANGE , HANDLEMULTIROOMSCENENAMESLISTCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetMultiroomSceneNamesListChange  += HANDLEMULTIROOMSCENENAMESLISTCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 583;
                // RegisterEvent( MYBRIDGE , SETKEYBOARDCAPSLOCKFEEDBACK , HANDLEKEYBOARDCAPSLOCKFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetKeyboardCapsLockFeedback  += HANDLEKEYBOARDCAPSLOCKFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 584;
                // RegisterEvent( MYBRIDGE , SETKEYBOARDSHIFTFEEDBACK , HANDLEKEYBOARDSHIFTFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetKeyboardShiftFeedback  += HANDLEKEYBOARDSHIFTFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 585;
                // RegisterEvent( MYBRIDGE , SETKEYBOARDCURRENTTEXTFEEDBACK , HANDLEKEYBOARDCURRENTTEXTFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetKeyboardCurrentTextFeedback  += HANDLEKEYBOARDCURRENTTEXTFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 586;
                // RegisterEvent( MYBRIDGE , SETKEYBOARDSHIFTMODECHANGE , HANDLEKEYBOARDSHIFTMODECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetKeyboardShiftModeChange  += HANDLEKEYBOARDSHIFTMODECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 588;
                // RegisterEvent( MYBRIDGE , SETDEFAULTROOMNAMEFEEDBACK , HANDLEDEFAULTROOMNAMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDefaultRoomNameFeedback  += HANDLEDEFAULTROOMNAMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 589;
                // RegisterEvent( MYBRIDGE , SETDEFAULTROOMTIMEOUTFEEDBACK , HANDLEDEFAULTROOMTIMEOUTFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDefaultRoomTimeoutFeedback  += HANDLEDEFAULTROOMTIMEOUTFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 590;
                // RegisterEvent( MYBRIDGE , SETDEFAULTPAGENUMFEEDBACK , HANDLEDEFAULTPAGENUMFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDefaultPageNumFeedback  += HANDLEDEFAULTPAGENUMFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 591;
                // RegisterEvent( MYBRIDGE , SETDEFAULTPAGETIMEOUTFEEDBACK , HANDLEDEFAULTPAGETIMEOUTFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDefaultPageTimeoutFeedback  += HANDLEDEFAULTPAGETIMEOUTFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 593;
                // RegisterEvent( MYBRIDGE , SETOTHERDEVICENUMBERCHANGE , HANDLEOTHERDEVICENUMBERCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetOtherDeviceNumberChange  += HANDLEOTHERDEVICENUMBERCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 595;
                // RegisterEvent( MYBRIDGE , SETROOMHASMULTIPLEDISPLAYSFEEDBACK , HANDLEROOMHASMULTIPLEDISPLAYSFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomHasMultipleDisplaysFeedback  += HANDLEROOMHASMULTIPLEDISPLAYSFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 596;
                // RegisterEvent( MYBRIDGE , SETCAMERANAMESLISTFEEDBACK , HANDLECAMERANAMESLISTCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetCameraNamesListFeedback  += HANDLECAMERANAMESLISTCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 597;
                // RegisterEvent( MYBRIDGE , SETCAMERANAMESLISTSIZE , HANDLECAMERALISTSIZECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetCameraNamesListSize  += HANDLECAMERALISTSIZECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 598;
                // RegisterEvent( MYBRIDGE , SETCAMERASELECTEDFEEDBACK , HANDLECAMERASELECTEDFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetCameraSelectedFeedback  += HANDLECAMERASELECTEDFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 599;
                // RegisterEvent( MYBRIDGE , SETCAMERAVIDEOTYPECHANGE , HANDLECAMERAVIDEOTYPECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetCameraVideoTypeChange  += HANDLECAMERAVIDEOTYPECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 601;
                // RegisterEvent( MYBRIDGE , SETROOMDISPLAYSELECTEDFEEDBACK , HANDLEROOMDISPLAYSELECTEDFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomDisplaySelectedFeedback  += HANDLEROOMDISPLAYSELECTEDFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 602;
                // RegisterEvent( MYBRIDGE , SETROOMDISPLAYLISTSIZE , HANDLEROOMDISPLAYLISTSIZECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomDisplayListSize  += HANDLEROOMDISPLAYLISTSIZECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 603;
                // RegisterEvent( MYBRIDGE , SETROOMDISPLAYLISTITEMFEEDBACK , HANDLEROOMDISPLAYLISTITEMFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomDisplayListItemFeedback  += HANDLEROOMDISPLAYLISTITEMFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 604;
                // RegisterEvent( MYBRIDGE , SETROOMDISPLAYNAMESELECTEDFEEDBACK , HANDLEROOMDISPLAYNAMESELECTEDFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomDisplayNameSelectedFeedback  += HANDLEROOMDISPLAYNAMESELECTEDFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 605;
                // RegisterEvent( MYBRIDGE , SETSHOWSHAREBUTTONCHANGE , HANDLESHOWSHAREBUTTONCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetShowShareButtonChange  += HANDLESHOWSHAREBUTTONCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 608;
                // RegisterEvent( MYBRIDGE , SETDOORBELLMESSAGE , HANDLEDOORBELLMESSAGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDoorbellMessage  += HANDLEDOORBELLMESSAGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 609;
                // RegisterEvent( MYBRIDGE , SETDOORBELLCHIME , HANDLEDOORBELLCHIME ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDoorbellChime  += HANDLEDOORBELLCHIME; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 611;
                // RegisterEvent( MYBRIDGE , SETINTERCOMSTRINGTODIALCHANGE , HANDLEINTERCOMSTRINGTODIAL ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetIntercomStringToDialChange  += HANDLEINTERCOMSTRINGTODIAL; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 612;
                // RegisterEvent( MYBRIDGE , SETINTERCOMLISTITEMAVAILABLESTATUSCHANGE , HANDLEINTERCOMLISTITEMENABLE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetIntercomListItemAvailableStatusChange  += HANDLEINTERCOMLISTITEMENABLE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 613;
                // RegisterEvent( MYBRIDGE , SETINTERCOMLISTITEMONLINECHANGE , HANDLEINTERCOMLISTITEMVISIBLE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetIntercomListItemOnlineChange  += HANDLEINTERCOMLISTITEMVISIBLE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 614;
                // RegisterEvent( MYBRIDGE , SETINTERCOMLISTITEMTEXTCHANGE , HANDLEINTERCOMLISTNAMECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetIntercomListItemTextChange  += HANDLEINTERCOMLISTNAMECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 615;
                // RegisterEvent( MYBRIDGE , SETINTERCOMINCOMINGNAMECHANGE , HANDLEINTERCOMINCOMINGNAMECHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetIntercomIncomingNameChange  += HANDLEINTERCOMINCOMINGNAMECHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 616;
                // RegisterEvent( MYBRIDGE , SETINTERCOMHANGUPCHANGE , HANDLEINTERCOMHANGUPCHANGE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetIntercomHangupChange  += HANDLEINTERCOMHANGUPCHANGE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 617;
                // RegisterEvent( MYBRIDGE , SETDOORBELLINTERCOMVISIBLECHANGE , HANDLEDOORBELLINTERCOMVISIBLE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDoorbellIntercomVisibleChange  += HANDLEDOORBELLINTERCOMVISIBLE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 618;
                // RegisterEvent( MYBRIDGE , SETDOORBELLCAMERAVISIBLECHANGE , HANDLEDOORBELLCAMERAVISIBLE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDoorbellCameraVisibleChange  += HANDLEDOORBELLCAMERAVISIBLE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 619;
                // RegisterEvent( MYBRIDGE , SETDOORBELLCONTROLSVISIBLECHANGE , HANDLEDOORBELLCONTROLSVISIBLE ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetDoorbellControlsVisibleChange  += HANDLEDOORBELLCONTROLSVISIBLE; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 621;
                // RegisterEvent( MYBRIDGE , SETCURRENTAREANAMEFEEDBACK , HANDLECURRENTAREANAMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetCurrentAreaNameFeedback  += HANDLECURRENTAREANAMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 622;
                // RegisterEvent( MYBRIDGE , SETROOMLISTITEMENABLEFEEDBACK , HANDLEROOMLISTITEMENABLEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetRoomListItemEnableFeedback  += HANDLEROOMLISTITEMENABLEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 623;
                // RegisterEvent( MYBRIDGE , SETSHOWAREACONTROLSFEEDBACK , HANDLESHOWAREACONTROLSFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetShowAreaControlsFeedback  += HANDLESHOWAREACONTROLSFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 625;
                // RegisterEvent( MYBRIDGE , SETSHOWVOLUMEFEEDBACK , HANDLESHOWVOLUMEFEEDBACK ) 
                try { g_criticalSection.Enter(); MYBRIDGE .SetShowVolumeFeedback  += HANDLESHOWVOLUMEFEEDBACK; } finally { g_criticalSection.Leave(); }
                ; 
                __context__.SourceCodeLine = 626;
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
            
            __context__.SourceCodeLine = 629;
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
        
        __context__.SourceCodeLine = 630;
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
        
        __context__.SourceCodeLine = 632;
        MYBRIDGE . ActivityDetected ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ONLINE_OnChange_4 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 633;
        MYBRIDGE . SetOnlineStatus ( (ushort)( ONLINE  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONNECTED_TO_ADDRESS2_OnChange_5 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 634;
        MYBRIDGE . ConnectedFromOutsideNetwork ( (ushort)( CONNECTED_TO_ADDRESS2  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INTERCOM_ACTIVE_OnChange_6 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 636;
        MYBRIDGE . SetIntercomCallActive ( (ushort)( INTERCOM_ACTIVE  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INTERCOM_SELECT_OnChange_7 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 637;
        MYBRIDGE . IntercomItemSelect ( (ushort)( INTERCOM_SELECT  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INTERCOM_MY_URI_OnChange_8 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 638;
        MYBRIDGE . IntercomUri  =  ( INTERCOM_MY_URI  )  .ToString() ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object INTERCOM_INCOMING_URI_FB_OnChange_9 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 639;
        MYBRIDGE . SetIntercomIncomingUri ( INTERCOM_INCOMING_URI_FB .ToString()) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_LIST_INDEX_OnChange_10 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 641;
        MYBRIDGE . ConnectToRoomInList ( (ushort)( ROOM_LIST_INDEX  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_DIRECT_SELECT_OnChange_11 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 642;
        MYBRIDGE . ConnectToRoomDirect ( (ushort)( ROOM_DIRECT_SELECT  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCEQUICKCONTROL_OnChange_12 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 644;
        MYBRIDGE . SourceQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( SOURCEQUICKCONTROL[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTSQUICKCONTROL_OnChange_13 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 645;
        MYBRIDGE . LightingQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( LIGHTSQUICKCONTROL[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIMATEQUICKCONTROL_OnChange_14 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 646;
        MYBRIDGE . ClimateQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( CLIMATEQUICKCONTROL[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOORLOCKQUICKCONTROL_OnChange_15 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 647;
        MYBRIDGE . DoorlockQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( DOORLOCKQUICKCONTROL[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WINDOWSQUICKCONTROL_OnChange_16 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 648;
        MYBRIDGE . WindowsQuickControlChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( WINDOWSQUICKCONTROL[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object D_IN_OnChange_17 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 650;
        MYBRIDGE . DigitalInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( D_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object A_IN_OnChange_18 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 651;
        MYBRIDGE . AnalogInputChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( A_IN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_ON_OnChange_19 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 653;
        MYBRIDGE . ZoneOnControlChange ( (ushort)( ROOM_AV_ON  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_OFF_OnChange_20 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 654;
        MYBRIDGE . ZoneOffControlChange ( (ushort)( ROOM_AV_OFF  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_TOGGLE_OnChange_21 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 655;
        MYBRIDGE . ZoneToggleControlChange ( (ushort)( ROOM_AV_TOGGLE  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_VOLUME_UP_OnChange_22 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 656;
        MYBRIDGE . VolumeUpControlChange ( (ushort)( ROOM_AV_VOLUME_UP  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_VOLUME_DOWN_OnChange_23 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 657;
        MYBRIDGE . VolumeDownControlChange ( (ushort)( ROOM_AV_VOLUME_DOWN  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_MUTE_ON_OnChange_24 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 658;
        MYBRIDGE . MuteOnControlChange ( (ushort)( ROOM_AV_MUTE_ON  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_MUTE_OFF_OnChange_25 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 659;
        MYBRIDGE . MuteOffControlChange ( (ushort)( ROOM_AV_MUTE_OFF  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_MUTE_TOGGLE_OnChange_26 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 660;
        MYBRIDGE . MuteToggleControlChange ( (ushort)( ROOM_AV_MUTE_TOGGLE  .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object OTHER_ROOMS_OFF_OnPush_27 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 662;
        MYBRIDGE . OtherRoomsOffChange ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ALL_ROOMS_OFF_OnPush_28 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 663;
        MYBRIDGE . AllRoomsOffChange ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_OFF_BTN_OnPush_29 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 664;
        MYBRIDGE . AreaOff ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_VOLUME_OnChange_30 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 666;
        MYBRIDGE . VolumeValueControlChange ( (ushort)( ROOM_AV_VOLUME  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_LIST_SOURCE_OnChange_31 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 667;
        MYBRIDGE . SourceListSelect ( (ushort)( ROOM_AV_LIST_SOURCE  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object ROOM_AV_DIRECT_SOURCE_OnChange_32 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 668;
        MYBRIDGE . SourceDirectChange ( (ushort)( ROOM_AV_DIRECT_SOURCE  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SOURCE_LIST_MODE_OnChange_33 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 670;
        MYBRIDGE . SourceListMode = (ushort) ( SOURCE_LIST_MODE  .UshortValue ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SELECT_PAGE_DEVICE_OnChange_34 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 671;
        MYBRIDGE . SelectDeviceOnPage ( (ushort)( SELECT_PAGE_DEVICE  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DIRECT_OTHERDEVICE_SELECT_OnChange_35 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 672;
        MYBRIDGE . DirectOtherDeviceSelect ( (ushort)( DIRECT_OTHERDEVICE_SELECT  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object NAVIGATIONITEMCLICKED_OnChange_36 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 673;
        MYBRIDGE . HomePageItemSelect ( (ushort)( NAVIGATIONITEMCLICKED  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THROWPAGE_OnChange_37 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 674;
        MYBRIDGE . PageSelect ( (ushort)( THROWPAGE  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object THROWDEVICESUBPAGE_OnChange_38 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 675;
        MYBRIDGE . ThrowDeviceSubpage ( (ushort)( THROWDEVICESUBPAGE  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object BACK_BTN_OnPush_39 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 677;
        MYBRIDGE . BackButton ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object HOME_BTN_OnPush_40 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 678;
        MYBRIDGE . HomeSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MEDIA_BTN_OnPush_41 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 680;
        MYBRIDGE . MediaSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LIGHTS_BTN_OnPush_42 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 681;
        MYBRIDGE . LightingSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CLIMATE_BTN_OnPush_43 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 682;
        MYBRIDGE . ClimateSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SECURITY_BTN_OnPush_44 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 683;
        MYBRIDGE . SecuritySelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CAMERAS_BTN_OnPush_45 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 684;
        MYBRIDGE . CamerasSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object WINDOWS_BTN_OnPush_46 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 685;
        MYBRIDGE . WindowsSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOORS_BTN_OnPush_47 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 686;
        MYBRIDGE . DoorsSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object LOCAL_DEVICE_BTN_OnPush_48 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 688;
        MYBRIDGE . LocalDeviceSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object GLOBAL_DEVICE_BTN_OnPush_49 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 689;
        MYBRIDGE . GlobalDeviceSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CONTROL_LIST_BTN_OnChange_50 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 691;
        MYBRIDGE . ControlListItemChange ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ), (ushort)( CONTROL_LIST_BTN[ Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) ] .Value )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_SELECT_BTN_OnPush_51 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 693;
        MYBRIDGE . MultiroomRoomSelect ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_ZONE_OFF_BTN_OnPush_52 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 694;
        MYBRIDGE . MultiroomZoneOffControlChange ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_CLEAR_BTN_OnPush_53 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 695;
        MYBRIDGE . MultiroomClearSelections ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_SELECT_ALL_BTN_OnPush_54 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 696;
        MYBRIDGE . MultiroomSelectAll ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_VOLUME_IN_OnChange_55 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 697;
        MYBRIDGE . MultiroomVolumeControlChange ( (ushort)( MULTIROOM_VOLUME_IN  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_SOURCE_INDEX_OnChange_56 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 698;
        MYBRIDGE . MultiroomSourceControlChange ( (ushort)( MULTIROOM_SOURCE_INDEX  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_CONTROL_SOURCE_BTN_OnPush_57 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 699;
        MYBRIDGE . MultiroomControlSelectedSource ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_MODE_OnChange_58 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 700;
        MYBRIDGE . MultiroomModeSelect ( (ushort)( MULTIROOM_MODE  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_NEW_SCENE_BTN_OnPush_59 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 702;
        MYBRIDGE . MultiroomAddNewScene ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_REPLACE_SCENE_BTN_OnPush_60 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 703;
        MYBRIDGE . MultiroomReplaceScene ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MUTLIROOM_DELETE_SCENE_BTN_OnPush_61 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 704;
        MYBRIDGE . MultiroomDeleteScene ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_SCENE_RECALL_OnChange_62 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 706;
        MYBRIDGE . MultiroomSceneRecall ( (ushort)( MULTIROOM_SCENE_RECALL  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object MULTIROOM_SCENE_STORE_OnChange_63 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 707;
        MYBRIDGE . MultiroomSceneStore ( (ushort)( MULTIROOM_SCENE_STORE  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYBOARD_CLEAR_BTN_OnPush_64 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 709;
        MYBRIDGE . KeyboardClear ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYBOARD_BACKSPACE_BTN_OnPush_65 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 710;
        MYBRIDGE . KeyboardBackspace ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYBOARD_CAPS_LOCK_BTN_OnPush_66 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 711;
        MYBRIDGE . KeyboardCapsLockToggle ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYBOARD_SHIFT_BTN_OnPush_67 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 712;
        MYBRIDGE . KeyboardShiftToggle ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYBOARD_CHAR_BTN_OnPush_68 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 713;
        MYBRIDGE . KeyboardCharacter ( (ushort)( Functions.GetLastModifiedArrayIndex( __SignalEventArg__ ) )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYBOARD_SAVE_BTN_OnPush_69 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 714;
        MYBRIDGE . KeyboardSave ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object KEYBOARD_CANCEL_EDIT_BTN_OnPush_70 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 715;
        MYBRIDGE . KeyboardCancelEdit ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object SET_CURRENT_ROOM_TO_DEFAULT_OnPush_71 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 717;
        MYBRIDGE . SetDefaultRoomNum ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULT_ROOM_TIMEOUT_OnChange_72 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 718;
        MYBRIDGE . SetDefaultRoomTimeout ( (ushort)( DEFAULT_ROOM_TIMEOUT  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULT_PAGE_NUM_OnChange_73 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 719;
        MYBRIDGE . SetDefaultPageNum ( (ushort)( DEFAULT_PAGE_NUM  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DEFAULT_PAGE_TIMEOUT_OnChange_74 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 720;
        MYBRIDGE . SetDefaultPageTimeout ( (ushort)( DEFAULT_PAGE_TIMEOUT  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object CAMERA_SELECT_OnChange_75 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 722;
        MYBRIDGE . ViewCamera ( (ushort)( CAMERA_SELECT  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DISPLAY_SELECT_OnChange_76 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 724;
        MYBRIDGE . RoomDisplaySelect ( (ushort)( DISPLAY_SELECT  .UshortValue )) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object START_SHARE_MODE_OnPush_77 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 726;
        MYBRIDGE . EnableSourceShareMode ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object STOP_SHARE_MODE_OnPush_78 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 727;
        MYBRIDGE . DisableSourceShareMode ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOORBELL_CANCEL_THIS_ROOM_OnPush_79 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 729;
        MYBRIDGE . DoorbellCancelThisRoom ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOORBELL_CANCEL_ALL_OnPush_80 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 730;
        MYBRIDGE . DoorbellCancelAll ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOORBELL_ANSWER_OnPush_81 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 731;
        MYBRIDGE . DoorbellAnswer ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object DOORBELL_END_CALL_OnPush_82 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 732;
        MYBRIDGE . DoorbellEndCall ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_SELECT_NEXT_BTN_OnPush_83 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 734;
        MYBRIDGE . AreaNextSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_SELECT_PREV_BTN_OnPush_84 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 735;
        MYBRIDGE . AreaPreviousSelect ( ) ; 
        
        
    }
    catch(Exception e) { ObjectCatchHandler(e); }
    finally { ObjectFinallyHandler( __SignalEventArg__ ); }
    return this;
    
}

object AREA_SELECT_OnChange_85 ( Object __EventInfo__ )

    { 
    Crestron.Logos.SplusObjects.SignalEventArgs __SignalEventArg__ = (Crestron.Logos.SplusObjects.SignalEventArgs)__EventInfo__;
    try
    {
        SplusExecutionContext __context__ = SplusThreadStartCode(__SignalEventArg__);
        
        __context__.SourceCodeLine = 736;
        MYBRIDGE . AreaSelect ( (ushort)( AREA_SELECT  .UshortValue )) ; 
        
        
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
    
    ONLINE = new Crestron.Logos.SplusObjects.DigitalInput( ONLINE__DigitalInput__, this );
    m_DigitalInputList.Add( ONLINE__DigitalInput__, ONLINE );
    
    CONNECTED_TO_ADDRESS2 = new Crestron.Logos.SplusObjects.DigitalInput( CONNECTED_TO_ADDRESS2__DigitalInput__, this );
    m_DigitalInputList.Add( CONNECTED_TO_ADDRESS2__DigitalInput__, CONNECTED_TO_ADDRESS2 );
    
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
    
    OTHER_ROOMS_OFF = new Crestron.Logos.SplusObjects.DigitalInput( OTHER_ROOMS_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( OTHER_ROOMS_OFF__DigitalInput__, OTHER_ROOMS_OFF );
    
    ALL_ROOMS_OFF = new Crestron.Logos.SplusObjects.DigitalInput( ALL_ROOMS_OFF__DigitalInput__, this );
    m_DigitalInputList.Add( ALL_ROOMS_OFF__DigitalInput__, ALL_ROOMS_OFF );
    
    AREA_OFF_BTN = new Crestron.Logos.SplusObjects.DigitalInput( AREA_OFF_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_OFF_BTN__DigitalInput__, AREA_OFF_BTN );
    
    BACK_BTN = new Crestron.Logos.SplusObjects.DigitalInput( BACK_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( BACK_BTN__DigitalInput__, BACK_BTN );
    
    HOME_BTN = new Crestron.Logos.SplusObjects.DigitalInput( HOME_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( HOME_BTN__DigitalInput__, HOME_BTN );
    
    MEDIA_BTN = new Crestron.Logos.SplusObjects.DigitalInput( MEDIA_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( MEDIA_BTN__DigitalInput__, MEDIA_BTN );
    
    LIGHTS_BTN = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTS_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( LIGHTS_BTN__DigitalInput__, LIGHTS_BTN );
    
    CLIMATE_BTN = new Crestron.Logos.SplusObjects.DigitalInput( CLIMATE_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( CLIMATE_BTN__DigitalInput__, CLIMATE_BTN );
    
    SECURITY_BTN = new Crestron.Logos.SplusObjects.DigitalInput( SECURITY_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( SECURITY_BTN__DigitalInput__, SECURITY_BTN );
    
    CAMERAS_BTN = new Crestron.Logos.SplusObjects.DigitalInput( CAMERAS_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( CAMERAS_BTN__DigitalInput__, CAMERAS_BTN );
    
    WINDOWS_BTN = new Crestron.Logos.SplusObjects.DigitalInput( WINDOWS_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( WINDOWS_BTN__DigitalInput__, WINDOWS_BTN );
    
    DOORS_BTN = new Crestron.Logos.SplusObjects.DigitalInput( DOORS_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( DOORS_BTN__DigitalInput__, DOORS_BTN );
    
    LOCAL_DEVICE_BTN = new Crestron.Logos.SplusObjects.DigitalInput( LOCAL_DEVICE_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( LOCAL_DEVICE_BTN__DigitalInput__, LOCAL_DEVICE_BTN );
    
    GLOBAL_DEVICE_BTN = new Crestron.Logos.SplusObjects.DigitalInput( GLOBAL_DEVICE_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( GLOBAL_DEVICE_BTN__DigitalInput__, GLOBAL_DEVICE_BTN );
    
    MULTIROOM_ZONE_OFF_BTN = new Crestron.Logos.SplusObjects.DigitalInput( MULTIROOM_ZONE_OFF_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( MULTIROOM_ZONE_OFF_BTN__DigitalInput__, MULTIROOM_ZONE_OFF_BTN );
    
    MULTIROOM_CLEAR_BTN = new Crestron.Logos.SplusObjects.DigitalInput( MULTIROOM_CLEAR_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( MULTIROOM_CLEAR_BTN__DigitalInput__, MULTIROOM_CLEAR_BTN );
    
    MULTIROOM_SELECT_ALL_BTN = new Crestron.Logos.SplusObjects.DigitalInput( MULTIROOM_SELECT_ALL_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( MULTIROOM_SELECT_ALL_BTN__DigitalInput__, MULTIROOM_SELECT_ALL_BTN );
    
    MULTIROOM_CONTROL_SOURCE_BTN = new Crestron.Logos.SplusObjects.DigitalInput( MULTIROOM_CONTROL_SOURCE_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( MULTIROOM_CONTROL_SOURCE_BTN__DigitalInput__, MULTIROOM_CONTROL_SOURCE_BTN );
    
    MULTIROOM_NEW_SCENE_BTN = new Crestron.Logos.SplusObjects.DigitalInput( MULTIROOM_NEW_SCENE_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( MULTIROOM_NEW_SCENE_BTN__DigitalInput__, MULTIROOM_NEW_SCENE_BTN );
    
    MULTIROOM_REPLACE_SCENE_BTN = new Crestron.Logos.SplusObjects.DigitalInput( MULTIROOM_REPLACE_SCENE_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( MULTIROOM_REPLACE_SCENE_BTN__DigitalInput__, MULTIROOM_REPLACE_SCENE_BTN );
    
    MUTLIROOM_DELETE_SCENE_BTN = new Crestron.Logos.SplusObjects.DigitalInput( MUTLIROOM_DELETE_SCENE_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( MUTLIROOM_DELETE_SCENE_BTN__DigitalInput__, MUTLIROOM_DELETE_SCENE_BTN );
    
    KEYBOARD_CLEAR_BTN = new Crestron.Logos.SplusObjects.DigitalInput( KEYBOARD_CLEAR_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( KEYBOARD_CLEAR_BTN__DigitalInput__, KEYBOARD_CLEAR_BTN );
    
    KEYBOARD_BACKSPACE_BTN = new Crestron.Logos.SplusObjects.DigitalInput( KEYBOARD_BACKSPACE_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( KEYBOARD_BACKSPACE_BTN__DigitalInput__, KEYBOARD_BACKSPACE_BTN );
    
    KEYBOARD_CAPS_LOCK_BTN = new Crestron.Logos.SplusObjects.DigitalInput( KEYBOARD_CAPS_LOCK_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( KEYBOARD_CAPS_LOCK_BTN__DigitalInput__, KEYBOARD_CAPS_LOCK_BTN );
    
    KEYBOARD_SHIFT_BTN = new Crestron.Logos.SplusObjects.DigitalInput( KEYBOARD_SHIFT_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( KEYBOARD_SHIFT_BTN__DigitalInput__, KEYBOARD_SHIFT_BTN );
    
    KEYBOARD_SAVE_BTN = new Crestron.Logos.SplusObjects.DigitalInput( KEYBOARD_SAVE_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( KEYBOARD_SAVE_BTN__DigitalInput__, KEYBOARD_SAVE_BTN );
    
    KEYBOARD_CANCEL_EDIT_BTN = new Crestron.Logos.SplusObjects.DigitalInput( KEYBOARD_CANCEL_EDIT_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( KEYBOARD_CANCEL_EDIT_BTN__DigitalInput__, KEYBOARD_CANCEL_EDIT_BTN );
    
    SET_CURRENT_ROOM_TO_DEFAULT = new Crestron.Logos.SplusObjects.DigitalInput( SET_CURRENT_ROOM_TO_DEFAULT__DigitalInput__, this );
    m_DigitalInputList.Add( SET_CURRENT_ROOM_TO_DEFAULT__DigitalInput__, SET_CURRENT_ROOM_TO_DEFAULT );
    
    START_SHARE_MODE = new Crestron.Logos.SplusObjects.DigitalInput( START_SHARE_MODE__DigitalInput__, this );
    m_DigitalInputList.Add( START_SHARE_MODE__DigitalInput__, START_SHARE_MODE );
    
    STOP_SHARE_MODE = new Crestron.Logos.SplusObjects.DigitalInput( STOP_SHARE_MODE__DigitalInput__, this );
    m_DigitalInputList.Add( STOP_SHARE_MODE__DigitalInput__, STOP_SHARE_MODE );
    
    DOORBELL_CANCEL_THIS_ROOM = new Crestron.Logos.SplusObjects.DigitalInput( DOORBELL_CANCEL_THIS_ROOM__DigitalInput__, this );
    m_DigitalInputList.Add( DOORBELL_CANCEL_THIS_ROOM__DigitalInput__, DOORBELL_CANCEL_THIS_ROOM );
    
    DOORBELL_CANCEL_ALL = new Crestron.Logos.SplusObjects.DigitalInput( DOORBELL_CANCEL_ALL__DigitalInput__, this );
    m_DigitalInputList.Add( DOORBELL_CANCEL_ALL__DigitalInput__, DOORBELL_CANCEL_ALL );
    
    DOORBELL_ANSWER = new Crestron.Logos.SplusObjects.DigitalInput( DOORBELL_ANSWER__DigitalInput__, this );
    m_DigitalInputList.Add( DOORBELL_ANSWER__DigitalInput__, DOORBELL_ANSWER );
    
    DOORBELL_END_CALL = new Crestron.Logos.SplusObjects.DigitalInput( DOORBELL_END_CALL__DigitalInput__, this );
    m_DigitalInputList.Add( DOORBELL_END_CALL__DigitalInput__, DOORBELL_END_CALL );
    
    INTERCOM_ACTIVE = new Crestron.Logos.SplusObjects.DigitalInput( INTERCOM_ACTIVE__DigitalInput__, this );
    m_DigitalInputList.Add( INTERCOM_ACTIVE__DigitalInput__, INTERCOM_ACTIVE );
    
    AREA_SELECT_NEXT_BTN = new Crestron.Logos.SplusObjects.DigitalInput( AREA_SELECT_NEXT_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_SELECT_NEXT_BTN__DigitalInput__, AREA_SELECT_NEXT_BTN );
    
    AREA_SELECT_PREV_BTN = new Crestron.Logos.SplusObjects.DigitalInput( AREA_SELECT_PREV_BTN__DigitalInput__, this );
    m_DigitalInputList.Add( AREA_SELECT_PREV_BTN__DigitalInput__, AREA_SELECT_PREV_BTN );
    
    SOURCEQUICKCONTROL = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        SOURCEQUICKCONTROL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( SOURCEQUICKCONTROL__DigitalInput__ + i, SOURCEQUICKCONTROL__DigitalInput__, this );
        m_DigitalInputList.Add( SOURCEQUICKCONTROL__DigitalInput__ + i, SOURCEQUICKCONTROL[i+1] );
    }
    
    LIGHTSQUICKCONTROL = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        LIGHTSQUICKCONTROL[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( LIGHTSQUICKCONTROL__DigitalInput__ + i, LIGHTSQUICKCONTROL__DigitalInput__, this );
        m_DigitalInputList.Add( LIGHTSQUICKCONTROL__DigitalInput__ + i, LIGHTSQUICKCONTROL[i+1] );
    }
    
    CLIMATEQUICKCONTROL = new InOutArray<DigitalInput>( 12, this );
    for( uint i = 0; i < 12; i++ )
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
    
    D_IN = new InOutArray<DigitalInput>( 300, this );
    for( uint i = 0; i < 300; i++ )
    {
        D_IN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( D_IN__DigitalInput__ + i, D_IN__DigitalInput__, this );
        m_DigitalInputList.Add( D_IN__DigitalInput__ + i, D_IN[i+1] );
    }
    
    CONTROL_LIST_BTN = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        CONTROL_LIST_BTN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( CONTROL_LIST_BTN__DigitalInput__ + i, CONTROL_LIST_BTN__DigitalInput__, this );
        m_DigitalInputList.Add( CONTROL_LIST_BTN__DigitalInput__ + i, CONTROL_LIST_BTN[i+1] );
    }
    
    MULTIROOM_SELECT_BTN = new InOutArray<DigitalInput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        MULTIROOM_SELECT_BTN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( MULTIROOM_SELECT_BTN__DigitalInput__ + i, MULTIROOM_SELECT_BTN__DigitalInput__, this );
        m_DigitalInputList.Add( MULTIROOM_SELECT_BTN__DigitalInput__ + i, MULTIROOM_SELECT_BTN[i+1] );
    }
    
    KEYBOARD_CHAR_BTN = new InOutArray<DigitalInput>( 44, this );
    for( uint i = 0; i < 44; i++ )
    {
        KEYBOARD_CHAR_BTN[i+1] = new Crestron.Logos.SplusObjects.DigitalInput( KEYBOARD_CHAR_BTN__DigitalInput__ + i, KEYBOARD_CHAR_BTN__DigitalInput__, this );
        m_DigitalInputList.Add( KEYBOARD_CHAR_BTN__DigitalInput__ + i, KEYBOARD_CHAR_BTN[i+1] );
    }
    
    PANEL_BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( PANEL_BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( PANEL_BUSY__DigitalOutput__, PANEL_BUSY );
    
    ROOM_BUSY = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_BUSY__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_BUSY__DigitalOutput__, ROOM_BUSY );
    
    ROOM_AV_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_AV_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_AV_ON_FB__DigitalOutput__, ROOM_AV_ON_FB );
    
    ROOM_AV_OFF_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_AV_OFF_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_AV_OFF_FB__DigitalOutput__, ROOM_AV_OFF_FB );
    
    ROOM_AV_MUTE_ON_FB = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_AV_MUTE_ON_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_AV_MUTE_ON_FB__DigitalOutput__, ROOM_AV_MUTE_ON_FB );
    
    ROOM_HAS_AUDIO = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_HAS_AUDIO__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_HAS_AUDIO__DigitalOutput__, ROOM_HAS_AUDIO );
    
    ROOM_HAS_DISPLAYS = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_HAS_DISPLAYS__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_HAS_DISPLAYS__DigitalOutput__, ROOM_HAS_DISPLAYS );
    
    ROOM_HAS_LIGHTING = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_HAS_LIGHTING__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_HAS_LIGHTING__DigitalOutput__, ROOM_HAS_LIGHTING );
    
    ROOM_HAS_CLIMATE = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_HAS_CLIMATE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_HAS_CLIMATE__DigitalOutput__, ROOM_HAS_CLIMATE );
    
    ROOM_HAS_SECURITY = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_HAS_SECURITY__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_HAS_SECURITY__DigitalOutput__, ROOM_HAS_SECURITY );
    
    ROOM_HAS_CAMERAS = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_HAS_CAMERAS__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_HAS_CAMERAS__DigitalOutput__, ROOM_HAS_CAMERAS );
    
    ROOM_HAS_WINDOWS = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_HAS_WINDOWS__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_HAS_WINDOWS__DigitalOutput__, ROOM_HAS_WINDOWS );
    
    ROOM_HAS_DOORS = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_HAS_DOORS__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_HAS_DOORS__DigitalOutput__, ROOM_HAS_DOORS );
    
    DEMO_EXPIRED = new Crestron.Logos.SplusObjects.DigitalOutput( DEMO_EXPIRED__DigitalOutput__, this );
    m_DigitalOutputList.Add( DEMO_EXPIRED__DigitalOutput__, DEMO_EXPIRED );
    
    LOCAL_DEVICE_SELECTED = new Crestron.Logos.SplusObjects.DigitalOutput( LOCAL_DEVICE_SELECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( LOCAL_DEVICE_SELECTED__DigitalOutput__, LOCAL_DEVICE_SELECTED );
    
    GLOBAL_DEVICE_SELECTED = new Crestron.Logos.SplusObjects.DigitalOutput( GLOBAL_DEVICE_SELECTED__DigitalOutput__, this );
    m_DigitalOutputList.Add( GLOBAL_DEVICE_SELECTED__DigitalOutput__, GLOBAL_DEVICE_SELECTED );
    
    ALLOW_ROAMING = new Crestron.Logos.SplusObjects.DigitalOutput( ALLOW_ROAMING__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALLOW_ROAMING__DigitalOutput__, ALLOW_ROAMING );
    
    ALLOW_GLOBAL_LIGHTING = new Crestron.Logos.SplusObjects.DigitalOutput( ALLOW_GLOBAL_LIGHTING__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALLOW_GLOBAL_LIGHTING__DigitalOutput__, ALLOW_GLOBAL_LIGHTING );
    
    ALLOW_GLOBAL_CLIMATE = new Crestron.Logos.SplusObjects.DigitalOutput( ALLOW_GLOBAL_CLIMATE__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALLOW_GLOBAL_CLIMATE__DigitalOutput__, ALLOW_GLOBAL_CLIMATE );
    
    ALLOW_GLOBAL_SECURITY = new Crestron.Logos.SplusObjects.DigitalOutput( ALLOW_GLOBAL_SECURITY__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALLOW_GLOBAL_SECURITY__DigitalOutput__, ALLOW_GLOBAL_SECURITY );
    
    ALLOW_GLOBAL_CAMERAS = new Crestron.Logos.SplusObjects.DigitalOutput( ALLOW_GLOBAL_CAMERAS__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALLOW_GLOBAL_CAMERAS__DigitalOutput__, ALLOW_GLOBAL_CAMERAS );
    
    ALLOW_GLOBAL_WINDOWS = new Crestron.Logos.SplusObjects.DigitalOutput( ALLOW_GLOBAL_WINDOWS__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALLOW_GLOBAL_WINDOWS__DigitalOutput__, ALLOW_GLOBAL_WINDOWS );
    
    ALLOW_GLOBAL_DOORS = new Crestron.Logos.SplusObjects.DigitalOutput( ALLOW_GLOBAL_DOORS__DigitalOutput__, this );
    m_DigitalOutputList.Add( ALLOW_GLOBAL_DOORS__DigitalOutput__, ALLOW_GLOBAL_DOORS );
    
    MULTIROOM_SHOW_SOURCE_LIST = new Crestron.Logos.SplusObjects.DigitalOutput( MULTIROOM_SHOW_SOURCE_LIST__DigitalOutput__, this );
    m_DigitalOutputList.Add( MULTIROOM_SHOW_SOURCE_LIST__DigitalOutput__, MULTIROOM_SHOW_SOURCE_LIST );
    
    MULTIROOM_CONTROL_NOW_VISIBLE = new Crestron.Logos.SplusObjects.DigitalOutput( MULTIROOM_CONTROL_NOW_VISIBLE__DigitalOutput__, this );
    m_DigitalOutputList.Add( MULTIROOM_CONTROL_NOW_VISIBLE__DigitalOutput__, MULTIROOM_CONTROL_NOW_VISIBLE );
    
    MULTIROOM_SHOW_SCENE_EDIT_POPUP = new Crestron.Logos.SplusObjects.DigitalOutput( MULTIROOM_SHOW_SCENE_EDIT_POPUP__DigitalOutput__, this );
    m_DigitalOutputList.Add( MULTIROOM_SHOW_SCENE_EDIT_POPUP__DigitalOutput__, MULTIROOM_SHOW_SCENE_EDIT_POPUP );
    
    MULTIROOM_SHOW_SCENE_SAVE_POPUP = new Crestron.Logos.SplusObjects.DigitalOutput( MULTIROOM_SHOW_SCENE_SAVE_POPUP__DigitalOutput__, this );
    m_DigitalOutputList.Add( MULTIROOM_SHOW_SCENE_SAVE_POPUP__DigitalOutput__, MULTIROOM_SHOW_SCENE_SAVE_POPUP );
    
    KEYBOARD_CAPS_LOCK_FB = new Crestron.Logos.SplusObjects.DigitalOutput( KEYBOARD_CAPS_LOCK_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( KEYBOARD_CAPS_LOCK_FB__DigitalOutput__, KEYBOARD_CAPS_LOCK_FB );
    
    KEYBOARD_SHIFT_FB = new Crestron.Logos.SplusObjects.DigitalOutput( KEYBOARD_SHIFT_FB__DigitalOutput__, this );
    m_DigitalOutputList.Add( KEYBOARD_SHIFT_FB__DigitalOutput__, KEYBOARD_SHIFT_FB );
    
    ROOM_HAS_MULTIPLE_DISPLAYS = new Crestron.Logos.SplusObjects.DigitalOutput( ROOM_HAS_MULTIPLE_DISPLAYS__DigitalOutput__, this );
    m_DigitalOutputList.Add( ROOM_HAS_MULTIPLE_DISPLAYS__DigitalOutput__, ROOM_HAS_MULTIPLE_DISPLAYS );
    
    SHOW_SHARE_BUTTON = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_SHARE_BUTTON__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_SHARE_BUTTON__DigitalOutput__, SHOW_SHARE_BUTTON );
    
    INTERCOM_HANGUP = new Crestron.Logos.SplusObjects.DigitalOutput( INTERCOM_HANGUP__DigitalOutput__, this );
    m_DigitalOutputList.Add( INTERCOM_HANGUP__DigitalOutput__, INTERCOM_HANGUP );
    
    SHOW_DOORBELL_CAMERA = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_DOORBELL_CAMERA__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_DOORBELL_CAMERA__DigitalOutput__, SHOW_DOORBELL_CAMERA );
    
    SHOW_DOORBELL_INTERCOM = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_DOORBELL_INTERCOM__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_DOORBELL_INTERCOM__DigitalOutput__, SHOW_DOORBELL_INTERCOM );
    
    SHOW_DOORBELL_CONTROLS = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_DOORBELL_CONTROLS__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_DOORBELL_CONTROLS__DigitalOutput__, SHOW_DOORBELL_CONTROLS );
    
    SHOW_AREA_CONTROLS = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_AREA_CONTROLS__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_AREA_CONTROLS__DigitalOutput__, SHOW_AREA_CONTROLS );
    
    SHOW_VOLUME_FEEDBACK = new Crestron.Logos.SplusObjects.DigitalOutput( SHOW_VOLUME_FEEDBACK__DigitalOutput__, this );
    m_DigitalOutputList.Add( SHOW_VOLUME_FEEDBACK__DigitalOutput__, SHOW_VOLUME_FEEDBACK );
    
    D_OUT = new InOutArray<DigitalOutput>( 300, this );
    for( uint i = 0; i < 300; i++ )
    {
        D_OUT[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( D_OUT__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( D_OUT__DigitalOutput__ + i, D_OUT[i+1] );
    }
    
    SOURCE_LIST_IN_USE = new InOutArray<DigitalOutput>( 36, this );
    for( uint i = 0; i < 36; i++ )
    {
        SOURCE_LIST_IN_USE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( SOURCE_LIST_IN_USE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( SOURCE_LIST_IN_USE__DigitalOutput__ + i, SOURCE_LIST_IN_USE[i+1] );
    }
    
    QUICKSOURCE_D_FB = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        QUICKSOURCE_D_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICKSOURCE_D_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICKSOURCE_D_FB__DigitalOutput__ + i, QUICKSOURCE_D_FB[i+1] );
    }
    
    QUICKLIGHTS_D_FB = new InOutArray<DigitalOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICKLIGHTS_D_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICKLIGHTS_D_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICKLIGHTS_D_FB__DigitalOutput__ + i, QUICKLIGHTS_D_FB[i+1] );
    }
    
    QUICKCLIMATE_D_FB = new InOutArray<DigitalOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICKCLIMATE_D_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICKCLIMATE_D_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICKCLIMATE_D_FB__DigitalOutput__ + i, QUICKCLIMATE_D_FB[i+1] );
    }
    
    QUICKDOORLOCK_D_FB = new InOutArray<DigitalOutput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        QUICKDOORLOCK_D_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICKDOORLOCK_D_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICKDOORLOCK_D_FB__DigitalOutput__ + i, QUICKDOORLOCK_D_FB[i+1] );
    }
    
    QUICKWINDOWS_D_FB = new InOutArray<DigitalOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICKWINDOWS_D_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( QUICKWINDOWS_D_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( QUICKWINDOWS_D_FB__DigitalOutput__ + i, QUICKWINDOWS_D_FB[i+1] );
    }
    
    NAVIGATIONITEMENABLE = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        NAVIGATIONITEMENABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( NAVIGATIONITEMENABLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( NAVIGATIONITEMENABLE__DigitalOutput__ + i, NAVIGATIONITEMENABLE[i+1] );
    }
    
    NAVIGATIONITEMVISIBLE = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        NAVIGATIONITEMVISIBLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( NAVIGATIONITEMVISIBLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( NAVIGATIONITEMVISIBLE__DigitalOutput__ + i, NAVIGATIONITEMVISIBLE[i+1] );
    }
    
    CONTROLLISTDIGITAL_FB = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        CONTROLLISTDIGITAL_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( CONTROLLISTDIGITAL_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( CONTROLLISTDIGITAL_FB__DigitalOutput__ + i, CONTROLLISTDIGITAL_FB[i+1] );
    }
    
    MULTIROOM_SELECT_FB = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        MULTIROOM_SELECT_FB[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( MULTIROOM_SELECT_FB__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( MULTIROOM_SELECT_FB__DigitalOutput__ + i, MULTIROOM_SELECT_FB[i+1] );
    }
    
    INTERCOM_LIST_ENABLE = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        INTERCOM_LIST_ENABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( INTERCOM_LIST_ENABLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( INTERCOM_LIST_ENABLE__DigitalOutput__ + i, INTERCOM_LIST_ENABLE[i+1] );
    }
    
    INTERCOM_LIST_VISIBLE = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        INTERCOM_LIST_VISIBLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( INTERCOM_LIST_VISIBLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( INTERCOM_LIST_VISIBLE__DigitalOutput__ + i, INTERCOM_LIST_VISIBLE[i+1] );
    }
    
    DOORBELL_CHIME = new InOutArray<DigitalOutput>( 4, this );
    for( uint i = 0; i < 4; i++ )
    {
        DOORBELL_CHIME[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( DOORBELL_CHIME__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( DOORBELL_CHIME__DigitalOutput__ + i, DOORBELL_CHIME[i+1] );
    }
    
    ROOMLISTITEMENABLE = new InOutArray<DigitalOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        ROOMLISTITEMENABLE[i+1] = new Crestron.Logos.SplusObjects.DigitalOutput( ROOMLISTITEMENABLE__DigitalOutput__ + i, this );
        m_DigitalOutputList.Add( ROOMLISTITEMENABLE__DigitalOutput__ + i, ROOMLISTITEMENABLE[i+1] );
    }
    
    ROOM_AV_VOLUME = new Crestron.Logos.SplusObjects.AnalogInput( ROOM_AV_VOLUME__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOM_AV_VOLUME__AnalogSerialInput__, ROOM_AV_VOLUME );
    
    ROOM_AV_LIST_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ROOM_AV_LIST_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOM_AV_LIST_SOURCE__AnalogSerialInput__, ROOM_AV_LIST_SOURCE );
    
    ROOM_AV_DIRECT_SOURCE = new Crestron.Logos.SplusObjects.AnalogInput( ROOM_AV_DIRECT_SOURCE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOM_AV_DIRECT_SOURCE__AnalogSerialInput__, ROOM_AV_DIRECT_SOURCE );
    
    SOURCE_LIST_MODE = new Crestron.Logos.SplusObjects.AnalogInput( SOURCE_LIST_MODE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SOURCE_LIST_MODE__AnalogSerialInput__, SOURCE_LIST_MODE );
    
    ROOM_LIST_INDEX = new Crestron.Logos.SplusObjects.AnalogInput( ROOM_LIST_INDEX__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOM_LIST_INDEX__AnalogSerialInput__, ROOM_LIST_INDEX );
    
    ROOM_DIRECT_SELECT = new Crestron.Logos.SplusObjects.AnalogInput( ROOM_DIRECT_SELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( ROOM_DIRECT_SELECT__AnalogSerialInput__, ROOM_DIRECT_SELECT );
    
    THROWPAGE = new Crestron.Logos.SplusObjects.AnalogInput( THROWPAGE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( THROWPAGE__AnalogSerialInput__, THROWPAGE );
    
    THROWDEVICESUBPAGE = new Crestron.Logos.SplusObjects.AnalogInput( THROWDEVICESUBPAGE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( THROWDEVICESUBPAGE__AnalogSerialInput__, THROWDEVICESUBPAGE );
    
    SELECT_PAGE_DEVICE = new Crestron.Logos.SplusObjects.AnalogInput( SELECT_PAGE_DEVICE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( SELECT_PAGE_DEVICE__AnalogSerialInput__, SELECT_PAGE_DEVICE );
    
    DIRECT_OTHERDEVICE_SELECT = new Crestron.Logos.SplusObjects.AnalogInput( DIRECT_OTHERDEVICE_SELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DIRECT_OTHERDEVICE_SELECT__AnalogSerialInput__, DIRECT_OTHERDEVICE_SELECT );
    
    NAVIGATIONITEMCLICKED = new Crestron.Logos.SplusObjects.AnalogInput( NAVIGATIONITEMCLICKED__AnalogSerialInput__, this );
    m_AnalogInputList.Add( NAVIGATIONITEMCLICKED__AnalogSerialInput__, NAVIGATIONITEMCLICKED );
    
    MULTIROOM_VOLUME_IN = new Crestron.Logos.SplusObjects.AnalogInput( MULTIROOM_VOLUME_IN__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MULTIROOM_VOLUME_IN__AnalogSerialInput__, MULTIROOM_VOLUME_IN );
    
    MULTIROOM_SOURCE_INDEX = new Crestron.Logos.SplusObjects.AnalogInput( MULTIROOM_SOURCE_INDEX__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MULTIROOM_SOURCE_INDEX__AnalogSerialInput__, MULTIROOM_SOURCE_INDEX );
    
    MULTIROOM_MODE = new Crestron.Logos.SplusObjects.AnalogInput( MULTIROOM_MODE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MULTIROOM_MODE__AnalogSerialInput__, MULTIROOM_MODE );
    
    MULTIROOM_SCENE_RECALL = new Crestron.Logos.SplusObjects.AnalogInput( MULTIROOM_SCENE_RECALL__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MULTIROOM_SCENE_RECALL__AnalogSerialInput__, MULTIROOM_SCENE_RECALL );
    
    MULTIROOM_SCENE_STORE = new Crestron.Logos.SplusObjects.AnalogInput( MULTIROOM_SCENE_STORE__AnalogSerialInput__, this );
    m_AnalogInputList.Add( MULTIROOM_SCENE_STORE__AnalogSerialInput__, MULTIROOM_SCENE_STORE );
    
    CAMERA_SELECT = new Crestron.Logos.SplusObjects.AnalogInput( CAMERA_SELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( CAMERA_SELECT__AnalogSerialInput__, CAMERA_SELECT );
    
    DISPLAY_SELECT = new Crestron.Logos.SplusObjects.AnalogInput( DISPLAY_SELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DISPLAY_SELECT__AnalogSerialInput__, DISPLAY_SELECT );
    
    INTERCOM_SELECT = new Crestron.Logos.SplusObjects.AnalogInput( INTERCOM_SELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( INTERCOM_SELECT__AnalogSerialInput__, INTERCOM_SELECT );
    
    DEFAULT_ROOM_TIMEOUT = new Crestron.Logos.SplusObjects.AnalogInput( DEFAULT_ROOM_TIMEOUT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DEFAULT_ROOM_TIMEOUT__AnalogSerialInput__, DEFAULT_ROOM_TIMEOUT );
    
    DEFAULT_PAGE_NUM = new Crestron.Logos.SplusObjects.AnalogInput( DEFAULT_PAGE_NUM__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DEFAULT_PAGE_NUM__AnalogSerialInput__, DEFAULT_PAGE_NUM );
    
    DEFAULT_PAGE_TIMEOUT = new Crestron.Logos.SplusObjects.AnalogInput( DEFAULT_PAGE_TIMEOUT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( DEFAULT_PAGE_TIMEOUT__AnalogSerialInput__, DEFAULT_PAGE_TIMEOUT );
    
    AREA_SELECT = new Crestron.Logos.SplusObjects.AnalogInput( AREA_SELECT__AnalogSerialInput__, this );
    m_AnalogInputList.Add( AREA_SELECT__AnalogSerialInput__, AREA_SELECT );
    
    A_IN = new InOutArray<AnalogInput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        A_IN[i+1] = new Crestron.Logos.SplusObjects.AnalogInput( A_IN__AnalogSerialInput__ + i, A_IN__AnalogSerialInput__, this );
        m_AnalogInputList.Add( A_IN__AnalogSerialInput__ + i, A_IN[i+1] );
    }
    
    ROOM_AV_VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_AV_VOLUME_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_AV_VOLUME_FB__AnalogSerialOutput__, ROOM_AV_VOLUME_FB );
    
    ROOM_AV_LIST_SOURCE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_AV_LIST_SOURCE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_AV_LIST_SOURCE_FB__AnalogSerialOutput__, ROOM_AV_LIST_SOURCE_FB );
    
    ROOM_AV_DIRECT_SOURCE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_AV_DIRECT_SOURCE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_AV_DIRECT_SOURCE_FB__AnalogSerialOutput__, ROOM_AV_DIRECT_SOURCE_FB );
    
    PANEL_CONTROL_SOURCE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( PANEL_CONTROL_SOURCE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( PANEL_CONTROL_SOURCE_FB__AnalogSerialOutput__, PANEL_CONTROL_SOURCE_FB );
    
    OTHERDEVICE_CONNECTED_FB = new Crestron.Logos.SplusObjects.AnalogOutput( OTHERDEVICE_CONNECTED_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( OTHERDEVICE_CONNECTED_FB__AnalogSerialOutput__, OTHERDEVICE_CONNECTED_FB );
    
    GO_TO_PAGE = new Crestron.Logos.SplusObjects.AnalogOutput( GO_TO_PAGE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GO_TO_PAGE__AnalogSerialOutput__, GO_TO_PAGE );
    
    GO_TO_DEVICE_SUBPAGE = new Crestron.Logos.SplusObjects.AnalogOutput( GO_TO_DEVICE_SUBPAGE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( GO_TO_DEVICE_SUBPAGE__AnalogSerialOutput__, GO_TO_DEVICE_SUBPAGE );
    
    CONNECTED_ROOM_NUM_FB = new Crestron.Logos.SplusObjects.AnalogOutput( CONNECTED_ROOM_NUM_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONNECTED_ROOM_NUM_FB__AnalogSerialOutput__, CONNECTED_ROOM_NUM_FB );
    
    CONNECTED_ROOM_INDEX_FB = new Crestron.Logos.SplusObjects.AnalogOutput( CONNECTED_ROOM_INDEX_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONNECTED_ROOM_INDEX_FB__AnalogSerialOutput__, CONNECTED_ROOM_INDEX_FB );
    
    MEDIA_NUM_LINES = new Crestron.Logos.SplusObjects.AnalogOutput( MEDIA_NUM_LINES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MEDIA_NUM_LINES__AnalogSerialOutput__, MEDIA_NUM_LINES );
    
    ROOMS_NUM_LINES = new Crestron.Logos.SplusObjects.AnalogOutput( ROOMS_NUM_LINES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOMS_NUM_LINES__AnalogSerialOutput__, ROOMS_NUM_LINES );
    
    SOURCE_NUM_QUICK_CONTROLS = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCE_NUM_QUICK_CONTROLS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( SOURCE_NUM_QUICK_CONTROLS__AnalogSerialOutput__, SOURCE_NUM_QUICK_CONTROLS );
    
    LIGHTS_NUM_QUICK_CONTROLS = new Crestron.Logos.SplusObjects.AnalogOutput( LIGHTS_NUM_QUICK_CONTROLS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( LIGHTS_NUM_QUICK_CONTROLS__AnalogSerialOutput__, LIGHTS_NUM_QUICK_CONTROLS );
    
    WINDOWS_NUM_QUICK_CONTROLS = new Crestron.Logos.SplusObjects.AnalogOutput( WINDOWS_NUM_QUICK_CONTROLS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( WINDOWS_NUM_QUICK_CONTROLS__AnalogSerialOutput__, WINDOWS_NUM_QUICK_CONTROLS );
    
    HOME_PAGE_TYPE = new Crestron.Logos.SplusObjects.AnalogOutput( HOME_PAGE_TYPE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( HOME_PAGE_TYPE__AnalogSerialOutput__, HOME_PAGE_TYPE );
    
    NAVIGATIONITEMSELECTED = new Crestron.Logos.SplusObjects.AnalogOutput( NAVIGATIONITEMSELECTED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( NAVIGATIONITEMSELECTED__AnalogSerialOutput__, NAVIGATIONITEMSELECTED );
    
    CONTROLLISTNUMITEMS = new Crestron.Logos.SplusObjects.AnalogOutput( CONTROLLISTNUMITEMS__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CONTROLLISTNUMITEMS__AnalogSerialOutput__, CONTROLLISTNUMITEMS );
    
    MULTIROOM_VOLUME_FB = new Crestron.Logos.SplusObjects.AnalogOutput( MULTIROOM_VOLUME_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MULTIROOM_VOLUME_FB__AnalogSerialOutput__, MULTIROOM_VOLUME_FB );
    
    MULTIROOM_MODE_FB = new Crestron.Logos.SplusObjects.AnalogOutput( MULTIROOM_MODE_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MULTIROOM_MODE_FB__AnalogSerialOutput__, MULTIROOM_MODE_FB );
    
    MULTIROOM_SOURCE_LIST_SIZE = new Crestron.Logos.SplusObjects.AnalogOutput( MULTIROOM_SOURCE_LIST_SIZE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MULTIROOM_SOURCE_LIST_SIZE__AnalogSerialOutput__, MULTIROOM_SOURCE_LIST_SIZE );
    
    MULTIROOM_SOURCE_SELECTED_INDEX = new Crestron.Logos.SplusObjects.AnalogOutput( MULTIROOM_SOURCE_SELECTED_INDEX__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MULTIROOM_SOURCE_SELECTED_INDEX__AnalogSerialOutput__, MULTIROOM_SOURCE_SELECTED_INDEX );
    
    MULTIROOM_SCENE_LIST_SIZE = new Crestron.Logos.SplusObjects.AnalogOutput( MULTIROOM_SCENE_LIST_SIZE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( MULTIROOM_SCENE_LIST_SIZE__AnalogSerialOutput__, MULTIROOM_SCENE_LIST_SIZE );
    
    KEYBOARD_SHIFT_MODE = new Crestron.Logos.SplusObjects.AnalogOutput( KEYBOARD_SHIFT_MODE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( KEYBOARD_SHIFT_MODE__AnalogSerialOutput__, KEYBOARD_SHIFT_MODE );
    
    DEFAULT_ROOM_TIMEOUT_FB = new Crestron.Logos.SplusObjects.AnalogOutput( DEFAULT_ROOM_TIMEOUT_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DEFAULT_ROOM_TIMEOUT_FB__AnalogSerialOutput__, DEFAULT_ROOM_TIMEOUT_FB );
    
    DEFAULT_PAGE_NUM_FB = new Crestron.Logos.SplusObjects.AnalogOutput( DEFAULT_PAGE_NUM_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DEFAULT_PAGE_NUM_FB__AnalogSerialOutput__, DEFAULT_PAGE_NUM_FB );
    
    DEFAULT_PAGE_TIMEOUT_FB = new Crestron.Logos.SplusObjects.AnalogOutput( DEFAULT_PAGE_TIMEOUT_FB__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( DEFAULT_PAGE_TIMEOUT_FB__AnalogSerialOutput__, DEFAULT_PAGE_TIMEOUT_FB );
    
    CAMERA_SELECTED = new Crestron.Logos.SplusObjects.AnalogOutput( CAMERA_SELECTED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CAMERA_SELECTED__AnalogSerialOutput__, CAMERA_SELECTED );
    
    CAMERA_LIST_NUM_LINES = new Crestron.Logos.SplusObjects.AnalogOutput( CAMERA_LIST_NUM_LINES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CAMERA_LIST_NUM_LINES__AnalogSerialOutput__, CAMERA_LIST_NUM_LINES );
    
    CAMERA_VIDEO_TYPE = new Crestron.Logos.SplusObjects.AnalogOutput( CAMERA_VIDEO_TYPE__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( CAMERA_VIDEO_TYPE__AnalogSerialOutput__, CAMERA_VIDEO_TYPE );
    
    ROOM_DISPLAY_SELECTED = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_DISPLAY_SELECTED__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_DISPLAY_SELECTED__AnalogSerialOutput__, ROOM_DISPLAY_SELECTED );
    
    ROOM_DISPLAYS_NUM_LINES = new Crestron.Logos.SplusObjects.AnalogOutput( ROOM_DISPLAYS_NUM_LINES__AnalogSerialOutput__, this );
    m_AnalogOutputList.Add( ROOM_DISPLAYS_NUM_LINES__AnalogSerialOutput__, ROOM_DISPLAYS_NUM_LINES );
    
    A_OUT = new InOutArray<AnalogOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        A_OUT[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( A_OUT__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( A_OUT__AnalogSerialOutput__ + i, A_OUT[i+1] );
    }
    
    SOURCE_LIST_ICON = new InOutArray<AnalogOutput>( 36, this );
    for( uint i = 0; i < 36; i++ )
    {
        SOURCE_LIST_ICON[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( SOURCE_LIST_ICON__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( SOURCE_LIST_ICON__AnalogSerialOutput__ + i, SOURCE_LIST_ICON[i+1] );
    }
    
    QUICKSOURCE_A_FB = new InOutArray<AnalogOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        QUICKSOURCE_A_FB[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( QUICKSOURCE_A_FB__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( QUICKSOURCE_A_FB__AnalogSerialOutput__ + i, QUICKSOURCE_A_FB[i+1] );
    }
    
    NAVIGATIONITEMICON = new InOutArray<AnalogOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        NAVIGATIONITEMICON[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( NAVIGATIONITEMICON__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( NAVIGATIONITEMICON__AnalogSerialOutput__ + i, NAVIGATIONITEMICON[i+1] );
    }
    
    MULTIROOM_SOURCE_LIST_ICON = new InOutArray<AnalogOutput>( 36, this );
    for( uint i = 0; i < 36; i++ )
    {
        MULTIROOM_SOURCE_LIST_ICON[i+1] = new Crestron.Logos.SplusObjects.AnalogOutput( MULTIROOM_SOURCE_LIST_ICON__AnalogSerialOutput__ + i, this );
        m_AnalogOutputList.Add( MULTIROOM_SOURCE_LIST_ICON__AnalogSerialOutput__ + i, MULTIROOM_SOURCE_LIST_ICON[i+1] );
    }
    
    INTERCOM_MY_URI = new Crestron.Logos.SplusObjects.StringInput( INTERCOM_MY_URI__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( INTERCOM_MY_URI__AnalogSerialInput__, INTERCOM_MY_URI );
    
    INTERCOM_INCOMING_URI_FB = new Crestron.Logos.SplusObjects.StringInput( INTERCOM_INCOMING_URI_FB__AnalogSerialInput__, 100, this );
    m_StringInputList.Add( INTERCOM_INCOMING_URI_FB__AnalogSerialInput__, INTERCOM_INCOMING_URI_FB );
    
    CONNECTED_ROOM_NAME_FB = new Crestron.Logos.SplusObjects.StringOutput( CONNECTED_ROOM_NAME_FB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONNECTED_ROOM_NAME_FB__AnalogSerialOutput__, CONNECTED_ROOM_NAME_FB );
    
    QUICK_SOURCE_NAME_FB = new Crestron.Logos.SplusObjects.StringOutput( QUICK_SOURCE_NAME_FB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( QUICK_SOURCE_NAME_FB__AnalogSerialOutput__, QUICK_SOURCE_NAME_FB );
    
    CONNECTED_CONTROL_NAME_FB = new Crestron.Logos.SplusObjects.StringOutput( CONNECTED_CONTROL_NAME_FB__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CONNECTED_CONTROL_NAME_FB__AnalogSerialOutput__, CONNECTED_CONTROL_NAME_FB );
    
    HOME_PAGE_TITLE = new Crestron.Logos.SplusObjects.StringOutput( HOME_PAGE_TITLE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( HOME_PAGE_TITLE__AnalogSerialOutput__, HOME_PAGE_TITLE );
    
    MULTIROOM_SOURCE_NAME = new Crestron.Logos.SplusObjects.StringOutput( MULTIROOM_SOURCE_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( MULTIROOM_SOURCE_NAME__AnalogSerialOutput__, MULTIROOM_SOURCE_NAME );
    
    KEYBOARD_CURRENT_TEXT = new Crestron.Logos.SplusObjects.StringOutput( KEYBOARD_CURRENT_TEXT__AnalogSerialOutput__, this );
    m_StringOutputList.Add( KEYBOARD_CURRENT_TEXT__AnalogSerialOutput__, KEYBOARD_CURRENT_TEXT );
    
    DEFAULT_ROOM_NAME = new Crestron.Logos.SplusObjects.StringOutput( DEFAULT_ROOM_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DEFAULT_ROOM_NAME__AnalogSerialOutput__, DEFAULT_ROOM_NAME );
    
    QUICKCAMERAURL = new Crestron.Logos.SplusObjects.StringOutput( QUICKCAMERAURL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( QUICKCAMERAURL__AnalogSerialOutput__, QUICKCAMERAURL );
    
    ROOM_SELECTED_DISPLAY_NAME = new Crestron.Logos.SplusObjects.StringOutput( ROOM_SELECTED_DISPLAY_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( ROOM_SELECTED_DISPLAY_NAME__AnalogSerialOutput__, ROOM_SELECTED_DISPLAY_NAME );
    
    DOORBELL_MESSAGE = new Crestron.Logos.SplusObjects.StringOutput( DOORBELL_MESSAGE__AnalogSerialOutput__, this );
    m_StringOutputList.Add( DOORBELL_MESSAGE__AnalogSerialOutput__, DOORBELL_MESSAGE );
    
    INTERCOM_STRING_TO_DIAL = new Crestron.Logos.SplusObjects.StringOutput( INTERCOM_STRING_TO_DIAL__AnalogSerialOutput__, this );
    m_StringOutputList.Add( INTERCOM_STRING_TO_DIAL__AnalogSerialOutput__, INTERCOM_STRING_TO_DIAL );
    
    INTERCOM_INCOMING_NAME = new Crestron.Logos.SplusObjects.StringOutput( INTERCOM_INCOMING_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( INTERCOM_INCOMING_NAME__AnalogSerialOutput__, INTERCOM_INCOMING_NAME );
    
    CURRENT_AREA_NAME = new Crestron.Logos.SplusObjects.StringOutput( CURRENT_AREA_NAME__AnalogSerialOutput__, this );
    m_StringOutputList.Add( CURRENT_AREA_NAME__AnalogSerialOutput__, CURRENT_AREA_NAME );
    
    S_OUT = new InOutArray<StringOutput>( 100, this );
    for( uint i = 0; i < 100; i++ )
    {
        S_OUT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( S_OUT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( S_OUT__AnalogSerialOutput__ + i, S_OUT[i+1] );
    }
    
    SOURCE_LIST_TEXT = new InOutArray<StringOutput>( 36, this );
    for( uint i = 0; i < 36; i++ )
    {
        SOURCE_LIST_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( SOURCE_LIST_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( SOURCE_LIST_TEXT__AnalogSerialOutput__ + i, SOURCE_LIST_TEXT[i+1] );
    }
    
    ROOM_LIST_TEXT = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        ROOM_LIST_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ROOM_LIST_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ROOM_LIST_TEXT__AnalogSerialOutput__ + i, ROOM_LIST_TEXT[i+1] );
    }
    
    QUICKSOURCE_S_FB = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        QUICKSOURCE_S_FB[i+1] = new Crestron.Logos.SplusObjects.StringOutput( QUICKSOURCE_S_FB__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( QUICKSOURCE_S_FB__AnalogSerialOutput__ + i, QUICKSOURCE_S_FB[i+1] );
    }
    
    QUICKLIGHTS_S_FB = new InOutArray<StringOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICKLIGHTS_S_FB[i+1] = new Crestron.Logos.SplusObjects.StringOutput( QUICKLIGHTS_S_FB__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( QUICKLIGHTS_S_FB__AnalogSerialOutput__ + i, QUICKLIGHTS_S_FB[i+1] );
    }
    
    QUICKCLIMATE_S_FB = new InOutArray<StringOutput>( 4, this );
    for( uint i = 0; i < 4; i++ )
    {
        QUICKCLIMATE_S_FB[i+1] = new Crestron.Logos.SplusObjects.StringOutput( QUICKCLIMATE_S_FB__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( QUICKCLIMATE_S_FB__AnalogSerialOutput__ + i, QUICKCLIMATE_S_FB[i+1] );
    }
    
    QUICKDOORLOCK_S_FB = new InOutArray<StringOutput>( 2, this );
    for( uint i = 0; i < 2; i++ )
    {
        QUICKDOORLOCK_S_FB[i+1] = new Crestron.Logos.SplusObjects.StringOutput( QUICKDOORLOCK_S_FB__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( QUICKDOORLOCK_S_FB__AnalogSerialOutput__ + i, QUICKDOORLOCK_S_FB[i+1] );
    }
    
    QUICKWINDOWS_S_FB = new InOutArray<StringOutput>( 12, this );
    for( uint i = 0; i < 12; i++ )
    {
        QUICKWINDOWS_S_FB[i+1] = new Crestron.Logos.SplusObjects.StringOutput( QUICKWINDOWS_S_FB__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( QUICKWINDOWS_S_FB__AnalogSerialOutput__ + i, QUICKWINDOWS_S_FB[i+1] );
    }
    
    NAVIGATIONITEMTEXT = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        NAVIGATIONITEMTEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( NAVIGATIONITEMTEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( NAVIGATIONITEMTEXT__AnalogSerialOutput__ + i, NAVIGATIONITEMTEXT[i+1] );
    }
    
    CONTROLLISTSERIAL_FB = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        CONTROLLISTSERIAL_FB[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CONTROLLISTSERIAL_FB__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CONTROLLISTSERIAL_FB__AnalogSerialOutput__ + i, CONTROLLISTSERIAL_FB[i+1] );
    }
    
    MULTIROOM_SOURCE_LIST_TEXT = new InOutArray<StringOutput>( 36, this );
    for( uint i = 0; i < 36; i++ )
    {
        MULTIROOM_SOURCE_LIST_TEXT[i+1] = new Crestron.Logos.SplusObjects.StringOutput( MULTIROOM_SOURCE_LIST_TEXT__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( MULTIROOM_SOURCE_LIST_TEXT__AnalogSerialOutput__ + i, MULTIROOM_SOURCE_LIST_TEXT[i+1] );
    }
    
    MULTIROOM_SCENE_NAMES = new InOutArray<StringOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        MULTIROOM_SCENE_NAMES[i+1] = new Crestron.Logos.SplusObjects.StringOutput( MULTIROOM_SCENE_NAMES__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( MULTIROOM_SCENE_NAMES__AnalogSerialOutput__ + i, MULTIROOM_SCENE_NAMES[i+1] );
    }
    
    CAMERA_NAMES_LIST = new InOutArray<StringOutput>( 24, this );
    for( uint i = 0; i < 24; i++ )
    {
        CAMERA_NAMES_LIST[i+1] = new Crestron.Logos.SplusObjects.StringOutput( CAMERA_NAMES_LIST__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( CAMERA_NAMES_LIST__AnalogSerialOutput__ + i, CAMERA_NAMES_LIST[i+1] );
    }
    
    ROOM_DISPLAYS_LIST = new InOutArray<StringOutput>( 6, this );
    for( uint i = 0; i < 6; i++ )
    {
        ROOM_DISPLAYS_LIST[i+1] = new Crestron.Logos.SplusObjects.StringOutput( ROOM_DISPLAYS_LIST__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( ROOM_DISPLAYS_LIST__AnalogSerialOutput__ + i, ROOM_DISPLAYS_LIST[i+1] );
    }
    
    INTERCOM_NAMES_LIST = new InOutArray<StringOutput>( 50, this );
    for( uint i = 0; i < 50; i++ )
    {
        INTERCOM_NAMES_LIST[i+1] = new Crestron.Logos.SplusObjects.StringOutput( INTERCOM_NAMES_LIST__AnalogSerialOutput__ + i, this );
        m_StringOutputList.Add( INTERCOM_NAMES_LIST__AnalogSerialOutput__ + i, INTERCOM_NAMES_LIST[i+1] );
    }
    
    TP_ID = new UShortParameter( TP_ID__Parameter__, this );
    m_ParameterList.Add( TP_ID__Parameter__, TP_ID );
    
    DEFAULT_ROOM = new UShortParameter( DEFAULT_ROOM__Parameter__, this );
    m_ParameterList.Add( DEFAULT_ROOM__Parameter__, DEFAULT_ROOM );
    
    ACCESS_LEVEL = new UShortParameter( ACCESS_LEVEL__Parameter__, this );
    m_ParameterList.Add( ACCESS_LEVEL__Parameter__, ACCESS_LEVEL );
    
    DEFAULT_HOME_PAGE_TYPE = new UShortParameter( DEFAULT_HOME_PAGE_TYPE__Parameter__, this );
    m_ParameterList.Add( DEFAULT_HOME_PAGE_TYPE__Parameter__, DEFAULT_HOME_PAGE_TYPE );
    
    TP_NAME = new StringParameter( TP_NAME__Parameter__, this );
    m_ParameterList.Add( TP_NAME__Parameter__, TP_NAME );
    
    FILE_NAME = new StringParameter( FILE_NAME__Parameter__, this );
    m_ParameterList.Add( FILE_NAME__Parameter__, FILE_NAME );
    
    READ_AT_BOOTUP = new StringParameter( READ_AT_BOOTUP__Parameter__, this );
    m_ParameterList.Add( READ_AT_BOOTUP__Parameter__, READ_AT_BOOTUP );
    
    
    INIT.OnDigitalPush.Add( new InputChangeHandlerWrapper( INIT_OnPush_0, true ) );
    READ.OnDigitalPush.Add( new InputChangeHandlerWrapper( READ_OnPush_1, true ) );
    WRITE.OnDigitalPush.Add( new InputChangeHandlerWrapper( WRITE_OnPush_2, true ) );
    ACTIVITY_DETECTED.OnDigitalPush.Add( new InputChangeHandlerWrapper( ACTIVITY_DETECTED_OnPush_3, false ) );
    ONLINE.OnDigitalChange.Add( new InputChangeHandlerWrapper( ONLINE_OnChange_4, false ) );
    CONNECTED_TO_ADDRESS2.OnDigitalChange.Add( new InputChangeHandlerWrapper( CONNECTED_TO_ADDRESS2_OnChange_5, false ) );
    INTERCOM_ACTIVE.OnDigitalChange.Add( new InputChangeHandlerWrapper( INTERCOM_ACTIVE_OnChange_6, false ) );
    INTERCOM_SELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( INTERCOM_SELECT_OnChange_7, false ) );
    INTERCOM_MY_URI.OnSerialChange.Add( new InputChangeHandlerWrapper( INTERCOM_MY_URI_OnChange_8, false ) );
    INTERCOM_INCOMING_URI_FB.OnSerialChange.Add( new InputChangeHandlerWrapper( INTERCOM_INCOMING_URI_FB_OnChange_9, false ) );
    ROOM_LIST_INDEX.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOM_LIST_INDEX_OnChange_10, false ) );
    ROOM_DIRECT_SELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOM_DIRECT_SELECT_OnChange_11, false ) );
    for( uint i = 0; i < 50; i++ )
        SOURCEQUICKCONTROL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( SOURCEQUICKCONTROL_OnChange_12, false ) );
        
    for( uint i = 0; i < 12; i++ )
        LIGHTSQUICKCONTROL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( LIGHTSQUICKCONTROL_OnChange_13, false ) );
        
    for( uint i = 0; i < 12; i++ )
        CLIMATEQUICKCONTROL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( CLIMATEQUICKCONTROL_OnChange_14, false ) );
        
    for( uint i = 0; i < 2; i++ )
        DOORLOCKQUICKCONTROL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( DOORLOCKQUICKCONTROL_OnChange_15, false ) );
        
    for( uint i = 0; i < 12; i++ )
        WINDOWSQUICKCONTROL[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( WINDOWSQUICKCONTROL_OnChange_16, false ) );
        
    for( uint i = 0; i < 300; i++ )
        D_IN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( D_IN_OnChange_17, false ) );
        
    for( uint i = 0; i < 100; i++ )
        A_IN[i+1].OnAnalogChange.Add( new InputChangeHandlerWrapper( A_IN_OnChange_18, false ) );
        
    ROOM_AV_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_ON_OnChange_19, false ) );
    ROOM_AV_OFF.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_OFF_OnChange_20, false ) );
    ROOM_AV_TOGGLE.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_TOGGLE_OnChange_21, false ) );
    ROOM_AV_VOLUME_UP.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_VOLUME_UP_OnChange_22, false ) );
    ROOM_AV_VOLUME_DOWN.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_VOLUME_DOWN_OnChange_23, false ) );
    ROOM_AV_MUTE_ON.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_MUTE_ON_OnChange_24, false ) );
    ROOM_AV_MUTE_OFF.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_MUTE_OFF_OnChange_25, false ) );
    ROOM_AV_MUTE_TOGGLE.OnDigitalChange.Add( new InputChangeHandlerWrapper( ROOM_AV_MUTE_TOGGLE_OnChange_26, false ) );
    OTHER_ROOMS_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( OTHER_ROOMS_OFF_OnPush_27, false ) );
    ALL_ROOMS_OFF.OnDigitalPush.Add( new InputChangeHandlerWrapper( ALL_ROOMS_OFF_OnPush_28, false ) );
    AREA_OFF_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_OFF_BTN_OnPush_29, false ) );
    ROOM_AV_VOLUME.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOM_AV_VOLUME_OnChange_30, false ) );
    ROOM_AV_LIST_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOM_AV_LIST_SOURCE_OnChange_31, false ) );
    ROOM_AV_DIRECT_SOURCE.OnAnalogChange.Add( new InputChangeHandlerWrapper( ROOM_AV_DIRECT_SOURCE_OnChange_32, false ) );
    SOURCE_LIST_MODE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SOURCE_LIST_MODE_OnChange_33, false ) );
    SELECT_PAGE_DEVICE.OnAnalogChange.Add( new InputChangeHandlerWrapper( SELECT_PAGE_DEVICE_OnChange_34, false ) );
    DIRECT_OTHERDEVICE_SELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( DIRECT_OTHERDEVICE_SELECT_OnChange_35, false ) );
    NAVIGATIONITEMCLICKED.OnAnalogChange.Add( new InputChangeHandlerWrapper( NAVIGATIONITEMCLICKED_OnChange_36, false ) );
    THROWPAGE.OnAnalogChange.Add( new InputChangeHandlerWrapper( THROWPAGE_OnChange_37, false ) );
    THROWDEVICESUBPAGE.OnAnalogChange.Add( new InputChangeHandlerWrapper( THROWDEVICESUBPAGE_OnChange_38, false ) );
    BACK_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( BACK_BTN_OnPush_39, false ) );
    HOME_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( HOME_BTN_OnPush_40, false ) );
    MEDIA_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MEDIA_BTN_OnPush_41, false ) );
    LIGHTS_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( LIGHTS_BTN_OnPush_42, false ) );
    CLIMATE_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CLIMATE_BTN_OnPush_43, false ) );
    SECURITY_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( SECURITY_BTN_OnPush_44, false ) );
    CAMERAS_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( CAMERAS_BTN_OnPush_45, false ) );
    WINDOWS_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( WINDOWS_BTN_OnPush_46, false ) );
    DOORS_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( DOORS_BTN_OnPush_47, false ) );
    LOCAL_DEVICE_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( LOCAL_DEVICE_BTN_OnPush_48, false ) );
    GLOBAL_DEVICE_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( GLOBAL_DEVICE_BTN_OnPush_49, false ) );
    for( uint i = 0; i < 50; i++ )
        CONTROL_LIST_BTN[i+1].OnDigitalChange.Add( new InputChangeHandlerWrapper( CONTROL_LIST_BTN_OnChange_50, false ) );
        
    for( uint i = 0; i < 50; i++ )
        MULTIROOM_SELECT_BTN[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( MULTIROOM_SELECT_BTN_OnPush_51, false ) );
        
    MULTIROOM_ZONE_OFF_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MULTIROOM_ZONE_OFF_BTN_OnPush_52, false ) );
    MULTIROOM_CLEAR_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MULTIROOM_CLEAR_BTN_OnPush_53, false ) );
    MULTIROOM_SELECT_ALL_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MULTIROOM_SELECT_ALL_BTN_OnPush_54, false ) );
    MULTIROOM_VOLUME_IN.OnAnalogChange.Add( new InputChangeHandlerWrapper( MULTIROOM_VOLUME_IN_OnChange_55, false ) );
    MULTIROOM_SOURCE_INDEX.OnAnalogChange.Add( new InputChangeHandlerWrapper( MULTIROOM_SOURCE_INDEX_OnChange_56, false ) );
    MULTIROOM_CONTROL_SOURCE_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MULTIROOM_CONTROL_SOURCE_BTN_OnPush_57, false ) );
    MULTIROOM_MODE.OnAnalogChange.Add( new InputChangeHandlerWrapper( MULTIROOM_MODE_OnChange_58, false ) );
    MULTIROOM_NEW_SCENE_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MULTIROOM_NEW_SCENE_BTN_OnPush_59, false ) );
    MULTIROOM_REPLACE_SCENE_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MULTIROOM_REPLACE_SCENE_BTN_OnPush_60, false ) );
    MUTLIROOM_DELETE_SCENE_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( MUTLIROOM_DELETE_SCENE_BTN_OnPush_61, false ) );
    MULTIROOM_SCENE_RECALL.OnAnalogChange.Add( new InputChangeHandlerWrapper( MULTIROOM_SCENE_RECALL_OnChange_62, false ) );
    MULTIROOM_SCENE_STORE.OnAnalogChange.Add( new InputChangeHandlerWrapper( MULTIROOM_SCENE_STORE_OnChange_63, false ) );
    KEYBOARD_CLEAR_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYBOARD_CLEAR_BTN_OnPush_64, false ) );
    KEYBOARD_BACKSPACE_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYBOARD_BACKSPACE_BTN_OnPush_65, false ) );
    KEYBOARD_CAPS_LOCK_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYBOARD_CAPS_LOCK_BTN_OnPush_66, false ) );
    KEYBOARD_SHIFT_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYBOARD_SHIFT_BTN_OnPush_67, false ) );
    for( uint i = 0; i < 44; i++ )
        KEYBOARD_CHAR_BTN[i+1].OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYBOARD_CHAR_BTN_OnPush_68, false ) );
        
    KEYBOARD_SAVE_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYBOARD_SAVE_BTN_OnPush_69, false ) );
    KEYBOARD_CANCEL_EDIT_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( KEYBOARD_CANCEL_EDIT_BTN_OnPush_70, false ) );
    SET_CURRENT_ROOM_TO_DEFAULT.OnDigitalPush.Add( new InputChangeHandlerWrapper( SET_CURRENT_ROOM_TO_DEFAULT_OnPush_71, false ) );
    DEFAULT_ROOM_TIMEOUT.OnAnalogChange.Add( new InputChangeHandlerWrapper( DEFAULT_ROOM_TIMEOUT_OnChange_72, false ) );
    DEFAULT_PAGE_NUM.OnAnalogChange.Add( new InputChangeHandlerWrapper( DEFAULT_PAGE_NUM_OnChange_73, false ) );
    DEFAULT_PAGE_TIMEOUT.OnAnalogChange.Add( new InputChangeHandlerWrapper( DEFAULT_PAGE_TIMEOUT_OnChange_74, false ) );
    CAMERA_SELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( CAMERA_SELECT_OnChange_75, false ) );
    DISPLAY_SELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( DISPLAY_SELECT_OnChange_76, false ) );
    START_SHARE_MODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( START_SHARE_MODE_OnPush_77, false ) );
    STOP_SHARE_MODE.OnDigitalPush.Add( new InputChangeHandlerWrapper( STOP_SHARE_MODE_OnPush_78, false ) );
    DOORBELL_CANCEL_THIS_ROOM.OnDigitalPush.Add( new InputChangeHandlerWrapper( DOORBELL_CANCEL_THIS_ROOM_OnPush_79, false ) );
    DOORBELL_CANCEL_ALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( DOORBELL_CANCEL_ALL_OnPush_80, false ) );
    DOORBELL_ANSWER.OnDigitalPush.Add( new InputChangeHandlerWrapper( DOORBELL_ANSWER_OnPush_81, false ) );
    DOORBELL_END_CALL.OnDigitalPush.Add( new InputChangeHandlerWrapper( DOORBELL_END_CALL_OnPush_82, false ) );
    AREA_SELECT_NEXT_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_SELECT_NEXT_BTN_OnPush_83, false ) );
    AREA_SELECT_PREV_BTN.OnDigitalPush.Add( new InputChangeHandlerWrapper( AREA_SELECT_PREV_BTN_OnPush_84, false ) );
    AREA_SELECT.OnAnalogChange.Add( new InputChangeHandlerWrapper( AREA_SELECT_OnChange_85, false ) );
    
    _SplusNVRAM.PopulateCustomAttributeList( true );
    
    NVRAM = _SplusNVRAM;
    
}

public override void LogosSimplSharpInitialize()
{
    MYBRIDGE  = new AdaptCore.PD_TouchPanel();
    
    
}

public UserModuleClass__AS__TOUCHPANEL_V1_6_0 ( string InstanceName, string ReferenceID, Crestron.Logos.SplusObjects.CrestronStringEncoding nEncodingType ) : base( InstanceName, ReferenceID, nEncodingType ) {}




const uint INIT__DigitalInput__ = 0;
const uint READ__DigitalInput__ = 1;
const uint WRITE__DigitalInput__ = 2;
const uint ACTIVITY_DETECTED__DigitalInput__ = 3;
const uint ONLINE__DigitalInput__ = 4;
const uint CONNECTED_TO_ADDRESS2__DigitalInput__ = 5;
const uint ROOM_AV_ON__DigitalInput__ = 6;
const uint ROOM_AV_OFF__DigitalInput__ = 7;
const uint ROOM_AV_TOGGLE__DigitalInput__ = 8;
const uint ROOM_AV_VOLUME_UP__DigitalInput__ = 9;
const uint ROOM_AV_VOLUME_DOWN__DigitalInput__ = 10;
const uint ROOM_AV_MUTE_ON__DigitalInput__ = 11;
const uint ROOM_AV_MUTE_OFF__DigitalInput__ = 12;
const uint ROOM_AV_MUTE_TOGGLE__DigitalInput__ = 13;
const uint OTHER_ROOMS_OFF__DigitalInput__ = 14;
const uint ALL_ROOMS_OFF__DigitalInput__ = 15;
const uint AREA_OFF_BTN__DigitalInput__ = 16;
const uint BACK_BTN__DigitalInput__ = 17;
const uint HOME_BTN__DigitalInput__ = 18;
const uint MEDIA_BTN__DigitalInput__ = 19;
const uint LIGHTS_BTN__DigitalInput__ = 20;
const uint CLIMATE_BTN__DigitalInput__ = 21;
const uint SECURITY_BTN__DigitalInput__ = 22;
const uint CAMERAS_BTN__DigitalInput__ = 23;
const uint WINDOWS_BTN__DigitalInput__ = 24;
const uint DOORS_BTN__DigitalInput__ = 25;
const uint LOCAL_DEVICE_BTN__DigitalInput__ = 26;
const uint GLOBAL_DEVICE_BTN__DigitalInput__ = 27;
const uint MULTIROOM_ZONE_OFF_BTN__DigitalInput__ = 28;
const uint MULTIROOM_CLEAR_BTN__DigitalInput__ = 29;
const uint MULTIROOM_SELECT_ALL_BTN__DigitalInput__ = 30;
const uint MULTIROOM_CONTROL_SOURCE_BTN__DigitalInput__ = 31;
const uint MULTIROOM_NEW_SCENE_BTN__DigitalInput__ = 32;
const uint MULTIROOM_REPLACE_SCENE_BTN__DigitalInput__ = 33;
const uint MUTLIROOM_DELETE_SCENE_BTN__DigitalInput__ = 34;
const uint KEYBOARD_CLEAR_BTN__DigitalInput__ = 35;
const uint KEYBOARD_BACKSPACE_BTN__DigitalInput__ = 36;
const uint KEYBOARD_CAPS_LOCK_BTN__DigitalInput__ = 37;
const uint KEYBOARD_SHIFT_BTN__DigitalInput__ = 38;
const uint KEYBOARD_SAVE_BTN__DigitalInput__ = 39;
const uint KEYBOARD_CANCEL_EDIT_BTN__DigitalInput__ = 40;
const uint SET_CURRENT_ROOM_TO_DEFAULT__DigitalInput__ = 41;
const uint START_SHARE_MODE__DigitalInput__ = 42;
const uint STOP_SHARE_MODE__DigitalInput__ = 43;
const uint DOORBELL_CANCEL_THIS_ROOM__DigitalInput__ = 44;
const uint DOORBELL_CANCEL_ALL__DigitalInput__ = 45;
const uint DOORBELL_ANSWER__DigitalInput__ = 46;
const uint DOORBELL_END_CALL__DigitalInput__ = 47;
const uint ROOM_AV_VOLUME__AnalogSerialInput__ = 0;
const uint ROOM_AV_LIST_SOURCE__AnalogSerialInput__ = 1;
const uint ROOM_AV_DIRECT_SOURCE__AnalogSerialInput__ = 2;
const uint SOURCE_LIST_MODE__AnalogSerialInput__ = 3;
const uint ROOM_LIST_INDEX__AnalogSerialInput__ = 4;
const uint ROOM_DIRECT_SELECT__AnalogSerialInput__ = 5;
const uint THROWPAGE__AnalogSerialInput__ = 6;
const uint THROWDEVICESUBPAGE__AnalogSerialInput__ = 7;
const uint SELECT_PAGE_DEVICE__AnalogSerialInput__ = 8;
const uint DIRECT_OTHERDEVICE_SELECT__AnalogSerialInput__ = 9;
const uint NAVIGATIONITEMCLICKED__AnalogSerialInput__ = 10;
const uint MULTIROOM_VOLUME_IN__AnalogSerialInput__ = 11;
const uint MULTIROOM_SOURCE_INDEX__AnalogSerialInput__ = 12;
const uint MULTIROOM_MODE__AnalogSerialInput__ = 13;
const uint MULTIROOM_SCENE_RECALL__AnalogSerialInput__ = 14;
const uint MULTIROOM_SCENE_STORE__AnalogSerialInput__ = 15;
const uint CAMERA_SELECT__AnalogSerialInput__ = 16;
const uint DISPLAY_SELECT__AnalogSerialInput__ = 17;
const uint INTERCOM_ACTIVE__DigitalInput__ = 48;
const uint INTERCOM_SELECT__AnalogSerialInput__ = 18;
const uint INTERCOM_MY_URI__AnalogSerialInput__ = 19;
const uint INTERCOM_INCOMING_URI_FB__AnalogSerialInput__ = 20;
const uint DEFAULT_ROOM_TIMEOUT__AnalogSerialInput__ = 21;
const uint DEFAULT_PAGE_NUM__AnalogSerialInput__ = 22;
const uint DEFAULT_PAGE_TIMEOUT__AnalogSerialInput__ = 23;
const uint AREA_SELECT_NEXT_BTN__DigitalInput__ = 49;
const uint AREA_SELECT_PREV_BTN__DigitalInput__ = 50;
const uint AREA_SELECT__AnalogSerialInput__ = 24;
const uint SOURCEQUICKCONTROL__DigitalInput__ = 51;
const uint LIGHTSQUICKCONTROL__DigitalInput__ = 101;
const uint CLIMATEQUICKCONTROL__DigitalInput__ = 113;
const uint DOORLOCKQUICKCONTROL__DigitalInput__ = 125;
const uint WINDOWSQUICKCONTROL__DigitalInput__ = 127;
const uint D_IN__DigitalInput__ = 139;
const uint CONTROL_LIST_BTN__DigitalInput__ = 439;
const uint MULTIROOM_SELECT_BTN__DigitalInput__ = 489;
const uint KEYBOARD_CHAR_BTN__DigitalInput__ = 539;
const uint A_IN__AnalogSerialInput__ = 25;
const uint PANEL_BUSY__DigitalOutput__ = 0;
const uint ROOM_BUSY__DigitalOutput__ = 1;
const uint ROOM_AV_ON_FB__DigitalOutput__ = 2;
const uint ROOM_AV_OFF_FB__DigitalOutput__ = 3;
const uint ROOM_AV_MUTE_ON_FB__DigitalOutput__ = 4;
const uint ROOM_HAS_AUDIO__DigitalOutput__ = 5;
const uint ROOM_HAS_DISPLAYS__DigitalOutput__ = 6;
const uint ROOM_HAS_LIGHTING__DigitalOutput__ = 7;
const uint ROOM_HAS_CLIMATE__DigitalOutput__ = 8;
const uint ROOM_HAS_SECURITY__DigitalOutput__ = 9;
const uint ROOM_HAS_CAMERAS__DigitalOutput__ = 10;
const uint ROOM_HAS_WINDOWS__DigitalOutput__ = 11;
const uint ROOM_HAS_DOORS__DigitalOutput__ = 12;
const uint DEMO_EXPIRED__DigitalOutput__ = 13;
const uint LOCAL_DEVICE_SELECTED__DigitalOutput__ = 14;
const uint GLOBAL_DEVICE_SELECTED__DigitalOutput__ = 15;
const uint ALLOW_ROAMING__DigitalOutput__ = 16;
const uint ALLOW_GLOBAL_LIGHTING__DigitalOutput__ = 17;
const uint ALLOW_GLOBAL_CLIMATE__DigitalOutput__ = 18;
const uint ALLOW_GLOBAL_SECURITY__DigitalOutput__ = 19;
const uint ALLOW_GLOBAL_CAMERAS__DigitalOutput__ = 20;
const uint ALLOW_GLOBAL_WINDOWS__DigitalOutput__ = 21;
const uint ALLOW_GLOBAL_DOORS__DigitalOutput__ = 22;
const uint ROOM_AV_VOLUME_FB__AnalogSerialOutput__ = 0;
const uint ROOM_AV_LIST_SOURCE_FB__AnalogSerialOutput__ = 1;
const uint ROOM_AV_DIRECT_SOURCE_FB__AnalogSerialOutput__ = 2;
const uint PANEL_CONTROL_SOURCE_FB__AnalogSerialOutput__ = 3;
const uint OTHERDEVICE_CONNECTED_FB__AnalogSerialOutput__ = 4;
const uint GO_TO_PAGE__AnalogSerialOutput__ = 5;
const uint GO_TO_DEVICE_SUBPAGE__AnalogSerialOutput__ = 6;
const uint CONNECTED_ROOM_NUM_FB__AnalogSerialOutput__ = 7;
const uint CONNECTED_ROOM_INDEX_FB__AnalogSerialOutput__ = 8;
const uint MEDIA_NUM_LINES__AnalogSerialOutput__ = 9;
const uint ROOMS_NUM_LINES__AnalogSerialOutput__ = 10;
const uint SOURCE_NUM_QUICK_CONTROLS__AnalogSerialOutput__ = 11;
const uint LIGHTS_NUM_QUICK_CONTROLS__AnalogSerialOutput__ = 12;
const uint WINDOWS_NUM_QUICK_CONTROLS__AnalogSerialOutput__ = 13;
const uint HOME_PAGE_TYPE__AnalogSerialOutput__ = 14;
const uint NAVIGATIONITEMSELECTED__AnalogSerialOutput__ = 15;
const uint CONTROLLISTNUMITEMS__AnalogSerialOutput__ = 16;
const uint CONNECTED_ROOM_NAME_FB__AnalogSerialOutput__ = 17;
const uint QUICK_SOURCE_NAME_FB__AnalogSerialOutput__ = 18;
const uint CONNECTED_CONTROL_NAME_FB__AnalogSerialOutput__ = 19;
const uint HOME_PAGE_TITLE__AnalogSerialOutput__ = 20;
const uint MULTIROOM_SHOW_SOURCE_LIST__DigitalOutput__ = 23;
const uint MULTIROOM_CONTROL_NOW_VISIBLE__DigitalOutput__ = 24;
const uint MULTIROOM_VOLUME_FB__AnalogSerialOutput__ = 21;
const uint MULTIROOM_MODE_FB__AnalogSerialOutput__ = 22;
const uint MULTIROOM_SOURCE_LIST_SIZE__AnalogSerialOutput__ = 23;
const uint MULTIROOM_SOURCE_SELECTED_INDEX__AnalogSerialOutput__ = 24;
const uint MULTIROOM_SOURCE_NAME__AnalogSerialOutput__ = 25;
const uint MULTIROOM_SHOW_SCENE_EDIT_POPUP__DigitalOutput__ = 25;
const uint MULTIROOM_SHOW_SCENE_SAVE_POPUP__DigitalOutput__ = 26;
const uint MULTIROOM_SCENE_LIST_SIZE__AnalogSerialOutput__ = 26;
const uint KEYBOARD_CAPS_LOCK_FB__DigitalOutput__ = 27;
const uint KEYBOARD_SHIFT_FB__DigitalOutput__ = 28;
const uint KEYBOARD_SHIFT_MODE__AnalogSerialOutput__ = 27;
const uint KEYBOARD_CURRENT_TEXT__AnalogSerialOutput__ = 28;
const uint DEFAULT_ROOM_NAME__AnalogSerialOutput__ = 29;
const uint DEFAULT_ROOM_TIMEOUT_FB__AnalogSerialOutput__ = 30;
const uint DEFAULT_PAGE_NUM_FB__AnalogSerialOutput__ = 31;
const uint DEFAULT_PAGE_TIMEOUT_FB__AnalogSerialOutput__ = 32;
const uint QUICKCAMERAURL__AnalogSerialOutput__ = 33;
const uint CAMERA_SELECTED__AnalogSerialOutput__ = 34;
const uint CAMERA_LIST_NUM_LINES__AnalogSerialOutput__ = 35;
const uint CAMERA_VIDEO_TYPE__AnalogSerialOutput__ = 36;
const uint ROOM_HAS_MULTIPLE_DISPLAYS__DigitalOutput__ = 29;
const uint ROOM_DISPLAY_SELECTED__AnalogSerialOutput__ = 37;
const uint ROOM_DISPLAYS_NUM_LINES__AnalogSerialOutput__ = 38;
const uint ROOM_SELECTED_DISPLAY_NAME__AnalogSerialOutput__ = 39;
const uint SHOW_SHARE_BUTTON__DigitalOutput__ = 30;
const uint INTERCOM_HANGUP__DigitalOutput__ = 31;
const uint DOORBELL_MESSAGE__AnalogSerialOutput__ = 40;
const uint SHOW_DOORBELL_CAMERA__DigitalOutput__ = 32;
const uint SHOW_DOORBELL_INTERCOM__DigitalOutput__ = 33;
const uint SHOW_DOORBELL_CONTROLS__DigitalOutput__ = 34;
const uint INTERCOM_STRING_TO_DIAL__AnalogSerialOutput__ = 41;
const uint INTERCOM_INCOMING_NAME__AnalogSerialOutput__ = 42;
const uint SHOW_AREA_CONTROLS__DigitalOutput__ = 35;
const uint CURRENT_AREA_NAME__AnalogSerialOutput__ = 43;
const uint SHOW_VOLUME_FEEDBACK__DigitalOutput__ = 36;
const uint D_OUT__DigitalOutput__ = 37;
const uint A_OUT__AnalogSerialOutput__ = 44;
const uint S_OUT__AnalogSerialOutput__ = 144;
const uint SOURCE_LIST_IN_USE__DigitalOutput__ = 337;
const uint SOURCE_LIST_TEXT__AnalogSerialOutput__ = 244;
const uint SOURCE_LIST_ICON__AnalogSerialOutput__ = 280;
const uint ROOM_LIST_TEXT__AnalogSerialOutput__ = 316;
const uint QUICKSOURCE_D_FB__DigitalOutput__ = 373;
const uint QUICKSOURCE_A_FB__AnalogSerialOutput__ = 366;
const uint QUICKSOURCE_S_FB__AnalogSerialOutput__ = 416;
const uint QUICKLIGHTS_D_FB__DigitalOutput__ = 423;
const uint QUICKLIGHTS_S_FB__AnalogSerialOutput__ = 466;
const uint QUICKCLIMATE_D_FB__DigitalOutput__ = 435;
const uint QUICKCLIMATE_S_FB__AnalogSerialOutput__ = 478;
const uint QUICKDOORLOCK_D_FB__DigitalOutput__ = 447;
const uint QUICKDOORLOCK_S_FB__AnalogSerialOutput__ = 482;
const uint QUICKWINDOWS_D_FB__DigitalOutput__ = 449;
const uint QUICKWINDOWS_S_FB__AnalogSerialOutput__ = 484;
const uint NAVIGATIONITEMENABLE__DigitalOutput__ = 461;
const uint NAVIGATIONITEMVISIBLE__DigitalOutput__ = 511;
const uint NAVIGATIONITEMICON__AnalogSerialOutput__ = 496;
const uint NAVIGATIONITEMTEXT__AnalogSerialOutput__ = 546;
const uint CONTROLLISTDIGITAL_FB__DigitalOutput__ = 561;
const uint CONTROLLISTSERIAL_FB__AnalogSerialOutput__ = 596;
const uint MULTIROOM_SELECT_FB__DigitalOutput__ = 611;
const uint MULTIROOM_SOURCE_LIST_TEXT__AnalogSerialOutput__ = 646;
const uint MULTIROOM_SOURCE_LIST_ICON__AnalogSerialOutput__ = 682;
const uint MULTIROOM_SCENE_NAMES__AnalogSerialOutput__ = 718;
const uint CAMERA_NAMES_LIST__AnalogSerialOutput__ = 742;
const uint ROOM_DISPLAYS_LIST__AnalogSerialOutput__ = 766;
const uint INTERCOM_NAMES_LIST__AnalogSerialOutput__ = 772;
const uint INTERCOM_LIST_ENABLE__DigitalOutput__ = 661;
const uint INTERCOM_LIST_VISIBLE__DigitalOutput__ = 711;
const uint DOORBELL_CHIME__DigitalOutput__ = 761;
const uint ROOMLISTITEMENABLE__DigitalOutput__ = 765;
const uint TP_ID__Parameter__ = 10;
const uint TP_NAME__Parameter__ = 11;
const uint DEFAULT_ROOM__Parameter__ = 12;
const uint ACCESS_LEVEL__Parameter__ = 13;
const uint FILE_NAME__Parameter__ = 14;
const uint READ_AT_BOOTUP__Parameter__ = 15;
const uint DEFAULT_HOME_PAGE_TYPE__Parameter__ = 16;

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

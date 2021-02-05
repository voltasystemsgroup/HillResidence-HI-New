namespace AdaptCore;
        // class declarations
         class AE_ApiBatteryOnlineData;
         class AE_ApiBatteryStatusData;
         class AE_ApiBreakerData;
         class AE_ApiBreakerDataWrapper;
         class AE_ApiBreakerStatusData;
         class AE_ApiConfigurationData;
         class AE_ApiConfigWrapper;
         class AE_ApiEventData;
         class AE_ApiEventIds;
         class AE_ApiEventWrapper;
         class AE_ApiTokenData;
         class AE_TokenData;
         class ApiConfigData;
         class ApiLightingZoneData;
         class ApiNameIdPairData;
         class ApiRoomData;
         class ApiRoomResponse;
         class ApiSecuritySystemData;
         class ApiSecuritySystemResponse;
         class ApiSecurityZoneResponse;
         class ApiSystemStatusWrapper;
         class ApiTstatResponse;
         class ApiWindowZoneData;
         class Certificate;
         class KeyGenerator;
         class KeyHelper;
         class KeyValidator;
         class LICENSE_STATUS;
         class LicenseKeyEncoding;
         class LicenseKeyFieldType;
         class LicenseKeyStatus;
         class LicenseTemplate;
         class LicensingClient;
         class PD_AdaptEnergy;
         class PD_AnalogEventArgs;
         class PD_ApiServer;
         class PD_ApiToken;
         class PD_Area;
         class PD_AudioSwitcher;
         class PD_AudioZone;
         class PD_AvEndPoint;
         class PD_AvEndPointDevice;
         class PD_AvInput;
         class PD_AvReceiver;
         class PD_BoolEventArgs;
         class PD_Bridge;
         class PD_BridgeIdNamePair;
         class PD_BridgeSignal;
         class PD_BridgeTypes;
         class PD_Camera;
         class PD_ChannelPreset;
         class PD_ClimateSystem;
         class PD_ClimateSystemEx;
         class PD_CommandQueue;
         class PD_CommandQueueItem;
         class PD_ConnectionEventArgs;
         class PD_Const;
         class PD_Core;
         class PD_DataClient;
         class PD_DataServer;
         class PD_Device;
         class PD_ControlType;
         class PD_DynamicIrStatus;
         class PD_DeviceCommands;
         class PD_DigitalEventArgs;
         class PD_Display;
         class PD_DisplayStandardCommands;
         class PD_DisplayStandardCommandsEnum;
         class PD_Doorbell;
         class PD_DoorbellEventArgs;
         class PD_DoorbellRoomSettings;
         class PD_DoorbellUiSettings;
         class PD_Doorlock;
         class PD_DoorlockSystem;
         class PD_EcoLinx;
         class AutonomyCalculator;
         class SonnenHttpComm;
         class ErrorEventArgs;
         class PD_EnergyEventData;
         class PD_Handheld;
         class PD_IntercomManager;
         class PD_Interface;
         class PD_IrCommandData;
         class PD_Keyboard;
         class PD_Keypad;
         class PD_LightingLoad;
         class PD_LightingSystem;
         class PD_LightingZone;
         class PD_Mlx3;
         class PD_Mlx3ListPage;
         class PD_Mlx3ListPageItem;
         class PD_MultiWindowInput;
         class PD_NameEventArgs;
         class PD_Notifier;
         class PD_OtherDevice;
         class PD_Room;
         class PD_RoomSourceSettings;
         class PD_Scene;
         class PD_SceneData;
         class PD_SecuritySystem;
         class PD_SecurityZone;
         class PD_SerialEventArgs;
         class PD_SignalClient;
         class PD_SignalServer;
         class PD_SignalTypes;
         class PD_Source;
         class PD_SourceListItem;
         class PD_SourceMapItem;
         class PD_SourceMultiWindow;
         class PD_SourceStandardCommands;
         class PD_SourceStandardCommandsEnum;
         class PD_SourceWithPresets;
         class PD_StandardCommand;
         class PD_StandardCommands;
         class PD_StandardCommandsConstants;
         class PD_StandardCommandsEnum;
         class PD_Switcher;
         class PD_TieLineDependency;
         class PD_TouchPanel;
         class Y2GHEGGAYMVDPB9V3EBMULCFMTJJQYXG;
         class PD_Tstat;
         class PD_User;
         class PD_ValueEventArgs;
         class PD_VideoOutput;
         class PD_VideoSwitcher;
         class PD_WindowController;
         class PD_WindowSystem;
         class PD_WindowZone;
         class SDKRegistration;
         class TIME_VALIDATION_METHOD;
     class AE_ApiConfigurationData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING AdaptHardwareId[];
        SIGNED_LONG_INTEGER BackupReserve;
    };

     class AE_ApiConfigWrapper 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION AddBreaker ( AE_ApiBreakerDataWrapper breaker );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AE_ApiConfigurationData ConfigData;
    };

    static class AE_ApiEventIds // enum
    {
        static SIGNED_LONG_INTEGER BatteryOnline;
        static SIGNED_LONG_INTEGER WeatherPrompt;
    };

     class AE_TokenData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Token[];
    };

     class ApiConfigData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        ApiSecuritySystemData SecuritySystem;
    };

     class ApiLightingZoneData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING ID[];
    };

     class ApiRoomData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING ID[];
        STRING LightingZone[];
        STRING Thermostat[];
        STRING WindowZone[];
    };

     class ApiSecuritySystemData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING ID[];
    };

     class ApiSystemStatusWrapper 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        AE_ApiBatteryStatusData BatteryStatus;
    };

     class ApiWindowZoneData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Name[];
        STRING ID[];
    };

     class KeyGenerator 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION SetLicenseKeyTemplate ( LicenseTemplate templ );
        FUNCTION SetKeyData ( STRING fieldName , STRING data );
        FUNCTION SetValidationData ( STRING fieldName , STRING data );
        STRING_FUNCTION GenerateKey ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class KeyHelper 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION GetCurrentHardwareId ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class KeyValidator 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION SetKeyTemplate ( LicenseTemplate templ );
        FUNCTION SetKey ( STRING strKey );
        FUNCTION SetValidationData ( STRING fieldName , SIGNED_LONG_INTEGER data );
        SIGNED_LONG_INTEGER_FUNCTION QueryIntKeyData ( STRING fieldName );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class LICENSE_STATUS // enum
    {
        static SIGNED_LONG_INTEGER Valid;
        static SIGNED_LONG_INTEGER Invalid;
        static SIGNED_LONG_INTEGER InvalidHardwareId;
        static SIGNED_LONG_INTEGER Expired;
        static SIGNED_LONG_INTEGER InvalidActivationKey;
    };

    static class LicenseKeyEncoding // enum
    {
        static SIGNED_LONG_INTEGER None;
        static SIGNED_LONG_INTEGER Base32X;
        static SIGNED_LONG_INTEGER Base64;
    };

    static class LicenseKeyFieldType // enum
    {
        static SIGNED_LONG_INTEGER Raw;
        static SIGNED_LONG_INTEGER Integer;
        static SIGNED_LONG_INTEGER String;
        static SIGNED_LONG_INTEGER Date14;
        static SIGNED_LONG_INTEGER Date16;
        static SIGNED_LONG_INTEGER Date13;
    };

    static class LicenseKeyStatus // enum
    {
        static SIGNED_LONG_INTEGER Success;
        static SIGNED_LONG_INTEGER GenericError;
        static SIGNED_LONG_INTEGER OutOfMemory;
        static SIGNED_LONG_INTEGER FieldNotFound;
        static SIGNED_LONG_INTEGER BufferTooSmall;
        static SIGNED_LONG_INTEGER InvalidXml;
        static SIGNED_LONG_INTEGER InvalidLicenseKey;
        static SIGNED_LONG_INTEGER InvalidKeyEncoding;
        static SIGNED_LONG_INTEGER InvalidParameter;
        static SIGNED_LONG_INTEGER InvalidSignatureSize;
        static SIGNED_LONG_INTEGER UnsupportedVersion;
    };

     class LicenseTemplate 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION AddDataField ( STRING name , LicenseKeyFieldType type , SIGNED_LONG_INTEGER size );
        FUNCTION DeleteDataField ( STRING name );
        FUNCTION AddValidationField ( STRING name , LicenseKeyFieldType type , SIGNED_LONG_INTEGER size );
        FUNCTION DeleteValidationField ( STRING fieldName );
        FUNCTION LoadXml ( STRING xmlTemplate );
        FUNCTION SetSigningServiceUrl ( STRING url );
        FUNCTION SetSigningServiceTemplateId ( SIGNED_LONG_INTEGER templateId );
        FUNCTION SetSigningServiceParameters ( STRING parameters );
        FUNCTION SetPublicKeyCertificate ( STRING base64Certificate );
        FUNCTION SetPrivateKey ( STRING base64PrivateKey );
        FUNCTION GenerateSigningKeyPair ();
        STRING_FUNCTION GetPublicKeyCertificate ();
        STRING_FUNCTION GetPrivateKey ();
        FUNCTION SetProperty ( STRING path , STRING name , STRING value );
        STRING_FUNCTION GetProperty ( STRING path , STRING name );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        SIGNED_LONG_INTEGER Version;
        SIGNED_LONG_INTEGER NumberOfGroups;
        SIGNED_LONG_INTEGER CharactersPerGroup;
        LicenseKeyEncoding KeyEncoding;
        STRING GroupSeparator[];
        LicenseKeyEncoding Encoding;
        STRING Header[];
        STRING Footer[];
        SIGNED_LONG_INTEGER DataSize;
        STRING SigningServiceUrl[];
        SIGNED_LONG_INTEGER SigningServiceTemplateId;
        SIGNED_LONG_INTEGER ValidationDataSize;
        SIGNED_LONG_INTEGER SignatureSize;
    };

     class PD_AdaptEnergy 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_AdaptEnergy sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_AdaptEnergy sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_AdaptEnergy sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_AdaptEnergy sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_AdaptEnergy sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_AdaptEnergy sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_AdaptEnergy sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_AdaptEnergy sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_AdaptEnergy sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_AdaptEnergy sender, PD_NameEventArgs e );

        // class functions
        FUNCTION Start ();
        FUNCTION Stop ();
        STRING_FUNCTION RequestToken ();
        FUNCTION StartStream ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING DeviceAddress[];
        INTEGER NumDefaultButtonLabels;
        INTEGER NumDefaultListLabels;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_AnalogEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER JoinNum;
        INTEGER SignalValue;
    };

     class PD_ApiServer 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Stop ();
        FUNCTION StartHttp ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class PD_ApiToken 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Token[];
    };

     class PD_Area 
    {
        // class delegates

        // class events
        EventHandler SetInUseChange ( PD_Area sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Area sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Area sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Area sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Area sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Area sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Area sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_AudioSwitcher 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_AudioSwitcher sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_AudioSwitcher sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_AudioSwitcher sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_AudioSwitcher sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_AudioSwitcher sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_AudioSwitcher sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_AudioSwitcher sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_AudioSwitcher sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_AudioSwitcher sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_AudioSwitcher sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION RegisterWithCore ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumInputs;
        PD_AvInput InputBridges[];
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_AudioZone 
    {
        // class delegates

        // class events
        EventHandler SetSourceControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetAudioSourceControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetZoneOnControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetZoneOffControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetZoneToggleControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetVolumeValueControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetVolumeUpControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetVolumeDownControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetMuteOnControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetMuteOffControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetMuteToggleControlChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_AudioZone sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_AudioZone sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_AudioZone sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_AudioZone sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_AudioZone sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_AudioZone sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_AudioZone sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_AudioZone sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SourceFeedbackChange ( INTEGER val );
        FUNCTION VolumeFeedbackChange ( INTEGER val );
        FUNCTION ZoneOnFeedbackChange ( INTEGER val );
        FUNCTION MuteOnFeedbackChange ( INTEGER val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER OutputNumber;
        INTEGER NumInputs;
        PD_AvInput InputBridges[];
        INTEGER LastSourceNumSent;
        INTEGER ZonePowerStatus;
        INTEGER MuteStatus;
        INTEGER VolumeStatus;
        INTEGER SourceStatus;
        INTEGER UseLogicFeedback;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_AvEndPoint 
    {
        // class delegates

        // class events
        EventHandler SetSourceControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetAudioSourceControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetZoneOnControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetZoneOffControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetZoneToggleControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetVolumeValueControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetVolumeUpControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetVolumeDownControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetMuteOnControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetMuteOffControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetMuteToggleControlChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_AvEndPoint sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_AvEndPoint sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_AvEndPoint sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_AvEndPoint sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_AvEndPoint sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_AvEndPoint sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_AvEndPoint sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_AvEndPoint sender, PD_NameEventArgs e );

        // class functions
        FUNCTION SourceFeedbackChange ( INTEGER val );
        FUNCTION VolumeFeedbackChange ( INTEGER val );
        FUNCTION ZoneOnFeedbackChange ( INTEGER val );
        FUNCTION MuteOnFeedbackChange ( INTEGER val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumInputs;
        PD_AvInput InputBridges[];
        INTEGER LastSourceNumSent;
        INTEGER ZonePowerStatus;
        INTEGER MuteStatus;
        INTEGER VolumeStatus;
        INTEGER SourceStatus;
        INTEGER UseLogicFeedback;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_AvEndPointDevice 
    {
        // class delegates

        // class events
        EventHandler SetSourceControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetZoneOnControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetZoneOffControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetZoneToggleControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetMuteOnControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetMuteOffControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetMuteToggleControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetVolumeValueControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetVolumeUpControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetVolumeDownControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetCommandStringChange ( PD_AvEndPointDevice sender, PD_NameEventArgs e );
        EventHandler OnBusyEvent ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetAudioSourceControlChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_AvEndPointDevice sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_AvEndPointDevice sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_AvEndPointDevice sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_AvEndPointDevice sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_AvEndPointDevice sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_AvEndPointDevice sender, PD_SerialEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_AvEndPointDevice sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_AvEndPointDevice sender, PD_NameEventArgs e );

        // class functions
        FUNCTION SourceFeedbackChange ( INTEGER val );
        FUNCTION ZoneOnFeedbackChange ( INTEGER val );
        FUNCTION VolumeFeedbackChange ( INTEGER val );
        FUNCTION MuteOnFeedbackChange ( INTEGER val );
        FUNCTION CommandQueueCallback ( PD_CommandQueueItem commandItem );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumInputs;
        PD_AvInput InputBridges[];
        INTEGER LastSourceNumSent;
        INTEGER ZonePowerStatus;
        INTEGER MuteStatus;
        INTEGER VolumeStatus;
        INTEGER SourceStatus;
        INTEGER UseLogicFeedback;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_AvInput 
    {
        // class delegates

        // class events
        EventHandler SetInUseChange ( PD_AvInput sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_AvInput sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_AvInput sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_AvInput sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_AvInput sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_AvInput sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_AvInput sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER InputType;
        INTEGER InputNumber;
        STRING TieLineId[];
        PD_AvEndPoint TieLine;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_AvReceiver 
    {
        // class delegates

        // class events
        EventHandler OnBusyEvent ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetSourceControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetZoneOnControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetZoneOffControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetZoneToggleControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetMuteOnControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetMuteOffControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetMuteToggleControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetVolumeValueControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetVolumeUpControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetVolumeDownControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetCommandStringChange ( PD_AvReceiver sender, PD_NameEventArgs e );
        EventHandler SetAudioSourceControlChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_AvReceiver sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_AvReceiver sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_AvReceiver sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_AvReceiver sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_AvReceiver sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_AvReceiver sender, PD_SerialEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_AvReceiver sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_AvReceiver sender, PD_NameEventArgs e );

        // class functions
        FUNCTION RegisterWithCore ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SourceFeedbackChange ( INTEGER val );
        FUNCTION ZoneOnFeedbackChange ( INTEGER val );
        FUNCTION VolumeFeedbackChange ( INTEGER val );
        FUNCTION MuteOnFeedbackChange ( INTEGER val );
        FUNCTION CommandQueueCallback ( PD_CommandQueueItem commandItem );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumInputs;
        PD_AvInput InputBridges[];
        INTEGER LastSourceNumSent;
        INTEGER ZonePowerStatus;
        INTEGER MuteStatus;
        INTEGER VolumeStatus;
        INTEGER SourceStatus;
        INTEGER UseLogicFeedback;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_BoolEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class PD_Bridge 
    {
        // class delegates

        // class events
        EventHandler SetInUseChange ( PD_Bridge sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Bridge sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Bridge sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Bridge sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Bridge sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Bridge sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Bridge sender, PD_NameEventArgs e );

        // class functions
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_BridgeSignal 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING Id[];
        PD_SignalTypes T;
        INTEGER J;
        STRING D[];
    };

    static class PD_BridgeTypes // enum
    {
        static LONG_INTEGER PD_BRIDGE;
        static LONG_INTEGER PD_USER;
        static LONG_INTEGER PD_ROOM;
        static LONG_INTEGER PD_AREA;
        static LONG_INTEGER PD_TOUCHPANEL;
        static LONG_INTEGER PD_HANDHELD;
        static LONG_INTEGER PD_INTERFACE;
        static LONG_INTEGER PD_KEYPAD;
        static LONG_INTEGER PD_MLX3;
        static LONG_INTEGER PD_AUDIOSWITCHER;
        static LONG_INTEGER PD_VIDEOSWITCHER;
        static LONG_INTEGER PD_AVRECEIVER;
        static LONG_INTEGER PD_SWITCHER;
        static LONG_INTEGER PD_SOURCE;
        static LONG_INTEGER PD_SOURCEMULTIWINDOW;
        static LONG_INTEGER PD_DISPLAY;
        static LONG_INTEGER PD_TSTAT;
        static LONG_INTEGER PD_CLIMATESYSTEM;
        static LONG_INTEGER PD_LIGHTINGSYSTEM;
        static LONG_INTEGER PD_LIGHTINGZONE;
        static LONG_INTEGER PD_SECURITYSYSTEM;
        static LONG_INTEGER PD_CAMERA;
        static LONG_INTEGER PD_WINDOWSYSTEM;
        static LONG_INTEGER PD_WINDOWZONE;
        static LONG_INTEGER PD_DOORBELL;
        static LONG_INTEGER PD_DOORLOCK;
        static LONG_INTEGER PD_DOORLOCKSYSTEM;
        static LONG_INTEGER PD_DEVICE;
        static LONG_INTEGER PD_AVINPUT;
        static LONG_INTEGER PD_AUDIOOUTPUT;
        static LONG_INTEGER PD_VIDEOOUTPUT;
        static LONG_INTEGER PD_MULTIWINDOWINPUT;
        static LONG_INTEGER PD_LIGHTINGLOAD;
        static LONG_INTEGER PD_SECURITYZONE;
        static LONG_INTEGER PD_WINDOWCONTROLLER;
        static LONG_INTEGER PD_CORE;
    };

     class PD_Camera 
    {
        // class delegates

        // class events
        EventHandler SetCameraSelect ( PD_Camera sender, PD_ValueEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_Camera sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_Camera sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_Camera sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_Camera sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Camera sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Camera sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Camera sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Camera sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Camera sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Camera sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING InsideUrl[];
        STRING OutsideUrl[];
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_ClimateSystem 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_ClimateSystem sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_ClimateSystem sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_ClimateSystem sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_ClimateSystem sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_ClimateSystem sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_ClimateSystem sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_ClimateSystem sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_ClimateSystem sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_ClimateSystem sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_ClimateSystem sender, PD_NameEventArgs e );

        // class functions
        FUNCTION Setup ();
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_ClimateSystemEx 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_ClimateSystemEx sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_ClimateSystemEx sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_ClimateSystemEx sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_ClimateSystemEx sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_ClimateSystemEx sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_ClimateSystemEx sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_ClimateSystemEx sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_ClimateSystemEx sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_ClimateSystemEx sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_ClimateSystemEx sender, PD_NameEventArgs e );

        // class functions
        FUNCTION Setup ();
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION RefreshFeedback ( PD_Bridge sender );
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_CommandQueue 
    {
        // class delegates
        delegate FUNCTION CommandTimerCallback ( PD_CommandQueueItem cmd );

        // class events
        EventHandler OnQueueBusyEvent ( PD_CommandQueue sender, PD_ValueEventArgs e );

        // class functions
        FUNCTION Add ( PD_CommandQueueItem cmdItem );
        FUNCTION Clear ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty CommandTimerCallback CommandCallback;
    };

     class PD_ConnectionEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        PD_SignalTypes State;
        INTEGER ConnectionCount;
        STRING TargetLogicId[];
        INTEGER Refresh;
    };

     class PD_Const 
    {
        // class delegates

        // class events

        // class functions
        static STRING_FUNCTION GetLogicId ( PD_BridgeTypes type , INTEGER friendlyId , PD_BridgeTypes parentType , INTEGER parentId );
        static STRING_FUNCTION GetParentLogicId ( STRING childLogicId );
        static INTEGER_FUNCTION GetFriendlyId ( STRING logicId );
        static STRING_FUNCTION GetLabelFromType ( PD_BridgeTypes type );
        static STRING_FUNCTION ReplaceHexCharacters ( STRING input );
        static STRING_FUNCTION ReplaceNumWithHex ( INTEGER num );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static INTEGER SourceTypeGeneric;
        static INTEGER SourceTypeCableSatBox;
        static INTEGER SourceTypeVideoServer;
        static INTEGER SourceTypeBluRayDvd;
        static INTEGER SourceTypeMediaPlayer;
        static INTEGER SourceTypeSecurityDvr;
        static INTEGER SourceTypePlayerWithMetaData;
        static INTEGER SourceTypeTvApps;
        static INTEGER SourceTypeMisc1;
        static INTEGER SourceTypeMisc2;
        static INTEGER SourceTypeMisc3;
        static INTEGER SourceTypeMisc4;
        static INTEGER SourceTypeMisc5;
        static INTEGER SourceTypeMisc6;
        static INTEGER SourceTypeMisc7;
        static INTEGER SourceTypeMisc8;
        static INTEGER SourceTypeMisc9;
        static INTEGER SourceTypeMisc10;
        static STRING ColorDefault[];
        static STRING ColorBlack[];
        static STRING ColorRed[];
        static STRING ColorGreen[];
        static STRING ColorYellow[];
        static STRING ColorBlue[];
        static STRING ColorMagenta[];
        static STRING ColorCyan[];
        static STRING ColorWhite[];
        static STRING ColorReset[];
        static STRING ConsoleClear[];
        static SIGNED_LONG_INTEGER ProgramTcpPort;
        static SIGNED_LONG_INTEGER BridgeTcpPort;
        static INTEGER IdOffset;
        static STRING cAllowNextProgram[];
        static STRING cLoadingFilesStartMessage[];
        static STRING cLoadingFilesEndMessage[];
        static INTEGER ReadyToRead;
        static INTEGER ReadyToConnectVideoSwitchers;
        static INTEGER ReadyToConnectAudioSwitchers;
        static INTEGER ReadyToConnectAvReceivers;
        static INTEGER ReadyToConnectDevices;
        static INTEGER ReadyToConnectRooms;
        static INTEGER ReadyToConnectInterfaces;
        static INTEGER DoorbellEnd;
        static INTEGER DoorbellStart;
        static INTEGER DoorbellRetrigger;
        static INTEGER DoorbellAnswered;
        static STRING EscapeSeq[];
        static STRING LabelCore[];
        static STRING LabelRegisterRequest[];
        static STRING LabelRegisterIds[];
        static STRING LabelRegistrationComplete[];
        static STRING LabelDataRequest[];
        static STRING LabelAddElement[];
        static STRING LabelReplaceElement[];
        static STRING LabelNullData[];
        static STRING LabelRemote[];
        static STRING LabelResponse[];
        static STRING LabelResponseStart[];
        static STRING LabelResponseEnd[];
        static STRING LabelSystemData[];
        static STRING LabelJobNumber[];
        static STRING LabelDealer[];
        static STRING LabelDate[];
        static STRING LabelProcessor[];
        static STRING LabelIp[];
        static STRING LabelProgram[];
        static STRING LabelSlot[];
        static STRING LabelProcessorKey[];
        static STRING LabelActivationKey[];
        static STRING LabelCoreVersion[];
        static STRING LabelNone[];
        static STRING LabelBridge[];
        static STRING LabelId[];
        static STRING LabelType[];
        static STRING LabelUsers[];
        static STRING LabelRooms[];
        static STRING LabelInterfaces[];
        static STRING LabelDevices[];
        static STRING LabelAutomation[];
        static STRING LabelInfo[];
        static STRING LabelUser[];
        static STRING LabelRoom[];
        static STRING LabelArea[];
        static STRING LabelTouchPanel[];
        static STRING LabelHandheld[];
        static STRING LabelMlx3[];
        static STRING LabelKeypad[];
        static STRING LabelInterface[];
        static STRING LabelSwitchers[];
        static STRING LabelSources[];
        static STRING LabelDisplays[];
        static STRING LabelClimate[];
        static STRING LabelLighting[];
        static STRING LabelSecurity[];
        static STRING LabelCameras[];
        static STRING LabelWindows[];
        static STRING LabelDoors[];
        static STRING LabelDoorbells[];
        static STRING LabelOtherDevices[];
        static STRING LabelRemoteBridge[];
        static STRING LabelAreas[];
        static STRING LabelAudioSwitcher[];
        static STRING LabelVideoSwitcher[];
        static STRING LabelAvReceiver[];
        static STRING LabelSwitcher[];
        static STRING LabelSource[];
        static STRING LabelSourceMultiWindow[];
        static STRING LabelDisplay[];
        static STRING LabelTstat[];
        static STRING LabelClimateSystem[];
        static STRING LabelLightingSystem[];
        static STRING LabelLightingZone[];
        static STRING LabelSecuritySystem[];
        static STRING LabelCamera[];
        static STRING LabelWindowSystem[];
        static STRING LabelWindowZone[];
        static STRING LabelDoor[];
        static STRING LabelDoorbell[];
        static STRING LabelDoorlock[];
        static STRING LabelDoorlockSystem[];
        static STRING LabelGarageDoor[];
        static STRING LabelGate[];
        static STRING LabelDevice[];
        static STRING LabelAvInput[];
        static STRING LabelMultiWindowInput[];
        static STRING LabelAudioOutput[];
        static STRING LabelVideoOutput[];
        static STRING LabelLightingLoad[];
        static STRING LabelSecurityZone[];
        static STRING LabelWindowController[];
        static STRING LabelTrue[];
        static STRING LabelFalse[];
        static STRING LabelAccess[];
        static STRING LabelName[];
        static STRING LabelAudio[];
        static STRING LabelVideo[];
        static STRING LabelAudioId[];
        static STRING LabelVideoId[];
        static STRING LabelSourceId[];
        static STRING LabelTieLine[];
        static STRING LabelTieLineId[];
        static STRING LabelDisplayId[];
        static STRING LabelLightingId[];
        static STRING LabelClimateId[];
        static STRING LabelSecurityId[];
        static STRING LabelCameraId[];
        static STRING LabelWindowsId[];
        static STRING LabelDoorId[];
        static STRING LabelDoorbellId[];
        static STRING LabelOther[];
        static STRING LabelOtherDevice[];
        static STRING LabelSettings[];
        static STRING LabelInputNumber[];
        static STRING LabelOutputNumber[];
        static STRING LabelInput[];
        static STRING LabelVolume[];
        static STRING LabelDefaultRoom[];
        static STRING LabelDefaultRoomId[];
        static STRING LabelDelayAfterOn[];
        static STRING LabelDelayAfterInput[];
        static STRING LabelDelayAfterOff[];
        static STRING LabelDelayBeforeOff[];
        static STRING LabelPulseLength[];
        static STRING LabelAutoOff[];
        static STRING LabelIncludeVideo[];
        static STRING LabelPowerOnIfOff[];
        static STRING LabelTiming[];
        static STRING LabelSourcesAllowed[];
        static STRING LabelDisplayVol[];
        static STRING LabelUseIr[];
        static STRING LabelCommand[];
        static STRING LabelCommands[];
        static STRING LabelPowerOn[];
        static STRING LabelPowerOff[];
        static STRING LabelPowerToggle[];
        static STRING LabelMuteOn[];
        static STRING LabelMuteOff[];
        static STRING LabelMuteToggle[];
        static STRING LabelHoldTime[];
        static STRING LabelRepeatTime[];
        static STRING LabelVolStart[];
        static STRING LabelVolEnd[];
        static STRING LabelMinValue[];
        static STRING LabelMaxValue[];
        static STRING LabelNumDigits[];
        static STRING LabelStartupLevel[];
        static STRING LabelVolOnTime[];
        static STRING LabelVolOffTime[];
        static STRING LabelDriverData[];
        static STRING LabelIrFilePath[];
        static STRING LabelPortNumber[];
        static STRING LabelTimeout[];
        static STRING LabelRoomList[];
        static STRING LabelSourceList[];
        static STRING LabelRoomId[];
        static STRING LabelLightingButton[];
        static STRING LabelWindowButton[];
        static STRING LabelDefault[];
        static STRING LabelDefaultPage[];
        static STRING LabelPageFlip[];
        static STRING LabelOnSourceSelect[];
        static STRING LabelOnRoomOff[];
        static STRING LabelRoaming[];
        static STRING LabelUseDefaultPage[];
        static STRING LabelIcon[];
        static STRING LabelDimmable[];
        static STRING LabelAllowGlobals[];
        static STRING LabelMultiroomSources[];
        static STRING LabelScenes[];
        static STRING LabelScene[];
        static STRING LabelSceneNum[];
        static STRING LabelSourceNum[];
        static STRING LabelChannelPresets[];
        static STRING LabelPreset[];
        static STRING LabelPresetNum[];
        static STRING LabelChannel[];
        static STRING LabelMessage[];
        static STRING LabelDuration[];
        static STRING LabelChimeDelay[];
        static STRING LabelChime[];
        static STRING LabelButtonLabels[];
        static STRING LabelListLabels[];
        static STRING LabelLabel[];
        static STRING LabelLabelNum[];
        static STRING LabelText[];
        static STRING LabelHomePageType[];
        static STRING LabelInsideUrl[];
        static STRING LabelOutsideUrl[];
        static STRING LabelUrl[];
        static STRING LabelUseMjpeg[];
        static STRING LabelIntercomList[];
        static STRING LabelTouchPanelId[];
        static STRING LabelDoorbellPageFlip[];
        static STRING LabelInteromUri[];
        static STRING LabelSourceButtons[];
        static STRING LabelSourceButton[];
        static STRING LabelHomePage[];
        static STRING LabelPowerPage[];
        static STRING LabelTitle[];
        static STRING LabelPageNum[];
        static STRING LabelListItem[];
        static STRING LabelListPage[];
        static STRING LabelControlId[];
        static STRING LabelSoftHardkeys[];
        static STRING LabelHardkey[];
        static STRING LabelRoomSelectGoToPage[];
        static STRING LabelEnergy[];
        static STRING LabelGlobalLights[];
        static STRING LabelGlobalWindows[];
        static STRING LabelGlobalClimate[];
        static STRING LabelGlobalAV[];
        static STRING LabelButton[];
        static STRING LabelAllOff[];
        static STRING LabelGridLossDefault[];
        static STRING LabelGridLossUserOption1[];
        static STRING LabelGridLossUserOption2[];
        static STRING LabelGridRestore[];
        static INTEGER cHandheldHomePage;
        static INTEGER cHandheldTurnOffPage;
        static INTEGER cHandheldFullListPage;
        static INTEGER cHandheldInfoListPage;
        static INTEGER cHandheldInfoOnlyPage;
        static INTEGER cHandheldMediaPage;
        static INTEGER cHandheldRoomsPage;
        static INTEGER TouchPanelPageHome;
        static INTEGER TouchPanelPageMedia;
        static INTEGER TouchPanelPageLighting;
        static INTEGER TouchPanelPageClimate;
        static INTEGER TouchPanelPageSecurity;
        static INTEGER TouchPanelPageCameras;
        static INTEGER TouchPanelPageWindows;
        static INTEGER TouchPanelPageDoors;
        static INTEGER TouchPanelPageOtherDevices;
        static INTEGER TouchPanelPageMultiroom;
        static INTEGER TouchPanelPageIntercom;
        static INTEGER TouchPanelPageDoorbell;
        static STRING LabelRoomMedia[];
        static STRING LabelRoomLights[];
        static STRING LabelRoomClimate[];
        static STRING LabelRoomSecurity[];
        static STRING LabelRoomCamera[];
        static STRING LabelRoomWindow[];
        static STRING LabelRoomDoor[];

        // class properties
    };

    static class PD_Core 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION AddToBridgeCount ();
        static FUNCTION AddTieLineDependency ( PD_TieLineDependency tieLineDep );
        static FUNCTION SendSourceMap ( PD_TieLineDependency tieLineDep );
        static FUNCTION RegisterCoreBridge ( PD_Bridge bridgeToRegister );
        static FUNCTION FireEnergyGridLossEvent ( INTEGER devNum );
        static FUNCTION EnergyGridLossUserOption ( INTEGER optionNum );
        static FUNCTION FireEnergyGridRestoreEvent ();
        static FUNCTION GetRemoteXmlData ( STRING logicId );
        static FUNCTION ConnectProgramClient ();
        static FUNCTION ConnectSignalClient ();
        static FUNCTION StopSignalClient ();
        static FUNCTION MasterProcessBridgeSignal ( LONG_INTEGER clientIndex , PD_BridgeSignal bs );
        static FUNCTION RemoteProcessBridgeSignal ( PD_BridgeSignal bs );
        static FUNCTION DataClientDisconnected ( LONG_INTEGER clientIndex , STRING ipAddress );
        static FUNCTION InitializeAsMaster ( STRING jobNum , INTEGER fileLocation , INTEGER startupDelay );
        static FUNCTION InitializeAsRemote ( STRING masterIp , STRING jobNum , INTEGER startupDelay );
        static FUNCTION FireInitEvent ( INTEGER phase );
        static FUNCTION Debug ( STRING statement );
        static FUNCTION Cout ( STRING color , STRING message );
        static FUNCTION UserCommand ( STRING command );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DebugOn;
        STRING JobNumber[];
        STRING DealerName[];
        STRING ProcessorName[];
        STRING ProcessorIp[];
        STRING ProcessorSystemVersionInfo[];
        STRING LicenseKey[];
        INTEGER StartupDelay;
        STRING DefaultFileLocation[];
        STRING ConfigFilePath[];
        STRING GlobalClimateId[];
        STRING GlobalLightingId[];
        STRING GlobalSecurityId[];
        STRING GlobalDoorlocksId[];
        STRING GlobalWindowsId[];
        PD_ClimateSystem GlobalClimateSystem;
        PD_User SystemUser;
        INTEGER EnableApi;
    };

     class PD_DataClient 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION ClientConnect ();
        FUNCTION ClientDisconnect ();
        FUNCTION ClientProcessResponse ( STRING response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING MasterIpAddress[];
        SIGNED_LONG_INTEGER Port;
        INTEGER DebugOn;
    };

     class PD_DataServer 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Debug ( STRING statement );
        FUNCTION ServerStart ();
        FUNCTION ServerStop ();
        FUNCTION ServerProcessResponse ( LONG_INTEGER clientIndex , STRING response );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DebugOn;
    };

     class PD_Device 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_Device sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_Device sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_Device sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_Device sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Device sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Device sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Device sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Device sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Device sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Device sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

    static class PD_ControlType // enum
    {
        static LONG_INTEGER ProgramIr;
        static LONG_INTEGER DynamicIr;
        static LONG_INTEGER CommandsData;
        static LONG_INTEGER ProgramModule;
        static LONG_INTEGER DynamicDll;
    };

    static class PD_DeviceCommands // enum
    {
        static SIGNED_LONG_INTEGER PowerOn;
        static SIGNED_LONG_INTEGER PowerOff;
        static SIGNED_LONG_INTEGER PowerToggle;
        static SIGNED_LONG_INTEGER MuteOn;
        static SIGNED_LONG_INTEGER MuteOff;
        static SIGNED_LONG_INTEGER MuteToggle;
        static SIGNED_LONG_INTEGER VolumeUp;
        static SIGNED_LONG_INTEGER VolumeDown;
        static SIGNED_LONG_INTEGER VolumeValue;
        static SIGNED_LONG_INTEGER InputValue;
        static SIGNED_LONG_INTEGER IrVolumeOn;
        static SIGNED_LONG_INTEGER IrVolumeOff;
        static SIGNED_LONG_INTEGER Num1;
        static SIGNED_LONG_INTEGER Num2;
        static SIGNED_LONG_INTEGER Num3;
        static SIGNED_LONG_INTEGER Num4;
        static SIGNED_LONG_INTEGER Num5;
        static SIGNED_LONG_INTEGER Num6;
        static SIGNED_LONG_INTEGER Num7;
        static SIGNED_LONG_INTEGER Num8;
        static SIGNED_LONG_INTEGER Num9;
        static SIGNED_LONG_INTEGER Num0;
        static SIGNED_LONG_INTEGER Dash;
        static SIGNED_LONG_INTEGER Enter;
    };

     class PD_DigitalEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER JoinNum;
        INTEGER SignalValue;
    };

     class PD_Display 
    {
        // class delegates

        // class events
        EventHandler OnBusyEvent ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetSourceControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetZoneOnControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetZoneOffControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetZoneToggleControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetMuteOnControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetMuteOffControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetMuteToggleControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetVolumeValueControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetVolumeUpControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetVolumeDownControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetCommandStringChange ( PD_Display sender, PD_NameEventArgs e );
        EventHandler SetAudioSourceControlChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_Display sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_Display sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_Display sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Display sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Display sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Display sender, PD_SerialEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Display sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Display sender, PD_NameEventArgs e );

        // class functions
        FUNCTION RegisterWithCore ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SourceFeedbackChange ( INTEGER val );
        FUNCTION ZoneOnFeedbackChange ( INTEGER val );
        FUNCTION VolumeFeedbackChange ( INTEGER val );
        FUNCTION MuteOnFeedbackChange ( INTEGER val );
        FUNCTION CommandQueueCallback ( PD_CommandQueueItem commandItem );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumInputs;
        PD_AvInput InputBridges[];
        INTEGER LastSourceNumSent;
        INTEGER ZonePowerStatus;
        INTEGER MuteStatus;
        INTEGER VolumeStatus;
        INTEGER SourceStatus;
        INTEGER UseLogicFeedback;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

    static class PD_DisplayStandardCommands 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static PD_StandardCommandsEnum InputCommands[];

        // class properties
    };

    static class PD_DisplayStandardCommandsEnum // enum
    {
        static SIGNED_LONG_INTEGER Vga1;
        static SIGNED_LONG_INTEGER Vga10;
        static SIGNED_LONG_INTEGER Vga2;
        static SIGNED_LONG_INTEGER Vga3;
        static SIGNED_LONG_INTEGER Vga4;
        static SIGNED_LONG_INTEGER Vga5;
        static SIGNED_LONG_INTEGER Vga6;
        static SIGNED_LONG_INTEGER Vga7;
        static SIGNED_LONG_INTEGER Vga8;
        static SIGNED_LONG_INTEGER Vga9;
        static SIGNED_LONG_INTEGER Hdmi1;
        static SIGNED_LONG_INTEGER Hdmi10;
        static SIGNED_LONG_INTEGER Hdmi2;
        static SIGNED_LONG_INTEGER Hdmi3;
        static SIGNED_LONG_INTEGER Hdmi4;
        static SIGNED_LONG_INTEGER Hdmi5;
        static SIGNED_LONG_INTEGER Hdmi6;
        static SIGNED_LONG_INTEGER Hdmi7;
        static SIGNED_LONG_INTEGER Hdmi8;
        static SIGNED_LONG_INTEGER Hdmi9;
        static SIGNED_LONG_INTEGER Dvi1;
        static SIGNED_LONG_INTEGER Dvi10;
        static SIGNED_LONG_INTEGER Dvi2;
        static SIGNED_LONG_INTEGER Dvi3;
        static SIGNED_LONG_INTEGER Dvi4;
        static SIGNED_LONG_INTEGER Dvi5;
        static SIGNED_LONG_INTEGER Dvi6;
        static SIGNED_LONG_INTEGER Dvi7;
        static SIGNED_LONG_INTEGER Dvi8;
        static SIGNED_LONG_INTEGER Dvi9;
        static SIGNED_LONG_INTEGER Component1;
        static SIGNED_LONG_INTEGER Component10;
        static SIGNED_LONG_INTEGER Component2;
        static SIGNED_LONG_INTEGER Component3;
        static SIGNED_LONG_INTEGER Component4;
        static SIGNED_LONG_INTEGER Component5;
        static SIGNED_LONG_INTEGER Component6;
        static SIGNED_LONG_INTEGER Component7;
        static SIGNED_LONG_INTEGER Component8;
        static SIGNED_LONG_INTEGER Component9;
        static SIGNED_LONG_INTEGER Composite1;
        static SIGNED_LONG_INTEGER Composite10;
        static SIGNED_LONG_INTEGER Composite2;
        static SIGNED_LONG_INTEGER Composite3;
        static SIGNED_LONG_INTEGER Composite4;
        static SIGNED_LONG_INTEGER Composite5;
        static SIGNED_LONG_INTEGER Composite6;
        static SIGNED_LONG_INTEGER Composite7;
        static SIGNED_LONG_INTEGER Composite8;
        static SIGNED_LONG_INTEGER Composite9;
        static SIGNED_LONG_INTEGER DisplayPort1;
        static SIGNED_LONG_INTEGER DisplayPort10;
        static SIGNED_LONG_INTEGER DisplayPort2;
        static SIGNED_LONG_INTEGER DisplayPort3;
        static SIGNED_LONG_INTEGER DisplayPort4;
        static SIGNED_LONG_INTEGER DisplayPort5;
        static SIGNED_LONG_INTEGER DisplayPort6;
        static SIGNED_LONG_INTEGER DisplayPort7;
        static SIGNED_LONG_INTEGER DisplayPort8;
        static SIGNED_LONG_INTEGER DisplayPort9;
        static SIGNED_LONG_INTEGER Usb1;
        static SIGNED_LONG_INTEGER Usb2;
        static SIGNED_LONG_INTEGER Usb3;
        static SIGNED_LONG_INTEGER Usb4;
        static SIGNED_LONG_INTEGER Usb5;
        static SIGNED_LONG_INTEGER Antenna1;
        static SIGNED_LONG_INTEGER Antenna2;
        static SIGNED_LONG_INTEGER Network1;
        static SIGNED_LONG_INTEGER Network10;
        static SIGNED_LONG_INTEGER Network2;
        static SIGNED_LONG_INTEGER Network3;
        static SIGNED_LONG_INTEGER Network4;
        static SIGNED_LONG_INTEGER Network5;
        static SIGNED_LONG_INTEGER Network6;
        static SIGNED_LONG_INTEGER Network7;
        static SIGNED_LONG_INTEGER Network8;
        static SIGNED_LONG_INTEGER Network9;
        static SIGNED_LONG_INTEGER Input1;
        static SIGNED_LONG_INTEGER Input10;
        static SIGNED_LONG_INTEGER Input2;
        static SIGNED_LONG_INTEGER Input3;
        static SIGNED_LONG_INTEGER Input4;
        static SIGNED_LONG_INTEGER Input5;
        static SIGNED_LONG_INTEGER Input6;
        static SIGNED_LONG_INTEGER Input7;
        static SIGNED_LONG_INTEGER Input8;
        static SIGNED_LONG_INTEGER Input9;
        static SIGNED_LONG_INTEGER Mute;
        static SIGNED_LONG_INTEGER MuteOff;
        static SIGNED_LONG_INTEGER MuteOn;
        static SIGNED_LONG_INTEGER InputPoll;
        static SIGNED_LONG_INTEGER MutePoll;
        static SIGNED_LONG_INTEGER Power;
        static SIGNED_LONG_INTEGER PowerOff;
        static SIGNED_LONG_INTEGER PowerOn;
        static SIGNED_LONG_INTEGER PowerPoll;
        static SIGNED_LONG_INTEGER VolMinus;
        static SIGNED_LONG_INTEGER VolPlus;
        static SIGNED_LONG_INTEGER Vol;
        static SIGNED_LONG_INTEGER VolumePoll;
    };

     class PD_Doorbell 
    {
        // class delegates

        // class events
        EventHandler SetDoorbellPlayChime ( PD_Doorbell sender, PD_ValueEventArgs e );
        EventHandler FireDoorbellEvent ( PD_Doorbell sender, PD_DoorbellEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_Doorbell sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_Doorbell sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_Doorbell sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_Doorbell sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Doorbell sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Doorbell sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Doorbell sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Doorbell sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Doorbell sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Doorbell sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION TriggerDoorbell ();
        FUNCTION CancelDoorbell ();
        FUNCTION TryAnswer ( STRING panelId );
        FUNCTION EndCall ();
        FUNCTION SetInCall ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER SourceNum;
        STRING Message[];
        INTEGER Duration;
        SIGNED_LONG_INTEGER ChimeDelay;
        STRING CameraId[];
        STRING IntercomUri[];
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_DoorbellEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER State;
        STRING TouchPanelId[];
    };

     class PD_Doorlock 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_Doorlock sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_Doorlock sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_Doorlock sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_Doorlock sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Doorlock sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Doorlock sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Doorlock sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Doorlock sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Doorlock sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Doorlock sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER LockedStatus;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_DoorlockSystem 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_DoorlockSystem sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_DoorlockSystem sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_DoorlockSystem sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_DoorlockSystem sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_DoorlockSystem sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_DoorlockSystem sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_DoorlockSystem sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_DoorlockSystem sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_DoorlockSystem sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_DoorlockSystem sender, PD_NameEventArgs e );

        // class functions
        FUNCTION Setup ();
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_EcoLinx 
    {
        // class delegates

        // class events
        EventHandler OnDigitalOutputChange ( PD_EcoLinx sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_EcoLinx sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_EcoLinx sender, PD_SerialEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_EcoLinx sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_EcoLinx sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_EcoLinx sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_EcoLinx sender, PD_ValueEventArgs e );
        EventHandler OnBusyEvent ( PD_EcoLinx sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_EcoLinx sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_EcoLinx sender, PD_NameEventArgs e );

        // class functions
        FUNCTION Setup ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION ResendCurrentPage ();
        FUNCTION SetModeBackup ();
        FUNCTION SetModeSelfConsumption ();
        FUNCTION SetModeTimeOfUse ();
        FUNCTION SetModeMultipleTimesOfUse ();
        FUNCTION SetModeZeroExport ();
        FUNCTION SetModeManual ();
        FUNCTION SetGeneratorChargePower ( INTEGER value );
        FUNCTION GeneratorChargePowerUp ();
        FUNCTION GeneratorChargePowerDown ();
        FUNCTION SetGeneratorTurnOnPoint ( INTEGER value );
        FUNCTION GeneratorTurnOnPointUp ();
        FUNCTION GeneratorTurnOnPointDown ();
        FUNCTION SetGeneratorTurnOffPoint ( INTEGER value );
        FUNCTION GeneratorTurnOffPointUp ();
        FUNCTION GeneratorTurnOffPointDown ();
        FUNCTION SetBackupBuffer ( INTEGER value );
        FUNCTION SetChargeRate ( INTEGER value );
        FUNCTION GridChargingEnable ();
        FUNCTION GridChargingDisable ();
        FUNCTION PeakHourStartTimeUp ();
        FUNCTION PeakHourStartTimeDown ();
        FUNCTION PeakHourEndTimeUp ();
        FUNCTION PeakHourEndTimeDown ();
        FUNCTION LowTariffChargeTimeUp ();
        FUNCTION LowTariffChargeTimeDown ();
        FUNCTION SetHighTariffThreshold ( INTEGER value );
        FUNCTION HighTariffThresholdUp ();
        FUNCTION HighTariffThresholdDown ();
        FUNCTION HighTariffStart1Up ();
        FUNCTION HighTariffStart1Down ();
        FUNCTION HighTariffEnd1Up ();
        FUNCTION HighTariffEnd1Down ();
        FUNCTION HighTariffStart2Up ();
        FUNCTION HighTariffStart2Down ();
        FUNCTION HighTariffEnd2Up ();
        FUNCTION HighTariffEnd2Down ();
        FUNCTION LowTariffChargeStartUp ();
        FUNCTION LowTariffChargeStartDown ();
        FUNCTION LowTariffChargeEndUp ();
        FUNCTION LowTariffChargeEndDown ();
        FUNCTION SelfConsumptionInZeroExportEnable ();
        FUNCTION SelfConsumptionInZeroExportDisable ();
        FUNCTION TimeOfUseInZeroExportEnable ();
        FUNCTION TimeOfUseInZeroExportDisable ();
        FUNCTION ZeroExportTimeStartUp ();
        FUNCTION ZeroExportTimeStartDown ();
        FUNCTION ZeroExportTimeEndUp ();
        FUNCTION ZeroExportTimeEndDown ();
        FUNCTION StartPolling ( SIGNED_LONG_INTEGER pollTime );
        FUNCTION StopPolling ();
        FUNCTION PollInitialSettings ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        STRING DeviceAddress[];
        SIGNED_LONG_INTEGER SlowPollInterval;
        SIGNED_LONG_INTEGER FastPollInterval;
        STRING WeatherZipCode[];
        static INTEGER OperatingModeManual;
        static INTEGER OperatingModeBackup;
        static INTEGER OperatingModeSelfConsumption;
        static INTEGER OperatingModeTimeOfUse;
        static INTEGER OperatingModeMultipleTOU;
        static INTEGER OperatingModeZeroExport;
        static INTEGER High;
        static INTEGER Low;

        // class properties
        INTEGER NumDefaultButtonLabels;
        INTEGER NumDefaultListLabels;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class AutonomyCalculator 
    {
        // class delegates

        // class events

        // class functions
        INTEGER_FUNCTION GetAutonomy ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class SonnenHttpComm 
    {
        // class delegates

        // class events
        EventHandler ErrorEvent ( SonnenHttpComm sender, ErrorEventArgs e );

        // class functions
        FUNCTION TurnDebugOn ( STRING symbolName );
        FUNCTION TurnDebugOff ();
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class PD_EnergyEventData 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER GlobalLightsButton;
        INTEGER GlobalWindowsButton;

        // class properties
    };

     class PD_Handheld 
    {
        // class delegates

        // class events
        EventHandler SetRoomSourceFeedbackChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomSourceNameFeedbackChange ( PD_Handheld sender, PD_NameEventArgs e );
        EventHandler SetListDigitalFeedbackChange ( PD_Handheld sender, PD_DigitalEventArgs e );
        EventHandler SetListAnalogFeedbackChange ( PD_Handheld sender, PD_AnalogEventArgs e );
        EventHandler SetListSerialFeedbackChange ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler SetAllowTimerFlagChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetConnectedRoomNameFeedbackChange ( PD_Handheld sender, PD_NameEventArgs e );
        EventHandler SetConnectedRoomNumFeedbackChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetConnectedRoomIndexFeedbackChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomListSourceFeedbackChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetSourceListFeedbackChange ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler SetSourceListIconChange ( PD_Handheld sender, PD_AnalogEventArgs e );
        EventHandler SetSourceListSizeChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomListFeedbackChange ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler SetRoomListSizeChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomVolumeFeedbackChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOnFeedbackChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOffFeedbackChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomMuteOnFeedbackChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasMultipleDisplaysFeedback ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplaySelectedFeedback ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListSize ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListItemFeedback ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler SetRoomDisplayNameSelectedFeedback ( PD_Handheld sender, PD_NameEventArgs e );
        EventHandler SetConnectedDeviceNameFeedbackChange ( PD_Handheld sender, PD_NameEventArgs e );
        EventHandler SetSourceQuickDigitalFeedback ( PD_Handheld sender, PD_DigitalEventArgs e );
        EventHandler SetSourceQuickAnalogFeedback ( PD_Handheld sender, PD_AnalogEventArgs e );
        EventHandler SetSourceQuickSerialFeedback ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler SetSourceQuickControlCount ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetLightingQuickDigitalFeedback ( PD_Handheld sender, PD_DigitalEventArgs e );
        EventHandler SetLightingQuickSerialFeedback ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler SetLightingQuickControlsCount ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetClimateQuickDigitalFeedback ( PD_Handheld sender, PD_DigitalEventArgs e );
        EventHandler SetClimateQuickSerialFeedback ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler SetDoorlockQuickDigitalFeedback ( PD_Handheld sender, PD_DigitalEventArgs e );
        EventHandler SetDoorlockQuickSerialFeedback ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler SetCameraQuickDigitalFeedback ( PD_Handheld sender, PD_DigitalEventArgs e );
        EventHandler SetCameraQuickUrlFeedback ( PD_Handheld sender, PD_NameEventArgs e );
        EventHandler SetWindowsQuickDigitalFeedback ( PD_Handheld sender, PD_DigitalEventArgs e );
        EventHandler SetWindowsQuickSerialFeedback ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler SetWindowsQuickControlsCount ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler SetInUseChange ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Handheld sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Handheld sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Handheld sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Handheld sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Handheld sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SourceDirectChange ( INTEGER sourceNum );
        FUNCTION SourceListSelect ( INTEGER index );
        FUNCTION SoftkeyChange ( INTEGER join , INTEGER val );
        FUNCTION CustomSourceButtonPush ( INTEGER btnNum );
        FUNCTION Setup ();
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION ActivityDetected ();
        FUNCTION ConnectToRoomInList ( INTEGER index );
        FUNCTION ConnectToRoomDirect ( INTEGER roomNum );
        FUNCTION StartDefaultRoomTimer ( INTEGER roomNum );
        FUNCTION OtherRoomsOffChange ();
        FUNCTION AllRoomsOffChange ();
        FUNCTION RoomDisplaySelect ( INTEGER displayNum );
        FUNCTION ZoneOnControlChange ( INTEGER val );
        FUNCTION ZoneOffControlChange ( INTEGER val );
        FUNCTION ZoneToggleControlChange ( INTEGER val );
        FUNCTION VolumeValueControlChange ( INTEGER val );
        FUNCTION VolumeUpControlChange ( INTEGER val );
        FUNCTION VolumeDownControlChange ( INTEGER val );
        FUNCTION MuteOnControlChange ( INTEGER val );
        FUNCTION MuteOffControlChange ( INTEGER val );
        FUNCTION MuteToggleControlChange ( INTEGER val );
        FUNCTION SourceQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION LightingQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ClimateQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION DoorlockQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION WindowsQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ConnectedRoomNameFeedbackChange ( STRING roomName );
        FUNCTION ConnectedRoomNumFeedbackChange ( INTEGER roomNum );
        FUNCTION SourceListChange ( INTEGER index , STRING name , INTEGER icon );
        FUNCTION SourceListSizeChange ( INTEGER size );
        FUNCTION RoomNameListChange ( INTEGER index , STRING name );
        FUNCTION RoomNameListSizeChange ( INTEGER size );
        FUNCTION ConnectedDeviceNameFeedbackChange ( STRING deviceName );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumSourceButtons;
        INTEGER InterfaceType;
        INTEGER DefaultRoomNum;
        INTEGER MaxNumRooms;
        INTEGER MaxNumSources;
        INTEGER SourceListMode;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

    static class PD_IntercomManager 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION SendListToPanels ();
        static FUNCTION SetPanelExtension ( STRING logicId , STRING ext );
        static FUNCTION CallPanel ( PD_TouchPanel tp , INTEGER index );
        static STRING_FUNCTION GetNameFromUri ( STRING uri );
        static STRING_FUNCTION FormatIntercomUri ( STRING uri );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class PD_Interface 
    {
        // class delegates

        // class events
        EventHandler SetConnectedRoomNameFeedbackChange ( PD_Interface sender, PD_NameEventArgs e );
        EventHandler SetConnectedRoomNumFeedbackChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetConnectedRoomIndexFeedbackChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomSourceFeedbackChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomListSourceFeedbackChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomSourceNameFeedbackChange ( PD_Interface sender, PD_NameEventArgs e );
        EventHandler SetSourceListFeedbackChange ( PD_Interface sender, PD_SerialEventArgs e );
        EventHandler SetSourceListIconChange ( PD_Interface sender, PD_AnalogEventArgs e );
        EventHandler SetSourceListSizeChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomListFeedbackChange ( PD_Interface sender, PD_SerialEventArgs e );
        EventHandler SetRoomListSizeChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomVolumeFeedbackChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOnFeedbackChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOffFeedbackChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomMuteOnFeedbackChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasMultipleDisplaysFeedback ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplaySelectedFeedback ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListSize ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListItemFeedback ( PD_Interface sender, PD_SerialEventArgs e );
        EventHandler SetRoomDisplayNameSelectedFeedback ( PD_Interface sender, PD_NameEventArgs e );
        EventHandler SetConnectedDeviceNameFeedbackChange ( PD_Interface sender, PD_NameEventArgs e );
        EventHandler SetSourceQuickDigitalFeedback ( PD_Interface sender, PD_DigitalEventArgs e );
        EventHandler SetSourceQuickAnalogFeedback ( PD_Interface sender, PD_AnalogEventArgs e );
        EventHandler SetSourceQuickSerialFeedback ( PD_Interface sender, PD_SerialEventArgs e );
        EventHandler SetSourceQuickControlCount ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetLightingQuickDigitalFeedback ( PD_Interface sender, PD_DigitalEventArgs e );
        EventHandler SetLightingQuickSerialFeedback ( PD_Interface sender, PD_SerialEventArgs e );
        EventHandler SetLightingQuickControlsCount ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetClimateQuickDigitalFeedback ( PD_Interface sender, PD_DigitalEventArgs e );
        EventHandler SetClimateQuickSerialFeedback ( PD_Interface sender, PD_SerialEventArgs e );
        EventHandler SetDoorlockQuickDigitalFeedback ( PD_Interface sender, PD_DigitalEventArgs e );
        EventHandler SetDoorlockQuickSerialFeedback ( PD_Interface sender, PD_SerialEventArgs e );
        EventHandler SetCameraQuickDigitalFeedback ( PD_Interface sender, PD_DigitalEventArgs e );
        EventHandler SetCameraQuickUrlFeedback ( PD_Interface sender, PD_NameEventArgs e );
        EventHandler SetWindowsQuickDigitalFeedback ( PD_Interface sender, PD_DigitalEventArgs e );
        EventHandler SetWindowsQuickSerialFeedback ( PD_Interface sender, PD_SerialEventArgs e );
        EventHandler SetWindowsQuickControlsCount ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetAllowTimerFlagChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler SetInUseChange ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Interface sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Interface sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Interface sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Interface sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Interface sender, PD_NameEventArgs e );

        // class functions
        FUNCTION Setup ();
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION ActivityDetected ();
        FUNCTION ConnectToRoomInList ( INTEGER index );
        FUNCTION ConnectToRoomDirect ( INTEGER roomNum );
        FUNCTION StartDefaultRoomTimer ( INTEGER roomNum );
        FUNCTION OtherRoomsOffChange ();
        FUNCTION AllRoomsOffChange ();
        FUNCTION RoomDisplaySelect ( INTEGER displayNum );
        FUNCTION SourceDirectChange ( INTEGER sourceNum );
        FUNCTION SourceListSelect ( INTEGER index );
        FUNCTION ZoneOnControlChange ( INTEGER val );
        FUNCTION ZoneOffControlChange ( INTEGER val );
        FUNCTION ZoneToggleControlChange ( INTEGER val );
        FUNCTION VolumeValueControlChange ( INTEGER val );
        FUNCTION VolumeUpControlChange ( INTEGER val );
        FUNCTION VolumeDownControlChange ( INTEGER val );
        FUNCTION MuteOnControlChange ( INTEGER val );
        FUNCTION MuteOffControlChange ( INTEGER val );
        FUNCTION MuteToggleControlChange ( INTEGER val );
        FUNCTION SourceQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION LightingQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ClimateQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION DoorlockQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION WindowsQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ConnectedRoomNameFeedbackChange ( STRING roomName );
        FUNCTION ConnectedRoomNumFeedbackChange ( INTEGER roomNum );
        FUNCTION SourceListChange ( INTEGER index , STRING name , INTEGER icon );
        FUNCTION SourceListSizeChange ( INTEGER size );
        FUNCTION RoomNameListChange ( INTEGER index , STRING name );
        FUNCTION RoomNameListSizeChange ( INTEGER size );
        FUNCTION ConnectedDeviceNameFeedbackChange ( STRING deviceName );
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER InterfaceType;
        INTEGER DefaultRoomNum;
        INTEGER MaxNumRooms;
        INTEGER MaxNumSources;
        INTEGER SourceListMode;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_Keyboard 
    {
        // class delegates

        // class events
        EventHandler CapsLockFeedback ( PD_Keyboard sender, PD_ValueEventArgs e );
        EventHandler ShiftFeedback ( PD_Keyboard sender, PD_ValueEventArgs e );
        EventHandler CurrentTextFeedback ( PD_Keyboard sender, PD_NameEventArgs e );
        EventHandler ShiftModeChange ( PD_Keyboard sender, PD_ValueEventArgs e );

        // class functions
        FUNCTION Clear ();
        FUNCTION Backspace ();
        FUNCTION CapsLockToggle ();
        FUNCTION ShiftToggle ();
        FUNCTION AppendCharacter ( INTEGER charIndex );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class PD_Keypad 
    {
        // class delegates

        // class events
        EventHandler SetRoomSourceFeedbackChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetCustomSourceFeedbackChange ( PD_Keypad sender, PD_DigitalEventArgs e );
        EventHandler SetRoomZoneOffFeedbackChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetConnectedRoomNameFeedbackChange ( PD_Keypad sender, PD_NameEventArgs e );
        EventHandler SetConnectedRoomNumFeedbackChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetConnectedRoomIndexFeedbackChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomListSourceFeedbackChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomSourceNameFeedbackChange ( PD_Keypad sender, PD_NameEventArgs e );
        EventHandler SetSourceListFeedbackChange ( PD_Keypad sender, PD_SerialEventArgs e );
        EventHandler SetSourceListIconChange ( PD_Keypad sender, PD_AnalogEventArgs e );
        EventHandler SetSourceListSizeChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomListFeedbackChange ( PD_Keypad sender, PD_SerialEventArgs e );
        EventHandler SetRoomListSizeChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomVolumeFeedbackChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOnFeedbackChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomMuteOnFeedbackChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasMultipleDisplaysFeedback ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplaySelectedFeedback ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListSize ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListItemFeedback ( PD_Keypad sender, PD_SerialEventArgs e );
        EventHandler SetRoomDisplayNameSelectedFeedback ( PD_Keypad sender, PD_NameEventArgs e );
        EventHandler SetConnectedDeviceNameFeedbackChange ( PD_Keypad sender, PD_NameEventArgs e );
        EventHandler SetSourceQuickDigitalFeedback ( PD_Keypad sender, PD_DigitalEventArgs e );
        EventHandler SetSourceQuickAnalogFeedback ( PD_Keypad sender, PD_AnalogEventArgs e );
        EventHandler SetSourceQuickSerialFeedback ( PD_Keypad sender, PD_SerialEventArgs e );
        EventHandler SetSourceQuickControlCount ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetLightingQuickDigitalFeedback ( PD_Keypad sender, PD_DigitalEventArgs e );
        EventHandler SetLightingQuickSerialFeedback ( PD_Keypad sender, PD_SerialEventArgs e );
        EventHandler SetLightingQuickControlsCount ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetClimateQuickDigitalFeedback ( PD_Keypad sender, PD_DigitalEventArgs e );
        EventHandler SetClimateQuickSerialFeedback ( PD_Keypad sender, PD_SerialEventArgs e );
        EventHandler SetDoorlockQuickDigitalFeedback ( PD_Keypad sender, PD_DigitalEventArgs e );
        EventHandler SetDoorlockQuickSerialFeedback ( PD_Keypad sender, PD_SerialEventArgs e );
        EventHandler SetCameraQuickDigitalFeedback ( PD_Keypad sender, PD_DigitalEventArgs e );
        EventHandler SetCameraQuickUrlFeedback ( PD_Keypad sender, PD_NameEventArgs e );
        EventHandler SetWindowsQuickDigitalFeedback ( PD_Keypad sender, PD_DigitalEventArgs e );
        EventHandler SetWindowsQuickSerialFeedback ( PD_Keypad sender, PD_SerialEventArgs e );
        EventHandler SetWindowsQuickControlsCount ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetAllowTimerFlagChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler SetInUseChange ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Keypad sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Keypad sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Keypad sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Keypad sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Keypad sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SourceCycle ();
        FUNCTION CustomSourceButtonPush ( INTEGER btnNum );
        FUNCTION SourceDirectChange ( INTEGER sourceNum );
        FUNCTION SourceListSelect ( INTEGER index );
        FUNCTION Setup ();
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION ActivityDetected ();
        FUNCTION ConnectToRoomInList ( INTEGER index );
        FUNCTION ConnectToRoomDirect ( INTEGER roomNum );
        FUNCTION StartDefaultRoomTimer ( INTEGER roomNum );
        FUNCTION OtherRoomsOffChange ();
        FUNCTION AllRoomsOffChange ();
        FUNCTION RoomDisplaySelect ( INTEGER displayNum );
        FUNCTION ZoneOnControlChange ( INTEGER val );
        FUNCTION ZoneOffControlChange ( INTEGER val );
        FUNCTION ZoneToggleControlChange ( INTEGER val );
        FUNCTION VolumeValueControlChange ( INTEGER val );
        FUNCTION VolumeUpControlChange ( INTEGER val );
        FUNCTION VolumeDownControlChange ( INTEGER val );
        FUNCTION MuteOnControlChange ( INTEGER val );
        FUNCTION MuteOffControlChange ( INTEGER val );
        FUNCTION MuteToggleControlChange ( INTEGER val );
        FUNCTION SourceQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION LightingQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ClimateQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION DoorlockQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION WindowsQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ConnectedRoomNameFeedbackChange ( STRING roomName );
        FUNCTION ConnectedRoomNumFeedbackChange ( INTEGER roomNum );
        FUNCTION SourceListChange ( INTEGER index , STRING name , INTEGER icon );
        FUNCTION SourceListSizeChange ( INTEGER size );
        FUNCTION RoomNameListChange ( INTEGER index , STRING name );
        FUNCTION RoomNameListSizeChange ( INTEGER size );
        FUNCTION ConnectedDeviceNameFeedbackChange ( STRING deviceName );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER InterfaceType;
        INTEGER DefaultRoomNum;
        INTEGER MaxNumRooms;
        INTEGER MaxNumSources;
        INTEGER SourceListMode;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_LightingLoad 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_LightingLoad sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_LightingLoad sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_LightingLoad sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_LightingLoad sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_LightingLoad sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_LightingLoad sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_LightingLoad sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_LightingLoad sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_LightingLoad sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_LightingLoad sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_LightingSystem 
    {
        // class delegates

        // class events
        EventHandler OnDigitalOutputChange ( PD_LightingSystem sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_LightingSystem sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_LightingSystem sender, PD_SerialEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_LightingSystem sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_LightingSystem sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_LightingSystem sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_LightingSystem sender, PD_ValueEventArgs e );
        EventHandler OnBusyEvent ( PD_LightingSystem sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_LightingSystem sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_LightingSystem sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION RunGlobalScene ( INTEGER sceneNum );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumScenes;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_LightingZone 
    {
        // class delegates

        // class events
        EventHandler SetQuickControlChange ( PD_LightingZone sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_LightingZone sender, PD_DigitalEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_LightingZone sender, PD_NameEventArgs e );
        EventHandler SetInUseChange ( PD_LightingZone sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_LightingZone sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_LightingZone sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_LightingZone sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_LightingZone sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_LightingZone sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_LightingZone sender, PD_NameEventArgs e );

        // class functions
        FUNCTION RegisterWithCore ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumScenes;
        INTEGER NumLoads;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_Mlx3 
    {
        // class delegates

        // class events
        EventHandler SetRoomZoneOffFeedbackChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomSourceFeedbackChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomSourceNameFeedbackChange ( PD_Mlx3 sender, PD_NameEventArgs e );
        EventHandler SetConnectedRoomNameFeedbackChange ( PD_Mlx3 sender, PD_NameEventArgs e );
        EventHandler SetConnectedRoomNumFeedbackChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetConnectedRoomIndexFeedbackChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetPageFlipChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetControlListSizeChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetHomePageTitleChange ( PD_Mlx3 sender, PD_NameEventArgs e );
        EventHandler SetHomePageListItemTextChange ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetHomePageListSizeChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetListPageTitleChange ( PD_Mlx3 sender, PD_NameEventArgs e );
        EventHandler SetListPageTextChange ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetListPageSizeChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetListDigitalFeedbackChange ( PD_Mlx3 sender, PD_DigitalEventArgs e );
        EventHandler SetListAnalogFeedbackChange ( PD_Mlx3 sender, PD_AnalogEventArgs e );
        EventHandler SetListSerialFeedbackChange ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetAllowTimerFlagChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomListSourceFeedbackChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetSourceListFeedbackChange ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetSourceListIconChange ( PD_Mlx3 sender, PD_AnalogEventArgs e );
        EventHandler SetSourceListSizeChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomListFeedbackChange ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetRoomListSizeChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomVolumeFeedbackChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOnFeedbackChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomMuteOnFeedbackChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasMultipleDisplaysFeedback ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplaySelectedFeedback ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListSize ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListItemFeedback ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetRoomDisplayNameSelectedFeedback ( PD_Mlx3 sender, PD_NameEventArgs e );
        EventHandler SetConnectedDeviceNameFeedbackChange ( PD_Mlx3 sender, PD_NameEventArgs e );
        EventHandler SetSourceQuickDigitalFeedback ( PD_Mlx3 sender, PD_DigitalEventArgs e );
        EventHandler SetSourceQuickAnalogFeedback ( PD_Mlx3 sender, PD_AnalogEventArgs e );
        EventHandler SetSourceQuickSerialFeedback ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetSourceQuickControlCount ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetLightingQuickDigitalFeedback ( PD_Mlx3 sender, PD_DigitalEventArgs e );
        EventHandler SetLightingQuickSerialFeedback ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetLightingQuickControlsCount ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetClimateQuickDigitalFeedback ( PD_Mlx3 sender, PD_DigitalEventArgs e );
        EventHandler SetClimateQuickSerialFeedback ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetDoorlockQuickDigitalFeedback ( PD_Mlx3 sender, PD_DigitalEventArgs e );
        EventHandler SetDoorlockQuickSerialFeedback ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetCameraQuickDigitalFeedback ( PD_Mlx3 sender, PD_DigitalEventArgs e );
        EventHandler SetCameraQuickUrlFeedback ( PD_Mlx3 sender, PD_NameEventArgs e );
        EventHandler SetWindowsQuickDigitalFeedback ( PD_Mlx3 sender, PD_DigitalEventArgs e );
        EventHandler SetWindowsQuickSerialFeedback ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler SetWindowsQuickControlsCount ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler SetInUseChange ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Mlx3 sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Mlx3 sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Mlx3 sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Mlx3 sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Mlx3 sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION ActivePageChange ( INTEGER pageNum );
        FUNCTION HomePageItemSelect ( INTEGER index );
        FUNCTION ListPageItemSelect ( INTEGER index );
        FUNCTION SoftHardkeyPress ( INTEGER index );
        FUNCTION ConnectedRoomNameFeedbackChange ( STRING roomName );
        FUNCTION ConnectedRoomNumFeedbackChange ( INTEGER roomNum );
        FUNCTION ThrowPageFlip ( INTEGER pageNum );
        FUNCTION SourceDirectChange ( INTEGER sourceNum );
        FUNCTION SourceListSelect ( INTEGER index );
        FUNCTION SoftkeyChange ( INTEGER join , INTEGER val );
        FUNCTION CustomSourceButtonPush ( INTEGER btnNum );
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION ActivityDetected ();
        FUNCTION ConnectToRoomInList ( INTEGER index );
        FUNCTION ConnectToRoomDirect ( INTEGER roomNum );
        FUNCTION StartDefaultRoomTimer ( INTEGER roomNum );
        FUNCTION OtherRoomsOffChange ();
        FUNCTION AllRoomsOffChange ();
        FUNCTION RoomDisplaySelect ( INTEGER displayNum );
        FUNCTION ZoneOnControlChange ( INTEGER val );
        FUNCTION ZoneOffControlChange ( INTEGER val );
        FUNCTION ZoneToggleControlChange ( INTEGER val );
        FUNCTION VolumeValueControlChange ( INTEGER val );
        FUNCTION VolumeUpControlChange ( INTEGER val );
        FUNCTION VolumeDownControlChange ( INTEGER val );
        FUNCTION MuteOnControlChange ( INTEGER val );
        FUNCTION MuteOffControlChange ( INTEGER val );
        FUNCTION MuteToggleControlChange ( INTEGER val );
        FUNCTION SourceQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION LightingQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ClimateQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION DoorlockQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION WindowsQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION SourceListChange ( INTEGER index , STRING name , INTEGER icon );
        FUNCTION SourceListSizeChange ( INTEGER size );
        FUNCTION RoomNameListChange ( INTEGER index , STRING name );
        FUNCTION RoomNameListSizeChange ( INTEGER size );
        FUNCTION ConnectedDeviceNameFeedbackChange ( STRING deviceName );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumSourceButtons;
        INTEGER InterfaceType;
        INTEGER DefaultRoomNum;
        INTEGER MaxNumRooms;
        INTEGER MaxNumSources;
        INTEGER SourceListMode;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_MultiWindowInput 
    {
        // class delegates

        // class events
        EventHandler SetInUseChange ( PD_MultiWindowInput sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_MultiWindowInput sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_MultiWindowInput sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_MultiWindowInput sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_MultiWindowInput sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_MultiWindowInput sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_MultiWindowInput sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER InputType;
        INTEGER InputNumber;
        STRING TieLineId[];
        PD_AvEndPoint TieLine;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_NameEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING NameValue[];
    };

     class PD_Notifier 
    {
        // class delegates
        delegate FUNCTION NoticeDelegate ( SIMPLSHARPSTRING message );

        // class events

        // class functions
        FUNCTION OnNotifyEvent ( STRING message );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        DelegateProperty NoticeDelegate NoticeHandler;
    };

     class PD_OtherDevice 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_OtherDevice sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_OtherDevice sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_OtherDevice sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_OtherDevice sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_OtherDevice sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_OtherDevice sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_OtherDevice sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_OtherDevice sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_OtherDevice sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_OtherDevice sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumDefaultButtonLabels;
        INTEGER NumDefaultListLabels;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_Room 
    {
        // class delegates

        // class events
        EventHandler SetRoomSourceFeedbackChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetRoomVolumeFeedbackChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOnFeedbackChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOffFeedbackChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetRoomMuteOnFeedbackChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetLightingQuickDigitalFeedbackChange ( PD_Room sender, PD_DigitalEventArgs e );
        EventHandler SetLightingQuickSerialFeedbackChange ( PD_Room sender, PD_SerialEventArgs e );
        EventHandler SetWindowsQuickDigitalFeedbackChange ( PD_Room sender, PD_DigitalEventArgs e );
        EventHandler SetWindowsQuickSerialFeedbackChange ( PD_Room sender, PD_SerialEventArgs e );
        EventHandler SetClimateQuickDigitalFeedbackChange ( PD_Room sender, PD_DigitalEventArgs e );
        EventHandler SetClimateQuickSerialFeedbackChange ( PD_Room sender, PD_SerialEventArgs e );
        EventHandler SetDoorlockQuickDigitalFeedbackChange ( PD_Room sender, PD_DigitalEventArgs e );
        EventHandler SetDoorlockQuickSerialFeedbackChange ( PD_Room sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler OnSourceItemInUseChange ( PD_Room sender, PD_DigitalEventArgs e );
        EventHandler SetRoomNameChange ( PD_Room sender, PD_NameEventArgs e );
        EventHandler SetRoomSourceNameChange ( PD_Room sender, PD_NameEventArgs e );
        EventHandler SetRoomHasAudioChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasDisplayChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasLightingChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasClimateChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasDoorlocksChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasWindowsChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler SetInUseChange ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Room sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Room sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Room sender, PD_SerialEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Room sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Room sender, PD_NameEventArgs e );

        // class functions
        FUNCTION DoorbellCancel ();
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SubscribeToArea ( PD_Area area );
        FUNCTION UnsubscribeFromArea ( PD_Area area );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint zone );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint zone );
        FUNCTION SubscribeToDisplay ( PD_Display display );
        FUNCTION UnsubscribeFromDisplay ( PD_Display display );
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION ClearDeviceConnections ();
        FUNCTION RoomVolumeValueControlChange ( INTEGER val );
        FUNCTION RoomSourceControlChange ( INTEGER val );
        FUNCTION RoomVolumeUpControlChange ( INTEGER val );
        FUNCTION RoomVolumeDownControlChange ( INTEGER val );
        FUNCTION RoomMuteOnControlChange ( INTEGER val );
        FUNCTION RoomMuteOffControlChange ( INTEGER val );
        FUNCTION RoomMuteToggleControlChange ( INTEGER val );
        FUNCTION RoomZoneOnControlChange ( INTEGER val );
        FUNCTION RoomZoneOffControlChange ( INTEGER val );
        FUNCTION RoomZoneToggleControlChange ( INTEGER val );
        FUNCTION RoomMultiWindowAudioSourceControlChange ( INTEGER val );
        FUNCTION LightingQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ClimateQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION WindowsQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION DoorlockQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumAudioZones;
        INTEGER SelectedAudioZone;
        INTEGER DefaultAudioSwitcherType;
        INTEGER DefaultAudioSwitcherNumber;
        INTEGER DefaultAudioOutputNumber;
        INTEGER CurrentVolume;
        INTEGER NumDisplays;
        INTEGER SelectedDisplay;
        INTEGER DefaultDisplayNumber;
        INTEGER SetDisplayAudio;
        INTEGER NumLightingZones;
        INTEGER SelectedLightingZone;
        STRING DefaultLightingId[];
        INTEGER DefaultLightingZoneNumber;
        INTEGER NumTstats;
        STRING DefaultClimateId[];
        INTEGER DefaultTstatNumber;
        INTEGER NumSecurityZones;
        INTEGER NumCameras;
        STRING DefaultCameraId[];
        STRING QuickCameraInsideUrl[];
        STRING QuickCameraOutsideUrl[];
        INTEGER NumWindowZones;
        STRING DefaultWindowId[];
        INTEGER NumDoorlocks;
        STRING DefaultDoorlockId[];
        INTEGER DefaultDoorlockNumber;
        INTEGER DoorbellDisable;
        PD_Source ConnectedSource;
        INTEGER CurrentSource;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_SecuritySystem 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_SecuritySystem sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_SecuritySystem sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_SecuritySystem sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_SecuritySystem sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_SecuritySystem sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_SecuritySystem sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_SecuritySystem sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_SecuritySystem sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_SecuritySystem sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_SecuritySystem sender, PD_NameEventArgs e );

        // class functions
        FUNCTION RegisterWithCore ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumZones;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_SecurityZone 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_SecurityZone sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_SecurityZone sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_SecurityZone sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_SecurityZone sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_SecurityZone sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_SecurityZone sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_SecurityZone sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_SecurityZone sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_SecurityZone sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_SecurityZone sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_SerialEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER JoinNum;
        STRING SignalValue[];
    };

     class PD_SignalClient 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Debug ( STRING statement );
        FUNCTION ClientConnect ();
        FUNCTION ClientDisconnect ();
        FUNCTION ClientSendSignal ( PD_BridgeSignal bs );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING MasterIpAddress[];
        SIGNED_LONG_INTEGER Port;
        INTEGER DebugOn;
    };

     class PD_SignalServer 
    {
        // class delegates

        // class events

        // class functions
        FUNCTION Debug ( STRING statement );
        FUNCTION ServerStart ();
        FUNCTION ServerStop ();
        FUNCTION ServerSendSignal ( LONG_INTEGER clientIndex , PD_BridgeSignal bs );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DebugOn;
    };

    static class PD_SignalTypes // enum
    {
        static LONG_INTEGER SYSTEM;
        static LONG_INTEGER DIGITAL;
        static LONG_INTEGER ANALOG;
        static LONG_INTEGER SERIAL;
        static LONG_INTEGER CONNECTION;
        static LONG_INTEGER DISCONNECTION;
        static LONG_INTEGER GLOBALEVENT;
    };

     class PD_Source 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_Source sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_Source sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_Source sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_Source sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Source sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Source sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Source sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Source sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Source sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Source sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DefaultAudioSwitcherId;
        INTEGER DefaultAudioInputNumber;
        INTEGER DefaultVideoSwitcherId;
        INTEGER DefaultVideoInputNumber;
        INTEGER IconNum;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_SourceMultiWindow 
    {
        // class delegates

        // class events
        EventHandler OnDigitalOutputChange ( PD_SourceMultiWindow sender, PD_DigitalEventArgs e );
        EventHandler SetVideoWindowSourceFeedback ( PD_SourceMultiWindow sender, PD_AnalogEventArgs e );
        EventHandler SetAudioSourceSelectFeedback ( PD_SourceMultiWindow sender, PD_ValueEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_SourceMultiWindow sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_SourceMultiWindow sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_SourceMultiWindow sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_SourceMultiWindow sender, PD_ValueEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_SourceMultiWindow sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_SourceMultiWindow sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_SourceMultiWindow sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_SourceMultiWindow sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_SourceMultiWindow sender, PD_NameEventArgs e );

        // class functions
        FUNCTION RegisterWithCore ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION VideoLayoutSelect ( INTEGER layoutNum );
        FUNCTION VideoWindowSelect ( INTEGER windowNum );
        FUNCTION VideoWindowDirectSource ( INTEGER window , INTEGER sourceNum );
        FUNCTION VideoWindowSourceSelect ( INTEGER window , INTEGER sourceIndex );
        FUNCTION AudioSourceSelect ( INTEGER sourceNum );
        FUNCTION VideoWindowAudioSelect ( INTEGER window );
        FUNCTION VideoWindowVisible ( INTEGER window , INTEGER val );
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumVideoWindows;
        INTEGER NumVideoLayouts;
        INTEGER UseWindowVisibilityLogic;
        PD_MultiWindowInput VideoWindowBridges[];
        INTEGER AudioSource;
        INTEGER DefaultAudioSwitcherId;
        INTEGER DefaultAudioInputNumber;
        INTEGER DefaultVideoSwitcherId;
        INTEGER DefaultVideoInputNumber;
        INTEGER IconNum;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

    static class PD_SourceStandardCommands 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class PD_SourceStandardCommandsEnum // enum
    {
        static SIGNED_LONG_INTEGER Play;
        static SIGNED_LONG_INTEGER Stop;
        static SIGNED_LONG_INTEGER Pause;
        static SIGNED_LONG_INTEGER ForwardScan;
        static SIGNED_LONG_INTEGER ReverseScan;
        static SIGNED_LONG_INTEGER ForwardSkip;
        static SIGNED_LONG_INTEGER ReverseSkip;
        static SIGNED_LONG_INTEGER Record;
        static SIGNED_LONG_INTEGER PlayPause;
        static SIGNED_LONG_INTEGER Replay;
        static SIGNED_LONG_INTEGER Shuffle;
        static SIGNED_LONG_INTEGER Repeat;
        static SIGNED_LONG_INTEGER Red;
        static SIGNED_LONG_INTEGER Green;
        static SIGNED_LONG_INTEGER Yellow;
        static SIGNED_LONG_INTEGER Blue;
        static SIGNED_LONG_INTEGER UpArrow;
        static SIGNED_LONG_INTEGER DownArrow;
        static SIGNED_LONG_INTEGER LeftArrow;
        static SIGNED_LONG_INTEGER RightArrow;
        static SIGNED_LONG_INTEGER Select;
        static SIGNED_LONG_INTEGER PageUp;
        static SIGNED_LONG_INTEGER PageDown;
        static SIGNED_LONG_INTEGER _1;
        static SIGNED_LONG_INTEGER _2;
        static SIGNED_LONG_INTEGER _3;
        static SIGNED_LONG_INTEGER _4;
        static SIGNED_LONG_INTEGER _5;
        static SIGNED_LONG_INTEGER _6;
        static SIGNED_LONG_INTEGER _7;
        static SIGNED_LONG_INTEGER _8;
        static SIGNED_LONG_INTEGER _9;
        static SIGNED_LONG_INTEGER _0;
        static SIGNED_LONG_INTEGER Dash;
        static SIGNED_LONG_INTEGER Enter;
        static SIGNED_LONG_INTEGER ChannelUp;
        static SIGNED_LONG_INTEGER ChannelDown;
        static SIGNED_LONG_INTEGER Last;
        static SIGNED_LONG_INTEGER PowerOn;
        static SIGNED_LONG_INTEGER PowerOff;
        static SIGNED_LONG_INTEGER Power;
        static SIGNED_LONG_INTEGER Menu;
        static SIGNED_LONG_INTEGER TopMenu;
        static SIGNED_LONG_INTEGER PopUpMenu;
        static SIGNED_LONG_INTEGER Display;
        static SIGNED_LONG_INTEGER Home;
        static SIGNED_LONG_INTEGER Guide;
        static SIGNED_LONG_INTEGER Live;
        static SIGNED_LONG_INTEGER Dvr;
        static SIGNED_LONG_INTEGER Info;
        static SIGNED_LONG_INTEGER Options;
        static SIGNED_LONG_INTEGER Favorite;
        static SIGNED_LONG_INTEGER OnDemand;
        static SIGNED_LONG_INTEGER Audio;
        static SIGNED_LONG_INTEGER Subtitle;
        static SIGNED_LONG_INTEGER Return;
        static SIGNED_LONG_INTEGER Back;
        static SIGNED_LONG_INTEGER Exit;
    };

     class PD_SourceWithPresets 
    {
        // class delegates

        // class events
        EventHandler OnDigitalOutputChange ( PD_SourceWithPresets sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_SourceWithPresets sender, PD_DigitalEventArgs e );
        EventHandler SetQuickControlChange ( PD_SourceWithPresets sender, PD_DigitalEventArgs e );
        EventHandler SetPresetNameChange ( PD_SourceWithPresets sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_SourceWithPresets sender, PD_ValueEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_SourceWithPresets sender, PD_NameEventArgs e );
        EventHandler SetInUseChange ( PD_SourceWithPresets sender, PD_ValueEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_SourceWithPresets sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_SourceWithPresets sender, PD_SerialEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_SourceWithPresets sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_SourceWithPresets sender, PD_NameEventArgs e );

        // class functions
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION RecallPreset ( INTEGER presetNum );
        FUNCTION CommandQueueCallback ( PD_CommandQueueItem commandItem );
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DefaultAudioSwitcherId;
        INTEGER DefaultAudioInputNumber;
        INTEGER DefaultVideoSwitcherId;
        INTEGER DefaultVideoInputNumber;
        INTEGER IconNum;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_StandardCommand 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING StandardCommandString[];
        STRING Description[];
    };

    static class PD_StandardCommands 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

     class PD_StandardCommandsConstants 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static STRING AllLampsOff[];
        static STRING AllLampsOn[];
        static STRING Antenna[];
        static STRING ArrowDown[];
        static STRING ArrowLeft[];
        static STRING ArrowRight[];
        static STRING ArrowUp[];
        static STRING Aspect1[];
        static STRING Aspect2[];
        static STRING Aspect3[];
        static STRING Aspect4[];
        static STRING Aspect5[];
        static STRING Aspect6[];
        static STRING Aspect7[];
        static STRING Aspect8[];
        static STRING AspectPoll[];
        static STRING Asterisk[];
        static STRING AudioMute[];
        static STRING AudioMuteOff[];
        static STRING AudioMuteOn[];
        static STRING AudioMutePoll[];
        static STRING Auto[];
        static STRING Aux1[];
        static STRING Aux2[];
        static STRING ChannelUp[];
        static STRING ChannelDown[];
        static STRING ChannelPoll[];
        static STRING ChannelTune[];
        static STRING Custom1[];
        static STRING Custom1Poll[];
        static STRING Custom2[];
        static STRING Custom2Poll[];
        static STRING Custom3[];
        static STRING Custom3Poll[];
        static STRING Custom4[];
        static STRING Custom4Poll[];
        static STRING Custom5[];
        static STRING Custom5Poll[];
        static STRING Eject[];
        static STRING Enter[];
        static STRING Error1[];
        static STRING Error10[];
        static STRING Error2[];
        static STRING Error3[];
        static STRING Error4[];
        static STRING Error5[];
        static STRING Error6[];
        static STRING Error7[];
        static STRING Error8[];
        static STRING Error9[];
        static STRING ErrorPoll[];
        static STRING Home[];
        static STRING Info[];
        static STRING Input1[];
        static STRING Input10[];
        static STRING Input2[];
        static STRING Input3[];
        static STRING Input4[];
        static STRING Input5[];
        static STRING Input6[];
        static STRING Input7[];
        static STRING Input8[];
        static STRING Input9[];
        static STRING InputPoll[];
        static STRING Mute[];
        static STRING MuteOff[];
        static STRING MuteOn[];
        static STRING MutePoll[];
        static STRING Osd[];
        static STRING OsdOff[];
        static STRING OsdOn[];
        static STRING OsdPoll[];
        static STRING Power[];
        static STRING PowerOff[];
        static STRING PowerOn[];
        static STRING PowerPoll[];
        static STRING VideoMute[];
        static STRING VideoMuteOff[];
        static STRING VideoMuteOn[];
        static STRING VideoMutePoll[];
        static STRING VolMinus[];
        static STRING VolPlus[];
        static STRING Vol[];
        static STRING VolumePoll[];
        static STRING _0[];
        static STRING _1[];
        static STRING _2[];
        static STRING _3[];
        static STRING _4[];
        static STRING _5[];
        static STRING _6[];
        static STRING _7[];
        static STRING _8[];
        static STRING _9[];
        static STRING Octothorpe[];
        static STRING KeypadBackSpace[];
        static STRING Vga1[];
        static STRING Vga10[];
        static STRING Vga2[];
        static STRING Vga3[];
        static STRING Vga4[];
        static STRING Vga5[];
        static STRING Vga6[];
        static STRING Vga7[];
        static STRING Vga8[];
        static STRING Vga9[];
        static STRING Hdmi1[];
        static STRING Hdmi10[];
        static STRING Hdmi2[];
        static STRING Hdmi3[];
        static STRING Hdmi4[];
        static STRING Hdmi5[];
        static STRING Hdmi6[];
        static STRING Hdmi7[];
        static STRING Hdmi8[];
        static STRING Hdmi9[];
        static STRING Dvi1[];
        static STRING Dvi10[];
        static STRING Dvi2[];
        static STRING Dvi3[];
        static STRING Dvi4[];
        static STRING Dvi5[];
        static STRING Dvi6[];
        static STRING Dvi7[];
        static STRING Dvi8[];
        static STRING Dvi9[];
        static STRING Component1[];
        static STRING Component10[];
        static STRING Component2[];
        static STRING Component3[];
        static STRING Component4[];
        static STRING Component5[];
        static STRING Component6[];
        static STRING Component7[];
        static STRING Component8[];
        static STRING Component9[];
        static STRING Composite1[];
        static STRING Composite10[];
        static STRING Composite2[];
        static STRING Composite3[];
        static STRING Composite4[];
        static STRING Composite5[];
        static STRING Composite6[];
        static STRING Composite7[];
        static STRING Composite8[];
        static STRING Composite9[];
        static STRING DisplayPort1[];
        static STRING DisplayPort10[];
        static STRING DisplayPort2[];
        static STRING DisplayPort3[];
        static STRING DisplayPort4[];
        static STRING DisplayPort5[];
        static STRING DisplayPort6[];
        static STRING DisplayPort7[];
        static STRING DisplayPort8[];
        static STRING DisplayPort9[];
        static STRING Usb1[];
        static STRING Usb2[];
        static STRING Usb3[];
        static STRING Usb4[];
        static STRING Usb5[];
        static STRING Antenna1[];
        static STRING Antenna2[];
        static STRING Network1[];
        static STRING Network10[];
        static STRING Network2[];
        static STRING Network3[];
        static STRING Network4[];
        static STRING Network5[];
        static STRING Network6[];
        static STRING Network7[];
        static STRING Network8[];
        static STRING Network9[];
        static STRING Audio[];
        static STRING Blue[];
        static STRING Clear[];
        static STRING Display[];
        static STRING DownArrow[];
        static STRING UpArrow[];
        static STRING LeftArrow[];
        static STRING RightArrow[];
        static STRING Exit[];
        static STRING ForwardScan[];
        static STRING ReverseScan[];
        static STRING Green[];
        static STRING Options[];
        static STRING Pause[];
        static STRING Play[];
        static STRING Red[];
        static STRING Repeat[];
        static STRING Return[];
        static STRING Stop[];
        static STRING Subtitle[];
        static STRING TopMenu[];
        static STRING ForwardSkip[];
        static STRING ReverseSkip[];
        static STRING Yellow[];
        static STRING PopUpMenu[];
        static STRING Menu[];
        static STRING A[];
        static STRING B[];
        static STRING C[];
        static STRING D[];
        static STRING Back[];
        static STRING Dvr[];
        static STRING Favorite[];
        static STRING Guide[];
        static STRING Last[];
        static STRING Live[];
        static STRING PageDown[];
        static STRING PageUp[];
        static STRING Record[];
        static STRING Replay[];
        static STRING SpeedSlow[];
        static STRING LampHoursPoll[];
        static STRING PlayBackStatusPoll[];
        static STRING TrackPoll[];
        static STRING TrackElapsedTimePoll[];
        static STRING ChapterElapsedTimePoll[];
        static STRING ChapterPoll[];
        static STRING TotalElapsedTimePoll[];
        static STRING TrackRemainingTimePoll[];
        static STRING ChapterRemainingTimePoll[];
        static STRING TotalRemainingTimePoll[];
        static STRING ThumbsUp[];
        static STRING ThumbsDown[];
        static STRING Channel[];
        static STRING Dash[];
        static STRING Period[];
        static STRING PlayPause[];
        static STRING Shuffle[];
        static STRING Select[];
        static STRING OnDemand[];

        // class properties
    };

    static class PD_StandardCommandsEnum // enum
    {
        static SIGNED_LONG_INTEGER Vga1;
        static SIGNED_LONG_INTEGER Vga10;
        static SIGNED_LONG_INTEGER Vga2;
        static SIGNED_LONG_INTEGER Vga3;
        static SIGNED_LONG_INTEGER Vga4;
        static SIGNED_LONG_INTEGER Vga5;
        static SIGNED_LONG_INTEGER Vga6;
        static SIGNED_LONG_INTEGER Vga7;
        static SIGNED_LONG_INTEGER Vga8;
        static SIGNED_LONG_INTEGER Vga9;
        static SIGNED_LONG_INTEGER Hdmi1;
        static SIGNED_LONG_INTEGER Hdmi10;
        static SIGNED_LONG_INTEGER Hdmi2;
        static SIGNED_LONG_INTEGER Hdmi3;
        static SIGNED_LONG_INTEGER Hdmi4;
        static SIGNED_LONG_INTEGER Hdmi5;
        static SIGNED_LONG_INTEGER Hdmi6;
        static SIGNED_LONG_INTEGER Hdmi7;
        static SIGNED_LONG_INTEGER Hdmi8;
        static SIGNED_LONG_INTEGER Hdmi9;
        static SIGNED_LONG_INTEGER Dvi1;
        static SIGNED_LONG_INTEGER Dvi10;
        static SIGNED_LONG_INTEGER Dvi2;
        static SIGNED_LONG_INTEGER Dvi3;
        static SIGNED_LONG_INTEGER Dvi4;
        static SIGNED_LONG_INTEGER Dvi5;
        static SIGNED_LONG_INTEGER Dvi6;
        static SIGNED_LONG_INTEGER Dvi7;
        static SIGNED_LONG_INTEGER Dvi8;
        static SIGNED_LONG_INTEGER Dvi9;
        static SIGNED_LONG_INTEGER Component1;
        static SIGNED_LONG_INTEGER Component10;
        static SIGNED_LONG_INTEGER Component2;
        static SIGNED_LONG_INTEGER Component3;
        static SIGNED_LONG_INTEGER Component4;
        static SIGNED_LONG_INTEGER Component5;
        static SIGNED_LONG_INTEGER Component6;
        static SIGNED_LONG_INTEGER Component7;
        static SIGNED_LONG_INTEGER Component8;
        static SIGNED_LONG_INTEGER Component9;
        static SIGNED_LONG_INTEGER Composite1;
        static SIGNED_LONG_INTEGER Composite10;
        static SIGNED_LONG_INTEGER Composite2;
        static SIGNED_LONG_INTEGER Composite3;
        static SIGNED_LONG_INTEGER Composite4;
        static SIGNED_LONG_INTEGER Composite5;
        static SIGNED_LONG_INTEGER Composite6;
        static SIGNED_LONG_INTEGER Composite7;
        static SIGNED_LONG_INTEGER Composite8;
        static SIGNED_LONG_INTEGER Composite9;
        static SIGNED_LONG_INTEGER DisplayPort1;
        static SIGNED_LONG_INTEGER DisplayPort10;
        static SIGNED_LONG_INTEGER DisplayPort2;
        static SIGNED_LONG_INTEGER DisplayPort3;
        static SIGNED_LONG_INTEGER DisplayPort4;
        static SIGNED_LONG_INTEGER DisplayPort5;
        static SIGNED_LONG_INTEGER DisplayPort6;
        static SIGNED_LONG_INTEGER DisplayPort7;
        static SIGNED_LONG_INTEGER DisplayPort8;
        static SIGNED_LONG_INTEGER DisplayPort9;
        static SIGNED_LONG_INTEGER Usb1;
        static SIGNED_LONG_INTEGER Usb2;
        static SIGNED_LONG_INTEGER Usb3;
        static SIGNED_LONG_INTEGER Usb4;
        static SIGNED_LONG_INTEGER Usb5;
        static SIGNED_LONG_INTEGER Antenna1;
        static SIGNED_LONG_INTEGER Antenna2;
        static SIGNED_LONG_INTEGER Network1;
        static SIGNED_LONG_INTEGER Network10;
        static SIGNED_LONG_INTEGER Network2;
        static SIGNED_LONG_INTEGER Network3;
        static SIGNED_LONG_INTEGER Network4;
        static SIGNED_LONG_INTEGER Network5;
        static SIGNED_LONG_INTEGER Network6;
        static SIGNED_LONG_INTEGER Network7;
        static SIGNED_LONG_INTEGER Network8;
        static SIGNED_LONG_INTEGER Network9;
        static SIGNED_LONG_INTEGER Input1;
        static SIGNED_LONG_INTEGER Input10;
        static SIGNED_LONG_INTEGER Input2;
        static SIGNED_LONG_INTEGER Input3;
        static SIGNED_LONG_INTEGER Input4;
        static SIGNED_LONG_INTEGER Input5;
        static SIGNED_LONG_INTEGER Input6;
        static SIGNED_LONG_INTEGER Input7;
        static SIGNED_LONG_INTEGER Input8;
        static SIGNED_LONG_INTEGER Input9;
        static SIGNED_LONG_INTEGER AspectSideBar;
        static SIGNED_LONG_INTEGER AspectStrech;
        static SIGNED_LONG_INTEGER AspectZoom;
        static SIGNED_LONG_INTEGER AspectNormal;
        static SIGNED_LONG_INTEGER AspectDotByDot;
        static SIGNED_LONG_INTEGER AspectFullScreen;
        static SIGNED_LONG_INTEGER AspectAuto;
        static SIGNED_LONG_INTEGER AspectOriginal;
        static SIGNED_LONG_INTEGER Aspect16By9;
        static SIGNED_LONG_INTEGER AspectWideZoom;
        static SIGNED_LONG_INTEGER Aspect4By3;
        static SIGNED_LONG_INTEGER AspectSubTitle;
        static SIGNED_LONG_INTEGER AspectJust;
        static SIGNED_LONG_INTEGER AspectZoom2;
        static SIGNED_LONG_INTEGER AspectZoom3;
        static SIGNED_LONG_INTEGER AspectRatio1;
        static SIGNED_LONG_INTEGER AspectRatio2;
        static SIGNED_LONG_INTEGER AspectRatio3;
        static SIGNED_LONG_INTEGER AspectRatio4;
        static SIGNED_LONG_INTEGER AspectRatio5;
        static SIGNED_LONG_INTEGER AspectRatio6;
        static SIGNED_LONG_INTEGER AspectRatio7;
        static SIGNED_LONG_INTEGER AspectRatio8;
        static SIGNED_LONG_INTEGER AspectRatio9;
        static SIGNED_LONG_INTEGER AspectRatio10;
        static SIGNED_LONG_INTEGER AspectRatio11;
        static SIGNED_LONG_INTEGER AspectRatioPoll;
        static SIGNED_LONG_INTEGER AvStandard;
        static SIGNED_LONG_INTEGER AvMovie;
        static SIGNED_LONG_INTEGER AvGame;
        static SIGNED_LONG_INTEGER AvUser;
        static SIGNED_LONG_INTEGER AvDynamicFixed;
        static SIGNED_LONG_INTEGER AvDynamic;
        static SIGNED_LONG_INTEGER AvPc;
        static SIGNED_LONG_INTEGER AvXvColor;
        static SIGNED_LONG_INTEGER AvVintageMovie;
        static SIGNED_LONG_INTEGER AvStandard3D;
        static SIGNED_LONG_INTEGER AvMovie3D;
        static SIGNED_LONG_INTEGER AvGame3D;
        static SIGNED_LONG_INTEGER AvAuto;
        static SIGNED_LONG_INTEGER AvPoll;
        static SIGNED_LONG_INTEGER AllLampsOff;
        static SIGNED_LONG_INTEGER AllLampsOn;
        static SIGNED_LONG_INTEGER Antenna;
        static SIGNED_LONG_INTEGER DownArrow;
        static SIGNED_LONG_INTEGER LeftArrow;
        static SIGNED_LONG_INTEGER RightArrow;
        static SIGNED_LONG_INTEGER UpArrow;
        static SIGNED_LONG_INTEGER Asterisk;
        static SIGNED_LONG_INTEGER Mute;
        static SIGNED_LONG_INTEGER MuteOff;
        static SIGNED_LONG_INTEGER MuteOn;
        static SIGNED_LONG_INTEGER Auto;
        static SIGNED_LONG_INTEGER Aux1;
        static SIGNED_LONG_INTEGER Aux2;
        static SIGNED_LONG_INTEGER Channel;
        static SIGNED_LONG_INTEGER DigitalChannel;
        static SIGNED_LONG_INTEGER AnalogChannel;
        static SIGNED_LONG_INTEGER ChannelUp;
        static SIGNED_LONG_INTEGER ChannelDown;
        static SIGNED_LONG_INTEGER ChannelPoll;
        static SIGNED_LONG_INTEGER Tune;
        static SIGNED_LONG_INTEGER Eject;
        static SIGNED_LONG_INTEGER Enter;
        static SIGNED_LONG_INTEGER Home;
        static SIGNED_LONG_INTEGER Info;
        static SIGNED_LONG_INTEGER InputPoll;
        static SIGNED_LONG_INTEGER MutePoll;
        static SIGNED_LONG_INTEGER Osd;
        static SIGNED_LONG_INTEGER OsdOff;
        static SIGNED_LONG_INTEGER OsdOn;
        static SIGNED_LONG_INTEGER OsdPoll;
        static SIGNED_LONG_INTEGER Power;
        static SIGNED_LONG_INTEGER PowerOff;
        static SIGNED_LONG_INTEGER PowerOn;
        static SIGNED_LONG_INTEGER PowerPoll;
        static SIGNED_LONG_INTEGER PictureMute;
        static SIGNED_LONG_INTEGER PictureMuteOff;
        static SIGNED_LONG_INTEGER PictureMuteOn;
        static SIGNED_LONG_INTEGER VideoMutePoll;
        static SIGNED_LONG_INTEGER VolMinus;
        static SIGNED_LONG_INTEGER VolPlus;
        static SIGNED_LONG_INTEGER Vol;
        static SIGNED_LONG_INTEGER VolumePoll;
        static SIGNED_LONG_INTEGER _0;
        static SIGNED_LONG_INTEGER _1;
        static SIGNED_LONG_INTEGER _2;
        static SIGNED_LONG_INTEGER _3;
        static SIGNED_LONG_INTEGER _4;
        static SIGNED_LONG_INTEGER _5;
        static SIGNED_LONG_INTEGER _6;
        static SIGNED_LONG_INTEGER _7;
        static SIGNED_LONG_INTEGER _8;
        static SIGNED_LONG_INTEGER _9;
        static SIGNED_LONG_INTEGER Octothorpe;
        static SIGNED_LONG_INTEGER Nop;
        static SIGNED_LONG_INTEGER Audio;
        static SIGNED_LONG_INTEGER Blue;
        static SIGNED_LONG_INTEGER Clear;
        static SIGNED_LONG_INTEGER Display;
        static SIGNED_LONG_INTEGER Exit;
        static SIGNED_LONG_INTEGER ForwardScan;
        static SIGNED_LONG_INTEGER ReverseScan;
        static SIGNED_LONG_INTEGER Green;
        static SIGNED_LONG_INTEGER Options;
        static SIGNED_LONG_INTEGER Pause;
        static SIGNED_LONG_INTEGER Play;
        static SIGNED_LONG_INTEGER Red;
        static SIGNED_LONG_INTEGER Repeat;
        static SIGNED_LONG_INTEGER Return;
        static SIGNED_LONG_INTEGER Stop;
        static SIGNED_LONG_INTEGER Subtitle;
        static SIGNED_LONG_INTEGER TopMenu;
        static SIGNED_LONG_INTEGER ForwardSkip;
        static SIGNED_LONG_INTEGER ReverseSkip;
        static SIGNED_LONG_INTEGER Yellow;
        static SIGNED_LONG_INTEGER PopUpMenu;
        static SIGNED_LONG_INTEGER Menu;
        static SIGNED_LONG_INTEGER A;
        static SIGNED_LONG_INTEGER B;
        static SIGNED_LONG_INTEGER C;
        static SIGNED_LONG_INTEGER D;
        static SIGNED_LONG_INTEGER Back;
        static SIGNED_LONG_INTEGER Dvr;
        static SIGNED_LONG_INTEGER Favorite;
        static SIGNED_LONG_INTEGER Guide;
        static SIGNED_LONG_INTEGER Last;
        static SIGNED_LONG_INTEGER Live;
        static SIGNED_LONG_INTEGER PageDown;
        static SIGNED_LONG_INTEGER PageUp;
        static SIGNED_LONG_INTEGER Record;
        static SIGNED_LONG_INTEGER Replay;
        static SIGNED_LONG_INTEGER SpeedSlow;
        static SIGNED_LONG_INTEGER LampHoursPoll;
        static SIGNED_LONG_INTEGER KeypadBackSpace;
        static SIGNED_LONG_INTEGER PlayBackStatusPoll;
        static SIGNED_LONG_INTEGER TrackPoll;
        static SIGNED_LONG_INTEGER ChapterPoll;
        static SIGNED_LONG_INTEGER TrackElapsedTimePoll;
        static SIGNED_LONG_INTEGER ChapterElapsedTimePoll;
        static SIGNED_LONG_INTEGER TotalElapsedTimePoll;
        static SIGNED_LONG_INTEGER TrackRemainingTimePoll;
        static SIGNED_LONG_INTEGER ChapterRemainingTimePoll;
        static SIGNED_LONG_INTEGER TotalRemainingTimePoll;
        static SIGNED_LONG_INTEGER ThumbsUp;
        static SIGNED_LONG_INTEGER ThumbsDown;
        static SIGNED_LONG_INTEGER Dash;
        static SIGNED_LONG_INTEGER Period;
        static SIGNED_LONG_INTEGER PlayPause;
        static SIGNED_LONG_INTEGER Shuffle;
        static SIGNED_LONG_INTEGER Select;
        static SIGNED_LONG_INTEGER OnDemand;
    };

     class PD_Switcher 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_Switcher sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_Switcher sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_Switcher sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_Switcher sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Switcher sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Switcher sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Switcher sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Switcher sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Switcher sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Switcher sender, PD_NameEventArgs e );

        // class functions
        FUNCTION RegisterWithCore ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumInputs;
        PD_AvInput InputBridges[];
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_TouchPanel 
    {
        // class delegates

        // class events
        EventHandler SetPanelControlSourceFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetPageFlipChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetDeviceSubpageChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasAudio ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasDisplays ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasLighting ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasClimate ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasSecurity ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasCameras ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasWindows ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasDoors ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetHomePageItemSelected ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetHomePageTitleChange ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetHomePageItemTextChange ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetHomePageItemIconChange ( PD_TouchPanel sender, PD_AnalogEventArgs e );
        EventHandler SetHomePageItemEnableChange ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetHomePageItemVisibleChange ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetDefaultRoomNameFeedback ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetDefaultRoomTimeoutFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetDefaultPageNumFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetDefaultPageTimeoutFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetControlListDigitalFeedbackChange ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetControlListSerialFeedbackChange ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetControlListSizeChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetLocalDeviceSelectedChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetGlobalDeviceSelectedChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetHomePageTypeChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetAllowRoamingChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetAllowGlobalLightsChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetAllowGlobalClimateChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetAllowGlobalSecurityChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetAllowGlobalCamerasChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetAllowGlobalWindowsChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetAllowGlobalDoorsChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetConnectedRoomNumFeedbackChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetConnectedRoomIndexFeedbackChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomSourceFeedbackChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomListSourceFeedbackChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomSourceNameFeedbackChange ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetDemoExpiredChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler OnPanelBusyEvent ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetOtherDeviceNumberChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetKeyboardCapsLockFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetKeyboardShiftFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetKeyboardCurrentTextFeedback ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetKeyboardShiftModeChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetCameraNamesListFeedback ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetCameraSelectedFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetCameraNamesListSize ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetCameraVideoTypeChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomHasMultipleDisplaysFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplaySelectedFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListSize ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomDisplayListItemFeedback ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetRoomDisplayNameSelectedFeedback ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetShowShareButtonChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetSourceItemInUseChange ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetCurrentAreaNameFeedback ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetRoomListItemEnableFeedback ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetShowAreaControlsFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetShowVolumeFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetAllowTimerFlagChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomSelectFeedback ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetMultiroomVolumeFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomModeSelectFeedback ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomShowSourceList ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomSourceListSizeChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomSourceListFeedbackChange ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetMultiroomSourceListIconChange ( PD_TouchPanel sender, PD_AnalogEventArgs e );
        EventHandler SetMultiroomSelectedSourceName ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetMultiroomSelectedSourceIndex ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomControlNowVisibility ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomShowSceneEditPopup ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomShowSceneSavePopup ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomSceneListSizeChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetMultiroomSceneNamesListChange ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetIntercomHangupChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetIntercomIncomingNameChange ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetIntercomListItemTextChange ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetIntercomListItemOnlineChange ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetIntercomListItemAvailableStatusChange ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetIntercomStringToDialChange ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetDoorbellMessage ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetDoorbellChime ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetDoorbellCameraVisibleChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetDoorbellIntercomVisibleChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetDoorbellControlsVisibleChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetConnectedRoomNameFeedbackChange ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetSourceListFeedbackChange ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetSourceListIconChange ( PD_TouchPanel sender, PD_AnalogEventArgs e );
        EventHandler SetSourceListSizeChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomListFeedbackChange ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetRoomListSizeChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomVolumeFeedbackChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOnFeedbackChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomZoneOffFeedbackChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetRoomMuteOnFeedbackChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetConnectedDeviceNameFeedbackChange ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetSourceQuickDigitalFeedback ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetSourceQuickAnalogFeedback ( PD_TouchPanel sender, PD_AnalogEventArgs e );
        EventHandler SetSourceQuickSerialFeedback ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetSourceQuickControlCount ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetLightingQuickDigitalFeedback ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetLightingQuickSerialFeedback ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetLightingQuickControlsCount ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetClimateQuickDigitalFeedback ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetClimateQuickSerialFeedback ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetDoorlockQuickDigitalFeedback ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetDoorlockQuickSerialFeedback ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetCameraQuickDigitalFeedback ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetCameraQuickUrlFeedback ( PD_TouchPanel sender, PD_NameEventArgs e );
        EventHandler SetWindowsQuickDigitalFeedback ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler SetWindowsQuickSerialFeedback ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler SetWindowsQuickControlsCount ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler SetInUseChange ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_TouchPanel sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_TouchPanel sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_TouchPanel sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_TouchPanel sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_TouchPanel sender, PD_NameEventArgs e );

        // class functions
        FUNCTION DoorbellEndCall ();
        FUNCTION LocalDeviceSelectedChange ( INTEGER val );
        FUNCTION GlobalDeviceSelectedChange ( INTEGER val );
        FUNCTION ConnectedRoomNumFeedbackChange ( INTEGER roomNum );
        FUNCTION DemoExpired ();
        FUNCTION MultiroomSelectFeedback ( INTEGER index , INTEGER val );
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION ControlDevice ( STRING targetId );
        FUNCTION SetOnlineStatus ( INTEGER state );
        FUNCTION ActivityDetected ();
        FUNCTION StartDefaultPageTimer ( INTEGER pageNum );
        FUNCTION RoomDisplaySelect ( INTEGER displayNum );
        FUNCTION ConnectToRoomInList ( INTEGER index );
        FUNCTION ConnectedFromOutsideNetwork ( INTEGER state );
        FUNCTION SourceListSelect ( INTEGER index );
        FUNCTION SourceDirectChange ( INTEGER sourceNum );
        FUNCTION BackButton ();
        FUNCTION PageSelect ( INTEGER pageNum );
        FUNCTION PageBack ();
        FUNCTION ThrowDeviceSubpage ( INTEGER subpgNum );
        FUNCTION HomePageItemSelect ( INTEGER index );
        FUNCTION SelectDeviceOnPage ( INTEGER index );
        FUNCTION ConnectToLightingZoneNum ( INTEGER devNum );
        FUNCTION ConnectToTstatNum ( INTEGER devNum );
        FUNCTION ConnectToDoorlockNum ( INTEGER devNum );
        FUNCTION HomeSelect ();
        FUNCTION MediaSelect ();
        FUNCTION LightingSelect ();
        FUNCTION ClimateSelect ();
        FUNCTION SecuritySelect ();
        FUNCTION CamerasSelect ();
        FUNCTION WindowsSelect ();
        FUNCTION DoorsSelect ();
        FUNCTION LocalDeviceSelect ();
        FUNCTION GlobalDeviceSelect ();
        FUNCTION OtherDeviceSelect ( INTEGER devNum );
        FUNCTION DirectOtherDeviceSelect ( INTEGER devNum );
        FUNCTION ControlListItemChange ( INTEGER join , INTEGER val );
        FUNCTION KeyboardClear ();
        FUNCTION KeyboardBackspace ();
        FUNCTION KeyboardCapsLockToggle ();
        FUNCTION KeyboardShiftToggle ();
        FUNCTION KeyboardCharacter ( INTEGER charIndex );
        FUNCTION KeyboardSave ();
        FUNCTION KeyboardCancelEdit ();
        FUNCTION SetDefaultRoomNum ();
        FUNCTION SetDefaultRoomTimeout ( INTEGER minutes );
        FUNCTION SetDefaultPageNum ( INTEGER pageNum );
        FUNCTION SetDefaultPageTimeout ( INTEGER minutes );
        FUNCTION ViewCamera ( INTEGER camNum );
        FUNCTION AreaNextSelect ();
        FUNCTION AreaPreviousSelect ();
        FUNCTION AreaSelect ( INTEGER index );
        FUNCTION AreaOff ();
        FUNCTION EnableSourceShareMode ();
        FUNCTION DisableSourceShareMode ();
        FUNCTION MultiroomRoomSelect ( INTEGER index );
        FUNCTION MultiroomClearSelections ();
        FUNCTION MultiroomSelectAll ();
        FUNCTION MultiroomControlSelectedSource ();
        FUNCTION MultiroomModeSelect ( INTEGER mode );
        FUNCTION MultiroomSceneRecall ( INTEGER index );
        FUNCTION MultiroomSceneStore ( INTEGER index );
        FUNCTION MultiroomAddNewScene ();
        FUNCTION MultiroomCancelSceneEdit ();
        FUNCTION MultiroomReplaceScene ();
        FUNCTION MultiroomDeleteScene ();
        FUNCTION MultiroomSaveScene ();
        FUNCTION MultiroomVolumeControlChange ( INTEGER val );
        FUNCTION MultiroomSourceControlChange ( INTEGER index );
        FUNCTION MultiroomZoneOffControlChange ();
        FUNCTION MultiroomSourceListChange ( INTEGER index , STRING name , INTEGER icon );
        FUNCTION IntercomItemSelect ( INTEGER index );
        FUNCTION SetIntercomCallActive ( INTEGER state );
        FUNCTION SetIntercomIncomingUri ( STRING uri );
        FUNCTION SendIntercomStringToDial ( STRING uri );
        FUNCTION IntercomHangup ();
        FUNCTION DoorbellCancelThisRoom ();
        FUNCTION DoorbellCancelAll ();
        FUNCTION DoorbellAnswer ();
        FUNCTION ConnectToRoomDirect ( INTEGER roomNum );
        FUNCTION StartDefaultRoomTimer ( INTEGER roomNum );
        FUNCTION OtherRoomsOffChange ();
        FUNCTION AllRoomsOffChange ();
        FUNCTION ZoneOnControlChange ( INTEGER val );
        FUNCTION ZoneOffControlChange ( INTEGER val );
        FUNCTION ZoneToggleControlChange ( INTEGER val );
        FUNCTION VolumeValueControlChange ( INTEGER val );
        FUNCTION VolumeUpControlChange ( INTEGER val );
        FUNCTION VolumeDownControlChange ( INTEGER val );
        FUNCTION MuteOnControlChange ( INTEGER val );
        FUNCTION MuteOffControlChange ( INTEGER val );
        FUNCTION MuteToggleControlChange ( INTEGER val );
        FUNCTION SourceQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION LightingQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ClimateQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION DoorlockQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION WindowsQuickControlChange ( INTEGER join , INTEGER val );
        FUNCTION ConnectedRoomNameFeedbackChange ( STRING roomName );
        FUNCTION SourceListChange ( INTEGER index , STRING name , INTEGER icon );
        FUNCTION SourceListSizeChange ( INTEGER size );
        FUNCTION RoomNameListChange ( INTEGER index , STRING name );
        FUNCTION RoomNameListSizeChange ( INTEGER size );
        FUNCTION ConnectedDeviceNameFeedbackChange ( STRING deviceName );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        STRING IntercomUri[];
        INTEGER HomePageType;
        INTEGER InterfaceType;
        INTEGER DefaultRoomNum;
        INTEGER MaxNumRooms;
        INTEGER MaxNumSources;
        INTEGER SourceListMode;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

    static class Y2GHEGGAYMVDPB9V3EBMULCFMTJJQYXG // enum
    {
        INTEGER __class_id__;
    };

     class PD_Tstat 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_Tstat sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_Tstat sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_Tstat sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_Tstat sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_Tstat sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_Tstat sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_Tstat sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_Tstat sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_Tstat sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_Tstat sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        static INTEGER cSetpointUp;
        static INTEGER cSetpointDown;
        static INTEGER cHeatSetpointUp;
        static INTEGER cHeatSetpointDown;
        static INTEGER cCoolSetpointUp;
        static INTEGER cCoolSetpointDown;
        static INTEGER cHeatMode;
        static INTEGER cCoolMode;
        static INTEGER cAutoMode;
        static INTEGER cOffMode;
        static INTEGER cFanOn;
        static INTEGER cFanAuto;
        static INTEGER cHeatSetpoint;
        static INTEGER cCoolSetpoint;
        static INTEGER cAutoSetpoint;
        static INTEGER cCurrentTemp;
        static INTEGER cCurrentSetpoint;

        // class properties
        STRING CurrentMode[];
        STRING CurrentFanMode[];
        STRING CurrentTemp[];
        STRING CurrentSingleSetpoint[];
        STRING CurrentCoolSetpoint[];
        STRING CurrentHeatSetpoint[];
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_User 
    {
        // class delegates

        // class events
        EventHandler SetSceneNameFeedback ( PD_User sender, PD_SerialEventArgs e );
        EventHandler UpdateScenesEvent ( PD_User sender, PD_ValueEventArgs e );
        EventHandler SetSceneRecalled ( PD_User sender, PD_DigitalEventArgs e );
        EventHandler SetAllRoomsOffRecalled ( PD_User sender, PD_ValueEventArgs e );
        EventHandler SetInUseChange ( PD_User sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_User sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_User sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_User sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_User sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_User sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_User sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION RecallAllRoomsOffScene ();
        FUNCTION RecallScene ( INTEGER sceneNum );
        FUNCTION StoreScene ( INTEGER sceneNum , STRING name , PD_Interface ui );
        FUNCTION DeleteScene ( INTEGER sceneNum );
        FUNCTION StoreChannelPreset ( STRING sourceId , INTEGER presetNum , PD_ChannelPreset preset );
        FUNCTION DeleteChannelPreset ( STRING sourceId , INTEGER presetNum );
        FUNCTION RefreshData ();
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        FUNCTION UnsubscribeFromInterface ( PD_Interface subscriber );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumScenes;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_ValueEventArgs 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER SignalValue;
    };

     class PD_VideoOutput 
    {
        // class delegates

        // class events
        EventHandler SetSourceControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetAudioSourceControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetZoneOnControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetZoneOffControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetZoneToggleControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetVolumeValueControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetVolumeUpControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetVolumeDownControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetMuteOnControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetMuteOffControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetMuteToggleControlChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_VideoOutput sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_VideoOutput sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_VideoOutput sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_VideoOutput sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_VideoOutput sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_VideoOutput sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_VideoOutput sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_VideoOutput sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SourceFeedbackChange ( INTEGER val );
        FUNCTION VolumeFeedbackChange ( INTEGER val );
        FUNCTION ZoneOnFeedbackChange ( INTEGER val );
        FUNCTION MuteOnFeedbackChange ( INTEGER val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER OutputNumber;
        INTEGER NumInputs;
        PD_AvInput InputBridges[];
        INTEGER LastSourceNumSent;
        INTEGER ZonePowerStatus;
        INTEGER MuteStatus;
        INTEGER VolumeStatus;
        INTEGER SourceStatus;
        INTEGER UseLogicFeedback;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_VideoSwitcher 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_VideoSwitcher sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_VideoSwitcher sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_VideoSwitcher sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_VideoSwitcher sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_VideoSwitcher sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_VideoSwitcher sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_VideoSwitcher sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_VideoSwitcher sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_VideoSwitcher sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_VideoSwitcher sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION RegisterWithCore ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumInputs;
        PD_AvInput InputBridges[];
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_WindowController 
    {
        // class delegates

        // class events
        EventHandler SetSendPacketTxChange ( PD_WindowController sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_WindowController sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_WindowController sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_WindowController sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_WindowController sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_WindowController sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_WindowController sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_WindowController sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_WindowController sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_WindowController sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION Setup ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_WindowSystem 
    {
        // class delegates

        // class events
        EventHandler OnDigitalOutputChange ( PD_WindowSystem sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_WindowSystem sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_WindowSystem sender, PD_SerialEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_WindowSystem sender, PD_NameEventArgs e );
        EventHandler SetQuickControlChange ( PD_WindowSystem sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_WindowSystem sender, PD_DigitalEventArgs e );
        EventHandler SetInUseChange ( PD_WindowSystem sender, PD_ValueEventArgs e );
        EventHandler OnBusyEvent ( PD_WindowSystem sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_WindowSystem sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_WindowSystem sender, PD_NameEventArgs e );

        // class functions
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SubscribeToDevice ( PD_Device device );
        FUNCTION UnsubscribeFromDevice ( PD_Device device );
        FUNCTION RunGlobalScene ( INTEGER sceneNum );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION RegisterWithCore ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToRoom ( PD_Room subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromRoom ( PD_Room subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumScenes;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class PD_WindowZone 
    {
        // class delegates

        // class events
        EventHandler SetQuickControlChange ( PD_WindowZone sender, PD_DigitalEventArgs e );
        EventHandler SetListDigitalControlChange ( PD_WindowZone sender, PD_DigitalEventArgs e );
        EventHandler SetSendPacketTxChange ( PD_WindowZone sender, PD_NameEventArgs e );
        EventHandler SetInUseChange ( PD_WindowZone sender, PD_ValueEventArgs e );
        EventHandler OnDigitalOutputChange ( PD_WindowZone sender, PD_DigitalEventArgs e );
        EventHandler OnAnalogOutputChange ( PD_WindowZone sender, PD_AnalogEventArgs e );
        EventHandler OnSerialOutputChange ( PD_WindowZone sender, PD_SerialEventArgs e );
        EventHandler OnBusyEvent ( PD_WindowZone sender, PD_ValueEventArgs e );
        EventHandler OnRefreshInputsEvent ( PD_WindowZone sender, PD_ValueEventArgs e );
        EventHandler OnFriendlyNameChange ( PD_WindowZone sender, PD_NameEventArgs e );

        // class functions
        FUNCTION RegisterWithCore ();
        FUNCTION CreateFileData ();
        FUNCTION WriteFileData ();
        FUNCTION Setup ();
        FUNCTION SetControllerSettings ( INTEGER windowNumNum , STRING name );
        FUNCTION SubscribeToRoom ( PD_Room room );
        FUNCTION UnsubscribeFromRoom ( PD_Room room );
        FUNCTION RefreshFeedback ( PD_Bridge subscriber );
        FUNCTION ListDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION ListSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION SubscribeToInterface ( PD_Interface ui );
        FUNCTION UnsubscribeFromInterface ( PD_Interface ui );
        FUNCTION DigitalInputChange ( INTEGER join , INTEGER val );
        FUNCTION AnalogInputChange ( INTEGER join , INTEGER val );
        FUNCTION SerialInputChange ( INTEGER join , STRING val );
        FUNCTION QuickDigitalFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickAnalogFeedbackChange ( INTEGER join , INTEGER val );
        FUNCTION QuickSerialFeedbackChange ( INTEGER join , STRING val );
        FUNCTION Debug ( STRING statement1 , STRING statement2 , STRING statement3 );
        FUNCTION PrintBridgeConnections ();
        FUNCTION ReadFileData ();
        FUNCTION OnInitEvent ( INTEGER corePhase );
        FUNCTION OnSetupVideoSwitchersEvent ();
        FUNCTION OnSetupAudioSwitchersEvent ();
        FUNCTION OnSetupAvReceiversEvent ();
        FUNCTION OnSetupDevicesEvent ();
        FUNCTION OnSetupRoomsEvent ();
        FUNCTION OnSetupInterfacesEvent ();
        FUNCTION ConnectTo ( STRING targetId , INTEGER refresh );
        FUNCTION SubscribeToBridge ( PD_Bridge subscriber );
        FUNCTION SubscribeToArea ( PD_Area subscriber );
        FUNCTION SubscribeToDevice ( PD_Device subscriber );
        FUNCTION SubscribeToAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION SubscribeToDisplay ( PD_Display subscriber );
        FUNCTION DisconnectFrom ( STRING targetId );
        FUNCTION UnsubscribeFromBridge ( PD_Bridge subscriber );
        FUNCTION UnsubscribeFromArea ( PD_Area subscriber );
        FUNCTION UnsubscribeFromDevice ( PD_Device subscriber );
        FUNCTION UnsubscribeFromAudioZone ( PD_AvEndPoint subscriber );
        FUNCTION UnsubscribeFromDisplay ( PD_Display subscriber );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
        INTEGER NumScenes;
        INTEGER NumControllers;
        INTEGER DeviceType;
        INTEGER HandheldPageNum;
        INTEGER NumListControls;
        INTEGER NumQuickControls;
        INTEGER DefaultPage;
        INTEGER NumDigitals;
        INTEGER NumAnalogs;
        INTEGER NumSerials;
        INTEGER NumListDigitals;
        INTEGER NumListAnalogs;
        INTEGER NumListSerials;
        INTEGER NumQuickDigitals;
        INTEGER NumQuickAnalogs;
        INTEGER NumQuickSerials;
        STRING DriverFilePath[];
        INTEGER IrPortNumber;
        PD_BridgeTypes BridgeType;
        STRING LogicId[];
        STRING SymbolName[];
        STRING SymbolFileName[];
        INTEGER FriendlyId;
        STRING FriendlyName[];
        INTEGER ParentId;
        PD_BridgeTypes ParentType;
        INTEGER ParentTypeNum;
        INTEGER AccessLevel;
        STRING ReadAtBootup[];
        LONG_INTEGER DataClientId;
        LONG_INTEGER SignalClientId;
        INTEGER DebugOn;
    };

     class SDKRegistration 
    {
        // class delegates

        // class events

        // class functions
        static FUNCTION SetLicenseKey ( STRING licenseKey );
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };

    static class TIME_VALIDATION_METHOD // enum
    {
        static SIGNED_LONG_INTEGER PreferInternetTime;
        static SIGNED_LONG_INTEGER UseInternetTime;
        static SIGNED_LONG_INTEGER UseLocalTime;
    };

namespace AdaptCore.Core;
        // class declarations
         class PD_EnergyAction;
     class PD_EnergyAction 
    {
        // class delegates

        // class events

        // class functions
        SIGNED_LONG_INTEGER_FUNCTION GetHashCode ();
        STRING_FUNCTION ToString ();

        // class variables
        INTEGER __class_id__;

        // class properties
    };


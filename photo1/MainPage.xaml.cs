namespace photo1;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
        InitializeComponent();
		img1.Source = "dotnet_bot.png";
	}

	private async void OnCounterClicked(object sender, EventArgs e)
	{
		try
		{
            var newImg = await MediaPicker.CapturePhotoAsync(new MediaPickerOptions { Title = "Take the shot" });
            //var newImg = await MediaPicker.CapturePhotoAsync(null);
            img1.Source = newImg?.FullPath;
        }
		catch 
		{
			img1.Source = "dotnet_bot.png";
		}
	}
}
/*
 * Device log upon crash on an actual device:
 * Time	Device Name	Type	PID	Tag	Message
10-05 14:55:09.793	KYOCERA C6930	Info	3258	ThermalEngine	Thermal-Server: removing client on fd 79
10-05 14:55:09.799	KYOCERA C6930	Error	1714	libc	Access denied finding property "vendor.camera.aux.packagelist"
10-05 14:55:09.798	KYOCERA C6930	Info	1349	CameraProviderManager	Camera device device@3.5/legacy/1 torch status is now AVAILABLE_OFF
10-05 14:55:09.798	KYOCERA C6930	Info	1349	CameraService	onTorchStatusChangedLocked: Torch status changed for cameraId=0, newStatus=1
10-05 14:55:09.798	KYOCERA C6930	Info	1349	CameraProviderManager	Camera device device@3.5/legacy/0 torch status is now AVAILABLE_OFF
10-05 14:55:09.794	KYOCERA C6930	Info	929	Thermal-Lib	thermal_bandwidth_client_cancel_request: Removing all bw request for camera_bw
10-05 14:55:09.793	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chxextensionmodule.cpp:4955 RequestThreadProcessing() Terminating recovery thread for logical cameraId: 2
10-05 14:55:09.758	KYOCERA C6930	Warning	929	CamX	[ WARN][CSL    ] camxcslhw.cpp:405 CSLCloseHW() Current number of existing acquired devices: 0 for session: ZSLPreviewRaw_LT1080p_KC(0xaf0200), Handle Index: 0
10-05 14:55:09.756	KYOCERA C6930	Error	929	QMI_FW	qmi_cci_get_ref: ref count increased 2
10-05 14:55:09.756	KYOCERA C6930	Error	929	QMI_FW	qmi_cci_get_ref: ref count increased 2
10-05 14:55:09.753	KYOCERA C6930	Info	929	CamX	[CORE_CFG][FD     ] camxfdmanagernode.cpp:118 ~FDManagerNode() FD frames processed 468 skipped 0 total frames 468
10-05 14:55:09.752	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhw.cpp:1158 CSLReleaseDeviceHW() hCSL release success: 11469312, cslDeviceIndex 10 oishandle, hDevice 15335691 name:CSLHwOPE
10-05 14:55:09.744	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhw.cpp:1158 CSLReleaseDeviceHW() hCSL release success: 11469312, cslDeviceIndex 10 oishandle, hDevice 12845322 name:CSLHwOPE
10-05 14:55:09.741	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhw.cpp:1158 CSLReleaseDeviceHW() hCSL release success: 11469312, cslDeviceIndex 0 oishandle, hDevice 1179913 name:CSLHwTFE
10-05 14:55:09.739	KYOCERA C6930	Error	929	QMI_FW	qmi_cci_get_ref: ref count increased 2
10-05 14:55:09.739	KYOCERA C6930	Error	929	QMI_FW	qmi_cci_get_ref: ref count increased 2
10-05 14:55:09.738	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ UnInitializeSVQ run 61 ms
10-05 14:55:09.703	KYOCERA C6930	Info	3258	ThermalEngine	Mitigation:Battery:7
10-05 14:55:09.697	KYOCERA C6930	Info	3258	ThermalEngine	Mitigation:Battery:0
10-05 14:55:09.694	KYOCERA C6930	Info	27847	kc_thermal_dynamic_adj	set thermal_config_list
10-05 14:55:09.693	KYOCERA C6930	Info	3258	ThermalEngine	Thermal-Server: Num of config set request 53
10-05 14:55:09.689	KYOCERA C6930	Info	3258	ThermalEngine	Thermal-Server: Num of config set request 53
10-05 14:55:09.689	KYOCERA C6930	Info	3258	ThermalEngine	Thermal-Server: Thermal received msg from  config_set
10-05 14:55:09.688	KYOCERA C6930	Info	27847	kc_thermal_dynamic_adj	kc_label is enabled. label=KC_LCDBLT_SS_CPU0-5_Silver
10-05 14:55:09.688	KYOCERA C6930	Info	27847	kc_thermal_dynamic_adj	kc_label is enabled. label=KC_LCDBLT_SS_CPU6-7_GOLD
10-05 14:55:09.688	KYOCERA C6930	Info	27847	kc_thermal_dynamic_adj	kc_label is enabled. label=KC_LCDBLT_SS_GPU
10-05 14:55:09.688	KYOCERA C6930	Info	27847	kc_thermal_dynamic_adj	kc_label is enabled. label=KC_LCDBLT_HOTPLUG_CPU6
10-05 14:55:09.688	KYOCERA C6930	Info	27847	kc_thermal_dynamic_adj	kc_label is enabled. label=KC_LCDBLT_HOTPLUG_CPU7
10-05 14:55:09.688	KYOCERA C6930	Info	27847	kc_thermal_dynamic_adj	kc_label is enabled. label=KC_LCDBLT_BATTERY_XO_THERM
10-05 14:55:09.688	KYOCERA C6930	Info	27847	kc_thermal_dynamic_adj	kc_label is enabled. label=KC_LCDBLT_LOW_CLUSTER10
10-05 14:55:09.686	KYOCERA C6930	Info	3258	ThermalEngine	Thermal-Server: total num of config queried 26
10-05 14:55:09.686	KYOCERA C6930	Info	3258	ThermalEngine	Thermal-Server: Thermal received msg from  config_query
10-05 14:55:09.681	KYOCERA C6930	Info	3258	ThermalEngine	Thermal-Server: total num of config queried 36
10-05 14:55:09.681	KYOCERA C6930	Info	3258	ThermalEngine	Thermal-Server: Thermal received msg from  config_query
10-05 14:55:09.679	KYOCERA C6930	Info	27847	kc_thermal_dynamic_adj	mode is LCDBLT
10-05 14:55:09.677	KYOCERA C6930	Warning	929	CamX	[ WARN][CSL    ] camxcslhw.cpp:405 CSLCloseHW() Current number of existing acquired devices: 0 for session: InternalZSLYuv2Jpegwide(0x7f0207), Handle Index: 7
10-05 14:55:09.648	KYOCERA C6930	Warning	1714	BroadcastQueue	Skipping deliver [background] BroadcastRecord{957c890 u-1 jp.kyocera.internal.devicemonitor.ThermalMonitor.action.TEMPERATURE_CHANGED} to ReceiverList{b503bf7 30573 jp.kyocera.camera/10131/u0 remote:1aa0bf6}: process gone or crashing
10-05 14:55:09.637	KYOCERA C6930	Warning	929	CamX	[ WARN][CSL    ] camxcslhw.cpp:405 CSLCloseHW() Current number of existing acquired devices: 0 for session: ZSLSnapshotYUVHAL(0x290202), Handle Index: 2
10-05 14:55:09.634	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhw.cpp:1158 CSLReleaseDeviceHW() hCSL release success: 2687490, cslDeviceIndex 10 oishandle, hDevice 13435150 name:CSLHwOPE
10-05 14:55:09.631	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhw.cpp:1158 CSLReleaseDeviceHW() hCSL release success: 2687490, cslDeviceIndex 10 oishandle, hDevice 15204621 name:CSLHwOPE
10-05 14:55:09.621	KYOCERA C6930	Warning	929	CamX	[ WARN][CSL    ] camxcslhw.cpp:405 CSLCloseHW() Current number of existing acquired devices: 0 for session: FullHDRMergeYuv(0x4d0206), Handle Index: 6
10-05 14:55:09.611	KYOCERA C6930	Warning	929	CamX	[ WARN][CSL    ] camxcslhw.cpp:405 CSLCloseHW() Current number of existing acquired devices: 0 for session: ZSLSnapshotYUVHALwithCDS(0x5f0203), Handle Index: 3
10-05 14:55:09.577	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:193 Destroy() Destroying InternalZSLYuv2Jpegwide_0
10-05 14:55:09.577	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:1325 Destroy() Session (0xb400006cb6742040) Destroy InternalZSLYuv2Jpegwide
10-05 14:55:09.574	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() InternalZSLYuv2Jpegwide_0 status is now PipelineStatus::RESOURCES_RELEASED
10-05 14:55:09.574	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() InternalZSLYuv2Jpegwide_0 status is now PipelineStatus::STREAM_OFF
10-05 14:55:09.574	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:1204 StreamOff() InternalZSLYuv2Jpegwide_0 Streaming Off successful:0xb400006eab1d8550, last request id 1 is real time 0 cam Id: 2 mode : 1 hasFlushOccurred: 0
10-05 14:55:09.574	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:9464 SetStreamOffPipelineSync() Set Stream Off Pipeline Sync to FALSE
10-05 14:55:09.574	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:9458 SetStreamOffPipelineSync() Set Stream Off Pipeline Sync to TRUE (Fwk Frame Num: 0, StreamOffPipeline: 0xb400006d8acd8c50)
10-05 14:55:09.574	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:3851 AsyncDestroyJobs() DeActivatePipeline name InternalZSLYuv2Jpegwide
10-05 14:55:09.574	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:193 Destroy() Destroying FullHDRMergeYuv_0
10-05 14:55:09.573	KYOCERA C6930	Warning	929	CamX	[ WARN][CSL    ] camxcslhw.cpp:405 CSLCloseHW() Current number of existing acquired devices: 0 for session: Merge4YuvCustomTo1Yuv(0xa0208), Handle Index: 8
10-05 14:55:09.573	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:1325 Destroy() Session (0xb400006cb6880040) Destroy FullHDRMergeYuv
10-05 14:55:09.573	KYOCERA C6930	Info	929	CamX	[CORE_CFG][SENSOR ] camxsensornode.cpp:281 ReleaseOneSubDevice() CameraId=2 CSLClose(0xaf0200)
10-05 14:55:09.573	KYOCERA C6930	Info	929	CamX	[CORE_CFG][SENSOR ] camxsensornode.cpp:276 ReleaseOneSubDevice() Released CameraId=2 CSLSession=0xaf0200 refCount=0 SubdeviceType=0 subDevHandle=0x790101
10-05 14:55:09.573	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhw.cpp:1158 CSLReleaseDeviceHW() hCSL release success: 11469312, cslDeviceIndex 13 oishandle, hDevice 7930113 name:CSLHwImageSensor
10-05 14:55:09.556	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:193 Destroy() Destroying Merge4YuvCustomTo1Yuv_0
10-05 14:55:09.556	KYOCERA C6930	Info	929	CamX	[CORE_CFG][SENSOR ] camxsensornode.cpp:245 MustRelease() cameraId=2 subDevice=0: bReleaseDevice=1
10-05 14:55:09.556	KYOCERA C6930	Info	929	CamX	[CORE_CFG][SENSOR ] camxsensornode.cpp:276 ReleaseOneSubDevice() Released CameraId=2 CSLSession=0xaf0200 refCount=1 SubdeviceType=1 subDevHandle=0x1b0105
10-05 14:55:09.556	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhw.cpp:1158 CSLReleaseDeviceHW() hCSL release success: 11469312, cslDeviceIndex 3 oishandle, hDevice 1769733 name:CSLHwCSIPHY
10-05 14:55:09.556	KYOCERA C6930	Info	929	CamX	[CORE_CFG][SENSOR ] camxsensornode.cpp:245 MustRelease() cameraId=2 subDevice=1: bReleaseDevice=1
10-05 14:55:09.554	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() FullHDRMergeYuv_0 status is now PipelineStatus::RESOURCES_RELEASED
10-05 14:55:09.554	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() FullHDRMergeYuv_0 status is now PipelineStatus::STREAM_OFF
10-05 14:55:09.554	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:1204 StreamOff() FullHDRMergeYuv_0 Streaming Off successful:0xb400006eab294840, last request id 1 is real time 0 cam Id: 2 mode : 1 hasFlushOccurred: 0
10-05 14:55:09.554	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:9464 SetStreamOffPipelineSync() Set Stream Off Pipeline Sync to FALSE
10-05 14:55:09.554	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:9458 SetStreamOffPipelineSync() Set Stream Off Pipeline Sync to TRUE (Fwk Frame Num: 0, StreamOffPipeline: 0xb400006d8ad0b7d0)
10-05 14:55:09.554	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:3851 AsyncDestroyJobs() DeActivatePipeline name FullHDRMergeYuv
10-05 14:55:09.553	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:1325 Destroy() Session (0xb400006cb6190040) Destroy Merge4YuvCustomTo1Yuv
10-05 14:55:09.550	KYOCERA C6930	Info	929	CamX	[CORE_CFG][SENSOR ] camxsensornode.cpp:625 ~SensorNode() Sensor[2] destroy pipeline[0]
10-05 14:55:09.550	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:193 Destroy() Destroying ZSLSnapshotYUVHALwithCDS_0
10-05 14:55:09.549	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:1325 Destroy() Session (0xb400006cb7e9d040) Destroy ZSLSnapshotYUVHALwithCDS
10-05 14:55:09.549	KYOCERA C6930	Warning	929	CamX	[ WARN][CSL    ] camxcslhw.cpp:405 CSLCloseHW() Current number of existing acquired devices: 0 for session: SWMFMergeRaw(0x940204), Handle Index: 4
10-05 14:55:09.547	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:193 Destroy() Destroying ZSLSnapshotYUVHAL_0
10-05 14:55:09.546	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:1325 Destroy() Session (0xb400006cb8018040) Destroy ZSLSnapshotYUVHAL
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() ZSLSnapshotYUVHAL_0 status is now PipelineStatus::RESOURCES_RELEASED
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() ZSLSnapshotYUVHAL_0 status is now PipelineStatus::STREAM_OFF
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:1204 StreamOff() ZSLSnapshotYUVHAL_0 Streaming Off successful:0xb400006eab1382d0, last request id 9 is real time 0 cam Id: 2 mode : 1 hasFlushOccurred: 0
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2601 CSLHwStreamOffKMDHardwares() Stream off Success: Setting device to inactive state hAc: 0xcd010e type: 19, idx: 10 name:CSLHwOPE
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2557 CSLHwStreamOffKMDHardwares() Turning off DevH: 0xcd010e, hAc: 0xcd010e type: 19, idx: 10, name = CSLHwOPE, mode: 1, active: 1
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2601 CSLHwStreamOffKMDHardwares() Stream off Success: Setting device to inactive state hAc: 0xe8010d type: 19, idx: 10 name:CSLHwOPE
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:193 Destroy() Destroying SWMFMergeRaw_0
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2557 CSLHwStreamOffKMDHardwares() Turning off DevH: 0xe8010d, hAc: 0xe8010d type: 19, idx: 10, name = CSLHwOPE, mode: 1, active: 1
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:9464 SetStreamOffPipelineSync() Set Stream Off Pipeline Sync to FALSE
10-05 14:55:09.543	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:9458 SetStreamOffPipelineSync() Set Stream Off Pipeline Sync to TRUE (Fwk Frame Num: 8, StreamOffPipeline: 0xb400006d8ad09fd0)
10-05 14:55:09.543	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:3851 AsyncDestroyJobs() DeActivatePipeline name ZSLSnapshotYUVHAL
10-05 14:55:09.542	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:1325 Destroy() Session (0xb400006cb69a3040) Destroy SWMFMergeRaw
10-05 14:55:09.540	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:193 Destroy() Destroying ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:09.539	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:1325 Destroy() Session (0xb400006cb89f1040) Destroy ZSLPreviewRaw_LT1080p_KC
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:178 DumpState() -------------------------
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:177 DumpState()     Key     Allocation
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:176 DumpState() -------------------------
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:175 DumpState() client {ZSLPreviewRaw_LT1080p_KC, 0xb400006eaaf33ac0}
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:174 DumpState() 
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:101 DumpState() [SensorHw : 2], AvailableResource = 100
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:101 DumpState() [SensorHw : 1], AvailableResource = 100
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:101 DumpState() [SensorHw : 0], AvailableResource = 100
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:101 DumpState() [IFEHw : 0], AvailableResource = 100
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[ DUMP][CORE   ] camxresourcemanager.cpp:101 DumpState() [IPEHw : 0], AvailableResource = 100
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() ZSLPreviewRaw_LT1080p_KC_0 status is now PipelineStatus::RESOURCES_RELEASED
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][SENSOR ] camxsensornode.cpp:8140 ReleaseResources() Sensor[2] modeBitmask 0x1
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() ZSLPreviewRaw_LT1080p_KC_0 status is now PipelineStatus::STREAM_OFF
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:1204 StreamOff() ZSLPreviewRaw_LT1080p_KC_0 Streaming Off successful:0xb400006eaafdbd60, last request id 468 is real time 1 cam Id: 2 mode : 1 hasFlushOccurred: 0
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2601 CSLHwStreamOffKMDHardwares() Stream off Success: Setting device to inactive state hAc: 0xea010b type: 19, idx: 10 name:CSLHwOPE
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2557 CSLHwStreamOffKMDHardwares() Turning off DevH: 0xea010b, hAc: 0xea010b type: 19, idx: 10, name = CSLHwOPE, mode: 1, active: 1
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2601 CSLHwStreamOffKMDHardwares() Stream off Success: Setting device to inactive state hAc: 0xc4010a type: 19, idx: 10 name:CSLHwOPE
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2557 CSLHwStreamOffKMDHardwares() Turning off DevH: 0xc4010a, hAc: 0xc4010a type: 19, idx: 10, name = CSLHwOPE, mode: 1, active: 1
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2601 CSLHwStreamOffKMDHardwares() Stream off Success: Setting device to inactive state hAc: 0x1b0105 type: 5, idx: 3 name:CSLHwCSIPHY
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2557 CSLHwStreamOffKMDHardwares() Turning off DevH: 0x1b0105, hAc: 0x1b0105 type: 5, idx: 3, name = CSLHwCSIPHY, mode: 1, active: 1
10-05 14:55:09.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2601 CSLHwStreamOffKMDHardwares() Stream off Success: Setting device to inactive state hAc: 0x790101 type: 1, idx: 13 name:CSLHwImageSensor
10-05 14:55:09.535	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2557 CSLHwStreamOffKMDHardwares() Turning off DevH: 0x790101, hAc: 0x790101 type: 1, idx: 13, name = CSLHwImageSensor, mode: 1, active: 1
10-05 14:55:09.535	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2601 CSLHwStreamOffKMDHardwares() Stream off Success: Setting device to inactive state hAc: 0x120109 type: 20, idx: 0 name:CSLHwTFE
10-05 14:55:09.529	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2557 CSLHwStreamOffKMDHardwares() Turning off DevH: 0x120109, hAc: 0x120109 type: 20, idx: 0, name = CSLHwTFE, mode: 1, active: 1
10-05 14:55:09.529	KYOCERA C6930	Info	1070	SmoMo	SmoMoImpl::NotifyCameraSmoothInfo: Notify Camera Info: op=0, fps=0
10-05 14:55:09.527	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:9464 SetStreamOffPipelineSync() Set Stream Off Pipeline Sync to FALSE
10-05 14:55:09.527	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxsession.cpp:9458 SetStreamOffPipelineSync() Set Stream Off Pipeline Sync to TRUE (Fwk Frame Num: 467, StreamOffPipeline: 0xb400006d8acfd6d0)
10-05 14:55:09.527	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:3851 AsyncDestroyJobs() DeActivatePipeline name ZSLPreviewRaw_LT1080p_KC
10-05 14:55:09.523	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature JPEG Session JPEG
10-05 14:55:09.523	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature SUPERNIGHT Session SUPERNIGHT
10-05 14:55:09.523	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature HDR Session HDRT1
10-05 14:55:09.523	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature Bayer2Yuv Session Bayer2Yuv
10-05 14:55:09.522	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature Bayer2Yuv Session Bayer2Yuv
10-05 14:55:09.522	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature RawHDR Session RawHDR
10-05 14:55:09.522	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature RealTime Session RealTime
10-05 14:55:09.519	KYOCERA C6930	Info	993	SDM	ResourceImpl::SetMaxBandwidthMode: new bandwidth mode=0
10-05 14:55:09.517	KYOCERA C6930	Error	997	ANDR-PERF-MPCTL	Active req limit reached, No optimizations performed
10-05 14:55:09.517	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:955 close() HalOp: Begin CLOSE, logicalCameraId: 2, cameraId: 2
10-05 14:55:09.515	KYOCERA C6930	Info	1349	CameraLatencyHistogram	ProcessCaptureRequest latency histogram (460) samples:
       40     80    120    160    200    240    280    320    360    inf (max ms)
     7.39   89.78   2.17   0.00   0.00   0.22   0.00   0.00   0.00   0.43 (%)
10-05 14:55:09.514	KYOCERA C6930	Info	1349	Camera3-Device	disconnectImpl: E
10-05 14:55:09.513	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1514 flush() HalOp: End FLUSH: 0xb400006f0ba25930 with result 0, logicalCameraId: 2, cameraId: 2
10-05 14:55:09.513	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature RawHDR Session RawHDR
10-05 14:55:09.513	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature Bayer2Yuv Session Bayer2Yuv
10-05 14:55:09.512	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature JPEG Session JPEG
10-05 14:55:09.512	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature HDR Session HDRT1
10-05 14:55:09.512	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature SUPERNIGHT Session SUPERNIGHT
10-05 14:55:09.512	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature Bayer2Yuv Session Bayer2Yuv
10-05 14:55:09.512	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature RealTime Session RealTime
10-05 14:55:09.512	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature SUPERNIGHT Session SUPERNIGHT
10-05 14:55:09.512	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature RawHDR Session RawHDR
10-05 14:55:09.512	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature JPEG Session JPEG
10-05 14:55:09.511	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature HDR Session HDRT1
10-05 14:55:09.511	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature Bayer2Yuv Session Bayer2Yuv
10-05 14:55:09.511	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature Bayer2Yuv Session Bayer2Yuv
10-05 14:55:09.510	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:752 ExecuteFlushHelper() pSessionData isFlushInProgress FALSE Feature RealTime Session RealTime
10-05 14:55:09.510	KYOCERA C6930	Error	997	ANDR-PERF-MPCTL	Active req limit reached, No optimizations performed
10-05 14:55:09.508	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1502 flush() HalOp: Begin FLUSH: 0xb400006f0ba25930, logicalCameraId: 2, cameraId: 2
10-05 14:55:09.461	KYOCERA C6930	Verbose	30573	CaptureModule	stopUpdateWrapperThread [out]
10-05 14:55:09.458	KYOCERA C6930	Verbose	30573	CaptureModule	stopUpdateWrapperThread [in]
10-05 14:55:09.457	KYOCERA C6930	Verbose	30573	CaptureModule	closeCamera [in]
10-05 14:55:09.456	KYOCERA C6930	Verbose	30573	MainActivity	onPause closeCamera
10-05 14:55:09.137	KYOCERA C6930	Error	27775	ANDR-PERF	IPerf:: Perf HAL Service is not available.
10-05 14:55:09.137	KYOCERA C6930	Error	560	SELinux	avc:  denied  { find } for interface=vendor.qti.hardware.perf::IPerf sid=u:r:gmscore_app:s0:c512,c768 pid=27775 scontext=u:r:gmscore_app:s0:c512,c768 tcontext=u:object_r:vendor_hal_perf_hwservice:s0 tclass=hwservice_manager permissive=0
10-05 14:55:09.135	KYOCERA C6930	Error	27775	ANDR-PERF	IPerf:: Perf HAL Service is not available.
10-05 14:55:09.135	KYOCERA C6930	Error	560	SELinux	avc:  denied  { find } for interface=vendor.qti.hardware.perf::IPerf sid=u:r:gmscore_app:s0:c512,c768 pid=27775 scontext=u:r:gmscore_app:s0:c512,c768 tcontext=u:object_r:vendor_hal_perf_hwservice:s0 tclass=hwservice_manager permissive=0
10-05 14:55:09.133	KYOCERA C6930	Info	27775	bynn	Primes not initialized, returning default (no-op) Primes instance which will ignore all calls. Please call Primes.initialize(...) before using any Primes API.
10-05 14:55:09.132	KYOCERA C6930	Info	27775	Watchcat	Started
10-05 14:55:09.127	KYOCERA C6930	Info	27775	GMS_MM_Logger	Started.
10-05 14:55:09.033	KYOCERA C6930	Info	27775	ProviderInstaller	Installed default security provider GmsCore_OpenSSL
10-05 14:55:08.924	KYOCERA C6930	Verbose	27775	NativeCrypto	Registering com/google/android/gms/org/conscrypt/NativeCrypto's 295 native methods...
10-05 14:55:08.863	KYOCERA C6930	Info	27775	DynamiteModule	Selected local version of com.google.android.gms.providerinstaller.dynamite
10-05 14:55:08.863	KYOCERA C6930	Info	27775	DynamiteModule	Considering local module com.google.android.gms.providerinstaller.dynamite:1 and remote module com.google.android.gms.providerinstaller.dynamite:0
10-05 14:55:08.862	KYOCERA C6930	Warning	27775	ProviderHelper	Unknown dynamite feature providerinstaller.dynamite
10-05 14:55:08.675	KYOCERA C6930	Info	27775	DynamiteModule	Selected local version of com.google.android.gms.permissions
10-05 14:55:08.675	KYOCERA C6930	Info	27775	DynamiteModule	Considering local module com.google.android.gms.permissions:1 and remote module com.google.android.gms.permissions:1
10-05 14:55:08.430	KYOCERA C6930	Info	27803	GservicesProvider	Gservices pushing to system: true; secure/global: true
10-05 14:55:08.426	KYOCERA C6930	Debug	27803	NetworkSecurityConfig	No Network Security Config specified, using platform default
10-05 14:55:08.426	KYOCERA C6930	Debug	27803	NetworkSecurityConfig	No Network Security Config specified, using platform default
10-05 14:55:08.418	KYOCERA C6930	Info	27803	Perf	Connecting to perf service.
10-05 14:55:08.382	KYOCERA C6930	Info	27803	ocess.gservice	The ClassLoaderContext is a special shared library.
10-05 14:55:08.368	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:08.368	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:08.368	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:08.359	KYOCERA C6930	Error	27803	ocess.gservice	Not starting debugger since process cannot load the jdwp agent.
10-05 14:55:08.349	KYOCERA C6930	Info	1714	ActivityManager	Start proc 27803:com.google.process.gservices/u0a145 for content provider {com.google.android.gsf/com.google.android.gsf.gservices.GservicesProvider}
10-05 14:55:08.347	KYOCERA C6930	Debug	777	Zygote	Forked child process 27803
10-05 14:55:08.340	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 143937733; UID 10145; state: ENABLED
10-05 14:55:08.340	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135754954; UID 10145; state: ENABLED
10-05 14:55:08.339	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135634846; UID 10145; state: DISABLED
10-05 14:55:08.296	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10151 pid 23241 in 16ms
10-05 14:55:08.293	KYOCERA C6930	Info	778	Zygote	Process 23241 exited due to signal 9 (Killed)
10-05 14:55:08.290	KYOCERA C6930	Error	1714	libprocessgroup	getpgid(23241) failed: Permission denied
10-05 14:55:08.287	KYOCERA C6930	Warning	1714	ActivityManager	type=1400 audit(0.0:541248): avc: denied { getpgid } for scontext=u:r:system_server:s0 tcontext=u:r:app_zygote:s0:c512,c768 tclass=process permissive=0
10-05 14:55:08.283	KYOCERA C6930	Warning	1714	ActivityManager	type=1400 audit(0.0:541247): avc: denied { getpgid } for scontext=u:r:system_server:s0 tcontext=u:r:app_zygote:s0:c512,c768 tclass=process permissive=0
10-05 14:55:08.285	KYOCERA C6930	Error	1714	libprocessgroup	getpgid(23241) failed: Permission denied
10-05 14:55:08.283	KYOCERA C6930	Warning	1714	ActivityManager	type=1400 audit(0.0:541246): avc: denied { getpgid } for scontext=u:r:system_server:s0 tcontext=u:r:app_zygote:s0:c512,c768 tclass=process permissive=0
10-05 14:55:08.275	KYOCERA C6930	Warning	1714	ActivityManager	type=1400 audit(0.0:541245): avc: denied { getpgid } for scontext=u:r:system_server:s0 tcontext=u:r:app_zygote:s0:c512,c768 tclass=process permissive=0
10-05 14:55:08.279	KYOCERA C6930	Error	1714	libprocessgroup	getpgid(23241) failed: Permission denied
10-05 14:55:08.275	KYOCERA C6930	Warning	1714	ActivityManager	type=1400 audit(0.0:541244): avc: denied { getpgid } for scontext=u:r:system_server:s0 tcontext=u:r:app_zygote:s0:c512,c768 tclass=process permissive=0
10-05 14:55:08.252	KYOCERA C6930	Info	7057	KMMService	kmmMemoryCheck FreeRAM [KB] = 618316
10-05 14:55:08.232	KYOCERA C6930	Debug	27775	NetworkSecurityConfig	Using Network Security Config from resource network_security_config debugBuild: false
10-05 14:55:08.226	KYOCERA C6930	Debug	27775	NetworkSecurityConfig	Using Network Security Config from resource network_security_config debugBuild: false
10-05 14:55:08.220	KYOCERA C6930	Info	15612	A	(REDACTED) onApplyWindowInsets: systemWindowInsets=%s
10-05 14:55:08.220	KYOCERA C6930	Info	15612	A	(REDACTED) onApplyWindowInsets: systemWindowInsets=%s
10-05 14:55:08.217	KYOCERA C6930	Error	27775	ANDR-PERF	IPerf:: Perf HAL Service is not available.
10-05 14:55:08.217	KYOCERA C6930	Error	560	SELinux	avc:  denied  { find } for interface=vendor.qti.hardware.perf::IPerf sid=u:r:gmscore_app:s0:c512,c768 pid=27775 scontext=u:r:gmscore_app:s0:c512,c768 tcontext=u:object_r:vendor_hal_perf_hwservice:s0 tclass=hwservice_manager permissive=0
10-05 14:55:08.216	KYOCERA C6930	Error	27775	ANDR-PERF	IPerf:: Perf HAL Service is not available.
10-05 14:55:08.215	KYOCERA C6930	Error	560	SELinux	avc:  denied  { find } for interface=vendor.qti.hardware.perf::IPerf sid=u:r:gmscore_app:s0:c512,c768 pid=27775 scontext=u:r:gmscore_app:s0:c512,c768 tcontext=u:object_r:vendor_hal_perf_hwservice:s0 tclass=hwservice_manager permissive=0
10-05 14:55:08.208	KYOCERA C6930	Info	27775	Perf	Connecting to perf service.
10-05 14:55:08.167	KYOCERA C6930	Info	5038	BtGatt.ScanManager	msg.what = 6
10-05 14:55:08.167	KYOCERA C6930	Error	17894	FrameEvents	updateAcquireFence: Did not find frame.
10-05 14:55:08.166	KYOCERA C6930	Warning	27775	gle.android.gm	JIT profile information will not be recorded: profile file does not exist.
10-05 14:55:08.166	KYOCERA C6930	Warning	27775	gle.android.gm	JIT profile information will not be recorded: profile file does not exist.
10-05 14:55:08.163	KYOCERA C6930	Info	15640	GsaVoiceInteractionSrv	Cannot start hotword, hotword has been explicitly disabled.
10-05 14:55:08.162	KYOCERA C6930	Info	15640	GsaVoiceInteractionSrv	(REDACTED) disregardVoiceMatch: %b
10-05 14:55:08.159	KYOCERA C6930	Error	17894	FrameEvents	updateAcquireFence: Did not find frame.
10-05 14:55:08.159	KYOCERA C6930	Info	15640	GsaVoiceInteractionSrv	Handling ACTION_START_HOTWORD
10-05 14:55:08.143	KYOCERA C6930	Error	17894	FrameEvents	updateAcquireFence: Did not find frame.
10-05 14:55:08.100	KYOCERA C6930	Info	27775	gle.android.gm	The ClassLoaderContext is a special shared library.
10-05 14:55:08.073	KYOCERA C6930	Info	27775	gle.android.gm	The ClassLoaderContext is a special shared library.
10-05 14:55:08.062	KYOCERA C6930	Info	15612	A	(REDACTED) onApplyWindowInsets: systemWindowInsets=%s
10-05 14:55:08.061	KYOCERA C6930	Info	15612	A	(REDACTED) onApplyWindowInsets: systemWindowInsets=%s
10-05 14:55:08.011	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:08.011	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:08.011	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:08.007	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:08.007	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:08.007	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:07.990	KYOCERA C6930	Error	27775	gle.android.gm	Not starting debugger since process cannot load the jdwp agent.
10-05 14:55:07.933	KYOCERA C6930	Error	997	ANDR-PERF-MPCTL	Active req limit reached, No optimizations performed
10-05 14:55:07.922	KYOCERA C6930	Warning	1714	ActivityTaskManager	Activity pause timeout for ActivityRecord{9e16058 u0 jp.kyocera.camera/.MainActivity t58 f}}
10-05 14:55:07.701	KYOCERA C6930	Info	1714	ActivityManager	Start proc 27775:com.google.android.gms/u0a145 for service {com.google.android.gms/com.google.android.gms.chimera.GmsIntentOperationService}
10-05 14:55:07.699	KYOCERA C6930	Debug	777	Zygote	Forked child process 27775
10-05 14:55:07.680	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 143937733; UID 10145; state: ENABLED
10-05 14:55:07.679	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135754954; UID 10145; state: ENABLED
10-05 14:55:07.679	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135634846; UID 10145; state: DISABLED
10-05 14:55:07.668	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:07.668	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:07.668	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:07.666	KYOCERA C6930	Warning	1714	Looper	Slow dispatch took 135ms android.ui h=com.android.server.am.ActivityManagerService$UiHandler c=com.android.server.am.-$$Lambda$ProcessRecord$ErrorDialogController$W-AQD6Azm5daJOusD9r1R26WGBo@974a21e m=0
10-05 14:55:07.609	KYOCERA C6930	Info	2460	ndroid.systemu	NativeAlloc concurrent copying GC freed 23274(1001KB) AllocSpace objects, 0(0B) LOS objects, 49% free, 9038KB/17MB, paused 58us total 164.218ms
10-05 14:55:07.538	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:07.538	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:07.538	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:07.530	KYOCERA C6930	Warning	1714	ContextImpl	Calling a method in the system process without a qualified user: android.app.ContextImpl.sendBroadcast:1111 com.android.server.am.AppErrorDialog.<init>:117 com.android.server.am.ProcessRecord$ErrorDialogController.showCrashDialogs:2037 com.android.server.am.AppErrors.handleShowAppErrorUi:857 com.android.server.am.ActivityManagerService$UiHandler.handleMessage:1711 
10-05 14:55:07.476	KYOCERA C6930	Warning	1714	BroadcastQueue	Background execution not allowed: receiving Intent { act=android.intent.action.DROPBOX_ENTRY_ADDED flg=0x10 (has extras) } to com.google.android.gms/.chimera.GmsIntentOperationService$PersistentTrustedReceiver
  Force finishing activity jp.kyocera.camera/.MainActivity
10-05 14:55:07.476	KYOCERA C6930	Warning	1714	BroadcastQueue	Background execution not allowed: receiving Intent { act=android.intent.action.DROPBOX_ENTRY_ADDED flg=0x10 (has extras) } to com.google.android.gms/.stats.service.DropBoxEntryAddedReceiver
10-05 14:55:07.469	KYOCERA C6930	Info	1714	ActivityManager	
10-05 14:55:07.469	KYOCERA C6930	Info	1714	ActivityManager	Caused by: android.os.RemoteException: Remote stack trace:
	at com.android.server.am.ActivityManagerService.getContentProviderImpl(ActivityManagerService.java:7319)
	at com.android.server.am.ActivityManagerService.getContentProvider(ActivityManagerService.java:7655)
	at android.app.IActivityManager$Stub.onTransact(IActivityManager.java:2408)
	at com.android.server.am.ActivityManagerService.onTransact(ActivityManagerService.java:2890)
	at android.os.Binder.execTransactInternal(Binder.java:1159)
10-05 14:55:07.469	KYOCERA C6930	Info	1714	ActivityManager	IQalog set call. rescue party crash info : java.lang.SecurityException: Permission Denial: opening provider microsoft.maui.essentials.fileProvider from ProcessRecord{d575514 30573:jp.kyocera.camera/u0a131} (pid=30573, uid=10131) that is not exported from UID 10258
	at android.os.Parcel.createExceptionOrNull(Parcel.java:2373)
	at android.os.Parcel.createException(Parcel.java:2357)
	at android.os.Parcel.readException(Parcel.java:2340)
	at android.os.Parcel.readException(Parcel.java:2282)
	at android.app.IActivityManager$Stub$Proxy.getContentProvider(IActivityManager.java:5746)
	at android.app.ActivityThread.acquireProvider(ActivityThread.java:6889)
	at android.app.ContextImpl$ApplicationContentResolver.acquireUnstableProvider(ContextImpl.java:2935)
	at android.content.ContentResolver.acquireUnstableProvider(ContentResolver.java:2484)
	at android.content.ContentResolver.openAssetFileDescriptor(ContentResolver.java:1802)
	at android.content.ContentResolver.openOutputStream(ContentResolver.java:1520)
	at android.content.ContentResolver.openOutputStream(ContentResolver.java:1496)
	at jp.kyocera.camera.CaptureModule$48.onImageAvailable(CaptureModule.java:6551)
	at android.media.ImageReader$ListenerHandler.handleMessage(ImageReader.java:812)
	at android.os.Handler.dispatchMessage(Handler.java:106)
	at android.os.Looper.loop(Looper.java:223)
	at android.os.HandlerThread.run(HandlerThread.java:67)
10-05 14:55:07.466	KYOCERA C6930	Info	1714	android_os_HwBinder	HwBinder: Starting thread pool for getting: vendor.kyocera.hardware.qalog@1.0::IQalog/default
10-05 14:55:07.462	KYOCERA C6930	Info	1714	DropBoxManagerService	add tag=system_app_crash isTagEnabled=true flags=0x2
10-05 14:55:07.453	KYOCERA C6930	Verbose	30573	FocusView	disappear: false
10-05 14:55:07.453	KYOCERA C6930	Verbose	30573	MainActivity	stopArcFramSync [out]
10-05 14:55:07.453	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:07.453	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.453	KYOCERA C6930	Verbose	30573	MainActivity	stopArcFramSync [in]
10-05 14:55:07.453	KYOCERA C6930	Error	30573	AndroidRuntime	
10-05 14:55:07.453	KYOCERA C6930	Error	30573	AndroidRuntime	Caused by: android.os.RemoteException: Remote stack trace:
	at com.android.server.am.ActivityManagerService.getContentProviderImpl(ActivityManagerService.java:7319)
	at com.android.server.am.ActivityManagerService.getContentProvider(ActivityManagerService.java:7655)
	at android.app.IActivityManager$Stub.onTransact(IActivityManager.java:2408)
	at com.android.server.am.ActivityManagerService.onTransact(ActivityManagerService.java:2890)
	at android.os.Binder.execTransactInternal(Binder.java:1159)
10-05 14:55:07.453	KYOCERA C6930	Error	30573	AndroidRuntime	java.lang.SecurityException: Permission Denial: opening provider microsoft.maui.essentials.fileProvider from ProcessRecord{d575514 30573:jp.kyocera.camera/u0a131} (pid=30573, uid=10131) that is not exported from UID 10258
	at android.os.Parcel.createExceptionOrNull(Parcel.java:2373)
	at android.os.Parcel.createException(Parcel.java:2357)
	at android.os.Parcel.readException(Parcel.java:2340)
	at android.os.Parcel.readException(Parcel.java:2282)
	at android.app.IActivityManager$Stub$Proxy.getContentProvider(IActivityManager.java:5746)
	at android.app.ActivityThread.acquireProvider(ActivityThread.java:6889)
	at android.app.ContextImpl$ApplicationContentResolver.acquireUnstableProvider(ContextImpl.java:2935)
	at android.content.ContentResolver.acquireUnstableProvider(ContentResolver.java:2484)
	at android.content.ContentResolver.openAssetFileDescriptor(ContentResolver.java:1802)
	at android.content.ContentResolver.openOutputStream(ContentResolver.java:1520)
	at android.content.ContentResolver.openOutputStream(ContentResolver.java:1496)
	at jp.kyocera.camera.CaptureModule$48.onImageAvailable(CaptureModule.java:6551)
	at android.media.ImageReader$ListenerHandler.handleMessage(ImageReader.java:812)
	at android.os.Handler.dispatchMessage(Handler.java:106)
	at android.os.Looper.loop(Looper.java:223)
	at android.os.HandlerThread.run(HandlerThread.java:67)
10-05 14:55:07.453	KYOCERA C6930	Error	30573	AndroidRuntime	Process: jp.kyocera.camera, PID: 30573
10-05 14:55:07.453	KYOCERA C6930	Error	30573	AndroidRuntime	FATAL EXCEPTION: CameraBackground
10-05 14:55:07.453	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOpenSlowMotionList [out] : ret = false
10-05 14:55:07.453	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOpenTimelapseList [out] : ret = false
10-05 14:55:07.452	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.452	KYOCERA C6930	Verbose	30573	ZoomController	appear [out]
10-05 14:55:07.452	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.447	KYOCERA C6930	Verbose	30573	MainActivity	isVideo1080p60fps : ret = false
10-05 14:55:07.447	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.447	KYOCERA C6930	Verbose	30573	ZoomController	appear [in]
10-05 14:55:07.446	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : facing_key = 2
10-05 14:55:07.445	KYOCERA C6930	Info	942	sensors-hal	batch:251, android.sensor.accelerometer/11, period=200000000, max_latency=0 request completed
10-05 14:55:07.445	KYOCERA C6930	Info	942	sensors-hal	set_config:63, sample_period_ns is adjusted to 200000000 based on min/max delay_ns
10-05 14:55:07.445	KYOCERA C6930	Info	942	sensors-hal	batch:242, android.sensor.accelerometer/11, period=200000000, max_latency=0
10-05 14:55:07.431	KYOCERA C6930	Verbose	30573	qrCodeController	hideQrcodeResult [in]
10-05 14:55:07.430	KYOCERA C6930	Verbose	30573	CaptureModule	cancelQrReader
10-05 14:55:07.428	KYOCERA C6930	Verbose	30573	MainActivity	preview blackout
10-05 14:55:07.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.427	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:55:07.427	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 5
10-05 14:55:07.425	KYOCERA C6930	Verbose	30573	MainActivity	returnIntent [out]
10-05 14:55:07.418	KYOCERA C6930	Debug	1714	ActivityTrigger	ActivityTrigger activityPauseTrigger 
10-05 14:55:07.367	KYOCERA C6930	Verbose	30573	MainActivity	returnIntent [in]
10-05 14:55:07.346	KYOCERA C6930	Debug	970	KcWifi	[KcWifi] waitForEvent: waitForEvent fb[6]
10-05 14:55:07.345	KYOCERA C6930	Debug	2751	KcWifiSocketManager	waitForEvent failed: -1
10-05 14:55:07.341	KYOCERA C6930	Error	970	KcWifi	[KcWifi] waitForEvent: recv timeout
10-05 14:55:07.341	KYOCERA C6930	Error	970	KcWifi	[KcWifi] waitForEvent: recv failed
10-05 14:55:07.337	KYOCERA C6930	Warning	1714	ActivityManager	Permission Denial: opening provider microsoft.maui.essentials.fileProvider from ProcessRecord{d575514 30573:jp.kyocera.camera/u0a131} (pid=30573, uid=10131) that is not exported from UID 10258
10-05 14:55:07.322	KYOCERA C6930	Debug	30573	qdgralloc	GetYUVPlaneInfo: Invalid format passed: 0x21
10-05 14:55:07.314	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.293	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.293	KYOCERA C6930	Verbose	30573	CaptureModule	onImageAvailable [in] : android.media.ImageReader@ad2e3ae
10-05 14:55:07.196	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.196	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:07.174	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_configure : Slice Num = 3, Slice Height = 80 
 
 Encoding Completed 
10-05 14:55:07.174	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_configure : Slice Num = 2, Slice Height = 80 
10-05 14:55:07.174	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_configure : Slice Num = 1, Slice Height = 80 
10-05 14:55:07.173	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_configure : Slice Num = 0, Slice Height = 80 
10-05 14:55:07.163	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Stride En = 0 
10-05 14:55:07.163	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Scale out H = 320 
10-05 14:55:07.163	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Scale out W = 240 
10-05 14:55:07.163	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Scale in H = 582 
10-05 14:55:07.163	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Scale in W = 438 
10-05 14:55:07.163	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Scale En = 1 
10-05 14:55:07.163	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Source Rotation = 0 
10-05 14:55:07.163	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Source (WxH) = 438 x 582 
10-05 14:55:07.134	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
 
 Encoding Completed 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_configure : Slice Num = 3, Slice Height = 1152 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_configure : Slice Num = 2, Slice Height = 1168 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_configure : Slice Num = 1, Slice Height = 1168 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_configure : Slice Num = 0, Slice Height = 1168 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Stride out UV = 0 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Stride out Y = 0 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Stride in UV = 4736 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Stride in Y = 4736 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Stride En = 1 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Scale En = 0 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Source Rotation = 90 
10-05 14:55:07.065	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_start : Source (WxH) = 4656 x 3496 
10-05 14:55:07.046	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 0  <==>  requestId: 1  <==>  sequenceId: 0  <==> CSLSyncId: 1 -- InternalZSLYuv2Jpegwide_0
10-05 14:55:07.034	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() InternalZSLYuv2Jpegwide_0 status is now PipelineStatus::STREAM_ON
10-05 14:55:07.034	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:1053 StreamOn() [InternalZSLYuv2Jpegwide_0] StreamingOn for pipeline: 0xb400006eab1d8550 with ExposureTimeMs:700 ExposureTimeStreamOn:700 hasFlushOccurred: 0
10-05 14:55:07.034	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() InternalZSLYuv2Jpegwide_0 status is now PipelineStatus::RESOURCES_ACQUIRED
10-05 14:55:07.034	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() InternalZSLYuv2Jpegwide_0 status is now PipelineStatus::FINALIZED
10-05 14:55:07.034	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() InternalZSLYuv2Jpegwide_0 status is now PipelineStatus::PRE_FINALIZED
10-05 14:55:07.032	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_init: Init success: nCPU Cores = 4, DSP enable = 0
10-05 14:55:07.030	KYOCERA C6930	Error	929	JPEG_SW_LIB	jpege_engine_hybrid_init: Init success: nCPU Cores = 4, DSP enable = 0
10-05 14:55:07.017	KYOCERA C6930	Info	929	CamX	[CORE_CFG][MEMMGR ] camxmempoolgroup.cpp:480 RegisterBufferManager() [MPG_18]-->[JPEGSWNodeReq] : NumBufMgrs=1, type=CamX, heap=1, Original Immediate=1, Max=1, SelfTuned Immediate=0, Max=1, needDedicatedBuffers=1, lateBinding=0, numBatched=1, deviceCount=0, devices=0, 0, flags=0x18 width=0, height=0, format=3, size=430080
10-05 14:55:07.013	KYOCERA C6930	Info	929	CamX	[CORE_CFG][MEMMGR ] camxmempoolgroup.cpp:480 RegisterBufferManager() [MPG_17]-->[JPEGSWNodeReq] : NumBufMgrs=1, type=CamX, heap=1, Original Immediate=1, Max=1, SelfTuned Immediate=0, Max=1, needDedicatedBuffers=1, lateBinding=0, numBatched=1, deviceCount=0, devices=0, 0, flags=0x18 width=0, height=0, format=3, size=430080
10-05 14:55:06.993	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.993	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.982	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.982	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.969	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.969	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.958	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.958	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.945	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.945	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.934	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.934	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.921	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.921	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.910	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.910	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.899	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.898	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.885	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.885	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.874	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.874	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.861	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.861	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.850	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.850	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.837	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.837	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.826	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.826	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.813	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.813	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.802	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.802	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.791	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:55:06.791	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 3
10-05 14:55:06.791	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.791	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.789	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.789	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.778	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.778	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.765	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.765	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.754	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.754	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.743	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.742	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.730	KYOCERA C6930	Debug	27647	NetworkSecurityConfig	No Network Security Config specified, using platform default
10-05 14:55:06.729	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.729	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.718	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.718	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.713	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() InternalZSLYuv2Jpegwide_0 status is now PipelineStatus::PRE_FINALIZATION_INPROGRESS
10-05 14:55:06.711	KYOCERA C6930	Debug	27647	NetworkSecurityConfig	No Network Security Config specified, using platform default
10-05 14:55:06.710	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:12223 ActivatePipeline() ActivatePipeline name InternalZSLYuv2Jpegwide
10-05 14:55:06.706	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:06.705	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.705	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.694	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.694	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.681	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.681	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.670	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.670	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.657	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.657	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.646	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.646	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.640	KYOCERA C6930	Info	27647	Perf	Connecting to perf service.
10-05 14:55:06.637	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.633	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.633	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.622	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.622	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.609	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.609	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.598	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.598	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.589	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:55:06.589	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.589	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.589	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 4
10-05 14:55:06.585	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.585	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.574	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.574	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.561	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.561	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.550	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.550	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.537	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.537	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.526	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.526	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.489	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10098 pid 27618 in 0ms
10-05 14:55:06.479	KYOCERA C6930	Info	1714	ActivityManager	Process com.verizon.messaging.vzmsgs (pid 27618) has died: cch+5 CEM 
10-05 14:55:06.478	KYOCERA C6930	Info	777	Zygote	Process 27618 exited due to signal 9 (Killed)
10-05 14:55:06.478	KYOCERA C6930	Info	558	lowmemorykiller	2 memory pressure events were skipped after a kill!
10-05 14:55:06.462	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10263 pid 27627 in 0ms
10-05 14:55:06.461	KYOCERA C6930	Info	1714	ActivityManager	Process com.jlgray.sitemanagement (pid 27627) has died: cch+5 CEM 
10-05 14:55:06.460	KYOCERA C6930	Info	778	Zygote	Process 27627 exited due to signal 9 (Killed)
10-05 14:55:06.456	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 37248kB at oom_adj 606
10-05 14:55:06.456	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.456	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.verizon.messaging.vzmsgs' (27618), uid 10098, oom_adj 905 to free 37248kB
10-05 14:55:06.425	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 25324kB at oom_adj 900
10-05 14:55:06.425	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.425	KYOCERA C6930	Info	558	lowmemorykiller	Kill '<pre-initialized>' (27627), uid 10263, oom_adj 905 to free 25324kB
10-05 14:55:06.401	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.401	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.390	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.390	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.388	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.388	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.387	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:55:06.386	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 2
10-05 14:55:06.377	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.377	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.374	KYOCERA C6930	Warning	27647	services:remot	ClassLoaderContext classpath element mismatch. expected=/system/product/priv-app/VZWAPNLib/VZWAPNLib.apk, found=/product/priv-app/VZWAPNLib/VZWAPNLib.apk (PCL[]{PCL[/system/framework/org.apache.http.legacy.jar*1522375157]#PCL[/system/product/priv-app/VZWAPNLib/VZWAPNLib.apk*4049575408]#PCL[/system/framework/com.verizon.provider.jar*59988602]#PCL[/system_ext/framework/uimremotesimlocklibrary.jar*2659516993]#PCL[/system_ext/framework/remotesimlockmanagerlibrary.jar*256773510]{PCL[/system_ext/framework/uimremotesimlocklibrary.jar*2659516993]}} | PCL[]{PCL[/system/framework/org.apache.http.legacy.jar*1522375157]#PCL[/product/priv-app/VZWAPNLib/VZWAPNLib.apk*4049575408]#PCL[/system/framework/com.verizon.provider.jar*59988602]#PCL[/system_ext/framework/uimremotesimlocklibrary.jar*2659516993]#PCL[/system_ext/framework/remotesimlockmanagerlibrary.jar*256773510]{PCL[/system_ext/framework/uimremotesimlocklibrary.jar*2659516993]}})
10-05 14:55:06.372	KYOCERA C6930	Debug	5007	FavoriteWidget	3x3 onReceive android.intent.action.BATTERY_CHANGED
10-05 14:55:06.366	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.366	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.357	KYOCERA C6930	Warning	27618	essaging.vzmsg	ClassLoaderContext classpath element mismatch. expected=/system/product/priv-app/VZWAPNLib/VZWAPNLib.apk, found=/product/priv-app/VZWAPNLib/VZWAPNLib.apk (PCL[]{PCL[/system/product/priv-app/VZWAPNLib/VZWAPNLib.apk*4049575408]#PCL[/system/framework/org.apache.http.legacy.jar*1522375157]} | PCL[]{PCL[/product/priv-app/VZWAPNLib/VZWAPNLib.apk*4049575408]#PCL[/system/framework/org.apache.http.legacy.jar*1522375157]})
10-05 14:55:06.353	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.353	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.343	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.342	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.333	KYOCERA C6930	Debug	5007	FavoriteWidgetLightService	call isLighting()
10-05 14:55:06.329	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.329	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.327	KYOCERA C6930	Debug	5007	FavoriteWidgetLightService	call isLighting()
10-05 14:55:06.322	KYOCERA C6930	Info	27647	services:remot	The ClassLoaderContext is a special shared library.
10-05 14:55:06.319	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.318	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.305	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.305	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.299	KYOCERA C6930	Info	27647	services:remot	The ClassLoaderContext is a special shared library.
10-05 14:55:06.294	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.294	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.292	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:06.292	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:06.292	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:06.287	KYOCERA C6930	Info	27647	services:remot	The ClassLoaderContext is a special shared library.
10-05 14:55:06.282	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.282	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.276	KYOCERA C6930	Info	27618	essaging.vzmsg	The ClassLoaderContext is a special shared library.
10-05 14:55:06.269	KYOCERA C6930	Debug	27647	nativeloader	classloader namespace configured for unbundled product apk. library_path=/data/app/~~XALKkbSsFUcNGiuIhelI-Q==/com.verizon.mips.services-rSw-46-Ehir5g_1hhCd9Ug==/lib/arm64:/data/app/~~XALKkbSsFUcNGiuIhelI-Q==/com.verizon.mips.services-rSw-46-Ehir5g_1hhCd9Ug==/base.apk!/lib/arm64-v8a:/system/product/priv-app/VZWAPNLib/VZWAPNLib.apk!/lib/arm64-v8a:/product/lib64:/system/product/lib64
10-05 14:55:06.269	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.269	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.268	KYOCERA C6930	Info	27647	services:remot	The ClassLoaderContext is a special shared library.
10-05 14:55:06.267	KYOCERA C6930	Debug	27618	nativeloader	classloader namespace configured for unbundled product apk. library_path=/data/app/~~T4kZWet6Y4M57S9QEMWokg==/com.verizon.messaging.vzmsgs-sZEksBOfxdVmPhELJzy-EA==/lib/arm64:/data/app/~~T4kZWet6Y4M57S9QEMWokg==/com.verizon.messaging.vzmsgs-sZEksBOfxdVmPhELJzy-EA==/base.apk!/lib/arm64-v8a:/system/product/priv-app/VZWAPNLib/VZWAPNLib.apk!/lib/arm64-v8a:/product/lib64:/system/product/lib64
10-05 14:55:06.258	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.258	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.253	KYOCERA C6930	Debug	5007	U	isRestrictVolume() ret : false
10-05 14:55:06.245	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.245	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.243	KYOCERA C6930	Info	27618	essaging.vzmsg	The ClassLoaderContext is a special shared library.
10-05 14:55:06.242	KYOCERA C6930	Info	27647	services:remot	The ClassLoaderContext is a special shared library.
10-05 14:55:06.234	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.234	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.221	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.221	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.210	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.210	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.197	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.197	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.188	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.188	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.186	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.186	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.184	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:55:06.184	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 0
10-05 14:55:06.176	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.175	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.137	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:06.137	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.136	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.126	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.125	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.113	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.113	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.102	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.102	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.093	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.093	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.090	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.090	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.077	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.077	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.066	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.066	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.053	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.053	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.042	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.042	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.029	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.029	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.026	KYOCERA C6930	Debug	5007	FavoriteWidgetBase	FavoriteWidget3x3 onReceiveParallel: action=android.intent.action.BATTERY_CHANGED
10-05 14:55:06.025	KYOCERA C6930	Debug	7115	DeviceStatisticsService	chargerType=2 batteryLevel=100 totalBatteryCapacity=3450000
10-05 14:55:06.021	KYOCERA C6930	Info	26793	adbd	jdwp connection from 27627
10-05 14:55:06.018	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.018	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.005	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:06.005	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:06.005	KYOCERA C6930	Info	777	Zygote	Process 27641 exited due to signal 9 (Killed)
10-05 14:55:06.005	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10219 pid 27641 in 0ms
10-05 14:55:06.004	KYOCERA C6930	Info	1714	ActivityManager	Process com.microsoft.teams (pid 27641) has died: cch+15 CEM 
10-05 14:55:06.002	KYOCERA C6930	Verbose	30573	StatusManager	onReceive [out]
10-05 14:55:06.001	KYOCERA C6930	Verbose	30573	StatusManager	Intent BATTERY_CHANGED
10-05 14:55:06.001	KYOCERA C6930	Verbose	30573	StatusManager	Intent Action : android.intent.action.BATTERY_CHANGED
10-05 14:55:06.001	KYOCERA C6930	Verbose	30573	StatusManager	onReceive [in]
10-05 14:55:05.988	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.988	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.984	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:55:05.983	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 2
10-05 14:55:05.980	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 47628kB at oom_adj 200
10-05 14:55:05.980	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.979	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.microsoft.teams' (27641), uid 10219, oom_adj 915 to free 47628kB
10-05 14:55:05.971	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 1000 pid 27633 in 0ms
10-05 14:55:05.963	KYOCERA C6930	Info	1714	ActivityManager	Process com.android.settings (pid 27633) has died: cch+5 CEM 
10-05 14:55:05.963	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.963	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.963	KYOCERA C6930	Info	777	Zygote	Process 27633 exited due to signal 9 (Killed)
10-05 14:55:05.942	KYOCERA C6930	Info	558	lowmemorykiller	Suppressed 21 failed kill reports
10-05 14:55:05.942	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 46888kB at oom_adj 250
10-05 14:55:05.942	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.942	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.android.settings' (27633), uid 1000, oom_adj 905 to free 46888kB
10-05 14:55:05.862	KYOCERA C6930	Info	1714	system_server	oneway function results will be dropped but finished with status OK and parcel size 4
10-05 14:55:05.831	KYOCERA C6930	Info	925	soundtrigger	audio_extn_sound_trigger_update_device_status: device 0x2 of type 0 for Event 0, with Raise=0
10-05 14:55:05.831	KYOCERA C6930	Debug	925	audio_hw_primary	disable_snd_device: snd_device(2: speaker)
10-05 14:55:05.831	KYOCERA C6930	Debug	925	hardware_info	hw_info_append_hw_type : device_name = speaker
10-05 14:55:05.831	KYOCERA C6930	Debug	925	soundtrigger	audio_extn_sound_trigger_update_stream_status: uc_info->id 1 of type 0 for Event 2, with Raise=0
10-05 14:55:05.825	KYOCERA C6930	Debug	925	audio_hw_primary	disable_audio_route: reset and update mixer path: low-latency-playback speaker
10-05 14:55:05.825	KYOCERA C6930	Info	27627	.sitemanagemen	Unquickening 21 vdex files!
10-05 14:55:05.799	KYOCERA C6930	Debug	925	audio_hw_primary	out_standby: enter: stream (0xe77c21a0) usecase(1: low-latency-playback)
10-05 14:55:05.787	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=false
10-05 14:55:05.781	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.781	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.781	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:55:05.781	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 359
10-05 14:55:05.736	KYOCERA C6930	Info	27627	.sitemanagemen	Late-enabling -Xcheck:jni
10-05 14:55:05.637	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:05.637	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:05.637	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:05.633	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:05.633	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.633	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:05.633	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:05.627	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:05.627	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:05.627	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:05.622	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:05.622	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:05.622	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:05.611	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:55:05.611	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:55:05.611	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:55:05.580	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.579	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.579	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 345
10-05 14:55:05.550	KYOCERA C6930	Warning	26793	adbd	timeout expired while flushing socket, closing
10-05 14:55:05.550	KYOCERA C6930	Warning	26793	adbd	timeout expired while flushing socket, closing
10-05 14:55:05.530	KYOCERA C6930	Error	27633	ndroid.setting	Not starting debugger since process cannot load the jdwp agent.
10-05 14:55:05.530	KYOCERA C6930	Error	27647	services:remot	Not starting debugger since process cannot load the jdwp agent.
10-05 14:55:05.530	KYOCERA C6930	Error	27618	essaging.vzmsg	Not starting debugger since process cannot load the jdwp agent.
10-05 14:55:05.530	KYOCERA C6930	Error	27641	microsoft.team	Not starting debugger since process cannot load the jdwp agent.
10-05 14:55:05.419	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 83ms so far, now at startProcess: done updating pids map
10-05 14:55:05.418	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 83ms so far, now at startProcess: starting to update pids map
10-05 14:55:05.418	KYOCERA C6930	Info	1714	ActivityManager	Start proc 27647:com.verizon.mips.services:remote/u0a140 for service {com.verizon.mips.services/com.vzw.apnservice.VZWAPNServiceNew}
10-05 14:55:05.418	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 83ms so far, now at startProcess: building log message
10-05 14:55:05.418	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 83ms so far, now at startProcess: done updating battery stats
10-05 14:55:05.418	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 83ms so far, now at startProcess: returned from zygote!
10-05 14:55:05.416	KYOCERA C6930	Debug	777	Zygote	Forked child process 27647
10-05 14:55:05.400	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 143937733; UID 10140; state: ENABLED
10-05 14:55:05.400	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 65ms so far, now at startProcess: asking zygote to start proc
10-05 14:55:05.400	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 411ms so far, now at startProcess: done updating pids map
10-05 14:55:05.400	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 411ms so far, now at startProcess: starting to update pids map
10-05 14:55:05.400	KYOCERA C6930	Info	1714	ActivityManager	Start proc 27641:com.microsoft.teams/u0a219 for null
10-05 14:55:05.400	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 411ms so far, now at startProcess: building log message
10-05 14:55:05.400	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 411ms so far, now at startProcess: done updating battery stats
10-05 14:55:05.400	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 411ms so far, now at startProcess: returned from zygote!
10-05 14:55:05.398	KYOCERA C6930	Debug	777	Zygote	Forked child process 27641
10-05 14:55:05.384	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.384	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.383	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 330
10-05 14:55:05.381	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 143937733; UID 10219; state: ENABLED
10-05 14:55:05.381	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 369ms so far, now at startProcess: asking zygote to start proc
10-05 14:55:05.359	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 371ms so far, now at startProcess: done updating pids map
10-05 14:55:05.358	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 371ms so far, now at startProcess: starting to update pids map
10-05 14:55:05.358	KYOCERA C6930	Info	1714	ActivityManager	Start proc 27633:com.android.settings/1000 for null
10-05 14:55:05.358	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 371ms so far, now at startProcess: building log message
10-05 14:55:05.358	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 371ms so far, now at startProcess: done updating battery stats
10-05 14:55:05.358	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 371ms so far, now at startProcess: returned from zygote!
10-05 14:55:05.357	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.356	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.355	KYOCERA C6930	Debug	777	Zygote	Forked child process 27633
10-05 14:55:05.347	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 360ms so far, now at startProcess: asking zygote to start proc
10-05 14:55:05.347	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 449ms so far, now at startProcess: done updating pids map
10-05 14:55:05.347	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 449ms so far, now at startProcess: starting to update pids map
10-05 14:55:05.347	KYOCERA C6930	Info	1714	ActivityManager	Start proc 27627:com.jlgray.sitemanagement/u0a263 for null
10-05 14:55:05.347	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 449ms so far, now at startProcess: building log message
10-05 14:55:05.347	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 449ms so far, now at startProcess: done updating battery stats
10-05 14:55:05.347	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 448ms so far, now at startProcess: returned from zygote!
10-05 14:55:05.346	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.346	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.337	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135754954; UID 10140; state: ENABLED
10-05 14:55:05.336	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135634846; UID 10140; state: DISABLED
10-05 14:55:05.332	KYOCERA C6930	Debug	778	Zygote	Forked child process 27627
10-05 14:55:05.333	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.333	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.332	KYOCERA C6930	Debug	3650	RegisteredNfcFServicesCache	Service unchanged, not updating
10-05 14:55:05.322	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.322	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.314	KYOCERA C6930	Error	3650	RegisteredServicesCache	component namecom.google.android.gms/com.google.android.gms.pay.hce.service.PayHceService
10-05 14:55:05.314	KYOCERA C6930	Error	3650	RegisteredServicesCache	component namecom.google.android.gms/com.google.android.gms.nearby.mediums.nearfieldcommunication.NfcAdvertisingService
10-05 14:55:05.312	KYOCERA C6930	Error	3650	RegisteredServicesCache	1invalidateCache:WriteServiceStateToFile
 Writing service state Data Always
10-05 14:55:05.309	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.309	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.298	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.298	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.286	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.286	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.277	KYOCERA C6930	Error	3650	RegisteredServicesCache	installedServices contains uidString : 10145
10-05 14:55:05.277	KYOCERA C6930	Error	3650	RegisteredServicesCache	installedServices no uidString 
 curr component com.google.android.gms/com.google.android.gms.pay.hce.service.PayHceService
 curr uid 10145
 curr state 2
10-05 14:55:05.277	KYOCERA C6930	Error	3650	RegisteredServicesCache	Next Tag=services
 curr component com.google.android.gms/com.google.android.gms.nearby.mediums.nearfieldcommunication.NfcAdvertisingService
 curr uid 10145
 curr state 2
10-05 14:55:05.276	KYOCERA C6930	Debug	3650	RegisteredServicesCache	ServiceStateFileVersion=1.0
10-05 14:55:05.273	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.273	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.262	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.262	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.249	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.249	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.237	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
 Reading service state data always from file
10-05 14:55:05.236	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.226	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.226	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.224	KYOCERA C6930	Info	2582	rkstack.proces	Background concurrent copying GC freed 11663(630KB) AllocSpace objects, 32(1920KB) LOS objects, 49% free, 2652KB/5305KB, paused 49us total 263.888ms
10-05 14:55:05.213	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.213	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.202	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.202	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.189	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.189	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.185	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 310
10-05 14:55:05.178	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.177	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.177	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.177	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.174	KYOCERA C6930	Debug	2802	CarrierSvcBindHelper	No carrier app for: 0
10-05 14:55:05.166	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.166	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.157	KYOCERA C6930	Debug	9169	[PackageRemovalReceiver]	Extra Data = package:com.companyname.photo1
10-05 14:55:05.157	KYOCERA C6930	Debug	9169	[PackageRemovalReceiver]	Received Action = android.intent.action.PACKAGE_RESTARTED
10-05 14:55:05.153	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.153	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.151	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 143937733; UID 10263; state: DISABLED
10-05 14:55:05.151	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 253ms so far, now at startProcess: asking zygote to start proc
10-05 14:55:05.150	KYOCERA C6930	Warning	1714	BroadcastQueue	Background execution not allowed: receiving Intent { act=android.intent.action.PACKAGE_RESTARTED dat=package:com.companyname.photo1 flg=0x10 (has extras) } to com.securityandprivacy.android.verizon.vms/com.mcafee.verizon.receivers.VZWAutoconnectWifiReceiver
10-05 14:55:05.148	KYOCERA C6930	Warning	1714	Looper	Slow dispatch took 152ms android.ui h=com.android.server.am.ActivityManagerService$UiHandler c=null m=53
10-05 14:55:05.147	KYOCERA C6930	Warning	1714	ActivityManager	setHasOverlayUi called on unknown pid: 14725
10-05 14:55:05.147	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 274ms so far, now at startProcess: done updating pids map
10-05 14:55:05.143	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 270ms so far, now at startProcess: starting to update pids map
10-05 14:55:05.143	KYOCERA C6930	Info	1714	ActivityManager	Start proc 27618:com.verizon.messaging.vzmsgs/u0a98 for null
10-05 14:55:05.143	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 270ms so far, now at startProcess: building log message
10-05 14:55:05.142	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.142	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.136	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 263ms so far, now at startProcess: done updating battery stats
10-05 14:55:05.135	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:05.129	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.129	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.122	KYOCERA C6930	Warning	1714	ActivityManager	Scheduling restart of crashed service com.qualcomm.atfwd/.AtFwdService in 50236ms for start-requested
10-05 14:55:05.120	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10194 pid 27106 in 0ms
10-05 14:55:05.119	KYOCERA C6930	Info	1714	ActivityManager	Process com.qualcomm.telephony (pid 27106) has died: svc SVC 
10-05 14:55:05.118	KYOCERA C6930	Warning	558	lowmemorykiller	Failed to open /proc/27106/oom_score_adj; errno=2: process 27106 might have been killed
10-05 14:55:05.118	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.118	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.112	KYOCERA C6930	Warning	1714	ActivityManager	Scheduling restart of crashed service jp.kyocera.poweronactivation/.CheckEnterpriseActivateService in 83096ms for start-requested
10-05 14:55:05.109	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 1000 pid 27388 in 0ms
10-05 14:55:05.108	KYOCERA C6930	Info	1714	ActivityManager	Process jp.kyocera.poweronactivation (pid 27388) has died: svc SVC 
10-05 14:55:05.105	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:05.104	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.094	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
  Force finishing activity ActivityRecord{1c9b764 u0 com.companyname.photo1/crc64d16f0749eb93bcf3.MainActivity t58}
10-05 14:55:05.093	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:05.077	KYOCERA C6930	Warning	1714	Looper	Slow dispatch took 149ms main h=android.app.ActivityThread$H c=android.app.LoadedApk$ServiceDispatcher$RunConnection@ac3d73f m=0
10-05 14:55:05.062	KYOCERA C6930	Warning	1714	InputMethodManagerService	android.os.DeadObjectException
	at android.os.BinderProxy.transactNative(Native Method)
	at android.os.BinderProxy.transact(BinderProxy.java:550)
	at com.android.internal.view.IInputMethodSession$Stub$Proxy.finishSession(IInputMethodSession.java:432)
	at com.android.server.inputmethod.InputMethodManagerService.finishSessionLocked(InputMethodManagerService.java:2710)
	at com.android.server.inputmethod.InputMethodManagerService.clearClientSessionLocked(InputMethodManagerService.java:2701)
	at com.android.server.inputmethod.InputMethodManagerService.clearCurMethodLocked(InputMethodManagerService.java:2728)
	at com.android.server.inputmethod.InputMethodManagerService.onServiceDisconnected(InputMethodManagerService.java:2757)
	at android.app.LoadedApk$ServiceDispatcher.doDeath(LoadedApk.java:1997)
	at android.app.LoadedApk$ServiceDispatcher$RunConnection.run(LoadedApk.java:2012)
	at android.os.Handler.handleCallback(Handler.java:938)
	at android.os.Handler.dispatchMessage(Handler.java:99)
	at android.os.Looper.loop(Looper.java:223)
	at com.android.server.SystemServer.run(SystemServer.java:639)
	at com.android.server.SystemServer.main(SystemServer.java:425)
	at java.lang.reflect.Method.invoke(Native Method)
	at com.android.internal.os.RuntimeInit$MethodAndArgsCaller.run(RuntimeInit.java:592)
	at com.android.internal.os.ZygoteInit.main(ZygoteInit.java:942)
  Force finishing activity ActivityRecord{60feb35 u0 com.companyname.photo1/crc64ba438d8f48cf7e75.IntermediateActivity t58}
10-05 14:55:05.062	KYOCERA C6930	Warning	1714	InputMethodManagerService	Session failed to close due to remote exception
10-05 14:55:05.061	KYOCERA C6930	Warning	1714	InputMethodManagerService	android.os.DeadObjectException
	at android.os.BinderProxy.transactNative(Native Method)
	at android.os.BinderProxy.transact(BinderProxy.java:550)
	at com.android.internal.view.IInputMethodSession$Stub$Proxy.finishSession(IInputMethodSession.java:432)
	at com.android.server.inputmethod.InputMethodManagerService.finishSessionLocked(InputMethodManagerService.java:2710)
	at com.android.server.inputmethod.InputMethodManagerService.clearClientSessionLocked(InputMethodManagerService.java:2701)
	at com.android.server.inputmethod.InputMethodManagerService.clearCurMethodLocked(InputMethodManagerService.java:2728)
	at com.android.server.inputmethod.InputMethodManagerService.onServiceDisconnected(InputMethodManagerService.java:2757)
	at android.app.LoadedApk$ServiceDispatcher.doDeath(LoadedApk.java:1997)
	at android.app.LoadedApk$ServiceDispatcher$RunConnection.run(LoadedApk.java:2012)
	at android.os.Handler.handleCallback(Handler.java:938)
	at android.os.Handler.dispatchMessage(Handler.java:99)
	at android.os.Looper.loop(Looper.java:223)
	at com.android.server.SystemServer.run(SystemServer.java:639)
	at com.android.server.SystemServer.main(SystemServer.java:425)
	at java.lang.reflect.Method.invoke(Native Method)
	at com.android.internal.os.RuntimeInit$MethodAndArgsCaller.run(RuntimeInit.java:592)
	at com.android.internal.os.ZygoteInit.main(ZygoteInit.java:942)
10-05 14:55:05.061	KYOCERA C6930	Warning	1714	InputMethodManagerService	Session failed to close due to remote exception
10-05 14:55:05.048	KYOCERA C6930	Info	1714	ActivityManager	Force stopping com.companyname.photo1 appid=10258 user=0: from pid 27609
10-05 14:55:05.039	KYOCERA C6930	Warning	1714	InputMethodManagerService	android.os.DeadObjectException
	at android.os.BinderProxy.transactNative(Native Method)
	at android.os.BinderProxy.transact(BinderProxy.java:550)
	at com.android.internal.view.IInputMethodSession$Stub$Proxy.finishSession(IInputMethodSession.java:432)
	at com.android.server.inputmethod.InputMethodManagerService.finishSessionLocked(InputMethodManagerService.java:2710)
	at com.android.server.inputmethod.InputMethodManagerService.clearClientSessionLocked(InputMethodManagerService.java:2701)
	at com.android.server.inputmethod.InputMethodManagerService.clearCurMethodLocked(InputMethodManagerService.java:2728)
	at com.android.server.inputmethod.InputMethodManagerService.onServiceDisconnected(InputMethodManagerService.java:2757)
	at android.app.LoadedApk$ServiceDispatcher.doDeath(LoadedApk.java:1997)
	at android.app.LoadedApk$ServiceDispatcher$RunConnection.run(LoadedApk.java:2012)
	at android.os.Handler.handleCallback(Handler.java:938)
	at android.os.Handler.dispatchMessage(Handler.java:99)
	at android.os.Looper.loop(Looper.java:223)
	at com.android.server.SystemServer.run(SystemServer.java:639)
	at com.android.server.SystemServer.main(SystemServer.java:425)
	at java.lang.reflect.Method.invoke(Native Method)
	at com.android.internal.os.RuntimeInit$MethodAndArgsCaller.run(RuntimeInit.java:592)
	at com.android.internal.os.ZygoteInit.main(ZygoteInit.java:942)
10-05 14:55:05.039	KYOCERA C6930	Warning	1714	InputMethodManagerService	Session failed to close due to remote exception
10-05 14:55:04.996	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 123ms so far, now at startProcess: returned from zygote!
10-05 14:55:04.994	KYOCERA C6930	Warning	1714	ActivityManager	Scheduling restart of crashed service com.google.android.inputmethod.latin/com.android.inputmethod.latin.LatinIME in 40363ms for connection
10-05 14:55:04.990	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10163 pid 14725 in 0ms
10-05 14:55:04.990	KYOCERA C6930	Debug	777	Zygote	Forked child process 27618
10-05 14:55:04.973	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.990	KYOCERA C6930	Info	1714	ActivityManager	Process com.google.android.inputmethod.latin (pid 14725) has died: prcp IMPB
10-05 14:55:04.989	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135754954; UID 10219; state: ENABLED
10-05 14:55:04.989	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135634846; UID 10219; state: DISABLED
10-05 14:55:04.988	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135754954; UID 1000; state: ENABLED
10-05 14:55:04.988	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135634846; UID 1000; state: DISABLED
10-05 14:55:04.973	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.928	KYOCERA C6930	Debug	1714	ConnectivityService	releasing NetworkRequest [ TRACK_DEFAULT id=1800, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10163 AdministratorUids: [] RequestorUid: 10163 RequestorPackageName: com.google.android.inputmethod.latin] ] (release request)
10-05 14:55:04.927	KYOCERA C6930	Warning	1714	InputDispatcher	Attempted to unregister already unregistered input channel '286d42c InputMethod (server)'
10-05 14:55:04.927	KYOCERA C6930	Info	777	Zygote	Process 14725 exited due to signal 9 (Killed)
10-05 14:55:04.927	KYOCERA C6930	Info	1714	WindowManager	WIN DEATH: Window{286d42c u0 InputMethod}
10-05 14:55:04.927	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ TRACK_DEFAULT id=1800, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10163 AdministratorUids: [] RequestorUid: 10163 RequestorPackageName: com.google.android.inputmethod.latin] ], android.os.BinderProxy@9602d86)
10-05 14:55:04.926	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ LISTEN id=1801, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED&FOREGROUND Uid: 10163 AdministratorUids: [] RequestorUid: 10163 RequestorPackageName: com.google.android.inputmethod.latin] ], android.os.BinderProxy@3099e61)
10-05 14:55:04.925	KYOCERA C6930	Info	558	lowmemorykiller	6 memory pressure events were skipped after a kill!
10-05 14:55:04.902	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135634846; UID 10263; state: DISABLED
10-05 14:55:04.899	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 143937733; UID 10098; state: ENABLED
10-05 14:55:04.898	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 116ms so far, now at startProcess: done starting proc!
10-05 14:55:04.884	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135754954; UID 10098; state: ENABLED
10-05 14:55:04.882	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135634846; UID 10098; state: DISABLED
10-05 14:55:04.873	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 91ms so far, now at startProcess: stepping in to startProcess
10-05 14:55:04.873	KYOCERA C6930	Warning	1714	ActivityManager	Slow operation: 91ms so far, now at startProcess: done creating new process record
10-05 14:55:04.857	KYOCERA C6930	Info	558	lowmemorykiller	Suppressed 2 failed kill reports
10-05 14:55:04.857	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 36128kB at oom_adj 200
10-05 14:55:04.857	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.855	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.google.android.inputmethod.latin' (14725), uid 10163, oom_adj 200 to free 36128kB
10-05 14:55:04.818	KYOCERA C6930	Info	777	Zygote	Process 27388 exited due to signal 9 (Killed)
10-05 14:55:04.805	KYOCERA C6930	Info	777	Zygote	Process 27106 exited due to signal 9 (Killed)
10-05 14:55:04.804	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 19112kB at oom_adj 250
10-05 14:55:04.804	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.804	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'jp.kyocera.poweronactivation' (27388), uid 1000, oom_adj 500 to free 19112kB
10-05 14:55:04.780	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.780	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.766	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 18500kB at oom_adj 250
10-05 14:55:04.766	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.766	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.qualcomm.telephony' (27106), uid 10194, oom_adj 800 to free 18500kB
10-05 14:55:04.759	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=true
10-05 14:55:04.754	KYOCERA C6930	Verbose	30573	StatusManager	onReceive [out]
10-05 14:55:04.754	KYOCERA C6930	Verbose	30573	StatusManager	TEMPERATURE_CHANGED : 29 battery : 100 , board : 27
10-05 14:55:04.754	KYOCERA C6930	Verbose	30573	StatusManager	Test battery level : 100%
10-05 14:55:04.753	KYOCERA C6930	Verbose	30573	MainActivity	getVideoSize [out] 1920x1080
10-05 14:55:04.753	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeHeight [out]: 1080
10-05 14:55:04.753	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeHeight [in]
10-05 14:55:04.753	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeWidth [out]: 1920
10-05 14:55:04.753	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeWidth [in]
10-05 14:55:04.753	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizeMovie [out] : 107
10-05 14:55:04.752	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG movie size : 0:setting_video_size_wide_video = NOT SUPPORTED: 107 change to 4
10-05 14:55:04.750	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.750	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.746	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.746	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.746	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListMovie [in]
10-05 14:55:04.746	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizeMovie [in]
10-05 14:55:04.745	KYOCERA C6930	Verbose	30573	MainActivity	getVideoSize [in]
10-05 14:55:04.742	KYOCERA C6930	Verbose	30573	StatusManager	Intent Action : jp.kyocera.internal.devicemonitor.ThermalMonitor.action.TEMPERATURE_CHANGED
10-05 14:55:04.741	KYOCERA C6930	Verbose	30573	StatusManager	onReceive [in]
10-05 14:55:04.741	KYOCERA C6930	Warning	1714	ActivityManager	setHasOverlayUi called on unknown pid: 26335
10-05 14:55:04.737	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.737	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.724	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.724	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.721	KYOCERA C6930	Warning	925	audio_hw_primary	out_write: underrun(1344) frames_by_time(49476) > out->last_fifo_frames_remaining(384)
10-05 14:55:04.714	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=false
10-05 14:55:04.714	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.714	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.702	KYOCERA C6930	Warning	1714	InputDispatcher	Attempted to unregister already unregistered input channel 'f382a04 com.companyname.photo1/crc64ba438d8f48cf7e75.IntermediateActivity (server)'
10-05 14:55:04.701	KYOCERA C6930	Info	1714	WindowManager	WIN DEATH: Window{f382a04 u0 com.companyname.photo1/crc64ba438d8f48cf7e75.IntermediateActivity}
10-05 14:55:04.701	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.701	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.690	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.690	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.677	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.677	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.666	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.666	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.654	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.654	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.641	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.641	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.637	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.630	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.630	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.626	KYOCERA C6930	Error	929	anc_fullhdr	cant find context data, model_key:(SEGMENT, 0) !
10-05 14:55:04.617	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.617	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.604	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.602	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.589	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.589	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.577	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.577	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.573	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.573	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.566	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.566	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.561	KYOCERA C6930	Warning	1714	InputDispatcher	Attempted to unregister already unregistered input channel 'f5d3b6 com.companyname.photo1/crc64d16f0749eb93bcf3.MainActivity (server)'
10-05 14:55:04.553	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.553	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.542	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.542	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.529	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.529	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.519	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.518	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.506	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.505	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.493	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.493	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.482	KYOCERA C6930	Info	1714	WindowManager	WIN DEATH: Window{f5d3b6 u0 com.companyname.photo1/crc64d16f0749eb93bcf3.MainActivity}
10-05 14:55:04.482	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.482	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.469	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.469	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.466	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10258 pid 26335 in 0ms
10-05 14:55:04.457	KYOCERA C6930	Info	1714	ActivityManager	Process com.companyname.photo1 (pid 26335) has died: prev LAST
10-05 14:55:04.456	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.456	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.456	KYOCERA C6930	Info	777	Zygote	Process 26335 exited due to signal 9 (Killed)
10-05 14:55:04.428	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 1000 pid 26827 in 0ms
10-05 14:55:04.416	KYOCERA C6930	Warning	1714	ActivityManager	Scheduling restart of crashed service com.kyocera.waterproof/.WaterProofService in 30941ms for start-requested
10-05 14:55:04.415	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 112588kB at oom_adj 0
10-05 14:55:04.415	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.415	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.companyname.photo1' (26335), uid 10258, oom_adj 700 to free 112588kB
10-05 14:55:04.411	KYOCERA C6930	Info	1714	ActivityManager	Process com.kyocera.waterproof (pid 26827) has died: svcb SVC 
10-05 14:55:04.411	KYOCERA C6930	Info	777	Zygote	Process 26827 exited due to signal 9 (Killed)
10-05 14:55:04.399	KYOCERA C6930	Warning	1714	ActivityManager	Scheduling restart of crashed service com.kyocera.PcoStatusReceiver/.PcoStartUpReceiverService in 20958ms for start-requested
10-05 14:55:04.399	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 18772kB at oom_adj 0
10-05 14:55:04.399	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.399	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.kyocera.waterproof' (26827), uid 1000, oom_adj 800 to free 18772kB
10-05 14:55:04.397	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 1001 pid 24910 in 0ms
10-05 14:55:04.396	KYOCERA C6930	Info	1714	ActivityManager	Process com.kyocera.PcoStatusReceiver (pid 24910) has died: svcb SVC 
10-05 14:55:04.396	KYOCERA C6930	Info	777	Zygote	Process 24910 exited due to signal 9 (Killed)
10-05 14:55:04.380	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 1000 pid 26505 in 0ms
10-05 14:55:04.378	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 18788kB at oom_adj 0
10-05 14:55:04.378	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.378	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.kyocera.PcoStatusReceiver' (24910), uid 1001, oom_adj 800 to free 18788kB
10-05 14:55:04.378	KYOCERA C6930	Error	558	libprocessgroup	set_timerslack_ns write failed: No such process
10-05 14:55:04.377	KYOCERA C6930	Warning	1714	ActivityManager	Scheduling restart of crashed service com.qti.diagservices/.QTIDiagServices in 10980ms for start-requested
10-05 14:55:04.373	KYOCERA C6930	Info	1714	ActivityManager	Process com.qti.diagservices (pid 26505) has died: svcb SVC 
10-05 14:55:04.372	KYOCERA C6930	Info	777	Zygote	Process 26505 exited due to signal 9 (Killed)
10-05 14:55:04.367	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.367	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.357	KYOCERA C6930	Warning	1714	ActivityManager	Scheduling restart of crashed service com.verizon.mips.services/com.vzw.apnservice.VZWAPNServiceNew in 1000ms for start-requested
10-05 14:55:04.339	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 19044kB at oom_adj 0
10-05 14:55:04.339	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.339	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.qti.diagservices' (26505), uid 1000, oom_adj 800 to free 19044kB
10-05 14:55:04.338	KYOCERA C6930	Error	558	libprocessgroup	set_timerslack_ns write failed: No such process
10-05 14:55:04.327	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10140 pid 24836 in 0ms
10-05 14:55:04.327	KYOCERA C6930	Info	1714	ActivityManager	Process com.verizon.mips.services:remote (pid 24836) has died: svcb SVC 
10-05 14:55:04.326	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.326	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.326	KYOCERA C6930	Info	777	Zygote	Process 24836 exited due to signal 9 (Killed)
10-05 14:55:04.297	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 21908kB at oom_adj 0
10-05 14:55:04.297	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.297	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.verizon.mips.services:remote' (24836), uid 10140, oom_adj 800 to free 21908kB
10-05 14:55:04.284	KYOCERA C6930	Debug	970	KcWifi	[KcWifi] waitForEvent: waitForEvent fb[6]
10-05 14:55:04.282	KYOCERA C6930	Debug	2751	KcWifiSocketManager	waitForEvent failed: -1
10-05 14:55:04.274	KYOCERA C6930	Error	970	KcWifi	[KcWifi] waitForEvent: recv timeout
10-05 14:55:04.274	KYOCERA C6930	Error	970	KcWifi	[KcWifi] waitForEvent: recv failed
10-05 14:55:04.273	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.273	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.262	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.262	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.249	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.249	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.238	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.238	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.228	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10145 pid 23630 in 0ms
10-05 14:55:04.228	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.227	KYOCERA C6930	Info	777	Zygote	Process 23630 exited due to signal 9 (Killed)
10-05 14:55:04.227	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.167	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.227	KYOCERA C6930	Info	1714	ActivityManager	Process com.google.android.gms (pid 23630) has died: cch+5 CEM 
10-05 14:55:04.167	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.164	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 6040kB at oom_adj 0
10-05 14:55:04.163	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.163	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.google.android.gms' (23630), uid 10145, oom_adj 905 to free 6040kB
10-05 14:55:04.163	KYOCERA C6930	Warning	558	lowmemorykiller	Failed to get t_pid for '0' of pid(23630)
10-05 14:55:04.141	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:04.137	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.137	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.126	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.126	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.113	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.113	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.102	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10215 pid 14088 in 0ms
10-05 14:55:04.102	KYOCERA C6930	Debug	1714	ConnectivityService	releasing NetworkRequest [ TRACK_DEFAULT id=1738, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10215 AdministratorUids: [] RequestorUid: 10215 RequestorPackageName: com.microsoft.office.outlook] ] (release request)
10-05 14:55:04.102	KYOCERA C6930	Info	1714	ActivityManager	Process com.microsoft.office.outlook (pid 14088) has died: cch+15 CEM 
10-05 14:55:04.102	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ LISTEN id=1736, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED&NOT_VPN&FOREGROUND Uid: 10215 AdministratorUids: [] RequestorUid: 10215 RequestorPackageName: com.microsoft.office.outlook] ], android.os.BinderProxy@77fb329)
10-05 14:55:04.102	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ TRACK_DEFAULT id=1738, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10215 AdministratorUids: [] RequestorUid: 10215 RequestorPackageName: com.microsoft.office.outlook] ], android.os.BinderProxy@1f0f8b0)
10-05 14:55:04.101	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ LISTEN id=1740, [ Capabilities: NOT_RESTRICTED&TRUSTED&NOT_VPN&FOREGROUND Uid: 10215 AdministratorUids: [] RequestorUid: 10215 RequestorPackageName: com.microsoft.office.outlook] ], android.os.BinderProxy@c0353f3)
10-05 14:55:04.101	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.101	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:04.101	KYOCERA C6930	Info	777	Zygote	Process 14088 exited due to signal 9 (Killed)
10-05 14:55:04.100	KYOCERA C6930	Info	558	lowmemorykiller	4 memory pressure events were skipped after a kill!
10-05 14:55:04.065	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 27220kB at oom_adj 100
10-05 14:55:04.065	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.065	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.microsoft.office.outlook' (14088), uid 10215, oom_adj 915 to free 27220kB
10-05 14:55:04.065	KYOCERA C6930	Error	558	libprocessgroup	set_timerslack_ns write failed: No such process
10-05 14:55:04.064	KYOCERA C6930	Error	558	libprocessgroup	set_timerslack_ns write failed: No such process
10-05 14:55:04.059	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10136 pid 24982 in 0ms
10-05 14:55:04.058	KYOCERA C6930	Info	1714	ActivityManager	Process com.android.vending (pid 24982) has died: cch+25 CEM 
10-05 14:55:04.058	KYOCERA C6930	Debug	1714	ConnectivityService	releasing NetworkRequest [ TRACK_DEFAULT id=1835, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10136 AdministratorUids: [] RequestorUid: 10136 RequestorPackageName: com.android.vending] ] (release request)
10-05 14:55:04.058	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ TRACK_DEFAULT id=1835, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10136 AdministratorUids: [] RequestorUid: 10136 RequestorPackageName: com.android.vending] ], android.os.BinderProxy@c72d662)
10-05 14:55:04.058	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ LISTEN id=1836, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10136 AdministratorUids: [] RequestorUid: 10136 RequestorPackageName: com.android.vending] ], android.os.BinderProxy@964312d)
10-05 14:55:04.057	KYOCERA C6930	Info	777	Zygote	Process 24982 exited due to signal 9 (Killed)
10-05 14:55:04.013	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 15564kB at oom_adj 200
10-05 14:55:04.013	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:04.013	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.android.vending' (24982), uid 10136, oom_adj 925 to free 15564kB
10-05 14:55:04.012	KYOCERA C6930	Error	558	libprocessgroup	set_timerslack_ns write failed: No such process
10-05 14:55:03.999	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10209 pid 23107 in 0ms
10-05 14:55:03.999	KYOCERA C6930	Info	1714	ActivityManager	Process com.google.android.permissioncontroller (pid 23107) has died: cch+35 CEM 
10-05 14:55:03.998	KYOCERA C6930	Info	777	Zygote	Process 23107 exited due to signal 9 (Killed)
10-05 14:55:03.974	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 10136kB at oom_adj 250
10-05 14:55:03.974	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.974	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.google.android.permissioncontroller' (23107), uid 10209, oom_adj 935 to free 10136kB
10-05 14:55:03.973	KYOCERA C6930	Debug	1714	ConnectivityService	releasing NetworkRequest [ TRACK_DEFAULT id=1837, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10136 AdministratorUids: [] RequestorUid: 10136 RequestorPackageName: com.android.vending] ] (release request)
10-05 14:55:03.971	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10136 pid 25100 in 0ms
10-05 14:55:03.971	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ TRACK_DEFAULT id=1837, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10136 AdministratorUids: [] RequestorUid: 10136 RequestorPackageName: com.android.vending] ], android.os.BinderProxy@9a85c44)
10-05 14:55:03.971	KYOCERA C6930	Info	1714	ActivityManager	Process com.android.vending:background (pid 25100) has died: cch+45 CEM 
10-05 14:55:03.971	KYOCERA C6930	Info	777	Zygote	Process 25100 exited due to signal 9 (Killed)
10-05 14:55:03.965	KYOCERA C6930	Info	14725	GoogleInputMethodService	GoogleInputMethodService.onTrimMemory():4476 onTrimMemory(): 15
10-05 14:55:03.964	KYOCERA C6930	Info	14725	AppBase	AppBase.onTrimMemory():765 onTrimMemory(): 15
10-05 14:55:03.964	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.964	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.934	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10145 pid 31752 in 2ms
10-05 14:55:03.934	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 12632kB at oom_adj 900
10-05 14:55:03.934	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.934	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.android.vending:background' (25100), uid 10136, oom_adj 945 to free 12632kB
10-05 14:55:03.930	KYOCERA C6930	Info	1714	ActivityManager	Process com.google.process.gservices (pid 31752) has died: cch+55 CEM 
10-05 14:55:03.930	KYOCERA C6930	Info	777	Zygote	Process 31752 exited due to signal 9 (Killed)
10-05 14:55:03.912	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 11064kB at oom_adj 900
10-05 14:55:03.912	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.912	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.google.process.gservices' (31752), uid 10145, oom_adj 955 to free 11064kB
10-05 14:55:03.894	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.894	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.881	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.881	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.870	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.870	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.857	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.857	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.846	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.846	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.833	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.833	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.822	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.822	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.809	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.809	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.798	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.798	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.785	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.785	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.774	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.774	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.763	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.763	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.762	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.761	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.749	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.749	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.738	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.738	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.725	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.725	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.715	KYOCERA C6930	Warning	1714	Looper	Drained
10-05 14:55:03.712	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.712	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.712	KYOCERA C6930	Info	777	Zygote	Process 15843 exited due to signal 9 (Killed)
10-05 14:55:03.712	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10138 pid 15843 in 0ms
10-05 14:55:03.711	KYOCERA C6930	Info	1714	ActivityManager	Process com.securityandprivacy.android.verizon.vms (pid 15843) has died: cch+65 CEM 
10-05 14:55:03.711	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ LISTEN id=1759, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED&NOT_VPN Uid: 10138 AdministratorUids: [] RequestorUid: 10138 RequestorPackageName: com.securityandprivacy.android.verizon.vms] ], android.os.BinderProxy@dba7957)
10-05 14:55:03.694	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=true
10-05 14:55:03.685	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 16776kB at oom_adj 900
10-05 14:55:03.685	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.685	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.securityandprivacy.android.verizon.vms' (15843), uid 10138, oom_adj 965 to free 16776kB
10-05 14:55:03.665	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.665	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.654	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.654	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.646	KYOCERA C6930	Warning	925	audio_hw_primary	out_write: underrun(1343) frames_by_time(50621) > out->last_fifo_frames_remaining(384)
10-05 14:55:03.641	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.641	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.640	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.640	KYOCERA C6930	Warning	1714	Looper	Slow delivery took 367ms android.ui h=com.android.server.am.ActivityManagerService$UiHandler c=null m=32
10-05 14:55:03.639	KYOCERA C6930	Warning	1714	Looper	Slow dispatch took 575ms android.ui h=com.android.server.am.ActivityManagerService$UiHandler c=null m=31
10-05 14:55:03.636	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=false
10-05 14:55:03.635	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 1000 pid 25149 in 0ms
10-05 14:55:03.634	KYOCERA C6930	Info	1714	ActivityManager	Process com.android.keychain (pid 25149) has died: cch+75 CEM 
10-05 14:55:03.630	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.630	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.629	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10098 pid 13469 in 0ms
10-05 14:55:03.628	KYOCERA C6930	Info	1714	ActivityManager	Process com.verizon.messaging.vzmsgs (pid 13469) has died: cch+85 CEM 
10-05 14:55:03.628	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10145 pid 25063 in 0ms
10-05 14:55:03.627	KYOCERA C6930	Warning	558	lowmemorykiller	Failed to open /proc/13469/oom_score_adj; errno=2: process 13469 might have been killed
10-05 14:55:03.624	KYOCERA C6930	Warning	558	lowmemorykiller	Failed to open /proc/13469/oom_score_adj; errno=2: process 13469 might have been killed
10-05 14:55:03.624	KYOCERA C6930	Warning	558	lowmemorykiller	Failed to open /proc/25063/oom_score_adj; errno=2: process 25063 might have been killed
10-05 14:55:03.624	KYOCERA C6930	Warning	558	lowmemorykiller	Failed to open /proc/25149/oom_score_adj; errno=2: process 25149 might have been killed
10-05 14:55:03.623	KYOCERA C6930	Info	1714	ActivityManager	Process com.google.process.gapps (pid 25063) has died: cch+85 CEM 
10-05 14:55:03.620	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10208 pid 13421 in 0ms
10-05 14:55:03.620	KYOCERA C6930	Info	1714	ActivityManager	Process com.google.android.cellbroadcastreceiver (pid 13421) has died: cch+55 CEM 
10-05 14:55:03.618	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.618	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.614	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10160 pid 24394 in 0ms
10-05 14:55:03.614	KYOCERA C6930	Info	1714	ActivityManager	Process com.google.android.gm (pid 24394) has died: cch+55 CEM 
10-05 14:55:03.607	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10077 pid 19044 in 0ms
10-05 14:55:03.606	KYOCERA C6930	Info	1714	ActivityManager	Process android.process.acore (pid 19044) has died: cch+65 CEM 
10-05 14:55:03.605	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.605	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.602	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10132 pid 24496 in 0ms
10-05 14:55:03.601	KYOCERA C6930	Info	1714	ActivityManager	Process com.google.android.apps.turbo:aab (pid 24496) has died: cch+65 CEM 
10-05 14:55:03.595	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10151 pid 23257 in 0ms
10-05 14:55:03.594	KYOCERA C6930	Info	1714	ActivityManager	Process com.android.chrome:privileged_process0 (pid 23257) has died: cch+75 CEM 
10-05 14:55:03.593	KYOCERA C6930	Warning	558	lowmemorykiller	Failed to open /proc/23257/oom_score_adj; errno=2: process 23257 might have been killed
10-05 14:55:03.593	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.593	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.581	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.581	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.576	KYOCERA C6930	Warning	558	lowmemorykiller	Failed to open /proc/23257/oom_score_adj; errno=2: process 23257 might have been killed
10-05 14:55:03.572	KYOCERA C6930	Warning	1714	ActivityManager	android.os.DeadObjectException
	at android.os.BinderProxy.transactNative(Native Method)
	at android.os.BinderProxy.transact(BinderProxy.java:550)
	at android.app.IApplicationThread$Stub$Proxy.scheduleUnbindService(IApplicationThread.java:1646)
	at com.android.server.am.ActiveServices.removeConnectionLocked(ActiveServices.java:3723)
	at com.android.server.am.ActiveServices.killServicesLocked(ActiveServices.java:4134)
	at com.android.server.am.ActivityManagerService.cleanUpApplicationRecordLocked(ActivityManagerService.java:14832)
	at com.android.server.am.ActivityManagerService.handleAppDiedLocked(ActivityManagerService.java:3820)
	at com.android.server.am.ActivityManagerService.appDiedLocked(ActivityManagerService.java:3981)
	at com.android.server.am.ActivityManagerService$AppDeathRecipient.binderDied(ActivityManagerService.java:1623)
	at android.os.IBinder$DeathRecipient.binderDied(IBinder.java:305)
	at android.os.BinderProxy.sendDeathNotice(BinderProxy.java:664)
10-05 14:55:03.572	KYOCERA C6930	Warning	1714	ActivityManager	Exception when unbinding service com.android.chrome/org.chromium.content.app.PrivilegedProcessService0
10-05 14:55:03.570	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.570	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.560	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.560	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.557	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.557	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.544	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.544	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.540	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:778 CreateHandle() api create_handle X
10-05 14:55:03.534	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.534	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.533	KYOCERA C6930	Error	929	anc_fullhdr	customer module name:REAR_WIDE_1 is not set in json file!
10-05 14:55:03.531	KYOCERA C6930	Error	929	anc_fullhdr	/data/vendor/camera/hdr/anc_fullhdr_params.bin open failed!
10-05 14:55:03.527	KYOCERA C6930	Error	929	anc_fullhdr	customer module name:REAR_WIDE_1 is not set in json file!
10-05 14:55:03.521	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup6: Permission denied
10-05 14:55:03.521	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup21: Permission denied
10-05 14:55:03.521	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.521	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.520	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup31: Permission denied
10-05 14:55:03.520	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup41: Permission denied
10-05 14:55:03.519	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup8: Permission denied
10-05 14:55:03.519	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup51: Permission denied
10-05 14:55:03.519	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup23: Permission denied
10-05 14:55:03.519	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup61: Permission denied
10-05 14:55:03.518	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup33: Permission denied
10-05 14:55:03.518	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup43: Permission denied
10-05 14:55:03.517	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup81: Permission denied
10-05 14:55:03.517	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup53: Permission denied
10-05 14:55:03.517	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup25: Permission denied
10-05 14:55:03.516	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup63: Permission denied
10-05 14:55:03.515	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup45: Permission denied
10-05 14:55:03.514	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup55: Permission denied
10-05 14:55:03.513	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup27: Permission denied
10-05 14:55:03.513	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup37: Permission denied
10-05 14:55:03.513	KYOCERA C6930	Error	929	anc_fullhdr	*** *** *** *** *** *** *** *** *** *** *** *** *** *** *** ***
10-05 14:55:03.512	KYOCERA C6930	Error	929	anc_fullhdr	*** *** *** *** *** *** *** *** *** *** *** *** *** *** *** ***
 Build fingerprint: e875d869, build number: 420, date: 2021_08_18_17_36_19
 SDK version: 2.0.19
10-05 14:55:03.512	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup3: Permission denied
10-05 14:55:03.511	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup19: Permission denied
10-05 14:55:03.511	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup57: Permission denied
10-05 14:55:03.510	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup29: Permission denied
10-05 14:55:03.510	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.510	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.509	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup39: Permission denied
10-05 14:55:03.509	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup5: Permission denied
10-05 14:55:03.508	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup20: Permission denied
10-05 14:55:03.507	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup59: Permission denied
10-05 14:55:03.507	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup30: Permission denied
10-05 14:55:03.506	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup40: Permission denied
10-05 14:55:03.505	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup7: Permission denied
10-05 14:55:03.505	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup50: Permission denied
10-05 14:55:03.504	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup60: Permission denied
10-05 14:55:03.503	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup32: Permission denied
10-05 14:55:03.502	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup42: Permission denied
10-05 14:55:03.501	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup14: Permission denied
10-05 14:55:03.501	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup9: Permission denied
10-05 14:55:03.501	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup52: Permission denied
10-05 14:55:03.501	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup24: Permission denied
10-05 14:55:03.500	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup62: Permission denied
10-05 14:55:03.500	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup34: Permission denied
10-05 14:55:03.499	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup170: Permission denied
10-05 14:55:03.499	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup44: Permission denied
10-05 14:55:03.498	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup16: Permission denied
10-05 14:55:03.498	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup54: Permission denied
10-05 14:55:03.497	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup26: Permission denied
10-05 14:55:03.497	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.497	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.497	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup36: Permission denied
10-05 14:55:03.491	KYOCERA C6930	Warning	648	Binder:648_1	type=1400 audit(0.0:541195): avc: denied { read } for name="wakeup4" dev="sysfs" ino=44738 scontext=u:r:system_suspend:s0 tcontext=u:object_r:sysfs:s0 tclass=dir permissive=0
10-05 14:55:03.491	KYOCERA C6930	Warning	648	Binder:648_1	type=1400 audit(0.0:541194): avc: denied { read } for name="wakeup48" dev="sysfs" ino=76308 scontext=u:r:system_suspend:s0 tcontext=u:object_r:sysfs:s0 tclass=dir permissive=0
10-05 14:55:03.496	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup46: Permission denied
10-05 14:55:03.495	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup56: Permission denied
10-05 14:55:03.494	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup28: Permission denied
10-05 14:55:03.487	KYOCERA C6930	Warning	648	Binder:648_1	type=1400 audit(0.0:541193): avc: denied { read } for name="wakeup58" dev="sysfs" ino=84647 scontext=u:r:system_suspend:s0 tcontext=u:object_r:sysfs:s0 tclass=dir permissive=0
10-05 14:55:03.493	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup4: Permission denied
10-05 14:55:03.493	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup48: Permission denied
10-05 14:55:03.492	KYOCERA C6930	Error	648	android.system.suspend@1.0-service	Error opening kernel wakelock stats for: wakeup58: Permission denied
10-05 14:55:03.486	KYOCERA C6930	Info	24982	Finsky	[2] mhx.accept(9): Flushing in-memory image cache
10-05 14:55:03.485	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.485	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.478	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:764 CreateHandle() api create_handle E
10-05 14:55:03.478	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1393 ProcessRequest() [Anc Hdr]: frameNum 1, i 8, format: 3, width 4656,height 3496,numberofPlanes 2,planeStride 5120,sliceHeight 3584
10-05 14:55:03.478	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1388 ProcessRequest() Y 18350080,UV 9175040,plane3 0
10-05 14:55:03.477	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1393 ProcessRequest() [Anc Hdr]: frameNum 1, i 7, format: 3, width 4656,height 3496,numberofPlanes 2,planeStride 5120,sliceHeight 3584
10-05 14:55:03.476	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1388 ProcessRequest() Y 18350080,UV 9175040,plane3 0
10-05 14:55:03.475	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1393 ProcessRequest() [Anc Hdr]: frameNum 1, i 6, format: 3, width 4656,height 3496,numberofPlanes 2,planeStride 5120,sliceHeight 3584
10-05 14:55:03.475	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1388 ProcessRequest() Y 18350080,UV 9175040,plane3 0
10-05 14:55:03.474	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.474	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.473	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1393 ProcessRequest() [Anc Hdr]: frameNum 1, i 5, format: 3, width 4656,height 3496,numberofPlanes 2,planeStride 5120,sliceHeight 3584
10-05 14:55:03.473	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1388 ProcessRequest() Y 18350080,UV 9175040,plane3 0
10-05 14:55:03.471	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1393 ProcessRequest() [Anc Hdr]: frameNum 1, i 4, format: 3, width 4656,height 3496,numberofPlanes 2,planeStride 5120,sliceHeight 3584
10-05 14:55:03.471	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1388 ProcessRequest() Y 18350080,UV 9175040,plane3 0
10-05 14:55:03.469	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1393 ProcessRequest() [Anc Hdr]: frameNum 1, i 3, format: 3, width 4656,height 3496,numberofPlanes 2,planeStride 5120,sliceHeight 3584
10-05 14:55:03.469	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1388 ProcessRequest() Y 18350080,UV 9175040,plane3 0
10-05 14:55:03.468	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1393 ProcessRequest() [Anc Hdr]: frameNum 1, i 2, format: 3, width 4656,height 3496,numberofPlanes 2,planeStride 5120,sliceHeight 3584
10-05 14:55:03.468	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1388 ProcessRequest() Y 18350080,UV 9175040,plane3 0
10-05 14:55:03.466	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1393 ProcessRequest() [Anc Hdr]: frameNum 1, i 1, format: 3, width 4656,height 3496,numberofPlanes 2,planeStride 5120,sliceHeight 3584
10-05 14:55:03.466	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1388 ProcessRequest() Y 18350080,UV 9175040,plane3 0
10-05 14:55:03.465	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1393 ProcessRequest() [Anc Hdr]: frameNum 1, i 0, format: 3, width 4656,height 3496,numberofPlanes 2,planeStride 5120,sliceHeight 3584
10-05 14:55:03.465	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:1388 ProcessRequest() Y 18350080,UV 9175040,plane3 0
10-05 14:55:03.461	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.461	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.461	KYOCERA C6930	Info	777	Zygote	Process 25149 exited due to signal 9 (Killed)
10-05 14:55:03.461	KYOCERA C6930	Info	558	lowmemorykiller	3 memory pressure events were skipped after a kill!
10-05 14:55:03.448	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 17556kB at oom_adj 250
10-05 14:55:03.448	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.444	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.android.keychain' (25149), uid 1000, oom_adj 935 to free 17556kB
10-05 14:55:03.439	KYOCERA C6930	Info	14088	ReactNativeJNI	Memory warning (pressure level: TRIM_MEMORY_COMPLETE) received by JS VM, running a GC
10-05 14:55:03.438	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.438	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.436	KYOCERA C6930	Info	24982	Finsky	[2] oyg.onTrimMemory(1): Memory trim requested to level 80
10-05 14:55:03.436	KYOCERA C6930	Info	25100	Finsky:background	[2] oyg.onTrimMemory(1): Memory trim requested to level 80
10-05 14:55:03.431	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 0  <==>  requestId: 1  <==>  sequenceId: 0  <==> CSLSyncId: 1 -- FullHDRMergeYuv_0
10-05 14:55:03.427	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() FullHDRMergeYuv_0 status is now PipelineStatus::STREAM_ON
10-05 14:55:03.427	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:1053 StreamOn() [FullHDRMergeYuv_0] StreamingOn for pipeline: 0xb400006eab294840 with ExposureTimeMs:700 ExposureTimeStreamOn:700 hasFlushOccurred: 0
10-05 14:55:03.427	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() FullHDRMergeYuv_0 status is now PipelineStatus::RESOURCES_ACQUIRED
10-05 14:55:03.427	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() FullHDRMergeYuv_0 status is now PipelineStatus::FINALIZED
10-05 14:55:03.427	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() FullHDRMergeYuv_0 status is now PipelineStatus::PRE_FINALIZED
10-05 14:55:03.425	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.425	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.423	KYOCERA C6930	Info	14725	GoogleInputMethodService	GoogleInputMethodService.onTrimMemory():4476 onTrimMemory(): 15
10-05 14:55:03.421	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() FullHDRMergeYuv_0 status is now PipelineStatus::PRE_FINALIZATION_INPROGRESS
10-05 14:55:03.413	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.412	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.406	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:12223 ActivatePipeline() ActivatePipeline name FullHDRMergeYuv
10-05 14:55:03.403	KYOCERA C6930	Info	14725	AppBase	AppBase.onTrimMemory():765 onTrimMemory(): 15
10-05 14:55:03.402	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.402	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.389	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.388	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.378	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.378	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.366	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.365	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.357	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.357	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.353	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.353	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.342	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.342	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.330	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:SUPERNIGHT_0 InputDependency Buffer not set for GID {0, 0 9}, result:6
10-05 14:55:03.330	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:SUPERNIGHT_0 InputDependency Buffer not set for GID {0, 0 8}, result:6
10-05 14:55:03.330	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:SUPERNIGHT_0 InputDependency Buffer not set for GID {0, 0 7}, result:6
10-05 14:55:03.330	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:SUPERNIGHT_0 InputDependency Buffer not set for GID {0, 0 6}, result:6
10-05 14:55:03.330	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:SUPERNIGHT_0 InputDependency Buffer not set for GID {0, 0 5}, result:6
10-05 14:55:03.330	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:SUPERNIGHT_0 InputDependency Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:03.330	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:SUPERNIGHT_0 InputDependency Buffer not set for GID {0, 0 3}, result:6
10-05 14:55:03.330	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:SUPERNIGHT_0 InputDependency Buffer not set for GID {0, 0 2}, result:6
10-05 14:55:03.330	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:SUPERNIGHT_0 InputDependency Buffer not set for GID {0, 0 1}, result:6
10-05 14:55:03.329	KYOCERA C6930	Info	777	Zygote	Process 13469 exited due to signal 9 (Killed)
10-05 14:55:03.329	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.329	KYOCERA C6930	Info	558	lowmemorykiller	Ignoring pressure since per-zone watermarks ok
10-05 14:55:03.310	KYOCERA C6930	Warning	558	lowmemorykiller	Failed to open /proc/23257/oom_score_adj; errno=2: process 23257 might have been killed
10-05 14:55:03.304	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10151 pid 23145 in 0ms
10-05 14:55:03.299	KYOCERA C6930	Info	1714	ActivityManager	Process com.android.chrome (pid 23145) has died: cch+75 CEM 
10-05 14:55:03.272	KYOCERA C6930	Warning	1714	ActivityManager	Scheduling restart of crashed service com.android.chrome/org.chromium.content.app.SandboxedProcessService0:0 in 1000ms for connection
10-05 14:55:03.264	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 12492kB at oom_adj 200
10-05 14:55:03.264	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.264	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.verizon.messaging.vzmsgs' (13469), uid 10098, oom_adj 945 to free 12492kB
10-05 14:55:03.259	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.257	KYOCERA C6930	Info	777	Zygote	Process 25063 exited due to signal 9 (Killed)
10-05 14:55:03.237	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 9048kB at oom_adj 200
10-05 14:55:03.237	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.237	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.google.process.gapps' (25063), uid 10145, oom_adj 945 to free 9048kB
10-05 14:55:03.233	KYOCERA C6930	Info	777	Zygote	Process 13421 exited due to signal 9 (Killed)
10-05 14:55:03.215	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 90000 pid 23252 in 0ms
10-05 14:55:03.215	KYOCERA C6930	Info	1714	ActivityManager	Process com.android.chrome:sandboxed_process0:org.chromium.content.app.SandboxedProcessService0:0 (pid 23252) has died: cch+85 CEM 
10-05 14:55:03.177	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 20816kB at oom_adj 200
10-05 14:55:03.177	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.177	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.google.android.cellbroadcastreceiver' (13421), uid 10208, oom_adj 955 to free 20816kB
10-05 14:55:03.176	KYOCERA C6930	Info	777	Zygote	Process 24394 exited due to signal 9 (Killed)
10-05 14:55:03.157	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.157	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:03.149	KYOCERA C6930	Debug	1714	ConnectivityService	releasing NetworkRequest [ TRACK_DEFAULT id=1817, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10151 AdministratorUids: [] RequestorUid: 10151 RequestorPackageName: com.android.chrome] ] (release request)
10-05 14:55:03.147	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 29728kB at oom_adj 200
10-05 14:55:03.147	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.147	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.google.android.gm' (24394), uid 10160, oom_adj 955 to free 29728kB
10-05 14:55:03.147	KYOCERA C6930	Error	558	libprocessgroup	set_timerslack_ns write failed: No such process
10-05 14:55:03.146	KYOCERA C6930	Error	558	libprocessgroup	set_timerslack_ns write failed: No such process
10-05 14:55:03.140	KYOCERA C6930	Info	777	Zygote	Process 19044 exited due to signal 9 (Killed)
10-05 14:55:03.139	KYOCERA C6930	Debug	1714	CountryDetector	No listener is left
10-05 14:55:03.111	KYOCERA C6930	Debug	1714	ConnectivityService	releasing NetworkRequest [ TRACK_DEFAULT id=1815, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10151 AdministratorUids: [] RequestorUid: 10151 RequestorPackageName: com.android.chrome] ] (release request)
10-05 14:55:03.109	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 22068kB at oom_adj 100
10-05 14:55:03.109	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.109	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'android.process.acore' (19044), uid 10077, oom_adj 965 to free 22068kB
10-05 14:55:03.104	KYOCERA C6930	Info	777	Zygote	Process 24496 exited due to signal 9 (Killed)
10-05 14:55:03.092	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 8  <==>  requestId: 9  <==>  sequenceId: 8  <==> CSLSyncId: 9 -- ZSLSnapshotYUVHAL_0
10-05 14:55:03.076	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 23996kB at oom_adj 100
10-05 14:55:03.076	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.076	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.google.android.apps.turbo:aab' (24496), uid 10132, oom_adj 965 to free 23996kB
10-05 14:55:03.075	KYOCERA C6930	Error	558	libprocessgroup	set_timerslack_ns write failed: No such process
10-05 14:55:03.071	KYOCERA C6930	Info	778	Zygote	Process 23257 exited due to signal 9 (Killed)
10-05 14:55:03.059	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ TRACK_DEFAULT id=1815, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10151 AdministratorUids: [] RequestorUid: 10151 RequestorPackageName: com.android.chrome] ], android.os.BinderProxy@c71507b)
10-05 14:55:03.059	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ LISTEN id=1816, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED&FOREGROUND Uid: 10151 AdministratorUids: [] RequestorUid: 10151 RequestorPackageName: com.android.chrome] ], android.os.BinderProxy@cf0500a)
10-05 14:55:03.058	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ TRACK_DEFAULT id=1817, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED Uid: 10151 AdministratorUids: [] RequestorUid: 10151 RequestorPackageName: com.android.chrome] ], android.os.BinderProxy@3fa6875)
10-05 14:55:03.058	KYOCERA C6930	Debug	1714	ConnectivityService	ConnectivityService NetworkRequestInfo binderDied(NetworkRequest [ LISTEN id=1818, [ Capabilities: INTERNET&NOT_RESTRICTED&TRUSTED&FOREGROUND Uid: 10151 AdministratorUids: [] RequestorUid: 10151 RequestorPackageName: com.android.chrome] ], android.os.BinderProxy@eb343ac)
10-05 14:55:03.057	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:03.050	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 4272kB at oom_adj 100
10-05 14:55:03.050	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:03.050	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.android.chrome:privileged_process0' (23257), uid 10151, oom_adj 975 to free 4272kB
10-05 14:55:03.045	KYOCERA C6930	Info	778	Zygote	Process 23145 exited due to signal 9 (Killed)
10-05 14:55:03.033	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 7  <==>  requestId: 8  <==>  sequenceId: 7  <==> CSLSyncId: 8 -- ZSLSnapshotYUVHAL_0
10-05 14:55:03.028	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:03.024	KYOCERA C6930	Info	23241	Zygote	Process 23252 exited due to signal 9 (Killed)
10-05 14:55:02.999	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 5036kB at oom_adj 100
10-05 14:55:02.999	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:02.999	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.android.chrome' (23145), uid 10151, oom_adj 975 to free 5036kB
10-05 14:55:02.984	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 6  <==>  requestId: 7  <==>  sequenceId: 6  <==> CSLSyncId: 7 -- ZSLSnapshotYUVHAL_0
10-05 14:55:02.984	KYOCERA C6930	Info	777	Zygote	Process 18992 exited due to signal 9 (Killed)
10-05 14:55:02.980	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.960	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 12384kB at oom_adj 100
10-05 14:55:02.960	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:02.960	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.android.chrome:sandboxed_process0:org.chromium.content.app.SandboxedProcessService0:0' (23252), uid 90000, oom_adj 985 to free 12384kB
10-05 14:55:02.960	KYOCERA C6930	Info	1714	libprocessgroup	Successfully killed process cgroup uid 10132 pid 18992 in 0ms
10-05 14:55:02.959	KYOCERA C6930	Info	1714	ActivityManager	Process com.google.android.apps.turbo (pid 18992) has died: cch+85 CEM 
10-05 14:55:02.956	KYOCERA C6930	Info	558	lowmemorykiller	4 memory pressure events were skipped after a kill!
10-05 14:55:02.954	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.954	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.933	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 5  <==>  requestId: 6  <==>  sequenceId: 5  <==> CSLSyncId: 6 -- ZSLSnapshotYUVHAL_0
10-05 14:55:02.929	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.926	KYOCERA C6930	Info	558	lowmemorykiller	Reclaimed 21172kB at oom_adj 200
10-05 14:55:02.925	KYOCERA C6930	Error	558	lowmemorykiller	Error opening /sys/kernel/debug/tracing/trace_marker; errno=2
10-05 14:55:02.925	KYOCERA C6930	Info	558	lowmemorykiller	Kill 'com.google.android.apps.turbo' (18992), uid 10132, oom_adj 985 to free 21172kB
10-05 14:55:02.912	KYOCERA C6930	Info	929	OV16A10KC	total gain: 1.349999,analogRegisterGain:345, analogRealGain 1.347656,digitalRealGain 1.000000 ,ISPDigitalGain 1.001739
10-05 14:55:02.910	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:468 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.868	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 4  <==>  requestId: 5  <==>  sequenceId: 4  <==> CSLSyncId: 5 -- ZSLSnapshotYUVHAL_0
10-05 14:55:02.865	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.854	KYOCERA C6930	Info	929	OV16A10KC	total gain: 5.399999,analogRegisterGain:1382, analogRealGain 5.398438,digitalRealGain 1.000000 ,ISPDigitalGain 1.000289
10-05 14:55:02.852	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:467 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.826	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 3  <==>  requestId: 4  <==>  sequenceId: 3  <==> CSLSyncId: 4 -- ZSLSnapshotYUVHAL_0
10-05 14:55:02.811	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 467  <==>  requestId: 468  <==>  sequenceId: 467  <==> CSLSyncId: 468 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.808	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.796	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.794	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:466 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.774	KYOCERA C6930	Verbose	30573	CaptureAnimationOverlay	onAnimationEnd [out]
10-05 14:55:02.773	KYOCERA C6930	Verbose	30573	CaptureAnimationOverlay	onAnimationEnd [in]
10-05 14:55:02.769	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 2  <==>  requestId: 3  <==>  sequenceId: 2  <==> CSLSyncId: 3 -- ZSLSnapshotYUVHAL_0
10-05 14:55:02.762	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 466  <==>  requestId: 467  <==>  sequenceId: 466  <==> CSLSyncId: 467 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.760	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.760	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.757	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.746	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.745	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:465 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.732	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 1  <==>  requestId: 2  <==>  sequenceId: 1  <==> CSLSyncId: 2 -- ZSLSnapshotYUVHAL_0
10-05 14:55:02.726	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.725	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 0  <==>  requestId: 1  <==>  sequenceId: 0  <==> CSLSyncId: 1 -- ZSLSnapshotYUVHAL_0
10-05 14:55:02.721	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() ZSLSnapshotYUVHAL_0 status is now PipelineStatus::STREAM_ON
10-05 14:55:02.721	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2437 CSLHwStreamOnKMDHardwares() Stream on Success: setting device to active state hAc: 0xcd010e type: 19, idx: 10 name:CSLHwOPE
10-05 14:55:02.721	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2388 CSLHwStreamOnKMDHardwares() Turning on DevH: 0xcd010e, hAc: 0xcd010e type: 19, idx: 10 name:CSLHwOPE
10-05 14:55:02.721	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2437 CSLHwStreamOnKMDHardwares() Stream on Success: setting device to active state hAc: 0xe8010d type: 19, idx: 10 name:CSLHwOPE
10-05 14:55:02.721	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhwinternal.cpp:2388 CSLHwStreamOnKMDHardwares() Turning on DevH: 0xe8010d, hAc: 0xe8010d type: 19, idx: 10 name:CSLHwOPE
10-05 14:55:02.721	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.cpp:1053 StreamOn() [ZSLSnapshotYUVHAL_0] StreamingOn for pipeline: 0xb400006eab1382d0 with ExposureTimeMs:700 ExposureTimeStreamOn:700 hasFlushOccurred: 0
10-05 14:55:02.721	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() ZSLSnapshotYUVHAL_0 status is now PipelineStatus::RESOURCES_ACQUIRED
10-05 14:55:02.721	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() ZSLSnapshotYUVHAL_0 status is now PipelineStatus::FINALIZED
10-05 14:55:02.716	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() ZSLSnapshotYUVHAL_0 status is now PipelineStatus::PRE_FINALIZED
10-05 14:55:02.713	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhw.cpp:967 CSLAcquireDeviceHW() DeviceAcquired: Name=CSLHwOPE phDevice=13435150 name:/dev/v4l-subdev14 dIndex 10 hIndex 14 sessionName ZSLSnapshotYUVHAL
10-05 14:55:02.700	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CSL    ] camxcslhw.cpp:967 CSLAcquireDeviceHW() DeviceAcquired: Name=CSLHwOPE phDevice=15204621 name:/dev/v4l-subdev14 dIndex 10 hIndex 13 sessionName ZSLSnapshotYUVHAL
10-05 14:55:02.697	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 465  <==>  requestId: 466  <==>  sequenceId: 465  <==> CSLSyncId: 466 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.680	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.678	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:464 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.658	KYOCERA C6930	Info	929	CamX	[CORE_CFG][CORE   ] camxpipeline.h:2985 SetPipelineStatus() ZSLSnapshotYUVHAL_0 status is now PipelineStatus::PRE_FINALIZATION_INPROGRESS
10-05 14:55:02.649	KYOCERA C6930	Info	929	CHIUSECASE	[CORE_CFG ] chifeature2base.cpp:12223 ActivatePipeline() ActivatePipeline name ZSLSnapshotYUVHAL
10-05 14:55:02.647	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 464  <==>  requestId: 465  <==>  sequenceId: 464  <==> CSLSyncId: 465 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.644	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 463  <==>  requestId: 464  <==>  sequenceId: 463  <==> CSLSyncId: 464 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.642	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.641	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.639	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4b9d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.637	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:55:02.637	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.286ms
10-05 14:55:02.632	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.623	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.623	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.623	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.622	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.622	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.622	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.622	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.619	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.618	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:463 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.611	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.611	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.611	KYOCERA C6930	Verbose	30573	CaptureAnimationOverlay	startFlashAnimation [out]
10-05 14:55:02.611	KYOCERA C6930	Verbose	30573	CaptureAnimationOverlay	onAnimationStart [out]
10-05 14:55:02.610	KYOCERA C6930	Verbose	30573	CaptureAnimationOverlay	onAnimationStart [in]
10-05 14:55:02.608	KYOCERA C6930	Verbose	30573	CaptureAnimationOverlay	startFlashAnimation [in]
10-05 14:55:02.604	KYOCERA C6930	Verbose	30573	CaptureModule	onCaptureStarted [out]
10-05 14:55:02.604	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.604	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:02.603	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.603	KYOCERA C6930	Verbose	30573	CaptureModule	onCaptureStarted [in]
10-05 14:55:02.593	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=true
10-05 14:55:02.593	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 462  <==>  requestId: 463  <==>  sequenceId: 462  <==> CSLSyncId: 463 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.590	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.587	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.587	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.586	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead19cf0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.583	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 17 ms
10-05 14:55:02.583	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.717ms
10-05 14:55:02.567	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.567	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.566	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.566	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.566	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.566	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.566	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.565	KYOCERA C6930	Info	1714	system_server	oneway function results will be dropped but finished with status OK and parcel size 4
10-05 14:55:02.565	KYOCERA C6930	Warning	1064	APM::AudioPolicyEngine	getDevicesForStrategy() unknown strategy: -1
10-05 14:55:02.564	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.560	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:462 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.553	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=false
10-05 14:55:02.550	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.550	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.542	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=true
10-05 14:55:02.538	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=false
10-05 14:55:02.528	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.528	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.527	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=true
10-05 14:55:02.526	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=false
10-05 14:55:02.524	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 461  <==>  requestId: 462  <==>  sequenceId: 461  <==> CSLSyncId: 462 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.521	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.517	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead00390, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.514	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:55:02.514	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.486ms
10-05 14:55:02.508	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.505	KYOCERA C6930	Debug	925	audio_hw_primary	out_set_parameters: enter: usecase(1: low-latency-playback) kvpairs: suspend_playback=true
10-05 14:55:02.504	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:461 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.500	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.500	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.499	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.499	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.499	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.499	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.499	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.466	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 460  <==>  requestId: 461  <==>  sequenceId: 460  <==> CSLSyncId: 461 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.465	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.465	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.464	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.461	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb0570, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.459	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:55:02.459	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.058ms
10-05 14:55:02.452	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.447	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:460 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.446	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.446	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.446	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.446	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.446	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.446	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.446	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.445	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 459  <==>  requestId: 460  <==>  sequenceId: 459  <==> CSLSyncId: 460 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.435	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.435	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.434	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.434	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.432	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.432	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.431	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.431	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.430	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.430	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.429	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.429	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.428	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.428	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.428	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.428	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.425	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:459_RTBayer2YUVSNJPEG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.424	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.407	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.407	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.403	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.400	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacc1eb0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.396	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:55:02.396	KYOCERA C6930	Info	929	AncSDK	leave process_image 15.298ms
10-05 14:55:02.387	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] chifeature2graphselector.cpp:4948 GetFeatureHint() set SUPERNIGHT framenum:9
10-05 14:55:02.386	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.385	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:459 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.382	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.382	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.381	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.381	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.381	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.381	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.381	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.370	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:02.364	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxperf.cpp:292 AcquirePerfLock() Failed to acquire perflock type: 2
10-05 14:55:02.363	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxperf.cpp:526 AcquirePerfLock() Acquire perflock failed
10-05 14:55:02.360	KYOCERA C6930	Error	997	ANDR-PERF-MPCTL	Active req limit reached, No optimizations performed
10-05 14:55:02.355	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 459, settings 0xb400006e3ad18c70, num_output_buffers 1
10-05 14:55:02.354	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.354	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.352	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 458  <==>  requestId: 459  <==>  sequenceId: 458  <==> CSLSyncId: 459 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.351	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.351	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.350	KYOCERA C6930	Debug	925	audio_hw_primary	start_output_stream: exit
10-05 14:55:02.350	KYOCERA C6930	Error	925	audio_hw_extn	audio_extn_perf_lock_release: Perf lock release error 
10-05 14:55:02.349	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.347	KYOCERA C6930	Debug	925	msm8974_platform	platform_set_channel_map: set mapping(1 2 0 0 0 0 0 0) for channel:2
10-05 14:55:02.347	KYOCERA C6930	Debug	925	msm8974_platform	platform_set_channel_map mixer_ctl_name:Playback Channel Map9
10-05 14:55:02.345	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde6f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.343	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:55:02.342	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.952ms
10-05 14:55:02.331	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.331	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.331	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.331	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.331	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.331	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.330	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.329	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.326	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:458 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.310	KYOCERA C6930	Debug	925	audio_hw_primary	enable_audio_route: handset->speaker elapsed time:[1665003302]
10-05 14:55:02.307	KYOCERA C6930	Debug	925	audio_route	Apply path: low-latency-playback speaker
10-05 14:55:02.307	KYOCERA C6930	Debug	925	audio_hw_primary	enable_audio_route: apply mixer and update path: low-latency-playback speaker
10-05 14:55:02.307	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_AVSYNC_INFO: ACDB_CMD_GET_DEVICE_PROPERTY
10-05 14:55:02.307	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> send_hw_delay : acdb_id = 14 path = 0
10-05 14:55:02.307	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> AUDIO_SET_AFE_CAL cal_type[16] acdb_id[14]
10-05 14:55:02.307	KYOCERA C6930	Debug	925	ACDB-LOADER	Error: ACDB AFE returned = -19
10-05 14:55:02.307	KYOCERA C6930	Debug	925	android.hardware.audio.service	Failed to fetch the lookup information of the device 0000000E 
10-05 14:55:02.307	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AFE_INSTANCE_COMMON_TABLE
10-05 14:55:02.307	KYOCERA C6930	Debug	925	ACDB-LOADER	Error: ACDB_CMD_GET_AFE_INSTANCE_COMMON_TABLE_SIZE Returned = -19
10-05 14:55:02.307	KYOCERA C6930	Debug	925	android.hardware.audio.service	Failed to fetch the lookup information of the device 0000000E 
10-05 14:55:02.307	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AFE_INSTANCE_COMMON_TABLE_SIZE
10-05 14:55:02.307	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> send_afe_cal
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> GET_AFE_TOPOLOGY_ID for adcd_id 14, Topology Id 112fc
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AFE_TOPOLOGY_ID
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> send_afe_topology
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> audstrm_cal->cal_type.cal_data.cal_size = 20
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AUDPROC_INSTANCE_STREAM_TABLE
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> send_audstrmtable
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AUDPROC_INSTANCE_STREAM_TABLE_SIZE
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> AUDIO_SET_VOL_CAL cal type = 12
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AUDPROC_INSTANCE_GAIN_DEP_STEP_TABLE, vol index 0
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AUDPROC_INSTANCE_GAIN_DEP_STEP_TABLE_SIZE
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> send_audvoltable
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> AUDIO_SET_AUDPROC_CAL cal_type[11] acdb_id[14] app_type[69937]
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AUDPROC_INSTANCE_COMMON_TABLE
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AUDPROC_INSTANCE_COMMON_TABLE_SIZE
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> send_audtable
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AUDPROC_COMMON_TOPOLOGY_ID
10-05 14:55:02.306	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> send_adm_topology
10-05 14:55:02.303	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> ACDB_CMD_GET_AUDPROC_STREAM_TOPOLOGY_ID
10-05 14:55:02.303	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> send_asm_topology
10-05 14:55:02.303	KYOCERA C6930	Debug	925	ACDB-LOADER	ACDB -> send_audio_cal, acdb_id = 14, path = 0, app id = 0x11131, sample rate = 48000, use_case = 0,buffer_idx_w_path =0, afe_sample_rate = 48000, cal_mode = 1, offset_index = 0
10-05 14:55:02.297	KYOCERA C6930	Info	925	audio_hw_utils	send_app_type_cfg_for_device PLAYBACK app_type 69937, acdb_dev_id 14, sample_rate 48000, snd_device_be_idx 43
10-05 14:55:02.297	KYOCERA C6930	Debug	925	audio_hw_utils	audio_extn_utils_send_app_type_cfg: usecase->out_snd_device speaker
10-05 14:55:02.297	KYOCERA C6930	Debug	925	soundtrigger	audio_extn_sound_trigger_update_stream_status: uc_info->id 1 of type 0 for Event 3, with Raise=0
10-05 14:55:02.293	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
 kcjprop:ON in:0 mode:0
10-05 14:55:02.293	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.286	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 457  <==>  requestId: 458  <==>  sequenceId: 457  <==> CSLSyncId: 458 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.283	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.280	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd7990, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.277	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 10 ms
10-05 14:55:02.277	KYOCERA C6930	Info	929	AncSDK	leave process_image 10.734ms
10-05 14:55:02.271	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.267	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:457 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.267	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.267	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.267	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.267	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.267	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.267	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.267	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.261	KYOCERA C6930	Verbose	30573	CaptureModule	startCapture [out]
10-05 14:55:02.261	KYOCERA C6930	Verbose	30573	CaptureModule	captureStillPicture [out]
10-05 14:55:02.261	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.261	KYOCERA C6930	Error	30573	[kyocera_camera]ImageCorrectionModule	getLastDRCheckerResult result = 0000
10-05 14:55:02.260	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.260	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:02.260	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.260	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:02.260	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.260	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.260	KYOCERA C6930	Verbose	30573	CaptureModule	isFrontFacing : false
10-05 14:55:02.259	KYOCERA C6930	Verbose	30573	MainActivity	getCameraDisplayOrientation [out] : 0
10-05 14:55:02.259	KYOCERA C6930	Verbose	30573	MainActivity	getCameraDisplayOrientation [in]
10-05 14:55:02.259	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.259	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.259	KYOCERA C6930	Verbose	30573	CaptureModule	[AE_REGIONS] setBuilderCommonStillPicture: mr= (x:8, y:8, w:4655, h:3495, wt:0)
10-05 14:55:02.254	KYOCERA C6930	Debug	925	audio_route	Apply path: speaker
10-05 14:55:02.253	KYOCERA C6930	Info	925	soundtrigger	audio_extn_sound_trigger_update_device_status: device 0x2 of type 0 for Event 1, with Raise=0
10-05 14:55:02.253	KYOCERA C6930	Debug	925	msm8974_platform	platform_get_island_cfg_on_device:island cfg status on snd_device = (speaker 0)
10-05 14:55:02.253	KYOCERA C6930	Debug	925	audio_hw_primary	enable_snd_device: snd_device(2: speaker)
10-05 14:55:02.252	KYOCERA C6930	Debug	925	hardware_info	hw_info_append_hw_type : device_name = speaker
10-05 14:55:02.252	KYOCERA C6930	Debug	925	audio_hw_primary	check_usecases_codec_backend:becf: check_usecases num.of Usecases to switch 0
10-05 14:55:02.252	KYOCERA C6930	Debug	925	audio_hw_primary	check_usecases_codec_backend:becf: (85) check_usecases curr device: speaker, usecase device: backends match 0
10-05 14:55:02.252	KYOCERA C6930	Debug	925	audio_hw_primary	check_usecases_codec_backend:becf: force routing 0
10-05 14:55:02.252	KYOCERA C6930	Info	925	msm8974_platform	platform_check_codec_backend_cfg:becf: afe: Codec selected backend: 0 updated bit width: 16 and sample rate: 48000
10-05 14:55:02.252	KYOCERA C6930	Debug	925	msm8974_platform	platform_check_codec_backend_cfg:becf: updated afe: bitwidth 16, samplerate 48000 channels 2,backend_idx 0 usecase = 1 device (speaker)
10-05 14:55:02.250	KYOCERA C6930	Debug	30573	log	DIGITALZOOM =1.0
10-05 14:55:02.246	KYOCERA C6930	Verbose	30573	CaptureModule	ZoomCrop [out] : 0
10-05 14:55:02.245	KYOCERA C6930	Info	925	msm8974_platform	platform_check_codec_backend_cfg:becf: afe: bitwidth 16, samplerate 48000 channels 2, backend_idx 0 usecase = 1 device (speaker)
10-05 14:55:02.245	KYOCERA C6930	Info	925	msm8974_platform	platform_check_and_set_codec_backend_cfg: new_snd_devices[0] is 2
10-05 14:55:02.245	KYOCERA C6930	Info	925	msm8974_platform	platform_check_and_set_codec_backend_cfg:becf: afe: bitwidth 16, samplerate 48000 channels 2, backend_idx 0 usecase = 1 device (speaker)
10-05 14:55:02.245	KYOCERA C6930	Debug	925	audio_hw_primary	select_devices: covert mode off : covert_mode=0 out_device=0x2
10-05 14:55:02.245	KYOCERA C6930	Verbose	925	kaudio_path	platform_get_snd_device: snd_device=2
10-05 14:55:02.245	KYOCERA C6930	Debug	925	kaudio_path	kaudio_get_snd_device: get_kind=0 tbl_num=1 snd_device=2
10-05 14:55:02.245	KYOCERA C6930	Debug	925	kaudio_path	kaudio_get_snd_device: mode(0) in_device(0) out_device(0x2) bt_wb(0) bt_nrec(1) freq_mode(0) hac_mode(0) ptt_mode(0) anr_mode(1) nb_mode(0) uplink_mode(0) gunshot_mode(0) wind_suppress(0) stereo_mic(0) stereo_mic_reverse(0) voice_recogniton(0) lpi_mode(0) rxvoice_mute_enabled(0) rxvoice_mute2_enabled(0)
10-05 14:55:02.245	KYOCERA C6930	Debug	925	kaudio_path	kaudio_get_snd_device: enter: get_kind(0) devices(0x2) source(0)
10-05 14:55:02.245	KYOCERA C6930	Verbose	925	kaudio_path	platform_get_snd_device: enter: get_kind(0) devices(0x2)
10-05 14:55:02.243	KYOCERA C6930	Debug	925	audio_hw_primary	select_devices for use case (low-latency-playback)
10-05 14:55:02.243	KYOCERA C6930	Error	925	audio_hw_extn	audio_extn_perf_lock_acquire: Failed to acquire perf lock, err: -1
10-05 14:55:02.243	KYOCERA C6930	Error	997	ANDR-PERF-MPCTL	Active req limit reached, No optimizations performed
10-05 14:55:02.238	KYOCERA C6930	Verbose	30573	VendorTagUtil	setKyoceraMasamuneStart : 0
10-05 14:55:02.238	KYOCERA C6930	Verbose	30573	VendorTagUtil	setKyoceraCameraStart : 1
10-05 14:55:02.238	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.238	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.238	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : stabilization = 1
10-05 14:55:02.238	KYOCERA C6930	Debug	30573	MakerNote	whitebalance = F00300030000000100000001
10-05 14:55:02.237	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:02.237	KYOCERA C6930	Verbose	30573	CaptureModule	isWideMode : true
10-05 14:55:02.237	KYOCERA C6930	Verbose	30573	CaptureModule	isFrontFacing : false
10-05 14:55:02.237	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.237	KYOCERA C6930	Verbose	30573	CaptureModule	requestControlAEMode [out]
10-05 14:55:02.237	KYOCERA C6930	Verbose	30573	CaptureModule	isWideMode : true
10-05 14:55:02.237	KYOCERA C6930	Verbose	30573	CaptureModule	isFrontFacing : false
10-05 14:55:02.237	KYOCERA C6930	Verbose	30573	CaptureModule	requestControlAEMode [in]
10-05 14:55:02.237	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.236	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.236	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.232	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.232	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.228	KYOCERA C6930	Debug	925	audio_hw_primary	start_output_stream: enter: stream(0xe77c21a0)usecase(1: low-latency-playback) devices(0x2) is_haptic_usecase(0)
10-05 14:55:02.226	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 456  <==>  requestId: 457  <==>  sequenceId: 456  <==> CSLSyncId: 457 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.225	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:458_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.225	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.225	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:02.224	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 458, settings 0x0, num_output_buffers 1
10-05 14:55:02.221	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3ad10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.218	KYOCERA C6930	Info	1714	system_server	oneway function results will be dropped but finished with status OK and parcel size 4
10-05 14:55:02.218	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:55:02.218	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.283ms
10-05 14:55:02.217	KYOCERA C6930	Info	1714	system_server	oneway function results will be dropped but finished with status OK and parcel size 4
10-05 14:55:02.212	KYOCERA C6930	Verbose	30573	CaptureModule	playMediaActionSound [out]
10-05 14:55:02.212	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.210	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:456 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.205	KYOCERA C6930	Debug	30573	AudioTrack	createTrack_l(8): AUDIO_OUTPUT_FLAG_FAST denied by server; frameCount 0 -> 6592
10-05 14:55:02.204	KYOCERA C6930	Debug	925	compress_voip	compress_voip_out_get_parameters: enter
10-05 14:55:02.202	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.202	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.201	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.201	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.201	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.201	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.201	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.182	KYOCERA C6930	Debug	1064	AF::TrackHandle	OpPlayAudio: track:190 usage:13 not muted
10-05 14:55:02.177	KYOCERA C6930	Info	1064	AudioPolicyManagerCustom	VR mode is 0, switch to primary output if request is for fast|raw
10-05 14:55:02.174	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.174	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.172	KYOCERA C6930	Info	1064	hash_map_utils	key: 'vr_audio_mode_on' value: ''
10-05 14:55:02.165	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 455  <==>  requestId: 456  <==>  sequenceId: 455  <==> CSLSyncId: 456 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.164	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:457_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.164	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.164	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:02.164	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 457, settings 0x0, num_output_buffers 1
10-05 14:55:02.163	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.162	KYOCERA C6930	Debug	925	audio_hw_primary	adev_get_parameters:vr_audio_mode_on
10-05 14:55:02.160	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3e550, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.158	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:55:02.158	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.917ms
10-05 14:55:02.153	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.151	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:455 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.146	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.146	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.146	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.146	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.145	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.145	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.145	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.145	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.145	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.131	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.116	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.116	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.110	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 454  <==>  requestId: 455  <==>  sequenceId: 454  <==> CSLSyncId: 455 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.109	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 4
10-05 14:55:02.107	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:456_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.107	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.107	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:02.106	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 456, settings 0x0, num_output_buffers 1
10-05 14:55:02.103	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb9210, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.100	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:55:02.100	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.658ms
10-05 14:55:02.097	KYOCERA C6930	Verbose	30573	CaptureModule	isShutterSoundEnabled:shutter_sound 1-->1
10-05 14:55:02.097	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : shutter_sound = 1
10-05 14:55:02.097	KYOCERA C6930	Verbose	30573	CaptureModule	playMediaActionSound [in] : 0
10-05 14:55:02.097	KYOCERA C6930	Verbose	30573	CaptureModule	captureStillPicture [in]
10-05 14:55:02.097	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.097	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.097	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:02.097	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.096	KYOCERA C6930	Verbose	30573	StorageManager	clearOriginalExif [out]
10-05 14:55:02.096	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.094	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.094	KYOCERA C6930	Debug	30573	CameraSettingMenu	updateModeListView : showSelectModeOnly = true,  isOtherLaunchMode = true
10-05 14:55:02.094	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.094	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.094	KYOCERA C6930	Verbose	30573	MainActivity	isSomeVideoShooting : ret = false
10-05 14:55:02.094	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.094	KYOCERA C6930	Verbose	30573	MainActivity	disableShutter [in]
10-05 14:55:02.094	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.094	KYOCERA C6930	Verbose	30573	FocusView	disappear: false
10-05 14:55:02.093	KYOCERA C6930	Verbose	30573	StorageManager	clearOriginalExif [in]
10-05 14:55:02.093	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:454 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.093	KYOCERA C6930	Verbose	30573	StorageManager	clearOriginalImage [out]
10-05 14:55:02.093	KYOCERA C6930	Verbose	30573	StorageManager	clearOriginalImage [in]
10-05 14:55:02.093	KYOCERA C6930	Verbose	30573	CaptureModule	startCapture [in]
10-05 14:55:02.093	KYOCERA C6930	Verbose	30573	CaptureModule	isFrontFacing : false
10-05 14:55:02.092	KYOCERA C6930	Verbose	30573	MainActivity	isSomeVideoShooting : ret = false
10-05 14:55:02.092	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.092	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.092	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:02.091	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.087	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.087	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.087	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.086	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.086	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.086	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.086	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	onClick [out]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	onClickShutter [out]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	clickShutter [out]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	CaptureModule	takePicture [out]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 4656x3496
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeHeight [out]: 3496
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeHeight [in]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeWidth [out]: 4656
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeWidth [in]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 4656x3496
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeHeight [out]: 3496
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeHeight [in]
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeWidth [out]: 4656
10-05 14:55:02.085	KYOCERA C6930	Verbose	30573	SizeDataManager	getCaptureSizeWidth [in]
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.084	KYOCERA C6930	Verbose	30573	CaptureModule	isFrontFacing : false
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	isSomeVideoShooting : ret = false
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	CaptureModule	takePicture [in]
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	StatusManager	getGpsLocation[out] : null
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	StatusManager	getGpsLocation[in]
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getGpsLocation [out]
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getGpsLocation [in]
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	clickShutter [in]
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	setIsClickShutterDone: true
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	getOrientation [out] : mOrientation
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	MainActivity	getOrientation [in]
10-05 14:55:02.083	KYOCERA C6930	Verbose	30573	SelfTimer	isSelfTimerMode [out] false
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	SelfTimer	readPreference [out] : return 0
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	SelfTimer	readPreference [in] : key=shooting_mode, defaultValue=0
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	SelfTimer	isSelfTimerMode [in]
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	StatusManager	getGpsLocation[out] : null
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	StatusManager	getGpsLocation[in]
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getGpsLocation [out]
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getGpsLocation [in]
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	FocusView	disappear: false
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	ZoomController	appear [out]
10-05 14:55:02.082	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	MainActivity	isVideo1080p60fps : ret = false
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	ZoomController	appear [in]
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	MainActivity	isLackStorageSpace [out] isLack=false
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	MainActivity	updateShutterAndRecordButton [out]
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	MainActivity	isSomeVideoShooting : ret = false
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	MainActivity	updateShutterAndRecordButton [in]
10-05 14:55:02.080	KYOCERA C6930	Verbose	30573	StorageAccessor	getAvailableStorageSize()[out]
 space =3.13062E7
10-05 14:55:02.080	KYOCERA C6930	Debug	30573	StorageAccessor	available Storage size = 3.13062E7
10-05 14:55:02.077	KYOCERA C6930	Verbose	30573	StorageAccessor	getStorageDirectory [out] storage directory:/storage/emulated/0
10-05 14:55:02.074	KYOCERA C6930	Verbose	30573	StorageAccessor	getStorageDirectory [in] mode:0
10-05 14:55:02.074	KYOCERA C6930	Verbose	30573	StorageAccessor	isStorageAvailable()[out]
10-05 14:55:02.074	KYOCERA C6930	Verbose	30573	StorageAccessor	getStorageState [out] storage status:mounted
10-05 14:55:02.056	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.056	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:02.053	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 453  <==>  requestId: 454  <==>  sequenceId: 453  <==> CSLSyncId: 454 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.053	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:455_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.053	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.052	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:02.052	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 455, settings 0x0, num_output_buffers 1
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.051	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.051	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:02.050	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:02.050	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:02.046	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead2a370, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:02.044	KYOCERA C6930	Verbose	30573	StorageAccessor	getStorageState [in] mode:0
10-05 14:55:02.044	KYOCERA C6930	Verbose	30573	StorageAccessor	isStorageAvailable()[in]
10-05 14:55:02.044	KYOCERA C6930	Verbose	30573	StorageAccessor	getAvailableStorageSize()[in] mode=0
10-05 14:55:02.044	KYOCERA C6930	Verbose	30573	MainActivity	isLackStorageSpace [in] takeMode=0
10-05 14:55:02.044	KYOCERA C6930	Verbose	30573	MainActivity	onClickShutter [in]
10-05 14:55:02.044	KYOCERA C6930	Verbose	30573	MainActivity	isSomeVideoShooting : ret = false
10-05 14:55:02.044	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.044	KYOCERA C6930	Verbose	30573	MainActivity	onClick [in] : jp.kyocera.camera.RotateImageView{3f8a22d VFED..CL. ..SP.... 427,0-652,225 #7f0901d9 app:id/shutter_button}
10-05 14:55:02.044	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:55:02.044	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.763ms
10-05 14:55:02.043	KYOCERA C6930	Verbose	30573	MainActivity	dispatchTouchEvent [out]
10-05 14:55:02.043	KYOCERA C6930	Verbose	30573	MainActivity	isThumbnailProgressing : ret = false
10-05 14:55:02.043	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.043	KYOCERA C6930	Verbose	30573	MainActivity	dispatchTouchEvent [ACTION_UP]
10-05 14:55:02.043	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.042	KYOCERA C6930	Verbose	30573	ExposureSeekBar	isOpen
10-05 14:55:02.042	KYOCERA C6930	Verbose	30573	ExposureSeekBar	isTrackingTouch : ret = false
10-05 14:55:02.042	KYOCERA C6930	Verbose	30573	ZoomController	isView [in] : false
10-05 14:55:02.042	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOtherMenuShow [out] : false
10-05 14:55:02.042	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOtherMenuShow [in]
10-05 14:55:02.042	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.042	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOtherMenuShow [out] : false
10-05 14:55:02.042	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOtherMenuShow [in]
10-05 14:55:02.042	KYOCERA C6930	Verbose	30573	MainActivity	dispatchTouchEvent [in]
10-05 14:55:02.037	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:02.035	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:453 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:02.032	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:02.032	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:02.031	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:02.031	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:02.031	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:02.031	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:02.031	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.014	KYOCERA C6930	Verbose	30573	MainActivity	dispatchTouchEvent [out]
10-05 14:55:02.014	KYOCERA C6930	Verbose	30573	MainActivity	dispatchTouchEvent[ACTION_DOWN] false
10-05 14:55:02.014	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.013	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.008	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:02.007	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isManualList [out]
10-05 14:55:02.007	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isManualList [in]
10-05 14:55:02.007	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOpenTimelapseList [out] : ret = false
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	ExposureSeekBar	isOpen
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	ExposureSeekBar	isTrackingTouch : ret = false
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	ZoomController	isView [in] : false
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOtherMenuShow [out] : false
10-05 14:55:02.006	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOtherMenuShow [in]
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:02.006	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:02.005	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.005	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 452  <==>  requestId: 453  <==>  sequenceId: 452  <==> CSLSyncId: 453 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:02.005	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:02.005	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.005	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.005	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:02.005	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.005	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:02.005	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:02.004	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOtherMenuShow [out] : false
10-05 14:55:02.004	KYOCERA C6930	Verbose	30573	CameraSettingMenu	isOtherMenuShow [in]
10-05 14:55:02.003	KYOCERA C6930	Verbose	30573	MainActivity	dispatchTouchEvent [in]
10-05 14:55:02.003	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:02.003	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:02.003	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:454_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:02.003	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:02.003	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:02.003	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:02.003	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:02.003	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:02.002	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:02.002	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 454, settings 0x0, num_output_buffers 1
10-05 14:55:02.001	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:02.001	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.998	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde3d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.993	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 18 ms
10-05 14:55:01.993	KYOCERA C6930	Info	929	AncSDK	leave process_image 18.130ms
10-05 14:55:01.978	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.976	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:452 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.975	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.975	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.974	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.974	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.974	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.974	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.974	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.951	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 451  <==>  requestId: 452  <==>  sequenceId: 451  <==> CSLSyncId: 452 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.950	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:453_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.950	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.949	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.949	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 453, settings 0x0, num_output_buffers 1
10-05 14:55:01.944	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.944	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.943	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.943	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.942	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.942	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.942	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.942	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.939	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacbab10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.936	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:55:01.936	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.926ms
10-05 14:55:01.924	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.924	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.924	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.923	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.923	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.923	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.923	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.920	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.918	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:451 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.915	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 450  <==>  requestId: 451  <==>  sequenceId: 450  <==> CSLSyncId: 451 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.902	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.902	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.902	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.902	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.901	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.901	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:452_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.901	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.901	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.900	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.900	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.900	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.900	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.900	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.900	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.900	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.900	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.900	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.900	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 452, settings 0x0, num_output_buffers 1
10-05 14:55:01.900	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.896	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deace0630, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.893	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 27 ms
10-05 14:55:01.893	KYOCERA C6930	Info	929	AncSDK	leave process_image 27.202ms
10-05 14:55:01.884	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.884	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.868	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.866	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.866	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.866	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.866	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:450 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.866	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.866	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.866	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.866	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.862	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 449  <==>  requestId: 450  <==>  sequenceId: 449  <==> CSLSyncId: 450 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.843	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:451_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.843	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.843	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.843	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.842	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.842	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.842	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.842	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.842	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.842	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.842	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.842	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.842	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 451, settings 0x0, num_output_buffers 1
10-05 14:55:01.842	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.842	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.842	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.839	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4df50, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.835	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 20 ms
10-05 14:55:01.835	KYOCERA C6930	Info	929	AncSDK	leave process_image 20.562ms
10-05 14:55:01.833	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.833	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.823	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.821	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:449 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.815	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.815	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.815	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.814	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.814	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.814	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.814	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.814	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 448  <==>  requestId: 449  <==>  sequenceId: 448  <==> CSLSyncId: 449 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.786	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:450_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.786	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.785	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.785	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 450, settings 0x0, num_output_buffers 1
10-05 14:55:01.785	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.784	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.784	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.783	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.783	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.783	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.778	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd82f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.774	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 23 ms
10-05 14:55:01.774	KYOCERA C6930	Info	929	AncSDK	leave process_image 23.101ms
10-05 14:55:01.767	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.767	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.751	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.751	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.751	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.751	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.751	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.751	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.750	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.747	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.744	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.744	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.744	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:448 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.713	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.713	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.699	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 447  <==>  requestId: 448  <==>  sequenceId: 447  <==> CSLSyncId: 448 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.699	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.698	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.698	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:449_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.698	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.698	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.698	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.698	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.697	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 449, settings 0x0, num_output_buffers 1
10-05 14:55:01.697	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.694	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4b9d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.691	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:55:01.691	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.962ms
10-05 14:55:01.686	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.684	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:447 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.678	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.678	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.677	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.677	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.677	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.677	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.677	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.654	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 446  <==>  requestId: 447  <==>  sequenceId: 446  <==> CSLSyncId: 447 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.653	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:448_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.653	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.653	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.652	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.652	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.652	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 448, settings 0x0, num_output_buffers 1
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.652	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.651	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.651	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.651	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.649	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.649	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.648	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead19cf0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.645	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 18 ms
10-05 14:55:01.645	KYOCERA C6930	Info	929	AncSDK	leave process_image 18.131ms
10-05 14:55:01.631	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.630	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.628	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.628	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.627	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.627	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.627	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.627	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.627	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.627	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:446 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.592	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.592	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.585	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 445  <==>  requestId: 446  <==>  sequenceId: 445  <==> CSLSyncId: 446 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.584	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:447_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.584	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.584	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.583	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.583	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.583	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 447, settings 0x0, num_output_buffers 1
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.583	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.583	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.582	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.579	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead00390, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.576	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:55:01.576	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.990ms
10-05 14:55:01.570	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.568	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:445 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.564	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.564	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.563	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.563	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.563	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.563	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.563	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.541	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 444  <==>  requestId: 445  <==>  sequenceId: 444  <==> CSLSyncId: 445 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.540	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.540	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.537	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:446_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.537	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.537	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.537	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.536	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.536	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 446, settings 0x0, num_output_buffers 1
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.536	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.535	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.535	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.535	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.532	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.532	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.532	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb0570, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.529	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:55:01.528	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.901ms
10-05 14:55:01.515	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.515	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.515	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.515	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.515	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.515	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.514	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.513	KYOCERA C6930	Debug	5007	FavoriteWidget	3x3 onReceive android.intent.action.BATTERY_CHANGED
10-05 14:55:01.512	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.510	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:444 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.505	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 443  <==>  requestId: 444  <==>  sequenceId: 443  <==> CSLSyncId: 444 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.496	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:445_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.496	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.496	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.496	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 445, settings 0x0, num_output_buffers 1
10-05 14:55:01.495	KYOCERA C6930	Debug	5007	FavoriteWidgetLightService	call isLighting()
10-05 14:55:01.495	KYOCERA C6930	Debug	5007	FavoriteWidgetLightService	call isLighting()
10-05 14:55:01.495	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.495	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.494	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.493	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.493	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.493	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.490	KYOCERA C6930	Debug	5007	U	isRestrictVolume() ret : false
10-05 14:55:01.489	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacc1eb0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.485	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 21 ms
10-05 14:55:01.485	KYOCERA C6930	Info	929	AncSDK	leave process_image 21.251ms
10-05 14:55:01.483	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.482	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.468	KYOCERA C6930	Debug	7115	DeviceStatisticsService	chargerType=2 batteryLevel=100 totalBatteryCapacity=3450000
10-05 14:55:01.467	KYOCERA C6930	Verbose	30573	StatusManager	onReceive [out]
10-05 14:55:01.467	KYOCERA C6930	Verbose	30573	StatusManager	Intent BATTERY_CHANGED
10-05 14:55:01.467	KYOCERA C6930	Verbose	30573	StatusManager	Intent Action : android.intent.action.BATTERY_CHANGED
10-05 14:55:01.467	KYOCERA C6930	Verbose	30573	StatusManager	onReceive [in]
10-05 14:55:01.465	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.465	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.464	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.464	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.464	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.464	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.464	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.463	KYOCERA C6930	Debug	5007	FavoriteWidgetBase	FavoriteWidget3x3 onReceiveParallel: action=android.intent.action.BATTERY_CHANGED
10-05 14:55:01.454	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.451	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:443 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.422	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.422	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.417	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 442  <==>  requestId: 443  <==>  sequenceId: 442  <==> CSLSyncId: 443 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.417	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.416	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.416	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:444_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.416	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.416	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.415	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.415	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.415	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.415	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.415	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 444, settings 0x0, num_output_buffers 1
10-05 14:55:01.411	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde6f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.406	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:55:01.406	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.515ms
10-05 14:55:01.395	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.392	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:442 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.390	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.390	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.389	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.389	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.389	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.389	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.389	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.358	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.357	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.357	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 441  <==>  requestId: 442  <==>  sequenceId: 441  <==> CSLSyncId: 442 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.355	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.355	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.355	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.355	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.355	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.355	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.355	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.354	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.354	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:443_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.354	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.354	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.354	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.353	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.353	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.353	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 443, settings 0x0, num_output_buffers 1
10-05 14:55:01.350	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd7990, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.347	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:55:01.347	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.690ms
10-05 14:55:01.340	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.340	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.338	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.335	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.335	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.335	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.335	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.335	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.335	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.335	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.334	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:441 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.306	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 440  <==>  requestId: 441  <==>  sequenceId: 440  <==> CSLSyncId: 441 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.306	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.305	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.305	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:442_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.305	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.305	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.304	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.304	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.304	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.304	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.304	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.304	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.304	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.304	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.304	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.304	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.304	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 442, settings 0x0, num_output_buffers 1
10-05 14:55:01.304	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.302	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.302	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.300	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3ad10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.297	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:55:01.297	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.681ms
10-05 14:55:01.283	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.283	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.283	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.283	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.282	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.282	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.282	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.279	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.276	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:440 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.246	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.246	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.244	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 439  <==>  requestId: 440  <==>  sequenceId: 439  <==> CSLSyncId: 440 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.243	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:441_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.243	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.243	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.242	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.242	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.242	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.242	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.242	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.242	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.242	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.242	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.242	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.242	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.242	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.242	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 441, settings 0x0, num_output_buffers 1
10-05 14:55:01.237	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3e550, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.232	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:55:01.232	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.128ms
10-05 14:55:01.221	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.219	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.219	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.218	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.218	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.218	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.218	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.218	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:439 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.218	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.197	KYOCERA C6930	Debug	970	KcWifi	[KcWifi] waitForEvent: waitForEvent fb[6]
10-05 14:55:01.196	KYOCERA C6930	Debug	2751	KcWifiSocketManager	waitForEvent failed: -1
10-05 14:55:01.196	KYOCERA C6930	Error	970	KcWifi	[KcWifi] waitForEvent: recv timeout
10-05 14:55:01.196	KYOCERA C6930	Error	970	KcWifi	[KcWifi] waitForEvent: recv failed
10-05 14:55:01.183	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.183	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.179	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 438  <==>  requestId: 439  <==>  sequenceId: 438  <==> CSLSyncId: 439 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.179	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:440_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.179	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.179	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.179	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.179	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.179	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.179	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.179	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.179	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.179	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.179	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.178	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.178	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.178	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 440, settings 0x0, num_output_buffers 1
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.178	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.177	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.177	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.174	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb9210, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.171	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:55:01.171	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.652ms
10-05 14:55:01.164	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.159	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.159	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.159	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:438 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.159	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.159	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.159	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.159	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.158	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.138	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.138	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.131	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.124	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.124	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.123	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 437  <==>  requestId: 438  <==>  sequenceId: 437  <==> CSLSyncId: 438 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.123	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.122	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.122	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:439_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.122	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.122	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.121	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.121	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.121	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.121	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.121	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 439, settings 0x0, num_output_buffers 1
10-05 14:55:01.117	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead2a370, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.113	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:55:01.113	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.227ms
10-05 14:55:01.105	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.101	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.101	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.101	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.101	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.101	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.101	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.101	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:437 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.101	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.067	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.067	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.067	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.067	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.067	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.067	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.067	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.067	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.067	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.067	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.066	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.066	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.065	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.065	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.065	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.063	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:438_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.063	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.063	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 436  <==>  requestId: 437  <==>  sequenceId: 436  <==> CSLSyncId: 437 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.062	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.062	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 438, settings 0x0, num_output_buffers 1
10-05 14:55:01.057	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde3d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:01.054	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:55:01.054	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.930ms
10-05 14:55:01.046	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:01.043	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:436 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:01.041	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:01.041	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:01.040	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:01.040	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:01.040	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:01.040	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:01.040	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.008	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 435  <==>  requestId: 436  <==>  sequenceId: 435  <==> CSLSyncId: 436 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:01.007	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:01.007	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:01.005	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:437_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:01.005	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:01.005	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:01.005	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:01.005	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:01.005	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.005	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.005	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:01.004	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.004	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 437, settings 0x0, num_output_buffers 1
10-05 14:55:01.004	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.004	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:01.003	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:01.003	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:01.003	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:01.003	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:01.003	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:01.003	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:01.003	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:01.000	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacbab10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.997	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:55:00.997	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.954ms
10-05 14:55:00.986	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.986	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.986	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.985	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.985	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.985	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.985	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.985	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.984	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:435 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.955	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 434  <==>  requestId: 435  <==>  sequenceId: 434  <==> CSLSyncId: 435 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.953	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.953	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.953	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.953	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.953	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.953	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.953	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.953	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.953	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.952	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.952	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:436_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.952	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.952	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.951	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.951	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.951	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.951	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.951	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 436, settings 0x0, num_output_buffers 1
10-05 14:55:00.950	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.950	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.948	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deace0630, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.944	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:55:00.944	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.640ms
10-05 14:55:00.936	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.936	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.930	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.928	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.928	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.928	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.927	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.927	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.927	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.927	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.926	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:434 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.892	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.892	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.883	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 433  <==>  requestId: 434  <==>  sequenceId: 433  <==> CSLSyncId: 434 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.882	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.882	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:435_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.882	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.882	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.881	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.881	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.881	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 435, settings 0x0, num_output_buffers 1
10-05 14:55:00.881	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.877	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4df50, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.874	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:55:00.874	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.653ms
10-05 14:55:00.869	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.867	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:433 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.861	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.861	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.861	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.860	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.860	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.860	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.860	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.832	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.832	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.832	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 432  <==>  requestId: 433  <==>  sequenceId: 432  <==> CSLSyncId: 433 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.831	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:434_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.831	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.830	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.830	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 434, settings 0x0, num_output_buffers 1
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.830	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.829	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.829	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.829	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.826	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd82f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.823	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 11 ms
10-05 14:55:00.823	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.391ms
10-05 14:55:00.812	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.812	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.812	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.812	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.812	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.812	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.812	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.812	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.810	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:432 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.778	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.778	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.777	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.777	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.776	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.776	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 431  <==>  requestId: 432  <==>  sequenceId: 431  <==> CSLSyncId: 432 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.776	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.775	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:433_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.775	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.774	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.774	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 433, settings 0x0, num_output_buffers 1
10-05 14:55:00.769	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4b9d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.765	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:55:00.765	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.451ms
10-05 14:55:00.755	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.751	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:431 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.749	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.749	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.748	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.748	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.748	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.748	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.748	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.732	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.732	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.717	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.717	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.711	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 430  <==>  requestId: 431  <==>  sequenceId: 430  <==> CSLSyncId: 431 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.711	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:432_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.711	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.710	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.710	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.710	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.710	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 432, settings 0x0, num_output_buffers 1
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.709	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.709	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.708	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.706	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead19cf0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.703	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:55:00.703	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.988ms
10-05 14:55:00.697	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.695	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:430 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.691	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.691	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.691	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.691	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.691	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 429  <==>  requestId: 430  <==>  sequenceId: 429  <==> CSLSyncId: 430 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.691	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.691	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.691	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.673	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:431_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.673	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.673	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.673	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.672	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.672	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 431, settings 0x0, num_output_buffers 1
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.672	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.672	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.669	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead00390, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.666	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:55:00.666	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.741ms
10-05 14:55:00.659	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.659	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.651	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.651	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.651	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.651	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.651	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.651	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.651	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.638	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.635	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:429 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.631	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.622	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 428  <==>  requestId: 429  <==>  sequenceId: 428  <==> CSLSyncId: 429 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.621	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:430_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.621	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.620	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.620	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.620	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 430, settings 0x0, num_output_buffers 1
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.620	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.619	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.619	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.618	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.615	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb0570, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.610	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 21 ms
10-05 14:55:00.609	KYOCERA C6930	Info	929	AncSDK	leave process_image 20.800ms
10-05 14:55:00.603	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.603	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.589	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.589	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.589	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.589	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.589	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.589	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.588	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.579	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.575	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:428 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.549	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.549	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.541	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 427  <==>  requestId: 428  <==>  sequenceId: 427  <==> CSLSyncId: 428 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.540	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:429_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.540	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.540	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.540	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.539	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.539	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.539	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 429, settings 0x0, num_output_buffers 1
10-05 14:55:00.538	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.538	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.537	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.534	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacc1eb0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.531	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:55:00.531	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.647ms
10-05 14:55:00.531	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.530	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.519	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.519	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.519	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.518	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.518	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.518	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.518	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.518	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.517	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:427 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.493	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 426  <==>  requestId: 427  <==>  sequenceId: 426  <==> CSLSyncId: 427 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.490	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:428_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.490	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.490	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.490	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.489	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.489	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 428, settings 0x0, num_output_buffers 1
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.489	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.489	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.488	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.484	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde6f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.484	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.484	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.481	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:55:00.481	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.136ms
10-05 14:55:00.466	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.466	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.465	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.465	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.465	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.465	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.465	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.463	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.459	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:426 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.429	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 425  <==>  requestId: 426  <==>  sequenceId: 425  <==> CSLSyncId: 426 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.428	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.428	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.428	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.428	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.428	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.428	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.428	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.427	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.427	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.426	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:427_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.426	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.426	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.426	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.426	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.426	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.425	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 427, settings 0x0, num_output_buffers 1
10-05 14:55:00.423	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.423	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.422	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd7990, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.419	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:55:00.419	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.992ms
10-05 14:55:00.405	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.405	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.405	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.405	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.405	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.405	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.405	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.403	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.399	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:425 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.377	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 424  <==>  requestId: 425  <==>  sequenceId: 424  <==> CSLSyncId: 425 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.375	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.375	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.374	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.374	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.373	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:426_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.373	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.372	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.372	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 426, settings 0x0, num_output_buffers 1
10-05 14:55:00.370	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.370	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.368	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3ad10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.364	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:55:00.364	KYOCERA C6930	Info	929	AncSDK	leave process_image 15.358ms
10-05 14:55:00.349	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.349	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.349	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.349	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.349	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.349	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.349	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.345	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.342	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:424 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.329	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.329	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.312	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.312	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.306	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 423  <==>  requestId: 424  <==>  sequenceId: 423  <==> CSLSyncId: 424 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.299	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.299	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.299	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.299	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.298	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:425_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.298	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.298	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.298	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.297	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.297	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.297	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.297	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.297	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.297	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 425, settings 0x0, num_output_buffers 1
10-05 14:55:00.297	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.293	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3e550, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.290	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:55:00.290	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.774ms
10-05 14:55:00.287	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.284	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:423 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.277	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.277	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.276	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.276	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.276	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.276	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.276	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.246	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.246	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.244	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 422  <==>  requestId: 423  <==>  sequenceId: 422  <==> CSLSyncId: 423 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.244	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:424_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.244	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.244	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.244	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.243	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.243	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 424, settings 0x0, num_output_buffers 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.243	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.243	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.242	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.240	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb9210, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.237	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 10 ms
10-05 14:55:00.237	KYOCERA C6930	Info	929	AncSDK	leave process_image 10.647ms
10-05 14:55:00.228	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.227	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.227	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.226	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.226	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.226	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.226	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.226	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.225	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:422 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.203	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:423_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.203	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.202	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 421  <==>  requestId: 422  <==>  sequenceId: 421  <==> CSLSyncId: 422 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.202	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.202	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 423, settings 0x0, num_output_buffers 1
10-05 14:55:00.202	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.202	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.201	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.201	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.200	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.196	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead2a370, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.193	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 19 ms
10-05 14:55:00.193	KYOCERA C6930	Info	929	AncSDK	leave process_image 19.083ms
10-05 14:55:00.191	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.191	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.174	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.174	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.174	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.174	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.174	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.174	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.174	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.171	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.167	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:421 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.146	KYOCERA C6930	Error	929	CamX	[ERROR][MEMMGR ] camximagebuffer.h:668 IsInValidUsageState() [ZSLPreviewRaw_LT1080p_KC_com.qti.node.gpu2_OutputPortId4_ ][0xb400006e0ae279a0] Client trying to use after releasing the ImageBuffer
10-05 14:55:00.139	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.139	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.131	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.128	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 420  <==>  requestId: 421  <==>  sequenceId: 420  <==> CSLSyncId: 421 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.127	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.127	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.126	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.126	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:422_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.126	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.126	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.126	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.126	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.126	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.126	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.125	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.125	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.125	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.124	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.124	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 422, settings 0x0, num_output_buffers 1
10-05 14:55:00.124	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.124	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.124	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.124	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.124	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.124	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.124	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.124	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.124	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.119	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde3d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.116	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:55:00.116	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.841ms
10-05 14:55:00.111	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.108	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:420 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.102	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.102	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.101	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.101	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.101	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.101	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.101	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.073	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.073	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.072	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:421_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.072	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.072	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 419  <==>  requestId: 420  <==>  sequenceId: 419  <==> CSLSyncId: 420 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.072	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.072	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.072	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 421, settings 0x0, num_output_buffers 1
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.072	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.071	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.071	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.067	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacbab10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.065	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 11 ms
10-05 14:55:00.065	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.505ms
10-05 14:55:00.054	KYOCERA C6930	Info	929	AncSDK	
10-05 14:55:00.054	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:55:00.053	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:55:00.053	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:55:00.053	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:55:00.053	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:55:00.053	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.052	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:55:00.049	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:419 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:55:00.048	KYOCERA C6930	Verbose	12744	AlarmController#restartAlarm:118	Alarm validation check : AllowNotification = false
10-05 14:55:00.047	KYOCERA C6930	Verbose	12744	AlarmController#restartAlarm:117	Alarm validation check : Skip
10-05 14:55:00.047	KYOCERA C6930	Error	12744	LocationProvidersChangeReceiver	action : android.intent.action.TIME_TICK
10-05 14:55:00.047	KYOCERA C6930	Verbose	12744	LocationProvidersChangeReceiver#onReceive:33	------------------------------------------------------
10-05 14:55:00.047	KYOCERA C6930	Verbose	12744	AlarmController#restartAlarm:118	Alarm validation check : AllowNotification = false
10-05 14:55:00.047	KYOCERA C6930	Verbose	12744	AlarmController#restartAlarm:117	Alarm validation check : Skip
10-05 14:55:00.047	KYOCERA C6930	Error	12744	LocationProvidersChangeReceiver	action : android.intent.action.TIME_TICK
10-05 14:55:00.046	KYOCERA C6930	Verbose	12744	LocationProvidersChangeReceiver#onReceive:33	------------------------------------------------------
10-05 14:55:00.019	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.018	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:55:00.018	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 418  <==>  requestId: 419  <==>  sequenceId: 418  <==> CSLSyncId: 419 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:55:00.018	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:55:00.017	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:55:00.017	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:420_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:55:00.017	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:55:00.016	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:55:00.016	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 420, settings 0x0, num_output_buffers 1
10-05 14:55:00.015	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:55:00.015	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:55:00.015	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:55:00.013	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:55:00.013	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:55:00.012	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deace0630, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:55:00.008	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 19 ms
10-05 14:55:00.008	KYOCERA C6930	Info	929	AncSDK	leave process_image 19.550ms
10-05 14:54:59.994	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.991	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:418 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.989	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.989	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.988	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.988	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.988	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.988	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.988	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.963	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 417  <==>  requestId: 418  <==>  sequenceId: 417  <==> CSLSyncId: 418 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.962	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.962	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:419_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.962	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.962	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.962	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.962	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.962	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.962	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.961	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.961	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 419, settings 0x0, num_output_buffers 1
10-05 14:54:59.961	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.961	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.961	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.961	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.961	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.961	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.961	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.960	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.960	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.956	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.956	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.956	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4df50, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.953	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:54:59.953	KYOCERA C6930	Info	929	AncSDK	leave process_image 15.307ms
10-05 14:54:59.938	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.938	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.937	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.937	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.937	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.937	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.937	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.935	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.933	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:417 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.925	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.925	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.903	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 416  <==>  requestId: 417  <==>  sequenceId: 416  <==> CSLSyncId: 417 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.901	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:418_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.901	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.901	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.901	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.901	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.901	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.900	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 418, settings 0x0, num_output_buffers 1
10-05 14:54:59.900	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.900	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.899	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.899	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.899	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.895	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd82f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.891	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 17 ms
10-05 14:54:59.890	KYOCERA C6930	Info	929	AncSDK	leave process_image 17.116ms
10-05 14:54:59.878	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.875	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:416 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.874	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.874	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.873	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.873	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.873	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.873	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.873	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.840	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.840	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.835	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 415  <==>  requestId: 416  <==>  sequenceId: 415  <==> CSLSyncId: 416 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.835	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:417_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.835	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.835	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.834	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.834	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.834	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 417, settings 0x0, num_output_buffers 1
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.834	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.833	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.833	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.833	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.833	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.833	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.833	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.833	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.833	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.833	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.833	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.829	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4b9d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.826	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 17 ms
10-05 14:54:59.825	KYOCERA C6930	Info	929	AncSDK	leave process_image 17.413ms
10-05 14:54:59.820	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.818	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:415 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.809	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.809	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.808	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.808	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.808	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.808	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.808	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.778	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.778	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.767	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 414  <==>  requestId: 415  <==>  sequenceId: 414  <==> CSLSyncId: 415 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.766	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:416_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.766	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.766	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.766	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.766	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 416, settings 0x0, num_output_buffers 1
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.766	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.765	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.765	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.765	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.765	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.762	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead19cf0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.760	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.760	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 11 ms
10-05 14:54:59.760	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.551ms
10-05 14:54:59.758	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:414 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.749	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.749	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.748	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.748	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.748	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.748	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.748	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.723	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.723	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.722	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.722	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.718	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 413  <==>  requestId: 414  <==>  sequenceId: 413  <==> CSLSyncId: 414 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.715	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:415_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.715	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.715	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.715	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.715	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.715	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.715	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.714	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.714	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.714	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 415, settings 0x0, num_output_buffers 1
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.714	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.713	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.713	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.711	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead00390, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.708	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:54:59.708	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.408ms
10-05 14:54:59.701	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.699	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:413 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.695	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.695	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.695	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 412  <==>  requestId: 413  <==>  sequenceId: 412  <==> CSLSyncId: 413 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.695	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.695	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.695	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.695	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.695	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.682	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:414_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.682	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.681	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.681	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 414, settings 0x0, num_output_buffers 1
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.681	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.681	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.680	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.680	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.679	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.676	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb0570, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.673	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 22 ms
10-05 14:54:59.673	KYOCERA C6930	Info	929	AncSDK	leave process_image 21.922ms
10-05 14:54:59.662	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.662	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.651	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.651	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.651	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.651	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.651	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.651	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.651	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.643	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.640	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:412 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.632	KYOCERA C6930	Info	5038	BtGatt.ScanManager	msg.what = 6
10-05 14:54:59.630	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.615	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 411  <==>  requestId: 412  <==>  sequenceId: 411  <==> CSLSyncId: 412 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.615	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.615	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.615	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.615	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.615	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.615	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.614	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.614	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.613	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:413_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.613	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.612	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.612	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 413, settings 0x0, num_output_buffers 1
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.612	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.612	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.611	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.607	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacc1eb0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.607	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.607	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.603	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 19 ms
10-05 14:54:59.603	KYOCERA C6930	Info	929	AncSDK	leave process_image 18.744ms
10-05 14:54:59.586	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.585	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.585	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.584	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.584	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.584	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.584	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.584	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.583	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:411 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.552	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 410  <==>  requestId: 411  <==>  sequenceId: 410  <==> CSLSyncId: 411 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.552	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.551	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:412_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.551	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.551	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.550	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.550	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.550	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.550	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.550	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.550	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.550	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.550	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.550	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 412, settings 0x0, num_output_buffers 1
10-05 14:54:59.550	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.550	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.550	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.546	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.546	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.546	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde6f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.542	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:54:59.542	KYOCERA C6930	Info	929	AncSDK	leave process_image 15.988ms
10-05 14:54:59.527	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.527	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.526	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.526	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.526	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.526	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.526	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.526	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.524	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:410 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.522	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.521	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.496	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.495	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.495	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 409  <==>  requestId: 410  <==>  sequenceId: 409  <==> CSLSyncId: 410 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.495	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.495	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.494	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.494	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:411_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.494	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.493	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.493	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 411, settings 0x0, num_output_buffers 1
10-05 14:54:59.490	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.490	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.489	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd7990, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.479	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:54:59.479	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.324ms
10-05 14:54:59.469	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.466	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:409 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.466	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.466	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.465	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.465	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.465	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.465	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.464	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.431	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.430	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.428	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 408  <==>  requestId: 409  <==>  sequenceId: 408  <==> CSLSyncId: 409 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.427	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:410_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.427	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.427	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.427	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.426	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.426	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 410, settings 0x0, num_output_buffers 1
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.426	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.426	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.422	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3ad10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.419	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:54:59.419	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.896ms
10-05 14:54:59.413	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.410	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:408 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.405	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.405	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.404	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.404	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.404	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.404	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.404	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.372	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.372	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.361	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.361	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 407  <==>  requestId: 408  <==>  sequenceId: 407  <==> CSLSyncId: 408 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.361	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.360	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:409_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.360	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.360	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.360	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.359	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.359	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 409, settings 0x0, num_output_buffers 1
10-05 14:54:59.356	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3e550, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.354	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:54:59.353	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.966ms
10-05 14:54:59.351	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.349	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:407 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.341	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.341	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.341	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.340	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.340	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.340	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.340	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.340	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 406  <==>  requestId: 407  <==>  sequenceId: 406  <==> CSLSyncId: 407 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.327	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:408_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.327	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.326	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.326	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.326	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.326	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.326	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.326	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.326	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.326	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.326	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.326	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.325	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.325	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.325	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.324	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 408, settings 0x0, num_output_buffers 1
10-05 14:54:59.321	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb9210, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.319	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.319	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.318	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 18 ms
10-05 14:54:59.318	KYOCERA C6930	Info	929	AncSDK	leave process_image 17.793ms
10-05 14:54:59.313	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.313	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.306	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.304	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:406 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.301	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.301	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.300	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.300	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.300	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.300	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.300	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 405  <==>  requestId: 406  <==>  sequenceId: 405  <==> CSLSyncId: 406 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.300	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.276	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:407_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.276	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.276	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.276	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.276	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.275	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.275	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 407, settings 0x0, num_output_buffers 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.275	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.274	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.274	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.274	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.270	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead2a370, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.265	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 22 ms
10-05 14:54:59.265	KYOCERA C6930	Info	929	AncSDK	leave process_image 21.867ms
10-05 14:54:59.261	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.261	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.244	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.244	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.243	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.243	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.243	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.243	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.243	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.236	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.234	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:405 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.206	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.206	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.200	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 404  <==>  requestId: 405  <==>  sequenceId: 404  <==> CSLSyncId: 405 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.199	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:406_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.199	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.199	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.199	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.198	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.198	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 406, settings 0x0, num_output_buffers 1
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.198	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.198	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.194	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde3d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.190	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 17 ms
10-05 14:54:59.190	KYOCERA C6930	Info	929	AncSDK	leave process_image 17.251ms
10-05 14:54:59.177	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.174	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:404 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.174	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.174	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.173	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.173	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.173	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.173	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.173	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.142	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 403  <==>  requestId: 404  <==>  sequenceId: 403  <==> CSLSyncId: 404 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.140	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:405_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.140	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.140	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.139	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.139	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.139	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 405, settings 0x0, num_output_buffers 1
10-05 14:54:59.139	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.139	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.139	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.139	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.138	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.135	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacbab10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.132	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:54:59.132	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.777ms
10-05 14:54:59.130	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.121	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.121	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.120	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.120	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.120	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.120	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.120	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.120	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.117	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.117	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.117	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:59.117	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : -1
10-05 14:54:59.115	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:403 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.085	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 402  <==>  requestId: 403  <==>  sequenceId: 402  <==> CSLSyncId: 403 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.085	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.085	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.085	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.085	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.085	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.085	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.085	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.085	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.084	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:404_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.084	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.084	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.084	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.083	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.083	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.083	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.083	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.083	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.083	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.083	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.083	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 404, settings 0x0, num_output_buffers 1
10-05 14:54:59.083	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.083	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.083	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.083	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.083	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.079	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deace0630, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.076	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 17 ms
10-05 14:54:59.075	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.812ms
10-05 14:54:59.062	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.060	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:59.060	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:59.059	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:59.059	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:59.059	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:59.059	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:59.058	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.058	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:402 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:59.026	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:59.025	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:59.015	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 401  <==>  requestId: 402  <==>  sequenceId: 401  <==> CSLSyncId: 402 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.015	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:403_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:59.015	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:59.015	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.015	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:59.014	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:59.014	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 403, settings 0x0, num_output_buffers 1
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:59.014	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:59.014	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:59.010	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4df50, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:59.008	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:54:59.008	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.302ms
10-05 14:54:59.005	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:59.002	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:401 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.995	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.995	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.995	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.995	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.995	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.995	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.994	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.972	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:402_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.972	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.971	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 400  <==>  requestId: 401  <==>  sequenceId: 400  <==> CSLSyncId: 401 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.971	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.971	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 402, settings 0x0, num_output_buffers 1
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.970	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.970	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.969	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.969	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.968	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.964	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.964	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.964	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd82f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.961	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:58.961	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.990ms
10-05 14:54:58.948	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.948	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.947	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.947	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.947	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.947	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.947	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.943	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.940	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:400 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.919	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.918	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.917	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:58.917	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 317
10-05 14:54:58.913	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.913	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.909	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 399  <==>  requestId: 400  <==>  sequenceId: 399  <==> CSLSyncId: 400 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.907	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:401_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.907	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.906	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.906	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 401, settings 0x0, num_output_buffers 1
10-05 14:54:58.905	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.905	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.904	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.904	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.904	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.900	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4b9d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.897	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:54:58.897	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.033ms
10-05 14:54:58.886	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.883	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:399 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.881	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.881	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.881	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.880	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.880	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.880	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.880	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.846	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.846	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.839	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:400_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.839	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.839	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 398  <==>  requestId: 399  <==>  sequenceId: 398  <==> CSLSyncId: 399 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.839	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.838	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.838	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.838	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 400, settings 0x0, num_output_buffers 1
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.838	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.838	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.837	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.833	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead19cf0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.830	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:54:58.830	KYOCERA C6930	Info	929	AncSDK	leave process_image 15.691ms
10-05 14:54:58.826	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.824	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:398 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.815	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.815	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.814	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.814	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.814	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.814	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.814	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.788	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.788	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.787	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 397  <==>  requestId: 398  <==>  sequenceId: 397  <==> CSLSyncId: 398 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.787	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:399_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.787	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.786	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 399, settings 0x0, num_output_buffers 1
10-05 14:54:58.786	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.786	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.785	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.785	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.785	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.778	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead00390, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.775	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 11 ms
10-05 14:54:58.775	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.359ms
10-05 14:54:58.769	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.767	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:397 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.764	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.764	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.764	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.764	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.764	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.764	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.763	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.733	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.733	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.732	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 396  <==>  requestId: 397  <==>  sequenceId: 396  <==> CSLSyncId: 397 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.731	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:398_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.731	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.730	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.730	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 398, settings 0x0, num_output_buffers 1
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.730	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.730	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.729	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.729	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.729	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.729	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.729	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.729	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.729	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.729	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.729	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.726	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb0570, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.722	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:58.722	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.500ms
10-05 14:54:58.715	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:58.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.714	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.714	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 318
10-05 14:54:58.713	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.710	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:396 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.708	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.708	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.707	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.707	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.707	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.707	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.707	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.706	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 395  <==>  requestId: 396  <==>  sequenceId: 395  <==> CSLSyncId: 396 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.693	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:397_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.693	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.693	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.693	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.693	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.692	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 397, settings 0x0, num_output_buffers 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.692	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.691	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.691	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.691	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.687	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacc1eb0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.684	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:58.684	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.116ms
10-05 14:54:58.675	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.674	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.671	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.671	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.670	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.670	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.670	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.670	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.670	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.669	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.666	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:395 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.661	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 394  <==>  requestId: 395  <==>  sequenceId: 394  <==> CSLSyncId: 395 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.644	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:396_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.644	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.643	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.643	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.643	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 396, settings 0x0, num_output_buffers 1
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.643	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.642	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.642	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.641	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.638	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde6f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.634	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 27 ms
10-05 14:54:58.634	KYOCERA C6930	Info	929	AncSDK	leave process_image 27.128ms
10-05 14:54:58.630	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.623	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.623	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.608	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.608	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.607	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.607	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.607	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.607	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.607	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.596	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.591	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:394 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.569	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.569	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.553	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 393  <==>  requestId: 394  <==>  sequenceId: 393  <==> CSLSyncId: 394 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.552	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.551	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.551	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.550	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.550	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:395_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.550	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.550	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.549	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.549	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 395, settings 0x0, num_output_buffers 1
10-05 14:54:58.544	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd7990, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.541	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:58.541	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.043ms
10-05 14:54:58.536	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.533	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:393 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.528	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.528	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.527	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.527	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.527	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.527	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.527	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.511	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.511	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.511	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:58.511	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 317
10-05 14:54:58.496	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.496	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.487	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 392  <==>  requestId: 393  <==>  sequenceId: 392  <==> CSLSyncId: 393 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.487	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:394_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.487	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.487	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.486	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.486	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.486	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 394, settings 0x0, num_output_buffers 1
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.486	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.486	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.483	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3ad10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.480	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:54:58.480	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.189ms
10-05 14:54:58.475	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.473	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:392 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.467	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.467	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.467	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.467	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.467	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.466	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.466	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.439	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.439	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.438	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 391  <==>  requestId: 392  <==>  sequenceId: 391  <==> CSLSyncId: 392 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.438	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:393_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.438	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.437	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.437	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.437	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 393, settings 0x0, num_output_buffers 1
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.437	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.436	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.436	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.436	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.436	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.436	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.436	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.436	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.436	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.436	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.433	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3e550, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.430	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:54:58.430	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.123ms
10-05 14:54:58.424	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.422	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:391 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.418	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 390  <==>  requestId: 391  <==>  sequenceId: 390  <==> CSLSyncId: 391 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.418	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.418	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.417	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.417	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.417	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.417	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.417	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.396	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.396	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.396	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.396	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.396	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.396	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.395	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.395	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.394	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:392_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.394	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.394	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.393	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.393	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.393	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.393	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 392, settings 0x0, num_output_buffers 1
10-05 14:54:58.387	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb9210, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.383	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 20 ms
10-05 14:54:58.383	KYOCERA C6930	Info	929	AncSDK	leave process_image 19.928ms
10-05 14:54:58.381	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.381	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.364	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.364	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.363	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.363	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.363	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.363	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.363	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.360	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.357	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:390 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.325	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.325	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.313	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 389  <==>  requestId: 390  <==>  sequenceId: 389  <==> CSLSyncId: 390 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.313	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:391_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.313	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.313	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.313	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.312	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.312	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 391, settings 0x0, num_output_buffers 1
10-05 14:54:58.312	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.312	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.311	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.309	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.309	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.309	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:58.309	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 318
10-05 14:54:58.308	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead2a370, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.305	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:54:58.305	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.887ms
10-05 14:54:58.302	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.299	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:389 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.293	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.293	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.292	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.292	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.292	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.292	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.292	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.265	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.265	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.265	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 388  <==>  requestId: 389  <==>  sequenceId: 388  <==> CSLSyncId: 389 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.263	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:390_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.263	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.262	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.262	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 390, settings 0x0, num_output_buffers 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.262	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.261	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.261	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.261	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.258	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde3d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.255	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 11 ms
10-05 14:54:58.255	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.673ms
10-05 14:54:58.244	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.244	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.243	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.243	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.243	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.243	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.243	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.243	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.240	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:388 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.211	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 387  <==>  requestId: 388  <==>  sequenceId: 387  <==> CSLSyncId: 388 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.211	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.211	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.211	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.211	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.211	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:389_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.211	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.211	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.211	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.211	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.210	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.210	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.210	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 389, settings 0x0, num_output_buffers 1
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.210	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.209	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.209	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.209	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.209	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.209	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.206	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacbab10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.201	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 21 ms
10-05 14:54:58.201	KYOCERA C6930	Info	929	AncSDK	leave process_image 21.036ms
10-05 14:54:58.186	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.182	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:387 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.181	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.181	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.180	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.180	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.180	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.180	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.180	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.152	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 386  <==>  requestId: 387  <==>  sequenceId: 386  <==> CSLSyncId: 387 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.146	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.146	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.145	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:388_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.145	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.144	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.144	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 388, settings 0x0, num_output_buffers 1
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.143	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.143	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.142	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.142	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.139	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deace0630, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.136	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:54:58.136	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.703ms
10-05 14:54:58.129	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.126	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.126	KYOCERA C6930	Debug	970	KcWifi	[KcWifi] waitForEvent: waitForEvent fb[6]
10-05 14:54:58.125	KYOCERA C6930	Debug	2751	KcWifiSocketManager	waitForEvent failed: -1
10-05 14:54:58.124	KYOCERA C6930	Error	970	KcWifi	[KcWifi] waitForEvent: recv timeout
10-05 14:54:58.124	KYOCERA C6930	Error	970	KcWifi	[KcWifi] waitForEvent: recv failed
10-05 14:54:58.124	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.124	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.123	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:386 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.123	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.123	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.123	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.123	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.123	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.107	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.107	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.107	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:58.107	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 317
10-05 14:54:58.091	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.090	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.087	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 385  <==>  requestId: 386  <==>  sequenceId: 385  <==> CSLSyncId: 386 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.087	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.087	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.087	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.087	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.087	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.087	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.086	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.086	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:387_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.086	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.086	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.085	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.085	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.085	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.085	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.084	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 387, settings 0x0, num_output_buffers 1
10-05 14:54:58.080	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4df50, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.077	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:58.077	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.470ms
10-05 14:54:58.070	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.066	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:385 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.063	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.063	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.062	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.062	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.062	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.062	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.062	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.032	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:58.032	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:58.030	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 384  <==>  requestId: 385  <==>  sequenceId: 384  <==> CSLSyncId: 385 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.030	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:58.030	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:386_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:58.030	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:58.029	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:58.029	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:58.029	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:58.028	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:58.028	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 386, settings 0x0, num_output_buffers 1
10-05 14:54:58.028	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:58.024	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd82f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:58.021	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:58.020	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.075ms
10-05 14:54:58.010	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:58.007	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:58.007	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:58.007	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:384 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:58.006	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:58.006	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:58.006	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:58.006	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:58.006	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.975	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.975	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.968	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 383  <==>  requestId: 384  <==>  sequenceId: 383  <==> CSLSyncId: 384 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.968	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.968	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.968	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.968	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.967	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:385_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.967	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.967	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.966	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.966	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.966	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.966	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 385, settings 0x0, num_output_buffers 1
10-05 14:54:57.966	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.962	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4b9d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.959	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:57.959	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.097ms
10-05 14:54:57.952	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.949	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:383 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.946	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.946	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.945	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.945	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.945	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.945	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.945	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.912	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.912	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.912	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.911	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.911	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.910	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.910	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.907	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 382  <==>  requestId: 383  <==>  sequenceId: 382  <==> CSLSyncId: 383 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.906	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:384_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.906	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.905	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.905	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 384, settings 0x0, num_output_buffers 1
10-05 14:54:57.905	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.905	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.902	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead19cf0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.899	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:54:57.899	KYOCERA C6930	Info	929	AncSDK	leave process_image 15.559ms
10-05 14:54:57.894	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.890	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:382 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.884	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.884	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.883	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.883	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.883	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.883	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.883	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.860	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.859	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.858	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 381  <==>  requestId: 382  <==>  sequenceId: 381  <==> CSLSyncId: 382 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.858	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:383_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.858	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.857	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.857	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 383, settings 0x0, num_output_buffers 1
10-05 14:54:57.857	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.857	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.857	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.854	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead00390, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.853	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.853	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.850	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:57.850	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.055ms
10-05 14:54:57.837	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.837	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.836	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.836	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.836	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.836	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.836	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.833	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.831	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:381 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.820	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 380  <==>  requestId: 381  <==>  sequenceId: 380  <==> CSLSyncId: 381 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.811	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:382_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.811	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.810	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.810	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 382, settings 0x0, num_output_buffers 1
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.807	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.807	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.806	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.806	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.806	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.806	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.806	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.806	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.806	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.806	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.803	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb0570, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.799	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.799	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.797	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 21 ms
10-05 14:54:57.796	KYOCERA C6930	Info	929	AncSDK	leave process_image 21.288ms
10-05 14:54:57.777	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.776	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.776	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.775	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.775	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.775	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.775	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.775	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.774	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:380 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.742	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.742	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 379  <==>  requestId: 380  <==>  sequenceId: 379  <==> CSLSyncId: 380 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.742	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.742	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.742	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.742	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.742	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.741	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.741	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:381_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.741	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.741	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.740	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.740	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.740	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.740	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.740	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 381, settings 0x0, num_output_buffers 1
10-05 14:54:57.740	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.739	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.739	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.736	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacc1eb0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.733	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:54:57.733	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.448ms
10-05 14:54:57.720	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.720	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.719	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.719	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.719	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.719	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.719	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.718	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.714	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:379 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.704	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.704	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.704	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:57.704	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 318
10-05 14:54:57.686	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.686	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.680	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 378  <==>  requestId: 379  <==>  sequenceId: 378  <==> CSLSyncId: 379 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.678	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.678	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:380_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.678	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.678	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.677	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.677	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.677	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 380, settings 0x0, num_output_buffers 1
10-05 14:54:57.677	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.671	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde6f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.668	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:54:57.668	KYOCERA C6930	Info	929	AncSDK	leave process_image 15.155ms
10-05 14:54:57.659	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.657	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:378 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.653	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.653	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.653	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.653	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.653	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.653	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.652	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.629	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.622	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.622	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.622	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.622	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.622	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.621	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.621	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.621	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.621	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 377  <==>  requestId: 378  <==>  sequenceId: 377  <==> CSLSyncId: 378 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.621	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:379_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.621	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.621	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.620	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.620	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.620	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.620	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.620	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 379, settings 0x0, num_output_buffers 1
10-05 14:54:57.616	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd7990, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.613	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:57.613	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.761ms
10-05 14:54:57.601	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.599	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.599	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.599	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.599	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.599	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.599	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.599	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.598	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:377 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.567	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.567	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.560	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 376  <==>  requestId: 377  <==>  sequenceId: 376  <==> CSLSyncId: 377 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.556	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.556	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.555	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:378_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.555	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.555	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.555	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.555	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.555	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 378, settings 0x0, num_output_buffers 1
10-05 14:54:57.551	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3ad10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.549	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 10 ms
10-05 14:54:57.549	KYOCERA C6930	Info	929	AncSDK	leave process_image 10.398ms
10-05 14:54:57.541	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.539	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:376 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.539	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.539	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.539	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.538	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.538	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.538	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.538	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.516	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 375  <==>  requestId: 376  <==>  sequenceId: 375  <==> CSLSyncId: 376 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.514	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:377_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.514	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.514	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.514	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.513	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.513	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 377, settings 0x0, num_output_buffers 1
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.513	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.513	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.510	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3e550, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.507	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 19 ms
10-05 14:54:57.507	KYOCERA C6930	Info	929	AncSDK	leave process_image 19.275ms
10-05 14:54:57.506	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.505	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.501	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.501	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.501	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:57.501	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 317
10-05 14:54:57.489	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.489	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.488	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.488	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.488	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.487	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.487	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.485	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.482	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:375 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.449	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.449	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.446	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 374  <==>  requestId: 375  <==>  sequenceId: 374  <==> CSLSyncId: 375 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.445	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:376_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.445	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.445	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.444	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.444	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.444	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 376, settings 0x0, num_output_buffers 1
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.443	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.443	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.443	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.443	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.436	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb9210, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.432	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 17 ms
10-05 14:54:57.432	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.785ms
10-05 14:54:57.426	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.424	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:374 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.416	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.416	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.415	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.415	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.415	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.415	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.415	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.387	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.387	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.386	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 373  <==>  requestId: 374  <==>  sequenceId: 373  <==> CSLSyncId: 374 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.385	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:375_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.385	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.385	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.385	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.385	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.384	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 375, settings 0x0, num_output_buffers 1
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.384	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.384	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.381	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead2a370, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.378	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:54:57.378	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.228ms
10-05 14:54:57.369	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.367	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:373 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.367	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.367	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.366	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.366	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.366	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.366	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.366	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.363	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 372  <==>  requestId: 373  <==>  sequenceId: 372  <==> CSLSyncId: 373 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.344	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:374_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.344	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.344	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.343	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.343	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.343	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 374, settings 0x0, num_output_buffers 1
10-05 14:54:57.343	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.343	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.342	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.339	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde3d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.336	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 21 ms
10-05 14:54:57.336	KYOCERA C6930	Info	929	AncSDK	leave process_image 21.460ms
10-05 14:54:57.330	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.330	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.315	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.315	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.314	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.314	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.314	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.314	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.314	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.309	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.306	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:372 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.299	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.299	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.299	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:57.299	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 318
10-05 14:54:57.284	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 371  <==>  requestId: 372  <==>  sequenceId: 371  <==> CSLSyncId: 372 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.283	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:373_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.283	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.283	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.283	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.282	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.282	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 373, settings 0x0, num_output_buffers 1
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.282	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.282	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.278	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacbab10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.275	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 17 ms
10-05 14:54:57.275	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.869ms
10-05 14:54:57.273	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.273	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.258	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.258	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.258	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.258	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.258	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.258	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.258	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.251	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.248	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:371 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.219	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.219	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.217	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.217	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.217	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.217	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.217	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.217	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.217	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.216	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.216	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.216	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.216	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.216	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.216	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.215	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 370  <==>  requestId: 371  <==>  sequenceId: 370  <==> CSLSyncId: 371 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.215	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.214	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:372_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.214	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.214	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.214	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.214	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.214	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.214	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.213	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.213	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 372, settings 0x0, num_output_buffers 1
10-05 14:54:57.207	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deace0630, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.203	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:54:57.203	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.132ms
10-05 14:54:57.194	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.191	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:370 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.188	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.188	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.187	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.187	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.187	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.187	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.187	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.154	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.154	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.151	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 369  <==>  requestId: 370  <==>  sequenceId: 369  <==> CSLSyncId: 370 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.150	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:371_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.150	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.149	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.149	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 371, settings 0x0, num_output_buffers 1
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.149	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.149	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.148	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.148	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.145	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4df50, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.141	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 13 ms
10-05 14:54:57.141	KYOCERA C6930	Info	929	AncSDK	leave process_image 13.218ms
10-05 14:54:57.133	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.131	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:369 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.130	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.129	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.129	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.128	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.128	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.128	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.128	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.128	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.098	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.098	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.097	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.097	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.089	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 368  <==>  requestId: 369  <==>  sequenceId: 368  <==> CSLSyncId: 369 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.089	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.089	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.089	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.089	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.089	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.088	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:370_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.088	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.088	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.088	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.087	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.087	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.087	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.087	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.087	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.087	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.087	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.087	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 370, settings 0x0, num_output_buffers 1
10-05 14:54:57.086	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.086	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.086	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.082	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd82f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.078	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:54:57.078	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.614ms
10-05 14:54:57.076	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.073	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:368 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.063	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.063	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.062	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.062	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.062	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.062	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.062	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.036	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:57.036	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:57.022	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 367  <==>  requestId: 368  <==>  sequenceId: 367  <==> CSLSyncId: 368 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:57.022	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	checkSimStatus() false
10-05 14:54:57.022	KYOCERA C6930	Debug	27388	EnterpriseActivateUtils	getDbgPoaTestHttps() poaTestHttpsFlag = false
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:57.020	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:369_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:57.020	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.020	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:57.020	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:57.019	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:57.019	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:57.019	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:57.019	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:57.019	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:57.019	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 369, settings 0x0, num_output_buffers 1
10-05 14:54:57.017	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:57.015	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:367 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:57.014	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4b9d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	checkSimStatus() state:LOADED type:VZW4G activated:YES
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: subscription
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: activated
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: phone
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: type
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: cold
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: ss
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: reason
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: phoneName
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: android.telephony.extra.SLOT_INDEX
10-05 14:54:57.013	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	key: android.telephony.extra.SUBSCRIPTION_INDEX
10-05 14:54:57.011	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 11 ms
10-05 14:54:57.011	KYOCERA C6930	Info	929	AncSDK	leave process_image 10.849ms
10-05 14:54:57.000	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:57.000	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:57.000	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:57.000	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:57.000	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:57.000	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:57.000	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.993	KYOCERA C6930	Info	27388	TetheringManager	registerTetheringEventCallback:jp.kyocera.poweronactivation
10-05 14:54:56.992	KYOCERA C6930	Verbose	27388	CheckEnterpriseActivateService	requestNetwork :
10-05 14:54:56.991	KYOCERA C6930	Debug	27388	CheckEnterpriseActivateService	onServiceStateChanged voiceRegState: 0 dataRegState: 0 rilDataRadioTechnology: 14
10-05 14:54:56.980	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 366  <==>  requestId: 367  <==>  sequenceId: 366  <==> CSLSyncId: 367 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.979	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.979	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:368_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.979	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.979	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.978	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.978	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 368, settings 0x0, num_output_buffers 1
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.977	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.977	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.976	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.976	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.973	KYOCERA C6930	Debug	27388	CompatibilityChangeReporter	Compat change id reported: 147600208; UID 1000; state: ENABLED
10-05 14:54:56.970	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead19cf0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.968	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:56.968	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.459ms
10-05 14:54:56.959	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.957	KYOCERA C6930	Verbose	27388	CheckEnterpriseActivateService	registerPhoneServiceStateListener :
10-05 14:54:56.956	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:366 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.954	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.954	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.953	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.953	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.953	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.953	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.953	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.918	KYOCERA C6930	Verbose	27388	CheckEnterpriseActivateService	onCreate :
10-05 14:54:56.918	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.918	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.911	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 365  <==>  requestId: 366  <==>  sequenceId: 365  <==> CSLSyncId: 366 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.908	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:367_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.908	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.907	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.906	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.906	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.905	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.905	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.905	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.905	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.904	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 367, settings 0x0, num_output_buffers 1
10-05 14:54:56.901	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead00390, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.901	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.898	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:54:56.898	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:365 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.898	KYOCERA C6930	Info	929	AncSDK	leave process_image 12.021ms
10-05 14:54:56.896	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.896	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.896	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:56.896	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : 317
10-05 14:54:56.888	KYOCERA C6930	Debug	27388	NetworkSecurityConfig	No Network Security Config specified, using platform default
10-05 14:54:56.887	KYOCERA C6930	Debug	27388	NetworkSecurityConfig	No Network Security Config specified, using platform default
10-05 14:54:56.886	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.886	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.886	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.886	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.886	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.886	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.886	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.869	KYOCERA C6930	Info	27388	Perf	Connecting to perf service.
10-05 14:54:56.860	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.860	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.853	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.852	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.852	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 364  <==>  requestId: 365  <==>  sequenceId: 364  <==> CSLSyncId: 365 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.852	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:366_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.852	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.852	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.851	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.851	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.851	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.851	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 366, settings 0x0, num_output_buffers 1
10-05 14:54:56.848	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb0570, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.845	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:54:56.845	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.111ms
10-05 14:54:56.841	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.839	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:364 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.830	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.830	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.829	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.829	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.829	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.829	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.829	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.809	KYOCERA C6930	Info	27388	weronactivatio	The ClassLoaderContext is a special shared library.
10-05 14:54:56.803	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.803	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.802	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 363  <==>  requestId: 364  <==>  sequenceId: 363  <==> CSLSyncId: 364 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.801	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:365_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.801	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.800	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.800	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 365, settings 0x0, num_output_buffers 1
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.800	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.800	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.799	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.799	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.795	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacc1eb0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.794	KYOCERA C6930	Info	27388	weronactivatio	The ClassLoaderContext is a special shared library.
10-05 14:54:56.793	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 11 ms
10-05 14:54:56.793	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.022ms
10-05 14:54:56.783	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.782	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.782	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.782	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:363 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.782	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.782	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.782	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.782	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.781	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.780	KYOCERA C6930	Info	27388	weronactivatio	The ClassLoaderContext is a special shared library.
10-05 14:54:56.778	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 362  <==>  requestId: 363  <==>  sequenceId: 362  <==> CSLSyncId: 363 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.758	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:364_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.758	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.758	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.757	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.757	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.757	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 364, settings 0x0, num_output_buffers 1
10-05 14:54:56.757	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.757	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.756	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.754	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:54:56.754	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:54:56.754	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:54:56.753	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde6f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.753	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationScale - 1.0
10-05 14:54:56.753	KYOCERA C6930	Debug	1714	CompatibilityInfo	applicationDensity - 500
10-05 14:54:56.753	KYOCERA C6930	Debug	1714	CompatibilityInfo	mCompatibilityFlags - 0
10-05 14:54:56.750	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:56.750	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.606ms
10-05 14:54:56.748	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.748	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.744	KYOCERA C6930	Error	27388	weronactivatio	Not starting debugger since process cannot load the jdwp agent.
10-05 14:54:56.736	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.736	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.735	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.735	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.735	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.735	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.735	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.727	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.724	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:362 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.709	KYOCERA C6930	Info	1714	ActivityManager	Start proc 27388:jp.kyocera.poweronactivation/1000 for service {jp.kyocera.poweronactivation/jp.kyocera.poweronactivation.CheckEnterpriseActivateService}
10-05 14:54:56.706	KYOCERA C6930	Debug	777	Zygote	Forked child process 27388
10-05 14:54:56.698	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.698	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.694	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.694	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.694	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged [out]
10-05 14:54:56.694	KYOCERA C6930	Verbose	30573	MainActivity	onOrientationChanged : -1
10-05 14:54:56.693	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135754954; UID 1000; state: ENABLED
10-05 14:54:56.693	KYOCERA C6930	Debug	1714	CompatibilityChangeReporter	Compat change id reported: 135634846; UID 1000; state: DISABLED
10-05 14:54:56.690	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 361  <==>  requestId: 362  <==>  sequenceId: 361  <==> CSLSyncId: 362 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.687	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:363_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.687	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.687	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.687	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.687	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.686	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.686	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 363, settings 0x0, num_output_buffers 1
10-05 14:54:56.686	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.686	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.685	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.685	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.685	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.685	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.685	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.685	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.681	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd7990, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.678	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:56.678	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.166ms
10-05 14:54:56.667	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.665	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.665	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.664	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.664	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.664	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:361 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.664	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.664	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.664	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.631	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.631	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.629	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.626	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 360  <==>  requestId: 361  <==>  sequenceId: 360  <==> CSLSyncId: 361 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.626	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.626	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.625	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:362_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.625	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.625	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.625	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.625	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.625	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 362, settings 0x0, num_output_buffers 1
10-05 14:54:56.624	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.621	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3ad10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.618	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:56.618	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.256ms
10-05 14:54:56.608	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.606	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:360 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.604	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.604	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.603	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.603	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.603	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.603	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.603	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.571	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.571	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.567	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 359  <==>  requestId: 360  <==>  sequenceId: 359  <==> CSLSyncId: 360 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.567	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.567	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.566	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:361_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.566	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.566	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.566	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.565	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.565	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 361, settings 0x0, num_output_buffers 1
10-05 14:54:56.561	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead3e550, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.558	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:54:56.558	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.770ms
10-05 14:54:56.551	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.547	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:359 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.544	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.544	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.543	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.543	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.543	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.543	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.543	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.511	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.511	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.502	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 358  <==>  requestId: 359  <==>  sequenceId: 358  <==> CSLSyncId: 359 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.500	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.500	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.500	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.500	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.500	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.500	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.499	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.500	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:360_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.500	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.499	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.499	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 360, settings 0x0, num_output_buffers 1
10-05 14:54:56.499	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.499	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.498	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.498	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.498	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.494	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb9210, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.492	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.491	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.491	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.490	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:54:56.490	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.757ms
10-05 14:54:56.488	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:358 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.479	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.479	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.479	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.479	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.479	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.479	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.478	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.452	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.452	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.446	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 357  <==>  requestId: 358  <==>  sequenceId: 357  <==> CSLSyncId: 358 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.445	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:359_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.445	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.444	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.444	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 359, settings 0x0, num_output_buffers 1
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.444	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.444	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.443	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.443	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.440	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead2a370, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.438	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 12 ms
10-05 14:54:56.438	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.903ms
10-05 14:54:56.432	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.430	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:357 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.426	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.426	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.426	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.426	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.426	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.426	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.426	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.400	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.400	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.392	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 356  <==>  requestId: 357  <==>  sequenceId: 356  <==> CSLSyncId: 357 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.392	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:358_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.392	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.392	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.392	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.391	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.391	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.391	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 358, settings 0x0, num_output_buffers 1
10-05 14:54:56.391	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.387	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacde3d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.384	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 11 ms
10-05 14:54:56.384	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.334ms
10-05 14:54:56.376	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.373	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.373	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.373	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:356 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.373	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.373	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.373	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.373	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.373	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.370	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 355  <==>  requestId: 356  <==>  sequenceId: 355  <==> CSLSyncId: 356 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.354	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:357_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.354	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.354	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.354	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.353	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.353	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 357, settings 0x0, num_output_buffers 1
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.353	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.353	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.349	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacbab10, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.346	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 16 ms
10-05 14:54:56.346	KYOCERA C6930	Info	929	AncSDK	leave process_image 16.566ms
10-05 14:54:56.342	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.342	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.334	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.331	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:355 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.330	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.330	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.330	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.330	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.330	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.330	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.330	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.325	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 354  <==>  requestId: 355  <==>  sequenceId: 354  <==> CSLSyncId: 355 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.306	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.305	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.305	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.304	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:356_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.304	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.304	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.304	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.304	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.304	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.304	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.304	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.303	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.303	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.303	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 356, settings 0x0, num_output_buffers 1
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.303	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.302	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.302	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.302	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.296	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deace0630, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.293	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 21 ms
10-05 14:54:56.292	KYOCERA C6930	Info	929	AncSDK	leave process_image 21.242ms
10-05 14:54:56.290	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.290	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.285	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.285	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.272	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.272	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.271	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.271	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.271	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.271	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.271	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.257	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.255	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:354 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.242	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 353  <==>  requestId: 354  <==>  sequenceId: 353  <==> CSLSyncId: 354 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.239	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.239	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.239	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.239	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:355_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.239	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.239	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.238	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.238	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.238	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.237	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.237	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.237	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 355, settings 0x0, num_output_buffers 1
10-05 14:54:56.236	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.235	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.235	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.230	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4df50, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.227	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.227	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.224	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 20 ms
10-05 14:54:56.224	KYOCERA C6930	Info	929	AncSDK	leave process_image 20.104ms
10-05 14:54:56.205	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.205	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.204	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.204	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.204	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.204	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.204	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.202	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.197	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:353 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.166	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.166	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.161	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.161	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.161	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.161	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.161	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.161	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.160	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.160	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.159	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.159	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.159	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.159	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.157	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 352  <==>  requestId: 353  <==>  sequenceId: 352  <==> CSLSyncId: 353 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.157	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:354_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.157	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.156	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.156	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 354, settings 0x0, num_output_buffers 1
10-05 14:54:56.152	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacd82f0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.149	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 17 ms
10-05 14:54:56.149	KYOCERA C6930	Info	929	AncSDK	leave process_image 17.484ms
10-05 14:54:56.141	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.138	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:352 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.132	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.132	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.132	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.132	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.132	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.132	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.131	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.130	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.103	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.103	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.101	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 351  <==>  requestId: 352  <==>  sequenceId: 351  <==> CSLSyncId: 352 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.101	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.101	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.100	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:353_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.100	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.100	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.099	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.099	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.099	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.099	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.098	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 353, settings 0x0, num_output_buffers 1
10-05 14:54:56.096	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead4b9d0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.093	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 11 ms
10-05 14:54:56.093	KYOCERA C6930	Info	929	AncSDK	leave process_image 11.649ms
10-05 14:54:56.087	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.087	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.083	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.082	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.082	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.081	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.081	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.081	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.081	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.081	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.081	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:351 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.048	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:56.048	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:56.047	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 350  <==>  requestId: 351  <==>  sequenceId: 350  <==> CSLSyncId: 351 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:56.047	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:56.046	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:352_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:56.046	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.046	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.046	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.046	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:56.045	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.045	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:56.045	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:56.045	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:56.045	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 352, settings 0x0, num_output_buffers 1
10-05 14:54:56.045	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:56.045	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:56.045	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:56.045	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:56.045	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:56.041	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead19cf0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:56.038	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:54:56.038	KYOCERA C6930	Info	929	AncSDK	leave process_image 15.251ms
10-05 14:54:56.026	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:56.023	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:56.023	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:56.022	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:56.022	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:56.022	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:56.022	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:56.022	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:350 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:56.022	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:55.990	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:55.990	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:55.987	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 349  <==>  requestId: 350  <==>  sequenceId: 349  <==> CSLSyncId: 350 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:55.987	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:351_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:55.987	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:55.986	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:55.986	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 351, settings 0x0, num_output_buffers 1
10-05 14:54:55.981	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:55.981	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:55.981	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:55.981	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.981	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.981	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:55.981	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:55.981	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.980	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.980	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:55.979	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:55.979	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:55.979	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:55.975	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006dead00390, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:55.972	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 14 ms
10-05 14:54:55.972	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.630ms
10-05 14:54:55.967	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:55.963	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:349 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:55.958	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:55.958	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:55.958	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:55.958	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:55.958	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:55.958	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:55.957	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:55.932	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 348  <==>  requestId: 349  <==>  sequenceId: 348  <==> CSLSyncId: 349 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:55.931	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:350_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:55.931	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:55.931	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:55.931	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:55.931	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:55.931	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.931	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.931	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:55.931	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.930	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:55.930	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:55.930	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 350, settings 0x0, num_output_buffers 1
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:55.930	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:55.929	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:55.929	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.929	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:55.929	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:55.929	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:55.929	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:55.927	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:55.927	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:55.926	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacb0570, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:55.922	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 15 ms
10-05 14:54:55.922	KYOCERA C6930	Info	929	AncSDK	leave process_image 14.872ms
10-05 14:54:55.909	KYOCERA C6930	Info	929	OV16A10KC	total gain: 49.371429,analogRegisterGain:3968, analogRealGain 15.500000,digitalRealGain 3.184570 ,ISPDigitalGain 1.000215
10-05 14:54:55.908	KYOCERA C6930	Info	929	AncSDK	
10-05 14:54:55.908	KYOCERA C6930	Info	929	AncSDK	mfnr_sigma=0.160000, ghost_sigma=2.000000
10-05 14:54:55.907	KYOCERA C6930	Error	929	AncSDK	m_image_Rect 1440 1080 m_align16_Rect 1440 1088 
10-05 14:54:55.907	KYOCERA C6930	Info	929	AncSDK	process output w 1440 stride 1440 h 1080 slice 1080 ,format 1
 select ext param camera id 1 ver 1 brighten 2.500000
10-05 14:54:55.907	KYOCERA C6930	Info	929	AncSDK	process input w 1440 stride 1440 h 1080 slice 1080 ,format 1
10-05 14:54:55.907	KYOCERA C6930	Info	929	AncSDK	start process_image
10-05 14:54:55.907	KYOCERA C6930	Error	929	CHISUPERVQ	[ERROR  ] camxchinodesvq.cpp:1463 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:55.905	KYOCERA C6930	Warning	929	CamX	[ WARN][STATS_AEC] camxcaecstatsprocessor.cpp:1785 GetAlgoInputDefaultStats() ReqId:348 PropertyID 805306417 (ISP BHist Stats) has not been published! 
10-05 14:54:55.886	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.886	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.881	KYOCERA C6930	Info	929	CamX	[REQMAP][CORE   ] camxsession.cpp:4807 ProcessRequest() chiFrameNum: 347  <==>  requestId: 348  <==>  sequenceId: 347  <==> CSLSyncId: 348 -- ZSLPreviewRaw_LT1080p_KC_0
10-05 14:54:55.881	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2requestobject.cpp:2748 GetBufferInfo() FRO-URO:349_RealtimeFG:RealTime_0 OutputConfiguration Buffer not set for GID {0, 0 4}, result:6
10-05 14:54:55.881	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chxutils.cpp:3478 UpdatePartialTuningModeData() UpdatePartialTuningModeData
10-05 14:54:55.880	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2usecaserequestobject.cpp:467 Initialize() pUsecaseSettings is NULL!!
10-05 14:54:55.880	KYOCERA C6930	Info	929	CamX	[CORE_CFG][HAL    ] camxhal3.cpp:1386 process_capture_request() frame_number 349, settings 0x0, num_output_buffers 1
10-05 14:54:55.880	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : hdr = 2
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [out] et = 58333332, iso = 4936
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	ImageStabilizationModule	updatePreviewEvInfo [in]
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[out] : ret = false
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	FaceFocusController	isFaceFocusing()[in]
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	MainActivity	isPortraitMode : ret = false
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	MainActivity	isBeautyMode : ret = false
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.879	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : auto_night_detection = 1
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [out] 21
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [out] : 21
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.879	KYOCERA C6930	Verbose	30573	ConfigUtil	CONFIG photo size : 0:setting_photo_size_wide_photo = SUPPORTED: 21
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [out] return: [21, 18, 19, 48]
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSupportSizeListPhoto [in] 
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	CameraSettingMenu	getSizePhoto [in]
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	MainActivity	getPictureSize [in]
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	MainActivity	getStartUpMode : 1
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	CaptureModule	readPreference : high_sensitivity = 0
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	CaptureModule	Face Length = 0
10-05 14:54:55.878	KYOCERA C6930	Warning	30573	CameraMetadataJV	Expect face scores and rectangles to be non-null
10-05 14:54:55.878	KYOCERA C6930	Verbose	30573	CaptureModule	process : State = 0
10-05 14:54:55.874	KYOCERA C6930	Warning	929	CHIUSECASE	[WARN   ] chifeature2realtime.cpp:1449 PopulateSensorModeOnMetadataResult() Couldn't translate result metadata to initial crop values.pMetadata = 0xb400006deacc1eb0, pInSensorZoomInfo = 0x0, m_pRoiTranslator = 0x0, pCameraInfo = 0x6cdd04ba60
10-05 14:54:55.873	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:881 GetOemFdResult() Get vendor tag oemfdresults failed
10-05 14:54:55.873	KYOCERA C6930	Error	929	CHIHDR	[ERROR  ] camxchinodehdr.cpp:880 GetOemFdResult() face data null
10-05 14:54:55.870	KYOCERA C6930	Error	929	CHIUSECASE	[ERROR  ] camxexecutetime.h:45 Execute() CHISUPERVQ SvqProcessImages run 20 ms
10-05 14:54:55.869	KYOCERA C6930	Info	929	AncSDK	leave process_image 19.860ms

 */

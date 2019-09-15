using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anti_DebugNET.Utils
{
    namespace WinStructs
    {
        public enum PROCESSINFOCLASS : int
        {
            ProcessBasicInformation, // 0, q: PROCESS_BASIC_INFORMATION, PROCESS_EXTENDED_BASIC_INFORMATION
            ProcessQuotaLimits, // qs: QUOTA_LIMITS, QUOTA_LIMITS_EX
            ProcessIoCounters, // q: IO_COUNTERS
            ProcessVmCounters, // q: VM_COUNTERS, VM_COUNTERS_EX
            ProcessTimes, // q: KERNEL_USER_TIMES
            ProcessBasePriority, // s: KPRIORITY
            ProcessRaisePriority, // s: ULONG
            ProcessDebugPort, // q: HANDLE
            ProcessExceptionPort, // s: HANDLE
            ProcessAccessToken, // s: PROCESS_ACCESS_TOKEN
            ProcessLdtInformation, // 10
            ProcessLdtSize,
            ProcessDefaultHardErrorMode, // qs: ULONG
            ProcessIoPortHandlers, // (kernel-mode only)
            ProcessPooledUsageAndLimits, // q: POOLED_USAGE_AND_LIMITS
            ProcessWorkingSetWatch, // q: PROCESS_WS_WATCH_INFORMATION[]; s: void
            ProcessUserModeIOPL,
            ProcessEnableAlignmentFaultFixup, // s: BOOLEAN
            ProcessPriorityClass, // qs: PROCESS_PRIORITY_CLASS
            ProcessWx86Information,
            ProcessHandleCount, // 20, q: ULONG, PROCESS_HANDLE_INFORMATION
            ProcessAffinityMask, // s: KAFFINITY
            ProcessPriorityBoost, // qs: ULONG
            ProcessDeviceMap, // qs: PROCESS_DEVICEMAP_INFORMATION, PROCESS_DEVICEMAP_INFORMATION_EX
            ProcessSessionInformation, // q: PROCESS_SESSION_INFORMATION
            ProcessForegroundInformation, // s: PROCESS_FOREGROUND_BACKGROUND
            ProcessWow64Information, // q: ULONG_PTR
            ProcessImageFileName, // q: UNICODE_STRING
            ProcessLUIDDeviceMapsEnabled, // q: ULONG
            ProcessBreakOnTermination, // qs: ULONG
            ProcessDebugObjectHandle, // 30, q: HANDLE
            ProcessDebugFlags, // qs: ULONG
            ProcessHandleTracing, // q: PROCESS_HANDLE_TRACING_QUERY; s: size 0 disables, otherwise enables
            ProcessIoPriority, // qs: ULONG
            ProcessExecuteFlags, // qs: ULONG
            ProcessResourceManagement,
            ProcessCookie, // q: ULONG
            ProcessImageInformation, // q: SECTION_IMAGE_INFORMATION
            ProcessCycleTime, // q: PROCESS_CYCLE_TIME_INFORMATION // since VISTA
            ProcessPagePriority, // q: ULONG
            ProcessInstrumentationCallback, // 40
            ProcessThreadStackAllocation, // s: PROCESS_STACK_ALLOCATION_INFORMATION, PROCESS_STACK_ALLOCATION_INFORMATION_EX
            ProcessWorkingSetWatchEx, // q: PROCESS_WS_WATCH_INFORMATION_EX[]
            ProcessImageFileNameWin32, // q: UNICODE_STRING
            ProcessImageFileMapping, // q: HANDLE (input)
            ProcessAffinityUpdateMode, // qs: PROCESS_AFFINITY_UPDATE_MODE
            ProcessMemoryAllocationMode, // qs: PROCESS_MEMORY_ALLOCATION_MODE
            ProcessGroupInformation, // q: USHORT[]
            ProcessTokenVirtualizationEnabled, // s: ULONG
            ProcessConsoleHostProcess, // q: ULONG_PTR
            ProcessWindowInformation, // 50, q: PROCESS_WINDOW_INFORMATION
            ProcessHandleInformation, // q: PROCESS_HANDLE_SNAPSHOT_INFORMATION // since WIN8
            ProcessMitigationPolicy, // s: PROCESS_MITIGATION_POLICY_INFORMATION
            ProcessDynamicFunctionTableInformation,
            ProcessHandleCheckingMode,
            ProcessKeepAliveCount, // q: PROCESS_KEEPALIVE_COUNT_INFORMATION
            ProcessRevokeFileHandles, // s: PROCESS_REVOKE_FILE_HANDLES_INFORMATION
            ProcessWorkingSetControl, // s: PROCESS_WORKING_SET_CONTROL
            ProcessHandleTable, // since WINBLUE
            ProcessCheckStackExtentsMode,
            ProcessCommandLineInformation, // 60, q: UNICODE_STRING
            ProcessProtectionInformation, // q: PS_PROTECTION
            MaxProcessInfoClass
        }

        [Flags]
        public enum DebugObjectInformationClass : int
        {
            DebugObjectFlags = 1,
            MaxDebugObjectInfoClass
        }

        public enum SYSTEM_INFORMATION_CLASS
        {
            SystemBasicInformation, // q: SYSTEM_BASIC_INFORMATION
            SystemProcessorInformation, // q: SYSTEM_PROCESSOR_INFORMATION
            SystemPerformanceInformation, // q: SYSTEM_PERFORMANCE_INFORMATION
            SystemTimeOfDayInformation, // q: SYSTEM_TIMEOFDAY_INFORMATION
            SystemPathInformation, // not implemented
            SystemProcessInformation, // q: SYSTEM_PROCESS_INFORMATION
            SystemCallCountInformation, // q: SYSTEM_CALL_COUNT_INFORMATION
            SystemDeviceInformation, // q: SYSTEM_DEVICE_INFORMATION
            SystemProcessorPerformanceInformation, // q: SYSTEM_PROCESSOR_PERFORMANCE_INFORMATION
            SystemFlagsInformation, // q: SYSTEM_FLAGS_INFORMATION
            SystemCallTimeInformation, // 10, not implemented
            SystemModuleInformation, // q: RTL_PROCESS_MODULES
            SystemLocksInformation,
            SystemStackTraceInformation,
            SystemPagedPoolInformation, // not implemented
            SystemNonPagedPoolInformation, // not implemented
            SystemHandleInformation, // q: SYSTEM_HANDLE_INFORMATION
            SystemObjectInformation, // q: SYSTEM_OBJECTTYPE_INFORMATION mixed with SYSTEM_OBJECT_INFORMATION
            SystemPageFileInformation, // q: SYSTEM_PAGEFILE_INFORMATION
            SystemVdmInstemulInformation, // q
            SystemVdmBopInformation, // 20, not implemented
            SystemFileCacheInformation, // q: SYSTEM_FILECACHE_INFORMATION; s (requires SeIncreaseQuotaPrivilege) (info for WorkingSetTypeSystemCache)
            SystemPoolTagInformation, // q: SYSTEM_POOLTAG_INFORMATION
            SystemInterruptInformation, // q: SYSTEM_INTERRUPT_INFORMATION
            SystemDpcBehaviorInformation, // q: SYSTEM_DPC_BEHAVIOR_INFORMATION; s: SYSTEM_DPC_BEHAVIOR_INFORMATION (requires SeLoadDriverPrivilege)
            SystemFullMemoryInformation, // not implemented
            SystemLoadGdiDriverInformation, // s (kernel-mode only)
            SystemUnloadGdiDriverInformation, // s (kernel-mode only)
            SystemTimeAdjustmentInformation, // q: SYSTEM_QUERY_TIME_ADJUST_INFORMATION; s: SYSTEM_SET_TIME_ADJUST_INFORMATION (requires SeSystemtimePrivilege)
            SystemSummaryMemoryInformation, // not implemented
            SystemMirrorMemoryInformation, // 30, s (requires license value "Kernel-MemoryMirroringSupported") (requires SeShutdownPrivilege)
            SystemPerformanceTraceInformation, // s
            SystemObsolete0, // not implemented
            SystemExceptionInformation, // q: SYSTEM_EXCEPTION_INFORMATION
            SystemCrashDumpStateInformation, // s (requires SeDebugPrivilege)
            SystemKernelDebuggerInformation, // q: SYSTEM_KERNEL_DEBUGGER_INFORMATION
            SystemContextSwitchInformation, // q: SYSTEM_CONTEXT_SWITCH_INFORMATION
            SystemRegistryQuotaInformation, // q: SYSTEM_REGISTRY_QUOTA_INFORMATION; s (requires SeIncreaseQuotaPrivilege)
            SystemExtendServiceTableInformation, // s (requires SeLoadDriverPrivilege) // loads win32k only
            SystemPrioritySeperation, // s (requires SeTcbPrivilege)
            SystemVerifierAddDriverInformation, // 40, s (requires SeDebugPrivilege)
            SystemVerifierRemoveDriverInformation, // s (requires SeDebugPrivilege)
            SystemProcessorIdleInformation, // q: SYSTEM_PROCESSOR_IDLE_INFORMATION
            SystemLegacyDriverInformation, // q: SYSTEM_LEGACY_DRIVER_INFORMATION
            SystemCurrentTimeZoneInformation, // q
            SystemLookasideInformation, // q: SYSTEM_LOOKASIDE_INFORMATION
            SystemTimeSlipNotification, // s (requires SeSystemtimePrivilege)
            SystemSessionCreate, // not implemented
            SystemSessionDetach, // not implemented
            SystemSessionInformation, // not implemented
            SystemRangeStartInformation, // 50, q
            SystemVerifierInformation, // q: SYSTEM_VERIFIER_INFORMATION; s (requires SeDebugPrivilege)
            SystemVerifierThunkExtend, // s (kernel-mode only)
            SystemSessionProcessInformation, // q: SYSTEM_SESSION_PROCESS_INFORMATION
            SystemLoadGdiDriverInSystemSpace, // s (kernel-mode only) (same as SystemLoadGdiDriverInformation)
            SystemNumaProcessorMap, // q
            SystemPrefetcherInformation, // q: PREFETCHER_INFORMATION; s: PREFETCHER_INFORMATION // PfSnQueryPrefetcherInformation
            SystemExtendedProcessInformation, // q: SYSTEM_PROCESS_INFORMATION
            SystemRecommendedSharedDataAlignment, // q
            SystemComPlusPackage, // q; s
            SystemNumaAvailableMemory, // 60
            SystemProcessorPowerInformation, // q: SYSTEM_PROCESSOR_POWER_INFORMATION
            SystemEmulationBasicInformation, // q
            SystemEmulationProcessorInformation,
            SystemExtendedHandleInformation, // q: SYSTEM_HANDLE_INFORMATION_EX
            SystemLostDelayedWriteInformation, // q: ULONG
            SystemBigPoolInformation, // q: SYSTEM_BIGPOOL_INFORMATION
            SystemSessionPoolTagInformation, // q: SYSTEM_SESSION_POOLTAG_INFORMATION
            SystemSessionMappedViewInformation, // q: SYSTEM_SESSION_MAPPED_VIEW_INFORMATION
            SystemHotpatchInformation, // q; s
            SystemObjectSecurityMode, // 70, q
            SystemWatchdogTimerHandler, // s (kernel-mode only)
            SystemWatchdogTimerInformation, // q (kernel-mode only); s (kernel-mode only)
            SystemLogicalProcessorInformation, // q: SYSTEM_LOGICAL_PROCESSOR_INFORMATION
            SystemWow64SharedInformationObsolete, // not implemented
            SystemRegisterFirmwareTableInformationHandler, // s (kernel-mode only)
            SystemFirmwareTableInformation, // not implemented
            SystemModuleInformationEx, // q: RTL_PROCESS_MODULE_INFORMATION_EX
            SystemVerifierTriageInformation, // not implemented
            SystemSuperfetchInformation, // q: SUPERFETCH_INFORMATION; s: SUPERFETCH_INFORMATION // PfQuerySuperfetchInformation
            SystemMemoryListInformation, // 80, q: SYSTEM_MEMORY_LIST_INFORMATION; s: SYSTEM_MEMORY_LIST_COMMAND (requires SeProfileSingleProcessPrivilege)
            SystemFileCacheInformationEx, // q: SYSTEM_FILECACHE_INFORMATION; s (requires SeIncreaseQuotaPrivilege) (same as SystemFileCacheInformation)
            SystemThreadPriorityClientIdInformation, // s: SYSTEM_THREAD_CID_PRIORITY_INFORMATION (requires SeIncreaseBasePriorityPrivilege)
            SystemProcessorIdleCycleTimeInformation, // q: SYSTEM_PROCESSOR_IDLE_CYCLE_TIME_INFORMATION[]
            SystemVerifierCancellationInformation, // not implemented // name:wow64:whNT32QuerySystemVerifierCancellationInformation
            SystemProcessorPowerInformationEx, // not implemented
            SystemRefTraceInformation, // q; s // ObQueryRefTraceInformation
            SystemSpecialPoolInformation, // q; s (requires SeDebugPrivilege) // MmSpecialPoolTag, then MmSpecialPoolCatchOverruns != 0
            SystemProcessIdInformation, // q: SYSTEM_PROCESS_ID_INFORMATION
            SystemErrorPortInformation, // s (requires SeTcbPrivilege)
            SystemBootEnvironmentInformation, // 90, q: SYSTEM_BOOT_ENVIRONMENT_INFORMATION
            SystemHypervisorInformation, // q; s (kernel-mode only)
            SystemVerifierInformationEx, // q; s
            SystemTimeZoneInformation, // s (requires SeTimeZonePrivilege)
            SystemImageFileExecutionOptionsInformation, // s: SYSTEM_IMAGE_FILE_EXECUTION_OPTIONS_INFORMATION (requires SeTcbPrivilege)
            SystemCoverageInformation, // q; s // name:wow64:whNT32QuerySystemCoverageInformation; ExpCovQueryInformation
            SystemPrefetchPatchInformation, // not implemented
            SystemVerifierFaultsInformation, // s (requires SeDebugPrivilege)
            SystemSystemPartitionInformation, // q: SYSTEM_SYSTEM_PARTITION_INFORMATION
            SystemSystemDiskInformation, // q: SYSTEM_SYSTEM_DISK_INFORMATION
            SystemProcessorPerformanceDistribution, // 100, q: SYSTEM_PROCESSOR_PERFORMANCE_DISTRIBUTION
            SystemNumaProximityNodeInformation, // q
            SystemDynamicTimeZoneInformation, // q; s (requires SeTimeZonePrivilege)
            SystemCodeIntegrityInformation, // q // SeCodeIntegrityQueryInformation
            SystemProcessorMicrocodeUpdateInformation, // s
            SystemProcessorBrandString, // q // HaliQuerySystemInformation -> HalpGetProcessorBrandString, info class 23
            SystemVirtualAddressInformation, // q: SYSTEM_VA_LIST_INFORMATION[]; s: SYSTEM_VA_LIST_INFORMATION[] (requires SeIncreaseQuotaPrivilege) // MmQuerySystemVaInformation
            SystemLogicalProcessorAndGroupInformation, // q: SYSTEM_LOGICAL_PROCESSOR_INFORMATION_EX // since WIN7 // KeQueryLogicalProcessorRelationship
            SystemProcessorCycleTimeInformation, // q: SYSTEM_PROCESSOR_CYCLE_TIME_INFORMATION[]
            SystemStoreInformation, // q; s // SmQueryStoreInformation
            SystemRegistryAppendString, // 110, s: SYSTEM_REGISTRY_APPEND_STRING_PARAMETERS
            SystemAitSamplingValue, // s: ULONG (requires SeProfileSingleProcessPrivilege)
            SystemVhdBootInformation, // q: SYSTEM_VHD_BOOT_INFORMATION
            SystemCpuQuotaInformation, // q; s // PsQueryCpuQuotaInformation
            SystemNativeBasicInformation, // not implemented
            SystemSpare1, // not implemented
            SystemLowPriorityIoInformation, // q: SYSTEM_LOW_PRIORITY_IO_INFORMATION
            SystemTpmBootEntropyInformation, // q: TPM_BOOT_ENTROPY_NT_RESULT // ExQueryTpmBootEntropyInformation
            SystemVerifierCountersInformation, // q: SYSTEM_VERIFIER_COUNTERS_INFORMATION
            SystemPagedPoolInformationEx, // q: SYSTEM_FILECACHE_INFORMATION; s (requires SeIncreaseQuotaPrivilege) (info for WorkingSetTypePagedPool)
            SystemSystemPtesInformationEx, // 120, q: SYSTEM_FILECACHE_INFORMATION; s (requires SeIncreaseQuotaPrivilege) (info for WorkingSetTypeSystemPtes)
            SystemNodeDistanceInformation, // q
            SystemAcpiAuditInformation, // q: SYSTEM_ACPI_AUDIT_INFORMATION // HaliQuerySystemInformation -> HalpAuditQueryResults, info class 26
            SystemBasicPerformanceInformation, // q: SYSTEM_BASIC_PERFORMANCE_INFORMATION // name:wow64:whNtQuerySystemInformation_SystemBasicPerformanceInformation
            SystemQueryPerformanceCounterInformation, // q: SYSTEM_QUERY_PERFORMANCE_COUNTER_INFORMATION // since WIN7 SP1
            SystemSessionBigPoolInformation, // since WIN8
            SystemBootGraphicsInformation,
            SystemScrubPhysicalMemoryInformation,
            SystemBadPageInformation,
            SystemProcessorProfileControlArea,
            SystemCombinePhysicalMemoryInformation, // 130
            SystemEntropyInterruptTimingCallback,
            SystemConsoleInformation,
            SystemPlatformBinaryInformation,
            SystemThrottleNotificationInformation,
            SystemHypervisorProcessorCountInformation,
            SystemDeviceDataInformation,
            SystemDeviceDataEnumerationInformation,
            SystemMemoryTopologyInformation,
            SystemMemoryChannelInformation,
            SystemBootLogoInformation, // 140
            SystemProcessorPerformanceInformationEx, // since WINBLUE
            SystemSpare0,
            SystemSecureBootPolicyInformation,
            SystemPageFileInformationEx,
            SystemSecureBootInformation,
            SystemEntropyInterruptTimingRawInformation,
            SystemPortableWorkspaceEfiLauncherInformation,
            SystemFullProcessInformation, // q: SYSTEM_PROCESS_INFORMATION with SYSTEM_PROCESS_INFORMATION_EXTENSION (requires admin)
            SystemKernelDebuggerInformationEx,
            SystemBootMetadataInformation, // 150
            SystemSoftRebootInformation,
            SystemElamCertificateInformation,
            SystemOfflineDumpConfigInformation,
            SystemProcessorFeaturesInformation,
            SystemRegistryReconciliationInformation,
            SystemEdidInformation,
            MaxSystemInfoClass
        }

        public enum ThreadInformationClass
        {
            ThreadBasicInformation = 0,
            ThreadTimes = 1,
            ThreadPriority = 2,
            ThreadBasePriority = 3,
            ThreadAffinityMask = 4,
            ThreadImpersonationToken = 5,
            ThreadDescriptorTableEntry = 6,
            ThreadEnableAlignmentFaultFixup = 7,
            ThreadEventPair_Reusable = 8,
            ThreadQuerySetWin32StartAddress = 9,
            ThreadZeroTlsCell = 10,
            ThreadPerformanceCount = 11,
            ThreadAmILastThread = 12,
            ThreadIdealProcessor = 13,
            ThreadPriorityBoost = 14,
            ThreadSetTlsArrayAddress = 15,   // Obsolete
            ThreadIsIoPending = 16,
            ThreadHideFromDebugger = 17,
            ThreadBreakOnTermination = 18,
            ThreadSwitchLegacyState = 19,
            ThreadIsTerminated = 20,
            ThreadLastSystemCall = 21,
            ThreadIoPriority = 22,
            ThreadCycleTime = 23,
            ThreadPagePriority = 24,
            ThreadActualBasePriority = 25,
            ThreadTebInformation = 26,
            ThreadCSwitchMon = 27,   // Obsolete
            ThreadCSwitchPmu = 28,
            ThreadWow64Context = 29,
            ThreadGroupInformation = 30,
            ThreadUmsInformation = 31,   // UMS
            ThreadCounterProfiling = 32,
            ThreadIdealProcessorEx = 33,
            ThreadCpuAccountingInformation = 34,
            ThreadSuspendCount = 35,
            ThreadDescription = 38,
            ThreadActualGroupAffinity = 41,
            ThreadDynamicCodePolicy = 42,
        }

        [Flags]
        public enum ThreadAccess : int
        {
            TERMINATE = (0x0001),
            SUSPEND_RESUME = (0x0002),
            GET_CONTEXT = (0x0008),
            SET_CONTEXT = (0x0010),
            SET_INFORMATION = (0x0020),
            QUERY_INFORMATION = (0x0040),
            SET_THREAD_TOKEN = (0x0080),
            IMPERSONATE = (0x0100),
            DIRECT_IMPERSONATION = (0x0200)
        }

        [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        public struct SYSTEM_KERNEL_DEBUGGER_INFORMATION
        {
            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.U1)]
            public bool KernelDebuggerEnabled;

            [System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.U1)]
            public bool KernelDebuggerNotPresent;
        }
    }
}

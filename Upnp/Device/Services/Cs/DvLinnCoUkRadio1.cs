using System;
using System.Runtime.InteropServices;
using System.Text;
using Zapp;

namespace Zapp
{
    public class DvProviderLinnCoUkRadio1 : DvProvider, IDisposable
    {
        [DllImport("DvLinnCoUkRadio1")]
        static extern uint DvProviderLinnCoUkRadio1Create(uint aDeviceHandle);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1Destroy(uint aHandle);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe int DvProviderLinnCoUkRadio1SetPropertyChannelUri(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe void DvProviderLinnCoUkRadio1GetPropertyChannelUri(uint aHandle, char** aValue);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe int DvProviderLinnCoUkRadio1SetPropertyChannelMetadata(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe void DvProviderLinnCoUkRadio1GetPropertyChannelMetadata(uint aHandle, char** aValue);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe int DvProviderLinnCoUkRadio1SetPropertyTransportState(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe void DvProviderLinnCoUkRadio1GetPropertyTransportState(uint aHandle, char** aValue);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe int DvProviderLinnCoUkRadio1SetPropertyProtocolInfo(uint aHandle, char* aValue, uint* aChanged);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe void DvProviderLinnCoUkRadio1GetPropertyProtocolInfo(uint aHandle, char** aValue);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe int DvProviderLinnCoUkRadio1SetPropertyId(uint aHandle, uint aValue, uint* aChanged);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe void DvProviderLinnCoUkRadio1GetPropertyId(uint aHandle, uint* aValue);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe int DvProviderLinnCoUkRadio1SetPropertyIdArray(uint aHandle, char* aValue, int aValueLen, uint* aChanged);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe void DvProviderLinnCoUkRadio1GetPropertyIdArray(uint aHandle, char** aValue, int* aValueLen);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe int DvProviderLinnCoUkRadio1SetPropertyIdsMax(uint aHandle, uint aValue, uint* aChanged);
        [DllImport("DvLinnCoUkRadio1")]
        static extern unsafe void DvProviderLinnCoUkRadio1GetPropertyIdsMax(uint aHandle, uint* aValue);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionPlay(uint aHandle, CallbackPlay aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionPause(uint aHandle, CallbackPause aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionStop(uint aHandle, CallbackStop aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionSeekSecondAbsolute(uint aHandle, CallbackSeekSecondAbsolute aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionSeekSecondRelative(uint aHandle, CallbackSeekSecondRelative aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionChannel(uint aHandle, CallbackChannel aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionSetChannel(uint aHandle, CallbackSetChannel aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionProtocolInfo(uint aHandle, CallbackProtocolInfo aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionTransportState(uint aHandle, CallbackTransportState aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionId(uint aHandle, CallbackId aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionSetId(uint aHandle, CallbackSetId aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionRead(uint aHandle, CallbackRead aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionReadList(uint aHandle, CallbackReadList aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionIdArray(uint aHandle, CallbackIdArray aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionIdArrayChanged(uint aHandle, CallbackIdArrayChanged aCallback, IntPtr aPtr);
        [DllImport("DvLinnCoUkRadio1")]
        static extern void DvProviderLinnCoUkRadio1EnableActionIdsMax(uint aHandle, CallbackIdsMax aCallback, IntPtr aPtr);
        [DllImport("ZappUpnp")]
        static extern unsafe void ZappFree(void* aPtr);

        private unsafe delegate int CallbackPlay(IntPtr aPtr, uint aVersion);
        private unsafe delegate int CallbackPause(IntPtr aPtr, uint aVersion);
        private unsafe delegate int CallbackStop(IntPtr aPtr, uint aVersion);
        private unsafe delegate int CallbackSeekSecondAbsolute(IntPtr aPtr, uint aVersion, uint aaSecond);
        private unsafe delegate int CallbackSeekSecondRelative(IntPtr aPtr, uint aVersion, int aaSecond);
        private unsafe delegate int CallbackChannel(IntPtr aPtr, uint aVersion, char** aaUri, char** aaMetadata);
        private unsafe delegate int CallbackSetChannel(IntPtr aPtr, uint aVersion, char* aaUri, char* aaMetadata);
        private unsafe delegate int CallbackProtocolInfo(IntPtr aPtr, uint aVersion, char** aaInfo);
        private unsafe delegate int CallbackTransportState(IntPtr aPtr, uint aVersion, char** aaState);
        private unsafe delegate int CallbackId(IntPtr aPtr, uint aVersion, uint* aaId);
        private unsafe delegate int CallbackSetId(IntPtr aPtr, uint aVersion, uint aaId, char* aaUri);
        private unsafe delegate int CallbackRead(IntPtr aPtr, uint aVersion, uint aaId, char** aaMetadata);
        private unsafe delegate int CallbackReadList(IntPtr aPtr, uint aVersion, char* aaIdList, char** aaMetadataList);
        private unsafe delegate int CallbackIdArray(IntPtr aPtr, uint aVersion, uint* aaIdArrayToken, char** aaIdArray, int* aaIdArrayLen);
        private unsafe delegate int CallbackIdArrayChanged(IntPtr aPtr, uint aVersion, uint aaIdArrayToken, int* aaIdArrayChanged);
        private unsafe delegate int CallbackIdsMax(IntPtr aPtr, uint aVersion, uint* aaIdsMax);

        private GCHandle iGch;
        private CallbackPlay iCallbackPlay;
        private CallbackPause iCallbackPause;
        private CallbackStop iCallbackStop;
        private CallbackSeekSecondAbsolute iCallbackSeekSecondAbsolute;
        private CallbackSeekSecondRelative iCallbackSeekSecondRelative;
        private CallbackChannel iCallbackChannel;
        private CallbackSetChannel iCallbackSetChannel;
        private CallbackProtocolInfo iCallbackProtocolInfo;
        private CallbackTransportState iCallbackTransportState;
        private CallbackId iCallbackId;
        private CallbackSetId iCallbackSetId;
        private CallbackRead iCallbackRead;
        private CallbackReadList iCallbackReadList;
        private CallbackIdArray iCallbackIdArray;
        private CallbackIdArrayChanged iCallbackIdArrayChanged;
        private CallbackIdsMax iCallbackIdsMax;

        public DvProviderLinnCoUkRadio1(DvDevice aDevice)
        {
            iHandle = DvProviderLinnCoUkRadio1Create(aDevice.Handle()); 
            iGch = GCHandle.Alloc(this);
        }

        public unsafe bool SetPropertyChannelUri(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderLinnCoUkRadio1SetPropertyChannelUri(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyChannelUri(out string aValue)
        {
            char* value;
            DvProviderLinnCoUkRadio1GetPropertyChannelUri(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyChannelMetadata(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderLinnCoUkRadio1SetPropertyChannelMetadata(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyChannelMetadata(out string aValue)
        {
            char* value;
            DvProviderLinnCoUkRadio1GetPropertyChannelMetadata(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyTransportState(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderLinnCoUkRadio1SetPropertyTransportState(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyTransportState(out string aValue)
        {
            char* value;
            DvProviderLinnCoUkRadio1GetPropertyTransportState(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyProtocolInfo(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int err = DvProviderLinnCoUkRadio1SetPropertyProtocolInfo(iHandle, value, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyProtocolInfo(out string aValue)
        {
            char* value;
            DvProviderLinnCoUkRadio1GetPropertyProtocolInfo(iHandle, &value);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value);
            ZappFree(value);
        }

        public unsafe bool SetPropertyId(uint aValue)
        {
        uint changed;
            if (0 != DvProviderLinnCoUkRadio1SetPropertyId(iHandle, aValue, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyId(out uint aValue)
        {
            fixed (uint* value = &aValue)
			{
                DvProviderLinnCoUkRadio1GetPropertyId(iHandle, value);
            }
        }

        public unsafe bool SetPropertyIdArray(string aValue)
        {
        uint changed;
            char* value = (char*)Marshal.StringToHGlobalAnsi(aValue).ToPointer();
            int valueLen = aValue.Length;
            int err = DvProviderLinnCoUkRadio1SetPropertyIdArray(iHandle, value, valueLen, &changed);
            Marshal.FreeHGlobal((IntPtr)value);
            if (err != 0)
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyIdArray(out string aValue)
        {
            char* value;
            int valueLen;
             DvProviderLinnCoUkRadio1GetPropertyIdArray(iHandle, &value, &valueLen);
            aValue = Marshal.PtrToStringAnsi((IntPtr)value, valueLen);
            ZappFree(value);
        }

        public unsafe bool SetPropertyIdsMax(uint aValue)
        {
        uint changed;
            if (0 != DvProviderLinnCoUkRadio1SetPropertyIdsMax(iHandle, aValue, &changed))
            {
                throw(new PropertyUpdateError());
            }
            return (changed != 0);
        }

        public unsafe void GetPropertyIdsMax(out uint aValue)
        {
            fixed (uint* value = &aValue)
			{
                DvProviderLinnCoUkRadio1GetPropertyIdsMax(iHandle, value);
            }
        }

        protected unsafe void EnableActionPlay()
        {
            iCallbackPlay = new CallbackPlay(DoPlay);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionPlay(iHandle, iCallbackPlay, ptr);
        }

        protected unsafe void EnableActionPause()
        {
            iCallbackPause = new CallbackPause(DoPause);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionPause(iHandle, iCallbackPause, ptr);
        }

        protected unsafe void EnableActionStop()
        {
            iCallbackStop = new CallbackStop(DoStop);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionStop(iHandle, iCallbackStop, ptr);
        }

        protected unsafe void EnableActionSeekSecondAbsolute()
        {
            iCallbackSeekSecondAbsolute = new CallbackSeekSecondAbsolute(DoSeekSecondAbsolute);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionSeekSecondAbsolute(iHandle, iCallbackSeekSecondAbsolute, ptr);
        }

        protected unsafe void EnableActionSeekSecondRelative()
        {
            iCallbackSeekSecondRelative = new CallbackSeekSecondRelative(DoSeekSecondRelative);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionSeekSecondRelative(iHandle, iCallbackSeekSecondRelative, ptr);
        }

        protected unsafe void EnableActionChannel()
        {
            iCallbackChannel = new CallbackChannel(DoChannel);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionChannel(iHandle, iCallbackChannel, ptr);
        }

        protected unsafe void EnableActionSetChannel()
        {
            iCallbackSetChannel = new CallbackSetChannel(DoSetChannel);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionSetChannel(iHandle, iCallbackSetChannel, ptr);
        }

        protected unsafe void EnableActionProtocolInfo()
        {
            iCallbackProtocolInfo = new CallbackProtocolInfo(DoProtocolInfo);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionProtocolInfo(iHandle, iCallbackProtocolInfo, ptr);
        }

        protected unsafe void EnableActionTransportState()
        {
            iCallbackTransportState = new CallbackTransportState(DoTransportState);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionTransportState(iHandle, iCallbackTransportState, ptr);
        }

        protected unsafe void EnableActionId()
        {
            iCallbackId = new CallbackId(DoId);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionId(iHandle, iCallbackId, ptr);
        }

        protected unsafe void EnableActionSetId()
        {
            iCallbackSetId = new CallbackSetId(DoSetId);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionSetId(iHandle, iCallbackSetId, ptr);
        }

        protected unsafe void EnableActionRead()
        {
            iCallbackRead = new CallbackRead(DoRead);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionRead(iHandle, iCallbackRead, ptr);
        }

        protected unsafe void EnableActionReadList()
        {
            iCallbackReadList = new CallbackReadList(DoReadList);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionReadList(iHandle, iCallbackReadList, ptr);
        }

        protected unsafe void EnableActionIdArray()
        {
            iCallbackIdArray = new CallbackIdArray(DoIdArray);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionIdArray(iHandle, iCallbackIdArray, ptr);
        }

        protected unsafe void EnableActionIdArrayChanged()
        {
            iCallbackIdArrayChanged = new CallbackIdArrayChanged(DoIdArrayChanged);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionIdArrayChanged(iHandle, iCallbackIdArrayChanged, ptr);
        }

        protected unsafe void EnableActionIdsMax()
        {
            iCallbackIdsMax = new CallbackIdsMax(DoIdsMax);
            IntPtr ptr = GCHandle.ToIntPtr(iGch);
            DvProviderLinnCoUkRadio1EnableActionIdsMax(iHandle, iCallbackIdsMax, ptr);
        }

        protected virtual void Play(uint aVersion)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void Pause(uint aVersion)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void Stop(uint aVersion)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SeekSecondAbsolute(uint aVersion, uint aaSecond)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SeekSecondRelative(uint aVersion, int aaSecond)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void Channel(uint aVersion, out string aaUri, out string aaMetadata)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetChannel(uint aVersion, string aaUri, string aaMetadata)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void ProtocolInfo(uint aVersion, out string aaInfo)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void TransportState(uint aVersion, out string aaState)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void Id(uint aVersion, out uint aaId)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void SetId(uint aVersion, uint aaId, string aaUri)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void Read(uint aVersion, uint aaId, out string aaMetadata)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void ReadList(uint aVersion, string aaIdList, out string aaMetadataList)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void IdArray(uint aVersion, out uint aaIdArrayToken, out string aaIdArray)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void IdArrayChanged(uint aVersion, uint aaIdArrayToken, out bool aaIdArrayChanged)
        {
            throw (new ActionDisabledError());
        }

        protected virtual void IdsMax(uint aVersion, out uint aaIdsMax)
        {
            throw (new ActionDisabledError());
        }

        private static unsafe int DoPlay(IntPtr aPtr, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            self.Play(aVersion);
            return 0;
        }

        private static unsafe int DoPause(IntPtr aPtr, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            self.Pause(aVersion);
            return 0;
        }

        private static unsafe int DoStop(IntPtr aPtr, uint aVersion)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            self.Stop(aVersion);
            return 0;
        }

        private static unsafe int DoSeekSecondAbsolute(IntPtr aPtr, uint aVersion, uint aaSecond)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            self.SeekSecondAbsolute(aVersion, aaSecond);
            return 0;
        }

        private static unsafe int DoSeekSecondRelative(IntPtr aPtr, uint aVersion, int aaSecond)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            self.SeekSecondRelative(aVersion, aaSecond);
            return 0;
        }

        private static unsafe int DoChannel(IntPtr aPtr, uint aVersion, char** aaUri, char** aaMetadata)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            string aUri;
            string aMetadata;
            self.Channel(aVersion, out aUri, out aMetadata);
            *aaUri = (char*)Marshal.StringToHGlobalAnsi(aUri).ToPointer();
            *aaMetadata = (char*)Marshal.StringToHGlobalAnsi(aMetadata).ToPointer();
            return 0;
        }

        private static unsafe int DoSetChannel(IntPtr aPtr, uint aVersion, char* aaUri, char* aaMetadata)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            string aUri = Marshal.PtrToStringAnsi((IntPtr)aaUri);
            string aMetadata = Marshal.PtrToStringAnsi((IntPtr)aaMetadata);
            self.SetChannel(aVersion, aUri, aMetadata);
            return 0;
        }

        private static unsafe int DoProtocolInfo(IntPtr aPtr, uint aVersion, char** aaInfo)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            string aInfo;
            self.ProtocolInfo(aVersion, out aInfo);
            *aaInfo = (char*)Marshal.StringToHGlobalAnsi(aInfo).ToPointer();
            return 0;
        }

        private static unsafe int DoTransportState(IntPtr aPtr, uint aVersion, char** aaState)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            string aState;
            self.TransportState(aVersion, out aState);
            *aaState = (char*)Marshal.StringToHGlobalAnsi(aState).ToPointer();
            return 0;
        }

        private static unsafe int DoId(IntPtr aPtr, uint aVersion, uint* aaId)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            uint aId;
            self.Id(aVersion, out aId);
            *aaId = aId;
            return 0;
        }

        private static unsafe int DoSetId(IntPtr aPtr, uint aVersion, uint aaId, char* aaUri)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            string aUri = Marshal.PtrToStringAnsi((IntPtr)aaUri);
            self.SetId(aVersion, aaId, aUri);
            return 0;
        }

        private static unsafe int DoRead(IntPtr aPtr, uint aVersion, uint aaId, char** aaMetadata)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            string aMetadata;
            self.Read(aVersion, aaId, out aMetadata);
            *aaMetadata = (char*)Marshal.StringToHGlobalAnsi(aMetadata).ToPointer();
            return 0;
        }

        private static unsafe int DoReadList(IntPtr aPtr, uint aVersion, char* aaIdList, char** aaMetadataList)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            string aIdList = Marshal.PtrToStringAnsi((IntPtr)aaIdList);
            string aMetadataList;
            self.ReadList(aVersion, aIdList, out aMetadataList);
            *aaMetadataList = (char*)Marshal.StringToHGlobalAnsi(aMetadataList).ToPointer();
            return 0;
        }

        private static unsafe int DoIdArray(IntPtr aPtr, uint aVersion, uint* aaIdArrayToken, char** aaIdArray, int* aaIdArrayLen)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            uint aIdArrayToken;
            string aIdArray;
            self.IdArray(aVersion, out aIdArrayToken, out aIdArray);
            *aaIdArrayToken = aIdArrayToken;
            *aaIdArray = (char*)Marshal.StringToHGlobalAnsi(aIdArray).ToPointer();
            *aaIdArrayLen = aIdArray.Length;
            return 0;
        }

        private static unsafe int DoIdArrayChanged(IntPtr aPtr, uint aVersion, uint aaIdArrayToken, int* aaIdArrayChanged)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            bool aIdArrayChanged;
            self.IdArrayChanged(aVersion, aaIdArrayToken, out aIdArrayChanged);
            *aaIdArrayChanged = (aIdArrayChanged ? 1 : 0);
            return 0;
        }

        private static unsafe int DoIdsMax(IntPtr aPtr, uint aVersion, uint* aaIdsMax)
        {
            GCHandle gch = GCHandle.FromIntPtr(aPtr);
            DvProviderLinnCoUkRadio1 self = (DvProviderLinnCoUkRadio1)gch.Target;
            uint aIdsMax;
            self.IdsMax(aVersion, out aIdsMax);
            *aaIdsMax = aIdsMax;
            return 0;
        }


        public void Dispose()
        {
            DoDispose();
            GC.SuppressFinalize(this);
        }

        ~DvProviderLinnCoUkRadio1()
        {
            DoDispose();
        }

        private void DoDispose()
        {
            uint handle;
            lock (this)
            {
                if (iHandle == 0)
                {
                    return;
                }
                handle = iHandle;
                iHandle = 0;
            }
            DvProviderLinnCoUkRadio1Destroy(handle);
            if (iGch.IsAllocated)
            {
                iGch.Free();
            }
        }
    }
}


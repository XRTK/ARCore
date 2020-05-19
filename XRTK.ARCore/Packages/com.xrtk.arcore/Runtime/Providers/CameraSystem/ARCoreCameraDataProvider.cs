// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Attributes;
using XRTK.Definitions.CameraSystem;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.CameraSystem;
using XRTK.Providers.CameraSystem;

namespace XRTK.ARCore.Providers.CameraSystem
{
    [RuntimePlatform(typeof(ARCorePlatform))]
    [System.Runtime.InteropServices.Guid("aae94bd9-d363-4cc2-82b8-5b9d27f2bbee")]
    public class ARCoreCameraDataProvider : BaseCameraDataProvider
    {
        /// <inheritdoc />
        public ARCoreCameraDataProvider(string name, uint priority, BaseMixedRealityCameraDataProviderProfile profile, IMixedRealityCameraSystem parentService)
            : base(name, priority, profile, parentService)
        {
        }
    }
}
// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Attributes;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.InputSystem;
using XRTK.ARCore.Profiles;
using XRTK.Providers.Controllers;

namespace XRTK.ARCore.Providers.Controllers
{
    [RuntimePlatform(typeof(ARCorePlatform))]
    [System.Runtime.InteropServices.Guid("3955aa79-16ea-4f94-9385-f047f9b956f2")]
    public class ARCoreControllerDataProvider : BaseControllerDataProvider
    {
        /// <inheritdoc />
        public ARCoreControllerDataProvider(string name, uint priority, ARCoreControllerDataProviderProfile profile, IMixedRealityInputSystem parentService)
            : base(name, priority, profile, parentService)
        {
        }
    }
}

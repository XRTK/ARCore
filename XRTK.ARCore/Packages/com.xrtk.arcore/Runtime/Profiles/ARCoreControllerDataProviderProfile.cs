// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Definitions.Controllers;
using XRTK.Definitions.Utilities;
using XRTK.ARCore.Providers.Controllers;

namespace XRTK.ARCore.Profiles
{
    public class ARCoreControllerDataProviderProfile : BaseMixedRealityControllerDataProviderProfile
    {
        public override ControllerDefinition[] GetDefaultControllerOptions()
        {
            return new[]
            {
                new ControllerDefinition(typeof(ARCoreController), Handedness.Left),
                new ControllerDefinition(typeof(ARCoreController), Handedness.Right)
            };
        }
    }
}

// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace XRTK.Definitions.Platforms
{
    /// <summary>
    /// Used by the XRTK to signal that the feature is available on the ARCore platform.
    /// </summary>
    [System.Runtime.InteropServices.Guid("01770abd-c0af-4c64-8bea-7e2381a61f40")]
    public class ARCorePlatform : BasePlatform
    {
        /// <inheritdoc />
        public override bool IsAvailable
        {
            get
            {
                return false;
            }
        }

        /// <inheritdoc />
        public override bool IsBuildTargetAvailable
        {
            get
            {
                return false;
            }
        }
    }
}
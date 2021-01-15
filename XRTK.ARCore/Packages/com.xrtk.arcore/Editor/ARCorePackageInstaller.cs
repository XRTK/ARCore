// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System.IO;
using UnityEditor;
using XRTK.Editor;
using XRTK.Extensions;
using XRTK.Editor.Utilities;

namespace XRTK.ARCore.Editor
{
    [InitializeOnLoad]
    internal static class ARCorePackageInstaller
    {
        private static readonly string DefaultPath = $"{MixedRealityPreferences.ProfileGenerationPath}ARCore";
        private static readonly string HiddenPath = Path.GetFullPath($"{PathFinderUtility.ResolvePath<IPathFinder>(typeof(ARCorePathFinder)).ToForwardSlashes()}\\{MixedRealityPreferences.HIDDEN_PROFILES_PATH}");

        static ARCorePackageInstaller()
        {
            if (!EditorPreferences.Get($"{nameof(ARCorePackageInstaller)}", false))
            {
                EditorPreferences.Set($"{nameof(ARCorePackageInstaller)}", PackageInstaller.TryInstallAssets(HiddenPath, DefaultPath));
            }
        }
    }
}
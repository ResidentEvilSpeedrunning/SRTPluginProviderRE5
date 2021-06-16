using SRTPluginBase;
using System;

namespace SRTPluginProviderRE5
{
    internal class PluginInfo : IPluginInfo
    {
        public string Name => "Game Memory Provider (Resident Evil 5 (2008))";

        public string Description => "A game memory provider plugin for Resident Evil 5 (2008).";

        public string Author => "Mysterion_06_, VideoGameRoulette & Squirrelies";

        public Uri MoreInfoURL => new Uri("https://github.com/Mysterion06/SRTPluginProviderRE5");

        public int VersionMajor => assemblyFileVersion.ProductMajorPart;

        public int VersionMinor => assemblyFileVersion.ProductMinorPart;

        public int VersionBuild => assemblyFileVersion.ProductBuildPart;

        public int VersionRevision => assemblyFileVersion.ProductPrivatePart;

        private System.Diagnostics.FileVersionInfo assemblyFileVersion = System.Diagnostics.FileVersionInfo.GetVersionInfo(System.Reflection.Assembly.GetExecutingAssembly().Location);
    }
}

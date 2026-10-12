using System.Reflection;
using MelonLoader;

[assembly: AssemblyTitle(ModTemplate.BuildInfo.Description)]
[assembly: AssemblyDescription(ModTemplate.BuildInfo.Description)]
[assembly: AssemblyCompany(ModTemplate.BuildInfo.Company)]
[assembly: AssemblyProduct(ModTemplate.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + ModTemplate.BuildInfo.Author)]
[assembly: AssemblyTrademark(ModTemplate.BuildInfo.Company)]
[assembly: AssemblyVersion(ModTemplate.BuildInfo.Version)]
[assembly: AssemblyFileVersion(ModTemplate.BuildInfo.Version)]
[assembly: MelonInfo(typeof(ModTemplate.ModTemplate), ModTemplate.BuildInfo.Name, ModTemplate.BuildInfo.Version, ModTemplate.BuildInfo.Author, ModTemplate.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame("CuriousOwlGames", "StellarDrive")]
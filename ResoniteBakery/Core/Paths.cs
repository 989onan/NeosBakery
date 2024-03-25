using System;
using System.IO;

using Newtonsoft.Json;

namespace ResoniteBakery.Core
{
    static class Paths
    {
        public static readonly string AssetsPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\Assets\\";
        public static readonly string OutputPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\Output\\";

        public static readonly string MeshesPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\Assets\\Meshes\\";
        public static readonly string MaterialsPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\Assets\\Materials\\";
        public static readonly string TexturesPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\Assets\\Textures\\";

        public static readonly string BakeJobPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\BakeJob.json";
        public static readonly string BakePyPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\bake.py";

        public static string BlenderPath { get; private set; } = @"C:\\Program Files\\Blender Foundation\\Blender 3.0\\blender.exe";
        public static void SetBlenderPath(string newPath)
        {
            BlenderPath = newPath;
            File.WriteAllText(ConfigPath, JsonConvert.SerializeObject(new Config(newPath), Formatting.Indented));
        }
        public static readonly string BakeSettingsPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\BakeSettings.json";
        public static readonly string ConfigPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\Config.json";

        static Paths()
        {
            if (File.Exists(ConfigPath))
            {
                BlenderPath = JsonConvert.DeserializeObject<Config>(File.ReadAllText(ConfigPath)).BlenderPath;
            }
            else
            {
                File.WriteAllText(ConfigPath, JsonConvert.SerializeObject(new Config(@"C:\\Program Files\\Blender Foundation\\Blender 3.0\\blender.exe"), Formatting.Indented));
            }
        }

        public static void EnsureAllPathsExist()
        {
            if (!Directory.Exists(AssetsPath))
            {
                Directory.CreateDirectory(AssetsPath);
            }
            if (!Directory.Exists(OutputPath))
            {
                Directory.CreateDirectory(OutputPath);
            }
            if (!Directory.Exists(MeshesPath))
            {
                Directory.CreateDirectory(MeshesPath);
            }
            if (!Directory.Exists(TexturesPath))
            {
                Directory.CreateDirectory(TexturesPath);
            }
            if (!Directory.Exists(MaterialsPath))
            {
                Directory.CreateDirectory(MaterialsPath);
            }
        }
        public static void RegeneratePath(string path)
        {
            Directory.Delete(path, true);
            Directory.CreateDirectory(path);
        }

        struct Config
        {
            public string BlenderPath;

            public Config(string blenderPath)
            {
                BlenderPath = blenderPath;
            }
        }
    }
}

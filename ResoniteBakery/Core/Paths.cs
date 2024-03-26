using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
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

        public static readonly string BakeSettingsPath = AppDomain.CurrentDomain.BaseDirectory + @"\\rml_mods\\_ResoniteBakery\\BakeSettings.json";

        static Paths()
        {
        }

        public static void EnsureAllPathsExist()
        {
            foreach(string directory in new string[]{ AssetsPath, OutputPath, MeshesPath, MaterialsPath, TexturesPath}){
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
            }
            foreach(string filename in new string[] { BakePyPath})
            {
                //https://stackoverflow.com/a/32009301
                //this generates the files as resources that we have like our python file into real files on the disk to use when doing blender baking.
                Directory.CreateDirectory(Path.GetDirectoryName(filename));
                File.WriteAllText(filename, System.Text.Encoding.Default.GetString(Properties.Resources.bake));
                
            }
        }
        public static void RegeneratePath(string path)
        {
            Directory.Delete(path, true);
            Directory.CreateDirectory(path);
        }

    }
}

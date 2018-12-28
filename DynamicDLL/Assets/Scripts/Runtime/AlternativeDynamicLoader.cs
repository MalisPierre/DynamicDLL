using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StaticModule;
using StaticModule.PluginNamespace;
using System.Reflection;
using System;
using System.IO;
using UnityEditor;

public class AlternativeDynamicLoader : MonoBehaviour
{
    [SerializeField]
    private List<Plugin> _Plugins;
    // Use this for initialization

    private string[] PluginsToOpen()
    {
        string[] Paths = { };

        return Paths;
    }

    static byte[] loadFile(string filename)
    {
        FileStream fs = new FileStream(filename, FileMode.Open);
        byte[] buffer = new byte[(int)fs.Length];
        fs.Read(buffer, 0, buffer.Length);
        fs.Close();

        return buffer;
    }

    Assembly AddAssemblyToDomain(string AssemblyPath)
    {
        byte[] rawAssembly = loadFile(AssemblyPath);
        return AppDomain.CurrentDomain.Load(rawAssembly);
    }

    void DebugAssembly()
    {
        Debug.Log("Debbuging Assemblies ...");
        var assemblies = AppDomain.CurrentDomain.GetAssemblies();
        foreach (Assembly assembly in assemblies)
        {
            if (assembly.GetName().ToString().Contains("Unity"))
            {

            }
            else if (assembly.GetName().ToString().Contains("Dungeon"))
            {
                Debug.Log("Assembly[" + assembly.Location + "]");
                Debug.Log("---{" + assembly.GetTypes()[0].Namespace + "}{" + assembly.GetTypes()[0].Name + "}");
                Debug.Log("---{" + assembly.GetTypes()[1].Namespace + "}{" + assembly.GetTypes()[1].Name + "}");
            }
            else
            {
                Debug.Log("Assembly[" + assembly.GetName() + "]");
            }
        }
    }

    void Start()
    {
        DebugAssembly();
        this._Plugins = new List<Plugin>();


        Debug.Log("Dynamic Load DLL into Env...");
        //string TestPath = @"D:\projet\Unity\source\2018_3\DynamicDLL\Data\Plugins\DungeonSolverCore.dll";
        string TestPath = @"Data\DynamicModule.dll";

        //Loading DLL Assembly into DOMAIN !
        Assembly DynamicPlugin = AddAssemblyToDomain(TestPath);
        DebugAssembly();


        Type Loadertype = Array.Find(DynamicPlugin.GetTypes(), x => x.Name == "CustomPlugin");
        Debug.Log("Type = {" + Loadertype.Name + "}");

        var c = Activator.CreateInstance(Loadertype);
        var method = Loadertype.GetMethod("AlternativeInitialize");
        method.Invoke(c, new object[] { });

    }
}

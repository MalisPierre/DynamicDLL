using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using System;

using StaticModule;
//using DynamicModule;


public class PluginStatic : MonoBehaviour
{
/*
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
                //assembly.Location = "D:\projet\Unity\source\2018_3\ModularGames\Assets\DungeonSolverCore.dl";
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

    // Start is called before the first frame update
    void Start()
    {
        DebugAssembly();

        CustomPlugin Plug = new CustomPlugin();

        Plug.Initialize();

        Debug.Log("Finished");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    */
}

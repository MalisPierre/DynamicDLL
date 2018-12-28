using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.IO;

public class ModGameWindow : EditorWindow
{
    public int NumberOfMods()
    {
        return 35;
    }

    public int NumberOfPlugins()
    {
        return 38;
    }

    public void OnGUI()
    {
        GUILayout.Label("Mod Game", EditorStyles.boldLabel);

        //NumberOfPlugins = EditorGUILayout.IntField("Number of clones:", 42);
        GUILayout.TextField("Mods = [" + NumberOfMods() + "] Plugins = [" + NumberOfPlugins() + "]");

        if (GUILayout.Button("Edit"))
        {
            

        }
    }

    [MenuItem("ModularGames/Game Mode/Edit")]
    static void BuildAllAssetBundlesWindows()
    {
        ModGameWindow window = (ModGameWindow)GetWindow(typeof(ModGameWindow));
        window.Show();
    }
}

public class ModGame
{



}

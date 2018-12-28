using System;
using System.Collections.Generic;
using UnityEngine;
using StaticModule;
using StaticModule.PluginNamespace;
using StaticModule.BundleNamespace;
using StaticModule.ElementNamespace;
using StaticModule.AssetManagerNamespace;

namespace DynamicModule
{
    public class CustomPlugin : Plugin
    {
        public override void Initialize()
        {
            _Bundles = new List<Bundle>();
            Debug.Log("Dungeon Solver Plugin Initialized !");
            //Element Elem = Plugin.
            AddBundleDirect("plugin_core_assets");
            Debug.Log("plugin_core Loaded !");
            GameObject Prefab = GetBundle("plugin_core_assets").LoadElement("assets/content/plugin_core/plugin_core_assets/Element.prefab");
            GameObject Instance = AssetManager.Instance.InstantiateElement(Prefab, Vector3.zero);
            Instance.GetComponent<Element>().SetPosition(new Vector3(5.0f, 0.42f, 3.0f));

            GameObject Prefab2 = GetBundle("plugin_core_assets").LoadElement("assets/content/plugin_core/plugin_core_assets/Player.prefab");
            GameObject Instance2 = AssetManager.Instance.InstantiateElement(Prefab2, Vector3.zero);
            Instance2.GetComponent<PlayerScript>().Initialize();

        }

        public override void AlternativeInitialize()
        {
            _Bundles = new List<Bundle>();
            Debug.Log("Dungeon Solver Plugin Initialized !");
            //Element Elem = Plugin.
            AddBundleDirect("plugin_core_assets");
            Debug.Log("plugin_core Loaded !");
            GameObject Prefab = GetBundle("plugin_core_assets").LoadElement("assets/content/plugin_core/plugin_core_assets/Element.prefab");
            GameObject Instance = AssetManager.Instance.InstantiateElement(Prefab, Vector3.zero);
            Instance.GetComponent<Element>().SetPosition(new Vector3(5.0f, 0.42f, 3.0f));

            GameObject Prefab2 = GetBundle("plugin_core_assets").LoadElement("assets/content/plugin_core/plugin_core_assets/Player.prefab");
            GameObject Instance2 = AssetManager.Instance.InstantiateElement(Prefab2, Vector3.zero);
            Instance2.AddComponent<PlayerScript>();
            Instance2.GetComponent<PlayerScript>()._Speed = 2.0f;
            Instance2.GetComponent<PlayerScript>().Initialize();

        }

    }

}

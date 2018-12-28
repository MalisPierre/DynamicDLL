using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using StaticModule.BundleNamespace;
using System;
using System.Linq;

namespace StaticModule.PluginNamespace
{


    [System.Serializable]
    public class Plugin
    {

        [SerializeField]
        protected List<Bundle> _Bundles;

        public virtual void Initialize()
        {
            _Bundles = new List<Bundle>();
        }

        public virtual void AlternativeInitialize()
        {
            _Bundles = new List<Bundle>();
        }

        public Bundle GetBundle(string Key)
        {
            return this._Bundles.Find(x => x._Name == Key);
        }

        public void AddBundle(Bundle NewBundle)
        {
            _Bundles.Add(NewBundle);
        }


        public IEnumerator AddBundleAsync(string BundlePath)
        {
            List<AssetBundle> AlreadyLoadedInMemory = AssetBundle.GetAllLoadedAssetBundles().ToList();
            AssetBundle MyBundle = AlreadyLoadedInMemory.Find(x => x.name == BundlePath);
            if (MyBundle == null)
            {
                string FullPath = Application.dataPath + "/../Data/Bundles/" + "/" + BundlePath;
                Debug.Log("Loading Bundle [" + FullPath + "]");
                var bundleLoadRequest = AssetBundle.LoadFromFileAsync(FullPath);
                yield return bundleLoadRequest;

                if (bundleLoadRequest.assetBundle == null)
                {
                    Debug.LogError("Failed to load AssetBundle!");
                }
                this.AddBundle(Bundle.CreateBundle(bundleLoadRequest.assetBundle, BundlePath));
                yield return new WaitForSeconds(0.5f);

            }
            else
            {
                // ALREADY IN MEMORY , GET REFERENCE
                this.AddBundle(Bundle.CreateBundle(MyBundle, BundlePath));
                yield return new WaitForSeconds(0.5f);
            }

        }

        public void AddBundleDirect(string BundlePath)
        {
            List<AssetBundle> AlreadyLoadedInMemory = AssetBundle.GetAllLoadedAssetBundles().ToList();
            AssetBundle MyBundle = AlreadyLoadedInMemory.Find(x => x.name == BundlePath);
            if (MyBundle == null)
            {

                string FullPath = Application.dataPath + "/../Data/Bundles/" + "/" + BundlePath;
                Debug.Log("Loading Bundle [" + FullPath + "]");
                var bundleLoadRequest = AssetBundle.LoadFromFile(FullPath);

                if (bundleLoadRequest == null)
                {
                    Debug.LogError("Failed to load AssetBundle!");
                }
                this.AddBundle(Bundle.CreateBundle(bundleLoadRequest, BundlePath));

            }
            else
            {
                // ALREADY IN MEMORY , GET REFERENCE
                this.AddBundle(Bundle.CreateBundle(MyBundle, BundlePath));
            }

        }



    }


}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using StaticModule.ElementNamespace;

namespace StaticModule.BundleNamespace
{
    [System.Serializable]
    public class Bundle
    {
        [SerializeField]
        private AssetBundle _bundle;

        public string _Name;

        public static Bundle CreateBundle(AssetBundle NewBundle, string name)
        {
            Bundle Bund = new Bundle();
            Bund._bundle = NewBundle;
            Bund._Name = name;
            return Bund;
        }

        public GameObject LoadElement(string FilePath)
        {
            GameObject Ret = _bundle.LoadAsset<GameObject>(FilePath);
            if (Ret == null)
            {
                Debug.LogError("Element IS NULL [" + FilePath + "]");
            }
            return Ret;
        }






    }
}

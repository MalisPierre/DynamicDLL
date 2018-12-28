using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using StaticModule.ElementNamespace;
using StaticModule.BundleNamespace;

namespace StaticModule.AssetManagerNamespace
{

    public class AssetManager : MonoBehaviour
    {

        public static AssetManager Instance { get; private set; }

        void Awake()
        {

            if (Instance != null && Instance != this)
            {
                Destroy(gameObject);
            }
            Instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }


        public GameObject InstantiateElement(GameObject Prefab, Vector3 NewPos)
        {
            Debug.Log("Instantiating Element");
            Debug.Log("{" + Prefab.name + "}");
            GameObject Instance = Instantiate(
                    Prefab.gameObject,
                    NewPos,
                    Quaternion.identity) as GameObject;

            Instance.transform.name = Prefab.transform.name;
            return Instance;
        }

        public GameObject InstantiateElement(Bundle BundleRef, string FilePath, Vector3 NewPos)
        {
            GameObject Prefab = BundleRef.LoadElement(FilePath);

            return InstantiateElement(Prefab, NewPos);
        }

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StaticModule.ElementNamespace
{



    public enum ImageType
    {
        Normal,
        Cutout,
        Transparent,
        Background
    };

    public partial class Element : MonoBehaviour
    {

        public void OnEditor()
        {
            Debug.Log("On Editor [" + this.gameObject.transform.name + "]");
            //this.gameObject.GetComponent<MeshRenderer> ().sharedMaterial.SetFloat ("Intensity", 0.0f);
        }

        public void SetParent(Element Obj)
        {
            this.transform.parent = Obj.transform;
        }

        public void Hide()
        {
            this.gameObject.SetActive(false);
        }

        public void Show()
        {
            this.gameObject.SetActive(true);
        }

        public string GetTag()
        {
            return this.gameObject.tag;
        }

        public string GetLayer()
        {
            return LayerMask.LayerToName(this.gameObject.layer);
        }

        public string GetName()
        {
            return this.gameObject.name;
        }

        public void Delete()
        {
            Destroy(this.gameObject);
        }

        public virtual void Initialize()
        {

        }


    }


}


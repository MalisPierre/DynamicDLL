using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;
using StaticModule.InputManager;

namespace DynamicModule
{
    class PlayerScript : MonoBehaviour
    {
        [SerializeField]
        public float _Speed;

        public void Initialize()
        {
            Debug.Log("Initialize");
        }

        void Update()
        {
            if (InputManager.Instance.CheckInput(KeyCode.Z))
            {
                MoveForward(_Speed);
            }
            else if (InputManager.Instance.CheckInput(KeyCode.S))
            {
                MoveForward(_Speed * -1);
            }

            if (InputManager.Instance.CheckInput(KeyCode.D))
            {
                MoveRight(_Speed);
            }
            else if (InputManager.Instance.CheckInput(KeyCode.Q))
            {
                MoveRight(_Speed * -1);
            }

        }


        public void MoveUp(float Speed)
        {
            this.transform.position = this.transform.position + (new Vector3(0.0f, Speed * Time.deltaTime, 0.0f));
        }

        public void MoveRight(float Speed)
        {
            this.transform.position = this.transform.position + (new Vector3(Speed * Time.deltaTime, 0.0f, 0.0f));
        }

        public void MoveForward(float Speed)
        {
            this.transform.position = this.transform.position + (new Vector3(0.0f, 0.0f, Speed * Time.deltaTime));
        }

        public void MoveToward(Vector3 TargetPos, float Speed)
        {
            this.transform.position = Vector3.MoveTowards(this.transform.position, TargetPos, Speed * Time.deltaTime);
        }



    }
}

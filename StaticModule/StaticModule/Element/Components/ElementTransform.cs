using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StaticModule.ElementNamespace
{


    public partial class Element : MonoBehaviour
    {


        public void LookAtY(Vector3 TargetPos, Vector3 Offset)
        {
            this.transform.LookAt(new Vector3(TargetPos.x, this.transform.position.y, TargetPos.z));
            this.transform.eulerAngles = transform.eulerAngles + Offset;
        }

        public void LookAt(Vector3 TargetPos)
        {
            this.transform.rotation = Quaternion.LookRotation(TargetPos - this.transform.position);
        }

        public Vector3 GetPosition()
        {
            return this.transform.position;
        }

        public Vector3 GetlocalPosition()
        {
            return this.transform.localPosition;
        }

        public float GetRotationX()
        {
            return this.transform.eulerAngles.x;
        }

        public float GetRotationY()
        {
            return this.transform.eulerAngles.y;
        }

        public float GetRotationZ()
        {
            return this.transform.eulerAngles.z;
        }

        public void SetLocalPosition(Vector3 Pos)
        {
            this.transform.localPosition = Pos;
        }

        public void SetPosition(Vector3 Pos)
        {
            this.transform.position = Pos;
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



        public void SetScale(Vector3 Scale)
        {
            this.transform.localScale = Scale;
        }

        public Vector3 GetRotation()
        {
            return this.transform.eulerAngles;
        }

        public Quaternion GetRotationQuat()
        {
            return this.transform.rotation;
        }

        public void SetRotation(Vector3 Rot)
        {
            this.transform.eulerAngles = Rot;
        }



        public void RotateRight(float NewValue)
        {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                transform.eulerAngles.y + (NewValue * Time.deltaTime),
                0.0f
            );
        }

        public void RotateUp(float NewValue)
        {
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x - (NewValue * Time.deltaTime),
                transform.eulerAngles.y,
                0.0f
            );
        }




    }

}

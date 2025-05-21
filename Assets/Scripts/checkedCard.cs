using UnityEngine;

public class checkedCard : MonoBehaviour {

    public float speed = 0f;
    public Quaternion checkPos;
    public float angle;

    void OnMouseDown()
    {
        if (transform.localRotation.y == 0f | speed == -0.15f)
        {
            checkPos = new Quaternion(transform.localRotation.x, 1, transform.localRotation.z, transform.localRotation.w);
            speed = 0.08f;
        }
        else if(transform.localRotation.y == 1f | speed == 0.08f)
        {
            checkPos = new Quaternion(transform.localRotation.x, 0, transform.localRotation.z, transform.localRotation.w);
            speed = -0.15f;
        }
    }

    void Update()
    {
        if (transform.localRotation.y >= 0)
        {
            if (transform.localRotation.y != checkPos.y)
            {
                transform.localRotation = new Quaternion(transform.localRotation.x, transform.localRotation.y + speed, transform.localRotation.z, transform.localRotation.w);
                angle = transform.localRotation.y;
            }
            else speed = 0f;
        }
        else transform.localRotation = new Quaternion(transform.localRotation.x, 0, transform.localRotation.z, transform.localRotation.w);


        //if (rec.offsetMin.x >= checkPos)
        //{

        //}
        //else
        //{
        //    speed = 0f;
        //    checkPos = 0f;
        //}
    }
}

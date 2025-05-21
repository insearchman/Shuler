using UnityEngine;

public class MoveButtons : MonoBehaviour
{
    public bool isVisible = true;
    public Vector3 cardAng;

    float speed = 100f;

    void Update()
    {
        if (transform.eulerAngles != cardAng && isVisible)
        {
            if (transform.eulerAngles.z < cardAng.z && transform.eulerAngles.z > 320f)
            {
                transform.eulerAngles += new Vector3(0f, 0f, speed * Time.deltaTime);
            }
            else if (transform.eulerAngles.z < (cardAng.z - 360f))
            {
                transform.eulerAngles += new Vector3(0f, 0f, speed * Time.deltaTime);
            }
            else
            {
                transform.eulerAngles = cardAng;
            }
        }
        else if (transform.eulerAngles != cardAng && !isVisible)
        {
            if (transform.eulerAngles.z > (cardAng.z - 360f) && transform.eulerAngles.z < 25f)
            {
                transform.eulerAngles -= new Vector3(0f, 0f, speed * Time.deltaTime);
            }
            else if (transform.eulerAngles.z > cardAng.z)
            {
                transform.eulerAngles -= new Vector3(0f, 0f, speed * Time.deltaTime);
            }
            else
            {
                transform.eulerAngles = cardAng;
            }
        }
    }
}

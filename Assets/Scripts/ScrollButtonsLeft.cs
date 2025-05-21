using UnityEngine;

public class ScrollButtonsLeft : MonoBehaviour
{
    public float speed = 0f, checkPos = 0f;

    RectTransform rec;

	void Start ()
    {
        rec = GetComponent <RectTransform>();
	}
	
	void Update ()
    {
        if (rec.offsetMin.x >= checkPos)
        {
            rec.offsetMin += new Vector2(speed * Time.deltaTime * 100, rec.offsetMin.y);
            rec.offsetMax += new Vector2(speed * Time.deltaTime * 100, rec.offsetMax.y);
        }
        else
        {
            speed = 0f;
        }
	}
}

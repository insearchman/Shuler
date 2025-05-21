using UnityEngine;
using UnityEngine.UI;

public class HideGameName : MonoBehaviour
{
    public bool isVisible = true;

    float speed = 2.5f;
    float targetAlfa;
    Text txt;

    void Start()
    {
        txt = GetComponent<Text>();
    }

    void isMove()
    {
        switch (isVisible)
        {
            case false:
                {
                    targetAlfa = 0f;
                    break;
                }
            case true:
                {
                    targetAlfa = 1f;
                    break;
                }
        }

    }

    void Update()
    {
        isMove();
        if (txt.color.a != targetAlfa && isVisible)
        {
            if (txt.color.a < targetAlfa)
            {
                txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, txt.color.a + speed * Time.deltaTime);
            }
            else
            {
                txt.color = new Color (txt.color.r, txt.color.g, txt.color.b, targetAlfa);
            }
        }
        else if (txt.color.a != targetAlfa && !isVisible)
        {
            if (txt.color.a > targetAlfa)
            {
                txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, txt.color.a - speed * Time.deltaTime);
            }
            else
            {
                txt.color = new Color(txt.color.r, txt.color.g, txt.color.b, targetAlfa);
            }
        }
    }
}

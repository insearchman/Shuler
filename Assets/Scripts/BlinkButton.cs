using UnityEngine;
using UnityEngine.UI;

public class BlinkButton : MonoBehaviour
{
    Text txt;

	void Start ()
    {
        txt = GetComponent<Text>();
	}
	
	void Update ()
    {
        txt.color = new Color(Mathf.PingPong(Time.time*1.4f, 0.8f), txt.color.g, txt.color.b, txt.color.a);
	}
}

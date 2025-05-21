using UnityEngine;
using UnityEngine.UI;

public class SoundSwitch : MonoBehaviour
{
    [SerializeField] GameObject music;

    bool isOn = true;
    Text txt;
    AudioSource audioS;

    void Start()
    {
        txt = GetComponent<Text>();
        audioS = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        isOn = !isOn;
        switch (isOn)
        {
            case true:
                {
                    AudioListener.volume = 1.0f;
                    audioS.Play();
                    if (music.gameObject.GetComponent<MusicSwitch>().isOn)
                    {
                        music.GetComponent<AudioSource>().Play();
                    }
                    txt.color = new Color(0.7f, 0.1f, 0f, 1f);
                    txt.text = "on";
                    break;
                }
            case false:
                {
                    AudioListener.volume = 0f;
                    music.GetComponent<AudioSource>().Stop();
                    txt.text = "off";
                    txt.color = new Color(0f, 0f, 0f, 1f);
                    break;
                }
        }
    }
}
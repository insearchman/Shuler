using UnityEngine;
using UnityEngine.UI;

public class MusicSwitch : MonoBehaviour
{
    [SerializeField] AudioClip audioSoundSwitch;

    public bool isOn = false;

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
                    audioS.Play();
                    audioS.PlayOneShot(audioSoundSwitch);
                    txt.color = new Color(0.7f, 0.1f, 0f, 1f);
                    txt.text = "on";
                    break;
                }
            case false:
                {
                    audioS.Stop();
                    audioS.PlayOneShot(audioSoundSwitch);
                    txt.text = "off";
                    txt.color = new Color(0f, 0f, 0f, 1f);
                    break;
                }
        }
    }
}
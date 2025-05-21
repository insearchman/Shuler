using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    [SerializeField] GameObject startButton;

    bool isOpen = false;
    AudioSource audioS;
    new Animation animation;

    void Start()
    {
        audioS = GetComponent<AudioSource>();
        animation = transform.parent.GetComponent<Animation>();
    }

    void OnMouseDown()
    {
        if (!isOpen)
        {
            audioS.Play();

            startButton.GetComponent<MoveButtons>().cardAng.z = 335f;
            startButton.GetComponent<MoveButtons>().isVisible = false;

            animation["OptionsMenu"].speed = 200 * Time.deltaTime;
            animation.Play("OptionsMenu");

            isOpen = !isOpen;
        }
        else
        {
            audioS.Play();

            startButton.GetComponent<MoveButtons>().cardAng.z = 358f;
            startButton.GetComponent<MoveButtons>().isVisible = true;

            animation["OptionsMenu"].speed = -200 * Time.deltaTime;
            animation["OptionsMenu"].time = animation["OptionsMenu"].length;
            animation.Play("OptionsMenu");

            isOpen = !isOpen;
        }
    }
}

using UnityEngine;

public class GameChoice : MonoBehaviour
{
    [SerializeField] GameObject c36, c52, startGame, options;
    //[SerializeField] Text gameName;


    AudioSource audioS;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        //gameName.GetComponent<HideGameName>().isVisible = false;
        startGame.GetComponent<MoveButtons>().cardAng.z = 335f;
        startGame.GetComponent<MoveButtons>().isVisible = false;

        options.GetComponent<MoveButtons>().cardAng.z = 335f;
        options.GetComponent<MoveButtons>().isVisible = false;

        c36.GetComponent<MoveButtons>().enabled = true;
        c36.GetComponent<MoveButtons>().cardAng.z = 358f;
        c36.GetComponent<MoveButtons>().isVisible = true;

        c52.GetComponent<MoveButtons>().enabled = true;
        c52.GetComponent<MoveButtons>().cardAng.z = 371f;
        c52.GetComponent<MoveButtons>().isVisible = true;

        //resetButton.GetComponent<ScrollButtonsLeft>().checkPos = 0f;
        //resetButton.GetComponent<ScrollButtonsRight>().speed = 0f;
        //resetButton.GetComponent<ScrollButtonsLeft>().speed = -5f;

        //pileButton.GetComponent<ScrollButtonsLeft>().checkPos = 0f;
        //pileButton.GetComponent<ScrollButtonsRight>().speed = 0f;
        //pileButton.GetComponent<ScrollButtonsLeft>().speed = -5f;

        //menuButton.GetComponent<ScrollButtonsLeft>().checkPos = 0f;
        //menuButton.GetComponent<ScrollButtonsRight>().speed = 0f;
        //menuButton.GetComponent<ScrollButtonsLeft>().speed = -5f;

        //cards.GetComponent<ScrollButtonsRight>().checkPos = 0f;
        //cards.GetComponent<ScrollButtonsLeft>().speed = 0f;
        //cards.GetComponent<ScrollButtonsRight>().speed = 5f;

        audioS.Play();



    }
}

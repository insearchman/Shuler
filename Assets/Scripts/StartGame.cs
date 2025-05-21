using UnityEngine;
using UnityEngine.UI;
using GoogleMobileAds.Api;

public class StartGame : MonoBehaviour
{
    [SerializeField] GameObject c36, c52, resetButton, pileButton, menuButton, cards;
    [SerializeField] Text gameName;

    AudioSource audioS;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void OnMouseDown ()
    {

        gameName.GetComponent<HideGameName>().isVisible = false;
        c36.GetComponent<MoveButtons>().cardAng.z = 335f;
        c36.GetComponent<MoveButtons>().isVisible = false;
        c52.GetComponent<MoveButtons>().cardAng.z = 335f;
        c52.GetComponent<MoveButtons>().isVisible = false;

        resetButton.GetComponent<ScrollButtonsLeft>().checkPos = 0f;
        resetButton.GetComponent<ScrollButtonsRight>().speed = 0f;
        resetButton.GetComponent<ScrollButtonsLeft>().speed = -5f;
        resetButton.GetComponent<Reset>().allCards = cards.gameObject;

        pileButton.GetComponent<ScrollButtonsLeft>().checkPos = 0f;
        pileButton.GetComponent<ScrollButtonsRight>().speed = 0f;
        pileButton.GetComponent<ScrollButtonsLeft>().speed = -5f;
        pileButton.GetComponent<PileButton>().allCards = cards.gameObject;

        menuButton.GetComponent<ScrollButtonsLeft>().checkPos = 0f;
        menuButton.GetComponent<ScrollButtonsRight>().speed = 0f;
        menuButton.GetComponent<ScrollButtonsLeft>().speed = -5f;
        menuButton.GetComponent<MenuInGame>().gameType = cards.gameObject;

        cards.GetComponent<ScrollButtonsRight>().checkPos = 0f;
        cards.GetComponent<ScrollButtonsLeft>().speed = 0f;
        cards.GetComponent<ScrollButtonsRight>().speed = 5f;

        audioS.Play();
    }
}

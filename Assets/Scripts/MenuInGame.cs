using UnityEngine.UI;
using UnityEngine;
using System.Collections.Generic;

public class MenuInGame : MonoBehaviour
{
    [SerializeField] Text gameName;
    [SerializeField] GameObject startButton, optionsButton, resetButton, pileButton, menuButton;

    List<GameObject> _selectedCard;
    AudioSource audioS;

    public GameObject gameType;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    public void ResetCard()
    {
        for (int i = 0; i < gameType.GetComponent<Transform>().GetChild(0).childCount; i++)
        {
            gameType.GetComponent<Transform>().GetChild(0).GetChild(i).GetComponent<checkCard>().checkedCard = false;
            gameType.GetComponent<Transform>().GetChild(0).GetChild(i).GetComponent<checkCard>().changeSide();
            gameType.GetComponent<Transform>().GetChild(1).GetChild(i).GetComponent<checkCard>().checkedCard = false;
            gameType.GetComponent<Transform>().GetChild(1).GetChild(i).GetComponent<checkCard>().changeSide();
            gameType.GetComponent<Transform>().GetChild(2).GetChild(i).GetComponent<checkCard>().checkedCard = false;
            gameType.GetComponent<Transform>().GetChild(2).GetChild(i).GetComponent<checkCard>().changeSide();
            gameType.GetComponent<Transform>().GetChild(3).GetChild(i).GetComponent<checkCard>().checkedCard = false;
            gameType.GetComponent<Transform>().GetChild(3).GetChild(i).GetComponent<checkCard>().changeSide();
        }
    }

    public void cardReset()
    {

        for (int i = _selectedCard.Count - 1; i >= 0; i--)
        {
            _selectedCard[i].transform.GetChild(0).gameObject.SetActive(false);
            _selectedCard.Remove(_selectedCard[i]);
        }

    }

    void OnMouseDown ()
    {
        _selectedCard = gameType.GetComponent<BlinkCard>().selectedCard;
        if (_selectedCard.Count != 0)
        {
            cardReset();
        }

        ResetCard();

        gameName.GetComponent<HideGameName>().isVisible = true;
        startButton.GetComponent<MoveButtons>().cardAng.z = 358f;
        startButton.GetComponent<MoveButtons>().isVisible = true;
        optionsButton.GetComponent<MoveButtons>().cardAng.z = 371f;
        optionsButton.GetComponent<MoveButtons>().isVisible = true;

        resetButton.GetComponent<ScrollButtonsRight>().checkPos = 150f;
        resetButton.GetComponent<ScrollButtonsLeft>().speed = 0f;
        resetButton.GetComponent<ScrollButtonsRight>().speed = 5f;

        pileButton.GetComponent<ScrollButtonsRight>().checkPos = 150f;
        pileButton.GetComponent<ScrollButtonsLeft>().speed = 0f;
        pileButton.GetComponent<ScrollButtonsRight>().speed = 5f;

        menuButton.GetComponent<ScrollButtonsRight>().checkPos = 190f;
        menuButton.GetComponent<ScrollButtonsLeft>().speed = 0f;
        menuButton.GetComponent<ScrollButtonsRight>().speed = 5f;

        gameType.GetComponent<ScrollButtonsLeft>().checkPos = -260f;
        gameType.GetComponent<ScrollButtonsRight>().speed = 0f;
        gameType.GetComponent<ScrollButtonsLeft>().speed = -5f;

        audioS.Play();
    }
}

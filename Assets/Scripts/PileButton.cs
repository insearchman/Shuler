using UnityEngine;
using System.Collections.Generic;

public class PileButton : MonoBehaviour
{
    public GameObject allCards;

    List<GameObject> _selectedCard;
    AudioSource audioS;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        _selectedCard = allCards.GetComponent<BlinkCard>().selectedCard;
        if (_selectedCard.Count != 0)
        {
            cardToPile();
        }
    }

    void cardToPile()
    {
        audioS.Play();
        for (int i = _selectedCard.Count-1; i>=0; i--)
        {
            _selectedCard[i].GetComponent<checkCard>().checkedCard = true;
            _selectedCard[i].GetComponent<checkCard>().changeSide();
            _selectedCard[i].transform.GetChild(0).gameObject.SetActive(false);
            _selectedCard.Remove(_selectedCard[i]);
        }       
    }
}

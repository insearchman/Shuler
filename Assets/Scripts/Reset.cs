using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
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
            cardReset();
        }
    }

    public void cardReset()
    {
        audioS.Play();
        for (int i = _selectedCard.Count - 1; i >= 0; i--)
        {
            _selectedCard[i].transform.GetChild(0).gameObject.SetActive(false);
            _selectedCard.Remove(_selectedCard[i]);
        }
    }
}

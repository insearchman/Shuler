using UnityEngine;

public class checkCard : MonoBehaviour
{
    [SerializeField] GameObject allCards;
    [SerializeField] AudioClip audioCardCheck;
    [SerializeField] AudioClip audioCardUncheck;

    public bool checkedCard = false;

    float speed = 500f;
    int rotateWay;
    Vector3 cardAng;
    AudioSource audioS;

    private void Start()
    {
        audioS = GetComponent<AudioSource>();
    }

    void OnMouseDown()
    {
        if (!allCards.GetComponent<BlinkCard>().selectedCard.Contains(this.gameObject) & !checkedCard)
        {
            audioS.PlayOneShot(audioCardCheck);
            this.transform.GetChild(0).gameObject.SetActive(true);
            allCards.GetComponent<BlinkCard>().selectedCard.Add(this.gameObject);
        }
        else if (!checkedCard)
        {
            audioS.PlayOneShot(audioCardUncheck);
            allCards.GetComponent<BlinkCard>().selectedCard.Remove(this.gameObject);
            this.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    public void changeSide()
    {
        switch (checkedCard)
        {
            case false:
                {
                    cardAng.y = 0f;
                    rotateWay = -1;
                    break;
                }
            case true:
                {
                    cardAng.y = 180f;
                    rotateWay = 1;
                    break;
                }
        }
    }

    void Update()
    {

        if (transform.eulerAngles != cardAng && checkedCard)
        {
            if (transform.eulerAngles.y < cardAng.y)
            {
                transform.eulerAngles += new Vector3(0f, speed * rotateWay * Time.deltaTime, 0f);
            }
            else
            {
                transform.eulerAngles = cardAng;
            }
        }
        else if (transform.eulerAngles != cardAng && !checkedCard)
        {
            if (transform.eulerAngles.y > cardAng.y && transform.eulerAngles.y < 190f)
            {
                transform.eulerAngles += new Vector3(0f, speed * rotateWay * Time.deltaTime, 0f);
            }
            else
            {
                transform.eulerAngles = cardAng;
            }
        }
    }
}


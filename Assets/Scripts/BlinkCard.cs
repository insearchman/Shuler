using System.Collections.Generic;
using UnityEngine;

public class BlinkCard : MonoBehaviour
{
    public List<GameObject> selectedCard = new List<GameObject>();

    void Update()
    {
        if (selectedCard.Count > 0)
        {
            foreach (GameObject i in selectedCard)
            {
                i.transform.GetChild(0).GetComponentInChildren<MeshRenderer>().material.color = new Color(Mathf.PingPong(Time.time * 4, 1.0f), Mathf.PingPong(Time.time * 4, 1.0f), 0, 0);
            }
        }
    }
}

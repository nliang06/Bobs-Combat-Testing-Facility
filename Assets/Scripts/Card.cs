using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [Header("Card Info")]
    [SerializeField] private Sprite cardArt;
    [SerializeField] private string description;

    [Header("Card Child Objects")]
    [SerializeField] private Image cardSR;
    [SerializeField] private TextMeshProUGUI cardText;

    // Start is called before the first frame update
    void Start()
    {
        if (description == "")
        {
            description = "Description goes here";
        }
        cardText.text = description;

        if (cardArt != null)
        {
            cardSR.sprite = cardArt;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// Select this card and prepare for an action
    /// </summary>
    public void SelectCard()
    {
        Debug.Log("Card has been selected"); // stub
    }

    /// <summary>
    /// Deselect this card and cancel all associated events
    /// </summary>
    public void DeselectCard()
    {
        Debug.Log("Card has been deselected"); // stub
    }
}

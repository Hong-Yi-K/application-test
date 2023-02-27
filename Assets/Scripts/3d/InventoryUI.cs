using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI starText;
    void Start()
    {
        starText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateStarText(PlayerInventory playerInventory)
    {
        starText.text = playerInventory.NumberOfStars.ToString();
    }
}

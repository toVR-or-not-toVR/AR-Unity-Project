using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GamePlay : MonoBehaviour
{
    [SerializeField] GameObject bot;
    [SerializeField] GameObject helmet;
    [SerializeField] GameObject katana;
    [SerializeField] GameObject plant;
    [SerializeField] GameObject button;

    public int playerChoose;

    public void PlayerChoice(int choice)
    {
        playerChoose = choice;
    }

    public void deactivateModels()
    {
        if (playerChoose == 0)
        {
            helmet.SetActive(false);
            katana.SetActive(false);
            plant.SetActive(false);
        }
        if (playerChoose == 1)
        {
            bot.SetActive(false);
            katana.SetActive(false);
            plant.SetActive(false);
        }
        if (playerChoose == 2)
        {
            helmet.SetActive(false);
            bot.SetActive(false);
            plant.SetActive(false);
        }
        if (playerChoose == 3)
        {
            helmet.SetActive(false);
            katana.SetActive(false);
            bot.SetActive(false);
        }
    }
}

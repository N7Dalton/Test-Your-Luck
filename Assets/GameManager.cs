using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float chanceOfSuccess;
    public float chanceOfFailure;
    
    public TextMeshProUGUI chanceStringtext;
    public float timesClicked;
    public TextMeshProUGUI TimesClickedStringtext;
    public float MostTimeClicked;
    public TextMeshProUGUI MostTimeClickedStringtext;
    public TextMeshProUGUI DeathMessage;
    public GameObject Panellll;
    public GameObject Panellll2;
    public float LowestPercent =100;
    public TextMeshProUGUI LowestPercentText;
    // Start is called before the first frame update
    void Start()
    {
        TimesClickedStringtext.text = timesClicked.ToString();
        chanceOfSuccess = 100f;
        MostTimeClickedStringtext.text = MostTimeClicked.ToString();
    }

    // Update is called once per frame
    void Update()
    {
       chanceStringtext.text = chanceOfSuccess.ToString();
        LowestPercentText.text = LowestPercent.ToString();
        if (chanceOfSuccess >=75)
        {
            chanceStringtext.color = new Color(0, 250, 0);

        }
        else if(chanceOfSuccess <75f && chanceOfSuccess >= 50f)
        {
            chanceStringtext.color = new Color(250, 140, 0);
        }
        else
        {
            chanceStringtext.color = new Color(250, 0, 0);
        }
      
    }
    public void TakeAChance()
    {
        chanceOfFailure = Random.Range(0f,75f);
        if(chanceOfFailure > chanceOfSuccess)
        {
            Die();
        }
        else
        {
            if(chanceOfSuccess < LowestPercent)
            {
                LowestPercent = chanceOfSuccess;
            }
            chanceOfSuccess = Random.Range(0f, chanceOfSuccess);
            
        }
    }
    public void Die()
    {
        chanceOfSuccess = 100f;
        Panellll.SetActive(true);
        Panellll2.SetActive(false);
        timesClicked = 0f;
        float random = Random.Range(0, 7);
        if(random == 0)
        {
            DeathMessage.text = "you suck.";
        }
        if (random == 1)
        {
            DeathMessage.text = "you lost your entire life savings.";
        }
        if (random == 2)
        {
            DeathMessage.text = "Seriously?";
        }
        if (random == 3)
        {
            DeathMessage.text = "your now homeless";
        }
        if (random == 4)
        {
            DeathMessage.text = "L";

        }
        if (random == 5)
        {
            DeathMessage.text = "Skill Issue";
        }
        if (random == 6)
        {
            DeathMessage.text = "You can do better than that.";
        }
        if (random == 7)
        {
            DeathMessage.text = "Just give up.";
        }

    }
    public void TryAgain()
    {
        SceneManager.LoadScene("Game");
    }
    public void ButtonPressed()
    {
        timesClicked++;
        if(MostTimeClicked <= timesClicked)
        {
            MostTimeClicked = timesClicked;
            MostTimeClickedStringtext.text = MostTimeClicked.ToString();
            
        }
        TimesClickedStringtext.text = timesClicked.ToString();

    }
}
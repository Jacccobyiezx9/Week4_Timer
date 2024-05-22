using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI hpText;
    public int healthValue;
    public float poison;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hpText.text = healthValue.ToString();
    }

    public void PlayerDamage()
    {
        healthValue -= 50;
    }

    public void PoisonCountdown()
    {
        InvokeRepeating("PlayerPoison", 0, 1.0f);
    }
    
    public void PoisonPlayer()
    {
        if (healthValue>0)
        {
            if (poison>0)
            {
                poison-=Time.deltaTime;
                healthValue -= 10;
            }
        }
    }

    
}

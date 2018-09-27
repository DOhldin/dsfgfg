using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgifttvå : MonoBehaviour
{
    public int UserValue;
    public int DiceIsNice = 10;
    public int Duragon = 0;
    public int WarriorOfLove = 100;
    public int Chance = 0;
    public int Max = 0;
    public int Min = 0;
    public int WarriorDamage;
    public int Crit;

    // Use this for initialization
    void Start()
    {
        print(10 / 3);
        Chance += Random.Range(1, 11);
        Duragon += Random.Range(100, 150);
        Max += Random.Range(25, 51);
        Min += Random.Range(5, 11);
        if (Chance == 1)
        {
            Duragon += Random.Range(100, 150);
        }
        Chance = 0;
    }
    

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        {
            UserValue += 2;
        }
            if (Input.GetKeyDown(KeyCode.RightArrow)== true)
        {
            UserValue /= 2;
        }
            if (Input.GetKeyDown(KeyCode.UpArrow) == true)
        {
            print(UserValue);
        }
            if (Input.GetKeyDown(KeyCode.R) == true)
        {
            DiceIsNice += Random.Range(1, 7);
            DiceIsNice -= Random.Range(1, 7);
        }
            if (DiceIsNice >= 20)
        {
            print("win");
        }
            if (DiceIsNice <= 0)
        {
            print("lose");
        }
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            WarriorDamage += Random.Range(1, 51);
            if (WarriorDamage <= Min)
            {
                WarriorDamage = Min;
            }
            if (WarriorDamage >= Max)
            {
                WarriorDamage = Max;
            }
            Crit += Random.Range(1, 21);
            if (Crit == 1)
            { 
                WarriorDamage += 500;
            }
            Duragon -= WarriorDamage;
            Chance += Random.Range(1, 3);
            if (Chance == 1)
            {
                WarriorOfLove -= Random.Range(11, 21);
                if (Duragon >= 150)
                {
                    WarriorOfLove -= Random.Range(11, 22);
                }
            }
            Chance = 0;
            WarriorDamage = 0;
            Crit = 0;
            if (Duragon <= 0)
            {
                print("WLV Wins");
            }
            if (WarriorOfLove <= 0)
            {
                print("We'll all die");
            }
            if (WarriorOfLove <= 0 && Duragon <= 0)
            {
                print("We will remember you");
            }
            
        }



    }
}

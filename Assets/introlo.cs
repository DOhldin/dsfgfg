using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introlo : MonoBehaviour
{
    public bool Ischecked;
    public int MyIntValue = 10;

    // Use this for initialization
    void Start()
    {
        if(Ischecked == true)
        {
            Debug.Log("It's true.");
        }
        else
        {
            Debug.Log("Kanske");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // == lika med
        // != inte lika med
        // <= mindre än eller lika med
        // >= större än eller lika med
        // < mindre än
        // > större än
        // && OCH (and)
        // || eller (or) [alt gr + <]
        // if (MyIntValue ==10 || Ischecked == true)
        // if (MyIntValue ==10 && Ischecked == true)

        if (MyIntValue == 10)
        {
            if (Ischecked == true)
            {
                print("Måndag");
            }
        }
        else if(MyIntValue == 9)
        {
            print("tisdag");
        }
        else
        {
            print("Onsdag");
        }
        if(Input.GetKeyDown(KeyCode.R)== true)
        {
            MyIntValue += 1;
        }
        if(Input.GetKeyDown(KeyCode.E) == true)
        {
            MyIntValue -= 1;
        }
        if(Input.GetKeyDown(KeyCode.Q) == true)
        {
            // 0 1 2 3 4 5 6 7 8 9
            //Random.Range(0, 1); nej.
            Random.Range(0, 10);
            // 0.032, 10.000f
            Random.Range(0f, 10f);
            MyIntValue += Random.Range(0, 10);
        }
    }
}

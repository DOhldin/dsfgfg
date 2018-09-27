using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class intro : MonoBehaviour
{
    //public = syns i unity
    public int testInt;
    public float testFloat;
    public double testDouble;
    public bool testBool;
    public char testChar;
    public string testString;

    public string sentence1;
    public string sentence2;
    public string sentence3;
    public float number;
    public float Trianglebase;
    public float Angle;

    void Uppgift1()
    {
        print((963f * 421) - (175463f / 87));

    }
    void Uppgift2()
    {
        Uppgift2a();
        Uppgift2b();
        Uppgift2c();
    } 
    void Uppgift2a()
    {
        print(sentence1);
    }
    void Uppgift2b()
    {
        print(sentence2);
    }
    void Uppgift2c()
    {
        print(sentence3);
    }
    void Uppgift3()
    {
        print(Mathf.Pow(number, 2));
        print(Mathf.Sqrt(number));
    }
    void Uppgift4()
    {
        Debug.Log(Trianglebase * 8 / 2);
    }
    void Uppgift5()
    {

    }
	// Use this for initialization
	void Start ()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        //print(testInt);
        //print(testString);
        //print(5.0 / 2);
        //print(10d / 3);
        //print("David Ohldin");
        //print("LBS");
        //print("18a");
        //print("spelutveckling");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
///counting
///count + 
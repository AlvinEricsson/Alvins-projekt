using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript2 : MonoBehaviour {

    public float userValue = 0;
    public int TärningPlus = 0;
    public int TärningMinus = 0;
    public int Uppgift2poäng = 10;
    public int DragonHP;
    public int SpelareHP = 100;
    private int DragonHitChance = 0;
    private int DragonDamage = 0;
	// Use this for initialization
	void Start () {
        //Uppgift3
        DragonHP = Random.Range(99, 151);
        SpelareHP = 100;
    }
	
	// Update is called once per frame
	void Update () {
      
        //Uppgift1
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue = userValue + 2;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue = userValue / 2;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }

        //Uppgift2
        if (Input.GetKeyDown(KeyCode.R))
        {
            TärningPlus = Random.Range(0, 7);
            TärningMinus = Random.Range(0, 7);
            Uppgift2poäng = Uppgift2poäng += TärningPlus - TärningMinus;
            Debug.Log(Uppgift2poäng);
        }
        if (Uppgift2poäng >= 20)
        {
            print ("Du vann!");
        }
        if (Uppgift2poäng <= 0)
        {
            print("Du förlorade.");
        }

        //Uppgift3
        if (Input.GetKeyDown(KeyCode.Space))
        {
            DragonHitChance = Random.Range(0, 2);
            if (DragonHitChance == 1) 
            {
                DragonDamage = (Random.Range(9, 21));
                
            }
            
        }


	}
}

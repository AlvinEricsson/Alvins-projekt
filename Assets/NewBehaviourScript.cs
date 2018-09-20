using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public int testInt = 5;
    public int Uppgift3tal = 0;
    public float testFloat = 1.0f;
    public float Uppgift4bas = 0;
    public float uppgift5pieces = 0;
    public float uppgift7radius = 0;
    public float uppgift8damage = 0;
    public float uppgift8aliv = 0;
    public float uppgift8demoner = 0;
    public float uppgift8maxdamage = 0;
    public float uppgift8mindamage = 0;
    public float uppgift9count = 0;
    [Range(0, 360)] public float uppgift5angle = 0;
    public double testDouble = 1.0d;
    public bool testBool = true;
    public char testChar = 'a';
    public string sentence1 = "0";
    public string sentence2 = "0";
    public string sentence3 = "0";
    public string username = "0";

    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift6();
        Uppgift7();
        Uppgift8();
        
        
    }

    void TestFunktion()
    {
        Debug.Log("Detta är min TestFunktion()");
    }
    // Update is called once per frame
    void Update()
    {
        Uppgift9();
    }
    void Uppgift1()
    {
        Debug.Log("Svaret på (963 * 421) - (175463f / 87f) = ");
        Debug.Log((963f * 421f) - (175463f / 87f));
        Debug.Log(
            string.Format("Svaret på (963 * 421) - (175463f / 87f) är {0}"
            , (963f * 421f) - (175463f / 87f)));

    }

    void Uppgift2()
    {
        Debug.Log(
            string.Format(sentence1)
            );
        Debug.Log(
            string.Format(sentence2)
            );
        Debug.Log(
            string.Format(sentence3)
            );
    }

    void Uppgift3()
    {
        Mathf.Pow(Uppgift3tal, 2);
        Mathf.Sqrt(Uppgift3tal);
        Debug.Log(Mathf.Pow(Uppgift3tal, 2));
        Debug.Log(Mathf.Sqrt(Uppgift3tal));
        Debug.Log(string.Format
            ("Talet {0} upphöjt med 2 blir {1} och kvadratroten ur {0} blir {2}",
            Uppgift3tal, Mathf.Pow(Uppgift3tal, 2), Mathf.Sqrt(Uppgift3tal)));
    }

    void Uppgift4()
    {
        Debug.Log(string.Format(
        "En triangel med höjden 8cm och basen {0}cm har arean {1}cm^2",
        Uppgift4bas, (Uppgift4bas * 8 / 2)));
    }

    void Uppgift5()
    {
        Debug.Log(string.Format(
            "Om man delar denna cirkel i bitar med vinkeln {0} så kan man få {1} hela bitar",
            uppgift5angle, (360 / uppgift5angle)));

        //A 
        Debug.Log(string.Format("Om man vill ha {0} bitar så kommer vinkeln vara {1}",
        uppgift5pieces, (360 / uppgift5pieces)));
    }
   
   
    void Uppgift6()
    {
        Debug.Log(string.Format("Boss {0} of Doom", username));
    }
    
    void Uppgift7()
    {
        Debug.Log(string.Format("Om ett klot har radien {0}cm så kommer 2978 klot ha volymen {1}cm^3",
            uppgift7radius, (2789 * (2 * 3.14 * Mathf.Pow(uppgift7radius, 2) / 3))));
    }

    void Uppgift8()
    {
        Debug.Log(string.Format("Det krävs {0} attacker för att döda en demon med 890000 liv", (890000 / uppgift8damage)));

        //A
        Debug.Log(string.Format("Om dina attacker skadar {0} så krävs det {1} attacker för att döda en demon med {2} liv",
            uppgift8damage, uppgift8aliv / uppgift8damage, uppgift8aliv));
        //B
        Debug.Log(string.Format("Om dina attacker skadar {0} så krävs det {1} attacker för att döda {2} demoner med {3} liv",
            uppgift8damage, ((uppgift8aliv / uppgift8damage) * uppgift8demoner), uppgift8demoner, uppgift8aliv));
        //C
        Debug.Log(string.Format("Om dina attackers max skada är {0} och minst skada är {1} så kommer det max krävas {2} attacker för att döda {3} demoner med"
            + "{4} liv eller minst {5} antal attacker. I snitt skulle det ta {6} antal attacker för att döda demonerna",
            uppgift8maxdamage, uppgift8mindamage, ((uppgift8aliv / uppgift8aliv / uppgift8mindamage) * uppgift8demoner), uppgift8demoner, uppgift8aliv,
            ((uppgift8aliv / uppgift8maxdamage)) * uppgift8demoner, ((uppgift8aliv / uppgift8mindamage) * uppgift8demoner) +
            ((uppgift8aliv / uppgift8maxdamage) * uppgift8demoner) / 2));
           
    }
    void Uppgift9()
    {
        Debug.Log(string.Format("{0}",
             uppgift9count *= 2 ));
    }

    void Uppgift10()
    {

    }

    
}

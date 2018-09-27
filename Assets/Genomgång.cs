using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour
{
    public bool IsChecked;
    public int MyIntValue = 10;

    // Use this for initialization
    void Start()
    {
        if (IsChecked == true)
        {
            Debug.Log("It's true.");
        }
        else
        {
            Debug.Log("Nej");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // == lika med
        // != inte lika med
        // <= mindre eller lika med
        // >= större eller lika med
        // > större än
        // < mindre än
        // || Eller
        // && Och

        if (MyIntValue == 10 || IsChecked == true)
        {
            print("Måndag");
        }

        else if (MyIntValue == 9)
        {
            print("Tisdag");
        }
        else
        {
            print("Okänd dag");
        }

        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            print("Reload");
        }

        if (Input.GetKeyDown(KeyCode.Q) == true)
        {
            MyIntValue = Random.Range(0, 10);
            print(Random.Range(0f, 10f));
            print("Lean left");
        }
    }
}

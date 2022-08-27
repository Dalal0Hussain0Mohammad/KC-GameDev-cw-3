using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script : MonoBehaviour
{
    string HeroName = "Batman";
    int HeroPower = 30;
    string VillainName = "Joker";
    int VillainPower = 30;
    float PlayerSpeed = 4.4f;
    // Start is called before the first frame update
    void Start()
    {
        if (VillainPower > HeroPower)
        {
            print(VillainName + " is stronger.");
        }
        else if (HeroPower < VillainPower)
        {
            print(HeroName + " is stronger.");
        }
        else
        {
            print("They are Both equal!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetSpeed(float NewSpeed)
    {
        print("Old speed is " + PlayerSpeed);
        PlayerSpeed = NewSpeed;
        print("New speed is " + PlayerSpeed);
    }
}

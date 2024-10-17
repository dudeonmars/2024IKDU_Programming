using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAgeIncrease : MonoBehaviour
{

    public int currentAge = 22; 
    private int ageIncrease = 8; 

    // Start is called before the first frame update
    void Start()
    {
        int ageNextYear = IncreaseAge(currentAge);
        Debug.LogFormat("My age next year will be {0}", ageNextYear);
        int ageInNYears = IncreaseAge(currentAge, ageIncrease);
        Debug.LogFormat("My age in {0} year will be {1}", ageIncrease, ageInNYears);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     /// <summary>
    /// Increases ageInitial by one year
    /// </summary>
    int IncreaseAge(int ageInitial) {
        return ageInitial + 1;
        
    }

    /// <summary>
    /// Increases ageInitial by n numberOfYears
    /// </summary>
    int IncreaseAge(int ageInitial, int numberOfYears) {
        return ageInitial + numberOfYears; 
    }
}

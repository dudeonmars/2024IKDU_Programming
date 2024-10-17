using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyFirstVariableAndMethod : MonoBehaviour {

    public int currentAge = 22; 
    private int ageIncrease = 2; 
    bool isFunny = true; 
    string firstName = "Nikolaj";
    string lastName = "Andersen"; 
    public int a = 512; 
    public int b = 731;
    
   
    // Start is called before the first frame update
    void Start() {
/*
        (a, b) = Swap(a, b);
        Debug.LogFormat("My swapped value are: a={0}, b={1}", a, b);

        int d0 = 10; 
        int d1 = 20; 
        (d0, d1) = Swap(d0, d1);
        Debug.LogFormat("My swapped values are: d0={0}, d1={1}", d0, d1);

        (float f1, float f2) = Swap (1.5f, 7.3f); 
        Debug.LogFormat("My swapped 1.5f and 7.3f values from the Swap method are: {0}, {1}", f1, f2);
*/
    }

    // Update is called once per frame
    void Update() {

    } 

    /// <summary>
    /// Swaps two intergers
    /// </summary>
    (int, int) Swap(int m, int n) {
/*
        int swapHelper = m; 
        m = n;
        n = swapHelper;
*/
        return (n, m);
    }

       /// <summary>
    /// Swaps two floats
    /// </summary>
    (float, float) Swap(float m, float n) {
/*
        float swapHelper = m; 
        m = n;
        n = swapHelper;
*/
        return (n, m);
    }
}

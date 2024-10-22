using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeekleyPlans : MonoBehaviour
{
    public string WeeklyActivities = "Monday";
    void Start() {
        WeeklySwitch();
        WeeklyIfElse();
    }

    void WeeklySwitch() {
        switch(WeeklyActivities){
            case "Monday":
                Debug.Log("Work");
                break;
            case "Tuesday":
                Debug.Log("Gym");
                break;
            case "Wednesday":
                Debug.Log("Dinner");
                break;
            case "Thursday":
                Debug.Log("Pubcrawl");
                break;
            case "Friday":
                    Debug.Log("Party");
                break;
            case "Saturday":
                    Debug.Log("Study");
                break;
            case "Sunday":
                    Debug.Log("Church");
                break;
            default:
                Debug.Log("No plans");
                break;
        }
    }

    void WeeklyIfElse() {
        if (WeeklyActivities == "Monday") {
            Debug.Log("Work");
        } else if (WeeklyActivities == "Tuesday") {
            Debug.Log("Gym");
        } else if (WeeklyActivities == "Wednesday") {
            Debug.Log("Dinner");
        } else if (WeeklyActivities == "Thursday") {
            Debug.Log("Pubcrawl");
        } else if (WeeklyActivities == "Friday") {
            Debug.Log("Party");
        } else if (WeeklyActivities == "Saturday") {
            Debug.Log("Study");
        } else if (WeeklyActivities == "Sunday") {
            Debug.Log("Church");
        } else {
            Debug.Log("No plans");
        }
    }
}

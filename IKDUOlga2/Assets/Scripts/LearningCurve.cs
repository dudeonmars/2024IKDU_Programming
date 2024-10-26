using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Character hero = new Character();
        Character hero2 = new Character("Nice secret name");
        Character hero3 = new Character("Nice secret name", 100);
        hero.PrintStatsInfo();
        hero2.PrintStatsInfo();
        hero3.PrintStatsInfo();
        string myFavoriteHeroCharacter = hero3.GetCharacterName();
        Debug.Log($"My favorite hero character is {myFavoriteHeroCharacter}");
    }
}

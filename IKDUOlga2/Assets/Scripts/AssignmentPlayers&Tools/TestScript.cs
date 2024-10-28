using System.Collections;
using System.Collections.Generic;
using PlayersAndTools;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player("Jackie Chan", 100);
        Player player2 = new Player("Bruce Lee", 90);
        Player player3 = new Player("Jet Li", 80);

        Tool tool1 = new("Fists", 10);
        Tool tool2 = new("Staff", 20);
        Tool tool3 = new("Nunchucks", 30);

        player1.PrintStatsInfo();
        player2.PrintStatsInfo();
        player3.PrintStatsInfo();
        tool1.PrintToolInfo();
        tool2.PrintToolInfo();
        tool3.PrintToolInfo();

        player1.AttackWithTool(tool3, player2);
        player2.AttackWithTool(tool2, player3);
        player3.AttackWithTool(tool1, player1);
    }

 
}

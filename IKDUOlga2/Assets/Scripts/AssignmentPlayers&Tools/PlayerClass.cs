using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayersAndTools {
    public class Player {
        private string CharacterName { get; set; }
        private int CharacterHealth { get; set; }

        public Player() {
            CharacterName = "Default Character Name";
            CharacterHealth = 0;
        }

        public Player(string characterName, int characterHealth) {
            CharacterName = characterName;
            CharacterHealth = characterHealth;
        }

        public void PrintStatsInfo() {
            Debug.Log($"Character Name: {CharacterName}, Character Health: {CharacterHealth}");
        }

        public void AttackWithTool(Tool tool, Player target) {
            target.CharacterHealth -= tool.ToolPower;
            Debug.Log($"{CharacterName} is attacking {target.CharacterName} with {tool.ToolName} for {tool.ToolPower}!\n{target.CharacterName} now has {target.CharacterHealth} health!");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PlayersAndTools {
    public class Tool {
        public string ToolName { get; private set; }
        public int ToolPower { get; private set; }

        public Tool() {
            ToolName = "Default Tool Name";
            ToolPower = 0;
        }

        public Tool(string toolName, int toolPower) {
            ToolName = toolName;
            ToolPower = toolPower;
        }

        public void PrintToolInfo() {
            Debug.Log($"Tool Name: {ToolName}, Tool Power: {ToolPower}");
        }
    }
}

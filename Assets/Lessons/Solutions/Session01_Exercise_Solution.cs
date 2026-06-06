using UnityEngine;

// Session 1 Exercise — Solution
// Hold this back until students have attempted the exercise themselves.

public class Session01_Exercise_Solution : MonoBehaviour
{
    void Start()
    {
        // =====================================================================
        // PART 1 — Variables
        // =====================================================================

        string characterName = "Jordan";
        int level = 4;
        int health = 100;
        float critChance = 0.25f;
        bool isPlayerOne = true;

        // =====================================================================
        // PART 2 — Starting state
        // =====================================================================

        Debug.Log("=== Starting State ===");
        Debug.Log(characterName + " | Level: " + level + " | Health: " + health);
        Debug.Log("Crit: " + critChance + " | Player One: " + isPlayerOne);

        // =====================================================================
        // PART 3 — Arithmetic
        // =====================================================================

        health = health - 45;
        level = level + 1;
        critChance = critChance + 0.10f;

        // =====================================================================
        // PART 4 — Updated state
        // =====================================================================

        Debug.Log("=== After Updates ===");
        Debug.Log("Health: " + health + " | Level: " + level + " | Crit: " + critChance);

        // =====================================================================
        // PART 5 — Health status
        // =====================================================================

        float healthPercentage = (float)health / 150.0f * 100.0f;

        if (healthPercentage <= 0)
        {
            Debug.Log("Status: Dead");
        }
        else if (healthPercentage < 30)
        {
            Debug.Log("Status: Critical");
        }
        else if (healthPercentage < 60)
        {
            Debug.Log("Status: Hurt");
        }
        else
        {
            Debug.Log("Status: Healthy");
        }

        // =====================================================================
        // PART 6 — Combined condition
        // =====================================================================

        bool hasRevive = false;

        if (health <= 0 && !hasRevive)
        {
            Debug.Log("Game over.");
        }
        else
        {
            Debug.Log("Still fighting.");
        }

        // =====================================================================
        // PART 7 — Error Gauntlet (all 10 fixed)
        // =====================================================================

        // --- Challenge 1 fix: "sting" → "string" ---
        string playerClass = "Warrior";
        Debug.Log("Class: " + playerClass);

        // --- Challenge 2 fix: "14.5" → "14.5f" ---
        float stamina = 14.5f;
        Debug.Log("Stamina: " + stamina);

        // --- Challenge 3 fix: added missing semicolon after "int lives = 3" ---
        int lives = 3;
        Debug.Log("Lives: " + lives);

        // --- Challenge 4 fix: "Bool" → "bool" ---
        bool isReady = false;
        Debug.Log("Ready: " + isReady);

        // --- Challenge 5 fix: "Debug.log" → "Debug.Log" ---
        int checkpoint = 2;
        Debug.Log("Checkpoint " + checkpoint + " reached");

        // --- Challenge 6 fix: single quotes → double quotes ---
        string motto = "never quit";
        Debug.Log("Motto: " + motto);

        // --- Challenge 7 fix: "coins = 50" → "coins == 50" ---
        int coins = 50;
        if (coins == 50)
        {
            Debug.Log("Exact change.");
        }

        // --- Challenge 8 fix: moved "int mana = 75" above the Debug.Log that uses it ---
        int spellCount = 3;
        int mana = 75;
        Debug.Log("Mana: " + mana);
        Debug.Log("Spells: " + spellCount);

        // --- Challenge 9 fix: "regenRate < 8" → "regenRate > 8" ---
        // regenRate is 5, which is NOT greater than 8, so "Slow regen" prints.
        int regenRate = 5;
        if (regenRate > 8)
        {
            Debug.Log("Fast regen");
        }
        else
        {
            Debug.Log("Slow regen");
        }

        // --- Challenge 10 fix: "||" → "&&" ---
        // shields = 2 but hpRemaining = 0. With ||, shields alone made it "Safe".
        // With &&, both must be true — health is 0 so the condition fails → "Danger".
        int shields = 2;
        int hpRemaining = 0;
        if (shields > 0 && hpRemaining > 0)
        {
            Debug.Log("Safe");
        }
        else
        {
            Debug.Log("Danger");
        }
    }
}

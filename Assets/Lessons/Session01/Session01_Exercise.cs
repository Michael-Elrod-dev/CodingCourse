using UnityEngine;

// Session 1 Exercise — Variables, Types & Conditionals
//
// Work through each part in order.
// Type everything yourself — no copy-paste.
// Press Play after each part to check your output before moving on.

public class Session01_Exercise : MonoBehaviour
{
    void Start()
    {
        // =====================================================================
        // PART 1 — Declare your variables
        // Declare ALL of the following (pick your own values):
        //   - a string called characterName
        //   - an int    called level          (1–10)
        //   - an int    called health         (50–150)
        //   - a float   called critChance     (try 0.25f)
        //   - a bool    called isPlayerOne
        // =====================================================================

        string characterName = "Michael";
        int level = 4;
        int health = 100;
        float critChance = 0.25f;
        bool isPlayerOne = true;

        // =====================================================================
        // PART 2 — Log your starting state
        // Print all five variables to the Console.
        // Make the output readable — label each value.
        // Example format: "Alex | Level: 3 | Health: 100"
        // =====================================================================

        Debug.Log("=== Starting State ===");
        Debug.Log(characterName + " | Level: " + level + " | Health: " + health);
        Debug.Log("Crit: " + critChance + " | Player One: " + isPlayerOne);

        // =====================================================================
        // PART 3 — Arithmetic
        // Make these three things happen (in this order):
        //   1. The player takes 45 damage    (subtract from health)
        //   2. The player gains a level      (add 1 to level)
        //   3. Crit chance improves by 0.10f (add to critChance)
        // =====================================================================

        health = health - 45;
        level = level + 1;
        critChance = critChance + 0.10f;

        // =====================================================================
        // PART 4 — Log the updated state
        // Print health, level, and critChance again so you can see the changes.
        // =====================================================================

        Debug.Log("=== After Updates ===");
        Debug.Log("Health: " + health + " | Level: " + level + " | Crit: " + critChance);

        // =====================================================================
        // PART 5 — Health status (if / else if / else)
        // Write a chain of if / else if / else that logs ONE status message
        // based on the current value of health.
        //
        // The rules:
        //   health is 0 or less   → "Status: Dead"
        //   health is under 30    → "Status: Critical"
        //   health is under 60    → "Status: Hurt"
        //   anything else         → "Status: Healthy"
        //
        // IMPORTANT — order matters. C# checks your conditions top to bottom
        // and runs the FIRST one that is true, then skips the rest. So write
        // the conditions from most specific (lowest health) to least specific.
        // Start with "0 or less", then "under 30", then "under 60", then else.
        //
        // (If you wrote "under 60" first, it would also catch health of 5 or
        //  20 — and you'd never reach the Critical or Dead branches.)
        // =====================================================================

        // Here, "health" is an integer data type.
        // So, we have to cast it to a float in order to get a decimal value from division
        // For example, in C#:
        //     75 / 100 = 0
        //     75.0f / 100.0 = 0.75f
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
        // Declare a bool (boolean) called hasRevive and set it to false.
        // Write ONE if statement that checks: is health zero or less and there is no revive
        // If true, log "Game over."
        // If false, log "Still fighting."
        // =====================================================================

        bool hasRevive = false;
        if (!(health == 1))
        {
            
        }
        if (health <= 0 && !hasRevive)
        {
            Debug.Log("")
        }


        // =====================================================================
        // PART 7 — Error Gauntlet
        //
        // 10 broken code snippets. Work through them one at a time:
        //   1. Uncomment the block (remove the // from every line in that challenge)
        //   2. Save, run the game in Unity, read what the Console tells you
        //   3. Fix the code
        //   4. Run the game again to confirm correct output
        //   5. Leave the code in place and move to the next challenge
        //
        // Challenges 1–8 are compile errors — Unity won't run at all until fixed.
        // Challenges 9–10 compile fine but produce WRONG output. Expected output
        // is stated in the comment. You have to reason through why the logic is
        // wrong, not just read a red error message.
        //
        // =====================================================================


        // --- Challenge 1 ---
        // Declare a string called playerClass set to "Warrior" and log it.
        string playerClass = "Warrior";
        Debug.Log("Class: " + playerClass);


        // --- Challenge 2 ---
        // Declare a float called stamina set to 14.5 and log it.
        float stamina = 14.5;
        Debug.Log("Stamina: " + stamina);


        // --- Challenge 3 ---
        // Declare an int called lives set to 3 and log it.
        // Note: the error message may point to a different line than you expect.
        // int lives = 3
        // Debug.Log("Lives: " + lives);


        // --- Challenge 4 ---
        // Declare a bool called isReady set to false and log it.
        // Bool isReady = false;
        // Debug.Log("Ready: " + isReady);


        // --- Challenge 5 ---
        // Log the message "Checkpoint 2 reached" to the Console.
        // int checkpoint = 2;
        // Debug.log("Checkpoint " + checkpoint + " reached");


        // --- Challenge 6 ---
        // Declare a string called motto and log it.
        // string motto = 'never quit';
        // Debug.Log("Motto: " + motto);


        // --- Challenge 7 ---
        // Declare an int called coins set to 50.
        // If coins equals 50, log "Exact change."
        int coins = 50;
        if (coins = 50)
        {
            Debug.Log("Exact change.");
        }


        // --- Challenge 8 ---
        // Declare an int called mana set to 75 and log it, then log spellCount.
        // int spellCount = 3;
        // Debug.Log("Mana: " + mana);
        // int mana = 75;
        // Debug.Log("Spells: " + spellCount);


        // --- Challenge 9 (logic error) ---
        // regenRate is 5. Expected output: "Slow regen"
        // int regenRate = 5;
        // if (regenRate < 8)
        // {
        //     Debug.Log("Fast regen");
        // }
        // else
        // {
        //     Debug.Log("Slow regen");
        // }


        // --- Challenge 10 (logic error) ---
        // shields = 2, hpRemaining = 0.
        // Rule: Safe only when shields and health are above zero.
        // Expected output: "Danger" (health is zero so the condition should fail)
        // int shields = 2;
        // int hpRemaining = 0;
        // if (shields > 0 || hpRemaining > 0)
        // {
        //     Debug.Log("Safe");
        // }
        // else
        // {
        //     Debug.Log("Danger");
        // }
    }
}

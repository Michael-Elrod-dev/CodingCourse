using UnityEngine;

// Session 1 Exercise — Variables, Types & Conditionals
//
// Work through each part in order.
// Type everything yourself — no copy-paste from the demo.
// Press Play after each part to check your output before moving on.
// Ask a neighbour before asking the instructor. Struggle a little first.

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

        // TODO


        // =====================================================================
        // PART 2 — Log your starting state
        // Print all five variables to the Console.
        // Make the output readable — label each value.
        // Example format: "Alex | Level: 3 | Health: 100"
        // =====================================================================

        // TODO


        // =====================================================================
        // PART 3 — Arithmetic
        // Make these three things happen (in this order):
        //   1. The player takes 45 damage    (subtract from health)
        //   2. The player gains a level      (add 1 to level)
        //   3. Crit chance improves by 0.10f (add to critChance)
        // =====================================================================

        // TODO


        // =====================================================================
        // PART 4 — Log the updated state
        // Print health, level, and critChance again so you can see the changes.
        // =====================================================================

        // TODO


        // =====================================================================
        // PART 5 — Health status (if / else if / else)
        // Write a chain that logs a status message based on health:
        //   health <= 0        → "Status: Dead"
        //   health < 30        → "Status: Critical"
        //   health < 60        → "Status: Hurt"
        //   anything else      → "Status: Healthy"
        // =====================================================================

        // TODO


        // =====================================================================
        // PART 6 — Combined condition
        // Declare a bool called hasRevive and set it to false.
        // Write ONE if statement that checks: is health <= 0 AND no revive?
        // If true, log "Game over."
        // If false, log "Still fighting."
        // =====================================================================

        // TODO


        // =====================================================================
        // PART 7 — Deliberate error
        // Uncomment the line below, save, and read the error in the Console.
        // Be ready to answer: which file? which line? what is the error saying?
        // Re-comment it when you're done so the project compiles again.
        // =====================================================================
        // sting playerTag = "hero";
    }
}

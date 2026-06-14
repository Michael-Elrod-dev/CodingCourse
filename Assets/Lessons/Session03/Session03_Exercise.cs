using System.Diagnostics;
using System.Runtime.InteropServices;
using UnityEngine;

// Session 3 Exercise — Methods
//
// Work through each part in order.
// Type everything yourself — no copy-paste.
// Press Play after each part to check your output before moving on.
//
// NEW THIS SESSION: for the first time you'll write code in TWO places.
// Your method definitions go in the "YOUR METHODS" section near the
// bottom of this file (outside Start). The code that CALLS them stays
// here inside Start, like always. Each part tells you what goes where.

public class Session03_Exercise : MonoBehaviour
{
    void Start()
    {
        // =====================================================================
        // WARM-UP — while loop refresher
        // Last session ended at while loops. Quick reminder before methods:
        //
        //   while (someCondition)
        //   {
        //       // repeats until someCondition becomes false —
        //       // YOU must change something inside, or it never ends
        //   }
        //
        // (This one works like previous sessions — code goes right here.)
        //
        // Declare an int called torches set to 9.
        // Write a while loop that runs while torches is greater than 0:
        //   - log "Torches left: " + torches
        //   - then subtract 3 from torches
        // After the loop, log "Darkness falls."
        //
        // Expected output:
        //   Torches left: 9
        //   Torches left: 6
        //   Torches left: 3
        //   Darkness falls.
        // =====================================================================

        int torches = 9;
        while (torches > 0)
        {
            Debug.Log("Torches left: " + torches);
            torches = torches - 3;      // or: torches -= 3;
        }
        Debug.Log("Darkness falls.");
        // Output:
        //   Torches left: 9
        //   Torches left: 6
        //   Torches left: 3
        //   Darkness falls.


        // =====================================================================
        // PART 1 — Define a method, call a method
        // A method is a named block of code. You write it ONCE, then run it
        // whenever you want by "calling" it. This is how you stop
        // copy-pasting the same code over and over which we'll get into later.
        //
        // A DEFINITION looks like this (it goes OUTSIDE Start, at class level):
        //
        //   void SayHello()
        //   {
        //       Debug.Log("Hello!");
        //   }
        //
        // Reading it: void = "returns nothing" (more on that in Part 4),
        // SayHello = the name, () = Parameters, empty for now, { } = the code that runs.
        //
        // A CALL looks like this (written here, inside Start):
        //
        //   SayHello();
        //
        // IMPORTANT: defining a method does nothing by itself. The code only
        // runs when something calls it.
        //
        // In the YOUR METHODS section below, write a void method called
        // PrintBattleCry that logs "For glory!". Then come back here and
        // call it three times.
        //
        // Expected output:
        //   For glory!
        //   For glory!
        //   For glory!
        // =====================================================================

        PrintBattleCry();
        PrintBattleCry();
        PrintBattleCry();
        // Output:
        //   For glory!
        //   For glory!
        //   For glory!
        // (The method is defined ONCE below Start — three calls, three runs.)


        // =====================================================================
        // PART 2 — Parameters: passing a value in
        // Methods get powerful when you can hand them information. A parameter
        // is a variable declared inside the parentheses — it gets its value
        // from whoever calls the method:
        //
        //   void Greet(string name)        // definition
        //   {
        //       Debug.Log("Hello, " + name);
        //   }
        //
        //   Greet("Ana");                  // call → logs "Hello, Ana"
        //   Greet("Bo");                   // call → logs "Hello, Bo"
        //
        // Same method, different output — the caller decides.
        //
        // Below, write a void method called AnnounceWave that takes an int
        // called waveNumber and logs "Wave " + waveNumber + " incoming!".
        // Back here, call it with 1, then 2, then 3.
        //
        // Expected output:
        //   Wave 1 incoming!
        //   Wave 2 incoming!
        //   Wave 3 incoming!
        //
        // =====================================================================

        AnnounceWave(1);
        AnnounceWave(2);
        AnnounceWave(3);
        // Output:
        //   Wave 1 incoming!
        //   Wave 2 incoming!
        //   Wave 3 incoming!
        //
        // Bonus form — same output:
        //   for (int i = 1; i <= 3; i++) { AnnounceWave(i); }


        // =====================================================================
        // PART 3 — Multiple parameters
        // Separate parameters with commas. Order matters — the first value
        // you pass lands in the first parameter, and so on:
        //
        //   void Describe(string name, int age) { ... }
        //   Describe("Rex", 7);            // name = "Rex", age = 7
        //
        // Write a void method called LogAttack that takes a string attacker
        // and an int damage, and logs:
        //   attacker + " deals " + damage + " damage!"
        // Call it twice: once for "Goblin" dealing 7, once for "Dragon"
        // dealing 25.
        //
        // Expected output:
        //   Goblin deals 7 damage!
        //   Dragon deals 25 damage!
        // =====================================================================

        LogAttack("Goblin", 7);
        LogAttack("Dragon", 25);
        // Output:
        //   Goblin deals 7 damage!
        //   Dragon deals 25 damage!


        // =====================================================================
        // PART 4 — Return values: getting an answer back
        // So far every method was void — it DID something but returned nothing
        // back. Replace void with a type, and the method returns a value:
        //
        //   int Add(int a, int b)
        //   {
        //       return a + b;    // return = "return this and exit NOW"
        //   }
        
        //   int result = Add(3, 5);    // the call BECOMES the value 8 how cool!
        //
        // KEY IDEA: returning is not printing, and it is not saving. The
        // value comes back to the caller — if the caller doesn't store it
        // (or log it), it just vanishes.
        //
        // Write a method called ApplyDamage that takes an int health and an
        // int damage, and RETURNS health - damage.
        //
        // Back here:
        //   1. Declare an int called playerHealth set to 100.
        //   2. playerHealth = ApplyDamage(playerHealth, 35);
        //      then log "Health after hit: " + playerHealth
        //   3. Do it again with 20 damage, and log again.
        //
        // Expected output:
        //   Health after hit: 65
        //   Health after hit: 45
        // =====================================================================

        int playerHealth = 100;
        playerHealth = ApplyDamage(playerHealth, 35);
        Debug.Log("Health after hit: " + playerHealth);
        playerHealth = ApplyDamage(playerHealth, 20);
        Debug.Log("Health after hit: " + playerHealth);
        // Output:
        //   Health after hit: 65
        //   Health after hit: 45
        //
        // The crucial bit is  playerHealth = ApplyDamage(...)  — the method
        // returns the new value, and the caller must STORE it. Calling
        // ApplyDamage(playerHealth, 35); alone would change nothing
        // (that exact mistake is Gauntlet Challenge 7).


        // =====================================================================
        // PART 5 — Returning a bool: methods that answer questions
        // A method can return true/false — perfect for giving a name to a
        // condition you check often. Name them like questions: IsDead,
        // HasKey, CanAfford.
        //
        //   bool IsEmpty(int count)
        //   {
        //       return count == 0;   // a comparison IS a bool — return it
        //   }
        //
        //   if (IsEmpty(arrows)) { ... }    // the call reads like English
        //
        // Write a method called IsCritical that takes an int health and
        // returns whether it is below 30.
        //
        // Back here (playerHealth should be 45 right now):
        //   1. If IsCritical(playerHealth) is true, log
        //      "CRITICAL - find a potion!" — otherwise log "Stable."
        //   2. Hit the player again:
        //      playerHealth = ApplyDamage(playerHealth, 30);
        //   3. Repeat the same if/else check.
        //
        // Expected output:
        //   Stable.
        //   CRITICAL - find a potion!
        // =====================================================================

        if (IsCritical(playerHealth))
        {
            Debug.Log("CRITICAL - find a potion!");
        }
        else
        {
            Debug.Log("Stable.");
        }

        playerHealth = ApplyDamage(playerHealth, 30);   // 45 → 15

        if (IsCritical(playerHealth))
        {
            Debug.Log("CRITICAL - find a potion!");
        }
        else
        {
            Debug.Log("Stable.");
        }
        // Output:
        //   Stable.
        //   CRITICAL - find a potion!


        // =====================================================================
        // PART 6 — The payoff: one method, any array
        // In Session 2 you wrote a loop to total up enemyHealth. If you
        // wanted the total of a DIFFERENT array, you'd have to copy-paste
        // the whole loop. Methods fix exactly this — arrays can be
        // parameters too:
        //
        //   int Sum(int[] values) { ... }
        //
        // Write a method called TotalHealth that takes an int[] called
        // enemies, loops over it adding everything up (Session 2, Part 5!),
        // and returns the total.
        //
        // Back here, declare both of these:
        //   int[] caveEnemies = { 30, 50, 20 };
        //   int[] bossRoom = { 80, 45 };
        // Then log each total, using ONE method call for each:
        //   "Cave total: " ...  and  "Boss room total: " ...
        //
        // Expected output:
        //   Cave total: 100
        //   Boss room total: 125
        //
        // That's the whole point of methods: the loop is written once, and
        // works for any array you ever hand it.
        // =====================================================================

        int[] caveEnemies = { 30, 50, 20 };
        int[] bossRoom = { 80, 45 };
        Debug.Log("Cave total: " + TotalHealth(caveEnemies));
        Debug.Log("Boss room total: " + TotalHealth(bossRoom));
        // Output:
        //   Cave total: 100
        //   Boss room total: 125


        // =====================================================================
        // PART 7 — Error Gauntlet
        //
        // 10 broken code snippets. Work through them one at a time:
        //   1. Uncomment the block (remove the // from every line in that challenge)
        //   2. Save — read what the Console or compiler tells you
        //   3. Fix the code
        //   4. Press Play to confirm correct output
        //   5. Leave the fixed code in place and move to the next challenge
        //
        // NEW: methods mean every challenge lives in TWO places — the call
        // here, and its method in the GAUNTLET METHODS section at the very
        // bottom of the file. Uncomment BOTH pieces for each challenge.
        // Some methods are correct as written and some are broken. For the
        // logic errors, the bug might be in the call here, in the method
        // down there, or in how the two talk to each other — deciding where
        // to look is part of the skill.
        //
        // Challenges 1–6 are compile errors — Unity won't run at all until fixed.
        // Challenges 7–10 compile fine but produce WRONG output. Expected
        // output is stated in the comment. You have to reason through why
        // the logic is wrong, not just read a red error message.
        //
        // =====================================================================


        // --- Challenge 1 ---
        // Sound the alarm. Uncomment the method SoundAlarm at the bottom of
        // the file too.
        // Expected output: ALARM! Enemies incoming!
        SoundAlarm();
        // Output: ALARM! Enemies incoming!


        // --- Challenge 2 ---
        // Taunt twice.
        // Expected output:
        //   Taunt!
        //   Taunt!
        RepeatTaunt(2);
        // Output: Taunt!, Taunt!
        // (Original call had no argument: "no overload for method
        //  'RepeatTaunt' takes 0 arguments".)


        // --- Challenge 3 ---
        // Award 50 gold.
        // Expected output: Gold gained: 50
        GrantGold(50);
        // Output: Gold gained: 50
        // (Strings and ints are not interchangeable — same lesson as
        //  Session 1, now at a method boundary.)


        // --- Challenge 4 ---
        // Double a damage number.
        // Expected output: Double damage: 12
        Debug.Log("Double damage: " + DoubleDamage(6));
        // Output: Double damage: 12


        // --- Challenge 5 ---
        // Celebrate the win.
        // Expected output: Victory!
        LogVictory();
        // Output: Victory!


        // --- Challenge 6 ---
        // Multiply two numbers.
        // Expected output: Product: 20
        Debug.Log("Product: " + Multiply(4, 5));
        // Output: Product: 20


        // --- Challenge 7 (logic error) ---
        // Drink a potion.
        // Expected output: HP after potion: 65 — but it logs 40. Why?
        int hp = 40;
        hp = Heal(hp, 25);
        Debug.Log("HP after potion: " + hp);
        // Output: HP after potion: 65


        // --- Challenge 8 (logic error) ---
        // Total up the loot.
        // Expected output: Loot total: 60 — but it logs 10. Find the bug.
        int[] loot = { 10, 20, 30 };
        Debug.Log("Loot total: " + SumAll(loot));
        // Output: Loot total: 60


        // --- Challenge 9 (logic error) ---
        // 30 bullets, 12 fired.
        // Expected output: Ammo left: 18 — but it logs -18. Find the bug.
        Debug.Log("Ammo left: " + AmmoLeft(30, 12));
        // Output: Ammo left: 18


        // --- Challenge 10 (logic error) ---
        // You have 40 gold; the sword costs 100.
        // Expected output: Not enough gold. — but it logs Purchased!
        if (CanAfford(40, 100))
        {
            Debug.Log("Purchased!");
        }
        else
        {
            Debug.Log("Not enough gold.");
        }
        // Output: Not enough gold.
    }

    // =========================================================================
    // YOUR METHODS — Parts 1–6
    // Write your methods below. Each one lives here at "class level":
    // inside the class braces, but OUTSIDE Start. Order doesn't matter —
    // C# finds methods by name, not by position in the file.
    // =========================================================================

    // Part 1
    void PrintBattleCry()
    {
        Debug.Log("For glory!");
    }

    // Part 2
    void AnnounceWave(int waveNumber)
    {
        Debug.Log("Wave " + waveNumber + " incoming!");
    }

    // Part 3
    void LogAttack(string attacker, int damage)
    {
        Debug.Log(attacker + " deals " + damage + " damage!");
    }

    // Part 4
    int ApplyDamage(int health, int damage)
    {
        return health - damage;
    }

    // Part 5
    bool IsCritical(int health)
    {
        return health < 30;
    }

    // Part 6
    int TotalHealth(int[] enemies)
    {
        int total = 0;
        for (int i = 0; i < enemies.Length; i++)
        {
            total = total + enemies[i];
        }
        return total;
    }

    // =========================================================================
    // GAUNTLET METHODS (fixed where they were broken)
    // =========================================================================

    // Challenge 1 (was correct)
    void SoundAlarm()
    {
        Debug.Log("ALARM! Enemies incoming!");
    }

    // Challenge 2 (was correct)
    void RepeatTaunt(int times)
    {
        for (int i = 0; i < times; i++)
        {
            Debug.Log("Taunt!");
        }
    }

    // Challenge 3 (was correct)
    void GrantGold(int amount)
    {
        Debug.Log("Gold gained: " + amount);
    }

    // Challenge 4 — FIX: added the missing return statement
    int DoubleDamage(int damage)
    {
        int doubled = damage * 2;
        return doubled;
        // (return damage * 2; in one line is equally correct)
    }

    // Challenge 5 (was correct)
    void LogVictory()
    {
        Debug.Log("Victory!");
    }

    // Challenge 6 — FIX: comma between the parameters
    int Multiply(int a, int b)
    {
        return a * b;
    }

    // Challenge 7 (was correct — the bug was at the call site)
    int Heal(int currentHealth, int amount)
    {
        return currentHealth + amount;
    }

    // Challenge 8 — FIX: removed the stray return inside the loop
    int SumAll(int[] values)
    {
        int total = 0;
        for (int i = 0; i < values.Length; i++)
        {
            total = total + values[i];
        }
        return total;
    }

    // Challenge 9 — FIX: ammo - shotsFired, not the other way around
    int AmmoLeft(int ammo, int shotsFired)
    {
        return ammo - shotsFired;
    }

    // Challenge 10 — FIX: >= instead of <
    bool CanAfford(int gold, int price)
    {
        return gold >= price;
    }
}

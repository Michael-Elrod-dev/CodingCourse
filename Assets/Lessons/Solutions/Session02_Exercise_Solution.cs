using UnityEngine;

// Session 2 Exercise — SOLUTION
// Loops & Arrays
//
// This is the answer key. Output is shown in comments after each part.
// Note: values like names and exact log labels are arbitrary — any version
// that produces the stated output and uses the right structure is correct.

public class Session02_Exercise_Solution : MonoBehaviour
{
    void Start()
    {
        // =====================================================================
        // WARM-UP — Conditionals refresher (&& and ||)
        // =====================================================================

        int potions = 2;
        bool inCombat = true;

        if (potions >= 1 && inCombat)
        {
            Debug.Log("Heal up!");
        }
        else
        {
            Debug.Log("Hold position.");
        }
        // Output: Heal up!


        // =====================================================================
        // PART 1 — Your first for loop
        // =====================================================================

        for (int i = 0; i < 5; i++)
        {
            Debug.Log("Wave " + (i + 1));
        }
        // Output:
        //   Wave 1
        //   Wave 2
        //   Wave 3
        //   Wave 4
        //   Wave 5
        //
        // Alternate valid form — start at 1, test <= 5:
        //   for (int i = 1; i <= 5; i++) { Debug.Log("Wave " + i); }


        // =====================================================================
        // PART 2 — Looping with a running total
        // =====================================================================

        int totalDamage = 0;            // declared OUTSIDE the loop
        for (int i = 0; i < 6; i++)
        {
            totalDamage = totalDamage + 10;   // or: totalDamage += 10;
        }
        Debug.Log("Total damage: " + totalDamage);
        // Output: Total damage: 60


        // =====================================================================
        // PART 3 — Declare an array
        // =====================================================================

        int[] enemyHealth = { 30, 50, 20, 80, 45 };
        Debug.Log("First enemy health: " + enemyHealth[0]);
        Debug.Log("Enemy count: " + enemyHealth.Length);
        // Output:
        //   First enemy health: 30
        //   Enemy count: 5


        // =====================================================================
        // PART 4 — Loop through the array
        // =====================================================================

        for (int i = 0; i < enemyHealth.Length; i++)
        {
            Debug.Log("Enemy " + i + " has " + enemyHealth[i] + " HP");
        }
        // Output:
        //   Enemy 0 has 30 HP
        //   Enemy 1 has 50 HP
        //   Enemy 2 has 20 HP
        //   Enemy 3 has 80 HP
        //   Enemy 4 has 45 HP


        // =====================================================================
        // PART 5 — Sum and find: loop + accumulate + compare
        // =====================================================================

        int totalHP = 0;
        int highest = 0;
        for (int i = 0; i < enemyHealth.Length; i++)
        {
            totalHP = totalHP + enemyHealth[i];
            if (enemyHealth[i] > highest)
            {
                highest = enemyHealth[i];
            }
        }
        Debug.Log("Total HP: " + totalHP);
        Debug.Log("Toughest enemy HP: " + highest);
        // Output:
        //   Total HP: 225
        //   Toughest enemy HP: 80


        // =====================================================================
        // PART 6 — Loop with a condition inside
        // =====================================================================

        int woundedCount = 0;
        for (int i = 0; i < enemyHealth.Length; i++)
        {
            if (enemyHealth[i] < 50)
            {
                Debug.Log("Enemy " + i + " is wounded");
                woundedCount = woundedCount + 1;
            }
        }
        Debug.Log("Wounded enemies: " + woundedCount);
        // Output:
        //   Enemy 0 is wounded
        //   Enemy 2 is wounded
        //   Enemy 4 is wounded
        //   Wounded enemies: 3


        // =====================================================================
        // PART 7 — The while loop
        // =====================================================================

        int fuel = 10;
        while (fuel > 0)
        {
            Debug.Log("Fuel remaining: " + fuel);
            fuel = fuel - 3;            // or: fuel -= 3;
        }
        Debug.Log("Out of fuel.");
        // Output:
        //   Fuel remaining: 10
        //   Fuel remaining: 7
        //   Fuel remaining: 4
        //   Fuel remaining: 1
        //   Out of fuel.


        // =====================================================================
        // PART 8 — Error Gauntlet (fixed)
        // =====================================================================


        // --- Challenge 1 --- FIX: commas → semicolons in the for header
        for (int i = 0; i < 3; i++)
        {
            Debug.Log(i);
        }
        // Output: 0, 1, 2


        // --- Challenge 2 --- FIX: the step clause (i++) was missing
        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Tick");
        }
        // Output: Tick, Tick, Tick
        // (Original would not compile — three clauses are required.)


        // --- Challenge 3 --- FIX: needs int[] and the [] on the type
        int[] ammo = { 12, 6, 30 };
        Debug.Log(ammo[0]);
        // Output: 12


        // --- Challenge 4 --- FIX: Length is a property, not a method — no ()
        int[] lives = { 3, 2, 1 };
        Debug.Log("Count: " + lives.Length);
        // Output: Count: 3


        // --- Challenge 5 --- FIX: log gold[i], not gold (the whole array)
        int[] gold = { 100, 250, 75 };
        for (int i = 0; i < gold.Length; i++)
        {
            Debug.Log(gold[i]);
        }
        // Output: 100, 250, 75


        // --- Challenge 6 --- FIX: missing semicolon after count--
        int count = 3;
        while (count > 0)
        {
            Debug.Log(count);
            count--;
        }
        // Output: 3, 2, 1


        // --- Challenge 7 --- FIX: index must be int, not float
        string[] names = { "Ana", "Bo", "Cy" };
        for (int i = 0; i < names.Length; i++)
        {
            Debug.Log(names[i]);
        }
        // Output: Ana, Bo, Cy


        // --- Challenge 8 (runtime) --- FIX: <= reads past the end; use <
        int[] mana = { 5, 10, 15 };
        for (int i = 0; i < mana.Length; i++)
        {
            Debug.Log(mana[i]);
        }
        // Output: 5, 10, 15
        // (Original used i <= mana.Length, which tries to read index 3 →
        //  IndexOutOfRangeException. Last valid index is Length - 1 = 2.)


        // --- Challenge 9 (logic) --- FIX: loop started at i = 1, skipping
        // index 0 (the 10). Start at i = 0 so every element is included.
        int[] hits = { 10, 20, 30 };
        int sum = 0;
        for (int i = 0; i < hits.Length; i++)
        {
            sum = sum + hits[i];
        }
        Debug.Log("Sum: " + sum);
        // Output: Sum: 60
        // (Original started at i = 1, so it summed only 20 + 30 = 50 and
        //  never added index 0. Remember: array indexes start at 0, so a loop
        //  that should touch every element must start there too.)


        // --- Challenge 10 (infinite loop) --- FIX: decrement gas inside the
        // loop so the condition eventually becomes false.
        int gas = 5;
        while (gas > 0)
        {
            Debug.Log(gas);
            gas--;
        }
        // Output: 5, 4, 3, 2, 1
        // (Original never changed gas, so gas > 0 stayed true forever.)
    }
}

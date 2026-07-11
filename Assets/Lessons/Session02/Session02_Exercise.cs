using UnityEngine;

// Session 2 Exercise — Loops & Arrays
//
// Work through each part in order.
// Type everything yourself — no copy-paste.
// Press Play after each part to check your output before moving on.

public class Session02_Exercise : MonoBehaviour {
    void Start() {
        // =====================================================================
        // WARM-UP — Conditionals refresher (&& and ||)
        // Last session ended at conditionals. Quick reminder before loops:
        //   &&  means AND  — both sides must be true
        //   ||  means OR   — at least one side must be true
        //   !   means NOT  — flips a bool
        //
        // Declare an int called potions set to 2.
        // Declare a bool called inCombat set to true.
        // Write ONE if statement: if you have at least 1 potion AND you are
        // in combat, log "Heal up!" — otherwise log "Hold position."
        // =====================================================================

        int potions = 2;
        bool inCombat = true;

        if (potions >= 1 && inCombat) {
            Debug.Log("Heal up!");
        } else {
            Debug.Log("Hold position.");
        }
        // Output: Heal up!


        // =====================================================================
        // PART 1 — Your first for loop
        // A for loop repeats a block a set number of times. The structure is:
        //
        //   for (int i = 0; i < 5; i++) {
        //       // this runs 5 times, with i going 0, 1, 2, 3, 4
        //   }
        //
        // Three pieces inside the parentheses, separated by semicolons:
        //   1. start:  int i = 0     (a counter, starts at 0)
        //   2. test:   i < 5         (keep going while this is true)
        //   3. step:   i++           (add 1 to i after each pass)
        //
        // Write a for loop that logs "Wave " followed by the number, for
        // waves 1 through 5. Expected output:
        //   Wave 1
        //   Wave 2
        //   Wave 3
        //   Wave 4
        //   Wave 5
        //
        // Hint: i starts at 0, so log (i + 1) to get 1–5. OR start i at 1
        // and test i <= 5. Either works — pick one and understand why.
        // =====================================================================

        for (int i = 0; i < 5; i++) {
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
        // A loop can build up a value across passes.
        //
        // Declare an int called totalDamage set to 0 BEFORE the loop.
        // Write a for loop that runs 6 times. Each pass, add 10 to totalDamage.
        // After the loop, log "Total damage: " + totalDamage.
        //
        // Expected output:  Total damage: 60
        //
        // Note: totalDamage is declared OUTSIDE the loop. If you declare it
        // inside, it resets to 0 every pass and you'd never accumulate.
        // =====================================================================

        int totalDamage = 0;            // declared OUTSIDE the loop
        for (int i = 0; i < 6; i++) {
            totalDamage = totalDamage + 10;   // or: totalDamage += 10;
        }
        Debug.Log("Total damage: " + totalDamage);
        // Output: Total damage: 60


        // =====================================================================
        // PART 3 — Declare an array
        // An array is a single variable that holds multiple values of the
        // same type, in order. You access each by its index (position),
        // and indexes start at 0.
        //
        // int score = 50;
        // int[] scores = { 10, 20, 30 };
        // scores[0] is 10,  scores[1] is 20,  scores[2] is 30
        // scores.Length is 3 (the number of items)
        //
        // Declare an int array called enemyHealth with these five values:
        //   30, 50, 20, 80, 45
        //
        // Then log two things:
        //   - the first enemy's health  (index 0)
        //   - the number of enemies      (.Length)
        //
        // Expected output:
        //   First enemy health: 30
        //   Enemy count: 5
        // =====================================================================

        int[] enemyHealth = { 30, 50, 20, 80, 45 };
        Debug.Log("First enemy health: " + enemyHealth[0]);
        Debug.Log("Enemy count: " + enemyHealth.Length);
        // Output:
        //   First enemy health: 30
        //   Enemy count: 5


        // =====================================================================
        // PART 4 — Loop through the array
        // This is where loops and arrays click together. A for loop can walk
        // every index of an array using .Length as the test:
        //
        //   for (int i = 0; i < enemyHealth.Length; i++) {
        //       // enemyHealth[i] is the value at the current index
        //   }
        //
        // Loop through enemyHealth and log each one, labeled with its index.
        // Expected output:
        //   Enemy 0 has 30 HP
        //   Enemy 1 has 50 HP
        //   Enemy 2 has 20 HP
        //   Enemy 3 has 80 HP
        //   Enemy 4 has 45 HP
        //
        // Note: the test is  i < enemyHealth.Length, NOT i <= Length. The last
        // valid index is Length - 1 (here, index 4). Using <= would try to read
        // index 5, which doesn't exist — an out-of-range error.
        // =====================================================================

        for (int i = 0; i < enemyHealth.Length; i++) {
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
        // Combine everything: loop the array while doing real work.
        //
        // Using the same enemyHealth array, find BOTH:
        //   - the total HP of all enemies   (a running sum, like Part 2)
        //   - the single highest HP value   (track a "highest so far")
        //
        // For the highest: declare an int called highest set to 0 before the
        // loop. Inside the loop, if the current value is greater than highest,
        // update highest to that value.
        //
        // After the loop, log:
        //   Total HP: 225
        //   Toughest enemy HP: 80
        // =====================================================================
        
        int totalHP = 0;
        int highest = 0;
        for (int i = 0; i < enemyHealth.Length; i++) {
            totalHP = totalHP + enemyHealth[i];
            if (enemyHealth[i] > highest) {
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
        // Loops and conditionals combine constantly. Walk the array and only
        // act on items that meet a test.
        //
        // Declare an int called woundedCount set to 0.
        // Loop through enemyHealth. For each enemy:
        //   - if its HP is below 50, log "Enemy " + i + " is wounded"
        //     and add 1 to woundedCount.
        // After the loop, log "Wounded enemies: " + woundedCount.
        //
        // Expected output:
        //   Enemy 0 is wounded
        //   Enemy 2 is wounded
        //   Enemy 4 is wounded
        //   Wounded enemies: 3
        // =====================================================================

        int woundedCount = 0;
        for (int i = 0; i < enemyHealth.Length; i++) {
            if (enemyHealth[i] < 50) {
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
        // A for loop is best when you know the count up front. A while loop
        // runs as long as a condition stays true — useful when you DON'T know
        // how many passes it'll take.
        //
        //   while (someCondition) {
        //       // runs over and over until someCondition becomes false
        //   }
        //
        // You are responsible for changing something inside the loop so the
        // condition eventually becomes false. If you don't, it loops forever
        // and Unity freezes (see Challenge 10).
        //
        // Declare an int called fuel set to 10.
        // Write a while loop that runs while fuel is greater than 0:
        //   - log "Fuel remaining: " + fuel
        //   - then subtract 3 from fuel
        // After the loop, log "Out of fuel."
        //
        // Expected output:
        //   Fuel remaining: 10
        //   Fuel remaining: 7
        //   Fuel remaining: 4
        //   Fuel remaining: 1
        //   Out of fuel.
        // =====================================================================

        int fuel = 10;
        while (fuel > 0) {
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
        // PART 8 — Error Gauntlet
        //
        // 10 broken code snippets. Work through them one at a time:
        //   1. Uncomment the block (remove the // from every line in that challenge)
        //   2. Save — read what the Console or compiler tells you
        //   3. Fix the code
        //   4. Press Play to confirm correct output
        //   5. Leave the fixed code in place and move to the next challenge
        //
        // Challenges 1–7 are compile errors — Unity won't run at all until fixed.
        // Challenges 8–10 compile fine (or run) but produce WRONG behavior.
        // Expected output is stated in the comment. You have to reason through
        // why the logic is wrong, not just read a red error message.
        //
        // =====================================================================


        // --- Challenge 1 ---
        // Log the numbers 0, 1, 2 using a for loop.
        // The semicolons inside the for are wrong.
        for (int i = 0; i < 3; i++) {
            Debug.Log(i);
        }
        // Output: 0, 1, 2


        // --- Challenge 2 ---
        // Log "Tick" three times with a for loop.
        // Something is missing from the loop header.
        for (int i = 0; i < 3; i++) {
            Debug.Log("Tick");
        }
        // Output: Tick, Tick, Tick
        // (Original would not compile — three clauses are required.)


        // --- Challenge 3 ---
        // Declare an array of three ints and log the first one.
        // The array syntax is wrong.
        int[] ammo = { 12, 6, 30 };
        Debug.Log(ammo[0]);
        // Output: 12


        // --- Challenge 4 ---
        // Declare an array and log how many items it has.
        // The way the count is being read is wrong.
        int[] lives = { 3, 2, 1 };
        Debug.Log("Count: " + lives.Length);
        // Output: Count: 3


        // --- Challenge 5 ---
        // Loop through an array and log each value.
        // The loop body refers to the wrong thing.
        int[] gold = { 100, 250, 75 };
        for (int i = 0; i < gold.Length; i++) {
            Debug.Log(gold[i]);
        }
        // Output: 100, 250, 75


        // --- Challenge 6 ---
        // A while loop that logs countdown 3, 2, 1.
        // One symbol is missing that the loop needs to work.
        int count = 3;
        while (count > 0) {
            Debug.Log(count);
            count--;
        }
        // Output: 3, 2, 1


        // --- Challenge 7 ---
        // Log each item of the array. The counter is declared with the
        // wrong type for indexing.
        string[] names = { "Ana", "Bo", "Cy" };
        for (int i = 0; i < names.Length; i++) {
            Debug.Log(names[i]);
        }
        // Output: Ana, Bo, Cy


        // --- Challenge 8 (logic / runtime error) ---
        // Log every value in the array.
        // This compiles, but pressing Play throws an IndexOutOfRangeException.
        // Expected: logs 5, 10, 15 with no error. Fix the loop test.
        int[] mana = { 5, 10, 15 };
        for (int i = 0; i < mana.Length; i++) {
            Debug.Log(mana[i]);
        }
        // Output: 5, 10, 15
        // (Original used i <= mana.Length, which tries to read index 3 →
        //  IndexOutOfRangeException. Last valid index is Length - 1 = 2.)


        // --- Challenge 9 (logic error) ---
        // Sum the array. Expected output: "Sum: 60"
        // It compiles and runs but logs the wrong number (it logs 50).
        // The loop skips something. Find the bug.
        int[] hits = { 10, 20, 30 };
        int sum = 0;
        for (int i = 0; i < hits.Length; i++) {
            sum = sum + hits[i];
        }
        Debug.Log("Sum: " + sum);
        // Output: Sum: 60
        // (Original started at i = 1, so it summed only 20 + 30 = 50 and
        //  never added index 0. Remember: array indexes start at 0, so a loop
        //  that should touch every element must start there too.)


        // --- Challenge 10 (logic error — INFINITE LOOP, read before running) ---
        // This while loop is supposed to count down from 5 and stop.
        // As written it NEVER stops — fuel never changes, so the condition
        // stays true forever and Unity will freeze.
        //
        // READ IT FIRST. Figure out the fix BEFORE you uncomment and Play.
        // Expected output: logs 5, 4, 3, 2, 1 then stops.
        //
        // (If you do freeze Unity: the loop will eventually be force-killed,
        //  or you can avoid it entirely by fixing the code before running.)
        int gas = 5;
        while (gas > 0) {
            Debug.Log(gas);
            gas--;
        }
        // Output: 5, 4, 3, 2, 1
        // (Original never changed gas, so gas > 0 stayed true forever.)
    }
}

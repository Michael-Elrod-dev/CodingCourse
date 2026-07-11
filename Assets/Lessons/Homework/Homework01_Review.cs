using UnityEngine;

// Homework 1 — Sessions 1 & 2 Review
// Variables, types, conditionals, loops, arrays. (No new material.)
//
// This is a self-check before Session 3, not a test. The goal
// is to find out which concepts stuck and which need another look. The
// reference sheet (CSharp_Reference.md) is fair game — this is not a
// memory contest. Old exercise solutions are not.
//
// Three sections, roughly 20–30 minutes total:
//
//   PART A — Predict the output. Six finished snippets, each commented
//            out. One at a time: uncomment it, read it, and write what
//            you think it prints in the "My prediction:" comment — THEN
//            press Play and compare the Console to your answer.
//
//   PART B — Write it. Three small tasks. Expected output is given.
//
//   PART C — Fix it. Two broken snippets, same drill as the gauntlets.
//
// A wrong prediction is the most useful result here — when the Console
// surprises you, re-read the snippet until you can explain why the
// Console is right. That moment is the whole assignment.

public class Homework01_Review : MonoBehaviour {
    void Start() {
        // =====================================================================
        // PART A — PREDICT THE OUTPUT
        // For each snippet: uncomment it, read it, write your prediction,
        // and THEN press Play. Don't fix or change anything — every snippet
        // works exactly as written. Your only job is to read it correctly.
        // (Earlier snippets keep printing on every run — match by label.)
        // =====================================================================


        // --- A1 — variables & arithmetic -------------------------------------
        // (Reminder: += adds to the current value, *= multiplies it.)

        // int score = 10;
        // score += 5;
        // score *= 2;
        // Debug.Log("A1: " + score);

        // My prediction:
        //


        // --- A2 — if / else if order ------------------------------------------

        // int health = 20;
        // if (health < 60) {
        //     Debug.Log("A2: Hurt");
        // } else if (health < 30) {
        //     Debug.Log("A2: Critical");
        // } else {
        //     Debug.Log("A2: Healthy");
        // }

        // My prediction:
        //


        // --- A3 — combined conditions -----------------------------------------

        // bool isNight = true;
        // bool hasTorch = false;
        // if (isNight && !hasTorch) {
        //     Debug.Log("A3: Too dark to travel.");
        // } else {
        //     Debug.Log("A3: On the road.");
        // }

        // My prediction:
        //


        // --- A4 — loop with a running total ------------------------------------

        // int chest = 0;
        // for (int i = 1; i <= 3; i++) {
        //     chest = chest + i;
        // }
        // Debug.Log("A4: " + chest);

        // My prediction:
        //


        // --- A5 — array + loop + condition -------------------------------------

        // int[] dmg = { 12, 3, 8, 20 };
        // int strongHits = 0;
        // for (int i = 0; i < dmg.Length; i++) {
        //     if (dmg[i] > 9) {
        //         strongHits = strongHits + 1;
        //     }
        // }
        // Debug.Log("A5: " + strongHits);

        // My prediction:
        //


        // --- A6 — while loop ----------------------------------------------------
        // (How many lines does this print, and what does each one say?)

        // int charge = 8;
        // while (charge > 0) {
        //     Debug.Log("A6: charge " + charge);
        //     charge = charge - 4;
        // }
        // Debug.Log("A6: depleted");

        // My prediction:
        //


        // =====================================================================
        // PART B — WRITE IT
        // =====================================================================


        // --- B1 — declare and log (Session 1) ---------------------------------
        // Declare three variables — a string called heroName, an int called
        // heroLevel, and a bool called hasShield — with values of your choice.
        // Log all three in ONE readable line, starting with "B1: ".
        //
        // Example output:  B1: Aria | Level 3 | Shield: True

        // TODO


        // --- B2 — sum an array (Session 2) ------------------------------------
        // Declare this array (type it yourself, values exactly as shown):
        //   waveSizes  →  4, 7, 2, 9
        // Then loop over it, add up the total number of enemies, and log
        // the result.
        //
        // Expected output:  B2 Total enemies: 22

        // TODO


        // --- B3 — if / else if chain (Session 1) ------------------------------
        // Declare an int called gold set to 75. Then write a chain that
        // logs exactly ONE line:
        //   gold is 100 or more  → "B3: Rich"
        //   gold is 50 or more   → "B3: Comfortable"
        //   anything else        → "B3: Broke"
        //
        // Expected output:  B3: Comfortable

        // TODO


        // =====================================================================
        // PART C — FIX IT
        // Uncomment each block, read what the compiler or Console tells you,
        // and fix it. (Same rules as the Error Gauntlets.)
        // =====================================================================


        // --- C1 — compile error -------------------------------------------------
        // Expected output:  C1: 0.3
        // float dropRate = 0.3;
        // Debug.Log("C1: " + dropRate);


        // --- C2 — logic error -----------------------------------------------------
        // This compiles and runs, but the sum is wrong.
        // Expected output:  C2 Sum: 18  — but it logs 7. Find the bug.
        // int[] runes = { 5, 6, 7 };
        // int runeSum = 0;
        // for (int i = 0; i < runes.Length; i++) {
        //     runeSum = runes[i];
        // }
        // Debug.Log("C2 Sum: " + runeSum);


        // =====================================================================
        // DONE — score yourself
        // 6 predictions + 3 writes + 2 fixes = 11 items.
        //   9–11 solid: you're ready for Session 3.
        //   6–8: fine — re-read the parts that surprised you.
        //   under 6: bring your questions to the next session; that's what
        //            it's for. Nothing here is graded.
        // =====================================================================
    }
}

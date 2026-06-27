using UnityEngine;

// Session 4 — INTRODUCTION
//
// Just watch and follow along — you don't need to type this one perfectly.
// Right after, you'll build your OWN class from scratch in the Exercise.
//
// Today's question: how do we make code represent a THING — an enemy, a
// player — instead of a pile of loose, disconnected variables?

public class Session04_Intro : MonoBehaviour
{
    void Start()
    {
        // =================================================================
        // BEAT 1 — the old way: loose, disconnected pieces
        // To remember one enemy we need two variables. For two enemies, four.
        // And nothing connects a name to its own health — we can mix them up
        // and C# won't notice.
        // =================================================================

        // ▶ TYPE LIVE: two enemies as four loose variables; log them; then
        //   log goblinName together with skeletonHealth and watch the nonsense.


        // =================================================================
        // BEAT 2 — the idea: bundle data + actions into one unit (an object)
        // A car HAS things (make, model, color) and DOES things (start, stop,
        // move) — one thing, not scattered pieces. A class lets us define a
        // brand-new kind of thing the same way: the data it carries are
        // FIELDS, the things it can do are METHODS.
        // (Our blueprint is the Player class at the bottom of this file.)
        // =================================================================


        // =================================================================
        // BEAT 3 — class = blueprint, object = one stamped out with `new`
        // We make two players from the single Player blueprint. Each gets its
        // OWN name and score, and acts on its own data.
        // =================================================================

        // ▶ TYPE LIVE: make two Players; give them names and scores; score Ana
        //   twice; then prove Bo is untouched; then check who IsWinning().

    }
}


// =====================================================================
// The blueprint. We build it together — fields first, then a method, then
// a question-answering (bool) method.
// =====================================================================

public class Player
{
    // ▶ TYPE LIVE: fields (name, score), then AddPoints(int points),
    //   then IsWinning().
}

using UnityEngine;

// Session 4 — INTRODUCTION   (COMPLETED — filled-in reference)
//
// The live demo, built together on the projector. Students watched this, then
// built their own Enemy in the Exercise. Console output shown after each beat.
//
// Today's question: how do we make code represent a THING — an enemy, a
// player — instead of a pile of loose, disconnected variables?

public class Session04_Intro : MonoBehaviour {
    void Start() {
        // =================================================================
        // BEAT 1 — the old way: loose, disconnected pieces
        // To remember one enemy we need two variables. For two enemies, four.
        // And nothing connects a name to its own health — we can mix them up
        // and C# won't notice.
        // =================================================================

        string goblinName = "Goblin";
        int goblinHealth = 30;
        string skeletonName = "Skeleton";
        int skeletonHealth = 12;

        Debug.Log(goblinName + " has " + goblinHealth + " HP");
        Debug.Log(skeletonName + " has " + skeletonHealth + " HP");
        Debug.Log(goblinName + " has " + skeletonHealth + " HP");   // the mix-up
        // Output:
        //   Goblin has 30 HP
        //   Skeleton has 12 HP
        //   Goblin has 12 HP        <- nonsense, and C# never complains


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
        // Two players from the single Player blueprint. Each gets its OWN
        // name and score, and acts on its own data.
        // =================================================================

        Player ana = new Player();
        ana.name = "Ana";
        ana.score = 0;

        Player bo = new Player();
        bo.name = "Bo";
        bo.score = 0;

        ana.AddPoints(70);
        ana.AddPoints(40);
        // Output:
        //   Ana scores 70! Total: 70
        //   Ana scores 40! Total: 110

        // The punchline — Bo was never touched, so Bo is untouched:
        Debug.Log(bo.name + "'s score is still " + bo.score);
        // Output: Bo's score is still 0

        // A method that answers a yes/no question (Session 3, Part 5):
        Debug.Log(ana.name + " winning? " + ana.IsWinning());   // True
        Debug.Log(bo.name + " winning? " + bo.IsWinning());     // False

        // The Session 3 link: AddPoints only needed the points — Ana already
        // knows her own name and score. The data lives ON the object now.
    }
}


// =====================================================================
// Player — the blueprint we built together: fields, then a method, then
// the bool method.
// =====================================================================

public class Player {
    // FIELDS — what every player HAS
    public string name;
    public int score;

    // METHOD — what a player can DO (acts on its OWN score)
    public void AddPoints(int points) {
        score = score + points;
        Debug.Log(name + " scores " + points + "! Total: " + score);
    }

    // a method that answers a question
    public bool IsWinning() {
        return score >= 100;
    }
}

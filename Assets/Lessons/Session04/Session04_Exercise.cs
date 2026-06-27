using UnityEngine;

// Session 4 Exercise — Classes & Objects
//
// You just saw the idea in the Intro: a class bundles data + actions into one
// "thing," and `new` stamps out objects from it. Now build your own — an Enemy.
//
// Work through each part in order. Type everything yourself — no copy-paste.
// Press Play after each part to check your output before moving on.
//
// TWO FILES: this runner (attached to LessonRunner) is where code RUNS — in
// Start, like always. The Enemy.cs file is where you DESIGN the enemy. Each
// part tells you which file you're in.

public class Session04_Exercise : MonoBehaviour
{
    void Start()
    {
        // =====================================================================
        // PART 1 — The blueprint: a class  [in Enemy.cs]
        // In the Intro, the Player class was a blueprint: it described what
        // every player HAS (fields) without being any one player. You'll do the
        // same for an enemy.
        //
        // The data inside a class are called FIELDS — variables that live on
        // the object instead of loose in Start. Marking a field `public` lets
        // other files (like this one) read and change it.
        //
        //   public class Potion
        //   {
        //       public string label;   // a field
        //       public int healing;    // a field
        //   }
        //
        // This part has no output of its own — you're drawing the blueprint;
        // Part 2 stamps out the first enemy from it.
        //
        // TODO: Open Enemy.cs. In the FIELDS section, give Enemy two fields:
        // a name, and its health.
        // =====================================================================


        // =====================================================================
        // PART 2 — Making one: `new`, and reaching its data
        // A class is just the blueprint. To get an actual enemy you CREATE one
        // with `new` — that's an instance. You saw
        // this with Players in the Intro; now it's your Enemy.
        //
        //   Potion big = new Potion();   // make one
        //   big.label = "Elixir";        // reach a field with a dot
        //   big.healing = 50;
        //   Debug.Log(big.label);        // read it back the same way
        //
        // TODO: Here in Start(), create two enemies with `new`. Give the first
        // the name "Goblin" and health 30; give the second "Skeleton" and 12.
        // Then log each as  name + " has " + health + " HP."  — reading the
        // values back off each object.
        //
        // Expected output:
        //   Goblin has 30 HP.
        //   Skeleton has 12 HP.
        //
        // Same idea as the loose variables from the Intro — except now each
        // enemy's two values travel together as ONE thing. Make a third enemy
        // if you want to prove each one carries its own separate data.
        // =====================================================================

        // TODO: your `new` enemies and logs go here.


        // =====================================================================
        // PART 3 — Giving an enemy behaviour  [in Enemy.cs]
        // A class can hold methods too, not just fields. A method written
        // inside Enemy works on THAT enemy's own data — when it says `health`,
        // it means the health of whichever enemy you called it on. Same method,
        // different enemy each time. (Remember Ana and Bo each scoring their own
        // points in the Intro.)
        //
        //   // inside the class:
        //   public void Drink()
        //   {
        //       Debug.Log(label + " restores " + healing);
        //   }
        //   // outside:
        //   big.Drink();    // uses big's own label and healing
        //
        // TODO (in Enemy.cs, METHODS section):
        //   1. TakeDamage(int amount): subtract amount from this enemy's health,
        //      then log  name + " takes " + amount + " damage! Health now: " + health
        //   2. IsDead(): return whether this enemy's health has reached 0 or below
        //      (a method that answers a true/false question — Session 3, Part 5).
        //
        // TODO (back here): take your Goblin and Skeleton from Part 2 and:
        //   - hit the Goblin for 10
        //   - hit the Skeleton for 5, then again for 10
        //   - then, in an if/else, report whether the Skeleton IsDead():
        //       log  name + " is down!"  or  name + " fights on."
        //
        // Expected output:
        //   Goblin takes 10 damage! Health now: 20
        //   Skeleton takes 5 damage! Health now: 7
        //   Skeleton takes 10 damage! Health now: -3
        //   Skeleton is down!
        // =====================================================================

        // TODO: your TakeDamage / IsDead calls go here.


        // =====================================================================
        // PART 4 — The constructor: set it up on creation  [in Enemy.cs]  [NEW]
        // In Part 2 you made an enemy, THEN set its name, THEN its health —
        // three lines for one enemy. A CONSTRUCTOR lets you do it all at once,
        // the moment you create it.
        //
        // A constructor is a special method inside the class. Its name is
        // exactly the class name, and it has no return type:
        //
        //   public class Potion
        //   {
        //       public string label;
        //       public int healing;
        //
        //       public Potion(string label, int healing)
        //       {
        //           this.label = label;       // `this.label` = the field
        //           this.healing = healing;   // `label` (no this) = the parameter
        //       }
        //   }
        //
        //   Potion big = new Potion("Elixir", 50);   // one line — done
        //
        // `this` means "the object being set up right now." You need it here
        // because the field and the parameter share a name; `this.label` is the
        // field, plain `label` is the parameter handed in.
        //
        // HEADS UP: the moment Enemy has a constructor, `new Enemy()` with empty
        // parentheses STOPS working — C# only gave you that free empty version
        // while no constructor existed. That's fine: you're about to replace
        // those calls anyway.
        //
        // TODO (in Enemy.cs): add the constructor — name and starting health.
        // TODO (back here): rewrite your Part 2 Goblin and Skeleton as ONE line
        //   each using the constructor, and delete the old field-setting lines.
        //   The output should be identical.
        // =====================================================================


        // =====================================================================
        // PART 5 — The payoff: a whole horde
        // Everything you've built, together. An array can hold enemies just like
        // it held ints in Session 2 — and you build each one with the
        // constructor right inside the braces:
        //
        //   Potion[] shelf = {
        //       new Potion("Elixir", 50),
        //       new Potion("Tonic", 10)
        //   };
        //
        // TODO: Make an Enemy[] called horde with three enemies of your choice
        // (use these to match the expected output):
        //   "Goblin" 30, "Orc" 50, "Slime" 8
        // Log "A fireball hits the horde!" once. Then loop over the array
        // (Session 2 — i < horde.Length): hit each enemy for 25, and if that one
        // IsDead(), log  name + " was destroyed!"
        //
        // Expected output:
        //   A fireball hits the horde!
        //   Goblin takes 25 damage! Health now: 5
        //   Orc takes 25 damage! Health now: 25
        //   Slime takes 25 damage! Health now: -17
        //   Slime was destroyed!
        //
        // Look at everything in that one loop: an array, a for loop, a method
        // call on each object, a method that returns a bool, and an if. That's
        // Sessions 1 through 4 working together.
        // =====================================================================

        // TODO: your horde array and loop go here.


        // =====================================================================
        // PART 6 — Error Gauntlet
        //
        // 10 broken snippets. For each one:
        //   1. Uncomment it (remove the // from every line of that challenge —
        //      and from its broken class at the very bottom of the file, when
        //      the challenge has one).
        //   2. Save — read what the Console or compiler tells you.
        //   3. Fix it.
        //   4. Press Play to confirm the expected output.
        //   5. Leave it fixed and move to the next.
        //
        // Challenges 1–6 are compile errors — Unity won't run until they're
        // fixed. Challenges 7–10 compile fine but print the WRONG thing; you
        // have to reason out why. Some bugs are here at the call site, some are
        // down in the broken class — deciding where to look is the skill.
        // =====================================================================


        // --- Challenge 1 (compile) ---
        // A bandit should appear with 15 HP.
        // Expected: Bandit appears with 15 HP.
        // --- Code ---
        // Enemy bandit = Enemy("Bandit", 15);
        // Debug.Log(bandit.name + " appears with " + bandit.health + " HP.");


        // --- Challenge 2 (compile) ---
        // Report the wolf's HP.
        // Expected: Wolf HP: 20
        // --- Code ---
        // Enemy wolf = new Enemy("Wolf", 20);
        // Debug.Log("Wolf HP: " + wolf.helth);


        // --- Challenge 3 (compile) ---
        // A 3-HP rat takes 5 damage and should be dead.
        // Expected:
        //   Rat takes 5 damage! Health now: -2
        //   Rat is dead.
        // --- Code ---
        // Enemy rat = new Enemy("Rat", 3);
        // rat.TakeDamage(5);
        // if (rat.IsDead)
        // {
        //     Debug.Log(rat.name + " is dead.");
        // }


        // --- Challenge 4 (compile) ---
        // Create a ghost with 18 HP.
        // Expected: Ghost has 18 HP.
        // --- Code ---
        // Enemy ghost = new Enemy("Ghost");
        // Debug.Log(ghost.name + " has " + ghost.health + " HP.");


        // --- Challenge 5 (compile) --- (also uncomment class Coin at the bottom)
        // A coin worth 5.
        // Expected: Coin worth: 5
        // --- Code ---
        // Coin coin = new Coin(5);
        // Debug.Log("Coin worth: " + coin.value);


        // --- Challenge 6 (compile) ---
        // A troll with 40 HP.
        // Expected: Troll has 40 HP.
        // --- Code ---
        // Enemy troll = new Enemy(40, "Troll");
        // Debug.Log(troll.name + " has " + troll.health + " HP.");


        // --- Challenge 7 (logic) --- (also uncomment class Dummy at the bottom)
        // A 20-HP dummy is hurt for 5.
        // Expected: Dummy health: 15  — but it logs 5. Why?
        // --- Code ---
        // Dummy dummy = new Dummy();
        // dummy.Hurt(5);
        // Debug.Log("Dummy health: " + dummy.health);


        // --- Challenge 8 (logic) --- (also uncomment class Chest at the bottom)
        // A chest holding 100 gold.
        // Expected: Chest gold: 100  — but it logs 0. The bug is in the class.
        // --- Code ---
        // Chest chest = new Chest(100);
        // Debug.Log("Chest gold: " + chest.gold);


        // --- Challenge 9 (logic) --- (also uncomment class Foe at the bottom)
        // A foe at exactly 0 HP should count as dead.
        // Expected: Foe is dead.  — but it logs "Foe still standing." Why?
        // --- Code ---
        // Foe foe = new Foe(0);
        // if (foe.IsDead())
        // {
        //     Debug.Log("Foe is dead.");
        // }
        // else
        // {
        //     Debug.Log("Foe still standing.");
        // }


        // --- Challenge 10 (logic) ---
        // backup is meant to be a SEPARATE enemy from hero, so hitting it should
        // leave hero untouched.
        // Expected: Hero health: 100  — but it logs 60. What does `= hero` really do?
        // --- Code ---
        // Enemy hero = new Enemy("Hero", 100);
        // Enemy backup = hero;
        // backup.TakeDamage(40);
        // Debug.Log(hero.name + " health: " + hero.health);
    }
}


// =============================================================================
// GAUNTLET CLASSES (Part 6)
// Small throwaway classes for the gauntlet challenges. Each ships BROKEN.
// Uncomment a class only when you reach its challenge, fix it, and move on.
// They live out here, outside the class above — a file can hold more than one
// class.
// =============================================================================

// Challenge 5
// public class Coin
// {
//     public int value;
//
//     public Coyn(int value)
//     {
//         this.value = value;
//     }
// }

// Challenge 7
// public class Dummy
// {
//     public int health = 20;
//
//     public void Hurt(int amount)
//     {
//         health = amount;
//     }
// }

// Challenge 8
// public class Chest
// {
//     public int gold;
//
//     public Chest(int gold)
//     {
//     }
// }

// Challenge 9
// public class Foe
// {
//     public int health;
//
//     public Foe(int health)
//     {
//         this.health = health;
//     }
//
//     public bool IsDead()
//     {
//         return health < 0;
//     }
// }

using UnityEngine;

// Session 4 Exercise — Classes & Objects   (COMPLETED — filled-in reference)
//
// You saw the idea in the Intro: a class bundles data + actions into one
// "thing," and `new` stamps out objects from it. Here you built your own — an
// Enemy. This copy has every part filled in, with the Console output shown
// after each one.
//
// TWO FILES: this runner (attached to LessonRunner) is where code RUNS — in
// Start. The Enemy.cs file is where the enemy is DESIGNED.

public class Session04_Exercise : MonoBehaviour {
    void Start() {
        // =====================================================================
        // PART 1 — The blueprint: a class  [in Enemy.cs]
        // A class bundles related data under one name — a blueprint. The data
        // inside are FIELDS: variables that live on the object instead of loose
        // in Start. `public` lets other files read and change them.
        //
        //   public class Potion {
        //       public string label;   // a field
        //       public int healing;    // a field
        //   }
        // =====================================================================

        // (Done in Enemy.cs — the FIELDS section holds `name` and `health`.)


        // =====================================================================
        // PART 2 — Making one: `new`, and reaching its data
        // A class is just the blueprint. To get an actual enemy you CREATE one
        // with `new` — that's an instance. Reach a field with a dot.
        //
        //   Potion big = new Potion();   // make one
        //   big.label = "Elixir";        // reach a field with a dot
        //   Debug.Log(big.label);        // read it back the same way
        // =====================================================================

        // First written the long way (new Enemy(); then set each field). Once
        // the constructor existed (Part 4) these collapsed to one line each:
        Enemy goblin = new Enemy("Goblin", 30);
        Enemy skeleton = new Enemy("Skeleton", 12);
        Debug.Log(goblin.name + " has " + goblin.health + " HP.");
        Debug.Log(skeleton.name + " has " + skeleton.health + " HP.");
        // Output:
        //   Goblin has 30 HP.
        //   Skeleton has 12 HP.


        // =====================================================================
        // PART 3 — Giving an enemy behaviour  [in Enemy.cs]
        // A class can hold methods too. A method written inside Enemy works on
        // THAT enemy's own data — when it says `health`, it means the health of
        // whichever enemy you called it on.
        //
        //   // inside the class:
        //   public void Drink() {
        //       Debug.Log(label + " restores " + healing);
        //   }
        //   // outside:
        //   big.Drink();    // uses big's own label and healing
        //
        // TakeDamage and IsDead are defined in Enemy.cs; called here:
        // =====================================================================

        goblin.TakeDamage(10);
        skeleton.TakeDamage(5);
        skeleton.TakeDamage(10);

        if (skeleton.IsDead()) {
            Debug.Log(skeleton.name + " is down!");
        } else {
            Debug.Log(skeleton.name + " fights on.");
        }
        // Output:
        //   Goblin takes 10 damage! Health now: 20
        //   Skeleton takes 5 damage! Health now: 7
        //   Skeleton takes 10 damage! Health now: -3
        //   Skeleton is down!


        // =====================================================================
        // PART 4 — The constructor: set it up on creation  [in Enemy.cs]  [NEW]
        // Instead of making an enemy THEN setting each field, a CONSTRUCTOR does
        // it all at once. Its name is exactly the class name and it has no
        // return type:
        //
        //   public Potion(string label, int healing) {
        //       this.label = label;       // `this.label` = the field
        //       this.healing = healing;   // `label` (no this) = the parameter
        //   }
        //
        //   Potion big = new Potion("Elixir", 50);   // one line — done
        //
        // `this` means "the object being set up right now." The moment Enemy has
        // a constructor, `new Enemy()` with empty parentheses stops working —
        // which is why Part 2's enemies were rewritten to the one-line form.
        // =====================================================================

        // (Constructor added in Enemy.cs; Part 2's enemies above already use it.)


        // =====================================================================
        // PART 5 — The payoff: a whole horde
        // Everything together. An array holds enemies just like it held ints in
        // Session 2, and each is built with the constructor right in the braces.
        // =====================================================================

        Enemy[] horde = {
            new Enemy("Goblin", 30),
            new Enemy("Orc", 50),
            new Enemy("Slime", 8)
        };

        Debug.Log("A fireball hits the horde!");
        for (int i = 0; i < horde.Length; i++) {
            horde[i].TakeDamage(25);
            if (horde[i].IsDead()) {
                Debug.Log(horde[i].name + " was destroyed!");
            }
        }
        // Output:
        //   A fireball hits the horde!
        //   Goblin takes 25 damage! Health now: 5
        //   Orc takes 25 damage! Health now: 25
        //   Slime takes 25 damage! Health now: -17
        //   Slime was destroyed!
        //
        // One loop: an array, a for loop, a method call on each object, a method
        // that returns a bool, and an if. Sessions 1–4 working together.


        // =====================================================================
        // PART 6 — Error Gauntlet  (all shown fixed)
        // Challenges 1–6 were compile errors; 7–10 compiled but printed the
        // wrong thing. Each is shown corrected, with a note on what was broken.
        // =====================================================================

        // --- Challenge 1 (compile) --- FIX: missing `new`
        // A bandit should appear with 15 HP.
        Enemy bandit = new Enemy("Bandit", 15);
        Debug.Log(bandit.name + " appears with " + bandit.health + " HP.");
        // Output: Bandit appears with 15 HP.

        // --- Challenge 2 (compile) --- FIX: the field is `health`, not `helth`
        Enemy wolf = new Enemy("Wolf", 20);
        Debug.Log("Wolf HP: " + wolf.health);
        // Output: Wolf HP: 20

        // --- Challenge 3 (compile) --- FIX: IsDead is a method — needs ()
        Enemy rat = new Enemy("Rat", 3);
        rat.TakeDamage(5);
        if (rat.IsDead()) {
            Debug.Log(rat.name + " is dead.");
        }
        // Output:
        //   Rat takes 5 damage! Health now: -2
        //   Rat is dead.

        // --- Challenge 4 (compile) --- FIX: constructor needs name AND health
        Enemy ghost = new Enemy("Ghost", 18);
        Debug.Log(ghost.name + " has " + ghost.health + " HP.");
        // Output: Ghost has 18 HP.

        // --- Challenge 5 (compile) --- FIX: constructor name must match the class (Coin)
        Coin coin = new Coin(5);
        Debug.Log("Coin worth: " + coin.value);
        // Output: Coin worth: 5

        // --- Challenge 6 (compile) --- FIX: argument order — string first, then int
        Enemy troll = new Enemy("Troll", 40);
        Debug.Log(troll.name + " has " + troll.health + " HP.");
        // Output: Troll has 40 HP.

        // --- Challenge 7 (logic) --- FIX (in class): subtract, don't overwrite
        Dummy dummy = new Dummy();
        dummy.Hurt(5);
        Debug.Log("Dummy health: " + dummy.health);
        // Output: Dummy health: 15   (was 5 — Hurt did `health = amount`)

        // --- Challenge 8 (logic) --- FIX (in class): constructor must store its param
        Chest chest = new Chest(100);
        Debug.Log("Chest gold: " + chest.gold);
        // Output: Chest gold: 100   (was 0 — the constructor ignored `gold`)

        // --- Challenge 9 (logic) --- FIX (in class): dead means health <= 0, not < 0
        Foe foe = new Foe(0);
        if (foe.IsDead()) {
            Debug.Log("Foe is dead.");
        } else {
            Debug.Log("Foe still standing.");
        }
        // Output: Foe is dead.   (was "still standing" — `< 0` is false at exactly 0)

        // --- Challenge 10 (logic) --- FIX: `= hero` aliases; make a real separate enemy
        Enemy hero = new Enemy("Hero", 100);
        Enemy backup = new Enemy("Backup", 100);
        backup.TakeDamage(40);
        Debug.Log(hero.name + " health: " + hero.health);
        // Output:
        //   Backup takes 40 damage! Health now: 60
        //   Hero health: 100
        // KEY IDEA: `Enemy backup = hero;` does NOT copy — both names point at
        // the SAME object, so damaging one damages both. Use `new` for a
        // separate enemy.
    }
}


// =============================================================================
// GAUNTLET CLASSES (Part 6) — shown FIXED.
// Small throwaway classes for the gauntlet challenges. A file can hold more
// than one class.
// =============================================================================

// Challenge 5 — FIX: constructor renamed Coyn -> Coin (must match class name).
public class Coin {
    public int value;

    public Coin(int value) {
        this.value = value;
    }
}

// Challenge 7 — FIX: subtract instead of overwrite.
public class Dummy {
    public int health = 20;

    public void Hurt(int amount) {
        health = health - amount;
    }
}

// Challenge 8 — FIX: store the parameter into the field.
public class Chest {
    public int gold;

    public Chest(int gold) {
        this.gold = gold;
    }
}

// Challenge 9 — FIX: <= 0 so exactly-0 HP counts as dead.
public class Foe {
    public int health;

    public Foe(int health) {
        this.health = health;
    }

    public bool IsDead() {
        return health <= 0;
    }
}

using UnityEngine;

// Enemy.cs — Session 4
//
// A SECOND file. Until now everything lived in one script attached to
// LessonRunner. This file is different — it is NOT attached to any GameObject,
// and it is NOT a MonoBehaviour. It is a plain class: a blueprint.
//
// A blueprint describes what every Enemy HAS (its data) and what every Enemy
// can DO (its behaviour). The class itself does nothing on its own! Over in
// Session04_Exercise.cs you stamp out actual enemies FROM this blueprint using
// the word `new` — and each one gets its own private copy of the data described
// here. One class, many enemies.
//
// Built across Parts 1, 3, and 4 of the exercise.

public class Enemy {
    // --- FIELDS (Part 1) -------------------------------------------------
    // The data every enemy carries around.
    public string name;
    public int health;

    // --- CONSTRUCTOR (Part 4) --------------------------------------------
    // Sets a fresh enemy up the instant it's created:  new Enemy("Goblin", 30)
    public Enemy(string name, int health) {
        this.name = name;       // this.name = the field; name = the parameter
        this.health = health;
    }

    // --- METHODS (Part 3) ------------------------------------------------
    // The things an enemy can DO. A method works on THIS enemy's own data.
    public void TakeDamage(int amount) {
        health = health - amount;
        Debug.Log(name + " takes " + amount + " damage! Health now: " + health);
    }

    public bool IsDead() {
        return health <= 0;
    }
}

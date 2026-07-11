using UnityEngine;

// Hero.cs — Session 5, Part 9
//
// A second file, same pattern as Session 4: a plain class (NOT a MonoBehaviour,
// not attached to anything) that the runner script creates with `new`.
//
// You built exactly this shape last week with Enemy. Build this one from
// memory — fields, then a constructor, then the methods. Peek at your
// Session 4 files only if you're genuinely stuck.
//
// (Why "Hero" and not "Player"? Session 4's intro already has a Player class,
// and two classes in the project can't share a name — a real Unity rule you
// just ran into for free.)
//
// (And why no ": MonoBehaviour" after the class name? That suffix turns a
// class into a Unity component — Unity creates those itself when you attach
// them to a GameObject, and you're not allowed to `new` one. Hero is created
// by YOUR code — new Hero(...) — so it stays a plain class. Rule of thumb:
//   lives in the scene, Unity runs it  -> MonoBehaviour
//   data + actions your code owns      -> plain class)

public class Hero {
    // --- FIELDS ---
    // A name, and a health value.


    // --- CONSTRUCTOR ---
    // Takes the name and the starting health.


    // --- METHODS ---
    // TakeDamage(int amount) — subtract from health, then log:
    //   name + " takes " + amount + " damage! Health: " + health
    // IsDead() — answers true when health has reached 0 or below.

}

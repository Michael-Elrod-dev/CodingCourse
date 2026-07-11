using UnityEngine;
using UnityEngine.InputSystem;

// Session 5 Exercise — Making It Move
// Lifecycle (Start / Update), Transform, Input — then everything you know, live.
//
// Today we're going to write a script from scratch that moves a cube around to
// learn about built-in Unity functionality and practice everything we've learned.
//
// SETUP: put this script on a Cube in the scene. A script controls the object it lives on,
// and the cube is what we want to move. Press Play and watch the Game view.
//
// ALSO drop the provided Session05_Arena script onto the same cube. Right now it
// doesn't do anything yet, but we'll use it later to add some visuals to our exercise.
//
// TWO FILES, eventually: in Part 9 you'll also build a Hero class in
// Hero.cs — the same two-file pattern as Session 4.
//
// Work in order. Type everything yourself — no copy-paste. Parts 1–4 introduce
// the new ideas; Parts 5–9 are where you COMBINE them with everything from
// Sessions 1–4.
//
// About ": MonoBehaviour" below — that suffix makes this class a Unity
// COMPONENT: something you can attach to a GameObject, that Unity itself
// creates and runs. It's the only reason Unity calls Start and Update for
// you, and why `transform` works in here. Compare Hero.cs (Part 9): no
// ": MonoBehaviour" — a plain class that YOUR code creates with `new`.
//   Lives in the scene, Unity runs it  -> MonoBehaviour (never `new` one)
//   Data + actions your code owns      -> plain class   (`new` is the point)
public class Session05_Exercise : MonoBehaviour {
    // =========================================================================
    // FIELDS — variables that live on the script, OUTSIDE the methods.
    // Several parts will tell you something belongs up here: a variable the
    // whole script can see, that survives from frame to frame. The parts
    // describe WHAT to declare — writing it is your job.
    // =========================================================================

    // TODO: fields appear here as the parts ask for them.


    void Start() {
        // =====================================================================
        // PART 1 — Start vs Update: the lifecycle  [NEW]
        // Unity calls two methods for you, automatically — you never call them
        // yourself:
        //   Start()  — runs ONCE, the moment the object wakes up.
        //   Update() — runs EVERY FRAME, ~60 times a second, forever.
        //
        // KEY IDEA for this whole session: Update is a LOOP. Session 2's loops
        // ran all at once and finished; this one runs forever, live, one pass
        // per frame. Every loop skill you have still applies here.
        //
        // So what decides how fast that loop runs? Nothing in your code — the
        // frame rate does. By default Unity draws frames as fast as your
        // machine can (usually capped by VSync to your monitor's refresh
        // rate — 60, 144...). Click the Stats button in the Game view while
        // playing: that FPS number = how many times Update ran last second.
        // Different machines, different FPS. Remember that — it becomes
        // important later on.
        //
        // TODO (here): log "Start ran once."
        // TODO (in Update below): log "Update ran this frame."
        // Press Play, watch the Console flood — then COMMENT OUT the Update log.
        // =====================================================================

        // TODO: your Start log goes here.
    }


    void Update() {
        // TODO (Part 1): your Update log goes here (comment out after you see it).


        // =====================================================================
        // PART 2 — Your first movement: transform.Translate
        // Every GameObject has a Transform — its position, rotation, and scale.
        // Nudge it a little every frame and it moves:
        //
        //   transform.Translate(0.02f, 0, 0);   // slide along X each frame
        //
        // TODO: make the cube drift along X. Press Play — it slides. (Its speed
        // secretly depends on your frame rate. Part 3 fixes that.)
        // =====================================================================

        // TODO: your Part 2 drift goes here (it evolves in Parts 3 and 4).


        // =====================================================================
        // PART 3 — Speed you control: Time.deltaTime + Vector3  [NEW]
        //
        //   transform.Translate(Vector3.right * speed * Time.deltaTime);
        //
        //   Vector3.right   = the direction (1, 0, 0). Also .left .up .down.
        //   speed           = a field YOU add, in units per SECOND.
        //   Time.deltaTime  = seconds since the last frame. Multiplying by it
        //                     makes motion per-second — identical on every machine.
        //
        // TODO: in the FIELDS section, declare a public float called speed,
        // set to 5f. Making it public puts it in the Inspector — select the
        // cube and it's right there on the component. Then upgrade your
        // Part 2 line to the form above, and try changing speed in the
        // Inspector while the game is running.
        // =====================================================================


        // =====================================================================
        // PART 4 — Make it listen: Input  [NEW]
        // Move only WHILE a key is held. The Input System reads the keyboard:
        //
        //   if (Keyboard.current.rightArrowKey.isPressed) {
        //       transform.Translate(Vector3.right * speed * Time.deltaTime);
        //   }
        //
        //   .isPressed is true the whole time the key is held down.
        //
        // TODO: turn your movement into FOUR if-checks — right, left, up, down
        // arrows, each moving that direction. Drive the cube around.
        // =====================================================================


        // =====================================================================
        // PART 5 — Sprint  (goal, not recipe)
        // GOAL: while Left Shift is held, the cube moves TWICE as fast.
        //
        // You know everything you need: an if, a variable, multiplication, and
        //   Keyboard.current.leftShiftKey.isPressed
        //
        // HINT: decide the speed for THIS frame in a variable before the four
        // movement ifs, and use that variable in all four.
        //
        // CHECK: drive around, tap Shift on and off — you should feel it.
        // =====================================================================


        // =====================================================================
        // PART 6 — Walls  (reading and WRITING position)
        // The cube can fly clean off the screen. Let's build an arena around
        // it: x from -8 to 8, y from -4 to 4.
        //
        // You can READ where the cube is:   transform.position.x
        // You can WRITE a whole position:   transform.position = new Vector3(x, y, z);
        //
        // Wait — new? A constructor?! Yes: Vector3 is a class-like type, and you
        // learned exactly what  new Vector3(8f, 2f, 0f)  means last week.
        //
        // One wall as an example — the right wall:
        //
        //   if (transform.position.x > 8f) {
        //       transform.position = new Vector3(8f, transform.position.y, transform.position.z);
        //   }
        //
        // (Read it: "if you've gone past 8, put yourself back at exactly 8,
        //  keeping your current y and z.")
        // Show how rendering happens last in the game loop.
        //
        // TODO: add the right wall, confirm it works, then build the other
        // THREE walls yourself (left -8, top 4, bottom -4).
        // CHECK: you can drive around but never escape... an arena you can't
        // even see. You just built invisible walls — and that's exactly what
        // they'd stay in a real game until an artist dresses them.
        //
        // Add ONE line up in Start:
        //
        //   Session05_Arena.showWalls = true;
        //
        // (Read it with Session 4 eyes: showWalls is a field on the provided
        // Session05_Arena class — one that belongs to the CLASS itself, so you
        // flip it by class name. You've been READING members like that all
        // day: Vector3.right, Time.deltaTime, Keyboard.current. Now you get
        // to WRITE one.)
        // CHECK: press Play — walls, exactly where your numbers put them.
        // =====================================================================


        // =====================================================================
        // PART 7 — Clean it up: methods  (Session 3, for real)
        // Look at Update. It's a wall of code — and we're not done adding. This
        // is exactly what methods are for. The goal: Update should read like a
        // TABLE OF CONTENTS — nothing in it but a short list of method calls,
        // one per job.
        //
        // TODO: create two void methods in the YOUR METHODS section below —
        // HandleMovement and KeepInsideArena — and MOVE your code into them:
        // movement + sprint into the first, the four walls into the second.
        // Then Update just calls one, then the other.
        // CHECK: the game behaves EXACTLY the same as before. That's the point —
        // a cleanup that changes nothing is called a refactor, and proving
        // "same behavior" is how you know it worked.
        // =====================================================================


        // =====================================================================
        // PART 8 — The survival clock  (fields vs locals — the deep one)
        // GOAL: track how long you've survived, and log a milestone at 10s,
        // 20s, 30s... exactly ONCE each.
        //
        // THE KEY IDEA: a variable declared INSIDE Update is reborn every frame
        // — it can't remember anything. A FIELD lives on the script and
        // survives across frames. (Session 2 again: the accumulator goes
        // OUTSIDE the loop. Update is the loop.)
        //
        // HOW: Time.deltaTime isn't just for multiplying — it IS this frame's
        // slice of time, in seconds. Add it onto a float field every frame,
        // and that field becomes a stopwatch.
        //
        // TRAP (feel it first): if (timeAlive >= 10f) { Debug.Log(...); }
        // logs every frame after 10s — a flood, like Part 1. You need a field
        // that remembers the NEXT milestone, and moves it forward when hit.
        //
        // TODO: make a TrackSurvival() method, call it from Update, and get:
        //   Survived 10 seconds!        (once)
        //   Survived 20 seconds!        (once)   ... and so on.
        // =====================================================================


        // =====================================================================
        // PART 9 — THE GAME: lava walls  (everything you know)
        // Those walls you revealed? They're lava. Touching any wall burns —
        // 25 damage per full second of contact. Run out of health: GAME OVER,
        // and the cube stops responding. You are building this with ZERO new
        // concepts. Steps:
        //
        //   1. In Hero.cs: build the Hero class from scratch — name, health,
        //      constructor, TakeDamage(int), IsDead(). You built this exact
        //      shape last week. (Why not "Player"? Session 4's intro already
        //      owns that class name — two classes can't share one.)
        //
        //   2. Fields here: a Hero, and a bool gameOver flag (starts false).
        //      Then in Start, fill that field with a brand-new Hero — pick a
        //      name, give them 100 health. (Session 4: one `new`, one
        //      constructor call.)
        //
        //   3. A bool method TouchingLava() — true when the cube is AT any wall
        //      (position >= 8, <= -8, etc. — a method that answers a question).
        //
        //   4. A CheckLava() method, called from Update:
        //      - while TouchingLava(), accumulate a burn timer (Part 8's trick);
        //        every time it reaches 1 second: hero.TakeDamage(25), reset
        //        the timer. Step away from the wall? Reset the timer too.
        //      - if hero.IsDead(): log "GAME OVER — <name> melted." and set
        //        gameOver to true.
        //
        //   5. At the very TOP of Update: if the game is over, return — so
        //      nothing below it ever runs. (A bare `return` with no value is
        //      allowed in a void method — Session 3's "return exits
        //      immediately." Dead players don't move.)
        //
        //   6. Working? Then flip the second switch up in Start:
        //
        //        Session05_Arena.showBurnGlow = true;
        //
        //      Now the damage you wired up is something you can SEE.
        //
        // CHECK: hug a wall — you glow red-hot and damage ticks once per
        // second. At 0 HP everything freezes. Survive the lava as long as you
        // can. That log line at the end? That's your high score.
        // =====================================================================
    }


    // =========================================================================
    // YOUR METHODS — Parts 7, 8, 9
    // Class level, outside Start and Update — same as Sessions 3 and 4.
    // =========================================================================

    // TODO (Part 7): HandleMovement()  and  KeepInsideArena()

    // TODO (Part 8): TrackSurvival()

    // TODO (Part 9): TouchingLava()  and  CheckLava()

}

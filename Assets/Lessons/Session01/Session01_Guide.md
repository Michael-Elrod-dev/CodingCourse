# Session 1 — Instructor Guide
## Variables, Types & Conditionals

**Session length:** ~50 minutes  
**Files used:** `Session01_Demo.cs` (you), `Session01_Exercise.cs` (students)

---

## Pre-Session Checklist

- [ ] Unity is open with the project loaded
- [ ] `LessonRunner` GameObject exists in the Hierarchy with `Session01_Demo` attached
- [ ] Console window is open and docked somewhere visible
- [ ] You've pressed Play once to confirm expected output (see SETUP doc)
- [ ] Every student has the project open and can see `Session01_Exercise.cs`
- [ ] Pair them up if there are more than 3 people

---

## Session Map (time guide)

| Block | Time |
|---|---|
| Opening — framing what code is | 5 min |
| Concept: variables and types (verbal) | 5 min |
| Live demo: Part 1 & 2 | 10 min |
| Concept: conditionals (verbal) | 5 min |
| Live demo: Part 3 & 4 | 8 min |
| Error demo | 3 min |
| Exercise | 12 min |
| Debrief | 5 min |

---

## Opening (5 min) — say this before touching the keyboard

The goal of this block is to give them a mental model before they see any syntax. Don't open the editor yet.

**Say something like:**

> "Before we write anything, I want to give you the one idea that makes everything else make sense. A program is a list of instructions. The computer reads from the top and executes them one at a time, in order, exactly as written. It does nothing more and nothing less than what the instructions say. That's both the power and the frustration of code."

> "Today we're going to answer two questions. First: how does a program store and track information? Second: how does a program behave differently depending on what that information is? Those two things together get you 80% of the way to reading any script you'll ever encounter."

Ask the room: *"In the game jam, did anyone open a script and feel like they could kind of read it but didn't really understand what it was doing?"* Let a couple people answer. That's the gap you're closing today.

---

## Concept: Variables & Types (5 min verbal, before coding)

**The box analogy:**
> "A variable is a named box. You give it a name, and you can put a value in it, look at it later, and change what's inside. That's all it is."

**Why types matter:**
> "C# needs you to label the box with what KIND of thing goes inside. This isn't arbitrary — the computer stores an integer and a decimal completely differently in memory, and it won't mix them up by accident. Once you label a box as an int, only whole numbers go in."

Walk through each type verbally before showing it in code:

- **int** — "a counter. Whole numbers only. Health points, score, level, lives."
- **float** — "a measurement. Has a decimal. Speed, percentage, a timer. The 'f' at the end is a signal to C# that this specific number is a float and not a higher-precision type."
- **bool** — "a light switch. It is either on or off, true or false. Is the player alive? Has the door been opened? Anything that's a yes/no question."
- **string** — "a sticky note with text on it. Names, dialogue, labels. Always in double quotes."

---

## Live Demo: Part 1 & 2 (10 min)

Open `Session01_Demo.cs`. Students have their editors open too. Tell them to type every line as you type it.

**As you type each variable, say:**

- `int playerHealth = 100;`
  > "int — the type. playerHealth — the name, I made that up. 100 — the starting value. The semicolon ends the statement, like a period ends a sentence. Miss it and C# will complain."

- `float moveSpeed = 6.5f;`
  > "float because we want a decimal. Notice the f. If you leave it off, C# reads 6.5 as a double — a different, higher-precision type — and throws a type mismatch error. The f is easy to forget; you'll do it at least once."

- `bool isAlive = true;`
  > "true — no quotes, no capital T yet. C# keywords are lowercase. Notice I named it 'isAlive' — booleans almost always start with 'is', 'has', or 'can' because that makes them read like a question."

- `string playerName = "Alex";`
  > "String is the odd one out — it has a capital S in some contexts, but as a type keyword you'll usually see lowercase. The value is in double quotes. Single quotes mean something different in C#."

After the `Debug.Log` lines:
> "Debug.Log sends a message to the Console. The plus sign joins things together. You can join as many pieces as you want. Press Play and let's see what shows up."

**Press Play.** Point out the output line by line.

After the arithmetic section:
> "This line reads: take the value currently in playerHealth, subtract damage from it, and put the result back into playerHealth. The old value is gone. The variable now holds 65. Press Play again."

Point out that the second health log changed. Drive home: **variables hold state, and state can change.**

---

## Concept: Conditionals (5 min verbal, before coding Part 3)

Don't write code yet. Put the keyboard down.

> "So far, every line runs every time. The script doesn't think — it just executes. But most interesting behavior in a game is conditional. IF the health is zero, show the death screen. IF the score is above a threshold, unlock the next level. IF the player has the key AND is at the door, open it. This is how code becomes responsive."

Draw or describe the flow on a whiteboard if you have one:

```
Is health <= 0?  → YES → log "Dead"      (stop checking)
                 → NO  →
Is health < 30?  → YES → log "Critical"  (stop checking)
                 → NO  →
                         log "OK"         (nothing else matched)
```

> "C# checks from top to bottom and runs the FIRST branch that matches. Once it finds one, it skips the rest. Order matters."

---

## Live Demo: Part 3 & 4 (8 min)

Type the if/else if/else block. As you open the first curly brace:
> "The curly braces define the body — everything inside runs if the condition is true. Indentation is just for readability; C# doesn't care. The braces are what actually group the lines."

After typing the full chain, ask the room: *"With health at 65, which branch will run?"* Let them answer before pressing Play.

**Press Play.** Confirm "Status: OK" appears.

Then change `int damage = 35;` to `int damage = 85;` and ask again before pressing Play. Health becomes 15 — "Status: Critical" should appear.

For the `&&` section:
> "The double ampersand means AND. Both sides have to be true. A single pipe character means OR. The exclamation mark in front of something flips it — !hasPotion means 'hasPotion is false'."

Restore damage to 35 when done.

---

## Error Demo (3 min)

In `Session01_Demo.cs`, uncomment `// imt broken = 99;` and save. 

While Unity recompiles, say:
> "Watch the Play button. It just greyed out — Unity refuses to run anything while there's a compile error anywhere in the project. This is intentional. Better to catch it now than at runtime."

When the error appears, walk through it together:
- Point to the filename
- Point to the line and column number
- Read the message aloud: *"The type or namespace name 'imt' could not be found"*
> "It's telling you exactly what went wrong. 'imt' isn't a type it knows. Most beginner errors are this direct. Before you Google anything, read the message — it usually tells you the answer."

Re-comment the line, save, confirm Play button returns.

---

## Exercise Handoff (12 min)

Tell the class:

> "Your turn. Open Session01_Exercise.cs — it's in Assets/Lessons/Session01. Work through Parts 1 through 7 in order. Type everything yourself, and press Play after each part before moving on. If you get stuck, ask your partner first. If you're both stuck after two minutes, ask me."

> "When you hit Part 7, that's not a mistake in the file — that's intentional. Read the error, understand it, then fix it."

**While they work, circulate and watch for:**
- Students who got `health` below 30 before Part 5 (their "Hurt" or "Critical" branch will fire — that's great, it shows conditionals working)
- Anyone trying to add a float to an int directly — that's a type mismatch, worth addressing with the group if it comes up
- The `&&` in Part 6 tripping people up — remind them: "both sides need to be a true/false check"
- Missing semicolons, missing curly braces — these are the most common

---

## Debrief (5 min)

Pull the group back together. Ask a couple of questions before showing the solution:

1. *"Did anyone's health drop low enough that a different status branch fired? What did you see?"*
2. *"What did the error in Part 7 say? What was wrong?"*
3. *"In Part 6, what happened if health was above zero — which branch ran?"*

Show the solution file briefly. Point out that the solution isn't the only valid answer — any values that demonstrate the structure are correct.

**Close with:**
> "You just wrote code that stores state and makes decisions based on it. That's the skeleton of almost every script in a real game. Next session we'll add loops — making code repeat — and then methods, which are how you organize and reuse logic instead of copy-pasting it."

---

## Common Confusions (reference — address as they come up)

**`=` vs `==`**  
Single `=` assigns a value. Double `==` compares. `if (health = 0)` is an assignment inside a condition — C# will error or behave unexpectedly. This is the single most common mistake beginners make writing their first conditionals.

**Missing `f` on float literals**  
`float speed = 6.5;` — C# reads 6.5 as a double and the types don't match. The fix is always just adding the `f`. Worth pointing out preemptively rather than letting them debug it.

**`bool` prints as `True` / `False` with a capital letter**  
The keyword is lowercase `true`, but when you log a bool, Unity/C# formats it as `True`. Not a bug, just a display quirk. Don't address this unless someone asks.

**Forgetting curly braces around an if body**  
If you omit braces, only the very next line is part of the if. Everything after it runs unconditionally. This produces subtle bugs, not errors. Convention is always use braces.

**`else if` vs nested `if`**  
A chain of `else if` stops at the first match. Multiple standalone `if` statements each check independently. For the health status example, standalone ifs would trigger multiple log messages if health is low. Point this out if anyone has multiple messages printing.

**String vs string**  
Both `string` and `String` work in C#. Lowercase `string` is the conventional choice in Unity scripts. If they write `String`, it compiles fine — don't make it a big deal.

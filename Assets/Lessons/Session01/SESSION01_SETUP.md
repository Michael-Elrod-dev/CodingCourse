# Session 1 — Editor Setup Steps

**Session scope:** Variables, types, arithmetic, conditionals, reading an error.  
Do these steps once before the session. Takes about 2 minutes.

---

## 1. Open the Console window

**Window → General → Console**  
Dock it somewhere visible (bottom panel works well). This is where `Debug.Log` output appears.

---

## 2. Create an empty GameObject for the demo

1. In the **Hierarchy** panel, right-click → **Create Empty**.
2. Rename it `LessonRunner` — this same object gets reused every session, just swap the script.

---

## 3. Attach the demo script

1. Select `LessonRunner` in the Hierarchy.
2. In the **Project** panel, navigate to `Assets/Lessons/Session01/`.
3. Drag **`Session01_Demo`** onto the Inspector, or click **Add Component → Scripts → Session01_Demo**.

---

## 4. Press Play and confirm output

**Expected Console output:**
```
=== Game Start ===
Alex — Health: 100  Speed: 6.5
Alive: True
--- Took 35 damage ---
Health is now: 65
=== Status Check ===
Status: OK
Still alive: True
```

If you see those lines in order, the script is working correctly.

---

## 5. Error demo — what to do

Open `Session01_Demo.cs`. Near the bottom, find:
```
// imt broken = 99;
```
Remove the `//` and save. The Play button greys out and the Console shows:
> `The type or namespace name 'imt' could not be found`

Walk students through reading it — file name, line number, message text.  
Re-add the `//` and save to restore. Play button returns.

---

## 6. Switching to the exercise

When it's time for students to work independently:

1. Select `LessonRunner` in the Hierarchy.
2. In the Inspector, click the **⋮ menu** on the `Session01_Demo` component → **Remove Component**.
3. Drag **`Session01_Exercise`** onto `LessonRunner`.
4. Students open `Session01_Exercise.cs` in their own editors and work through the TODOs.

To demo the solution afterward: remove `Session01_Exercise` and attach `Session01_Exercise_Solution` from the `Solutions/Session01/` folder (local only — not on GitHub).

---

## Notes

- The **Guide** (`Session01_Guide.md`) has the full instructor script including what to say, timing, and common student confusions. Read it before the session.
- Future sessions follow the same pattern: new folder `Session02/`, same `LessonRunner` object, swap the script.

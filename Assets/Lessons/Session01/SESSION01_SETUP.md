# Session 1 — Editor Setup Steps

Do these once before the session. Takes about 2 minutes.

---

## 1. Open the Console window

**Window → General → Console**  
Dock it somewhere visible (bottom of the screen works well). This is where `Debug.Log` output appears.

---

## 2. Create an empty GameObject for the demo

1. In the **Hierarchy** panel, right-click → **Create Empty**.
2. Rename it `LessonRunner` (click the name in the Hierarchy and press F2, or double-click it).

---

## 3. Attach the demo script

1. Select `LessonRunner` in the Hierarchy so it shows in the **Inspector**.
2. In the **Project** panel, navigate to `Assets/Lessons/Session01/`.
3. Drag **`Session01_Demo`** onto the Inspector, or click **Add Component → Scripts → Session01_Demo**.

You should see the component appear in the Inspector with no fields (that's fine — all variables are declared inside `Start()`).

---

## 4. Press Play and check the Console

Click the **Play** button (▶) at the top of the editor.

**Expected Console output (in order):**
```
Name:   Alex
Health: 100
Speed:  4.5
Alive:  True
--- After taking 25 damage ---
Health is now: 75
Score: 30   Half of 50: 25
```

If you see those lines, the script is working. Press Play again (or the ▶ button) to stop.

---

## 5. Demo the deliberate error

Open `Session01_Demo.cs` in your editor. Find the line near the bottom:
```
// imt brokenVariable = 99;
```
Remove the `//` so it reads:
```
imt brokenVariable = 99;
```
Save the file. Unity recompiles — the Play button greys out and the Console shows a red error like:
> `The type or namespace name 'imt' could not be found`

Walk the class through reading it: *what file, what line, what does the message say?*  
Re-add the `//` and save to restore the project.

---

## 6. Swapping in the exercise script (students' turn)

When it's time for the solo exercise:

1. Select `LessonRunner` in the Hierarchy.
2. In the Inspector, click the **⋮ (three-dot menu)** on the `Session01_Demo` component → **Remove Component**.
3. Drag **`Session01_Exercise`** onto the Inspector (same as step 3 above).
4. Each student opens `Session01_Exercise.cs` in their own editor and fills in the TODOs.
5. When they press Play, their output appears in their Console.

After ~10 minutes, show `Session01_Exercise_Solution.cs` as a reference — attach it the same way if you want to demo it running.

---

## Notes for future sessions

- Each session gets its own folder: `Assets/Lessons/Session02/`, `Session03/`, etc.
- The same `LessonRunner` GameObject can be reused — just swap the attached script each time.
- Keep all demo and exercise scripts in their session folder so students can revisit earlier sessions.

using UnityEngine;

// Session05_Arena.cs — TEACHER-PROVIDED, STUDENT-ACTIVATED
//
// Drop this on your cube during setup. It does NOTHING on its own — it sleeps
// until the exercise tells you to flip its switches, from YOUR code:
//
//   Session05_Arena.showWalls = true;      // Part 6 — reveals the arena walls
//   Session05_Arena.showBurnGlow = true;   // Part 9 — glow while in the lava
//
// You do NOT need to read past this line. This file isn't part of any lesson
// yet. But if you're curious after Part 9: open it up — fields, methods, ifs,
// new Vector3(...) — you can already read almost every line. The only new
// faces are a few Unity helpers (CreatePrimitive, localScale, Color.Lerp).

public class Session05_Arena : MonoBehaviour {
    // The switches. `static` means these belong to the CLASS itself rather
    // than to one object — which is why your script can flip them by name:
    // Session05_Arena.showWalls = true;  (You've been READING class-level
    // members all session: Vector3.right, Time.deltaTime, Keyboard.current.)
    public static bool showWalls = false;
    public static bool showBurnGlow = false;

    Renderer cubeRenderer;
    Color normalColor;
    bool wallsBuilt = false;

    void Awake() {
        // Fresh switches every time Play starts — flipping them is YOUR job.
        showWalls = false;
        showBurnGlow = false;
    }

    void Start() {
        cubeRenderer = GetComponent<Renderer>();
        normalColor = cubeRenderer.material.color;
    }

    void Update() {
        // The reveal: the first frame showWalls is true, build the walls.
        if (showWalls && !wallsBuilt) {
            // They sit just OUTSIDE the play area (x ±8, y ±4), so your cube's
            // face kisses them exactly where your Part 6 code stops it.
            BuildWall(0f, 4.75f, 18.5f, 0.5f);     // top
            BuildWall(0f, -4.75f, 18.5f, 0.5f);    // bottom
            BuildWall(8.75f, 0f, 0.5f, 9f);        // right
            BuildWall(-8.75f, 0f, 0.5f, 9f);       // left
            wallsBuilt = true;
        }

        if (showBurnGlow && InLavaZone()) {
            // Pulse between normal and red-hot while touching the lava.
            float pulse = 0.5f + 0.5f * Mathf.Sin(Time.time * 12f);
            cubeRenderer.material.color = Color.Lerp(normalColor, new Color(1f, 0.2f, 0.05f), pulse);
        } else {
            cubeRenderer.material.color = normalColor;
        }
    }

    bool InLavaZone() {
        // Same boundary the exercise uses — driven purely by position.
        return transform.position.x >= 8f || transform.position.x <= -8f
            || transform.position.y >= 4f || transform.position.y <= -4f;
    }

    void BuildWall(float x, float y, float width, float height) {
        GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
        wall.name = "Lava Wall";
        wall.transform.position = new Vector3(x, y, 0f);
        wall.transform.localScale = new Vector3(width, height, 1f);
        wall.GetComponent<Renderer>().material.color = new Color(0.9f, 0.25f, 0.1f);
    }
}

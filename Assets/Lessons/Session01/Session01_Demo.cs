using UnityEngine;

// A MonoBehaviour is a script you can attach to a GameObject in Unity.
// When you press Play, Unity calls Start() once automatically — that's where
// our code will run.
public class Session01_Demo : MonoBehaviour
{
    void Start()
    {
        // ---------------------------------------------------------------
        // VARIABLES — named boxes that hold a value.
        // The word on the left is the TYPE (what kind of data).
        // The word in the middle is the NAME (what we call the box).
        // The value on the right is what we put inside it.
        // ---------------------------------------------------------------

        // int = a whole number (no decimal point)
        int playerHealth = 100;

        // float = a number with a decimal point.
        // The "f" at the end is required — it tells C# "this is a float".
        float moveSpeed = 4.5f;

        // bool = true or false, and nothing else
        bool isAlive = true;

        // string = text. Always wrap text in double quotes.
        string playerName = "Alex";

        // ---------------------------------------------------------------
        // Debug.Log() prints a value to Unity's Console window.
        // The + sign joins pieces of text together.
        // ---------------------------------------------------------------
        Debug.Log("Name:   " + playerName);
        Debug.Log("Health: " + playerHealth);
        Debug.Log("Speed:  " + moveSpeed);
        Debug.Log("Alive:  " + isAlive);

        // ---------------------------------------------------------------
        // ARITHMETIC — we can do math on numbers and store the result.
        // ---------------------------------------------------------------
        int damage = 25;

        // Re-assign playerHealth: take the old value, subtract damage, save it back.
        playerHealth = playerHealth - damage;

        Debug.Log("--- After taking " + damage + " damage ---");
        Debug.Log("Health is now: " + playerHealth);

        // Show a few more operators so students see them exist.
        // We're not memorizing all of these — just noticing the pattern.
        int score = 10 * 3;       // * is multiply
        float half = 50f / 2f;    // / is divide
        Debug.Log("Score: " + score + "   Half of 50: " + half);

        // ---------------------------------------------------------------
        // DELIBERATE ERROR
        // Uncomment the line below (remove the // at the start) and save.
        // Unity will refuse to run and show a compile error in the Console.
        // Practice reading that error — it tells you exactly what's wrong.
        // ---------------------------------------------------------------
        // imt brokenVariable = 99;
    }
}

# C# / Unity Quick Reference

A lookup sheet for the course. Sections are ordered the same way concepts appear in the session — follow along top to bottom during the demo and exercise.

---

## 1. Data Types

The TYPE tells C# what kind of value a variable can hold.

| Type | Full name | What it holds | Example |
|---|---|---|---|
| `int` | integer | Whole numbers only | `int score = 10;` |
| `float` | floating-point | Decimal numbers | `float speed = 4.5f;` |
| `bool` | boolean | `true` or `false` only | `bool isAlive = true;` |
| `string` | string of characters | Text | `string name = "Alex";` |
| `char` | character | A single letter or symbol | `char grade = 'A';` |

> **float gotcha:** Always put `f` at the end of a float number — `4.5f`, not `4.5`. Without it C# treats it as a `double` (a different type) and throws a type error.

> **char vs string:** `char` uses single quotes `'A'`. `string` uses double quotes `"Alex"`. They are not interchangeable.

---

## 2. Declaring & Assigning Variables

```csharp
// Declare and assign in one line (most common)
int playerHealth = 100;

// Re-assign — change the value later (no type word this time)
playerHealth = 75;

// Declare first, assign later (less common)
int playerHealth;
playerHealth = 100;
```

> A variable must be **declared before it is used**. Referencing it on an earlier line than the declaration is a compile error.

---

## 3. Comments

```csharp
// Single-line comment — C# ignores everything after the //

/* Multi-line comment
   spans as many lines as you need */
```

Use comments to explain *why* something is written the way it is, not just *what* it does.

---

## 4. Debug.Log

Prints a message to Unity's Console window. The only way to see values while running.

```csharp
Debug.Log("any message");       // white  — general info
Debug.LogWarning("watch out");  // yellow — something suspicious
Debug.LogError("broke");        // red    — something went wrong
```

> `Debug.Log` not `Debug.log` — the capital L matters. C# is case-sensitive everywhere.

---

## 5. Strings

Joining values together for log messages:

```csharp
// Concatenation — join with +
Debug.Log("Health: " + playerHealth);
Debug.Log("Hello, " + playerName + "! Score: " + score);

// String interpolation — cleaner when joining many values
Debug.Log($"Hello, {playerName}! Score: {score}");
```

Both produce identical output. The `$"..."` form is easier to read with multiple values.

---

## 6. Arithmetic Operators

| Symbol | Meaning | Example |
|---|---|---|
| `+` | Add | `score + 10` |
| `-` | Subtract | `health - damage` |
| `*` | Multiply | `speed * 2` |
| `/` | Divide | `total / 4` |
| `%` | Remainder (modulo) | `7 % 3` → `1` |

```csharp
// Read this as: "take the current value, change it, store it back"
playerHealth = playerHealth - damage;
```

> **Int division truncates:** `7 / 2` gives `3`, not `3.5`. Use floats if you need a decimal result: `7f / 2f`.

---

## 7. Shorthand Assignment

Shortcuts for the most common update patterns:

| Shorthand | Same as |
|---|---|
| `score += 10` | `score = score + 10` |
| `score -= 5` | `score = score - 5` |
| `score *= 2` | `score = score * 2` |
| `score /= 4` | `score = score / 4` |
| `score++` | `score = score + 1` |
| `score--` | `score = score - 1` |

---

## 8. Comparison Operators

Used inside conditions — always evaluate to `true` or `false`.

| Symbol | Meaning | Example |
|---|---|---|
| `==` | Equal to | `health == 0` |
| `!=` | Not equal to | `name != "enemy"` |
| `>` | Greater than | `score > 100` |
| `<` | Less than | `health < 25` |
| `>=` | Greater than or equal | `level >= 5` |
| `<=` | Less than or equal | `timer <= 0` |

> **`=` vs `==`:** Single `=` assigns a value. Double `==` compares two values. Writing `if (score = 10)` is a bug — use `if (score == 10)`.

---

## 9. Conditionals

```csharp
if (health <= 0)
{
    Debug.Log("Dead");
}
else if (health < 30)
{
    Debug.Log("Critical");
}
else
{
    Debug.Log("OK");
}
```

- C# checks **top to bottom** and runs the **first branch that matches**, then skips the rest.
- Order matters — put the most specific conditions first.
- Always use curly braces `{ }`. Without them, only the very next line belongs to the `if`.

---

## 10. Logical Operators

Combine or flip conditions.

| Symbol | Meaning | When it's true |
|---|---|---|
| `&&` | AND | Both sides must be true |
| `\|\|` | OR | At least one side must be true |
| `!` | NOT | Flips `true` to `false` and vice versa |

```csharp
if (health < 30 && !hasPotion)
{
    Debug.Log("Low health and no potion — in trouble.");
}

if (isAlive || hasRevive)
{
    Debug.Log("Game can continue.");
}
```

---

## 11. Reading an Error Message

```
Assets/Lessons/Session01/Session01_Exercise.cs(14,13): error CS0246:
The type or namespace name 'sting' could not be found
```

| Part | What it means |
|---|---|
| `Session01_Exercise.cs` | Which file |
| `(14,13)` | Line 14, column 13 — **not always the exact broken line** |
| `error CS0246` | Error code (searchable if needed) |
| The rest | Plain-English description — read this first |

**Read the message before you do anything else.** Most errors are typos, wrong types, or missing punctuation — the message usually tells you directly. The column number is a hint, not a guarantee.

---

## 12. Unity-Specific

### MonoBehaviour lifecycle

Unity calls these automatically — you never call them yourself.

```csharp
void Start()   { }  // runs once when the object activates
void Update()  { }  // runs every frame (~60× per second)
```

### GetComponent

Grab another component attached to the same GameObject.

```csharp
Rigidbody rb = GetComponent<Rigidbody>();
```

### Common Unity types (recognise these in tutorials)

| Type | What it is |
|---|---|
| `Vector3` | A point or direction in 3D: `new Vector3(x, y, z)` |
| `Vector2` | Same but 2D |
| `GameObject` | A reference to any object in the scene |
| `Transform` | Position, rotation, and scale of a GameObject |
| `Color` | An RGBA colour value |

---

## 13. Naming Conventions

| Thing | Style | Example |
|---|---|---|
| Local variables | camelCase | `playerHealth` |
| Method names | PascalCase | `TakeDamage()` |
| Class names | PascalCase | `PlayerController` |
| Constants | ALL_CAPS | `MAX_HEALTH` |
| Booleans | Start with `is` / `has` / `can` | `isAlive`, `hasKey` |

---

## 14. Loops — Session 2

```csharp
// for — when you know how many times
for (int i = 0; i < 5; i++)
{
    Debug.Log(i);
}

// while — when you stop on a condition
while (health > 0)
{
    health -= 10;
}

// foreach — iterate over a collection
foreach (string item in inventory)
{
    Debug.Log(item);
}
```

---

## 15. Methods — Session 3

```csharp
// Define
int Add(int a, int b)
{
    return a + b;
}

// Call
int result = Add(3, 5);  // result is 8

// void = returns nothing
void PrintScore()
{
    Debug.Log("Score: " + score);
}
```

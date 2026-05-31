# C# / Unity Quick Reference

A lookup sheet for the course. Not a tutorial — use this when you remember *that* something exists but forget the exact syntax.

---

## Data Types

| Type | What it holds | Example |
|---|---|---|
| `int` | (integer) Whole numbers | `int score = 10;` |
| `float` | (floating-point) Decimal numbers | `float speed = 4.5f;` |
| `bool` | (boolean) True or false only (evaluates to either 1 or 0, binary) | `bool isAlive = true;` |
| `char` | (character) A single letter | `char letter = 'A';` |
| `string` | (string of chracters) Text | `string name = "Alex";` |

> **float gotcha:** C# needs an `f` at the end of a float literal — `4.5f`, not `4.5`. Without it, C# treats it as a `double` and may throw an error.

---

## Declaring & Assigning Variables

```csharp
// Declare and assign in one line (most common)
int playerHealth = 100;

// Declare first, assign later
int playerHealth;
playerHealth = 100;

// Re-assign (change the value — no type word this time)
playerHealth = 75;
```

---

## Arithmetic Operators

| Symbol | Meaning | Example |
|---|---|---|
| `+` | Add | `score + 10` |
| `-` | Subtract | `health - damage` |
| `*` | Multiply | `speed * 2` |
| `/` | Divide | `total / 4` |
| `%` | Remainder (modulo) | `7 % 3` → `1` |

> **Int division truncates:** `7 / 2` gives `3`, not `3.5`. If you need a decimal result, use floats: `7f / 2f`.

---

## Shorthand Assignment

These are just shortcuts — they do the same thing as the long form.

| Shorthand | Same as |
|---|---|
| `score += 10` | `score = score + 10` |
| `score -= 5` | `score = score - 5` |
| `score *= 2` | `score = score * 2` |
| `score /= 4` | `score = score / 4` |
| `score++` | `score = score + 1` |
| `score--` | `score = score - 1` |

---

## Comparison Operators

Used inside `if` conditions — always return `true` or `false`.

| Symbol | Meaning | Example |
|---|---|---|
| `==` | Equal to | `health == 0` |
| `!=` | Not equal to | `name != "enemy"` |
| `>` | Greater than | `score > 100` |
| `<` | Less than | `health < 25` |
| `>=` | Greater than or equal | `level >= 5` |
| `<=` | Less than or equal | `timer <= 0` |

> **Common mistake:** `=` assigns a value; `==` compares two values. `if (score = 10)` is a bug; `if (score == 10)` is the check.

---

## Logical Operators

Combine or flip conditions.

| Symbol | Meaning | Example |
|---|---|---|
| `&&` | AND — both must be true | `isAlive && hasKey` |
| `\|\|` | OR — at least one must be true | `isAlive \|\| hasShield` |
| `!` | NOT — flips true/false | `!isAlive` |

---

## Strings

```csharp
// Joining (concatenation) with +
Debug.Log("Score: " + score);
Debug.Log("Hello, " + playerName + "!");

// String interpolation — cleaner for multiple values
Debug.Log($"Hello, {playerName}! Score: {score}");
```

Both approaches produce identical output. The `$"..."` form (interpolation) is generally easier to read.

---

## Comments

```csharp
// This is a single-line comment — ignored by C#

/* This is a
   multi-line comment */
```

---

## Conditionals

```csharp
if (health <= 0)
{
    Debug.Log("Dead");
}
else if (health < 25)
{
    Debug.Log("Critical");
}
else
{
    Debug.Log("OK");
}
```

---

## Loops (Session 3)

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

// foreach — over a collection
foreach (string item in inventory)
{
    Debug.Log(item);
}
```

---

## Methods (Session 4)

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

---

## Unity-Specific

### MonoBehaviour lifecycle methods
Unity calls these automatically — you never call them yourself.

```csharp
void Start()   { }  // runs once when the object is created
void Update()  { }  // runs every frame (~60x per second)
```

### Debug.Log
```csharp
Debug.Log("any message");       // white — info
Debug.LogWarning("watch out");  // yellow — warning
Debug.LogError("broke");        // red — error
```
All three appear in the Console. **Red errors** usually mean the script crashed — they stop that script from running further that frame.

### GetComponent
Grab another component attached to the same GameObject.
```csharp
Rigidbody rb = GetComponent<Rigidbody>();
```

### Common Unity types (just to recognise them)

| Type | What it is |
|---|---|
| `Vector3` | A point or direction in 3D space: `new Vector3(x, y, z)` |
| `Vector2` | Same but 2D |
| `GameObject` | A reference to any object in the scene |
| `Transform` | Position, rotation, scale of a GameObject |
| `Color` | An RGBA colour value |

---

## Naming Conventions

Unity / C# community standards — your code will look "normal" to everyone else if you follow these.

| Thing | Style | Example |
|---|---|---|
| Local variables | camelCase | `playerHealth` |
| Method names | PascalCase | `TakeDamage()` |
| Class names | PascalCase | `PlayerController` |
| Constants | ALL_CAPS or PascalCase | `MAX_HEALTH` |
| Booleans | Start with `is`/`has`/`can` | `isAlive`, `hasKey` |

---

## Reading an Error Message

```
Assets/Lessons/Session01/Session01_Demo.cs(14,13): error CS0246:
The type or namespace name 'imt' could not be found
```

| Part | Meaning |
|---|---|
| `Session01_Demo.cs` | Which file |
| `(14,13)` | Line 14, column 13 |
| `error CS0246` | Error code (you can Google this) |
| The text after | Plain-English description of the problem |

**Read the message before Googling.** Most beginner errors are typos in the type name or a missing semicolon — the message usually tells you directly.

# 📚 Day 1, Day 2 & Day 3 Demo

## 📌 Overview
This repository contains the demos for the **ITI Summer Training C# course .NET Tracks — C# Part**.  
It is designed to introduce **absolute beginners** to the basic concepts of C# programming, the .NET environment, and console-based input/output,
then gradually progress to **type conversion, nullable types, conditional statements, loops, arrays, strings, StringBuilder, parameter passing techniques, and more**.

---

## 🛠 Topics Covered

### 📅 **Day 1**
1. **C# Program Structure**
   - `namespace`, `class`, and `Main` method

2. **Variables & Constants**
   - Declaration, initialization, naming conventions  
   - `const` keyword

3. **Data Types**
   - Value Types vs Reference Types  
   - `int`, `double`, `char`, `bool`, `string`  
   - Arrays

4. **Operators**
   - Unary (`++`, `--`)
   - Arithmetic (`+`, `-`, `*`, `/`, `%`)
   - Assignment (`=`, `+=`, `-=`, etc.)
   - Relational (`==`, `!=`, `<`, `>`, `<=`, `>=`)
   - Logical (`!`, `&&`, `||`)
   - Bitwise (`&`, `|`, `^`, `~`, `<<`, `>>`)
   - Ternary (`?:`)
   - Operator precedence

5. **Console Input/Output + Basic Parsing**

6. **Errors**
   - Syntax errors  
   - Logical errors  
   - Exceptions

---

### 📅 **Day 2**
1. **Fractions & Numeric Precision**
   - `float`, `double`, `decimal` differences
   - Precision limits and usage

2. **String Formatting**
   - String Interpolation (`$""`)
   - `string.Format()` method
   - Composite formatting
   - String concatenation and immutability
   - Format specifiers (`c`, `x`, `n`)
   - Escape sequences (`\n`, `\t`, `\\`, `@` for verbatim strings)

3. **Casting & Conversion**
   - Implicit casting (widening)
   - Explicit casting (narrowing, potential data loss)
   - Checked/unchecked contexts
   - Protective coding (range checks, `typeof`, object type checks)
   - `Convert` class
   - `Parse()` method
   - `TryParse()` method (safe parsing)

4. **Nullable Types**
   - Nullable value types (`int?`, `Nullable<int>`)
   - Converting nullable to non-nullable types
   - Protective code with `HasValue`, `.Value`, `??` (null-coalescing)
   - `GetValueOrDefault()`
   - Nullable reference types (`string?`)
   - Null-forgiving operator (`!`)
   - Null-conditional / null-propagation operator (`?.`)

5. **Conditional Statements**
   - `if` / `else if` / `else`
   - `switch` with constant patterns (numeric & string)
   - Relational patterns in switch (C# 9)
   - Switch with `goto case`
   - **Evolution of switch**:
     - C# 7: Pattern matching with case guards (`when`)
     - C# 8: Pattern matching without alias, switch expressions, discard pattern, nullable handling
     - C# 9: Relational & logical patterns in switch expressions

6. **Looping / Iteration Statements**
   - `for` loop
   - `foreach` loop (read-only iteration)
   - `while` loop
   - `do-while` loop
   - Use of `break` and `continue`

---

### 📅 **Day 3**
1. **Methods**
   - PascalCase naming convention  
   - **Static methods** (class-level) vs **Instance methods** (object-level)
   - Method overloading
   - **Optional parameters** & named arguments
   - Checking for `null` in array/reference type parameters

2. **Parameter Passing Techniques**
   - **Pass by Value** (default)
   - **Pass by Reference** (`ref`)
   - **Output parameters** (`out`)
   - **Parameter arrays** (`params`) — C# 13 improvements with `ReadOnlySpan<T>`
   - Real differences in modifying arrays with `ref` vs without

3. **Arrays**
   - **1D Arrays** — creation, initialization, access, `Length` and `Rank`
   - **2D Arrays** (Rectangular) — `GetLength()`, nested loops for row/column traversal
   - **Jagged Arrays** — array of arrays, different lengths per row
   - **Array Class Methods**
     - `Sort`, `Reverse`, `Clear`, `Resize`
     - `Copy`, `ConstrainedCopy`

4. **Strings**
   - String immutability & string pool
   - Common methods: `Length`, `ToUpper`, `ToLower`, `Trim`, `Substring`, `Replace`, `Contains`, `IndexOf`

5. **StringBuilder**
   - Mutable string operations
   - Methods: `Append`, `AppendLine`, `AppendFormat`, `AppendJoin`, `Replace`, `Remove`, `Clear`
   - Performance benefits over string concatenation

6. **Boxing & Unboxing**
   - **Boxing**: value type → reference type (e.g., `object obj = 10;`)
   - **Unboxing**: reference type → value type (requires explicit cast)
   - Safe vs unsafe casting, `InvalidCastException`

---

## 📂 Structure
- **Day1** → Basics: syntax, variables, operators, and I/O  
- **Day2** → Data conversion, nullable types, advanced conditionals, and loops  
- **Day3** → Methods, parameter passing, arrays, strings, StringBuilder, boxing/unboxing

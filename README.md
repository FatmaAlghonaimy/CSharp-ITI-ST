# 📚 Day 1 & Day 2 Demo

## 📌 Overview
This repository contains the demos for the **ITI Summer Training C# course .NET Tracks**.   C# Part
It is designed to introduce **absolute beginners** to the basic concepts of C# programming, the .NET environment, and console-based input/output, gradually progressing to **type conversion, nullable types, conditional statements, switch enhancements, and loops**.

---

## 🛠 Topics Covered

### **Day 1**
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

### **Day 2**
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

## 📂 Structure
- **Day1** → Covers basic syntax, variables, operators, and I/O.  
- **Day2** → Builds on Day 1 by introducing data conversion, nullable types, advanced conditionals, and loops.

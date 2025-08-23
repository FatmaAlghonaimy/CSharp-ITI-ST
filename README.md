# 📚 Day 1, Day 2, Day 3, Day 4, Day 5 & Day 6 Demo

## 📌 Overview
This repository contains demos from the **ITI Summer Training C# course (.NET Track — C# Part)**.  
It covers the fundamentals of **C# programming** and progresses through topics like:

- User-defined data types, enums, structs, and type conversion.  
- Methods, arrays, strings, and memory management.  
- Encapsulation, access modifiers, and working with `System.Object`.  
- Classes, constructors, inheritance, and operator overloading.  
- Abstraction, interfaces, binding, and overriding.  

Each day introduces **progressively advanced OOP concepts** with practical examples.

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

### 📅 **Day 4**
1. **Access Modifiers**
   - **Private** → accessible only within the same class
   - **Internal** → accessible within the same project/assembly
   - **Public** → accessible from anywhere (same project or outside project)
   - Demo with class fields (`x`, `y`, `z`) showing scope differences  

2. **Structs**
   - Value types stored on the **stack**
   - **Constructor overloading** (default, parameterized, single parameter)
   - **Copy behavior** → structs create *independent copies* (no shared reference like classes)
   - Example: `Point` struct with multiple constructors and assignments  

3. **Encapsulation**
   - **Fields with getters/setters** → protect data from direct modification
   - **Properties** → improved readability, validation, and controlled access  
   - **Read-only / Write-only properties**
   - **Indexers** → access data by key/index (like an array or dictionary)  
   - Examples:
     - `Employee` class → `Id`, `Name`, `Age` with encapsulation
     - `PhoneNoteBook` class → indexer for names & phone numbers  

4. **System.Object Methods**
   Every class/struct in C# inherits from `System.Object`. Key methods:
   - `ToString()` → string representation (can override)
   - `Equals()` → value vs reference equality
   - `GetHashCode()` → generates hash for collections/lookup
   - `GetType()` → runtime type info  
   - Demo includes **static vs dynamic binding**, boxing/unboxing with `object`  

5. **Enums**
   - Strongly typed constants for readability & maintainability
   - Example: `Gender` enum with values (e.g., `Male`, `Female`)
   - Casting between enum values and integers
   - Used in `Employee` class for gender property

---

### 📅 **Day 5**
1. **Enums (Advanced)**
   - Using `Enum.TryParse()` for safe user input parsing  
   - Branch enum example (HR, IT, Finance, Marketing)  
   - **Flagged Enums for Permissions** (`[Flags]`)  
     - Assigning multiple permissions (`Read | Write | Update | Delete`)  
     - Adding/removing permissions using `|`, `&`, `^` operators  
     - Checking if a user has a specific permission  

2. **Classes**
   - Creating objects on the heap  
   - Constructor overloading and **constructor chaining**  
   - Example: `Car` class with multiple constructors (`id`, `brand`, `speed`)  

3. **Inheritance**
   - Base class (`Parent`) and derived class (`Child`)  
   - Upcasting (`Parent p = new Child()`)  
   - Overriding methods vs inherited behavior  
   - Example: calculating product using base and child members  

4. **Access Modifiers (continued from Day 4)**  
   - Deep dive into accessibility across **different assemblies**  
   - Behavior of:
     - `private`, `internal`, `public`  
     - `protected`, `private protected`, `protected internal`  
   - Demo with `TypeA`, `TypeB`, and `TypeD` classes  

5. **Method Overloading**
   - Multiple `Sum` method variations with different signatures  
   - Overloading not allowed by **return type only**  
   - Example with `int`, `double`, and mixed parameters  

6. **Operator Overloading**
   - **Binary Operators** (`+`, `-`) → e.g., `Complex` numbers addition/subtraction  
   - **Unary Operators** (`++`, `--`) → prefix vs postfix  
   - **Relational Operators** (`>`, `<`, `==`, `!=`) → comparing custom objects  
   - **Casting Operators**  
     - Explicit: `(int)Complex`  
     - Implicit/explicit: `(string)Complex` → `"2 + 3i"`  
   - **User-defined type casting** (mapping `User` → `UserViewModel`)  
     - Example for manual mapping, and hinting at **AutoMapper** for automation  

---

### 📅 **Day 6**
1. **Abstraction**
   - Abstract classes  
   - Abstract vs non-abstract members  
   - Abstract class inheritance  

2. **Binding**
   - Early binding (compile-time)  
   - Late binding (runtime) with `virtual`/`override`  
   - Dynamic binding using `dynamic`  

3. **Interfaces**
   - Defining & implementing interfaces  
   - Multiple interface implementation  
   - Interface segregation principle  
   - Real-world use cases  

4. **Override**
   - Overriding base class methods  
   - `virtual`, `override`, and `sealed override` keywords  
   - Differences between hiding (`new`) and overriding (`override`)  

---
## 📂 Repository Structure

📦 Solution  
├── 📂 CSharpBasics  
│   ├── 📚 Day1 → Basics: syntax, variables, operators, and I/O  
│   ├── 📚 Day2 → Data conversion, nullable types, advanced conditionals, and loops  
│   └── 📚 Day3 → Methods, parameter passing, arrays, strings, StringBuilder, boxing/unboxing  
│  
├── 📂 OOPAndMore  
│   ├── 📚 Day4 → Structs, encapsulation, enums, objects, OOP topics  
│   ├── 📚 Day5 → Advanced enums, permissions, classes, inheritance, access modifiers, method & operator overloading  
│   └── 📚 Day6 → Abstraction, binding, interfaces, overriding  
│  
└── 📚 Common → Shared Class Library used across demos

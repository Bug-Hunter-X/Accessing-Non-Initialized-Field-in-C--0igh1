# Accessing Non-Initialized Field in C#

This repository demonstrates a common error in C#: accessing a field before it has been initialized.  Uninitialized fields will contain default values (0 for integers, null for objects, etc.), which might lead to unexpected behavior or runtime exceptions if not handled properly.

The `bug.cs` file contains the erroneous code. The `bugSolution.cs` file provides a corrected version.

## Problem

The original code attempts to access the `_myValue` field in the `MyMethod()` method before it's been assigned a value.  This may work in some cases, but it is not dependable and prone to errors, and can result in unexpected results.

## Solution

The solution involves initializing the `_myValue` field in the constructor, or assigning it a value prior to its use in any method.
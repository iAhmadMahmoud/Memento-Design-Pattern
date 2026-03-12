# Memento Design Pattern – Presentation

This repository contains a presentation and a simple C# example explaining the **Memento Design Pattern**.  
This work was created as a task for a **Design Patterns course**.

## 📌 Overview

The **Memento Design Pattern** is a behavioral design pattern that allows saving and restoring an object's state without exposing its internal implementation.

It is commonly used in features like:
- Undo / Redo operations
- Save and Load systems in video games
- Checkpoints in applications

## 🧠 Pattern Structure

The Memento pattern consists of three main components:

- **Originator**  
  The object whose state needs to be saved or restored.

- **Memento**  
  Stores the snapshot of the object's state.

- **Caretaker**  
  Manages and keeps the saved states but does not modify them.

## 💻 Example Used in This Project

A simple **Text Editor example** implemented in **C#** demonstrating an **Undo feature**.

The editor:
1. Saves the previous state of the text
2. Allows restoring the previous state using Undo

## 📂 Repository Contents

- `presentation.pptx` – Slides explaining the Memento pattern
- `example.cs` – Simple C# implementation
- `diagram.png` – Visual diagram of the pattern structure

## 🎯 Purpose of This Project

The purpose of this project is to:
- Understand the concept of the **Memento Design Pattern**
- Learn how state saving and restoration works
- Demonstrate the pattern with a simple practical example

## 📚 Course

Design Patterns – Software Engineering Course

---

👨‍💻 Created for learning and educational purposes.

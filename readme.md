# C# Event Handling Example: Xmas Tree Printers

## Overview
This project demonstrates the use of events in C#. It consists of a `XmasTree` class that sends tree pattern data to different printer classes (`ColorPrinter` and `NormalPrinter`) using events. The printers subscribe to the `XmasTree`'s event and react differently based on the type of printer.

## Files and Classes
1. **XmasTree.cs**: Represents the event publisher. It creates a Christmas tree pattern and uses an event to send this data to subscribers.
2. **ColorPrinter.cs**: A subscriber that listens to `XmasTree`'s events and prints the tree pattern in random colors.
3. **NormalPrinter.cs**: Another subscriber that prints the tree pattern in normal console color.
4. **Program.cs**: The entry point of the application where the `XmasTree` and printer instances are created and linked.

## Usage
Run `Program.cs` to see the output. The program will first print the Christmas tree pattern in normal color and then in random colors.

## Key Concepts Illustrated
- Event declaration and raising
- Event subscription and handling
- Use of delegates in C#
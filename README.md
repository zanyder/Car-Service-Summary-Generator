# Car Service Summary Generator

A small Windows Forms desktop application that generates printable summaries for car service records. Built for .NET Framework 4.7.2 as an object-oriented assignment, this project demonstrates fundamental software-engineering skills including UI design, domain modelling, validation, and simple persistence.

## Purpose

The app is an educational, real-world example of a form-based data-entry tool. It collects vehicle and service information, validates input, formats a service summary, and provides options to save or print the result.

## Key Features

- Windows Forms UI for entering vehicle and service details
- Input validation with user feedback to prevent invalid data
- Generation of a readable service summary for display, print, or save
- Clear separation between UI and domain logic for maintainability

## Skills and Understanding Demonstrated

This project emphasizes practical application of core software-development principles:

- Object-oriented design: domain classes represent Vehicles and ServiceRecords, demonstrating encapsulation and single-responsibility.
- Event-driven GUI programming: Windows Forms event handlers wire UI actions (buttons, form events) to application behavior.
- Input validation and defensive coding: the app validates required fields and numeric inputs, and uses try/catch around risky operations.
- Separation of concerns: business logic is kept separate from presentation where possible, making the code easier to test and extend.
- File I/O and export: demonstrates safe handling of file writes for saving summaries.

## Project Structure (What to inspect)

- Form1.cs / Form1.Designer.cs — main UI and event handlers
- Program.cs — application entry point
- Models/ (if present) — classes for Vehicle, ServiceRecord, etc.
- Services/ or Utilities/ (if present) — formatting, validation, and file I/O helpers

## Build and Run

Prerequisites: Windows, Visual Studio (2019/2022/2026) and .NET Framework 4.7.2 Developer Pack.

1. Open `Assignment3_Byfielda.sln` in Visual Studio.
2. Restore NuGet packages (if any).
3. Build the solution (Build → Build Solution).
4. Run (F5 or Debug → Start Debugging). The main form is `Form1`.

## Quick Usage

1. Enter vehicle and service details on the form (make/model, date, odometer, service tasks).
2. Fix any validation errors reported by the UI.
3. Generate the service summary and choose to save or print.

## Suggestions for Extension

- Add persistent storage (SQLite or JSON) to manage multiple records.
- Add PDF export for higher-quality printable summaries.
- Refactor business logic into testable service classes and add unit tests.

## For Evaluators

Check `Form1.cs` and any model/service classes to see concrete uses of OOP, validation logic, and separation of concerns. The project is intended to demonstrate a solid grasp of event-driven desktop application development and maintainable code organization.

## License

Add a license file or choose a license (e.g., MIT) if you want to publish or share this repository publicly.


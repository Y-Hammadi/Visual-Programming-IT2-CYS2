# Introduction to Windows Forms

## Learning Objectives

By the end of this lecture, students should be able to:

- Explain what Windows Forms is and why it is used.
- Distinguish between Console and GUI applications.
- Create a Windows Forms project using Visual Studio.
- Identify the main parts of the Windows Forms development environment.
- Understand Forms and Controls.
- Recognize common Windows Forms controls and their basic properties.
- Explain the basic idea of properties, methods, and events.

---

## 1. What is Windows Forms?

**Windows Forms (WinForms)** is a graphical user interface (GUI) framework for building Windows desktop applications using .NET and C#.

Instead of interacting with a program only through text commands, users can interact with a Windows Forms application through windows, buttons, text boxes, menus, and other visual elements.

### Why Use Windows Forms?

Windows Forms makes it possible to:

- Build desktop applications with graphical interfaces.
- Collect information from users through input controls.
- Display information in a clear and organized way.
- Respond to user actions such as clicks and text input.
- Create applications for everyday tasks, such as data entry and management systems.

### Examples of Windows Forms Applications

- Student management systems.
- Library management systems.
- Point-of-sale applications.
- Inventory management systems.
- Simple calculator applications.

> **Note:** Windows Forms is primarily used to build applications for Windows.

---

## 2. GUI vs. Console Applications

Applications can provide different ways for users to interact with them.

### Console Application

A Console application mainly uses text input and output. The user interacts with the application by typing commands or values into a terminal.

### GUI Application

A GUI (Graphical User Interface) application provides visual elements such as windows, buttons, labels, and text boxes. Users can interact with these elements using a mouse or keyboard.

### Main Differences

| Console Application | GUI Application |
|---|---|
| Mainly text-based interaction. | Visual interaction through interface elements. |
| Uses a terminal or command prompt. | Uses windows and graphical controls. |
| Input is usually entered as text. | Input can be entered through different controls. |
| Suitable for command-line tools and simple exercises. | Suitable for interactive desktop applications. |

---

## 3. Creating a Windows Forms Project

We can create a Windows Forms project using **Visual Studio**.

### Steps

1. Open Visual Studio.
2. Select **Create a new project**.
3. Search for `Windows Forms`.
4. Choose the appropriate template, such as **Windows Forms App**.
5. Click **Next**.
6. Enter the project name.
7. Choose the project location.
8. Select the target .NET version if the template asks for it.
9. Click **Create**.

Visual Studio will create the project and open the Form Designer.

### Important Note About Project Templates

Visual Studio may provide more than one Windows Forms template, depending on the installed workloads and .NET versions.

- **Windows Forms App:** The modern .NET template.
- **Windows Forms App (.NET Framework):** The template for applications targeting .NET Framework.

> **For this course, choose Windows Forms App (.NET Framework).**

### Running the Application

After creating the project:

1. Press `F5` or click **Start**.
2. Visual Studio builds and runs the application.
3. A blank Form window appears.
4. Close the application to return to Visual Studio.

---

## 4. Understanding the Visual Studio Environment

When a Windows Forms project is open, Visual Studio provides several tools that help us design and develop the application.

### 4.1 Form Designer

The Form Designer is the visual area where we design the application window.

We can use it to:

- Add controls to the Form.
- Move controls.
- Resize controls.
- Arrange controls.
- Select controls to edit their properties.

### 4.2 Toolbox

The Toolbox contains the controls that we can add to a Form.

Examples include:

- Label
- TextBox
- Button
- RadioButton
- CheckBox

To add a control, we can drag it from the Toolbox and drop it onto the Form.

### 4.3 Properties Window

The Properties Window displays the properties of the currently selected Form or control.

For example, when we select a Button, we can change its text, name, color, size, and other properties.

### 4.4 Solution Explorer

Solution Explorer displays the structure of the project, including:

- Project files.
- Forms.
- Source code files.
- Resources and other project items.

### 4.5 Code Editor

The Code Editor is where we write and edit C# code.

In Windows Forms, the code is used to define application behavior and respond to user actions.

---

## 5. Understanding Forms

A **Form** is a window that acts as a container for controls in a Windows Forms application.

A Form can contain buttons, labels, text boxes, and other interface elements.

Most Windows Forms applications have at least one Form.

### Common Form Properties

| Property | Description |
|---|---|
| `Name` | The name used to refer to the Form in code. |
| `Text` | The text displayed in the Form's title bar. |
| `Size` | The width and height of the Form. |
| `StartPosition` | Determines where the Form appears when it starts. |
| `BackColor` | Sets the background color. |
| `FormBorderStyle` | Controls the appearance and resizing behavior of the Form border. |
| `MaximizeBox` | Determines whether the maximize button is available. |
| `MinimizeBox` | Determines whether the minimize button is available. |

### Important Difference: Name and Text

- `Name` is used in the code to identify the Form.
- `Text` is displayed to the user, usually in the title bar.

For example:

- `Name`: `MainForm`
- `Text`: `Student Management System`

---

## 6. Introduction to Controls

A **Control** is a visual element placed on a Form to display information or allow the user to interact with the application.

Examples of controls include:

- Label: Displays text.
- TextBox: Accepts text input.
- Button: Allows the user to perform an action.
- RadioButton: Allows the user to select one option from a group.
- CheckBox: Allows the user to select or clear an independent option.

### Working with Controls

In the Form Designer, we can:

1. Select a control from the Toolbox.
2. Drag it onto the Form.
3. Move it to the desired position.
4. Resize it using its handles.
5. Select it and edit its properties in the Properties Window.
6. Delete it if it is no longer needed.

### Common Properties of Controls

Many controls share some common properties:

| Property | Description |
|---|---|
| `Name` | The identifier used to access the control in code. |
| `Text` | The text displayed by the control, if applicable. |
| `Size` | The width and height of the control. |
| `Location` | The position of the control on its parent container. |
| `Enabled` | Determines whether the user can interact with the control. |
| `Visible` | Determines whether the control is displayed. |
| `BackColor` | Sets the background color. |
| `ForeColor` | Sets the foreground or text color. |
| `Font` | Sets the font family, size, and style. |

---

## 7. Basic Windows Forms Controls

### 7.1 Label

A **Label** is used to display text that the user generally cannot edit directly.

Common uses:

- Displaying field names.
- Showing instructions.
- Displaying short messages.
- Providing titles or descriptions.

#### Common Label Properties

| Property | Description |
|---|---|
| `Name` | The identifier used in code. |
| `Text` | The text displayed by the Label. |
| `Font` | Changes the font family, size, and style. |
| `ForeColor` | Changes the text color. |
| `BackColor` | Changes the background color. |
| `AutoSize` | Automatically adjusts the control size to fit its content. |
| `TextAlign` | Sets the alignment of the text. |

**Example:**

A Label displaying:

`Enter your name:`

---

### 7.2 TextBox

A **TextBox** allows the user to enter or edit text.

Common uses:

- Entering a person's name.
- Entering an email address.
- Entering a phone number.
- Entering a password.

#### Common TextBox Properties

| Property | Description |
|---|---|
| `Name` | The identifier used in code. |
| `Text` | Gets or sets the text inside the TextBox. |
| `Multiline` | Allows the user to enter multiple lines of text. |
| `MaxLength` | Sets the maximum number of characters. |
| `ReadOnly` | Prevents the user from editing the text. |
| `PasswordChar` | Displays a specified character instead of the entered characters. |
| `UseSystemPasswordChar` | Uses the system's password character to hide entered text. |
| `TextAlign` | Sets the alignment of the text. |

**Example:**

A TextBox next to a Label that says `Full Name`.

---

### 7.3 Button

A **Button** is a control that allows the user to initiate an action.

Common uses:

- Saving information.
- Submitting a form.
- Searching for data.
- Closing a window.
- Clearing input fields.

#### Common Button Properties

| Property | Description |
|---|---|
| `Name` | The identifier used in code. |
| `Text` | The text displayed on the Button. |
| `Enabled` | Determines whether the Button can be clicked. |
| `Visible` | Determines whether the Button is displayed. |
| `BackColor` | Changes the background color. |
| `ForeColor` | Changes the text color. |
| `Font` | Changes the font settings. |
| `Image` | Displays an image on the Button. |

**Example:**

A Button displaying:

`Save`

When the user clicks it, the application can save the entered information. The actual behavior is implemented using code and events.

---

### 7.4 RadioButton

A **RadioButton** allows the user to select one option from a group of mutually exclusive options.

This means that, within the same group, selecting one RadioButton automatically clears the selection of another.

Common uses:

- Selecting gender options.
- Choosing a payment method.
- Selecting an account type.
- Choosing one answer from multiple options.

#### Common RadioButton Properties

| Property | Description |
|---|---|
| `Name` | The identifier used in code. |
| `Text` | The text displayed next to the RadioButton. |
| `Checked` | Indicates whether the RadioButton is selected. |
| `Enabled` | Determines whether the user can interact with it. |
| `Visible` | Determines whether the RadioButton is displayed. |
| `AutoCheck` | Determines whether the control automatically changes its checked state when clicked. |

**Example:**

Choose your account type:

- ( ) Student
- ( ) Teacher

The user can select only one option from this group.

> **Important:** RadioButtons are grouped according to their parent container. To create separate groups, place them in different containers, such as GroupBox or Panel controls.

---

### 7.5 CheckBox

A **CheckBox** allows the user to select or clear an option independently of other CheckBoxes.

Unlike RadioButtons, multiple CheckBoxes can be selected at the same time.

Common uses:

- Selecting hobbies.
- Accepting terms and conditions.
- Choosing additional services.
- Selecting multiple preferences.

#### Common CheckBox Properties

| Property | Description |
|---|---|
| `Name` | The identifier used in code. |
| `Text` | The text displayed next to the CheckBox. |
| `Checked` | Indicates whether the CheckBox is selected. |
| `CheckState` | Represents the state of the CheckBox: Checked, Unchecked, or Indeterminate. |
| `ThreeState` | Allows the CheckBox to have three states. |
| `Enabled` | Determines whether the user can interact with it. |
| `Visible` | Determines whether the CheckBox is displayed. |

**Example:**

Choose your hobbies:

- [ ] Reading
- [ ] Programming
- [ ] Sports

The user can select more than one option.

---

## 8. Properties, Methods, and Events

In Windows Forms, controls have properties, methods, and events. These concepts help us understand how controls are configured and how they behave.

### 8.1 Properties

A **Property** describes an attribute or setting of an object.

Examples:

- `Text`: The text displayed by a control.
- `BackColor`: The background color.
- `Enabled`: Whether the control is enabled.
- `Visible`: Whether the control is visible.

Properties describe the state or appearance of an object.

### 8.2 Methods

A **Method** is an operation that an object can perform.

Examples:

- `Show()`: Displays a Form or control.
- `Hide()`: Hides a Form or control.
- `Focus()`: Sets the input focus to a control.
- `Close()`: Closes a Form.

### 8.3 Events

An **Event** represents an action or occurrence that an application can respond to.

Examples:

| Event | Description |
|---|---|
| `Click` | Occurs when a control is clicked. |
| `TextChanged` | Occurs when the text changes. |
| `CheckedChanged` | Occurs when the checked state changes. |
| `Load` | Occurs when a Form is being loaded. |

### What Is Event-Driven Programming?

Windows Forms applications commonly use **Event-Driven Programming**.

In this programming model, the application waits for events and executes specific code when those events occur.

For example:

1. The user clicks a Button.
2. The `Click` event occurs.
3. The application executes the code associated with that event.

We will learn how to write event-handling code in a practical lesson.

---

## 9. How a Windows Forms Application Works

A Windows Forms application typically follows this general flow:

1. The application starts.
2. The main Form is displayed.
3. The application waits for user interaction.
4. The user interacts with controls.
5. An event occurs.
6. The application executes the code associated with the event.
7. The application updates the interface or performs an action.
8. The application continues waiting for more interactions until it is closed.

### A Simple Example

Imagine a form that asks the user to enter their name.

The Form contains:

- A Label displaying `Enter your name:`
- A TextBox for entering the name.
- A Button displaying `Submit`.

The general interaction is:

1. The user enters a name in the TextBox.
2. The user clicks the Submit Button.
3. The Button's `Click` event occurs.
4. The application can read the entered text and process it.

This example demonstrates how Forms, Controls, Properties, and Events work together.

---

## 10. Summary

In this lecture, we learned:

- Windows Forms is a framework for building Windows desktop applications.
- GUI applications use visual elements to interact with users.
- A Windows Forms project can be created using Visual Studio.
- The Form Designer, Toolbox, Properties Window, Solution Explorer, and Code Editor are important development tools.
- A Form is a window that contains controls.
- Controls are visual elements used to display information or receive user input.
- Label, TextBox, Button, RadioButton, and CheckBox are common controls.
- Properties describe an object's settings.
- Methods represent operations that an object can perform.
- Events allow an application to respond to user actions.
- Windows Forms applications commonly use Event-Driven Programming.

---

## Key Terms

| Term | Meaning |
|---|---|
| Windows Forms | A framework for building Windows desktop applications. |
| GUI | Graphical User Interface. |
| Form | A window that contains controls. |
| Control | A visual element placed on a Form. |
| Toolbox | A collection of controls available in Visual Studio. |
| Property | An attribute or setting of an object. |
| Method | An operation that an object can perform. |
| Event | An occurrence to which an application can respond. |
| Event Handler | Code that executes in response to an event. |

---

**End of Lecture**

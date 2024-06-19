# Parameterized Password Generator

This repository hosts a WinForms application written in C#, designed for generating customized passwords based on specific criteria such as minimum and maximum counts of alphabetic characters, numeric digits, special characters, and optional separators.

## Overview

The application allows users to input parameters directly into the UI and generates multiple passwords according to the specified criteria. It employs a Linear Feedback Shift Register (LFSR) for pseudo-random character generation and supports the inclusion of separators at specified intervals within passwords.

## Key Features

- **Input Parameters**:
  - Specify minimum and maximum counts for uppercase and lowercase alphabetic characters.
  - Define minimum and maximum counts for numeric digits.
  - Set minimum and maximum counts for special characters.
  - Toggle separators and adjust their interval within generated passwords.

- **Password Generation**:
  - Utilizes an LFSR algorithm to produce sequences of characters.
  - Selects alphabetic, numeric, and special characters randomly based on user-defined ranges.

- **Separator Functionality**:
  - Optionally inserts separators (e.g., '-') at specified intervals within generated passwords.

## Usage

1. **Configure Parameters**:
   - Launch the WinForms application.
   - Enter desired parameter values directly into the provided fields.

2. **Generate Passwords**:
   - Click the "Generate Passwords" button to initiate the password generation process.

3. **View Generated Passwords**:
   - The generated passwords will be displayed in the application's list box are.

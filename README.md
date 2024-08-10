# Number Prettifier
## Overview
The idea behind the "Number Prettifier" is to make large numbers easier to read by shortening them with suffixes like M for million, B for billion, and T for trillion.
This folder contains the Python and C# implementation of the number prettifier. I've also included commented code at the bottom of both the Python and C# implementations to demonstrate how the prettification logic can be achieved without using libraries like 'math'.

## Additional Work
Since the requirements specify that there will be room to expand on this idea in future rounds, I have avoided implementing anything beyond the basic functionality in the requirement samples. For instance:
- I have not yet explicitly handled negative integers.
- I have not handled numbers less than one like 0.75

## Assumptions I made:
- The input is always numeric.
- Numbers below a million are returned unchanged
- As of now, the requirements are based on the sample cases provided.

## Requirements (From the email):

- Input: `1000000` -> Output: `1M`
- Input: `2500000.34` -> Output: `2.5M`
- Input: `532` -> Output: `532`
- Input: `1123456789` -> Output: `1.1B`

## Approach and Decisions
The prettifier function accepts any numeric input. It determines an appropriate suffix based on predefined thresholds. Any number less than a million is returned as-is.
- I picked C# and Python as two languages just to show the same concept in a statically typed and dynamic language. 
- I used NUnit for the testing framework in C# since I have experience using it at Siemens Healthineers.

## Project Structure:
number_prettifier/
│
├── csharp/
│   ├── NumberPrettifier/
│   │   └── Program.cs
│   └── NumberPrettifier.Tests/
│       └── UnitTest1.cs
│
├── python/
│   ├── prettifier.py
│   └── test_prettifier.py
│
└── README.md

## Running Tests:
Python:
python -m unittest test_prettifier.py

C#:
dotnet test

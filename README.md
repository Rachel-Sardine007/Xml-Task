# Xml-Task
## Description

This is a simple console application built in C# that reads an XML file, finds a specific element by its `id`, extracts the value of its `target` element, and writes the result to a file.

The task was implemented as part of a technical assignment.

---

## How it works

1. The application loads an XML file `gentext.xml`
2. It searches for an element with an attribute `id` == `42014`
3. It extracts the value of the `target` element
4. The result is printed to the console and written to an output TXT file

---

## Implementation details

* Built using **.NET Console Application**
* XML parsing is done using **LINQ to XML (`XDocument`)**
* The logic is separated into:

  * `XmlService` – XML parsing and data extraction
  * `FileService` – writing output to file
  * `Program` – coordinates the flow

---

## Running the application

Make sure `gentext.xml` is available in the output directory.

Run the application:

```
dotnet run
```

---

## Output

The extracted value is written to:

```
Output.txt
```

Example output:

```
File not found.
```

---

## Notes

* Basic error handling is included for missing elements or values
* The structure can be extended if needed (e.g. support for multiple IDs or input arguments)

---

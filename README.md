# 🧾 ParagraphSplitter

### 🧠 Description
**ParagraphSplitter** is a Windows desktop tool built using C# and .NET Framework that processes text files to extract, clean, and filter English words.  
It removes unwanted characters, filters forbidden terms, and saves the clean words into an output file.

---

## Features
- **Drag & Drop Support** for input, output, and filter files.
- **Cleans text** by removing non-English symbols and tags.
- **Converts words to lowercase** for normalization.
- **Skips forbidden words** using a filter list.
- **Prevents duplication** of words.
- **Hash-based word organization** for faster lookup.
- **Exports results** to a specified output text file.

---

## Requirements
- Windows OS
- .NET Framework 4.x
- Visual Studio (any edition that supports WinForms)

---

## 📥 Installation
1. Clone or download this repository.
2. Open the `.sln` file using **Visual Studio**.
3. Build the project (Ctrl + Shift + B).
4. Run the application (F5).

---

## Usage

1. **Input File:**  
   - Drag and drop a `.txt` file into the **Input** textbox.  
   - The file should contain paragraphs or sentences.

2. **Filter File:**  
   - Drag and drop a `.txt` file containing forbidden words (one per line).  
   - These words will be skipped during processing.

3. **Output File:**  
   - Drag and drop a `.txt` file where you want to save the results.  
   - The program will append the filtered words there.

4. **Start Processing:**  
   - Click the **Start** button (usually the `button1`) to begin.  
   - The app will display a message box showing how many valid words were counted.

---

## Example

### Example Input (`input.txt`)

# Shopping Cart Unit Tests

This project contains comprehensive unit tests for the Shopping Cart Windows Forms application, achieving 100% code coverage.

## Running Tests

### Prerequisites
- Visual Studio 2019 or later with .NET Framework 4.7.2
- Windows operating system (required for .NET Framework and Windows Forms)

### Steps to Run Tests

1. Open `Shopping Cart.sln` in Visual Studio
2. Build the solution (Ctrl+Shift+B)
3. Open Test Explorer (Test > Test Explorer)
4. Click "Run All" to execute all tests

## Measuring Code Coverage

### Using Visual Studio Enterprise
1. Go to Test > Analyze Code Coverage for All Tests
2. The Code Coverage Results window will show coverage percentages
3. You should see 100% coverage for Form1.vb

### Using Visual Studio Community with Fine Code Coverage Extension
1. Install the Fine Code Coverage extension from the Visual Studio Marketplace
2. Run tests normally
3. View coverage results in the Fine Code Coverage window

## Test Coverage

The test suite includes 9 test methods covering:
- All 8 combinations of checkbox selections for the total calculation (Button1_Click)
- The clear functionality (Button2_Click)

### Test Cases

#### Button1_Click Tests (8 test cases)
1. **No checkboxes selected**: Total = ₹0
2. **Laptop only** (CheckBox1): Total = ₹50,000
3. **Mouse only** (CheckBox2): Total = ₹10,000
4. **Keyboard only** (CheckBox3): Total = ₹8,000
5. **Laptop + Mouse**: Total = ₹60,000
6. **Laptop + Keyboard**: Total = ₹58,000
7. **Mouse + Keyboard**: Total = ₹18,000
8. **All items selected**: Total = ₹68,000

#### Button2_Click Tests (1 test case)
- Verifies all checkboxes are unchecked and text is reset to "Total is :"

## Notes

- The VB.NET `Str()` function adds a leading space for positive numbers, so expected values include an extra space after the ₹ symbol
- Tests use `PerformClick()` to simulate button clicks, which is the standard approach for Windows Forms unit testing
- These tests achieve 100% code coverage of the Form1 business logic

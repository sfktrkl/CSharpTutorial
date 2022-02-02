
namespace ConsoleApplication
{
    // Method is a collection of statements that perform some specific 
    // tasks and then return that result to the caller.
    // Method can also perform some specific task without returning anything.
    // Access modifiers, public, private, protected
    // Return type, data type returned by value, or void.
    // Parameeter list, comma separated list of input parameters.
    // Enhance the readability of the code.
    // Reuse the existing code.
    // Optimizes the execution time and memory space.
    // Static methods that are called on the class itself.
    // The static modifier ensures implementation is the same across all class instances.
    // Value parameters will pass a copy of the original value instead of the original.
    // Output parameters are more like a reference type of parameter but don't need initialization.
    // Method overloading allows the creation of several methods with the same name, 
    // which differ from each other in the type of input.
    class Methods
    {
        public bool visible = true;
        public string text1 = "";
        public string text2 = "";
        public string label1 = "";
        public string label2 = "";
        public string label3 = "";

        private void Hide()
        {
            visible = false;
        }

        private void ClearAllText()
        {
            text1 = "";
            text2 = "";
        }

        private void FillTextBox(string text)
        {
            text2 = text;
        }

        private void SetNumber(int age)
        {
            label1 = age.ToString();
        }

        private string GetName()
        {
            return "Charles";
        }

        private int Sum(int x, int y)
        {
            return x + y;
        }

        private string ValueControl()
        {
            return "ValueControl()";
        }

        private string ValueControl(string name)
        {
            return "ValueControl(name)";
        }

        private string ValueControl(string name, bool control)
        {
            return "ValueControl(name, control)";
        }

        public void Method1()
        {
            Hide();
            ClearAllText();
        }

        private void Method2()
        {
            SetNumber(12);
            label2 = GetName();
            FillTextBox(text1);
        }

        private void Method3()
        {
            label1 = ValueControl();
            label2 = ValueControl("name");
            label3 = ValueControl("name", true);
        }
    }
}

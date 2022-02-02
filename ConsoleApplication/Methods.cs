
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

    // The created methods and the properties are contained 
    // within a class and we can always reuse a class.
    // Both functions and data are closely linked at the same time.
    // Class must contain a number of members for the objects to be created in.
    // Class defines the operations and properties associated with the status of the objects.
    // Data and procedures for objects with common properties are collected in a class.
    // Classes support polymorphism, inheritance and also provides the concept of 
    // derived classes as well as base classes.
    // A field has to be declared in a type class war structure with 
    // its data type and an identifier that names the member.
    // Properties are the special type of class members that provides a flexible 
    // mechanism in order to read and write or compute the value of a private field,
    // properties can be used as if they are public data members, but they are
    // actually special methods called accessors.
    // Encapsulation and the hiding of information can also be achieved using properties,
    // so it uses predefined methods which are get and set.
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

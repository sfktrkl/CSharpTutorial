
namespace ConsoleApplication
{
    interface Computer
    {
        void GetDesktops();
        void GetLaptops();
    }

    interface DellComputer
    {
        void GetMark();
    }

    class DellComputers : Computer, DellComputer
    {
        public void GetDesktops() { }
        public void GetLaptops() { }
        public void GetMark() { }
    }
}

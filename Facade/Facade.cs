namespace Facade
{
    class Facade
    {
        private SubSystem1 subSystem1 = new SubSystem1();
        private SubSystem2 subSystem2 = new SubSystem2();
        private SubSystem3 subSystem3 = new SubSystem3();
        private SubSystem4 subSystem4 = new SubSystem4();

        public void MethodA() 
        {
            subSystem1.MethodOne();
            subSystem2.MethodTwo();
        }
        public void MethodB()
        {
            subSystem3.MethodThree();
            subSystem4.MethodFour();
        }
    }
}
namespace unitTestExercise
{
    public class DummyClass
    {
        string name;
        bool amDummy;

        public DummyClass(string name = "Dummy Doe")
        {
            this.name = name;
            amDummy = true;

        }
        public string PresentYourself()
        {
            return $"My name is {name}. Am I a dummy? Well: {amDummy}";
        }
    }
}

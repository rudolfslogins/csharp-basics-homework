namespace Exercise7
{
    public class Dog
    {
        private string _name;
        private string _sex;
        private string _mother;
        private string _father;

        public Dog(string name, string sex)
        {
            _name = name;
            _sex = sex;
        }

        public void SetParents(string motherName, string fatherName)
        {
            _mother = motherName;
            _father = fatherName;
        }

        public string GetFathersName()
        {
            if (_father == null)
            {
                return "Unknown";
            }

            return _father;
        }

        public bool HasSameMotherAs(Dog otherDog)
        {
            if (otherDog._mother == _mother)
            {
                return true;
            }

            return false;
        }
    }
}
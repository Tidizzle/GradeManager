namespace GradeManagerV4.Classes
{
    internal class Grade
    {
        private string owner;
        private string letter;
        private ParentClass parent;
        private double percentage;

        public string Owner
        {
            get
            {
                return owner;
            }

            set
            {
                owner = value;
            }
        }

        public string Letter
        {
            get
            {
                return letter;
            }

            set
            {
                letter = value;
            }
        }

        internal ParentClass Parent
        {
            get
            {
                return parent;
            }

            set
            {
                parent = value;
            }
        }

        public double Percentage
        {
            get
            {
                return percentage;
            }

            set
            {
                percentage = value;
            }
        }
    }
}
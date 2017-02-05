namespace GradeManagerV4.Classes
{
    public class ParentClass
    {
        public enum Types { Honors, Standard, Ap };

        public enum Scales { TenPoint, SevenPoint };

        private Types classType;
        private Scales gradingScale;
        private string className;

        internal Types ClassType
        {
            get
            {
                return classType;
            }

            set
            {
                classType = value;
            }
        }

        internal Scales GradingScale
        {
            get
            {
                return gradingScale;
            }

            set
            {
                gradingScale = value;
            }
        }

        public string ClassName
        {
            get
            {
                return className;
            }

            set
            {
                className = value;
            }
        }
    }
}
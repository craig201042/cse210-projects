public abstract class Goal
{
        protected string _ShortName;
        protected string _description;
        protected int _points;

        protected string _checkbox="[]";

        public Goal(string shortName, string description, int points)
        {
                     _ShortName=shortName;
                     _description=description;
                     _points=points;
        }
        public abstract int GetPoint();
        public abstract string Getname();
        public abstract string GetCheckbox();
        public abstract void SetCheckbox(string checkbox);
        public abstract void RecordEvent();
        public abstract bool IsComplete();
        public virtual string GetDetailsString() {
                return $"{_checkbox} {_ShortName}({_description})";
        }
        public abstract string GetStringRepresentation();

}
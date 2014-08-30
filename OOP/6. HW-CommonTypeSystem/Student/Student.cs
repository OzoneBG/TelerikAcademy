using System;
using System.Text;

namespace Student
{
    public class Student : ICloneable, IComparable<Student>
    {
        //1. Define a class Student, which contains data about a
        //student – first, middle and last name, SSN,
        //permanent address, mobile phone e-mail, course,
        //specialty, university, faculty

        //Fields
        string firstName;
        string middleName;
        string lastName;
        int SSN;
        string permamentAddres;
        string mobilePhone;
        string email;
        string course;
        Specialty specialty;
        University university;
        Faculty faculty;

        //Properties
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string MiddleName
        {
            get { return this.middleName; }
            set { this.middleName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public int Ssn
        {
            get { return this.SSN; }
            set { this.SSN = value; }
        }
        
        public string PermamentAddress
        {
            get { return this.permamentAddres; }
            set { this.permamentAddres = value; }
        }

        public string MobilePhone
        {
            get { return this.mobilePhone; }
            set { this.mobilePhone = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public string Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public Specialty Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }

        public Faculty Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
        }

        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }

        //Constructor
        public Student(string FirstName, string MiddleName, string LastName, int Ssn,
                       string Address, string Phone, string Email, string Course,
                       Specialty Specialty, University University, Faculty Faculty)
        {
            this.firstName = FirstName;
            this.middleName = MiddleName;
            this.lastName = LastName;
            this.SSN = Ssn;
            this.permamentAddres = Address;
            this.mobilePhone = Phone;
            this.email = Email;
            this.course = Course;
            this.specialty = Specialty;
            this.university = University;
            this.faculty = Faculty;
        }

        //1. Override the standard methods, inherited by
        //System.Object: Equals(), ToString(),
        //GetHashCode() and operators == and !=.
        
        
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("{0} {1} {2} from {3}, {4}", this.FirstName, this.MiddleName, this.LastName, this.University, this.Faculty);
            return result.ToString();
        }

        public override bool Equals(object otherStudent)
        {
            Student student = otherStudent as Student;

            if (student == null)
            {
                return false;    
            }

            if (!System.Object.Equals(this.Ssn, student.Ssn))
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }
        
        //2. Add implementations of the ICloneable interface.
        ///The Clone() method should deeply copy all object's
        //fields into a new object of type Student.

        public object Clone()
        {
            Student newStudent = new Student(this.FirstName, this.MiddleName, this.LastName, this.Ssn, this.PermamentAddress,
                this.MobilePhone, this.Email, this.Course, this.Specialty, this.University, this.Faculty);

            return newStudent;
        }

        //3. Implement the  IComparable<Student> interface
        //to compare students by names (as first criteria, in
        //lexicographic order) and by social security number
        //(as second criteria, in increasing order).

        public int CompareTo(Student otherStudent)
        {
            if (this.FirstName != otherStudent.FirstName)
            {
                return this.FirstName.CompareTo(otherStudent.FirstName);
            }

            if (this.MiddleName != otherStudent.MiddleName)
            {
                return this.MiddleName.CompareTo(otherStudent.MiddleName);
            }

            if (this.LastName != otherStudent.LastName)
            {
                return this.LastName.CompareTo(otherStudent.LastName);
            }

            if (this.Ssn != otherStudent.Ssn)
            {
                return this.Ssn.CompareTo(otherStudent.Ssn);
            }

            return 0;
        }

    }
}

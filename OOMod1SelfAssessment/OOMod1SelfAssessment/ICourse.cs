namespace OOMod1SelfAssessment
{
    public interface ICourse
    {
        string CourseName { get; set; }

        void AddStudent(Student newStudent);
    }
}
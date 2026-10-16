namespace Ifrastructure;
public class DepartmentService
    {
        public List<Department> departments = new List<Department>();

        public List<Department> GetDepartments()
        {
            return departments;
        }

        public void AddDeparments(Department department)
        {
            departments.Add(department);
        }

        public int CountDepartments()
        {
            return departments.Count;
        }
    }
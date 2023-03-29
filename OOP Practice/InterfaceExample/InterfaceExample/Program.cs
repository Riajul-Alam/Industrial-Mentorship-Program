using InterfaceExample;





Student student = new Student();
student.RegNo=125454;

string info=student.GetBasicInformation();

Department department = new Department();
department.Code="CSE-4544";
string deptinfo=department.GetBasicInformation();

Course course = new Course();
course.Code="565656";
string courseInfo=course.GetBasicInformation();
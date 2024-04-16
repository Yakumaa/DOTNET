namespace MVC.Models
{
    //model is used to store data and logic. it is accessible by controller and view to preview
    //necessary responses. to use model by controller it should using projectname.models and
    //to use model in view it should add 
    //@using projectname.models. as model is class it normally contains properties

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Faculty { get; set; }

        public string Grade { get; set; }
    }
}

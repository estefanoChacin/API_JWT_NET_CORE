using JWT.Models;

namespace JWT.CONSTANS
{
    public class EmployeContants
    {
        public static List<EmployesModel> listEmployes = new List<EmployesModel>() {
           new EmployesModel(){ id=1, name= "empleado1", email= "empleado1@gmail.com", phone="123455", salary= 1.200000},
           new EmployesModel(){ id=2, name= "empleado2", email= "empleado2@gmail.com", phone="1234566", salary= 1.300000},
           new EmployesModel(){ id=3, name= "empleado3", email= "empleado3@gmail.com", phone="12345777", salary= 1.400000},
           new EmployesModel(){ id=4, name= "empleado4", email= "empleado4@gmail.com", phone="123458888", salary= 1.500000},
           new EmployesModel(){ id=5, name= "empleado5", email= "empleado5@gmail.com", phone="1234599999", salary= 1.700000}

        };
    }
}

using JWT.Models;

namespace JWT.CONSTANS
{
    public class UsersConstants
    {
        public static  List<UserModel> usuarios = new List<UserModel>()
        {
            new UserModel(){ id=1, name="jhon", lastmane="guerrero", email="jhon@gmail.com", password="12345", rol="administrador"},
            new UserModel(){ id=2, name="maria", lastmane="chacin", email="maria@gmail.com", password="12345", rol="seguridad"},
            new UserModel(){ id=3, name="faruth", lastmane="chacin", email="Faruth@gmail.com", password="12345", rol="tecnico"}

        };

         
    }
}

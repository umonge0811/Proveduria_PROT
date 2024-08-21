namespace Proveduria_PROT.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
    {
                new UserAccount { UserName = "1", Password = "1", Role = "Administrador", Name="Ulises Monge", ProfileImagePath = "img/admin.jpg" },
                new UserAccount { UserName = "2", Password = "2", Role = "Comprador", Name = "Kevin Núñez", ProfileImagePath = "img/comp1.jpg" },
                new UserAccount { UserName = "3", Password = "3", Role = "Jefe Departamento" ,Name = "Elías Méndez", ProfileImagePath = "img/jefe.jpg" },
                new UserAccount { UserName = "4", Password = "4", Role = "Aprobador", Name = "Dayana Murillo", ProfileImagePath = "img/aprobador.jpg" }
    };
        }


        public UserAccount GetByUserName(string userName) 
        {
            return _users.FirstOrDefault(x => x.UserName == userName);        
        }

    }


}

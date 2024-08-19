namespace Proveduria_PROT.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
    {
                new UserAccount { UserName = "Admin", Password = "admin", Role = "Administrador", Name="Ulises Monge", ProfileImagePath = "img/admin.jpg" },
                new UserAccount { UserName = "Compras1", Password = "comp123", Role = "Comprador", Name = "Kevin Núñez", ProfileImagePath = "img/comp1.jpg" },
                new UserAccount { UserName = "Jefe", Password = "jefe123", Role = "Jefatura" ,Name = "Elías Méndez", ProfileImagePath = "img/jefe.jpg" },
                new UserAccount { UserName = "Aprobador1", Password = "Aprob123", Role = "Aprobador", Name = "Dayana Murillo", ProfileImagePath = "img/aprobador1.jpg" }
    };
        }


        public UserAccount GetByUserName(string userName) 
        {
            return _users.FirstOrDefault(x => x.UserName == userName);        
        }

    }


}

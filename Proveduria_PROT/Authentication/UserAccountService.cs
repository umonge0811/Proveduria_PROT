namespace Proveduria_PROT.Authentication
{
    public class UserAccountService
    {
        private List<UserAccount> _users;

        public UserAccountService()
        {
            _users = new List<UserAccount>
            {
                new UserAccount { UserName = "Admin", Password = "admin", Role = "Administrador", Name="Ulises Monge"},
                new UserAccount { UserName = "Compras1", Password = "comp123", Role = "Comprador", Name = "kevin Núñez"},
                new UserAccount { UserName = "Jefe", Password = "jefe123", Role = "Jefatura" ,Name = "Elías Méndez" },
                new UserAccount { UserName = "Aprobador1", Password = "Aprob123", Role = "Aprobador", Name = "Dayana Murillo" }

            };
        }

        public UserAccount GetByUserName(string userName) 
        {
            return _users.FirstOrDefault(x => x.UserName == userName);        
        }

    }


}

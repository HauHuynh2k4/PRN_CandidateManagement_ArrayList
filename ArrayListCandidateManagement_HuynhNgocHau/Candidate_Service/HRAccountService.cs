using Candidate_BO;
using Candidate_DAO;
using Candidate_Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate_Service
{
    public class HRAccountService : IHRAccountService
    {
        private IHRAccountRepo repo;

        public HRAccountService()
        {
            repo = new HRAccountRepo();
        }

        public ArrayList GetAllHRAccounts() => repo.GetHraccounts();
        public bool AddHRAccount(Hraccount account) => repo.AddHRAccount(account);

        public bool UpdateHRAccount(Hraccount account) => repo.UpdateHRAccount(account);

        public bool DeleteHRAccount(string email) => repo.DeleteHRAccount(email);

        public Hraccount GetHraccountByEmail(string email) => repo.GetHraccountByEmail(email);
        public ArrayList GetHraccountsByNameOrRole(string? name, int? Role) => repo.GetHraccountsByNameOrRole(name, Role);
    }
}

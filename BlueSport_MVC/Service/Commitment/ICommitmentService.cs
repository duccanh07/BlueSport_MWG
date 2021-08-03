using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlueSport_MVC.Models;
namespace BlueSport_MVC.Service.Commitment
{
    public interface ICommitmentService
    {
        public List<CommitmentModel> GetCommitments();
    }
}

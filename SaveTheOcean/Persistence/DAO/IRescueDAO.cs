using System;
using SaveTheOcean.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOcean.Persistence.DAO
{
    public interface IRescueDAO
    {

        RescueDTO GetRescueById(int id);
        public IEnumerable<RescueDTO> GetAllRescues();

        public void InsertRescue(RescueDTO rescue);

    }
}

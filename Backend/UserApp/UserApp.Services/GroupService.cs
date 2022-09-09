using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using UserApp.Models;
using UserApp.DAL;

namespace UserApp.Services
{
    public class GroupService : IGroupService
    {
        private readonly DAL.AppDbContext _db;

        public GroupService(DAL.AppDbContext db)
        {
            this._db = db;
        }
        // POST GROUP
        public void CreateGroup(GroupModel group)
        {
            // voy a llamar a AppContext para conectar con la DB
            // con Add(group) agrego a la DB
            /* necesito entrar al context. 
             * necesito dependency injection:
             * 1. tengo una clase GroupService que necesita un obj AppContext();
             * 2. para eso necesito un constructor de GroupService()
             * 3. Como INYECTAR DEPENDENCIAS: punto 05 de clase_05.txt
             */

            var groupEntity = new DAL.Entities.Group
            {
                groupName = group.groupName,
                Inactive = group.Status == "ACTIVE" ? false : true,
                LastUpdateBy = "",
                LastUpdateDate = DateTime.Now
            };

            // tengo que pasarle un Entity, pero group es Model
            _db.Groups.Add(groupEntity);

            // una vez que agrego la entity al DbSet Groups, salvo los cambios
            _db.SaveChanges();

        }

        public void DeleteGroup(int id)
        {
            throw new NotImplementedException();
        }

        public GroupModel GetGroup(int id)
        {
            return null;
        }

        public List<GroupModel> GetGroups()
        {
            throw new NotImplementedException();
        }

        public void UpdateGroup(GroupModel groupModel)
        {
            throw new NotImplementedException();
        }
    }
}

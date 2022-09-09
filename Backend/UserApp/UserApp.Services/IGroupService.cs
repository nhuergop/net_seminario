using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UserApp.Models;

namespace UserApp.Services
{

    // la interfaz define qué metodos y propiedades va a tener la clase que la implemente
    public interface IGroupService
    {
        public void CreateGroup(GroupModel groupModel);

        public void UpdateGroup(GroupModel groupModel);

        public GroupModel GetGroup(int id);

        public List<GroupModel> GetGroups();

        public void DeleteGroup(int id);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine.core.SOLUTIONS.Coffee.Commande
{
    public class CommandeDAO : CoffeeMachine.core.Base
    {

        private DotNetTN.Connector.DotNetTNConnector DotNetTNConnector = new DotNetTN.Connector.DotNetTNConnector(GetInstance());

        public List<Commande> GetListCommande()
        {
            var data = DotNetTNConnector.GetList<Commande>();
            return data;
        }
        /**Tested**/
        public void Add(Commande insertObj)
        {

            try
            {
                DotNetTNConnector.Insert(insertObj);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        /**Tested**/
        public void Update(Commande updateObj)
        {
            DotNetTNConnector.Update(updateObj);
        }

        public Commande Find(int id)
        {
            var student2 = DotNetTNConnector.GetById<Commande>(id);
            return student2;
        }

        public List<Commande> getByUser(string id)
        {

            var data2 = DotNetTNConnector.GetList<Commande>(it => it.userId == id);
            return data2;

        }
        /**Tested**/
        public void DeleteCommand(Commande cmd)
        {

            var data2 = DotNetTNConnector.Delete(cmd);
            //return data2;

        }

    }
}

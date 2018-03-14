using CoffeeMachine.core.SOLUTIONS.Coffee.Commande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLachineAPIs.Services
{
    public class CommandeServices : ICommandeServices
    {
        private CommandeDAO cmd = new CommandeDAO();
        public List<Commande> AfficherCommandes()
        {
            var result = cmd.GetListCommande();
            return result;
        }

        public void AjouterCommande(Commande insertObj)
        {
            cmd.Add(insertObj);
        }

        public void EffacerCommande(Commande commande)
        {
            cmd.DeleteCommand(commande);

        }

        public void MajCommande(Commande updateObj)
        {
            cmd.Update(updateObj);
        }

        public Commande TrouverCommandeparID(int id)
        {
            var result = cmd.Find(id);
            return result;

        }

        public List<Commande> TrouverCommandeparUser(string id)
        {
            var result = cmd.getByUser(id);
            return result;
        }


    }
}

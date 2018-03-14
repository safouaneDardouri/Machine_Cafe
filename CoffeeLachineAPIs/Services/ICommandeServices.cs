using CoffeeMachine.core.SOLUTIONS.Coffee.Commande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLachineAPIs.Services
{
    public interface ICommandeServices
    {
        //  [OperationContract]
        //  [WebInvoke(Method = "PUT",
        // RequestFormat = WebMessageFormat.Json,
        // ResponseFormat = WebMessageFormat.Json,
        // UriTemplate = "/Commande/add")]
        //  bool Add(Commande cmd);


        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Commande/TrouverCommandeparID/")]
        Commande TrouverCommandeparID(int id);

        [OperationContract]
        [WebInvoke(Method = "PUT",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Commande/TrouverCommandeparUser")]
        List<Commande> TrouverCommandeparUser(string id);

        [OperationContract]
        [WebInvoke(Method = "PUT",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Commande/MajCommande")]
        void MajCommande(Commande updateObj);

        [OperationContract]
        [WebInvoke(Method = "PUT",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Commande/AjouterCommande")]
        void AjouterCommande(Commande insertObj);

        [OperationContract]
        [WebInvoke(Method = "PUT",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "/Commande/AfficherCommandes")]
        List<Commande> AfficherCommandes();


        [OperationContract]
        [WebInvoke(Method = "PUT",
       RequestFormat = WebMessageFormat.Json,
       ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "/Commande/EffacerCommande")]
        void EffacerCommande(Commande cmd);
    }
}

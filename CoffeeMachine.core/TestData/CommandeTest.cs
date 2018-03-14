using CoffeeMachine.core.SOLUTIONS.Coffee.Commande;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoffeeMachine.core.TestData
{
    public class CommandeTest
    {
        public Commande GetDummyData() {
            Commande Data = new Commande();
            Data.id =100;
            Data.mug = "t";
            Data.qtsucre = 2;
            Data.type = "chocolat";
            Data.userId = "30f36614-5f38-437f-b34f-fe8d11a7aba1";
            return Data;
        }
    }
}
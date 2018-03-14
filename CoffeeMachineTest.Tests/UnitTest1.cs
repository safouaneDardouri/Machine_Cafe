using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CoffeeLachineAPIs.Services;
using CoffeeMachine.core.TestData;
using CoffeeMachine.core.SOLUTIONS.Coffee.Commande;

namespace CoffeeMachineTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// UnitTest1
        /// <para>
        /// ADD/EDIT/DELETE test
        /// </para>
        /// </summary>
         ////////////////////////////////////////////////////////////////////////////////
        #region Member Variables

        CommandeServices CS;

        #endregion
        ////////////////////////////////////////////////////////////////////////////////

        ////////////////////////////////////////////////////////////////////////////////
        #region Members
        [TestInitialize]
        public void Init()
        {
            CS = new CommandeServices();
        }

        #endregion
        ////////////////////////////////////////////////////////////////////////////////
        [TestMethod]
        [TestCategory("AjouterCommandeTest")]

        public void AjouterCommandeTestInput()
        {
             
            try
            {
                //Arrange            
                CommandeTest CMD = new CommandeTest();
                Commande input1 = CMD.GetDummyData();
                input1.id++;
                //Act
                CS.AjouterCommande(input1);

                //Assert
                Assert.IsNotNull(CS.TrouverCommandeparUser(input1.userId));

                //DataReset
                CS.EffacerCommande(input1);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        [TestCategory("EffacerCommandeTest")]
        public void EffacerCommandeTestInput()
        {

            try
            {
                //Arrange            
                List<Commande> input1 = CS.AfficherCommandes();
                //brings by default the last record so that we can test the delete method on it
                Commande input2 = input1[input1.Count - 1];
                //Act
                CS.EffacerCommande(input2);

                //Assert
                Assert.IsNull(CS.TrouverCommandeparID(input2.id));

                //DataReset
                CS.AjouterCommande(input2);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [TestMethod]
        [TestCategory("DeleteTest")]
        public void MajCommandeTestInput()
        {

            try
            {
                //Arrange            
                List<Commande> input1 = CS.AfficherCommandes();
                //brings by default the last record so that we can test the update method on it
                Commande input2 = input1[input1.Count - 1];
                Commande OriginalObject = input2;
                //Act
                input2.qtsucre++;
                input2.mug = "f";
                CS.MajCommande(input2);

                //Assert
                Assert.AreNotEqual(OriginalObject, CS.TrouverCommandeparID(input2.id));

                //DataReset
                input2.qtsucre--;
                input2.mug = "t";
                CS.MajCommande(input2);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

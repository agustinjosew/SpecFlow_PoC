using SpecFlow_PoC.Class;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject_PoC.Specs.StepDefinitions
{
    [Binding]
    public class InventoryStepDefinitions
    {
        //Llamada al metodo de Inventario
        Inventory _inventory = new Inventory();
        private int _result;

        [Given(@"There are (.*) items in the inventory")]
        public void GivenThereAreItemInTheInventory(int p0)
        {
            _inventory.Set(p0);
        }

        [When(@"I get all the inventory")]
        public void WhenIGetAllTheInventory()
        {
            _result = _inventory.GetQuantity();
        }

        [Then(@"I should get (.*) items")]
        public void ThenIShouldGetItems(int p0)
        {
            _result.Should().Be(p0);
        }

        // Seccion de ADD ITEM
        [When(@"I add (.*) item to inventory")]
        public void WhenIAddItemToInventory(int p0)
        {
            _result = _inventory.Add(p0);
        }

        // Seccion de REMOVE ITEM
        [When(@"I remove (.*) item from inventory")]
        public void WhenIRemoveItemFromInventory(int p0)
        {
            _result = _inventory.Remove(p0);    
        }

    }
}

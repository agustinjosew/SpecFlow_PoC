using System;
using TechTalk.SpecFlow;

namespace SpecFlowProject_PoC.Specs.StepDefinitions
{
    [Binding]
    public class InventoryStepDefinitions
    {
        [Given(@"There are (.*) item in the inventory")]
        public void GivenThereAreItemInTheInventory(int p0)
        {
            throw new PendingStepException();
        }

        [When(@"I get all the inventory")]
        public void WhenIGetAllTheInventory()
        {
            throw new PendingStepException();
        }

        [Then(@"I should get (.*) items")]
        public void ThenIShouldGetItems(int p0)
        {
            throw new PendingStepException();
        }
    }
}

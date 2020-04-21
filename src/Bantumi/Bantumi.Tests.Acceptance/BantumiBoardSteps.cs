using System;
using TechTalk.SpecFlow;

namespace Bantumi.Tests.Acceptance
{
    [Binding]
    public class BantumiBoardSteps
    {
        [Given(@"a player named (.*)")]
        public void GivenAPlayerNamed(string namePlayer)
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"(.*) plays (.*)")]
        public void GivenFirstPlayerPlaysScondPlayer(string firstPlayer, string secondPlayer)
        {
            ScenarioContext.Current.Pending();
        }

                [Given(@"an initial bantumi board")]
        public void GivenAnInitialBantumiBoard()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"Michel plays field (.*)")]
        public void WhenMichelPlaysField(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the board should be")]
        public void ThenTheBoardShouldBe(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"score Michel-Geale should be (.*)")]
        public void ThenScoreMichel_GealeShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it is Geale's turn")]
        public void ThenItIsGealeSTurn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it is Michel's turn")]
        public void ThenItIsMichelSTurn()
        {
            ScenarioContext.Current.Pending();
        }

    }
}

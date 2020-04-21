using System;
using System.Globalization;
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
        
        [When(@"(.*) plays field (.*)")]
        public void WhenPlayerPlaysField(string playerName, string field)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the board should be")]
        public void ThenTheBoardShouldBe(Table table)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"score (.*)-(.*) should be (.*)-(.*)")]
        public void ThenScoreMichel_GealeShouldBe(string firstPlayer, string secondPlayer, int scoreFirstPlayer, int scoreSecondPlayer)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"it is (.*)'s turn")]
        public void ThenItIsPlayersTurn(string playerName)
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

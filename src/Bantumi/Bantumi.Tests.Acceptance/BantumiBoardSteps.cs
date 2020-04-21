using System;
using System.Globalization;
using TechTalk.SpecFlow;

namespace Bantumi.Tests.Acceptance
{
    [Binding]
    public class BantumiBoardSteps
    {
        private readonly ScenarioContext _scenarioContext;

        public BantumiBoardSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given(@"a player named (.*)")]
        public void GivenAPlayerNamed(string namePlayer)
        {
            _scenarioContext.Pending();
        }

        [Given(@"(.*) plays (.*)")]
        public void GivenFirstPlayerPlaysScondPlayer(string firstPlayer, string secondPlayer)
        {
            _scenarioContext.Pending();
        }

        [Given(@"an initial bantumi board")]
        public void GivenAnInitialBantumiBoard()
        {
            _scenarioContext.Pending();
        }

        [When(@"(.*) plays field (.*)")]
        public void WhenPlayerPlaysField(string playerName, string field)
        {
            _scenarioContext.Pending();
        }

        [Then(@"the board should be")]
        public void ThenTheBoardShouldBe(Table table)
        {
            _scenarioContext.Pending();
        }

        [Then(@"score (.*)-(.*) should be (.*)-(.*)")]
        public void ThenScoreMichel_GealeShouldBe(string firstPlayer, string secondPlayer, int scoreFirstPlayer, int scoreSecondPlayer)
        {
            _scenarioContext.Pending();
        }

        [Then(@"it is (.*)'s turn")]
        public void ThenItIsPlayersTurn(string playerName)
        {
            _scenarioContext.Pending();
        }

        [Then(@"it is Michel's turn")]
        public void ThenItIsMichelSTurn()
        {
            _scenarioContext.Pending();
        }
    }
}
using System;
using TechTalk.SpecFlow;

namespace CucumberTests
{
    [Binding]
    public class PawnMovementSteps
    {
        [Then(@"the white pawn is placed in a(.*)\.")]
        public void ThenTheWhitePawnIsPlacedInA_(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}

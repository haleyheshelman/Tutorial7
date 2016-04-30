using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;

namespace CucumberTests
{
    [Binding]
    public class PawnCaptureSteps
    {
        [Given(@"that I have an empty chessboard")]
        public void GivenThatIHaveAnEmptyChessboard()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I have a white pawn at d(.*)")]
        public void GivenIHaveAWhitePawnAtD(int p0)
        {
            ScenarioContext.Current.Pending();
        }

        PawnMovementSteps moveSteps;
        public PawnCaptureSteps(PawnMovementSteps p)
        {
            moveSteps = p;
        }

        Pawn blackPawn = null;
        private object board;

        [Given(@"I have a black pawn at (.)(.)")]
        public void GivenIHaveABlackPawnAt(char x, int y)
        {
            blackPawn = new Pawn("black");
            board.placePiece(blackPawn, new Tuple<char, int>(x, y));
        }

        [When(@"I try to move the white pawn from d(.*) to e(.*)")]
        public void WhenITryToMoveTheWhitePawnFromDToE(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"the black pawn is captured")]
        public void ThenTheBlackPawnIsCaptured()
        {
            Assert.IsTrue(blackPawn.isCaptured());
        }
    }
}

using Assignment;

namespace AssignmentTest
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void OpenLockedTest()
        {
            // Chest starts in the locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            // Try to open the chest
            // Verify chest is still locked
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }
        [TestMethod]
        public void OpenClosedTest()
        {
            // Create a new chest that is in the closed state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Closed);
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }
        [TestMethod]
        public void OpenOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Open();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Open);
        }
        [TestMethod]
        public void LockedLockedTest()
        {
            // Create a new chest that is in the Locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Locked();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }
        [TestMethod]
        public void CloseLockedTest()
        {
            // Create a new chest that is in the Locked state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Locked);
            chest.Closed();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Closed);
        }
        [TestMethod]
        public void LockectOpenTest()
        {
            // Create a new chest that is in the open state
            TreasureChest chest = new TreasureChest(TreasureChest.State.Open);
            chest.Locked();
            Assert.AreEqual(chest.GetState(), TreasureChest.State.Locked);
        }
    }
}

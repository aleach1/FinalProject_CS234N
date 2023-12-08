using Microsoft.EntityFrameworkCore;

namespace UnitTests
{
    public class Tests
    {
        public BITSContext dbContext;
        List<Recipe> recipes;
        Recipe? r;

        [SetUp]
        public void Setup()
        {
            dbContext = new BITSContext();
        }

        [Test]
        public void GetRecipesForSearch()
        {
            recipes = dbContext.Recipes.Where(r => r.Name.Contains("cas")).OrderBy(r => r.Name).ToList();
            Assert.AreEqual(1, recipes.Count());
            Assert.AreEqual(recipes[0].RecipeId, 3);

        }

        [Test]
        public void GetRecipeFromSearch()
        {
            r = dbContext.Recipes.Find(2);
            Assert.IsNotNull(r);
            Assert.AreEqual(r.StyleId, 70);
        }
    }
}
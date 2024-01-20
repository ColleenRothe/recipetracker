using IO.Swagger.Models;

namespace recipetracker.Services
{
    /// <summary>
    /// Service for performing recipe related services
    /// </summary>
    public interface IRecipeService
	{
		/// <summary>
		/// Create a new recipe
		/// </summary>
		/// <param name="recipe">the recipe to be created</param>
		public void CreateRecipe(Recipe recipe);

		/// <summary>
		/// Get a recipe based on its id
		/// </summary>
		/// <param name="id">id of the recipe to find</param>
		/// <returns>the matching recipe</returns>
		public Recipe GetRecipeById(int id);

		/// <summary>
		/// Update an existing recipe
		/// </summary>
		/// <param name="recipe">recipe with updated fields</param>
		/// <returns>Updated recipe</returns>
		public Recipe UpdateRecipe(Recipe recipe);

		/// <summary>
		/// Delete a recipe based on its id
		/// </summary>
		/// <param name="id">id of the recipe to delete</param>
		public void DeleteRecipeById(int id);
	}
}


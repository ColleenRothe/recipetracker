using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace IO.Swagger.Model
{

    /// <summary>
    /// A recipe
    /// </summary>
    [DataContract]
    public class Recipe
    {
        /// <summary>
        /// reference id of the recipe
        /// </summary>
        /// <value>reference id of the recipe</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the Recipe.
        /// </summary>
        /// <value>The name of the Recipe.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// When the recipe was created.
        /// </summary>
        /// <value>When the recipe was created.</value>
        [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "dateCreated")]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Where the recipe is from. A book, website etc.
        /// </summary>
        /// <value>Where the recipe is from. A book, website etc.</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Ingredients
        /// </summary>
        [DataMember(Name = "ingredients", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "ingredients")]
        public List<Ingredient> Ingredients { get; set; }

        /// <summary>
        /// Gets or Sets Labels
        /// </summary>
        [DataMember(Name = "labels", EmitDefaultValue = false)]
        [JsonProperty(PropertyName = "labels")]
        public List<Label> Labels { get; set; }


        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Recipe {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Ingredients: ").Append(Ingredients).Append("\n");
            sb.Append("  Labels: ").Append(Labels).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Get the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

    }
}

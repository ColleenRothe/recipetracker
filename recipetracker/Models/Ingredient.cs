﻿/*
 * Recipe Tracker - OpenAPI 3.0
 *
 * This is a simple API for keeping track of recipes and their ingredients. 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Models
{
    /// <summary>
    /// A part of a recipe.
    /// </summary>
    [DataContract]
    public partial class Ingredient : IEquatable<Ingredient>
    {
        /// <summary>
        /// Name of the ingredient.
        /// </summary>
        /// <value>Name of the ingredient.</value>

        [DataMember(Name = "name")]
        public string? Name { get; set; }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public enum AmountEnum
        {
            /// <summary>
            /// Enum TodoEnum for todo
            /// </summary>
            [EnumMember(Value = "todo")]
            TodoEnum = 0
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>

        [DataMember(Name = "amount")]
        public AmountEnum? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ingredient {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == GetType() && Equals((Ingredient)obj);
        }

        /// <summary>
        /// Returns true if Ingredient instances are equal
        /// </summary>
        /// <param name="other">Instance of Ingredient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ingredient other)
        {
            if (ReferenceEquals(null, other)) return false;
            if (ReferenceEquals(this, other)) return true;

            return
                (
                    Name == other.Name ||
                    Name != null &&
                    Name.Equals(other.Name)
                ) &&
                (
                    Amount == other.Amount ||
                    Amount != null &&
                    Amount.Equals(other.Amount)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                // Suitable nullity checks etc, of course :)
                if (Name != null)
                    hashCode = hashCode * 59 + Name.GetHashCode();
                if (Amount != null)
                    hashCode = hashCode * 59 + Amount.GetHashCode();
                return hashCode;
            }
        }

        #region Operators
#pragma warning disable 1591

        public static bool operator ==(Ingredient left, Ingredient right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Ingredient left, Ingredient right)
        {
            return !Equals(left, right);
        }

#pragma warning restore 1591
        #endregion Operators
    }
}

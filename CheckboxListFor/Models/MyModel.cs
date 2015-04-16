using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CheckboxListFor.Extensions;

namespace CheckboxListFor.Models
{
	public enum MyType
	{
		CSharp,
		VB,
		Java,
        Ruby,
        CPlus
	}
	
	
	public class MyModel
	{
		      
        [Required(ErrorMessage="Please provide your name.")]
        public string Name { get; set; }

        [RequiredCheckbox(2)]
		public IList<MyType> SelectedLanguages { get; set; }
		public Dictionary<MyType, string> LanguageOptions { get; set; }

	}
}
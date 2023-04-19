using System;
using Properties_Price_Jacob;

namespace Properties_Price_Jacob
{
	class Car
	{// initializes a private string variable to assign propperties
		private string model;
		
		// Assgins properties to athe Model String
		public string Model
		{
			get { return model; }
			set { model = value; }
		}
		// Initializes and sets properties for a new string Make
		public string Make
		{
			get; set;
		}
	}
}

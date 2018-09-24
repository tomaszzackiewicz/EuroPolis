public class Poland {
	
	string capital = "Warsaw";
	float population = 38;
	CountryData countryData;
	
	public Poland(){
		
	}
	
	Poland(string capital, float population){
		countryData.capital = capital;
		countryData.population = population;
	}

	public string GetCapital(){
		return capital;
	}
	
	public float GetPopulation(){
		return population;
	}
}

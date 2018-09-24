public class Romania{
	string capital = "Bucharest";
	float population = 20;
	CountryData countryData;
	
	public Romania(){
		
	}
	
	Romania(string capital, float population){
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

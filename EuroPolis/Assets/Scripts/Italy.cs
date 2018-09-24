public class Italy{
	string capital = "Rome";
	float population = 60;
	CountryData countryData;
	
	public Italy(){
		
	}
	
	Italy(string capital, float population){
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

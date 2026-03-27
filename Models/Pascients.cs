namespace Models.Pascients;

public class Pascients
{
    public string Name  { get; set; }
    public int Year { get; set; }
    public string Code { get; set; }
    public string Symptoms { get; set; }
    // Constructor to do the list
    public Pascients(string name, int year, string symptoms, string code) {
        this.Name = name;
        this.Year = year;
        this.Code = code;
        this.Symptoms = symptoms;
    }
    
}

// Methods that needed it into of the class axuliary
/*RegisterPascient()
 *ListPascient
 * SearchPascient
 */
public class PascientService
{
    
    public void registerPascient(string name, int year, string symptoms, string code, List<Pascients> pascientsList)
    {
        Pascients newPascient = new Pascients(name, year, symptoms, code);
        pascientsList.Add(newPascient);
    }

    public void listPascient(List<Pascients> pascientsList)
    {
        foreach (Pascients pascient in pascientsList){
            Console.WriteLine($"Nombre: {pascient.Name}, Edad: {pascient.Year}, Sintomas: {pascient.Symptoms}");
        }
    }

    public void searchPascient(string code, List<Pascients> pascientsList)
    {
        // Get the pascient that has name that the users writte
        var result = from p in pascientsList
            where p.Code == code
            select p;
        if (result.LongCount()>0)
        {
            Console.WriteLine("");
            Console.WriteLine("El pasciente al que busca tiene los siguientes valores: ");
            Console.WriteLine($"Nombre: {result.First().Name} con la edad: {result.First().Year} Y los sintomas son:  {result.First().Symptoms}");
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("Este documento no existe");
        }
        
    }
}


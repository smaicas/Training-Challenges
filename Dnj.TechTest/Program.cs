// Dado un array de enteros devolver el número que se repite mas veces

int[] array = new int[] { 1, 5, 5, 2, 6, 6, 6, 4, 4 };
Console.WriteLine(WithDictionary(array));
Console.WriteLine(WithoutDictionary(array));

static int WithDictionary(int[] arr)
{
    IDictionary<int, int> dict = new Dictionary<int, int>();
    foreach (int i in arr)
    {
        if (dict.ContainsKey(i))
        {
            dict[i]++;
        }
        else
        {
            dict.Add(i, 0);
        }
    }
    return dict.First(x => x.Value == dict.Max(y => y.Value)).Key;
}

static int WithoutDictionary(int[] arr)
{
    int[] sum = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        for (int j = 0; j < arr.Length - 1; j++)
        {
            if (arr[j] == arr[i])
            {
                sum[i]++;
            }
        }
    }
    return arr[sum.ToList().IndexOf(sum.Max())];
}

// Encuentra la máxima diferencia entre dos elementos de un array de enteros. 
int Resolve1(int[] arr)
{
    return arr.ToList().Max() - arr.ToList().Min();
}

/// Crear una función que acepte como parámetro una lista de objetos “Station” llamada updateStations().
/// Esta función recogerá la lista y guardará aquellas que no existan, y actualizará aquellas que ya estuvieran guardadas.
/// La Station tiene un identificativo único de MacAddress, y un atributo llamado SSID.

public class Exercise
{
    public List<Station> FinalStations { get; set; } = new List<Station>();

    public void UpdateStations(List<Station> stations)
    {
        List<int> knownMacs = new();
        foreach (Station fstation in FinalStations)
        {
            if (stations.ToList().Find(x => x.MacAddress == fstation.MacAddress) != null)
            {
                knownMacs.Add(fstation.MacAddress);
            }
        }

        FinalStations.RemoveAll(x => knownMacs.Contains(x.MacAddress));
        FinalStations.AddRange(stations);
    }

    public class Station
    {
        public string SSID { get; set; }
        public int MacAddress { get; set; }
    }
}

// Obtener el numero de islas
public class Islands
{
    int[][] map = new int[][] {
        new []  { 1, 0, 1, 0, 0, 0, 1, 1, 1, 1 },
        new []  { 0, 0, 1, 0, 1, 0, 1, 0, 0, 0 },
        new []  { 1, 1, 1, 1, 0, 0, 1, 0, 0, 0 },
        new []  { 1, 0, 0, 1, 0, 1, 0, 0, 0, 0 },
        new []  { 1, 1, 1, 1, 0, 0, 0, 1, 1, 1 },
        new []  { 0, 1, 0, 1, 0, 0, 1, 1, 1, 1 },
        new []  { 0, 0, 0, 0, 0, 1, 1, 1, 0, 0 },
        new []  { 0, 0, 0, 1, 0, 0, 1, 1, 1, 0 },
        new []  { 1, 0, 1, 0, 1, 0, 0, 1, 0, 0 },
        new []  { 1, 1, 1, 1, 0, 0, 0, 1, 1, 1 }
    };
}

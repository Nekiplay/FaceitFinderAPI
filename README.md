# FaceitFinderAPI

**Initalization**
```C#
FaceitFinderAPI.FaceitFinder faceit = new FaceitFinderAPI.FaceitFinder();
```

**Get Trust Factor and Faceit link**
```C#
var faceitresponce = faceit.GetResponce("Steam ID");
Console.WriteLine("Faceit link: " + faceitresponce.Faceit);
Console.WriteLine("Trust Factor: " + faceitresponce.Trust + "% from " + (100 - faceitresponce.Trust) + "%");
```
# Notes

## Verschil tussen Java Streams en LINQ

- LINQ maakt gebruikt van extension methods en de syntax is daardoor meestal een stuk korter/eleganter
- C# kent echt delegates, Java niet (lambdas worden vertaald naar anonieme classes in Java)
- toepassingen van LINQ, met name EF Core
- verschillende soorten lists terugkrijge:n https://stackoverflow.com/questions/65969919/differences-of-java-16s-stream-tolist-and-stream-collectcollectors-tolist
- interessant: https://www.iodigital.com/en/history/foreach/java-and-net-comparing-streams-linq

  soms wat kort door de bocht:

  ```cs
  // the .NET example
  var subset2 = dataset.AsParallel().ToList();
  ```
  ```java
  // the Java example
  // import static ... toList;
  var subset2 = dataset.stream().collect(toList());
  ```
  maar dat `.OfType<>()` voorbeeld is wel een goed punt

Toepassingen LINQ:
- LINQ to SQL
- Entity Framework / Entity Framework Core  n:m
  - let op met custom methoden die niet naar SQL vertaalt kunnen worden:
    ```cs
    context.Products.Where(x => MijnCustomFunctie(x)).ToListAsync()
    ```
- Parallel LINQ
- LINQ to SharePoint 🤢
- LINQ to XML
- LINQ to objects


## Gekke dingen binnen LINQ

- deferred execution, even van bewust zijn als je variabelen in een `.Where()` gebruikt. Ook als je `.Select()` en dergelijke doet, bij exceptions kan het lijken alsof er bij een andere operatie de exception triggert terwijl dat dan gewoon de plek is waar je voor het eerst door de lijst heengaat
- te diepe nestings met `.Select()` - principes van never nesting kunnen ook toegepast worden op nested selects
  - nested selects zijn ook vervelend te debuggen

```cs
return TypedResults.Ok(mijnData.Select(m => new BlaDto
{
	Ding = d.Ding.Select(d => new DingDto
	{
    Bla = d.Bla.Select(b => new BlaDto
    {
      Iets = b.Iets
    })
	})
});
```

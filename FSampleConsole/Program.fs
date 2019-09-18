open FSharp.Data

[<Literal>]
let url  = @"https://en.wikipedia.org/wiki/Megacity"

type Megacities = HtmlProvider<url>

let explore() =
    let data= Megacities.GetSample()
    let cityTables= data.Tables 

    cityTables.``Largest cities``.Rows
    |> Array.take 5
    |> Array.map (fun row -> row.Continent, row.Population, row.Megacity)
    |> Array.iter (fun (continent,pop,city)-> printf "City: %s Continent: %s Population %s" city continent pop)

[<EntryPoint>]

let main argv =
    explore()
    0 // return an integer exit code

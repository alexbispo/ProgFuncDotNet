namespace ProgFuncDotNet

module HighOrderFunctions =

  let apply func lista  =
    lista
    |> List.iter func

  let printNames names =
    names
    |> apply (printfn "Hello %s")
    

  let printSquareOfNumbers numbers = 
    numbers
    |> apply (fun n -> printfn "%i." (n * 2))

  let multiplyAndPrintNumbers numbers multiplicator = 
    numbers
    |> apply (fun n -> printfn "%i." (n * multiplicator))

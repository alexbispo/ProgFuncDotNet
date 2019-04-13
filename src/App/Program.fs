namespace ProgFuncDotNet

module App =
  open System

  [<EntryPoint>]
  let main argv =
    HighOrderFunctions.printNames ["Euclides"; "Sanches"; "Paulo"]

    HighOrderFunctions.printSquareOfNumbers [1..10]

    HighOrderFunctions.multiplyAndPrintNumbers [1..10] 3

    let multiplyListFor = HighOrderFunctions.multiplyAndPrintNumbers [1..10]

    multiplyListFor 4

    multiplyListFor 5

    printfn "%i" (HighOrderFunctions.sumWith5 3)

    let sumWith2 = HighOrderFunctions.sum 2

    printfn "%i" (sumWith2 4)

    let bmi = HighOrderFunctions.bmi

    printfn "IMC = %f" (bmi 163 80)

    Console.ReadKey() |> ignore

    0 // return an integer exit code
  
  

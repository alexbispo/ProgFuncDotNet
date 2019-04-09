namespace ProgFuncDotNet

module App =

  [<EntryPoint>]
  let main argv =
    HighOrderFunctions.printNames ["Euclides"; "Sanches"; "Paulo"]

    HighOrderFunctions.printSquareOfNumbers [1..10]

    HighOrderFunctions.multiplyAndPrintNumbers [1..10] 3

    let multiplyListFor = HighOrderFunctions.multiplyAndPrintNumbers [1..10]

    multiplyListFor 4

    multiplyListFor 5
    0 // return an integer exit code
  
  

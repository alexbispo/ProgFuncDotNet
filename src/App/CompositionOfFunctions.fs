namespace ProgFuncDotNet

module CompositionOfFunctions =
    
    let numberIsOdd number =
        number % 0 = 0

    let compound func1 func2 param =
        func2 (func1 (param) )
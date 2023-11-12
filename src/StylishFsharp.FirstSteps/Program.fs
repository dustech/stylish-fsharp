open System

module MyFirstFunctions =
    let numbers = [1..10]
    // let toPigLatin (word: string) =
    //     let isVowel (c: char) =
    //         match c with
    //         | 'a' | 'e' | 'i' |'o' |'u'
    //         | 'A' | 'E' | 'I' | 'O' | 'U' -> true
    //         |_ -> false
        
    //     if isVowel word[0] then
    //         word + "yay"
    //     else
    //         word[1..] + string word[0] + "ay"

    let addOne = (+) 1

    let timesFour = (*) 4

    let square x = x * x
    let isEven x = x % 2 = 0

    let squareTimesFourEvenPlusOnePipeline values = 
        values |>
        List.filter isEven |>
        List.map square |>
        List.map timesFour |>
        List.map addOne

    let squareTimesFourEvenPlusOneComposition =
        List.filter isEven >> List.map (square >> timesFour >> addOne)



[<EntryPoint>]
let main args =
    printfn $"processing {MyFirstFunctions.numbers} through 
        'MyFirstFunctions.squareTimesFourEvenPlusOnePipeline' produces: 
        {MyFirstFunctions.squareTimesFourEvenPlusOnePipeline MyFirstFunctions.numbers}"
    printfn $"processing {MyFirstFunctions.numbers} through 
        'MyFirstFunctions.squareTimesFourEvenPlusOneComposition' produces: 
        {MyFirstFunctions.squareTimesFourEvenPlusOneComposition MyFirstFunctions.numbers}"  
    0

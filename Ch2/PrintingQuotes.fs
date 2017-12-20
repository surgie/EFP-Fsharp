module PrintingQuotes

open System

let printingQuote() =
    printf "What is the quote? "
    let quote = Console.ReadLine()
    printf "Who said it? "
    let person = Console.ReadLine()
    printfn "%s" (person + " says, \"" + quote + "\"")
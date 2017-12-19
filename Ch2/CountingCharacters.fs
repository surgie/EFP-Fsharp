module CountingCharacters

open System

let countingNumberOfCharacters() =
    printf "What is the input string? "
    let string = Console.ReadLine()
    printfn "%s has %d characters." string string.Length

let countingNumberOfCharacters'() =
    printf "What is the input string? "
    let string = Console.ReadLine()
    let output = 
        match string.Length with
            | 0 -> "You must enter at least 1 character."
            | _ -> sprintf "%s has %d characters." string string.Length
    printfn "%s" output
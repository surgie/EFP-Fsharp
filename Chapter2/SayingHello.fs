module SayingHello

open System

let sayingHello() =
    printf "What is your name? "
    let name = Console.ReadLine()
    printfn "Hello, %s, nice to meet you!" name

let sayingHello'() =
    printf "What is your name? "
    printfn "Hello, %s, nice to meet you!" <| Console.ReadLine()

let sayingHello''() = 
    printf "What is your name? "
    let name = Console.ReadLine()

    let greeting =
        match name with
            | "Travis" -> "Hey there, self!"
            | "Surgie" -> "Hey there, alter ego!"
            | _ -> sprintf "Hello, %s, nice to meet you!" name

    printfn "%s" greeting

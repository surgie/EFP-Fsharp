module SimpleMath

open System

let validation num =
    match num with
    | num when num < 0 -> false
    | _ -> true

let simple() =
    printf "What is the first number? "
    let first = Console.ReadLine()

    printf "What is the second number? "
    let second = Console.ReadLine()

    let x = first |> int
    let y = second |> int

    printfn "%i + %i = %i\n%i - %i = %i\n%i * %i = %i\n%i / %i = %i" x y (x + y) x y (x - y) x y (x * y) x y (x / y)


let challengeOne() =
    printf "What is the first number? "
    let first = Console.ReadLine()

    printf "What is the second number? "
    let second = Console.ReadLine()

    let x =
        try
            first |> int
        with
            | ex -> printfn "Can't continue, %s is not a number." first; -1

    let y =
        try
            second |> int
        with
            | ex -> printfn "Can't continue, %s is not a number." second; -1

    let isValid = validation x && validation y
    match isValid with
        | true -> printfn "%i + %i = %i\n%i - %i = %i\n%i * %i = %i\n%i / %i = %i" x y (x + y) x y (x - y) x y (x * y) x y (x / y)
        | false -> printfn "Numbers are invalid. They must be numeric and greater than 0."

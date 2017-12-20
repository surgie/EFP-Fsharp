module MadLib

open System

let simple() =
    printf "Enter a noun: "
    let noun = Console.ReadLine()

    printf "Enter a verb: "
    let verb = Console.ReadLine()

    printf "Enter an adjective: "
    let adjective = Console.ReadLine()

    printf "Enter an adverb: "
    let adverb = Console.ReadLine()

    printfn "Do you %s your %s %s %s? That's hilarious!" verb adjective noun adverb

let challengeOne() =
    printf "Enter an exclamation: "
    let exclamation = Console.ReadLine()

    printf "Enter an adverb: "
    let adverb = Console.ReadLine()

    printf "Enter a noun: "
    let noun = Console.ReadLine()

    printf "Enter an adjective: "
    let adjective = Console.ReadLine()

    printfn "%s! he said %s as he jumped into his convertible %s and drove off with his %s wife." exclamation adverb noun adjective
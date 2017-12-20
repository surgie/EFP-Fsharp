open System

(*

Challenges to revisit:
- Counting the number of characters #2 -> Update UI as user types length
- Printing Quotes -> Lists of Data

*)

let main() =
    SayingHello.sayingHello''()
    CountingCharacters.countingNumberOfCharacters'()
    PrintingQuotes.printingQuote()
    MadLib.simple()
    MadLib.challengeOne()

    printfn "Press any key to continue..."
    Console.ReadLine() |> ignore

main()
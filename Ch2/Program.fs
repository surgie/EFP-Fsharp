open System

(*

Challenges to revisit:
- Counting the number of characters #2 -> Update UI as user types length
- Printing Quotes -> Lists of Data
- Mad Lib -> Branching Story
- Simple Math -> Break program into functions (Ch5), Implemenet as Gui

*)

let main() =
    //SayingHello.sayingHello''()
    // CountingCharacters.countingNumberOfCharacters'()
    // PrintingQuotes.printingQuote()
    // MadLib.simple()
    // MadLib.challengeOne()
    SimpleMath.simple()
    SimpleMath.challengeOne()

    printfn "Press any key to continue..."
    Console.ReadLine() |> ignore

main()
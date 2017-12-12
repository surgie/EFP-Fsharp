open System

(*

Challenges to revisit:
- Counting the number of characters #2 -> Update UI as user types length

*)

let main() =
    SayingHello.sayingHello''()
    CountingCharacters.countingNumberOfCharacters'()

    printfn "Press any key to continue..."
    Console.ReadLine() |> ignore

main()
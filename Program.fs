open System
open System.Numerics

let filter(n:seq<int>):seq<int> =
    seq { for i in n do
            if i % 3 = 0 || i % 5 = 0 then
                yield i}

let sum(n:seq<int>):int =
    Seq.sum(n)

[<EntryPoint>]
let main argv = 
    printfn "For all natural numbers n less than 1,000, list all the multiples of 3 and 5"
    printfn "____________________________________________________________________________"
    printfn "Remember the definition per the 5th Peano: \r"
    printfn "For all n in N, if n is true then n + 1 is true."
    printfn "%A" (filter [1..9])
    printfn "The sum of the sequence of 1 to 9 is: %d" (filter [1..9] |> sum)
    printfn "%A" (filter [1..999])
    printfn "The sum of the sequence of 1 to 999 is: %d" (filter [1..999] |> sum)
   
    0 // return an integer exit code


// Learn more about F# at http://fsharp.org

open System


[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let s = Calculator.Simple.Add(2,3)
    printfn "%d" s
    
    0 // return an integer exit code

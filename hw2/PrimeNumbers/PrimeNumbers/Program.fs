module PrimeNumbersGenerator
let IsPrime number =
    match number with
        | _ when number <= 1 -> false
        | _ -> 
            let root = number |> float |> sqrt |> int
            seq{2 .. root}
            |> Seq.filter(fun divisor -> number % divisor = 0)
            |> Seq.length = 0
let PrimeGenerator() = Seq.initInfinite(fun n -> n) |> Seq.filter(IsPrime)
printfn "%A" (PrimeGenerator() |> Seq.take 15)
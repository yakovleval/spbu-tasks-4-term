module PrimeNumbers.Tests

open NUnit.Framework
open FsUnit
open PrimeNumbersGenerator

[<Test>]
let TestFirst15PrimeNumbersAreEqual () =
    let expected = seq {2;3;5;7;11;13;17;23;29;31;37;41;43;47;53}
    PrimeGenerator() |> Seq.take 15 |> should equal expected

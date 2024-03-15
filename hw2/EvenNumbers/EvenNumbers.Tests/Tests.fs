module EvenNumbers.Tests

open NUnit.Framework
open FsUnit
open FsCheck
open EvenNumbers

[<Test>]
let testCount() =
    let list = [1..10]
    byMap list |> should equal 5

[<Test>]
let testMapAndFilter() = Check.Quick (fun list -> byMap(list) = byFilter(list))

[<Test>]
let testMapAndFold() = Check.Quick (fun list -> byMap(list) = byFold(list))

[<Test>]
let testFilterAndFold() = Check.Quick (fun list -> byFilter(list) = byFold(list))


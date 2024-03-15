module MapForTree.Tests

open NUnit.Framework
open FsUnit
open MapForTree

let sourceCases () =
    [
        TestCaseData((Empty:Tree<int>), (Empty:Tree<int>))
        TestCaseData(Tree(5, Empty, Empty), Tree(25, Empty, Empty))
        TestCaseData(Tree(1, Tree(2, Empty, Empty), Tree(3, Empty, Empty)), Tree(1, Tree(4, Empty, Empty), Tree(9, Empty, Empty)))
    ]

[<TestCaseSource("sourceCases")>]
let Test1(src, expected) =
    treeMap (fun x -> x * x) src |> should equal expected

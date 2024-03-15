module ArithmeticTree.Tests

open NUnit.Framework
open FsUnit
open ArithmeticTree

let CorrectTreeSource() =
    [
        TestCaseData(Leaf 0, 0)
        TestCaseData(Tree (Addition, Leaf 5, Leaf 6), 11)
        TestCaseData(Tree (Addition, Leaf 0.5, Leaf 0.5), 1)
        TestCaseData(Tree (Subtraction, (Tree (Addition, Leaf 5, Leaf 6)), Tree (Division, Leaf 90, Leaf 3)), -19)
    ]

[<TestCaseSource("CorrectTreeSource")>]
let TestCorrectTree (tree, expectedResult) =
    tree |> Evaluate |> should equal expectedResult

[<Test>]
let TestDivisionByZero =
    let testTree = Tree (Subtraction, (Tree (Addition, Leaf 5, Leaf 6)), Tree (Division, Leaf 90, Leaf 0))
    (fun() -> testTree |> Evaluate) |> should throw typeof<System.DivideByZeroException>

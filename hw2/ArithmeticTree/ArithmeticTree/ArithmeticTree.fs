namespace ArithmeticTree

module ArithmeticTree =
    open System
    type Operation =
        | Addition
        | Subtraction
        | Multiplication
        | Division
    type Tree = 
        | Leaf of float
        | Tree of Operation * Tree * Tree
    let rec Evaluate tree =
        match tree with
            | Leaf number -> number
            | Tree (operation, leftTree, rightTree) ->
                let leftResult = Evaluate leftTree
                let rightResult = Evaluate rightTree
                match operation with
                    | Addition -> leftResult + rightResult
                    | Subtraction -> leftResult - rightResult
                    | Multiplication -> leftResult * rightResult
                    | Division ->
                        if rightResult < 0.001 then
                            raise (new DivideByZeroException())
                        else
                            leftResult / rightResult
            | _ -> raise (new ArgumentException())

namespace MapForTree

module MapForTree =
    type 'a Tree =
        | Tree of 'a * 'a Tree * 'a Tree
        | Empty

    let rec treeMap f tree =
        match tree with
            | Empty -> Empty
            | Tree(value, left, right) -> Tree(f value, treeMap f left, treeMap f right)

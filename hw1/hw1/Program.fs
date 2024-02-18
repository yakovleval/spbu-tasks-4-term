let find list number =
    let rec _find list number index = 
        if list = [] then
            None
        elif List.head list = number then
            Some(index)
        else 
            _find (List.tail list) number (index + 1)
    _find list number 0

let powersOfTwo n m = 
    let compoundFold state _ = state, state * 2
    let list, _ = List.mapFold compoundFold (pown 2 n) [n..n + m]
    list

let reverseList list = 
    let folder state t = t :: state
    List.fold folder [] list

let fibonacci n =
    let rec _fibonacci a b n =
        if n = 1 then 
            a
        elif n = 2 then
            b
        else
            _fibonacci b (a + b) (n - 1)
    _fibonacci 1 1 n

let factorial n =
    let rec _factorial acc n =
        if n = 1 then
            acc
        else
            _factorial (acc * n) (n - 1)
    _factorial 1 n

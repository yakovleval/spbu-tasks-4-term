namespace EvenNumbers

module EvenNumbers =
    let byMap = 
        List.map (fun x -> x % 2) >> List.filter (fun x -> x = 0) >> List.length

    let byFilter =
        List.filter (fun x -> x % 2 = 0) >> List.length

    let folder state x =
        if x % 2 = 0 then
            state + 1
        else
            state
    let byFold =
        List.fold folder 0

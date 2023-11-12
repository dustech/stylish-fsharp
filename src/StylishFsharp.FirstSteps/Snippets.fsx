let myCount = Seq.init 1001 (fun n -> n * 2)

let printMyCount () = 
  myCount |> Seq.iter (printfn "%d")


// printMyCount()

let rec sumList xs =
        match xs with
        | []    -> 0
        | y::ys -> y + sumList ys
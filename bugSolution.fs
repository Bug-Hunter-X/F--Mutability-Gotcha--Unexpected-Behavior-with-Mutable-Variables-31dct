let x = ref 10
let y = ref 20

let add () = !x + !y

let z = add()

printf "%d\n" z

x := 15
y := 25

printf "%d\n" (add())
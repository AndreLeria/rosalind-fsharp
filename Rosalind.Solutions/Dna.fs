namespace Rosalind.Solutions

module Dna =

  type Counts = { A: int; C: int; G: int; T: int; }

  let isChar c = (=) c

  let countChars c = String.filter (isChar c) >> String.length

  let solve dataset =
    { A = dataset |> countChars 'A'
    ; C = dataset |> countChars 'C'
    ; G = dataset |> countChars 'G'
    ; T = dataset |> countChars 'T'
    }

  let showCounts counts = 
    sprintf "%d %d %d %d" counts.A counts.C counts.G counts.T

  let solveToString = solve >> showCounts
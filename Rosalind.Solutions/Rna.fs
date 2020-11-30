namespace Rosalind.Solutions

module Rna =
  let solve = String.map (function
    | 'T' -> 'U'
    | other -> other
    )

  let solveToString = solve
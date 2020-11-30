module Tests
open Rosalind.Solutions

open Xunit

[<Fact>]
let ``Counting DNA Nucleotides`` () =
    Assert.Equal("20 12 17 21", Dna.solveToString "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC")

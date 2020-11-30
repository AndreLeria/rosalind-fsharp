module Tests
open Rosalind.Solutions

open Xunit

[<Fact>]
let ``Counting DNA Nucleotides`` () =
    Assert.Equal("20 12 17 21", Dna.solveToString "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC")

[<Fact>]
let ``Transcribing DNA into RNA`` () =
    Assert.Equal("GAUGGAACUUGACUACGUAAAUU", Rna.solveToString "GATGGAACTTGACTACGTAAATT")
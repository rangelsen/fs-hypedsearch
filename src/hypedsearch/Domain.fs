namespace HypedSearch.Domain

[<AutoOpen>]
module Domain =
    [<Measure>] type mz

    type Charge = SinglyCharged | DoublyCharged

    type AminoAcid = A | R | N | D | C | Q | E | G | H | I | L | K | M | F | P | O | S | U | T | W | Y | V | B | Z | X 

    type Protein = {
        Name: string
        AminoAcids: seq<AminoAcid>
    }

    type Peptide = seq<AminoAcid>

    type NormalizedFragment = {
        // low
        AdjustedWeight: double<mz>
        // high
        Charge: Charge
    }

    type PeptideFragment = {
        Weight: double<mz>
        Abundance: double
    }

    type Precursor = {
        Fragments: seq<PeptideFragment>
        Weight: double<mz>
        Charge: Charge
    }

    type MassSpectrum = {
        Id: string
        Precursor: Precursor
    }


namespace HypedSearch.Domain

[<AutoOpen>]
module Domain =
    type Charge = SinglyCharged | DoublyCharged

    type AminoAcid = A | R | N | D | C | Q | E | G | H | I | L | K | M | F | P | O | S | U | T | W | Y | V | B | Z | X 

    type Protein = {
        Name: string
        AminoAcids: seq<AminoAcid>
    }

    type Peptide = seq<AminoAcid>

    type NormalizedFragment = {
        // low
        AdjustedWeight: double
        // high
        Charge: Charge
    }

    type PeptideFragment = {
        Weight: double
        Abundance: double
    }

    type Precursor = {
        Fragments: seq<PeptideFragment>
        Weight: double
        Charge: Charge
    }

    type MassSpectrum = {
        Id: string
        Precursor: Precursor
    }

    type Alignment = {
        ObservedSpectrumId: string
        Score: int
    }


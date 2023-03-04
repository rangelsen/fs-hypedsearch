namespace HypedSearch.Domain

[<AutoOpen>]
module Domain =
    type AminoAcid = A | R | N | D | C | Q | E | G | H | I | L | K | M | F | P | O | S | U | T | W | Y | V | B | Z | X 

    type Peptide = seq<AminoAcid>

    // type Protein = seq<AminoAcid> ?

    type Charge = int

    type NormalizedFragment = {
        // low
        adjustedWeight: double
        // high
        charge: Charge
    }

    type Fragment = {
        weight: double
        abundance: double
    }

    type Precursor = {
        fragments: seq<Fragment>
        weight: double
        charge: Charge
    }

    type Spectrum = {
        id: string
        mz: seq<double>
        intensity: seq<double>
        precursor: Precursor
    }


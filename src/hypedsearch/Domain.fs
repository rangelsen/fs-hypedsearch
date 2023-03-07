namespace HypedSearch.Domain

[<AutoOpen>]
module Domain =
    type Charge = SinglyCharged | DoublyCharged

    [<Measure>] type Da
    type Mass = double<Da>

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
        Mass: Mass
        Abundance: double
    }

    type MassSpectrum = seq<PeptideFragment>

    type Precursor = {
        Mass: Mass
        Charge: Charge
    }

    type MassSpectrumRun = {
        Id: string
        Precursor: Precursor
        Fragments: MassSpectrum
    }

    type TheoreticalPeptideFragment = {
        Fragment: PeptideFragment
        Peptide: Peptide
    }

    type TheoreticalMassSpectrum = seq<TheoreticalPeptideFragment>

    type Alignment = {
        ObservedSpectrumId: string
        Score: int
    }


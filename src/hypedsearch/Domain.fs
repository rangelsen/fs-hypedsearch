namespace HypedSearch.Domain

module Domain =
    type Charge =
        | SinglyCharged of uint
        | DoublyCharged of uint

    [<Measure>] type Da
    type Mass = double<Da>

    type AminoAcid = A | R | N | D | C | Q | E | G | H | I | L | K | M | F | P | O | S | U | T | W | Y | V | B | Z | X 

    type ProteinId = uint

    type Precursor = {
        Mass: Mass
        Charge: Charge
    }

    type Peptide = seq<AminoAcid>

    type Index = uint

    type PeptideFragment = {
        Id: Index
        Mass: double
        Abundance: double
    }

    type NormalizedFragment = {
        Id: Index
        Mass: Mass
    }

    type MassSpectrum = seq<PeptideFragment>

    type MassSpectrumRun = {
        Id: string
        Precursor: Precursor
        Fragments: MassSpectrum
    }

    type TheoreticalPeptideFragment = {
        Peptide: Peptide
        Mass: Mass
        ParentProtein: ProteinId 
    }

    type PeptideScore = {
        FragmentId: Index
        Peptide: Peptide
        Score: int
    }

    type Alignment = seq<PeptideScore>

    type PeptideMassRepo = {
        LookupMass: Mass -> Mass -> seq<TheoreticalPeptideFragment> option
    }


namespace HypedSearch.Alignment

module Alignment =
    open HypedSearch.Domain

    let approxEqual x y epsilon = abs(x - y) < epsilon

    let isPeptideInFragment (
    let scorePeptide (observed:NormalizedFragment) (theoretical:TheoreticalPeptideFragment) : PeptideScore =
        let folder peptides score frag =
            let closestFrag = isPeptideInFragment frag spec

            match approxEqual frag.Mass closestFrag.Fragment.Mass tolerance with
            | true -> score + 1
            | false -> score

        Seq.fold (theoretical |> folder) 0 observed

    let align (observed:MassSpectrum) (theoretical:PeptideMassRepo) (tol:Mass) : Alignment option = 
        let peptideCandidates = theoretical.LookupMass observed.Mass tol
        Seq.map (scorePeptide observed) peptideCandidates


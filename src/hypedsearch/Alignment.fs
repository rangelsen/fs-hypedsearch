namespace HypedSearch.Alignment

module Alignment =
    open HypedSearch.Domain

    let approxEqual x y epsilon = abs(x - y) < epsilon

    let findBestCandidate (fragment:PeptideFragment) (theoretical:TheoreticalMassSpectrum) : TheoreticalPeptideFragment =
        failwith "Not implemented"

    let scoreMassSpectrum (observed:MassSpectrum) (theoretical:TheoreticalMassSpectrum) (tolerance:Mass) : int =
        let folder spec score frag =
            let closestFrag = findBestCandidate frag spec

            match approxEqual frag.Mass closestFrag.Fragment.Mass tolerance with
            | true -> score + 1
            | false -> score

        Seq.fold (theoretical |> folder) 0 observed

    let align (observed:MassSpectrumRun) (theoretical:TheoreticalMassSpectrum) (tolerance:Mass) : Alignment =
        let score = scoreMassSpectrum observed.Fragments theoretical tolerance
        { ObservedSpectrumId = observed.Id; Score = score }
